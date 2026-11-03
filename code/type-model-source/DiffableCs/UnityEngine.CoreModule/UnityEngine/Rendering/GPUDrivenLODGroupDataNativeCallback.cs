namespace UnityEngine.Rendering;

[Token(Token = "0x20003B3")]
internal sealed class GPUDrivenLODGroupDataNativeCallback : MulticastDelegate
{

	[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
	[Token(Token = "0x6001D10")]
	public GPUDrivenLODGroupDataNativeCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6001D11")]
	public override void Invoke(in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback callback) { }

}

