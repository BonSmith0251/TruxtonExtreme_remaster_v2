namespace InGame.Kernel.Player;

[Token(Token = "0x200011E")]
public class PlayerMuzzle : InGameObjectBase
{
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400081A")]
	private ParticleSystem[] _fireEffects; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400081B")]
	private Single[] _fireEffectSecs; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400081C")]
	private int _playEffectBit; //Field offset: 0x78

	[Address(RVA = "0x1D4F140", Offset = "0x1D4E540", Length = "0x82")]
	[Token(Token = "0x60008F8")]
	public PlayerMuzzle() { }

	[Address(RVA = "0x1D4EF70", Offset = "0x1D4E370", Length = "0xE7")]
	[Token(Token = "0x60008F7")]
	public void ClearBit(float dt) { }

	[Address(RVA = "0x1D4F060", Offset = "0x1D4E460", Length = "0xDD")]
	[Token(Token = "0x60008F6")]
	public void Fire(ArmsKind ak) { }

}

