namespace System.Xml.Schema;

[Token(Token = "0x200019A")]
internal class Datatype_token : Datatype_normalizedString
{

	[Token(Token = "0x1700047A")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001075")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000479")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6001074")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001076")]
	public Datatype_token() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001075")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6001074")]
	public virtual XmlTypeCode get_TypeCode() { }

}

