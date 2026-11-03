namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000268")]
public class XStoreSubscriptionInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067E")]
	internal XStoreSubscriptionInfo interop; //Field offset: 0x10

	[Token(Token = "0x17000296")]
	public uint BillingPeriod
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C9C")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000C9D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000295")]
	public XStoreDurationUnit BillingPeriodUnit
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000C9B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000292")]
	public bool HasTrialPeriod
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000C94")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000C95")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000294")]
	public uint TrialPeriod
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C98")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000C99")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000293")]
	public XStoreDurationUnit TrialPeriodUnit
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000C96")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000C97")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B834E0", Offset = "0x2B828E0", Length = "0x2F")]
	[Token(Token = "0x6000C92")]
	internal XStoreSubscriptionInfo(XStoreSubscriptionInfo interop) { }

	[Address(RVA = "0x2B83510", Offset = "0x2B82910", Length = "0x22")]
	[Token(Token = "0x6000C93")]
	public XStoreSubscriptionInfo() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C9C")]
	public uint get_BillingPeriod() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000C9A")]
	public XStoreDurationUnit get_BillingPeriodUnit() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000C94")]
	public bool get_HasTrialPeriod() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C98")]
	public uint get_TrialPeriod() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000C96")]
	public XStoreDurationUnit get_TrialPeriodUnit() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000C9D")]
	public void set_BillingPeriod(uint value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000C9B")]
	public void set_BillingPeriodUnit(XStoreDurationUnit value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6000C95")]
	public void set_HasTrialPeriod(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000C99")]
	public void set_TrialPeriod(uint value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000C97")]
	public void set_TrialPeriodUnit(XStoreDurationUnit value) { }

}

