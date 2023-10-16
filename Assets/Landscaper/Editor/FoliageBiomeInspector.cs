using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Landscaper;
using UnityEditor;
using UnityEngine;

namespace LandscaperEditor
{
    [CustomEditor(typeof(FoliageBiome))]
    public sealed class FoliageBiomeInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            var data = target as FoliageBiome;

            if (data == null)
                return;

            EditorGUILayout.LabelField("Species & Weights");
            int indexToRemove = -1;

            for (int i = 0; i < data.Species.Count; i++)
            {
                SpeciesWeight species = data.Species[i];

                EditorGUILayout.BeginHorizontal("box");

                species.Weight = EditorGUILayout.FloatField(species.Weight);
                species.Species = EditorGUILayout.ObjectField(species.Species, typeof(FoliageSpecies), false) as FoliageSpecies;

                if (GUILayout.Button("x"))
                    indexToRemove = i;

                EditorGUILayout.EndHorizontal();
            }

            if (indexToRemove >= 0)
            {
                data.Species.RemoveAt(indexToRemove);
                EditorUtility.SetDirty(data);
            }

            if (GUILayout.Button("+"))
            {
                data.Species.Add(new SpeciesWeight());
                EditorUtility.SetDirty(data);
            }
        }
    }
}
