namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002EF")]
internal struct XblHopperStatisticsResponse
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400080C")]
	internal UTF8StringPtr hopperName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400080D")]
	internal long estimatedWaitTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400080E")]
	internal uint playersWaitingToMatch; //Field offset: 0x10

}

