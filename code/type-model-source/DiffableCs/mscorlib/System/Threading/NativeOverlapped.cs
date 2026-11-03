namespace System.Threading;

[Token(Token = "0x2000204")]
public struct NativeOverlapped
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400099E")]
	public IntPtr InternalLow; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400099F")]
	public IntPtr InternalHigh; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009A0")]
	public int OffsetLow; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009A1")]
	public int OffsetHigh; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009A2")]
	public IntPtr EventHandle; //Field offset: 0x18

}

