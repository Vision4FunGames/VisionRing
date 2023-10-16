#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Landscaper
{
	public delegate void ParameterlessDelegate();

	/// <summary>
	/// Fills a set area with foliage
	/// </summary>
	[AddComponentMenu("Landscaper/Foliage Area")]
	public sealed class FoliageArea : MonoBehaviour
	{
		/// <summary>
		/// The random seed to use; allows us to re-generate the same foliage repeatedly
		/// </summary>
		public int Seed;

		/// <summary>
		/// The number of foliage generations to simulate, each generation is created using seeds from the
		/// previous generation. Increasing the GenerationsCount will exponentially increase the number of foliage objects placed.
		/// </summary>
		public int GenerationsCount = 5;

		/// <summary>
		/// The root object in which all GameObject foliage instances are placed
		/// </summary>
		public GameObject Root;

		/// <summary>
		/// The unscaled boundaries to place foliage in
		/// </summary>
		public readonly Bounds Bounds = new Bounds(Vector3.zero, Vector3.one);

		/// <summary>
		/// The scaled and translated boundaries to place foliage in
		/// </summary>
		public Bounds ScaledBounds { get { return new Bounds(Bounds.center + transform.position, Vector3.Scale(Bounds.size, transform.localScale)); } }

		/// <summary>
		/// The maximum size of a FoliageVolume. If the area is larger than this, it will be split into multiple smaller volumes
		/// </summary>
		public float MaxTileSize = 500;

		/// <summary>
		/// Easily allows for scaling the number of trees that are spawned without having to change the "Initial Seed Density" in each species
		/// </summary>
		public float DensityScale = 1.0f;

		/// <summary>
		/// Defines the method used to handle the Unity cap of 65,535 terrain trees per terrain before LODs stop working properly
		/// See the enum for more information on each mode
		/// </summary>
		public TerrainTreeLimitMode LimitMode = TerrainTreeLimitMode.Limit;

		/// <summary>
		/// The layer to add generated foliage to
		/// </summary>
		public int Layer;

		/// <summary>
		/// Only objects on these layers can have foliage placed on them. Raycasts will pass throuugh these layers and may place foliage underneath
		/// </summary>
		public LayerMask PlacementMask;

		/// <summary>
		/// Raycasts hitting these layers will be blocked. Unlike PlacementMask, foliage cannot be placed under objects in these layers
		/// </summary>
		public LayerMask ExcludedLayers;

		/// <summary>
		/// The Biome asset used to describe which foliage species should be placed
		/// </summary>
		public FoliageBiome Biome;

		public event ParameterlessDelegate OnGenerationComplete;
		public event ParameterlessDelegate OnGenerationProgressChanged;


		public bool IsSimulating { get; private set; }
		public float PercentageComplete { get; private set; }
		public float Volume
		{
			get
			{
				Vector3 scaledSize = ScaledBounds.extents * 2;
				return scaledSize.x * scaledSize.z;
			}
		}
		public int CellCount
		{
			get
			{
				if (IsSimulating)
					return volumes.Count;
				else
				{
					int xCount, yCount, zCount;
					Vector3 remainder;

					NumberUtil.ModWithRemainder(ScaledBounds.size, MaxTileSize, out xCount, out yCount, out zCount, out remainder);
					return xCount * zCount;
				}
			}
		}

		public int FailedCount { get { return failedCount; } }
		public int InstanceCount { get { return instanceCount; } }
		public double GenerationTime { get { return generationTime; } }
		public int InstancesAffectedByTreeLimit { get { return instancesAffectedByTreeLimit; } }
		public List<Terrain> TerrainsAffectedByTreeLimit { get { return terrainsAffectedByTreeLimit; } }

		[SerializeField, HideInInspector] private FoliageGenerationData data;
		[SerializeField, HideInInspector] private int instanceCount;
		[SerializeField, HideInInspector] private double generationTime;
		[SerializeField, HideInInspector] private GameObject generatedRoot;
		[SerializeField, HideInInspector] internal int failedCount;
		[SerializeField, HideInInspector] internal List<Terrain> terrainsAffectedByTreeLimit = new List<Terrain>();
		[SerializeField, HideInInspector] internal int instancesAffectedByTreeLimit;

		private System.Random randomStream;
		private List<FoliageAreaTile> volumes = new List<FoliageAreaTile>();
		private DateTime generationStartTime;


		public FoliageArea()
		{
			Layer = 1;
			PlacementMask = 1;
			ExcludedLayers = 0;
		}

		/// <summary>
		/// Simulates the generation of foliage. This is a blocking call
		/// </summary>
		public void SimulateImmediate(bool clear = true)
		{
			var enumerator = SimulationCoroutine(clear);
			while (enumerator.MoveNext()) { }
		}

		/// <summary>
		/// Simulates the generation of foliage over a number of frames
		/// </summary>
		public void Simulate(bool clear = true, Func<IEnumerator> yieldDelegate = null)
		{
			StartCoroutine(SimulationCoroutine(clear, yieldDelegate));
		}

		/// <summary>
		/// Simulates the generation of foliage over a number of frames
		/// </summary>
		public IEnumerator SimulationCoroutine(bool clear = true, Func<IEnumerator> yieldDelegate = null)
		{
			if (IsSimulating) yield break;
			if (yieldDelegate == null) yieldDelegate = () => { return null; };

			// Clear & re-initialize for a clean-slate
			if (clear)
				Clear();

			Initialize();

			IsSimulating = true;
			generationStartTime = DateTime.UtcNow;

			foreach (var segmentBounds in GetSplitBounds())
				volumes.Add(new FoliageAreaTile(data, segmentBounds));

			foreach (var volume in volumes)
				volume.StartSimulation();

			while (volumes.Any(x => x.IsSimulating))
			{
				foreach (var volume in volumes)
				{
					if (volume.IsSimulating)
					{
						volume.ContinueSimulation();
						PercentageComplete = volumes.Average(x => x.PercentageComplete);

						if (OnGenerationProgressChanged != null)
							OnGenerationProgressChanged();

						yield return yieldDelegate();
					}
				}
			}

			PostProcess();
			IsSimulating = false;
			generationTime = (DateTime.UtcNow - generationStartTime).TotalSeconds;

			// We need to refresh any terrain colliders if terrain trees were placed at runtime
#if UNITY_EDITOR
			if (UnityEditor.EditorApplication.isPlaying)
				RefreshTerrainColliders();
			else
				EditorSceneManager.MarkSceneDirty(gameObject.scene);
#else
			RefreshTerrainColliders();
#endif

			if (OnGenerationComplete != null)
				OnGenerationComplete();
		}

		/// <summary>
		/// Refreshes all the terrain colliders so they're aware of any runtime-placed terrain trees
		/// </summary>
		private void RefreshTerrainColliders()
		{
			foreach (var terrainCollider in Component.FindObjectsOfType<TerrainCollider>())
			{
				terrainCollider.enabled = false;
				terrainCollider.enabled = true;
			}
		}

		#region "Fit to" Helper Methods

		public void SetBounds(Bounds bounds)
		{
			if (bounds.extents.x > 0 && bounds.extents.y > 0 && bounds.extents.z > 0)
			{
				transform.position = bounds.center;
				transform.localScale = bounds.extents * 2;
			}
		}

		public void FitToGeometry()
		{
			Bounds bounds = new Bounds();
			bool hasBounds = false;

			// Encapsulate Colliders
			foreach (var collider in Component.FindObjectsOfType<Collider>())
				if (!hasBounds)
				{
					bounds = collider.bounds;
					hasBounds = true;
				}
				else
					bounds.Encapsulate(collider.bounds);

			// Enacapsulate Renderers
			foreach (var renderer in Component.FindObjectsOfType<Renderer>())
				if (!hasBounds)
				{
					bounds = renderer.bounds;
					hasBounds = true;
				}
				else
					bounds.Encapsulate(renderer.bounds);

			SetBounds(bounds);
		}

		public void FitToTerrain()
		{
			Bounds bounds = new Bounds();
			bool hasBounds = false;

			// Encapsulate Colliders
			foreach (var collider in Component.FindObjectsOfType<TerrainCollider>())
				if (!hasBounds)
				{
					bounds = collider.bounds;
					hasBounds = true;
				}
				else
					bounds.Encapsulate(collider.bounds);

			SetBounds(bounds);
		}

#if UNITY_EDITOR
		public void FitToSelection()
		{
			if (UnityEditor.Selection.gameObjects.Length <= 0)
				return;

			Bounds bounds = new Bounds();
			bool hasBounds = false;

			foreach (var obj in UnityEditor.Selection.gameObjects)
			{
				// Encapsulate Colliders
				foreach (var collider in obj.GetComponents<Collider>())
					if (!hasBounds)
					{
						bounds = collider.bounds;
						hasBounds = true;
					}
					else
						bounds.Encapsulate(collider.bounds);

				// Encapsulate Renderers
				foreach (var renderer in obj.GetComponents<Renderer>())
					if (!hasBounds)
					{
						bounds = renderer.bounds;
						hasBounds = true;
					}
					else
						bounds.Encapsulate(renderer.bounds);
			}

			SetBounds(bounds);
		}
#endif

		#endregion

		/// <summary>
		/// Sets the initial state
		/// </summary>
		private void Initialize()
		{
			// Simple sanity-checks
			if (Biome.Species.Count <= 0)
				throw new Exception("Biome must have at least one species assigned");

			// Seed the random stream
			randomStream = new System.Random(Seed);
			data = new FoliageGenerationData(this, randomStream);

			if (Root == null)
			{
				Root = new GameObject("Landscaper Foliage");
				Root.isStatic = true;
				Root.layer = Layer;

				generatedRoot = Root;
			}
		}

		/// <summary>
		/// Handles the finalization stage
		/// </summary>
		private void PostProcess()
		{
			instanceCount = 0;

			foreach (var volume in volumes)
				instanceCount += volume.InstanceCount;

			if (generatedRoot != null && generatedRoot.transform.childCount == 0)
			{
				GameObject.DestroyImmediate(generatedRoot);
				Root = null;
			}
		}

		/// <summary>
		/// Removes all of the placed foliage and resets the component back to an uninitialized state
		/// </summary>
		public void Clear()
		{
			if (data == null || IsSimulating)
				return;

			volumes.Clear();
			instanceCount = 0;
			failedCount = 0;
			instancesAffectedByTreeLimit = 0;
			terrainsAffectedByTreeLimit.Clear();

			if (generatedRoot != null)
			{
				GameObject.DestroyImmediate(generatedRoot);
				Root = null;
			}

			// Remove every GameObject
			if (data.PlacedObjects != null)
			{
				foreach (var obj in data.PlacedObjects)
					if (obj != null)
						GameObject.DestroyImmediate(obj);

				data.PlacedObjects.Clear();
			}

			// Remove Tree instances from the terrain
			if (data.UsedTerrains != null)
			{
				foreach (var terrain in data.UsedTerrains)
				{
					if (terrain == null)
						continue;

					// Unfortunately, we can't reliably remove only the trees we added when simulating, so we have to clear the terrain
					terrain.terrainData.treeInstances = new TreeInstance[0];
				}

				data.UsedTerrains.Clear();
			}

			data = null;
			IsSimulating = false;
		}

		private List<Bounds> GetSplitBounds()
		{
			return ScaledBounds.Split(new Vector3(MaxTileSize, ScaledBounds.extents.y * 2, MaxTileSize));
		}

		private void OnDrawGizmosSelected()
		{
			// Draw segment bounds
			Gizmos.color = Color.yellow;
			foreach (var segment in GetSplitBounds())
				Gizmos.DrawWireCube(segment.center, segment.extents * 2);

			// Draw the overall area bounds
			Gizmos.color = Color.green;
			Gizmos.DrawWireCube(ScaledBounds.center, ScaledBounds.extents * 2);
		}
	}
}
