namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeParallelHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000130")]
public struct UnsafeParallelHashSet : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable
{
	[Token(Token = "0x2000132")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000508")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x17000183")]
		public override T Current
		{
			[Address(RVA = "0x19A7400", Offset = "0x19A6800", Length = "0xEB")]
			[Token(Token = "0x6000CA2")]
			 get { } //Length: 235
		}

		[Token(Token = "0x17000184")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xA914F0", Offset = "0xA908F0", Length = "0xFD")]
			[Token(Token = "0x6000CA3")]
			private get { } //Length: 253
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000C9F")]
		public override void Dispose() { }

		[Address(RVA = "0x19A7400", Offset = "0x19A6800", Length = "0xEB")]
		[Token(Token = "0x6000CA2")]
		public override T get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x6000CA0")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x6000CA1")]
		public override void Reset() { }

		[Address(RVA = "0xA914F0", Offset = "0xA908F0", Length = "0xFD")]
		[Token(Token = "0x6000CA3")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x2000131")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000507")]
		internal ParallelWriter<T, Boolean> m_Data; //Field offset: 0x0

		[Token(Token = "0x17000182")]
		public int Capacity
		{
			[Address(RVA = "0xD6DEE0", Offset = "0xD6D2E0", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000C9C")]
			 get { } //Length: 112
		}

		[Address(RVA = "0xE1BD20", Offset = "0xE1B120", Length = "0xF6")]
		[Token(Token = "0x6000C9D")]
		public bool Add(T item) { }

		[Address(RVA = "0xE1BE20", Offset = "0xE1B220", Length = "0x103")]
		[Token(Token = "0x6000C9E")]
		public bool Add(T item, int threadIndexOverride) { }

		[Address(RVA = "0xD6DEE0", Offset = "0xD6D2E0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000C9C")]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x2000133")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000509")]
		internal UnsafeParallelHashMap<T, Boolean> m_Data; //Field offset: 0x0

		[Token(Token = "0x17000187")]
		public int Capacity
		{
			[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000CA8")]
			 get { } //Length: 112
		}

		[Token(Token = "0x17000185")]
		public bool IsCreated
		{
			[Address(RVA = "0xEA4280", Offset = "0xEA3680", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000CA5")]
			 get { } //Length: 112
		}

		[Token(Token = "0x17000186")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4500", Offset = "0xEA3900", Length = "0xCE")]
			[IsReadOnly]
			[Token(Token = "0x6000CA6")]
			 get { } //Length: 206
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x6000CA4")]
		internal ReadOnly(ref UnsafeParallelHashSet<T>& data) { }

		[Address(RVA = "0xE9EB80", Offset = "0xE9DF80", Length = "0xF3")]
		[IsReadOnly]
		[Token(Token = "0x6000CA9")]
		public bool Contains(T item) { }

		[Address(RVA = "0xD8A1F0", Offset = "0xD895F0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000CA7")]
		public int Count() { }

		[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000CA8")]
		public int get_Capacity() { }

		[Address(RVA = "0xEA4280", Offset = "0xEA3680", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000CA5")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4500", Offset = "0xEA3900", Length = "0xCE")]
		[IsReadOnly]
		[Token(Token = "0x6000CA6")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[IsReadOnly]
		[Token(Token = "0x6000CAB")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000CAC")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000CAD")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA32D0", Offset = "0xEA26D0", Length = "0x96")]
		[IsReadOnly]
		[Token(Token = "0x6000CAA")]
		public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000506")]
	internal UnsafeParallelHashMap<T, Boolean> m_Data; //Field offset: 0x0

	[Token(Token = "0x17000180")]
	public int Capacity
	{
		[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000C8D")]
		 get { } //Length: 112
		[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
		[Token(Token = "0x6000C8E")]
		 set { } //Length: 126
	}

	[Token(Token = "0x17000181")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 112
	}

	[Token(Token = "0x1700017F")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000C8B")]
		 get { } //Length: 112
	}

	[Address(RVA = "0xD8C410", Offset = "0xD8B810", Length = "0x66")]
	[Token(Token = "0x6000C8A")]
	public UnsafeParallelHashSet`1(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD8D8F0", Offset = "0xD8CCF0", Length = "0xF6")]
	[Token(Token = "0x6000C93")]
	public bool Add(T item) { }

	[Address(RVA = "0x11D9490", Offset = "0x11D8890", Length = "0x94")]
	[Token(Token = "0x6000C97")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0x11D9530", Offset = "0x11D8930", Length = "0x52")]
	[Token(Token = "0x6000C9B")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD8DAF0", Offset = "0xD8CEF0", Length = "0x70")]
	[Token(Token = "0x6000C92")]
	public void Clear() { }

	[Address(RVA = "0xD8DB60", Offset = "0xD8CF60", Length = "0xE9")]
	[Token(Token = "0x6000C95")]
	public bool Contains(T item) { }

	[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
	[Token(Token = "0x6000C8C")]
	public int Count() { }

	[Address(RVA = "0xD8DD70", Offset = "0xD8D170", Length = "0x70")]
	[Token(Token = "0x6000C90")]
	public override void Dispose() { }

	[Address(RVA = "0xD8DCC0", Offset = "0xD8D0C0", Length = "0xA5")]
	[Token(Token = "0x6000C91")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000C8D")]
	public int get_Capacity() { }

	[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000C8F")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000C8B")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x6000C98")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD8DDE0", Offset = "0xD8D1E0", Length = "0xE9")]
	[Token(Token = "0x6000C94")]
	public bool Remove(T item) { }

	[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
	[Token(Token = "0x6000C8E")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C99")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C9A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD8DED0", Offset = "0xD8D2D0", Length = "0xA0")]
	[Token(Token = "0x6000C96")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

