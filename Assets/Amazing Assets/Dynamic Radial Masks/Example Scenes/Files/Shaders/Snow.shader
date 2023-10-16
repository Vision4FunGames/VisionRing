Shader "Amazing Assets/Dynamic Radial Masks/Example/Snow"
{
    Properties
    {
        _Color ("Base Color", Color) = (1,1,1,1)
        _BaseTex ("Base Map", 2D) = "white" {}
        _BaseGlossiness ("Base Smoothness", Range(0,1)) = 0.5
        _BaseMetallic ("Base Metallic", Range(0,1)) = 0.0
        [NoScaleOffset] _BaseNormal("Base Normal", 2D) = "bump" {}

        _SnowCover("Snow Cover", Range(-1, 1)) = 0.5
        _SnowColor ("Snow Color", Color) = (1,1,1,1)
        _SnowTex ("Snow Map", 2D) = "white" {}
        _SnowGlossiness ("Snow Smoothness", Range(0,1)) = 0.5
        _SnowMetallic ("Snow Metallic", Range(0,1)) = 0.0
        [NoScaleOffset] _SnowNormal("Snow Normal", 2D) = "bump" {}

        [Toggle(_SONAR_EFFECT_ON)] _RenderSonarEffect("Render Sonar Effect", Float) = 0
        [HDR] _SonarColor("Sonar Color", Color) = (0, 0, 0, 1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows addshadow

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        #include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Torus/DynamicRadialMasks_Torus_4_Advanced_Additive_ID1_Global.cginc"
		#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/HeightField/DynamicRadialMasks_HeightField_4_Advanced_Normalized_ID1_Global.cginc"

        #pragma shader_feature_local_fragment _SONAR_EFFECT_ON

         
        fixed4 _Color;
        sampler2D _BaseTex;
        sampler2D _BaseNormal;
        half _BaseGlossiness;
        half _BaseMetallic;


        float _SnowCover;
        fixed4 _SnowColor;
        sampler2D _SnowTex;
        sampler2D _SnowNormal;
        half _SnowGlossiness;
        half _SnowMetallic;

        float4 _SonarColor;
        

        struct Input
        {
            float2 uv_BaseTex;
            float2 uv_SnowTex;
            float3 worldPos;
            float3 worldNormal;
            INTERNAL_DATA
        };

        
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
           float mask = DynamicRadialMasks_HeightField_4_Advanced_Normalized_ID1_Global(IN.worldPos, 0);

            //Unpack normals
            float3 baseNormal = UnpackNormal(tex2D(_BaseNormal, IN.uv_BaseTex));
            float3 snowNormal = UnpackNormal(tex2D(_SnowNormal, IN.uv_SnowTex));

            //Snow cover
            float3 worldNormal = WorldNormalVector(IN, baseNormal);
            float snowCover = saturate(dot(float3(0, 1, 0), worldNormal) + _SnowCover);
            snowCover = pow(snowCover, 6);


            mask *= snowCover;


            //Normal            
            o.Normal = normalize(lerp(baseNormal, snowNormal, mask));


            //Albedo
            fixed4 base = tex2D (_BaseTex, IN.uv_BaseTex) * _Color;

            fixed4 snow = tex2D (_SnowTex, IN.uv_SnowTex) * _SnowColor;
            o.Albedo = lerp(base, snow, mask);


            //Metallic & Smoothness
            o.Metallic = lerp(_BaseMetallic, _SnowMetallic, mask);
            o.Smoothness = lerp(_BaseGlossiness, _SnowGlossiness, mask);


            //Emission
            #if defined(_SONAR_EFFECT_ON)
                o.Emission = _SonarColor.rgb * DynamicRadialMasks_Torus_4_Advanced_Additive_ID1_Global(IN.worldPos, 0); 
            #endif


            //Alpha
            o.Alpha = base.a;            
        }
        ENDCG
    }
    FallBack "Diffuse"
}
