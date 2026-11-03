namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000273")]
public class XStorePackageUpdate
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A7")]
	internal XStorePackageUpdate interop; //Field offset: 0x10

	[Token(Token = "0x170002C3")]
	public bool IsMandatory
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000CF1")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6000CF2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C2")]
	public string PackageIdentifier
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CEF")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000CF0")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x6000CED")]
	internal XStorePackageUpdate(XStorePackageUpdate interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000CEE")]
	public XStorePackageUpdate() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000CF1")]
	public bool get_IsMandatory() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CEF")]
	public string get_PackageIdentifier() { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6000CF2")]
	public void set_IsMandatory(bool value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000CF0")]
	public void set_PackageIdentifier(string value) { }

}

