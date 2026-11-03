namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200026F")]
public class XStoreProduct
{
	[CompilerGenerated]
	[Token(Token = "0x2000270")]
	private sealed class <>c
	{
		[Token(Token = "0x40006A1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40006A2")]
		public static Func<XStoreSkuInterop, XStoreSku> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40006A3")]
		public static Func<XStoreImage, XStoreImage> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40006A4")]
		public static Func<XStoreVideo, XStoreVideo> <>9__0_2; //Field offset: 0x18

		[Address(RVA = "0x2B80900", Offset = "0x2B7FD00", Length = "0x67")]
		[Token(Token = "0x6000CDA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CDB")]
		public <>c() { }

		[Address(RVA = "0x2B7FDC0", Offset = "0x2B7F1C0", Length = "0x54")]
		[Token(Token = "0x6000CDC")]
		internal XStoreSku <.ctor>b__0_0(XStoreSkuInterop skuInterop) { }

		[Address(RVA = "0x2B802E0", Offset = "0x2B7F6E0", Length = "0x6A")]
		[Token(Token = "0x6000CDD")]
		internal XStoreImage <.ctor>b__0_1(XStoreImage imageInterop) { }

		[Address(RVA = "0x2B80480", Offset = "0x2B7F880", Length = "0x79")]
		[Token(Token = "0x6000CDE")]
		internal XStoreVideo <.ctor>b__0_2(XStoreVideo videoInterop) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000693")]
	private readonly string <StoreId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000694")]
	private readonly string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000695")]
	private readonly string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000696")]
	private readonly string <Language>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000697")]
	private readonly string <InAppOfferToken>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000698")]
	private readonly string <LinkUri>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000699")]
	private readonly XStoreProductKind <ProductKind>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400069A")]
	private readonly XStorePrice <Price>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400069B")]
	private readonly bool <HasDigitalDownload>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x400069C")]
	private readonly bool <IsInUserCollection>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400069D")]
	private readonly String[] <Keywords>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400069E")]
	private readonly XStoreSku[] <Skus>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400069F")]
	private readonly XStoreImage[] <Images>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006A0")]
	private readonly XStoreVideo[] <Videos>k__BackingField; //Field offset: 0x70

	[Token(Token = "0x170002B1")]
	public string Description
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CCE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B7")]
	public bool HasDigitalDownload
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BB")]
	public XStoreImage[] Images
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B3")]
	public string InAppOfferToken
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B8")]
	public bool IsInUserCollection
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B9")]
	public String[] Keywords
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B2")]
	public string Language
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CCF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B4")]
	public string LinkUri
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B6")]
	public XStorePrice Price
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B5")]
	public XStoreProductKind ProductKind
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002BA")]
	public XStoreSku[] Skus
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002AF")]
	public string StoreId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B0")]
	public string Title
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CCD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BC")]
	public XStoreVideo[] Videos
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CD9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B82B20", Offset = "0x2B81F20", Length = "0x45F")]
	[Token(Token = "0x6000CCB")]
	internal XStoreProduct(ref XStoreProductInterop interop) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CCE")]
	public string get_Description() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD4")]
	public bool get_HasDigitalDownload() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD8")]
	public XStoreImage[] get_Images() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD0")]
	public string get_InAppOfferToken() { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD5")]
	public bool get_IsInUserCollection() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD6")]
	public String[] get_Keywords() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CCF")]
	public string get_Language() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD1")]
	public string get_LinkUri() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD3")]
	public XStorePrice get_Price() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD2")]
	public XStoreProductKind get_ProductKind() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD7")]
	public XStoreSku[] get_Skus() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CCC")]
	public string get_StoreId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CCD")]
	public string get_Title() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CD9")]
	public XStoreVideo[] get_Videos() { }

}

