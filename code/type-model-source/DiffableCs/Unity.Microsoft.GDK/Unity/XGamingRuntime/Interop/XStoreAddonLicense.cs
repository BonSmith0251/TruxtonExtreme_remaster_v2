namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200038C")]
internal struct XStoreAddonLicense
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A40")]
	internal string skuStoreId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A41")]
	internal string inAppOfferToken; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A42")]
	internal bool isActive; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A43")]
	internal long expirationDate; //Field offset: 0x18

}

