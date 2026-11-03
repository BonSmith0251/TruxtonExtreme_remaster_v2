namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001E9")]
public sealed class AsyncCancelTrigger : AsyncTriggerBase<BaseEventData>, ICancelHandler, IEventSystemHandler
{

	[Address(RVA = "0x2772F60", Offset = "0x2772360", Length = "0x39")]
	[Token(Token = "0x6000B60")]
	public AsyncCancelTrigger() { }

	[Address(RVA = "0x2772D10", Offset = "0x2772110", Length = "0x67")]
	[Token(Token = "0x6000B5C")]
	public IAsyncOnCancelHandler GetOnCancelAsyncHandler() { }

	[Address(RVA = "0x2772C90", Offset = "0x2772090", Length = "0x7C")]
	[Token(Token = "0x6000B5D")]
	public IAsyncOnCancelHandler GetOnCancelAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2772E50", Offset = "0x2772250", Length = "0xB0")]
	[Token(Token = "0x6000B5E")]
	public UniTask<BaseEventData> OnCancelAsync() { }

	[Address(RVA = "0x2772D80", Offset = "0x2772180", Length = "0xC5")]
	[Token(Token = "0x6000B5F")]
	public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2772F10", Offset = "0x2772310", Length = "0x48")]
	[Token(Token = "0x6000B5B")]
	private override void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData) { }

}

