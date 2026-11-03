namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200038C")]
public interface IChannelSender : IChannel
{

	[Token(Token = "0x6001C06")]
	public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { }

}

