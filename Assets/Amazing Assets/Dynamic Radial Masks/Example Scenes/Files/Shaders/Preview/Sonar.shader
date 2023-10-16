Shader "Amazing Assets/Dynamic Radial Masks/Example/Preview/Sonar"
{
    Properties
    {
        _NoiseTex ("Noise", 2D) = "black" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
        Cull Off

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

			#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Sonar/DynamicRadialMasks_Sonar_1_Advanced_Additive_ID1_Local.cginc"
			


			sampler2D _NoiseTex;
            float4 _NoiseTex_ST;

            
            struct v2f 
            {                
                float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
				float3 worldPos : TEXCOORD1;
            };            

            v2f vert (float4 vertex : POSITION, float2 uv : TEXCOORD0)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(vertex);
                o.uv = TRANSFORM_TEX(uv, _NoiseTex);
				o.worldPos = mul(unity_ObjectToWorld, vertex).xyz;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float noise = tex2D(_NoiseTex, i.uv).r;

				float mask = DynamicRadialMasks_Sonar_1_Advanced_Additive_ID1_Local(i.worldPos, noise);


                return mask;
            }
            ENDCG
        }
    }
}
