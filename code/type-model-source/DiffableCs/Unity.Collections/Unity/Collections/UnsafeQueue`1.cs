namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x20000EC")]
public struct UnsafeQueue : INativeDisposable, IDisposable
{
	[Token(Token = "0x20000ED")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000461")]
		internal UnsafeQueueBlockHeader* m_FirstBlock; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000462")]
		internal UnsafeQueueBlockHeader* m_Block; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000463")]
		internal int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000464")]
		private T value; //Field offset: 0x0

		[Token(Token = "0x17000131")]
		public override T Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x6000A56")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000132")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xE82CE0", Offset = "0xE820E0", Length = "0x5E")]
			[Token(Token = "0x6000A57")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A53")]
		public override void Dispose() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000A56")]
		public override T get_Current() { }

		[Address(RVA = "0x1987E70", Offset = "0x1987270", Length = "0x8D")]
		[Token(Token = "0x6000A54")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1988000", Offset = "0x1987400", Length = "0xF")]
		[Token(Token = "0x6000A55")]
		public override void Reset() { }

		[Address(RVA = "0xE82CE0", Offset = "0xE820E0", Length = "0x5E")]
		[Token(Token = "0x6000A57")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x20000EF")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000466")]
		internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000467")]
		internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeSetThreadIndex]
		[Token(Token = "0x4000468")]
		internal int m_ThreadIndex; //Field offset: 0x0

		[Address(RVA = "0xE1C440", Offset = "0xE1B840", Length = "0x9B")]
		[Token(Token = "0x6000A62")]
		public void Enqueue(T value) { }

		[Address(RVA = "0xE1C3A0", Offset = "0xE1B7A0", Length = "0x9A")]
		[Token(Token = "0x6000A63")]
		public void Enqueue(T value, int threadIndexOverride) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20000EE")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000465")]
		private UnsafeQueueData* m_Buffer; //Field offset: 0x0

		[Token(Token = "0x17000134")]
		public int Count
		{
			[Address(RVA = "0xE9E130", Offset = "0xE9D530", Length = "0x58")]
			[IsReadOnly]
			[Token(Token = "0x6000A5B")]
			 get { } //Length: 88
		}

		[Token(Token = "0x17000133")]
		public bool IsCreated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x6000A59")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000135")]
		public T Item
		{
			[Address(RVA = "0xE9E290", Offset = "0xE9D690", Length = "0xA3")]
			[IsReadOnly]
			[Token(Token = "0x6000A5C")]
			 get { } //Length: 163
		}

		[Address(RVA = "0xE9E120", Offset = "0xE9D520", Length = "0x7")]
		[Token(Token = "0x6000A58")]
		internal ReadOnly(ref UnsafeQueue<T>& data) { }

		[Address(RVA = "0xE9E130", Offset = "0xE9D530", Length = "0x58")]
		[IsReadOnly]
		[Token(Token = "0x6000A5B")]
		public int get_Count() { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000A59")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xE9E290", Offset = "0xE9D690", Length = "0xA3")]
		[IsReadOnly]
		[Token(Token = "0x6000A5C")]
		public T get_Item(int index) { }

		[Address(RVA = "0xE9BBC0", Offset = "0xE9AFC0", Length = "0x61")]
		[IsReadOnly]
		[Token(Token = "0x6000A5E")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xE9C6A0", Offset = "0xE9BAA0", Length = "0x61")]
		[IsReadOnly]
		[Token(Token = "0x6000A5A")]
		public bool IsEmpty() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000A5F")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000A60")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xE8A820", Offset = "0xE89C20", Length = "0xBA")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000A61")]
		private void ThrowIndexOutOfRangeException(int index) { }

		[Address(RVA = "0xE9DB90", Offset = "0xE9CF90", Length = "0x8E")]
		[IsReadOnly]
		[Token(Token = "0x6000A5D")]
		private bool TryGetValue(int index, out T item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400045F")]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000460")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x1700012F")]
	public int Count
	{
		[Address(RVA = "0xE9E130", Offset = "0xE9D530", Length = "0x58")]
		[IsReadOnly]
		[Token(Token = "0x6000A45")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000130")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000A4C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x11DF440", Offset = "0x11DE840", Length = "0x46")]
	[Token(Token = "0x6000A41")]
	public UnsafeQueue`1(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DD2A0", Offset = "0x11DC6A0", Length = "0x44")]
	[Token(Token = "0x6000A42")]
	internal static UnsafeQueue<T>* Alloc(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DD2F0", Offset = "0x11DC6F0", Length = "0x17")]
	[Token(Token = "0x6000A50")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0x11DD310", Offset = "0x11DC710", Length = "0x4D")]
	[Token(Token = "0x6000A4F")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0x11DD360", Offset = "0x11DC760", Length = "0x1C")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A51")]
	private void CheckNotEmpty() { }

	[Address(RVA = "0x11DD460", Offset = "0x11DC860", Length = "0xD6")]
	[Token(Token = "0x6000A4B")]
	public void Clear() { }

	[Address(RVA = "0x11DD700", Offset = "0x11DCB00", Length = "0x48")]
	[Token(Token = "0x6000A48")]
	public T Dequeue() { }

	[Address(RVA = "0x11DD920", Offset = "0x11DCD20", Length = "0x3C")]
	[Token(Token = "0x6000A4D")]
	public override void Dispose() { }

	[Address(RVA = "0x11DD960", Offset = "0x11DCD60", Length = "0xBA")]
	[Token(Token = "0x6000A4E")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11DDF60", Offset = "0x11DD360", Length = "0x8B")]
	[Token(Token = "0x6000A47")]
	public void Enqueue(T value) { }

	[Address(RVA = "0x11DE090", Offset = "0x11DD490", Length = "0xE3")]
	[Token(Token = "0x6000A43")]
	internal static void Free(UnsafeQueue<T>* data) { }

	[Address(RVA = "0xE9E130", Offset = "0xE9D530", Length = "0x58")]
	[IsReadOnly]
	[Token(Token = "0x6000A45")]
	public int get_Count() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000A4C")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11DE290", Offset = "0x11DD690", Length = "0x86")]
	[IsReadOnly]
	[Token(Token = "0x6000A44")]
	public bool IsEmpty() { }

	[Address(RVA = "0x11DE640", Offset = "0x11DDA40", Length = "0x61")]
	[Token(Token = "0x6000A46")]
	public T Peek() { }

	[Address(RVA = "0x11DE6B0", Offset = "0x11DDAB0", Length = "0x49")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A52")]
	private static void ThrowEmpty() { }

	[Address(RVA = "0x11DE8B0", Offset = "0x11DDCB0", Length = "0x1A8")]
	[Token(Token = "0x6000A4A")]
	public NativeArray<T> ToArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DEE30", Offset = "0x11DE230", Length = "0x12C")]
	[Token(Token = "0x6000A49")]
	public bool TryDequeue(out T item) { }

}

