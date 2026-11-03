namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000205")]
public sealed class AsyncSubmitTrigger : AsyncTriggerBase<BaseEventData>, ISubmitHandler, IEventSystemHandler
{

	[Address(RVA = "0x277FA20", Offset = "0x277EE20", Length = "0x39")]
	[Token(Token = "0x6000BC2")]
	public AsyncSubmitTrigger() { }

	[Address(RVA = "0x277F750", Offset = "0x277EB50", Length = "0x67")]
	[Token(Token = "0x6000BBE")]
	public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler() { }

	[Address(RVA = "0x277F7C0", Offset = "0x277EBC0", Length = "0x7C")]
	[Token(Token = "0x6000BBF")]
	public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277F910", Offset = "0x277ED10", Length = "0xB0")]
	[Token(Token = "0x6000BC0")]
	public UniTask<BaseEventData> OnSubmitAsync() { }

	[Address(RVA = "0x277F840", Offset = "0x277EC40", Length = "0xC5")]
	[Token(Token = "0x6000BC1")]
	public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277F9D0", Offset = "0x277EDD0", Length = "0x48")]
	[Token(Token = "0x6000BBD")]
	private override void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

}

