namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A5")]
internal struct CopyMeshJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013B3")]
	public IntPtr vertSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40013B4")]
	public IntPtr vertDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013B5")]
	public int vertCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013B6")]
	public IntPtr indexSrc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013B7")]
	public IntPtr indexDst; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013B8")]
	public int indexCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40013B9")]
	public int indexOffset; //Field offset: 0x2C

}

