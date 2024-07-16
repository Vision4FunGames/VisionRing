using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Screenshot))]
public class EditorBtn : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Screenshot screenshot = (Screenshot)target;

        if (GUILayout.Button("Capture"))
        {
            screenshot.CapturePNG();
        }
    }
}

