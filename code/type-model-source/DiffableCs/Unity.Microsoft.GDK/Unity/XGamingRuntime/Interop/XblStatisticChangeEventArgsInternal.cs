namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200034B")]
internal struct XblStatisticChangeEventArgsInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000985")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000986")]
	internal readonly Byte[] serviceConfigurationId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000987")]
	internal readonly XblStatisticInternal latestStatistic; //Field offset: 0x10

}

