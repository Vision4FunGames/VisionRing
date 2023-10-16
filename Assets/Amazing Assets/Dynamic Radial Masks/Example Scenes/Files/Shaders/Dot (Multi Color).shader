Shader "Amazing Assets/Dynamic Radial Masks/Example/Dot (Multi Color)"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0

		
        [HDR]_MaskColor1("Mask Color #1", color) = (1, 1, 1, 1)
        [HDR]_MaskColor2("Mask Color #2", color) = (1, 1, 1, 1)
        [HDR]_MaskColor3("Mask Color #3", color) = (1, 1, 1, 1)
		_NoiseTex ("Noise", 2D) = "black" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0


		#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Dot/DynamicRadialMasks_Dot_8_Advanced_Additive_ID1_Local.cginc"
        #include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Dot/DynamicRadialMasks_Dot_8_Advanced_Additive_ID2_Local.cginc"
        #include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Dot/DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local.cginc"
         


        sampler2D _MainTex;
		half _Glossiness; 
        half _Metallic;
        fixed4 _Color;

		fixed4 _MaskColor1;
        fixed4 _MaskColor2;
        fixed4 _MaskColor3;
		sampler2D _NoiseTex;


        struct Input
        {
            float2 uv_MainTex;
			float2 uv_NoiseTex;
			float3 worldPos;
        };
		
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float noise = tex2D(_NoiseTex, IN.uv_NoiseTex).r;
			float mask1 = DynamicRadialMasks_Dot_8_Advanced_Additive_ID1_Local(IN.worldPos, noise);
            float mask2 = DynamicRadialMasks_Dot_8_Advanced_Additive_ID2_Local(IN.worldPos, noise);
            float mask3 = DynamicRadialMasks_Dot_8_Advanced_Additive_ID3_Local(IN.worldPos, noise);

            float maskSum = saturate(mask1 + mask2 + mask3);
            fixed3 maskColorSum = saturate(_MaskColor1 * mask1 + _MaskColor2 * mask2 + _MaskColor3 * mask3);



            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;

            o.Albedo = lerp(c.rgb, maskColorSum, maskSum);
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = 1;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
