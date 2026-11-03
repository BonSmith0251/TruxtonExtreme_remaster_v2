namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200015E")]
internal sealed class Publish : IConnectableUniTaskAsyncEnumerable<TSource>, IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000160")]
	private sealed class _Publish : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable, ITriggerHandler<TSource>
	{
		[Token(Token = "0x4000E94")]
		private static readonly Action<Object> CancelDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E95")]
		private readonly Publish<TSource> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E96")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E97")]
		private CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E98")]
		private bool isDisposed; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E99")]
		private TSource <Current>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9A")]
		private ITriggerHandler<TSource> <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9B")]
		private ITriggerHandler<TSource> <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700002E")]
		public private override TSource Current
		{
			[Address(RVA = "0x16091F0", Offset = "0x16085F0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60006AC")]
			 get { } //Length: 176
			[Address(RVA = "0x16092A0", Offset = "0x16086A0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60006AD")]
			private set { } //Length: 189
		}

		[Token(Token = "0x17000030")]
		private override ITriggerHandler<TSource> Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Next
		{
			[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x60006B0")]
			private get { } //Length: 46
			[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x60006B1")]
			private set { } //Length: 111
		}

		[Token(Token = "0x1700002F")]
		private override ITriggerHandler<TSource> Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Prev
		{
			[Address(RVA = "0x1608800", Offset = "0x1607C00", Length = "0x2E")]
			[CompilerGenerated]
			[Token(Token = "0x60006AE")]
			private get { } //Length: 46
			[Address(RVA = "0x1608830", Offset = "0x1607C30", Length = "0x6F")]
			[CompilerGenerated]
			[Token(Token = "0x60006AF")]
			private set { } //Length: 111
		}

		[Address(RVA = "0x1608E80", Offset = "0x1608280", Length = "0xEA")]
		[Token(Token = "0x60006B9")]
		private static _Publish() { }

		[Address(RVA = "0x1608F70", Offset = "0x1608370", Length = "0x273")]
		[Token(Token = "0x60006AB")]
		public _Publish(Publish<TSource> parent, CancellationToken cancellationToken) { }

		[Address(RVA = "0x121B300", Offset = "0x121A700", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x60006B0")]
		private override ITriggerHandler<TSource> Cysharp.Threading.Tasks.ITriggerHandler<TSource>.get_Next() { }

		[Address(RVA = "0x1608800", Offset = "0x1607C00", Length = "0x2E")]
		[CompilerGenerated]
		[Token(Token = "0x60006AE")]
		private override ITriggerHandler<TSource> Cysharp.Threading.Tasks.ITriggerHandler<TSource>.get_Prev() { }

		[Address(RVA = "0x121B3E0", Offset = "0x121A7E0", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x60006B1")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.set_Next(ITriggerHandler<TSource> value) { }

		[Address(RVA = "0x1608830", Offset = "0x1607C30", Length = "0x6F")]
		[CompilerGenerated]
		[Token(Token = "0x60006AF")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.set_Prev(ITriggerHandler<TSource> value) { }

		[Address(RVA = "0x16088A0", Offset = "0x1607CA0", Length = "0x12D")]
		[Token(Token = "0x60006B4")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x16091F0", Offset = "0x16085F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60006AC")]
		public override TSource get_Current() { }

		[Address(RVA = "0x16089D0", Offset = "0x1607DD0", Length = "0x164")]
		[Token(Token = "0x60006B2")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1608B90", Offset = "0x1607F90", Length = "0x145")]
		[Token(Token = "0x60006B3")]
		private static void OnCanceled(object state) { }

		[Address(RVA = "0x1608B40", Offset = "0x1607F40", Length = "0x49")]
		[Token(Token = "0x60006B6")]
		public override void OnCanceled(CancellationToken cancellationToken) { }

		[Address(RVA = "0x1608CE0", Offset = "0x16080E0", Length = "0x3C")]
		[Token(Token = "0x60006B7")]
		public override void OnCompleted() { }

		[Address(RVA = "0x1608D20", Offset = "0x1608120", Length = "0x49")]
		[Token(Token = "0x60006B8")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x1608D70", Offset = "0x1608170", Length = "0x102")]
		[Token(Token = "0x60006B5")]
		public override void OnNext(TSource value) { }

		[Address(RVA = "0x16092A0", Offset = "0x16086A0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60006AD")]
		private void set_Current(TSource value) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000161")]
	private struct <ConsumeEnumerator>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9D")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9E")]
		public Publish<TSource> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E9F")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA0")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA1")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA2")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1143430", Offset = "0x1142830", Length = "0x943")]
		[Token(Token = "0x60006BA")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60006BB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200015F")]
	private sealed class ConnectDisposable : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E93")]
		private readonly CancellationTokenSource cancellationTokenSource; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006A9")]
		public ConnectDisposable(CancellationTokenSource cancellationTokenSource) { }

		[Address(RVA = "0x17BF7D0", Offset = "0x17BEBD0", Length = "0x1D")]
		[Token(Token = "0x60006AA")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E8D")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E8E")]
	private readonly CancellationTokenSource cancellationTokenSource; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E8F")]
	private TriggerEvent<TSource> trigger; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E90")]
	private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E91")]
	private IDisposable connectedDisposable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E92")]
	private bool isCompleted; //Field offset: 0x0

	[Address(RVA = "0xE7E230", Offset = "0xE7D630", Length = "0x79")]
	[Token(Token = "0x60006A5")]
	public Publish`1(IUniTaskAsyncEnumerable<TSource> source) { }

	[Address(RVA = "0xE7DF60", Offset = "0xE7D360", Length = "0x1BF")]
	[Token(Token = "0x60006A6")]
	public override IDisposable Connect() { }

	[Address(RVA = "0xE7E120", Offset = "0xE7D520", Length = "0x8D")]
	[AsyncStateMachine(typeof(<ConsumeEnumerator>d__8))]
	[Token(Token = "0x60006A7")]
	private UniTaskVoid ConsumeEnumerator() { }

	[Address(RVA = "0xE7E1B0", Offset = "0xE7D5B0", Length = "0x7E")]
	[Token(Token = "0x60006A8")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

