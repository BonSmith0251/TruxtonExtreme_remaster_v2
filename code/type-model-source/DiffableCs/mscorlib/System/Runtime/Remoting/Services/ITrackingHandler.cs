namespace System.Runtime.Remoting.Services;

[ComVisible(True)]
[Token(Token = "0x2000364")]
public interface ITrackingHandler
{

	[Token(Token = "0x6001B46")]
	public void DisconnectedObject(object obj) { }

	[Token(Token = "0x6001B47")]
	public void MarshaledObject(object obj, ObjRef or) { }

	[Token(Token = "0x6001B48")]
	public void UnmarshaledObject(object obj, ObjRef or) { }

}

