namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001F9")]
public sealed class AsyncPointerDownTrigger : AsyncTriggerBase<PointerEventData>, IPointerDownHandler, IEventSystemHandler
{

	[Address(RVA = "0x277C290", Offset = "0x277B690", Length = "0x39")]
	[Token(Token = "0x6000B98")]
	public AsyncPointerDownTrigger() { }

	[Address(RVA = "0x277BFC0", Offset = "0x277B3C0", Length = "0x67")]
	[Token(Token = "0x6000B94")]
	public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler() { }

	[Address(RVA = "0x277C030", Offset = "0x277B430", Length = "0x7C")]
	[Token(Token = "0x6000B95")]
	public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C0B0", Offset = "0x277B4B0", Length = "0xB0")]
	[Token(Token = "0x6000B96")]
	public UniTask<PointerEventData> OnPointerDownAsync() { }

	[Address(RVA = "0x277C170", Offset = "0x277B570", Length = "0xC5")]
	[Token(Token = "0x6000B97")]
	public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C240", Offset = "0x277B640", Length = "0x48")]
	[Token(Token = "0x6000B93")]
	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

}

