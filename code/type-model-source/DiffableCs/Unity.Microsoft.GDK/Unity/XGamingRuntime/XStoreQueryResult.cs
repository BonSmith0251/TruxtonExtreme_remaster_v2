namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000139")]
public class XStoreQueryResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E2")]
	private XStoreProductQuery <QueryHandle>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E3")]
	private bool <HasMorePages>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E4")]
	private XStoreProduct[] <PageItems>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700006C")]
	public private bool HasMorePages
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600071F")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000720")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700006D")]
	public private XStoreProduct[] PageItems
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000721")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000722")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700006B")]
	internal XStoreProductQuery QueryHandle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600071D")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600071E")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B7D0F0", Offset = "0x2B7C4F0", Length = "0x61")]
	[Token(Token = "0x600071C")]
	internal XStoreQueryResult(XStoreProductQuery queryHandle, XStoreProduct[] pageItems, bool hasMorePages) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600071F")]
	public bool get_HasMorePages() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000721")]
	public XStoreProduct[] get_PageItems() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600071D")]
	internal XStoreProductQuery get_QueryHandle() { }

	[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
	[Token(Token = "0x6000723")]
	public static XStoreProductQuery op_Implicit(XStoreQueryResult result) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000720")]
	private void set_HasMorePages(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000722")]
	private void set_PageItems(XStoreProduct[] value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600071E")]
	private void set_QueryHandle(XStoreProductQuery value) { }

}

