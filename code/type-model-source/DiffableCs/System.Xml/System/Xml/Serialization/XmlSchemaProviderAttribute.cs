namespace System.Xml.Serialization;

[AttributeUsage(1036)]
[Token(Token = "0x200011E")]
public sealed class XmlSchemaProviderAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000656")]
	private string _methodName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000657")]
	private bool _isAny; //Field offset: 0x18

	[Token(Token = "0x17000356")]
	public bool IsAny
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000CCD")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6000CCE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000355")]
	public string MethodName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000CCB")]
	public XmlSchemaProviderAttribute(string methodName) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000CCD")]
	public bool get_IsAny() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CCC")]
	public string get_MethodName() { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6000CCE")]
	public void set_IsAny(bool value) { }

}

