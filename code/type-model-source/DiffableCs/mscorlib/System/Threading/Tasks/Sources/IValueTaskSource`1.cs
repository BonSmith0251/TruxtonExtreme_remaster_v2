namespace System.Threading.Tasks.Sources;

[Token(Token = "0x2000294")]
public interface IValueTaskSource
{

	[Token(Token = "0x600152C")]
	public TResult GetResult(short token) { }

	[Token(Token = "0x600152A")]
	public ValueTaskSourceStatus GetStatus(short token) { }

	[Token(Token = "0x600152B")]
	public void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

