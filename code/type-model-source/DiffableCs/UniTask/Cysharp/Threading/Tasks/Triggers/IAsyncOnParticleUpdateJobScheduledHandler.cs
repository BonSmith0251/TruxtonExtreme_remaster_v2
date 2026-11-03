namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001BC")]
public interface IAsyncOnParticleUpdateJobScheduledHandler
{

	[Token(Token = "0x6000AC0")]
	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync() { }

}

