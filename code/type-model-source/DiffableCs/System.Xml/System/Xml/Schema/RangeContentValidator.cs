namespace System.Xml.Schema;

[Token(Token = "0x2000171")]
internal sealed class RangeContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000780")]
	private BitSet firstpos; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000781")]
	private BitSet[] followpos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000782")]
	private BitSet positionsWithRangeTerminals; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000783")]
	private SymbolsDictionary symbols; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000784")]
	private Positions positions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000785")]
	private int minMaxNodesCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000786")]
	private int endMarkerPos; //Field offset: 0x44

	[Address(RVA = "0x25B4440", Offset = "0x25B3840", Length = "0xEC")]
	[Token(Token = "0x6000F6C")]
	internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	[Address(RVA = "0x25B3450", Offset = "0x25B2850", Length = "0x17")]
	[Token(Token = "0x6000F6F")]
	public virtual bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x25B3470", Offset = "0x25B2870", Length = "0x2A5")]
	[Token(Token = "0x6000F70")]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[Address(RVA = "0x25B3720", Offset = "0x25B2B20", Length = "0x217")]
	[Token(Token = "0x6000F71")]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x25B3940", Offset = "0x25B2D40", Length = "0x1E3")]
	[Token(Token = "0x6000F6D")]
	public virtual void InitValidation(ValidationState context) { }

	[Address(RVA = "0x25B3B30", Offset = "0x25B2F30", Length = "0x90F")]
	[Token(Token = "0x6000F6E")]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

