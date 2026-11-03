namespace System.Xml.Schema;

[Token(Token = "0x20001B0")]
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
{
	[Token(Token = "0x4000848")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x170004B8")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5910", Offset = "0x25A4D10", Length = "0x4E")]
		[Token(Token = "0x60010EA")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170004B9")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCB90", Offset = "0x9DBF90", Length = "0x6")]
		[Token(Token = "0x60010EB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A5790", Offset = "0x25A4B90", Length = "0xFB")]
	[Token(Token = "0x60010ED")]
	private static Datatype_positiveInteger() { }

	[Address(RVA = "0x25A5890", Offset = "0x25A4C90", Length = "0x7A")]
	[Token(Token = "0x60010EC")]
	public Datatype_positiveInteger() { }

	[Address(RVA = "0x25A5910", Offset = "0x25A4D10", Length = "0x4E")]
	[Token(Token = "0x60010EA")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x9DCB90", Offset = "0x9DBF90", Length = "0x6")]
	[Token(Token = "0x60010EB")]
	public virtual XmlTypeCode get_TypeCode() { }

}

