namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001DA")]
public interface IAsyncOnTriggerStayHandler
{

	[Token(Token = "0x6000B29")]
	public UniTask<Collider> OnTriggerStayAsync() { }

}

