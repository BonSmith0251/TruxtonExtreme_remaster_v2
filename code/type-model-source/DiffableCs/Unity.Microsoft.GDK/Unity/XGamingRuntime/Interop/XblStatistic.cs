namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003B8")]
public struct XblStatistic
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A7D")]
	public SByte* statisticName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A7E")]
	public SByte* statisticType; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A7F")]
	public SByte* value; //Field offset: 0x10

}

