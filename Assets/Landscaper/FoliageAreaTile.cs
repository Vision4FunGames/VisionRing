using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Landscaper
{
	/// <summary>
	/// Data about the placement of a foliage object
	/// </summary>
	public struct PlacementInfo
	{
		public FoliageSpecies Species;
		public int Generation;
		public Vector3 Position;
		public Vector3 Normal;


		public PlacementInfo(FoliageSpecies species, int generation, Vector3 position, Vector3 normal, System.Random randomStream)
			: this()
		{
			Species = species;
			Generation = generation;
			Position = position;
			Normal = normal;
		}
	}


	/// <summary>
	/// Fills a set area with foliage
	/// </summary>
	public sealed class FoliageAreaTile
	{
		#region Constants
		private const int MaxRetryCount = 100;
		private const int IgnoreRaycastLayer = 2;
		#endregion

		public FoliageGenerationData Data { get; private set; }
		public Bounds Bounds { get; private set; }
		public float Volume { get; private set; }
		public bool IsSimulating { get; private set; }
		public float PercentageComplete { get { return generation / (float)foliageArea.GenerationsCount; } }

		public int InstanceCount { get; private set; }

		private FoliageArea foliageArea;
		private FoliageBiome biome;
		private System.Random randomStream;

		private List<GameObject> placedObjects = new List<GameObject>();
		private List<PlacementInfo> placedFoliage = new List<PlacementInfo>();
		private List<Terrain> usedTerrains = new List<Terrain>();
		private Dictionary<FoliageSpecies, List<PlacementInfo>> previousGeneration = new Dictionary<FoliageSpecies, List<PlacementInfo>>();
		private Dictionary<FoliageSpecies, List<PlacementInfo>> currentGeneration = new Dictionary<FoliageSpecies, List<PlacementInfo>>();

		private int generation;
		private float averageSpeciesWeight;

		private int retryCount;
		private PlacementInfo currentInstance;
		private Dictionary<TerrainData, Dictionary<TerrainLayerDensity, int>> cachedLayerMaskIndices = new Dictionary<TerrainData, Dictionary<TerrainLayerDensity, int>>();


		public FoliageAreaTile(FoliageGenerationData data, Bounds bounds)
		{
			Data = data;
			Bounds = bounds;
			Volume = (bounds.extents.x * bounds.extents.z) * 2;

			// Store information in temporary variables for quick & easy access
			foliageArea = data.Area;
			biome = foliageArea.Biome;
			randomStream = data.RandomStream;
		}

		/// <summary>
		/// Generates the initial foliage instances
		/// </summary>
		public void StartSimulation()
		{
			if (IsSimulating)
				return;

			IsSimulating = true;
			Initialize();

			ContinueSimulation();
		}

		/// <summary>
		/// Continues the generation process by generating one additional generation for each species
		/// </summary>
		/// <returns>True if the generation is now complete</returns>
		public bool ContinueSimulation()
		{
			foreach (var species in biome.Species)
				AddFoliageGeneration(species);

			AdvanceGeneration();

			if (generation >= foliageArea.GenerationsCount)
			{
				PostProcess();
				IsSimulating = false;

				return true;
			}

			return false;
		}

		/// <summary>
		/// Sets the initial state
		/// </summary>
		private void Initialize()
		{
			// Cache some information to be used later
			averageSpeciesWeight = biome.Species.Select(x => x.Weight).Sum() / biome.Species.Count;

			// Pre-calculate some values to speed up generation
			foreach (var species in biome.Species)
			{
				species.Species.CollisionRangeSq = Mathf.Pow(species.Species.CollisionRange, 2);
				species.Species.ShadeRangeSq = Mathf.Pow(species.Species.ShadeRange, 2);
			}
		}

		/// <summary>
		/// Advances the generation by 1
		/// </summary>
		private void AdvanceGeneration()
		{
			generation++;

			// Swap previousGeneration and currentGeneration dictionaries
			previousGeneration.Clear();
			var temp = previousGeneration;

			previousGeneration = currentGeneration;
			currentGeneration = temp;
		}

		/// <summary>
		/// Adds the next generation of foliage
		/// </summary>
		/// <param name="species">The species to plant</param>
		private void AddFoliageGeneration(SpeciesWeight species)
		{
			// First Generation
			if (generation == 0)
				PlaceFoliageFirstGeneration(species);
			else
			{
				List<PlacementInfo> instances;
				if (previousGeneration.TryGetValue(species.Species, out instances))
				{
					// Foreach instance of this species in the previous generation, plant some children
					foreach (var inst in instances)
						SimulateChildren(inst);
				}
			}
		}

		/// <summary>
		/// Generates some child instances for a given foliage instance
		/// </summary>
		/// <param name="instance"></param>
		private void SimulateChildren(PlacementInfo instance)
		{
			// Cache the current instance for use later
			currentInstance = instance;

			FoliageSpecies species = instance.Species;
			int childCount = randomStream.Next(species.MinChildren, species.MaxChildren);

			// For each child, try to pick a random position in range of the current instance. Can skip if it fails
			for (int i = 0; i < childCount; i++)
			{
				Vector3 normal;
				Terrain terrain;
				Vector3? position = PickRandomPoint(GetRandomPointInRangeOfCurrentInstance, species, out normal, out terrain, false);

				if (!position.HasValue)
					continue;

				AddNewInstance(species, position.Value, normal, terrain);
			}
		}

		/// <summary>
		/// Handles the finalization stage
		/// </summary>
		private void PostProcess()
		{
			// Make sure our foliage instances are on the right layer
			foreach (var obj in placedObjects)
				UnityUtil.SetLayerRecursive(foliageArea.Layer, obj);

			// Clear all temporary data
			previousGeneration.Clear();
			currentGeneration.Clear();
			placedFoliage.Clear();
			cachedLayerMaskIndices.Clear();

			Data.PlacedObjects.AddRange(placedObjects);
			Data.UsedTerrains.AddRange(usedTerrains);
		}

		/// <summary>
		/// Place the first generation of foliage for a given species
		/// </summary>
		/// <param name="species">The species to plant</param>
		private void PlaceFoliageFirstGeneration(SpeciesWeight species)
		{
			// Modify the initial seed density by the species' weight (as defined by the biome)
			float density = species.Species.InitialSeedDensity * (species.Weight / averageSpeciesWeight);
			density *= foliageArea.DensityScale;

			// Use the density and volume to calculate a number of instances to spawn..
			int pointCount = Mathf.RoundToInt(Volume * density);

			//..down to a minimum of one
			if (pointCount == 0)
				pointCount = 1;

			// For each child, try to pick a random position on the bounding box. Can skip if it fails
			for (int i = 0; i < pointCount; i++)
			{
				Vector3 normal;
				Terrain terrain;
				Vector3? position = PickRandomPoint(GetRandomPointOnBounds, species.Species, out normal, out terrain, false);

				if (!position.HasValue)
					continue;

				AddNewInstance(species.Species, position.Value, normal, terrain);
			}
		}

		/// <summary>
		/// Adds a new foliage instance to the world
		/// </summary>
		/// <param name="species">The species to add</param>
		/// <param name="position">Chosen position</param>
		/// <param name="normal">Chosen surface normal</param>
		/// /// <param name="terrain">The terrain this instance should be placed on, or NULL for non-terrain surfaces</param>
		private void AddNewInstance(FoliageSpecies species, Vector3 position, Vector3 normal, Terrain terrain)
		{
			PlacementInfo placementInfo = new PlacementInfo(species, generation, position, normal, randomStream);
			placedFoliage.Add(placementInfo);

			// Add this instance to the corresponding list for this species; if the list doesn't exist, create it
			List<PlacementInfo> instances;
			if (!currentGeneration.TryGetValue(species, out instances))
			{
				instances = new List<PlacementInfo>();
				currentGeneration.Add(species, instances);
			}

			instances.Add(placementInfo);

			FoliageArchetype archetype = species.GetRandomArchetype(randomStream, generation);
			FoliagePlacementMethod method = (terrain == null) ? FoliagePlacementMethod.GameObject : archetype.PlacementMethod;

			// Has reach limit for placing LODable terrain trees on this terrain
			if (method == FoliagePlacementMethod.TerrainTree &&
				terrain.terrainData.treeInstances.Length >= LandscaperConstants.TerrainTreeCap)
			{
				foliageArea.instancesAffectedByTreeLimit++;

				if (!foliageArea.terrainsAffectedByTreeLimit.Contains(terrain))
					foliageArea.terrainsAffectedByTreeLimit.Add(terrain);


				if (foliageArea.LimitMode == TerrainTreeLimitMode.Limit)
					return;
				else if (foliageArea.LimitMode == TerrainTreeLimitMode.Replace)
					method = FoliagePlacementMethod.GameObject;
			}

			switch (method)
			{
				case FoliagePlacementMethod.TerrainTree:
					{
						CreateFoliageTerrainTree(species, archetype, generation, position, normal, terrain);
					}
					break;

				case FoliagePlacementMethod.GameObject:
					{
						GameObject placedObject = CreateFoliageGameObject(species, archetype, generation, position, normal);
						placedObject.transform.parent = foliageArea.Root.transform;
						placedObjects.Add(placedObject);
					}
					break;

				default:
					break;
			}

			InstanceCount++;
		}

		/// <summary>
		/// Picks a random point using a provided delegate then checks against all requirements. If it fails, it will
		/// retry until it succeeds or until FoliageArea.MaxRetryCount is reached.
		/// </summary>
		/// <param name="pointGenerator">The delegate that handles generation random points</param>
		/// <param name="species">The species to spawn</param>
		/// <param name="normal">Output the surface normal for the randomly selected point</param>
		/// /// <param name="terrain">Output the terrain beneath the chosen point, or NULL if placed on a non-terrain object</param>
		/// <param name="wasRetry">Is this call to the method a retry?</param>
		/// <returns>The selected point, or null if no point could be found</returns>
		private Vector3? PickRandomPoint(Func<Vector3> pointGenerator, FoliageSpecies species, out Vector3 normal, out Terrain terrain, bool wasRetry)
		{
			terrain = null;

			// Manage the retry counter
			if (wasRetry)
			{
				if (retryCount >= FoliageAreaTile.MaxRetryCount)
				{
					normal = Vector3.up;
					foliageArea.failedCount++;
					return null;
				}
				else
					retryCount++;
			}
			else
				retryCount = 0;

			Vector3 startPoint = pointGenerator();
			Vector3 endPoint = startPoint + (Vector3.down * Bounds.extents.y * 2);



			// Test collision

			// Hit excluded layer
			if (foliageArea.ExcludedLayers.value != 0 && Physics.Linecast(startPoint, endPoint, foliageArea.ExcludedLayers))
				return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);

			RaycastHit hitInfo;
			bool wasHit = Physics.Linecast(startPoint, endPoint, out hitInfo, foliageArea.PlacementMask);

			// No hit
			if (!wasHit)
				return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);



			// Try to find a terrain beneath the point
			if (hitInfo.collider is TerrainCollider)
			{
				terrain = hitInfo.collider.gameObject.GetComponent<Terrain>();
				var terrainData = terrain.terrainData;

				// We have some mask constraints
				if (species.LayerDensityRules.Count > 0)
				{
					Vector3 terrainPosition = terrain.transform.position;

					int x = (int)(((hitInfo.point.x - terrainPosition.x) / terrainData.size.x) * terrainData.alphamapWidth);
					int z = (int)(((hitInfo.point.z - terrainPosition.z) / terrainData.size.z) * terrainData.alphamapHeight);

					float[,,] splatmap = terrainData.GetAlphamaps(x, z, 1, 1);
					int layerCount = splatmap.GetUpperBound(2) + 1;


					float[] densityMultipliers = new float[layerCount];

					for (int i = 0; i < layerCount; i++)
						densityMultipliers[i] = species.DefaultLayerDensity;

					foreach(var maskLayer in species.LayerDensityRules)
					{
						int layerIndex = GetTerrainLayerForMask(species.LayerMode, maskLayer, terrainData);

						if (layerIndex >= 0 && layerIndex < layerCount)
							densityMultipliers[layerIndex] = maskLayer.DensityMultiplier;
					}


					float density;

					switch (species.LayerDensityCombineMode)
					{
						case MaskDensityCombineMode.Blend:
							density = 0f;

							for (int i = 0; i < layerCount; i++)
							{
								float layerStrength = splatmap[0, 0, i];
								float densityMul = densityMultipliers[i];

								density += layerStrength * densityMul;
							}

							break;

						case MaskDensityCombineMode.Min:
							density = 1f;

							for (int i = 0; i < layerCount; i++)
							{
								float densityMul = densityMultipliers[i];

								// Only consider layers that have some weight
								if (splatmap[0, 0, i] > 0f && densityMul < density)
									density = densityMul;
							}

							break;

						case MaskDensityCombineMode.Max:
							density = 0f;

							for (int i = 0; i < layerCount; i++)
							{
								float densityMul = densityMultipliers[i];

								// Only consider layers that have some weight
								if (splatmap[0, 0, i] > 0f && densityMul > density)
									density = densityMul;
							}

							break;

						default:
							throw new NotImplementedException(string.Format("{0}.{1} is not implemented", typeof(MaskDensityCombineMode).Name, species.LayerDensityCombineMode));
					}

					// Skip placing this instance
					if (density <= 0f || randomStream.NextDouble() > density)
						return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);
				}
			}

			Vector3 position = hitInfo.point;
			normal = hitInfo.normal;

			// Test position to ensure it's still inside AABB
			if (!Bounds.Contains(position))
				return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);

			// Test slope angle
			float slopeAngle = Mathf.Acos(Vector3.Dot(normal, Vector3.up)) * Mathf.Rad2Deg;
			if (slopeAngle < species.MinSlopeAngle || slopeAngle > species.MaxSlopeAngle)
				return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);

			// Test position
			bool isValidPosition = true;

			// Check altitude (as world Y position)
			if (position.y < species.MinAltitude || position.y > species.MaxAltitude)
				isValidPosition = false;

			if (isValidPosition)
			{
				foreach (var other in placedFoliage)
				{
					// Check against either collision or shade range based on whether this foliage can grow in shade or not
					// NOTE: This assumes ShadeRange is always >= CollisionRange
					float otherRadiusSqr = (species.CanGrowInShade) ? other.Species.CollisionRangeSq : other.Species.ShadeRangeSq;
					float myRadiusSqr = (other.Species.CanGrowInShade) ? species.CollisionRangeSq : species.ShadeRangeSq;

					float radiusSqr = myRadiusSqr + otherRadiusSqr;
					float distanceSqr = (position - other.Position).sqrMagnitude;

					if (distanceSqr < radiusSqr)
					{
						isValidPosition = false;
						break;
					}
				}
			}

			if (!isValidPosition)
				return PickRandomPoint(pointGenerator, species, out normal, out terrain, true);

			return position;
		}

		private int GetTerrainLayerForMask(TextureMaskMode maskMode, TerrainLayerDensity maskInfo, TerrainData terrainData)
		{
			int layerIndex = -1;

			// Check the cache first
			Dictionary<TerrainLayerDensity, int> cachedIndices;
			if (cachedLayerMaskIndices.TryGetValue(terrainData, out cachedIndices))
				if (cachedIndices.TryGetValue(maskInfo, out layerIndex))
					return layerIndex;


			switch (maskMode)
			{
				case TextureMaskMode.Texture:

#if UNITY_2018_3_OR_NEWER
					for (int i = 0; i < terrainData.terrainLayers.Length; i++)
					{
						if (terrainData.terrainLayers[i].diffuseTexture == maskInfo.Texture)
						{
							layerIndex = i;
							break;
						}
					}

					break;
#else
					for (int i = 0; i < terrainData.splatPrototypes.Length; i++)
					{
						if (terrainData.splatPrototypes[i].texture == maskInfo.Texture)
						{
							layerIndex = i;
							break;
						}
					}

					break;
#endif


				case TextureMaskMode.TextureIndex:

					int layerCount;

#if UNITY_2018_3_OR_NEWER
					layerCount = terrainData.terrainLayers.Length;
#else
					layerCount = terrainData.splatPrototypes.Length;
#endif

					if (maskInfo.TextureIndex >= 0 && maskInfo.TextureIndex < terrainData.terrainLayers.Length)
						layerIndex = maskInfo.TextureIndex;

					break;

#if UNITY_2018_3_OR_NEWER
				case TextureMaskMode.TerrainLayer:
					for (int i = 0; i < terrainData.terrainLayers.Length; i++)
					{
						if (terrainData.terrainLayers[i] == maskInfo.TerrainLayer)
						{
							layerIndex = i;
							break;
						}
					}

					break;
#endif

				default:
					throw new NotImplementedException(string.Format("{0}.{1} is not implemented", typeof(TextureMaskMode).Name, maskMode));
			}

			if (!cachedLayerMaskIndices.ContainsKey(terrainData))
				cachedLayerMaskIndices.Add(terrainData, new Dictionary<TerrainLayerDensity, int>());

			cachedLayerMaskIndices[terrainData][maskInfo] = layerIndex;
			return layerIndex;
		}

		/// <summary>
		/// Creates the actual GameObject for a foliage instance
		/// </summary>
		/// <param name="species">The species to create an instance of</param>
		/// <param name="archetype">The chosen archetype to spawn</param>
		/// <param name="generation">The current generation</param>
		/// <param name="position">The position to spawn the instance at</param>
		/// <param name="normal">Corresponding surface normal for the chosen position</param>
		/// <returns></returns>
		private GameObject CreateFoliageGameObject(FoliageSpecies species, FoliageArchetype archetype, int generation, Vector3 position, Vector3 normal)
		{
			// Create the GameObject from the chosen prefab; and set some defaults
			GameObject foliageObject;

#if UNITY_EDITOR
			foliageObject = (GameObject)UnityEditor.PrefabUtility.InstantiatePrefab(archetype.Prefab);
#else
			foliageObject = (GameObject)GameObject.Instantiate(archetype.Prefab);
#endif

			//foliageObject.hideFlags = HideFlags.HideInHierarchy;
			//foliageObject.name = species.name + "_Generation" + generation;
			foliageObject.isStatic = archetype.GameObjectStatic;

			// Gather all GameObjects that are children of the newly created folaige instance..
			List<GameObject> allObjects = new List<GameObject>();
			UnityUtil.GetAllChildrenInHierarchy(foliageObject, ref allObjects);
			allObjects.Add(foliageObject);

			// ..and set them to use the "Ignore Raycast" layer. This prevents the PickRandomPoint method from trying to place foliage ontop of other foliage
			foreach (var obj in allObjects)
				obj.layer = IgnoreRaycastLayer;

			// Update Transforms
			float yaw = randomStream.Next(0.0f, 360.0f);
			foliageObject.transform.position = position;
			foliageObject.transform.up = (species.ConformToMeshSurface) ? normal : Vector3.up;
			foliageObject.transform.Rotate(Vector3.up, yaw, Space.Self);

			// Set scale based on the current generation - with some slight variation
			float scale = Mathf.Lerp(archetype.MaximumScale, archetype.MinimumScale, generation / (float)foliageArea.GenerationsCount);
			foliageObject.transform.localScale = Vector3.one * scale * randomStream.Next(species.MinScaleMultiplier, species.MaxScaleMultiplier);

			return foliageObject;
		}

		/// <summary>
		/// Creates the actual Terrain tree for a foliage instance
		/// </summary>
		/// <param name="species">The species to create an instance of</param>
		/// <param name="archetype">The chosen archetype to spawn</param>
		/// <param name="generation">The current generation</param>
		/// <param name="position">The position to spawn the instance at</param>
		/// <param name="normal">Corresponding surface normal for the chosen position</param>
		/// <param name="terrain">The terrain to add this instance to</param>
		private void CreateFoliageTerrainTree(FoliageSpecies species, FoliageArchetype archetype, int generation, Vector3 position, Vector3 normal, Terrain terrain)
		{
			// Calculate rotation and scaling
			float scale = Mathf.Lerp(archetype.MaximumScale, archetype.MinimumScale, generation / (float)foliageArea.GenerationsCount);
			Vector3 scaleVector = Vector3.one * scale * randomStream.Next(species.MinScaleMultiplier, species.MaxScaleMultiplier);

			int protoIndex = UnityUtil.GetOrAddTreePrototype(terrain, archetype.Prefab);

			float colourVariation = randomStream.Next(0, archetype.ColourVariation);
			byte maxVariation = (byte)(255 * colourVariation);
			byte colourValue = (byte)(255 - maxVariation);
			Color32 instanceColour = new Color32(colourValue, colourValue, colourValue, 255);

			TreeInstance instance = new TreeInstance()
			{
				heightScale = scaleVector.y,
				position = UnityUtil.WorldToTerrainPosition(terrain, position),
				prototypeIndex = protoIndex,
				widthScale = Mathf.Max(scaleVector.x, scaleVector.z),
				color = instanceColour,
				lightmapColor = new Color32(255, 255, 255, 255),
			};

#if UNITY_5
			float yaw = randomStream.Next(0.0f, Mathf.PI * 2);
			instance.rotation = yaw;
#endif

			terrain.AddTreeInstance(instance);

			if (!usedTerrains.Contains(terrain))
				usedTerrains.Add(terrain);
		}

		/// <summary>
		/// Gets a random point on the area's scaled bounds
		/// </summary>
		/// <returns>The chosen point</returns>
		private Vector3 GetRandomPointOnBounds()
		{
			Vector3 point = new Vector3(randomStream.Next(0.0f, 1.0f) - 0.5f, 0.5f, randomStream.Next(0.0f, 1.0f) - 0.5f);
			point.Scale(Bounds.extents * 2);
			point += Bounds.center;

			return point;
		}

		/// <summary>
		/// Gets a random point in range of the current foliage instance
		/// </summary>
		/// <returns>The chosen point</returns>
		private Vector3 GetRandomPointInRangeOfCurrentInstance()
		{
			Vector3 position = currentInstance.Position + randomStream.NextUnitVector2D() * currentInstance.Species.MaxSeedTravelDistance;
			position.y = Bounds.max.y;

			return position;
		}
	}
}
