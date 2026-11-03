namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001D1")]
public sealed class AsyncTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x27801E0", Offset = "0x277F5E0", Length = "0x39")]
	[Token(Token = "0x6000B0C")]
	public AsyncTransformParentChangedTrigger() { }

	[Address(RVA = "0x277FE40", Offset = "0x277F240", Length = "0x67")]
	[Token(Token = "0x6000B08")]
	public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler() { }

	[Address(RVA = "0x277FEB0", Offset = "0x277F2B0", Length = "0x7C")]
	[Token(Token = "0x6000B09")]
	public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2780170", Offset = "0x277F570", Length = "0x6E")]
	[Token(Token = "0x6000B07")]
	private void OnTransformParentChanged() { }

	[Address(RVA = "0x277FF30", Offset = "0x277F330", Length = "0x10C")]
	[Token(Token = "0x6000B0A")]
	public UniTask OnTransformParentChangedAsync() { }

	[Address(RVA = "0x2780040", Offset = "0x277F440", Length = "0x122")]
	[Token(Token = "0x6000B0B")]
	public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken) { }

}

