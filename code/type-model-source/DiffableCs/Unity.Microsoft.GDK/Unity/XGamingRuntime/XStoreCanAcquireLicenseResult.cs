namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000263")]
public class XStoreCanAcquireLicenseResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000678")]
	internal XStoreCanAcquireLicenseResult interop; //Field offset: 0x10

	[Token(Token = "0x17000276")]
	public string LicensableSku
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C52")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000C53")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000277")]
	public XStoreCanLicenseStatus Status
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C54")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000C55")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x6000C50")]
	internal XStoreCanAcquireLicenseResult(XStoreCanAcquireLicenseResult interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000C51")]
	public XStoreCanAcquireLicenseResult() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C52")]
	public string get_LicensableSku() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C54")]
	public XStoreCanLicenseStatus get_Status() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000C53")]
	public void set_LicensableSku(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000C55")]
	public void set_Status(XStoreCanLicenseStatus value) { }

}

