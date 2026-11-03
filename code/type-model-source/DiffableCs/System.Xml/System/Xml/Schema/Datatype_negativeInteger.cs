namespace System.Xml.Schema;

[Token(Token = "0x20001A6")]
internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
{
	[Token(Token = "0x400082E")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x17000492")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5470", Offset = "0x25A4870", Length = "0x4E")]
		[Token(Token = "0x60010A0")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000493")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A54C0", Offset = "0x25A48C0", Length = "0x6")]
		[Token(Token = "0x60010A1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A52F0", Offset = "0x25A46F0", Length = "0xFB")]
	[Token(Token = "0x60010A3")]
	private static Datatype_negativeInteger() { }

	[Address(RVA = "0x25A53F0", Offset = "0x25A47F0", Length = "0x7A")]
	[Token(Token = "0x60010A2")]
	public Datatype_negativeInteger() { }

	[Address(RVA = "0x25A5470", Offset = "0x25A4870", Length = "0x4E")]
	[Token(Token = "0x60010A0")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A54C0", Offset = "0x25A48C0", Length = "0x6")]
	[Token(Token = "0x60010A1")]
	public virtual XmlTypeCode get_TypeCode() { }

}

