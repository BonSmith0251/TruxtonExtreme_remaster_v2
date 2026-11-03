namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000169")]
public class EnemyMoverGround : EnemyMover
{
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000A6F")]
	private EnemyTurret _turret; //Field offset: 0x2C0

	[Address(RVA = "0x1D6B1B0", Offset = "0x1D6A5B0", Length = "0x7")]
	[Token(Token = "0x6000B45")]
	public EnemyMoverGround() { }

	[Address(RVA = "0x1D6B100", Offset = "0x1D6A500", Length = "0x99")]
	[Token(Token = "0x6000B43")]
	protected virtual bool IsTurning(Transform tchild) { }

	[Address(RVA = "0x1D6B1A0", Offset = "0x1D6A5A0", Length = "0x10")]
	[Token(Token = "0x6000B44")]
	public virtual void SetNoTrun(bool tvalue, Transform tchild) { }

}

