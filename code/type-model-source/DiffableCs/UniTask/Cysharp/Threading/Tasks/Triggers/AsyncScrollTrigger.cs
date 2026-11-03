namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000201")]
public sealed class AsyncScrollTrigger : AsyncTriggerBase<PointerEventData>, IScrollHandler, IEventSystemHandler
{

	[Address(RVA = "0x277EE00", Offset = "0x277E200", Length = "0x39")]
	[Token(Token = "0x6000BB4")]
	public AsyncScrollTrigger() { }

	[Address(RVA = "0x277EBB0", Offset = "0x277DFB0", Length = "0x67")]
	[Token(Token = "0x6000BB0")]
	public IAsyncOnScrollHandler GetOnScrollAsyncHandler() { }

	[Address(RVA = "0x277EB30", Offset = "0x277DF30", Length = "0x7C")]
	[Token(Token = "0x6000BB1")]
	public IAsyncOnScrollHandler GetOnScrollAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277ECF0", Offset = "0x277E0F0", Length = "0xB0")]
	[Token(Token = "0x6000BB2")]
	public UniTask<PointerEventData> OnScrollAsync() { }

	[Address(RVA = "0x277EC20", Offset = "0x277E020", Length = "0xC5")]
	[Token(Token = "0x6000BB3")]
	public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277EDB0", Offset = "0x277E1B0", Length = "0x48")]
	[Token(Token = "0x6000BAF")]
	private override void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData) { }

}

