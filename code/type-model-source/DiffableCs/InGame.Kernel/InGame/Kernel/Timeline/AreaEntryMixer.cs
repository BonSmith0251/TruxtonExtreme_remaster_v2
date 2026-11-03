namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CA")]
public class AreaEntryMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000711")]
	public AreaEntryMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000710")]
	public virtual void OnGraphStart(Playable playable) { }

}

