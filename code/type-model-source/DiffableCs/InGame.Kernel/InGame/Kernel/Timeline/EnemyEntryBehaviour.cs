namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E4")]
public class EnemyEntryBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000E5")]
	private sealed class <>c
	{
		[Token(Token = "0x400063D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400063E")]
		public static Func<PawnEnemy, Boolean> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x400063F")]
		public static Predicate<PawnEnemy> <>9__3_1; //Field offset: 0x10

		[Address(RVA = "0x1D478B0", Offset = "0x1D46CB0", Length = "0x67")]
		[Token(Token = "0x6000775")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000776")]
		public <>c() { }

		[Address(RVA = "0x1D47720", Offset = "0x1D46B20", Length = "0x22")]
		[Token(Token = "0x6000777")]
		internal bool <ProcessFrame>b__3_0(PawnEnemy n) { }

		[Address(RVA = "0x1D47720", Offset = "0x1D46B20", Length = "0x22")]
		[Token(Token = "0x6000778")]
		internal bool <ProcessFrame>b__3_1(PawnEnemy n) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000626")]
	private EnemyData _enemyData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000627")]
	private string _enemyDataName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000628")]
	private Transform _emitRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000629")]
	private int _loopWaveCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400062A")]
	private int _loopWaveMax; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400062B")]
	private bool _isLoopWave; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400062C")]
	private bool _isDestroyed; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400062D")]
	private bool _isGround; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x400062E")]
	private bool _isGroundSky; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400062F")]
	private bool _isDisplay; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4000630")]
	private bool _isSkipCall; //Field offset: 0x35
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4000631")]
	private bool _isOutMeansDestroy; //Field offset: 0x36
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000632")]
	private Vector3 _offset; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000633")]
	private Vector3[] _offsets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000634")]
	private Vector3 _rotate; //Field offset: 0x50
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000635")]
	private Kind _dropItemObject; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000636")]
	private float _startDelaySecond; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000637")]
	private float _loopDelaySecond; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000638")]
	private int _indexValue; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000639")]
	private int _offsetsIndex; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400063A")]
	private int _offsetsCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400063B")]
	private int _hashCode; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400063C")]
	private List<PawnEnemy> _enemysLists; //Field offset: 0x78

	[Address(RVA = "0x1D342B0", Offset = "0x1D336B0", Length = "0x464")]
	[Token(Token = "0x6000771")]
	private void _callEnemy(ref InGameManager gm) { }

	[Address(RVA = "0x1D34720", Offset = "0x1D33B20", Length = "0xA8")]
	[Token(Token = "0x6000774")]
	public EnemyEntryBehaviour() { }

	[Address(RVA = "0x1D33250", Offset = "0x1D32650", Length = "0x12")]
	[Token(Token = "0x6000772")]
	private float GetDelaySecond() { }

	[Address(RVA = "0x1D33270", Offset = "0x1D32670", Length = "0x96")]
	[Token(Token = "0x6000773")]
	private Vector3 GetOffset() { }

	[Address(RVA = "0x1D33310", Offset = "0x1D32710", Length = "0x1E7")]
	[Token(Token = "0x6000770")]
	private bool IsEnableCall(ref InGameManager gm, double ptime) { }

	[Address(RVA = "0x1D33500", Offset = "0x1D32900", Length = "0x1C")]
	[Token(Token = "0x600076E")]
	private bool IsLoopWaveBonus() { }

	[Address(RVA = "0x1D33520", Offset = "0x1D32920", Length = "0x24E")]
	[Token(Token = "0x600076D")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D33770", Offset = "0x1D32B70", Length = "0x182")]
	[Token(Token = "0x600076B")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D33900", Offset = "0x1D32D00", Length = "0xFC")]
	[Token(Token = "0x6000769")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x1D33A00", Offset = "0x1D32E00", Length = "0x85")]
	[Token(Token = "0x600076A")]
	public virtual void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x1D33A90", Offset = "0x1D32E90", Length = "0x571")]
	[Token(Token = "0x600076C")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x1D34010", Offset = "0x1D33410", Length = "0x294")]
	[Token(Token = "0x600076F")]
	public void Set(EnemyData edata, Transform _root, EnemyEntryClip clipData, int _code, int lpmax) { }

}

