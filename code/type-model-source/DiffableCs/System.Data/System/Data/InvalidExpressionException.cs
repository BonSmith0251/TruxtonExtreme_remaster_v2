namespace System.Data;

[Token(Token = "0x2000067")]
public class InvalidExpressionException : DataException
{

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x60005C1")]
	protected InvalidExpressionException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x23392E0", Offset = "0x23386E0", Length = "0x7")]
	[Token(Token = "0x60005C2")]
	public InvalidExpressionException() { }

	[Address(RVA = "0x23392F0", Offset = "0x23386F0", Length = "0x8")]
	[Token(Token = "0x60005C3")]
	public InvalidExpressionException(string s) { }

}

