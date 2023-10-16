#ifndef DYNAMIC_RADIAL_MASKS_TORUS_64_ADVANCED_NORMALIZED_ID1_LOCAL
#define DYNAMIC_RADIAL_MASKS_TORUS_64_ADVANCED_NORMALIZED_ID1_LOCAL


float4 DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Position[64];	
float  DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Radius[64];
float  DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Intensity[64];
float  DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_NoiseStrength[64];
float  DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_EdgeSize[64];
float  DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Smooth[64];


#include "../../Core/Core.cginc"



////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                Main Method                                 //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
float DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local(float3 positionWS, float noise)
{
    float retValue = 1; 

	int i = 0;
[unroll]	for(i = 0; i < 64; i++)
	{
		float mask = ShaderExtensions_DynamicRadialMasks_Torus_Advanced(positionWS,
																		noise,
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Position[i].xyz, 
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Radius[i],         
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Intensity[i],           
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_NoiseStrength[i],  
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_EdgeSize[i],		
																		DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_Smooth[i]);
		retValue *= 1 - saturate(mask);	
	}		

    return 1 - retValue;
}

////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                               Helper Methods                               //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_float(float3 positionWS, float noise, out float retValue)
{
    retValue = DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local(positionWS, noise); 		
}

void DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local_half(half3 positionWS, half noise, out half retValue)
{
    retValue = DynamicRadialMasks_Torus_64_Advanced_Normalized_ID1_Local(positionWS, noise); 		
}

#endif
