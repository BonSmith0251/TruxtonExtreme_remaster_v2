namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001F4")]
public interface IAsyncOnMoveHandler
{

	[Token(Token = "0x6000B84")]
	public UniTask<AxisEventData> OnMoveAsync() { }

}

