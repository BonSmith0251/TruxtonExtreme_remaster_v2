namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000224")]
public class PawnEnemyDD : PawnEnemy
{
	[CompilerGenerated]
	[Token(Token = "0x2000226")]
	private struct <_progressEndAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400134C")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400134D")]
		public PawnEnemyDD <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400134E")]
		private float <tpass>5__2; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400134F")]
		private int <tstart>5__3; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001350")]
		private int <tmax>5__4; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4001351")]
		private Vector3 <targetVector>5__5; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001352")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x1D1AF70", Offset = "0x1D1A370", Length = "0x4B5")]
		[Token(Token = "0x6001077")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6001078")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000225")]
	internal class ExplosionOrder
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001347")]
		public Renderer _target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001348")]
		public float _WaitTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001349")]
		public Transform _effectTransform; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400134A")]
		public Explosion _ekind; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001076")]
		public ExplosionOrder() { }

	}

	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001343")]
	private float _delayDeadTime; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[SerializeField]
	[Token(Token = "0x4001344")]
	private Vector3 _delayDeadVector; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4001345")]
	private ExplosionOrder[] _explosionOrder; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001346")]
	private CancellationTokenSource _ddtoken; //Field offset: 0x1C8

	[Address(RVA = "0x1D17600", Offset = "0x1D16A00", Length = "0x8C")]
	[AsyncStateMachine(typeof(<_progressEndAsync>d__3))]
	[Token(Token = "0x6001073")]
	private UniTaskVoid _progressEndAsync() { }

	[Address(RVA = "0x1D17570", Offset = "0x1D16970", Length = "0x88")]
	[Token(Token = "0x6001074")]
	public PawnEnemyDD() { }

	[Address(RVA = "0x1D171C0", Offset = "0x1D165C0", Length = "0x3AD")]
	[CompilerGenerated]
	[Token(Token = "0x6001075")]
	private void <_progressEndAsync>g___startExplostion|3_0(ExplosionOrder bp) { }

	[Address(RVA = "0x1D16EF0", Offset = "0x1D162F0", Length = "0x2B")]
	[Token(Token = "0x6001072")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D16F20", Offset = "0x1D16320", Length = "0xE2")]
	[Token(Token = "0x6001070")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D17010", Offset = "0x1D16410", Length = "0x1AA")]
	[Token(Token = "0x6001071")]
	public virtual void ToDestroid() { }

}

