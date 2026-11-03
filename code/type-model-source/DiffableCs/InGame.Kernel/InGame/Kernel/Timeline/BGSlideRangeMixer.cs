namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D7")]
public class BGSlideRangeMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600073D")]
	public BGSlideRangeMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600073B")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x1D31A90", Offset = "0x1D30E90", Length = "0x208")]
	[Token(Token = "0x600073C")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

