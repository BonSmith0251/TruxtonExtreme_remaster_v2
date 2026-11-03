namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CE")]
public class BGEntryMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600071E")]
	public BGEntryMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600071D")]
	public virtual void OnGraphStart(Playable playable) { }

}

