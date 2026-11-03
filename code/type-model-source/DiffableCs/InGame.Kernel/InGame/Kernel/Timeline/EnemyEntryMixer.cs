namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E8")]
public class EnemyEntryMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000791")]
	public EnemyEntryMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000790")]
	public virtual void OnGraphStart(Playable playable) { }

}

