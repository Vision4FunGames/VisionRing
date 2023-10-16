using Landscaper;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LandscaperEditor
{
	[CustomEditor(typeof(FoliageArea))]
	[CanEditMultipleObjects]
	public sealed class FoliagePlacementAreaInspector : UnityEditor.Editor
	{
		#region Constants

		private sealed class Labels
		{
			public static readonly GUIContent Seed = new GUIContent("Seed", "The seed passed to the random number generator. You can change this value to produce a different foliage arrangement using the same settings");
			public static readonly GUIContent Root = new GUIContent("Root", "The object that foliage GameObjects will be parented under. If left blank, a new object will be created");
			public static readonly GUIContent Biome = new GUIContent("Biome", "The biome settings to use");
			public static readonly GUIContent GenerationsCount = new GUIContent("Generations", "The number of iterations of the foliage generation. If set to 1, only the initial seeds will be planted. The higher the number, the more foliage will be placed (increasing exponentially)");
			public static readonly GUIContent Layer = new GUIContent("Foliage Layer", "The layer to place new foliage instances on");
			public static readonly GUIContent PlacementMask = new GUIContent("Place Foliage On", "A layer mask determining on what objects foliage can be placed. Foliage will not be placed on any object NOT in these layers (but raycasts may pass through to valid terrain beneath)");
			public static readonly GUIContent ExcludedLayers = new GUIContent("Excluded Layers", "Foliage will not be placed on an object in any of these layers and raycasts will be blocked, preventing foliage from being placed on anything below either");
			public static readonly GUIContent MaxTileSize = new GUIContent("Max Tile Size", "If the Foliage Area (green box) is larger than this size, it will be split into multiple smaller volumes (yellow boxes) to improve generation speed");
			public static readonly GUIContent DensityScale = new GUIContent("Density Scale", "Controls the global density scale for foliage placed by this Foliage Area");
			public static readonly GUIContent LimitMode = new GUIContent("Limit Mode", "Defines how to handle a very large number of terrain tree instances. Any terrain trees placed beyond the limit (>65,535 per-terrain) will be permanently rendered as a billboard due to a limitation within Unity. NOTE: This does not apply to foliage placed as GameObjects");
			public static readonly GUIContent Simulating = new GUIContent("Simulating...", "This foliage area is currently simulating and must complete before it can be simulated again");
			public static readonly GUIContent Simulate = new GUIContent("Simulate", "Simulate this foliage area and instantiate the resulting foliage");
			public static readonly GUIContent SimulateAll = new GUIContent("Simulate All", "Simulates all foliage areas in the scene");
		}

		#endregion

		private bool previousRunInBackground;

		private SerializedProperty seedProperty;
		private SerializedProperty rootProperty;
		private SerializedProperty biomeProperty;
		private SerializedProperty generationsCountProperty;
		private SerializedProperty layerProperty;
		private SerializedProperty placementMaskProperty;
		private SerializedProperty excludedLayersProperty;
		private SerializedProperty maxTileSizeProperty;
		private SerializedProperty densityScaleProperty;
		private SerializedProperty limitModeProperty;


		private void OnEnable()
		{
			seedProperty = serializedObject.FindProperty(nameof(FoliageArea.Seed));
			rootProperty = serializedObject.FindProperty(nameof(FoliageArea.Root));
			biomeProperty = serializedObject.FindProperty(nameof(FoliageArea.Biome));
			generationsCountProperty = serializedObject.FindProperty(nameof(FoliageArea.GenerationsCount));
			layerProperty = serializedObject.FindProperty(nameof(FoliageArea.Layer));
			placementMaskProperty = serializedObject.FindProperty(nameof(FoliageArea.PlacementMask));
			excludedLayersProperty = serializedObject.FindProperty(nameof(FoliageArea.ExcludedLayers));
			maxTileSizeProperty = serializedObject.FindProperty(nameof(FoliageArea.MaxTileSize));
			densityScaleProperty = serializedObject.FindProperty(nameof(FoliageArea.DensityScale));
			limitModeProperty = serializedObject.FindProperty(nameof(FoliageArea.LimitMode));

			Undo.undoRedoPerformed += OnUndoRedo;
		}

		private void OnDisable()
		{
			Undo.undoRedoPerformed -= OnUndoRedo;
		}

		private void OnUndoRedo()
		{
			Repaint();
		}

		public override void OnInspectorGUI()
		{
			bool prevEnabled = GUI.enabled;
			var data = target as FoliageArea;

			if (data == null)
				return;

			EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
			EditorGUILayout.Space();

			EditorGUILayout.PropertyField(seedProperty, Labels.Seed);
			EditorGUILayout.PropertyField(rootProperty, Labels.Root);

			EditorGUILayout.Space();

			EditorGUILayout.PropertyField(biomeProperty, Labels.Biome);
			EditorGUILayout.PropertyField(generationsCountProperty, Labels.GenerationsCount);

			int currentLayer = layerProperty.intValue;
			int newLayer = EditorGUILayout.LayerField(Labels.Layer, currentLayer);
			if (newLayer != currentLayer)
				layerProperty.intValue = newLayer;

			EditorGUILayout.PropertyField(placementMaskProperty, Labels.PlacementMask);
			EditorGUILayout.PropertyField(excludedLayersProperty, Labels.ExcludedLayers);
			EditorGUILayout.Slider(maxTileSizeProperty, 100, 1000, Labels.MaxTileSize);
			EditorGUILayout.Slider(densityScaleProperty, 0.01f, 2f, Labels.DensityScale);
			EditorGUILayout.PropertyField(limitModeProperty, Labels.LimitMode);
			DrawLimitModeMessage();
			EditorGUILayout.EndVertical();

			EditorGUILayout.Space();

			EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("Actions", EditorStyles.boldLabel);
			EditorGUILayout.Space();
			EditorGUILayout.LabelField("Fit Bounds to:");

			EditorGUILayout.BeginHorizontal();

			if (GUILayout.Button("All Geometry", EditorStyles.miniButtonLeft))
			{
				Undo.RecordObject(data.transform, "Fit to Geometry");
				data.FitToGeometry();
			}
			if (GUILayout.Button("Terrain", EditorStyles.miniButtonMid))
			{
				Undo.RecordObject(data.transform, "Fit to Terrain");
				data.FitToTerrain();
			}

			prevEnabled = GUI.enabled;
			GUI.enabled = Selection.gameObjects.Length > 0;

			if (GUILayout.Button("Selection", EditorStyles.miniButtonRight))
			{
				Undo.RecordObject(data.transform, "Fit to Selection");
				data.FitToSelection();
			}

			GUI.enabled = prevEnabled;

			EditorGUILayout.EndHorizontal();

			EditorGUILayout.Space();
			EditorGUILayout.Space();

			if (data.Biome != null)
			{
				int estimatedInstances, estimatedInstancesMax;
				data.Biome.GetInstanceCountEstimate(data.Seed, data.Volume, data.GenerationsCount, data, out estimatedInstances, out estimatedInstancesMax);

				if (estimatedInstances > 10000000)
					EditorGUILayout.HelpBox("That's a lot of foliage instances! Simulation could take a *very* long time.", MessageType.Error, true);
				else if (estimatedInstances > 1000000)
					EditorGUILayout.HelpBox("Simulation time increases exponentially with the number of foliage instances placed.\n\nIt's recommended that you test your settings with a smaller area or lower generation count before doing a 'final build' if you have a lot of foliage instances as this may take a long time to simulate.", MessageType.Warning, true);

				EditorGUILayout.Space();
				EditorGUILayout.Space();

				EditorGUILayout.LabelField(string.Format("Estimated instance count: ~{0:N0} (Max: {1:N0})", estimatedInstances, estimatedInstancesMax));
			}

			if (data.IsSimulating || data.InstanceCount > 0)
			{
				GUIContent dummy = new GUIContent("");
				var rect = GUILayoutUtility.GetRect(dummy, EditorStyles.boldLabel);
				string progressText = (data.PercentageComplete == 1.0f || !data.IsSimulating) ? "Done!" : string.Format("{0:N0}%", (data.PercentageComplete * 100));

				EditorGUI.ProgressBar(rect, data.PercentageComplete, progressText);
			}

			prevEnabled = GUI.enabled;
			GUI.enabled = !data.IsSimulating && data.Biome != null;

			if (GUILayout.Button(data.IsSimulating ? Labels.Simulating : Labels.Simulate))
			{
				previousRunInBackground = Application.runInBackground;
				Application.runInBackground = true;
				data.OnGenerationComplete += OnSimulationComplete;

				EditorCoroutine.Start(data.SimulationCoroutine(true));
			}

			var allFoliageAreas = FindObjectsOfType<FoliageArea>();
			bool isAnyFoliageAreaSimulating = allFoliageAreas.Any(x => x.IsSimulating);
			if (GUILayout.Button(isAnyFoliageAreaSimulating ? Labels.Simulating : Labels.SimulateAll))
			{
				previousRunInBackground = Application.runInBackground;
				Application.runInBackground = true;

				foreach (var area in allFoliageAreas)
				{
					area.OnGenerationComplete += OnSimulationComplete;

					area.Clear();
					EditorCoroutine.Start(area.SimulationCoroutine(true));
				}
			}

			if (GUILayout.Button("Clear"))
				data.Clear();

			EditorGUILayout.EndVertical();

			EditorGUILayout.Space();

			// Generation Statistics
			EditorGUILayout.BeginVertical("box");
			EditorGUI.BeginDisabledGroup(data.InstanceCount == 0);
			EditorGUILayout.LabelField("Statistics", EditorStyles.boldLabel);
			EditorGUILayout.Space();

			if (data.InstanceCount > 0)
			{
				ReadOnlyField("Foliage Instances", data.InstanceCount, "{0:N0}");
				ReadOnlyField("Generation Time", data.GenerationTime, "{0:0.00} seconds");

				EditorGUILayout.Space();

				if (data.InstancesAffectedByTreeLimit > 0)
				{
					EditorGUILayout.BeginVertical("box");
					EditorGUILayout.HelpBox(string.Format("The terrain tree instance limit of {0:N0} was hit on one or more terrains", LandscaperConstants.TerrainTreeCap), MessageType.Warning, true);
					ReadOnlyField("Affected Instances", data.InstancesAffectedByTreeLimit, "{0:N0}");

					EditorGUILayout.LabelField(data.TerrainsAffectedByTreeLimit.Count + " Terrain(s) affected by terrain tree instance limit:", EditorStyles.boldLabel);
					EditorGUI.indentLevel++;

					foreach (var terrain in data.TerrainsAffectedByTreeLimit)
						EditorGUILayout.LabelField(terrain.name);

					EditorGUI.indentLevel--;
					EditorGUILayout.EndVertical();
				}
			}

			EditorGUI.EndDisabledGroup();
			EditorGUILayout.EndVertical();

			serializedObject.ApplyModifiedProperties();
		}

		private void OnSimulationComplete()
		{
			var data = target as FoliageArea;

			Application.runInBackground = previousRunInBackground;

			if (data != null)
				data.OnGenerationComplete -= OnSimulationComplete;
		}

		private void DrawLimitModeMessage()
		{
			var data = target as FoliageArea;
			string messageText = "";
			MessageType messageType = MessageType.None;

			switch (data.LimitMode)
			{
				case TerrainTreeLimitMode.Limit:
					messageText = string.Format("The number of terrain trees (per-terrain) will be limited to {0:N0}. See Limit Mode for more options", LandscaperConstants.TerrainTreeCap);
					messageType = MessageType.Warning;
					break;

				case TerrainTreeLimitMode.Replace:
					messageText = string.Format("Any terrain trees placed beyond {0:N0} (per-terrain) will be replaced with GameObjects. NOTE: Placing large quantities of trees as GameObjects can take a very long time. See Limit Mode for more options", LandscaperConstants.TerrainTreeCap);
					messageType = MessageType.Info;
					break;

				case TerrainTreeLimitMode.Ignore:
				default:
					messageText = string.Format("Any terrain trees placed beyond {0:N0} (per-terrain) will not handle LOD properly. See Limit Mode for more options", LandscaperConstants.TerrainTreeCap);
					messageType = MessageType.Error;
					break;
			}

			EditorGUILayout.HelpBox(messageText, messageType, true);
		}

		private void ReadOnlyField(string label, object obj, string format = null, string tooltip = null)
		{
			label = label + ":";
			EditorGUILayout.BeginHorizontal();

			GUIContent labelContent = (string.IsNullOrEmpty(tooltip) ? new GUIContent(label) : new GUIContent(label, tooltip));
			GUIStyle labelStyle = EditorStyles.boldLabel;
			EditorGUILayout.LabelField(labelContent, labelStyle, GUILayout.Width(labelStyle.CalcSize(labelContent).x));

			string objString = (format == null) ? obj.ToString() : string.Format(format, obj);
			EditorGUILayout.LabelField(objString);

			EditorGUILayout.EndHorizontal();
		}
	}
}
