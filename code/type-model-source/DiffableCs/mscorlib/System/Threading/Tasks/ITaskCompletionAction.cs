namespace System.Threading.Tasks;

[Token(Token = "0x2000275")]
internal interface ITaskCompletionAction
{

	[Token(Token = "0x170001F5")]
	public bool InvokeMayRunArbitraryCode
	{
		[Token(Token = "0x60014B3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60014B3")]
	public bool get_InvokeMayRunArbitraryCode() { }

	[Token(Token = "0x60014B2")]
	public void Invoke(Task completingTask) { }

}

