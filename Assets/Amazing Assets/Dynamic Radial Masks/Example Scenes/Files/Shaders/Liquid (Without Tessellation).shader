Shader "Amazing Assets/Dynamic Radial Masks/Example/Liquid (Without Tessellation)"
{
    Properties
    {
        _Color ("Base Color", Color) = (1,1,1,1)  
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        
        _NormalStrength("Normal Strength", float) = 0.01
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "DisableBatching"="True" }
        LOD 200
        Cull Off

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows
        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        
		#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Torus/DynamicRadialMasks_Torus_64_Advanced_Additive_ID1_Local.cginc"
                 

		sampler2D _MainTex;
        fixed4 _Color;
        half _Glossiness;
        half _Metallic; 
        
        float _NormalStrength;



        #ifdef UNITY_PASS_SHADOWCASTER
			#undef INTERNAL_DATA
			#undef WorldReflectionVector
			#undef WorldNormalVector
			#define INTERNAL_DATA half3 internalSurfaceTtoW0; half3 internalSurfaceTtoW1; half3 internalSurfaceTtoW2;
			#define WorldReflectionVector(data,normal) reflect (data.worldRefl, half3(dot(data.internalSurfaceTtoW0,normal), dot(data.internalSurfaceTtoW1,normal), dot(data.internalSurfaceTtoW2,normal)))
			#define WorldNormalVector(data,normal) half3(dot(data.internalSurfaceTtoW0,normal), dot(data.internalSurfaceTtoW1,normal), dot(data.internalSurfaceTtoW2,normal))
		#endif

        struct Input
        {
			float2 uv_MainTex;
            float3 worldPos;
            float3 worldNormal;
            INTERNAL_DATA
        };

        inline half3 SafeNormalize(half3 inVec)
        {
            half dp3 = max(0.001f, dot(inVec, inVec));
            return inVec * rsqrt(dp3);
        }


        float3 PerturbNormal( float3 surf_pos, float3 surf_norm, float height, float scale )
		{
			// "Bump Mapping Unparametrized Surfaces on the GPU" by Morten S. Mikkelsen
			float3 vSigmaS = ddx( surf_pos );
			float3 vSigmaT = ddy( surf_pos );
			float3 vN = surf_norm;
			float3 vR1 = cross( vSigmaT , vN );
			float3 vR2 = cross( vN , vSigmaS );
			float fDet = dot( vSigmaS , vR1 );
			float dBs = ddx( height );
			float dBt = ddy( height );
			float3 vSurfGrad = scale * 0.05 * sign( fDet ) * ( dBs * vR1 + dBt * vR2 );
			return SafeNormalize ( abs( fDet ) * vN - vSurfGrad );
		}

        float3 NormalFromHeight(Input IN, float height, float normalStrength)
        {
            float3 worldNormal = WorldNormalVector(IN, float3( 0, 0, 1 ) );
            float3 worldTangent = WorldNormalVector(IN, float3( 1, 0, 0 ) );
			float3 worldBitangent = WorldNormalVector(IN, float3( 0, 1, 0 ) );
            float3x3 worldToTangent = float3x3( worldTangent, worldBitangent, worldNormal );

            float3 perturbNormal = PerturbNormal(IN.worldPos, worldNormal, height,  normalStrength);

            return mul(worldToTangent, perturbNormal);
        }

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color; 
            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a; 

            float mask = DynamicRadialMasks_Torus_64_Advanced_Additive_ID1_Local(IN.worldPos, 0);
                        
            o.Normal = NormalFromHeight(IN, mask,_NormalStrength);

        }
        ENDCG
    }
    FallBack "Diffuse"
}
