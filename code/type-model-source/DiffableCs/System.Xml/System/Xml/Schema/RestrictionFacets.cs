namespace System.Xml.Schema;

[Token(Token = "0x2000177")]
internal class RestrictionFacets
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A2")]
	internal int Length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40007A3")]
	internal int MinLength; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007A4")]
	internal int MaxLength; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007A5")]
	internal ArrayList Patterns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007A6")]
	internal ArrayList Enumeration; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007A7")]
	internal XmlSchemaWhiteSpace WhiteSpace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007A8")]
	internal object MaxInclusive; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007A9")]
	internal object MaxExclusive; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007AA")]
	internal object MinInclusive; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007AB")]
	internal object MinExclusive; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007AC")]
	internal int TotalDigits; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40007AD")]
	internal int FractionDigits; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007AE")]
	internal RestrictionFlags Flags; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40007AF")]
	internal RestrictionFlags FixedFlags; //Field offset: 0x64

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F7D")]
	public RestrictionFacets() { }

}

