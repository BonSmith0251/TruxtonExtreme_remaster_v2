namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000203")]
public sealed class AsyncSelectTrigger : AsyncTriggerBase<BaseEventData>, ISelectHandler, IEventSystemHandler
{

	[Address(RVA = "0x277F110", Offset = "0x277E510", Length = "0x39")]
	[Token(Token = "0x6000BBB")]
	public AsyncSelectTrigger() { }

	[Address(RVA = "0x277EEC0", Offset = "0x277E2C0", Length = "0x67")]
	[Token(Token = "0x6000BB7")]
	public IAsyncOnSelectHandler GetOnSelectAsyncHandler() { }

	[Address(RVA = "0x277EE40", Offset = "0x277E240", Length = "0x7C")]
	[Token(Token = "0x6000BB8")]
	public IAsyncOnSelectHandler GetOnSelectAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277F000", Offset = "0x277E400", Length = "0xB0")]
	[Token(Token = "0x6000BB9")]
	public UniTask<BaseEventData> OnSelectAsync() { }

	[Address(RVA = "0x277EF30", Offset = "0x277E330", Length = "0xC5")]
	[Token(Token = "0x6000BBA")]
	public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277F0C0", Offset = "0x277E4C0", Length = "0x48")]
	[Token(Token = "0x6000BB6")]
	private override void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData) { }

}

