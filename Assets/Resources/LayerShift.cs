using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class LayerShift : MonoBehaviour
{
    public string layerPath2 = "Layers";
    public string texturePath2 = "Textures";
    public Terrain terrain;
    private WaitForSeconds waitTime;
    public float swapInterval = 1.0f;
    private Texture2D[] textures;
    private Dictionary<string, List<Texture2D>> textureDict = new Dictionary<string, List<Texture2D>>();

    private int slider = 0;

    void Start()
    {

        // Get the terrain's name
        string terrainName = terrain.name;

        // Load all layers and textures from the specified paths
        TerrainLayer[] layers = Resources.LoadAll<TerrainLayer>(layerPath2);
        textures = Resources.LoadAll<Texture2D>(texturePath2);

        // Create dictionaries to store layers and textures by name

        foreach (Texture2D tex in textures)
        {
            textureDict.TryGetValue(tex.name.Split("#")[0], out List<Texture2D> list);
            if (list == null)
                list = new List<Texture2D>();
            list.Add(tex);

            if (textureDict.ContainsKey(tex.name.Split("#")[0]))
            {
                textureDict[tex.name.Split("#")[0]] = list;
            }
            else
            {
                textureDict.Add(tex.name.Split("#")[0], list);
            }

        }

        waitTime = new WaitForSeconds(swapInterval);

        // Start the coroutine to swap textures
        StartCoroutine(SwapTexturesRoutine());


        //// Check if there is a layer with the same name as the terrain
        //if (layerDict.ContainsKey(terrainName))
        //{
        //    // Assign the layer to the terrain
        //    terrain.terrainData.terrainLayers = new TerrainLayer[] { layerDict[terrainName] };
        //}

        //// Check if there is a texture with the same name as the terrain
        //if (textureDict.ContainsKey(terrainName))
        //{
        //    // Assign the texture to the terrain's material
        //    terrain.materialTemplate.SetTexture("_BaseMap", textureDict[terrainName]);
        //}
    }

    //20

    private IEnumerator SwapTexturesRoutine()
    {


        int index = 0;
        while (true)
        {
            foreach (TerrainLayer lay in terrain.terrainData.terrainLayers)
            {


                List<Texture2D> list = new List<Texture2D>();
                textureDict.TryGetValue(lay.name, out list);

                //int ratio = 20 / list.Count;

                lay.diffuseTexture = list[index % list.Count];
            }

            //List<Texture2D> list = new List<Texture2D>();
            //textureDict.TryGetValue(terrain.terrainData.terrainLayers[0].name, out list);
            //terrain.terrainData.terrainLayers[0].diffuseTexture = list[index % list.Count];
            index++;

            yield return waitTime;

        }
    }

    void OnApplicationQuit()
    {
        //int index = 0;
        //foreach (TerrainLayer layer in terrain.terrainData.terrainLayers)
        //{
        //    layer.diffuseTexture = textures[index++];

        //}

    }

    [CustomEditor(typeof(LayerShift))] // Replace 'MyComponent' with the name of your script.
    public class MyComponentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            LayerShift myComponent = (LayerShift)target;

            // Draw the default inspector.
            DrawDefaultInspector();

            // Add a slider for a specific variable.
            int newVal = EditorGUILayout.IntSlider("My Float Value", myComponent.slider, 0, 19);

            if (newVal != myComponent.slider)
            {
                myComponent.slider = newVal;

                // You can call a function or perform any other action here.
            }
        }
    
    }

    public void test(int val)
    {
 

            TerrainLayer lay = terrain.terrainData.terrainLayers[0];
            List<Texture2D> list = new List<Texture2D>();
            textureDict.TryGetValue(lay.name, out list);

            //int ratio = 20 / list.Count;

            lay.diffuseTexture = list[val];
       
    }
}
