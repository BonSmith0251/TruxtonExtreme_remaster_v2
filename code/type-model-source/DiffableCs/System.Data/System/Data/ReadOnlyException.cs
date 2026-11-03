namespace System.Data;

[Token(Token = "0x2000014")]
public class ReadOnlyException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000B8")]
	protected ReadOnlyException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F620", Offset = "0x230EA20", Length = "0x44")]
	[Token(Token = "0x60000B9")]
	public ReadOnlyException() { }

	[Address(RVA = "0x230F670", Offset = "0x230EA70", Length = "0x1E")]
	[Token(Token = "0x60000BA")]
	public ReadOnlyException(string s) { }

}

