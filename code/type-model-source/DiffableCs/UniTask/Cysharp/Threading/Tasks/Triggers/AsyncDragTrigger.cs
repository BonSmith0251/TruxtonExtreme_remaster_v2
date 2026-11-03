namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001ED")]
public sealed class AsyncDragTrigger : AsyncTriggerBase<PointerEventData>, IDragHandler, IEventSystemHandler
{

	[Address(RVA = "0x27752B0", Offset = "0x27746B0", Length = "0x39")]
	[Token(Token = "0x6000B6E")]
	public AsyncDragTrigger() { }

	[Address(RVA = "0x2775060", Offset = "0x2774460", Length = "0x67")]
	[Token(Token = "0x6000B6A")]
	public IAsyncOnDragHandler GetOnDragAsyncHandler() { }

	[Address(RVA = "0x2774FE0", Offset = "0x27743E0", Length = "0x7C")]
	[Token(Token = "0x6000B6B")]
	public IAsyncOnDragHandler GetOnDragAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27751A0", Offset = "0x27745A0", Length = "0xB0")]
	[Token(Token = "0x6000B6C")]
	public UniTask<PointerEventData> OnDragAsync() { }

	[Address(RVA = "0x27750D0", Offset = "0x27744D0", Length = "0xC5")]
	[Token(Token = "0x6000B6D")]
	public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2775260", Offset = "0x2774660", Length = "0x48")]
	[Token(Token = "0x6000B69")]
	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

}

