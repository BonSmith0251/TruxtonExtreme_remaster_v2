namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x200016F")]
public abstract class AsyncTriggerBase : MonoBehaviour, IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x2000170")]
	private sealed class AsyncTriggerEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
	{
		[Token(Token = "0x400058D")]
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058E")]
		private readonly AsyncTriggerBase<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058F")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000590")]
		private CancellationTokenRegistration registration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000591")]
		private bool called; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000592")]
		private bool isDisposed; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000593")]
		private T <Current>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000594")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000595")]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000068")]
		public private override T Current
		{
			[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x600095A")]
			 get { } //Length: 11
			[Address(RVA = "0x121E6C0", Offset = "0x121DAC0", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x600095B")]
			private set { } //Length: 18
		}

		[Token(Token = "0x1700006A")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600095E")]
			private get { } //Length: 8
			[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x600095F")]
			private set { } //Length: 16
		}

		[Token(Token = "0x17000069")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600095C")]
			private get { } //Length: 5
			[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600095D")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x121DE90", Offset = "0x121D290", Length = "0xEA")]
		[Token(Token = "0x6000962")]
		private static AsyncTriggerEnumerator() { }

		[Address(RVA = "0x121E340", Offset = "0x121D740", Length = "0x4D")]
		[Token(Token = "0x6000954")]
		public AsyncTriggerEnumerator(AsyncTriggerBase<T> parent, CancellationToken cancellationToken) { }

		[Address(RVA = "0x121B190", Offset = "0x121A590", Length = "0x11B")]
		[Token(Token = "0x6000959")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600095E")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600095C")]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x600095F")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600095D")]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		[Address(RVA = "0x121B5F0", Offset = "0x121A9F0", Length = "0x71")]
		[Token(Token = "0x6000961")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x600095A")]
		public override T get_Current() { }

		[Address(RVA = "0x121BCE0", Offset = "0x121B0E0", Length = "0x1DF")]
		[Token(Token = "0x6000960")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x121CE90", Offset = "0x121C290", Length = "0x49")]
		[Token(Token = "0x6000955")]
		public override void OnCanceled(CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x121D2E0", Offset = "0x121C6E0", Length = "0x3C")]
		[Token(Token = "0x6000957")]
		public override void OnCompleted() { }

		[Address(RVA = "0x121D490", Offset = "0x121C890", Length = "0x49")]
		[Token(Token = "0x6000958")]
		public override void OnError(Exception ex) { }

		[Address(RVA = "0x121D730", Offset = "0x121CB30", Length = "0x5A")]
		[Token(Token = "0x6000956")]
		public override void OnNext(T value) { }

		[Address(RVA = "0x121E6C0", Offset = "0x121DAC0", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x600095B")]
		private void set_Current(T value) { }

	}

	[Token(Token = "0x2000171")]
	private class AwakeMonitor : IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000596")]
		private readonly AsyncTriggerBase<T> trigger; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000963")]
		public AwakeMonitor(AsyncTriggerBase<T> trigger) { }

		[Address(RVA = "0x1651C80", Offset = "0x1651080", Length = "0xAA")]
		[Token(Token = "0x6000964")]
		public override bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058A")]
	private TriggerEvent<T> triggerEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058B")]
	protected private bool calledAwake; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058C")]
	protected private bool calledDestroy; //Field offset: 0x0

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000953")]
	protected AsyncTriggerBase`1() { }

	[Address(RVA = "0x12197E0", Offset = "0x1218BE0", Length = "0xD8")]
	[Token(Token = "0x600094F")]
	internal void AddHandler(ITriggerHandler<T> handler) { }

	[Address(RVA = "0x12199A0", Offset = "0x1218DA0", Length = "0x5")]
	[Token(Token = "0x600094D")]
	private void Awake() { }

	[Address(RVA = "0x12199B0", Offset = "0x1218DB0", Length = "0x7C")]
	[Token(Token = "0x6000952")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1219C30", Offset = "0x1219030", Length = "0x23")]
	[Token(Token = "0x600094E")]
	private void OnDestroy() { }

	[Address(RVA = "0x1219C90", Offset = "0x1219090", Length = "0x2E")]
	[Token(Token = "0x6000951")]
	protected void RaiseEvent(T value) { }

	[Address(RVA = "0x121A1C0", Offset = "0x12195C0", Length = "0xD8")]
	[Token(Token = "0x6000950")]
	internal void RemoveHandler(ITriggerHandler<T> handler) { }

}

