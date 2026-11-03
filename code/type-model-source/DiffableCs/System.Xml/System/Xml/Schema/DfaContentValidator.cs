namespace System.Xml.Schema;

[Token(Token = "0x200016E")]
internal sealed class DfaContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000777")]
	private Int32[][] transitionTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000778")]
	private SymbolsDictionary symbols; //Field offset: 0x20

	[Address(RVA = "0x2582640", Offset = "0x2581A40", Length = "0xA2")]
	[Token(Token = "0x6000F60")]
	internal DfaContentValidator(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[Address(RVA = "0x2582070", Offset = "0x2581470", Length = "0x1A")]
	[Token(Token = "0x6000F63")]
	public virtual bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x2582090", Offset = "0x2581490", Length = "0x1D7")]
	[Token(Token = "0x6000F64")]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[Address(RVA = "0x2582270", Offset = "0x2581670", Length = "0x17C")]
	[Token(Token = "0x6000F65")]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x25823F0", Offset = "0x25817F0", Length = "0x58")]
	[Token(Token = "0x6000F61")]
	public virtual void InitValidation(ValidationState context) { }

	[Address(RVA = "0x2582450", Offset = "0x2581850", Length = "0x1E7")]
	[Token(Token = "0x6000F62")]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

