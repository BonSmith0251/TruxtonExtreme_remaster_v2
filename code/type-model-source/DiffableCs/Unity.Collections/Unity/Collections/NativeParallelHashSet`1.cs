namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeParallelHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x20000A7")]
public struct NativeParallelHashSet : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000A9")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CE")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000EA")]
		public override T Current
		{
			[Address(RVA = "0x19A7400", Offset = "0x19A6800", Length = "0xEB")]
			[Token(Token = "0x6000828")]
			 get { } //Length: 235
		}

		[Token(Token = "0x170000EB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xA914F0", Offset = "0xA908F0", Length = "0xFD")]
			[Token(Token = "0x6000829")]
			private get { } //Length: 253
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000825")]
		public override void Dispose() { }

		[Address(RVA = "0x19A7400", Offset = "0x19A6800", Length = "0xEB")]
		[Token(Token = "0x6000828")]
		public override T get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x6000826")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x6000827")]
		public override void Reset() { }

		[Address(RVA = "0xA914F0", Offset = "0xA908F0", Length = "0xFD")]
		[Token(Token = "0x6000829")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x20000A8")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CD")]
		internal ParallelWriter<T, Boolean> m_Data; //Field offset: 0x0

		[Token(Token = "0x170000E9")]
		public int Capacity
		{
			[Address(RVA = "0xD6DEE0", Offset = "0xD6D2E0", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000822")]
			 get { } //Length: 112
		}

		[Address(RVA = "0xE1BD20", Offset = "0xE1B120", Length = "0xF6")]
		[Token(Token = "0x6000823")]
		public bool Add(T item) { }

		[Address(RVA = "0xE1BE20", Offset = "0xE1B220", Length = "0x103")]
		[Token(Token = "0x6000824")]
		public bool Add(T item, int threadIndexOverride) { }

		[Address(RVA = "0xD6DEE0", Offset = "0xD6D2E0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000822")]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000AA")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CF")]
		internal UnsafeParallelHashMap<T, Boolean> m_Data; //Field offset: 0x0

		[Token(Token = "0x170000EE")]
		public int Capacity
		{
			[Address(RVA = "0xD8DAF0", Offset = "0xD8CEF0", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x600082E")]
			 get { } //Length: 112
		}

		[Token(Token = "0x170000EC")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x600082B")]
			 get { } //Length: 112
		}

		[Token(Token = "0x170000ED")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA46C0", Offset = "0xEA3AC0", Length = "0xCE")]
			[IsReadOnly]
			[Token(Token = "0x600082C")]
			 get { } //Length: 206
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x600082A")]
		internal ReadOnly(ref NativeParallelHashSet<T>& data) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x6000834")]
		private void CheckRead() { }

		[Address(RVA = "0xE9E8E0", Offset = "0xE9DCE0", Length = "0xF3")]
		[IsReadOnly]
		[Token(Token = "0x600082F")]
		public bool Contains(T item) { }

		[Address(RVA = "0xD89DD0", Offset = "0xD891D0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x600082D")]
		public int Count() { }

		[Address(RVA = "0xD8DAF0", Offset = "0xD8CEF0", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x600082E")]
		public int get_Capacity() { }

		[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x600082B")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA46C0", Offset = "0xEA3AC0", Length = "0xCE")]
		[IsReadOnly]
		[Token(Token = "0x600082C")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[IsReadOnly]
		[Token(Token = "0x6000831")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000832")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000833")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA3370", Offset = "0xEA2770", Length = "0x96")]
		[IsReadOnly]
		[Token(Token = "0x6000830")]
		public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CC")]
	internal NativeParallelHashMap<T, Boolean> m_Data; //Field offset: 0x0

	[Token(Token = "0x170000E7")]
	public int Capacity
	{
		[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000813")]
		 get { } //Length: 112
		[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
		[Token(Token = "0x6000814")]
		 set { } //Length: 126
	}

	[Token(Token = "0x170000E8")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000815")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170000E6")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000811")]
		 get { } //Length: 112
	}

	[Address(RVA = "0xD8DF70", Offset = "0xD8D370", Length = "0x86")]
	[Token(Token = "0x6000810")]
	public NativeParallelHashSet`1(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD8D8F0", Offset = "0xD8CCF0", Length = "0xF6")]
	[Token(Token = "0x6000819")]
	public bool Add(T item) { }

	[Address(RVA = "0xD8D9F0", Offset = "0xD8CDF0", Length = "0x94")]
	[Token(Token = "0x600081D")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0xD8DA90", Offset = "0xD8CE90", Length = "0x52")]
	[Token(Token = "0x6000821")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD8DAF0", Offset = "0xD8CEF0", Length = "0x70")]
	[Token(Token = "0x6000818")]
	public void Clear() { }

	[Address(RVA = "0xD8DB60", Offset = "0xD8CF60", Length = "0xE9")]
	[Token(Token = "0x600081B")]
	public bool Contains(T item) { }

	[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
	[Token(Token = "0x6000812")]
	public int Count() { }

	[Address(RVA = "0xD8DD70", Offset = "0xD8D170", Length = "0x70")]
	[Token(Token = "0x6000816")]
	public override void Dispose() { }

	[Address(RVA = "0xD8DCC0", Offset = "0xD8D0C0", Length = "0xA5")]
	[Token(Token = "0x6000817")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000813")]
	public int get_Capacity() { }

	[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000815")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000811")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x600081E")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD8DDE0", Offset = "0xD8D1E0", Length = "0xE9")]
	[Token(Token = "0x600081A")]
	public bool Remove(T item) { }

	[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
	[Token(Token = "0x6000814")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x600081F")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000820")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD8DED0", Offset = "0xD8D2D0", Length = "0xA0")]
	[Token(Token = "0x600081C")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

