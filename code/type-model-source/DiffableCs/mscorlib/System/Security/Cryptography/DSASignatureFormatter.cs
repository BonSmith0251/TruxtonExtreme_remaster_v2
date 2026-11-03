namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FC")]
public class DSASignatureFormatter : AsymmetricSignatureFormatter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CDF")]
	private string _oid; //Field offset: 0x10

	[Address(RVA = "0x1EB7C60", Offset = "0x1EB7060", Length = "0x73")]
	[Token(Token = "0x6001880")]
	public DSASignatureFormatter() { }

}

