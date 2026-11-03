namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001A1")]
public sealed class AsyncEnableTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2776160", Offset = "0x2775560", Length = "0x39")]
	[Token(Token = "0x6000A64")]
	public AsyncEnableTrigger() { }

	[Address(RVA = "0x2775E40", Offset = "0x2775240", Length = "0x67")]
	[Token(Token = "0x6000A60")]
	public IAsyncOnEnableHandler GetOnEnableAsyncHandler() { }

	[Address(RVA = "0x2775DC0", Offset = "0x27751C0", Length = "0x7C")]
	[Token(Token = "0x6000A61")]
	public IAsyncOnEnableHandler GetOnEnableAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27760F0", Offset = "0x27754F0", Length = "0x6E")]
	[Token(Token = "0x6000A5F")]
	private void OnEnable() { }

	[Address(RVA = "0x2775EB0", Offset = "0x27752B0", Length = "0x10C")]
	[Token(Token = "0x6000A62")]
	public UniTask OnEnableAsync() { }

	[Address(RVA = "0x2775FC0", Offset = "0x27753C0", Length = "0x122")]
	[Token(Token = "0x6000A63")]
	public UniTask OnEnableAsync(CancellationToken cancellationToken) { }

}

