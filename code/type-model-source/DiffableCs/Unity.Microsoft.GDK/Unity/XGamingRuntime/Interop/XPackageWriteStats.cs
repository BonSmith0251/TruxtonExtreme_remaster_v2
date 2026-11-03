namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000377")]
internal struct XPackageWriteStats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E7")]
	internal ulong interval; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009E8")]
	internal ulong budget; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E9")]
	internal ulong elapsed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009EA")]
	internal ulong bytesWritten; //Field offset: 0x18

}

