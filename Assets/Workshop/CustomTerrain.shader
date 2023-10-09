Shader"Custom/TerrainShader"
{
    Properties
    {
        _SplatMap ("Splat Map", 2D) = "white" {}
        _Texture0 ("Texture 0", 2D) = "white" {}
        _Texture1 ("Texture 1", 2D) = "white" {}
        _Texture2 ("Texture 2", 2D) = "white" {}
        _Texture3 ("Texture 3", 2D) = "white" {}
    }
 
    SubShader
    {
        Tags { "RenderType"="Opaque" }
 
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
#include "UnityCG.cginc"
 
struct appdata_t
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};
 
struct v2f
{
    float2 uv : TEXCOORD0;
    float4 vertex : SV_POSITION;
};
 
sampler2D _SplatMap;
sampler2D _Texture0;
sampler2D _Texture1;
sampler2D _Texture2;
sampler2D _Texture3;
 
v2f vert(appdata_t v)
{
    v2f o;
    o.vertex = UnityObjectToClipPos(v.vertex);
    o.uv = v.uv;
    return o;
}
 
fixed4 frag(v2f i) : SV_Target
{
                // Sample the splat map
    fixed4 splat = tex2D(_SplatMap, i.uv);
 
                // Sample the individual texture layers
    fixed4 tex0 = tex2D(_Texture0, i.uv);
    fixed4 tex1 = tex2D(_Texture1, i.uv);
    fixed4 tex2 = tex2D(_Texture2, i.uv);
    fixed4 tex3 = tex2D(_Texture3, i.uv);
 
                // Calculate the final color by blending based on the splat map
    fixed4 finalColor = tex0 * splat.r + tex1 * splat.g + tex2 * splat.b + tex3 * splat.a;
 
    return finalColor;
}
            ENDCG
        }
    }
}