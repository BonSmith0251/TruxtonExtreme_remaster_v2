namespace System;

[Token(Token = "0x2000114")]
public class MissingMethodException : MissingMemberException
{

	[Token(Token = "0x1700008D")]
	public virtual string Message
	{
		[Address(RVA = "0x202CCA0", Offset = "0x202C0A0", Length = "0xEC")]
		[Token(Token = "0x60008C9")]
		 get { } //Length: 236
	}

	[Address(RVA = "0x202CC30", Offset = "0x202C030", Length = "0x44")]
	[Token(Token = "0x60008C5")]
	public MissingMethodException() { }

	[Address(RVA = "0x202CC80", Offset = "0x202C080", Length = "0x1E")]
	[Token(Token = "0x60008C6")]
	public MissingMethodException(string message) { }

	[Address(RVA = "0x202CBB0", Offset = "0x202BFB0", Length = "0x5A")]
	[Token(Token = "0x60008C7")]
	public MissingMethodException(string className, string methodName) { }

	[Address(RVA = "0x202CC10", Offset = "0x202C010", Length = "0x1F")]
	[Token(Token = "0x60008C8")]
	protected MissingMethodException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x202CCA0", Offset = "0x202C0A0", Length = "0xEC")]
	[Token(Token = "0x60008C9")]
	public virtual string get_Message() { }

}

