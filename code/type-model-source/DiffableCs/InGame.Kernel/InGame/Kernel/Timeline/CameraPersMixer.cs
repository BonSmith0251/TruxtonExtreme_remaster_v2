namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000DB")]
public class CameraPersMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000748")]
	public CameraPersMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000746")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x1D31EC0", Offset = "0x1D312C0", Length = "0x208")]
	[Token(Token = "0x6000747")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

