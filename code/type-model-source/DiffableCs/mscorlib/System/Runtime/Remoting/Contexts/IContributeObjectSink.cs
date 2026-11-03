namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200037E")]
public interface IContributeObjectSink
{

	[Token(Token = "0x6001BD6")]
	public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

