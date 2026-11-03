namespace InGame.Kernel.Enemy;

[Token(Token = "0x200019D")]
public class Ene_Bos04Bit : PawnEnemy
{
	[Token(Token = "0x4000D02")]
	private static readonly List<String> _BtNames; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000D03")]
	private Ene_Bos04 _parent; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000D04")]
	private BulletTemplate _bulletTemplate; //Field offset: 0x1B8

	[Address(RVA = "0x1D8B290", Offset = "0x1D8A690", Length = "0x10B")]
	[Token(Token = "0x6000CBD")]
	private static Ene_Bos04Bit() { }

	[Address(RVA = "0x1D8B3A0", Offset = "0x1D8A7A0", Length = "0x49")]
	[Token(Token = "0x6000CBC")]
	public Ene_Bos04Bit() { }

	[Address(RVA = "0x1D8AEA0", Offset = "0x1D8A2A0", Length = "0xA3")]
	[Token(Token = "0x6000CB9")]
	public void Fire() { }

	[Address(RVA = "0x1D8AF50", Offset = "0x1D8A350", Length = "0x4E")]
	[Token(Token = "0x6000CBB")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D8AFA0", Offset = "0x1D8A3A0", Length = "0x11F")]
	[Token(Token = "0x6000CB7")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D8B0C0", Offset = "0x1D8A4C0", Length = "0xCC")]
	[Token(Token = "0x6000CB8")]
	public void Setup(Ene_Bos04 parent) { }

	[Address(RVA = "0x1D8B190", Offset = "0x1D8A590", Length = "0xF2")]
	[Token(Token = "0x6000CBA")]
	public virtual void ToDestroid() { }

}

