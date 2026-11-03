namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000580")]
public class RegionInfo
{
	[Token(Token = "0x4001747")]
	private static RegionInfo currentRegion; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001748")]
	private int regionId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001749")]
	private string iso2Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400174A")]
	private string iso3Name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400174B")]
	private string win3Name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400174C")]
	private string englishName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400174D")]
	private string nativeName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400174E")]
	private string currencySymbol; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400174F")]
	private string isoCurrencySymbol; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001750")]
	private string currencyEnglishName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001751")]
	private string currencyNativeName; //Field offset: 0x58

	[ComVisible(False)]
	[Token(Token = "0x170005F4")]
	public override string CurrencyEnglishName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60028D1")]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	[Token(Token = "0x170005FC")]
	public override string CurrencyNativeName
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60028D9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F5")]
	public override string CurrencySymbol
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60028D2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F3")]
	public static RegionInfo CurrentRegion
	{
		[Address(RVA = "0x1FCC770", Offset = "0x1FCBB70", Length = "0xCC")]
		[Token(Token = "0x60028CB")]
		 get { } //Length: 204
	}

	[MonoTODO("DisplayName currently only returns the EnglishName")]
	[Token(Token = "0x170005F6")]
	public override string DisplayName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60028D3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F7")]
	public override string EnglishName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60028D4")]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	[Token(Token = "0x170005F8")]
	public override int GeoId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60028D5")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170005F9")]
	public override bool IsMetric
	{
		[Address(RVA = "0x1FCC840", Offset = "0x1FCBC40", Length = "0x70")]
		[Token(Token = "0x60028D6")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170005FA")]
	public override string ISOCurrencySymbol
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60028D7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005FD")]
	public override string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60028DA")]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	[Token(Token = "0x170005FB")]
	public override string NativeName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60028D8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005FE")]
	public override string ThreeLetterISORegionName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60028DB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005FF")]
	public override string ThreeLetterWindowsRegionName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60028DC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000600")]
	public override string TwoLetterISORegionName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60028DD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FCC5E0", Offset = "0x1FCB9E0", Length = "0x179")]
	[Token(Token = "0x60028CC")]
	public RegionInfo(int culture) { }

	[Address(RVA = "0x1FCC210", Offset = "0x1FCB610", Length = "0x1BE")]
	[Token(Token = "0x60028CD")]
	public RegionInfo(string name) { }

	[Address(RVA = "0x1FCC3D0", Offset = "0x1FCB7D0", Length = "0x201")]
	[Token(Token = "0x60028CE")]
	private RegionInfo(CultureInfo ci) { }

	[Address(RVA = "0x1FCBFF0", Offset = "0x1FCB3F0", Length = "0x4E")]
	[Token(Token = "0x60028E1")]
	internal static void ClearCachedData() { }

	[Address(RVA = "0x1FCC760", Offset = "0x1FCBB60", Length = "0x5")]
	[Token(Token = "0x60028D0")]
	private bool construct_internal_region_from_name(string name) { }

	[Address(RVA = "0x1FCC040", Offset = "0x1FCB440", Length = "0xB1")]
	[Token(Token = "0x60028DE")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60028D1")]
	public override string get_CurrencyEnglishName() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60028D9")]
	public override string get_CurrencyNativeName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60028D2")]
	public override string get_CurrencySymbol() { }

	[Address(RVA = "0x1FCC770", Offset = "0x1FCBB70", Length = "0xCC")]
	[Token(Token = "0x60028CB")]
	public static RegionInfo get_CurrentRegion() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60028D3")]
	public override string get_DisplayName() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60028D4")]
	public override string get_EnglishName() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60028D5")]
	public override int get_GeoId() { }

	[Address(RVA = "0x1FCC840", Offset = "0x1FCBC40", Length = "0x70")]
	[Token(Token = "0x60028D6")]
	public override bool get_IsMetric() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60028D7")]
	public override string get_ISOCurrencySymbol() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60028DA")]
	public override string get_Name() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60028D8")]
	public override string get_NativeName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60028DB")]
	public override string get_ThreeLetterISORegionName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60028DC")]
	public override string get_ThreeLetterWindowsRegionName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60028DD")]
	public override string get_TwoLetterISORegionName() { }

	[Address(RVA = "0x1FCC100", Offset = "0x1FCB500", Length = "0xAB")]
	[Token(Token = "0x60028CF")]
	private bool GetByTerritory(CultureInfo ci) { }

	[Address(RVA = "0x1FCC1B0", Offset = "0x1FCB5B0", Length = "0x3C")]
	[Token(Token = "0x60028DF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FCC1F0", Offset = "0x1FCB5F0", Length = "0x14")]
	[Token(Token = "0x60028E0")]
	public virtual string ToString() { }

}

