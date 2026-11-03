namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000343")]
internal struct XblTitleHistory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096A")]
	internal readonly bool hasUserPlayed; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096B")]
	internal readonly TimeT lastTimeUserPlayed; //Field offset: 0x8

}

