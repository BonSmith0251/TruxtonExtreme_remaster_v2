namespace System.ComponentModel;

[Token(Token = "0x2000154")]
public interface ISynchronizeInvoke
{

	[Token(Token = "0x1700018D")]
	public bool InvokeRequired
	{
		[Token(Token = "0x6000852")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000853")]
	public IAsyncResult BeginInvoke(Delegate method, Object[] args) { }

	[Token(Token = "0x6000852")]
	public bool get_InvokeRequired() { }

}

