namespace System.Xml.Schema;

[Token(Token = "0x200017E")]
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
{

	[Token(Token = "0x17000426")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FDA")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000427")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
		[Token(Token = "0x6000FDB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A7FF0", Offset = "0x25A73F0", Length = "0x7")]
	[Token(Token = "0x6000FDC")]
	public Datatype_untypedAtomicType() { }

	[Address(RVA = "0x25A7FA0", Offset = "0x25A73A0", Length = "0x4E")]
	[Token(Token = "0x6000FD9")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FDA")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
	[Token(Token = "0x6000FDB")]
	public virtual XmlTypeCode get_TypeCode() { }

}

