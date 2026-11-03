namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[Token(Token = "0x2000002")]
public class AssetBundle : object
{

	[Address(RVA = "0x2FC3CC0", Offset = "0x2FC30C0", Length = "0x49")]
	[Token(Token = "0x6000001")]
	private AssetBundle() { }

	[Address(RVA = "0x2FC2750", Offset = "0x2FC1B50", Length = "0x2A")]
	[Token(Token = "0x6000003")]
	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() { }

	[Address(RVA = "0x2FC2750", Offset = "0x2FC1B50", Length = "0x2A")]
	[FreeFunction("GetAllAssetBundles")]
	[Token(Token = "0x6000002")]
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	[Address(RVA = "0x2FC2880", Offset = "0x2FC1C80", Length = "0xB9")]
	[Token(Token = "0x6000010")]
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	[Address(RVA = "0x734590", Offset = "0x733990", Length = "0x5D")]
	[Token(Token = "0x600000F")]
	public AssetBundleRequest LoadAllAssetsAsync() { }

	[Address(RVA = "0x2FC2780", Offset = "0x2FC1B80", Length = "0xFB")]
	[Token(Token = "0x600000E")]
	public AssetBundleRequest LoadAllAssetsAsync() { }

	[Address(RVA = "0x7345F0", Offset = "0x7339F0", Length = "0xB9")]
	[Token(Token = "0x6000009")]
	public T LoadAsset(string name) { }

	[Address(RVA = "0x2FC3420", Offset = "0x2FC2820", Length = "0x147")]
	[Token(Token = "0x600000A")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	public object LoadAsset(string name, Type type) { }

	[Address(RVA = "0x2FC3200", Offset = "0x2FC2600", Length = "0x21F")]
	[NativeMethod("LoadAsset_Internal")]
	[NativeThrows]
	[Token(Token = "0x600000B")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	private object LoadAsset_Internal(string name, Type type) { }

	[Address(RVA = "0x2FC31A0", Offset = "0x2FC25A0", Length = "0x52")]
	[Token(Token = "0x6000017")]
	private static IntPtr LoadAsset_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }

	[Address(RVA = "0x2FC2C20", Offset = "0x2FC2020", Length = "0x147")]
	[Token(Token = "0x600000C")]
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	[Address(RVA = "0x2FC29A0", Offset = "0x2FC1DA0", Length = "0x276")]
	[NativeMethod("LoadAssetAsync_Internal")]
	[NativeThrows]
	[Token(Token = "0x6000011")]
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[Address(RVA = "0x2FC2940", Offset = "0x2FC1D40", Length = "0x52")]
	[Token(Token = "0x6000018")]
	private static IntPtr LoadAssetAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }

	[Address(RVA = "0x2FC3050", Offset = "0x2FC2450", Length = "0x147")]
	[Token(Token = "0x600000D")]
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	[Address(RVA = "0x2FC2DD0", Offset = "0x2FC21D0", Length = "0x276")]
	[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
	[NativeThrows]
	[Token(Token = "0x6000014")]
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

	[Address(RVA = "0x2FC2D70", Offset = "0x2FC2170", Length = "0x52")]
	[Token(Token = "0x600001B")]
	private static IntPtr LoadAssetWithSubAssetsAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }

	[Address(RVA = "0x2FC3810", Offset = "0x2FC2C10", Length = "0xD")]
	[Token(Token = "0x6000006")]
	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	[Address(RVA = "0x2FC3820", Offset = "0x2FC2C20", Length = "0xF")]
	[Token(Token = "0x6000005")]
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[Address(RVA = "0x2FC35C0", Offset = "0x2FC29C0", Length = "0x246")]
	[FreeFunction("LoadFromFileAsync")]
	[Token(Token = "0x6000004")]
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	[Address(RVA = "0x2FC3570", Offset = "0x2FC2970", Length = "0x50")]
	[Token(Token = "0x6000015")]
	private static IntPtr LoadFromFileAsync_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset) { }

	[Address(RVA = "0x2FC3990", Offset = "0x2FC2D90", Length = "0x116")]
	[Token(Token = "0x6000008")]
	public static AssetBundleCreateRequest LoadFromMemoryAsync(Byte[] binary) { }

	[Address(RVA = "0x2FC3870", Offset = "0x2FC2C70", Length = "0x118")]
	[FreeFunction("LoadFromMemoryAsync")]
	[Token(Token = "0x6000007")]
	internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Byte[] binary, uint crc) { }

	[Address(RVA = "0x2FC3830", Offset = "0x2FC2C30", Length = "0x40")]
	[Token(Token = "0x6000016")]
	private static IntPtr LoadFromMemoryAsync_Internal_Injected(ref ManagedSpanWrapper binary, uint crc) { }

	[Address(RVA = "0x2FC3C30", Offset = "0x2FC3030", Length = "0x86")]
	[NativeMethod("Unload")]
	[NativeThrows]
	[Token(Token = "0x6000012")]
	public void Unload(bool unloadAllLoadedObjects) { }

	[Address(RVA = "0x2FC3BE0", Offset = "0x2FC2FE0", Length = "0x42")]
	[Token(Token = "0x6000019")]
	private static void Unload_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }

	[Address(RVA = "0x2FC3B00", Offset = "0x2FC2F00", Length = "0xDB")]
	[NativeMethod("UnloadAsync")]
	[NativeThrows]
	[Token(Token = "0x6000013")]
	public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects) { }

	[Address(RVA = "0x2FC3AB0", Offset = "0x2FC2EB0", Length = "0x42")]
	[Token(Token = "0x600001A")]
	private static IntPtr UnloadAsync_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }

}

