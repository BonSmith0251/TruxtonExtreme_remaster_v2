namespace System.Xml.Serialization;

[AttributeUsage(1100, AllowMultiple = True)]
[Token(Token = "0x2000113")]
public class XmlIncludeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000635")]
	private Type type; //Field offset: 0x10

	[Token(Token = "0x17000343")]
	public Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C8C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C8C")]
	public Type get_Type() { }

}

