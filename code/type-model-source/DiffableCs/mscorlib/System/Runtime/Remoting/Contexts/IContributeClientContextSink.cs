namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200037B")]
public interface IContributeClientContextSink
{

	[Token(Token = "0x6001BD3")]
	public IMessageSink GetClientContextSink(IMessageSink nextSink) { }

}

