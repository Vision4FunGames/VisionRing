using System;
using System.Collections.Generic;

namespace Landscaper
{
	/// <summary>
	/// Generation-specific information related to a species of foliage
	/// </summary>
	[Serializable]
	public sealed class FoliageGeneration
	{
		#region Statics

		/// <summary>
		/// Default, empty generation object
		/// </summary>
		public static readonly FoliageGeneration None = new FoliageGeneration();

		#endregion

		/// <summary>
		/// Species whether this generation override information is to be used
		/// </summary>
		public bool IsEnabled = false;

		/// <summary>
		/// An optional set of override archetypes which allows for different prefabs to be used for different generations of the same species
		/// </summary>
		public List<FoliageArchetype> OverrideArchetypes = new List<FoliageArchetype>();
	}
}
