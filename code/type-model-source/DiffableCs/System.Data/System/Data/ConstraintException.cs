namespace System.Data;

[Token(Token = "0x200000E")]
public class ConstraintException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000A6")]
	protected ConstraintException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22ED840", Offset = "0x22ECC40", Length = "0x44")]
	[Token(Token = "0x60000A7")]
	public ConstraintException() { }

	[Address(RVA = "0x22ED890", Offset = "0x22ECC90", Length = "0x1E")]
	[Token(Token = "0x60000A8")]
	public ConstraintException(string s) { }

}

