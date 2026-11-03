namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003BA")]
public interface IMessageSink
{

	[Token(Token = "0x6001CCF")]
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Token(Token = "0x6001CCE")]
	public IMessage SyncProcessMessage(IMessage msg) { }

}

