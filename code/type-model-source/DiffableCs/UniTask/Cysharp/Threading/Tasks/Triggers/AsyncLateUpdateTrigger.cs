namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000177")]
public sealed class AsyncLateUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2778340", Offset = "0x2777740", Length = "0x39")]
	[Token(Token = "0x60009D1")]
	public AsyncLateUpdateTrigger() { }

	[Address(RVA = "0x2777FA0", Offset = "0x27773A0", Length = "0x67")]
	[Token(Token = "0x60009CD")]
	public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler() { }

	[Address(RVA = "0x2778010", Offset = "0x2777410", Length = "0x7C")]
	[Token(Token = "0x60009CE")]
	public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27782D0", Offset = "0x27776D0", Length = "0x6E")]
	[Token(Token = "0x60009CC")]
	private void LateUpdate() { }

	[Address(RVA = "0x2778090", Offset = "0x2777490", Length = "0x10C")]
	[Token(Token = "0x60009CF")]
	public UniTask LateUpdateAsync() { }

	[Address(RVA = "0x27781A0", Offset = "0x27775A0", Length = "0x122")]
	[Token(Token = "0x60009D0")]
	public UniTask LateUpdateAsync(CancellationToken cancellationToken) { }

}

