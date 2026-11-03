namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(NativeRingQueueDebugView`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
[Token(Token = "0x20000BF")]
public struct NativeRingQueue : INativeDisposable, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003EA")]
	internal UnsafeRingQueue<T>* m_RingQueue; //Field offset: 0x0

	[Token(Token = "0x1700010A")]
	public int Capacity
	{
		[Address(RVA = "0xD92F50", Offset = "0xD92350", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x60008F4")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000107")]
	public bool IsCreated
	{
		[Address(RVA = "0xD92FC0", Offset = "0xD923C0", Length = "0x7F")]
		[IsReadOnly]
		[Token(Token = "0x60008F1")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000108")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD93040", Offset = "0xD92440", Length = "0x81")]
		[IsReadOnly]
		[Token(Token = "0x60008F2")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000109")]
	public int Length
	{
		[Address(RVA = "0xD930D0", Offset = "0xD924D0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x60008F3")]
		 get { } //Length: 112
	}

	[Address(RVA = "0xD92E60", Offset = "0xD92260", Length = "0xEB")]
	[Token(Token = "0x60008F5")]
	public NativeRingQueue`1(int capacity, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60008FC")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60008FD")]
	private void CheckWrite() { }

	[Address(RVA = "0xD92940", Offset = "0xD91D40", Length = "0xF4")]
	[Token(Token = "0x60008FB")]
	public T Dequeue() { }

	[Address(RVA = "0xD92B20", Offset = "0xD91F20", Length = "0xCD")]
	[Token(Token = "0x60008F6")]
	public override void Dispose() { }

	[Address(RVA = "0xD92A40", Offset = "0xD91E40", Length = "0xDE")]
	[Token(Token = "0x60008F7")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD92BF0", Offset = "0xD91FF0", Length = "0xE4")]
	[Token(Token = "0x60008F9")]
	public void Enqueue(T value) { }

	[Address(RVA = "0xD92F50", Offset = "0xD92350", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x60008F4")]
	public int get_Capacity() { }

	[Address(RVA = "0xD92FC0", Offset = "0xD923C0", Length = "0x7F")]
	[IsReadOnly]
	[Token(Token = "0x60008F1")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD93040", Offset = "0xD92440", Length = "0x81")]
	[IsReadOnly]
	[Token(Token = "0x60008F2")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD930D0", Offset = "0xD924D0", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x60008F3")]
	public int get_Length() { }

	[Address(RVA = "0xD92CE0", Offset = "0xD920E0", Length = "0x86")]
	[Token(Token = "0x60008FA")]
	public bool TryDequeue(out T item) { }

	[Address(RVA = "0xD92D70", Offset = "0xD92170", Length = "0xEC")]
	[Token(Token = "0x60008F8")]
	public bool TryEnqueue(T value) { }

}

