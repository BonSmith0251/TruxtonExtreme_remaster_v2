namespace AEAsAnimation;

[Token(Token = "0x200000D")]
public interface IAEAudioPlayer
{

	[Token(Token = "0x6000058")]
	public void Initialize(string name) { }

	[Token(Token = "0x6000059")]
	public void Play(float volume) { }

	[Token(Token = "0x600005A")]
	public void Stop() { }

}

