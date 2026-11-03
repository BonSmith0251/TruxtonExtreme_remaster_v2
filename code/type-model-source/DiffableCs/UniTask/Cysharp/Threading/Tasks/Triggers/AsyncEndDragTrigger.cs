namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001F1")]
public sealed class AsyncEndDragTrigger : AsyncTriggerBase<PointerEventData>, IEndDragHandler, IEventSystemHandler
{

	[Address(RVA = "0x2776470", Offset = "0x2775870", Length = "0x39")]
	[Token(Token = "0x6000B7C")]
	public AsyncEndDragTrigger() { }

	[Address(RVA = "0x2776220", Offset = "0x2775620", Length = "0x67")]
	[Token(Token = "0x6000B78")]
	public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler() { }

	[Address(RVA = "0x27761A0", Offset = "0x27755A0", Length = "0x7C")]
	[Token(Token = "0x6000B79")]
	public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2776360", Offset = "0x2775760", Length = "0xB0")]
	[Token(Token = "0x6000B7A")]
	public UniTask<PointerEventData> OnEndDragAsync() { }

	[Address(RVA = "0x2776290", Offset = "0x2775690", Length = "0xC5")]
	[Token(Token = "0x6000B7B")]
	public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2776420", Offset = "0x2775820", Length = "0x48")]
	[Token(Token = "0x6000B77")]
	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

}

