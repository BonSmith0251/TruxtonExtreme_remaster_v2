namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200037F")]
public interface IContributeServerContextSink
{

	[Token(Token = "0x6001BD7")]
	public IMessageSink GetServerContextSink(IMessageSink nextSink) { }

}

