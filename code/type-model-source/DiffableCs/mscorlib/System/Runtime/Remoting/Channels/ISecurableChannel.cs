namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x200038E")]
public interface ISecurableChannel
{

	[Token(Token = "0x17000309")]
	public bool IsSecured
	{
		[Token(Token = "0x6001C08")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001C08")]
	public void set_IsSecured(bool value) { }

}

