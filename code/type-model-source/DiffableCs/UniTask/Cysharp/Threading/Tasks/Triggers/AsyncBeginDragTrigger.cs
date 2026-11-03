namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001E7")]
public sealed class AsyncBeginDragTrigger : AsyncTriggerBase<PointerEventData>, IBeginDragHandler, IEventSystemHandler
{

	[Address(RVA = "0x2772C50", Offset = "0x2772050", Length = "0x39")]
	[Token(Token = "0x6000B59")]
	public AsyncBeginDragTrigger() { }

	[Address(RVA = "0x2772A00", Offset = "0x2771E00", Length = "0x67")]
	[Token(Token = "0x6000B55")]
	public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler() { }

	[Address(RVA = "0x2772980", Offset = "0x2771D80", Length = "0x7C")]
	[Token(Token = "0x6000B56")]
	public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2772A70", Offset = "0x2771E70", Length = "0xB0")]
	[Token(Token = "0x6000B57")]
	public UniTask<PointerEventData> OnBeginDragAsync() { }

	[Address(RVA = "0x2772B30", Offset = "0x2771F30", Length = "0xC5")]
	[Token(Token = "0x6000B58")]
	public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2772C00", Offset = "0x2772000", Length = "0x48")]
	[Token(Token = "0x6000B54")]
	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

}

