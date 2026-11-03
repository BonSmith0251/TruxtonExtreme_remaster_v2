namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001BB")]
public sealed class AsyncParticleTriggerTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277B7F0", Offset = "0x277ABF0", Length = "0x39")]
	[Token(Token = "0x6000ABF")]
	public AsyncParticleTriggerTrigger() { }

	[Address(RVA = "0x277B450", Offset = "0x277A850", Length = "0x67")]
	[Token(Token = "0x6000ABB")]
	public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler() { }

	[Address(RVA = "0x277B4C0", Offset = "0x277A8C0", Length = "0x7C")]
	[Token(Token = "0x6000ABC")]
	public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277B780", Offset = "0x277AB80", Length = "0x6E")]
	[Token(Token = "0x6000ABA")]
	private void OnParticleTrigger() { }

	[Address(RVA = "0x277B540", Offset = "0x277A940", Length = "0x10C")]
	[Token(Token = "0x6000ABD")]
	public UniTask OnParticleTriggerAsync() { }

	[Address(RVA = "0x277B650", Offset = "0x277AA50", Length = "0x122")]
	[Token(Token = "0x6000ABE")]
	public UniTask OnParticleTriggerAsync(CancellationToken cancellationToken) { }

}

