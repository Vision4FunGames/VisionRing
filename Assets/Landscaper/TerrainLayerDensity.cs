using System;
using UnityEngine;

namespace Landscaper
{

	[Serializable]
	public sealed class TerrainLayerDensity
	{
#if UNITY_2018_3_OR_NEWER
		public TerrainLayer TerrainLayer = null;
#endif
		public Texture2D Texture = null;
		public int TextureIndex = 0;
		public float DensityMultiplier = 1f;


		public TerrainLayerDensity()
		{
		}

#if UNITY_2018_3_OR_NEWER

		public TerrainLayerDensity(TerrainLayer terrainLayer, float densityMultiplier)
		{
			TerrainLayer = terrainLayer;
			DensityMultiplier = densityMultiplier;
		}
#endif

		public TerrainLayerDensity(Texture2D texture, float densityMultiplier)
		{
			Texture = texture;
			DensityMultiplier = densityMultiplier;
		}

		public TerrainLayerDensity(int textureIndex, float densityMultiplier)
		{
			TextureIndex = textureIndex;
			DensityMultiplier = densityMultiplier;
		}
	}
}
