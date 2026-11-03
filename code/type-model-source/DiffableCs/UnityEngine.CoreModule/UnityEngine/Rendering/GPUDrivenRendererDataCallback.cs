namespace UnityEngine.Rendering;

[Token(Token = "0x20003B4")]
internal sealed class GPUDrivenRendererDataCallback : MulticastDelegate
{

	[Address(RVA = "0x22D3880", Offset = "0x22D2C80", Length = "0xB5")]
	[Token(Token = "0x6001D12")]
	public GPUDrivenRendererDataCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6001D13")]
	public override void Invoke(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

}

