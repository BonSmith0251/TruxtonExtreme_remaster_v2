namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x2000242")]
internal sealed class AsyncUniTaskVoid : IStateMachineRunner, ITaskPoolNode<AsyncUniTaskVoid`1<TStateMachine>>, IUniTaskSource
{
	[CompilerGenerated]
	[Token(Token = "0x2000243")]
	private sealed class <>c
	{
		[Token(Token = "0x4000621")]
		public static readonly <>c<TStateMachine> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000CEA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CEB")]
		public <>c() { }

		[Address(RVA = "0xA35A50", Offset = "0xA34E50", Length = "0x77")]
		[Token(Token = "0x6000CEC")]
		internal int <.cctor>b__10_0() { }

	}

	[Token(Token = "0x400061C")]
	private static TaskPool<AsyncUniTaskVoid`1<TStateMachine>> pool; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400061D")]
	private readonly Action <ReturnAction>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400061E")]
	private TStateMachine stateMachine; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400061F")]
	private readonly Action <MoveNext>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000620")]
	private AsyncUniTaskVoid<TStateMachine> nextNode; //Field offset: 0x0

	[Token(Token = "0x17000083")]
	public override Action MoveNext
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CDF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000084")]
	public override AsyncUniTaskVoid<TStateMachine>& NextNode
	{
		[Address(RVA = "0x1388F90", Offset = "0x1388390", Length = "0x5")]
		[Token(Token = "0x6000CE3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000082")]
	public override Action ReturnAction
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CDE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13876A0", Offset = "0x1386AA0", Length = "0x172")]
	[Token(Token = "0x6000CE2")]
	private static AsyncUniTaskVoid`1() { }

	[Address(RVA = "0x1388E00", Offset = "0x1388200", Length = "0xBD")]
	[Token(Token = "0x6000CE0")]
	public AsyncUniTaskVoid`1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CE9")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000CE6")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CE8")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000CE7")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CDF")]
	public override Action get_MoveNext() { }

	[Address(RVA = "0x1388F90", Offset = "0x1388390", Length = "0x5")]
	[Token(Token = "0x6000CE3")]
	public override AsyncUniTaskVoid<TStateMachine>& get_NextNode() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CDE")]
	public override Action get_ReturnAction() { }

	[Address(RVA = "0x137FA30", Offset = "0x137EE30", Length = "0xA0")]
	[Token(Token = "0x6000CE4")]
	public override void Return() { }

	[Address(RVA = "0x13802A0", Offset = "0x137F6A0", Length = "0x1B")]
	[DebuggerHidden]
	[Token(Token = "0x6000CE5")]
	private void Run() { }

	[Address(RVA = "0x1383AB0", Offset = "0x1382EB0", Length = "0x245")]
	[Token(Token = "0x6000CE1")]
	public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunner runnerFieldRef) { }

}

