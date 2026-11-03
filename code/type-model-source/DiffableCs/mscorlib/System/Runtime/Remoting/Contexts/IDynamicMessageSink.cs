namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000380")]
public interface IDynamicMessageSink
{

	[Token(Token = "0x6001BD8")]
	public void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync) { }

	[Token(Token = "0x6001BD9")]
	public void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync) { }

}

