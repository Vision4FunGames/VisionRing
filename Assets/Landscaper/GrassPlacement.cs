//#define CELL_DEBUG_DRAW

using System;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace Landscaper
{
	[AddComponentMenu("Landscaper/Experimental/Grass Placement")]
	public class GrassPlacement : MonoBehaviour
	{
		#region Nested Types

		[Serializable]
		public sealed class GrassInfo
		{
			/// <summary>
			/// The GameObject prefab to spawn
			/// </summary>
			public GameObject Prefab;
			/// <summary>
			/// How likely this grass type is to be placed relative to other grass types
			/// </summary>
			[Range(0f, 1f)]
			public float Weight = 1.0f;
			/// <summary>
			/// If true, uses a random yaw, otherwise unrotated
			/// </summary>
			public bool UseRandomRotation = true;
			/// <summary>
			/// The minimum amount to scale the GameObject (chosen at random)
			/// </summary>
			[Range(0.1f, 10f)]
			public float MinScale = 0.75f;
			/// <summary>
			/// The maximum amount to scale the GameObject (chosen at random)
			/// </summary>
			[Range(0.1f, 10f)]
			public float MaxScale = 1.25f;
			/// <summary>
			/// If true, the GameObject will match its rotation to the underlying terrain surface normal
			/// </summary>
			public bool AlignToSurfaceNormal = true;
			/// <summary>
			/// The minimum slope angle (in degrees) this grass type can grow on
			/// </summary>
			[Range(0f, 90f)]
			public float MinSlopeAngle = 0f;
			/// <summary>
			/// The maximum slope angle (in degrees) this grass type can grow on
			/// </summary>
			[Range(0f, 90f)]
			public float MaxSlopeAngle = 30f;
			/// <summary>
			/// This grass type will only be planted on the layers in TerrainLayerMask when the layer has
			/// a strength greater than this value
			/// </summary>
			[Range(0f, 1f)]
			public float TerrainLayerStrengthThreshold = 0.5f;
			/// <summary>
			/// A list of valid terrain layers this grass type can grow on. If empty, this
			/// grass type can grow on any terrain layer
			/// </summary>
			public List<TerrainLayer> TerrainLayerMask = new List<TerrainLayer>();


			public Vector3 GetRandomScale()
			{
				float scale = Random.Range(MinScale, MaxScale);
				return new Vector3(scale, scale, scale);
			}
		}

		private struct GrassInstance
		{
			public GameObject GameObject;
			public Stack<GameObject> Pool;


			public GrassInstance(GameObject gameObject, Stack<GameObject> pool)
			{
				GameObject = gameObject;
				Pool = pool;
			}
		}

		private sealed class PlacementCell
		{
			public Point Coordinates { get; set; }
			public List<GrassInstance> PlantedInstances { get; } = new List<GrassInstance>();


			public PlacementCell(Point coordinates)
			{
				Coordinates = coordinates;
			}
		}

		private sealed class CachedTerrain
		{
			public Terrain Terrain;
			public TerrainData TerrainData;
			public Vector3 MinPosition;
			public Vector3 MaxPosition;
			public TerrainLayer[] TerrainLayers;
			public float[,,] AlphaMaps;
			public Vector3 Size;
			public int HeightmapResolution;
		}

		#endregion

#if LANDSCAPER_GRASS_DEBUG_STATS
		public float UpdateTime { get; set; }
		public int InstanceCount { get; set; }
#endif

		/// <summary>
		/// The average distance between grass instances
		/// </summary>
		[Min(0.1f)]
		public float Spacing = 2.0f;
		/// <summary>
		/// The size of the grid used to partition the world. Grass instances are loaded/unloaded as
		/// a group based on while grid cell they are contained in
		/// </summary>
		[Min(0.5f)]
		public float GridSize = 10.0f;
		/// <summary>
		/// The maximum distance away from this component (in Unity units) that foliage will be grown
		/// </summary>
		[Min(0.5f)]
		public float Range = 80f;
		/// <summary>
		/// The maximum amount of jitter (0-1) applied to the original grid position to avoid grass
		/// instanced being planted in a uniform grid
		/// </summary>
		[Range(0f, 1f)]
		public float JitterStrength = 1.0f;
		/// <summary>
		/// The density scale (0-1). Determines how many blank spaces to leave while planting grass instances
		/// E.g. A value of 0.25 means each instance has a 25% chance of not being spawned
		/// </summary>
		[Range(0f, 1f)]
		public float Density = 1.0f;
		/// <summary>
		/// A list of possible grass types to spawn
		/// </summary>
		public List<GrassInfo> GrassTypes = new List<GrassInfo>();
		/// <summary>
		/// If true, creating/destroying cells will be done over multiple frames. This is supposed to
		/// smooth out frame hitching but can often do the opposite
		/// </summary>
		public bool StaggerUpdatesOverMultipleFrames = false;
		/// <summary>
		/// If StaggerUpdatesOverMultipleFrames is true, this is the maximum number of tiles to create/destroy
		/// per frame
		/// </summary>
		[Min(1)]
		public int MaxCellUpdatesPerFrame = 1;

		private Point currentCellPosition;
		private Point previousCellPosition;
		private Dictionary<Point, PlacementCell> cells = new Dictionary<Point, PlacementCell>();
		private List<Stack<GameObject>> prefabPools = new List<Stack<GameObject>>();
		private Stack<PlacementCell> cellPool = new Stack<PlacementCell>();
		private Queue<Point> cellsPendingCreation = new Queue<Point>();
		private Queue<Point> cellsPendingDestruction = new Queue<Point>();
		private List<CachedTerrain> terrains = new List<CachedTerrain>();
		private float totalGrassTypeWeight;

		// These are here instead of inside functions to avoid generating garbage every frame
		private List<Point> cellsToDestroy = new List<Point>();
		private List<Point> cellsToCreate = new List<Point>();
		private List<Point> tempCells = new List<Point>();


		private void OnEnable()
		{
			// Initialise prefab pools
			prefabPools.Clear();
			for (int i = 0; i < GrassTypes.Count; i++)
				prefabPools.Add(new Stack<GameObject>());


			// Pre-calculate the total weight of all the grass types
			totalGrassTypeWeight = 0;

			foreach (var grassInfo in GrassTypes)
				totalGrassTypeWeight += grassInfo.Weight;


			// Cache data about all the terrains in the scene
			foreach (var terrain in FindObjectsOfType<Terrain>())
			{
				var terrainData = terrain.terrainData;

				var t = new CachedTerrain()
				{
					Terrain = terrain,
					TerrainData = terrainData,
					MinPosition= terrain.transform.position,
					MaxPosition = terrain.transform.position + terrain.terrainData.size,
					Size = terrainData.size,
					HeightmapResolution = terrainData.heightmapResolution,
				};

				t.TerrainLayers = terrainData.terrainLayers;
				t.AlphaMaps = terrainData.GetAlphamaps(0, 0, terrainData.heightmapResolution - 1, terrainData.heightmapResolution - 1);

				terrains.Add(t);
			}

			// Initial cell refresh
			RefreshCells(false);
		}

		private void OnDisable()
		{
			CleanUp();
		}

		private void CleanUp()
		{
			cellsToDestroy.Clear();
			cellsToDestroy.AddRange(cells.Keys);

			foreach (var cell in cellsToDestroy)
			{
				foreach (var instance in cells[cell].PlantedInstances)
					Destroy(instance.GameObject);

				cells[cell].PlantedInstances.Clear();
			}

			foreach (var pool in prefabPools)
			{
				while (pool.Count > 0)
					Destroy(pool.Pop());
			}

			cells.Clear();
			prefabPools.Clear();
			cellPool.Clear();
			cellsPendingCreation.Clear();
			cellsPendingDestruction.Clear();
		}

		private void Update()
		{
#if CELL_DEBUG_DRAW
			tempCells.Clear();
			GetRelevantCells(PointToGridPosition(transform.position), ref tempCells);

			foreach (var cell in tempCells)
				DrawDebugCell(cell, Color.grey, 0f);
#endif

			currentCellPosition = PointToGridPosition(transform.position);

			if (currentCellPosition != previousCellPosition)
				RefreshCells(StaggerUpdatesOverMultipleFrames);


			// Create / Destroy any staggered cells
			if (cellsPendingDestruction.Count > 0)
			{
				int cellsToDestroy = Mathf.Min(MaxCellUpdatesPerFrame, cellsPendingDestruction.Count);

				for (int i = 0; i < cellsToDestroy; i++)
				{
					Point cell = cellsPendingDestruction.Dequeue();
					DestroyCell(cell);
				}
			}

			if (cellsPendingCreation.Count > 0)
			{
				int cellsToCreate = Mathf.Min(MaxCellUpdatesPerFrame, cellsPendingCreation.Count);

				for (int i = 0; i < cellsToCreate; i++)
				{
					Point cell = cellsPendingCreation.Dequeue();
					CreateCell(cell);
				}
			}
		}

		private void RefreshCells(bool queueCellUpdates)
		{
#if LANDSCAPER_GRASS_DEBUG_STATS
			var sw = System.Diagnostics.Stopwatch.StartNew();
#endif

			// If our position hasn't changed since last time we can skip
			// refreshing cells unless this is our first refresh (cells.Count == 0)
			if (cells.Count > 0 && currentCellPosition == previousCellPosition)
				return;

			// There are existing cells so we need to adjust which cells we update
			// based on our previous position
			if (cells.Count > 0)
			{
				cellsToDestroy.Clear();
				GetNewlyExitedCells(currentCellPosition, previousCellPosition, ref cellsToDestroy);

				cellsToCreate.Clear();
				GetNewlyEnteredCells(currentCellPosition, previousCellPosition, ref cellsToCreate);
			}
			else
			{
				cellsToDestroy.Clear();
				GetRelevantCells(previousCellPosition, ref cellsToDestroy);

				cellsToCreate.Clear();
				GetRelevantCells(currentCellPosition, ref cellsToCreate);
			}

			foreach (var cell in cellsToDestroy)
			{
				if (queueCellUpdates)
					cellsPendingDestruction.Enqueue(cell);
				else
					DestroyCell(cell);
			}

			foreach (var cell in cellsToCreate)
			{
				if (queueCellUpdates)
					cellsPendingCreation.Enqueue(cell);
				else
					CreateCell(cell);
			}

			previousCellPosition = currentCellPosition;

#if LANDSCAPER_GRASS_DEBUG_STATS
			UpdateTime = sw.ElapsedMilliseconds;

			InstanceCount = 0;
			foreach (var pair in cells)
				InstanceCount += pair.Value.PlantedInstances.Count;
#endif
		}

		private void CreateCell(Point cellPosition)
		{
			PlacementCell cell;

			if(!cells.TryGetValue(cellPosition, out cell))
			{
				if (cellPool.Count > 0)
					cell = cellPool.Pop();
				else
					cell = new PlacementCell(cellPosition);

				cells[cellPosition] = cell;
			}

			// Find terrains
			CachedTerrain terrainOnCell = null;
			Vector3 minCellPosition = PointToWorldPosition(cellPosition, Vector2.zero);
			Vector3 maxCellPosition = PointToWorldPosition(cellPosition, Vector2.one);

			foreach (var t in terrains)
			{
				if (t.MinPosition.x > maxCellPosition.x || t.MaxPosition.x < minCellPosition.x ||
					t.MinPosition.z > maxCellPosition.z || t.MaxPosition.z < minCellPosition.z)
					continue;

				terrainOnCell = t;
				break;
			}

			if (terrainOnCell == null)
				return;

			// Plant grass instances
			int rows = Mathf.CeilToInt(GridSize / Spacing);
			Vector3 topLeft = PointToWorldPosition(cellPosition, Vector2.zero);

			for (int x = 0; x < rows; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					if (Random.value > Density)
						continue;

					Vector3 offset = new Vector3(x / (float)rows, 0f, y / (float)rows) * GridSize;
					Vector3 instancePosition = topLeft + offset;

					if (JitterStrength > 0f)
					{
						Vector2 jitter = Random.insideUnitCircle * Spacing;
						instancePosition.x += jitter.x;
						instancePosition.z += jitter.y;
					}

					if (GrassTypes.Count > 0)
					{
						// Get terrain info
						Point terrainPoint;
						Vector2 normalizedTerrainPosition;

						{
							Vector3 terrainPosition = instancePosition - terrainOnCell.MinPosition;
							terrainPosition.x /= terrainOnCell.Size.x;
							terrainPosition.z /= terrainOnCell.Size.z;

							if (terrainPosition.x < 0 || terrainPosition.x > 1 ||
								terrainPosition.z < 0 || terrainPosition.z > 1)
								continue;

							normalizedTerrainPosition = new Vector2(terrainPosition.x, terrainPosition.z);

							terrainPosition = Vector3.Scale(terrainPosition, new Vector3(terrainOnCell.HeightmapResolution - 1, 0f, terrainOnCell.HeightmapResolution - 1));
							terrainPoint = new Point((int)terrainPosition.x, (int)terrainPosition.z);

							terrainPoint = Point.Clamp(terrainPoint, new Point(0), new Point(terrainOnCell.HeightmapResolution - 2));
						}

						instancePosition.y = terrainOnCell.TerrainData.GetHeight(terrainPoint.X, terrainPoint.Y) + terrainOnCell.MinPosition.y;
						Vector3 terrainNormal = terrainOnCell.TerrainData.GetInterpolatedNormal(normalizedTerrainPosition.x, normalizedTerrainPosition.y);
						float slopeAngle = Mathf.Acos(Vector2.Dot(terrainNormal, Vector3.up)) * Mathf.Rad2Deg;

						// Choose grass type to plant
						int grassTypeIndex = -1;
						float randomWeightValue = Random.value * totalGrassTypeWeight;

						for (int i = 0; i < GrassTypes.Count; i++)
						{
							float grassWeight = GrassTypes[i].Weight;

							if (randomWeightValue < grassWeight)
							{
								grassTypeIndex = i;
								break;
							}
							else
								randomWeightValue -= grassWeight;
						}

						// Create grass instance
						var grassInfo = GrassTypes[grassTypeIndex];

						// Check slope angle
						if (slopeAngle < grassInfo.MinSlopeAngle || slopeAngle > grassInfo.MaxSlopeAngle)
							continue;

						// Check layer masks
						if (grassInfo.TerrainLayerMask.Count > 0)
						{
							bool isValidTerrainLayer = false;

							for (int l = 0; l < terrainOnCell.TerrainData.alphamapLayers; l++)
							{
								if (grassInfo.TerrainLayerMask.Contains(terrainOnCell.TerrainLayers[l]))
								{
									float layerStrength = terrainOnCell.AlphaMaps[terrainPoint.Y, terrainPoint.X, l];

									if (layerStrength >= grassInfo.TerrainLayerStrengthThreshold)
									{
										isValidTerrainLayer = true;
										break;
									}
								}
							}

							if (!isValidTerrainLayer)
								continue;
						}

						var instance = GetPrefabInstance(grassTypeIndex);

						// Set transform
						Quaternion instanceRotation = grassInfo.AlignToSurfaceNormal ? Quaternion.LookRotation(Vector3.forward, terrainNormal) : Quaternion.identity;

						if (grassInfo.UseRandomRotation)
							instanceRotation *= Quaternion.AngleAxis(Random.value * 360f, Vector3.up);

						instance.transform.SetPositionAndRotation(instancePosition, instanceRotation);
						instance.transform.localScale = grassInfo.GetRandomScale();

						cell.PlantedInstances.Add(new GrassInstance(instance, prefabPools[grassTypeIndex]));
					}
				}
			}

#if CELL_DEBUG_DRAW
			DrawDebugCell(cellPosition, Color.green, 3f);
#endif
		}

		private void DestroyCell(Point cellPosition)
		{
			PlacementCell cell;

			if (cells.TryGetValue(cellPosition, out cell))
			{
				cells.Remove(cellPosition);

				// Remove grass instances
				foreach (var instance in cell.PlantedInstances)
					PutPrefabInstance(instance);

				cell.PlantedInstances.Clear();
				cellPool.Push(cell);
			}

#if CELL_DEBUG_DRAW
			DrawDebugCell(cellPosition, Color.red, 3f);
#endif
		}

		private void GetRelevantCells(Point position, ref List<Point> cellList)
		{
			int cellRange = Mathf.CeilToInt(Range / GridSize);

			Point min = position - cellRange;
			Point max = position + cellRange;

			for (int x = min.X; x <= max.X; x++)
				for (int y = min.Y; y <= max.Y; y++)
					cellList.Add(new Point(x, y));
		}

		private void GetNewlyEnteredCells(Point currentPosition, Point previousPosition, ref List<Point> cellList)
		{
			int cellRange = Mathf.CeilToInt(Range / GridSize);

			Point currentMin = currentPosition - cellRange;
			Point currentMax = currentPosition + cellRange;

			Point previousMin = previousPosition - cellRange;
			Point previousMax = previousPosition + cellRange;

			for (int x = currentMin.X; x <= currentMax.X; x++)
			{
				for (int y = currentMin.Y; y <= currentMax.Y; y++)
				{
					if ((x >= previousMin.X && x <= previousMax.X) &&
						(y >= previousMin.Y && y <= previousMax.Y))
						continue;

					cellList.Add(new Point(x, y));
				}
			}
		}

		private void GetNewlyExitedCells(Point currentPosition, Point previousPosition, ref List<Point> cellList)
		{
			int cellRange = Mathf.CeilToInt(Range / GridSize);

			Point currentMin = currentPosition - cellRange;
			Point currentMax = currentPosition + cellRange;

			Point previousMin = previousPosition - cellRange;
			Point previousMax = previousPosition + cellRange;

			for (int x = previousMin.X; x <= previousMax.X; x++)
			{
				for (int y = previousMin.Y; y <= previousMax.Y; y++)
				{
					if ((x >= currentMin.X && x <= currentMax.X) &&
						(y >= currentMin.Y && y <= currentMax.Y))
						continue;

					cellList.Add(new Point(x, y));
				}
			}
		}

		private Point PointToGridPosition(Vector3 worldPosition)
		{
			int x = Mathf.FloorToInt(worldPosition.x / GridSize);
			int y = Mathf.FloorToInt(worldPosition.z / GridSize);

			return new Point(x, y);
		}

		private Vector3 PointToWorldPosition(Point gridPosition, Vector2 normalizedDistance)
		{
			Vector3 topLeft = new Vector3(gridPosition.X, 0f, gridPosition.Y) * GridSize;
			Vector3 position = topLeft + new Vector3(	Mathf.Clamp01(normalizedDistance.x),
														0f,
														Mathf.Clamp01(normalizedDistance.y)) * GridSize;
			return position;
		}

		private void DrawDebugCell(Point position, Color colour, float duration)
		{
			Vector3 v0 = PointToWorldPosition(position, new Vector2(0, 0));
			Vector3 v1 = PointToWorldPosition(position, new Vector2(1, 0));
			Vector3 v2 = PointToWorldPosition(position, new Vector2(1, 1));
			Vector3 v3 = PointToWorldPosition(position, new Vector2(0, 1));

			Debug.DrawLine(v0, v1, colour, duration, true);
			Debug.DrawLine(v1, v2, colour, duration, true);
			Debug.DrawLine(v2, v3, colour, duration, true);
			Debug.DrawLine(v3, v0, colour, duration, true);
		}

		private GameObject GetPrefabInstance(int prefabIndex)
		{
			Stack<GameObject> pool = prefabPools[prefabIndex];

			GameObject instance;

			if (pool.Count > 0)
				instance = pool.Pop();
			else
			{
				instance = Instantiate(GrassTypes[prefabIndex].Prefab);
				instance.hideFlags = HideFlags.HideInHierarchy;
			}

			return instance;
		}

		private void PutPrefabInstance(GrassInstance instance)
		{
			instance.Pool.Push(instance.GameObject);
		}
	}
}