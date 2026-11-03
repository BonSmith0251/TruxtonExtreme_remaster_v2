namespace System.Xml.Serialization;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000111")]
public class XmlEnumAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000634")]
	private string name; //Field offset: 0x10

	[Token(Token = "0x17000342")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C89")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000C88")]
	public XmlEnumAttribute(string name) { }

	[Address(RVA = "0x2563040", Offset = "0x2562440", Length = "0x76")]
	[Token(Token = "0x6000C8A")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C89")]
	public string get_Name() { }

}

