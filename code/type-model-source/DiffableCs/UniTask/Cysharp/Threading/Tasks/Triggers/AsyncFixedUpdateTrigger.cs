namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x2000175")]
public sealed class AsyncFixedUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2776850", Offset = "0x2775C50", Length = "0x39")]
	[Token(Token = "0x60009CA")]
	public AsyncFixedUpdateTrigger() { }

	[Address(RVA = "0x27766F0", Offset = "0x2775AF0", Length = "0x6E")]
	[Token(Token = "0x60009C5")]
	private void FixedUpdate() { }

	[Address(RVA = "0x27764B0", Offset = "0x27758B0", Length = "0x10C")]
	[Token(Token = "0x60009C8")]
	public UniTask FixedUpdateAsync() { }

	[Address(RVA = "0x27765C0", Offset = "0x27759C0", Length = "0x122")]
	[Token(Token = "0x60009C9")]
	public UniTask FixedUpdateAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x27767E0", Offset = "0x2775BE0", Length = "0x67")]
	[Token(Token = "0x60009C6")]
	public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler() { }

	[Address(RVA = "0x2776760", Offset = "0x2775B60", Length = "0x7C")]
	[Token(Token = "0x60009C7")]
	public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(CancellationToken cancellationToken) { }

}

