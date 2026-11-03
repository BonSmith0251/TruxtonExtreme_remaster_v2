namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000188")]
public interface IAsyncOnBeforeTransformParentChangedHandler
{

	[Token(Token = "0x6000A0A")]
	public UniTask OnBeforeTransformParentChangedAsync() { }

}

