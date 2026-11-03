namespace System.Xml.Schema;

[Token(Token = "0x200017D")]
internal class Datatype_anyAtomicType : Datatype_anySimpleType
{

	[Token(Token = "0x17000424")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FD6")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000425")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x6000FD7")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A02A0", Offset = "0x259F6A0", Length = "0x7A")]
	[Token(Token = "0x6000FD8")]
	public Datatype_anyAtomicType() { }

	[Address(RVA = "0x25A0250", Offset = "0x259F650", Length = "0x4F")]
	[Token(Token = "0x6000FD5")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FD6")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000FD7")]
	public virtual XmlTypeCode get_TypeCode() { }

}

