namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000569")]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	[Token(Token = "0x4001683")]
	private static NumberFormatInfo invariantInfo; //Field offset: 0x0
	[Token(Token = "0x40016A6")]
	private const NumberStyles InvalidNumberStyles = -1024; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001684")]
	internal Int32[] numberGroupSizes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001685")]
	internal Int32[] currencyGroupSizes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001686")]
	internal Int32[] percentGroupSizes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001687")]
	internal string positiveSign; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001688")]
	internal string negativeSign; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001689")]
	internal string numberDecimalSeparator; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400168A")]
	internal string numberGroupSeparator; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400168B")]
	internal string currencyGroupSeparator; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400168C")]
	internal string currencyDecimalSeparator; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400168D")]
	internal string currencySymbol; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400168E")]
	internal string ansiCurrencySymbol; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400168F")]
	internal string nanSymbol; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001690")]
	internal string positiveInfinitySymbol; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001691")]
	internal string negativeInfinitySymbol; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001692")]
	internal string percentDecimalSeparator; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001693")]
	internal string percentGroupSeparator; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001694")]
	internal string percentSymbol; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001695")]
	internal string perMilleSymbol; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4001696")]
	internal String[] nativeDigits; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x4001697")]
	internal int m_dataItem; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4001698")]
	internal int numberDecimalDigits; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001699")]
	internal int currencyDecimalDigits; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400169A")]
	internal int currencyPositivePattern; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400169B")]
	internal int currencyNegativePattern; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400169C")]
	internal int numberNegativePattern; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400169D")]
	internal int percentPositivePattern; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400169E")]
	internal int percentNegativePattern; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400169F")]
	internal int percentDecimalDigits; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A0")]
	internal int digitSubstitution; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40016A1")]
	internal bool isReadOnly; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD1")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A2")]
	internal bool m_useUserOverride; //Field offset: 0xD1
	[FieldOffset(Offset = "0xD2")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A3")]
	internal bool m_isInvariant; //Field offset: 0xD2
	[FieldOffset(Offset = "0xD3")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A4")]
	internal bool validForParseAsNumber; //Field offset: 0xD3
	[FieldOffset(Offset = "0xD4")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A5")]
	internal bool validForParseAsCurrency; //Field offset: 0xD4

	[Token(Token = "0x17000599")]
	public int CurrencyDecimalDigits
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[Token(Token = "0x6002797")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700059A")]
	public string CurrencyDecimalSeparator
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6002798")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700059F")]
	public string CurrencyGroupSeparator
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600279D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700059C")]
	public Int32[] CurrencyGroupSizes
	{
		[Address(RVA = "0x1F7B340", Offset = "0x1F7A740", Length = "0x77")]
		[Token(Token = "0x600279A")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005A3")]
	public int CurrencyNegativePattern
	{
		[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
		[Token(Token = "0x60027A2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005AC")]
	public int CurrencyPositivePattern
	{
		[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
		[Token(Token = "0x60027AB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005A0")]
	public string CurrencySymbol
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600279E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A1")]
	public static NumberFormatInfo CurrentInfo
	{
		[Address(RVA = "0x1F7B3E0", Offset = "0x1F7A7E0", Length = "0xFE")]
		[Token(Token = "0x600279F")]
		 get { } //Length: 254
	}

	[Token(Token = "0x17000598")]
	public static NumberFormatInfo InvariantInfo
	{
		[Address(RVA = "0x1F7B4E0", Offset = "0x1F7A8E0", Length = "0x116")]
		[Token(Token = "0x6002794")]
		 get { } //Length: 278
	}

	[Token(Token = "0x1700059B")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x1F7B600", Offset = "0x1F7AA00", Length = "0x8")]
		[Token(Token = "0x6002799")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005A2")]
	public string NaNSymbol
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60027A0")]
		 get { } //Length: 5
		[Address(RVA = "0x1F7B730", Offset = "0x1F7AB30", Length = "0xE9")]
		[Token(Token = "0x60027A1")]
		 set { } //Length: 233
	}

	[Token(Token = "0x170005A7")]
	public string NegativeInfinitySymbol
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60027A6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A8")]
	public string NegativeSign
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60027A7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A9")]
	public int NumberDecimalDigits
	{
		[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
		[Token(Token = "0x60027A8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005AA")]
	public string NumberDecimalSeparator
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60027A9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005AB")]
	public string NumberGroupSeparator
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60027AA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700059D")]
	public Int32[] NumberGroupSizes
	{
		[Address(RVA = "0x1F7B620", Offset = "0x1F7AA20", Length = "0x77")]
		[Token(Token = "0x600279B")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005A4")]
	public int NumberNegativePattern
	{
		[Address(RVA = "0x1F7B6A0", Offset = "0x1F7AAA0", Length = "0x7")]
		[Token(Token = "0x60027A3")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005AF")]
	public int PercentDecimalDigits
	{
		[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
		[Token(Token = "0x60027AE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B0")]
	public string PercentDecimalSeparator
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60027AF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005B1")]
	public string PercentGroupSeparator
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60027B0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700059E")]
	public Int32[] PercentGroupSizes
	{
		[Address(RVA = "0x1F7B6B0", Offset = "0x1F7AAB0", Length = "0x77")]
		[Token(Token = "0x600279C")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005A6")]
	public int PercentNegativePattern
	{
		[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
		[Token(Token = "0x60027A5")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005A5")]
	public int PercentPositivePattern
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[Token(Token = "0x60027A4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B2")]
	public string PercentSymbol
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60027B1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005B3")]
	public string PerMilleSymbol
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60027B2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005AD")]
	public string PositiveInfinitySymbol
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60027AC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005AE")]
	public string PositiveSign
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60027AD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F7AD60", Offset = "0x1F7A160", Length = "0xA")]
	[Token(Token = "0x600278E")]
	public NumberFormatInfo() { }

	[Address(RVA = "0x1F7AD70", Offset = "0x1F7A170", Length = "0x5C0")]
	[Token(Token = "0x6002792")]
	internal NumberFormatInfo(CultureData cultureData) { }

	[Address(RVA = "0x1F7A610", Offset = "0x1F79A10", Length = "0x64")]
	[Token(Token = "0x6002796")]
	public override object Clone() { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[Token(Token = "0x6002797")]
	public int get_CurrencyDecimalDigits() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6002798")]
	public string get_CurrencyDecimalSeparator() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600279D")]
	public string get_CurrencyGroupSeparator() { }

	[Address(RVA = "0x1F7B340", Offset = "0x1F7A740", Length = "0x77")]
	[Token(Token = "0x600279A")]
	public Int32[] get_CurrencyGroupSizes() { }

	[Address(RVA = "0x1F7B3C0", Offset = "0x1F7A7C0", Length = "0x7")]
	[Token(Token = "0x60027A2")]
	public int get_CurrencyNegativePattern() { }

	[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
	[Token(Token = "0x60027AB")]
	public int get_CurrencyPositivePattern() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600279E")]
	public string get_CurrencySymbol() { }

	[Address(RVA = "0x1F7B3E0", Offset = "0x1F7A7E0", Length = "0xFE")]
	[Token(Token = "0x600279F")]
	public static NumberFormatInfo get_CurrentInfo() { }

	[Address(RVA = "0x1F7B4E0", Offset = "0x1F7A8E0", Length = "0x116")]
	[Token(Token = "0x6002794")]
	public static NumberFormatInfo get_InvariantInfo() { }

	[Address(RVA = "0x1F7B600", Offset = "0x1F7AA00", Length = "0x8")]
	[Token(Token = "0x6002799")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60027A0")]
	public string get_NaNSymbol() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60027A6")]
	public string get_NegativeInfinitySymbol() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60027A7")]
	public string get_NegativeSign() { }

	[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
	[Token(Token = "0x60027A8")]
	public int get_NumberDecimalDigits() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60027A9")]
	public string get_NumberDecimalSeparator() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60027AA")]
	public string get_NumberGroupSeparator() { }

	[Address(RVA = "0x1F7B620", Offset = "0x1F7AA20", Length = "0x77")]
	[Token(Token = "0x600279B")]
	public Int32[] get_NumberGroupSizes() { }

	[Address(RVA = "0x1F7B6A0", Offset = "0x1F7AAA0", Length = "0x7")]
	[Token(Token = "0x60027A3")]
	public int get_NumberNegativePattern() { }

	[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
	[Token(Token = "0x60027AE")]
	public int get_PercentDecimalDigits() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60027AF")]
	public string get_PercentDecimalSeparator() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60027B0")]
	public string get_PercentGroupSeparator() { }

	[Address(RVA = "0x1F7B6B0", Offset = "0x1F7AAB0", Length = "0x77")]
	[Token(Token = "0x600279C")]
	public Int32[] get_PercentGroupSizes() { }

	[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
	[Token(Token = "0x60027A5")]
	public int get_PercentNegativePattern() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[Token(Token = "0x60027A4")]
	public int get_PercentPositivePattern() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60027B1")]
	public string get_PercentSymbol() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60027B2")]
	public string get_PerMilleSymbol() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60027AC")]
	public string get_PositiveInfinitySymbol() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60027AD")]
	public string get_PositiveSign() { }

	[Address(RVA = "0x1F7A680", Offset = "0x1F79A80", Length = "0x80")]
	[Token(Token = "0x60027B3")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x1F7A700", Offset = "0x1F79B00", Length = "0x2A0")]
	[Token(Token = "0x6002795")]
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[OnDeserialized]
	[Token(Token = "0x6002791")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[OnDeserializing]
	[Token(Token = "0x6002790")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F7A9B0", Offset = "0x1F79DB0", Length = "0x89")]
	[OnSerializing]
	[Token(Token = "0x600278F")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F7AA40", Offset = "0x1F79E40", Length = "0xC4")]
	[Token(Token = "0x60027B4")]
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	[Address(RVA = "0x1F7B730", Offset = "0x1F7AB30", Length = "0xE9")]
	[Token(Token = "0x60027A1")]
	public void set_NaNSymbol(string value) { }

	[Address(RVA = "0x1F7AB10", Offset = "0x1F79F10", Length = "0xDD")]
	[Token(Token = "0x60027B6")]
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

	[Address(RVA = "0x1F7ABF0", Offset = "0x1F79FF0", Length = "0xEB")]
	[Token(Token = "0x60027B5")]
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	[Address(RVA = "0x1F7ACE0", Offset = "0x1F7A0E0", Length = "0x7B")]
	[Token(Token = "0x6002793")]
	private void VerifyWritable() { }

}

