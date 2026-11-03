namespace UnityEngine.Rendering.LookDev;

[Token(Token = "0x20002CC")]
public struct Sky
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D09")]
	public Cubemap cubemap; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D0A")]
	public float longitudeOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D0B")]
	public float exposure; //Field offset: 0xC

}

