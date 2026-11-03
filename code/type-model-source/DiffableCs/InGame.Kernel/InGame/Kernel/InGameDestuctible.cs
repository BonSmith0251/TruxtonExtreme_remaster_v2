namespace InGame.Kernel;

[Token(Token = "0x200001F")]
public class InGameDestuctible : InGameBullet, IDamagedObject
{
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	private string _deadBullet; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000D7")]
	private BulletTemplate _bt; //Field offset: 0xF8

	[Address(RVA = "0x1CCFB80", Offset = "0x1CCEF80", Length = "0x6D")]
	[Token(Token = "0x6000137")]
	public InGameDestuctible() { }

	[Address(RVA = "0x1CCFAC0", Offset = "0x1CCEEC0", Length = "0xB9")]
	[CompilerGenerated]
	[Token(Token = "0x6000138")]
	internal static void <SetCauseOfDeath>g___generateCallback|3_0(InGameBulletInterface ib) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000130")]
	public override int GetDamageScore() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000131")]
	public override int GetDeathScore() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000134")]
	public override toleType GetTolerance(attackType at) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000135")]
	public override void HitBlink(attackType at) { }

	[Address(RVA = "0x1CCF730", Offset = "0x1CCEB30", Length = "0x159")]
	[Token(Token = "0x600012C")]
	public virtual void Initialize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000132")]
	public virtual bool IsBombered() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600012E")]
	public virtual bool IsBomberRange() { }

	[Address(RVA = "0x1CCF890", Offset = "0x1CCEC90", Length = "0x14")]
	[Token(Token = "0x6000136")]
	private bool IsDividedCause(attackType at) { }

	[Address(RVA = "0x1CCF8B0", Offset = "0x1CCECB0", Length = "0x77")]
	[Token(Token = "0x600012D")]
	public virtual bool IsHitEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000133")]
	public virtual void SetBombered() { }

	[Address(RVA = "0x1CCF930", Offset = "0x1CCED30", Length = "0x18B")]
	[Token(Token = "0x600012F")]
	public virtual void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

}

