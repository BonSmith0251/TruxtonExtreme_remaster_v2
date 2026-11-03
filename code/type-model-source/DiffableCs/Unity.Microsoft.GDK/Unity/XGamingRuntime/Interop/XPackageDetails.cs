namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000375")]
internal struct XPackageDetails
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D9")]
	internal string packageIdentifier; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009DA")]
	internal XVersion version; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009DB")]
	internal XPackageKind kind; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009DC")]
	internal string displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009DD")]
	internal string description; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009DE")]
	internal string publisher; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009DF")]
	internal string storeId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009E0")]
	internal bool installing; //Field offset: 0x38

}

