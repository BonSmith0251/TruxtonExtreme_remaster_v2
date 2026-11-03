namespace UnityEngine.Assertions;

[Token(Token = "0x200032F")]
public class AssertionException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000850")]
	private string m_UserMessage; //Field offset: 0x90

	[Token(Token = "0x170003B6")]
	public virtual string Message
	{
		[Address(RVA = "0x30773A0", Offset = "0x30767A0", Length = "0x58")]
		[Token(Token = "0x60019D8")]
		 get { } //Length: 88
	}

	[Address(RVA = "0x3077320", Offset = "0x3076720", Length = "0x7C")]
	[Token(Token = "0x60019D7")]
	public AssertionException(string message, string userMessage) { }

	[Address(RVA = "0x30773A0", Offset = "0x30767A0", Length = "0x58")]
	[Token(Token = "0x60019D8")]
	public virtual string get_Message() { }

}

