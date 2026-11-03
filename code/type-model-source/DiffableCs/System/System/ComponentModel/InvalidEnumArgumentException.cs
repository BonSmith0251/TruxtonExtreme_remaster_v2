namespace System.ComponentModel;

[Token(Token = "0x2000155")]
public class InvalidEnumArgumentException : ArgumentException
{

	[Address(RVA = "0x26488C0", Offset = "0x2647CC0", Length = "0xA")]
	[Token(Token = "0x6000854")]
	public InvalidEnumArgumentException() { }

	[Address(RVA = "0x26488D0", Offset = "0x2647CD0", Length = "0x8")]
	[Token(Token = "0x6000855")]
	public InvalidEnumArgumentException(string message) { }

	[Address(RVA = "0x26488E0", Offset = "0x2647CE0", Length = "0xDE")]
	[Token(Token = "0x6000856")]
	public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass) { }

	[Address(RVA = "0x1E8BAA0", Offset = "0x1E8AEA0", Length = "0x1F")]
	[Token(Token = "0x6000857")]
	protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context) { }

}

