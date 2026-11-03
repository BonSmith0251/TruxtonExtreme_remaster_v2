namespace System.Xml.Schema;

[Token(Token = "0x200014F")]
internal class AutoValidator : BaseValidator
{

	[Token(Token = "0x170003BD")]
	public virtual bool PreserveWhitespace
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000E7A")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x257AE00", Offset = "0x257A200", Length = "0x93")]
	[Token(Token = "0x6000E79")]
	public AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E7C")]
	public virtual void CompleteValidation() { }

	[Address(RVA = "0x257A900", Offset = "0x2579D00", Length = "0x401")]
	[Token(Token = "0x6000E7E")]
	private ValidationType DetectValidationType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E7D")]
	public virtual object FindId(string name) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000E7A")]
	public virtual bool get_PreserveWhitespace() { }

	[Address(RVA = "0x257AD10", Offset = "0x257A110", Length = "0xEC")]
	[Token(Token = "0x6000E7B")]
	public virtual void Validate() { }

}

