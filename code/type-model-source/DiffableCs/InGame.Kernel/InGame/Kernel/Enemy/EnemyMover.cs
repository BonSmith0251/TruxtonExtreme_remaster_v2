namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000167")]
public class EnemyMover : SplineMover, IEnemyUpdater
{
	[CompilerGenerated]
	[Token(Token = "0x2000168")]
	private struct <StartRouteWithDelay>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A67")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A68")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A69")]
		public EnemyMover <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A6A")]
		public float startDelay; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A6B")]
		public float activeDelay; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A6C")]
		public Action startCallback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A6D")]
		public Action callback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A6E")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1D73990", Offset = "0x1D72D90", Length = "0x407")]
		[Token(Token = "0x6000B41")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000B42")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000A5A")]
	private CancellationTokenSource _callToken; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000A5B")]
	private bool _isRangeFireLimit; //Field offset: 0x290
	[FieldOffset(Offset = "0x291")]
	[Token(Token = "0x4000A5C")]
	private bool _isInGamePlayArea; //Field offset: 0x291
	[FieldOffset(Offset = "0x292")]
	[Token(Token = "0x4000A5D")]
	private bool _isForceFire; //Field offset: 0x292
	[FieldOffset(Offset = "0x293")]
	[Token(Token = "0x4000A5E")]
	private bool _inAreaStart; //Field offset: 0x293
	[CompilerGenerated]
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000A5F")]
	private bool <_isEventStackPlay>k__BackingField; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000A60")]
	private float _inAreaDelay; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000A61")]
	private float _startDelay; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000A62")]
	private float _eventStackDelay; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4000A63")]
	private int _eventStackIndex; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000A64")]
	private Dictionary<Int32, Int32> _loopCounters; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000A65")]
	private EnemyData _baseEnemyData; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000A66")]
	private bool _isFinishDelay; //Field offset: 0x2B8

	[Token(Token = "0x170001CD")]
	protected private bool _isEventStackPlay
	{
		[Address(RVA = "0x1D6D650", Offset = "0x1D6CA50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000B39")]
		 get { } //Length: 8
		[Address(RVA = "0x1D6CBE0", Offset = "0x1D6BFE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000B38")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170001CE")]
	public EnemyData BaseEnemyData
	{
		[Address(RVA = "0x1D6D5E0", Offset = "0x1D6C9E0", Length = "0x8")]
		[Token(Token = "0x6000B3E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001CA")]
	public bool IsCallWait
	{
		[Address(RVA = "0x1D6D5F0", Offset = "0x1D6C9F0", Length = "0x2A")]
		[Token(Token = "0x6000B35")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001CF")]
	public bool IsFinishDelay
	{
		[Address(RVA = "0x1D6D620", Offset = "0x1D6CA20", Length = "0x8")]
		[Token(Token = "0x6000B3F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001CB")]
	public bool IsRangeFireLimit
	{
		[Address(RVA = "0x1D6D630", Offset = "0x1D6CA30", Length = "0x8")]
		[Token(Token = "0x6000B36")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001CC")]
	public bool IsStayPlayArea
	{
		[Address(RVA = "0x1D6D640", Offset = "0x1D6CA40", Length = "0x8")]
		[Token(Token = "0x6000B37")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D6CDD0", Offset = "0x1D6C1D0", Length = "0x73")]
	[Token(Token = "0x6000B3D")]
	private void _clearEvent() { }

	[Address(RVA = "0x1D6CED0", Offset = "0x1D6C2D0", Length = "0x4FB")]
	[Token(Token = "0x6000B3C")]
	private void _execStackEvent(float dt) { }

	[Address(RVA = "0x1D6D3D0", Offset = "0x1D6C7D0", Length = "0x20B")]
	[Token(Token = "0x6000B3B")]
	private bool _isExecStackEvent(float dt) { }

	[Address(RVA = "0x1D6CE50", Offset = "0x1D6C250", Length = "0x7D")]
	[Token(Token = "0x6000B40")]
	public EnemyMover() { }

	[Address(RVA = "0x1D6C730", Offset = "0x1D6BB30", Length = "0x1F")]
	[Token(Token = "0x6000B29")]
	public virtual void Clear() { }

	[Address(RVA = "0x1D6C710", Offset = "0x1D6BB10", Length = "0x1F")]
	[Token(Token = "0x6000B2A")]
	public virtual void ClearToStart() { }

	[Address(RVA = "0x1D6C750", Offset = "0x1D6BB50", Length = "0x104")]
	[Token(Token = "0x6000B3A")]
	public virtual void CreateRouteData(EnemyData ed, Vector3 spos) { }

	[Address(RVA = "0x1D6D650", Offset = "0x1D6CA50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000B39")]
	protected bool get__isEventStackPlay() { }

	[Address(RVA = "0x1D6D5E0", Offset = "0x1D6C9E0", Length = "0x8")]
	[Token(Token = "0x6000B3E")]
	public EnemyData get_BaseEnemyData() { }

	[Address(RVA = "0x1D6D5F0", Offset = "0x1D6C9F0", Length = "0x2A")]
	[Token(Token = "0x6000B35")]
	public bool get_IsCallWait() { }

	[Address(RVA = "0x1D6D620", Offset = "0x1D6CA20", Length = "0x8")]
	[Token(Token = "0x6000B3F")]
	public bool get_IsFinishDelay() { }

	[Address(RVA = "0x1D6D630", Offset = "0x1D6CA30", Length = "0x8")]
	[Token(Token = "0x6000B36")]
	public bool get_IsRangeFireLimit() { }

	[Address(RVA = "0x1D6D640", Offset = "0x1D6CA40", Length = "0x8")]
	[Token(Token = "0x6000B37")]
	public bool get_IsStayPlayArea() { }

	[Address(RVA = "0x1D6C860", Offset = "0x1D6BC60", Length = "0x136")]
	[Token(Token = "0x6000B32")]
	public void InStartArea(Action startCallback) { }

	[Address(RVA = "0x1D6C9A0", Offset = "0x1D6BDA0", Length = "0x15A")]
	[Token(Token = "0x6000B2D")]
	public virtual bool IsBulletFire(Transform tchild) { }

	[Address(RVA = "0x1D6CB00", Offset = "0x1D6BF00", Length = "0x29")]
	[Token(Token = "0x6000B31")]
	public virtual bool IsForceFire() { }

	[Address(RVA = "0x1D6CB50", Offset = "0x1D6BF50", Length = "0x76")]
	[Token(Token = "0x6000B21")]
	public virtual void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B23")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B22")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D6CB30", Offset = "0x1D6BF30", Length = "0x7")]
	[Token(Token = "0x6000B1E")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000B25")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B1F")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B20")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B24")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D6CBE0", Offset = "0x1D6BFE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000B38")]
	private void set__isEventStackPlay(bool value) { }

	[Address(RVA = "0x1D6CBD0", Offset = "0x1D6BFD0", Length = "0x7")]
	[Token(Token = "0x6000B33")]
	public void SetAreaStart(bool value) { }

	[Address(RVA = "0x1D6CBE0", Offset = "0x1D6BFE0", Length = "0x7")]
	[Token(Token = "0x6000B34")]
	public void SetEventStack(bool value) { }

	[Address(RVA = "0x1D6CBF0", Offset = "0x1D6BFF0", Length = "0x7")]
	[Token(Token = "0x6000B30")]
	public void SetForceFire(bool v) { }

	[Address(RVA = "0x1D6CC00", Offset = "0x1D6C000", Length = "0x7")]
	[Token(Token = "0x6000B2F")]
	public void SetInGamePlayArea(bool v) { }

	[Address(RVA = "0x1D6CC10", Offset = "0x1D6C010", Length = "0x14")]
	[Token(Token = "0x6000B2C")]
	public void SetPlayPause(bool sw) { }

	[Address(RVA = "0x1D6CC30", Offset = "0x1D6C030", Length = "0x7")]
	[Token(Token = "0x6000B2E")]
	public void SetRangeFireLimit(bool v) { }

	[Address(RVA = "0x1D6CC40", Offset = "0x1D6C040", Length = "0x4D")]
	[Token(Token = "0x6000B2B")]
	public bool StartCanceled() { }

	[Address(RVA = "0x1D6CD90", Offset = "0x1D6C190", Length = "0x17")]
	[Token(Token = "0x6000B27")]
	public virtual void StartRoute(Action callback) { }

	[Address(RVA = "0x1D6CC90", Offset = "0x1D6C090", Length = "0xF1")]
	[AsyncStateMachine(typeof(<StartRouteWithDelay>d__8))]
	[Token(Token = "0x6000B26")]
	public UniTaskVoid StartRouteWithDelay(Action callback, float activeDelay, float startDelay, Action startCallback = null) { }

	[Address(RVA = "0x1D6CDB0", Offset = "0x1D6C1B0", Length = "0x12")]
	[Token(Token = "0x6000B28")]
	protected virtual void UpdateEvent(float s, float step) { }

}

