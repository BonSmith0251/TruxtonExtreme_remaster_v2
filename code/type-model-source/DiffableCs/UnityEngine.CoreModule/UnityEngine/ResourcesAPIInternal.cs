namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[Token(Token = "0x200017B")]
internal static class ResourcesAPIInternal
{

	[Address(RVA = "0x306FE30", Offset = "0x306F230", Length = "0x33")]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[Token(Token = "0x600122F")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[Address(RVA = "0x306FEB0", Offset = "0x306F2B0", Length = "0x1DA")]
	[FreeFunction("GetShaderNameRegistry().FindShader")]
	[Token(Token = "0x6001230")]
	public static Shader FindShaderByName(string name) { }

	[Address(RVA = "0x306FE70", Offset = "0x306F270", Length = "0x33")]
	[Token(Token = "0x6001235")]
	private static IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30705B0", Offset = "0x306F9B0", Length = "0x1FE")]
	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[Token(Token = "0x6001231")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	public static object Load(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x3070560", Offset = "0x306F960", Length = "0x42")]
	[Token(Token = "0x6001236")]
	private static IntPtr Load_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }

	[Address(RVA = "0x30700E0", Offset = "0x306F4E0", Length = "0x1E6")]
	[FreeFunction("Resources_Bindings::LoadAll")]
	[NativeThrows]
	[Token(Token = "0x6001232")]
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x3070090", Offset = "0x306F490", Length = "0x42")]
	[Token(Token = "0x6001237")]
	private static Object[] LoadAll_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }

	[Address(RVA = "0x3070320", Offset = "0x306F720", Length = "0x23D")]
	[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
	[Token(Token = "0x6001233")]
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[Address(RVA = "0x30702D0", Offset = "0x306F6D0", Length = "0x42")]
	[Token(Token = "0x6001238")]
	private static IntPtr LoadAsyncInternal_Injected(ref ManagedSpanWrapper path, Type type) { }

	[Address(RVA = "0x30707F0", Offset = "0x306FBF0", Length = "0x6B")]
	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	[Token(Token = "0x6001234")]
	public static void UnloadAsset(object assetToUnload) { }

	[Address(RVA = "0x30707B0", Offset = "0x306FBB0", Length = "0x33")]
	[Token(Token = "0x6001239")]
	private static void UnloadAsset_Injected(IntPtr assetToUnload) { }

}

