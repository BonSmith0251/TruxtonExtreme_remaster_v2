namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000009")]
public class AsyncReactiveProperty : IAsyncReactiveProperty<T>, IReadOnlyAsyncReactiveProperty<T>, IUniTaskAsyncEnumerable<T>, IDisposable
{
	[Token(Token = "0x200000D")]
	private sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
	{
		[Token(Token = "0x4000021")]
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		private readonly AsyncReactiveProperty<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		private readonly CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		private T value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private bool isDisposed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		private bool firstCall; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000029")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700000A")]
		public override T Current
		{
			[Address(RVA = "0x19A8090", Offset = "0x19A7490", Length = "0xAD")]
			[Token(Token = "0x600003F")]
			 get { } //Length: 173
		}

		[Token(Token = "0x1700000C")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[Address(RVA = "0x121B2D0", Offset = "0x121A6D0", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x6000042")]
			private get { } //Length: 46
			[Address(RVA = "0x121B340", Offset = "0x121A740", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x6000043")]
			private set { } //Length: 111
		}

		[Token(Token = "0x1700000B")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x6000040")]
			private get { } //Length: 46
			[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x6000041")]
			private set { } //Length: 111
		}

		[Address(RVA = "0x19A4D10", Offset = "0x19A4110", Length = "0xEA")]
		[Token(Token = "0x600004B")]
		private static Enumerator() { }

		[Address(RVA = "0x19A5110", Offset = "0x19A4510", Length = "0x2BB")]
		[Token(Token = "0x600003E")]
		public Enumerator(AsyncReactiveProperty<T> parent, CancellationToken cancellationToken, bool publishCurrentValue) { }

		[Address(RVA = "0x199B6C0", Offset = "0x199AAC0", Length = "0x146")]
		[Token(Token = "0x600004A")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x121B2D0", Offset = "0x121A6D0", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x6000042")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x6000040")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[Address(RVA = "0x121B340", Offset = "0x121A740", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x6000043")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x6000041")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		[Address(RVA = "0x199B810", Offset = "0x199AC10", Length = "0x177")]
		[Token(Token = "0x6000045")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x19A8090", Offset = "0x19A7490", Length = "0xAD")]
		[Token(Token = "0x600003F")]
		public override T get_Current() { }

		[Address(RVA = "0x199CFB0", Offset = "0x199C3B0", Length = "0x20A")]
		[Token(Token = "0x6000044")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x19A17A0", Offset = "0x19A0BA0", Length = "0x3D")]
		[Token(Token = "0x6000047")]
		public override void OnCanceled(CancellationToken cancellationToken) { }

		[Address(RVA = "0x19A17E0", Offset = "0x19A0BE0", Length = "0x3C")]
		[Token(Token = "0x6000048")]
		public override void OnCompleted() { }

		[Address(RVA = "0x19A18B0", Offset = "0x19A0CB0", Length = "0x49")]
		[Token(Token = "0x6000049")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x19A1A00", Offset = "0x19A0E00", Length = "0xF2")]
		[Token(Token = "0x6000046")]
		public override void OnNext(T value) { }

	}

	[Token(Token = "0x200000A")]
	private sealed class WaitAsyncSource : IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, ITaskPoolNode<WaitAsyncSource<T>>
	{
		[CompilerGenerated]
		[Token(Token = "0x200000B")]
		private sealed class <>c
		{
			[Token(Token = "0x400001F")]
			public static readonly <>c<T> <>9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000039")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600003A")]
			public <>c() { }

			[Address(RVA = "0xA36AB0", Offset = "0xA35EB0", Length = "0x9C")]
			[Token(Token = "0x600003B")]
			internal int <.cctor>b__5_0() { }

		}

		[Token(Token = "0x4000016")]
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		[Token(Token = "0x4000017")]
		private static TaskPool<WaitAsyncSource<T>> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000018")]
		private WaitAsyncSource<T> nextNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		private AsyncReactiveProperty<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001B")]
		private CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001C")]
		private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001D")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000007")]
		private override WaitAsyncSource<T> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.NextNode
		{
			[Address(RVA = "0x1413390", Offset = "0x1412790", Length = "0x1E")]
			[Token(Token = "0x6000026")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000009")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[Address(RVA = "0xE7D800", Offset = "0xE7CC00", Length = "0x2D")]
			[CompilerGenerated]
			[Token(Token = "0x6000033")]
			private get { } //Length: 45
			[Address(RVA = "0x115FC90", Offset = "0x115F090", Length = "0x6E")]
			[CompilerGenerated]
			[Token(Token = "0x6000034")]
			private set { } //Length: 110
		}

		[Token(Token = "0x17000008")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[Address(RVA = "0x136E870", Offset = "0x136DC70", Length = "0x2D")]
			[CompilerGenerated]
			[Token(Token = "0x6000031")]
			private get { } //Length: 45
			[Address(RVA = "0x136E8A0", Offset = "0x136DCA0", Length = "0x6E")]
			[CompilerGenerated]
			[Token(Token = "0x6000032")]
			private set { } //Length: 110
		}

		[Address(RVA = "0x1413FE0", Offset = "0x14133E0", Length = "0x235")]
		[Token(Token = "0x6000027")]
		private static WaitAsyncSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000028")]
		private WaitAsyncSource() { }

		[Address(RVA = "0x14125D0", Offset = "0x14119D0", Length = "0x115")]
		[Token(Token = "0x600002B")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x1412D40", Offset = "0x1412140", Length = "0x644")]
		[Token(Token = "0x6000029")]
		public static IUniTaskSource<T> Create(AsyncReactiveProperty<T> parent, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x1413390", Offset = "0x1412790", Length = "0x1E")]
		[Token(Token = "0x6000026")]
		private override WaitAsyncSource<T> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode() { }

		[Address(RVA = "0xE7D800", Offset = "0xE7CC00", Length = "0x2D")]
		[CompilerGenerated]
		[Token(Token = "0x6000033")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[Address(RVA = "0x136E870", Offset = "0x136DC70", Length = "0x2D")]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[Address(RVA = "0x115FC90", Offset = "0x115F090", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000034")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[Address(RVA = "0x136E8A0", Offset = "0x136DCA0", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000032")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		[Address(RVA = "0x14133B0", Offset = "0x14127B0", Length = "0xB8")]
		[Token(Token = "0x600002D")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1413470", Offset = "0x1412870", Length = "0x1EB")]
		[Token(Token = "0x600002C")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x1413660", Offset = "0x1412A60", Length = "0x6D")]
		[Token(Token = "0x600002F")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14136D0", Offset = "0x1412AD0", Length = "0x6D")]
		[Token(Token = "0x6000035")]
		public override void OnCanceled(CancellationToken cancellationToken) { }

		[Address(RVA = "0x1413740", Offset = "0x1412B40", Length = "0x98")]
		[Token(Token = "0x600002E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14137E0", Offset = "0x1412BE0", Length = "0xC4")]
		[Token(Token = "0x6000036")]
		public override void OnCompleted() { }

		[Address(RVA = "0x1413980", Offset = "0x1412D80", Length = "0x6D")]
		[Token(Token = "0x6000037")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x14139F0", Offset = "0x1412DF0", Length = "0x117")]
		[Token(Token = "0x6000038")]
		public override void OnNext(T value) { }

		[Address(RVA = "0x1413B10", Offset = "0x1412F10", Length = "0x226")]
		[Token(Token = "0x600002A")]
		private bool TryReturn() { }

		[Address(RVA = "0x1413D40", Offset = "0x1413140", Length = "0x5D")]
		[Token(Token = "0x6000030")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200000C")]
	private sealed class WithoutCurrentEnumerable : IUniTaskAsyncEnumerable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		private readonly AsyncReactiveProperty<T> parent; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600003C")]
		public WithoutCurrentEnumerable(AsyncReactiveProperty<T> parent) { }

		[Address(RVA = "0x154E430", Offset = "0x154D830", Length = "0x87")]
		[Token(Token = "0x600003D")]
		public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

	}

	[Token(Token = "0x4000015")]
	private static bool isValueType; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private T latestValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000013")]
	private TriggerEvent<T> triggerEvent; //Field offset: 0x0

	[Token(Token = "0x17000006")]
	public override T Value
	{
		[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 172
		[Address(RVA = "0x11694D0", Offset = "0x11688D0", Length = "0x174")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 372
	}

	[Address(RVA = "0x1169220", Offset = "0x1168620", Length = "0xAB")]
	[Token(Token = "0x6000025")]
	private static AsyncReactiveProperty`1() { }

	[Address(RVA = "0x11692D0", Offset = "0x11686D0", Length = "0xF1")]
	[Token(Token = "0x600001E")]
	public AsyncReactiveProperty`1(T value) { }

	[Address(RVA = "0x1168B70", Offset = "0x1167F70", Length = "0x50")]
	[Token(Token = "0x6000021")]
	public override void Dispose() { }

	[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
	[Token(Token = "0x600001C")]
	public override T get_Value() { }

	[Address(RVA = "0x1168BC0", Offset = "0x1167FC0", Length = "0x86")]
	[Token(Token = "0x6000020")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken) { }

	[Address(RVA = "0x11693D0", Offset = "0x11687D0", Length = "0xF5")]
	[Token(Token = "0x6000022")]
	public static T op_Implicit(AsyncReactiveProperty<T> value) { }

	[Address(RVA = "0x11694D0", Offset = "0x11688D0", Length = "0x174")]
	[Token(Token = "0x600001D")]
	public override void set_Value(T value) { }

	[Address(RVA = "0x1168C50", Offset = "0x1168050", Length = "0x33E")]
	[Token(Token = "0x6000023")]
	public virtual string ToString() { }

	[Address(RVA = "0x1168F90", Offset = "0x1168390", Length = "0x215")]
	[Token(Token = "0x6000024")]
	public override UniTask<T> WaitAsync(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x11691B0", Offset = "0x11685B0", Length = "0x6E")]
	[Token(Token = "0x600001F")]
	public override IUniTaskAsyncEnumerable<T> WithoutCurrent() { }

}

