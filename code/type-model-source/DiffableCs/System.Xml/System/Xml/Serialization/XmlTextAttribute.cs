namespace System.Xml.Serialization;

[AttributeUsage(10624)]
[Token(Token = "0x2000134")]
public class XmlTextAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A9")]
	private string dataType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006AA")]
	private Type type; //Field offset: 0x18

	[Token(Token = "0x17000366")]
	public string DataType
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000DAF")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000367")]
	public Type Type
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000DB0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000DAE")]
	public XmlTextAttribute() { }

	[Address(RVA = "0x2591BB0", Offset = "0x2590FB0", Length = "0x8A")]
	[Token(Token = "0x6000DB1")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000DAF")]
	public string get_DataType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000DB0")]
	public Type get_Type() { }

}

