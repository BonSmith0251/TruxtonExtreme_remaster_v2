namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001EB")]
public sealed class AsyncDeselectTrigger : AsyncTriggerBase<BaseEventData>, IDeselectHandler, IEventSystemHandler
{

	[Address(RVA = "0x27747E0", Offset = "0x2773BE0", Length = "0x39")]
	[Token(Token = "0x6000B67")]
	public AsyncDeselectTrigger() { }

	[Address(RVA = "0x2774510", Offset = "0x2773910", Length = "0x67")]
	[Token(Token = "0x6000B63")]
	public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler() { }

	[Address(RVA = "0x2774580", Offset = "0x2773980", Length = "0x7C")]
	[Token(Token = "0x6000B64")]
	public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2774600", Offset = "0x2773A00", Length = "0xB0")]
	[Token(Token = "0x6000B65")]
	public UniTask<BaseEventData> OnDeselectAsync() { }

	[Address(RVA = "0x27746C0", Offset = "0x2773AC0", Length = "0xC5")]
	[Token(Token = "0x6000B66")]
	public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2774790", Offset = "0x2773B90", Length = "0x48")]
	[Token(Token = "0x6000B62")]
	private override void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData) { }

}

