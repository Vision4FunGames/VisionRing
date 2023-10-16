using Landscaper;
using LandscaperEditor.Windows;
using System;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace LandscaperEditor
{
	[CustomEditor(typeof(GrassPlacement))]
	public sealed class GrassPlacementInspector : Editor
	{
		#region Properties

		private SerializedProperty spacing;
		private SerializedProperty gridSize;
		private SerializedProperty range;
		private SerializedProperty jitterStrength;
		private SerializedProperty density;
		private SerializedProperty grassTypes;
		private SerializedProperty staggerUpdatesOverMultipleFrames;
		private SerializedProperty maxCellUpdatesPerFrame;

		#endregion

		#region Labels

		private sealed class Labels
		{
			public GUIContent Spacing = new GUIContent("Spacing", "The distance between each grass object. The lower this value, the more grass is planted. This should be kept as high as possible to avoid spawning too many objects");
			public GUIContent GridSize = new GUIContent("Grid Size", "Grass instances are updated in a grid, allowing instances to be created/destroyed in chunks. Larger grid sizes result in longer, but less frequent updates");
			public GUIContent Range = new GUIContent("Range", "The maximum distance (in Unity units) the grass will be spawned at relative to this component. This should be kept as low as possible to avoid spawning too many objects");
			public GUIContent JitterStrength = new GUIContent("Jitter", "How much jitter to apply to the grass positions. Lower values will plant grass at more uniform intervals");
			public GUIContent Density = new GUIContent("Density", "How dense the grass should be");
			public GUIContent GrassTypes = new GUIContent("Grass Types");
			public GUIContent StaggerUpdatesOverMultipleFrames = new GUIContent("Stagger Updates", "If true, grid cell updates will happen over a number of frames. This is supposed to reduce frame hitching, but can sometimes do the opposite");
			public GUIContent MaxCellUpdatesPerFrame = new GUIContent("Cell Update Rate", "How many cells should be updated per frame");
			public GUIContent Advanced = new GUIContent("Advanced");
			public GUIContent Stats = new GUIContent("Stats", "Estimated instance counts are upper bounds and don't take constraints into account (terrain layer, slope angle, etc)");
		}

		#endregion

		private Labels labels;
		private ReorderableList grassTypeList;
		private GUIStyle infoLabelHeaderStyle;


		private void OnEnable()
		{
			labels = new Labels();

			spacing = serializedObject.FindProperty("Spacing");
			gridSize = serializedObject.FindProperty("GridSize");
			range = serializedObject.FindProperty("Range");
			jitterStrength = serializedObject.FindProperty("JitterStrength");
			density = serializedObject.FindProperty("Density");
			grassTypes = serializedObject.FindProperty("GrassTypes");
			staggerUpdatesOverMultipleFrames = serializedObject.FindProperty("StaggerUpdatesOverMultipleFrames");
			maxCellUpdatesPerFrame = serializedObject.FindProperty("MaxCellUpdatesPerFrame");

			grassTypeList = new ReorderableList(serializedObject, grassTypes)
			{
				drawHeaderCallback = DrawGrassTypesListHeader,
				drawElementCallback = DrawGrassType,
				elementHeightCallback = GetGrassTypeElementHeight
			};
		}

		public override void OnInspectorGUI()
		{
			if(infoLabelHeaderStyle == null)
			{
				infoLabelHeaderStyle = new GUIStyle(EditorStyles.whiteLabel)
				{
					fontStyle = FontStyle.Bold,
					alignment = TextAnchor.MiddleCenter
				};
			}

			serializedObject.Update();

			EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

			EditorGUILayout.PropertyField(spacing, labels.Spacing);
			EditorGUILayout.PropertyField(range, labels.Range);
			EditorGUILayout.Slider(density, 0f, 1f, labels.Density);

			EditorGUILayout.Space();
			EditorGUILayout.Space();

			// Show estimated instance counts
			EditorGUILayout.BeginVertical("box");
			float instancesPerGridCell = Mathf.Pow((gridSize.floatValue / spacing.floatValue), 2) * density.floatValue;
			int cellRange = Mathf.CeilToInt(range.floatValue / gridSize.floatValue);
			int gridCellCount = (int)Mathf.Pow(cellRange * 2 + 1, 2);
			float maximumInstances = gridCellCount * instancesPerGridCell;

			EditorGUILayout.LabelField(new GUIContent("Stats"), infoLabelHeaderStyle);
			EditorGUILayout.LabelField(new GUIContent($"Max instances (per cell): {instancesPerGridCell:N0}"));
			EditorGUILayout.LabelField(new GUIContent($"Grid Cells in range: {gridCellCount:N0}"));
			EditorGUILayout.LabelField(new GUIContent($"Max instances (total): {maximumInstances:N0}"));
			EditorGUILayout.EndVertical();

			if (maximumInstances > 75000)
				EditorGUILayout.HelpBox("The current settings will result in a large number of objects which could affect performance.\n\nYou may want to tweak the 'Spacing' and 'Range' settings to lower the total number of instances.", MessageType.Warning, true);

			EditorGUILayout.Space();
			EditorGUILayout.Space();


			grassTypeList.DoLayoutList();

			EditorGUILayout.Space();

			gridSize.isExpanded = EditorGUILayout.Foldout(gridSize.isExpanded, labels.Advanced);

			if (gridSize.isExpanded)
			{
				EditorGUI.indentLevel++;
				EditorGUILayout.PropertyField(gridSize, labels.GridSize);
			EditorGUILayout.Slider(jitterStrength, 0f, 1f, labels.JitterStrength);
				EditorGUILayout.PropertyField(staggerUpdatesOverMultipleFrames, labels.StaggerUpdatesOverMultipleFrames);

				EditorGUI.BeginDisabledGroup(!staggerUpdatesOverMultipleFrames.boolValue);
				EditorGUILayout.PropertyField(maxCellUpdatesPerFrame, labels.MaxCellUpdatesPerFrame);
				EditorGUI.EndDisabledGroup();
				EditorGUI.indentLevel--;
			}

			EditorGUI.EndDisabledGroup();

			serializedObject.ApplyModifiedProperties();
		}

		#region Grass Types Reorderable List

		private void DrawGrassTypesListHeader(Rect rect)
		{
			EditorGUI.LabelField(rect, labels.GrassTypes);
		}

		private float GetGrassTypeElementHeight(int index)
		{
			return EditorGUIUtility.singleLineHeight;
		}

		private void DrawGrassType(Rect rect, int index, bool isActive, bool isFocused)
		{
			var property = grassTypes.GetArrayElementAtIndex(index);
			var prefabProperty = property.FindPropertyRelative("Prefab");

			string label;
			Color previousColour = GUI.color;

			if (prefabProperty.objectReferenceValue != null)
				label = prefabProperty.objectReferenceValue.name;
			else
			{
				label = "Missing Prefab";
				GUI.color = Color.red;
			}

			Rect labelRect = rect;
			labelRect.width /= 2;

			Rect buttonRect = labelRect;
			buttonRect.x = labelRect.xMax;

			EditorGUI.LabelField(labelRect, new GUIContent(label));

			GUI.color = previousColour;

			if (GUI.Button(buttonRect, new GUIContent("Edit")))
				GrassTypeEditorWindow.OpenWindow(property);
		}

		#endregion
	}
}
