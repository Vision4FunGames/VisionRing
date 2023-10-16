using UnityEngine;
using UnityEngine.UI;


namespace AmazingAssets.DynamicRadialMasks
{
    [ExecuteAlways]
    public class DRMGameObject : MonoBehaviour
    {
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


        void Start()
        {
            currentPhase = 0;
        }

        void Update()
        {
            currentPhase += Time.deltaTime * phaseSpeed;
        }

        public void SliderValueChanged()
        {
            radius = slider.value * 100f;
        }
    }
}