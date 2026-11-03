namespace System.Xml.Serialization;

[AttributeUsage(9244)]
[Token(Token = "0x200011D")]
public class XmlRootAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000652")]
	private string dataType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000653")]
	private string elementName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000654")]
	private bool isNullable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000655")]
	private string ns; //Field offset: 0x28

	[Token(Token = "0x17000351")]
	public string DataType
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000CC2")]
		 get { } //Length: 30
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000CC3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000352")]
	public string ElementName
	{
		[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
		[Token(Token = "0x6000CC4")]
		 get { } //Length: 30
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000CC5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000353")]
	public bool IsNullable
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000CC6")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000CC7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000354")]
	public string Namespace
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000CC8")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000CC9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x256AA50", Offset = "0x2569E50", Length = "0xB")]
	[Token(Token = "0x6000CC0")]
	public XmlRootAttribute() { }

	[Address(RVA = "0x256AA60", Offset = "0x2569E60", Length = "0x35")]
	[Token(Token = "0x6000CC1")]
	public XmlRootAttribute(string elementName) { }

	[Address(RVA = "0x256A990", Offset = "0x2569D90", Length = "0xB3")]
	[Token(Token = "0x6000CCA")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000CC2")]
	public string get_DataType() { }

	[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
	[Token(Token = "0x6000CC4")]
	public string get_ElementName() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000CC6")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000CC8")]
	public string get_Namespace() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000CC3")]
	public void set_DataType(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000CC5")]
	public void set_ElementName(string value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000CC7")]
	public void set_IsNullable(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000CC9")]
	public void set_Namespace(string value) { }

}

