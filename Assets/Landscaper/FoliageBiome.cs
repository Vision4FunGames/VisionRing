using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Landscaper
{
	/// <summary>
	/// Small helper class - allows the Biome to weight each species of foliage to define how often it appears
	/// </summary>
	[Serializable]
	public sealed class SpeciesWeight
	{
		/// <summary>
		/// The foliage species
		/// </summary>
		public FoliageSpecies Species;

		/// <summary>
		/// A weight describing how often this species of folliage appears (relative to the other species' weights)
		/// </summary>
		public float Weight = 1.0f;
	}

	/// <summary>
	/// A description of the type of foliage that can appear in an area
	/// </summary>
	[Serializable]
	public sealed class FoliageBiome : ScriptableObject
	{
		/// <summary>
		/// A list of foliage species and their corresponding weights, defining how often
		/// a foliage species appears relative to the other species in the list
		/// </summary>
		public List<SpeciesWeight> Species = new List<SpeciesWeight>();


		/// <summary>
		/// Estimates the total number of instances of foliage that will be placed
		/// </summary>
		/// <param name="seed">The random seed used when generating</param>
		/// <param name="volume">The 2D volume for the foliage to be placed in</param>
		/// <param name="generationCount">How many generations are to be spawned</param>
		/// <param name="foliageArea">The foliage area that will be simulating the foliage</param>
		public void GetInstanceCountEstimate(int seed, float volume, int generationCount, FoliageArea foliageArea, out int estimate, out int estimateMax)
		{
			float averageSpeciesWeight = Species.Select(x => x.Weight).Sum() / Species.Count;
			estimate = 0;
			estimateMax = 0;

			foreach (var speciesWeight in Species)
			{
				if (speciesWeight == null || speciesWeight.Species == null)
					continue;

				float density = speciesWeight.Species.InitialSeedDensity * (speciesWeight.Weight / averageSpeciesWeight);
				density *= foliageArea.DensityScale;

				//
				// START NEW CALCULATIONS

				var species = speciesWeight.Species;

				float initialCount = Mathf.Round(volume * density);
				float averageChildCount = ((species.MaxChildren - species.MinChildren) * 0.5f) + species.MinChildren;

				int speciesInstances = Mathf.CeilToInt(initialCount * Mathf.Pow(averageChildCount + 1, generationCount - 1));
				estimate += speciesInstances;

				int speciesInstancesMax = Mathf.CeilToInt(initialCount * Mathf.Pow(species.MaxChildren + 1, generationCount - 1));
				estimateMax += speciesInstancesMax;
			}
		}

		#region Static Methods
#if UNITY_EDITOR
		/// <summary>
		/// Creates a new Biome asset
		/// </summary>
		/// <returns>The newly created asset</returns>
		[MenuItem("Assets/Create/Landscaper/Biome")]
		public static FoliageBiome CreateNew()
		{
			return UnityUtil.CreateAsset<FoliageBiome>();
		}
#endif

		#endregion
	}
}
