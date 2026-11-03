namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001E3")]
public sealed class AsyncResetTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277EAF0", Offset = "0x277DEF0", Length = "0x39")]
	[Token(Token = "0x6000B4B")]
	public AsyncResetTrigger() { }

	[Address(RVA = "0x277E7D0", Offset = "0x277DBD0", Length = "0x67")]
	[Token(Token = "0x6000B47")]
	public IAsyncResetHandler GetResetAsyncHandler() { }

	[Address(RVA = "0x277E750", Offset = "0x277DB50", Length = "0x7C")]
	[Token(Token = "0x6000B48")]
	public IAsyncResetHandler GetResetAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277EA80", Offset = "0x277DE80", Length = "0x6E")]
	[Token(Token = "0x6000B46")]
	private void Reset() { }

	[Address(RVA = "0x277E970", Offset = "0x277DD70", Length = "0x10C")]
	[Token(Token = "0x6000B49")]
	public UniTask ResetAsync() { }

	[Address(RVA = "0x277E840", Offset = "0x277DC40", Length = "0x122")]
	[Token(Token = "0x6000B4A")]
	public UniTask ResetAsync(CancellationToken cancellationToken) { }

}

