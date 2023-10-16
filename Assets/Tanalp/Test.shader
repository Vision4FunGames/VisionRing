Shader"Tan" {
    Properties {
        [HideInInspector] _Control ("Control (RGBA)", 2D) = "red" {}
        [HideInInspector] _Splat4 ("Layer 4 (A)", 2D) = "white" {}
        [HideInInspector] _Splat3 ("Layer 3 (A)", 2D) = "white" {}
        [HideInInspector] _Splat2 ("Layer 2 (B)", 2D) = "white" {}
        [HideInInspector] _Splat1 ("Layer 1 (G)", 2D) = "white" {}
        [HideInInspector] _Splat0 ("Layer 0 (R)", 2D) = "white" {}
        [HideInInspector] _Normal3 ("Normal 3 (A)", 2D) = "bump" {}
        [HideInInspector] _Normal2 ("Normal 2 (B)", 2D) = "bump" {}
        [HideInInspector] _Normal1 ("Normal 1 (G)", 2D) = "bump" {}
        [HideInInspector] _Normal0 ("Normal 0 (R)", 2D) = "bump" {}
        // used in fallback on old cards & base map
        [HideInInspector] _MainTex ("BaseMap (RGB)", 2D) = "white" {}
        [HideInInspector] _Color ("Main Color", Color) = (1,1,1,1)


		[HDR]_EdgeEmission("Edge Emission", Color) = (1,1,1,1)
		_DissolveNoise("Dissolve Noise", 2D) = "white" {}
		[Toggle]_InvertDissolve("Invert Dissolve", Float) = 0


    }



    CGINCLUDE
        #pragma surface surf Lambert vertex:SplatmapVert finalcolor:SplatmapFinalColor finalprepass:SplatmapFinalPrepass finalgbuffer:SplatmapFinalGBuffer noinstancing
        #pragma multi_compile_fog
//#include "TerrainSplatmapCommon.cginc"
#include "VisionTerrainSplatmapCommon.cginc"
#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/HeightField/DynamicRadialMasks_HeightField_1_Advanced_Normalized_ID1_Global.cginc"

		#pragma target 3.0


fixed4 _EdgeEmission;
sampler2D _DissolveNoise;
float _InvertDissolve;

void surf(Input IN, inout SurfaceOutput o)
{
    half4 splat_control;
    half weight;
    fixed4 mixedDiffuse;
    SplatmapMix(IN, splat_control, weight, mixedDiffuse, o.Normal);
    o.Albedo = mixedDiffuse.rgb;
    o.Alpha = weight;
    
    float noise = tex2D(_DissolveNoise, IN.uv_DissolveNoise).r;
    float mask = DynamicRadialMasks_HeightField_1_Advanced_Normalized_ID1_Global(IN.worldPos, noise);
    mask = _InvertDissolve ? mask : 1 - mask;

    clip(mask > 0.5 ? -1 : 1);
    
    o.Emission = _EdgeEmission * 3 * mask;

    
}

ENDCG

    Category
{
    Tags{
            "Queue" = "Geometry-99"
            "RenderType"="TransparentCutout"
}
        // TODO: Seems like "#pragma target 3.0 _TERRAIN_NORMAL_MAP" can't fallback correctly on less capable devices?
        // Use two sub-shaders to simulate different features for different targets and still fallback correctly.
        SubShader { // for sm3.0+ targets
CGPROGRAM
                #pragma target 3.0
                #pragma multi_compile __ _TERRAIN_NORMAL_MAP



		 


            ENDCG
        }

    }

Dependency"AddPassShader" = "Hidden/TerrainEngine/Splatmap/Diffuse-AddPass"
Dependency"BaseMapShader" = "Diffuse"
Dependency"Details0"      = "Hidden/TerrainEngine/Details/Vertexlit"
Dependency"Details1"      = "Hidden/TerrainEngine/Details/WavingDoublePass"
Dependency"Details2"      = "Hidden/TerrainEngine/Details/BillboardWavingDoublePass"
Dependency"Tree0"         = "Hidden/TerrainEngine/BillboardTree"

Fallback"Transparent"
}