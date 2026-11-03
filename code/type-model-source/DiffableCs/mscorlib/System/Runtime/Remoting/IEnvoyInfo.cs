namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200034A")]
public interface IEnvoyInfo
{

	[Token(Token = "0x170002BF")]
	public IMessageSink EnvoySinks
	{
		[Token(Token = "0x6001A7A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001A7A")]
	public IMessageSink get_EnvoySinks() { }

}

