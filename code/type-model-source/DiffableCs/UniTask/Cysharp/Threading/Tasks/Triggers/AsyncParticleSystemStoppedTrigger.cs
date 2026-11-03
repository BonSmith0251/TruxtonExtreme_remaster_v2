namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001B9")]
public sealed class AsyncParticleSystemStoppedTrigger : AsyncTriggerBase<AsyncUnit>
{

	[Address(RVA = "0x277B410", Offset = "0x277A810", Length = "0x39")]
	[Token(Token = "0x6000AB8")]
	public AsyncParticleSystemStoppedTrigger() { }

	[Address(RVA = "0x277B070", Offset = "0x277A470", Length = "0x67")]
	[Token(Token = "0x6000AB4")]
	public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler() { }

	[Address(RVA = "0x277B0E0", Offset = "0x277A4E0", Length = "0x7C")]
	[Token(Token = "0x6000AB5")]
	public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277B3A0", Offset = "0x277A7A0", Length = "0x6E")]
	[Token(Token = "0x6000AB3")]
	private void OnParticleSystemStopped() { }

	[Address(RVA = "0x277B160", Offset = "0x277A560", Length = "0x10C")]
	[Token(Token = "0x6000AB6")]
	public UniTask OnParticleSystemStoppedAsync() { }

	[Address(RVA = "0x277B270", Offset = "0x277A670", Length = "0x122")]
	[Token(Token = "0x6000AB7")]
	public UniTask OnParticleSystemStoppedAsync(CancellationToken cancellationToken) { }

}

