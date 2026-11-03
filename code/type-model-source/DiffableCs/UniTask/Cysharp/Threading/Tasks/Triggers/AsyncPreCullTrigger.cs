namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001C1")]
public sealed class AsyncPreCullTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277D380", Offset = "0x277C780", Length = "0x39")]
	[Token(Token = "0x6000AD4")]
	public AsyncPreCullTrigger() { }

	[Address(RVA = "0x277CFE0", Offset = "0x277C3E0", Length = "0x67")]
	[Token(Token = "0x6000AD0")]
	public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler() { }

	[Address(RVA = "0x277D050", Offset = "0x277C450", Length = "0x7C")]
	[Token(Token = "0x6000AD1")]
	public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277D310", Offset = "0x277C710", Length = "0x6E")]
	[Token(Token = "0x6000ACF")]
	private void OnPreCull() { }

	[Address(RVA = "0x277D200", Offset = "0x277C600", Length = "0x10C")]
	[Token(Token = "0x6000AD2")]
	public UniTask OnPreCullAsync() { }

	[Address(RVA = "0x277D0D0", Offset = "0x277C4D0", Length = "0x122")]
	[Token(Token = "0x6000AD3")]
	public UniTask OnPreCullAsync(CancellationToken cancellationToken) { }

}

