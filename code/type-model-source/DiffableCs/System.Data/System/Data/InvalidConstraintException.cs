namespace System.Data;

[Token(Token = "0x2000012")]
public class InvalidConstraintException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000B2")]
	protected InvalidConstraintException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F110", Offset = "0x230E510", Length = "0x44")]
	[Token(Token = "0x60000B3")]
	public InvalidConstraintException() { }

	[Address(RVA = "0x230F0F0", Offset = "0x230E4F0", Length = "0x1E")]
	[Token(Token = "0x60000B4")]
	public InvalidConstraintException(string s) { }

}

