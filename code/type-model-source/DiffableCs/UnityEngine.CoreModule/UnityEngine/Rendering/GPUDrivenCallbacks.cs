namespace UnityEngine.Rendering;

[RequiredByNativeCode]
[Token(Token = "0x20003B6")]
internal static class GPUDrivenCallbacks
{

	[Address(RVA = "0x30B39F0", Offset = "0x30B2DF0", Length = "0x21")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6001D16")]
	public static void InvokeGPUDrivenLODGroupDataNativeCallback(GPUDrivenLODGroupDataNativeCallback callback, in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback target) { }

	[Address(RVA = "0x30B3A20", Offset = "0x30B2E20", Length = "0x26")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6001D17")]
	public static void InvokeGPUDrivenRendererDataNativeCallback(GPUDrivenRendererDataNativeCallback callback, in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback target) { }

}

