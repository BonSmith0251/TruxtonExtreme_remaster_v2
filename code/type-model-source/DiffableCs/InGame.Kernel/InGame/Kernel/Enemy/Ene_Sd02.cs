namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000201")]
public class Ene_Sd02 : PawnEnemy
{
	[Token(Token = "0x2000202")]
	private enum MoveState : int
	{
		Init = 0,
		ToUp = 1,
		Higher = 2,
		Attack = 3,
	}

	[Token(Token = "0x4001208")]
	private static readonly float AttackSpeed; //Field offset: 0x0
	[Token(Token = "0x4001209")]
	private static readonly float DeploySpeed; //Field offset: 0x4
	[Token(Token = "0x400120A")]
	private static readonly float DeployTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400120B")]
	private MoveState _state; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x400120C")]
	private float _stateTime; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400120D")]
	private float _spin; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x400120E")]
	private float _moveValue0; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400120F")]
	private float _moveValue1; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4001210")]
	private float _localDuration; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001211")]
	private float _homingDuration; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001212")]
	private Vector3 _hormingArcVector; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001213")]
	private int _loop; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4001214")]
	private int _targetPlayerIndex; //Field offset: 0x1DC

	[Address(RVA = "0x1CFE0D0", Offset = "0x1CFD4D0", Length = "0xA9B")]
	[Token(Token = "0x6000F35")]
	private void _moveState() { }

	[Address(RVA = "0x1CFE010", Offset = "0x1CFD410", Length = "0x63")]
	[Token(Token = "0x6000F37")]
	private static Ene_Sd02() { }

	[Address(RVA = "0x1CFE080", Offset = "0x1CFD480", Length = "0x49")]
	[Token(Token = "0x6000F36")]
	public Ene_Sd02() { }

	[Address(RVA = "0x1CFDF90", Offset = "0x1CFD390", Length = "0x30")]
	[Token(Token = "0x6000F34")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CFDFC0", Offset = "0x1CFD3C0", Length = "0x48")]
	[Token(Token = "0x6000F33")]
	public virtual void ReStart(bool withPlay) { }

}

