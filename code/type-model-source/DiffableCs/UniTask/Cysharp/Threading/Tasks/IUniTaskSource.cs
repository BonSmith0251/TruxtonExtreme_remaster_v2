namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200003A")]
public interface IUniTaskSource
{

	[Token(Token = "0x6000121")]
	public void GetResult(short token) { }

	[Token(Token = "0x600011F")]
	public UniTaskStatus GetStatus(short token) { }

	[Token(Token = "0x6000120")]
	public void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Token(Token = "0x6000122")]
	public UniTaskStatus UnsafeGetStatus() { }

}

