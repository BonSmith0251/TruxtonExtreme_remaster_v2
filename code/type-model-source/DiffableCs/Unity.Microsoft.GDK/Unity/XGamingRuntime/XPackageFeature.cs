namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024F")]
public class XPackageFeature
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000659")]
	internal XPackageFeature _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400065A")]
	private String[] _storeIds; //Field offset: 0x38

	[Token(Token = "0x1700025A")]
	public string DisplayName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BF1")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000BF2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700025C")]
	public bool Hidden
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000BF5")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000BF6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000259")]
	public string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BEF")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000BF0")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700025D")]
	public String[] StoreIds
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000BF7")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000BF8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700025B")]
	public string Tags
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BF3")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000BF4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B82090", Offset = "0x2B81490", Length = "0x64")]
	[Token(Token = "0x6000BED")]
	internal XPackageFeature(XPackageFeature interop) { }

	[Address(RVA = "0x2B81C20", Offset = "0x2B81020", Length = "0x27")]
	[Token(Token = "0x6000BEE")]
	public XPackageFeature() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BF1")]
	public string get_DisplayName() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000BF5")]
	public bool get_Hidden() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BEF")]
	public string get_Id() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000BF7")]
	public String[] get_StoreIds() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BF3")]
	public string get_Tags() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000BF2")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000BF6")]
	public void set_Hidden(bool value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000BF0")]
	public void set_Id(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000BF8")]
	public void set_StoreIds(String[] value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000BF4")]
	public void set_Tags(string value) { }

}

