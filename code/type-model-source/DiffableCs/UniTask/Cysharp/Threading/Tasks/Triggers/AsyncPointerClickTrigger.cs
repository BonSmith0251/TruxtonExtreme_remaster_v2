namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001F7")]
public sealed class AsyncPointerClickTrigger : AsyncTriggerBase<PointerEventData>, IPointerClickHandler, IEventSystemHandler
{

	[Address(RVA = "0x277BF80", Offset = "0x277B380", Length = "0x39")]
	[Token(Token = "0x6000B91")]
	public AsyncPointerClickTrigger() { }

	[Address(RVA = "0x277BD30", Offset = "0x277B130", Length = "0x67")]
	[Token(Token = "0x6000B8D")]
	public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler() { }

	[Address(RVA = "0x277BCB0", Offset = "0x277B0B0", Length = "0x7C")]
	[Token(Token = "0x6000B8E")]
	public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277BE70", Offset = "0x277B270", Length = "0xB0")]
	[Token(Token = "0x6000B8F")]
	public UniTask<PointerEventData> OnPointerClickAsync() { }

	[Address(RVA = "0x277BDA0", Offset = "0x277B1A0", Length = "0xC5")]
	[Token(Token = "0x6000B90")]
	public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277BF30", Offset = "0x277B330", Length = "0x48")]
	[Token(Token = "0x6000B8C")]
	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

}

