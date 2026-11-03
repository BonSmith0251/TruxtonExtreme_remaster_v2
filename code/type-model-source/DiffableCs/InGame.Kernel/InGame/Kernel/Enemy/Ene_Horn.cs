namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001DB")]
public class Ene_Horn : MonoBehaviour, IEnemyUpdater
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400106A")]
	private EnemyMover _rootEnemy; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400106B")]
	private bool _isStart; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400106C")]
	private bool _isToped; //Field offset: 0x29

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000E65")]
	public Ene_Horn() { }

	[Address(RVA = "0x1DBC530", Offset = "0x1DBB930", Length = "0x19A")]
	[Token(Token = "0x6000E5E")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E63")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E62")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1DBC4E0", Offset = "0x1DBB8E0", Length = "0x3D")]
	[Token(Token = "0x6000E5D")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000E64")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E5F")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1DBC520", Offset = "0x1DBB920", Length = "0x7")]
	[Token(Token = "0x6000E60")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E61")]
	public override void ProgressTerminate() { }

}

