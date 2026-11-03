namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200036C")]
internal struct XNetworkingSecurityInformation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C8")]
	internal uint enabledHttpSecurityProtocolFlags; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009C9")]
	internal ulong thumbprintCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CA")]
	internal IntPtr thumbprints; //Field offset: 0x10

}

