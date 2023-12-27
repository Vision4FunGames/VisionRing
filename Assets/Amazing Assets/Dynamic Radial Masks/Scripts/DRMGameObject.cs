using UnityEngine;
using UnityEngine.UI;


namespace AmazingAssets.DynamicRadialMasks
{
    [ExecuteAlways]
    public class DRMGameObject : MonoBehaviour
    {
        private DrmEnemyChange _drmEnemyChange;
         public bool increaseEnes;
        [HideInInspector] public float radius = 5;
        [HideInInspector] public float intensity = 1;
        [HideInInspector] public float noiseStrength = 0;
        [HideInInspector] [Min(0f)] public float edgeSize = 1;
        [HideInInspector] public int ringCount = 3;
        [HideInInspector] public float frequency = 10;
        [HideInInspector] public float phaseSpeed = 2;
        [HideInInspector] public float currentPhase = 0;
        [HideInInspector] [Min(0.001f)] public float smooth = 1;
        public Slider slider;
    
#if UNITY_EDITOR
        [HideInInspector] public bool displayAllProperties = true;
        [HideInInspector] public DynamicRadialMasks.Enum.MaskShape maskShape;
#endif
        public TerrainCollider ter1, ter2;
        public bool increase,decrease;
        
        void Start()
        {
            _drmEnemyChange = GetComponent<DrmEnemyChange>();
            currentPhase = 0;
        }
        void Update()
         {
             currentPhase += Time.deltaTime * phaseSpeed;
        //     
        //     if (increase)
        //     {
        //         radius += Time.deltaTime * phaseSpeed;
        //         if (radius >=100)
        //         {
        //             radius = 100;
        //             increase = false;
        //         }
        //     }
        //     if (decrease)
        //     {
        //         radius -= Time.deltaTime * phaseSpeed;
        //         if ( radius <= 0)
        //         {
        //             radius = 0;
        //             decrease = false;
        //         }
        //     }
        }

        public void SliderValueChanged()
        {
            if (radius == 100)
            {

                transform.GetChild(0).GetComponent<FogScale>().StartScale();
                decrease = true;
                increaseEnes = false;
                ter1.enabled = true;
                ter2.enabled = false;
            }

            if (radius!=100)
            {
                transform.GetChild(0).GetComponent<FogScale>().StartScale();
                increase = true;
                increaseEnes = true;
                ter1.enabled = false;
                ter2.enabled = true;
            }
        }
    }
}