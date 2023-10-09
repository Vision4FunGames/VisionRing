// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Kaima/Dissolve/ToPoint"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_MainTex1 ("Texture", 2D) = "white" {}
		_NoiseTex("Noise", 2D) = "white" {}
		_Threshold("Threshold", Range(0.0, 1.0)) = 0.5
		_EdgeLength("Edge Length", Range(0.0, 0.2)) = 0.1
		_RampTex("Ramp", 2D) = "white" {}
		_StartPoint("Start Point", Vector) = (0, 0, 0, 0)
		_MaxDistance("Max Distance", Float) = 0
		_DistanceEffect("Distance Effect", Range(0.0, 1.0)) = 0.5
	}
	SubShader
	{
		Tags { "Queue"="Geometry" "RenderType"="Opaque" }

		Pass
		{
			Tags {"LightMode" = "ForwardBase"}
			Cull Off 

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			#include "Lighting.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uvMainTex : TEXCOORD0;
				float2 uvNoiseTex : TEXCOORD1;
				float2 uvRampTex : TEXCOORD2;
				float3 worldPos : TEXCOORD3;
				float3 worldNormal : TEXCOORD4;
			};

			sampler2D _MainTex;
			sampler2D _MainTex1;
			float4 _MainTex_ST;
			sampler2D _NoiseTex;
			float4 _NoiseTex_ST;
			float _Threshold;
			float _EdgeLength;
			sampler2D _RampTex;
			float4 _RampTex_ST;
			float _MaxDistance;
			float4 _StartPoint;
			float _DistanceEffect;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);

				o.uvMainTex = TRANSFORM_TEX(v.uv, _MainTex);
				o.uvNoiseTex = TRANSFORM_TEX(v.uv, _NoiseTex);
				o.uvRampTex = TRANSFORM_TEX(v.uv, _RampTex);

				o.worldPos = mul(unity_ObjectToWorld, v.vertex);
				o.worldNormal = UnityObjectToWorldNormal(v.normal);

				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				float dist = length(i.worldPos.xyz - _StartPoint.xyz);
				float normalizedDist = 1 - saturate(dist / _MaxDistance);

				fixed cutout = tex2D(_NoiseTex, i.uvNoiseTex).r * (1 - _DistanceEffect) + normalizedDist * _DistanceEffect;
				//clip(cutout - _Threshold);

				float degree = saturate((cutout - _Threshold) / _EdgeLength);
				fixed4 edgeColor = tex2D(_RampTex, float2(degree, degree));

				//加点漫反射
				fixed4 albedo = tex2D(_MainTex, i.uvMainTex);
				albedo = clamp((1 - 1 / (_Threshold - cutout)), 0, 1) * albedo;
				
				
	
				float3 worldNormal = normalize(i.worldNormal);
				float3 worldLightDir = normalize(UnityWorldSpaceLightDir(i.worldPos));
				fixed3 diffuse = _LightColor0.rgb * albedo.rgb * saturate(dot(worldNormal, worldLightDir));
	
				edgeColor = clamp(edgeColor * (1 - (_Threshold - cutout)), 0, 1);

				fixed4 finalColor = lerp(edgeColor, albedo, degree);
				
				fixed4 albedo2 = tex2D(_MainTex1, i.uvMainTex);
		finalColor = finalColor + clamp((1 / (_Threshold - cutout)), 0, 1) * albedo2;
	
				//finalColor = cutout*finalColor + base;
				
	
					
				//finalColor =  (_Threshold - cutout);

				//base = base * (cutout + _Threshold);
	
				//finalColor = finalColor + base;
    return fixed4(finalColor.rgb, 1);
}
			ENDCG
		}
	}
}
