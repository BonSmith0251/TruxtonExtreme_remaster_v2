namespace System;

[Token(Token = "0x200016A")]
public class MissingFieldException : MissingMemberException, ISerializable
{

	[Token(Token = "0x17000107")]
	public virtual string Message
	{
		[Address(RVA = "0x2043030", Offset = "0x2042430", Length = "0x1B7")]
		[Token(Token = "0x6000C9F")]
		 get { } //Length: 439
	}

	[Address(RVA = "0x2042F30", Offset = "0x2042330", Length = "0x44")]
	[Token(Token = "0x6000C9B")]
	public MissingFieldException() { }

	[Address(RVA = "0x2043010", Offset = "0x2042410", Length = "0x1E")]
	[Token(Token = "0x6000C9C")]
	public MissingFieldException(string message) { }

	[Address(RVA = "0x2042F80", Offset = "0x2042380", Length = "0x88")]
	[Token(Token = "0x6000C9D")]
	public MissingFieldException(string className, string fieldName) { }

	[Address(RVA = "0x202CC10", Offset = "0x202C010", Length = "0x1F")]
	[Token(Token = "0x6000C9E")]
	protected MissingFieldException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2043030", Offset = "0x2042430", Length = "0x1B7")]
	[Token(Token = "0x6000C9F")]
	public virtual string get_Message() { }

}

