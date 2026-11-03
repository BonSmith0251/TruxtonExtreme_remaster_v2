namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023D")]
internal interface IStateMachineRunner
{

	[Token(Token = "0x1700007C")]
	public Action MoveNext
	{
		[Token(Token = "0x6000CCF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007D")]
	public Action ReturnAction
	{
		[Token(Token = "0x6000CD1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000CCF")]
	public Action get_MoveNext() { }

	[Token(Token = "0x6000CD1")]
	public Action get_ReturnAction() { }

	[Token(Token = "0x6000CD0")]
	public void Return() { }

}

