namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000EA")]
public class EnemyWaveBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000EB")]
	private struct <EnemyEmptyChecker>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400065D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400065E")]
		public EnemyWaveBehaviour <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400065F")]
		public CancellationToken token; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000660")]
		private int <areaindex>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000661")]
		private int <tindex>5__3; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000662")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1D45EC0", Offset = "0x1D452C0", Length = "0x2D6")]
		[Token(Token = "0x600079C")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600079D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000651")]
	private Vector3 _emitPos; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000652")]
	private Vector3 _emitRot; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000653")]
	private int _enemyIndexValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000654")]
	private int _ownerID; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000655")]
	private int _waveEnemyTotalCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000656")]
	private WaveBonus _bonus; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000657")]
	private string _enemyStr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000658")]
	private String[] _enemyFilters; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000659")]
	private bool _isEmptyAreaBonus; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x400065A")]
	private bool _isBonusDone; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400065B")]
	private CancellationToken _token; //Field offset: 0x50

	[Address(RVA = "0x1D35C30", Offset = "0x1D35030", Length = "0x503")]
	[Token(Token = "0x6000797")]
	private void _callEnmey() { }

	[Address(RVA = "0x1D36140", Offset = "0x1D35540", Length = "0x36")]
	[Token(Token = "0x600079B")]
	public EnemyWaveBehaviour() { }

	[Address(RVA = "0x1D35850", Offset = "0x1D34C50", Length = "0x1D5")]
	[AsyncStateMachine(typeof(<EnemyEmptyChecker>d__4))]
	[Token(Token = "0x6000799")]
	private UniTask EnemyEmptyChecker(CancellationToken token) { }

	[Address(RVA = "0x1D35A30", Offset = "0x1D34E30", Length = "0x37")]
	[Token(Token = "0x6000798")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D35A70", Offset = "0x1D34E70", Length = "0x11E")]
	[Token(Token = "0x6000795")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000796")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x1D35B90", Offset = "0x1D34F90", Length = "0x98")]
	[Token(Token = "0x600079A")]
	public void SetBonus(WaveBonus bonus, string enemyStr, bool isEmptyArea, int nEnemy, int _hashCode, String[] _filters, Vector3 epos, Vector3 erot, int enemyIndexValue, CancellationToken token) { }

}

