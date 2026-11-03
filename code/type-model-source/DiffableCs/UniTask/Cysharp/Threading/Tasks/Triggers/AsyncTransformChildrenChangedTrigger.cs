namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001CF")]
public sealed class AsyncTransformChildrenChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277FE00", Offset = "0x277F200", Length = "0x39")]
	[Token(Token = "0x6000B05")]
	public AsyncTransformChildrenChangedTrigger() { }

	[Address(RVA = "0x277FA60", Offset = "0x277EE60", Length = "0x67")]
	[Token(Token = "0x6000B01")]
	public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler() { }

	[Address(RVA = "0x277FAD0", Offset = "0x277EED0", Length = "0x7C")]
	[Token(Token = "0x6000B02")]
	public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277FD90", Offset = "0x277F190", Length = "0x6E")]
	[Token(Token = "0x6000B00")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x277FC80", Offset = "0x277F080", Length = "0x10C")]
	[Token(Token = "0x6000B03")]
	public UniTask OnTransformChildrenChangedAsync() { }

	[Address(RVA = "0x277FB50", Offset = "0x277EF50", Length = "0x122")]
	[Token(Token = "0x6000B04")]
	public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken) { }

}

