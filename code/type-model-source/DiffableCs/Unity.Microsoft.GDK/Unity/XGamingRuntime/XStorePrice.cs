namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000265")]
public class XStorePrice
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067A")]
	internal XStorePrice interop; //Field offset: 0x10

	[Token(Token = "0x1700027D")]
	public float BasePrice
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000C64")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000C65")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000280")]
	public string CurrencyCode
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C6A")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000C6B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000281")]
	public string FormattedBasePrice
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C6C")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000C6D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000282")]
	public string FormattedPrice
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C6E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000C6F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000283")]
	public string FormattedRecurrencePrice
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C70")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000C71")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000284")]
	public bool IsOnSale
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000C72")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[Token(Token = "0x6000C73")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700027E")]
	public float Price
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x6000C66")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[Token(Token = "0x6000C67")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700027F")]
	public float RecurrencePrice
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000C68")]
		 get { } //Length: 6
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[Token(Token = "0x6000C69")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000285")]
	public long SaleEndDate
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000C74")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[Token(Token = "0x6000C75")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B82AA0", Offset = "0x2B81EA0", Length = "0x4B")]
	[Token(Token = "0x6000C62")]
	internal XStorePrice(XStorePrice interop) { }

	[Address(RVA = "0x2B82A70", Offset = "0x2B81E70", Length = "0x29")]
	[Token(Token = "0x6000C63")]
	public XStorePrice() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000C64")]
	public float get_BasePrice() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C6A")]
	public string get_CurrencyCode() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C6C")]
	public string get_FormattedBasePrice() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C6E")]
	public string get_FormattedPrice() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C70")]
	public string get_FormattedRecurrencePrice() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000C72")]
	public bool get_IsOnSale() { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[Token(Token = "0x6000C66")]
	public float get_Price() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000C68")]
	public float get_RecurrencePrice() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000C74")]
	public long get_SaleEndDate() { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000C65")]
	public void set_BasePrice(float value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000C6B")]
	public void set_CurrencyCode(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000C6D")]
	public void set_FormattedBasePrice(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000C6F")]
	public void set_FormattedPrice(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000C71")]
	public void set_FormattedRecurrencePrice(string value) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x6000C73")]
	public void set_IsOnSale(bool value) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[Token(Token = "0x6000C67")]
	public void set_Price(float value) { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[Token(Token = "0x6000C69")]
	public void set_RecurrencePrice(float value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[Token(Token = "0x6000C75")]
	public void set_SaleEndDate(long value) { }

}

