namespace System.Threading;

[Token(Token = "0x2000239")]
internal sealed class ThreadPoolWorkQueue
{
	[Token(Token = "0x200023C")]
	public class QueueSegment
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A40")]
		internal readonly IThreadPoolWorkItem[] nodes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A41")]
		private int indexes; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A42")]
		public QueueSegment Next; //Field offset: 0x20

		[Address(RVA = "0x20B2EC0", Offset = "0x20B22C0", Length = "0x55")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x6001312")]
		public QueueSegment() { }

		[Address(RVA = "0x20B2B80", Offset = "0x20B1F80", Length = "0x7C")]
		[Token(Token = "0x6001311")]
		private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

		[Address(RVA = "0x20B2C00", Offset = "0x20B2000", Length = "0x3C")]
		[Token(Token = "0x6001310")]
		private void GetIndexes(out int upper, out int lower) { }

		[Address(RVA = "0x20B2C40", Offset = "0x20B2040", Length = "0x51")]
		[Token(Token = "0x6001313")]
		public bool IsUsedUp() { }

		[Address(RVA = "0x20B2CA0", Offset = "0x20B20A0", Length = "0x149")]
		[Token(Token = "0x6001315")]
		public bool TryDequeue(out IThreadPoolWorkItem node) { }

		[Address(RVA = "0x20B2DF0", Offset = "0x20B21F0", Length = "0xC0")]
		[Token(Token = "0x6001314")]
		public bool TryEnqueue(IThreadPoolWorkItem node) { }

	}

	[Token(Token = "0x200023A")]
	public class SparseArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A3A")]
		private T[] m_array; //Field offset: 0x0

		[Token(Token = "0x170001C2")]
		internal T[] Current
		{
			[Address(RVA = "0xFAB6D0", Offset = "0xFAAAD0", Length = "0x18")]
			[Token(Token = "0x6001307")]
			internal get { } //Length: 24
		}

		[Address(RVA = "0xFAB660", Offset = "0xFAAA60", Length = "0x6E")]
		[Token(Token = "0x6001306")]
		internal SparseArray`1(int initialSize) { }

		[Address(RVA = "0xFAB2B0", Offset = "0xFAA6B0", Length = "0x23D")]
		[Token(Token = "0x6001308")]
		internal int Add(T e) { }

		[Address(RVA = "0xFAB6D0", Offset = "0xFAAAD0", Length = "0x18")]
		[Token(Token = "0x6001307")]
		internal T[] get_Current() { }

		[Address(RVA = "0xFAB4F0", Offset = "0xFAA8F0", Length = "0x167")]
		[Token(Token = "0x6001309")]
		internal void Remove(T e) { }

	}

	[Token(Token = "0x200023B")]
	public class WorkStealingQueue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A3B")]
		internal IThreadPoolWorkItem[] m_array; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A3C")]
		private int m_mask; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A3D")]
		private int m_headIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A3E")]
		private int m_tailIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000A3F")]
		private SpinLock m_foreignLock; //Field offset: 0x24

		[Address(RVA = "0x20C75A0", Offset = "0x20C69A0", Length = "0x91")]
		[Token(Token = "0x600130F")]
		public WorkStealingQueue() { }

		[Address(RVA = "0x20C6710", Offset = "0x20C5B10", Length = "0x312")]
		[Token(Token = "0x600130B")]
		public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x20C6A30", Offset = "0x20C5E30", Length = "0x356")]
		[Token(Token = "0x600130C")]
		public bool LocalPop(out IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x20C6D90", Offset = "0x20C6190", Length = "0x550")]
		[Token(Token = "0x600130A")]
		public void LocalPush(IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x20C7580", Offset = "0x20C6980", Length = "0x1A")]
		[Token(Token = "0x600130D")]
		public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

		[Address(RVA = "0x20C72F0", Offset = "0x20C66F0", Length = "0x28C")]
		[Token(Token = "0x600130E")]
		private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	}

	[Token(Token = "0x4000A38")]
	internal static SparseArray<WorkStealingQueue> allThreadQueues; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A36")]
	internal QueueSegment queueHead; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A37")]
	internal QueueSegment queueTail; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A39")]
	private int numOutstandingThreadRequests; //Field offset: 0x20

	[Address(RVA = "0x20C1B90", Offset = "0x20C0F90", Length = "0x89")]
	[Token(Token = "0x6001305")]
	private static ThreadPoolWorkQueue() { }

	[Address(RVA = "0x20C1C20", Offset = "0x20C1020", Length = "0xBD")]
	[Token(Token = "0x60012FD")]
	public ThreadPoolWorkQueue() { }

	[Address(RVA = "0x20C0F60", Offset = "0x20C0360", Length = "0x358")]
	[Token(Token = "0x6001303")]
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	[Address(RVA = "0x20C12C0", Offset = "0x20C06C0", Length = "0x4BB")]
	[Token(Token = "0x6001304")]
	internal static bool Dispatch() { }

	[Address(RVA = "0x20C1780", Offset = "0x20C0B80", Length = "0x21E")]
	[Token(Token = "0x6001301")]
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	[Address(RVA = "0x20C19A0", Offset = "0x20C0DA0", Length = "0x99")]
	[Token(Token = "0x60012FE")]
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	[Address(RVA = "0x20C1A40", Offset = "0x20C0E40", Length = "0x96")]
	[Token(Token = "0x60012FF")]
	internal void EnsureThreadRequested() { }

	[Address(RVA = "0x20C1AE0", Offset = "0x20C0EE0", Length = "0x5F")]
	[Token(Token = "0x6001302")]
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	[Address(RVA = "0x20C1B40", Offset = "0x20C0F40", Length = "0x49")]
	[Token(Token = "0x6001300")]
	internal void MarkThreadRequestSatisfied() { }

}

