namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000271")]
public class XStoreAddonLicense
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A5")]
	internal XStoreAddonLicense interop; //Field offset: 0x10

	[Token(Token = "0x170002C0")]
	public long ExpirationDate
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000CE7")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000CE8")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002BE")]
	public string InAppOfferToken
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000CE3")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000CE4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002BF")]
	public bool IsActive
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000CE5")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000CE6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002BD")]
	public string SkuStoreId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CE1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000CE2")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2B82650", Offset = "0x2B81A50", Length = "0x3B")]
	[Token(Token = "0x6000CDF")]
	internal XStoreAddonLicense(XStoreAddonLicense interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000CE0")]
	public XStoreAddonLicense() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000CE7")]
	public long get_ExpirationDate() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000CE3")]
	public string get_InAppOfferToken() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000CE5")]
	public bool get_IsActive() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CE1")]
	public string get_SkuStoreId() { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000CE8")]
	public void set_ExpirationDate(long value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000CE4")]
	public void set_InAppOfferToken(string value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000CE6")]
	public void set_IsActive(bool value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000CE2")]
	public void set_SkuStoreId(string value) { }

}

