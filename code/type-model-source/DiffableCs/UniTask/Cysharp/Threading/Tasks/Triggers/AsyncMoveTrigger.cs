namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001F5")]
public sealed class AsyncMoveTrigger : AsyncTriggerBase<AxisEventData>, IMoveHandler, IEventSystemHandler
{

	[Address(RVA = "0x277A170", Offset = "0x2779570", Length = "0x39")]
	[Token(Token = "0x6000B8A")]
	public AsyncMoveTrigger() { }

	[Address(RVA = "0x2779F20", Offset = "0x2779320", Length = "0x67")]
	[Token(Token = "0x6000B86")]
	public IAsyncOnMoveHandler GetOnMoveAsyncHandler() { }

	[Address(RVA = "0x2779EA0", Offset = "0x27792A0", Length = "0x7C")]
	[Token(Token = "0x6000B87")]
	public IAsyncOnMoveHandler GetOnMoveAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277A060", Offset = "0x2779460", Length = "0xB0")]
	[Token(Token = "0x6000B88")]
	public UniTask<AxisEventData> OnMoveAsync() { }

	[Address(RVA = "0x2779F90", Offset = "0x2779390", Length = "0xC5")]
	[Token(Token = "0x6000B89")]
	public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277A120", Offset = "0x2779520", Length = "0x48")]
	[Token(Token = "0x6000B85")]
	private override void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData) { }

}

