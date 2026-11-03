namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023E")]
internal interface IStateMachineRunnerPromise : IUniTaskSource
{

	[Token(Token = "0x1700007E")]
	public Action MoveNext
	{
		[Token(Token = "0x6000CD2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007F")]
	public UniTask Task
	{
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000CD2")]
	public Action get_MoveNext() { }

	[Token(Token = "0x6000CD3")]
	public UniTask get_Task() { }

	[Token(Token = "0x6000CD5")]
	public void SetException(Exception exception) { }

	[Token(Token = "0x6000CD4")]
	public void SetResult() { }

}

