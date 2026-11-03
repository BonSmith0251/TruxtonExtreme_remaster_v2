namespace InGame.Kernel;

[Token(Token = "0x20000A9")]
public class SilverHorming : SimpleMoveHorming
{
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000512")]
	private WeaponCollisionBase _weapon; //Field offset: 0x108

	[Address(RVA = "0x1D40F30", Offset = "0x1D40330", Length = "0x40")]
	[Token(Token = "0x6000623")]
	public SilverHorming() { }

	[Address(RVA = "0x1D40E40", Offset = "0x1D40240", Length = "0xED")]
	[Token(Token = "0x6000622")]
	protected virtual void SetStartTarget() { }

}

