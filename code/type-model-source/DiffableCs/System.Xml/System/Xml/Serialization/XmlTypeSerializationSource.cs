namespace System.Xml.Serialization;

[Token(Token = "0x20000FF")]
internal class XmlTypeSerializationSource : SerializationSource
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005F0")]
	private string attributeOverridesHash; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F1")]
	private Type type; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F2")]
	private string rootHash; //Field offset: 0x38

	[Address(RVA = "0x255DF00", Offset = "0x255D300", Length = "0x157")]
	[Token(Token = "0x6000C07")]
	public XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	[Address(RVA = "0x255DD20", Offset = "0x255D120", Length = "0x1AD")]
	[Token(Token = "0x6000C08")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x255DED0", Offset = "0x255D2D0", Length = "0x2A")]
	[Token(Token = "0x6000C09")]
	public virtual int GetHashCode() { }

}

