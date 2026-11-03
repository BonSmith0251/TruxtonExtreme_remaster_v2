namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F6")]
internal struct XblMultiplayerMatchmakingServer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000823")]
	internal XblMatchmakingStatus Status; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000824")]
	internal UTF8StringPtr StatusDetails; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000825")]
	internal uint TypicalWaitInSeconds; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000826")]
	internal XblMultiplayerSessionReference TargetSessionRef; //Field offset: 0x14

}

