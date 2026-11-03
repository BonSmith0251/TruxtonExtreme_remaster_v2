namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200037D")]
public interface IContributeEnvoySink
{

	[Token(Token = "0x6001BD5")]
	public IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

