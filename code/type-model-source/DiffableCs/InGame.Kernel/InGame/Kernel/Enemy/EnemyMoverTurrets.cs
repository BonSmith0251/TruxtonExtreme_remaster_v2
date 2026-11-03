namespace InGame.Kernel.Enemy;

[Token(Token = "0x200016B")]
public class EnemyMoverTurrets : EnemyMover
{
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000A77")]
	private EnemyTurret[] _turrets; //Field offset: 0x2C0

	[Address(RVA = "0x1D6B1B0", Offset = "0x1D6A5B0", Length = "0x7")]
	[Token(Token = "0x6000B52")]
	public EnemyMoverTurrets() { }

	[Address(RVA = "0x1D6C0B0", Offset = "0x1D6B4B0", Length = "0xB4")]
	[Token(Token = "0x6000B51")]
	private EnemyTurret GetTurret(Transform tchild) { }

	[Address(RVA = "0x1D6C170", Offset = "0x1D6B570", Length = "0x1BC")]
	[Token(Token = "0x6000B4F")]
	public virtual bool IsBulletFire(Transform tchild) { }

	[Address(RVA = "0x1D6C330", Offset = "0x1D6B730", Length = "0x9F")]
	[Token(Token = "0x6000B4D")]
	protected virtual bool IsTurning(Transform tchild) { }

	[Address(RVA = "0x1D6C3D0", Offset = "0x1D6B7D0", Length = "0x24B")]
	[Token(Token = "0x6000B50")]
	public virtual void Progress(float dt) { }

	[Address(RVA = "0x1D6C620", Offset = "0x1D6BA20", Length = "0xED")]
	[Token(Token = "0x6000B4E")]
	public virtual void SetNoTrun(bool tvalue, Transform tchild) { }

}

