// Made with Amplify Shader Editor v1.9.0.2
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Amazing Assets/Dynamic Radial Masks/Example/Force Field"
{
	Properties
	{
		[HDR]_BaseColor("Base Color", Color) = (0,0,0,0)
		_BaseMap("Base Map", 2D) = "white" {}
		_ScrollSpeed("Scroll Speed", Vector) = (1,1,0,0)
		_FresnelScale("Fresnel Scale", Float) = 1
		[HDR]_EmissionColor("Emission Color", Color) = (0,0,0,0)
		_VertexDisplaceStrength("Vertex Displace Strength", Float) = 0
		[ASEEnd]_RadialMaskNoise("Radial Mask Noise", 2D) = "white" {}
		[HideInInspector] _texcoord( "", 2D ) = "white" {}

	}
	
	SubShader
	{
		
		
		Tags { "RenderType"="Transparent" "Queue"="Transparent" }
	LOD 0

		CGINCLUDE
		#pragma target 3.0
		ENDCG
		Blend One One
		AlphaToMask Off
		Cull Back
		ColorMask RGB
		ZWrite Off
		ZTest LEqual
		
		
		
		Pass
		{
			Name "Unlit"
			Tags { "LightMode"="ForwardBase" }
			CGPROGRAM

			

			#ifndef UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX
			//only defining to not throw compilation error over Unity 5.5
			#define UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(input)
			#endif
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_instancing
			#include "UnityCG.cginc"
			#include "UnityShaderVariables.cginc"
			#define ASE_NEEDS_FRAG_WORLD_POSITION
			#include "Assets/Amazing Assets/Dynamic Radial Masks/Shaders/CGINC/Torus/DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local.cginc"


			struct appdata
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
				float4 ase_texcoord3 : TEXCOORD3;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord : TEXCOORD0;
				float3 ase_normal : NORMAL;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};
			
			struct v2f
			{
				float4 vertex : SV_POSITION;
				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				float3 worldPos : TEXCOORD0;
				#endif
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord3 : TEXCOORD3;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			uniform sampler2D _RadialMaskNoise;
			uniform float4 _RadialMaskNoise_ST;
			uniform float _VertexDisplaceStrength;
			uniform float4 _BaseColor;
			uniform sampler2D _BaseMap;
			uniform float4 _BaseMap_ST;
			uniform float2 _ScrollSpeed;
			uniform float _FresnelScale;
			uniform float4 _EmissionColor;

			
			v2f vert ( appdata v )
			{
				v2f o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
				UNITY_TRANSFER_INSTANCE_ID(v, o);

				float localRead_DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local3_g3 = ( 0.0 );
				float3 WorldPosition3_g3 = mul( unity_ObjectToWorld, v.ase_texcoord2 ).xyz;
				float2 uv_RadialMaskNoise = v.ase_texcoord.xy * _RadialMaskNoise_ST.xy + _RadialMaskNoise_ST.zw;
				float Noise3_g3 = tex2Dlod( _RadialMaskNoise, float4( uv_RadialMaskNoise, 0, 0.0) ).r;
				float Mask3_g3 = 0;
				{
				DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local_float(WorldPosition3_g3, Noise3_g3, Mask3_g3);
				}
				float temp_output_246_0 = pow( Mask3_g3 , 2.0 );
				
				float3 ase_worldNormal = UnityObjectToWorldNormal(v.ase_normal);
				o.ase_texcoord2.xyz = ase_worldNormal;
				
				o.ase_texcoord1.xy = v.ase_texcoord.xy;
				o.ase_texcoord3 = v.ase_texcoord2;
				
				//setting value to unused interpolator channels and avoid initialization warnings
				o.ase_texcoord1.zw = 0;
				o.ase_texcoord2.w = 0;
				float3 vertexValue = float3(0, 0, 0);
				#if ASE_ABSOLUTE_VERTEX_POS
				vertexValue = v.vertex.xyz;
				#endif
				vertexValue = ( v.ase_texcoord3.xyz * ( temp_output_246_0 * _VertexDisplaceStrength ) );
				#if ASE_ABSOLUTE_VERTEX_POS
				v.vertex.xyz = vertexValue;
				#else
				v.vertex.xyz += vertexValue;
				#endif
				o.vertex = UnityObjectToClipPos(v.vertex);

				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
				#endif
				return o;
			}
			
			fixed4 frag (v2f i ) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID(i);
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i);
				fixed4 finalColor;
				#ifdef ASE_NEEDS_FRAG_WORLD_POSITION
				float3 WorldPosition = i.worldPos;
				#endif
				float2 uv_BaseMap = i.ase_texcoord1.xy * _BaseMap_ST.xy + _BaseMap_ST.zw;
				float3 ase_worldViewDir = UnityWorldSpaceViewDir(WorldPosition);
				ase_worldViewDir = normalize(ase_worldViewDir);
				float3 ase_worldNormal = i.ase_texcoord2.xyz;
				float fresnelNdotV268 = dot( ase_worldNormal, ase_worldViewDir );
				float fresnelNode268 = ( 0.0 + _FresnelScale * pow( 1.0 - fresnelNdotV268, 5.0 ) );
				float localRead_DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local3_g3 = ( 0.0 );
				float3 WorldPosition3_g3 = mul( unity_ObjectToWorld, i.ase_texcoord3 ).xyz;
				float2 uv_RadialMaskNoise = i.ase_texcoord1.xy * _RadialMaskNoise_ST.xy + _RadialMaskNoise_ST.zw;
				float Noise3_g3 = tex2D( _RadialMaskNoise, uv_RadialMaskNoise ).r;
				float Mask3_g3 = 0;
				{
				DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local_float(WorldPosition3_g3, Noise3_g3, Mask3_g3);
				}
				float temp_output_246_0 = pow( Mask3_g3 , 2.0 );
				
				
				finalColor = ( ( ( _BaseColor * tex2D( _BaseMap, ( uv_BaseMap + ( _Time.y * _ScrollSpeed ) ) ) ) * fresnelNode268 ) + ( _EmissionColor * temp_output_246_0 ) );
				return finalColor;
			}
			ENDCG
		}
	}
	
	
	Fallback Off
}
/*ASEBEGIN
Version=19002
1647.709;256.5818;1476;765;1673.462;-73.15152;1;True;False
Node;AmplifyShaderEditor.CommentaryNode;207;-144.5246,-2060.521;Inherit;False;1554.749;970.269;Base Map;9;220;256;247;258;250;257;259;214;221;;1,1,1,1;0;0
Node;AmplifyShaderEditor.Vector2Node;259;286.9593,-1236.29;Inherit;False;Property;_ScrollSpeed;Scroll Speed;2;0;Create;True;0;0;0;False;0;False;1,1;0,0;0;3;FLOAT2;0;FLOAT;1;FLOAT;2
Node;AmplifyShaderEditor.TimeNode;257;250.2697,-1379.222;Inherit;False;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.CommentaryNode;208;-1925.374,320.7441;Inherit;False;1513.39;728.2723;Dynamic Radial Mask;6;260;212;225;211;210;246;;1,1,1,1;0;0
Node;AmplifyShaderEditor.TexturePropertyNode;214;-33.40947,-1755.492;Float;True;Property;_BaseMap;Base Map;1;0;Create;True;0;0;0;False;0;False;None;None;False;white;Auto;Texture2D;-1;0;2;SAMPLER2D;0;SAMPLERSTATE;1
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;258;478.2699,-1323.222;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;250;242.6566,-1496.968;Inherit;False;0;-1;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.TexCoordVertexDataNode;210;-1841.189,552.0089;Inherit;False;2;4;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ObjectToWorldMatrixNode;211;-1848.677,436.2622;Inherit;False;0;1;FLOAT4x4;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;225;-1604.675,487.2623;Inherit;False;2;2;0;FLOAT4x4;0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1;False;1;FLOAT4;0,0,0,0;False;1;FLOAT4;0
Node;AmplifyShaderEditor.SimpleAddOpNode;256;670.2903,-1493.625;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SamplerNode;212;-1847.849,796.2918;Inherit;True;Property;_RadialMaskNoise;Radial Mask Noise;6;0;Create;True;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;237;1021.507,-419.0576;Float;False;Property;_FresnelScale;Fresnel Scale;3;0;Create;True;0;0;0;False;0;False;1;39.8;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;209;869.9423,1377.425;Inherit;False;1134.741;351.4886;Vertex Offset;4;219;218;217;216;;1,1,1,1;0;0
Node;AmplifyShaderEditor.ColorNode;220;933.4027,-1975.555;Float;False;Property;_BaseColor;Base Color;0;1;[HDR];Create;True;0;0;0;False;0;False;0,0,0,0;0,0.7171054,1,1;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;247;857.0307,-1755.879;Inherit;True;Property;_TextureSample0;Texture Sample 0;10;0;Create;True;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.FunctionNode;260;-1343.714,493.1706;Inherit;False;DynamicRadialMasks_Torus_16_Advanced_Normalized_ID1_Local;-1;;3;8f51d6976566d774898ae9bfe57521b6;0;2;4;FLOAT3;0,0,0;False;5;FLOAT;0;False;1;FLOAT;6
Node;AmplifyShaderEditor.PowerNode;246;-746.3422,489.6301;Inherit;False;False;2;0;FLOAT;0;False;1;FLOAT;2;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;216;931.142,1614.778;Float;False;Property;_VertexDisplaceStrength;Vertex Displace Strength;5;0;Create;True;0;0;0;False;0;False;0;0.2;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.FresnelNode;268;1241.054,-486.0176;Inherit;False;Standard;WorldNormal;ViewDir;False;False;5;0;FLOAT3;0,0,1;False;4;FLOAT3;0,0,0;False;1;FLOAT;0;False;2;FLOAT;1;False;3;FLOAT;5;False;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;223;1461.856,344.7628;Float;False;Property;_EmissionColor;Emission Color;4;1;[HDR];Create;True;0;0;0;False;0;False;0,0,0,0;0,2.117647,2.996078,1;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;221;1255.054,-1771.032;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.TexCoordVertexDataNode;217;1438.468,1438.007;Inherit;False;3;3;0;5;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;226;1926.692,-517.2196;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;218;1213.999,1596.858;Inherit;False;2;2;0;FLOAT;1;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;224;1849.079,470.2426;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleAddOpNode;222;2156.047,444.4773;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;219;1837.703,1576.491;Inherit;False;2;2;0;FLOAT3;0,0,0;False;1;FLOAT;0;False;1;FLOAT3;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;82;2831.887,433.9581;Float;False;True;-1;2;;0;3;Amazing Assets/Dynamic Radial Masks/Example/Force Field;0770190933193b94aaa3065e307002fa;True;Unlit;0;0;Unlit;2;True;True;4;1;False;;1;False;;0;1;False;;1;False;;True;0;False;;0;False;;False;False;False;False;False;False;False;False;False;True;0;False;;True;True;0;False;;True;True;True;True;True;False;0;False;;False;False;False;False;False;False;False;True;False;255;False;;255;False;;255;False;;7;False;;1;False;;1;False;;1;False;;7;False;;1;False;;1;False;;1;False;;True;True;2;False;;True;3;False;;True;False;0;False;;0;False;;True;2;RenderType=Transparent=RenderType;Queue=Transparent=Queue=0;True;2;False;0;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;1;LightMode=ForwardBase;False;False;0;;0;0;Standard;1;Vertex Position,InvertActionOnDeselection;1;0;0;1;True;False;;False;0
WireConnection;258;0;257;2
WireConnection;258;1;259;0
WireConnection;250;2;214;0
WireConnection;225;0;211;0
WireConnection;225;1;210;0
WireConnection;256;0;250;0
WireConnection;256;1;258;0
WireConnection;247;0;214;0
WireConnection;247;1;256;0
WireConnection;260;4;225;0
WireConnection;260;5;212;1
WireConnection;246;0;260;6
WireConnection;268;2;237;0
WireConnection;221;0;220;0
WireConnection;221;1;247;0
WireConnection;226;0;221;0
WireConnection;226;1;268;0
WireConnection;218;0;246;0
WireConnection;218;1;216;0
WireConnection;224;0;223;0
WireConnection;224;1;246;0
WireConnection;222;0;226;0
WireConnection;222;1;224;0
WireConnection;219;0;217;0
WireConnection;219;1;218;0
WireConnection;82;0;222;0
WireConnection;82;1;219;0
ASEEND*/
//CHKSM=F7C4078A7AE9DC63007F934DAEBB7DB49A075DD5