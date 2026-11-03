namespace InGame.Kernel;

[Token(Token = "0x2000035")]
public abstract class InGameEnemyMoveBase : InGameObjectWithEvent
{
	[CompilerGenerated]
	[Token(Token = "0x2000041")]
	private struct <_bulletFireAsync>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001ED")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001EE")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001EF")]
		public RouteEvent _event; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001F0")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001F1")]
		public Action<InGameBulletInterface> callback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001F2")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1CF5A10", Offset = "0x1CF4E10", Length = "0x676")]
		[Token(Token = "0x600026D")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600026E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private struct <_changeSpeedAsync>d__74 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001F4")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001F5")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001F6")]
		public RouteEvent _event; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001F7")]
		public CancellationToken token; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001F8")]
		private float <ttotal>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001F9")]
		private float <tpass>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001FA")]
		private float <bspeed>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40001FB")]
		private float <rspeed>5__5; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001FC")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1CF6090", Offset = "0x1CF5490", Length = "0x372")]
		[Token(Token = "0x600026F")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000270")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private struct <_execEventWithRepeat>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001FE")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001FF")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000200")]
		public CancellationToken ct; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000201")]
		public RouteEvent _event; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000202")]
		private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000203")]
		private int <repeatCount>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000204")]
		private float <repeatWait>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000205")]
		private bool <isLoop>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000206")]
		private float <firstTimeWait>5__5; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000207")]
		private bool <isNoEntry>5__6; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x4000208")]
		private bool <isOnceForceFire>5__7; //Field offset: 0x41
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000209")]
		private Awaiter <>u__1; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400020A")]
		private Awaiter <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400020B")]
		private SplineRouteData <tempSplineData>5__8; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400020C")]
		private bool <isSet>5__9; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400020D")]
		private InGameObjectFlag <_tflag>5__10; //Field offset: 0x64

		[Address(RVA = "0x1CF6410", Offset = "0x1CF5810", Length = "0x3280")]
		[Token(Token = "0x6000271")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000272")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private struct <_moveTypeUpdateAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400020F")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000210")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000211")]
		public TaskFlags _flags; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000212")]
		public CancellationToken token; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000213")]
		private bool <isMoveTypeChanged>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000214")]
		private Awaiter <>u__1; //Field offset: 0x34

		[Address(RVA = "0x1CF9730", Offset = "0x1CF8B30", Length = "0xCE0")]
		[Token(Token = "0x6000273")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000274")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003A")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x200003B")]
		private struct <<_execEventWithRepeat>g__WaitSeconds|1>d : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40001A2")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40001A3")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40001A4")]
			public float tsec; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40001A5")]
			public <>c__DisplayClass31_0 <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40001A6")]
			private Awaiter <>u__1; //Field offset: 0x28

			[Address(RVA = "0x1CF53B0", Offset = "0x1CF47B0", Length = "0x291")]
			[Token(Token = "0x6000261")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000262")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x200003C")]
		private struct <<_execEventWithRepeat>g__WaitTaskFlag|0>d : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40001A7")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40001A8")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40001A9")]
			public <>c__DisplayClass31_0 <>4__this; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40001AA")]
			public TaskFlags tflag; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x40001AB")]
			private Awaiter <>u__1; //Field offset: 0x24

			[Address(RVA = "0x1CF5650", Offset = "0x1CF4A50", Length = "0x20E")]
			[Token(Token = "0x6000263")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000264")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019E")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400019F")]
		public CancellationToken ct; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A0")]
		public float repeatDelay; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001A1")]
		public float repeatDelayBase; //Field offset: 0x24

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600025E")]
		public <>c__DisplayClass31_0() { }

		[Address(RVA = "0x1CF5860", Offset = "0x1CF4C60", Length = "0xD3")]
		[AsyncStateMachine(typeof(<<_execEventWithRepeat>g__WaitSeconds|1>d))]
		[Token(Token = "0x6000260")]
		internal UniTask <_execEventWithRepeat>g__WaitSeconds|1(float tsec) { }

		[Address(RVA = "0x1CF5940", Offset = "0x1CF4D40", Length = "0xCB")]
		[AsyncStateMachine(typeof(<<_execEventWithRepeat>g__WaitTaskFlag|0>d))]
		[Token(Token = "0x600025F")]
		internal UniTask <_execEventWithRepeat>g__WaitTaskFlag|0(TaskFlags tflag) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private struct <BulletDirFireAsync>d__52 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001AD")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001AE")]
		public int overlapLoop; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001AF")]
		public BulletTemplate bt; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B0")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001B1")]
		public Transform mzt; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001B2")]
		public Transform dirt; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001B3")]
		public Action<InGameBulletInterface> callback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001B4")]
		public CancellationToken token; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001B5")]
		private InGameManager <gm>5__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001B6")]
		private int <loopcount>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40001B7")]
		private float <startArc>5__4; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001B8")]
		private float <selfArc>5__5; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40001B9")]
		private float <speedRate>5__6; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001BA")]
		private bool <isForce>5__7; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40001BB")]
		private int <laped>5__8; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001BC")]
		private int <nway>5__9; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40001BD")]
		private Awaiter <>u__1; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001BE")]
		private Awaiter <>u__2; //Field offset: 0x78

		[Address(RVA = "0x1CF3610", Offset = "0x1CF2A10", Length = "0x96B")]
		[Token(Token = "0x6000265")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000266")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private struct <BulletFireAsync>d__48 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001C0")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C1")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C2")]
		public string _hierarchyName; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001C3")]
		public string _baseHierarhyName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001C4")]
		public CancellationToken token; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001C5")]
		public BulletTemplate bt; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001C6")]
		public bool isSelfDir; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40001C7")]
		public float offsetAngle; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001C8")]
		public Action<InGameBulletInterface> callback; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001C9")]
		private Awaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x1CF4240", Offset = "0x1CF3640", Length = "0x2B9")]
		[Token(Token = "0x6000267")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000268")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private struct <BulletFireAsync>d__51 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001CB")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CC")]
		public int argLoopCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CD")]
		public BulletTemplate bt; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CE")]
		public bool isSelfDir; //Field offset: 0x28
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x40001CF")]
		public bool isNested; //Field offset: 0x29
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001D0")]
		public Transform muzzleTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001D1")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001D2")]
		public Transform baseTransform; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001D3")]
		public float offsetAngle; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001D4")]
		public Action<InGameBulletInterface> callback; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001D5")]
		public CancellationToken token; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001D6")]
		private InGameManager <gm>5__2; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001D7")]
		private int <loopcount>5__3; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40001D8")]
		private float <startArc>5__4; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001D9")]
		private float <selfArc>5__5; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40001DA")]
		private float <targetArc>5__6; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001DB")]
		private float <speedRate>5__7; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x40001DC")]
		private bool <isTarget>5__8; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40001DD")]
		private int <laped>5__9; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x40001DE")]
		private float <rapidDelta>5__10; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001DF")]
		private Awaiter <>u__1; //Field offset: 0x88

		[Address(RVA = "0x1CF4500", Offset = "0x1CF3900", Length = "0xEA5")]
		[Token(Token = "0x6000269")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600026A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000040")]
	private struct <BulletFireAsyncDelayed>d__50 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001E1")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001E2")]
		public InGameEnemyMoveBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001E3")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001E4")]
		public float tsec; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001E5")]
		public BulletTemplate bt; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001E6")]
		public bool isSelfDir; //Field offset: 0x38
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x40001E7")]
		public bool isNested; //Field offset: 0x39
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001E8")]
		public Transform muzzleTransform; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001E9")]
		public Transform baseTransform; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001EA")]
		public float offsetAngle; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001EB")]
		private Awaiter <>u__1; //Field offset: 0x58

		[Address(RVA = "0x1CF3F80", Offset = "0x1CF3380", Length = "0x2B1")]
		[Token(Token = "0x600026B")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600026C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000037")]
	internal enum MoveType : int
	{
		TraceMove = 1,
		DirectionMove = 2,
		HormingMove = 3,
		HormingMoveEnd = 4,
		HormingMoveEnemy = 5,
		SplineMove = 6,
		GravityMove = 7,
		Done = 999,
		None = -1,
	}

	[Token(Token = "0x2000039")]
	internal class MuzzlePacks
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019C")]
		public string keyName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400019D")]
		public List<Transform> muzzles; //Field offset: 0x18

		[Address(RVA = "0x1CF34E0", Offset = "0x1CF28E0", Length = "0x95")]
		[Token(Token = "0x600025D")]
		public MuzzlePacks() { }

	}

	[Token(Token = "0x2000036")]
	internal sealed class OnBulletFire : MulticastDelegate
	{

		[Address(RVA = "0x1C4B9A0", Offset = "0x1C4ADA0", Length = "0xA6")]
		[Token(Token = "0x6000259")]
		public OnBulletFire(object object, IntPtr method) { }

		[Address(RVA = "0x1CF3580", Offset = "0x1CF2980", Length = "0x88")]
		[Token(Token = "0x600025B")]
		public override IAsyncResult BeginInvoke(CancellationToken token, RouteEvent _event, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600025C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600025A")]
		public override void Invoke(CancellationToken token, RouteEvent _event) { }

	}

	[Token(Token = "0x2000038")]
	internal enum State : int
	{
		None = 0,
		PlayReady = 1,
		Playing = 2,
		Finished = 3,
		PlayPause = 4,
	}

	[Token(Token = "0x400015A")]
	private static readonly Dictionary<Int32, TaskFlags> _eventToTaskflag; //Field offset: 0x0
	[Token(Token = "0x400015B")]
	private static readonly Dictionary<String, RouteLutAsset> _routeLutAssets; //Field offset: 0x8
	[Token(Token = "0x400015C")]
	private static readonly Dictionary<String, String> _routeLutPaths; //Field offset: 0x10
	[Token(Token = "0x400015D")]
	private static readonly object _routeLutLock; //Field offset: 0x18
	[Token(Token = "0x400015E")]
	private static readonly Single[] _DriftArcs; //Field offset: 0x20
	[Token(Token = "0x400015F")]
	private static readonly Single[] _DriftSpeed; //Field offset: 0x28
	[Token(Token = "0x4000160")]
	private static readonly Single[] _DriftBackSpeed; //Field offset: 0x30
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000161")]
	protected bool isEntryedArea; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000162")]
	private MoveType _moveType; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000163")]
	private Vector3 _moveValue; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000164")]
	protected Spline _spline; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000165")]
	private RouteLutAsset _routeLutAsset; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000166")]
	private string _splineRouteName; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000167")]
	private int _routeLutIndex; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000168")]
	private Vector3 _splineRootPosition; //Field offset: 0x104
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000169")]
	protected Vector3 _splineStartPosition; //Field offset: 0x110
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x400016A")]
	protected Vector3 _splineCurrentPosition; //Field offset: 0x11C
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400016B")]
	private Vector3 _beforeDirection; //Field offset: 0x128
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400016C")]
	private Vector3 _currentDirection; //Field offset: 0x134
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400016D")]
	private int _targetPlayerIndex; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400016E")]
	private int _intValue1; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400016F")]
	private float _moveValue0; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000170")]
	private float _moveValue1; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000171")]
	private float _localDuration; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000172")]
	private float _homingDuration; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000173")]
	private float _wakeAfterSecond; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000174")]
	protected float _durationTime; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000175")]
	protected float _durationPassTime; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000176")]
	protected float _currentSpeed; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000177")]
	private float _splineLength; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x4000178")]
	protected float _rollAngle; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000179")]
	private Quaternion _firstRotate; //Field offset: 0x170
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400017A")]
	private Quaternion _lastDir; //Field offset: 0x180
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x400017B")]
	protected bool _isSmooth; //Field offset: 0x190
	[FieldOffset(Offset = "0x191")]
	[Token(Token = "0x400017C")]
	private bool _isDirtyTransform; //Field offset: 0x191
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x400017D")]
	protected EasingType _easingType; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400017E")]
	protected EasingType _nextEasingType; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x400017F")]
	protected LookAtType _nextLookAtType; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000180")]
	protected Vector3 _nextLookAtRotate; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1AC")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000181")]
	protected LookAtType _lookAtType; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000182")]
	private State _moverState; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x4000183")]
	protected List<MuzzlePacks> _muzzlePacks; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000184")]
	private CancellationTokenSource _reveToken; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000185")]
	private PawnEnemy _masterEnemy; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000186")]
	protected Division _division; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000187")]
	private bool _laserCancelFlag; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D5")]
	[Token(Token = "0x4000188")]
	private bool _isDeletedReve; //Field offset: 0x1D5
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000189")]
	protected float _smoothRotateValue; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x400018A")]
	private float _spRate; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400018B")]
	private OnBulletFire _bulletFire; //Field offset: 0x1E0

	[Token(Token = "0x17000054")]
	public float CurrentSpeed
	{
		[Address(RVA = "0x1CDD4B0", Offset = "0x1CDC8B0", Length = "0x9")]
		[Token(Token = "0x6000249")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000053")]
	public float DurationRemain
	{
		[Address(RVA = "0x1CDD4C0", Offset = "0x1CDC8C0", Length = "0x11")]
		[Token(Token = "0x6000248")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000056")]
	public Quaternion FirstRotate
	{
		[Address(RVA = "0x1CDD4E0", Offset = "0x1CDC8E0", Length = "0xE")]
		[Token(Token = "0x600024B")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700004E")]
	public MoveType GetMoveType
	{
		[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
		[Token(Token = "0x6000243")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000057")]
	public bool IsDirtyTransform
	{
		[Address(RVA = "0x1CDD4F0", Offset = "0x1CDC8F0", Length = "0x8")]
		[Token(Token = "0x600024C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005B")]
	public bool IsGroundDivision
	{
		[Address(RVA = "0x1CDD500", Offset = "0x1CDC900", Length = "0x17")]
		[Token(Token = "0x6000250")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700005C")]
	public bool IsGroundSkyDivision
	{
		[Address(RVA = "0x1CDD520", Offset = "0x1CDC920", Length = "0xB")]
		[Token(Token = "0x6000251")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000051")]
	public float LocalDuration
	{
		[Address(RVA = "0x1CDD530", Offset = "0x1CDC930", Length = "0x9")]
		[Token(Token = "0x6000246")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700005A")]
	protected PawnEnemy MasterEnemy
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[Token(Token = "0x600024F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000058")]
	public State MoverState
	{
		[Address(RVA = "0x1CDD570", Offset = "0x1CDC970", Length = "0x7")]
		[Token(Token = "0x600024D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700004F")]
	public Vector3 MoveVector
	{
		[Address(RVA = "0x1CDD550", Offset = "0x1CDC950", Length = "0x19")]
		[Token(Token = "0x6000244")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000059")]
	public CancellationToken RouteToken
	{
		[Address(RVA = "0x1CDD580", Offset = "0x1CDC980", Length = "0x20")]
		[Token(Token = "0x600024E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000055")]
	protected float SplineLength
	{
		[Address(RVA = "0x1CDD5B0", Offset = "0x1CDC9B0", Length = "0x9")]
		[Token(Token = "0x600024A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700005D")]
	public float SplineRate
	{
		[Address(RVA = "0x1CDD5C0", Offset = "0x1CDC9C0", Length = "0x9")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000050")]
	public Vector3 SplineStartPosition
	{
		[Address(RVA = "0x1CDD5D0", Offset = "0x1CDC9D0", Length = "0x19")]
		[Token(Token = "0x6000245")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000052")]
	protected float WakeAfterSecond
	{
		[Address(RVA = "0x1CDD5F0", Offset = "0x1CDC9F0", Length = "0x9")]
		[Token(Token = "0x6000247")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1CDB930", Offset = "0x1CDAD30", Length = "0x222")]
	[Token(Token = "0x6000233")]
	protected Quaternion _AddDriftAngle(float xsub, float nlimit, float dt) { }

	[Address(RVA = "0x1CDBB60", Offset = "0x1CDAF60", Length = "0xA4")]
	[Token(Token = "0x6000232")]
	private void _AddRollAngle(float subdir, float nStep, float nlimit) { }

	[Address(RVA = "0x1CDBC10", Offset = "0x1CDB010", Length = "0xEC")]
	[AsyncStateMachine(typeof(<_bulletFireAsync>d__47))]
	[Token(Token = "0x600021B")]
	private UniTaskVoid _bulletFireAsync(CancellationToken token, RouteEvent _event, Action<InGameBulletInterface> callback = null) { }

	[Address(RVA = "0x1CDC060", Offset = "0x1CDB460", Length = "0x110")]
	[AsyncStateMachine(typeof(<_changeSpeedAsync>d__74))]
	[Token(Token = "0x6000236")]
	private UniTask _changeSpeedAsync(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1CDA240", Offset = "0x1CD9640", Length = "0x2F")]
	[Token(Token = "0x6000253")]
	private void _defaultBulletFire(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1CDC370", Offset = "0x1CDB770", Length = "0xD8")]
	[AsyncStateMachine(typeof(<_execEventWithRepeat>d__31))]
	[Token(Token = "0x600020E")]
	private UniTaskVoid _execEventWithRepeat(RouteEvent _event, CancellationToken ct) { }

	[Address(RVA = "0x1CDC450", Offset = "0x1CDB850", Length = "0xF0")]
	[Token(Token = "0x6000238")]
	private Transform _getCheckTransform(string tname) { }

	[Address(RVA = "0x1CDC550", Offset = "0x1CDB950", Length = "0x1DD")]
	[Token(Token = "0x6000215")]
	private Quaternion _getLocalLookAtRotate(Vector3 direction) { }

	[Address(RVA = "0x1CDC730", Offset = "0x1CDBB30", Length = "0xF1")]
	[Token(Token = "0x6000237")]
	private Transform _getMuzzleTransform(string tname, out bool isNest) { }

	[Address(RVA = "0x1CDC830", Offset = "0x1CDBC30", Length = "0x35D")]
	[Token(Token = "0x6000210")]
	protected Quaternion _getRotate(Spline _vspline, float trate, float tstep, float dt) { }

	[Address(RVA = "0x1CDCB90", Offset = "0x1CDBF90", Length = "0x130")]
	[Token(Token = "0x600022E")]
	private Vector3 _getSplineUpVector(Spline _sp, float _offset) { }

	[Address(RVA = "0x1CDCCC0", Offset = "0x1CDC0C0", Length = "0x96")]
	[Token(Token = "0x6000216")]
	private Vector3 _lookAtVector() { }

	[Address(RVA = "0x1CDCD60", Offset = "0x1CDC160", Length = "0xEF")]
	[AsyncStateMachine(typeof(<_moveTypeUpdateAsync>d__37))]
	[Token(Token = "0x6000211")]
	private UniTask _moveTypeUpdateAsync(CancellationToken token, TaskFlags _flags) { }

	[Address(RVA = "0x1CDCE50", Offset = "0x1CDC250", Length = "0x658")]
	[Token(Token = "0x6000235")]
	private Vector3 _rollForwardMove(Spline _sp, float _offset) { }

	[Address(RVA = "0x1CDBD00", Offset = "0x1CDB100", Length = "0x35F")]
	[Token(Token = "0x6000257")]
	private static InGameEnemyMoveBase() { }

	[Address(RVA = "0x1CDC170", Offset = "0x1CDB570", Length = "0x1F5")]
	[Token(Token = "0x6000256")]
	protected InGameEnemyMoveBase() { }

	[Address(RVA = "0x1CDB890", Offset = "0x1CDAC90", Length = "0x90")]
	[CompilerGenerated]
	[Token(Token = "0x6000258")]
	private void <ExecEvent>b__22_0(RouteEvent teve) { }

	[Address(RVA = "0x1CD8BA0", Offset = "0x1CD7FA0", Length = "0x47")]
	[Token(Token = "0x6000234")]
	private void AttenuationAngle(float nStep) { }

	[Address(RVA = "0x1CD8BF0", Offset = "0x1CD7FF0", Length = "0x14D")]
	[AsyncStateMachine(typeof(<BulletDirFireAsync>d__52))]
	[Token(Token = "0x6000220")]
	public UniTask BulletDirFireAsync(CancellationToken token, BulletTemplate bt, Transform mzt, Transform dirt, int overlapLoop = 0, Action<InGameBulletInterface> callback = null) { }

	[Address(RVA = "0x1CD8FE0", Offset = "0x1CD83E0", Length = "0x16B")]
	[AsyncStateMachine(typeof(<BulletFireAsync>d__51))]
	[Token(Token = "0x600021F")]
	public UniTask BulletFireAsync(CancellationToken token, BulletTemplate bt, bool isSelfDir, bool isNested, Transform muzzleTransform, Transform baseTransform, float offsetAngle = 0, int argLoopCount = 0, Action<InGameBulletInterface> callback = null) { }

	[Address(RVA = "0x1CD8E90", Offset = "0x1CD8290", Length = "0x14A")]
	[AsyncStateMachine(typeof(<BulletFireAsync>d__48))]
	[Token(Token = "0x600021C")]
	public UniTask BulletFireAsync(CancellationToken token, BulletTemplate bt, bool isSelfDir, string _hierarchyName = null, string _baseHierarhyName = null, float offsetAngle = 0, Action<InGameBulletInterface> callback = null) { }

	[Address(RVA = "0x1CD8D40", Offset = "0x1CD8140", Length = "0x14B")]
	[AsyncStateMachine(typeof(<BulletFireAsyncDelayed>d__50))]
	[Token(Token = "0x600021E")]
	public UniTask BulletFireAsyncDelayed(float tsec, CancellationToken token, BulletTemplate bt, bool isSelfDir, bool isNested, Transform muzzleTransform, Transform baseTransform, float offsetAngle) { }

	[Address(RVA = "0x1CD9150", Offset = "0x1CD8550", Length = "0x243")]
	[Token(Token = "0x600021D")]
	public void BulletFireByMuzzlePack(CancellationToken token, BulletTemplate bt, bool isSelfDir, bool isNest, string mzpackName, float delaySec = 0) { }

	[Address(RVA = "0x1CD9680", Offset = "0x1CD8A80", Length = "0x68")]
	[Token(Token = "0x6000200")]
	public override void Clear() { }

	[Address(RVA = "0x1CD93A0", Offset = "0x1CD87A0", Length = "0x2D2")]
	[Token(Token = "0x600020A")]
	public static void ClearSplineCaches() { }

	[Address(RVA = "0x1CD96F0", Offset = "0x1CD8AF0", Length = "0xC4")]
	[Token(Token = "0x60001F9")]
	public override CancellationTokenSource CreateLinkedToken() { }

	[Token(Token = "0x60001FF")]
	public abstract void CreateRouteData(EnemyData ed, Vector3 spos) { }

	[Address(RVA = "0x1CD97C0", Offset = "0x1CD8BC0", Length = "0x6E")]
	[Token(Token = "0x60001F7")]
	public void CreateRouteToken() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000242")]
	protected override void DebugPrint(string tstr) { }

	[Address(RVA = "0x1CD9830", Offset = "0x1CD8C30", Length = "0x47")]
	[Token(Token = "0x60001F8")]
	public void DeleteRouteToken() { }

	[Token(Token = "0x60001FE")]
	public abstract void EndRoute() { }

	[Address(RVA = "0x1CD9880", Offset = "0x1CD8C80", Length = "0x15F")]
	[Token(Token = "0x600022F")]
	protected Vector3 EvalCachedPosition(Spline spline, float rate) { }

	[Address(RVA = "0x1CD99E0", Offset = "0x1CD8DE0", Length = "0x1D2")]
	[Token(Token = "0x6000230")]
	protected Vector3 EvalCachedTangent(Spline spline, float rate) { }

	[Address(RVA = "0x1CD9BC0", Offset = "0x1CD8FC0", Length = "0x182")]
	[Token(Token = "0x6000231")]
	protected Vector3 EvalCachedUpVector(Spline spline, float rate) { }

	[Address(RVA = "0x1CD9D50", Offset = "0x1CD9150", Length = "0x49C")]
	[Token(Token = "0x6000209")]
	protected override void ExecEvent(RouteEvent _event, CancellationToken ct) { }

	[Address(RVA = "0x1CDA240", Offset = "0x1CD9640", Length = "0x2F")]
	[Token(Token = "0x6000254")]
	public void FireByRouteEvent(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1CDA210", Offset = "0x1CD9610", Length = "0x2C")]
	[Token(Token = "0x6000255")]
	public void FireByRouteEvent(CancellationToken token, RouteEvent _event, Action<InGameBulletInterface> callback) { }

	[Address(RVA = "0x1CDD4B0", Offset = "0x1CDC8B0", Length = "0x9")]
	[Token(Token = "0x6000249")]
	public float get_CurrentSpeed() { }

	[Address(RVA = "0x1CDD4C0", Offset = "0x1CDC8C0", Length = "0x11")]
	[Token(Token = "0x6000248")]
	public float get_DurationRemain() { }

	[Address(RVA = "0x1CDD4E0", Offset = "0x1CDC8E0", Length = "0xE")]
	[Token(Token = "0x600024B")]
	public Quaternion get_FirstRotate() { }

	[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
	[Token(Token = "0x6000243")]
	public MoveType get_GetMoveType() { }

	[Address(RVA = "0x1CDD4F0", Offset = "0x1CDC8F0", Length = "0x8")]
	[Token(Token = "0x600024C")]
	public bool get_IsDirtyTransform() { }

	[Address(RVA = "0x1CDD500", Offset = "0x1CDC900", Length = "0x17")]
	[Token(Token = "0x6000250")]
	public bool get_IsGroundDivision() { }

	[Address(RVA = "0x1CDD520", Offset = "0x1CDC920", Length = "0xB")]
	[Token(Token = "0x6000251")]
	public bool get_IsGroundSkyDivision() { }

	[Address(RVA = "0x1CDD530", Offset = "0x1CDC930", Length = "0x9")]
	[Token(Token = "0x6000246")]
	public float get_LocalDuration() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[Token(Token = "0x600024F")]
	protected PawnEnemy get_MasterEnemy() { }

	[Address(RVA = "0x1CDD570", Offset = "0x1CDC970", Length = "0x7")]
	[Token(Token = "0x600024D")]
	public State get_MoverState() { }

	[Address(RVA = "0x1CDD550", Offset = "0x1CDC950", Length = "0x19")]
	[Token(Token = "0x6000244")]
	public Vector3 get_MoveVector() { }

	[Address(RVA = "0x1CDD580", Offset = "0x1CDC980", Length = "0x20")]
	[Token(Token = "0x600024E")]
	public CancellationToken get_RouteToken() { }

	[Address(RVA = "0x1CDD5B0", Offset = "0x1CDC9B0", Length = "0x9")]
	[Token(Token = "0x600024A")]
	protected float get_SplineLength() { }

	[Address(RVA = "0x1CDD5C0", Offset = "0x1CDC9C0", Length = "0x9")]
	[Token(Token = "0x6000252")]
	public float get_SplineRate() { }

	[Address(RVA = "0x1CDD5D0", Offset = "0x1CDC9D0", Length = "0x19")]
	[Token(Token = "0x6000245")]
	public Vector3 get_SplineStartPosition() { }

	[Address(RVA = "0x1CDD5F0", Offset = "0x1CDC9F0", Length = "0x9")]
	[Token(Token = "0x6000247")]
	protected float get_WakeAfterSecond() { }

	[Address(RVA = "0x1CDA270", Offset = "0x1CD9670", Length = "0xD0")]
	[Token(Token = "0x600022D")]
	public MuzzlePacks GetMuzzlePack(string mname) { }

	[Address(RVA = "0x1CDA350", Offset = "0x1CD9750", Length = "0x214")]
	[Token(Token = "0x600020C")]
	private static RouteLutAsset GetRouteLut(string routeName) { }

	[Address(RVA = "0x1CDA570", Offset = "0x1CD9970", Length = "0x45")]
	[Token(Token = "0x600023D")]
	public Vector3 GetVelocityVector() { }

	[Address(RVA = "0x1CDA5C0", Offset = "0x1CD99C0", Length = "0xDE")]
	[Token(Token = "0x60001F6")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CDD600", Offset = "0x1CDCA00", Length = "0x20")]
	[Token(Token = "0x6000212")]
	private bool isAreaoutEnd() { }

	[Address(RVA = "0x1CDA6A0", Offset = "0x1CD9AA0", Length = "0x1B")]
	[Token(Token = "0x6000202")]
	public override bool IsBulletFire(Transform tchild) { }

	[Address(RVA = "0x1CDA6C0", Offset = "0x1CD9AC0", Length = "0x7C")]
	[Token(Token = "0x6000217")]
	private bool IsCheckFire(RouteEvent tevent) { }

	[Address(RVA = "0x1CDA740", Offset = "0x1CD9B40", Length = "0x76")]
	[Token(Token = "0x6000201")]
	public bool IsCleared() { }

	[Address(RVA = "0x1CDA7C0", Offset = "0x1CD9BC0", Length = "0xB")]
	[Token(Token = "0x6000240")]
	public bool IsDirectionMove() { }

	[Address(RVA = "0x1CDA7D0", Offset = "0x1CD9BD0", Length = "0xF")]
	[Token(Token = "0x600020F")]
	protected bool IsDriftType(LookAtType lt) { }

	[Address(RVA = "0x1CDA7E0", Offset = "0x1CD9BE0", Length = "0x1F6")]
	[Token(Token = "0x6000218")]
	private bool IsEntryFireArea(RouteEvent tevent) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000204")]
	public override bool IsForceFire() { }

	[Address(RVA = "0x1CDA9E0", Offset = "0x1CD9DE0", Length = "0x17")]
	[Token(Token = "0x600023F")]
	public bool IsHormingMove() { }

	[Address(RVA = "0x1CDAA00", Offset = "0x1CD9E00", Length = "0x8")]
	[Token(Token = "0x6000222")]
	public bool IsLaserCancel() { }

	[Address(RVA = "0x1CDAA10", Offset = "0x1CD9E10", Length = "0xB")]
	[Token(Token = "0x600023A")]
	public bool IsPausing() { }

	[Address(RVA = "0x1CDAA40", Offset = "0x1CD9E40", Length = "0xB")]
	[Token(Token = "0x6000239")]
	public virtual bool IsPlaying() { }

	[Address(RVA = "0x1CDAA20", Offset = "0x1CD9E20", Length = "0x17")]
	[Token(Token = "0x600023B")]
	public bool IsPlayStart() { }

	[Address(RVA = "0x1CDAA50", Offset = "0x1CD9E50", Length = "0x17F")]
	[Token(Token = "0x6000203")]
	private bool IsPossibleFire(Transform mzl, Transform bzl) { }

	[Address(RVA = "0x1CDABD0", Offset = "0x1CD9FD0", Length = "0x1E")]
	[Token(Token = "0x6000241")]
	protected bool IsSplineMove() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000219")]
	protected override bool IsTurning(Transform tchild) { }

	[Address(RVA = "0x1CDABF0", Offset = "0x1CD9FF0", Length = "0x1F2")]
	[Token(Token = "0x600020B")]
	public static void RegisterRouteLut(RouteLutAsset lutAsset, string assetPath = null) { }

	[Address(RVA = "0x1CDADF0", Offset = "0x1CDA1F0", Length = "0x79")]
	[Token(Token = "0x60001F4")]
	public void ResetBulletFire() { }

	[Address(RVA = "0x1CDAE70", Offset = "0x1CDA270", Length = "0xB")]
	[Token(Token = "0x60001FD")]
	public void ResetTargetPlayer() { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[Token(Token = "0x60001F5")]
	public void SetBulletFire(OnBulletFire tfire) { }

	[Address(RVA = "0x1CDAEA0", Offset = "0x1CDA2A0", Length = "0x7")]
	[Token(Token = "0x600022C")]
	public void SetDirtyTransform(bool v) { }

	[Address(RVA = "0x1CDAEB0", Offset = "0x1CDA2B0", Length = "0x3D")]
	[Token(Token = "0x600022A")]
	public void SetDivision(PawnEnemy penemy, Division tdivision) { }

	[Address(RVA = "0x1CDAEF0", Offset = "0x1CDA2F0", Length = "0x7")]
	[Token(Token = "0x6000225")]
	public void SetEaseType(EasingType etype) { }

	[Address(RVA = "0x1CDAF00", Offset = "0x1CDA300", Length = "0x7")]
	[Token(Token = "0x6000221")]
	public void SetLaserCanselFlag(bool sw) { }

	[Address(RVA = "0x1CDAF10", Offset = "0x1CDA310", Length = "0x7")]
	[Token(Token = "0x6000227")]
	public void SetLookAtType(LookAtType ltype) { }

	[Address(RVA = "0x1CDAF40", Offset = "0x1CDA340", Length = "0x7")]
	[Token(Token = "0x600023E")]
	protected void SetMoverState(State tstate) { }

	[Address(RVA = "0xE26DD0", Offset = "0xE261D0", Length = "0x7")]
	[Token(Token = "0x6000213")]
	private void SetMoveType(MoveType mt) { }

	[Address(RVA = "0x1CDAF20", Offset = "0x1CDA320", Length = "0x16")]
	[Token(Token = "0x6000223")]
	public void SetMoveVector(Vector3 tvec) { }

	[Address(RVA = "0x1CDAF50", Offset = "0x1CDA350", Length = "0x7")]
	[Token(Token = "0x6000226")]
	public void SetNextEaseType(EasingType nextEaseType) { }

	[Address(RVA = "0x1CDAF60", Offset = "0x1CDA360", Length = "0x1E")]
	[Token(Token = "0x6000228")]
	public void SetNextLookAtType(LookAtType ltype, Vector3 rot) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600021A")]
	public override void SetNoTrun(bool tflag, Transform tchild) { }

	[Address(RVA = "0x1CDB150", Offset = "0x1CDA550", Length = "0x43E")]
	[Token(Token = "0x6000208")]
	public void SetRotate(Quaternion q, LookAtType lktype) { }

	[Address(RVA = "0x1CDB120", Offset = "0x1CDA520", Length = "0x25")]
	[Token(Token = "0x6000206")]
	public void SetRotate(Quaternion q) { }

	[Address(RVA = "0x1CDAF80", Offset = "0x1CDA380", Length = "0x197")]
	[Token(Token = "0x6000207")]
	public void SetRotateUpdate(Quaternion q) { }

	[Address(RVA = "0x1CDB5A0", Offset = "0x1CDA9A0", Length = "0x7")]
	[Token(Token = "0x6000224")]
	public void SetSmooth(bool value) { }

	[Address(RVA = "0x1CDB590", Offset = "0x1CDA990", Length = "0x9")]
	[Token(Token = "0x600023C")]
	public void SetSmoothRotateParam(float _value = 0.1) { }

	[Address(RVA = "0x1CDB5B0", Offset = "0x1CDA9B0", Length = "0x9")]
	[Token(Token = "0x6000205")]
	public void SetSpeed(float v) { }

	[Address(RVA = "0x1CDB5C0", Offset = "0x1CDA9C0", Length = "0x1A4")]
	[Token(Token = "0x600022B")]
	public override void SetSpline(Spline _sc, float _length, string routeName) { }

	[Address(RVA = "0x1CDB770", Offset = "0x1CDAB70", Length = "0x7")]
	[Token(Token = "0x60001FC")]
	public void SetTargetPlayer(int pno) { }

	[Address(RVA = "0x1CDB790", Offset = "0x1CDAB90", Length = "0x37")]
	[Token(Token = "0x60001FB")]
	public void SetupStartRoute() { }

	[Address(RVA = "0x1CDB780", Offset = "0x1CDAB80", Length = "0x9")]
	[Token(Token = "0x6000229")]
	public void SetWakeAfterSecond(float tsec) { }

	[Address(RVA = "0x1CDB7D0", Offset = "0x1CDABD0", Length = "0x14")]
	[Token(Token = "0x60001FA")]
	public void TokenCancel() { }

	[Address(RVA = "0x1CDB7F0", Offset = "0x1CDABF0", Length = "0x94")]
	[Token(Token = "0x600020D")]
	public static bool TryGetRouteLut(string routeName, out RouteLutAsset lutAsset) { }

	[Address(RVA = "0x1CDD620", Offset = "0x1CDCA20", Length = "0x229")]
	[Token(Token = "0x6000214")]
	private void updateHormingDirection() { }

}

