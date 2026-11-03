namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200038F")]
public interface IServerChannelSinkProvider
{

	[Token(Token = "0x1700030A")]
	public IServerChannelSinkProvider Next
	{
		[Token(Token = "0x6001C09")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001C09")]
	public void set_Next(IServerChannelSinkProvider value) { }

}

