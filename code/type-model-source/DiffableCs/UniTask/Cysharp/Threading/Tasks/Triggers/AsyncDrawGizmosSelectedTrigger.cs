namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x200019F")]
public sealed class AsyncDrawGizmosSelectedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x2775690", Offset = "0x2774A90", Length = "0x39")]
	[Token(Token = "0x6000A5D")]
	public AsyncDrawGizmosSelectedTrigger() { }

	[Address(RVA = "0x2775370", Offset = "0x2774770", Length = "0x67")]
	[Token(Token = "0x6000A59")]
	public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler() { }

	[Address(RVA = "0x27752F0", Offset = "0x27746F0", Length = "0x7C")]
	[Token(Token = "0x6000A5A")]
	public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2775620", Offset = "0x2774A20", Length = "0x6E")]
	[Token(Token = "0x6000A58")]
	private void OnDrawGizmosSelected() { }

	[Address(RVA = "0x2775510", Offset = "0x2774910", Length = "0x10C")]
	[Token(Token = "0x6000A5B")]
	public UniTask OnDrawGizmosSelectedAsync() { }

	[Address(RVA = "0x27753E0", Offset = "0x27747E0", Length = "0x122")]
	[Token(Token = "0x6000A5C")]
	public UniTask OnDrawGizmosSelectedAsync(CancellationToken cancellationToken) { }

}

