namespace InGame.Kernel;

[Token(Token = "0x2000073")]
public class InGameObjectWithEvent : InGameObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000077")]
	private struct <_delayPlayPause>d__10 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003DB")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003DC")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003DD")]
		public CancellationToken token; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003DE")]
		public float startSec; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40003DF")]
		public float sec; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003E0")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D2C7A0", Offset = "0x1D2BBA0", Length = "0x2FA")]
		[Token(Token = "0x60004D6")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004D7")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000078")]
	private struct <_delayRotate>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003E1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003E2")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E3")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003E4")]
		public TaskFlags setflag; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003E5")]
		public CancellationToken token; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003E6")]
		public float preWait; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003E7")]
		public Transform _tempTransform; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003E8")]
		public bool isLocal; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40003E9")]
		public Vector3 rot; //Field offset: 0x44
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40003EA")]
		public float dotime; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40003EB")]
		public RotateMode rm; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40003EC")]
		public Ease emode; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40003ED")]
		public bool isAbsolute; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40003EE")]
		public float postWait; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40003EF")]
		private Awaiter <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40003F0")]
		private TweenerCore<Quaternion, Vector3, QuaternionOptions> <eveseq>5__2; //Field offset: 0x78

		[Address(RVA = "0x1D2CAA0", Offset = "0x1D2BEA0", Length = "0x662")]
		[Token(Token = "0x60004D8")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004D9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private struct <_delayScale>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003F2")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003F3")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003F4")]
		public CancellationToken token; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003F5")]
		public float preWait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003F6")]
		public Transform _tempTransform; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003F7")]
		public Vector3 scale; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40003F8")]
		public float dotime; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003F9")]
		public float postWait; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40003FA")]
		private Awaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40003FB")]
		private TweenerCore<Vector3, Vector3, VectorOptions> <eveseq>5__2; //Field offset: 0x58

		[Address(RVA = "0x1D2D110", Offset = "0x1D2C510", Length = "0x43C")]
		[Token(Token = "0x60004DA")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004DB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007A")]
	private struct <_delaySecond>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003FC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003FD")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003FE")]
		public float s; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003FF")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000400")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D2D7C0", Offset = "0x1D2CBC0", Length = "0x236")]
		[Token(Token = "0x60004DC")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004DD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007B")]
	private struct <_delaySecondLate>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000401")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000402")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000403")]
		public float tsec; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000404")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000405")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D2D550", Offset = "0x1D2C950", Length = "0x263")]
		[Token(Token = "0x60004DE")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004DF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007C")]
	private struct <_delaySecondWithPause>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000406")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000407")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000408")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000409")]
		public float tsec; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400040A")]
		public CancellationToken token; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400040B")]
		public Action<RouteEvent> taction; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400040C")]
		public RouteEvent teve; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400040D")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1D2DA00", Offset = "0x1D2CE00", Length = "0x2A7")]
		[Token(Token = "0x60004E0")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004E1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007D")]
	private struct <_delayTranslate>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400040E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400040F")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000410")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000411")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000412")]
		public float preWait; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000413")]
		public Transform _tempTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000414")]
		public Vector3 translate; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000415")]
		public float dotime; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000416")]
		public bool isRelative; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000417")]
		public float postWait; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000418")]
		private Awaiter <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000419")]
		private TweenerCore<Vector3, Vector3, VectorOptions> <eveseq>5__2; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400041A")]
		private bool <isPlay>5__3; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400041B")]
		private Awaiter <>u__2; //Field offset: 0x6C

		[Address(RVA = "0x1D2DCB0", Offset = "0x1D2D0B0", Length = "0x575")]
		[Token(Token = "0x60004E2")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004E3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000075")]
	private struct <DelayAnimationTask>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003CB")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003CC")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003CD")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003CE")]
		public float tsec; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40003CF")]
		public int aindex; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003D0")]
		public int aHash; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003D1")]
		private Awaiter <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40003D2")]
		private Animator <tanime>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40003D3")]
		private Awaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1D262A0", Offset = "0x1D256A0", Length = "0x467")]
		[Token(Token = "0x60004D2")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004D3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000076")]
	private struct <DelayRotate>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003D5")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003D6")]
		public RouteEvent _event; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003D7")]
		public InGameObjectWithEvent <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003D8")]
		public int playerIndex; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003D9")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1D26710", Offset = "0x1D25B10", Length = "0x908")]
		[Token(Token = "0x60004D4")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004D5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Flags]
	[Token(Token = "0x2000074")]
	internal enum TaskFlags : int
	{
		None = 0,
		RotateTask = 1,
		RotateTTask = 2,
		TranslateTask = 4,
		ScaleTask = 8,
		AnimationTask = 16,
		SpeedTask = 32,
		MovingTask = 256,
		HormingTask = 512,
		DirectionTask = 1024,
		EndCheck = 532,
		All = 2147483647,
	}

	[Token(Token = "0x40003B0")]
	protected static readonly float _dotimeMin; //Field offset: 0x0
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003B1")]
	protected Transform _transformCache; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003B2")]
	protected string _transformNameCache; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003B3")]
	private Dictionary<String, Transform> _transformCaches; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003B4")]
	protected List<RouteEvent> _eventDatas; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003B5")]
	private CancellationToken _destroyedToken; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003B6")]
	private CancellationTokenSource _animationToken; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003B7")]
	private CancellationTokenSource _rotateToken; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40003B8")]
	private CancellationTokenSource _scaleToken; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40003B9")]
	private CancellationTokenSource _translateToken; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40003BA")]
	private CancellationTokenSource _hormingToken; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40003BB")]
	private CancellationTokenSource _speedToken; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40003BC")]
	private TaskFlags _taskFlag; //Field offset: 0xC8

	[Token(Token = "0x170000E3")]
	protected CancellationTokenSource AnimationToken
	{
		[Address(RVA = "0x1D1E9F0", Offset = "0x1D1DDF0", Length = "0x48")]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E2")]
	public CancellationToken DestroyedToken
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60004C8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E7")]
	protected CancellationTokenSource HormingToken
	{
		[Address(RVA = "0x1D1EA40", Offset = "0x1D1DE40", Length = "0x48")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E4")]
	protected CancellationTokenSource RotateToken
	{
		[Address(RVA = "0x1D1EA90", Offset = "0x1D1DE90", Length = "0x48")]
		[Token(Token = "0x60004CA")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E5")]
	protected CancellationTokenSource ScaleToken
	{
		[Address(RVA = "0x1D1EAE0", Offset = "0x1D1DEE0", Length = "0x48")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E8")]
	protected CancellationTokenSource SpeedToken
	{
		[Address(RVA = "0x1D1EB30", Offset = "0x1D1DF30", Length = "0x48")]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E9")]
	public TaskFlags TaskFlag
	{
		[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
		[Token(Token = "0x60004CF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000E6")]
	protected CancellationTokenSource TranslateToken
	{
		[Address(RVA = "0x1D1EB90", Offset = "0x1D1DF90", Length = "0x48")]
		[Token(Token = "0x60004CC")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000E1")]
	public Vector3 WorldPos
	{
		[Address(RVA = "0x1D1EBE0", Offset = "0x1D1DFE0", Length = "0x3B")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x1D1E1A0", Offset = "0x1D1D5A0", Length = "0xD9")]
	[AsyncStateMachine(typeof(<_delayPlayPause>d__10))]
	[Token(Token = "0x60004BE")]
	protected UniTaskVoid _delayPlayPause(CancellationToken token, float sec, float startSec) { }

	[Address(RVA = "0x1D1E280", Offset = "0x1D1D680", Length = "0x169")]
	[AsyncStateMachine(typeof(<_delayRotate>d__13))]
	[Token(Token = "0x60004C1")]
	protected UniTask _delayRotate(Transform _tempTransform, Ease emode, RotateMode rm, CancellationToken token, float preWait, float postWait, float dotime, Vector3 rot, bool isLocal, bool isAbsolute, TaskFlags setflag) { }

	[Address(RVA = "0x1D1E3F0", Offset = "0x1D1D7F0", Length = "0x11B")]
	[AsyncStateMachine(typeof(<_delayScale>d__14))]
	[Token(Token = "0x60004C2")]
	private UniTaskVoid _delayScale(Transform _tempTransform, CancellationToken token, float preWait, float postWait, float dotime, Vector3 scale) { }

	[Address(RVA = "0x1D1E730", Offset = "0x1D1DB30", Length = "0xDD")]
	[AsyncStateMachine(typeof(<_delaySecond>d__7))]
	[Token(Token = "0x60004BB")]
	protected UniTask _delaySecond(CancellationToken token, float s) { }

	[Address(RVA = "0x1D1E510", Offset = "0x1D1D910", Length = "0xD3")]
	[AsyncStateMachine(typeof(<_delaySecondLate>d__8))]
	[Token(Token = "0x60004BC")]
	protected UniTask _delaySecondLate(CancellationToken token, float tsec) { }

	[Address(RVA = "0x1D1E5F0", Offset = "0x1D1D9F0", Length = "0x136")]
	[AsyncStateMachine(typeof(<_delaySecondWithPause>d__9))]
	[Token(Token = "0x60004BD")]
	protected UniTask _delaySecondWithPause(CancellationToken token, float tsec, RouteEvent teve = null, Action<RouteEvent> taction = null) { }

	[Address(RVA = "0x1D1E810", Offset = "0x1D1DC10", Length = "0x144")]
	[AsyncStateMachine(typeof(<_delayTranslate>d__15))]
	[Token(Token = "0x60004C3")]
	protected UniTask _delayTranslate(Transform _tempTransform, CancellationToken token, float preWait, float postWait, float dotime, Vector3 translate, bool isRelative) { }

	[Address(RVA = "0x1D1E960", Offset = "0x1D1DD60", Length = "0x8B")]
	[Token(Token = "0x60004C4")]
	protected Transform _getTransform(string tname) { }

	[Address(RVA = "0x1D1E060", Offset = "0x1D1D460", Length = "0x39")]
	[Token(Token = "0x60004D1")]
	private static InGameObjectWithEvent() { }

	[Address(RVA = "0x1D1E0A0", Offset = "0x1D1D4A0", Length = "0xF3")]
	[Token(Token = "0x60004D0")]
	public InGameObjectWithEvent() { }

	[Address(RVA = "0x1D1D820", Offset = "0x1D1CC20", Length = "0x146")]
	[Token(Token = "0x60004C5")]
	protected void CancelTaskToken(TaskFlags taskbit) { }

	[Address(RVA = "0x1D1D970", Offset = "0x1D1CD70", Length = "0x18")]
	[Token(Token = "0x60004B7")]
	protected void ClearTaskFlag(TaskFlags tflag) { }

	[Address(RVA = "0x1D1D990", Offset = "0x1D1CD90", Length = "0x110")]
	[Token(Token = "0x60004B6")]
	protected void ClearToken() { }

	[Address(RVA = "0x1D1DAA0", Offset = "0x1D1CEA0", Length = "0x9E")]
	[Token(Token = "0x60004BA")]
	public CancellationTokenSource CreateDestroyedToken() { }

	[Address(RVA = "0x1D1DB40", Offset = "0x1D1CF40", Length = "0x11B")]
	[AsyncStateMachine(typeof(<DelayAnimationTask>d__11))]
	[Token(Token = "0x60004BF")]
	public UniTask DelayAnimationTask(int aindex, CancellationToken token, float tsec, int aHash) { }

	[Address(RVA = "0x1D1DC60", Offset = "0x1D1D060", Length = "0xF4")]
	[AsyncStateMachine(typeof(<DelayRotate>d__12))]
	[Token(Token = "0x60004C0")]
	protected UniTask DelayRotate(RouteEvent _event, int playerIndex) { }

	[Address(RVA = "0x1D1E9F0", Offset = "0x1D1DDF0", Length = "0x48")]
	[Token(Token = "0x60004C9")]
	protected CancellationTokenSource get_AnimationToken() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60004C8")]
	public CancellationToken get_DestroyedToken() { }

	[Address(RVA = "0x1D1EA40", Offset = "0x1D1DE40", Length = "0x48")]
	[Token(Token = "0x60004CD")]
	protected CancellationTokenSource get_HormingToken() { }

	[Address(RVA = "0x1D1EA90", Offset = "0x1D1DE90", Length = "0x48")]
	[Token(Token = "0x60004CA")]
	protected CancellationTokenSource get_RotateToken() { }

	[Address(RVA = "0x1D1EAE0", Offset = "0x1D1DEE0", Length = "0x48")]
	[Token(Token = "0x60004CB")]
	protected CancellationTokenSource get_ScaleToken() { }

	[Address(RVA = "0x1D1EB30", Offset = "0x1D1DF30", Length = "0x48")]
	[Token(Token = "0x60004CE")]
	protected CancellationTokenSource get_SpeedToken() { }

	[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
	[Token(Token = "0x60004CF")]
	public TaskFlags get_TaskFlag() { }

	[Address(RVA = "0x1D1EB90", Offset = "0x1D1DF90", Length = "0x48")]
	[Token(Token = "0x60004CC")]
	protected CancellationTokenSource get_TranslateToken() { }

	[Address(RVA = "0x1D1EBE0", Offset = "0x1D1DFE0", Length = "0x3B")]
	[Token(Token = "0x60004C7")]
	public Vector3 get_WorldPos() { }

	[Address(RVA = "0x1D1DD60", Offset = "0x1D1D160", Length = "0x249")]
	[Token(Token = "0x60004B4")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D1DFB0", Offset = "0x1D1D3B0", Length = "0x98")]
	[Token(Token = "0x60004B5")]
	private bool IsNoCache(string tname) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60004C6")]
	public override bool IsPlaying() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004B9")]
	protected override void PlayPasue(bool value) { }

	[Address(RVA = "0x1D1E050", Offset = "0x1D1D450", Length = "0x7")]
	[Token(Token = "0x60004B8")]
	protected void SetTaskFlag(TaskFlags tflag) { }

}

