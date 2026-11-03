namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200000E")]
public class ReadOnlyAsyncReactiveProperty : IReadOnlyAsyncReactiveProperty<T>, IUniTaskAsyncEnumerable<T>, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private struct <ConsumeEnumerator>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		public ReadOnlyAsyncReactiveProperty<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		public IUniTaskAsyncEnumerable<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1142910", Offset = "0x1141D10", Length = "0xB1A")]
		[Token(Token = "0x600007D")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600007E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000012")]
	private sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
	{
		[Token(Token = "0x4000039")]
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		private readonly ReadOnlyAsyncReactiveProperty<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		private readonly CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		private T value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		private bool isDisposed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private bool firstCall; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000011")]
		public override T Current
		{
			[Address(RVA = "0x19A8090", Offset = "0x19A7490", Length = "0xAD")]
			[Token(Token = "0x6000070")]
			 get { } //Length: 173
		}

		[Token(Token = "0x17000013")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[Address(RVA = "0x121B2D0", Offset = "0x121A6D0", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x6000073")]
			private get { } //Length: 46
			[Address(RVA = "0x121B340", Offset = "0x121A740", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x6000074")]
			private set { } //Length: 111
		}

		[Token(Token = "0x17000012")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x6000071")]
			private get { } //Length: 46
			[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x6000072")]
			private set { } //Length: 111
		}

		[Address(RVA = "0x19A4E00", Offset = "0x19A4200", Length = "0xEA")]
		[Token(Token = "0x600007C")]
		private static Enumerator() { }

		[Address(RVA = "0x19A6310", Offset = "0x19A5710", Length = "0x2BB")]
		[Token(Token = "0x600006F")]
		public Enumerator(ReadOnlyAsyncReactiveProperty<T> parent, CancellationToken cancellationToken, bool publishCurrentValue) { }

		[Address(RVA = "0x199B6C0", Offset = "0x199AAC0", Length = "0x146")]
		[Token(Token = "0x600007B")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x121B2D0", Offset = "0x121A6D0", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x6000073")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x6000071")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[Address(RVA = "0x121B340", Offset = "0x121A740", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x6000074")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x6000072")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		[Address(RVA = "0x199BA60", Offset = "0x199AE60", Length = "0x177")]
		[Token(Token = "0x6000076")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x19A8090", Offset = "0x19A7490", Length = "0xAD")]
		[Token(Token = "0x6000070")]
		public override T get_Current() { }

		[Address(RVA = "0x199CCC0", Offset = "0x199C0C0", Length = "0x20A")]
		[Token(Token = "0x6000075")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x19A17A0", Offset = "0x19A0BA0", Length = "0x3D")]
		[Token(Token = "0x6000078")]
		public override void OnCanceled(CancellationToken cancellationToken) { }

		[Address(RVA = "0x19A1820", Offset = "0x19A0C20", Length = "0x3C")]
		[Token(Token = "0x6000079")]
		public override void OnCompleted() { }

		[Address(RVA = "0x19A1860", Offset = "0x19A0C60", Length = "0x49")]
		[Token(Token = "0x600007A")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x19A1900", Offset = "0x19A0D00", Length = "0xF2")]
		[Token(Token = "0x6000077")]
		public override void OnNext(T value) { }

	}

	[Token(Token = "0x200000F")]
	private sealed class WaitAsyncSource : IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, ITaskPoolNode<WaitAsyncSource<T>>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000010")]
		private sealed class <>c
		{
			[Token(Token = "0x4000037")]
			public static readonly <>c<T> <>9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600006A")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600006B")]
			public <>c() { }

			[Address(RVA = "0xA36AB0", Offset = "0xA35EB0", Length = "0x9C")]
			[Token(Token = "0x600006C")]
			internal int <.cctor>b__5_0() { }

		}

		[Token(Token = "0x400002E")]
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		[Token(Token = "0x400002F")]
		private static TaskPool<WaitAsyncSource<T>> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		private WaitAsyncSource<T> nextNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		private ReadOnlyAsyncReactiveProperty<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		private CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700000E")]
		private override WaitAsyncSource<T> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.NextNode
		{
			[Address(RVA = "0x1413390", Offset = "0x1412790", Length = "0x1E")]
			[Token(Token = "0x6000057")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000010")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[Address(RVA = "0xE7D800", Offset = "0xE7CC00", Length = "0x2D")]
			[CompilerGenerated]
			[Token(Token = "0x6000064")]
			private get { } //Length: 45
			[Address(RVA = "0x115FC90", Offset = "0x115F090", Length = "0x6E")]
			[CompilerGenerated]
			[Token(Token = "0x6000065")]
			private set { } //Length: 110
		}

		[Token(Token = "0x1700000F")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[Address(RVA = "0x136E870", Offset = "0x136DC70", Length = "0x2D")]
			[CompilerGenerated]
			[Token(Token = "0x6000062")]
			private get { } //Length: 45
			[Address(RVA = "0x136E8A0", Offset = "0x136DCA0", Length = "0x6E")]
			[CompilerGenerated]
			[Token(Token = "0x6000063")]
			private set { } //Length: 110
		}

		[Address(RVA = "0x1413DA0", Offset = "0x14131A0", Length = "0x235")]
		[Token(Token = "0x6000058")]
		private static WaitAsyncSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000059")]
		private WaitAsyncSource() { }

		[Address(RVA = "0x14125D0", Offset = "0x14119D0", Length = "0x115")]
		[Token(Token = "0x600005C")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x14126F0", Offset = "0x1411AF0", Length = "0x644")]
		[Token(Token = "0x600005A")]
		public static IUniTaskSource<T> Create(ReadOnlyAsyncReactiveProperty<T> parent, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x1413390", Offset = "0x1412790", Length = "0x1E")]
		[Token(Token = "0x6000057")]
		private override WaitAsyncSource<T> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode() { }

		[Address(RVA = "0xE7D800", Offset = "0xE7CC00", Length = "0x2D")]
		[CompilerGenerated]
		[Token(Token = "0x6000064")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[Address(RVA = "0x136E870", Offset = "0x136DC70", Length = "0x2D")]
		[CompilerGenerated]
		[Token(Token = "0x6000062")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[Address(RVA = "0x115FC90", Offset = "0x115F090", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000065")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[Address(RVA = "0x136E8A0", Offset = "0x136DCA0", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000063")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		[Address(RVA = "0x14133B0", Offset = "0x14127B0", Length = "0xB8")]
		[Token(Token = "0x600005E")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1413470", Offset = "0x1412870", Length = "0x1EB")]
		[Token(Token = "0x600005D")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x1413660", Offset = "0x1412A60", Length = "0x6D")]
		[Token(Token = "0x6000060")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14136D0", Offset = "0x1412AD0", Length = "0x6D")]
		[Token(Token = "0x6000066")]
		public override void OnCanceled(CancellationToken cancellationToken) { }

		[Address(RVA = "0x1413740", Offset = "0x1412B40", Length = "0x98")]
		[Token(Token = "0x600005F")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14138B0", Offset = "0x1412CB0", Length = "0xC4")]
		[Token(Token = "0x6000067")]
		public override void OnCompleted() { }

		[Address(RVA = "0x1413980", Offset = "0x1412D80", Length = "0x6D")]
		[Token(Token = "0x6000068")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x14139F0", Offset = "0x1412DF0", Length = "0x117")]
		[Token(Token = "0x6000069")]
		public override void OnNext(T value) { }

		[Address(RVA = "0x1413B10", Offset = "0x1412F10", Length = "0x226")]
		[Token(Token = "0x600005B")]
		private bool TryReturn() { }

		[Address(RVA = "0x1413D40", Offset = "0x1413140", Length = "0x5D")]
		[Token(Token = "0x6000061")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000011")]
	private sealed class WithoutCurrentEnumerable : IUniTaskAsyncEnumerable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		private readonly ReadOnlyAsyncReactiveProperty<T> parent; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600006D")]
		public WithoutCurrentEnumerable(ReadOnlyAsyncReactiveProperty<T> parent) { }

		[Address(RVA = "0x154E430", Offset = "0x154D830", Length = "0x87")]
		[Token(Token = "0x600006E")]
		public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

	}

	[Token(Token = "0x400002D")]
	private static bool isValueType; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002A")]
	private TriggerEvent<T> triggerEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002B")]
	private T latestValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002C")]
	private IUniTaskAsyncEnumerator<T> enumerator; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	public override T Value
	{
		[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
		[Token(Token = "0x600004C")]
		 get { } //Length: 172
	}

	[Address(RVA = "0xEA7270", Offset = "0xEA6670", Length = "0xAE")]
	[Token(Token = "0x6000056")]
	private static ReadOnlyAsyncReactiveProperty`1() { }

	[Address(RVA = "0xEA7320", Offset = "0xEA6720", Length = "0x118")]
	[Token(Token = "0x600004D")]
	public ReadOnlyAsyncReactiveProperty`1(T initialValue, IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0xEA7440", Offset = "0xEA6840", Length = "0x7E")]
	[Token(Token = "0x600004E")]
	public ReadOnlyAsyncReactiveProperty`1(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0xEA69B0", Offset = "0xEA5DB0", Length = "0xC8")]
	[AsyncStateMachine(typeof(<ConsumeEnumerator>d__7))]
	[Token(Token = "0x600004F")]
	private UniTaskVoid ConsumeEnumerator(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0xEA6A80", Offset = "0xEA5E80", Length = "0x176")]
	[Token(Token = "0x6000052")]
	public override void Dispose() { }

	[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
	[Token(Token = "0x600004C")]
	public override T get_Value() { }

	[Address(RVA = "0xEA6C00", Offset = "0xEA6000", Length = "0x86")]
	[Token(Token = "0x6000051")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken) { }

	[Address(RVA = "0xEA74C0", Offset = "0xEA68C0", Length = "0xF5")]
	[Token(Token = "0x6000053")]
	public static T op_Implicit(ReadOnlyAsyncReactiveProperty<T> value) { }

	[Address(RVA = "0xEA6C90", Offset = "0xEA6090", Length = "0x34A")]
	[Token(Token = "0x6000054")]
	public virtual string ToString() { }

	[Address(RVA = "0xEA6FE0", Offset = "0xEA63E0", Length = "0x218")]
	[Token(Token = "0x6000055")]
	public override UniTask<T> WaitAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0xEA7200", Offset = "0xEA6600", Length = "0x6E")]
	[Token(Token = "0x6000050")]
	public override IUniTaskAsyncEnumerable<T> WithoutCurrent() { }

}

