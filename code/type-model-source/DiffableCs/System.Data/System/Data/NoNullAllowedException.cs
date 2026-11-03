namespace System.Data;

[Token(Token = "0x2000013")]
public class NoNullAllowedException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000B5")]
	protected NoNullAllowedException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F550", Offset = "0x230E950", Length = "0x44")]
	[Token(Token = "0x60000B6")]
	public NoNullAllowedException() { }

	[Address(RVA = "0x230F530", Offset = "0x230E930", Length = "0x1E")]
	[Token(Token = "0x60000B7")]
	public NoNullAllowedException(string s) { }

}

