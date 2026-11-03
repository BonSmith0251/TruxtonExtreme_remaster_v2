namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000396")]
internal struct XVersion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A52")]
	internal ushort major; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A56")]
	internal ulong Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000A53")]
	internal ushort minor; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A54")]
	internal ushort build; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000A55")]
	internal ushort revision; //Field offset: 0x6

}

