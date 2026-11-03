namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000389")]
internal struct XStoreSkuInterop
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A1B")]
	internal string skuId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A1C")]
	internal string title; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A1D")]
	internal string description; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A1E")]
	internal string language; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A1F")]
	internal XStorePrice price; //Field offset: 0x20
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A20")]
	internal bool isTrial; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000A21")]
	internal bool isInUserCollection; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A22")]
	internal XStoreCollectionData collectionData; //Field offset: 0x68
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A23")]
	internal bool isSubscription; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000A24")]
	internal XStoreSubscriptionInfo subscriptionInfo; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A25")]
	internal uint bundledSkusCount; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A26")]
	internal IntPtr bundledSkus; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A27")]
	internal uint imagesCount; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A28")]
	internal IntPtr images; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A29")]
	internal uint videosCount; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A2A")]
	internal IntPtr videos; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A2B")]
	internal uint availabilitiesCount; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000A2C")]
	internal IntPtr availabilities; //Field offset: 0xF0

}

