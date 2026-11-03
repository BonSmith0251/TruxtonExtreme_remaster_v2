namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001FB")]
public sealed class AsyncPointerEnterTrigger : AsyncTriggerBase<PointerEventData>, IPointerEnterHandler, IEventSystemHandler
{

	[Address(RVA = "0x277C5A0", Offset = "0x277B9A0", Length = "0x39")]
	[Token(Token = "0x6000B9F")]
	public AsyncPointerEnterTrigger() { }

	[Address(RVA = "0x277C2D0", Offset = "0x277B6D0", Length = "0x67")]
	[Token(Token = "0x6000B9B")]
	public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler() { }

	[Address(RVA = "0x277C340", Offset = "0x277B740", Length = "0x7C")]
	[Token(Token = "0x6000B9C")]
	public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C490", Offset = "0x277B890", Length = "0xB0")]
	[Token(Token = "0x6000B9D")]
	public UniTask<PointerEventData> OnPointerEnterAsync() { }

	[Address(RVA = "0x277C3C0", Offset = "0x277B7C0", Length = "0xC5")]
	[Token(Token = "0x6000B9E")]
	public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C550", Offset = "0x277B950", Length = "0x48")]
	[Token(Token = "0x6000B9A")]
	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

}

