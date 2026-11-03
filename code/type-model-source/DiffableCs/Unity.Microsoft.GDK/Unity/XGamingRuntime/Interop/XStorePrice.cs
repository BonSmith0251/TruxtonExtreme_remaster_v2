namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000384")]
internal struct XStorePrice
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009FC")]
	internal float basePrice; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009FD")]
	internal float price; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009FE")]
	internal float recurrencePrice; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009FF")]
	internal string currencyCode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A00")]
	internal string formattedBasePrice; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A01")]
	internal string formattedPrice; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A02")]
	internal string formattedRecurrencePrice; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A03")]
	internal bool isOnSale; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A04")]
	internal long saleEndDate; //Field offset: 0x38

}

