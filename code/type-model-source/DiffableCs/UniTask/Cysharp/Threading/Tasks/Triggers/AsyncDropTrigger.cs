namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001EF")]
public sealed class AsyncDropTrigger : AsyncTriggerBase<PointerEventData>, IDropHandler, IEventSystemHandler
{

	[Address(RVA = "0x2775D80", Offset = "0x2775180", Length = "0x39")]
	[Token(Token = "0x6000B75")]
	public AsyncDropTrigger() { }

	[Address(RVA = "0x2775AB0", Offset = "0x2774EB0", Length = "0x67")]
	[Token(Token = "0x6000B71")]
	public IAsyncOnDropHandler GetOnDropAsyncHandler() { }

	[Address(RVA = "0x2775B20", Offset = "0x2774F20", Length = "0x7C")]
	[Token(Token = "0x6000B72")]
	public IAsyncOnDropHandler GetOnDropAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2775BA0", Offset = "0x2774FA0", Length = "0xB0")]
	[Token(Token = "0x6000B73")]
	public UniTask<PointerEventData> OnDropAsync() { }

	[Address(RVA = "0x2775C60", Offset = "0x2775060", Length = "0xC5")]
	[Token(Token = "0x6000B74")]
	public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2775D30", Offset = "0x2775130", Length = "0x48")]
	[Token(Token = "0x6000B70")]
	private override void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

}

