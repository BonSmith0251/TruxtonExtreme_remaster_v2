namespace InGame.Kernel;

[Token(Token = "0x20000B0")]
public class SimpleMoveMiRocket : SimpleMove
{
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000545")]
	[Tooltip("変更角度")]
	private float HomingAngle; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[Token(Token = "0x4000546")]
	[Tooltip("初期速度")]
	public float FirstTimeSpeed; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000547")]
	[Tooltip("減速終了秒")]
	private float decelerationTime; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x4000548")]
	[Tooltip("最小速度係数")]
	private float minDeceleration; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000549")]
	[Tooltip("追尾開始時間")]
	private float turnStartTime; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	[Tooltip("最短追尾時間")]
	private float turnEnd; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400054B")]
	[Tooltip("最大追尾時間")]
	private float turnTime; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	[Token(Token = "0x400054C")]
	[Tooltip("最高速到達時間")]
	private float accelerationTime; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400054D")]
	private float _maxRSin; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400054E")]
	private float _maxRCos; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400054F")]
	private float _initialSpeed; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000550")]
	private float _localTime; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000551")]
	private float _homingTime; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000552")]
	private float _homingAngleF; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000553")]
	private int _targetPlayer; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000554")]
	private bool _isLocked; //Field offset: 0x124

	[Token(Token = "0x17000138")]
	private float accelerationDuration
	{
		[Address(RVA = "0x1D42740", Offset = "0x1D41B40", Length = "0x2D")]
		[Token(Token = "0x600066C")]
		private get { } //Length: 45
	}

	[Address(RVA = "0x1D426C0", Offset = "0x1D41AC0", Length = "0x75")]
	[Token(Token = "0x6000668")]
	protected virtual void _updateMove(float dt) { }

	[Address(RVA = "0x1D42640", Offset = "0x1D41A40", Length = "0x75")]
	[Token(Token = "0x600066D")]
	public SimpleMoveMiRocket() { }

	[Address(RVA = "0x1D42740", Offset = "0x1D41B40", Length = "0x2D")]
	[Token(Token = "0x600066C")]
	private float get_accelerationDuration() { }

	[Address(RVA = "0x1D41DA0", Offset = "0x1D411A0", Length = "0x9")]
	[Token(Token = "0x6000669")]
	public virtual float GetFirstSpeed() { }

	[Address(RVA = "0x1D41DB0", Offset = "0x1D411B0", Length = "0x103")]
	[Token(Token = "0x6000665")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D41EC0", Offset = "0x1D412C0", Length = "0x108")]
	[Token(Token = "0x600066B")]
	private bool IsLocked(Vector3 subpos) { }

	[Address(RVA = "0x1D41FD0", Offset = "0x1D413D0", Length = "0xF2")]
	[Token(Token = "0x6000667")]
	public virtual void SetTargetPlayer() { }

	[Address(RVA = "0x1D420D0", Offset = "0x1D414D0", Length = "0xF2")]
	[Token(Token = "0x6000666")]
	public virtual void StartMove(Vector3 s, Vector3 ndir, float speedRate, bool isLookAt = false, MoveType mt = 0) { }

	[Address(RVA = "0x1D421D0", Offset = "0x1D415D0", Length = "0x468")]
	[Token(Token = "0x600066A")]
	private bool UpdateSpeed(float dt) { }

}

