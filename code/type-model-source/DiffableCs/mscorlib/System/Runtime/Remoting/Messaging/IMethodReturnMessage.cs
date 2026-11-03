namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003BD")]
public interface IMethodReturnMessage : IMethodMessage, IMessage
{

	[Token(Token = "0x17000357")]
	public Exception Exception
	{
		[Token(Token = "0x6001CD9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000358")]
	public Object[] OutArgs
	{
		[Token(Token = "0x6001CDA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000359")]
	public object ReturnValue
	{
		[Token(Token = "0x6001CDB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001CD9")]
	public Exception get_Exception() { }

	[Token(Token = "0x6001CDA")]
	public Object[] get_OutArgs() { }

	[Token(Token = "0x6001CDB")]
	public object get_ReturnValue() { }

}

