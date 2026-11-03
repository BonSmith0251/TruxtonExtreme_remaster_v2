namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
[Token(Token = "0x2000107")]
public class XmlArrayAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060A")]
	private string elementName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060B")]
	private XmlSchemaForm form; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400060C")]
	private bool isNullable; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400060D")]
	private string ns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400060E")]
	private int order; //Field offset: 0x28

	[Token(Token = "0x17000315")]
	public string ElementName
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C3B")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000316")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C3C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000317")]
	public bool IsNullable
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x6000C3D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000318")]
	public string Namespace
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C3E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000319")]
	public int Order
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000C3F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x255E7E0", Offset = "0x255DBE0", Length = "0x12A")]
	[Token(Token = "0x6000C40")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C3B")]
	public string get_ElementName() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C3C")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x6000C3D")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C3E")]
	public string get_Namespace() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000C3F")]
	public int get_Order() { }

}

