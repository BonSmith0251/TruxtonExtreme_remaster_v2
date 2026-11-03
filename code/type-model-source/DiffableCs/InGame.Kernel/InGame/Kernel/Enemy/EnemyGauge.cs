namespace InGame.Kernel.Enemy;

[RequireComponent(typeof(PawnEnemy))]
[Token(Token = "0x200015D")]
public class EnemyGauge : MonoBehaviour, IEnemyUpdater
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009D6")]
	private Ene_BosBase _baseEnemy; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009D7")]
	private UIBossGauge _gauge; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009D8")]
	private float _hprate; //Field offset: 0x30

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000A98")]
	public EnemyGauge() { }

	[Address(RVA = "0x1D63D90", Offset = "0x1D63190", Length = "0xD5")]
	[Token(Token = "0x6000A91")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A96")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x1D63BB0", Offset = "0x1D62FB0", Length = "0x9B")]
	[Token(Token = "0x6000A95")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D63C50", Offset = "0x1D63050", Length = "0xA9")]
	[Token(Token = "0x6000A90")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000A97")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D63D00", Offset = "0x1D63100", Length = "0x8")]
	[Token(Token = "0x6000A92")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1D63D10", Offset = "0x1D63110", Length = "0x3B")]
	[Token(Token = "0x6000A93")]
	public override void ProgressStart() { }

	[Address(RVA = "0x1D63D50", Offset = "0x1D63150", Length = "0x3C")]
	[Token(Token = "0x6000A94")]
	public override void ProgressTerminate() { }

}

