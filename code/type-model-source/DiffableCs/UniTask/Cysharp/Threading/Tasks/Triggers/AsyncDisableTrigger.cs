namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200019B")]
public sealed class AsyncDisableTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2774FA0", Offset = "0x27743A0", Length = "0x39")]
	[Token(Token = "0x6000A4F")]
	public AsyncDisableTrigger() { }

	[Address(RVA = "0x2774C00", Offset = "0x2774000", Length = "0x67")]
	[Token(Token = "0x6000A4B")]
	public IAsyncOnDisableHandler GetOnDisableAsyncHandler() { }

	[Address(RVA = "0x2774C70", Offset = "0x2774070", Length = "0x7C")]
	[Token(Token = "0x6000A4C")]
	public IAsyncOnDisableHandler GetOnDisableAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2774F30", Offset = "0x2774330", Length = "0x6E")]
	[Token(Token = "0x6000A4A")]
	private void OnDisable() { }

	[Address(RVA = "0x2774E20", Offset = "0x2774220", Length = "0x10C")]
	[Token(Token = "0x6000A4D")]
	public UniTask OnDisableAsync() { }

	[Address(RVA = "0x2774CF0", Offset = "0x27740F0", Length = "0x122")]
	[Token(Token = "0x6000A4E")]
	public UniTask OnDisableAsync(CancellationToken cancellationToken) { }

}

