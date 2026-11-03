namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001B7")]
public sealed class AsyncParticleCollisionTrigger : AsyncTriggerBase<GameObject>
{

	[Address(RVA = "0x277B030", Offset = "0x277A430", Length = "0x39")]
	[Token(Token = "0x6000AB1")]
	public AsyncParticleCollisionTrigger() { }

	[Address(RVA = "0x277AD60", Offset = "0x277A160", Length = "0x67")]
	[Token(Token = "0x6000AAD")]
	public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler() { }

	[Address(RVA = "0x277ADD0", Offset = "0x277A1D0", Length = "0x7C")]
	[Token(Token = "0x6000AAE")]
	public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277AFE0", Offset = "0x277A3E0", Length = "0x48")]
	[Token(Token = "0x6000AAC")]
	private void OnParticleCollision(GameObject other) { }

	[Address(RVA = "0x277AE50", Offset = "0x277A250", Length = "0xB0")]
	[Token(Token = "0x6000AAF")]
	public UniTask<GameObject> OnParticleCollisionAsync() { }

	[Address(RVA = "0x277AF10", Offset = "0x277A310", Length = "0xC5")]
	[Token(Token = "0x6000AB0")]
	public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken) { }

}

