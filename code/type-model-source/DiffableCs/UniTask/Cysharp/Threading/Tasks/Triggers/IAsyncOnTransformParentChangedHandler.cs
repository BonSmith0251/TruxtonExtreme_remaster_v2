namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001D0")]
public interface IAsyncOnTransformParentChangedHandler
{

	[Token(Token = "0x6000B06")]
	public UniTask OnTransformParentChangedAsync() { }

}

