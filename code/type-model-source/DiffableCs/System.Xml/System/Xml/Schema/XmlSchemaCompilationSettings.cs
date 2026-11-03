namespace System.Xml.Schema;

[Token(Token = "0x2000205")]
public sealed class XmlSchemaCompilationSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B18")]
	private bool enableUpaCheck; //Field offset: 0x10

	[Token(Token = "0x1700059D")]
	public bool EnableUpaCheck
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60014CA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21890D0", Offset = "0x21884D0", Length = "0x1A")]
	[Token(Token = "0x60014C9")]
	public XmlSchemaCompilationSettings() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60014CA")]
	public bool get_EnableUpaCheck() { }

}

