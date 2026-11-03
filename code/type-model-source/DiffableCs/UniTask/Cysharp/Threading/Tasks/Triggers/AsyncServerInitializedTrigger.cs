namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001CD")]
public sealed class AsyncServerInitializedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277F4F0", Offset = "0x277E8F0", Length = "0x39")]
	[Token(Token = "0x6000AFE")]
	public AsyncServerInitializedTrigger() { }

	[Address(RVA = "0x277F1D0", Offset = "0x277E5D0", Length = "0x67")]
	[Token(Token = "0x6000AFA")]
	public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler() { }

	[Address(RVA = "0x277F150", Offset = "0x277E550", Length = "0x7C")]
	[Token(Token = "0x6000AFB")]
	public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277F480", Offset = "0x277E880", Length = "0x6E")]
	[Token(Token = "0x6000AF9")]
	private void OnServerInitialized() { }

	[Address(RVA = "0x277F370", Offset = "0x277E770", Length = "0x10C")]
	[Token(Token = "0x6000AFC")]
	public UniTask OnServerInitializedAsync() { }

	[Address(RVA = "0x277F240", Offset = "0x277E640", Length = "0x122")]
	[Token(Token = "0x6000AFD")]
	public UniTask OnServerInitializedAsync(CancellationToken cancellationToken) { }

}

