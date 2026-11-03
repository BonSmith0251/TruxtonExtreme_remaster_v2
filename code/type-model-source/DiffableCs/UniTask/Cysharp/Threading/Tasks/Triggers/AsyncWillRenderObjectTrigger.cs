namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001E1")]
public sealed class AsyncWillRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2786050", Offset = "0x2785450", Length = "0x39")]
	[Token(Token = "0x6000B44")]
	public AsyncWillRenderObjectTrigger() { }

	[Address(RVA = "0x2785CB0", Offset = "0x27850B0", Length = "0x67")]
	[Token(Token = "0x6000B40")]
	public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler() { }

	[Address(RVA = "0x2785D20", Offset = "0x2785120", Length = "0x7C")]
	[Token(Token = "0x6000B41")]
	public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2785FE0", Offset = "0x27853E0", Length = "0x6E")]
	[Token(Token = "0x6000B3F")]
	private void OnWillRenderObject() { }

	[Address(RVA = "0x2785ED0", Offset = "0x27852D0", Length = "0x10C")]
	[Token(Token = "0x6000B42")]
	public UniTask OnWillRenderObjectAsync() { }

	[Address(RVA = "0x2785DA0", Offset = "0x27851A0", Length = "0x122")]
	[Token(Token = "0x6000B43")]
	public UniTask OnWillRenderObjectAsync(CancellationToken cancellationToken) { }

}

