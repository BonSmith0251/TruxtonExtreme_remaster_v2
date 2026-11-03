namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023F")]
internal interface IStateMachineRunnerPromise : IUniTaskSource<T>, IUniTaskSource
{

	[Token(Token = "0x17000080")]
	public Action MoveNext
	{
		[Token(Token = "0x6000CD6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000081")]
	public UniTask<T> Task
	{
		[Token(Token = "0x6000CD7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000CD6")]
	public Action get_MoveNext() { }

	[Token(Token = "0x6000CD7")]
	public UniTask<T> get_Task() { }

	[Token(Token = "0x6000CD9")]
	public void SetException(Exception exception) { }

	[Token(Token = "0x6000CD8")]
	public void SetResult(T result) { }

}

