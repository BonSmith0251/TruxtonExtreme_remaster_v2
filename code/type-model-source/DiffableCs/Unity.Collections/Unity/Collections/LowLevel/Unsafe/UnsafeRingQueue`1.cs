namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200013C")]
public struct UnsafeRingQueue : INativeDisposable, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000517")]
	public T* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000518")]
	public AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000519")]
	internal readonly int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400051A")]
	internal int m_Filled; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400051B")]
	internal int m_Write; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400051C")]
	internal int m_Read; //Field offset: 0x0

	[Token(Token = "0x17000197")]
	public int Capacity
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000D6A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000198")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000D6F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000195")]
	public bool IsEmpty
	{
		[Address(RVA = "0x11E0B70", Offset = "0x11DFF70", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000D68")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000196")]
	public int Length
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[IsReadOnly]
		[Token(Token = "0x6000D69")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x11E0AF0", Offset = "0x11DFEF0", Length = "0x7F")]
	[Token(Token = "0x6000D6B")]
	public UnsafeRingQueue`1(T* ptr, int capacity) { }

	[Address(RVA = "0x11E0910", Offset = "0x11DFD10", Length = "0x8A")]
	[Token(Token = "0x6000D6C")]
	public UnsafeRingQueue`1(int capacity, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x11DF9F0", Offset = "0x11DEDF0", Length = "0x44")]
	[Token(Token = "0x6000D6D")]
	internal static UnsafeRingQueue<T>* Alloc(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DFA40", Offset = "0x11DEE40", Length = "0x48")]
	[Token(Token = "0x6000D79")]
	public T Dequeue() { }

	[Address(RVA = "0x11DFF30", Offset = "0x11DF330", Length = "0x10F")]
	[Token(Token = "0x6000D71")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11DFE50", Offset = "0x11DF250", Length = "0xD7")]
	[Token(Token = "0x6000D70")]
	public override void Dispose() { }

	[Address(RVA = "0x11E0130", Offset = "0x11DF530", Length = "0x55")]
	[Token(Token = "0x6000D75")]
	public void Enqueue(T value) { }

	[Address(RVA = "0x11E02A0", Offset = "0x11DF6A0", Length = "0xBA")]
	[Token(Token = "0x6000D6E")]
	internal static void Free(UnsafeRingQueue<T>* data) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000D6A")]
	public int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000D6F")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11E0B70", Offset = "0x11DFF70", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000D68")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[IsReadOnly]
	[Token(Token = "0x6000D69")]
	public int get_Length() { }

	[Address(RVA = "0x11E0360", Offset = "0x11DF760", Length = "0x49")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000D78")]
	private static void ThrowQueueEmpty() { }

	[Address(RVA = "0x11E03B0", Offset = "0x11DF7B0", Length = "0x49")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000D74")]
	private static void ThrowQueueFull() { }

	[Address(RVA = "0x11E05D0", Offset = "0x11DF9D0", Length = "0x65")]
	[Token(Token = "0x6000D77")]
	public bool TryDequeue(out T item) { }

	[Address(RVA = "0x11E0400", Offset = "0x11DF800", Length = "0x31")]
	[Token(Token = "0x6000D76")]
	private bool TryDequeueInternal(out T item) { }

	[Address(RVA = "0x11E08A0", Offset = "0x11DFCA0", Length = "0x64")]
	[Token(Token = "0x6000D73")]
	public bool TryEnqueue(T value) { }

	[Address(RVA = "0x11E0780", Offset = "0x11DFB80", Length = "0x30")]
	[Token(Token = "0x6000D72")]
	private bool TryEnqueueInternal(T value) { }

}

