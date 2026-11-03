namespace System.Xml.Serialization;

[DefaultMember("Item")]
[Token(Token = "0x200010B")]
public class XmlAttributeOverrides
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061C")]
	private Hashtable overrides; //Field offset: 0x10

	[Token(Token = "0x17000327")]
	public XmlAttributes Item
	{
		[Address(RVA = "0x255F4B0", Offset = "0x255E8B0", Length = "0x19")]
		[Token(Token = "0x6000C59")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000328")]
	public XmlAttributes Item
	{
		[Address(RVA = "0x255F4D0", Offset = "0x255E8D0", Length = "0xF1")]
		[Token(Token = "0x6000C5A")]
		 get { } //Length: 241
	}

	[Address(RVA = "0x255F440", Offset = "0x255E840", Length = "0x66")]
	[Token(Token = "0x6000C58")]
	public XmlAttributeOverrides() { }

	[Address(RVA = "0x255EFD0", Offset = "0x255E3D0", Length = "0x3F5")]
	[Token(Token = "0x6000C5C")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x255F4B0", Offset = "0x255E8B0", Length = "0x19")]
	[Token(Token = "0x6000C59")]
	public XmlAttributes get_Item(Type type) { }

	[Address(RVA = "0x255F4D0", Offset = "0x255E8D0", Length = "0xF1")]
	[Token(Token = "0x6000C5A")]
	public XmlAttributes get_Item(Type type, string member) { }

	[Address(RVA = "0x255F3D0", Offset = "0x255E7D0", Length = "0x64")]
	[Token(Token = "0x6000C5B")]
	private TypeMember GetKey(Type type, string member) { }

}

