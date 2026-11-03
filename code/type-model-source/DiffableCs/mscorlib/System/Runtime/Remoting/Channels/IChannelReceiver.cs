namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200038B")]
public interface IChannelReceiver : IChannel
{

	[Token(Token = "0x17000307")]
	public object ChannelData
	{
		[Token(Token = "0x6001C04")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C04")]
	public object get_ChannelData() { }

	[Token(Token = "0x6001C05")]
	public void StartListening(object data) { }

}

