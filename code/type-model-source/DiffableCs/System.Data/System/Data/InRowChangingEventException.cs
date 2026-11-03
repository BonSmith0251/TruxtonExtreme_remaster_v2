namespace System.Data;

[Token(Token = "0x2000011")]
public class InRowChangingEventException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000AF")]
	protected InRowChangingEventException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F080", Offset = "0x230E480", Length = "0x44")]
	[Token(Token = "0x60000B0")]
	public InRowChangingEventException() { }

	[Address(RVA = "0x230F0D0", Offset = "0x230E4D0", Length = "0x1E")]
	[Token(Token = "0x60000B1")]
	public InRowChangingEventException(string s) { }

}

