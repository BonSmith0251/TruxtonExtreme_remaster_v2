namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024E")]
public class XPackageDetails
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000657")]
	internal XPackageDetails interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000658")]
	internal XVersion _XVersion; //Field offset: 0x50

	[Token(Token = "0x17000255")]
	public string Description
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000BE5")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000BE6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000254")]
	public string DisplayName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000BE3")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000BE4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000258")]
	public bool Installing
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000BEB")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[Token(Token = "0x6000BEC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000253")]
	public XPackageKind Kind
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000BE1")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000BE2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000251")]
	public string PackageIdentifier
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BDD")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000BDE")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000256")]
	public string Publisher
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000BE7")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000BE8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000257")]
	public string StoreId
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000BE9")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000BEA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000252")]
	public XVersion Version
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000BDF")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6000BE0")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B81F30", Offset = "0x2B81330", Length = "0xA4")]
	[Token(Token = "0x6000BDB")]
	internal XPackageDetails(XPackageDetails interop) { }

	[Address(RVA = "0x2B81EB0", Offset = "0x2B812B0", Length = "0x7F")]
	[Token(Token = "0x6000BDC")]
	public XPackageDetails() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000BE5")]
	public string get_Description() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000BE3")]
	public string get_DisplayName() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000BEB")]
	public bool get_Installing() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000BE1")]
	public XPackageKind get_Kind() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BDD")]
	public string get_PackageIdentifier() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000BE7")]
	public string get_Publisher() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000BE9")]
	public string get_StoreId() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000BDF")]
	public XVersion get_Version() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000BE6")]
	public void set_Description(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000BE4")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[Token(Token = "0x6000BEC")]
	public void set_Installing(bool value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000BE2")]
	public void set_Kind(XPackageKind value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000BDE")]
	public void set_PackageIdentifier(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000BE8")]
	public void set_Publisher(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000BEA")]
	public void set_StoreId(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6000BE0")]
	public void set_Version(XVersion value) { }

}

