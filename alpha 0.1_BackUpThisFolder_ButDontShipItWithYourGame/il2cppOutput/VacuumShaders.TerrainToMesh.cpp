#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2;
template <typename T1, typename T2>
struct InvokerActionInvoker2<T1*, T2>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2 p2)
	{
		void* params[2] = { p1, &p2 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3;
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3<T1*, T2*, T3>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3 p3)
	{
		void* params[3] = { p1, p2, &p3 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Collections.Generic.IEnumerable`1<System.Int32>
struct IEnumerable_1_tCE758D940790D6D0D56B457E522C195F8C413AF2;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>
struct IEnumerable_1_t6C47A8FE62321E6AD75C312B8549AFD2B13F0591;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>
struct IEnumerable_1_t5C1E5CDFEA99062D152E83B174072FEDB9763788;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Vector4>
struct IEnumerable_1_tD5C0FD17E45BB16A64310D831E29C350A184590F;
// System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>
struct List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.List`1<UnityEngine.Vector2>
struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B;
// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B;
// System.Collections.Generic.List`1<UnityEngine.Vector4>
struct List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317;
// System.Collections.Generic.List`1<UnityEngine.Vector3>[]
struct List_1U5BU5D_tC1B009E92641A2C993F3BB28A80D61D2AB67979B;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// UnityEngine.Mesh[]
struct MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689;
// UnityEngine.MeshFilter[]
struct MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// VacuumShaders.TerrainToMesh.PreMesh[]
struct PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// UnityEngine.SplatPrototype[]
struct SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A;
// UnityEngine.Texture2D[]
struct Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191;
// UnityEngine.TreeInstance[]
struct TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429;
// UnityEngine.TreePrototype[]
struct TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// UnityEngine.Vector4[]
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
// System.Single[,]
struct SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// VacuumShaders.TerrainToMesh.CompressedMeshLoader
struct CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// UnityEngine.MeshFilter
struct MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// VacuumShaders.TerrainToMesh.PreMesh
struct PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03;
// UnityEngine.RenderTexture
struct RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27;
// UnityEngine.Shader
struct Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692;
// UnityEngine.SplatPrototype
struct SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// UnityEngine.Terrain
struct Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667;
// VacuumShaders.TerrainToMesh.TerrainConvertInfo
struct TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D;
// UnityEngine.TerrainData
struct TerrainData_t615A68EAC648066681875D47FC641496D12F2E24;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// UnityEngine.TreePrototype
struct TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction
struct ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF;

IL2CPP_EXTERN_C RuntimeClass* ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Graphics_t99CD970FFEA58171C70F54DF0C06D315BD452F2C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral1D81D3AF9B723F2D77E4987B9173B054328650BE;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral27316A4940BF2B13EE1D13319104AE84C93A6010;
IL2CPP_EXTERN_C String_t* _stringLiteral2C86B2BC763697332424FE2A75529D19514427B8;
IL2CPP_EXTERN_C String_t* _stringLiteral3114E31F897F3607D8D80829EB380C5FE0D23242;
IL2CPP_EXTERN_C String_t* _stringLiteral3AE26BC35C10AF76A289EE17081B65A3ECDB479E;
IL2CPP_EXTERN_C String_t* _stringLiteral3BAEF3F8883849DABF41F0396F462E7B861A32B0;
IL2CPP_EXTERN_C String_t* _stringLiteral3D574679C44394BA9A98F52653C5978AF7EAC5C9;
IL2CPP_EXTERN_C String_t* _stringLiteral3E321812348924F7AA224F948AC80E9E5A7841FE;
IL2CPP_EXTERN_C String_t* _stringLiteral3F8C35472D6335178E5DB62294702D4E1545A6E6;
IL2CPP_EXTERN_C String_t* _stringLiteral4698118A5AC187D0548E80D23BB386EF5015065A;
IL2CPP_EXTERN_C String_t* _stringLiteral4E9A903C24F8DD959F1BF4F77241BFB1848A3436;
IL2CPP_EXTERN_C String_t* _stringLiteral4EA526C4094316E1ABDC97726C22C86A9A389C1A;
IL2CPP_EXTERN_C String_t* _stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C;
IL2CPP_EXTERN_C String_t* _stringLiteral5425E4DDE72D9B019B45A16C8F497D3B7D8EE6B2;
IL2CPP_EXTERN_C String_t* _stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229;
IL2CPP_EXTERN_C String_t* _stringLiteral5CFE8923806CDDAAD3F303E0C2ED3D9A4B5008EE;
IL2CPP_EXTERN_C String_t* _stringLiteral6508496C80DA5B8525543A261C6B54B584D3C4C9;
IL2CPP_EXTERN_C String_t* _stringLiteral6DC06A97CD7BB70F5ECDB0405BECBB5EDCFD1923;
IL2CPP_EXTERN_C String_t* _stringLiteral78C3D77C204E73EDD42708C9D78AAB6B667D05A6;
IL2CPP_EXTERN_C String_t* _stringLiteral814A81152C9DCF6898084A33A69BA57D08BF6A9B;
IL2CPP_EXTERN_C String_t* _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1;
IL2CPP_EXTERN_C String_t* _stringLiteral86CECC01D3FC259A06032362A21A3273E76DA152;
IL2CPP_EXTERN_C String_t* _stringLiteral8DA8E813D130ABDEBE308DB1EEA65D7EA322F124;
IL2CPP_EXTERN_C String_t* _stringLiteral94064E2D96DF1C4B6EFDC5807CDD156B50F5179A;
IL2CPP_EXTERN_C String_t* _stringLiteralA188446A42B03C243C9A7A0685A66E973B0D5739;
IL2CPP_EXTERN_C String_t* _stringLiteralA21C073BA5F0E66881D17295C5FB2901B4066EDB;
IL2CPP_EXTERN_C String_t* _stringLiteralAA9047E47B1DF12227A442BB2C254519C336E893;
IL2CPP_EXTERN_C String_t* _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D;
IL2CPP_EXTERN_C String_t* _stringLiteralBD6BC43E86DD63F925ABC8E3701B7F0E06FB6C94;
IL2CPP_EXTERN_C String_t* _stringLiteralC3F08F24B5EA074413F20BF19487B1DAFFB34470;
IL2CPP_EXTERN_C String_t* _stringLiteralD41D89DAD98E1F1783260FD0A5A774F557A05F0F;
IL2CPP_EXTERN_C String_t* _stringLiteralD55DD4F5305B96ED01127FA9602F1551CB0D2AFB;
IL2CPP_EXTERN_C String_t* _stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32;
IL2CPP_EXTERN_C String_t* _stringLiteralE5EE957CF9978795A3D9DF30B3186097186F4640;
IL2CPP_EXTERN_C String_t* _stringLiteralE6CB1BE05B6B4F7E53DCC55E187512FF0190FDFF;
IL2CPP_EXTERN_C String_t* _stringLiteralEB5EBD1E02B2257829FD68BB68B823AEDE84FA47;
IL2CPP_EXTERN_C String_t* _stringLiteralEFF27F09C45736F9769495B4CC293BC41A1C9991;
IL2CPP_EXTERN_C String_t* _stringLiteralFE4FFD4BF19A7FD0D1A4FDDF13A60A7F7C65AFC0;
IL2CPP_EXTERN_C String_t* _stringLiteralFF9F061FAD25E6BEA133D47C40B680E60D40D5CE;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentsInChildren_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_m68EDB1BC21CDD271AF95048193430D2BFD67C99E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m8B5DEF3F8F4F49003BB953399B6E84A6DC941AC6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mBE9255218FAB0B859E0DD1B944986BBC7F1C3A33_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689;
struct MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B;
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
struct SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A;
struct Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191;
struct TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429;
struct TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A;
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
struct SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t855A3325EEB3E0AD3BD4CA254BBD455C8DE092A5 
{
};

// System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>
struct List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	List_1U5BU5D_tC1B009E92641A2C993F3BB28A80D61D2AB67979B* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<UnityEngine.Vector2>
struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<UnityEngine.Vector4>
struct List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// VacuumShaders.TerrainToMesh.PreMesh
struct PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03  : public RuntimeObject
{
	// System.String VacuumShaders.TerrainToMesh.PreMesh::name
	String_t* ___name_0;
	// UnityEngine.Vector3[] VacuumShaders.TerrainToMesh.PreMesh::vertices
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___vertices_1;
	// System.Int32[] VacuumShaders.TerrainToMesh.PreMesh::triangles
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___triangles_2;
	// UnityEngine.Vector2[] VacuumShaders.TerrainToMesh.PreMesh::uv
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv_3;
	// UnityEngine.Vector2[] VacuumShaders.TerrainToMesh.PreMesh::uv2
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___uv2_4;
	// UnityEngine.Vector3[] VacuumShaders.TerrainToMesh.PreMesh::normals
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___normals_5;
	// UnityEngine.Vector4[] VacuumShaders.TerrainToMesh.PreMesh::tangents
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___tangents_6;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.Text.StringBuilder
struct StringBuilder_t  : public RuntimeObject
{
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t* ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;
};

// VacuumShaders.TerrainToMesh.TerrainConvertInfo
struct TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D  : public RuntimeObject
{
	// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::chunkCountHorizontal
	int32_t ___chunkCountHorizontal_1;
	// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::chunkCountVertical
	int32_t ___chunkCountVertical_2;
	// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::vertexCountHorizontal
	int32_t ___vertexCountHorizontal_3;
	// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::vertexCountVertical
	int32_t ___vertexCountVertical_4;
	// System.Boolean VacuumShaders.TerrainToMesh.TerrainConvertInfo::generateSkirt
	bool ___generateSkirt_5;
	// System.Single VacuumShaders.TerrainToMesh.TerrainConvertInfo::skirtGroundLevel
	float ___skirtGroundLevel_6;
};

// UnityEngine.TreePrototype
struct TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D  : public RuntimeObject
{
	// UnityEngine.GameObject UnityEngine.TreePrototype::m_Prefab
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_Prefab_0;
	// System.Single UnityEngine.TreePrototype::m_BendFactor
	float ___m_BendFactor_1;
	// System.Int32 UnityEngine.TreePrototype::m_NavMeshLod
	int32_t ___m_NavMeshLod_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.TreePrototype
struct TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D_marshaled_pinvoke
{
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_Prefab_0;
	float ___m_BendFactor_1;
	int32_t ___m_NavMeshLod_2;
};
// Native definition for COM marshalling of UnityEngine.TreePrototype
struct TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D_marshaled_com
{
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_Prefab_0;
	float ___m_BendFactor_1;
	int32_t ___m_NavMeshLod_2;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// UnityEngine.Color32
struct Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Int32 UnityEngine.Color32::rgba
			int32_t ___rgba_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			int32_t ___rgba_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Byte UnityEngine.Color32::r
			uint8_t ___r_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint8_t ___r_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___g_2_OffsetPadding[1];
			// System.Byte UnityEngine.Color32::g
			uint8_t ___g_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___g_2_OffsetPadding_forAlignmentOnly[1];
			uint8_t ___g_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___b_3_OffsetPadding[2];
			// System.Byte UnityEngine.Color32::b
			uint8_t ___b_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___b_3_OffsetPadding_forAlignmentOnly[2];
			uint8_t ___b_3_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___a_4_OffsetPadding[3];
			// System.Byte UnityEngine.Color32::a
			uint8_t ___a_4;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___a_4_OffsetPadding_forAlignmentOnly[3];
			uint8_t ___a_4_forAlignmentOnly;
		};
	};
};

// System.DateTime
struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D 
{
	// System.UInt64 System.DateTime::_dateData
	uint64_t ____dateData_46;
};

// System.Double
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	// System.Double System.Double::m_value
	double ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

// UnityEngine.Rect
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.SplatPrototype
struct SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8  : public RuntimeObject
{
	// UnityEngine.Texture2D UnityEngine.SplatPrototype::m_Texture
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_Texture_0;
	// UnityEngine.Texture2D UnityEngine.SplatPrototype::m_NormalMap
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_NormalMap_1;
	// UnityEngine.Vector2 UnityEngine.SplatPrototype::m_TileSize
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileSize_2;
	// UnityEngine.Vector2 UnityEngine.SplatPrototype::m_TileOffset
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileOffset_3;
	// UnityEngine.Vector4 UnityEngine.SplatPrototype::m_SpecularMetallic
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_SpecularMetallic_4;
	// System.Single UnityEngine.SplatPrototype::m_Smoothness
	float ___m_Smoothness_5;
};
// Native definition for P/Invoke marshalling of UnityEngine.SplatPrototype
struct SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8_marshaled_pinvoke
{
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_Texture_0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_NormalMap_1;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileSize_2;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileOffset_3;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_SpecularMetallic_4;
	float ___m_Smoothness_5;
};
// Native definition for COM marshalling of UnityEngine.SplatPrototype
struct SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8_marshaled_com
{
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_Texture_0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___m_NormalMap_1;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileSize_2;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_TileOffset_3;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_SpecularMetallic_4;
	float ___m_Smoothness_5;
};

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter
struct TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E  : public RuntimeObject
{
};

// UnityEngine.TreeInstance
struct TreeInstance_t382B018173ED020660D262061EA9424682614F50 
{
	// UnityEngine.Vector3 UnityEngine.TreeInstance::position
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position_0;
	// System.Single UnityEngine.TreeInstance::widthScale
	float ___widthScale_1;
	// System.Single UnityEngine.TreeInstance::heightScale
	float ___heightScale_2;
	// System.Single UnityEngine.TreeInstance::rotation
	float ___rotation_3;
	// UnityEngine.Color32 UnityEngine.TreeInstance::color
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_4;
	// UnityEngine.Color32 UnityEngine.TreeInstance::lightmapColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___lightmapColor_5;
	// System.Int32 UnityEngine.TreeInstance::prototypeIndex
	int32_t ___prototypeIndex_6;
	// System.Single UnityEngine.TreeInstance::temporaryDistance
	float ___temporaryDistance_7;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// UnityEngine.Shader
struct Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.TerrainData
struct TerrainData_t615A68EAC648066681875D47FC641496D12F2E24  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.MeshFilter
struct MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.RenderTexture
struct RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction
struct ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF  : public MulticastDelegate_t
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.Terrain
struct Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// VacuumShaders.TerrainToMesh.CompressedMeshLoader
struct CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Int32 VacuumShaders.TerrainToMesh.CompressedMeshLoader::chunkCountHorizontal
	int32_t ___chunkCountHorizontal_4;
	// System.Int32 VacuumShaders.TerrainToMesh.CompressedMeshLoader::chunkCountVertical
	int32_t ___chunkCountVertical_5;
	// System.Int32 VacuumShaders.TerrainToMesh.CompressedMeshLoader::vertexCountHorizontal
	int32_t ___vertexCountHorizontal_6;
	// System.Int32 VacuumShaders.TerrainToMesh.CompressedMeshLoader::vertexCountVertical
	int32_t ___vertexCountVertical_7;
	// System.Boolean VacuumShaders.TerrainToMesh.CompressedMeshLoader::usingPerChunkBasemap
	bool ___usingPerChunkBasemap_8;
	// System.Boolean VacuumShaders.TerrainToMesh.CompressedMeshLoader::usingSkirt
	bool ___usingSkirt_9;
};

// <Module>

// <Module>

// System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>
struct List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	List_1U5BU5D_tC1B009E92641A2C993F3BB28A80D61D2AB67979B* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>

// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Int32>

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Object>

// System.Collections.Generic.List`1<UnityEngine.Vector2>
struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Vector2>

// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Vector3>

// System.Collections.Generic.List`1<UnityEngine.Vector4>
struct List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Vector4>

// VacuumShaders.TerrainToMesh.PreMesh

// VacuumShaders.TerrainToMesh.PreMesh

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.Text.StringBuilder

// System.Text.StringBuilder

// VacuumShaders.TerrainToMesh.TerrainConvertInfo

// VacuumShaders.TerrainToMesh.TerrainConvertInfo

// UnityEngine.TreePrototype

// UnityEngine.TreePrototype

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// UnityEngine.Color

// UnityEngine.Color

// System.DateTime
struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_StaticFields
{
	// System.Int32[] System.DateTime::s_daysToMonth365
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth365_30;
	// System.Int32[] System.DateTime::s_daysToMonth366
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth366_31;
	// System.DateTime System.DateTime::MinValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MinValue_32;
	// System.DateTime System.DateTime::MaxValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MaxValue_33;
	// System.DateTime System.DateTime::UnixEpoch
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___UnixEpoch_34;
};

// System.DateTime

// System.Double

// System.Double

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// UnityEngine.Quaternion

// UnityEngine.Rect

// UnityEngine.Rect

// System.Single

// System.Single

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector2

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// UnityEngine.Vector3

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields
{
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___negativeInfinityVector_8;
};

// UnityEngine.Vector4

// System.Void

// System.Void

// System.Delegate

// System.Delegate

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// UnityEngine.SplatPrototype

// UnityEngine.SplatPrototype

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter
struct TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields
{
	// UnityEngine.Terrain VacuumShaders.TerrainToMesh.TerrainToMeshConverter::terrain
	Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___terrain_0;
	// VacuumShaders.TerrainToMesh.TerrainConvertInfo VacuumShaders.TerrainToMesh.TerrainToMeshConverter::terrainConvertInfo
	TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* ___terrainConvertInfo_1;
	// VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction VacuumShaders.TerrainToMesh.TerrainToMeshConverter::callback
	ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* ___callback_2;
	// System.Boolean VacuumShaders.TerrainToMesh.TerrainToMeshConverter::basemapSplit
	bool ___basemapSplit_3;
	// UnityEngine.Vector4 VacuumShaders.TerrainToMesh.TerrainToMeshConverter::basemapSplitOffsetScale
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___basemapSplitOffsetScale_4;
};

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter

// UnityEngine.TreeInstance

// UnityEngine.TreeInstance

// UnityEngine.Component

// UnityEngine.Component

// UnityEngine.GameObject

// UnityEngine.GameObject

// UnityEngine.Material

// UnityEngine.Material

// UnityEngine.Mesh

// UnityEngine.Mesh

// UnityEngine.Shader

// UnityEngine.Shader

// UnityEngine.TerrainData
struct TerrainData_t615A68EAC648066681875D47FC641496D12F2E24_StaticFields
{
	// System.Int32 UnityEngine.TerrainData::k_MaximumResolution
	int32_t ___k_MaximumResolution_10;
	// System.Int32 UnityEngine.TerrainData::k_MinimumDetailResolutionPerPatch
	int32_t ___k_MinimumDetailResolutionPerPatch_11;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailResolutionPerPatch
	int32_t ___k_MaximumDetailResolutionPerPatch_12;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailPatchCount
	int32_t ___k_MaximumDetailPatchCount_13;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailsPerRes
	int32_t ___k_MaximumDetailsPerRes_14;
	// System.Int32 UnityEngine.TerrainData::k_MinimumAlphamapResolution
	int32_t ___k_MinimumAlphamapResolution_15;
	// System.Int32 UnityEngine.TerrainData::k_MaximumAlphamapResolution
	int32_t ___k_MaximumAlphamapResolution_16;
	// System.Int32 UnityEngine.TerrainData::k_MinimumBaseMapResolution
	int32_t ___k_MinimumBaseMapResolution_17;
	// System.Int32 UnityEngine.TerrainData::k_MaximumBaseMapResolution
	int32_t ___k_MaximumBaseMapResolution_18;
};

// UnityEngine.TerrainData

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700_StaticFields
{
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;
};

// UnityEngine.Texture

// System.AsyncCallback

// System.AsyncCallback

// UnityEngine.Behaviour

// UnityEngine.Behaviour

// UnityEngine.MeshFilter

// UnityEngine.MeshFilter

// UnityEngine.RenderTexture

// UnityEngine.RenderTexture

// UnityEngine.Texture2D

// UnityEngine.Texture2D

// UnityEngine.Transform

// UnityEngine.Transform

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction

// VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction

// UnityEngine.MonoBehaviour

// UnityEngine.MonoBehaviour

// UnityEngine.Terrain

// UnityEngine.Terrain

// VacuumShaders.TerrainToMesh.CompressedMeshLoader

// VacuumShaders.TerrainToMesh.CompressedMeshLoader
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.MeshFilter[]
struct MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA  : public RuntimeArray
{
	ALIGN_FIELD (8) MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* m_Items[1];

	inline MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 m_Items[1];

	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 m_Items[1];

	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector4[]
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 m_Items[1];

	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 value)
	{
		m_Items[index] = value;
	}
};
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Mesh[]
struct MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689  : public RuntimeArray
{
	ALIGN_FIELD (8) Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* m_Items[1];

	inline Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// VacuumShaders.TerrainToMesh.PreMesh[]
struct PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B  : public RuntimeArray
{
	ALIGN_FIELD (8) PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* m_Items[1];

	inline PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Texture2D[]
struct Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191  : public RuntimeArray
{
	ALIGN_FIELD (8) Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* m_Items[1];

	inline Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C  : public RuntimeArray
{
	ALIGN_FIELD (8) float m_Items[1];

	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389  : public RuntimeArray
{
	ALIGN_FIELD (8) Color_tD001788D726C3A7F1379BEED0260B9591F440C1F m_Items[1];

	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		m_Items[index] = value;
	}
};
// System.Single[,]
struct SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4  : public RuntimeArray
{
	ALIGN_FIELD (8) float m_Items[1];

	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
	inline float GetAt(il2cpp_array_size_t i, il2cpp_array_size_t j) const
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t i, il2cpp_array_size_t j)
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t i, il2cpp_array_size_t j, float value)
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j) const
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j)
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j, float value)
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		m_Items[index] = value;
	}
};
// UnityEngine.SplatPrototype[]
struct SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A  : public RuntimeArray
{
	ALIGN_FIELD (8) SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* m_Items[1];

	inline SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF  : public RuntimeArray
{
	ALIGN_FIELD (8) GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* m_Items[1];

	inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.TreePrototype[]
struct TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A  : public RuntimeArray
{
	ALIGN_FIELD (8) TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* m_Items[1];

	inline TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.TreeInstance[]
struct TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429  : public RuntimeArray
{
	ALIGN_FIELD (8) TreeInstance_t382B018173ED020660D262061EA9424682614F50 m_Items[1];

	inline TreeInstance_t382B018173ED020660D262061EA9424682614F50 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline TreeInstance_t382B018173ED020660D262061EA9424682614F50* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, TreeInstance_t382B018173ED020660D262061EA9424682614F50 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline TreeInstance_t382B018173ED020660D262061EA9424682614F50 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline TreeInstance_t382B018173ED020660D262061EA9424682614F50* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, TreeInstance_t382B018173ED020660D262061EA9424682614F50 value)
	{
		m_Items[index] = value;
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// T[] UnityEngine.Component::GetComponentsInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* Component_GetComponentsInChildren_TisRuntimeObject_m1F5B6FC0689B07D4FAAC0C605D9B2933A9B32543_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<System.Object>(T,UnityEngine.Vector3,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Object_Instantiate_TisRuntimeObject_m249A6BA4F2F19C2D3CE217D4D31847DF0EF03EFE_gshared (RuntimeObject* ___0_original, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_capacity, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_capacity, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_item, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector3>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<System.Int32>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::set_Item(System.Int32,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, int32_t ___1_value, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_gshared (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector4>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C_gshared (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_gshared (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector4>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D_gshared (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector2>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_gshared (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector4>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5_gshared (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) ;

// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T[] UnityEngine.Component::GetComponentsInChildren<UnityEngine.MeshFilter>()
inline MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* Component_GetComponentsInChildren_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_m68EDB1BC21CDD271AF95048193430D2BFD67C99E (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponentsInChildren_TisRuntimeObject_m1F5B6FC0689B07D4FAAC0C605D9B2933A9B32543_gshared)(__this, method);
}
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B (String_t* ___0_str0, String_t* ___1_str1, String_t* ___2_str2, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E (RuntimeObject* ___0_message, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_context, const RuntimeMethod* method) ;
// System.Void UnityEngine.Behaviour::set_enabled(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A (Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// UnityEngine.Mesh UnityEngine.MeshFilter::get_sharedMesh()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C (MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mesh::get_vertexCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Transform::get_childCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Transform_get_childCount_mE9C29C702AB662CC540CA053EDE48BDAFA35B4B0 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::Fix(UnityEngine.MeshFilter[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_Fix_m03CB192078D49FAEE1C6C0694FAB58C458DB980B (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* ___0__childMeshFilter, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::Combine(UnityEngine.Mesh,UnityEngine.Mesh,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_Combine_m27AB5605E1665164BC35FABEB0E2BC61C7394529 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__meshBottom, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___1__meshTop, bool ___2_bottomTop, const RuntimeMethod* method) ;
// System.Int32[] VacuumShaders.TerrainToMesh.CompressedMeshLoader::GetIndexies(VacuumShaders.TerrainToMesh.CompressedMeshLoader/SIDE)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* CompressedMeshLoader_GetIndexies_m69A354853534948AFFCF7ED9F743AD5BCABE779F (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, int32_t ___0__side, const RuntimeMethod* method) ;
// UnityEngine.Vector3[] UnityEngine.Mesh::get_vertices()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2[] UnityEngine.Mesh::get_uv()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2[] UnityEngine.Mesh::get_uv2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3[] UnityEngine.Mesh::get_normals()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector4[] UnityEngine.Mesh::get_tangents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::GetMeshData(UnityEngine.Mesh,VacuumShaders.TerrainToMesh.CompressedMeshLoader/SIDE,UnityEngine.Vector3[]&,UnityEngine.Vector2[]&,UnityEngine.Vector2[]&,UnityEngine.Vector3[]&,UnityEngine.Vector4[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_GetMeshData_mAE6F45F1FC31543D14D29332671CD6AC0019A479 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__mesh, int32_t ___1__side, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___2_vertices, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___3_uv, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___4_uv2, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___5_normal, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** ___6_tangent, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_vertices(UnityEngine.Vector3[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_uv(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_uv_m6ED9C50E0DA8166DD48AC40FD6C828B9AD2E9617 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_uv2(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_uv2_m37B442C04EBB029C0AD9545C54F95D9BDAD8E9B5 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_normals(UnityEngine.Vector3[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_normals_m85D73193C49211BE9FA135FF72D5749B16A4760B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_tangents(UnityEngine.Vector4[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_tangents_mF547B7E4F9C70FB7CD6168139180A70AD306169B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainConvertInfo::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainConvertInfo_Reset_m33D17DB183B77F1912C837A24D5BD489E5C45B29 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) ;
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetChunkCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetChunkCount_mD6CC2B383FDA836FDD37B3B48FD8F82E28C19063 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) ;
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetVertexCountPerChunk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetVertexCountPerChunk_mF6B86EEC8CF6C71D24E570763057478FE478F6F9 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) ;
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetTriangleCountPerChunk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetTriangleCountPerChunk_m43D15F98EDC732CBE72CABCD7A2856A078E8C2FF (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainConvertInfo::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainConvertInfo__ctor_mFB8735B68A94E3F8C7620B16D3023512CCB3E2FE (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Transform_get_rotation_m32AF40CA0D50C797DA639A696F8EAEC7524C179C (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_localScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_localScale_m804A002A53A645CDFCD15BB0F37209162720363F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::get_identity()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_rotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_rotation_m61340DE74726CF0F9946743A727C4D444397331D (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_one()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_one_mC9B289F1E15C42C597180C9FE6FB492495B51D02_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Mesh VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrain()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* TerrainToMeshConverter_GenerateTerrain_mA5AA623B54893CFD3735DFFF64C6032B525E0F20 (const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainBaseChunks(VacuumShaders.TerrainToMesh.PreMesh[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTerrainBaseChunks_m8F805CFFC5B087C619E46746492E0C180782D89E (PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** ___0__preMeshes, const RuntimeMethod* method) ;
// UnityEngine.TerrainData UnityEngine.Terrain::get_terrainData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.TerrainData::get_size()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5 (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36 (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___0_args, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction::Invoke(System.String,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_inline (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method) ;
// UnityEngine.Mesh VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainMainChunks(VacuumShaders.TerrainToMesh.PreMesh&,System.Single,System.Single,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* TerrainToMeshConverter_GenerateTerrainMainChunks_mEC78207E0925FC5BAC882673CFD0FCD01AD25A44 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** ___0__preMesh, float ___1__chunkH_Width, float ___2__chunkH_StartOffset, float ___3__chunkV_Length, float ___4__chunkV_StartOffset, bool ___5__normalizeUV, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::RecalculateBounds()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_RecalculateBounds_mA9B293F57C6CD298AE2D2DB19061FC23B05AB90B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::AddSkirt(UnityEngine.Mesh)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_AddSkirt_mA461756B9E0B28EF818F961AF1D3D59D7915127E (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__sourceMesh, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// UnityEngine.Texture2D[] UnityEngine.TerrainData::get_alphamapTextures()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45 (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ResizePro(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.Texture2D&,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_ResizePro_mEF356558D6D46C1A23BF1E6724D38CFC3896330A (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_texture, int32_t ___1_width, int32_t ___2_height, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___3_dstTexture, bool ___4_sRGB, bool ___5_hasMipMap, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractBasemap(UnityEngine.Terrain,UnityEngine.Texture2D&,UnityEngine.Texture2D&,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_ExtractBasemap_m385F298CB909E6AB7C0FB1D3877B26866AF8F3A7 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___1__diffuseMap, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___2__normalMap, int32_t ___3__width, int32_t ___4__height, bool ___5_sRGB, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Shader UnityEngine.Shader::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* Shader_Find_m183AA54F78320212DDEC811592F98456898A41C5 (String_t* ___0_name, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::.ctor(UnityEngine.Shader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_m7FDF47105D66D19591BE505A0C42B0F90D88C9BF (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* ___0_shader, const RuntimeMethod* method) ;
// System.Int32 VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractTexturesInfo(UnityEngine.Terrain,UnityEngine.Texture2D[]&,UnityEngine.Texture2D[]&,UnityEngine.Vector2[]&,UnityEngine.Vector2[]&,System.Single[]&,System.Single[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainToMeshConverter_ExtractTexturesInfo_m56AB39E9B6AD743592F187EAE2A3EA827EA79EBB (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___1__diffuseTextures, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___2__normalTextures, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___3__uvScale, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___4__uvOffset, SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** ___5__metalic, SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** ___6__smoothness, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___0_width, int32_t ___1_height, int32_t ___2_textureFormat, bool ___3_mipChain, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_clear()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixels(UnityEngine.Color[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* ___0_colors, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// UnityEngine.RenderTexture UnityEngine.RenderTexture::get_active()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* RenderTexture_get_active_mA4434B3E79DEF2C01CAE0A53061598B16443C9E7 (const RuntimeMethod* method) ;
// UnityEngine.RenderTexture UnityEngine.RenderTexture::GetTemporary(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* RenderTexture_GetTemporary_m5B16E03FC6142149BDC336285A5C18D5152CA2C3 (int32_t ___0_width, int32_t ___1_height, int32_t ___2_depthBuffer, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::SetVector(System.String,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___0_name, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.RenderTexture::DiscardContents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32 (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* __this, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, bool ___2_sRGB, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::SetTexture(System.String,UnityEngine.Texture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___0_name, Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___1_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetFloat_m879CF81D740BAE6F23C9822400679F4D16365836 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___0_name, float ___1_value, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,UnityEngine.Material,System.Boolean,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_Blit_mEEE3B1AA11BD74C6FF6809D63CAA6DFA4FC60560 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___2_mat, bool ___3_sRGB, int32_t ___4_pass, const RuntimeMethod* method) ;
// System.Void UnityEngine.RenderTexture::set_active(UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Rect::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23 (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* __this, float ___0_x, float ___1_y, float ___2_width, float ___3_height, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::ReadPixels(UnityEngine.Rect,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_ReadPixels_m6B45DF7C051BF599C72ED09691F21A6C769EEBD9 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___0_source, int32_t ___1_destX, int32_t ___2_destY, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture::set_wrapMode(UnityEngine.TextureWrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture_set_wrapMode_m1F74A690E3883EC9C5C371D502D09642F15D0F7E (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Vector4 UnityEngine.Vector4::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 Vector4_get_zero_m3D61F5FA9483CD9C08977D9D8852FB448B4CE6D1_inline (const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Application::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isPlaying_m25B0ABDFEF54F5370CD3F263A813540843D00F34 (const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::DestroyImmediate(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_obj, const RuntimeMethod* method) ;
// System.Void UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderTexture_ReleaseTemporary_mEEF2C1990196FF06FDD0DC190928AD3A023EBDD2 (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___0_temp, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.TerrainData::get_heightmapResolution()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainData_get_heightmapResolution_m39FE9A5C31A80B28021F8E2484EF5F2664798836 (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// System.Single[,] UnityEngine.TerrainData::GetHeights(System.Int32,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4* TerrainData_GetHeights_m3E5C109E98E72A23E39B92F7DF48D87888B2D488 (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, int32_t ___0_xBase, int32_t ___1_yBase, int32_t ___2_width, int32_t ___3_height, const RuntimeMethod* method) ;
// System.Single VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Remap(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TerrainToMeshConverter_Remap_m649C48A5904AE65F6E6646F62F4786D7AC1C01B3 (float ___0_value, float ___1_from1, float ___2_to1, float ___3_from2, float ___4_to2, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixel(System.Int32,System.Int32,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixel_m2CCFC5F729135D59DC4A697C2605A3FC5C8574DB (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___0_x, int32_t ___1_y, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_color, const RuntimeMethod* method) ;
// UnityEngine.Texture2D VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractHeightmap(UnityEngine.Terrain,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TerrainToMeshConverter_ExtractHeightmap_mD71042540E9B77D3B04827F4B6CD56BA33EE39B3 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, bool ___1__remap, const RuntimeMethod* method) ;
// UnityEngine.SplatPrototype[] UnityEngine.TerrainData::get_splatPrototypes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A* TerrainData_get_splatPrototypes_m349F72923854A74F3EE20D2F09452ED73852923E (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::get_one()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline (const RuntimeMethod* method) ;
// UnityEngine.Texture2D UnityEngine.SplatPrototype::get_texture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* SplatPrototype_get_texture_m10D1E021FA78ADB602A6B9DCF7D7C3108B5226EB (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// UnityEngine.Texture2D UnityEngine.SplatPrototype::get_normalMap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* SplatPrototype_get_normalMap_mB81C93E54EEDF854E3A6265259C627A80B3E76D3 (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.SplatPrototype::get_tileSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496 (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// UnityEngine.Vector2 UnityEngine.SplatPrototype::get_tileOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 SplatPrototype_get_tileOffset_m5D7E37F7FDB7B6A2CD8A2323D2AF0B7CCE88FCFF (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___0_x, float ___1_y, const RuntimeMethod* method) ;
// System.Single UnityEngine.SplatPrototype::get_metallic()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SplatPrototype_get_metallic_mF45573E9F0187E619B352DCC1A43D8950A7B5544 (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.SplatPrototype::get_smoothness()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SplatPrototype_get_smoothness_m41F39F21541FFA167558900FC05F6508E2CBB519 (SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* __this, const RuntimeMethod* method) ;
// UnityEngine.TreePrototype[] UnityEngine.TerrainData::get_treePrototypes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.TreePrototype::get_prefab()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C (TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_parent(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_parent_m9BD5E563B539DD5BEC342736B03F97B38A243234 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___0_value, const RuntimeMethod* method) ;
// UnityEngine.TreeInstance[] UnityEngine.TerrainData::get_treeInstances()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429* TerrainData_get_treeInstances_mDAB68FD1F3677BD5CB122EA943493D5FC94B2147 (TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<UnityEngine.GameObject>(T,UnityEngine.Vector3,UnityEngine.Quaternion)
inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___0_original, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_position, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___2_rotation, const RuntimeMethod* method)
{
	return ((  GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_m249A6BA4F2F19C2D3CE217D4D31847DF0EF03EFE_gshared)(___0_original, ___1_position, ___2_rotation, method);
}
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166 (String_t* __this, String_t* ___0_oldValue, String_t* ___1_newValue, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline (const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Quaternion::AngleAxis(System.Single,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80 (float ___0_angle, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_axis, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localRotation_mAB4A011D134BA58AB780BECC0025CA65F16185FA (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___0_value, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainOBJ(UnityEngine.Terrain,System.Int32,System.Int32,UnityEngine.Vector3[]&,System.Int32[]&,UnityEngine.Vector3[]&,UnityEngine.Vector2[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTerrainOBJ_m39D8EF8ED84134DDB615A055C216AC3F0B3BFAA2 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, int32_t ___1__vCountH, int32_t ___2_vCountV, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___3__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___4__trinagles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___5__normals, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___6__uvs, const RuntimeMethod* method) ;
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D (StringBuilder_t* __this, const RuntimeMethod* method) ;
// System.DateTime System.DateTime::get_Now()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D DateTime_get_Now_m636CB9651A9099D20BA1CF813A0C69637317325C (const RuntimeMethod* method) ;
// System.String System.DateTime::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DateTime_ToString_m447C83E1F8FFFFF4D20C0F7D5C18DEB160F9833A (DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D* __this, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D (StringBuilder_t* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.String System.Environment::get_NewLine()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF (const RuntimeMethod* method) ;
// System.String System.Single::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972 (float* __this, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA (StringBuilder_t* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) ;
// System.Single UnityEngine.Terrain::SampleHeight(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Terrain_SampleHeight_m460F9060BC4D5F05275391A6AC05570047EF3177 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_worldPosition, const RuntimeMethod* method) ;
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) ;
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateNormals(UnityEngine.Vector3[],System.Int32[],UnityEngine.Vector3[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateNormals_m017762E446405F9EA0A0991C669950579514D0C8 (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1__trinagles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___2__normals, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(System.Int32)
inline void List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33 (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_capacity, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, int32_t, const RuntimeMethod*))List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33_gshared)(__this, ___0_capacity, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor(System.Int32)
inline void List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_capacity, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98_gshared)(__this, ___0_capacity, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::Add(T)
inline void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*))List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline)(__this, ___0_item, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(T)
inline void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline)(__this, ___0_item, method);
}
// System.Void VacuumShaders.TerrainToMesh.PreMesh::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PreMesh__ctor_mCFC51B5015A64C2EFC55D3EB7A09645F8A2DE0B6 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* __this, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987 (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector3>::ToArray()
inline Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3 (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method)
{
	return ((  Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_gshared)(__this, method);
}
// T[] System.Collections.Generic.List`1<System.Int32>::ToArray()
inline Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	return ((  Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_gshared)(__this, method);
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTangents(UnityEngine.Vector3[],System.Int32[],UnityEngine.Vector3[],UnityEngine.Vector2[],UnityEngine.Vector4[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTangents_mD98240D042EB200A19307E4F73FA748C98B5E4CA (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1__triangles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2__normals, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___3__texcoords, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** ___4__tangents, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
inline void List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, RuntimeObject*, const RuntimeMethod*))List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_gshared)(__this, ___0_collection, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
inline void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
inline void List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, RuntimeObject*, const RuntimeMethod*))List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C_gshared)(__this, ___0_collection, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_gshared)(__this, ___0_index, method);
}
// T System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
inline int32_t List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_gshared)(__this, ___0_index, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::set_Item(System.Int32,T)
inline void List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_index, int32_t ___1_value, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, int32_t, const RuntimeMethod*))List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_gshared)(__this, ___0_index, ___1_value, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
inline void List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, RuntimeObject*, const RuntimeMethod*))List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_gshared)(__this, ___0_collection, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector4>::.ctor(System.Collections.Generic.IEnumerable`1<T>)
inline void List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, RuntimeObject* ___0_collection, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317*, RuntimeObject*, const RuntimeMethod*))List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C_gshared)(__this, ___0_collection, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679 (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, int32_t, const RuntimeMethod*))List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_gshared)(__this, ___0_index, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991 (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, int32_t, const RuntimeMethod*))List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_gshared)(__this, ___0_index, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector4>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317*, int32_t, const RuntimeMethod*))List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D_gshared)(__this, ___0_index, method);
}
// System.Void VacuumShaders.TerrainToMesh.PreMesh::Clear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PreMesh_Clear_m03D6E67111D9BF088E63E1B9157C29518275DFF5 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh__ctor_m5A9AECEDDAFFD84811ED8928012BDE97A9CEBD00 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_triangles(System.Int32[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_triangles_m124405320579A8D92711BB5A124644963A26F60B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___0_value, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector2>::ToArray()
inline Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5 (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method)
{
	return ((  Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, const RuntimeMethod*))List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_gshared)(__this, method);
}
// UnityEngine.Vector2[] VacuumShaders.TerrainToMesh.TerrainToMeshConverter::NormalizeUV(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* TerrainToMeshConverter_NormalizeUV_m242122C8B24863869D87ED3C1D13A3EB0601CD78 (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0__oldUVs, const RuntimeMethod* method) ;
// T[] System.Collections.Generic.List`1<UnityEngine.Vector4>::ToArray()
inline Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5 (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* __this, const RuntimeMethod* method)
{
	return ((  Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* (*) (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317*, const RuntimeMethod*))List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5_gshared)(__this, method);
}
// System.Void UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_hideFlags_mACB8BFC903FB3B01BBD427753E791BF28B5E33D4 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::RecalculateNormals()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_RecalculateNormals_m3AA2788914611444E030CA310E03E3CFE683902B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Int32[] UnityEngine.Mesh::get_triangles()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* Mesh_get_triangles_m33E39B4A383CC613C760FA7E297AC417A433F24B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void System.Array::CopyTo(System.Array,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB (RuntimeArray* __this, RuntimeArray* ___0_array, int32_t ___1_index, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>::.ctor()
inline void List_1__ctor_mBE9255218FAB0B859E0DD1B944986BBC7F1C3A33 (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor()
inline void List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>::Add(T)
inline void List_1_Add_m8B5DEF3F8F4F49003BB953399B6E84A6DC941AC6_inline (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* __this, List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F*, List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::Cross(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::Normalize()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.Vector3>>::get_Item(System.Int32)
inline List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075 (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* (*) (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
// T System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Item(System.Int32)
inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810 (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, int32_t, const RuntimeMethod*))List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_gshared)(__this, ___0_index, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Count()
inline int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline)(__this, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Division(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::OrthoNormalize(UnityEngine.Vector3&,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector3_OrthoNormalize_m4450C7BEB70DBFA60E3AAC08C98CDAE831A54158 (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_normal, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___1_tangent, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::Dot(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) ;
// UnityEngine.RenderTexture UnityEngine.RenderTexture::GetTemporary(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* RenderTexture_GetTemporary_m82379FD4C767A36F0677CAF4E68319EAE16ADF7F (int32_t ___0_width, int32_t ___1_height, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.RenderTexture::Create()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool RenderTexture_Create_mA6E4D3CCC84AC3F68E85AA0D6609E1692C672AD2 (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture::set_filterMode(UnityEngine.FilterMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture_set_filterMode_mE423E58C0C16D059EA62BA87AD70F44AEA50CCC9 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.GL::set_sRGBWrite(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GL_set_sRGBWrite_m28E2276D0879B7BAD039B14B10E470D312CDE0C8 (bool ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Graphics::Blit(UnityEngine.Texture,UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Graphics_Blit_m8D99E16B74C7D3C8F79F4F142C59DB6B38114504 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, const RuntimeMethod* method) ;
// System.Void UnityEngine.Graphics::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,UnityEngine.Material,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Graphics_Blit_m1875691D6AAA8CF8EDE8508538714CF895E36779 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___2_mat, int32_t ___3_pass, const RuntimeMethod* method) ;
// System.Void UnityEngine.RenderTexture::.ctor(System.Int32,System.Int32,System.Int32,UnityEngine.RenderTextureFormat,UnityEngine.RenderTextureReadWrite)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderTexture__ctor_m68A1B9CAA1BE0B597C5F4895C296E21502D0C962 (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* __this, int32_t ___0_width, int32_t ___1_height, int32_t ___2_depth, int32_t ___3_format, int32_t ___4_readWrite, const RuntimeMethod* method) ;
// UnityEngine.RenderTexture UnityEngine.RenderTexture::GetTemporary(System.Int32,System.Int32,System.Int32,UnityEngine.RenderTextureFormat,UnityEngine.RenderTextureReadWrite)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* RenderTexture_GetTemporary_mA6619EA324AAE80B6892107C6968092F6F1B4C45 (int32_t ___0_width, int32_t ___1_height, int32_t ___2_depthBuffer, int32_t ___3_format, int32_t ___4_readWrite, const RuntimeMethod* method) ;
// System.Single UnityEngine.Vector3::Magnitude(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_Start_mFF2E1CC3E9C99B6E0F82CC3AD77B637C2455F3B0 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentsInChildren_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_m68EDB1BC21CDD271AF95048193430D2BFD67C99E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1D81D3AF9B723F2D77E4987B9173B054328650BE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3AE26BC35C10AF76A289EE17081B65A3ECDB479E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3BAEF3F8883849DABF41F0396F462E7B861A32B0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4E9A903C24F8DD959F1BF4F77241BFB1848A3436);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBD6BC43E86DD63F925ABC8E3701B7F0E06FB6C94);
		s_Il2CppMethodInitialized = true;
	}
	MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_0);
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_1;
		L_1 = Component_GetComponentsInChildren_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_m68EDB1BC21CDD271AF95048193430D2BFD67C99E(L_0, Component_GetComponentsInChildren_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_m68EDB1BC21CDD271AF95048193430D2BFD67C99E_RuntimeMethod_var);
		V_0 = L_1;
		V_1 = 0;
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_2 = V_0;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_3 = V_0;
		NullCheck(L_3);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length))) >= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}

IL_0017:
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_4;
		L_4 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_4);
		String_t* L_5;
		L_5 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_4, NULL);
		String_t* L_6;
		L_6 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral3BAEF3F8883849DABF41F0396F462E7B861A32B0, L_5, _stringLiteralBD6BC43E86DD63F925ABC8E3701B7F0E06FB6C94, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E(L_6, __this, NULL);
		Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A(__this, (bool)0, NULL);
		return;
	}

IL_003f:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_7 = V_0;
		NullCheck(L_7);
		int32_t L_8 = 0;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_9 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_10;
		L_10 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_9, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_10)
		{
			goto IL_006a;
		}
	}
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_11 = V_0;
		NullCheck(L_11);
		int32_t L_12 = 0;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_13 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		NullCheck(L_13);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_14;
		L_14 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_13, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_15;
		L_15 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_14, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_15)
		{
			goto IL_006a;
		}
	}
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_16 = V_0;
		NullCheck(L_16);
		int32_t L_17 = 0;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		NullCheck(L_18);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_19;
		L_19 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_18, NULL);
		NullCheck(L_19);
		int32_t L_20;
		L_20 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_19, NULL);
		if ((((int32_t)L_20) >= ((int32_t)4)))
		{
			goto IL_0092;
		}
	}

IL_006a:
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_21;
		L_21 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_21);
		String_t* L_22;
		L_22 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_21, NULL);
		String_t* L_23;
		L_23 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral3BAEF3F8883849DABF41F0396F462E7B861A32B0, L_22, _stringLiteral4E9A903C24F8DD959F1BF4F77241BFB1848A3436, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E(L_23, __this, NULL);
		Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A(__this, (bool)0, NULL);
		return;
	}

IL_0092:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_24 = V_0;
		NullCheck(L_24);
		int32_t L_25 = 0;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_26 = (L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		NullCheck(L_26);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_27;
		L_27 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_26, NULL);
		NullCheck(L_27);
		int32_t L_28;
		L_28 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_27, NULL);
		V_1 = L_28;
		V_2 = 1;
		goto IL_00fb;
	}

IL_00a4:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_29 = V_0;
		int32_t L_30 = V_2;
		NullCheck(L_29);
		int32_t L_31 = L_30;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_33;
		L_33 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_32, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_33)
		{
			goto IL_00cf;
		}
	}
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_34 = V_0;
		int32_t L_35 = V_2;
		NullCheck(L_34);
		int32_t L_36 = L_35;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_37 = (L_34)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		NullCheck(L_37);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_38;
		L_38 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_37, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_39;
		L_39 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_38, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_39)
		{
			goto IL_00cf;
		}
	}
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_40 = V_0;
		int32_t L_41 = V_2;
		NullCheck(L_40);
		int32_t L_42 = L_41;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_43 = (L_40)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		NullCheck(L_43);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_44;
		L_44 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_43, NULL);
		NullCheck(L_44);
		int32_t L_45;
		L_45 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_44, NULL);
		int32_t L_46 = V_1;
		if ((((int32_t)L_45) == ((int32_t)L_46)))
		{
			goto IL_00f7;
		}
	}

IL_00cf:
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_47;
		L_47 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_47);
		String_t* L_48;
		L_48 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_47, NULL);
		String_t* L_49;
		L_49 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral3BAEF3F8883849DABF41F0396F462E7B861A32B0, L_48, _stringLiteral4E9A903C24F8DD959F1BF4F77241BFB1848A3436, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E(L_49, __this, NULL);
		Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A(__this, (bool)0, NULL);
		return;
	}

IL_00f7:
	{
		int32_t L_50 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_50, 1));
	}

IL_00fb:
	{
		int32_t L_51 = V_2;
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_52 = V_0;
		NullCheck(L_52);
		if ((((int32_t)L_51) < ((int32_t)((int32_t)(((RuntimeArray*)L_52)->max_length)))))
		{
			goto IL_00a4;
		}
	}
	{
		int32_t L_53 = __this->___chunkCountHorizontal_4;
		if ((((int32_t)L_53) >= ((int32_t)1)))
		{
			goto IL_0111;
		}
	}
	{
		__this->___chunkCountHorizontal_4 = 1;
	}

IL_0111:
	{
		int32_t L_54 = __this->___chunkCountVertical_5;
		if ((((int32_t)L_54) >= ((int32_t)1)))
		{
			goto IL_0121;
		}
	}
	{
		__this->___chunkCountVertical_5 = 1;
	}

IL_0121:
	{
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_55;
		L_55 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		NullCheck(L_55);
		int32_t L_56;
		L_56 = Transform_get_childCount_mE9C29C702AB662CC540CA053EDE48BDAFA35B4B0(L_55, NULL);
		int32_t L_57 = __this->___chunkCountHorizontal_4;
		int32_t L_58 = __this->___chunkCountVertical_5;
		if ((((int32_t)L_56) == ((int32_t)((int32_t)il2cpp_codegen_multiply(L_57, L_58)))))
		{
			goto IL_014e;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E(_stringLiteral1D81D3AF9B723F2D77E4987B9173B054328650BE, __this, NULL);
		Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A(__this, (bool)0, NULL);
		return;
	}

IL_014e:
	{
		int32_t L_59 = __this->___vertexCountHorizontal_6;
		if ((((int32_t)L_59) >= ((int32_t)2)))
		{
			goto IL_015e;
		}
	}
	{
		__this->___vertexCountHorizontal_6 = 2;
	}

IL_015e:
	{
		int32_t L_60 = __this->___vertexCountVertical_7;
		if ((((int32_t)L_60) >= ((int32_t)2)))
		{
			goto IL_016e;
		}
	}
	{
		__this->___vertexCountVertical_7 = 2;
	}

IL_016e:
	{
		bool L_61 = __this->___usingSkirt_9;
		if (!L_61)
		{
			goto IL_0188;
		}
	}
	{
		int32_t L_62 = V_1;
		int32_t L_63 = __this->___vertexCountHorizontal_6;
		int32_t L_64 = __this->___vertexCountVertical_7;
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_62, ((int32_t)il2cpp_codegen_multiply(2, ((int32_t)il2cpp_codegen_add(L_63, L_64))))));
	}

IL_0188:
	{
		int32_t L_65 = V_1;
		int32_t L_66 = __this->___vertexCountHorizontal_6;
		int32_t L_67 = __this->___vertexCountVertical_7;
		if ((((int32_t)L_65) == ((int32_t)((int32_t)il2cpp_codegen_multiply(L_66, L_67)))))
		{
			goto IL_01ab;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m94F967AB31244EACE68C3BE1DD85B69ED3334C0E(_stringLiteral3AE26BC35C10AF76A289EE17081B65A3ECDB479E, __this, NULL);
		Behaviour_set_enabled_mF1DCFE60EB09E0529FE9476CA804A3AA2D72B16A(__this, (bool)0, NULL);
		return;
	}

IL_01ab:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_68 = V_0;
		CompressedMeshLoader_Fix_m03CB192078D49FAEE1C6C0694FAB58C458DB980B(__this, L_68, NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::Fix(UnityEngine.MeshFilter[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_Fix_m03CB192078D49FAEE1C6C0694FAB58C458DB980B (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* ___0__childMeshFilter, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		V_0 = 0;
		V_1 = 0;
		goto IL_0043;
	}

IL_0006:
	{
		V_2 = 0;
		goto IL_002b;
	}

IL_000a:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_0 = ___0__childMeshFilter;
		int32_t L_1 = V_0;
		int32_t L_2 = V_2;
		NullCheck(L_0);
		int32_t L_3 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_4 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		NullCheck(L_4);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_5;
		L_5 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_4, NULL);
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_6 = ___0__childMeshFilter;
		int32_t L_7 = V_0;
		int32_t L_8 = V_2;
		NullCheck(L_6);
		int32_t L_9 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_7, L_8)), 1));
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_10 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_10);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_11;
		L_11 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_10, NULL);
		CompressedMeshLoader_Combine_m27AB5605E1665164BC35FABEB0E2BC61C7394529(__this, L_5, L_11, (bool)1, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002b:
	{
		int32_t L_13 = V_2;
		int32_t L_14 = __this->___chunkCountVertical_5;
		if ((((int32_t)L_13) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_14, 1)))))
		{
			goto IL_000a;
		}
	}
	{
		int32_t L_15 = V_0;
		int32_t L_16 = __this->___chunkCountVertical_5;
		V_0 = ((int32_t)il2cpp_codegen_add(L_15, L_16));
		int32_t L_17 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_17, 1));
	}

IL_0043:
	{
		int32_t L_18 = V_1;
		int32_t L_19 = __this->___chunkCountHorizontal_4;
		if ((((int32_t)L_18) < ((int32_t)L_19)))
		{
			goto IL_0006;
		}
	}
	{
		V_0 = 0;
		V_3 = 0;
		goto IL_0098;
	}

IL_0052:
	{
		V_4 = 0;
		goto IL_0081;
	}

IL_0057:
	{
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_20 = ___0__childMeshFilter;
		int32_t L_21 = V_0;
		int32_t L_22 = V_4;
		NullCheck(L_20);
		int32_t L_23 = ((int32_t)il2cpp_codegen_add(L_21, L_22));
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_24 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		NullCheck(L_24);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_25;
		L_25 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_24, NULL);
		MeshFilterU5BU5D_tCE3B457E6F7ECE5ECEE9E09150642150448685BA* L_26 = ___0__childMeshFilter;
		int32_t L_27 = V_0;
		int32_t L_28 = V_4;
		int32_t L_29 = __this->___chunkCountVertical_5;
		NullCheck(L_26);
		int32_t L_30 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_27, L_28)), L_29));
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_31 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		NullCheck(L_31);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_32;
		L_32 = MeshFilter_get_sharedMesh_mE4ED3E7E31C1DE5097E4980DA996E620F7D7CB8C(L_31, NULL);
		CompressedMeshLoader_Combine_m27AB5605E1665164BC35FABEB0E2BC61C7394529(__this, L_25, L_32, (bool)0, NULL);
		int32_t L_33 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_0081:
	{
		int32_t L_34 = V_4;
		int32_t L_35 = __this->___chunkCountVertical_5;
		if ((((int32_t)L_34) < ((int32_t)L_35)))
		{
			goto IL_0057;
		}
	}
	{
		int32_t L_36 = V_0;
		int32_t L_37 = __this->___chunkCountVertical_5;
		V_0 = ((int32_t)il2cpp_codegen_add(L_36, L_37));
		int32_t L_38 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_38, 1));
	}

IL_0098:
	{
		int32_t L_39 = V_3;
		int32_t L_40 = __this->___chunkCountHorizontal_4;
		if ((((int32_t)L_39) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_40, 1)))))
		{
			goto IL_0052;
		}
	}
	{
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::GetMeshData(UnityEngine.Mesh,VacuumShaders.TerrainToMesh.CompressedMeshLoader/SIDE,UnityEngine.Vector3[]&,UnityEngine.Vector2[]&,UnityEngine.Vector2[]&,UnityEngine.Vector3[]&,UnityEngine.Vector4[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_GetMeshData_mAE6F45F1FC31543D14D29332671CD6AC0019A479 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__mesh, int32_t ___1__side, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___2_vertices, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___3_uv, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___4_uv2, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___5_normal, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** ___6_tangent, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_1 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_2 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_3 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_4 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_5 = NULL;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	int32_t V_10 = 0;
	int32_t V_11 = 0;
	int32_t G_B4_0 = 0;
	int32_t G_B8_0 = 0;
	int32_t G_B12_0 = 0;
	int32_t G_B16_0 = 0;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B18_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B17_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* G_B19_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B19_1 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B21_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B20_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* G_B22_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** G_B22_1 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** G_B24_0 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** G_B23_0 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* G_B25_0 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** G_B25_1 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** G_B27_0 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** G_B26_0 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* G_B28_0 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** G_B28_1 = NULL;
	{
		int32_t L_0 = ___1__side;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1;
		L_1 = CompressedMeshLoader_GetIndexies_m69A354853534948AFFCF7ED9F743AD5BCABE779F(__this, L_0, NULL);
		V_0 = L_1;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_2 = ___0__mesh;
		NullCheck(L_2);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_3;
		L_3 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_2, NULL);
		V_1 = L_3;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_4 = ___0__mesh;
		NullCheck(L_4);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_5;
		L_5 = Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F(L_4, NULL);
		V_2 = L_5;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_6 = ___0__mesh;
		NullCheck(L_6);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_7;
		L_7 = Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F(L_6, NULL);
		V_3 = L_7;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_8 = ___0__mesh;
		NullCheck(L_8);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_9;
		L_9 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_8, NULL);
		V_4 = L_9;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_10 = ___0__mesh;
		NullCheck(L_10);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_11;
		L_11 = Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E(L_10, NULL);
		V_5 = L_11;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_12 = ___0__mesh;
		NullCheck(L_12);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_13;
		L_13 = Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F(L_12, NULL);
		if (!L_13)
		{
			goto IL_004a;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_14 = ___0__mesh;
		NullCheck(L_14);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_15;
		L_15 = Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F(L_14, NULL);
		NullCheck(L_15);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_16 = ___0__mesh;
		NullCheck(L_16);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_17;
		L_17 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_16, NULL);
		NullCheck(L_17);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_15)->max_length))) == ((uint32_t)((int32_t)(((RuntimeArray*)L_17)->max_length))))))
		{
			goto IL_004a;
		}
	}
	{
		G_B4_0 = 1;
		goto IL_004b;
	}

IL_004a:
	{
		G_B4_0 = 0;
	}

IL_004b:
	{
		V_6 = (bool)G_B4_0;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_18 = ___0__mesh;
		NullCheck(L_18);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_19;
		L_19 = Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F(L_18, NULL);
		if (!L_19)
		{
			goto IL_006a;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_20 = ___0__mesh;
		NullCheck(L_20);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_21;
		L_21 = Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F(L_20, NULL);
		NullCheck(L_21);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_22 = ___0__mesh;
		NullCheck(L_22);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_23;
		L_23 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_22, NULL);
		NullCheck(L_23);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_21)->max_length))) == ((uint32_t)((int32_t)(((RuntimeArray*)L_23)->max_length))))))
		{
			goto IL_006a;
		}
	}
	{
		G_B8_0 = 1;
		goto IL_006b;
	}

IL_006a:
	{
		G_B8_0 = 0;
	}

IL_006b:
	{
		V_7 = (bool)G_B8_0;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_24 = ___0__mesh;
		NullCheck(L_24);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_25;
		L_25 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_24, NULL);
		if (!L_25)
		{
			goto IL_008a;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_26 = ___0__mesh;
		NullCheck(L_26);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_27;
		L_27 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_26, NULL);
		NullCheck(L_27);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_28 = ___0__mesh;
		NullCheck(L_28);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29;
		L_29 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_28, NULL);
		NullCheck(L_29);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_27)->max_length))) == ((uint32_t)((int32_t)(((RuntimeArray*)L_29)->max_length))))))
		{
			goto IL_008a;
		}
	}
	{
		G_B12_0 = 1;
		goto IL_008b;
	}

IL_008a:
	{
		G_B12_0 = 0;
	}

IL_008b:
	{
		V_8 = (bool)G_B12_0;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_30 = ___0__mesh;
		NullCheck(L_30);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_31;
		L_31 = Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E(L_30, NULL);
		if (!L_31)
		{
			goto IL_00aa;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_32 = ___0__mesh;
		NullCheck(L_32);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_33;
		L_33 = Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E(L_32, NULL);
		NullCheck(L_33);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_34 = ___0__mesh;
		NullCheck(L_34);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_35;
		L_35 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_34, NULL);
		NullCheck(L_35);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_33)->max_length))) == ((uint32_t)((int32_t)(((RuntimeArray*)L_35)->max_length))))))
		{
			goto IL_00aa;
		}
	}
	{
		G_B16_0 = 1;
		goto IL_00ab;
	}

IL_00aa:
	{
		G_B16_0 = 0;
	}

IL_00ab:
	{
		V_9 = (bool)G_B16_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_36 = ___2_vertices;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_37 = V_0;
		NullCheck(L_37);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_37)->max_length)));
		*((RuntimeObject**)L_36) = (RuntimeObject*)L_38;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_36, (void*)(RuntimeObject*)L_38);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_39 = ___3_uv;
		bool L_40 = V_6;
		G_B17_0 = L_39;
		if (L_40)
		{
			G_B18_0 = L_39;
			goto IL_00c0;
		}
	}
	{
		G_B19_0 = ((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(NULL));
		G_B19_1 = G_B17_0;
		goto IL_00c8;
	}

IL_00c0:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_41 = V_0;
		NullCheck(L_41);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_42 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_41)->max_length)));
		G_B19_0 = L_42;
		G_B19_1 = G_B18_0;
	}

IL_00c8:
	{
		*((RuntimeObject**)G_B19_1) = (RuntimeObject*)G_B19_0;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)G_B19_1, (void*)(RuntimeObject*)G_B19_0);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_43 = ___4_uv2;
		bool L_44 = V_7;
		G_B20_0 = L_43;
		if (L_44)
		{
			G_B21_0 = L_43;
			goto IL_00d2;
		}
	}
	{
		G_B22_0 = ((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(NULL));
		G_B22_1 = G_B20_0;
		goto IL_00da;
	}

IL_00d2:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_45 = V_0;
		NullCheck(L_45);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_46 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_45)->max_length)));
		G_B22_0 = L_46;
		G_B22_1 = G_B21_0;
	}

IL_00da:
	{
		*((RuntimeObject**)G_B22_1) = (RuntimeObject*)G_B22_0;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)G_B22_1, (void*)(RuntimeObject*)G_B22_0);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_47 = ___5_normal;
		bool L_48 = V_8;
		G_B23_0 = L_47;
		if (L_48)
		{
			G_B24_0 = L_47;
			goto IL_00e4;
		}
	}
	{
		G_B25_0 = ((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(NULL));
		G_B25_1 = G_B23_0;
		goto IL_00ec;
	}

IL_00e4:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_49 = V_0;
		NullCheck(L_49);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_49)->max_length)));
		G_B25_0 = L_50;
		G_B25_1 = G_B24_0;
	}

IL_00ec:
	{
		*((RuntimeObject**)G_B25_1) = (RuntimeObject*)G_B25_0;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)G_B25_1, (void*)(RuntimeObject*)G_B25_0);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_51 = ___6_tangent;
		bool L_52 = V_9;
		G_B26_0 = L_51;
		if (L_52)
		{
			G_B27_0 = L_51;
			goto IL_00f6;
		}
	}
	{
		G_B28_0 = ((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)(NULL));
		G_B28_1 = G_B26_0;
		goto IL_00fe;
	}

IL_00f6:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_53 = V_0;
		NullCheck(L_53);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_54 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)SZArrayNew(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_53)->max_length)));
		G_B28_0 = L_54;
		G_B28_1 = G_B27_0;
	}

IL_00fe:
	{
		*((RuntimeObject**)G_B28_1) = (RuntimeObject*)G_B28_0;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)G_B28_1, (void*)(RuntimeObject*)G_B28_0);
		V_10 = 0;
		goto IL_017b;
	}

IL_0104:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_55 = V_0;
		int32_t L_56 = V_10;
		NullCheck(L_55);
		int32_t L_57 = L_56;
		int32_t L_58 = (L_55)->GetAt(static_cast<il2cpp_array_size_t>(L_57));
		V_11 = L_58;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_59 = ___2_vertices;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_60 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_59);
		int32_t L_61 = V_10;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_62 = V_1;
		int32_t L_63 = V_11;
		NullCheck(L_62);
		int32_t L_64 = L_63;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		NullCheck(L_60);
		(L_60)->SetAt(static_cast<il2cpp_array_size_t>(L_61), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_65);
		bool L_66 = V_6;
		if (!L_66)
		{
			goto IL_0131;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_67 = ___3_uv;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_68 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_67);
		int32_t L_69 = V_10;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_70 = V_2;
		int32_t L_71 = V_11;
		NullCheck(L_70);
		int32_t L_72 = L_71;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_73 = (L_70)->GetAt(static_cast<il2cpp_array_size_t>(L_72));
		NullCheck(L_68);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(L_69), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_73);
	}

IL_0131:
	{
		bool L_74 = V_7;
		if (!L_74)
		{
			goto IL_0147;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_75 = ___4_uv2;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_76 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_75);
		int32_t L_77 = V_10;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_78 = V_3;
		int32_t L_79 = V_11;
		NullCheck(L_78);
		int32_t L_80 = L_79;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_81 = (L_78)->GetAt(static_cast<il2cpp_array_size_t>(L_80));
		NullCheck(L_76);
		(L_76)->SetAt(static_cast<il2cpp_array_size_t>(L_77), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_81);
	}

IL_0147:
	{
		bool L_82 = V_8;
		if (!L_82)
		{
			goto IL_015e;
		}
	}
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_83 = ___5_normal;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_84 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_83);
		int32_t L_85 = V_10;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_86 = V_4;
		int32_t L_87 = V_11;
		NullCheck(L_86);
		int32_t L_88 = L_87;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_89 = (L_86)->GetAt(static_cast<il2cpp_array_size_t>(L_88));
		NullCheck(L_84);
		(L_84)->SetAt(static_cast<il2cpp_array_size_t>(L_85), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_89);
	}

IL_015e:
	{
		bool L_90 = V_9;
		if (!L_90)
		{
			goto IL_0175;
		}
	}
	{
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_91 = ___6_tangent;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_92 = *((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD**)L_91);
		int32_t L_93 = V_10;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_94 = V_5;
		int32_t L_95 = V_11;
		NullCheck(L_94);
		int32_t L_96 = L_95;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_97 = (L_94)->GetAt(static_cast<il2cpp_array_size_t>(L_96));
		NullCheck(L_92);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3)L_97);
	}

IL_0175:
	{
		int32_t L_98 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add(L_98, 1));
	}

IL_017b:
	{
		int32_t L_99 = V_10;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_100 = V_0;
		NullCheck(L_100);
		if ((((int32_t)L_99) < ((int32_t)((int32_t)(((RuntimeArray*)L_100)->max_length)))))
		{
			goto IL_0104;
		}
	}
	{
		return;
	}
}
// System.Int32[] VacuumShaders.TerrainToMesh.CompressedMeshLoader::GetIndexies(VacuumShaders.TerrainToMesh.CompressedMeshLoader/SIDE)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* CompressedMeshLoader_GetIndexies_m69A354853534948AFFCF7ED9F743AD5BCABE779F (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, int32_t ___0__side, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t G_B4_0 = 0;
	{
		int32_t L_0 = ___0__side;
		if (!L_0)
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_1 = ___0__side;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_2 = __this->___vertexCountHorizontal_6;
		G_B4_0 = L_2;
		goto IL_0015;
	}

IL_000f:
	{
		int32_t L_3 = __this->___vertexCountVertical_7;
		G_B4_0 = L_3;
	}

IL_0015:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)G_B4_0);
		V_0 = L_4;
		int32_t L_5 = ___0__side;
		switch (L_5)
		{
			case 0:
			{
				goto IL_0079;
			}
			case 1:
			{
				goto IL_00a4;
			}
			case 2:
			{
				goto IL_0050;
			}
			case 3:
			{
				goto IL_0036;
			}
		}
	}
	{
		goto IL_00d6;
	}

IL_0036:
	{
		V_1 = 0;
		goto IL_0042;
	}

IL_003a:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = V_0;
		int32_t L_7 = V_1;
		int32_t L_8 = V_1;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (int32_t)L_8);
		int32_t L_9 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_9, 1));
	}

IL_0042:
	{
		int32_t L_10 = V_1;
		int32_t L_11 = __this->___vertexCountHorizontal_6;
		if ((((int32_t)L_10) < ((int32_t)L_11)))
		{
			goto IL_003a;
		}
	}
	{
		goto IL_00f0;
	}

IL_0050:
	{
		int32_t L_12 = __this->___vertexCountHorizontal_6;
		int32_t L_13 = __this->___vertexCountVertical_7;
		V_2 = ((int32_t)il2cpp_codegen_multiply(L_12, ((int32_t)il2cpp_codegen_subtract(L_13, 1))));
		V_3 = 0;
		goto IL_006e;
	}

IL_0064:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_14 = V_0;
		int32_t L_15 = V_3;
		int32_t L_16 = V_2;
		int32_t L_17 = V_3;
		NullCheck(L_14);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(L_15), (int32_t)((int32_t)il2cpp_codegen_add(L_16, L_17)));
		int32_t L_18 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_006e:
	{
		int32_t L_19 = V_3;
		int32_t L_20 = __this->___vertexCountHorizontal_6;
		if ((((int32_t)L_19) < ((int32_t)L_20)))
		{
			goto IL_0064;
		}
	}
	{
		goto IL_00f0;
	}

IL_0079:
	{
		V_4 = 0;
		V_5 = 0;
		goto IL_0098;
	}

IL_0081:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_21 = V_0;
		int32_t L_22 = V_5;
		int32_t L_23 = V_4;
		NullCheck(L_21);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(L_22), (int32_t)L_23);
		int32_t L_24 = V_4;
		int32_t L_25 = __this->___vertexCountHorizontal_6;
		V_4 = ((int32_t)il2cpp_codegen_add(L_24, L_25));
		int32_t L_26 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_26, 1));
	}

IL_0098:
	{
		int32_t L_27 = V_5;
		int32_t L_28 = __this->___vertexCountVertical_7;
		if ((((int32_t)L_27) < ((int32_t)L_28)))
		{
			goto IL_0081;
		}
	}
	{
		goto IL_00f0;
	}

IL_00a4:
	{
		int32_t L_29 = __this->___vertexCountHorizontal_6;
		V_6 = ((int32_t)il2cpp_codegen_subtract(L_29, 1));
		V_7 = 0;
		goto IL_00ca;
	}

IL_00b3:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_30 = V_0;
		int32_t L_31 = V_7;
		int32_t L_32 = V_6;
		NullCheck(L_30);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(L_31), (int32_t)L_32);
		int32_t L_33 = V_6;
		int32_t L_34 = __this->___vertexCountHorizontal_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_33, L_34));
		int32_t L_35 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_35, 1));
	}

IL_00ca:
	{
		int32_t L_36 = V_7;
		int32_t L_37 = __this->___vertexCountVertical_7;
		if ((((int32_t)L_36) < ((int32_t)L_37)))
		{
			goto IL_00b3;
		}
	}
	{
		goto IL_00f0;
	}

IL_00d6:
	{
		V_8 = 0;
		goto IL_00e6;
	}

IL_00db:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_38 = V_0;
		int32_t L_39 = V_8;
		NullCheck(L_38);
		(L_38)->SetAt(static_cast<il2cpp_array_size_t>(L_39), (int32_t)0);
		int32_t L_40 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_40, 1));
	}

IL_00e6:
	{
		int32_t L_41 = V_8;
		int32_t L_42 = __this->___vertexCountHorizontal_6;
		if ((((int32_t)L_41) < ((int32_t)L_42)))
		{
			goto IL_00db;
		}
	}

IL_00f0:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_43 = V_0;
		return L_43;
	}
}
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::Combine(UnityEngine.Mesh,UnityEngine.Mesh,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader_Combine_m27AB5605E1665164BC35FABEB0E2BC61C7394529 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__meshBottom, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___1__meshTop, bool ___2_bottomTop, const RuntimeMethod* method) 
{
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_0 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_1 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_2 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_3 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_4 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_5 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_6 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_7 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_8 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_9 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_10 = NULL;
	int32_t V_11 = 0;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B2_0 = NULL;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B2_1 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B1_0 = NULL;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B1_1 = NULL;
	int32_t G_B3_0 = 0;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B3_1 = NULL;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B3_2 = NULL;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B5_0 = NULL;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* G_B6_1 = NULL;
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_0 = ___0__meshBottom;
		bool L_1 = ___2_bottomTop;
		G_B1_0 = L_0;
		G_B1_1 = __this;
		if (L_1)
		{
			G_B2_0 = L_0;
			G_B2_1 = __this;
			goto IL_0008;
		}
	}
	{
		G_B3_0 = 1;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		goto IL_0009;
	}

IL_0008:
	{
		G_B3_0 = 2;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
	}

IL_0009:
	{
		NullCheck(G_B3_2);
		CompressedMeshLoader_GetMeshData_mAE6F45F1FC31543D14D29332671CD6AC0019A479(G_B3_2, G_B3_1, G_B3_0, (&V_0), (&V_1), (&V_2), (&V_3), (&V_4), NULL);
		bool L_2 = ___2_bottomTop;
		G_B4_0 = __this;
		if (L_2)
		{
			G_B5_0 = __this;
			goto IL_001f;
		}
	}
	{
		G_B6_0 = 0;
		G_B6_1 = G_B4_0;
		goto IL_0020;
	}

IL_001f:
	{
		G_B6_0 = 3;
		G_B6_1 = G_B5_0;
	}

IL_0020:
	{
		NullCheck(G_B6_1);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3;
		L_3 = CompressedMeshLoader_GetIndexies_m69A354853534948AFFCF7ED9F743AD5BCABE779F(G_B6_1, G_B6_0, NULL);
		V_5 = L_3;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_4 = ___1__meshTop;
		NullCheck(L_4);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_5;
		L_5 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_4, NULL);
		V_6 = L_5;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_6 = ___1__meshTop;
		NullCheck(L_6);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_7;
		L_7 = Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F(L_6, NULL);
		V_7 = L_7;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_8 = ___1__meshTop;
		NullCheck(L_8);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_9;
		L_9 = Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F(L_8, NULL);
		V_8 = L_9;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_10 = ___1__meshTop;
		NullCheck(L_10);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_11;
		L_11 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_10, NULL);
		V_9 = L_11;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_12 = ___1__meshTop;
		NullCheck(L_12);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_13;
		L_13 = Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E(L_12, NULL);
		V_10 = L_13;
		V_11 = 0;
		goto IL_00cc;
	}

IL_0054:
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_14 = V_6;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_15 = V_5;
		int32_t L_16 = V_11;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		int32_t L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_19 = V_0;
		int32_t L_20 = V_11;
		NullCheck(L_19);
		int32_t L_21 = L_20;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		NullCheck(L_14);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(L_18), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_22);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_23 = V_1;
		if (!L_23)
		{
			goto IL_007f;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_24 = V_7;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_25 = V_5;
		int32_t L_26 = V_11;
		NullCheck(L_25);
		int32_t L_27 = L_26;
		int32_t L_28 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_29 = V_1;
		int32_t L_30 = V_11;
		NullCheck(L_29);
		int32_t L_31 = L_30;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(L_28), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_32);
	}

IL_007f:
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_33 = V_2;
		if (!L_33)
		{
			goto IL_0096;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_34 = V_8;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_35 = V_5;
		int32_t L_36 = V_11;
		NullCheck(L_35);
		int32_t L_37 = L_36;
		int32_t L_38 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_37));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_39 = V_2;
		int32_t L_40 = V_11;
		NullCheck(L_39);
		int32_t L_41 = L_40;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_42 = (L_39)->GetAt(static_cast<il2cpp_array_size_t>(L_41));
		NullCheck(L_34);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(L_38), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_42);
	}

IL_0096:
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_43 = V_3;
		if (!L_43)
		{
			goto IL_00ad;
		}
	}
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_44 = V_9;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_45 = V_5;
		int32_t L_46 = V_11;
		NullCheck(L_45);
		int32_t L_47 = L_46;
		int32_t L_48 = (L_45)->GetAt(static_cast<il2cpp_array_size_t>(L_47));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_49 = V_3;
		int32_t L_50 = V_11;
		NullCheck(L_49);
		int32_t L_51 = L_50;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52 = (L_49)->GetAt(static_cast<il2cpp_array_size_t>(L_51));
		NullCheck(L_44);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(L_48), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_52);
	}

IL_00ad:
	{
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_53 = V_4;
		if (!L_53)
		{
			goto IL_00c6;
		}
	}
	{
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_54 = V_10;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_55 = V_5;
		int32_t L_56 = V_11;
		NullCheck(L_55);
		int32_t L_57 = L_56;
		int32_t L_58 = (L_55)->GetAt(static_cast<il2cpp_array_size_t>(L_57));
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_59 = V_4;
		int32_t L_60 = V_11;
		NullCheck(L_59);
		int32_t L_61 = L_60;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_62 = (L_59)->GetAt(static_cast<il2cpp_array_size_t>(L_61));
		NullCheck(L_54);
		(L_54)->SetAt(static_cast<il2cpp_array_size_t>(L_58), (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3)L_62);
	}

IL_00c6:
	{
		int32_t L_63 = V_11;
		V_11 = ((int32_t)il2cpp_codegen_add(L_63, 1));
	}

IL_00cc:
	{
		int32_t L_64 = V_11;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_65 = V_0;
		NullCheck(L_65);
		if ((((int32_t)L_64) < ((int32_t)((int32_t)(((RuntimeArray*)L_65)->max_length)))))
		{
			goto IL_0054;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_66 = ___1__meshTop;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_67 = V_6;
		NullCheck(L_66);
		Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C(L_66, L_67, NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_68 = V_1;
		if (!L_68)
		{
			goto IL_00ee;
		}
	}
	{
		bool L_69 = __this->___usingPerChunkBasemap_8;
		if (L_69)
		{
			goto IL_00ee;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_70 = ___1__meshTop;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_71 = V_7;
		NullCheck(L_70);
		Mesh_set_uv_m6ED9C50E0DA8166DD48AC40FD6C828B9AD2E9617(L_70, L_71, NULL);
	}

IL_00ee:
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_72 = V_2;
		if (!L_72)
		{
			goto IL_00f9;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_73 = ___1__meshTop;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_74 = V_8;
		NullCheck(L_73);
		Mesh_set_uv2_m37B442C04EBB029C0AD9545C54F95D9BDAD8E9B5(L_73, L_74, NULL);
	}

IL_00f9:
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_75 = V_3;
		if (!L_75)
		{
			goto IL_0104;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_76 = ___1__meshTop;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_77 = V_9;
		NullCheck(L_76);
		Mesh_set_normals_m85D73193C49211BE9FA135FF72D5749B16A4760B(L_76, L_77, NULL);
	}

IL_0104:
	{
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_78 = V_4;
		if (!L_78)
		{
			goto IL_0110;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_79 = ___1__meshTop;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_80 = V_10;
		NullCheck(L_79);
		Mesh_set_tangents_mF547B7E4F9C70FB7CD6168139180A70AD306169B(L_79, L_80, NULL);
	}

IL_0110:
	{
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.CompressedMeshLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompressedMeshLoader__ctor_m364EACCEE66055D140322C3707076629883575D2 (CompressedMeshLoader_tB2DFACCD263819A0677130F862621C4498607BC8* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void VacuumShaders.TerrainToMesh.TerrainConvertInfo::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainConvertInfo__ctor_mFB8735B68A94E3F8C7620B16D3023512CCB3E2FE (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		TerrainConvertInfo_Reset_m33D17DB183B77F1912C837A24D5BD489E5C45B29(__this, NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainConvertInfo::.ctor(VacuumShaders.TerrainToMesh.TerrainConvertInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainConvertInfo__ctor_m25143996DA4F375690725BFF7B884603D95A3535 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* ___0__right, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_0 = ___0__right;
		NullCheck(L_0);
		int32_t L_1 = L_0->___chunkCountHorizontal_1;
		__this->___chunkCountHorizontal_1 = L_1;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_2 = ___0__right;
		NullCheck(L_2);
		int32_t L_3 = L_2->___chunkCountVertical_2;
		__this->___chunkCountVertical_2 = L_3;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_4 = ___0__right;
		NullCheck(L_4);
		int32_t L_5 = L_4->___vertexCountHorizontal_3;
		__this->___vertexCountHorizontal_3 = L_5;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_6 = ___0__right;
		NullCheck(L_6);
		int32_t L_7 = L_6->___vertexCountVertical_4;
		__this->___vertexCountVertical_4 = L_7;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_8 = ___0__right;
		NullCheck(L_8);
		bool L_9 = L_8->___generateSkirt_5;
		__this->___generateSkirt_5 = L_9;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_10 = ___0__right;
		NullCheck(L_10);
		float L_11 = L_10->___skirtGroundLevel_6;
		__this->___skirtGroundLevel_6 = L_11;
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainConvertInfo::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainConvertInfo_Reset_m33D17DB183B77F1912C837A24D5BD489E5C45B29 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	{
		__this->___chunkCountHorizontal_1 = 1;
		__this->___chunkCountVertical_2 = 1;
		__this->___vertexCountHorizontal_3 = ((int32_t)25);
		__this->___vertexCountVertical_4 = ((int32_t)25);
		__this->___generateSkirt_5 = (bool)0;
		__this->___skirtGroundLevel_6 = (0.0f);
		return;
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetChunkCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetChunkCount_mD6CC2B383FDA836FDD37B3B48FD8F82E28C19063 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___chunkCountHorizontal_1;
		if ((((int32_t)L_0) >= ((int32_t)1)))
		{
			goto IL_0010;
		}
	}
	{
		__this->___chunkCountHorizontal_1 = 1;
	}

IL_0010:
	{
		int32_t L_1 = __this->___chunkCountVertical_2;
		if ((((int32_t)L_1) >= ((int32_t)1)))
		{
			goto IL_0020;
		}
	}
	{
		__this->___chunkCountVertical_2 = 1;
	}

IL_0020:
	{
		int32_t L_2 = __this->___chunkCountHorizontal_1;
		int32_t L_3 = __this->___chunkCountVertical_2;
		return ((int32_t)il2cpp_codegen_multiply(L_2, L_3));
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetVertexCountPerChunk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetVertexCountPerChunk_mF6B86EEC8CF6C71D24E570763057478FE478F6F9 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		V_0 = 0;
		bool L_0 = __this->___generateSkirt_5;
		if (!L_0)
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_1 = __this->___vertexCountHorizontal_3;
		int32_t L_2 = __this->___vertexCountVertical_4;
		V_0 = ((int32_t)il2cpp_codegen_multiply(2, ((int32_t)il2cpp_codegen_add(L_1, L_2))));
	}

IL_001a:
	{
		int32_t L_3 = __this->___vertexCountHorizontal_3;
		int32_t L_4 = __this->___vertexCountVertical_4;
		int32_t L_5 = V_0;
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_3, L_4)), L_5));
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetVertexCountTotal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetVertexCountTotal_m97CB4AFEAE7F68137170F793FF11FE5DAC6573C4 (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0;
		L_0 = TerrainConvertInfo_GetChunkCount_mD6CC2B383FDA836FDD37B3B48FD8F82E28C19063(__this, NULL);
		int32_t L_1;
		L_1 = TerrainConvertInfo_GetVertexCountPerChunk_mF6B86EEC8CF6C71D24E570763057478FE478F6F9(__this, NULL);
		return ((int32_t)il2cpp_codegen_multiply(L_0, L_1));
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetTriangleCountPerChunk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetTriangleCountPerChunk_m43D15F98EDC732CBE72CABCD7A2856A078E8C2FF (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		V_0 = 0;
		bool L_0 = __this->___generateSkirt_5;
		if (!L_0)
		{
			goto IL_001c;
		}
	}
	{
		int32_t L_1 = __this->___vertexCountHorizontal_3;
		int32_t L_2 = __this->___vertexCountVertical_4;
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(2, ((int32_t)il2cpp_codegen_add(L_1, L_2)))), 2));
	}

IL_001c:
	{
		int32_t L_3 = __this->___vertexCountHorizontal_3;
		int32_t L_4 = __this->___vertexCountVertical_4;
		int32_t L_5 = V_0;
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_3, 1)), ((int32_t)il2cpp_codegen_subtract(L_4, 1)))), 2)), L_5));
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainConvertInfo::GetTriangleCountTotal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainConvertInfo_GetTriangleCountTotal_m210FF6038351DEA689E0C7D794C44998E652CB3D (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0;
		L_0 = TerrainConvertInfo_GetChunkCount_mD6CC2B383FDA836FDD37B3B48FD8F82E28C19063(__this, NULL);
		int32_t L_1;
		L_1 = TerrainConvertInfo_GetTriangleCountPerChunk_m43D15F98EDC732CBE72CABCD7A2856A078E8C2FF(__this, NULL);
		return ((int32_t)il2cpp_codegen_multiply(L_0, L_1));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Mesh[] VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Convert(UnityEngine.Terrain,VacuumShaders.TerrainToMesh.TerrainConvertInfo,System.Boolean,VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* TerrainToMeshConverter_Convert_m8A37EF25CFD3F9878F1BABC03A66E80D9E00266C (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* ___1__terrainConvertInfo, bool ___2__normalizeUV, ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* ___3__callback, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5CFE8923806CDDAAD3F303E0C2ED3D9A4B5008EE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6DC06A97CD7BB70F5ECDB0405BECBB5EDCFD1923);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral814A81152C9DCF6898084A33A69BA57D08BF6A9B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral94064E2D96DF1C4B6EFDC5807CDD156B50F5179A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE5EE957CF9978795A3D9DF30B3186097186F4640);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_1;
	memset((&V_1), 0, sizeof(V_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* V_3 = NULL;
	PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* V_4 = NULL;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	float V_8 = 0.0f;
	float V_9 = 0.0f;
	float V_10 = 0.0f;
	float V_11 = 0.0f;
	int32_t V_12 = 0;
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteral814A81152C9DCF6898084A33A69BA57D08BF6A9B, NULL);
		return (MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)NULL;
	}

IL_0015:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_2 = ___1__terrainConvertInfo;
		if (L_2)
		{
			goto IL_001f;
		}
	}
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_3 = (TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D*)il2cpp_codegen_object_new(TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		TerrainConvertInfo__ctor_mFB8735B68A94E3F8C7620B16D3023512CCB3E2FE(L_3, NULL);
		___1__terrainConvertInfo = L_3;
	}

IL_001f:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_4 = ___1__terrainConvertInfo;
		NullCheck(L_4);
		int32_t L_5 = L_4->___chunkCountHorizontal_1;
		if ((((int32_t)L_5) >= ((int32_t)1)))
		{
			goto IL_002f;
		}
	}
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_6 = ___1__terrainConvertInfo;
		NullCheck(L_6);
		L_6->___chunkCountHorizontal_1 = 1;
	}

IL_002f:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_7 = ___1__terrainConvertInfo;
		NullCheck(L_7);
		int32_t L_8 = L_7->___chunkCountVertical_2;
		if ((((int32_t)L_8) >= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_9 = ___1__terrainConvertInfo;
		NullCheck(L_9);
		L_9->___chunkCountVertical_2 = 1;
	}

IL_003f:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_10 = ___1__terrainConvertInfo;
		NullCheck(L_10);
		int32_t L_11 = L_10->___vertexCountHorizontal_3;
		if ((((int32_t)L_11) >= ((int32_t)2)))
		{
			goto IL_004f;
		}
	}
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_12 = ___1__terrainConvertInfo;
		NullCheck(L_12);
		L_12->___vertexCountHorizontal_3 = 2;
	}

IL_004f:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_13 = ___1__terrainConvertInfo;
		NullCheck(L_13);
		int32_t L_14 = L_13->___vertexCountVertical_4;
		if ((((int32_t)L_14) >= ((int32_t)2)))
		{
			goto IL_005f;
		}
	}
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_15 = ___1__terrainConvertInfo;
		NullCheck(L_15);
		L_15->___vertexCountVertical_4 = 2;
	}

IL_005f:
	{
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_16 = ___1__terrainConvertInfo;
		NullCheck(L_16);
		int32_t L_17;
		L_17 = TerrainConvertInfo_GetVertexCountPerChunk_mF6B86EEC8CF6C71D24E570763057478FE478F6F9(L_16, NULL);
		if ((((int32_t)L_17) <= ((int32_t)((int32_t)65000))))
		{
			goto IL_0078;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteral94064E2D96DF1C4B6EFDC5807CDD156B50F5179A, NULL);
		return (MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)NULL;
	}

IL_0078:
	{
		ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* L_18 = ___3__callback;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___callback_2 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___callback_2), (void*)L_18);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_19 = ___0__terrain;
		NullCheck(L_19);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_20;
		L_20 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_19, NULL);
		NullCheck(L_20);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_21;
		L_21 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_20, NULL);
		V_0 = L_21;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_22 = ___0__terrain;
		NullCheck(L_22);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_23;
		L_23 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_22, NULL);
		NullCheck(L_23);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_24;
		L_24 = Transform_get_rotation_m32AF40CA0D50C797DA639A696F8EAEC7524C179C(L_23, NULL);
		V_1 = L_24;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_25 = ___0__terrain;
		NullCheck(L_25);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_26;
		L_26 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_25, NULL);
		NullCheck(L_26);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_27;
		L_27 = Transform_get_localScale_m804A002A53A645CDFCD15BB0F37209162720363F(L_26, NULL);
		V_2 = L_27;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_28 = ___0__terrain;
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0 = L_28;
		Il2CppCodeGenWriteBarrier((void**)(&((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0), (void*)L_28);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_29 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_29);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_30;
		L_30 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_29, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31;
		L_31 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		NullCheck(L_30);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_30, L_31, NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_32 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_32);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_33;
		L_33 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_32, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_34;
		L_34 = Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline(NULL);
		NullCheck(L_33);
		Transform_set_rotation_m61340DE74726CF0F9946743A727C4D444397331D(L_33, L_34, NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_35 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_35);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_36;
		L_36 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_35, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_get_one_mC9B289F1E15C42C597180C9FE6FB492495B51D02_inline(NULL);
		NullCheck(L_36);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_36, L_37, NULL);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_38 = ___1__terrainConvertInfo;
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1 = L_38;
		Il2CppCodeGenWriteBarrier((void**)(&((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1), (void*)L_38);
		V_3 = (MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)NULL;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_39 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_39);
		int32_t L_40 = L_39->___chunkCountHorizontal_1;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_41 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_41);
		int32_t L_42 = L_41->___chunkCountVertical_2;
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_multiply(L_40, L_42))) == ((uint32_t)1))))
		{
			goto IL_0118;
		}
	}
	{
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_43 = (MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)(MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)SZArrayNew(MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689_il2cpp_TypeInfo_var, (uint32_t)1);
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_44 = L_43;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_45;
		L_45 = TerrainToMeshConverter_GenerateTerrain_mA5AA623B54893CFD3735DFFF64C6032B525E0F20(NULL);
		NullCheck(L_44);
		ArrayElementTypeCheck (L_44, L_45);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(0), (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*)L_45);
		V_3 = L_44;
		goto IL_0256;
	}

IL_0118:
	{
		V_4 = (PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B*)NULL;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_GenerateTerrainBaseChunks_m8F805CFFC5B087C619E46746492E0C180782D89E((&V_4), NULL);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_46 = V_4;
		NullCheck(L_46);
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_47 = (MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)(MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689*)SZArrayNew(MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_46)->max_length)));
		V_3 = L_47;
		V_5 = (-1);
		V_6 = 0;
		goto IL_0245;
	}

IL_0137:
	{
		V_7 = 0;
		goto IL_022e;
	}

IL_013f:
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_48 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_48);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_49;
		L_49 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_48, NULL);
		NullCheck(L_49);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_49, NULL);
		float L_51 = L_50.___x_2;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_52 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_52);
		int32_t L_53 = L_52->___chunkCountHorizontal_1;
		V_8 = ((float)(L_51/((float)L_53)));
		int32_t L_54 = V_6;
		float L_55 = V_8;
		V_9 = ((float)il2cpp_codegen_multiply(((float)L_54), L_55));
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_56 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_56);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_57;
		L_57 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_56, NULL);
		NullCheck(L_57);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58;
		L_58 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_57, NULL);
		float L_59 = L_58.___z_4;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_60 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_60);
		int32_t L_61 = L_60->___chunkCountVertical_2;
		V_10 = ((float)(L_59/((float)L_61)));
		int32_t L_62 = V_7;
		float L_63 = V_10;
		V_11 = ((float)il2cpp_codegen_multiply(((float)L_62), L_63));
		ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* L_64 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___callback_2;
		if (!L_64)
		{
			goto IL_01fe;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* L_65 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___callback_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_66 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_67 = L_66;
		NullCheck(L_67);
		ArrayElementTypeCheck (L_67, _stringLiteral6DC06A97CD7BB70F5ECDB0405BECBB5EDCFD1923);
		(L_67)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)_stringLiteral6DC06A97CD7BB70F5ECDB0405BECBB5EDCFD1923);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_68 = L_67;
		int32_t L_69 = V_5;
		int32_t L_70 = ((int32_t)il2cpp_codegen_add(L_69, 1));
		RuntimeObject* L_71 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_70);
		NullCheck(L_68);
		ArrayElementTypeCheck (L_68, L_71);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_71);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_72 = L_68;
		NullCheck(L_72);
		ArrayElementTypeCheck (L_72, _stringLiteralE5EE957CF9978795A3D9DF30B3186097186F4640);
		(L_72)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)_stringLiteralE5EE957CF9978795A3D9DF30B3186097186F4640);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_73 = L_72;
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_74 = V_3;
		NullCheck(L_74);
		int32_t L_75 = ((int32_t)(((RuntimeArray*)L_74)->max_length));
		RuntimeObject* L_76 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_75);
		NullCheck(L_73);
		ArrayElementTypeCheck (L_73, L_76);
		(L_73)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_76);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_77 = L_73;
		NullCheck(L_77);
		ArrayElementTypeCheck (L_77, _stringLiteral5CFE8923806CDDAAD3F303E0C2ED3D9A4B5008EE);
		(L_77)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)_stringLiteral5CFE8923806CDDAAD3F303E0C2ED3D9A4B5008EE);
		String_t* L_78;
		L_78 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_77, NULL);
		int32_t L_79 = V_5;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_80 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_80);
		int32_t L_81 = L_80->___chunkCountHorizontal_1;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_82 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_82);
		int32_t L_83 = L_82->___chunkCountVertical_2;
		NullCheck(L_65);
		ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_inline(L_65, L_78, ((float)(((float)il2cpp_codegen_add((1.0f), ((float)L_79)))/((float)((int32_t)il2cpp_codegen_multiply(L_81, L_83))))), NULL);
	}

IL_01fe:
	{
		int32_t L_84 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_84, 1));
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_85 = V_3;
		int32_t L_86 = V_5;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_87 = V_4;
		int32_t L_88 = V_5;
		NullCheck(L_87);
		float L_89 = V_8;
		float L_90 = V_9;
		float L_91 = V_10;
		float L_92 = V_11;
		bool L_93 = ___2__normalizeUV;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_94;
		L_94 = TerrainToMeshConverter_GenerateTerrainMainChunks_mEC78207E0925FC5BAC882673CFD0FCD01AD25A44(((L_87)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_88))), L_89, L_90, L_91, L_92, L_93, NULL);
		NullCheck(L_85);
		ArrayElementTypeCheck (L_85, L_94);
		(L_85)->SetAt(static_cast<il2cpp_array_size_t>(L_86), (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*)L_94);
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_95 = V_3;
		int32_t L_96 = V_5;
		NullCheck(L_95);
		int32_t L_97 = L_96;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_98 = (L_95)->GetAt(static_cast<il2cpp_array_size_t>(L_97));
		NullCheck(L_98);
		Mesh_RecalculateBounds_mA9B293F57C6CD298AE2D2DB19061FC23B05AB90B(L_98, NULL);
		int32_t L_99 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_99, 1));
	}

IL_022e:
	{
		int32_t L_100 = V_7;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_101 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_101);
		int32_t L_102 = L_101->___chunkCountVertical_2;
		if ((((int32_t)L_100) < ((int32_t)L_102)))
		{
			goto IL_013f;
		}
	}
	{
		int32_t L_103 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_103, 1));
	}

IL_0245:
	{
		int32_t L_104 = V_6;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_105 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_105);
		int32_t L_106 = L_105->___chunkCountHorizontal_1;
		if ((((int32_t)L_104) < ((int32_t)L_106)))
		{
			goto IL_0137;
		}
	}

IL_0256:
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_107 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_107);
		bool L_108 = L_107->___generateSkirt_5;
		if (!L_108)
		{
			goto IL_027d;
		}
	}
	{
		V_12 = 0;
		goto IL_0276;
	}

IL_0267:
	{
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_109 = V_3;
		int32_t L_110 = V_12;
		NullCheck(L_109);
		int32_t L_111 = L_110;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_112 = (L_109)->GetAt(static_cast<il2cpp_array_size_t>(L_111));
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_AddSkirt_mA461756B9E0B28EF818F961AF1D3D59D7915127E(L_112, NULL);
		int32_t L_113 = V_12;
		V_12 = ((int32_t)il2cpp_codegen_add(L_113, 1));
	}

IL_0276:
	{
		int32_t L_114 = V_12;
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_115 = V_3;
		NullCheck(L_115);
		if ((((int32_t)L_114) < ((int32_t)((int32_t)(((RuntimeArray*)L_115)->max_length)))))
		{
			goto IL_0267;
		}
	}

IL_027d:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_116 = ___0__terrain;
		NullCheck(L_116);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_117;
		L_117 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_116, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_118 = V_0;
		NullCheck(L_117);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_117, L_118, NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_119 = ___0__terrain;
		NullCheck(L_119);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_120;
		L_120 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_119, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_121 = V_1;
		NullCheck(L_120);
		Transform_set_rotation_m61340DE74726CF0F9946743A727C4D444397331D(L_120, L_121, NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_122 = ___0__terrain;
		NullCheck(L_122);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_123;
		L_123 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(L_122, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_124 = V_2;
		NullCheck(L_123);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_123, L_124, NULL);
		MeshU5BU5D_t178CA36422FC397211E68FB7E39C5B2F95619689* L_125 = V_3;
		return L_125;
	}
}
// UnityEngine.Texture2D[] VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractSplatmaps(UnityEngine.Terrain)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* TerrainToMeshConverter_ExtractSplatmaps_mA3EFD694E307DE29C001670C6CEBC26ADECE55BB (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0023;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_2 = ___0__terrain;
		NullCheck(L_2);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_3;
		L_3 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_3, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_4)
		{
			goto IL_0023;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_5 = ___0__terrain;
		NullCheck(L_5);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_6;
		L_6 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_5, NULL);
		NullCheck(L_6);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_7;
		L_7 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_6, NULL);
		return L_7;
	}

IL_0023:
	{
		return (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)NULL;
	}
}
// UnityEngine.Texture2D[] VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractSplatmaps(UnityEngine.Terrain,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* TerrainToMeshConverter_ExtractSplatmaps_m0374535F98B9720BB1E2884201B8D8842CD735BE (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, int32_t ___1__width, int32_t ___2__height, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* V_0 = NULL;
	int32_t V_1 = 0;
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_2 = ___0__terrain;
		NullCheck(L_2);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_3;
		L_3 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_3, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_4)
		{
			goto IL_0032;
		}
	}

IL_0017:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_5 = ___0__terrain;
		NullCheck(L_5);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_6;
		L_6 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_5, NULL);
		NullCheck(L_6);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_7;
		L_7 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_6, NULL);
		if (!L_7)
		{
			goto IL_0032;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_8 = ___0__terrain;
		NullCheck(L_8);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_9;
		L_9 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_8, NULL);
		NullCheck(L_9);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_10;
		L_10 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_9, NULL);
		NullCheck(L_10);
		if ((((RuntimeArray*)L_10)->max_length))
		{
			goto IL_0034;
		}
	}

IL_0032:
	{
		return (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)NULL;
	}

IL_0034:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_11 = ___0__terrain;
		NullCheck(L_11);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_12;
		L_12 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_11, NULL);
		NullCheck(L_12);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_13;
		L_13 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_12, NULL);
		NullCheck(L_13);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_14 = (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)SZArrayNew(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)));
		V_0 = L_14;
		V_1 = 0;
		goto IL_006c;
	}

IL_004b:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_15 = ___0__terrain;
		NullCheck(L_15);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_16;
		L_16 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_15, NULL);
		NullCheck(L_16);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_17;
		L_17 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_16, NULL);
		int32_t L_18 = V_1;
		NullCheck(L_17);
		int32_t L_19 = L_18;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		int32_t L_21 = ___1__width;
		int32_t L_22 = ___2__height;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_23 = V_0;
		int32_t L_24 = V_1;
		NullCheck(L_23);
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_ResizePro_mEF356558D6D46C1A23BF1E6724D38CFC3896330A(L_20, L_21, L_22, ((L_23)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_24))), (bool)0, (bool)1, NULL);
		int32_t L_25 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_006c:
	{
		int32_t L_26 = V_1;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_27 = ___0__terrain;
		NullCheck(L_27);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_28;
		L_28 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_27, NULL);
		NullCheck(L_28);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_29;
		L_29 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_28, NULL);
		NullCheck(L_29);
		if ((((int32_t)L_26) < ((int32_t)((int32_t)(((RuntimeArray*)L_29)->max_length)))))
		{
			goto IL_004b;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_30 = V_0;
		return L_30;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractBasemaps(UnityEngine.Terrain,UnityEngine.Texture2D[]&,UnityEngine.Texture2D[]&,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_ExtractBasemaps_mEBDF984A6BF9D8EC85ABF0FDF2D9A7027F4FED55 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___1__diffuseMap, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___2__normalMap, int32_t ___3__textureWidth, int32_t ___4__textureHeight, int32_t ___5__splitCountHorizontal, int32_t ___6__splitCountVertical, bool ___7_sRGB, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2C86B2BC763697332424FE2A75529D19514427B8);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4698118A5AC187D0548E80D23BB386EF5015065A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8DA8E813D130ABDEBE308DB1EEA65D7EA322F124);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_3 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_4 = NULL;
	{
		int32_t L_0 = ___5__splitCountHorizontal;
		if ((((int32_t)L_0) >= ((int32_t)1)))
		{
			goto IL_0008;
		}
	}
	{
		___5__splitCountHorizontal = 1;
	}

IL_0008:
	{
		int32_t L_1 = ___6__splitCountVertical;
		if ((((int32_t)L_1) >= ((int32_t)1)))
		{
			goto IL_0010;
		}
	}
	{
		___6__splitCountVertical = 1;
	}

IL_0010:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_2 = ___1__diffuseMap;
		int32_t L_3 = ___5__splitCountHorizontal;
		int32_t L_4 = ___5__splitCountHorizontal;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_5 = (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)SZArrayNew(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_3, L_4)));
		*((RuntimeObject**)L_2) = (RuntimeObject*)L_5;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)L_5);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_6 = ___2__normalMap;
		int32_t L_7 = ___5__splitCountHorizontal;
		int32_t L_8 = ___5__splitCountHorizontal;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_9 = (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)SZArrayNew(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_7, L_8)));
		*((RuntimeObject**)L_6) = (RuntimeObject*)L_9;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_6, (void*)(RuntimeObject*)L_9);
		V_0 = 0;
		V_1 = 0;
		goto IL_0120;
	}

IL_0031:
	{
		V_2 = 0;
		goto IL_0114;
	}

IL_0038:
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplit_3 = (bool)1;
		int32_t L_10 = ___5__splitCountHorizontal;
		int32_t L_11 = ___6__splitCountVertical;
		int32_t L_12 = V_2;
		int32_t L_13 = ___5__splitCountHorizontal;
		int32_t L_14 = V_1;
		int32_t L_15 = ___6__splitCountVertical;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_16;
		memset((&L_16), 0, sizeof(L_16));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_16), ((float)((1.0f)/((float)L_10))), ((float)((1.0f)/((float)L_11))), ((float)(((float)L_12)/((float)L_13))), ((float)(((float)L_14)/((float)L_15))), /*hidden argument*/NULL);
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplitOffsetScale_4 = L_16;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_17 = ___0__terrain;
		int32_t L_18 = ___3__textureWidth;
		int32_t L_19 = ___4__textureHeight;
		bool L_20 = ___7_sRGB;
		TerrainToMeshConverter_ExtractBasemap_m385F298CB909E6AB7C0FB1D3877B26866AF8F3A7(L_17, (&V_3), (&V_4), L_18, L_19, L_20, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_21 = V_3;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_22;
		L_22 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_21, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_22)
		{
			goto IL_00ba;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = V_3;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_24 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_25 = L_24;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_26 = ___0__terrain;
		NullCheck(L_26);
		String_t* L_27;
		L_27 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_26, NULL);
		NullCheck(L_25);
		ArrayElementTypeCheck (L_25, L_27);
		(L_25)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_27);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_28 = L_25;
		NullCheck(L_28);
		ArrayElementTypeCheck (L_28, _stringLiteral8DA8E813D130ABDEBE308DB1EEA65D7EA322F124);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)_stringLiteral8DA8E813D130ABDEBE308DB1EEA65D7EA322F124);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_29 = L_28;
		int32_t L_30 = V_2;
		int32_t L_31 = L_30;
		RuntimeObject* L_32 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_31);
		NullCheck(L_29);
		ArrayElementTypeCheck (L_29, L_32);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_32);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_33 = L_29;
		NullCheck(L_33);
		ArrayElementTypeCheck (L_33, _stringLiteral4698118A5AC187D0548E80D23BB386EF5015065A);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)_stringLiteral4698118A5AC187D0548E80D23BB386EF5015065A);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_34 = L_33;
		int32_t L_35 = V_1;
		int32_t L_36 = L_35;
		RuntimeObject* L_37 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_36);
		NullCheck(L_34);
		ArrayElementTypeCheck (L_34, L_37);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_37);
		String_t* L_38;
		L_38 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_34, NULL);
		NullCheck(L_23);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_23, L_38, NULL);
	}

IL_00ba:
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_39 = V_4;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_40;
		L_40 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_39, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_40)
		{
			goto IL_0101;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_41 = V_4;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_42 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_43 = L_42;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_44 = ___0__terrain;
		NullCheck(L_44);
		String_t* L_45;
		L_45 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_44, NULL);
		NullCheck(L_43);
		ArrayElementTypeCheck (L_43, L_45);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_45);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_46 = L_43;
		NullCheck(L_46);
		ArrayElementTypeCheck (L_46, _stringLiteral2C86B2BC763697332424FE2A75529D19514427B8);
		(L_46)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)_stringLiteral2C86B2BC763697332424FE2A75529D19514427B8);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_47 = L_46;
		int32_t L_48 = V_2;
		int32_t L_49 = L_48;
		RuntimeObject* L_50 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_49);
		NullCheck(L_47);
		ArrayElementTypeCheck (L_47, L_50);
		(L_47)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_50);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_51 = L_47;
		NullCheck(L_51);
		ArrayElementTypeCheck (L_51, _stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C);
		(L_51)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)_stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_52 = L_51;
		int32_t L_53 = V_1;
		int32_t L_54 = L_53;
		RuntimeObject* L_55 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_54);
		NullCheck(L_52);
		ArrayElementTypeCheck (L_52, L_55);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_55);
		String_t* L_56;
		L_56 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_52, NULL);
		NullCheck(L_41);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_41, L_56, NULL);
	}

IL_0101:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_57 = ___1__diffuseMap;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_58 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_57);
		int32_t L_59 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_60 = V_3;
		NullCheck(L_58);
		ArrayElementTypeCheck (L_58, L_60);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(L_59), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)L_60);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_61 = ___2__normalMap;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_62 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_61);
		int32_t L_63 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_64 = V_4;
		NullCheck(L_62);
		ArrayElementTypeCheck (L_62, L_64);
		(L_62)->SetAt(static_cast<il2cpp_array_size_t>(L_63), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)L_64);
		int32_t L_65 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_65, 1));
		int32_t L_66 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_66, 1));
	}

IL_0114:
	{
		int32_t L_67 = V_2;
		int32_t L_68 = ___5__splitCountHorizontal;
		if ((((int32_t)L_67) < ((int32_t)L_68)))
		{
			goto IL_0038;
		}
	}
	{
		int32_t L_69 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_69, 1));
	}

IL_0120:
	{
		int32_t L_70 = V_1;
		int32_t L_71 = ___6__splitCountVertical;
		if ((((int32_t)L_70) < ((int32_t)L_71)))
		{
			goto IL_0031;
		}
	}
	{
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractBasemap(UnityEngine.Terrain,UnityEngine.Texture2D&,UnityEngine.Texture2D&,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_ExtractBasemap_m385F298CB909E6AB7C0FB1D3877B26866AF8F3A7 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___1__diffuseMap, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___2__normalMap, int32_t ___3__width, int32_t ___4__height, bool ___5_sRGB, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D574679C44394BA9A98F52653C5978AF7EAC5C9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3F8C35472D6335178E5DB62294702D4E1545A6E6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6508496C80DA5B8525543A261C6B54B584D3C4C9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral78C3D77C204E73EDD42708C9D78AAB6B667D05A6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86CECC01D3FC259A06032362A21A3273E76DA152);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA21C073BA5F0E66881D17295C5FB2901B4066EDB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAA9047E47B1DF12227A442BB2C254519C336E893);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC3F08F24B5EA074413F20BF19487B1DAFFB34470);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE6CB1BE05B6B4F7E53DCC55E187512FF0190FDFF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEB5EBD1E02B2257829FD68BB68B823AEDE84FA47);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEFF27F09C45736F9769495B4CC293BC41A1C9991);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFE4FFD4BF19A7FD0D1A4FDDF13A60A7F7C65AFC0);
		s_Il2CppMethodInitialized = true;
	}
	Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* V_0 = NULL;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* V_1 = NULL;
	Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* V_2 = NULL;
	Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* V_3 = NULL;
	Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* V_4 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_5 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_6 = NULL;
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* V_7 = NULL;
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* V_8 = NULL;
	int32_t V_9 = 0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_10 = NULL;
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* V_11 = NULL;
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* V_12 = NULL;
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* V_13 = NULL;
	int32_t V_14 = 0;
	int32_t V_15 = 0;
	{
		int32_t L_0 = ___3__width;
		if ((((int32_t)L_0) >= ((int32_t)4)))
		{
			goto IL_0007;
		}
	}
	{
		___3__width = 4;
	}

IL_0007:
	{
		int32_t L_1 = ___4__height;
		if ((((int32_t)L_1) >= ((int32_t)4)))
		{
			goto IL_000f;
		}
	}
	{
		___4__height = 4;
	}

IL_000f:
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_2 = ___1__diffuseMap;
		*((RuntimeObject**)L_2) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_3 = ___2__normalMap;
		*((RuntimeObject**)L_3) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_3, (void*)(RuntimeObject*)NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_4 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_4, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_5)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_6 = ___0__terrain;
		NullCheck(L_6);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_7;
		L_7 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_6, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_7, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_8)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_9 = ___0__terrain;
		NullCheck(L_9);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_10;
		L_10 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_9, NULL);
		NullCheck(L_10);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_11;
		L_11 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_10, NULL);
		if (!L_11)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_12 = ___0__terrain;
		NullCheck(L_12);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_13;
		L_13 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_12, NULL);
		NullCheck(L_13);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_14;
		L_14 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_13, NULL);
		NullCheck(L_14);
		if ((((RuntimeArray*)L_14)->max_length))
		{
			goto IL_0052;
		}
	}

IL_0047:
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteral78C3D77C204E73EDD42708C9D78AAB6B667D05A6, NULL);
		return;
	}

IL_0052:
	{
		Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* L_15;
		L_15 = Shader_Find_m183AA54F78320212DDEC811592F98456898A41C5(_stringLiteralE6CB1BE05B6B4F7E53DCC55E187512FF0190FDFF, NULL);
		V_0 = L_15;
		Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* L_16 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_17;
		L_17 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_16, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_17)
		{
			goto IL_0071;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteralA21C073BA5F0E66881D17295C5FB2901B4066EDB, NULL);
		return;
	}

IL_0071:
	{
		Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* L_18 = V_0;
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_19 = (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*)il2cpp_codegen_object_new(Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var);
		NullCheck(L_19);
		Material__ctor_m7FDF47105D66D19591BE505A0C42B0F90D88C9BF(L_19, L_18, NULL);
		V_1 = L_19;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_20 = ___0__terrain;
		NullCheck(L_20);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_21;
		L_21 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_20, NULL);
		NullCheck(L_21);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_22;
		L_22 = TerrainData_get_alphamapTextures_m82B7287C772D95D4E3D6A5793A8B9A15745D8C45(L_21, NULL);
		V_2 = L_22;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_23 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		int32_t L_24;
		L_24 = TerrainToMeshConverter_ExtractTexturesInfo_m56AB39E9B6AD743592F187EAE2A3EA827EA79EBB(L_23, (&V_3), (&V_4), (&V_5), (&V_6), (&V_7), (&V_8), NULL);
		V_9 = L_24;
		int32_t L_25 = V_9;
		if (L_25)
		{
			goto IL_00a7;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(_stringLiteralEFF27F09C45736F9769495B4CC293BC41A1C9991, NULL);
		return;
	}

IL_00a7:
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_26 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_26);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_26, 2, 2, 5, (bool)0, NULL);
		V_10 = L_26;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_27 = V_10;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_28 = (ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389*)(ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389*)SZArrayNew(ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389_il2cpp_TypeInfo_var, (uint32_t)4);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_29 = L_28;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_30;
		L_30 = Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline(NULL);
		NullCheck(L_29);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(0), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_30);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_31 = L_29;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_32;
		L_32 = Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline(NULL);
		NullCheck(L_31);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(1), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_32);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_33 = L_31;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_34;
		L_34 = Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline(NULL);
		NullCheck(L_33);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(2), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_34);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_35 = L_33;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_36;
		L_36 = Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline(NULL);
		NullCheck(L_35);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(3), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_36);
		NullCheck(L_27);
		Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073(L_27, L_35, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_37 = V_10;
		NullCheck(L_37);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_37, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_38;
		L_38 = RenderTexture_get_active_mA4434B3E79DEF2C01CAE0A53061598B16443C9E7(NULL);
		V_11 = L_38;
		int32_t L_39 = ___3__width;
		int32_t L_40 = ___4__height;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_41;
		L_41 = RenderTexture_GetTemporary_m5B16E03FC6142149BDC336285A5C18D5152CA2C3(L_39, L_40, ((int32_t)24), NULL);
		V_12 = L_41;
		int32_t L_42 = ___3__width;
		int32_t L_43 = ___4__height;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_44;
		L_44 = RenderTexture_GetTemporary_m5B16E03FC6142149BDC336285A5C18D5152CA2C3(L_42, L_43, ((int32_t)24), NULL);
		V_13 = L_44;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		bool L_45 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplit_3;
		if (!L_45)
		{
			goto IL_0134;
		}
	}
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_46 = V_1;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_47 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplitOffsetScale_4;
		NullCheck(L_46);
		Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1(L_46, _stringLiteral3D574679C44394BA9A98F52653C5978AF7EAC5C9, L_47, NULL);
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplit_3 = (bool)0;
		goto IL_0158;
	}

IL_0134:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_48 = V_1;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_49;
		memset((&L_49), 0, sizeof(L_49));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_49), (1.0f), (1.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		NullCheck(L_48);
		Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1(L_48, _stringLiteral3D574679C44394BA9A98F52653C5978AF7EAC5C9, L_49, NULL);
	}

IL_0158:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_50 = V_3;
		if (!L_50)
		{
			goto IL_02bc;
		}
	}
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_51 = V_12;
		NullCheck(L_51);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_51, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_52 = V_10;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_53 = V_12;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8(L_52, L_53, (bool)0, NULL);
		V_14 = 0;
		goto IL_0274;
	}

IL_0177:
	{
		int32_t L_54 = V_14;
		if (((int32_t)(L_54%4)))
		{
			goto IL_018e;
		}
	}
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_55 = V_1;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_56 = V_2;
		int32_t L_57 = V_14;
		NullCheck(L_56);
		int32_t L_58 = ((int32_t)(L_57/4));
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_59 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		NullCheck(L_55);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_55, _stringLiteral86CECC01D3FC259A06032362A21A3273E76DA152, L_59, NULL);
	}

IL_018e:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_60 = V_1;
		int32_t L_61 = V_14;
		NullCheck(L_60);
		Material_SetFloat_m879CF81D740BAE6F23C9822400679F4D16365836(L_60, _stringLiteralAA9047E47B1DF12227A442BB2C254519C336E893, ((float)il2cpp_codegen_add((0.5f), ((float)((int32_t)(L_61%4))))), NULL);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_62 = V_3;
		int32_t L_63 = V_14;
		NullCheck(L_62);
		int32_t L_64 = L_63;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_66;
		L_66 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_65, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_66)
		{
			goto IL_01f1;
		}
	}
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_67 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_68 = L_67;
		NullCheck(L_68);
		ArrayElementTypeCheck (L_68, _stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)_stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_69 = L_68;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_70 = ___0__terrain;
		NullCheck(L_70);
		String_t* L_71;
		L_71 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_70, NULL);
		NullCheck(L_69);
		ArrayElementTypeCheck (L_69, L_71);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_71);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_72 = L_69;
		NullCheck(L_72);
		ArrayElementTypeCheck (L_72, _stringLiteral6508496C80DA5B8525543A261C6B54B584D3C4C9);
		(L_72)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)_stringLiteral6508496C80DA5B8525543A261C6B54B584D3C4C9);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_73 = L_72;
		int32_t L_74 = V_14;
		int32_t L_75 = L_74;
		RuntimeObject* L_76 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_75);
		NullCheck(L_73);
		ArrayElementTypeCheck (L_73, L_76);
		(L_73)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_76);
		String_t* L_77;
		L_77 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_73, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(L_77, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_78 = V_1;
		NullCheck(L_78);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_78, _stringLiteral3F8C35472D6335178E5DB62294702D4E1545A6E6, (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700*)NULL, NULL);
		goto IL_0248;
	}

IL_01f1:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_79 = V_1;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_80 = V_3;
		int32_t L_81 = V_14;
		NullCheck(L_80);
		int32_t L_82 = L_81;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_83 = (L_80)->GetAt(static_cast<il2cpp_array_size_t>(L_82));
		NullCheck(L_79);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_79, _stringLiteral3F8C35472D6335178E5DB62294702D4E1545A6E6, L_83, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_84 = V_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_85 = V_5;
		int32_t L_86 = V_14;
		NullCheck(L_85);
		float L_87 = ((L_85)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_86)))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_88 = V_5;
		int32_t L_89 = V_14;
		NullCheck(L_88);
		float L_90 = ((L_88)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_89)))->___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_91 = V_6;
		int32_t L_92 = V_14;
		NullCheck(L_91);
		float L_93 = ((L_91)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_92)))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_94 = V_6;
		int32_t L_95 = V_14;
		NullCheck(L_94);
		float L_96 = ((L_94)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_95)))->___y_1;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_97;
		memset((&L_97), 0, sizeof(L_97));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_97), L_87, L_90, L_93, L_96, /*hidden argument*/NULL);
		NullCheck(L_84);
		Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1(L_84, _stringLiteralFE4FFD4BF19A7FD0D1A4FDDF13A60A7F7C65AFC0, L_97, NULL);
	}

IL_0248:
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_98 = V_13;
		NullCheck(L_98);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_98, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_99 = V_12;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_100 = V_13;
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_101 = V_1;
		bool L_102 = ___5_sRGB;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_mEEE3B1AA11BD74C6FF6809D63CAA6DFA4FC60560(L_99, L_100, L_101, L_102, 0, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_103 = V_12;
		NullCheck(L_103);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_103, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_104 = V_13;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_105 = V_12;
		bool L_106 = ___5_sRGB;
		TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8(L_104, L_105, L_106, NULL);
		int32_t L_107 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_107, 1));
	}

IL_0274:
	{
		int32_t L_108 = V_14;
		int32_t L_109 = V_9;
		if ((((int32_t)L_108) < ((int32_t)L_109)))
		{
			goto IL_0177;
		}
	}
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_110 = V_12;
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB(L_110, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_111 = ___1__diffuseMap;
		int32_t L_112 = ___3__width;
		int32_t L_113 = ___4__height;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_114 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_114);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_114, L_112, L_113, 5, (bool)1, NULL);
		*((RuntimeObject**)L_111) = (RuntimeObject*)L_114;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_111, (void*)(RuntimeObject*)L_114);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_115 = ___1__diffuseMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_116 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_115);
		int32_t L_117 = ___3__width;
		int32_t L_118 = ___4__height;
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_119;
		memset((&L_119), 0, sizeof(L_119));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_119), (0.0f), (0.0f), ((float)L_117), ((float)L_118), /*hidden argument*/NULL);
		NullCheck(L_116);
		Texture2D_ReadPixels_m6B45DF7C051BF599C72ED09691F21A6C769EEBD9(L_116, L_119, 0, 0, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_120 = ___1__diffuseMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_121 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_120);
		NullCheck(L_121);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_121, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_122 = ___1__diffuseMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_123 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_122);
		NullCheck(L_123);
		Texture_set_wrapMode_m1F74A690E3883EC9C5C371D502D09642F15D0F7E(L_123, 1, NULL);
	}

IL_02bc:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_124 = V_4;
		if (!L_124)
		{
			goto IL_0433;
		}
	}
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_125 = V_12;
		NullCheck(L_125);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_125, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_126 = V_10;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_127 = V_12;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8(L_126, L_127, (bool)0, NULL);
		V_15 = 0;
		goto IL_03eb;
	}

IL_02dc:
	{
		int32_t L_128 = V_15;
		if (((int32_t)(L_128%4)))
		{
			goto IL_02f3;
		}
	}
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_129 = V_1;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_130 = V_2;
		int32_t L_131 = V_15;
		NullCheck(L_130);
		int32_t L_132 = ((int32_t)(L_131/4));
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_133 = (L_130)->GetAt(static_cast<il2cpp_array_size_t>(L_132));
		NullCheck(L_129);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_129, _stringLiteral86CECC01D3FC259A06032362A21A3273E76DA152, L_133, NULL);
	}

IL_02f3:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_134 = V_1;
		int32_t L_135 = V_15;
		NullCheck(L_134);
		Material_SetFloat_m879CF81D740BAE6F23C9822400679F4D16365836(L_134, _stringLiteralAA9047E47B1DF12227A442BB2C254519C336E893, ((float)il2cpp_codegen_add((0.5f), ((float)((int32_t)(L_135%4))))), NULL);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_136 = V_4;
		int32_t L_137 = V_15;
		NullCheck(L_136);
		int32_t L_138 = L_137;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_139 = (L_136)->GetAt(static_cast<il2cpp_array_size_t>(L_138));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_140;
		L_140 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_139, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_140)
		{
			goto IL_0367;
		}
	}
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_141 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_142 = L_141;
		NullCheck(L_142);
		ArrayElementTypeCheck (L_142, _stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229);
		(L_142)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)_stringLiteral5BB0B67B8775929164F5A1A1FCDEF18762A31229);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_143 = L_142;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_144 = ___0__terrain;
		NullCheck(L_144);
		String_t* L_145;
		L_145 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_144, NULL);
		NullCheck(L_143);
		ArrayElementTypeCheck (L_143, L_145);
		(L_143)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_145);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_146 = L_143;
		NullCheck(L_146);
		ArrayElementTypeCheck (L_146, _stringLiteralEB5EBD1E02B2257829FD68BB68B823AEDE84FA47);
		(L_146)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)_stringLiteralEB5EBD1E02B2257829FD68BB68B823AEDE84FA47);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_147 = L_146;
		int32_t L_148 = V_15;
		int32_t L_149 = L_148;
		RuntimeObject* L_150 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_149);
		NullCheck(L_147);
		ArrayElementTypeCheck (L_147, L_150);
		(L_147)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_150);
		String_t* L_151;
		L_151 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_147, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_m33EF1B897E0C7C6FF538989610BFAFFEF4628CA9(L_151, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_152 = V_1;
		NullCheck(L_152);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_152, _stringLiteralC3F08F24B5EA074413F20BF19487B1DAFFB34470, (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700*)NULL, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_153 = V_1;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_154;
		L_154 = Vector4_get_zero_m3D61F5FA9483CD9C08977D9D8852FB448B4CE6D1_inline(NULL);
		NullCheck(L_153);
		Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1(L_153, _stringLiteralFE4FFD4BF19A7FD0D1A4FDDF13A60A7F7C65AFC0, L_154, NULL);
		goto IL_03bf;
	}

IL_0367:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_155 = V_1;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_156 = V_4;
		int32_t L_157 = V_15;
		NullCheck(L_156);
		int32_t L_158 = L_157;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_159 = (L_156)->GetAt(static_cast<il2cpp_array_size_t>(L_158));
		NullCheck(L_155);
		Material_SetTexture_m06083C3F52EF02FFB1177901D9907314F280F9A5(L_155, _stringLiteralC3F08F24B5EA074413F20BF19487B1DAFFB34470, L_159, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_160 = V_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_161 = V_5;
		int32_t L_162 = V_15;
		NullCheck(L_161);
		float L_163 = ((L_161)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_162)))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_164 = V_5;
		int32_t L_165 = V_15;
		NullCheck(L_164);
		float L_166 = ((L_164)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_165)))->___y_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_167 = V_6;
		int32_t L_168 = V_15;
		NullCheck(L_167);
		float L_169 = ((L_167)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_168)))->___x_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_170 = V_6;
		int32_t L_171 = V_15;
		NullCheck(L_170);
		float L_172 = ((L_170)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_171)))->___y_1;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_173;
		memset((&L_173), 0, sizeof(L_173));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_173), L_163, L_166, L_169, L_172, /*hidden argument*/NULL);
		NullCheck(L_160);
		Material_SetVector_m69444B8040D955821F241113446CC8713C9E12D1(L_160, _stringLiteralFE4FFD4BF19A7FD0D1A4FDDF13A60A7F7C65AFC0, L_173, NULL);
	}

IL_03bf:
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_174 = V_13;
		NullCheck(L_174);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_174, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_175 = V_12;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_176 = V_13;
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_177 = V_1;
		bool L_178 = ___5_sRGB;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_mEEE3B1AA11BD74C6FF6809D63CAA6DFA4FC60560(L_175, L_176, L_177, L_178, 1, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_179 = V_12;
		NullCheck(L_179);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_179, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_180 = V_13;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_181 = V_12;
		bool L_182 = ___5_sRGB;
		TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8(L_180, L_181, L_182, NULL);
		int32_t L_183 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_183, 1));
	}

IL_03eb:
	{
		int32_t L_184 = V_15;
		int32_t L_185 = V_9;
		if ((((int32_t)L_184) < ((int32_t)L_185)))
		{
			goto IL_02dc;
		}
	}
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_186 = V_12;
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB(L_186, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_187 = ___2__normalMap;
		int32_t L_188 = ___3__width;
		int32_t L_189 = ___4__height;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_190 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_190);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_190, L_188, L_189, 5, (bool)1, NULL);
		*((RuntimeObject**)L_187) = (RuntimeObject*)L_190;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_187, (void*)(RuntimeObject*)L_190);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_191 = ___2__normalMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_192 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_191);
		int32_t L_193 = ___3__width;
		int32_t L_194 = ___4__height;
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_195;
		memset((&L_195), 0, sizeof(L_195));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_195), (0.0f), (0.0f), ((float)L_193), ((float)L_194), /*hidden argument*/NULL);
		NullCheck(L_192);
		Texture2D_ReadPixels_m6B45DF7C051BF599C72ED09691F21A6C769EEBD9(L_192, L_195, 0, 0, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_196 = ___2__normalMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_197 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_196);
		NullCheck(L_197);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_197, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_198 = ___2__normalMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_199 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_198);
		NullCheck(L_199);
		Texture_set_wrapMode_m1F74A690E3883EC9C5C371D502D09642F15D0F7E(L_199, 1, NULL);
	}

IL_0433:
	{
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB((RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27*)NULL, NULL);
		bool L_200;
		L_200 = Application_get_isPlaying_m25B0ABDFEF54F5370CD3F263A813540843D00F34(NULL);
		if (!L_200)
		{
			goto IL_0447;
		}
	}
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_201 = V_11;
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB(L_201, NULL);
	}

IL_0447:
	{
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_202 = V_1;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705(L_202, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_203 = V_10;
		Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705(L_203, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_204 = V_12;
		RenderTexture_ReleaseTemporary_mEEF2C1990196FF06FDD0DC190928AD3A023EBDD2(L_204, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_205 = V_13;
		RenderTexture_ReleaseTemporary_mEEF2C1990196FF06FDD0DC190928AD3A023EBDD2(L_205, NULL);
		return;
	}
}
// UnityEngine.Texture2D VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractHeightmap(UnityEngine.Terrain,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TerrainToMeshConverter_ExtractHeightmap_mD71042540E9B77D3B04827F4B6CD56BA33EE39B3 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, bool ___1__remap, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_2 = NULL;
	SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4* V_3 = NULL;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	float V_8 = 0.0f;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	float V_11 = 0.0f;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_12;
	memset((&V_12), 0, sizeof(V_12));
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_1)
		{
			goto IL_0017;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_2 = ___0__terrain;
		NullCheck(L_2);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_3;
		L_3 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_3, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_4)
		{
			goto IL_0019;
		}
	}

IL_0017:
	{
		return (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
	}

IL_0019:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_5 = ___0__terrain;
		NullCheck(L_5);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_6;
		L_6 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_5, NULL);
		NullCheck(L_6);
		int32_t L_7;
		L_7 = TerrainData_get_heightmapResolution_m39FE9A5C31A80B28021F8E2484EF5F2664798836(L_6, NULL);
		V_0 = L_7;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_8 = ___0__terrain;
		NullCheck(L_8);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_9;
		L_9 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_8, NULL);
		NullCheck(L_9);
		int32_t L_10;
		L_10 = TerrainData_get_heightmapResolution_m39FE9A5C31A80B28021F8E2484EF5F2664798836(L_9, NULL);
		V_1 = L_10;
		int32_t L_11 = V_0;
		int32_t L_12 = V_1;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_13 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_13);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_13, L_11, L_12, 5, (bool)1, NULL);
		V_2 = L_13;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_14 = ___0__terrain;
		NullCheck(L_14);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_15;
		L_15 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_14, NULL);
		int32_t L_16 = V_0;
		int32_t L_17 = V_1;
		NullCheck(L_15);
		SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4* L_18;
		L_18 = TerrainData_GetHeights_m3E5C109E98E72A23E39B92F7DF48D87888B2D488(L_15, 0, 0, L_16, L_17, NULL);
		V_3 = L_18;
		V_4 = (1.0f);
		V_5 = (0.0f);
		bool L_19 = ___1__remap;
		if (!L_19)
		{
			goto IL_00a6;
		}
	}
	{
		V_6 = 0;
		goto IL_009c;
	}

IL_0061:
	{
		V_7 = 0;
		goto IL_008c;
	}

IL_0066:
	{
		SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4* L_20 = V_3;
		int32_t L_21 = V_6;
		int32_t L_22 = V_7;
		NullCheck(L_20);
		float L_23;
		L_23 = (L_20)->GetAt(L_21, L_22);
		V_8 = L_23;
		float L_24 = V_8;
		float L_25 = V_4;
		if ((!(((float)L_24) < ((float)L_25))))
		{
			goto IL_007c;
		}
	}
	{
		float L_26 = V_8;
		V_4 = L_26;
	}

IL_007c:
	{
		float L_27 = V_8;
		float L_28 = V_5;
		if ((!(((float)L_27) > ((float)L_28))))
		{
			goto IL_0086;
		}
	}
	{
		float L_29 = V_8;
		V_5 = L_29;
	}

IL_0086:
	{
		int32_t L_30 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_30, 1));
	}

IL_008c:
	{
		int32_t L_31 = V_7;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_32 = V_2;
		NullCheck(L_32);
		int32_t L_33;
		L_33 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_32);
		if ((((int32_t)L_31) < ((int32_t)L_33)))
		{
			goto IL_0066;
		}
	}
	{
		int32_t L_34 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_009c:
	{
		int32_t L_35 = V_6;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_36 = V_2;
		NullCheck(L_36);
		int32_t L_37;
		L_37 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_36);
		if ((((int32_t)L_35) < ((int32_t)L_37)))
		{
			goto IL_0061;
		}
	}

IL_00a6:
	{
		V_9 = 0;
		goto IL_010a;
	}

IL_00ab:
	{
		V_10 = 0;
		goto IL_00fa;
	}

IL_00b0:
	{
		SingleU5BU2CU5D_t8C95DA2D5056EB0490FC7DCB1ED30E33DE1D53F4* L_38 = V_3;
		int32_t L_39 = V_9;
		int32_t L_40 = V_10;
		NullCheck(L_38);
		float L_41;
		L_41 = (L_38)->GetAt(L_39, L_40);
		V_11 = L_41;
		bool L_42 = ___1__remap;
		if (!L_42)
		{
			goto IL_00d6;
		}
	}
	{
		float L_43 = V_11;
		float L_44 = V_4;
		float L_45 = V_5;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		float L_46;
		L_46 = TerrainToMeshConverter_Remap_m649C48A5904AE65F6E6646F62F4786D7AC1C01B3(L_43, L_44, L_45, (0.0f), (1.0f), NULL);
		V_11 = L_46;
	}

IL_00d6:
	{
		float L_47 = V_11;
		float L_48 = V_11;
		float L_49 = V_11;
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&V_12), L_47, L_48, L_49, (1.0f), NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_50 = V_2;
		int32_t L_51 = V_10;
		int32_t L_52 = V_9;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_53 = V_12;
		NullCheck(L_50);
		Texture2D_SetPixel_m2CCFC5F729135D59DC4A697C2605A3FC5C8574DB(L_50, L_51, L_52, L_53, NULL);
		int32_t L_54 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add(L_54, 1));
	}

IL_00fa:
	{
		int32_t L_55 = V_10;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_56 = V_2;
		NullCheck(L_56);
		int32_t L_57;
		L_57 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_56);
		if ((((int32_t)L_55) < ((int32_t)L_57)))
		{
			goto IL_00b0;
		}
	}
	{
		int32_t L_58 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_58, 1));
	}

IL_010a:
	{
		int32_t L_59 = V_9;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_60 = V_2;
		NullCheck(L_60);
		int32_t L_61;
		L_61 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_60);
		if ((((int32_t)L_59) < ((int32_t)L_61)))
		{
			goto IL_00ab;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_62 = V_2;
		NullCheck(L_62);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_62, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_63 = V_2;
		return L_63;
	}
}
// UnityEngine.Texture2D VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractHeightmap(UnityEngine.Terrain,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TerrainToMeshConverter_ExtractHeightmap_mB747D580C0F4BAFC1A6B4B64AB53ED1215B8EE30 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, int32_t ___1__width, int32_t ___2__height, bool ___3__remap, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_0 = NULL;
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		bool L_1 = ___3__remap;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_2;
		L_2 = TerrainToMeshConverter_ExtractHeightmap_mD71042540E9B77D3B04827F4B6CD56BA33EE39B3(L_0, L_1, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = L_2;
		int32_t L_4 = ___1__width;
		int32_t L_5 = ___2__height;
		TerrainToMeshConverter_ResizePro_mEF356558D6D46C1A23BF1E6724D38CFC3896330A(L_3, L_4, L_5, (&V_0), (bool)0, (bool)1, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705(L_3, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_0;
		return L_6;
	}
}
// System.Int32 VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractTexturesInfo(UnityEngine.Terrain,UnityEngine.Texture2D[]&,UnityEngine.Texture2D[]&,UnityEngine.Vector2[]&,UnityEngine.Vector2[]&,System.Single[]&,System.Single[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TerrainToMeshConverter_ExtractTexturesInfo_m56AB39E9B6AD743592F187EAE2A3EA827EA79EBB (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___1__diffuseTextures, Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** ___2__normalTextures, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___3__uvScale, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___4__uvOffset, SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** ___5__metalic, SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** ___6__smoothness, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* V_4 = NULL;
	float V_5 = 0.0f;
	float V_6 = 0.0f;
	float V_7 = 0.0f;
	float V_8 = 0.0f;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	float G_B17_0 = 0.0f;
	float G_B20_0 = 0.0f;
	float G_B23_0 = 0.0f;
	float G_B26_0 = 0.0f;
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_0 = ___1__diffuseTextures;
		*((RuntimeObject**)L_0) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_0, (void*)(RuntimeObject*)NULL);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_1 = ___2__normalTextures;
		*((RuntimeObject**)L_1) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_1, (void*)(RuntimeObject*)NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_2 = ___3__uvScale;
		*((RuntimeObject**)L_2) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_3 = ___4__uvOffset;
		*((RuntimeObject**)L_3) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_3, (void*)(RuntimeObject*)NULL);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_4 = ___5__metalic;
		*((RuntimeObject**)L_4) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_4, (void*)(RuntimeObject*)NULL);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_5 = ___6__smoothness;
		*((RuntimeObject**)L_5) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_5, (void*)(RuntimeObject*)NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_6 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_6, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_7)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_8 = ___0__terrain;
		NullCheck(L_8);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_9;
		L_9 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_8, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_10;
		L_10 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_9, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_10)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_11 = ___0__terrain;
		NullCheck(L_11);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_12;
		L_12 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_11, NULL);
		NullCheck(L_12);
		SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A* L_13;
		L_13 = TerrainData_get_splatPrototypes_m349F72923854A74F3EE20D2F09452ED73852923E(L_12, NULL);
		if (!L_13)
		{
			goto IL_0047;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_14 = ___0__terrain;
		NullCheck(L_14);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_15;
		L_15 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_14, NULL);
		NullCheck(L_15);
		SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A* L_16;
		L_16 = TerrainData_get_splatPrototypes_m349F72923854A74F3EE20D2F09452ED73852923E(L_15, NULL);
		NullCheck(L_16);
		if ((((RuntimeArray*)L_16)->max_length))
		{
			goto IL_0049;
		}
	}

IL_0047:
	{
		return 0;
	}

IL_0049:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_17 = ___0__terrain;
		NullCheck(L_17);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_18;
		L_18 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_17, NULL);
		NullCheck(L_18);
		SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A* L_19;
		L_19 = TerrainData_get_splatPrototypes_m349F72923854A74F3EE20D2F09452ED73852923E(L_18, NULL);
		NullCheck(L_19);
		V_0 = ((int32_t)(((RuntimeArray*)L_19)->max_length));
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_20 = ___1__diffuseTextures;
		int32_t L_21 = V_0;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_22 = (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)SZArrayNew(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var, (uint32_t)L_21);
		*((RuntimeObject**)L_20) = (RuntimeObject*)L_22;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_20, (void*)(RuntimeObject*)L_22);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_23 = ___2__normalTextures;
		int32_t L_24 = V_0;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_25 = (Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191*)SZArrayNew(Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191_il2cpp_TypeInfo_var, (uint32_t)L_24);
		*((RuntimeObject**)L_23) = (RuntimeObject*)L_25;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_23, (void*)(RuntimeObject*)L_25);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_26 = ___3__uvScale;
		int32_t L_27 = V_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_28 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)L_27);
		*((RuntimeObject**)L_26) = (RuntimeObject*)L_28;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_26, (void*)(RuntimeObject*)L_28);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_29 = ___4__uvOffset;
		int32_t L_30 = V_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_31 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)L_30);
		*((RuntimeObject**)L_29) = (RuntimeObject*)L_31;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_29, (void*)(RuntimeObject*)L_31);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_32 = ___5__metalic;
		int32_t L_33 = V_0;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_34 = (SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)SZArrayNew(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var, (uint32_t)L_33);
		*((RuntimeObject**)L_32) = (RuntimeObject*)L_34;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_32, (void*)(RuntimeObject*)L_34);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_35 = ___6__smoothness;
		int32_t L_36 = V_0;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_37 = (SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C*)SZArrayNew(SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C_il2cpp_TypeInfo_var, (uint32_t)L_36);
		*((RuntimeObject**)L_35) = (RuntimeObject*)L_37;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_35, (void*)(RuntimeObject*)L_37);
		V_3 = 0;
		goto IL_023f;
	}

IL_0091:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_38 = ___0__terrain;
		NullCheck(L_38);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_39;
		L_39 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_38, NULL);
		NullCheck(L_39);
		SplatPrototypeU5BU5D_t18109FC049B8FCFB38634E75365FC4A87109AF1A* L_40;
		L_40 = TerrainData_get_splatPrototypes_m349F72923854A74F3EE20D2F09452ED73852923E(L_39, NULL);
		int32_t L_41 = V_3;
		NullCheck(L_40);
		int32_t L_42 = L_41;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_43 = (L_40)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		V_4 = L_43;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_44 = V_4;
		if (L_44)
		{
			goto IL_00e2;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_45 = ___1__diffuseTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_46 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_45);
		int32_t L_47 = V_3;
		NullCheck(L_46);
		ArrayElementTypeCheck (L_46, NULL);
		(L_46)->SetAt(static_cast<il2cpp_array_size_t>(L_47), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL);
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_48 = ___2__normalTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_49 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_48);
		int32_t L_50 = V_3;
		NullCheck(L_49);
		ArrayElementTypeCheck (L_49, NULL);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(L_50), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_51 = ___3__uvScale;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_52 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_51);
		int32_t L_53 = V_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_54;
		L_54 = Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline(NULL);
		NullCheck(L_52);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(L_53), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_54);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_55 = ___4__uvOffset;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_56 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_55);
		int32_t L_57 = V_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_58;
		L_58 = Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline(NULL);
		NullCheck(L_56);
		(L_56)->SetAt(static_cast<il2cpp_array_size_t>(L_57), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_58);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_59 = ___5__metalic;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_60 = *((SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C**)L_59);
		int32_t L_61 = V_3;
		NullCheck(L_60);
		(L_60)->SetAt(static_cast<il2cpp_array_size_t>(L_61), (float)(0.0f));
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_62 = ___6__smoothness;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_63 = *((SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C**)L_62);
		int32_t L_64 = V_3;
		NullCheck(L_63);
		(L_63)->SetAt(static_cast<il2cpp_array_size_t>(L_64), (float)(0.0f));
		goto IL_023b;
	}

IL_00e2:
	{
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_65 = V_4;
		NullCheck(L_65);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_66;
		L_66 = SplatPrototype_get_texture_m10D1E021FA78ADB602A6B9DCF7D7C3108B5226EB(L_65, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_67;
		L_67 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_66, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_67)
		{
			goto IL_00f8;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_68 = ___1__diffuseTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_69 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_68);
		int32_t L_70 = V_3;
		NullCheck(L_69);
		ArrayElementTypeCheck (L_69, NULL);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(L_70), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL);
		goto IL_0103;
	}

IL_00f8:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_71 = ___1__diffuseTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_72 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_71);
		int32_t L_73 = V_3;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_74 = V_4;
		NullCheck(L_74);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_75;
		L_75 = SplatPrototype_get_texture_m10D1E021FA78ADB602A6B9DCF7D7C3108B5226EB(L_74, NULL);
		NullCheck(L_72);
		ArrayElementTypeCheck (L_72, L_75);
		(L_72)->SetAt(static_cast<il2cpp_array_size_t>(L_73), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)L_75);
	}

IL_0103:
	{
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_76 = V_4;
		NullCheck(L_76);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_77;
		L_77 = SplatPrototype_get_normalMap_mB81C93E54EEDF854E3A6265259C627A80B3E76D3(L_76, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_78;
		L_78 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_77, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_78)
		{
			goto IL_0119;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_79 = ___2__normalTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_80 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_79);
		int32_t L_81 = V_3;
		NullCheck(L_80);
		ArrayElementTypeCheck (L_80, NULL);
		(L_80)->SetAt(static_cast<il2cpp_array_size_t>(L_81), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL);
		goto IL_0124;
	}

IL_0119:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_82 = ___2__normalTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_83 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_82);
		int32_t L_84 = V_3;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_85 = V_4;
		NullCheck(L_85);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_86;
		L_86 = SplatPrototype_get_normalMap_mB81C93E54EEDF854E3A6265259C627A80B3E76D3(L_85, NULL);
		NullCheck(L_83);
		ArrayElementTypeCheck (L_83, L_86);
		(L_83)->SetAt(static_cast<il2cpp_array_size_t>(L_84), (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)L_86);
	}

IL_0124:
	{
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_87 = V_4;
		NullCheck(L_87);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_88;
		L_88 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_87, NULL);
		float L_89 = L_88.___x_0;
		if ((((float)L_89) == ((float)(0.0f))))
		{
			goto IL_0156;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_90 = ___0__terrain;
		NullCheck(L_90);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_91;
		L_91 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_90, NULL);
		NullCheck(L_91);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_92;
		L_92 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_91, NULL);
		float L_93 = L_92.___x_2;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_94 = V_4;
		NullCheck(L_94);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_95;
		L_95 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_94, NULL);
		float L_96 = L_95.___x_0;
		G_B17_0 = ((float)(L_93/L_96));
		goto IL_015b;
	}

IL_0156:
	{
		G_B17_0 = (0.0f);
	}

IL_015b:
	{
		V_5 = G_B17_0;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_97 = V_4;
		NullCheck(L_97);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_98;
		L_98 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_97, NULL);
		float L_99 = L_98.___y_1;
		if ((((float)L_99) == ((float)(0.0f))))
		{
			goto IL_018f;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_100 = ___0__terrain;
		NullCheck(L_100);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_101;
		L_101 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_100, NULL);
		NullCheck(L_101);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_102;
		L_102 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_101, NULL);
		float L_103 = L_102.___z_4;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_104 = V_4;
		NullCheck(L_104);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_105;
		L_105 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_104, NULL);
		float L_106 = L_105.___y_1;
		G_B20_0 = ((float)(L_103/L_106));
		goto IL_0194;
	}

IL_018f:
	{
		G_B20_0 = (0.0f);
	}

IL_0194:
	{
		V_6 = G_B20_0;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_107 = V_4;
		NullCheck(L_107);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_108;
		L_108 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_107, NULL);
		float L_109 = L_108.___x_0;
		if ((((float)L_109) == ((float)(0.0f))))
		{
			goto IL_01c4;
		}
	}
	{
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_110 = V_4;
		NullCheck(L_110);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_111;
		L_111 = SplatPrototype_get_tileOffset_m5D7E37F7FDB7B6A2CD8A2323D2AF0B7CCE88FCFF(L_110, NULL);
		float L_112 = L_111.___x_0;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_113 = V_4;
		NullCheck(L_113);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_114;
		L_114 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_113, NULL);
		float L_115 = L_114.___x_0;
		G_B23_0 = ((float)(L_112/L_115));
		goto IL_01c9;
	}

IL_01c4:
	{
		G_B23_0 = (0.0f);
	}

IL_01c9:
	{
		V_7 = G_B23_0;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_116 = V_4;
		NullCheck(L_116);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_117;
		L_117 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_116, NULL);
		float L_118 = L_117.___y_1;
		if ((((float)L_118) == ((float)(0.0f))))
		{
			goto IL_01f9;
		}
	}
	{
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_119 = V_4;
		NullCheck(L_119);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_120;
		L_120 = SplatPrototype_get_tileOffset_m5D7E37F7FDB7B6A2CD8A2323D2AF0B7CCE88FCFF(L_119, NULL);
		float L_121 = L_120.___y_1;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_122 = V_4;
		NullCheck(L_122);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_123;
		L_123 = SplatPrototype_get_tileSize_mFC64C788FD37AC90A3DADEA115E77476704C6496(L_122, NULL);
		float L_124 = L_123.___y_1;
		G_B26_0 = ((float)(L_121/L_124));
		goto IL_01fe;
	}

IL_01f9:
	{
		G_B26_0 = (0.0f);
	}

IL_01fe:
	{
		V_8 = G_B26_0;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_125 = ___3__uvScale;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_126 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_125);
		int32_t L_127 = V_3;
		float L_128 = V_5;
		float L_129 = V_6;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_130;
		memset((&L_130), 0, sizeof(L_130));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_130), L_128, L_129, /*hidden argument*/NULL);
		NullCheck(L_126);
		(L_126)->SetAt(static_cast<il2cpp_array_size_t>(L_127), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_130);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_131 = ___4__uvOffset;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_132 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_131);
		int32_t L_133 = V_3;
		float L_134 = V_7;
		float L_135 = V_8;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_136;
		memset((&L_136), 0, sizeof(L_136));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_136), L_134, L_135, /*hidden argument*/NULL);
		NullCheck(L_132);
		(L_132)->SetAt(static_cast<il2cpp_array_size_t>(L_133), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_136);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_137 = ___5__metalic;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_138 = *((SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C**)L_137);
		int32_t L_139 = V_3;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_140 = V_4;
		NullCheck(L_140);
		float L_141;
		L_141 = SplatPrototype_get_metallic_mF45573E9F0187E619B352DCC1A43D8950A7B5544(L_140, NULL);
		NullCheck(L_138);
		(L_138)->SetAt(static_cast<il2cpp_array_size_t>(L_139), (float)L_141);
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C** L_142 = ___6__smoothness;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_143 = *((SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C**)L_142);
		int32_t L_144 = V_3;
		SplatPrototype_t111B5B35A39EAF28A52C3CB2EFBA5F18ECA09BA8* L_145 = V_4;
		NullCheck(L_145);
		float L_146;
		L_146 = SplatPrototype_get_smoothness_m41F39F21541FFA167558900FC05F6508E2CBB519(L_145, NULL);
		NullCheck(L_143);
		(L_143)->SetAt(static_cast<il2cpp_array_size_t>(L_144), (float)L_146);
	}

IL_023b:
	{
		int32_t L_147 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_147, 1));
	}

IL_023f:
	{
		int32_t L_148 = V_3;
		int32_t L_149 = V_0;
		if ((((int32_t)L_148) < ((int32_t)L_149)))
		{
			goto IL_0091;
		}
	}
	{
		V_1 = (bool)0;
		V_9 = 0;
		goto IL_0262;
	}

IL_024d:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_150 = ___1__diffuseTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_151 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_150);
		int32_t L_152 = V_9;
		NullCheck(L_151);
		int32_t L_153 = L_152;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_154 = (L_151)->GetAt(static_cast<il2cpp_array_size_t>(L_153));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_155;
		L_155 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_154, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_155)
		{
			goto IL_025c;
		}
	}
	{
		V_1 = (bool)1;
	}

IL_025c:
	{
		int32_t L_156 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_156, 1));
	}

IL_0262:
	{
		int32_t L_157 = V_9;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_158 = ___1__diffuseTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_159 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_158);
		NullCheck(L_159);
		if ((((int32_t)L_157) < ((int32_t)((int32_t)(((RuntimeArray*)L_159)->max_length)))))
		{
			goto IL_024d;
		}
	}
	{
		bool L_160 = V_1;
		if (L_160)
		{
			goto IL_0270;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_161 = ___1__diffuseTextures;
		*((RuntimeObject**)L_161) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_161, (void*)(RuntimeObject*)NULL);
	}

IL_0270:
	{
		V_2 = (bool)0;
		V_10 = 0;
		goto IL_028c;
	}

IL_0277:
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_162 = ___2__normalTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_163 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_162);
		int32_t L_164 = V_10;
		NullCheck(L_163);
		int32_t L_165 = L_164;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_166 = (L_163)->GetAt(static_cast<il2cpp_array_size_t>(L_165));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_167;
		L_167 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_166, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_167)
		{
			goto IL_0286;
		}
	}
	{
		V_2 = (bool)1;
	}

IL_0286:
	{
		int32_t L_168 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add(L_168, 1));
	}

IL_028c:
	{
		int32_t L_169 = V_10;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_170 = ___2__normalTextures;
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191* L_171 = *((Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191**)L_170);
		NullCheck(L_171);
		if ((((int32_t)L_169) < ((int32_t)((int32_t)(((RuntimeArray*)L_171)->max_length)))))
		{
			goto IL_0277;
		}
	}
	{
		bool L_172 = V_2;
		if (L_172)
		{
			goto IL_029a;
		}
	}
	{
		Texture2DU5BU5D_t05332F1E3F7D4493E304C702201F9BE4F9236191** L_173 = ___2__normalTextures;
		*((RuntimeObject**)L_173) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_173, (void*)(RuntimeObject*)NULL);
	}

IL_029a:
	{
		bool L_174 = V_1;
		if (L_174)
		{
			goto IL_02a9;
		}
	}
	{
		bool L_175 = V_2;
		if (L_175)
		{
			goto IL_02a9;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_176 = ___3__uvScale;
		*((RuntimeObject**)L_176) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_176, (void*)(RuntimeObject*)NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_177 = ___4__uvOffset;
		*((RuntimeObject**)L_177) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_177, (void*)(RuntimeObject*)NULL);
		V_0 = 0;
	}

IL_02a9:
	{
		int32_t L_178 = V_0;
		return L_178;
	}
}
// UnityEngine.GameObject VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ExtractTrees(UnityEngine.Terrain)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* TerrainToMeshConverter_ExtractTrees_mE87AE0AA4FBDC64B5B3EE106D35C28362E3EEB57 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3114E31F897F3607D8D80829EB380C5FE0D23242);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD41D89DAD98E1F1783260FD0A5A774F557A05F0F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32);
		s_Il2CppMethodInitialized = true;
	}
	TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* V_0 = NULL;
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_1 = NULL;
	GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	TreeInstance_t382B018173ED020660D262061EA9424682614F50 V_6;
	memset((&V_6), 0, sizeof(V_6));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_7;
	memset((&V_7), 0, sizeof(V_7));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_8;
	memset((&V_8), 0, sizeof(V_8));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	int32_t V_10 = 0;
	int32_t V_11 = 0;
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_12 = NULL;
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_1)
		{
			goto IL_0024;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_2 = ___0__terrain;
		NullCheck(L_2);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_3;
		L_3 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_3, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_4)
		{
			goto IL_0024;
		}
	}
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_5 = ___0__terrain;
		NullCheck(L_5);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_6;
		L_6 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_5, NULL);
		NullCheck(L_6);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_7;
		L_7 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_6, NULL);
		if (L_7)
		{
			goto IL_0026;
		}
	}

IL_0024:
	{
		return (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)NULL;
	}

IL_0026:
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_8 = ___0__terrain;
		NullCheck(L_8);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_9;
		L_9 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_8, NULL);
		V_0 = L_9;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_10 = ___0__terrain;
		NullCheck(L_10);
		String_t* L_11;
		L_11 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_10, NULL);
		String_t* L_12;
		L_12 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_11, _stringLiteral3114E31F897F3607D8D80829EB380C5FE0D23242, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_13 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_13);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_13, L_12, NULL);
		V_1 = L_13;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_14 = V_1;
		NullCheck(L_14);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_15;
		L_15 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_14, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		NullCheck(L_15);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_15, L_16, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_17 = V_1;
		NullCheck(L_17);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_18;
		L_18 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_17, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_19;
		L_19 = Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline(NULL);
		NullCheck(L_18);
		Transform_set_rotation_m61340DE74726CF0F9946743A727C4D444397331D(L_18, L_19, NULL);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_20 = V_0;
		NullCheck(L_20);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_21;
		L_21 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_20, NULL);
		NullCheck(L_21);
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_22 = (GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF*)(GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF*)SZArrayNew(GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_21)->max_length)));
		V_2 = L_22;
		V_4 = 0;
		goto IL_00f3;
	}

IL_0076:
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_23 = V_0;
		NullCheck(L_23);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_24;
		L_24 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_23, NULL);
		int32_t L_25 = V_4;
		NullCheck(L_24);
		int32_t L_26 = L_25;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_27 = (L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_26));
		if (!L_27)
		{
			goto IL_00ed;
		}
	}
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_28 = V_0;
		NullCheck(L_28);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_29;
		L_29 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_28, NULL);
		int32_t L_30 = V_4;
		NullCheck(L_29);
		int32_t L_31 = L_30;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
		NullCheck(L_32);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_33;
		L_33 = TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C(L_32, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_34;
		L_34 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_33, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_34)
		{
			goto IL_00ed;
		}
	}
	{
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_35 = V_2;
		int32_t L_36 = V_4;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_37 = V_0;
		NullCheck(L_37);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_38;
		L_38 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_37, NULL);
		int32_t L_39 = V_4;
		NullCheck(L_38);
		int32_t L_40 = L_39;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_41 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_40));
		NullCheck(L_41);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_42;
		L_42 = TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C(L_41, NULL);
		NullCheck(L_42);
		String_t* L_43;
		L_43 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_42, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_44 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		NullCheck(L_44);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_44, L_43, NULL);
		NullCheck(L_35);
		ArrayElementTypeCheck (L_35, L_44);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(L_36), (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)L_44);
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_45 = V_2;
		int32_t L_46 = V_4;
		NullCheck(L_45);
		int32_t L_47 = L_46;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_48 = (L_45)->GetAt(static_cast<il2cpp_array_size_t>(L_47));
		NullCheck(L_48);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_49;
		L_49 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_48, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		NullCheck(L_49);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_49, L_50, NULL);
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_51 = V_2;
		int32_t L_52 = V_4;
		NullCheck(L_51);
		int32_t L_53 = L_52;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_54 = (L_51)->GetAt(static_cast<il2cpp_array_size_t>(L_53));
		NullCheck(L_54);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_55;
		L_55 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_54, NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_56;
		L_56 = Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline(NULL);
		NullCheck(L_55);
		Transform_set_rotation_m61340DE74726CF0F9946743A727C4D444397331D(L_55, L_56, NULL);
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_57 = V_2;
		int32_t L_58 = V_4;
		NullCheck(L_57);
		int32_t L_59 = L_58;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_60 = (L_57)->GetAt(static_cast<il2cpp_array_size_t>(L_59));
		NullCheck(L_60);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_61;
		L_61 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_60, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_62 = V_1;
		NullCheck(L_62);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_63;
		L_63 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_62, NULL);
		NullCheck(L_61);
		Transform_set_parent_m9BD5E563B539DD5BEC342736B03F97B38A243234(L_61, L_63, NULL);
	}

IL_00ed:
	{
		int32_t L_64 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_64, 1));
	}

IL_00f3:
	{
		int32_t L_65 = V_4;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_66 = V_0;
		NullCheck(L_66);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_67;
		L_67 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_66, NULL);
		NullCheck(L_67);
		if ((((int32_t)L_65) < ((int32_t)((int32_t)(((RuntimeArray*)L_67)->max_length)))))
		{
			goto IL_0076;
		}
	}
	{
		V_5 = 0;
		goto IL_02a0;
	}

IL_010a:
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_68 = V_0;
		NullCheck(L_68);
		TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429* L_69;
		L_69 = TerrainData_get_treeInstances_mDAB68FD1F3677BD5CB122EA943493D5FC94B2147(L_68, NULL);
		int32_t L_70 = V_5;
		NullCheck(L_69);
		int32_t L_71 = L_70;
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_72 = (L_69)->GetAt(static_cast<il2cpp_array_size_t>(L_71));
		V_6 = L_72;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_73 = V_0;
		NullCheck(L_73);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_74;
		L_74 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_73, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_75 = V_6;
		int32_t L_76 = L_75.___prototypeIndex_6;
		NullCheck(L_74);
		int32_t L_77 = L_76;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_78 = (L_74)->GetAt(static_cast<il2cpp_array_size_t>(L_77));
		if (!L_78)
		{
			goto IL_029a;
		}
	}
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_79 = V_0;
		NullCheck(L_79);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_80;
		L_80 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_79, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_81 = V_6;
		int32_t L_82 = L_81.___prototypeIndex_6;
		NullCheck(L_80);
		int32_t L_83 = L_82;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_84 = (L_80)->GetAt(static_cast<il2cpp_array_size_t>(L_83));
		NullCheck(L_84);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_85;
		L_85 = TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C(L_84, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_86;
		L_86 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_85, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_86)
		{
			goto IL_029a;
		}
	}
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_87 = V_0;
		NullCheck(L_87);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_88;
		L_88 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_87, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_89 = V_6;
		int32_t L_90 = L_89.___prototypeIndex_6;
		NullCheck(L_88);
		int32_t L_91 = L_90;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_92 = (L_88)->GetAt(static_cast<il2cpp_array_size_t>(L_91));
		NullCheck(L_92);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_93;
		L_93 = TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C(L_92, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_94;
		L_94 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_95;
		L_95 = Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline(NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_96;
		L_96 = Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4(L_93, L_94, L_95, Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_97 = L_96;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_98 = L_97;
		NullCheck(L_98);
		String_t* L_99;
		L_99 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_98, NULL);
		String_t* L_100 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		NullCheck(L_99);
		String_t* L_101;
		L_101 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_99, _stringLiteralD41D89DAD98E1F1783260FD0A5A774F557A05F0F, L_100, NULL);
		NullCheck(L_98);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_98, L_101, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_102 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_103 = L_102.___position_0;
		V_7 = L_103;
		float* L_104 = (&(&V_7)->___x_2);
		float* L_105 = L_104;
		float L_106 = *((float*)L_105);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_107 = V_0;
		NullCheck(L_107);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_108;
		L_108 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_107, NULL);
		float L_109 = L_108.___x_2;
		*((float*)L_105) = (float)((float)il2cpp_codegen_multiply(L_106, L_109));
		float* L_110 = (&(&V_7)->___y_3);
		float* L_111 = L_110;
		float L_112 = *((float*)L_111);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_113 = V_0;
		NullCheck(L_113);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_114;
		L_114 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_113, NULL);
		float L_115 = L_114.___y_3;
		*((float*)L_111) = (float)((float)il2cpp_codegen_multiply(L_112, L_115));
		float* L_116 = (&(&V_7)->___z_4);
		float* L_117 = L_116;
		float L_118 = *((float*)L_117);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_119 = V_0;
		NullCheck(L_119);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_120;
		L_120 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_119, NULL);
		float L_121 = L_120.___z_4;
		*((float*)L_117) = (float)((float)il2cpp_codegen_multiply(L_118, L_121));
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_122 = L_97;
		NullCheck(L_122);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_123;
		L_123 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_122, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_124 = V_7;
		NullCheck(L_123);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_123, L_124, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_125 = L_122;
		NullCheck(L_125);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_126;
		L_126 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_125, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_127 = V_6;
		float L_128 = L_127.___rotation_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_129;
		L_129 = Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline(NULL);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_130;
		L_130 = Quaternion_AngleAxis_mF37022977B297E63AA70D69EA1C4C922FF22CC80(((float)il2cpp_codegen_multiply((57.2957802f), L_128)), L_129, NULL);
		NullCheck(L_126);
		Transform_set_localRotation_mAB4A011D134BA58AB780BECC0025CA65F16185FA(L_126, L_130, NULL);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_131 = V_0;
		NullCheck(L_131);
		TreePrototypeU5BU5D_tB0255CA167F991C2C9BA3BA55DF7417168D93B7A* L_132;
		L_132 = TerrainData_get_treePrototypes_m0A43789B50E554DACB5DF88C86DA23B89DB33EEB(L_131, NULL);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_133 = V_6;
		int32_t L_134 = L_133.___prototypeIndex_6;
		NullCheck(L_132);
		int32_t L_135 = L_134;
		TreePrototype_tA221EF2DEEEF8152E67DC6C07B55EACFDF2AF07D* L_136 = (L_132)->GetAt(static_cast<il2cpp_array_size_t>(L_135));
		NullCheck(L_136);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_137;
		L_137 = TreePrototype_get_prefab_mCE1630C35B09770D35B2ECA45B98D1CB6D5AC67C(L_136, NULL);
		NullCheck(L_137);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_138;
		L_138 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_137, NULL);
		NullCheck(L_138);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_139;
		L_139 = Transform_get_localScale_m804A002A53A645CDFCD15BB0F37209162720363F(L_138, NULL);
		V_8 = L_139;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_140;
		L_140 = Vector3_get_one_mC9B289F1E15C42C597180C9FE6FB492495B51D02_inline(NULL);
		V_9 = L_140;
		float* L_141 = (&(&V_9)->___x_2);
		float* L_142 = L_141;
		float L_143 = *((float*)L_142);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_144 = V_6;
		float L_145 = L_144.___widthScale_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_146 = V_8;
		float L_147 = L_146.___x_2;
		*((float*)L_142) = (float)((float)il2cpp_codegen_multiply(L_143, ((float)il2cpp_codegen_multiply(L_145, L_147))));
		float* L_148 = (&(&V_9)->___y_3);
		float* L_149 = L_148;
		float L_150 = *((float*)L_149);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_151 = V_6;
		float L_152 = L_151.___heightScale_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_153 = V_8;
		float L_154 = L_153.___y_3;
		*((float*)L_149) = (float)((float)il2cpp_codegen_multiply(L_150, ((float)il2cpp_codegen_multiply(L_152, L_154))));
		float* L_155 = (&(&V_9)->___z_4);
		float* L_156 = L_155;
		float L_157 = *((float*)L_156);
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_158 = V_6;
		float L_159 = L_158.___widthScale_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_160 = V_8;
		float L_161 = L_160.___z_4;
		*((float*)L_156) = (float)((float)il2cpp_codegen_multiply(L_157, ((float)il2cpp_codegen_multiply(L_159, L_161))));
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_162 = L_125;
		NullCheck(L_162);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_163;
		L_163 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_162, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_164 = V_9;
		NullCheck(L_163);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_163, L_164, NULL);
		NullCheck(L_162);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_165;
		L_165 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_162, NULL);
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_166 = V_2;
		TreeInstance_t382B018173ED020660D262061EA9424682614F50 L_167 = V_6;
		int32_t L_168 = L_167.___prototypeIndex_6;
		NullCheck(L_166);
		int32_t L_169 = L_168;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_170 = (L_166)->GetAt(static_cast<il2cpp_array_size_t>(L_169));
		NullCheck(L_170);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_171;
		L_171 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_170, NULL);
		NullCheck(L_165);
		Transform_set_parent_m9BD5E563B539DD5BEC342736B03F97B38A243234(L_165, L_171, NULL);
	}

IL_029a:
	{
		int32_t L_172 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_172, 1));
	}

IL_02a0:
	{
		int32_t L_173 = V_5;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_174 = V_0;
		NullCheck(L_174);
		TreeInstanceU5BU5D_tA728320FD1360BBC648153584A156DB0B90C2429* L_175;
		L_175 = TerrainData_get_treeInstances_mDAB68FD1F3677BD5CB122EA943493D5FC94B2147(L_174, NULL);
		NullCheck(L_175);
		if ((((int32_t)L_173) < ((int32_t)((int32_t)(((RuntimeArray*)L_175)->max_length)))))
		{
			goto IL_010a;
		}
	}
	{
		V_3 = 0;
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_176 = V_2;
		NullCheck(L_176);
		V_10 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_176)->max_length)), 1));
		goto IL_032c;
	}

IL_02ba:
	{
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_177 = V_2;
		int32_t L_178 = V_10;
		NullCheck(L_177);
		int32_t L_179 = L_178;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_180 = (L_177)->GetAt(static_cast<il2cpp_array_size_t>(L_179));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_181;
		L_181 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_180, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_181)
		{
			goto IL_0326;
		}
	}
	{
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_182 = V_2;
		int32_t L_183 = V_10;
		NullCheck(L_182);
		int32_t L_184 = L_183;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_185 = (L_182)->GetAt(static_cast<il2cpp_array_size_t>(L_184));
		NullCheck(L_185);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_186;
		L_186 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_185, NULL);
		NullCheck(L_186);
		int32_t L_187;
		L_187 = Transform_get_childCount_mE9C29C702AB662CC540CA053EDE48BDAFA35B4B0(L_186, NULL);
		V_11 = L_187;
		int32_t L_188 = V_11;
		if (L_188)
		{
			goto IL_02e5;
		}
	}
	{
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_189 = V_2;
		int32_t L_190 = V_10;
		NullCheck(L_189);
		int32_t L_191 = L_190;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_192 = (L_189)->GetAt(static_cast<il2cpp_array_size_t>(L_191));
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_m6336EBC83591A5DB64EC70C92132824C6E258705(L_192, NULL);
		goto IL_0326;
	}

IL_02e5:
	{
		GameObjectU5BU5D_tFF67550DFCE87096D7A3734EA15B75896B2722CF* L_193 = V_2;
		int32_t L_194 = V_10;
		NullCheck(L_193);
		int32_t L_195 = L_194;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_196 = (L_193)->GetAt(static_cast<il2cpp_array_size_t>(L_195));
		V_12 = L_196;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_197 = V_12;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_198 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_199 = L_198;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_200 = V_12;
		NullCheck(L_200);
		String_t* L_201;
		L_201 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_200, NULL);
		NullCheck(L_199);
		ArrayElementTypeCheck (L_199, L_201);
		(L_199)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_201);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_202 = L_199;
		NullCheck(L_202);
		ArrayElementTypeCheck (L_202, _stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32);
		(L_202)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)_stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_203 = L_202;
		int32_t L_204 = V_11;
		int32_t L_205 = L_204;
		RuntimeObject* L_206 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_205);
		NullCheck(L_203);
		ArrayElementTypeCheck (L_203, L_206);
		(L_203)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_206);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_207 = L_203;
		NullCheck(L_207);
		ArrayElementTypeCheck (L_207, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		(L_207)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)_stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		String_t* L_208;
		L_208 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_207, NULL);
		NullCheck(L_197);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_197, L_208, NULL);
		int32_t L_209 = V_3;
		int32_t L_210 = V_11;
		V_3 = ((int32_t)il2cpp_codegen_add(L_209, L_210));
	}

IL_0326:
	{
		int32_t L_211 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_subtract(L_211, 1));
	}

IL_032c:
	{
		int32_t L_212 = V_10;
		if ((((int32_t)L_212) >= ((int32_t)0)))
		{
			goto IL_02ba;
		}
	}
	{
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_213 = V_1;
		V_12 = L_213;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_214 = V_12;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_215 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)SZArrayNew(ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_216 = L_215;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_217 = V_12;
		NullCheck(L_217);
		String_t* L_218;
		L_218 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_217, NULL);
		NullCheck(L_216);
		ArrayElementTypeCheck (L_216, L_218);
		(L_216)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_218);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_219 = L_216;
		NullCheck(L_219);
		ArrayElementTypeCheck (L_219, _stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32);
		(L_219)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)_stringLiteralD99605E29810F93D7DAE4EFBB764C41AF4E80D32);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_220 = L_219;
		int32_t L_221 = V_3;
		int32_t L_222 = L_221;
		RuntimeObject* L_223 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_222);
		NullCheck(L_220);
		ArrayElementTypeCheck (L_220, L_223);
		(L_220)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_223);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_224 = L_220;
		NullCheck(L_224);
		ArrayElementTypeCheck (L_224, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		(L_224)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)_stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		String_t* L_225;
		L_225 = String_Concat_m9EB826D3BC0EF2322AA8E55DF0D20EE41B1E5A36(L_224, NULL);
		NullCheck(L_214);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_214, L_225, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_226 = V_1;
		return L_226;
	}
}
// System.String VacuumShaders.TerrainToMesh.TerrainToMeshConverter::TerrainToOBJ(UnityEngine.Terrain,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TerrainToMeshConverter_TerrainToOBJ_m92D0DE687802A0EAD263268D3A346883FD6F6A29 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, int32_t ___1__vertexCountHorizontal, int32_t ___2__vertexCountVertical, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral27316A4940BF2B13EE1D13319104AE84C93A6010);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3E321812348924F7AA224F948AC80E9E5A7841FE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4EA526C4094316E1ABDC97726C22C86A9A389C1A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5425E4DDE72D9B019B45A16C8F497D3B7D8EE6B2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA188446A42B03C243C9A7A0685A66E973B0D5739);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFF9F061FAD25E6BEA133D47C40B680E60D40D5CE);
		s_Il2CppMethodInitialized = true;
	}
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_0 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_1 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_2 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_3 = NULL;
	StringBuilder_t* V_4 = NULL;
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D V_5;
	memset((&V_5), 0, sizeof(V_5));
	int32_t V_6 = 0;
	float V_7 = 0.0f;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	{
		V_0 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL;
		V_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		V_2 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL;
		V_3 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)NULL;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		int32_t L_1 = ___1__vertexCountHorizontal;
		int32_t L_2 = ___2__vertexCountVertical;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_GenerateTerrainOBJ_m39D8EF8ED84134DDB615A055C216AC3F0B3BFAA2(L_0, L_1, L_2, (&V_0), (&V_1), (&V_2), (&V_3), NULL);
		StringBuilder_t* L_3 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_3, NULL);
		V_4 = L_3;
		StringBuilder_t* L_4 = V_4;
		il2cpp_codegen_runtime_class_init_inline(DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_il2cpp_TypeInfo_var);
		DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D L_5;
		L_5 = DateTime_get_Now_m636CB9651A9099D20BA1CF813A0C69637317325C(NULL);
		V_5 = L_5;
		String_t* L_6;
		L_6 = DateTime_ToString_m447C83E1F8FFFFF4D20C0F7D5C18DEB160F9833A((&V_5), NULL);
		String_t* L_7;
		L_7 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(_stringLiteralA188446A42B03C243C9A7A0685A66E973B0D5739, L_6, NULL);
		NullCheck(L_4);
		StringBuilder_t* L_8;
		L_8 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_4, L_7, NULL);
		StringBuilder_t* L_9 = V_4;
		String_t* L_10;
		L_10 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		String_t* L_11;
		L_11 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_10, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		NullCheck(L_9);
		StringBuilder_t* L_12;
		L_12 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_9, L_11, NULL);
		StringBuilder_t* L_13 = V_4;
		String_t* L_14;
		L_14 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_13);
		StringBuilder_t* L_15;
		L_15 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_13, L_14, NULL);
		StringBuilder_t* L_16 = V_4;
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_17 = ___0__terrain;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_17, NULL);
		String_t* L_19;
		L_19 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(_stringLiteral4EA526C4094316E1ABDC97726C22C86A9A389C1A, L_18, NULL);
		NullCheck(L_16);
		StringBuilder_t* L_20;
		L_20 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_16, L_19, NULL);
		StringBuilder_t* L_21 = V_4;
		String_t* L_22;
		L_22 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		String_t* L_23;
		L_23 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_22, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		NullCheck(L_21);
		StringBuilder_t* L_24;
		L_24 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_21, L_23, NULL);
		StringBuilder_t* L_25 = V_4;
		String_t* L_26;
		L_26 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_25);
		StringBuilder_t* L_27;
		L_27 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_25, L_26, NULL);
		V_6 = 0;
		goto IL_0133;
	}

IL_00a7:
	{
		StringBuilder_t* L_28 = V_4;
		NullCheck(L_28);
		StringBuilder_t* L_29;
		L_29 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_28, _stringLiteral3E321812348924F7AA224F948AC80E9E5A7841FE, NULL);
		StringBuilder_t* L_30 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_31 = V_0;
		int32_t L_32 = V_6;
		NullCheck(L_31);
		float L_33 = ((L_31)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_32)))->___x_2;
		V_7 = ((float)il2cpp_codegen_multiply(L_33, (-1.0f)));
		String_t* L_34;
		L_34 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972((&V_7), NULL);
		NullCheck(L_30);
		StringBuilder_t* L_35;
		L_35 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_30, L_34, NULL);
		NullCheck(L_35);
		StringBuilder_t* L_36;
		L_36 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_35, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_37 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = V_0;
		int32_t L_39 = V_6;
		NullCheck(L_38);
		float* L_40 = (&((L_38)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_39)))->___y_3);
		String_t* L_41;
		L_41 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_40, NULL);
		NullCheck(L_37);
		StringBuilder_t* L_42;
		L_42 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_37, L_41, NULL);
		NullCheck(L_42);
		StringBuilder_t* L_43;
		L_43 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_42, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_44 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_45 = V_0;
		int32_t L_46 = V_6;
		NullCheck(L_45);
		float* L_47 = (&((L_45)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_46)))->___z_4);
		String_t* L_48;
		L_48 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_47, NULL);
		NullCheck(L_44);
		StringBuilder_t* L_49;
		L_49 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_44, L_48, NULL);
		StringBuilder_t* L_50 = V_4;
		String_t* L_51;
		L_51 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_50);
		StringBuilder_t* L_52;
		L_52 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_50, L_51, NULL);
		int32_t L_53 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_53, 1));
	}

IL_0133:
	{
		int32_t L_54 = V_6;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_55 = V_0;
		NullCheck(L_55);
		if ((((int32_t)L_54) < ((int32_t)((int32_t)(((RuntimeArray*)L_55)->max_length)))))
		{
			goto IL_00a7;
		}
	}
	{
		V_8 = 0;
		goto IL_01a0;
	}

IL_0142:
	{
		StringBuilder_t* L_56 = V_4;
		NullCheck(L_56);
		StringBuilder_t* L_57;
		L_57 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_56, _stringLiteral27316A4940BF2B13EE1D13319104AE84C93A6010, NULL);
		StringBuilder_t* L_58 = V_4;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_59 = V_3;
		int32_t L_60 = V_8;
		NullCheck(L_59);
		float* L_61 = (&((L_59)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_60)))->___x_0);
		String_t* L_62;
		L_62 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_61, NULL);
		NullCheck(L_58);
		StringBuilder_t* L_63;
		L_63 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_58, L_62, NULL);
		NullCheck(L_63);
		StringBuilder_t* L_64;
		L_64 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_63, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_65 = V_4;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_66 = V_3;
		int32_t L_67 = V_8;
		NullCheck(L_66);
		float* L_68 = (&((L_66)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_67)))->___y_1);
		String_t* L_69;
		L_69 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_68, NULL);
		NullCheck(L_65);
		StringBuilder_t* L_70;
		L_70 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_65, L_69, NULL);
		StringBuilder_t* L_71 = V_4;
		String_t* L_72;
		L_72 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_71);
		StringBuilder_t* L_73;
		L_73 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_71, L_72, NULL);
		int32_t L_74 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_74, 1));
	}

IL_01a0:
	{
		int32_t L_75 = V_8;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_76 = V_3;
		NullCheck(L_76);
		if ((((int32_t)L_75) < ((int32_t)((int32_t)(((RuntimeArray*)L_76)->max_length)))))
		{
			goto IL_0142;
		}
	}
	{
		V_9 = 0;
		goto IL_023b;
	}

IL_01af:
	{
		StringBuilder_t* L_77 = V_4;
		NullCheck(L_77);
		StringBuilder_t* L_78;
		L_78 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_77, _stringLiteralFF9F061FAD25E6BEA133D47C40B680E60D40D5CE, NULL);
		StringBuilder_t* L_79 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_80 = V_2;
		int32_t L_81 = V_9;
		NullCheck(L_80);
		float L_82 = ((L_80)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_81)))->___x_2;
		V_7 = ((float)il2cpp_codegen_multiply(L_82, (-1.0f)));
		String_t* L_83;
		L_83 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972((&V_7), NULL);
		NullCheck(L_79);
		StringBuilder_t* L_84;
		L_84 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_79, L_83, NULL);
		NullCheck(L_84);
		StringBuilder_t* L_85;
		L_85 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_84, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_86 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_87 = V_2;
		int32_t L_88 = V_9;
		NullCheck(L_87);
		float* L_89 = (&((L_87)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_88)))->___y_3);
		String_t* L_90;
		L_90 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_89, NULL);
		NullCheck(L_86);
		StringBuilder_t* L_91;
		L_91 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_86, L_90, NULL);
		NullCheck(L_91);
		StringBuilder_t* L_92;
		L_92 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_91, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_93 = V_4;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_94 = V_2;
		int32_t L_95 = V_9;
		NullCheck(L_94);
		float* L_96 = (&((L_94)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_95)))->___z_4);
		String_t* L_97;
		L_97 = Single_ToString_mE282EDA9CA4F7DF88432D807732837A629D04972(L_96, NULL);
		NullCheck(L_93);
		StringBuilder_t* L_98;
		L_98 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_93, L_97, NULL);
		StringBuilder_t* L_99 = V_4;
		String_t* L_100;
		L_100 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_99);
		StringBuilder_t* L_101;
		L_101 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_99, L_100, NULL);
		int32_t L_102 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_102, 1));
	}

IL_023b:
	{
		int32_t L_103 = V_9;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_104 = V_2;
		NullCheck(L_104);
		if ((((int32_t)L_103) < ((int32_t)((int32_t)(((RuntimeArray*)L_104)->max_length)))))
		{
			goto IL_01af;
		}
	}
	{
		V_10 = 0;
		goto IL_0335;
	}

IL_024d:
	{
		StringBuilder_t* L_105 = V_4;
		NullCheck(L_105);
		StringBuilder_t* L_106;
		L_106 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_105, _stringLiteral5425E4DDE72D9B019B45A16C8F497D3B7D8EE6B2, NULL);
		StringBuilder_t* L_107 = V_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_108 = V_1;
		int32_t L_109 = V_10;
		NullCheck(L_108);
		int32_t L_110 = ((int32_t)il2cpp_codegen_add(L_109, 2));
		int32_t L_111 = (L_108)->GetAt(static_cast<il2cpp_array_size_t>(L_110));
		NullCheck(L_107);
		StringBuilder_t* L_112;
		L_112 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_107, ((int32_t)il2cpp_codegen_add(L_111, 1)), NULL);
		NullCheck(L_112);
		StringBuilder_t* L_113;
		L_113 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_112, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_114 = V_1;
		int32_t L_115 = V_10;
		NullCheck(L_114);
		int32_t L_116 = ((int32_t)il2cpp_codegen_add(L_115, 2));
		int32_t L_117 = (L_114)->GetAt(static_cast<il2cpp_array_size_t>(L_116));
		NullCheck(L_113);
		StringBuilder_t* L_118;
		L_118 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_113, ((int32_t)il2cpp_codegen_add(L_117, 1)), NULL);
		NullCheck(L_118);
		StringBuilder_t* L_119;
		L_119 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_118, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_120 = V_1;
		int32_t L_121 = V_10;
		NullCheck(L_120);
		int32_t L_122 = ((int32_t)il2cpp_codegen_add(L_121, 2));
		int32_t L_123 = (L_120)->GetAt(static_cast<il2cpp_array_size_t>(L_122));
		NullCheck(L_119);
		StringBuilder_t* L_124;
		L_124 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_119, ((int32_t)il2cpp_codegen_add(L_123, 1)), NULL);
		NullCheck(L_124);
		StringBuilder_t* L_125;
		L_125 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_124, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_126 = V_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_127 = V_1;
		int32_t L_128 = V_10;
		NullCheck(L_127);
		int32_t L_129 = ((int32_t)il2cpp_codegen_add(L_128, 1));
		int32_t L_130 = (L_127)->GetAt(static_cast<il2cpp_array_size_t>(L_129));
		NullCheck(L_126);
		StringBuilder_t* L_131;
		L_131 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_126, ((int32_t)il2cpp_codegen_add(L_130, 1)), NULL);
		NullCheck(L_131);
		StringBuilder_t* L_132;
		L_132 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_131, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_133 = V_1;
		int32_t L_134 = V_10;
		NullCheck(L_133);
		int32_t L_135 = ((int32_t)il2cpp_codegen_add(L_134, 1));
		int32_t L_136 = (L_133)->GetAt(static_cast<il2cpp_array_size_t>(L_135));
		NullCheck(L_132);
		StringBuilder_t* L_137;
		L_137 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_132, ((int32_t)il2cpp_codegen_add(L_136, 1)), NULL);
		NullCheck(L_137);
		StringBuilder_t* L_138;
		L_138 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_137, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_139 = V_1;
		int32_t L_140 = V_10;
		NullCheck(L_139);
		int32_t L_141 = ((int32_t)il2cpp_codegen_add(L_140, 1));
		int32_t L_142 = (L_139)->GetAt(static_cast<il2cpp_array_size_t>(L_141));
		NullCheck(L_138);
		StringBuilder_t* L_143;
		L_143 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_138, ((int32_t)il2cpp_codegen_add(L_142, 1)), NULL);
		NullCheck(L_143);
		StringBuilder_t* L_144;
		L_144 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_143, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		StringBuilder_t* L_145 = V_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_146 = V_1;
		int32_t L_147 = V_10;
		NullCheck(L_146);
		int32_t L_148 = L_147;
		int32_t L_149 = (L_146)->GetAt(static_cast<il2cpp_array_size_t>(L_148));
		NullCheck(L_145);
		StringBuilder_t* L_150;
		L_150 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_145, ((int32_t)il2cpp_codegen_add(L_149, 1)), NULL);
		NullCheck(L_150);
		StringBuilder_t* L_151;
		L_151 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_150, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_152 = V_1;
		int32_t L_153 = V_10;
		NullCheck(L_152);
		int32_t L_154 = L_153;
		int32_t L_155 = (L_152)->GetAt(static_cast<il2cpp_array_size_t>(L_154));
		NullCheck(L_151);
		StringBuilder_t* L_156;
		L_156 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_151, ((int32_t)il2cpp_codegen_add(L_155, 1)), NULL);
		NullCheck(L_156);
		StringBuilder_t* L_157;
		L_157 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_156, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_158 = V_1;
		int32_t L_159 = V_10;
		NullCheck(L_158);
		int32_t L_160 = L_159;
		int32_t L_161 = (L_158)->GetAt(static_cast<il2cpp_array_size_t>(L_160));
		NullCheck(L_157);
		StringBuilder_t* L_162;
		L_162 = StringBuilder_Append_m283B617AC29FB0DD6F3A7D8C01D385C25A5F0FAA(L_157, ((int32_t)il2cpp_codegen_add(L_161, 1)), NULL);
		StringBuilder_t* L_163 = V_4;
		String_t* L_164;
		L_164 = Environment_get_NewLine_m8BF68A4EFDAFFB66500984CE779629811BA98FFF(NULL);
		NullCheck(L_163);
		StringBuilder_t* L_165;
		L_165 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_163, L_164, NULL);
		int32_t L_166 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add(L_166, 3));
	}

IL_0335:
	{
		int32_t L_167 = V_10;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_168 = V_1;
		NullCheck(L_168);
		if ((((int32_t)L_167) < ((int32_t)((int32_t)(((RuntimeArray*)L_168)->max_length)))))
		{
			goto IL_024d;
		}
	}
	{
		StringBuilder_t* L_169 = V_4;
		NullCheck(L_169);
		String_t* L_170;
		L_170 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_169);
		return L_170;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainOBJ(UnityEngine.Terrain,System.Int32,System.Int32,UnityEngine.Vector3[]&,System.Int32[]&,UnityEngine.Vector3[]&,UnityEngine.Vector2[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTerrainOBJ_m39D8EF8ED84134DDB615A055C216AC3F0B3BFAA2 (Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* ___0__terrain, int32_t ___1__vCountH, int32_t ___2_vCountV, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___3__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** ___4__trinagles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___5__normals, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** ___6__uvs, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	int32_t V_11 = 0;
	int32_t V_12 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_13;
	memset((&V_13), 0, sizeof(V_13));
	int32_t V_14 = 0;
	int32_t V_15 = 0;
	{
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ___0__terrain;
		NullCheck(L_0);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_1;
		L_1 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_0, NULL);
		V_0 = L_1;
		int32_t L_2 = ___2_vCountV;
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_2, 1));
		int32_t L_3 = ___1__vCountH;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_3, 1));
		int32_t L_4 = V_1;
		if ((((int32_t)L_4) >= ((int32_t)1)))
		{
			goto IL_0015;
		}
	}
	{
		V_1 = 1;
	}

IL_0015:
	{
		int32_t L_5 = V_2;
		if ((((int32_t)L_5) >= ((int32_t)1)))
		{
			goto IL_001b;
		}
	}
	{
		V_2 = 1;
	}

IL_001b:
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_6 = V_0;
		NullCheck(L_6);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_6, NULL);
		float L_8 = L_7.___x_2;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_9 = V_0;
		NullCheck(L_9);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_9, NULL);
		float L_11 = L_10.___z_4;
		V_3 = L_11;
		int32_t L_12 = V_2;
		V_4 = ((float)(L_8/((float)L_12)));
		float L_13 = V_3;
		int32_t L_14 = V_1;
		V_5 = ((float)(L_13/((float)L_14)));
		int32_t L_15 = V_1;
		V_6 = ((int32_t)il2cpp_codegen_add(L_15, 1));
		int32_t L_16 = V_2;
		V_7 = ((int32_t)il2cpp_codegen_add(L_16, 1));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_17 = ___3__vertices;
		int32_t L_18 = V_7;
		int32_t L_19 = V_6;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_20 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_18, L_19)));
		*((RuntimeObject**)L_17) = (RuntimeObject*)L_20;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_17, (void*)(RuntimeObject*)L_20);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_21 = ___4__trinagles;
		int32_t L_22 = V_1;
		int32_t L_23 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_22, L_23)), 2)), 3)));
		*((RuntimeObject**)L_21) = (RuntimeObject*)L_24;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_21, (void*)(RuntimeObject*)L_24);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_25 = ___5__normals;
		*((RuntimeObject**)L_25) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_25, (void*)(RuntimeObject*)NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_26 = ___6__uvs;
		int32_t L_27 = V_7;
		int32_t L_28 = V_6;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_29 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_27, L_28)));
		*((RuntimeObject**)L_26) = (RuntimeObject*)L_29;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_26, (void*)(RuntimeObject*)L_29);
		V_8 = (-1);
		V_11 = 0;
		goto IL_010e;
	}

IL_007e:
	{
		V_12 = 0;
		goto IL_00ff;
	}

IL_0083:
	{
		int32_t L_30 = V_12;
		float L_31 = V_4;
		int32_t L_32 = V_11;
		float L_33 = V_5;
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&V_13), ((float)il2cpp_codegen_multiply(((float)L_30), L_31)), (0.0f), ((float)il2cpp_codegen_multiply(((float)L_32), L_33)), NULL);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_34 = ___0__terrain;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = V_13;
		NullCheck(L_34);
		float L_36;
		L_36 = Terrain_SampleHeight_m460F9060BC4D5F05275391A6AC05570047EF3177(L_34, L_35, NULL);
		(&V_13)->___y_3 = L_36;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_37 = ___3__vertices;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_37);
		int32_t L_39 = V_8;
		int32_t L_40 = ((int32_t)il2cpp_codegen_add(L_39, 1));
		V_8 = L_40;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = V_13;
		NullCheck(L_38);
		(L_38)->SetAt(static_cast<il2cpp_array_size_t>(L_40), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_41);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA** L_42 = ___6__uvs;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_43 = *((Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA**)L_42);
		int32_t L_44 = V_8;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45 = V_13;
		float L_46 = L_45.___x_2;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_47 = V_0;
		NullCheck(L_47);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_48;
		L_48 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_47, NULL);
		float L_49 = L_48.___x_2;
		float L_50;
		L_50 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_46/L_49)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51 = V_13;
		float L_52 = L_51.___z_4;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_53 = V_0;
		NullCheck(L_53);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54;
		L_54 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_53, NULL);
		float L_55 = L_54.___z_4;
		float L_56;
		L_56 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_52/L_55)), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_57;
		memset((&L_57), 0, sizeof(L_57));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_57), L_50, L_56, /*hidden argument*/NULL);
		NullCheck(L_43);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(L_44), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_57);
		int32_t L_58 = V_12;
		V_12 = ((int32_t)il2cpp_codegen_add(L_58, 1));
	}

IL_00ff:
	{
		int32_t L_59 = V_12;
		int32_t L_60 = V_7;
		if ((((int32_t)L_59) < ((int32_t)L_60)))
		{
			goto IL_0083;
		}
	}
	{
		int32_t L_61 = V_11;
		V_11 = ((int32_t)il2cpp_codegen_add(L_61, 1));
	}

IL_010e:
	{
		int32_t L_62 = V_11;
		int32_t L_63 = V_6;
		if ((((int32_t)L_62) < ((int32_t)L_63)))
		{
			goto IL_007e;
		}
	}
	{
		V_9 = 0;
		V_10 = 0;
		V_8 = (-1);
		V_14 = 0;
		goto IL_01b2;
	}

IL_0128:
	{
		int32_t L_64 = V_14;
		int32_t L_65 = V_7;
		V_9 = ((int32_t)il2cpp_codegen_multiply(L_64, L_65));
		int32_t L_66 = V_10;
		int32_t L_67 = V_7;
		V_10 = ((int32_t)il2cpp_codegen_add(L_66, L_67));
		V_15 = 0;
		goto IL_01a7;
	}

IL_013b:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_68 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_69 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_68);
		int32_t L_70 = V_8;
		int32_t L_71 = ((int32_t)il2cpp_codegen_add(L_70, 1));
		V_8 = L_71;
		int32_t L_72 = V_9;
		int32_t L_73 = V_15;
		NullCheck(L_69);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(L_71), (int32_t)((int32_t)il2cpp_codegen_add(L_72, L_73)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_74 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_75 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_74);
		int32_t L_76 = V_8;
		int32_t L_77 = ((int32_t)il2cpp_codegen_add(L_76, 1));
		V_8 = L_77;
		int32_t L_78 = V_10;
		int32_t L_79 = V_15;
		NullCheck(L_75);
		(L_75)->SetAt(static_cast<il2cpp_array_size_t>(L_77), (int32_t)((int32_t)il2cpp_codegen_add(L_78, L_79)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_80 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_81 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_80);
		int32_t L_82 = V_8;
		int32_t L_83 = ((int32_t)il2cpp_codegen_add(L_82, 1));
		V_8 = L_83;
		int32_t L_84 = V_10;
		int32_t L_85 = V_15;
		NullCheck(L_81);
		(L_81)->SetAt(static_cast<il2cpp_array_size_t>(L_83), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_84, L_85)), 1)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_86 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_87 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_86);
		int32_t L_88 = V_8;
		int32_t L_89 = ((int32_t)il2cpp_codegen_add(L_88, 1));
		V_8 = L_89;
		int32_t L_90 = V_9;
		int32_t L_91 = V_15;
		NullCheck(L_87);
		(L_87)->SetAt(static_cast<il2cpp_array_size_t>(L_89), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_90, L_91)), 1)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_92 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_93 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_92);
		int32_t L_94 = V_8;
		int32_t L_95 = ((int32_t)il2cpp_codegen_add(L_94, 1));
		V_8 = L_95;
		int32_t L_96 = V_9;
		int32_t L_97 = V_15;
		NullCheck(L_93);
		(L_93)->SetAt(static_cast<il2cpp_array_size_t>(L_95), (int32_t)((int32_t)il2cpp_codegen_add(L_96, L_97)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_98 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_99 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_98);
		int32_t L_100 = V_8;
		int32_t L_101 = ((int32_t)il2cpp_codegen_add(L_100, 1));
		V_8 = L_101;
		int32_t L_102 = V_10;
		int32_t L_103 = V_15;
		NullCheck(L_99);
		(L_99)->SetAt(static_cast<il2cpp_array_size_t>(L_101), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_102, L_103)), 1)));
		int32_t L_104 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_104, 1));
	}

IL_01a7:
	{
		int32_t L_105 = V_15;
		int32_t L_106 = V_2;
		if ((((int32_t)L_105) < ((int32_t)L_106)))
		{
			goto IL_013b;
		}
	}
	{
		int32_t L_107 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_107, 1));
	}

IL_01b2:
	{
		int32_t L_108 = V_14;
		int32_t L_109 = V_1;
		if ((((int32_t)L_108) < ((int32_t)L_109)))
		{
			goto IL_0128;
		}
	}
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_110 = ___3__vertices;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_111 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_110);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C** L_112 = ___4__trinagles;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_113 = *((Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C**)L_112);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_114 = ___5__normals;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_GenerateNormals_m017762E446405F9EA0A0991C669950579514D0C8(L_111, L_113, L_114, NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainBaseChunks(VacuumShaders.TerrainToMesh.PreMesh[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTerrainBaseChunks_m8F805CFFC5B087C619E46746492E0C180782D89E (PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** ___0__preMeshes, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD55DD4F5305B96ED01127FA9602F1551CB0D2AFB);
		s_Il2CppMethodInitialized = true;
	}
	TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	float V_6 = 0.0f;
	float V_7 = 0.0f;
	float V_8 = 0.0f;
	float V_9 = 0.0f;
	float V_10 = 0.0f;
	float V_11 = 0.0f;
	int32_t V_12 = 0;
	int32_t V_13 = 0;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* V_14 = NULL;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_15 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_16 = NULL;
	int32_t V_17 = 0;
	int32_t V_18 = 0;
	int32_t V_19 = 0;
	int32_t V_20 = 0;
	int32_t V_21 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_22;
	memset((&V_22), 0, sizeof(V_22));
	int32_t V_23 = 0;
	int32_t V_24 = 0;
	{
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_0 = ___0__preMeshes;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_1 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_1);
		int32_t L_2 = L_1->___chunkCountHorizontal_1;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_3 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_3);
		int32_t L_4 = L_3->___chunkCountVertical_2;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_5 = (PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B*)(PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B*)SZArrayNew(PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_2, L_4)));
		*((RuntimeObject**)L_0) = (RuntimeObject*)L_5;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_0, (void*)(RuntimeObject*)L_5);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_6 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_6);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_7;
		L_7 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_6, NULL);
		V_0 = L_7;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_8 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_8);
		int32_t L_9 = L_8->___vertexCountVertical_4;
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_9, 1));
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_10 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_10);
		int32_t L_11 = L_10->___vertexCountHorizontal_3;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_11, 1));
		int32_t L_12 = V_1;
		if ((((int32_t)L_12) >= ((int32_t)1)))
		{
			goto IL_0047;
		}
	}
	{
		V_1 = 1;
	}

IL_0047:
	{
		int32_t L_13 = V_2;
		if ((((int32_t)L_13) >= ((int32_t)1)))
		{
			goto IL_004d;
		}
	}
	{
		V_2 = 1;
	}

IL_004d:
	{
		V_3 = (-1);
		V_4 = 0;
		goto IL_0327;
	}

IL_0057:
	{
		V_5 = 0;
		goto IL_0310;
	}

IL_005f:
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_14 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_14);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_15;
		L_15 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_14, NULL);
		NullCheck(L_15);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_15, NULL);
		float L_17 = L_16.___x_2;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_18 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_18);
		int32_t L_19 = L_18->___chunkCountHorizontal_1;
		V_6 = ((float)(L_17/((float)L_19)));
		int32_t L_20 = V_4;
		float L_21 = V_6;
		V_7 = ((float)il2cpp_codegen_multiply(((float)L_20), L_21));
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_22 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_22);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_23;
		L_23 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_22, NULL);
		NullCheck(L_23);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		L_24 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_23, NULL);
		float L_25 = L_24.___z_4;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_26 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_26);
		int32_t L_27 = L_26->___chunkCountVertical_2;
		V_8 = ((float)(L_25/((float)L_27)));
		int32_t L_28 = V_5;
		float L_29 = V_8;
		V_9 = ((float)il2cpp_codegen_multiply(((float)L_28), L_29));
		float L_30 = V_6;
		int32_t L_31 = V_2;
		V_10 = ((float)(L_30/((float)L_31)));
		float L_32 = V_8;
		int32_t L_33 = V_1;
		V_11 = ((float)(L_32/((float)L_33)));
		int32_t L_34 = V_1;
		V_12 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_34, 1)), 2));
		int32_t L_35 = V_2;
		V_13 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_35, 1)), 2));
		int32_t L_36 = V_13;
		int32_t L_37 = V_12;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_38 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		NullCheck(L_38);
		List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33(L_38, ((int32_t)il2cpp_codegen_multiply(L_36, L_37)), List_1__ctor_m7E6E0C4AE37ACBC1E9BDA9E56A8A7D8ACED3FD33_RuntimeMethod_var);
		V_14 = L_38;
		int32_t L_39 = V_1;
		int32_t L_40 = V_2;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_41 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		NullCheck(L_41);
		List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98(L_41, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_add(L_39, 2)), ((int32_t)il2cpp_codegen_add(L_40, 2)))), 2)), 3)), List_1__ctor_m30DD6F0F8DFBA9856BF7220A3CDB1C89ECEC0D98_RuntimeMethod_var);
		V_15 = L_41;
		int32_t L_42 = V_13;
		int32_t L_43 = V_12;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_44 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_42, L_43)));
		V_16 = L_44;
		V_17 = (-1);
		V_20 = 0;
		goto IL_01a5;
	}

IL_0104:
	{
		V_21 = 0;
		goto IL_0196;
	}

IL_010c:
	{
		float L_45 = V_7;
		int32_t L_46 = V_21;
		float L_47 = V_10;
		float L_48 = V_10;
		float L_49 = V_9;
		int32_t L_50 = V_20;
		float L_51 = V_11;
		float L_52 = V_11;
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&V_22), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_add(L_45, ((float)il2cpp_codegen_multiply(((float)L_46), L_47)))), L_48)), (0.0f), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_add(L_49, ((float)il2cpp_codegen_multiply(((float)L_50), L_51)))), L_52)), NULL);
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_53 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_54 = V_22;
		NullCheck(L_53);
		float L_55;
		L_55 = Terrain_SampleHeight_m460F9060BC4D5F05275391A6AC05570047EF3177(L_53, L_54, NULL);
		(&V_22)->___y_3 = L_55;
		int32_t L_56 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_56, 1));
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_57 = V_14;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = V_22;
		NullCheck(L_57);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_57, L_58, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_59 = V_16;
		int32_t L_60 = V_17;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_61 = V_22;
		float L_62 = L_61.___x_2;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_63 = V_0;
		NullCheck(L_63);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_64;
		L_64 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_63, NULL);
		float L_65 = L_64.___x_2;
		float L_66;
		L_66 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_62/L_65)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_67 = V_22;
		float L_68 = L_67.___z_4;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_69 = V_0;
		NullCheck(L_69);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_70;
		L_70 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_69, NULL);
		float L_71 = L_70.___z_4;
		float L_72;
		L_72 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_68/L_71)), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_73;
		memset((&L_73), 0, sizeof(L_73));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_73), L_66, L_72, /*hidden argument*/NULL);
		NullCheck(L_59);
		(L_59)->SetAt(static_cast<il2cpp_array_size_t>(L_60), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_73);
		int32_t L_74 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_74, 1));
	}

IL_0196:
	{
		int32_t L_75 = V_21;
		int32_t L_76 = V_13;
		if ((((int32_t)L_75) < ((int32_t)L_76)))
		{
			goto IL_010c;
		}
	}
	{
		int32_t L_77 = V_20;
		V_20 = ((int32_t)il2cpp_codegen_add(L_77, 1));
	}

IL_01a5:
	{
		int32_t L_78 = V_20;
		int32_t L_79 = V_12;
		if ((((int32_t)L_78) < ((int32_t)L_79)))
		{
			goto IL_0104;
		}
	}
	{
		V_18 = 0;
		V_19 = 0;
		V_17 = (-1);
		V_23 = 0;
		goto IL_0236;
	}

IL_01bc:
	{
		int32_t L_80 = V_23;
		int32_t L_81 = V_13;
		V_18 = ((int32_t)il2cpp_codegen_multiply(L_80, L_81));
		int32_t L_82 = V_19;
		int32_t L_83 = V_13;
		V_19 = ((int32_t)il2cpp_codegen_add(L_82, L_83));
		V_24 = 0;
		goto IL_0229;
	}

IL_01cf:
	{
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_84 = V_15;
		int32_t L_85 = V_18;
		int32_t L_86 = V_24;
		NullCheck(L_84);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_84, ((int32_t)il2cpp_codegen_add(L_85, L_86)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_87 = V_15;
		int32_t L_88 = V_19;
		int32_t L_89 = V_24;
		NullCheck(L_87);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_87, ((int32_t)il2cpp_codegen_add(L_88, L_89)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_90 = V_15;
		int32_t L_91 = V_19;
		int32_t L_92 = V_24;
		NullCheck(L_90);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_90, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_91, L_92)), 1)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_93 = V_15;
		int32_t L_94 = V_18;
		int32_t L_95 = V_24;
		NullCheck(L_93);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_93, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_94, L_95)), 1)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_96 = V_15;
		int32_t L_97 = V_18;
		int32_t L_98 = V_24;
		NullCheck(L_96);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_96, ((int32_t)il2cpp_codegen_add(L_97, L_98)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_99 = V_15;
		int32_t L_100 = V_19;
		int32_t L_101 = V_24;
		NullCheck(L_99);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_99, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_100, L_101)), 1)), List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		int32_t L_102 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_102, 6));
		int32_t L_103 = V_24;
		V_24 = ((int32_t)il2cpp_codegen_add(L_103, 1));
	}

IL_0229:
	{
		int32_t L_104 = V_24;
		int32_t L_105 = V_2;
		if ((((int32_t)L_104) < ((int32_t)((int32_t)il2cpp_codegen_add(L_105, 2)))))
		{
			goto IL_01cf;
		}
	}
	{
		int32_t L_106 = V_23;
		V_23 = ((int32_t)il2cpp_codegen_add(L_106, 1));
	}

IL_0236:
	{
		int32_t L_107 = V_23;
		int32_t L_108 = V_1;
		if ((((int32_t)L_107) < ((int32_t)((int32_t)il2cpp_codegen_add(L_108, 2)))))
		{
			goto IL_01bc;
		}
	}
	{
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_109 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_110 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_109);
		int32_t L_111 = V_3;
		int32_t L_112 = ((int32_t)il2cpp_codegen_add(L_111, 1));
		V_3 = L_112;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_113 = (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03*)il2cpp_codegen_object_new(PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03_il2cpp_TypeInfo_var);
		NullCheck(L_113);
		PreMesh__ctor_mCFC51B5015A64C2EFC55D3EB7A09645F8A2DE0B6(L_113, NULL);
		NullCheck(L_110);
		ArrayElementTypeCheck (L_110, L_113);
		(L_110)->SetAt(static_cast<il2cpp_array_size_t>(L_112), (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03*)L_113);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_114 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_115 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_114);
		int32_t L_116 = V_3;
		NullCheck(L_115);
		int32_t L_117 = L_116;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_118 = (L_115)->GetAt(static_cast<il2cpp_array_size_t>(L_117));
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_119 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_119);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_120;
		L_120 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_119, NULL);
		NullCheck(L_120);
		String_t* L_121;
		L_121 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_120, NULL);
		int32_t L_122 = V_4;
		int32_t L_123 = L_122;
		RuntimeObject* L_124 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_123);
		int32_t L_125 = V_5;
		int32_t L_126 = L_125;
		RuntimeObject* L_127 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_126);
		String_t* L_128;
		L_128 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteralD55DD4F5305B96ED01127FA9602F1551CB0D2AFB, L_124, L_127, NULL);
		String_t* L_129;
		L_129 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_121, L_128, NULL);
		NullCheck(L_118);
		L_118->___name_0 = L_129;
		Il2CppCodeGenWriteBarrier((void**)(&L_118->___name_0), (void*)L_129);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_130 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_131 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_130);
		int32_t L_132 = V_3;
		NullCheck(L_131);
		int32_t L_133 = L_132;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_134 = (L_131)->GetAt(static_cast<il2cpp_array_size_t>(L_133));
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_135 = V_14;
		NullCheck(L_135);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_136;
		L_136 = List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3(L_135, List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var);
		NullCheck(L_134);
		L_134->___vertices_1 = L_136;
		Il2CppCodeGenWriteBarrier((void**)(&L_134->___vertices_1), (void*)L_136);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_137 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_138 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_137);
		int32_t L_139 = V_3;
		NullCheck(L_138);
		int32_t L_140 = L_139;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_141 = (L_138)->GetAt(static_cast<il2cpp_array_size_t>(L_140));
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_142 = V_15;
		NullCheck(L_142);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_143;
		L_143 = List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA(L_142, List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		NullCheck(L_141);
		L_141->___triangles_2 = L_143;
		Il2CppCodeGenWriteBarrier((void**)(&L_141->___triangles_2), (void*)L_143);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_144 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_145 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_144);
		int32_t L_146 = V_3;
		NullCheck(L_145);
		int32_t L_147 = L_146;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_148 = (L_145)->GetAt(static_cast<il2cpp_array_size_t>(L_147));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_149 = V_16;
		NullCheck(L_148);
		L_148->___uv_3 = L_149;
		Il2CppCodeGenWriteBarrier((void**)(&L_148->___uv_3), (void*)L_149);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_150 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_151 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_150);
		int32_t L_152 = V_3;
		NullCheck(L_151);
		int32_t L_153 = L_152;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_154 = (L_151)->GetAt(static_cast<il2cpp_array_size_t>(L_153));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_155 = V_16;
		NullCheck(L_154);
		L_154->___uv2_4 = L_155;
		Il2CppCodeGenWriteBarrier((void**)(&L_154->___uv2_4), (void*)L_155);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_156 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_157 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_156);
		int32_t L_158 = V_3;
		NullCheck(L_157);
		int32_t L_159 = L_158;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_160 = (L_157)->GetAt(static_cast<il2cpp_array_size_t>(L_159));
		NullCheck(L_160);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_161 = L_160->___vertices_1;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_162 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_163 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_162);
		int32_t L_164 = V_3;
		NullCheck(L_163);
		int32_t L_165 = L_164;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_166 = (L_163)->GetAt(static_cast<il2cpp_array_size_t>(L_165));
		NullCheck(L_166);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_167 = L_166->___triangles_2;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_168 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_169 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_168);
		int32_t L_170 = V_3;
		NullCheck(L_169);
		int32_t L_171 = L_170;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_172 = (L_169)->GetAt(static_cast<il2cpp_array_size_t>(L_171));
		NullCheck(L_172);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_173 = (&L_172->___normals_5);
		TerrainToMeshConverter_GenerateNormals_m017762E446405F9EA0A0991C669950579514D0C8(L_161, L_167, L_173, NULL);
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_174 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_175 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_174);
		int32_t L_176 = V_3;
		NullCheck(L_175);
		int32_t L_177 = L_176;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_178 = (L_175)->GetAt(static_cast<il2cpp_array_size_t>(L_177));
		NullCheck(L_178);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_179 = L_178->___vertices_1;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_180 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_181 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_180);
		int32_t L_182 = V_3;
		NullCheck(L_181);
		int32_t L_183 = L_182;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_184 = (L_181)->GetAt(static_cast<il2cpp_array_size_t>(L_183));
		NullCheck(L_184);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_185 = L_184->___triangles_2;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_186 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_187 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_186);
		int32_t L_188 = V_3;
		NullCheck(L_187);
		int32_t L_189 = L_188;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_190 = (L_187)->GetAt(static_cast<il2cpp_array_size_t>(L_189));
		NullCheck(L_190);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_191 = L_190->___normals_5;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_192 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_193 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_192);
		int32_t L_194 = V_3;
		NullCheck(L_193);
		int32_t L_195 = L_194;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_196 = (L_193)->GetAt(static_cast<il2cpp_array_size_t>(L_195));
		NullCheck(L_196);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_197 = L_196->___uv_3;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B** L_198 = ___0__preMeshes;
		PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B* L_199 = *((PreMeshU5BU5D_tCBCEDF257A7FACEC56AEEF33D826668099ACCF0B**)L_198);
		int32_t L_200 = V_3;
		NullCheck(L_199);
		int32_t L_201 = L_200;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_202 = (L_199)->GetAt(static_cast<il2cpp_array_size_t>(L_201));
		NullCheck(L_202);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_203 = (&L_202->___tangents_6);
		TerrainToMeshConverter_GenerateTangents_mD98240D042EB200A19307E4F73FA748C98B5E4CA(L_179, L_185, L_191, L_197, L_203, NULL);
		int32_t L_204 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_204, 1));
	}

IL_0310:
	{
		int32_t L_205 = V_5;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_206 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_206);
		int32_t L_207 = L_206->___chunkCountVertical_2;
		if ((((int32_t)L_205) < ((int32_t)L_207)))
		{
			goto IL_005f;
		}
	}
	{
		int32_t L_208 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_208, 1));
	}

IL_0327:
	{
		int32_t L_209 = V_4;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_210 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_210);
		int32_t L_211 = L_210->___chunkCountHorizontal_1;
		if ((((int32_t)L_209) < ((int32_t)L_211)))
		{
			goto IL_0057;
		}
	}
	{
		return;
	}
}
// UnityEngine.Mesh VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrainMainChunks(VacuumShaders.TerrainToMesh.PreMesh&,System.Single,System.Single,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* TerrainToMeshConverter_GenerateTerrainMainChunks_mEC78207E0925FC5BAC882673CFD0FCD01AD25A44 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** ___0__preMesh, float ___1__chunkH_Width, float ___2__chunkH_StartOffset, float ___3__chunkV_Length, float ___4__chunkV_StartOffset, bool ___5__normalizeUV, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* V_1 = NULL;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_2 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_3 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_4 = NULL;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* V_9 = NULL;
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* V_10 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* V_11 = NULL;
	List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* V_12 = NULL;
	int32_t V_13 = 0;
	int32_t V_14 = 0;
	int32_t V_15 = 0;
	int32_t V_16 = 0;
	int32_t V_17 = 0;
	int32_t V_18 = 0;
	int32_t V_19 = 0;
	int32_t V_20 = 0;
	int32_t V_21 = 0;
	int32_t V_22 = 0;
	int32_t V_23 = 0;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_24 = NULL;
	int32_t V_25 = 0;
	int32_t V_26 = 0;
	int32_t V_27 = 0;
	int32_t V_28 = 0;
	int32_t V_29 = 0;
	int32_t V_30 = 0;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B46_0 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B46_1 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B45_0 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B45_1 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* G_B47_0 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B47_1 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B47_2 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_0 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_0);
		int32_t L_1 = L_0->___vertexCountVertical_4;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_2 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_2);
		int32_t L_3 = L_2->___vertexCountHorizontal_3;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_3, 1));
		int32_t L_4 = V_0;
		if ((((int32_t)L_4) >= ((int32_t)1)))
		{
			goto IL_0022;
		}
	}
	{
		V_0 = 1;
	}

IL_0022:
	{
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_5 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_6 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_5);
		NullCheck(L_6);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_7 = L_6->___vertices_1;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_8 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD(L_8, (RuntimeObject*)L_7, List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_RuntimeMethod_var);
		V_1 = L_8;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_9 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_9, List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		V_2 = L_9;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_10 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_11 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_10);
		NullCheck(L_11);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_12 = L_11->___triangles_2;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_13 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		NullCheck(L_13);
		List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C(L_13, (RuntimeObject*)L_12, List_1__ctor_mCC0E71080DE343C1A527526A1AC2DBEC355CEA6C_RuntimeMethod_var);
		V_2 = L_13;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_14 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_15 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_14);
		NullCheck(L_15);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_16 = L_15->___vertices_1;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_17 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		NullCheck(L_17);
		List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD(L_17, (RuntimeObject*)L_16, List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_RuntimeMethod_var);
		V_1 = L_17;
		V_3 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		V_4 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_18 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_18);
		int32_t L_19 = L_18->___vertexCountHorizontal_3;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_20 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_20);
		int32_t L_21 = L_20->___vertexCountVertical_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_22 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(2, L_19)), ((int32_t)il2cpp_codegen_multiply(2, L_21)))), 4)));
		V_3 = L_22;
		V_5 = 0;
		V_13 = 0;
		goto IL_008e;
	}

IL_007d:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_23 = V_3;
		int32_t L_24 = V_5;
		int32_t L_25 = L_24;
		V_5 = ((int32_t)il2cpp_codegen_add(L_25, 1));
		int32_t L_26 = V_13;
		NullCheck(L_23);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(L_25), (int32_t)L_26);
		int32_t L_27 = V_13;
		V_13 = ((int32_t)il2cpp_codegen_add(L_27, 1));
	}

IL_008e:
	{
		int32_t L_28 = V_13;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_29 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_29);
		int32_t L_30 = L_29->___vertexCountHorizontal_3;
		if ((((int32_t)L_28) < ((int32_t)((int32_t)il2cpp_codegen_add(L_30, 2)))))
		{
			goto IL_007d;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_31 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_31);
		int32_t L_32 = L_31->___vertexCountHorizontal_3;
		V_6 = ((int32_t)il2cpp_codegen_add(L_32, 1));
		V_14 = 0;
		goto IL_00e4;
	}

IL_00b1:
	{
		int32_t L_33 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_33, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_34 = V_3;
		int32_t L_35 = V_5;
		int32_t L_36 = L_35;
		V_5 = ((int32_t)il2cpp_codegen_add(L_36, 1));
		int32_t L_37 = V_6;
		NullCheck(L_34);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(L_36), (int32_t)L_37);
		int32_t L_38 = V_6;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_39 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_39);
		int32_t L_40 = L_39->___vertexCountHorizontal_3;
		V_6 = ((int32_t)il2cpp_codegen_add(L_38, ((int32_t)il2cpp_codegen_add(L_40, 1))));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_41 = V_3;
		int32_t L_42 = V_5;
		int32_t L_43 = L_42;
		V_5 = ((int32_t)il2cpp_codegen_add(L_43, 1));
		int32_t L_44 = V_6;
		NullCheck(L_41);
		(L_41)->SetAt(static_cast<il2cpp_array_size_t>(L_43), (int32_t)L_44);
		int32_t L_45 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_45, 1));
	}

IL_00e4:
	{
		int32_t L_46 = V_14;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_47 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_47);
		int32_t L_48 = L_47->___vertexCountVertical_4;
		if ((((int32_t)L_46) < ((int32_t)L_48)))
		{
			goto IL_00b1;
		}
	}
	{
		V_15 = 1;
		goto IL_010b;
	}

IL_00f7:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_49 = V_3;
		int32_t L_50 = V_5;
		int32_t L_51 = L_50;
		V_5 = ((int32_t)il2cpp_codegen_add(L_51, 1));
		int32_t L_52 = V_6;
		int32_t L_53 = V_15;
		NullCheck(L_49);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(L_51), (int32_t)((int32_t)il2cpp_codegen_add(L_52, L_53)));
		int32_t L_54 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_54, 1));
	}

IL_010b:
	{
		int32_t L_55 = V_15;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_56 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_56);
		int32_t L_57 = L_56->___vertexCountHorizontal_3;
		if ((((int32_t)L_55) < ((int32_t)((int32_t)il2cpp_codegen_add(L_57, 3)))))
		{
			goto IL_00f7;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_58 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_58);
		int32_t L_59 = L_58->___vertexCountHorizontal_3;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_60 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_60);
		int32_t L_61 = L_60->___vertexCountVertical_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_62 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(4, ((int32_t)il2cpp_codegen_subtract(L_59, 1)))), ((int32_t)il2cpp_codegen_multiply(4, ((int32_t)il2cpp_codegen_subtract(L_61, 1)))))), 8)));
		V_4 = L_62;
		V_5 = 0;
		V_6 = 0;
		V_16 = 0;
		goto IL_0174;
	}

IL_014c:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_63 = V_4;
		int32_t L_64 = V_5;
		int32_t L_65 = L_64;
		V_5 = ((int32_t)il2cpp_codegen_add(L_65, 1));
		int32_t L_66 = V_6;
		int32_t L_67 = L_66;
		V_6 = ((int32_t)il2cpp_codegen_add(L_67, 1));
		NullCheck(L_63);
		(L_63)->SetAt(static_cast<il2cpp_array_size_t>(L_65), (int32_t)L_67);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_68 = V_4;
		int32_t L_69 = V_5;
		int32_t L_70 = L_69;
		V_5 = ((int32_t)il2cpp_codegen_add(L_70, 1));
		int32_t L_71 = V_6;
		int32_t L_72 = L_71;
		V_6 = ((int32_t)il2cpp_codegen_add(L_72, 1));
		NullCheck(L_68);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(L_70), (int32_t)L_72);
		int32_t L_73 = V_16;
		V_16 = ((int32_t)il2cpp_codegen_add(L_73, 1));
	}

IL_0174:
	{
		int32_t L_74 = V_16;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_75 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_75);
		int32_t L_76 = L_75->___vertexCountHorizontal_3;
		if ((((int32_t)L_74) < ((int32_t)((int32_t)il2cpp_codegen_add(L_76, 1)))))
		{
			goto IL_014c;
		}
	}
	{
		V_17 = 0;
		goto IL_01e6;
	}

IL_0189:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_77 = V_4;
		int32_t L_78 = V_5;
		int32_t L_79 = L_78;
		V_5 = ((int32_t)il2cpp_codegen_add(L_79, 1));
		int32_t L_80 = V_6;
		int32_t L_81 = L_80;
		V_6 = ((int32_t)il2cpp_codegen_add(L_81, 1));
		NullCheck(L_77);
		(L_77)->SetAt(static_cast<il2cpp_array_size_t>(L_79), (int32_t)L_81);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_82 = V_4;
		int32_t L_83 = V_5;
		int32_t L_84 = L_83;
		V_5 = ((int32_t)il2cpp_codegen_add(L_84, 1));
		int32_t L_85 = V_6;
		int32_t L_86 = L_85;
		V_6 = ((int32_t)il2cpp_codegen_add(L_86, 1));
		NullCheck(L_82);
		(L_82)->SetAt(static_cast<il2cpp_array_size_t>(L_84), (int32_t)L_86);
		int32_t L_87 = V_6;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_88 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_88);
		int32_t L_89 = L_88->___vertexCountHorizontal_3;
		V_6 = ((int32_t)il2cpp_codegen_add(L_87, ((int32_t)il2cpp_codegen_multiply(2, ((int32_t)il2cpp_codegen_subtract(L_89, 1))))));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_90 = V_4;
		int32_t L_91 = V_5;
		int32_t L_92 = L_91;
		V_5 = ((int32_t)il2cpp_codegen_add(L_92, 1));
		int32_t L_93 = V_6;
		int32_t L_94 = L_93;
		V_6 = ((int32_t)il2cpp_codegen_add(L_94, 1));
		NullCheck(L_90);
		(L_90)->SetAt(static_cast<il2cpp_array_size_t>(L_92), (int32_t)L_94);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_95 = V_4;
		int32_t L_96 = V_5;
		int32_t L_97 = L_96;
		V_5 = ((int32_t)il2cpp_codegen_add(L_97, 1));
		int32_t L_98 = V_6;
		int32_t L_99 = L_98;
		V_6 = ((int32_t)il2cpp_codegen_add(L_99, 1));
		NullCheck(L_95);
		(L_95)->SetAt(static_cast<il2cpp_array_size_t>(L_97), (int32_t)L_99);
		int32_t L_100 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_100, 1));
	}

IL_01e6:
	{
		int32_t L_101 = V_17;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_102 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_102);
		int32_t L_103 = L_102->___vertexCountVertical_4;
		if ((((int32_t)L_101) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_103, 1)))))
		{
			goto IL_0189;
		}
	}
	{
		V_18 = 0;
		goto IL_0223;
	}

IL_01fb:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_104 = V_4;
		int32_t L_105 = V_5;
		int32_t L_106 = L_105;
		V_5 = ((int32_t)il2cpp_codegen_add(L_106, 1));
		int32_t L_107 = V_6;
		int32_t L_108 = L_107;
		V_6 = ((int32_t)il2cpp_codegen_add(L_108, 1));
		NullCheck(L_104);
		(L_104)->SetAt(static_cast<il2cpp_array_size_t>(L_106), (int32_t)L_108);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_109 = V_4;
		int32_t L_110 = V_5;
		int32_t L_111 = L_110;
		V_5 = ((int32_t)il2cpp_codegen_add(L_111, 1));
		int32_t L_112 = V_6;
		int32_t L_113 = L_112;
		V_6 = ((int32_t)il2cpp_codegen_add(L_113, 1));
		NullCheck(L_109);
		(L_109)->SetAt(static_cast<il2cpp_array_size_t>(L_111), (int32_t)L_113);
		int32_t L_114 = V_18;
		V_18 = ((int32_t)il2cpp_codegen_add(L_114, 1));
	}

IL_0223:
	{
		int32_t L_115 = V_18;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_116 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_116);
		int32_t L_117 = L_116->___vertexCountHorizontal_3;
		if ((((int32_t)L_115) < ((int32_t)((int32_t)il2cpp_codegen_add(L_117, 1)))))
		{
			goto IL_01fb;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_118 = V_4;
		NullCheck(L_118);
		V_19 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_118)->max_length)), 1));
		goto IL_026c;
	}

IL_023d:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_119 = V_4;
		int32_t L_120 = V_19;
		NullCheck(L_119);
		int32_t L_121 = L_120;
		int32_t L_122 = (L_119)->GetAt(static_cast<il2cpp_array_size_t>(L_121));
		V_20 = L_122;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_123 = V_2;
		int32_t L_124 = V_20;
		NullCheck(L_123);
		List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004(L_123, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_124, 3)), 2)), List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_125 = V_2;
		int32_t L_126 = V_20;
		NullCheck(L_125);
		List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004(L_125, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_126, 3)), 1)), List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_127 = V_2;
		int32_t L_128 = V_20;
		NullCheck(L_127);
		List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004(L_127, ((int32_t)il2cpp_codegen_multiply(L_128, 3)), List_1_RemoveAt_m76C4CDACF47BA529BAFADFC8D5E13DB9587F4004_RuntimeMethod_var);
		int32_t L_129 = V_19;
		V_19 = ((int32_t)il2cpp_codegen_subtract(L_129, 1));
	}

IL_026c:
	{
		int32_t L_130 = V_19;
		if ((((int32_t)L_130) >= ((int32_t)0)))
		{
			goto IL_023d;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_131 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_131);
		int32_t L_132 = L_131->___vertexCountHorizontal_3;
		V_7 = ((int32_t)il2cpp_codegen_add(L_132, 3));
		V_8 = (-1);
		V_21 = 0;
		goto IL_0354;
	}

IL_028a:
	{
		V_22 = 0;
		goto IL_0335;
	}

IL_0292:
	{
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_133 = V_2;
		V_24 = L_133;
		int32_t L_134 = V_8;
		int32_t L_135 = ((int32_t)il2cpp_codegen_add(L_134, 1));
		V_8 = L_135;
		V_25 = L_135;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_136 = V_24;
		int32_t L_137 = V_25;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_138 = V_24;
		int32_t L_139 = V_25;
		NullCheck(L_138);
		int32_t L_140;
		L_140 = List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D(L_138, L_139, List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		int32_t L_141 = V_7;
		NullCheck(L_136);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_136, L_137, ((int32_t)il2cpp_codegen_subtract(L_140, L_141)), List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_142 = V_2;
		int32_t L_143 = V_8;
		NullCheck(L_142);
		int32_t L_144;
		L_144 = List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D(L_142, L_143, List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		V_23 = L_144;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_145 = V_2;
		int32_t L_146 = V_8;
		int32_t L_147 = ((int32_t)il2cpp_codegen_add(L_146, 1));
		V_8 = L_147;
		int32_t L_148 = V_23;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_149 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_149);
		int32_t L_150 = L_149->___vertexCountHorizontal_3;
		NullCheck(L_145);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_145, L_147, ((int32_t)il2cpp_codegen_add(L_148, L_150)), List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_151 = V_2;
		int32_t L_152 = V_8;
		int32_t L_153 = ((int32_t)il2cpp_codegen_add(L_152, 1));
		V_8 = L_153;
		int32_t L_154 = V_23;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_155 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_155);
		int32_t L_156 = L_155->___vertexCountHorizontal_3;
		NullCheck(L_151);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_151, L_153, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_154, L_156)), 1)), List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_157 = V_2;
		int32_t L_158 = V_8;
		int32_t L_159 = ((int32_t)il2cpp_codegen_add(L_158, 1));
		V_8 = L_159;
		int32_t L_160 = V_23;
		NullCheck(L_157);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_157, L_159, ((int32_t)il2cpp_codegen_add(L_160, 1)), List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_161 = V_2;
		int32_t L_162 = V_8;
		int32_t L_163 = ((int32_t)il2cpp_codegen_add(L_162, 1));
		V_8 = L_163;
		int32_t L_164 = V_23;
		NullCheck(L_161);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_161, L_163, L_164, List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_165 = V_2;
		int32_t L_166 = V_8;
		int32_t L_167 = ((int32_t)il2cpp_codegen_add(L_166, 1));
		V_8 = L_167;
		int32_t L_168 = V_23;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_169 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_169);
		int32_t L_170 = L_169->___vertexCountHorizontal_3;
		NullCheck(L_165);
		List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587(L_165, L_167, ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_168, L_170)), 1)), List_1_set_Item_m95629806F31CF369D937590912E0B6A53FF7C587_RuntimeMethod_var);
		int32_t L_171 = V_22;
		V_22 = ((int32_t)il2cpp_codegen_add(L_171, 1));
	}

IL_0335:
	{
		int32_t L_172 = V_22;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_173 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_173);
		int32_t L_174 = L_173->___vertexCountHorizontal_3;
		if ((((int32_t)L_172) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_174, 1)))))
		{
			goto IL_0292;
		}
	}
	{
		int32_t L_175 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_175, 2));
		int32_t L_176 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_176, 1));
	}

IL_0354:
	{
		int32_t L_177 = V_21;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_178 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_178);
		int32_t L_179 = L_178->___vertexCountVertical_4;
		if ((((int32_t)L_177) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_179, 1)))))
		{
			goto IL_028a;
		}
	}
	{
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_180 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_181 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_180);
		NullCheck(L_181);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_182 = L_181->___uv_3;
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_183 = (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*)il2cpp_codegen_object_new(List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		NullCheck(L_183);
		List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC(L_183, (RuntimeObject*)L_182, List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_RuntimeMethod_var);
		V_9 = L_183;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_184 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_185 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_184);
		NullCheck(L_185);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_186 = L_185->___uv2_4;
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_187 = (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*)il2cpp_codegen_object_new(List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		NullCheck(L_187);
		List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC(L_187, (RuntimeObject*)L_186, List_1__ctor_m105596C2159C46B75E96D26ACEC0A5C1C1F5C5EC_RuntimeMethod_var);
		V_10 = L_187;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_188 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_189 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_188);
		NullCheck(L_189);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_190 = L_189->___normals_5;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_191 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		NullCheck(L_191);
		List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD(L_191, (RuntimeObject*)L_190, List_1__ctor_mC734A32FAD92BD7492907D4733032FD21348EECD_RuntimeMethod_var);
		V_11 = L_191;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_192 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_193 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_192);
		NullCheck(L_193);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_194 = L_193->___tangents_6;
		List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* L_195 = (List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317*)il2cpp_codegen_object_new(List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317_il2cpp_TypeInfo_var);
		NullCheck(L_195);
		List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C(L_195, (RuntimeObject*)L_194, List_1__ctor_mD9791AC84BFDD1E95ED483EF04752D321D7B3D5C_RuntimeMethod_var);
		V_12 = L_195;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_196 = V_3;
		NullCheck(L_196);
		V_26 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_196)->max_length)), 1));
		goto IL_03b8;
	}

IL_03a8:
	{
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_197 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_198 = V_3;
		int32_t L_199 = V_26;
		NullCheck(L_198);
		int32_t L_200 = L_199;
		int32_t L_201 = (L_198)->GetAt(static_cast<il2cpp_array_size_t>(L_200));
		NullCheck(L_197);
		List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679(L_197, L_201, List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_RuntimeMethod_var);
		int32_t L_202 = V_26;
		V_26 = ((int32_t)il2cpp_codegen_subtract(L_202, 1));
	}

IL_03b8:
	{
		int32_t L_203 = V_26;
		if ((((int32_t)L_203) >= ((int32_t)0)))
		{
			goto IL_03a8;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_204 = V_3;
		NullCheck(L_204);
		V_27 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_204)->max_length)), 1));
		goto IL_03d7;
	}

IL_03c6:
	{
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_205 = V_9;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_206 = V_3;
		int32_t L_207 = V_27;
		NullCheck(L_206);
		int32_t L_208 = L_207;
		int32_t L_209 = (L_206)->GetAt(static_cast<il2cpp_array_size_t>(L_208));
		NullCheck(L_205);
		List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991(L_205, L_209, List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_RuntimeMethod_var);
		int32_t L_210 = V_27;
		V_27 = ((int32_t)il2cpp_codegen_subtract(L_210, 1));
	}

IL_03d7:
	{
		int32_t L_211 = V_27;
		if ((((int32_t)L_211) >= ((int32_t)0)))
		{
			goto IL_03c6;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_212 = V_3;
		NullCheck(L_212);
		V_28 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_212)->max_length)), 1));
		goto IL_03f6;
	}

IL_03e5:
	{
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_213 = V_10;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_214 = V_3;
		int32_t L_215 = V_28;
		NullCheck(L_214);
		int32_t L_216 = L_215;
		int32_t L_217 = (L_214)->GetAt(static_cast<il2cpp_array_size_t>(L_216));
		NullCheck(L_213);
		List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991(L_213, L_217, List_1_RemoveAt_m60D3B14293FFCFAB03D463B1F88FBC8AB695C991_RuntimeMethod_var);
		int32_t L_218 = V_28;
		V_28 = ((int32_t)il2cpp_codegen_subtract(L_218, 1));
	}

IL_03f6:
	{
		int32_t L_219 = V_28;
		if ((((int32_t)L_219) >= ((int32_t)0)))
		{
			goto IL_03e5;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_220 = V_3;
		NullCheck(L_220);
		V_29 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_220)->max_length)), 1));
		goto IL_0415;
	}

IL_0404:
	{
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_221 = V_11;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_222 = V_3;
		int32_t L_223 = V_29;
		NullCheck(L_222);
		int32_t L_224 = L_223;
		int32_t L_225 = (L_222)->GetAt(static_cast<il2cpp_array_size_t>(L_224));
		NullCheck(L_221);
		List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679(L_221, L_225, List_1_RemoveAt_m482122FD05018D3A1F5EE75A17852A8F8A911679_RuntimeMethod_var);
		int32_t L_226 = V_29;
		V_29 = ((int32_t)il2cpp_codegen_subtract(L_226, 1));
	}

IL_0415:
	{
		int32_t L_227 = V_29;
		if ((((int32_t)L_227) >= ((int32_t)0)))
		{
			goto IL_0404;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_228 = V_3;
		NullCheck(L_228);
		V_30 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_228)->max_length)), 1));
		goto IL_0434;
	}

IL_0423:
	{
		List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* L_229 = V_12;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_230 = V_3;
		int32_t L_231 = V_30;
		NullCheck(L_230);
		int32_t L_232 = L_231;
		int32_t L_233 = (L_230)->GetAt(static_cast<il2cpp_array_size_t>(L_232));
		NullCheck(L_229);
		List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D(L_229, L_233, List_1_RemoveAt_mA6D665F94D3F7826F488DF40C349E9C597B2954D_RuntimeMethod_var);
		int32_t L_234 = V_30;
		V_30 = ((int32_t)il2cpp_codegen_subtract(L_234, 1));
	}

IL_0434:
	{
		int32_t L_235 = V_30;
		if ((((int32_t)L_235) >= ((int32_t)0)))
		{
			goto IL_0423;
		}
	}
	{
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_236 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_237 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_236);
		NullCheck(L_237);
		PreMesh_Clear_m03D6E67111D9BF088E63E1B9157C29518275DFF5(L_237, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_238 = (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*)il2cpp_codegen_object_new(Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		NullCheck(L_238);
		Mesh__ctor_m5A9AECEDDAFFD84811ED8928012BDE97A9CEBD00(L_238, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_239 = L_238;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03** L_240 = ___0__preMesh;
		PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* L_241 = *((PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03**)L_240);
		NullCheck(L_241);
		String_t* L_242 = L_241->___name_0;
		NullCheck(L_239);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_239, L_242, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_243 = L_239;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_244 = V_1;
		NullCheck(L_244);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_245;
		L_245 = List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3(L_244, List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var);
		NullCheck(L_243);
		Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C(L_243, L_245, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_246 = L_243;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_247 = V_2;
		NullCheck(L_247);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_248;
		L_248 = List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA(L_247, List_1_ToArray_m65479FB75A5FE539EA1A0D6681172717D23CEAAA_RuntimeMethod_var);
		NullCheck(L_246);
		Mesh_set_triangles_m124405320579A8D92711BB5A124644963A26F60B(L_246, L_248, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_249 = L_246;
		bool L_250 = ___5__normalizeUV;
		G_B45_0 = L_249;
		G_B45_1 = L_249;
		if (L_250)
		{
			G_B46_0 = L_249;
			G_B46_1 = L_249;
			goto IL_0478;
		}
	}
	{
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_251 = V_9;
		NullCheck(L_251);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_252;
		L_252 = List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5(L_251, List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_RuntimeMethod_var);
		G_B47_0 = L_252;
		G_B47_1 = G_B45_0;
		G_B47_2 = G_B45_1;
		goto IL_0484;
	}

IL_0478:
	{
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_253 = V_9;
		NullCheck(L_253);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_254;
		L_254 = List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5(L_253, List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_RuntimeMethod_var);
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_255;
		L_255 = TerrainToMeshConverter_NormalizeUV_m242122C8B24863869D87ED3C1D13A3EB0601CD78(L_254, NULL);
		G_B47_0 = L_255;
		G_B47_1 = G_B46_0;
		G_B47_2 = G_B46_1;
	}

IL_0484:
	{
		NullCheck(G_B47_1);
		Mesh_set_uv_m6ED9C50E0DA8166DD48AC40FD6C828B9AD2E9617(G_B47_1, G_B47_0, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_256 = G_B47_2;
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_257 = V_10;
		NullCheck(L_257);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_258;
		L_258 = List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5(L_257, List_1_ToArray_m9F2A058632994B7A2310424880C089F9DE5B1BA5_RuntimeMethod_var);
		NullCheck(L_256);
		Mesh_set_uv2_m37B442C04EBB029C0AD9545C54F95D9BDAD8E9B5(L_256, L_258, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_259 = L_256;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_260 = V_11;
		NullCheck(L_260);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_261;
		L_261 = List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3(L_260, List_1_ToArray_mF7A66D08104196EBAE0E29F0DD9BA140656EA5F3_RuntimeMethod_var);
		NullCheck(L_259);
		Mesh_set_normals_m85D73193C49211BE9FA135FF72D5749B16A4760B(L_259, L_261, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_262 = L_259;
		List_1_tF42FEB6C3B18B7E7C8F2DE1FEBA00D2491736317* L_263 = V_12;
		NullCheck(L_263);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_264;
		L_264 = List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5(L_263, List_1_ToArray_m65092E284FCFF79BD500F713ED24D6530A9B3CC5_RuntimeMethod_var);
		NullCheck(L_262);
		Mesh_set_tangents_mF547B7E4F9C70FB7CD6168139180A70AD306169B(L_262, L_264, NULL);
		return L_262;
	}
}
// UnityEngine.Mesh VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTerrain()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* TerrainToMeshConverter_GenerateTerrain_mA5AA623B54893CFD3735DFFF64C6032B525E0F20 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_8 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_9 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_10 = NULL;
	int32_t V_11 = 0;
	int32_t V_12 = 0;
	int32_t V_13 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_14 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_15 = NULL;
	int32_t V_16 = 0;
	int32_t V_17 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_18;
	memset((&V_18), 0, sizeof(V_18));
	int32_t V_19 = 0;
	int32_t V_20 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_0 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_0);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_1;
		L_1 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_0, NULL);
		V_0 = L_1;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_2 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_2);
		int32_t L_3 = L_2->___vertexCountVertical_4;
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_3, 1));
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_4 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_4);
		int32_t L_5 = L_4->___vertexCountHorizontal_3;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_5, 1));
		int32_t L_6 = V_1;
		if ((((int32_t)L_6) >= ((int32_t)1)))
		{
			goto IL_002b;
		}
	}
	{
		V_1 = 1;
	}

IL_002b:
	{
		int32_t L_7 = V_2;
		if ((((int32_t)L_7) >= ((int32_t)1)))
		{
			goto IL_0031;
		}
	}
	{
		V_2 = 1;
	}

IL_0031:
	{
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_8 = V_0;
		NullCheck(L_8);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_8, NULL);
		float L_10 = L_9.___x_2;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_11 = V_0;
		NullCheck(L_11);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		L_12 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_11, NULL);
		float L_13 = L_12.___z_4;
		V_3 = L_13;
		int32_t L_14 = V_2;
		V_4 = ((float)(L_10/((float)L_14)));
		float L_15 = V_3;
		int32_t L_16 = V_1;
		V_5 = ((float)(L_15/((float)L_16)));
		int32_t L_17 = V_1;
		V_6 = ((int32_t)il2cpp_codegen_add(L_17, 1));
		int32_t L_18 = V_2;
		V_7 = ((int32_t)il2cpp_codegen_add(L_18, 1));
		int32_t L_19 = V_7;
		int32_t L_20 = V_6;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_19, L_20)));
		V_8 = L_21;
		int32_t L_22 = V_1;
		int32_t L_23 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_22, L_23)), 2)), 3)));
		V_9 = L_24;
		int32_t L_25 = V_7;
		int32_t L_26 = V_6;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_27 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_25, L_26)));
		V_10 = L_27;
		V_11 = (-1);
		V_16 = 0;
		goto IL_0121;
	}

IL_008e:
	{
		V_17 = 0;
		goto IL_0112;
	}

IL_0093:
	{
		int32_t L_28 = V_17;
		float L_29 = V_4;
		int32_t L_30 = V_16;
		float L_31 = V_5;
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&V_18), ((float)il2cpp_codegen_multiply(((float)L_28), L_29)), (0.0f), ((float)il2cpp_codegen_multiply(((float)L_30), L_31)), NULL);
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_32 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = V_18;
		NullCheck(L_32);
		float L_34;
		L_34 = Terrain_SampleHeight_m460F9060BC4D5F05275391A6AC05570047EF3177(L_32, L_33, NULL);
		(&V_18)->___y_3 = L_34;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_35 = V_8;
		int32_t L_36 = V_11;
		int32_t L_37 = ((int32_t)il2cpp_codegen_add(L_36, 1));
		V_11 = L_37;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_38 = V_18;
		NullCheck(L_35);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(L_37), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_38);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_39 = V_10;
		int32_t L_40 = V_11;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41 = V_18;
		float L_42 = L_41.___x_2;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_43 = V_0;
		NullCheck(L_43);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44;
		L_44 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_43, NULL);
		float L_45 = L_44.___x_2;
		float L_46;
		L_46 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_42/L_45)), NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_47 = V_18;
		float L_48 = L_47.___z_4;
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_49 = V_0;
		NullCheck(L_49);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_50;
		L_50 = TerrainData_get_size_mCD3977F344B9DEBFF61DD537D03FEB9473838DA5(L_49, NULL);
		float L_51 = L_50.___z_4;
		float L_52;
		L_52 = Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline(((float)(L_48/L_51)), NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_53;
		memset((&L_53), 0, sizeof(L_53));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_53), L_46, L_52, /*hidden argument*/NULL);
		NullCheck(L_39);
		(L_39)->SetAt(static_cast<il2cpp_array_size_t>(L_40), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_53);
		int32_t L_54 = V_17;
		V_17 = ((int32_t)il2cpp_codegen_add(L_54, 1));
	}

IL_0112:
	{
		int32_t L_55 = V_17;
		int32_t L_56 = V_7;
		if ((((int32_t)L_55) < ((int32_t)L_56)))
		{
			goto IL_0093;
		}
	}
	{
		int32_t L_57 = V_16;
		V_16 = ((int32_t)il2cpp_codegen_add(L_57, 1));
	}

IL_0121:
	{
		int32_t L_58 = V_16;
		int32_t L_59 = V_6;
		if ((((int32_t)L_58) < ((int32_t)L_59)))
		{
			goto IL_008e;
		}
	}
	{
		V_12 = 0;
		V_13 = 0;
		V_11 = (-1);
		V_19 = 0;
		goto IL_01bf;
	}

IL_013b:
	{
		int32_t L_60 = V_19;
		int32_t L_61 = V_7;
		V_12 = ((int32_t)il2cpp_codegen_multiply(L_60, L_61));
		int32_t L_62 = V_13;
		int32_t L_63 = V_7;
		V_13 = ((int32_t)il2cpp_codegen_add(L_62, L_63));
		V_20 = 0;
		goto IL_01b4;
	}

IL_014e:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_64 = V_9;
		int32_t L_65 = V_11;
		int32_t L_66 = ((int32_t)il2cpp_codegen_add(L_65, 1));
		V_11 = L_66;
		int32_t L_67 = V_12;
		int32_t L_68 = V_20;
		NullCheck(L_64);
		(L_64)->SetAt(static_cast<il2cpp_array_size_t>(L_66), (int32_t)((int32_t)il2cpp_codegen_add(L_67, L_68)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_69 = V_9;
		int32_t L_70 = V_11;
		int32_t L_71 = ((int32_t)il2cpp_codegen_add(L_70, 1));
		V_11 = L_71;
		int32_t L_72 = V_13;
		int32_t L_73 = V_20;
		NullCheck(L_69);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(L_71), (int32_t)((int32_t)il2cpp_codegen_add(L_72, L_73)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_74 = V_9;
		int32_t L_75 = V_11;
		int32_t L_76 = ((int32_t)il2cpp_codegen_add(L_75, 1));
		V_11 = L_76;
		int32_t L_77 = V_13;
		int32_t L_78 = V_20;
		NullCheck(L_74);
		(L_74)->SetAt(static_cast<il2cpp_array_size_t>(L_76), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_77, L_78)), 1)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_79 = V_9;
		int32_t L_80 = V_11;
		int32_t L_81 = ((int32_t)il2cpp_codegen_add(L_80, 1));
		V_11 = L_81;
		int32_t L_82 = V_12;
		int32_t L_83 = V_20;
		NullCheck(L_79);
		(L_79)->SetAt(static_cast<il2cpp_array_size_t>(L_81), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_82, L_83)), 1)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_84 = V_9;
		int32_t L_85 = V_11;
		int32_t L_86 = ((int32_t)il2cpp_codegen_add(L_85, 1));
		V_11 = L_86;
		int32_t L_87 = V_12;
		int32_t L_88 = V_20;
		NullCheck(L_84);
		(L_84)->SetAt(static_cast<il2cpp_array_size_t>(L_86), (int32_t)((int32_t)il2cpp_codegen_add(L_87, L_88)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_89 = V_9;
		int32_t L_90 = V_11;
		int32_t L_91 = ((int32_t)il2cpp_codegen_add(L_90, 1));
		V_11 = L_91;
		int32_t L_92 = V_13;
		int32_t L_93 = V_20;
		NullCheck(L_89);
		(L_89)->SetAt(static_cast<il2cpp_array_size_t>(L_91), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_92, L_93)), 1)));
		int32_t L_94 = V_20;
		V_20 = ((int32_t)il2cpp_codegen_add(L_94, 1));
	}

IL_01b4:
	{
		int32_t L_95 = V_20;
		int32_t L_96 = V_2;
		if ((((int32_t)L_95) < ((int32_t)L_96)))
		{
			goto IL_014e;
		}
	}
	{
		int32_t L_97 = V_19;
		V_19 = ((int32_t)il2cpp_codegen_add(L_97, 1));
	}

IL_01bf:
	{
		int32_t L_98 = V_19;
		int32_t L_99 = V_1;
		if ((((int32_t)L_98) < ((int32_t)L_99)))
		{
			goto IL_013b;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_100 = (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*)il2cpp_codegen_object_new(Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		NullCheck(L_100);
		Mesh__ctor_m5A9AECEDDAFFD84811ED8928012BDE97A9CEBD00(L_100, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_101 = L_100;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		Terrain_t7F309492F67238DBFBC4566F47385B2A665CF667* L_102 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrain_0;
		NullCheck(L_102);
		TerrainData_t615A68EAC648066681875D47FC641496D12F2E24* L_103;
		L_103 = Terrain_get_terrainData_m3B6C1D89471A4E1C60FC19C168DB37A011B924FD(L_102, NULL);
		NullCheck(L_103);
		String_t* L_104;
		L_104 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_103, NULL);
		NullCheck(L_101);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_101, L_104, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_105 = L_101;
		NullCheck(L_105);
		Object_set_hideFlags_mACB8BFC903FB3B01BBD427753E791BF28B5E33D4(L_105, ((int32_t)61), NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_106 = L_105;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_107 = V_8;
		NullCheck(L_106);
		Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C(L_106, L_107, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_108 = L_106;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_109 = V_9;
		NullCheck(L_108);
		Mesh_set_triangles_m124405320579A8D92711BB5A124644963A26F60B(L_108, L_109, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_110 = L_108;
		NullCheck(L_110);
		Mesh_RecalculateBounds_mA9B293F57C6CD298AE2D2DB19061FC23B05AB90B(L_110, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_111 = L_110;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_112 = V_10;
		NullCheck(L_111);
		Mesh_set_uv_m6ED9C50E0DA8166DD48AC40FD6C828B9AD2E9617(L_111, L_112, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_113 = L_111;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_114 = V_10;
		NullCheck(L_113);
		Mesh_set_uv2_m37B442C04EBB029C0AD9545C54F95D9BDAD8E9B5(L_113, L_114, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_115 = L_113;
		NullCheck(L_115);
		Mesh_RecalculateNormals_m3AA2788914611444E030CA310E03E3CFE683902B(L_115, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_116 = L_115;
		NullCheck(L_116);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_117;
		L_117 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_116, NULL);
		V_14 = L_117;
		V_15 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)NULL;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_118 = V_8;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_119 = V_9;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_120 = V_14;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_121 = V_10;
		TerrainToMeshConverter_GenerateTangents_mD98240D042EB200A19307E4F73FA748C98B5E4CA(L_118, L_119, L_120, L_121, (&V_15), NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_122 = L_116;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_123 = V_15;
		NullCheck(L_122);
		Mesh_set_tangents_mF547B7E4F9C70FB7CD6168139180A70AD306169B(L_122, L_123, NULL);
		return L_122;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::AddSkirt(UnityEngine.Mesh)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_AddSkirt_mA461756B9E0B28EF818F961AF1D3D59D7915127E (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___0__sourceMesh, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_3 = NULL;
	int32_t V_4 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_5 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_6 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_7 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_8 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_9 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_10 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_11 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_12 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_13 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_14 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_15 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_16 = NULL;
	int32_t V_17 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_18 = NULL;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_19 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_20 = NULL;
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_21 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_22 = NULL;
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* V_23 = NULL;
	int32_t V_24 = 0;
	int32_t V_25 = 0;
	int32_t V_26 = 0;
	int32_t V_27 = 0;
	int32_t V_28 = 0;
	int32_t V_29 = 0;
	int32_t V_30 = 0;
	int32_t V_31 = 0;
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_0 = ___0__sourceMesh;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_000a;
		}
	}
	{
		return;
	}

IL_000a:
	{
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_2 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_2);
		int32_t L_3 = L_2->___vertexCountHorizontal_3;
		V_0 = L_3;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_4 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_4);
		int32_t L_5 = L_4->___vertexCountVertical_4;
		V_1 = L_5;
		int32_t L_6 = V_0;
		int32_t L_7 = V_1;
		V_2 = ((int32_t)il2cpp_codegen_multiply(2, ((int32_t)il2cpp_codegen_add(L_6, L_7))));
		int32_t L_8 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_9 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)L_8);
		V_3 = L_9;
		V_4 = 0;
		V_24 = 0;
		goto IL_0055;
	}

IL_0035:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_10 = V_3;
		int32_t L_11 = V_4;
		int32_t L_12 = V_24;
		NullCheck(L_10);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(L_11), (int32_t)L_12);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = V_3;
		int32_t L_14 = V_4;
		int32_t L_15 = V_0;
		int32_t L_16 = V_0;
		int32_t L_17 = V_1;
		int32_t L_18 = V_24;
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_14, L_15))), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_16, ((int32_t)il2cpp_codegen_subtract(L_17, 1)))), L_18)));
		int32_t L_19 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_19, 1));
		int32_t L_20 = V_24;
		V_24 = ((int32_t)il2cpp_codegen_add(L_20, 1));
	}

IL_0055:
	{
		int32_t L_21 = V_24;
		int32_t L_22 = V_0;
		if ((((int32_t)L_21) < ((int32_t)L_22)))
		{
			goto IL_0035;
		}
	}
	{
		int32_t L_23 = V_0;
		V_4 = ((int32_t)il2cpp_codegen_multiply(2, L_23));
		V_25 = 0;
		goto IL_0086;
	}

IL_0064:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = V_3;
		int32_t L_25 = V_4;
		int32_t L_26 = V_0;
		int32_t L_27 = V_25;
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(L_25), (int32_t)((int32_t)il2cpp_codegen_multiply(L_26, L_27)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_28 = V_3;
		int32_t L_29 = V_4;
		int32_t L_30 = V_1;
		int32_t L_31 = V_0;
		int32_t L_32 = V_25;
		NullCheck(L_28);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_29, L_30))), (int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_multiply(L_31, ((int32_t)il2cpp_codegen_add(L_32, 1)))), 1)));
		int32_t L_33 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_33, 1));
		int32_t L_34 = V_25;
		V_25 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_0086:
	{
		int32_t L_35 = V_25;
		int32_t L_36 = V_1;
		if ((((int32_t)L_35) < ((int32_t)L_36)))
		{
			goto IL_0064;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_37 = ___0__sourceMesh;
		NullCheck(L_37);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_38;
		L_38 = Mesh_get_vertices_mA3577F1B08EDDD54E26AEB3F8FFE4EC247D2ABB9(L_37, NULL);
		V_5 = L_38;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_39 = ___0__sourceMesh;
		NullCheck(L_39);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_40;
		L_40 = Mesh_get_triangles_m33E39B4A383CC613C760FA7E297AC417A433F24B(L_39, NULL);
		V_6 = L_40;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_41 = ___0__sourceMesh;
		NullCheck(L_41);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_42;
		L_42 = Mesh_get_uv_mA47805C48AB3493FF3727922C43E77880E73519F(L_41, NULL);
		V_7 = L_42;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_43 = ___0__sourceMesh;
		NullCheck(L_43);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_44;
		L_44 = Mesh_get_uv2_mBD25DD8C860E10A1D109C9622622D52571F56B6F(L_43, NULL);
		V_8 = L_44;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_45 = ___0__sourceMesh;
		NullCheck(L_45);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_46;
		L_46 = Mesh_get_normals_m2B6B159B799E6E235EA651FCAB2E18EE5B18ED62(L_45, NULL);
		V_9 = L_46;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_47 = ___0__sourceMesh;
		NullCheck(L_47);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_48;
		L_48 = Mesh_get_tangents_mEA6C7BF6A2B9A8BD0E9A62963E048F973878299E(L_47, NULL);
		V_10 = L_48;
		int32_t L_49 = V_2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_50 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_49);
		V_11 = L_50;
		int32_t L_51 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_52 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_51, 1)), 6)));
		V_12 = L_52;
		int32_t L_53 = V_2;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_54 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)L_53);
		V_13 = L_54;
		int32_t L_55 = V_2;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_56 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)L_55);
		V_14 = L_56;
		int32_t L_57 = V_2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_58 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_57);
		V_15 = L_58;
		int32_t L_59 = V_2;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_60 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)SZArrayNew(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var, (uint32_t)L_59);
		V_16 = L_60;
		V_26 = 0;
		goto IL_0172;
	}

IL_00f4:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_61 = V_3;
		int32_t L_62 = V_26;
		NullCheck(L_61);
		int32_t L_63 = L_62;
		int32_t L_64 = (L_61)->GetAt(static_cast<il2cpp_array_size_t>(L_63));
		V_27 = L_64;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_65 = V_11;
		int32_t L_66 = V_26;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_67 = V_5;
		int32_t L_68 = V_27;
		NullCheck(L_67);
		int32_t L_69 = L_68;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_70 = (L_67)->GetAt(static_cast<il2cpp_array_size_t>(L_69));
		NullCheck(L_65);
		(L_65)->SetAt(static_cast<il2cpp_array_size_t>(L_66), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_70);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_71 = V_11;
		int32_t L_72 = V_26;
		NullCheck(L_71);
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_73 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_73);
		float L_74 = L_73->___skirtGroundLevel_6;
		((L_71)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_72)))->___y_3 = L_74;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_75 = V_13;
		int32_t L_76 = V_26;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_77 = V_7;
		int32_t L_78 = V_27;
		NullCheck(L_77);
		int32_t L_79 = L_78;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_80 = (L_77)->GetAt(static_cast<il2cpp_array_size_t>(L_79));
		NullCheck(L_75);
		(L_75)->SetAt(static_cast<il2cpp_array_size_t>(L_76), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_80);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_81 = V_14;
		int32_t L_82 = V_26;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_83 = V_8;
		int32_t L_84 = V_27;
		NullCheck(L_83);
		int32_t L_85 = L_84;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_86 = (L_83)->GetAt(static_cast<il2cpp_array_size_t>(L_85));
		NullCheck(L_81);
		(L_81)->SetAt(static_cast<il2cpp_array_size_t>(L_82), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_86);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_87 = V_15;
		int32_t L_88 = V_26;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_89 = V_9;
		int32_t L_90 = V_27;
		NullCheck(L_89);
		int32_t L_91 = L_90;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_92 = (L_89)->GetAt(static_cast<il2cpp_array_size_t>(L_91));
		NullCheck(L_87);
		(L_87)->SetAt(static_cast<il2cpp_array_size_t>(L_88), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_92);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_93 = V_16;
		int32_t L_94 = V_26;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_95 = V_10;
		int32_t L_96 = V_27;
		NullCheck(L_95);
		int32_t L_97 = L_96;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_98 = (L_95)->GetAt(static_cast<il2cpp_array_size_t>(L_97));
		NullCheck(L_93);
		(L_93)->SetAt(static_cast<il2cpp_array_size_t>(L_94), (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3)L_98);
		int32_t L_99 = V_26;
		V_26 = ((int32_t)il2cpp_codegen_add(L_99, 1));
	}

IL_0172:
	{
		int32_t L_100 = V_26;
		int32_t L_101 = V_2;
		if ((((int32_t)L_100) < ((int32_t)L_101)))
		{
			goto IL_00f4;
		}
	}
	{
		V_17 = 0;
		V_28 = 0;
		goto IL_01f1;
	}

IL_0182:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_102 = V_12;
		int32_t L_103 = V_17;
		int32_t L_104 = L_103;
		V_17 = ((int32_t)il2cpp_codegen_add(L_104, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_105 = ___0__sourceMesh;
		NullCheck(L_105);
		int32_t L_106;
		L_106 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_105, NULL);
		int32_t L_107 = V_28;
		NullCheck(L_102);
		(L_102)->SetAt(static_cast<il2cpp_array_size_t>(L_104), (int32_t)((int32_t)il2cpp_codegen_add(L_106, L_107)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_108 = V_12;
		int32_t L_109 = V_17;
		int32_t L_110 = L_109;
		V_17 = ((int32_t)il2cpp_codegen_add(L_110, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_111 = V_3;
		int32_t L_112 = V_28;
		NullCheck(L_111);
		int32_t L_113 = L_112;
		int32_t L_114 = (L_111)->GetAt(static_cast<il2cpp_array_size_t>(L_113));
		NullCheck(L_108);
		(L_108)->SetAt(static_cast<il2cpp_array_size_t>(L_110), (int32_t)L_114);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_115 = V_12;
		int32_t L_116 = V_17;
		int32_t L_117 = L_116;
		V_17 = ((int32_t)il2cpp_codegen_add(L_117, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_118 = ___0__sourceMesh;
		NullCheck(L_118);
		int32_t L_119;
		L_119 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_118, NULL);
		int32_t L_120 = V_28;
		NullCheck(L_115);
		(L_115)->SetAt(static_cast<il2cpp_array_size_t>(L_117), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_119, 1)), L_120)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_121 = V_12;
		int32_t L_122 = V_17;
		int32_t L_123 = L_122;
		V_17 = ((int32_t)il2cpp_codegen_add(L_123, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_124 = V_3;
		int32_t L_125 = V_28;
		NullCheck(L_124);
		int32_t L_126 = ((int32_t)il2cpp_codegen_add(L_125, 1));
		int32_t L_127 = (L_124)->GetAt(static_cast<il2cpp_array_size_t>(L_126));
		NullCheck(L_121);
		(L_121)->SetAt(static_cast<il2cpp_array_size_t>(L_123), (int32_t)L_127);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_128 = V_12;
		int32_t L_129 = V_17;
		int32_t L_130 = L_129;
		V_17 = ((int32_t)il2cpp_codegen_add(L_130, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_131 = ___0__sourceMesh;
		NullCheck(L_131);
		int32_t L_132;
		L_132 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_131, NULL);
		int32_t L_133 = V_28;
		NullCheck(L_128);
		(L_128)->SetAt(static_cast<il2cpp_array_size_t>(L_130), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_132, 1)), L_133)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_134 = V_12;
		int32_t L_135 = V_17;
		int32_t L_136 = L_135;
		V_17 = ((int32_t)il2cpp_codegen_add(L_136, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_137 = V_3;
		int32_t L_138 = V_28;
		NullCheck(L_137);
		int32_t L_139 = L_138;
		int32_t L_140 = (L_137)->GetAt(static_cast<il2cpp_array_size_t>(L_139));
		NullCheck(L_134);
		(L_134)->SetAt(static_cast<il2cpp_array_size_t>(L_136), (int32_t)L_140);
		int32_t L_141 = V_28;
		V_28 = ((int32_t)il2cpp_codegen_add(L_141, 1));
	}

IL_01f1:
	{
		int32_t L_142 = V_28;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_143 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_143);
		int32_t L_144 = L_143->___vertexCountHorizontal_3;
		if ((((int32_t)L_142) < ((int32_t)((int32_t)il2cpp_codegen_subtract(L_144, 1)))))
		{
			goto IL_0182;
		}
	}
	{
		int32_t L_145 = V_0;
		V_29 = L_145;
		goto IL_0275;
	}

IL_0206:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_146 = V_12;
		int32_t L_147 = V_17;
		int32_t L_148 = L_147;
		V_17 = ((int32_t)il2cpp_codegen_add(L_148, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_149 = V_3;
		int32_t L_150 = V_29;
		NullCheck(L_149);
		int32_t L_151 = L_150;
		int32_t L_152 = (L_149)->GetAt(static_cast<il2cpp_array_size_t>(L_151));
		NullCheck(L_146);
		(L_146)->SetAt(static_cast<il2cpp_array_size_t>(L_148), (int32_t)L_152);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_153 = V_12;
		int32_t L_154 = V_17;
		int32_t L_155 = L_154;
		V_17 = ((int32_t)il2cpp_codegen_add(L_155, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_156 = ___0__sourceMesh;
		NullCheck(L_156);
		int32_t L_157;
		L_157 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_156, NULL);
		int32_t L_158 = V_29;
		NullCheck(L_153);
		(L_153)->SetAt(static_cast<il2cpp_array_size_t>(L_155), (int32_t)((int32_t)il2cpp_codegen_add(L_157, L_158)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_159 = V_12;
		int32_t L_160 = V_17;
		int32_t L_161 = L_160;
		V_17 = ((int32_t)il2cpp_codegen_add(L_161, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_162 = ___0__sourceMesh;
		NullCheck(L_162);
		int32_t L_163;
		L_163 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_162, NULL);
		int32_t L_164 = V_29;
		NullCheck(L_159);
		(L_159)->SetAt(static_cast<il2cpp_array_size_t>(L_161), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_163, 1)), L_164)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_165 = V_12;
		int32_t L_166 = V_17;
		int32_t L_167 = L_166;
		V_17 = ((int32_t)il2cpp_codegen_add(L_167, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_168 = ___0__sourceMesh;
		NullCheck(L_168);
		int32_t L_169;
		L_169 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_168, NULL);
		int32_t L_170 = V_29;
		NullCheck(L_165);
		(L_165)->SetAt(static_cast<il2cpp_array_size_t>(L_167), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_169, 1)), L_170)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_171 = V_12;
		int32_t L_172 = V_17;
		int32_t L_173 = L_172;
		V_17 = ((int32_t)il2cpp_codegen_add(L_173, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_174 = V_3;
		int32_t L_175 = V_29;
		NullCheck(L_174);
		int32_t L_176 = ((int32_t)il2cpp_codegen_add(L_175, 1));
		int32_t L_177 = (L_174)->GetAt(static_cast<il2cpp_array_size_t>(L_176));
		NullCheck(L_171);
		(L_171)->SetAt(static_cast<il2cpp_array_size_t>(L_173), (int32_t)L_177);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_178 = V_12;
		int32_t L_179 = V_17;
		int32_t L_180 = L_179;
		V_17 = ((int32_t)il2cpp_codegen_add(L_180, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_181 = V_3;
		int32_t L_182 = V_29;
		NullCheck(L_181);
		int32_t L_183 = L_182;
		int32_t L_184 = (L_181)->GetAt(static_cast<il2cpp_array_size_t>(L_183));
		NullCheck(L_178);
		(L_178)->SetAt(static_cast<il2cpp_array_size_t>(L_180), (int32_t)L_184);
		int32_t L_185 = V_29;
		V_29 = ((int32_t)il2cpp_codegen_add(L_185, 1));
	}

IL_0275:
	{
		int32_t L_186 = V_29;
		int32_t L_187 = V_0;
		if ((((int32_t)L_186) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_multiply(2, L_187)), 1)))))
		{
			goto IL_0206;
		}
	}
	{
		int32_t L_188 = V_0;
		V_30 = ((int32_t)il2cpp_codegen_multiply(2, L_188));
		goto IL_02f4;
	}

IL_0285:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_189 = V_12;
		int32_t L_190 = V_17;
		int32_t L_191 = L_190;
		V_17 = ((int32_t)il2cpp_codegen_add(L_191, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_192 = V_3;
		int32_t L_193 = V_30;
		NullCheck(L_192);
		int32_t L_194 = L_193;
		int32_t L_195 = (L_192)->GetAt(static_cast<il2cpp_array_size_t>(L_194));
		NullCheck(L_189);
		(L_189)->SetAt(static_cast<il2cpp_array_size_t>(L_191), (int32_t)L_195);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_196 = V_12;
		int32_t L_197 = V_17;
		int32_t L_198 = L_197;
		V_17 = ((int32_t)il2cpp_codegen_add(L_198, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_199 = ___0__sourceMesh;
		NullCheck(L_199);
		int32_t L_200;
		L_200 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_199, NULL);
		int32_t L_201 = V_30;
		NullCheck(L_196);
		(L_196)->SetAt(static_cast<il2cpp_array_size_t>(L_198), (int32_t)((int32_t)il2cpp_codegen_add(L_200, L_201)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_202 = V_12;
		int32_t L_203 = V_17;
		int32_t L_204 = L_203;
		V_17 = ((int32_t)il2cpp_codegen_add(L_204, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_205 = ___0__sourceMesh;
		NullCheck(L_205);
		int32_t L_206;
		L_206 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_205, NULL);
		int32_t L_207 = V_30;
		NullCheck(L_202);
		(L_202)->SetAt(static_cast<il2cpp_array_size_t>(L_204), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_206, 1)), L_207)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_208 = V_12;
		int32_t L_209 = V_17;
		int32_t L_210 = L_209;
		V_17 = ((int32_t)il2cpp_codegen_add(L_210, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_211 = ___0__sourceMesh;
		NullCheck(L_211);
		int32_t L_212;
		L_212 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_211, NULL);
		int32_t L_213 = V_30;
		NullCheck(L_208);
		(L_208)->SetAt(static_cast<il2cpp_array_size_t>(L_210), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_212, 1)), L_213)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_214 = V_12;
		int32_t L_215 = V_17;
		int32_t L_216 = L_215;
		V_17 = ((int32_t)il2cpp_codegen_add(L_216, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_217 = V_3;
		int32_t L_218 = V_30;
		NullCheck(L_217);
		int32_t L_219 = ((int32_t)il2cpp_codegen_add(L_218, 1));
		int32_t L_220 = (L_217)->GetAt(static_cast<il2cpp_array_size_t>(L_219));
		NullCheck(L_214);
		(L_214)->SetAt(static_cast<il2cpp_array_size_t>(L_216), (int32_t)L_220);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_221 = V_12;
		int32_t L_222 = V_17;
		int32_t L_223 = L_222;
		V_17 = ((int32_t)il2cpp_codegen_add(L_223, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_224 = V_3;
		int32_t L_225 = V_30;
		NullCheck(L_224);
		int32_t L_226 = L_225;
		int32_t L_227 = (L_224)->GetAt(static_cast<il2cpp_array_size_t>(L_226));
		NullCheck(L_221);
		(L_221)->SetAt(static_cast<il2cpp_array_size_t>(L_223), (int32_t)L_227);
		int32_t L_228 = V_30;
		V_30 = ((int32_t)il2cpp_codegen_add(L_228, 1));
	}

IL_02f4:
	{
		int32_t L_229 = V_30;
		int32_t L_230 = V_0;
		int32_t L_231 = V_1;
		if ((((int32_t)L_229) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(2, L_230)), L_231)), 1)))))
		{
			goto IL_0285;
		}
	}
	{
		int32_t L_232 = V_0;
		int32_t L_233 = V_1;
		V_31 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(2, L_232)), L_233));
		goto IL_0377;
	}

IL_0308:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_234 = V_12;
		int32_t L_235 = V_17;
		int32_t L_236 = L_235;
		V_17 = ((int32_t)il2cpp_codegen_add(L_236, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_237 = ___0__sourceMesh;
		NullCheck(L_237);
		int32_t L_238;
		L_238 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_237, NULL);
		int32_t L_239 = V_31;
		NullCheck(L_234);
		(L_234)->SetAt(static_cast<il2cpp_array_size_t>(L_236), (int32_t)((int32_t)il2cpp_codegen_add(L_238, L_239)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_240 = V_12;
		int32_t L_241 = V_17;
		int32_t L_242 = L_241;
		V_17 = ((int32_t)il2cpp_codegen_add(L_242, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_243 = V_3;
		int32_t L_244 = V_31;
		NullCheck(L_243);
		int32_t L_245 = L_244;
		int32_t L_246 = (L_243)->GetAt(static_cast<il2cpp_array_size_t>(L_245));
		NullCheck(L_240);
		(L_240)->SetAt(static_cast<il2cpp_array_size_t>(L_242), (int32_t)L_246);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_247 = V_12;
		int32_t L_248 = V_17;
		int32_t L_249 = L_248;
		V_17 = ((int32_t)il2cpp_codegen_add(L_249, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_250 = ___0__sourceMesh;
		NullCheck(L_250);
		int32_t L_251;
		L_251 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_250, NULL);
		int32_t L_252 = V_31;
		NullCheck(L_247);
		(L_247)->SetAt(static_cast<il2cpp_array_size_t>(L_249), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_251, 1)), L_252)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_253 = V_12;
		int32_t L_254 = V_17;
		int32_t L_255 = L_254;
		V_17 = ((int32_t)il2cpp_codegen_add(L_255, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_256 = V_3;
		int32_t L_257 = V_31;
		NullCheck(L_256);
		int32_t L_258 = ((int32_t)il2cpp_codegen_add(L_257, 1));
		int32_t L_259 = (L_256)->GetAt(static_cast<il2cpp_array_size_t>(L_258));
		NullCheck(L_253);
		(L_253)->SetAt(static_cast<il2cpp_array_size_t>(L_255), (int32_t)L_259);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_260 = V_12;
		int32_t L_261 = V_17;
		int32_t L_262 = L_261;
		V_17 = ((int32_t)il2cpp_codegen_add(L_262, 1));
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_263 = ___0__sourceMesh;
		NullCheck(L_263);
		int32_t L_264;
		L_264 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_263, NULL);
		int32_t L_265 = V_31;
		NullCheck(L_260);
		(L_260)->SetAt(static_cast<il2cpp_array_size_t>(L_262), (int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(L_264, 1)), L_265)));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_266 = V_12;
		int32_t L_267 = V_17;
		int32_t L_268 = L_267;
		V_17 = ((int32_t)il2cpp_codegen_add(L_268, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_269 = V_3;
		int32_t L_270 = V_31;
		NullCheck(L_269);
		int32_t L_271 = L_270;
		int32_t L_272 = (L_269)->GetAt(static_cast<il2cpp_array_size_t>(L_271));
		NullCheck(L_266);
		(L_266)->SetAt(static_cast<il2cpp_array_size_t>(L_268), (int32_t)L_272);
		int32_t L_273 = V_31;
		V_31 = ((int32_t)il2cpp_codegen_add(L_273, 1));
	}

IL_0377:
	{
		int32_t L_274 = V_31;
		int32_t L_275 = V_0;
		int32_t L_276 = V_1;
		if ((((int32_t)L_274) < ((int32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(2, L_275)), ((int32_t)il2cpp_codegen_multiply(2, L_276)))), 1)))))
		{
			goto IL_0308;
		}
	}
	{
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_277 = ___0__sourceMesh;
		NullCheck(L_277);
		int32_t L_278;
		L_278 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_277, NULL);
		int32_t L_279 = V_2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_280 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_278, L_279)));
		V_18 = L_280;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_281 = ___0__sourceMesh;
		NullCheck(L_281);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_282;
		L_282 = Mesh_get_triangles_m33E39B4A383CC613C760FA7E297AC417A433F24B(L_281, NULL);
		NullCheck(L_282);
		int32_t L_283 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_284 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(((int32_t)(((RuntimeArray*)L_282)->max_length)), ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_subtract(L_283, 1)), 6)))));
		V_19 = L_284;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_285 = ___0__sourceMesh;
		NullCheck(L_285);
		int32_t L_286;
		L_286 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_285, NULL);
		int32_t L_287 = V_2;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_288 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_286, L_287)));
		V_20 = L_288;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_289 = ___0__sourceMesh;
		NullCheck(L_289);
		int32_t L_290;
		L_290 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_289, NULL);
		int32_t L_291 = V_2;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_292 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_290, L_291)));
		V_21 = L_292;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_293 = ___0__sourceMesh;
		NullCheck(L_293);
		int32_t L_294;
		L_294 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_293, NULL);
		int32_t L_295 = V_2;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_296 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_294, L_295)));
		V_22 = L_296;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_297 = ___0__sourceMesh;
		NullCheck(L_297);
		int32_t L_298;
		L_298 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_297, NULL);
		int32_t L_299 = V_2;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_300 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)SZArrayNew(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_298, L_299)));
		V_23 = L_300;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_301 = V_5;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_302 = V_18;
		NullCheck((RuntimeArray*)L_301);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_301, (RuntimeArray*)L_302, 0, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_303 = V_11;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_304 = V_18;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_305 = ___0__sourceMesh;
		NullCheck(L_305);
		int32_t L_306;
		L_306 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_305, NULL);
		NullCheck((RuntimeArray*)L_303);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_303, (RuntimeArray*)L_304, L_306, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_307 = V_6;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_308 = V_19;
		NullCheck((RuntimeArray*)L_307);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_307, (RuntimeArray*)L_308, 0, NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_309 = V_12;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_310 = V_19;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_311 = ___0__sourceMesh;
		NullCheck(L_311);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_312;
		L_312 = Mesh_get_triangles_m33E39B4A383CC613C760FA7E297AC417A433F24B(L_311, NULL);
		NullCheck(L_312);
		NullCheck((RuntimeArray*)L_309);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_309, (RuntimeArray*)L_310, ((int32_t)(((RuntimeArray*)L_312)->max_length)), NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_313 = V_7;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_314 = V_20;
		NullCheck((RuntimeArray*)L_313);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_313, (RuntimeArray*)L_314, 0, NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_315 = V_13;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_316 = V_20;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_317 = ___0__sourceMesh;
		NullCheck(L_317);
		int32_t L_318;
		L_318 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_317, NULL);
		NullCheck((RuntimeArray*)L_315);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_315, (RuntimeArray*)L_316, L_318, NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_319 = V_8;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_320 = V_21;
		NullCheck((RuntimeArray*)L_319);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_319, (RuntimeArray*)L_320, 0, NULL);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_321 = V_14;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_322 = V_21;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_323 = ___0__sourceMesh;
		NullCheck(L_323);
		int32_t L_324;
		L_324 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_323, NULL);
		NullCheck((RuntimeArray*)L_321);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_321, (RuntimeArray*)L_322, L_324, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_325 = V_9;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_326 = V_22;
		NullCheck((RuntimeArray*)L_325);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_325, (RuntimeArray*)L_326, 0, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_327 = V_15;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_328 = V_22;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_329 = ___0__sourceMesh;
		NullCheck(L_329);
		int32_t L_330;
		L_330 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_329, NULL);
		NullCheck((RuntimeArray*)L_327);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_327, (RuntimeArray*)L_328, L_330, NULL);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_331 = V_10;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_332 = V_23;
		NullCheck((RuntimeArray*)L_331);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_331, (RuntimeArray*)L_332, 0, NULL);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_333 = V_16;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_334 = V_23;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_335 = ___0__sourceMesh;
		NullCheck(L_335);
		int32_t L_336;
		L_336 = Mesh_get_vertexCount_mB7BE0340AAF272933068D830C8E711FC8978E12C(L_335, NULL);
		NullCheck((RuntimeArray*)L_333);
		Array_CopyTo_mFD42E3443AB3B850ED6F19359698E242A08E1BAB((RuntimeArray*)L_333, (RuntimeArray*)L_334, L_336, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_337 = ___0__sourceMesh;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_338 = V_18;
		NullCheck(L_337);
		Mesh_set_vertices_m5BB814D89E9ACA00DBF19F7D8E22CB73AC73FE5C(L_337, L_338, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_339 = ___0__sourceMesh;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_340 = V_19;
		NullCheck(L_339);
		Mesh_set_triangles_m124405320579A8D92711BB5A124644963A26F60B(L_339, L_340, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_341 = ___0__sourceMesh;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_342 = V_20;
		NullCheck(L_341);
		Mesh_set_uv_m6ED9C50E0DA8166DD48AC40FD6C828B9AD2E9617(L_341, L_342, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_343 = ___0__sourceMesh;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_344 = V_21;
		NullCheck(L_343);
		Mesh_set_uv2_m37B442C04EBB029C0AD9545C54F95D9BDAD8E9B5(L_343, L_344, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_345 = ___0__sourceMesh;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_346 = V_22;
		NullCheck(L_345);
		Mesh_set_normals_m85D73193C49211BE9FA135FF72D5749B16A4760B(L_345, L_346, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_347 = ___0__sourceMesh;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_348 = V_23;
		NullCheck(L_347);
		Mesh_set_tangents_mF547B7E4F9C70FB7CD6168139180A70AD306169B(L_347, L_348, NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateNormals(UnityEngine.Vector3[],System.Int32[],UnityEngine.Vector3[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateNormals_m017762E446405F9EA0A0991C669950579514D0C8 (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1__trinagles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** ___2__normals, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m8B5DEF3F8F4F49003BB953399B6E84A6DC941AC6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mBE9255218FAB0B859E0DD1B944986BBC7F1C3A33_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_3;
	memset((&V_3), 0, sizeof(V_3));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_4;
	memset((&V_4), 0, sizeof(V_4));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_5;
	memset((&V_5), 0, sizeof(V_5));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_6;
	memset((&V_6), 0, sizeof(V_6));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_7;
	memset((&V_7), 0, sizeof(V_7));
	int32_t V_8 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	int32_t V_10 = 0;
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_0 = ___2__normals;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_1 = ___0__vertices;
		NullCheck(L_1);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_2 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)));
		*((RuntimeObject**)L_0) = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_0, (void*)(RuntimeObject*)L_2);
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_3 = (List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F*)il2cpp_codegen_object_new(List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		List_1__ctor_mBE9255218FAB0B859E0DD1B944986BBC7F1C3A33(L_3, List_1__ctor_mBE9255218FAB0B859E0DD1B944986BBC7F1C3A33_RuntimeMethod_var);
		V_0 = L_3;
		V_1 = 0;
		goto IL_0023;
	}

IL_0014:
	{
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_4 = V_0;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_5 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C(L_5, List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		NullCheck(L_4);
		List_1_Add_m8B5DEF3F8F4F49003BB953399B6E84A6DC941AC6_inline(L_4, L_5, List_1_Add_m8B5DEF3F8F4F49003BB953399B6E84A6DC941AC6_RuntimeMethod_var);
		int32_t L_6 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_6, 1));
	}

IL_0023:
	{
		int32_t L_7 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_8 = ___0__vertices;
		NullCheck(L_8);
		if ((((int32_t)L_7) < ((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length)))))
		{
			goto IL_0014;
		}
	}
	{
		V_2 = 0;
		goto IL_00ab;
	}

IL_002d:
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_9 = ___0__vertices;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_10 = ___1__trinagles;
		int32_t L_11 = V_2;
		NullCheck(L_10);
		int32_t L_12 = L_11;
		int32_t L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		NullCheck(L_9);
		int32_t L_14 = L_13;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_3 = L_15;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_16 = ___0__vertices;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_17 = ___1__trinagles;
		int32_t L_18 = V_2;
		NullCheck(L_17);
		int32_t L_19 = ((int32_t)il2cpp_codegen_add(L_18, 1));
		int32_t L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		NullCheck(L_16);
		int32_t L_21 = L_20;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		V_4 = L_22;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_23 = ___0__vertices;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = ___1__trinagles;
		int32_t L_25 = V_2;
		NullCheck(L_24);
		int32_t L_26 = ((int32_t)il2cpp_codegen_add(L_25, 2));
		int32_t L_27 = (L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_26));
		NullCheck(L_23);
		int32_t L_28 = L_27;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_29 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_30 = V_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_31 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32;
		L_32 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_30, L_31, NULL);
		V_5 = L_32;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_33 = V_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		L_34 = Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline(L_29, L_33, NULL);
		V_6 = L_34;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_35 = V_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_36 = V_6;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_37;
		L_37 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_35, L_36, NULL);
		V_7 = L_37;
		Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline((&V_7), NULL);
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_38 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_39 = ___1__trinagles;
		int32_t L_40 = V_2;
		NullCheck(L_39);
		int32_t L_41 = L_40;
		int32_t L_42 = (L_39)->GetAt(static_cast<il2cpp_array_size_t>(L_41));
		NullCheck(L_38);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_43;
		L_43 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_38, L_42, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44 = V_7;
		NullCheck(L_43);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_43, L_44, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_45 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_46 = ___1__trinagles;
		int32_t L_47 = V_2;
		NullCheck(L_46);
		int32_t L_48 = ((int32_t)il2cpp_codegen_add(L_47, 1));
		int32_t L_49 = (L_46)->GetAt(static_cast<il2cpp_array_size_t>(L_48));
		NullCheck(L_45);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_50;
		L_50 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_45, L_49, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51 = V_7;
		NullCheck(L_50);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_50, L_51, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_52 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_53 = ___1__trinagles;
		int32_t L_54 = V_2;
		NullCheck(L_53);
		int32_t L_55 = ((int32_t)il2cpp_codegen_add(L_54, 2));
		int32_t L_56 = (L_53)->GetAt(static_cast<il2cpp_array_size_t>(L_55));
		NullCheck(L_52);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_57;
		L_57 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_52, L_56, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_58 = V_7;
		NullCheck(L_57);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_57, L_58, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		int32_t L_59 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_59, 3));
	}

IL_00ab:
	{
		int32_t L_60 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_61 = ___1__trinagles;
		NullCheck(L_61);
		if ((((int32_t)L_60) < ((int32_t)((int32_t)(((RuntimeArray*)L_61)->max_length)))))
		{
			goto IL_002d;
		}
	}
	{
		V_8 = 0;
		goto IL_0118;
	}

IL_00b9:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_62;
		L_62 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		V_9 = L_62;
		V_10 = 0;
		goto IL_00e3;
	}

IL_00c5:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_63 = V_9;
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_64 = V_0;
		int32_t L_65 = V_8;
		NullCheck(L_64);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_66;
		L_66 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_64, L_65, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		int32_t L_67 = V_10;
		NullCheck(L_66);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_68;
		L_68 = List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810(L_66, L_67, List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_69;
		L_69 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_63, L_68, NULL);
		V_9 = L_69;
		int32_t L_70 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add(L_70, 1));
	}

IL_00e3:
	{
		int32_t L_71 = V_10;
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_72 = V_0;
		int32_t L_73 = V_8;
		NullCheck(L_72);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_74;
		L_74 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_72, L_73, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		NullCheck(L_74);
		int32_t L_75;
		L_75 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_74, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		if ((((int32_t)L_71) < ((int32_t)L_75)))
		{
			goto IL_00c5;
		}
	}
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C** L_76 = ___2__normals;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_77 = *((Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C**)L_76);
		int32_t L_78 = V_8;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_79 = V_9;
		List_1_tE5E2F520A1D08DC8DA6B8BF059CF6AE99CA46D0F* L_80 = V_0;
		int32_t L_81 = V_8;
		NullCheck(L_80);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_82;
		L_82 = List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075(L_80, L_81, List_1_get_Item_m4B238E04198FE52EB1D62E21BB6B0C8948740075_RuntimeMethod_var);
		NullCheck(L_82);
		int32_t L_83;
		L_83 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_82, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_84;
		L_84 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_79, ((float)L_83), NULL);
		NullCheck(L_77);
		(L_77)->SetAt(static_cast<il2cpp_array_size_t>(L_78), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_84);
		int32_t L_85 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_85, 1));
	}

IL_0118:
	{
		int32_t L_86 = V_8;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_87 = ___0__vertices;
		NullCheck(L_87);
		if ((((int32_t)L_86) < ((int32_t)((int32_t)(((RuntimeArray*)L_87)->max_length)))))
		{
			goto IL_00b9;
		}
	}
	{
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::GenerateTangents(UnityEngine.Vector3[],System.Int32[],UnityEngine.Vector3[],UnityEngine.Vector2[],UnityEngine.Vector4[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_GenerateTangents_mD98240D042EB200A19307E4F73FA748C98B5E4CA (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___0__vertices, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1__triangles, Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___2__normals, Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___3__texcoords, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** ___4__tangents, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_2 = NULL;
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_3 = NULL;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_9;
	memset((&V_9), 0, sizeof(V_9));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_10;
	memset((&V_10), 0, sizeof(V_10));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_11;
	memset((&V_11), 0, sizeof(V_11));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_12;
	memset((&V_12), 0, sizeof(V_12));
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_13;
	memset((&V_13), 0, sizeof(V_13));
	float V_14 = 0.0f;
	float V_15 = 0.0f;
	float V_16 = 0.0f;
	float V_17 = 0.0f;
	float V_18 = 0.0f;
	float V_19 = 0.0f;
	float V_20 = 0.0f;
	float V_21 = 0.0f;
	float V_22 = 0.0f;
	float V_23 = 0.0f;
	float V_24 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_25;
	memset((&V_25), 0, sizeof(V_25));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_26;
	memset((&V_26), 0, sizeof(V_26));
	int32_t V_27 = 0;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_28;
	memset((&V_28), 0, sizeof(V_28));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_29;
	memset((&V_29), 0, sizeof(V_29));
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* G_B8_0 = NULL;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* G_B7_0 = NULL;
	float G_B9_0 = 0.0f;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* G_B9_1 = NULL;
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_0 = ___0__vertices;
		NullCheck(L_0);
		V_0 = ((int32_t)(((RuntimeArray*)L_0)->max_length));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = ___1__triangles;
		NullCheck(L_1);
		V_1 = ((int32_t)(((int32_t)(((RuntimeArray*)L_1)->max_length))/3));
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_2 = ___4__tangents;
		int32_t L_3 = V_0;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_4 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)SZArrayNew(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD_il2cpp_TypeInfo_var, (uint32_t)L_3);
		*((RuntimeObject**)L_2) = (RuntimeObject*)L_4;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)L_4);
		int32_t L_5 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_5);
		V_2 = L_6;
		int32_t L_7 = V_0;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_8 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)SZArrayNew(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C_il2cpp_TypeInfo_var, (uint32_t)L_7);
		V_3 = L_8;
		V_4 = 0;
		V_5 = 0;
		goto IL_0258;
	}

IL_002c:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_9 = ___1__triangles;
		int32_t L_10 = V_4;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		int32_t L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		V_6 = L_12;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = ___1__triangles;
		int32_t L_14 = V_4;
		NullCheck(L_13);
		int32_t L_15 = ((int32_t)il2cpp_codegen_add(L_14, 1));
		int32_t L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		V_7 = L_16;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_17 = ___1__triangles;
		int32_t L_18 = V_4;
		NullCheck(L_17);
		int32_t L_19 = ((int32_t)il2cpp_codegen_add(L_18, 2));
		int32_t L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		V_8 = L_20;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_21 = ___0__vertices;
		int32_t L_22 = V_6;
		NullCheck(L_21);
		int32_t L_23 = L_22;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = (L_21)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
		V_9 = L_24;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_25 = ___0__vertices;
		int32_t L_26 = V_7;
		NullCheck(L_25);
		int32_t L_27 = L_26;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_28 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_29 = ___0__vertices;
		int32_t L_30 = V_8;
		NullCheck(L_29);
		int32_t L_31 = L_30;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
		V_10 = L_32;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_33 = ___3__texcoords;
		int32_t L_34 = V_6;
		NullCheck(L_33);
		int32_t L_35 = L_34;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_36 = (L_33)->GetAt(static_cast<il2cpp_array_size_t>(L_35));
		V_11 = L_36;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_37 = ___3__texcoords;
		int32_t L_38 = V_7;
		NullCheck(L_37);
		int32_t L_39 = L_38;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_40 = (L_37)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		V_12 = L_40;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_41 = ___3__texcoords;
		int32_t L_42 = V_8;
		NullCheck(L_41);
		int32_t L_43 = L_42;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_44 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_43));
		V_13 = L_44;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45 = L_28;
		float L_46 = L_45.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_47 = V_9;
		float L_48 = L_47.___x_2;
		V_14 = ((float)il2cpp_codegen_subtract(L_46, L_48));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_49 = V_10;
		float L_50 = L_49.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_51 = V_9;
		float L_52 = L_51.___x_2;
		V_15 = ((float)il2cpp_codegen_subtract(L_50, L_52));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_53 = L_45;
		float L_54 = L_53.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_55 = V_9;
		float L_56 = L_55.___y_3;
		V_16 = ((float)il2cpp_codegen_subtract(L_54, L_56));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_57 = V_10;
		float L_58 = L_57.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_59 = V_9;
		float L_60 = L_59.___y_3;
		V_17 = ((float)il2cpp_codegen_subtract(L_58, L_60));
		float L_61 = L_53.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_62 = V_9;
		float L_63 = L_62.___z_4;
		V_18 = ((float)il2cpp_codegen_subtract(L_61, L_63));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_64 = V_10;
		float L_65 = L_64.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_66 = V_9;
		float L_67 = L_66.___z_4;
		V_19 = ((float)il2cpp_codegen_subtract(L_65, L_67));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_68 = V_12;
		float L_69 = L_68.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_70 = V_11;
		float L_71 = L_70.___x_0;
		V_20 = ((float)il2cpp_codegen_subtract(L_69, L_71));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_72 = V_13;
		float L_73 = L_72.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_74 = V_11;
		float L_75 = L_74.___x_0;
		V_21 = ((float)il2cpp_codegen_subtract(L_73, L_75));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_76 = V_12;
		float L_77 = L_76.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_78 = V_11;
		float L_79 = L_78.___y_1;
		V_22 = ((float)il2cpp_codegen_subtract(L_77, L_79));
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_80 = V_13;
		float L_81 = L_80.___y_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_82 = V_11;
		float L_83 = L_82.___y_1;
		V_23 = ((float)il2cpp_codegen_subtract(L_81, L_83));
		V_24 = (9.99999975E-05f);
		float L_84 = V_20;
		float L_85 = V_23;
		float L_86 = V_21;
		float L_87 = V_22;
		if ((((float)((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_84, L_85)), ((float)il2cpp_codegen_multiply(L_86, L_87))))) == ((float)(0.0f))))
		{
			goto IL_014e;
		}
	}
	{
		float L_88 = V_20;
		float L_89 = V_23;
		float L_90 = V_21;
		float L_91 = V_22;
		V_24 = ((float)((1.0f)/((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_88, L_89)), ((float)il2cpp_codegen_multiply(L_90, L_91))))));
	}

IL_014e:
	{
		float L_92 = V_23;
		float L_93 = V_14;
		float L_94 = V_22;
		float L_95 = V_15;
		float L_96 = V_24;
		float L_97 = V_23;
		float L_98 = V_16;
		float L_99 = V_22;
		float L_100 = V_17;
		float L_101 = V_24;
		float L_102 = V_23;
		float L_103 = V_18;
		float L_104 = V_22;
		float L_105 = V_19;
		float L_106 = V_24;
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&V_25), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_92, L_93)), ((float)il2cpp_codegen_multiply(L_94, L_95)))), L_96)), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_97, L_98)), ((float)il2cpp_codegen_multiply(L_99, L_100)))), L_101)), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_102, L_103)), ((float)il2cpp_codegen_multiply(L_104, L_105)))), L_106)), NULL);
		float L_107 = V_20;
		float L_108 = V_15;
		float L_109 = V_21;
		float L_110 = V_14;
		float L_111 = V_24;
		float L_112 = V_20;
		float L_113 = V_17;
		float L_114 = V_21;
		float L_115 = V_16;
		float L_116 = V_24;
		float L_117 = V_20;
		float L_118 = V_19;
		float L_119 = V_21;
		float L_120 = V_18;
		float L_121 = V_24;
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&V_26), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_107, L_108)), ((float)il2cpp_codegen_multiply(L_109, L_110)))), L_111)), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_112, L_113)), ((float)il2cpp_codegen_multiply(L_114, L_115)))), L_116)), ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_117, L_118)), ((float)il2cpp_codegen_multiply(L_119, L_120)))), L_121)), NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_122 = V_2;
		int32_t L_123 = V_6;
		NullCheck(L_122);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_124 = ((L_122)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_123)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_125 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_124);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_126 = V_25;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_127;
		L_127 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_125, L_126, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_124 = L_127;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_128 = V_2;
		int32_t L_129 = V_7;
		NullCheck(L_128);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_130 = ((L_128)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_129)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_131 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_130);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_132 = V_25;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_133;
		L_133 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_131, L_132, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_130 = L_133;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_134 = V_2;
		int32_t L_135 = V_8;
		NullCheck(L_134);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_136 = ((L_134)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_135)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_137 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_136);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_138 = V_25;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_139;
		L_139 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_137, L_138, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_136 = L_139;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_140 = V_3;
		int32_t L_141 = V_6;
		NullCheck(L_140);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_142 = ((L_140)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_141)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_143 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_142);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_144 = V_26;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_145;
		L_145 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_143, L_144, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_142 = L_145;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_146 = V_3;
		int32_t L_147 = V_7;
		NullCheck(L_146);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_148 = ((L_146)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_147)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_149 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_148);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_150 = V_26;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_151;
		L_151 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_149, L_150, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_148 = L_151;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_152 = V_3;
		int32_t L_153 = V_8;
		NullCheck(L_152);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* L_154 = ((L_152)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_153)));
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_155 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_154);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_156 = V_26;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_157;
		L_157 = Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline(L_155, L_156, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)L_154 = L_157;
		int32_t L_158 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_158, 3));
		int32_t L_159 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_159, 1));
	}

IL_0258:
	{
		int32_t L_160 = V_5;
		int32_t L_161 = V_1;
		if ((((int32_t)L_160) < ((int32_t)L_161)))
		{
			goto IL_002c;
		}
	}
	{
		V_27 = 0;
		goto IL_0305;
	}

IL_0268:
	{
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_162 = ___2__normals;
		int32_t L_163 = V_27;
		NullCheck(L_162);
		int32_t L_164 = L_163;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_165 = (L_162)->GetAt(static_cast<il2cpp_array_size_t>(L_164));
		V_28 = L_165;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_166 = V_2;
		int32_t L_167 = V_27;
		NullCheck(L_166);
		int32_t L_168 = L_167;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_169 = (L_166)->GetAt(static_cast<il2cpp_array_size_t>(L_168));
		V_29 = L_169;
		Vector3_OrthoNormalize_m4450C7BEB70DBFA60E3AAC08C98CDAE831A54158((&V_28), (&V_29), NULL);
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_170 = ___4__tangents;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_171 = *((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD**)L_170);
		int32_t L_172 = V_27;
		NullCheck(L_171);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_173 = V_29;
		float L_174 = L_173.___x_2;
		((L_171)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_172)))->___x_1 = L_174;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_175 = ___4__tangents;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_176 = *((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD**)L_175);
		int32_t L_177 = V_27;
		NullCheck(L_176);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_178 = V_29;
		float L_179 = L_178.___y_3;
		((L_176)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_177)))->___y_2 = L_179;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_180 = ___4__tangents;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_181 = *((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD**)L_180);
		int32_t L_182 = V_27;
		NullCheck(L_181);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_183 = V_29;
		float L_184 = L_183.___z_4;
		((L_181)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_182)))->___z_3 = L_184;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD** L_185 = ___4__tangents;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_186 = *((Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD**)L_185);
		int32_t L_187 = V_27;
		NullCheck(L_186);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_188 = V_28;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_189 = V_29;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_190;
		L_190 = Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline(L_188, L_189, NULL);
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_191 = V_3;
		int32_t L_192 = V_27;
		NullCheck(L_191);
		int32_t L_193 = L_192;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_194 = (L_191)->GetAt(static_cast<il2cpp_array_size_t>(L_193));
		float L_195;
		L_195 = Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline(L_190, L_194, NULL);
		G_B7_0 = ((L_186)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_187)));
		if ((((float)L_195) < ((float)(0.0f))))
		{
			G_B8_0 = ((L_186)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_187)));
			goto IL_02f5;
		}
	}
	{
		G_B9_0 = (1.0f);
		G_B9_1 = G_B7_0;
		goto IL_02fa;
	}

IL_02f5:
	{
		G_B9_0 = (-1.0f);
		G_B9_1 = G_B8_0;
	}

IL_02fa:
	{
		G_B9_1->___w_4 = G_B9_0;
		int32_t L_196 = V_27;
		V_27 = ((int32_t)il2cpp_codegen_add(L_196, 1));
	}

IL_0305:
	{
		int32_t L_197 = V_27;
		int32_t L_198 = V_0;
		if ((((int32_t)L_197) < ((int32_t)L_198)))
		{
			goto IL_0268;
		}
	}
	{
		return;
	}
}
// System.Single VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Remap(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float TerrainToMeshConverter_Remap_m649C48A5904AE65F6E6646F62F4786D7AC1C01B3 (float ___0_value, float ___1_from1, float ___2_to1, float ___3_from2, float ___4_to2, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_value;
		float L_1 = ___1_from1;
		float L_2 = ___2_to1;
		float L_3 = ___1_from1;
		float L_4 = ___4_to2;
		float L_5 = ___3_from2;
		float L_6 = ___3_from2;
		return ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(((float)(((float)il2cpp_codegen_subtract(L_0, L_1))/((float)il2cpp_codegen_subtract(L_2, L_3)))), ((float)il2cpp_codegen_subtract(L_4, L_5)))), L_6));
	}
}
// UnityEngine.Vector2[] VacuumShaders.TerrainToMesh.TerrainToMeshConverter::NormalizeUV(UnityEngine.Vector2[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* TerrainToMeshConverter_NormalizeUV_m242122C8B24863869D87ED3C1D13A3EB0601CD78 (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___0__oldUVs, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_0 = ___0__oldUVs;
		NullCheck(L_0);
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_1 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)SZArrayNew(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)));
		V_0 = L_1;
		V_1 = 0;
		V_2 = 0;
		goto IL_0058;
	}

IL_000f:
	{
		V_3 = 0;
		goto IL_0047;
	}

IL_0013:
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_2 = V_0;
		int32_t L_3 = V_1;
		int32_t L_4 = V_3;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_5 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_5);
		int32_t L_6 = L_5->___vertexCountHorizontal_3;
		int32_t L_7 = V_2;
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_8 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_8);
		int32_t L_9 = L_8->___vertexCountVertical_4;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_10;
		memset((&L_10), 0, sizeof(L_10));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_10), ((float)(((float)L_4)/((float)((int32_t)il2cpp_codegen_subtract(L_6, 1))))), ((float)(((float)L_7)/((float)((int32_t)il2cpp_codegen_subtract(L_9, 1))))), /*hidden argument*/NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_10);
		int32_t L_11 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_11, 1));
		int32_t L_12 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_0047:
	{
		int32_t L_13 = V_3;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_14 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_14);
		int32_t L_15 = L_14->___vertexCountHorizontal_3;
		if ((((int32_t)L_13) < ((int32_t)L_15)))
		{
			goto IL_0013;
		}
	}
	{
		int32_t L_16 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_0058:
	{
		int32_t L_17 = V_2;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainConvertInfo_t205298D6F3957231732D02544854F550B77E8F2D* L_18 = ((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___terrainConvertInfo_1;
		NullCheck(L_18);
		int32_t L_19 = L_18->___vertexCountVertical_4;
		if ((((int32_t)L_17) < ((int32_t)L_19)))
		{
			goto IL_000f;
		}
	}
	{
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_20 = V_0;
		return L_20;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::ResizePro(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.Texture2D&,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_ResizePro_mEF356558D6D46C1A23BF1E6724D38CFC3896330A (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_texture, int32_t ___1_width, int32_t ___2_height, Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___3_dstTexture, bool ___4_sRGB, bool ___5_hasMipMap, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* V_0 = NULL;
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* V_1 = NULL;
	RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* G_B9_0 = NULL;
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = ___0_texture;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_2 = ___3_dstTexture;
		*((RuntimeObject**)L_2) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)NULL);
		return;
	}

IL_000d:
	{
		int32_t L_3 = ___1_width;
		if ((((int32_t)L_3) >= ((int32_t)4)))
		{
			goto IL_0014;
		}
	}
	{
		___1_width = 4;
	}

IL_0014:
	{
		int32_t L_4 = ___2_height;
		if ((((int32_t)L_4) >= ((int32_t)4)))
		{
			goto IL_001b;
		}
	}
	{
		___2_height = 4;
	}

IL_001b:
	{
		int32_t L_5 = ___1_width;
		int32_t L_6 = ___2_height;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_7;
		L_7 = RenderTexture_GetTemporary_m82379FD4C767A36F0677CAF4E68319EAE16ADF7F(L_5, L_6, NULL);
		V_0 = L_7;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_8 = V_0;
		NullCheck(L_8);
		bool L_9;
		L_9 = RenderTexture_Create_mA6E4D3CCC84AC3F68E85AA0D6609E1692C672AD2(L_8, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_10;
		L_10 = RenderTexture_get_active_mA4434B3E79DEF2C01CAE0A53061598B16443C9E7(NULL);
		V_1 = L_10;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_11 = V_0;
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB(L_11, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_12 = V_0;
		NullCheck(L_12);
		RenderTexture_DiscardContents_m6C446FB1B7B57334FAD8847DB03E983975F38B32(L_12, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_13 = ___0_texture;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_14 = V_0;
		bool L_15 = ___4_sRGB;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8(L_13, L_14, L_15, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_16 = ___3_dstTexture;
		int32_t L_17 = ___1_width;
		int32_t L_18 = ___2_height;
		bool L_19 = ___5_hasMipMap;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_20 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_20);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_20, L_17, L_18, 5, L_19, NULL);
		*((RuntimeObject**)L_16) = (RuntimeObject*)L_20;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_16, (void*)(RuntimeObject*)L_20);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_21 = ___3_dstTexture;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_22 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_21);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = ___0_texture;
		NullCheck(L_23);
		String_t* L_24;
		L_24 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(L_23, NULL);
		NullCheck(L_22);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_22, L_24, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_25 = ___3_dstTexture;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_26 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_25);
		NullCheck(L_26);
		Texture_set_filterMode_mE423E58C0C16D059EA62BA87AD70F44AEA50CCC9(L_26, 1, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_27 = ___3_dstTexture;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_28 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_27);
		int32_t L_29 = ___1_width;
		int32_t L_30 = ___2_height;
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_31;
		memset((&L_31), 0, sizeof(L_31));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_31), (0.0f), (0.0f), ((float)L_29), ((float)L_30), /*hidden argument*/NULL);
		NullCheck(L_28);
		Texture2D_ReadPixels_m6B45DF7C051BF599C72ED09691F21A6C769EEBD9(L_28, L_31, 0, 0, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_32 = ___3_dstTexture;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_33 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_32);
		NullCheck(L_33);
		Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_33, NULL);
		bool L_34;
		L_34 = Application_get_isPlaying_m25B0ABDFEF54F5370CD3F263A813540843D00F34(NULL);
		if (L_34)
		{
			goto IL_0093;
		}
	}
	{
		G_B9_0 = ((RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27*)(NULL));
		goto IL_0094;
	}

IL_0093:
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_35 = V_1;
		G_B9_0 = L_35;
	}

IL_0094:
	{
		RenderTexture_set_active_m5EE8E2327EF9B306C1425014CC34C41A8384E7AB(G_B9_0, NULL);
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_36 = V_0;
		RenderTexture_ReleaseTemporary_mEEF2C1990196FF06FDD0DC190928AD3A023EBDD2(L_36, NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_Blit_m8C231D93935473B183D412FAD4C44432333B7FE8 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, bool ___2_sRGB, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* L_0 = ___0_source;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_1 = ___1_dest;
		bool L_2 = ___2_sRGB;
		il2cpp_codegen_runtime_class_init_inline(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		TerrainToMeshConverter_Blit_mEEE3B1AA11BD74C6FF6809D63CAA6DFA4FC60560(L_0, L_1, (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*)NULL, L_2, (-1), NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,UnityEngine.Material,System.Boolean,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter_Blit_mEEE3B1AA11BD74C6FF6809D63CAA6DFA4FC60560 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___0_source, RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___1_dest, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___2_mat, bool ___3_sRGB, int32_t ___4_pass, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Graphics_t99CD970FFEA58171C70F54DF0C06D315BD452F2C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = ___3_sRGB;
		GL_set_sRGBWrite_m28E2276D0879B7BAD039B14B10E470D312CDE0C8(L_0, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_1 = ___2_mat;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_1, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* L_3 = ___0_source;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_4 = ___1_dest;
		il2cpp_codegen_runtime_class_init_inline(Graphics_t99CD970FFEA58171C70F54DF0C06D315BD452F2C_il2cpp_TypeInfo_var);
		Graphics_Blit_m8D99E16B74C7D3C8F79F4F142C59DB6B38114504(L_3, L_4, NULL);
		return;
	}

IL_0017:
	{
		Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* L_5 = ___0_source;
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_6 = ___1_dest;
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_7 = ___2_mat;
		int32_t L_8 = ___4_pass;
		il2cpp_codegen_runtime_class_init_inline(Graphics_t99CD970FFEA58171C70F54DF0C06D315BD452F2C_il2cpp_TypeInfo_var);
		Graphics_Blit_m1875691D6AAA8CF8EDE8508538714CF895E36779(L_5, L_6, L_7, L_8, NULL);
		return;
	}
}
// UnityEngine.RenderTexture VacuumShaders.TerrainToMesh.TerrainToMeshConverter::CreateRenderTexture(System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* TerrainToMeshConverter_CreateRenderTexture_mF67E567971FDE9A61183C1F94E8F0232E741D4B4 (int32_t ___0_width, int32_t ___1_height, bool ___2_sRGB, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t G_B2_0 = 0;
	int32_t G_B2_1 = 0;
	int32_t G_B2_2 = 0;
	int32_t G_B2_3 = 0;
	int32_t G_B1_0 = 0;
	int32_t G_B1_1 = 0;
	int32_t G_B1_2 = 0;
	int32_t G_B1_3 = 0;
	int32_t G_B3_0 = 0;
	int32_t G_B3_1 = 0;
	int32_t G_B3_2 = 0;
	int32_t G_B3_3 = 0;
	int32_t G_B3_4 = 0;
	{
		int32_t L_0 = ___0_width;
		int32_t L_1 = ___1_height;
		bool L_2 = ___2_sRGB;
		G_B1_0 = 0;
		G_B1_1 = ((int32_t)24);
		G_B1_2 = L_1;
		G_B1_3 = L_0;
		if (L_2)
		{
			G_B2_0 = 0;
			G_B2_1 = ((int32_t)24);
			G_B2_2 = L_1;
			G_B2_3 = L_0;
			goto IL_000b;
		}
	}
	{
		G_B3_0 = 0;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		G_B3_4 = G_B1_3;
		goto IL_000c;
	}

IL_000b:
	{
		G_B3_0 = 2;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
		G_B3_4 = G_B2_3;
	}

IL_000c:
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_3 = (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27*)il2cpp_codegen_object_new(RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		RenderTexture__ctor_m68A1B9CAA1BE0B597C5F4895C296E21502D0C962(L_3, G_B3_4, G_B3_3, G_B3_2, G_B3_1, G_B3_0, NULL);
		return L_3;
	}
}
// UnityEngine.RenderTexture VacuumShaders.TerrainToMesh.TerrainToMeshConverter::CreateTemporaryRenderTexture(System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* TerrainToMeshConverter_CreateTemporaryRenderTexture_m5BB9F7749A35A375504B1C5222AB2707B4875FC1 (int32_t ___0_width, int32_t ___1_height, bool ___2_sRGB, const RuntimeMethod* method) 
{
	int32_t G_B2_0 = 0;
	int32_t G_B2_1 = 0;
	int32_t G_B2_2 = 0;
	int32_t G_B2_3 = 0;
	int32_t G_B1_0 = 0;
	int32_t G_B1_1 = 0;
	int32_t G_B1_2 = 0;
	int32_t G_B1_3 = 0;
	int32_t G_B3_0 = 0;
	int32_t G_B3_1 = 0;
	int32_t G_B3_2 = 0;
	int32_t G_B3_3 = 0;
	int32_t G_B3_4 = 0;
	{
		int32_t L_0 = ___0_width;
		int32_t L_1 = ___1_height;
		bool L_2 = ___2_sRGB;
		G_B1_0 = 0;
		G_B1_1 = ((int32_t)24);
		G_B1_2 = L_1;
		G_B1_3 = L_0;
		if (L_2)
		{
			G_B2_0 = 0;
			G_B2_1 = ((int32_t)24);
			G_B2_2 = L_1;
			G_B2_3 = L_0;
			goto IL_000b;
		}
	}
	{
		G_B3_0 = 0;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		G_B3_4 = G_B1_3;
		goto IL_000c;
	}

IL_000b:
	{
		G_B3_0 = 2;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
		G_B3_4 = G_B2_3;
	}

IL_000c:
	{
		RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* L_3;
		L_3 = RenderTexture_GetTemporary_mA6619EA324AAE80B6892107C6968092F6F1B4C45(G_B3_4, G_B3_3, G_B3_2, G_B3_1, G_B3_0, NULL);
		return L_3;
	}
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TerrainToMeshConverter__cctor_mD5C4791919EB9CF6638D9B7F402E4B8A8481F1A4 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplit_3 = (bool)0;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_0;
		memset((&L_0), 0, sizeof(L_0));
		Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline((&L_0), (1.0f), (1.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_StaticFields*)il2cpp_codegen_static_fields_for(TerrainToMeshConverter_tCE4625145D8A21FA418CC6807FBCD1604211D38E_il2cpp_TypeInfo_var))->___basemapSplitOffsetScale_4 = L_0;
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_Multicast(ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* currentDelegate = reinterpret_cast<ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, float, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___0__name, ___1__value, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenInst(ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	NullCheck(___0__name);
	typedef void (*FunctionPointerType) (String_t*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___0__name, ___1__value, method);
}
void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenStatic(ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (String_t*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___0__name, ___1__value, method);
}
void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenStaticInvoker(ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	InvokerActionInvoker2< String_t*, float >::Invoke(__this->___method_ptr_0, method, NULL, ___0__name, ___1__value);
}
void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_ClosedStaticInvoker(ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	InvokerActionInvoker3< RuntimeObject*, String_t*, float >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___0__name, ___1__value);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*, float);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Marshaling of parameter '___0__name' to native representation
	char* ____0__name_marshaled = NULL;
	____0__name_marshaled = il2cpp_codegen_marshal_string(___0__name);

	// Native function invocation
	il2cppPInvokeFunc(____0__name_marshaled, ___1__value);

	// Marshaling cleanup of parameter '___0__name' native representation
	il2cpp_codegen_marshal_free(____0__name_marshaled);
	____0__name_marshaled = NULL;

}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProgressFunction__ctor_m7106DDB7413E7080176769A3FFB476B0804BEA74 (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___1_method);
	__this->___method_3 = ___1_method;
	__this->___m_target_2 = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___1_method))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl_1 = (intptr_t)&ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
			__this->___method_code_6 = (intptr_t)__this->___m_target_2;
		}
	}
	__this->___extra_arg_5 = (intptr_t)&ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_Multicast;
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction::Invoke(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0__name, ___1__value, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction::BeginInvoke(System.String,System.Single,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ProgressFunction_BeginInvoke_mF697BD9CE61876DDA6D7B16D26951806C12E9891 (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___2_callback, RuntimeObject* ___3_object, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = ___0__name;
	__d_args[1] = Box(Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_il2cpp_TypeInfo_var, &___1__value);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___2_callback, (RuntimeObject*)___3_object);
}
// System.Void VacuumShaders.TerrainToMesh.TerrainToMeshConverter/ProgressFunction::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProgressFunction_EndInvoke_m3896432F5E4DAC96BBA07CF2FA599EC6D53B50D7 (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, RuntimeObject* ___0_result, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void VacuumShaders.TerrainToMesh.PreMesh::Clear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PreMesh_Clear_m03D6E67111D9BF088E63E1B9157C29518275DFF5 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* __this, const RuntimeMethod* method) 
{
	{
		__this->___vertices_1 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___vertices_1), (void*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL);
		__this->___triangles_2 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___triangles_2), (void*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)NULL);
		__this->___uv_3 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___uv_3), (void*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)NULL);
		__this->___uv2_4 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___uv2_4), (void*)(Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)NULL);
		__this->___normals_5 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___normals_5), (void*)(Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)NULL);
		__this->___tangents_6 = (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___tangents_6), (void*)(Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*)NULL);
		return;
	}
}
// System.Void VacuumShaders.TerrainToMesh.PreMesh::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PreMesh__ctor_mCFC51B5015A64C2EFC55D3EB7A09645F8A2DE0B6 (PreMesh_t21954FBD01F5249B70A027AD5F64A590C07F1D03* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		__this->___name_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___name_0), (void*)L_0);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Quaternion_get_identity_m7E701AE095ED10FD5EA0B50ABCFDE2EEFF2173A5_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_0 = ((Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields*)il2cpp_codegen_static_fields_for(Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_il2cpp_TypeInfo_var))->___identityQuaternion_4;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_one_mC9B289F1E15C42C597180C9FE6FB492495B51D02_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___oneVector_6;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProgressFunction_Invoke_m7C8BCE16C75DA8E6142CB0839D3CF15ED0242CFB_inline (ProgressFunction_t5DA5A24E1DCA4C58179A16673D5B425D7E65D0DF* __this, String_t* ___0__name, float ___1__value, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0__name, ___1__value, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector4__ctor_m96B2CD8B862B271F513AF0BDC2EABD58E4DBC813_inline (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* __this, float ___0_x, float ___1_y, float ___2_z, float ___3_w, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_1 = L_0;
		float L_1 = ___1_y;
		__this->___y_2 = L_1;
		float L_2 = ___2_z;
		__this->___z_3 = L_2;
		float L_3 = ___3_w;
		__this->___w_4 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_clear_m02E023A7D396B973288B3915F6F24FBF7E0DC81D_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (0.0f), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 Vector4_get_zero_m3D61F5FA9483CD9C08977D9D8852FB448B4CE6D1_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_0 = ((Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_r;
		__this->___r_0 = L_0;
		float L_1 = ___1_g;
		__this->___g_1 = L_1;
		float L_2 = ___2_b;
		__this->___b_2 = L_2;
		float L_3 = ___3_a;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_one_m9097EB8DC23C26118A591AF16702796C3EF51DFB_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___oneVector_3;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m32506C40EC2EE7D5D4410BF40D3EE683A3D5F32C_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___zeroVector_2;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___0_x, float ___1_y, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_0 = L_0;
		float L_1 = ___1_y;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_up_m128AF3FDC820BF59D5DE86D973E7DE3F20C3AEBA_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___upVector_7;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___0_x, float ___1_y, float ___2_z, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_x;
		__this->___x_2 = L_0;
		float L_1 = ___1_y;
		__this->___y_3 = L_1;
		float L_2 = ___2_z;
		__this->___z_4 = L_2;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Mathf_Clamp01_mA7E048DBDA832D399A581BE4D6DED9FA44CE0F14_inline (float ___0_value, const RuntimeMethod* method) 
{
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	{
		float L_0 = ___0_value;
		V_0 = (bool)((((float)L_0) < ((float)(0.0f)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (0.0f);
		goto IL_002d;
	}

IL_0015:
	{
		float L_2 = ___0_value;
		V_2 = (bool)((((float)L_2) > ((float)(1.0f)))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0029;
		}
	}
	{
		V_1 = (1.0f);
		goto IL_002d;
	}

IL_0029:
	{
		float L_4 = ___0_value;
		V_1 = L_4;
		goto IL_002d;
	}

IL_002d:
	{
		float L_5 = V_1;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Subtraction_mE42023FF80067CB44A1D4A27EB7CF2B24CABB828_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_subtract(L_1, L_3)), ((float)il2cpp_codegen_subtract(L_5, L_7)), ((float)il2cpp_codegen_subtract(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_Cross_mF93A280558BCE756D13B6CC5DCD7DE8A43148987_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		float L_1 = L_0.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_rhs;
		float L_3 = L_2.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_lhs;
		float L_5 = L_4.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_rhs;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_lhs;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_rhs;
		float L_11 = L_10.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = ___0_lhs;
		float L_13 = L_12.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14 = ___1_rhs;
		float L_15 = L_14.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16 = ___0_lhs;
		float L_17 = L_16.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18 = ___1_rhs;
		float L_19 = L_18.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20 = ___0_lhs;
		float L_21 = L_20.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_22 = ___1_rhs;
		float L_23 = L_22.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24;
		memset((&L_24), 0, sizeof(L_24));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_24), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_9, L_11)), ((float)il2cpp_codegen_multiply(L_13, L_15)))), ((float)il2cpp_codegen_subtract(((float)il2cpp_codegen_multiply(L_17, L_19)), ((float)il2cpp_codegen_multiply(L_21, L_23)))), /*hidden argument*/NULL);
		V_0 = L_24;
		goto IL_005a;
	}

IL_005a:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_25 = V_0;
		return L_25;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3_Normalize_mC749B887A4C74BA0A2E13E6377F17CCAEB0AADA8_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	bool V_1 = false;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this);
		float L_1;
		L_1 = Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline(L_0, NULL);
		V_0 = L_1;
		float L_2 = V_0;
		V_1 = (bool)((((float)L_2) > ((float)(9.99999975E-06f)))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_002d;
		}
	}
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = (*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this);
		float L_5 = V_0;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline(L_4, L_5, NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this = L_6;
		goto IL_0038;
	}

IL_002d:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7;
		L_7 = Vector3_get_zero_m0C1249C3F25B1C70EAD3CC8B31259975A457AE39_inline(NULL);
		*(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*)__this = L_7;
	}

IL_0038:
	{
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Addition_m78C0EC70CB66E8DCAC225743D82B268DAEE92067_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_b, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_b;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_a;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_b;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_a;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_b;
		float L_11 = L_10.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_12), ((float)il2cpp_codegen_add(L_1, L_3)), ((float)il2cpp_codegen_add(L_5, L_7)), ((float)il2cpp_codegen_add(L_9, L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Division_mCC6BB24E372AB96B8380D1678446EF6A8BAE13BB_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_a, float ___1_d, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_a;
		float L_1 = L_0.___x_2;
		float L_2 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___0_a;
		float L_4 = L_3.___y_3;
		float L_5 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_a;
		float L_7 = L_6.___z_4;
		float L_8 = ___1_d;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)(L_1/L_2)), ((float)(L_4/L_5)), ((float)(L_7/L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Dot_mBB86BB940AA0A32FA7D3C02AC42E5BC7095A5D52_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_lhs, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___1_rhs, const RuntimeMethod* method) 
{
	float V_0 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_lhs;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___1_rhs;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_lhs;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___1_rhs;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_lhs;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___1_rhs;
		float L_11 = L_10.___z_4;
		V_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_multiply(L_9, L_11))));
		goto IL_002d;
	}

IL_002d:
	{
		float L_12 = V_0;
		return L_12;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_item, const RuntimeMethod* method) 
{
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_1 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = V_0;
		int32_t L_7 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_8);
		return;
	}

IL_0034:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ___0_item;
		((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___0_item, const RuntimeMethod* method) 
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = V_0;
		int32_t L_7 = V_1;
		int32_t L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (int32_t)L_8);
		return;
	}

IL_0034:
	{
		int32_t L_9 = ___0_item;
		((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___0_item;
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float Vector3_Magnitude_m21652D951393A3D7CE92CE40049A0E7F76544D1B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___0_vector, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___0_vector;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___0_vector;
		float L_3 = L_2.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4 = ___0_vector;
		float L_5 = L_4.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___0_vector;
		float L_7 = L_6.___y_3;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___0_vector;
		float L_9 = L_8.___z_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = ___0_vector;
		float L_11 = L_10.___z_4;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_12;
		L_12 = sqrt(((double)((float)il2cpp_codegen_add(((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_1, L_3)), ((float)il2cpp_codegen_multiply(L_5, L_7)))), ((float)il2cpp_codegen_multiply(L_9, L_11))))));
		V_0 = ((float)L_12);
		goto IL_0034;
	}

IL_0034:
	{
		float L_13 = V_0;
		return L_13;
	}
}
