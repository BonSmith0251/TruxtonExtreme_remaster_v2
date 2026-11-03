namespace System.Xml.Serialization;

[AttributeUsage(1052)]
[Token(Token = "0x2000135")]
public class XmlTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AB")]
	private bool includeInSchema; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006AC")]
	private string ns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006AD")]
	private string typeName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006AE")]
	private bool anonymousType; //Field offset: 0x28

	[Token(Token = "0x17000368")]
	public bool AnonymousType
	{
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000DB3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000369")]
	public bool IncludeInSchema
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000DB4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036A")]
	public string Namespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000DB5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700036B")]
	public string TypeName
	{
		[Address(RVA = "0x2591CF0", Offset = "0x25910F0", Length = "0x1E")]
		[Token(Token = "0x6000DB6")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2591CE0", Offset = "0x25910E0", Length = "0xB")]
	[Token(Token = "0x6000DB2")]
	public XmlTypeAttribute() { }

	[Address(RVA = "0x2591C40", Offset = "0x2591040", Length = "0x9F")]
	[Token(Token = "0x6000DB7")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000DB4")]
	public bool get_IncludeInSchema() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000DB5")]
	public string get_Namespace() { }

	[Address(RVA = "0x2591CF0", Offset = "0x25910F0", Length = "0x1E")]
	[Token(Token = "0x6000DB6")]
	public string get_TypeName() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000DB3")]
	public void set_AnonymousType(bool value) { }

}

