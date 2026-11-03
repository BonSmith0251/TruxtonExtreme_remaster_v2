namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200034A")]
internal struct XblStatisticInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000982")]
	internal readonly UTF8StringPtr statisticName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000983")]
	internal readonly UTF8StringPtr statisticType; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000984")]
	internal readonly UTF8StringPtr value; //Field offset: 0x10

}

