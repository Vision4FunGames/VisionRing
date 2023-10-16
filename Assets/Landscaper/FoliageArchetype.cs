using System;
using UnityEngine;

namespace Landscaper
{
	/// <summary>
	/// Contains all data required to describe a type of foliage, species can have multiple archetypes
	/// </summary>
	[Serializable]
	public sealed class FoliageArchetype
	{
		/// <summary>
		/// The prefab that represents an instance of this foliage archetype
		/// </summary>
		public GameObject Prefab;

		/// <summary>
		/// The method used when placing the foliage. GameObjects are always used when placing on non-terrain surfaces.
		/// </summary>
		public FoliagePlacementMethod PlacementMethod = FoliagePlacementMethod.TerrainTree;

		/// <summary>
		/// Whether the GameObject should be placed as static. Ignored when PlacementMethod is not 'GameObject'
		/// </summary>
		public bool GameObjectStatic = true;

		/// <summary>
		/// The scale of instances in the first generation
		/// </summary>
		public float MaximumScale = 1.0f;

		/// <summary>
		/// The scale of instances in the final generation
		/// </summary>
		public float MinimumScale = 0.8f;

		/// <summary>
		/// How much to allow the colour to be varied
		/// </summary>
		public float ColourVariation = 0.4f;

		/// <summary>
		/// Changes how likely it is that this archetype will be picked when planting a new foliage instance, relative to all others in the species
		/// </summary>
		public float Weight = 1.0f;
	}
}
