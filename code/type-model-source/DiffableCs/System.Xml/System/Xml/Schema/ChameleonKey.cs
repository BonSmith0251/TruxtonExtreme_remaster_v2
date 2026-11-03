namespace System.Xml.Schema;

[Token(Token = "0x2000153")]
internal class ChameleonKey
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000727")]
	internal string targetNS; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000728")]
	internal Uri chameleonLocation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000729")]
	internal XmlSchema originalSchema; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072A")]
	private int hashCode; //Field offset: 0x28

	[Address(RVA = "0x257F010", Offset = "0x257E410", Length = "0x88")]
	[Token(Token = "0x6000EC4")]
	public ChameleonKey(string ns, XmlSchema originalSchema) { }

	[Address(RVA = "0x257EE90", Offset = "0x257E290", Length = "0xD7")]
	[Token(Token = "0x6000EC6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x257EF70", Offset = "0x257E370", Length = "0x97")]
	[Token(Token = "0x6000EC5")]
	public virtual int GetHashCode() { }

}

