namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001CE")]
public interface IAsyncOnTransformChildrenChangedHandler
{

	[Token(Token = "0x6000AFF")]
	public UniTask OnTransformChildrenChangedAsync() { }

}

