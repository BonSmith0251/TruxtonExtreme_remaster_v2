namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200038D")]
public interface IClientChannelSinkProvider
{

	[Token(Token = "0x17000308")]
	public IClientChannelSinkProvider Next
	{
		[Token(Token = "0x6001C07")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001C07")]
	public void set_Next(IClientChannelSinkProvider value) { }

}

