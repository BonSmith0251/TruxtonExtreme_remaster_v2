namespace System.Xml.Schema;

[Token(Token = "0x200016F")]
internal sealed class NfaContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000779")]
	private BitSet firstpos; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077A")]
	private BitSet[] followpos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400077B")]
	private SymbolsDictionary symbols; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400077C")]
	private Positions positions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400077D")]
	private int endMarkerPos; //Field offset: 0x38

	[Address(RVA = "0x25B1CD0", Offset = "0x25B10D0", Length = "0xD3")]
	[Token(Token = "0x6000F66")]
	internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[Address(RVA = "0x25B1640", Offset = "0x25B0A40", Length = "0x4A")]
	[Token(Token = "0x6000F69")]
	public virtual bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x25B1690", Offset = "0x25B0A90", Length = "0x201")]
	[Token(Token = "0x6000F6A")]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[Address(RVA = "0x25B18A0", Offset = "0x25B0CA0", Length = "0x17F")]
	[Token(Token = "0x6000F6B")]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x25B1A20", Offset = "0x25B0E20", Length = "0xE0")]
	[Token(Token = "0x6000F67")]
	public virtual void InitValidation(ValidationState context) { }

	[Address(RVA = "0x25B1B10", Offset = "0x25B0F10", Length = "0x1BE")]
	[Token(Token = "0x6000F68")]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

