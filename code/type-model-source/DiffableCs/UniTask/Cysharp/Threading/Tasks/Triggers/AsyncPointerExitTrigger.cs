namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001FD")]
public sealed class AsyncPointerExitTrigger : AsyncTriggerBase<PointerEventData>, IPointerExitHandler, IEventSystemHandler
{

	[Address(RVA = "0x277C8B0", Offset = "0x277BCB0", Length = "0x39")]
	[Token(Token = "0x6000BA6")]
	public AsyncPointerExitTrigger() { }

	[Address(RVA = "0x277C660", Offset = "0x277BA60", Length = "0x67")]
	[Token(Token = "0x6000BA2")]
	public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler() { }

	[Address(RVA = "0x277C5E0", Offset = "0x277B9E0", Length = "0x7C")]
	[Token(Token = "0x6000BA3")]
	public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C6D0", Offset = "0x277BAD0", Length = "0xB0")]
	[Token(Token = "0x6000BA4")]
	public UniTask<PointerEventData> OnPointerExitAsync() { }

	[Address(RVA = "0x277C790", Offset = "0x277BB90", Length = "0xC5")]
	[Token(Token = "0x6000BA5")]
	public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277C860", Offset = "0x277BC60", Length = "0x48")]
	[Token(Token = "0x6000BA1")]
	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

