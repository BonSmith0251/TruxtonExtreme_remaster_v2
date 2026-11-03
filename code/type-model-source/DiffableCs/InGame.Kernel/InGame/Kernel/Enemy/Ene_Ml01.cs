namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001F1")]
public class Ene_Ml01 : PawnEnemy
{
	[CompilerGenerated]
	[Token(Token = "0x20001F4")]
	private sealed class <>c
	{
		[Token(Token = "0x4001156")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001157")]
		public static Func<PawnEnemy, Boolean> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x1DD15D0", Offset = "0x1DD09D0", Length = "0x67")]
		[Token(Token = "0x6000EF1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EF2")]
		public <>c() { }

		[Address(RVA = "0x1DD13F0", Offset = "0x1DD07F0", Length = "0x75")]
		[Token(Token = "0x6000EF3")]
		internal bool <_foodListup>b__6_0(PawnEnemy a) { }

	}

	[Token(Token = "0x20001F3")]
	private enum JawState : int
	{
		Normal = 0,
		Opne = 1,
		Cloce = 2,
	}

	[Token(Token = "0x20001F2")]
	private enum MoveState : int
	{
		Init = 0,
		Find = 1,
		PreWait = 2,
		Search = 3,
		Attack = 4,
		PostWait = 5,
		PlayerSearch = 6,
		PlayerAttack = 7,
		Release = 8,
	}

	[Token(Token = "0x4001130")]
	private static readonly string targetName; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001131")]
	private MoveState _state; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4001132")]
	private float _stateTime; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001133")]
	private PawnEnemy[] _childList; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001134")]
	private int _target; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4001135")]
	private float _speed; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001136")]
	private float _speedMax; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001137")]
	private float _turn; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4001138")]
	private float _turnMax; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[SerializeField]
	[Token(Token = "0x4001139")]
	private float _biteRange; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x400113A")]
	private AnimationCurve _biteAttack; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x400113B")]
	private Transform _leftJaw; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x400113C")]
	private Transform _rightJaw; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400113D")]
	private Vector3 _leftAngle; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x400113E")]
	private Vector3 _rightAngle; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400113F")]
	private Vector3 _lastTarget; //Field offset: 0x208
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x4001140")]
	private JawState _jaw; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4001141")]
	private bool _eatEnd; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4001142")]
	private float _totalTime; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4001143")]
	private readonly float _searchLimitX; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4001144")]
	private readonly float _searchLimitY; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Header("食いつき間隔")]
	[SerializeField]
	[Token(Token = "0x4001145")]
	private float _eatInterval; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Header("ギョグの逃走までの時間")]
	[SerializeField]
	[Token(Token = "0x4001146")]
	private float _getAway; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Header("回転速度係数")]
	[SerializeField]
	[Token(Token = "0x4001147")]
	private float _turnSpeed; //Field offset: 0x230

	[Token(Token = "0x1700020F")]
	private Vector3 _localForward
	{
		[Address(RVA = "0x1DCCA20", Offset = "0x1DCBE20", Length = "0xA5")]
		[Token(Token = "0x6000EEE")]
		private get { } //Length: 165
	}

	[Address(RVA = "0x1DCA500", Offset = "0x1DC9900", Length = "0x30")]
	[Token(Token = "0x6000EE3")]
	private float _calcAngle(float now, float target, float speed) { }

	[Address(RVA = "0x1DCA480", Offset = "0x1DC9880", Length = "0x75")]
	[Token(Token = "0x6000EEB")]
	private float _calcAngleDiff(float nowAngy, Vector3 posDiff) { }

	[Address(RVA = "0x1DCA530", Offset = "0x1DC9930", Length = "0x110")]
	[Token(Token = "0x6000EE0")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1DCA700", Offset = "0x1DC9B00", Length = "0x123")]
	[Token(Token = "0x6000EED")]
	private bool _checkPosition(Transform t, float range) { }

	[Address(RVA = "0x1DCA6C0", Offset = "0x1DC9AC0", Length = "0x36")]
	[Token(Token = "0x6000EEC")]
	private bool _checkPositionArea(Vector3 pos) { }

	[Address(RVA = "0x1DCA8C0", Offset = "0x1DC9CC0", Length = "0x150")]
	[Token(Token = "0x6000EE5")]
	private void _foodDelete(PawnEnemy pe) { }

	[Address(RVA = "0x1DCAA20", Offset = "0x1DC9E20", Length = "0x20A")]
	[Token(Token = "0x6000EE6")]
	private void _foodEatCheck(float range = 10) { }

	[Address(RVA = "0x1DCAC30", Offset = "0x1DCA030", Length = "0x107")]
	[Token(Token = "0x6000EE8")]
	private void _foodFadeAway() { }

	[Address(RVA = "0x1DCAD40", Offset = "0x1DCA140", Length = "0x107")]
	[Token(Token = "0x6000EE7")]
	private void _foodGoAway() { }

	[Address(RVA = "0x1DCAE50", Offset = "0x1DCA250", Length = "0x259")]
	[Token(Token = "0x6000EE4")]
	private void _foodListup() { }

	[Address(RVA = "0x1DCB0B0", Offset = "0x1DCA4B0", Length = "0x164")]
	[Token(Token = "0x6000EE2")]
	private void _moveState(float dt) { }

	[Address(RVA = "0x1DCC5E0", Offset = "0x1DCB9E0", Length = "0x189")]
	[Token(Token = "0x6000EEA")]
	private Quaternion _rotateTowards(Quaternion lRot, Vector3 targetVec, float delta) { }

	[Address(RVA = "0x1DCC770", Offset = "0x1DCBB70", Length = "0x2A7")]
	[Token(Token = "0x6000EE9")]
	private int _setNearFood(bool small = false) { }

	[Address(RVA = "0x1DCA650", Offset = "0x1DC9A50", Length = "0x62")]
	[Token(Token = "0x6000EF0")]
	private static Ene_Ml01() { }

	[Address(RVA = "0x1DCA830", Offset = "0x1DC9C30", Length = "0x85")]
	[Token(Token = "0x6000EEF")]
	public Ene_Ml01() { }

	[Address(RVA = "0x1DCCA20", Offset = "0x1DCBE20", Length = "0xA5")]
	[Token(Token = "0x6000EEE")]
	private Vector3 get__localForward() { }

	[Address(RVA = "0x1DCA380", Offset = "0x1DC9780", Length = "0x3A")]
	[Token(Token = "0x6000EE1")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DCA3C0", Offset = "0x1DC97C0", Length = "0xBF")]
	[Token(Token = "0x6000EDF")]
	public virtual void ReStart(bool withPlay) { }

}

