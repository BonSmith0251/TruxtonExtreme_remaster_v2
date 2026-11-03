namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001ED")]
public class XblTitleManagedStatistic
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400054D")]
	private string <StatisticName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400054E")]
	private XblTitleManagedStatType <StatisticType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400054F")]
	private double <NumberValue>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000550")]
	private string <StringValue>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170001D6")]
	public double NumberValue
	{
		[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3C")]
		 get { } //Length: 6
		[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170001D4")]
	public string StatisticName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A38")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A39")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001D5")]
	public XblTitleManagedStatType StatisticType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3A")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001D7")]
	public string StringValue
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3E")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B8C790", Offset = "0x2B8BB90", Length = "0xA5")]
	[Token(Token = "0x6000A40")]
	internal XblTitleManagedStatistic(XblTitleManagedStatistic interopStruct) { }

	[Address(RVA = "0x2B8C8A0", Offset = "0x2B8BCA0", Length = "0x6A")]
	[Token(Token = "0x6000A41")]
	internal XblTitleManagedStatistic(string statisticName, XblTitleManagedStatType statType, string stringValue, double numberValue) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A42")]
	public XblTitleManagedStatistic() { }

	[Address(RVA = "0x2B8C730", Offset = "0x2B8BB30", Length = "0x5E")]
	[Token(Token = "0x6000A43")]
	public XblTitleManagedStatistic(string statisticName, string statisticValue) { }

	[Address(RVA = "0x2B8C840", Offset = "0x2B8BC40", Length = "0x58")]
	[Token(Token = "0x6000A44")]
	public XblTitleManagedStatistic(string statisticName, double statisticValue) { }

	[Address(RVA = "0x2B8C680", Offset = "0x2B8BA80", Length = "0xA6")]
	[Token(Token = "0x6000A45")]
	public static int Create(string statisticName, string statisticValue, out XblTitleManagedStatistic titleManagedStatistic) { }

	[Address(RVA = "0x2B8C5E0", Offset = "0x2B8B9E0", Length = "0xA0")]
	[Token(Token = "0x6000A46")]
	public static int Create(string statisticName, double statisticValue, out XblTitleManagedStatistic titleManagedStatistic) { }

	[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3C")]
	public double get_NumberValue() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A38")]
	public string get_StatisticName() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3A")]
	public XblTitleManagedStatType get_StatisticType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3E")]
	public string get_StringValue() { }

	[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3D")]
	public void set_NumberValue(double value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A39")]
	public void set_StatisticName(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3B")]
	public void set_StatisticType(XblTitleManagedStatType value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3F")]
	public void set_StringValue(string value) { }

}

