namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000387")]
internal struct XStoreSubscriptionInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A10")]
	internal bool hasTrialPeriod; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000A11")]
	internal XStoreDurationUnit trialPeriodUnit; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A12")]
	internal uint trialPeriod; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A13")]
	internal XStoreDurationUnit billingPeriodUnit; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A14")]
	internal uint billingPeriod; //Field offset: 0x10

}

