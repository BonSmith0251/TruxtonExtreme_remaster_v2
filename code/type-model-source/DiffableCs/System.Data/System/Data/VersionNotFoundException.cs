namespace System.Data;

[Token(Token = "0x2000016")]
public class VersionNotFoundException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000BE")]
	protected VersionNotFoundException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F9A0", Offset = "0x230EDA0", Length = "0x44")]
	[Token(Token = "0x60000BF")]
	public VersionNotFoundException() { }

	[Address(RVA = "0x230F9F0", Offset = "0x230EDF0", Length = "0x74")]
	[Token(Token = "0x60000C0")]
	public VersionNotFoundException(string s) { }

}

