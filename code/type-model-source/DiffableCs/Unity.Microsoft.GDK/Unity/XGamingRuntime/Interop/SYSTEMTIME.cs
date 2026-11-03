namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C5")]
internal struct SYSTEMTIME
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000771")]
	internal ushort wYear; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000772")]
	internal ushort wMonth; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000773")]
	internal ushort wDayOfWeek; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000774")]
	internal ushort wDay; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000775")]
	internal ushort wHour; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000776")]
	internal ushort wMinute; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000777")]
	internal ushort wSecond; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000778")]
	internal ushort wMilliseconds; //Field offset: 0xE

}

