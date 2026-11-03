namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200036D")]
internal struct XNetworkingTcpQueuedReceivedBufferUsageStatistics
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009CB")]
	internal ulong numBytesCurrentlyQueued; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009CC")]
	internal ulong peakNumBytesEverQueued; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CD")]
	internal ulong totalNumBytesQueued; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009CE")]
	internal ulong numBytesDroppedForExceedingConfiguredMax; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009CF")]
	internal ulong numBytesDroppedDueToAnyFailure; //Field offset: 0x20

}

