namespace Unity.XGamingRuntime;

[Token(Token = "0x20001FF")]
public struct XblStatisticChangeEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400056B")]
	public ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400056C")]
	public string serviceConfigurationId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400056D")]
	public XblStatistic latestStatistic; //Field offset: 0x10

	[Address(RVA = "0x2B8C350", Offset = "0x2B8B750", Length = "0x10C")]
	[Token(Token = "0x6000A90")]
	internal XblStatisticChangeEventArgs(XblStatisticChangeEventArgs interopStruct) { }

}

