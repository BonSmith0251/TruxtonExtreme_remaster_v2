namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001FF")]
public sealed class AsyncPointerUpTrigger : AsyncTriggerBase<PointerEventData>, IPointerUpHandler, IEventSystemHandler
{

	[Address(RVA = "0x277CBC0", Offset = "0x277BFC0", Length = "0x39")]
	[Token(Token = "0x6000BAD")]
	public AsyncPointerUpTrigger() { }

	[Address(RVA = "0x277C970", Offset = "0x277BD70", Length = "0x67")]
	[Token(Token = "0x6000BA9")]
	public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler() { }

	[Address(RVA = "0x277C8F0", Offset = "0x277BCF0", Length = "0x7C")]
	[Token(Token = "0x6000BAA")]
	public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277CAB0", Offset = "0x277BEB0", Length = "0xB0")]
	[Token(Token = "0x6000BAB")]
	public UniTask<PointerEventData> OnPointerUpAsync() { }

	[Address(RVA = "0x277C9E0", Offset = "0x277BDE0", Length = "0xC5")]
	[Token(Token = "0x6000BAC")]
	public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277CB70", Offset = "0x277BF70", Length = "0x48")]
	[Token(Token = "0x6000BA8")]
	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}

