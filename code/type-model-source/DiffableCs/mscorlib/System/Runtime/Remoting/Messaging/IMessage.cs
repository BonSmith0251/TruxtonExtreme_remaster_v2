namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003B8")]
public interface IMessage
{

	[Token(Token = "0x1700034E")]
	public IDictionary Properties
	{
		[Token(Token = "0x6001CCD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001CCD")]
	public IDictionary get_Properties() { }

}

