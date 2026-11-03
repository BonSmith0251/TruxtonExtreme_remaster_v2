namespace System.ComponentModel.Design;

[Token(Token = "0x20001C6")]
public class CheckoutException : ExternalException
{
	[Token(Token = "0x40006E4")]
	public static readonly CheckoutException Canceled; //Field offset: 0x0

	[Address(RVA = "0x2679C60", Offset = "0x2679060", Length = "0x81")]
	[Token(Token = "0x6000B74")]
	private static CheckoutException() { }

	[Address(RVA = "0x2679CF0", Offset = "0x26790F0", Length = "0x7")]
	[Token(Token = "0x6000B71")]
	public CheckoutException() { }

	[Address(RVA = "0x2679D00", Offset = "0x2679100", Length = "0x8")]
	[Token(Token = "0x6000B72")]
	public CheckoutException(string message, int errorCode) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x6000B73")]
	protected CheckoutException(SerializationInfo info, StreamingContext context) { }

}

