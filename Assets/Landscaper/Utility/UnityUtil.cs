using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Landscaper
{
	/// <summary>
	/// A collection of utility methods specific to Unity
	/// </summary>
	public static class UnityUtil
	{
		#region Editor Utilities

#if UNITY_EDITOR
		public static LayerMask LayerMaskField(string label, LayerMask layerMask)
		{
			return LayerMaskField(new GUIContent(label), layerMask);
		}

		public static LayerMask LayerMaskField(GUIContent label, LayerMask layerMask)
		{
			List<string> layers = new List<string>();
			List<int> layerNumbers = new List<int>();

			for (int i = 0; i < 32; i++)
			{
				string layerName = LayerMask.LayerToName(i);
				if (layerName != "")
				{
					layers.Add(layerName);
					layerNumbers.Add(i);
				}
			}

			int maskWithoutEmpty = 0;
			for (int i = 0; i < layerNumbers.Count; i++)
			{
				if (((1 << layerNumbers[i]) & layerMask.value) > 0)
					maskWithoutEmpty |= (1 << i);
			}

			maskWithoutEmpty = EditorGUILayout.MaskField(label, maskWithoutEmpty, layers.ToArray());
			int mask = 0;

			for (int i = 0; i < layerNumbers.Count; i++)
			{
				if ((maskWithoutEmpty & (1 << i)) > 0)
					mask |= (1 << layerNumbers[i]);
			}

			layerMask.value = mask;
			return layerMask;
		}

		/// <summary>
		/// Creates a new asset and saves it to the currently selected folder in the project panel
		/// </summary>
		/// <typeparam name="T">The type of asset to create</typeparam>
		/// <returns>The new asset</returns>
		public static T CreateAsset<T>() where T : ScriptableObject
		{
			T newAsset = ScriptableObject.CreateInstance<T>();

			string path = "Assets";
			var selectedObjects = Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets);

			// We have some objects selected, use the path of the first
			if (selectedObjects.Count() > 0)
			{
				path = AssetDatabase.GetAssetPath(selectedObjects.First());

				if (File.Exists(path))
					path = Path.GetDirectoryName(path);
			}

			path += string.Format("/New {0}.asset", typeof(T).Name);

			AssetDatabase.CreateAsset(newAsset, path);
			AssetDatabase.SaveAssets();

			Selection.activeObject = newAsset;

			return newAsset;
		}
#endif

		#endregion

		#region Extensions

		public static List<Bounds> Split(this Bounds bounds, float maxSize)
		{
			return Split(bounds, new Vector3(maxSize, maxSize, maxSize));
		}

		public static List<Bounds> Split(this Bounds bounds, Vector3 maxSize)
		{
			int xCount, yCount, zCount;
			Vector3 remainder;

			NumberUtil.ModWithRemainder(bounds.extents * 2, maxSize, out xCount, out yCount, out zCount, out remainder);
			List<Bounds> splitBounds = new List<Bounds>((xCount + 1) * (yCount + 1) * (zCount + 1));

			for (int i = 0; i <= xCount; i++)
				for (int j = 0; j <= yCount; j++)
					for (int k = 0; k <= zCount; k++)
					{
						// Skip the last one if there's no remainder
						if (i == xCount && remainder.x <= 0)
							continue;
						if (j == yCount && remainder.y <= 0)
							continue;
						if (k == zCount && remainder.z <= 0)
							continue;

						Vector3 size = maxSize;

						// Adjust the size if this is the remainder
						if (i == xCount)
							size.x = remainder.x;
						if (j == yCount)
							size.y = remainder.y;
						if (k == zCount)
							size.z = remainder.z;

						Vector3 min = bounds.min + Vector3.Scale(new Vector3(i, j, k), maxSize);
						Bounds segmentBounds = new Bounds(min + (size / 2), size);
						splitBounds.Add(segmentBounds);
					}

			return splitBounds;
		}

		#endregion

		/// <summary>
		/// Find the index of the dominant texture at given world-space point on a terrain
		/// </summary>
		/// <param name="worldPosition">The world-space position to check</param>
		/// <param name="terrain">The terrain</param>
		/// <returns>The index of the dominant texture on the specified terrain</returns>
		public static int GetDominantTerrainTextureAtPosition(Vector3 worldPosition, Terrain terrain)
		{
			TerrainData terrainData = terrain.terrainData;
			Vector3 terrainPosition = terrain.transform.position;

			int x = (int)(((worldPosition.x - terrainPosition.x) / terrainData.size.x) * terrainData.alphamapWidth);
			int z = (int)(((worldPosition.z - terrainPosition.z) / terrainData.size.z) * terrainData.alphamapHeight);

			float[,,] splatmap = terrainData.GetAlphamaps(x, z, 1, 1);
			int textureCount = splatmap.GetUpperBound(2) + 1;

			float maxValue = 0;
			int maxID = 0;

			for (int i = 0; i < textureCount; i++)
			{
				float value = splatmap[0, 0, i];

				if (value > maxValue)
				{
					maxID = i;
					maxValue = value;
				}
			}

			return maxID;
		}

		/// <summary>
		/// Recursively gets a list of all child GameObjects in the hierarchy
		/// </summary>
		/// <param name="obj">The object to get the children from</param>
		/// <param name="children">Reference to a list to fill</param>
		public static void GetAllChildrenInHierarchy(GameObject obj, ref List<GameObject> children)
		{
			for (int i = 0; i < obj.transform.childCount; i++)
			{
				var child = obj.transform.GetChild(i);
				children.Add(child.gameObject);

				if (child.childCount > 0)
					GetAllChildrenInHierarchy(child.gameObject, ref children);
			}
		}

		/// <summary>
		/// Recursively sets the layer for this GameObject and all children in the hierarchy
		/// </summary>
		/// <param name="layer">The layer to set</param>
		/// <param name="gameObjects">The root GameObject(s)</param>
		public static void SetLayerRecursive(int layer, params GameObject[] gameObjects)
		{
			foreach (var obj in gameObjects)
			{
				obj.layer = layer;

				for (int i = 0; i < obj.transform.childCount; i++)
					SetLayerRecursive(layer, obj.transform.GetChild(i).gameObject);
			}
		}

		/// <summary>
		/// Gets the the index for the TreePrototype using a given prefab, or adds it if it doesn't already exist
		/// </summary>
		/// <param name="terrain">The terrain to check</param>
		/// <param name="prefab">The prefab to look for or add</param>
		/// <returns>An index into terrain.terainData.treePrototypes array</returns>
		public static int GetOrAddTreePrototype(Terrain terrain, GameObject prefab)
		{
			var prototypes = terrain.terrainData.treePrototypes;

			for (int i = 0; i < prototypes.Length; i++)
				if (prototypes[i].prefab == prefab)
					return i;

			TreePrototype newProto = new TreePrototype()
			{
				prefab = prefab,
			};

			TreePrototype[] newPrototypes = new TreePrototype[prototypes.Length + 1];
			Array.Copy(prototypes, newPrototypes, prototypes.Length);

			int newIndex = newPrototypes.Length - 1;
			newPrototypes[newIndex] = newProto;
			terrain.terrainData.treePrototypes = newPrototypes;

			return newIndex;
		}

		public static Vector3 WorldToTerrainPosition(Terrain terrain, Vector3 worldPosition)
		{
			Vector3 terrainSize = terrain.terrainData.size;
			Vector3 terrainPosition = worldPosition - terrain.transform.position;
			terrainPosition.x /= terrainSize.x;
			terrainPosition.y /= terrainSize.y;
			terrainPosition.z /= terrainSize.z;

			return terrainPosition;
		}
	}
}
