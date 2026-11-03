namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003BC")]
public struct XblUserStatisticsResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A84")]
	public ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A85")]
	public XblServiceConfigurationStatistic* serviceConfigStatistics; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A86")]
	public uint serviceConfigStatisticsCount; //Field offset: 0x10

}

