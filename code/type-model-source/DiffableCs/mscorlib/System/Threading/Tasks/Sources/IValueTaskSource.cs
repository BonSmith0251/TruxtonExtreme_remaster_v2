namespace System.Threading.Tasks.Sources;

[Token(Token = "0x2000293")]
public interface IValueTaskSource
{

	[Token(Token = "0x6001529")]
	public void GetResult(short token) { }

	[Token(Token = "0x6001527")]
	public ValueTaskSourceStatus GetStatus(short token) { }

	[Token(Token = "0x6001528")]
	public void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

}

