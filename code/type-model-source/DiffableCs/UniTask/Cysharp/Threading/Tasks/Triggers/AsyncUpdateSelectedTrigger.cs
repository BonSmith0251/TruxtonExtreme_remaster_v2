namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000207")]
public sealed class AsyncUpdateSelectedTrigger : AsyncTriggerBase<BaseEventData>, IUpdateSelectedHandler, IEventSystemHandler
{

	[Address(RVA = "0x27854B0", Offset = "0x27848B0", Length = "0x39")]
	[Token(Token = "0x6000BC9")]
	public AsyncUpdateSelectedTrigger() { }

	[Address(RVA = "0x27851E0", Offset = "0x27845E0", Length = "0x67")]
	[Token(Token = "0x6000BC5")]
	public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler() { }

	[Address(RVA = "0x2785250", Offset = "0x2784650", Length = "0x7C")]
	[Token(Token = "0x6000BC6")]
	public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27853A0", Offset = "0x27847A0", Length = "0xB0")]
	[Token(Token = "0x6000BC7")]
	public UniTask<BaseEventData> OnUpdateSelectedAsync() { }

	[Address(RVA = "0x27852D0", Offset = "0x27846D0", Length = "0xC5")]
	[Token(Token = "0x6000BC8")]
	public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2785460", Offset = "0x2784860", Length = "0x48")]
	[Token(Token = "0x6000BC4")]
	private override void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) { }

}

