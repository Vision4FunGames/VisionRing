using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace LandscaperEditor.Windows
{
	public sealed class GrassTypeEditorWindow : EditorWindow
	{
		#region Labels

		private sealed class Labels
		{
			public GUIContent Prefab = new GUIContent("Prefab", "The GameObject to spawn");
			public GUIContent Weight = new GUIContent("Weight", "How likely this grass type is to be spawned relative to every other grass type");
			public GUIContent UseRandomRotation = new GUIContent("Random Rotation?", "Should the grass have a random rotation around the up-axis?");
			public GUIContent Scale = new GUIContent("Scale", "Range of random scale values");
			public GUIContent AlignToSurfaceNormal = new GUIContent("Align to Surface?", "Should the grass rotate to match the surface they're planted on?");
			public GUIContent SlopeAngle = new GUIContent("Slope Angle", "Range of slope angles (in degrees) that the grass is allowed to be planted on");
			public GUIContent TerrainLayerStrengthThreshold = new GUIContent("Layer Threshold", "Any layer in the mask must have at least this much weight for the grass to be planted on it");
			public GUIContent TerrainLayerMask = new GUIContent("Layer Mask", "Which terrain layers the grass can be planted on");
		}

		#endregion

		private Labels labels;
		private SerializedProperty grassType;
		private ReorderableList terrainLayersList;
		private GUIStyle propertiesStyle;


		private void OnEnable()
		{
			labels = new Labels();
			propertiesStyle = new GUIStyle();
			propertiesStyle.margin = new RectOffset(10, 10, 20, 10);

			minSize = new Vector2(390, 300);
			maxSize = new Vector2(600, 1000);
		}

		private void OnGUI()
		{
			if (terrainLayersList == null)
			{
				terrainLayersList = new ReorderableList(grassType.serializedObject, grassType.FindPropertyRelative("TerrainLayerMask"), false, true, true, true);
				terrainLayersList.drawHeaderCallback = DrawLayerMaskHeader;
				terrainLayersList.drawElementCallback = DrawLayerMaskElement;
			}

			grassType.serializedObject.Update();

			var prefabProperty = grassType.FindPropertyRelative("Prefab");
			var weightProperty = grassType.FindPropertyRelative("Weight");
			var useRandomRotationProperty = grassType.FindPropertyRelative("UseRandomRotation");
			var minScaleProperty = grassType.FindPropertyRelative("MinScale");
			var maxScaleProperty = grassType.FindPropertyRelative("MaxScale");
			var alignToSurfaceNormalProperty = grassType.FindPropertyRelative("AlignToSurfaceNormal");
			var minSlopeAngleProperty = grassType.FindPropertyRelative("MinSlopeAngle");
			var maxSlopeAngleProperty = grassType.FindPropertyRelative("MaxSlopeAngle");
			var terrainLayerStrengthThresholdProperty = grassType.FindPropertyRelative("TerrainLayerStrengthThreshold");
			var terrainLayerMaskProperty = grassType.FindPropertyRelative("TerrainLayerMask");

			EditorGUILayout.BeginVertical(propertiesStyle);

			EditorGUILayout.PropertyField(prefabProperty, labels.Prefab);
			EditorGUILayout.Slider(weightProperty, 0f, 1f, labels.Weight);
			EditorGUILayout.PropertyField(useRandomRotationProperty, labels.UseRandomRotation);
			EditorGUILayout.PropertyField(alignToSurfaceNormalProperty, labels.AlignToSurfaceNormal);
			DrawMinMaxSlider(labels.Scale, minScaleProperty, maxScaleProperty, 0.1f, 10f);
			DrawMinMaxSlider(labels.SlopeAngle, minSlopeAngleProperty, maxSlopeAngleProperty, 0f, 90f);
			EditorGUILayout.Slider(terrainLayerStrengthThresholdProperty, 0f, 1f, labels.TerrainLayerStrengthThreshold);

			EditorGUILayout.Space();
			EditorGUILayout.Space();
			EditorGUILayout.Space();

			terrainLayersList.DoLayoutList();

			EditorGUILayout.EndVertical();

			grassType.serializedObject.ApplyModifiedProperties();
		}

		private void DrawLayerMaskHeader(Rect rect)
		{
			EditorGUI.LabelField(rect, new GUIContent("Terrain Layers"));
		}

		private void DrawLayerMaskElement(Rect rect, int index, bool isActive, bool isFocused)
		{
			var property = grassType.FindPropertyRelative("TerrainLayerMask").GetArrayElementAtIndex(index);

			EditorGUI.PropertyField(rect, property, new GUIContent("Layer"));
		}

		private void DrawMinMaxSlider(GUIContent label, SerializedProperty minProperty, SerializedProperty maxProperty, float minLimit, float maxLimit)
		{
			float min = minProperty.floatValue;
			float max = maxProperty.floatValue;

			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.PrefixLabel(label);
			EditorGUILayout.PropertyField(minProperty, GUIContent.none, GUILayout.Width(50));
			EditorGUILayout.Space();
			EditorGUILayout.MinMaxSlider(GUIContent.none, ref min, ref max, minLimit, maxLimit, GUILayout.MinWidth(60), GUILayout.MaxWidth(1000));
			EditorGUILayout.Space();
			EditorGUILayout.PropertyField(maxProperty, GUIContent.none, GUILayout.Width(50));
			EditorGUILayout.EndHorizontal();

			minProperty.floatValue = Mathf.Max(min, minLimit);
			maxProperty.floatValue = Mathf.Min(max, maxLimit);
		}

		#region Static Methods

		public static void OpenWindow(SerializedProperty grassType)
		{
			var window = GetWindow<GrassTypeEditorWindow>(true, "Grass Settings", true);
			window.grassType = grassType;

			window.Show();
		}

		#endregion
	}
}
