namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
[Token(Token = "0x20000B5")]
public struct NativeQueue : INativeDisposable, IDisposable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000B6")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DF")]
		internal Enumerator<T> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000FF")]
		public override T Current
		{
			[Address(RVA = "0x198AC40", Offset = "0x198A040", Length = "0x37")]
			[Token(Token = "0x60008CC")]
			 get { } //Length: 55
		}

		[Token(Token = "0x17000100")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19890C0", Offset = "0x19884C0", Length = "0x80")]
			[Token(Token = "0x60008CD")]
			private get { } //Length: 128
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60008C9")]
		public override void Dispose() { }

		[Address(RVA = "0x198AC40", Offset = "0x198A040", Length = "0x37")]
		[Token(Token = "0x60008CC")]
		public override T get_Current() { }

		[Address(RVA = "0x1986630", Offset = "0x1985A30", Length = "0x36")]
		[Token(Token = "0x60008CA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19883B0", Offset = "0x19877B0", Length = "0x2F")]
		[Token(Token = "0x60008CB")]
		public override void Reset() { }

		[Address(RVA = "0x19890C0", Offset = "0x19884C0", Length = "0x80")]
		[Token(Token = "0x60008CD")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x20000B8")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003E1")]
		internal ParallelWriter<T> unsafeWriter; //Field offset: 0x0

		[Address(RVA = "0xE1C250", Offset = "0xE1B650", Length = "0x44")]
		[Token(Token = "0x60008D7")]
		public void Enqueue(T value) { }

		[Address(RVA = "0xE1C180", Offset = "0xE1B580", Length = "0xC6")]
		[Token(Token = "0x60008D8")]
		public void Enqueue(T value, int threadIndexOverride) { }

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000B7")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003E0")]
		private ReadOnly<T> m_ReadOnly; //Field offset: 0x0

		[Token(Token = "0x17000102")]
		public int Count
		{
			[Address(RVA = "0xEA4210", Offset = "0xEA3610", Length = "0x68")]
			[IsReadOnly]
			[Token(Token = "0x60008D1")]
			 get { } //Length: 104
		}

		[Token(Token = "0x17000101")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x60008CF")]
			 get { } //Length: 40
		}

		[Token(Token = "0x17000103")]
		public T Item
		{
			[Address(RVA = "0xEA4870", Offset = "0xEA3C70", Length = "0xD5")]
			[IsReadOnly]
			[Token(Token = "0x60008D2")]
			 get { } //Length: 213
		}

		[Address(RVA = "0xEA41A0", Offset = "0xEA35A0", Length = "0x33")]
		[Token(Token = "0x60008CE")]
		internal ReadOnly(ref NativeQueue<T>& data) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x60008D6")]
		private void CheckRead() { }

		[Address(RVA = "0xEA4210", Offset = "0xEA3610", Length = "0x68")]
		[IsReadOnly]
		[Token(Token = "0x60008D1")]
		public int get_Count() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x60008CF")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4870", Offset = "0xEA3C70", Length = "0xD5")]
		[IsReadOnly]
		[Token(Token = "0x60008D2")]
		public T get_Item(int index) { }

		[Address(RVA = "0xE9F4D0", Offset = "0xE9E8D0", Length = "0xA8")]
		[IsReadOnly]
		[Token(Token = "0x60008D3")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xEA16B0", Offset = "0xEA0AB0", Length = "0x7E")]
		[IsReadOnly]
		[Token(Token = "0x60008D0")]
		public bool IsEmpty() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60008D4")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60008D5")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003DE")]
	private UnsafeQueue<T>* m_Queue; //Field offset: 0x0

	[Token(Token = "0x170000FD")]
	public int Count
	{
		[Address(RVA = "0xD91730", Offset = "0xD90B30", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x60008BB")]
		 get { } //Length: 54
	}

	[Token(Token = "0x170000FE")]
	public bool IsCreated
	{
		[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x60008C2")]
		 get { } //Length: 60
	}

	[Address(RVA = "0xD91620", Offset = "0xD90A20", Length = "0x9B")]
	[Token(Token = "0x60008B9")]
	public NativeQueue`1(AllocatorHandle allocator) { }

	[Address(RVA = "0xD90490", Offset = "0xD8F890", Length = "0x5C")]
	[Token(Token = "0x60008C6")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0xD90590", Offset = "0xD8F990", Length = "0x4D")]
	[Token(Token = "0x60008C5")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60008C7")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60008C8")]
	private void CheckWrite() { }

	[Address(RVA = "0xD90620", Offset = "0xD8FA20", Length = "0x39")]
	[Token(Token = "0x60008C1")]
	public void Clear() { }

	[Address(RVA = "0xD907D0", Offset = "0xD8FBD0", Length = "0x53")]
	[Token(Token = "0x60008BE")]
	public T Dequeue() { }

	[Address(RVA = "0xD90B20", Offset = "0xD8FF20", Length = "0x9B")]
	[Token(Token = "0x60008C3")]
	public override void Dispose() { }

	[Address(RVA = "0xD90A50", Offset = "0xD8FE50", Length = "0xCC")]
	[Token(Token = "0x60008C4")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD90D10", Offset = "0xD90110", Length = "0x50")]
	[Token(Token = "0x60008BD")]
	public void Enqueue(T value) { }

	[Address(RVA = "0xD91730", Offset = "0xD90B30", Length = "0x36")]
	[IsReadOnly]
	[Token(Token = "0x60008BB")]
	public int get_Count() { }

	[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
	[IsReadOnly]
	[Token(Token = "0x60008C2")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD90E50", Offset = "0xD90250", Length = "0x9D")]
	[IsReadOnly]
	[Token(Token = "0x60008BA")]
	public bool IsEmpty() { }

	[Address(RVA = "0xD90FD0", Offset = "0xD903D0", Length = "0x99")]
	[Token(Token = "0x60008BC")]
	public T Peek() { }

	[Address(RVA = "0xD91330", Offset = "0xD90730", Length = "0x66")]
	[Token(Token = "0x60008C0")]
	public NativeArray<T> ToArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD913F0", Offset = "0xD907F0", Length = "0x45")]
	[Token(Token = "0x60008BF")]
	public bool TryDequeue(out T item) { }

}

