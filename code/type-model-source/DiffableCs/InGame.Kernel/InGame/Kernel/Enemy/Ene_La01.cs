namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001DC")]
public class Ene_La01 : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x400106D")]
	private static readonly string _body1Name; //Field offset: 0x0
	[Token(Token = "0x400106E")]
	private static readonly string _b1MuzzleName; //Field offset: 0x8
	[Token(Token = "0x400106F")]
	private static readonly string _body2Name; //Field offset: 0x10
	[Token(Token = "0x4001070")]
	private static readonly string _body3Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001071")]
	private int _body1index; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001072")]
	private int _b1muzzleIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001073")]
	private int _body2index; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001074")]
	private int _body3index; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001075")]
	private PawnEnemy _rootEnemy; //Field offset: 0x30

	[Address(RVA = "0x1DBCB40", Offset = "0x1DBBF40", Length = "0x12B")]
	[Token(Token = "0x6000E6F")]
	private static Ene_La01() { }

	[Address(RVA = "0x1DBCC70", Offset = "0x1DBC070", Length = "0x17")]
	[Token(Token = "0x6000E6E")]
	public Ene_La01() { }

	[Address(RVA = "0x1DBCA20", Offset = "0x1DBBE20", Length = "0x112")]
	[Token(Token = "0x6000E67")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E6C")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x1DBC6D0", Offset = "0x1DBBAD0", Length = "0x224")]
	[Token(Token = "0x6000E6B")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1DBC900", Offset = "0x1DBBD00", Length = "0x117")]
	[Token(Token = "0x6000E66")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1CFEBB0", Offset = "0x1CFDFB0", Length = "0x6")]
	[Token(Token = "0x6000E6D")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E68")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E69")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E6A")]
	public override void ProgressTerminate() { }

}

