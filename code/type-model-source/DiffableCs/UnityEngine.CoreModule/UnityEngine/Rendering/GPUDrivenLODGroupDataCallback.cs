namespace UnityEngine.Rendering;

[Token(Token = "0x20003B2")]
internal sealed class GPUDrivenLODGroupDataCallback : MulticastDelegate
{

	[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
	[Token(Token = "0x6001D0E")]
	public GPUDrivenLODGroupDataCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6001D0F")]
	public override void Invoke(in GPUDrivenLODGroupData lodGroupData) { }

}

