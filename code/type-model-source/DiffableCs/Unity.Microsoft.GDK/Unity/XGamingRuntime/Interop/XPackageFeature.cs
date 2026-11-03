namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000376")]
internal struct XPackageFeature
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E1")]
	internal string id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009E2")]
	internal string displayName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E3")]
	internal string tags; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009E4")]
	internal bool hidden; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009E5")]
	internal uint storeIdCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009E6")]
	internal IntPtr storeIds; //Field offset: 0x20

}

