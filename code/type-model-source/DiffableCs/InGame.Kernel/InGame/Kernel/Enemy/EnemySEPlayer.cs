namespace InGame.Kernel.Enemy;

[Token(Token = "0x200016F")]
public class EnemySEPlayer : MonoBehaviour, IEnemyUpdater
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000A82")]
	private ID _appearSE; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000A83")]
	private ID _bastaredSE; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A84")]
	private int _appearID; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A85")]
	private bool _isBastared; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A86")]
	private PawnEnemy _rootEnemy; //Field offset: 0x30

	[Address(RVA = "0x1D6E620", Offset = "0x1D6DA20", Length = "0x16")]
	[Token(Token = "0x6000B6C")]
	public EnemySEPlayer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B64")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x1D6E3D0", Offset = "0x1D6D7D0", Length = "0x7")]
	[Token(Token = "0x6000B69")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x1D6E3D0", Offset = "0x1D6D7D0", Length = "0x7")]
	[Token(Token = "0x6000B68")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D6E3E0", Offset = "0x1D6D7E0", Length = "0x3D")]
	[Token(Token = "0x6000B63")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000B6A")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B65")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1D6E420", Offset = "0x1D6D820", Length = "0x6A")]
	[Token(Token = "0x6000B66")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B67")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D6E490", Offset = "0x1D6D890", Length = "0x188")]
	[Token(Token = "0x6000B6B")]
	private void StopSE() { }

}

