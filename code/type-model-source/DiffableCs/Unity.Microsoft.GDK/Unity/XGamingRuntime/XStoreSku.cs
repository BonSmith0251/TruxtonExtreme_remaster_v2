namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200026D")]
public class XStoreSku
{
	[CompilerGenerated]
	[Token(Token = "0x200026E")]
	private sealed class <>c
	{
		[Token(Token = "0x400068F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000690")]
		public static Func<XStoreImage, XStoreImage> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000691")]
		public static Func<XStoreVideo, XStoreVideo> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000692")]
		public static Func<XStoreAvailability, XStoreAvailability> <>9__0_2; //Field offset: 0x18

		[Address(RVA = "0x2B806D0", Offset = "0x2B7FAD0", Length = "0x67")]
		[Token(Token = "0x6000CC6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CC7")]
		public <>c() { }

		[Address(RVA = "0x2B7FD50", Offset = "0x2B7F150", Length = "0x6A")]
		[Token(Token = "0x6000CC8")]
		internal XStoreImage <.ctor>b__0_0(XStoreImage imageInterop) { }

		[Address(RVA = "0x2B7FFB0", Offset = "0x2B7F3B0", Length = "0x79")]
		[Token(Token = "0x6000CC9")]
		internal XStoreVideo <.ctor>b__0_1(XStoreVideo videoInterop) { }

		[Address(RVA = "0x2B80350", Offset = "0x2B7F750", Length = "0x12E")]
		[Token(Token = "0x6000CCA")]
		internal XStoreAvailability <.ctor>b__0_2(XStoreAvailability availabilityInterop) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000681")]
	private readonly string <SkuId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000682")]
	private readonly string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000683")]
	private readonly string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000684")]
	private readonly string <Language>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000685")]
	private readonly XStorePrice <Price>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000686")]
	private readonly bool <IsTrial>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000687")]
	private readonly bool <IsInUserCollection>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000688")]
	private readonly XStoreCollectionData <CollectionData>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000689")]
	private readonly bool <IsSubscription>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400068A")]
	private readonly XStoreSubscriptionInfo <SubscriptionInfo>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400068B")]
	private readonly String[] <BundledSkus>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400068C")]
	private readonly XStoreImage[] <Images>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400068D")]
	private readonly XStoreVideo[] <Videos>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400068E")]
	private readonly XStoreAvailability[] <Availabilities>k__BackingField; //Field offset: 0x70

	[Token(Token = "0x170002AE")]
	public XStoreAvailability[] Availabilities
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002AB")]
	public String[] BundledSkus
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A8")]
	public XStoreCollectionData CollectionData
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A3")]
	public string Description
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002AC")]
	public XStoreImage[] Images
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A7")]
	public bool IsInUserCollection
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A9")]
	public bool IsSubscription
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A6")]
	public bool IsTrial
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A4")]
	public string Language
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A5")]
	public XStorePrice Price
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CBC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A1")]
	public string SkuId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002AA")]
	public XStoreSubscriptionInfo SubscriptionInfo
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002A2")]
	public string Title
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CB9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002AD")]
	public XStoreVideo[] Videos
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B82FA0", Offset = "0x2B823A0", Length = "0x535")]
	[Token(Token = "0x6000CB7")]
	internal XStoreSku(ref XStoreSkuInterop interop) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC5")]
	public XStoreAvailability[] get_Availabilities() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC2")]
	public String[] get_BundledSkus() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBF")]
	public XStoreCollectionData get_CollectionData() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBA")]
	public string get_Description() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC3")]
	public XStoreImage[] get_Images() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBE")]
	public bool get_IsInUserCollection() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC0")]
	public bool get_IsSubscription() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBD")]
	public bool get_IsTrial() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBB")]
	public string get_Language() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CBC")]
	public XStorePrice get_Price() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB8")]
	public string get_SkuId() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC1")]
	public XStoreSubscriptionInfo get_SubscriptionInfo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB9")]
	public string get_Title() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC4")]
	public XStoreVideo[] get_Videos() { }

}

