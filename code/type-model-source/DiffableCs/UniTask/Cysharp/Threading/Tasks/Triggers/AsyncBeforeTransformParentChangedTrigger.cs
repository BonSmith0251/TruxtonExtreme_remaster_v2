namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000189")]
public sealed class AsyncBeforeTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2772940", Offset = "0x2771D40", Length = "0x39")]
	[Token(Token = "0x6000A10")]
	public AsyncBeforeTransformParentChangedTrigger() { }

	[Address(RVA = "0x2772620", Offset = "0x2771A20", Length = "0x67")]
	[Token(Token = "0x6000A0C")]
	public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler() { }

	[Address(RVA = "0x27725A0", Offset = "0x27719A0", Length = "0x7C")]
	[Token(Token = "0x6000A0D")]
	public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27728D0", Offset = "0x2771CD0", Length = "0x6E")]
	[Token(Token = "0x6000A0B")]
	private void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x2772690", Offset = "0x2771A90", Length = "0x10C")]
	[Token(Token = "0x6000A0E")]
	public UniTask OnBeforeTransformParentChangedAsync() { }

	[Address(RVA = "0x27727A0", Offset = "0x2771BA0", Length = "0x122")]
	[Token(Token = "0x6000A0F")]
	public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken) { }

}

