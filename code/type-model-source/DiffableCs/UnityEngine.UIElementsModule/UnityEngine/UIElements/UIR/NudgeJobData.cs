namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A3")]
internal struct NudgeJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001396")]
	public IntPtr headSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001397")]
	public IntPtr headDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001398")]
	public int headCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001399")]
	public IntPtr tailSrc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400139A")]
	public IntPtr tailDst; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400139B")]
	public int tailCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400139C")]
	public Matrix4x4 transform; //Field offset: 0x2C

}

