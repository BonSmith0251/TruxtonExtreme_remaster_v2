namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[Token(Token = "0x20001BD")]
public sealed class AsyncParticleUpdateJobScheduledTrigger : AsyncTriggerBase<ParticleSystemJobData>
{

	[Address(RVA = "0x277BC70", Offset = "0x277B070", Length = "0x39")]
	[Token(Token = "0x6000AC6")]
	public AsyncParticleUpdateJobScheduledTrigger() { }

	[Address(RVA = "0x277B830", Offset = "0x277AC30", Length = "0x67")]
	[Token(Token = "0x6000AC2")]
	public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler() { }

	[Address(RVA = "0x277B8A0", Offset = "0x277ACA0", Length = "0x7C")]
	[Token(Token = "0x6000AC3")]
	public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(CancellationToken cancellationToken) { }

	[Address(RVA = "0x277BB70", Offset = "0x277AF70", Length = "0xF6")]
	[Token(Token = "0x6000AC1")]
	private void OnParticleUpdateJobScheduled(ParticleSystemJobData particles) { }

	[Address(RVA = "0x277BA50", Offset = "0x277AE50", Length = "0x116")]
	[Token(Token = "0x6000AC4")]
	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync() { }

	[Address(RVA = "0x277B920", Offset = "0x277AD20", Length = "0x12A")]
	[Token(Token = "0x6000AC5")]
	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(CancellationToken cancellationToken) { }

}

