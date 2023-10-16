using System;
using System.Collections.Generic;
using UnityEngine;

namespace Landscaper
{
	/// <summary>
	/// A simple container for passing relevant information between a FoliageArea and all of it's contained FoliageVolumes
	/// </summary>
	[Serializable]
	public sealed class FoliageGenerationData
	{
		public FoliageArea Area { get { return area; } }
		public System.Random RandomStream { get { return randomStream; } }
		public List<GameObject> PlacedObjects { get { return placedObjects; } }
		public List<Terrain> UsedTerrains { get { return usedTerrains; } }

		[SerializeField, HideInInspector]
		private FoliageArea area;
		[SerializeField, HideInInspector]
		private List<GameObject> placedObjects;
		[SerializeField, HideInInspector]
		private List<Terrain> usedTerrains;
		[SerializeField, HideInInspector]
		private System.Random randomStream;


		public FoliageGenerationData(FoliageArea area, System.Random randomStream)
		{
			this.area = area;
			this.randomStream = randomStream;
			this.placedObjects = new List<GameObject>();
			this.usedTerrains = new List<Terrain>();
		}
	}
}
