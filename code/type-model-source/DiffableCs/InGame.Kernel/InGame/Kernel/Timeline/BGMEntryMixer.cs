namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D3")]
public class BGMEntryMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000732")]
	public BGMEntryMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000731")]
	public virtual void OnGraphStart(Playable playable) { }

}

