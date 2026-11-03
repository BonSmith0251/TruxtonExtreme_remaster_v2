namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000203")]
public class Ene_Sg01 : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x400121A")]
	private static readonly float minDistance; //Field offset: 0x0
	[Token(Token = "0x400121B")]
	private static readonly float maxDistance; //Field offset: 0x4
	[Token(Token = "0x400121C")]
	private static readonly float minSpeed; //Field offset: 0x8
	[Token(Token = "0x400121D")]
	private static readonly float outSpeed; //Field offset: 0xC
	[Token(Token = "0x400121E")]
	private static readonly float maxSpeed; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400121F")]
	private EnemyMover _mover; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001220")]
	private bool _isHomingDone; //Field offset: 0x28

	[Address(RVA = "0x1CFEE20", Offset = "0x1CFE220", Length = "0x8D")]
	[Token(Token = "0x6000F41")]
	private static Ene_Sg01() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000F40")]
	public Ene_Sg01() { }

	[Address(RVA = "0x1CFEBD0", Offset = "0x1CFDFD0", Length = "0x247")]
	[Token(Token = "0x6000F3B")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F3E")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F3D")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1CFEB70", Offset = "0x1CFDF70", Length = "0x3D")]
	[Token(Token = "0x6000F38")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1CFEBB0", Offset = "0x1CFDFB0", Length = "0x6")]
	[Token(Token = "0x6000F3F")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F39")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1CFEBC0", Offset = "0x1CFDFC0", Length = "0x5")]
	[Token(Token = "0x6000F3A")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F3C")]
	public override void ProgressTerminate() { }

}

