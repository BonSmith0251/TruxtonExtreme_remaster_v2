namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200037A")]
public interface IContextProperty
{

	[Token(Token = "0x170002FC")]
	public string Name
	{
		[Token(Token = "0x6001BD0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001BD1")]
	public void Freeze(Context newContext) { }

	[Token(Token = "0x6001BD0")]
	public string get_Name() { }

	[Token(Token = "0x6001BD2")]
	public bool IsNewContextOK(Context newCtx) { }

}

