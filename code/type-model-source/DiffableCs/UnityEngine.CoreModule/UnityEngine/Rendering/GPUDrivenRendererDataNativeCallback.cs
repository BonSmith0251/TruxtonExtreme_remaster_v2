namespace UnityEngine.Rendering;

[Token(Token = "0x20003B5")]
internal sealed class GPUDrivenRendererDataNativeCallback : MulticastDelegate
{

	[Address(RVA = "0x22D3C90", Offset = "0x22D3090", Length = "0xB5")]
	[Token(Token = "0x6001D14")]
	public GPUDrivenRendererDataNativeCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6001D15")]
	public override void Invoke(in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

}

