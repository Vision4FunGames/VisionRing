using Landscaper;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LandscaperEditor
{
	[CustomEditor(typeof(FoliageSpecies))]
	public sealed class FoliageSpeciesInspector : Editor
	{
		#region Properties

		private SerializedProperty conformToMeshSurface;
		private SerializedProperty initialSeedDensity;
		private SerializedProperty maxSeedTravelDistance;
		private SerializedProperty minChildren;
		private SerializedProperty maxChildren;
		private SerializedProperty collisionRange;
		private SerializedProperty shadeRange;
		private SerializedProperty canGrowInShade;
		private SerializedProperty minScaleMultiplier;
		private SerializedProperty maxScaleMultiplier;
		private SerializedProperty minSlopeAngle;
		private SerializedProperty maxSlopeAngle;
		private SerializedProperty minAltitude;
		private SerializedProperty maxAltitude;
		private SerializedProperty layerMode;
		private SerializedProperty layerDensityCombineMode;
		private SerializedProperty defaultLayerDensity;
		private SerializedProperty layerDensityRules;
		private SerializedProperty archetypeArray;
		private SerializedProperty generationArray;

		#endregion

		private class Labels
		{
			public readonly GUIContent Archetypes = new GUIContent("Archetypes", "Variants of this speies");
			public readonly GUIContent ExpandArchetypes = new GUIContent("Expand All");
			public readonly GUIContent CollapseArchetypes = new GUIContent("Collapse All");
			public readonly GUIContent ConformToMeshSurface = new GUIContent("Align to Surface?", "Should the foliage align its rotation with the surface it is planted on?");
			public readonly GUIContent InitialSeedDensity = new GUIContent("Initial Seed Density", "How much of the available space should be planted with the initial batch of seeds. This should be a very low number.");
			public readonly GUIContent MaxSeedTravelDistance = new GUIContent("Seed Travel Range", "How far away a child instance can spawn from its parent");
			public readonly GUIContent ChildCount = new GUIContent("Child Count (Min - Max)", "How many children each instance can spawn");
			public readonly GUIContent CollisionRange = new GUIContent("Collision Range", "No other foliage instances can be placed within this range");
			public readonly GUIContent ShadeRange = new GUIContent("Shade Range", "Other foliage instances cannot be planted within this range unless that particular species is allowed to grow in the shade");
			public readonly GUIContent CanGrowInShade = new GUIContent("Can Grow in Shade?", "Can this species grow in the shade of another foliage instance?");
			public readonly GUIContent ScaleVariation = new GUIContent("Scale Variation (Min - Max)", "A random scale is chosen between these ranges for each instance");
			public readonly GUIContent SlopeAngle = new GUIContent("Slope Angle (Min - Max)", "Instances of this species can only be planted on slopes between these two angles");
			public readonly GUIContent Altitude = new GUIContent("Altitude (Min - Max)", "The height range in which instances of this species can grow (in Unity units)");
			public readonly GUIContent Generations = new GUIContent("Generation Overrides", "Optional generation-specific override settings starting at generation 0 (the initial set of instances). Any generation beyond the last one specified in this list will be clamped to use the latest override settings");
			public readonly GUIContent MaskMode = new GUIContent("Mode", "Determines how the layers below are defined");
			public readonly GUIContent MaskDensityCombineMode = new GUIContent("Combine Density", "How two or more conflicting densities are resolved.\n     Blend: Blends density values based on the strength of each layer.\n     Min: The lowest density will be used.\n     Max: The highest density will be used.");
			public readonly GUIContent DefaultLayerDensity = new GUIContent("Default Density", "The default density to use for layers that are not present in the list below");
			public readonly GUIContent LayerDensityRules = new GUIContent("Terrain Layers", "Used to optionally define which terrain layers this species can grow on and now densly it will grow");
			public readonly GUIContent LayerDensityMultiplier = new GUIContent("Density", "The density of the foliage when growing on this specific terrain layer");

			public readonly GUIContent Archetype_PlacementMode = new GUIContent("Placement Mode", "What type of object should an instance of this foliage be placed as?");
			public readonly GUIContent Archetype_GameObjectStatic = new GUIContent("Static GameObject", "Should the foliage be placed as static GameObjects?");
			public readonly GUIContent Archetype_SizeByGeneration = new GUIContent("Size by Generation", "How the scale of the foliage changes with each generation. Younger trees use the smaller scale");
			public readonly GUIContent Archetype_ColourVariation = new GUIContent("Colour Variation", "Randomly darkens foliage by a maximum amount (terrain trees only)");
		}

		private Labels labels;

		private Dictionary<FoliageArchetype, bool> archetypeFoldoutStatuses = new Dictionary<FoliageArchetype, bool>();
		private Dictionary<FoliageGeneration, bool> generationFoldoutStatuses = new Dictionary<FoliageGeneration, bool>();
		private Dictionary<FoliageGeneration, Dictionary<FoliageArchetype, bool>> generationArchetypeFoldoutStatuses = new Dictionary<FoliageGeneration, Dictionary<FoliageArchetype, bool>>();
		private int selectedTextureMaskIndex;
		private FoliageSpecies species;


		private void OnEnable()
		{
			if (labels == null)
				labels = new Labels();

			conformToMeshSurface = serializedObject.FindProperty(nameof(FoliageSpecies.ConformToMeshSurface));
			initialSeedDensity = serializedObject.FindProperty(nameof(FoliageSpecies.InitialSeedDensity));
			maxSeedTravelDistance = serializedObject.FindProperty(nameof(FoliageSpecies.MaxSeedTravelDistance));
			minChildren = serializedObject.FindProperty(nameof(FoliageSpecies.MinChildren));
			maxChildren = serializedObject.FindProperty(nameof(FoliageSpecies.MaxChildren));
			collisionRange = serializedObject.FindProperty(nameof(FoliageSpecies.CollisionRange));
			shadeRange = serializedObject.FindProperty(nameof(FoliageSpecies.ShadeRange));
			canGrowInShade = serializedObject.FindProperty(nameof(FoliageSpecies.CanGrowInShade));
			minScaleMultiplier = serializedObject.FindProperty(nameof(FoliageSpecies.MinScaleMultiplier));
			maxScaleMultiplier = serializedObject.FindProperty(nameof(FoliageSpecies.MaxScaleMultiplier));
			minSlopeAngle = serializedObject.FindProperty(nameof(FoliageSpecies.MinSlopeAngle));
			maxSlopeAngle = serializedObject.FindProperty(nameof(FoliageSpecies.MaxSlopeAngle));
			minAltitude = serializedObject.FindProperty(nameof(FoliageSpecies.MinAltitude));
			maxAltitude = serializedObject.FindProperty(nameof(FoliageSpecies.MaxAltitude));
			layerMode = serializedObject.FindProperty(nameof(FoliageSpecies.LayerMode));
			layerDensityCombineMode = serializedObject.FindProperty(nameof(FoliageSpecies.LayerDensityCombineMode));
			defaultLayerDensity = serializedObject.FindProperty(nameof(FoliageSpecies.DefaultLayerDensity));
			layerDensityRules = serializedObject.FindProperty(nameof(FoliageSpecies.LayerDensityRules));
			archetypeArray = serializedObject.FindProperty(nameof(FoliageSpecies.Archetypes));
			generationArray = serializedObject.FindProperty(nameof(FoliageSpecies.Generations));
		}

		public override void OnInspectorGUI()
		{
			species = target as FoliageSpecies;

			if (species == null)
				return;

			serializedObject.Update();

			DrawArchetypeList(archetypeArray);
			EditorGUILayout.Space();
			DrawOptions();
			EditorGUILayout.Space();
			DrawGenerations();
			EditorGUILayout.Space();
			DrawTerrainTextureMasks(species);

			if (GUI.changed)
				EditorUtility.SetDirty(species);

			serializedObject.ApplyModifiedProperties();
		}

		private void DrawOptions()
		{
			EditorGUILayout.BeginVertical("box");

			EditorGUILayout.LabelField("Options", EditorStyles.boldLabel);
			EditorGUILayout.Space();

			EditorGUI.indentLevel++;

			EditorGUILayout.PropertyField(conformToMeshSurface, labels.ConformToMeshSurface);
			EditorGUILayout.PropertyField(initialSeedDensity, labels.InitialSeedDensity);
			EditorGUILayout.PropertyField(maxSeedTravelDistance, labels.MaxSeedTravelDistance);
			EditorGUILayout.PropertyField(collisionRange, labels.CollisionRange);
			EditorGUILayout.PropertyField(shadeRange, labels.ShadeRange);
			EditorGUILayout.PropertyField(canGrowInShade, labels.CanGrowInShade);

			DrawMinMaxSliderInt(labels.ChildCount, minChildren, maxChildren, 0, 10);
			DrawMinMaxSliderFloat(labels.ScaleVariation, minScaleMultiplier, maxScaleMultiplier, 0.5f, 1.5f);
			DrawMinMaxSliderFloat(labels.SlopeAngle, minSlopeAngle, maxSlopeAngle, 0.0f, 90.0f);

			EditorGUILayout.Space();
			EditorGUILayout.LabelField(labels.Altitude);
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.PropertyField(minAltitude, GUIContent.none);
			EditorGUILayout.LabelField(" - ", GUILayout.Width(30));
			EditorGUILayout.PropertyField(maxAltitude, GUIContent.none);
			EditorGUILayout.EndHorizontal();

			EditorGUI.indentLevel--;
			EditorGUILayout.Space();
			EditorGUILayout.EndVertical();
		}

		private void DrawGenerations()
		{
			EditorGUILayout.BeginVertical("box");

			EditorGUILayout.LabelField("Generation Overrides", EditorStyles.boldLabel);
			EditorGUILayout.Space();

			int generationToDelete = -1;
			EditorGUI.indentLevel++;

			for (int i = 0; i < generationArray.arraySize; i++)
			{
				var generation = generationArray.GetArrayElementAtIndex(i);
				var isEnabled = generation.FindPropertyRelative(nameof(FoliageGeneration.IsEnabled));

				EditorGUILayout.BeginVertical("box");

				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.PropertyField(isEnabled, GUIContent.none, GUILayout.Width(30));

				bool previousGUIEnabled = GUI.enabled;
				GUI.enabled = isEnabled.boolValue;

				generation.isExpanded = EditorGUILayout.Foldout(generation.isExpanded && isEnabled.boolValue, "Generation " + i);

				GUI.enabled = previousGUIEnabled;

				Color previousColour = GUI.color;
				GUI.color = new Color(1.0f, 0.6f, 0.6f);

				if (GUILayout.Button("x", EditorStyles.miniButton, GUILayout.Width(18)))
					generationToDelete = i;


				GUI.color = previousColour;

				EditorGUILayout.EndHorizontal();

				if (generation.isExpanded && isEnabled.boolValue)
					DrawArchetypeList(generation.FindPropertyRelative(nameof(FoliageGeneration.OverrideArchetypes)));

				EditorGUILayout.EndVertical();

				EditorGUILayout.Space();
				EditorGUILayout.Space();
			}

			if (generationToDelete >= 0)
				generationArray.DeleteArrayElementAtIndex(generationToDelete);

			if (GUILayout.Button("Add New Generation Override"))
				generationArray.InsertArrayElementAtIndex(0);

			EditorGUI.indentLevel--;

			EditorGUILayout.EndVertical();
		}

		private void DrawTerrainTextureMasks(FoliageSpecies data)
		{
			EditorGUILayout.BeginVertical("box");

			EditorGUILayout.LabelField(labels.LayerDensityRules, EditorStyles.boldLabel);
			EditorGUILayout.Space();

			switch (data.LayerMode)
			{
				case TextureMaskMode.Texture:
					EditorGUILayout.HelpBox("Restrict foliage placement to a specific texture on the terrain", MessageType.Info);
					break;

				case TextureMaskMode.TextureIndex:
					EditorGUILayout.HelpBox("Restrict foliage placement to the index of a texture on the terrain", MessageType.Info);
					break;

#if UNITY_2018_3_OR_NEWER
				case TextureMaskMode.TerrainLayer:
					EditorGUILayout.HelpBox("Restrict foliage placement to a specific terrain layer", MessageType.Info);
					break;
#endif

				default:
					EditorGUILayout.HelpBox("Texture Mask Mode '" + data.LayerMode + "' is not implemented", MessageType.Error);
					break;
			}

			EditorGUILayout.PropertyField(layerMode, labels.MaskMode);
			EditorGUILayout.PropertyField(layerDensityCombineMode, labels.MaskDensityCombineMode);
			EditorGUILayout.Slider(defaultLayerDensity, 0f, 1f, labels.DefaultLayerDensity);

			EditorGUILayout.Space();
			EditorGUI.indentLevel++;

			EditorGUI.BeginChangeCheck();
			int indexToRemove = -1;

			for (int i = 0; i < layerDensityRules.arraySize; i++)
			{
				var ruleProperty = layerDensityRules.GetArrayElementAtIndex(i);

				EditorGUILayout.BeginHorizontal("box");
				EditorGUILayout.BeginVertical();

				switch (species.LayerMode)
				{
					case TextureMaskMode.Texture:
						DrawMaskTextureEntry(data, i);
						break;

					case TextureMaskMode.TextureIndex:
						DrawMaskSplatMapIndexEntry(data, i);
						break;

#if UNITY_2018_3_OR_NEWER
					case TextureMaskMode.TerrainLayer:
						DrawMaskTerrainLayerEntry(data, i);
						break;
#endif

					default:
						break;
				}

				EditorGUILayout.Slider(ruleProperty.FindPropertyRelative(nameof(TerrainLayerDensity.DensityMultiplier)), 0f, 1f, labels.LayerDensityMultiplier);
				EditorGUILayout.EndVertical();

				Color previousColour = GUI.color;
				GUI.color = new Color(1.0f, 0.6f, 0.6f);

				if (GUILayout.Button("x", EditorStyles.miniButton, GUILayout.Width(18)))
					indexToRemove = i;

				GUI.color = previousColour;

				EditorGUILayout.EndHorizontal();
			}

			if (indexToRemove >= 0)
				data.LayerDensityRules.RemoveAt(indexToRemove);

			if (GUILayout.Button("+"))
				data.LayerDensityRules.Add(new TerrainLayerDensity());

			EditorGUI.indentLevel--;
			EditorGUILayout.EndVertical();
		}

		private void DrawMaskTextureEntry(FoliageSpecies data, int index)
		{
			EditorGUILayout.BeginHorizontal();

			var maskTexture = data.LayerDensityRules[index].Texture;

			if (GUILayout.Button(maskTexture, GUILayout.Width(50), GUILayout.Height(50)))
			{
				int controlID = EditorGUIUtility.GetControlID(FocusType.Passive);
				EditorGUIUtility.ShowObjectPicker<Texture2D>(maskTexture, false, null, controlID);

				selectedTextureMaskIndex = index;
			}

			if (Event.current.commandName == "ObjectSelectorUpdated" && selectedTextureMaskIndex == index)
			{
				data.LayerDensityRules[index].Texture = EditorGUIUtility.GetObjectPickerObject() as Texture2D;
				Repaint();
			}

			EditorGUILayout.BeginVertical();

			EditorGUILayout.LabelField((maskTexture != null) ? maskTexture.name.ToFriendlyString() : "None", EditorStyles.boldLabel);
			EditorGUILayout.LabelField((maskTexture != null) ? AssetDatabase.GetAssetPath(maskTexture) : "<- Click to choose");

			EditorGUILayout.EndVertical();

			EditorGUILayout.EndHorizontal();
		}

		private void DrawMaskSplatMapIndexEntry(FoliageSpecies data, int index)
		{
			var entry = data.LayerDensityRules[index];
			entry.TextureIndex = EditorGUILayout.IntField(entry.TextureIndex);
		}

#if UNITY_2018_3_OR_NEWER
		private void DrawMaskTerrainLayerEntry(FoliageSpecies data, int index)
		{
			var entry = data.LayerDensityRules[index];
			entry.TerrainLayer = EditorGUILayout.ObjectField(entry.TerrainLayer, typeof(TerrainLayer), false) as TerrainLayer;
		}
#endif

		private void DrawMinMaxSliderFloat(GUIContent label, SerializedProperty minProperty, SerializedProperty maxProperty, float min, float max)
		{
			EditorGUILayout.Space();
			EditorGUILayout.LabelField(label);

			EditorGUILayout.BeginHorizontal();

			float minValue = minProperty.floatValue;
			float maxValue = maxProperty.floatValue;

			EditorGUILayout.MinMaxSlider(GUIContent.none, ref minValue, ref maxValue, min, max);

			minProperty.floatValue = minValue;
			maxProperty.floatValue = maxValue;

			EditorGUILayout.PropertyField(minProperty, GUIContent.none, GUILayout.Width(50));
			EditorGUILayout.PropertyField(maxProperty, GUIContent.none, GUILayout.Width(50));

			if (minProperty.floatValue < min)
				minProperty.floatValue = min;
			if (maxProperty.floatValue > max)
				maxProperty.floatValue = max;


			EditorGUILayout.EndHorizontal();
		}

		private void DrawMinMaxSliderInt(GUIContent label, SerializedProperty minProperty, SerializedProperty maxProperty, int min, int max)
		{
			EditorGUILayout.Space();
			EditorGUILayout.LabelField(label);

			EditorGUILayout.BeginHorizontal();

			float floatMin = minProperty.intValue;
			float floatMax = maxProperty.intValue;

			EditorGUILayout.MinMaxSlider(GUIContent.none, ref floatMin, ref floatMax, 0, 10);
			minProperty.intValue = Mathf.RoundToInt(floatMin);
			maxProperty.intValue = Mathf.RoundToInt(floatMax);

			EditorGUILayout.PropertyField(minProperty, GUIContent.none, GUILayout.Width(50));
			EditorGUILayout.PropertyField(maxProperty, GUIContent.none, GUILayout.Width(50));

			if (minProperty.intValue < min)
				minProperty.intValue = min;
			if (maxProperty.intValue > max)
				maxProperty.intValue = max;

			EditorGUILayout.EndHorizontal();
		}

		private void DrawArchetypeList(SerializedProperty archetypeArray)
		{
			EditorGUILayout.BeginVertical("box");

			#region Expand/Collapse Archetypes List

			EditorGUILayout.BeginHorizontal();

			EditorGUILayout.LabelField(labels.Archetypes, EditorStyles.boldLabel, GUILayout.Width(100));

			if (archetypeArray.arraySize > 0)
			{
				EditorGUILayout.Space();
				EditorGUILayout.Space();
				EditorGUILayout.Space();

				if (GUILayout.Button(labels.ExpandArchetypes, EditorStyles.miniButtonLeft))
				{
					for (int i = 0; i < archetypeArray.arraySize; i++)
					{
						var archetype = archetypeArray.GetArrayElementAtIndex(i);
						archetype.isExpanded = true;
					}
				}
				if (GUILayout.Button(labels.CollapseArchetypes, EditorStyles.miniButtonRight))
				{
					for (int i = 0; i < archetypeArray.arraySize; i++)
					{
						var archetype = archetypeArray.GetArrayElementAtIndex(i);
						archetype.isExpanded = false;
					}
				}
			}

			EditorGUILayout.EndHorizontal();
			EditorGUILayout.Space();

			#endregion

			EditorGUI.indentLevel++;

			int archetypeToDelete = -1;

			for (int i = 0; i < archetypeArray.arraySize; i++)
			{
				bool shouldDelete;
				DrawArchetype(archetypeArray.GetArrayElementAtIndex(i), out shouldDelete);

				if (shouldDelete)
					archetypeToDelete = i;
			}

			if (GUILayout.Button("+"))
				AddNewArchetype(archetypeArray);

			EditorGUI.indentLevel--;
			EditorGUILayout.EndVertical();


			if (archetypeToDelete >= 0)
				archetypeArray.DeleteArrayElementAtIndex(archetypeToDelete);

			if (GUI.changed)
				EditorUtility.SetDirty(target);
		}

		private void AddNewArchetype(SerializedProperty archetypeArray)
		{
			archetypeArray.arraySize++;

			// Intialise with defaults
			var newArchetype = archetypeArray.GetArrayElementAtIndex(archetypeArray.arraySize - 1);
			var prefab = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.Prefab));
			var placementMethod = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.PlacementMethod));
			var minimumScale = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.MinimumScale));
			var maximumScale = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.MaximumScale));
			var colourVariation = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.ColourVariation));
			var weight = newArchetype.FindPropertyRelative(nameof(FoliageArchetype.Weight));

			prefab.objectReferenceValue = null;
			placementMethod.enumValueIndex = (int)FoliagePlacementMethod.TerrainTree;
			minimumScale.floatValue = 0.8f;
			maximumScale.floatValue = 1.0f;
			colourVariation.floatValue = 0.4f;
			weight.floatValue = 1.0f;
		}

		private void DrawArchetype(SerializedProperty archetype, out bool shouldDelete)
		{
			shouldDelete = false;

			EditorGUILayout.BeginVertical("box");

			var prefabProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.Prefab));
			var prefab = prefabProp.objectReferenceValue as GameObject;

			string foldoutLabel = (archetype.isExpanded) ? "" : (prefab != null) ? prefab.name.ToFriendlyString() : "None";

			EditorGUILayout.BeginHorizontal();
			archetype.isExpanded = EditorGUILayout.Foldout(archetype.isExpanded, foldoutLabel);

			Color previousColour = GUI.color;
			GUI.color = new Color(1.0f, 0.6f, 0.6f);

			if (GUILayout.Button("x", EditorStyles.miniButton, GUILayout.Width(18)))
				shouldDelete = true;

			GUI.color = previousColour;

			EditorGUILayout.EndHorizontal();

			if (archetype.isExpanded)
			{
				var weightProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.Weight));
				var placementMethodProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.PlacementMethod));
				var gameObjectStaticProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.GameObjectStatic));
				var minimumScaleProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.MinimumScale));
				var maximumScaleProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.MaximumScale));
				var colourVariationProp = archetype.FindPropertyRelative(nameof(FoliageArchetype.ColourVariation));

				EditorGUILayout.PropertyField(prefabProp);

				float totalWeight = 0;
				foreach (var a in species.Archetypes)
					totalWeight += a.Weight;

				float normalizedWeight = weightProp.floatValue / totalWeight;
				EditorGUILayout.Slider(weightProp, 0f, 2f, new GUIContent(string.Format("Weight ({0:P0})", normalizedWeight), "How likely this archetype is to be used relative to the others"));

				EditorGUILayout.Space();
				EditorGUILayout.Space();

				EditorGUILayout.PropertyField(placementMethodProp, labels.Archetype_PlacementMode);

				if (placementMethodProp.enumValueIndex == (int)FoliagePlacementMethod.GameObject)
					EditorGUILayout.PropertyField(gameObjectStaticProp, labels.Archetype_GameObjectStatic);

				EditorGUILayout.Space();
				EditorGUILayout.Space();

				EditorGUILayout.LabelField(labels.Archetype_SizeByGeneration);
				EditorGUILayout.BeginHorizontal();

				float minimumScale = minimumScaleProp.floatValue;
				float maximumScale = maximumScaleProp.floatValue;
				EditorGUILayout.MinMaxSlider(ref minimumScale, ref maximumScale, 0.1f, 1.5f);
				minimumScale = EditorGUILayout.FloatField(minimumScale, GUILayout.Width(50));
				maximumScale = EditorGUILayout.FloatField(maximumScale, GUILayout.Width(50));

				minimumScaleProp.floatValue = minimumScale;
				maximumScaleProp.floatValue = maximumScale;
				EditorGUILayout.EndHorizontal();

				EditorGUILayout.Space();
				EditorGUILayout.LabelField(labels.Archetype_ColourVariation);
				EditorGUILayout.Slider(colourVariationProp, 0.0f, 1.0f, GUIContent.none);
			}

			EditorGUILayout.EndVertical();
		}
	}
}
