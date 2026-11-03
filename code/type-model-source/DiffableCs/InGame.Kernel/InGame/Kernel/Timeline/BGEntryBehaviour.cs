namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CC")]
public class BGEntryBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005DF")]
	private GameObject _bgObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E0")]
	private bool _isPlayStart; //Field offset: 0x18

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000718")]
	public BGEntryBehaviour() { }

	[Address(RVA = "0x1D306B0", Offset = "0x1D2FAB0", Length = "0x39")]
	[Token(Token = "0x6000716")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D306F0", Offset = "0x1D2FAF0", Length = "0x36")]
	[Token(Token = "0x6000715")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D30730", Offset = "0x1D2FB30", Length = "0x18")]
	[Token(Token = "0x6000714")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000717")]
	public void Set(GameObject tobj) { }

}

