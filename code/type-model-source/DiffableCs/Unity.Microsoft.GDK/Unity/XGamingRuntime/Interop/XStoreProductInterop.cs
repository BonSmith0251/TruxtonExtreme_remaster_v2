namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200038A")]
internal struct XStoreProductInterop
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A2D")]
	internal string storeId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A2E")]
	internal string title; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A2F")]
	internal string description; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A30")]
	internal string language; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A31")]
	internal string inAppOfferToken; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A32")]
	internal string linkUri; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A33")]
	internal XStoreProductKind productKind; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A34")]
	internal XStorePrice price; //Field offset: 0x38
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A35")]
	internal bool hasDigitalDownload; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000A36")]
	internal bool isInUserCollection; //Field offset: 0x79
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000A37")]
	internal uint keywordsCount; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A38")]
	internal IntPtr keywords; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A39")]
	internal uint skusCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A3A")]
	internal IntPtr skus; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A3B")]
	internal uint imagesCount; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A3C")]
	internal IntPtr images; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A3D")]
	internal uint videosCount; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A3E")]
	internal IntPtr videos; //Field offset: 0xB0

}

