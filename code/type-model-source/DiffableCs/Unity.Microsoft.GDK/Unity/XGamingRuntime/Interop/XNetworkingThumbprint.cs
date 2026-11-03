namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200036B")]
internal struct XNetworkingThumbprint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C5")]
	internal XNetworkingThumbprintType thumbprintType; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009C6")]
	internal ulong thumbprintBufferByteCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009C7")]
	internal IntPtr thumbprintBuffer; //Field offset: 0x10

}

