namespace System.Xml.Schema;

[Token(Token = "0x200022F")]
public class XmlSchemaNotation : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B9B")]
	private string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B9C")]
	private string publicId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B9D")]
	private string systemId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B9E")]
	private XmlQualifiedName qname; //Field offset: 0x68

	[Token(Token = "0x17000610")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015E6")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015E7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000614")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015EE")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015EF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000611")]
	[XmlAttribute("public")]
	public string Public
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60015E8")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60015E9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000613")]
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60015EC")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60015ED")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000612")]
	[XmlAttribute("system")]
	public string System
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60015EA")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60015EB")]
		 set { } //Length: 995
	}

	[Address(RVA = "0x248F560", Offset = "0x248E960", Length = "0x6B")]
	[Token(Token = "0x60015F0")]
	public XmlSchemaNotation() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015E6")]
	public string get_Name() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015EE")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60015E8")]
	public string get_Public() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60015EC")]
	internal XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60015EA")]
	public string get_System() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015E7")]
	public void set_Name(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015EF")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60015E9")]
	public void set_Public(string value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60015ED")]
	internal void set_QualifiedName(XmlQualifiedName value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60015EB")]
	public void set_System(string value) { }

}

