namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000208")]
public class Ene_Sm01 : PawnEnemy
{
	[Token(Token = "0x2000209")]
	private enum MoveState : int
	{
		Init = 0,
		Entrying = 1,
		Moving = 2,
		Done = 3,
	}

	[Token(Token = "0x400125D")]
	private static readonly float _LifeTime; //Field offset: 0x0
	[Token(Token = "0x400125E")]
	private static readonly float _relectRandom; //Field offset: 0x4
	[Token(Token = "0x400125F")]
	private static readonly int _SeedV3; //Field offset: 0x8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001260")]
	private MoveState _MoveState; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x4001261")]
	private GameObject _model; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001262")]
	private Vector3 _moveDirection; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001263")]
	private Vector3 _reflectDireciton; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001264")]
	private Quaternion _moveRotation; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4001265")]
	private float _startTime; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4001266")]
	private float _lifeTime; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4001267")]
	private bool _isEntryed; //Field offset: 0x1F0

	[Token(Token = "0x17000210")]
	private bool IsMoving
	{
		[Address(RVA = "0x1D03150", Offset = "0x1D02550", Length = "0x17")]
		[Token(Token = "0x6000F6A")]
		private get { } //Length: 23
	}

	[Address(RVA = "0x1D02830", Offset = "0x1D01C30", Length = "0x22B")]
	[Token(Token = "0x6000F69")]
	private Vector3 _GetReflectDirectionAlongNearestDiagonal(Vector3 direction) { }

	[Address(RVA = "0x1D02B30", Offset = "0x1D01F30", Length = "0x616")]
	[Token(Token = "0x6000F66")]
	private void _progressMove(float dt) { }

	[Address(RVA = "0x1D02A60", Offset = "0x1D01E60", Length = "0x79")]
	[Token(Token = "0x6000F6C")]
	private static Ene_Sm01() { }

	[Address(RVA = "0x1D02AE0", Offset = "0x1D01EE0", Length = "0x49")]
	[Token(Token = "0x6000F6B")]
	public Ene_Sm01() { }

	[Address(RVA = "0x1D03150", Offset = "0x1D02550", Length = "0x17")]
	[Token(Token = "0x6000F6A")]
	private bool get_IsMoving() { }

	[Address(RVA = "0x1D021D0", Offset = "0x1D015D0", Length = "0x58")]
	[Token(Token = "0x6000F65")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D024B0", Offset = "0x1D018B0", Length = "0x2CB")]
	[Token(Token = "0x6000F67")]
	public void Reflect(Ene_Sm01 other) { }

	[Address(RVA = "0x1D02230", Offset = "0x1D01630", Length = "0x274")]
	[Token(Token = "0x6000F64")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D02780", Offset = "0x1D01B80", Length = "0xA7")]
	[Token(Token = "0x6000F68")]
	private void SetRandomMoveRotation() { }

}

