namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001C8")]
public interface IAsyncOnRenderImageHandler
{

	[Token(Token = "0x6000AEA")]
	public UniTask<ValueTuple`2<RenderTexture, RenderTexture>> OnRenderImageAsync() { }

}

