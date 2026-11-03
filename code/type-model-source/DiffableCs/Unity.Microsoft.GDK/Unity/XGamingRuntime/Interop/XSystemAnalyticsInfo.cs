namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000397")]
internal struct XSystemAnalyticsInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A57")]
	internal XVersion osVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A58")]
	internal XVersion hostingOsVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A59")]
	internal string family; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A5A")]
	internal string form; //Field offset: 0x18

}

