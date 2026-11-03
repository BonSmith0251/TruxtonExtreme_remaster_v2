namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
[Token(Token = "0x20005D1")]
public class ConcurrentQueue : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[CompilerGenerated]
	[Token(Token = "0x20005D4")]
	private sealed class <Enumerate>d__28 : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400181F")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001820")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001821")]
		public Segment<T> head; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001822")]
		public Segment<T> tail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001823")]
		public int tailTail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001824")]
		public int headHead; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001825")]
		public ConcurrentQueue<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001826")]
		private int <headTail>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001827")]
		private int <i>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001828")]
		private Segment<T> <s>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001829")]
		private int <i>5__5; //Field offset: 0x0

		[Token(Token = "0x170006A3")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x16F54C0", Offset = "0x16F48C0", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002B29")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170006A4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16F54D0", Offset = "0x16F48D0", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x6002B2B")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6002B26")]
		public <Enumerate>d__28(int <>1__state) { }

		[Address(RVA = "0x16F50A0", Offset = "0x16F44A0", Length = "0x350")]
		[Token(Token = "0x6002B28")]
		private override bool MoveNext() { }

		[Address(RVA = "0x16F54C0", Offset = "0x16F48C0", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002B29")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x16F54D0", Offset = "0x16F48D0", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x6002B2B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6002B2A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6002B27")]
		private override void System.IDisposable.Dispose() { }

	}

	[DebuggerDisplay("Capacity = {Capacity}")]
	[Token(Token = "0x20005D2")]
	public sealed class Segment
	{
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		[Token(Token = "0x20005D3")]
		public struct Slot
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400181D")]
			public T Item; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400181E")]
			public int SequenceNumber; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001817")]
		internal readonly Slot<T>[] _slots; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001818")]
		internal readonly int _slotsMask; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001819")]
		internal PaddedHeadAndTail _headAndTail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400181A")]
		internal bool _preservedForObservation; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400181B")]
		internal bool _frozenForEnqueues; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400181C")]
		internal Segment<T> _nextSegment; //Field offset: 0x0

		[Token(Token = "0x170006A1")]
		internal int Capacity
		{
			[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
			[Token(Token = "0x6002B21")]
			internal get { } //Length: 26
		}

		[Token(Token = "0x170006A2")]
		internal int FreezeOffset
		{
			[Address(RVA = "0xF59040", Offset = "0xF58440", Length = "0x1C")]
			[Token(Token = "0x6002B22")]
			internal get { } //Length: 28
		}

		[Address(RVA = "0xF58EC0", Offset = "0xF582C0", Length = "0xB7")]
		[Token(Token = "0x6002B20")]
		public Segment(int boundedLength) { }

		[Address(RVA = "0xF57F20", Offset = "0xF57320", Length = "0xC8")]
		[Token(Token = "0x6002B23")]
		internal void EnsureFrozenForEnqueues() { }

		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6002B21")]
		internal int get_Capacity() { }

		[Address(RVA = "0xF59040", Offset = "0xF58440", Length = "0x1C")]
		[Token(Token = "0x6002B22")]
		internal int get_FreezeOffset() { }

		[Address(RVA = "0xF586E0", Offset = "0xF57AE0", Length = "0x1B7")]
		[Token(Token = "0x6002B24")]
		public bool TryDequeue(out T item) { }

		[Address(RVA = "0xF58C40", Offset = "0xF58040", Length = "0x142")]
		[Token(Token = "0x6002B25")]
		public bool TryEnqueue(T item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001814")]
	private object _crossSegmentLock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001815")]
	private Segment<T> _tail; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001816")]
	private Segment<T> _head; //Field offset: 0x0

	[Token(Token = "0x170006A0")]
	public override int Count
	{
		[Address(RVA = "0x17BD1E0", Offset = "0x17BC5E0", Length = "0x358")]
		[Token(Token = "0x6002B14")]
		 get { } //Length: 856
	}

	[Token(Token = "0x1700069E")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B10")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700069F")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x17A9420", Offset = "0x17A8820", Length = "0x49")]
		[Token(Token = "0x6002B11")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x17BC930", Offset = "0x17BBD30", Length = "0xE4")]
	[Token(Token = "0x6002B0E")]
	public ConcurrentQueue`1() { }

	[Address(RVA = "0x17B9370", Offset = "0x17B8770", Length = "0x42A")]
	[Token(Token = "0x6002B17")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0x17BA0A0", Offset = "0x17B94A0", Length = "0x83")]
	[Token(Token = "0x6002B1C")]
	public void Enqueue(T item) { }

	[Address(RVA = "0x17B9C80", Offset = "0x17B9080", Length = "0x20C")]
	[Token(Token = "0x6002B1D")]
	private void EnqueueSlow(T item) { }

	[Address(RVA = "0x17BA360", Offset = "0x17B9760", Length = "0xD4")]
	[IteratorStateMachine(typeof(<Enumerate>d__28))]
	[Token(Token = "0x6002B1B")]
	private IEnumerator<T> Enumerate(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[Address(RVA = "0x17BD1E0", Offset = "0x17BC5E0", Length = "0x358")]
	[Token(Token = "0x6002B14")]
	public override int get_Count() { }

	[Address(RVA = "0x17BA700", Offset = "0x17B9B00", Length = "0xAD")]
	[Token(Token = "0x6002B15")]
	private static int GetCount(Segment<T> s, int head, int tail) { }

	[Address(RVA = "0x17BA7B0", Offset = "0x17B9BB0", Length = "0x170")]
	[Token(Token = "0x6002B16")]
	private static long GetCount(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[Address(RVA = "0x17BA9C0", Offset = "0x17B9DC0", Length = "0x8E")]
	[Token(Token = "0x6002B18")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x17BAE00", Offset = "0x17BA200", Length = "0xFE")]
	[Token(Token = "0x6002B1A")]
	private T GetItemWhenAvailable(Segment<T> segment, int i) { }

	[Address(RVA = "0x17BAF00", Offset = "0x17BA300", Length = "0x17F")]
	[Token(Token = "0x6002B19")]
	private void SnapForObservation(out Segment<T> head, out int headHead, out Segment<T> tail, out int tailTail) { }

	[Address(RVA = "0x17BB390", Offset = "0x17BA790", Length = "0xF8")]
	[Token(Token = "0x6002B0F")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B10")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x17A9420", Offset = "0x17A8820", Length = "0x49")]
	[Token(Token = "0x6002B11")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x17BB690", Offset = "0x17BAA90", Length = "0x45")]
	[Token(Token = "0x6002B12")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17BBA60", Offset = "0x17BAE60", Length = "0x3F4")]
	[Token(Token = "0x6002B13")]
	public override T[] ToArray() { }

	[Address(RVA = "0x17BC7B0", Offset = "0x17BBBB0", Length = "0x87")]
	[Token(Token = "0x6002B1E")]
	public bool TryDequeue(out T result) { }

	[Address(RVA = "0x17BC3C0", Offset = "0x17BB7C0", Length = "0x140")]
	[Token(Token = "0x6002B1F")]
	private bool TryDequeueSlow(out T item) { }

}

