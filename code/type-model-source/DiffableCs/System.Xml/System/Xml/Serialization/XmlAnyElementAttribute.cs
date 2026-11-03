namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
[Token(Token = "0x2000105")]
public class XmlAnyElementAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000607")]
	private string elementName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000608")]
	private string ns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000609")]
	private int order; //Field offset: 0x20

	[Token(Token = "0x17000310")]
	public string Name
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C32")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000311")]
	public string Namespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C33")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000312")]
	public int Order
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C34")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x254F970", Offset = "0x254ED70", Length = "0xE")]
	[Token(Token = "0x6000C31")]
	public XmlAnyElementAttribute() { }

	[Address(RVA = "0x254F790", Offset = "0x254EB90", Length = "0x1DE")]
	[Token(Token = "0x6000C35")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C32")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C33")]
	public string get_Namespace() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C34")]
	public int get_Order() { }

}

