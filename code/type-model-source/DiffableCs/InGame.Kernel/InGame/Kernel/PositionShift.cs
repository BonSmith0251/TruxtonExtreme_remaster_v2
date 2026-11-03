namespace InGame.Kernel;

[Token(Token = "0x20000A4")]
public class PositionShift : MonoBehaviour, IEnemyUpdater
{
	[Token(Token = "0x40004EE")]
	private static readonly float ScaleFactor; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004EF")]
	private float _baseY; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40004F0")]
	private float _targetY; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x40004F1")]
	private float _planeY; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x40004F2")]
	private float _lscale; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004F3")]
	private PawnEnemy _rootEnemy; //Field offset: 0x30

	[Address(RVA = "0x1D3E550", Offset = "0x1D3D950", Length = "0x39")]
	[Token(Token = "0x6000604")]
	private static PositionShift() { }

	[Address(RVA = "0x1D3E590", Offset = "0x1D3D990", Length = "0xE")]
	[Token(Token = "0x6000603")]
	public PositionShift() { }

	[Address(RVA = "0x1D3E180", Offset = "0x1D3D580", Length = "0x3A2")]
	[Token(Token = "0x60005FC")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005FE")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005FD")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D3E050", Offset = "0x1D3D450", Length = "0x3D")]
	[Token(Token = "0x60005F9")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000600")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D3E0A0", Offset = "0x1D3D4A0", Length = "0x40")]
	[Token(Token = "0x60005FA")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1D3E0F0", Offset = "0x1D3D4F0", Length = "0x85")]
	[Token(Token = "0x60005FB")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005FF")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D3E530", Offset = "0x1D3D930", Length = "0x7")]
	[Token(Token = "0x6000601")]
	private void ResetTargetY() { }

	[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
	[Token(Token = "0x6000602")]
	private void SetTargeyY(float y) { }

}

