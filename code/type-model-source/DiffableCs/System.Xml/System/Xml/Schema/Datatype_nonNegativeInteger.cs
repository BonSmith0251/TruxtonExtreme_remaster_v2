namespace System.Xml.Schema;

[Token(Token = "0x20001AB")]
internal class Datatype_nonNegativeInteger : Datatype_integer
{
	[Token(Token = "0x400083B")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x170004A5")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A55D0", Offset = "0x25A49D0", Length = "0x4E")]
		[Token(Token = "0x60010C5")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170004A7")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60010C7")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004A6")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2253700", Offset = "0x2252B00", Length = "0x6")]
		[Token(Token = "0x60010C6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A54D0", Offset = "0x25A48D0", Length = "0xFA")]
	[Token(Token = "0x60010C9")]
	private static Datatype_nonNegativeInteger() { }

	[Address(RVA = "0x25A4DB0", Offset = "0x25A41B0", Length = "0x49")]
	[Token(Token = "0x60010C8")]
	public Datatype_nonNegativeInteger() { }

	[Address(RVA = "0x25A55D0", Offset = "0x25A49D0", Length = "0x4E")]
	[Token(Token = "0x60010C5")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60010C7")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x2253700", Offset = "0x2252B00", Length = "0x6")]
	[Token(Token = "0x60010C6")]
	public virtual XmlTypeCode get_TypeCode() { }

}

