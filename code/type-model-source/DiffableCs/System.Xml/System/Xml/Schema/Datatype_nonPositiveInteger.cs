namespace System.Xml.Schema;

[Token(Token = "0x20001A5")]
internal class Datatype_nonPositiveInteger : Datatype_integer
{
	[Token(Token = "0x400082D")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x1700048F")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5720", Offset = "0x25A4B20", Length = "0x4E")]
		[Token(Token = "0x600109B")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000491")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600109D")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000490")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A5770", Offset = "0x25A4B70", Length = "0x6")]
		[Token(Token = "0x600109C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A5620", Offset = "0x25A4A20", Length = "0xFA")]
	[Token(Token = "0x600109F")]
	private static Datatype_nonPositiveInteger() { }

	[Address(RVA = "0x25A4DB0", Offset = "0x25A41B0", Length = "0x49")]
	[Token(Token = "0x600109E")]
	public Datatype_nonPositiveInteger() { }

	[Address(RVA = "0x25A5720", Offset = "0x25A4B20", Length = "0x4E")]
	[Token(Token = "0x600109B")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600109D")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x25A5770", Offset = "0x25A4B70", Length = "0x6")]
	[Token(Token = "0x600109C")]
	public virtual XmlTypeCode get_TypeCode() { }

}

