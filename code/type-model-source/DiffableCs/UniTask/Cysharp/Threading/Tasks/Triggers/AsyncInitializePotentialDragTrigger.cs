namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001F3")]
public sealed class AsyncInitializePotentialDragTrigger : AsyncTriggerBase<PointerEventData>, IInitializePotentialDragHandler, IEventSystemHandler
{

	[Address(RVA = "0x2777890", Offset = "0x2776C90", Length = "0x39")]
	[Token(Token = "0x6000B83")]
	public AsyncInitializePotentialDragTrigger() { }

	[Address(RVA = "0x27775C0", Offset = "0x27769C0", Length = "0x67")]
	[Token(Token = "0x6000B7F")]
	public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler() { }

	[Address(RVA = "0x2777630", Offset = "0x2776A30", Length = "0x7C")]
	[Token(Token = "0x6000B80")]
	public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2777780", Offset = "0x2776B80", Length = "0xB0")]
	[Token(Token = "0x6000B81")]
	public UniTask<PointerEventData> OnInitializePotentialDragAsync() { }

	[Address(RVA = "0x27776B0", Offset = "0x2776AB0", Length = "0xC5")]
	[Token(Token = "0x6000B82")]
	public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2777840", Offset = "0x2776C40", Length = "0x48")]
	[Token(Token = "0x6000B7E")]
	private override void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData) { }

}

