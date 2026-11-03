namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000136")]
public struct UnsafeParallelMultiHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x2000137")]
	internal struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400050D")]
		internal UnsafeParallelMultiHashMap<TKey, TValue> hashmap; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400050E")]
		internal TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400050F")]
		internal bool isFirst; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000510")]
		private TValue value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000511")]
		private NativeParallelMultiHashMapIterator<TKey> iterator; //Field offset: 0x0

		[Token(Token = "0x1700018C")]
		public override TValue Current
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6000D4C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700018D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19B82D0", Offset = "0x19B76D0", Length = "0x5E")]
			[Token(Token = "0x6000D4D")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D49")]
		public override void Dispose() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000D4C")]
		public override TValue get_Current() { }

		[Address(RVA = "0x19B22C0", Offset = "0x19B16C0", Length = "0x1C")]
		[Token(Token = "0x6000D4E")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0x19B3B30", Offset = "0x19B2F30", Length = "0xAF")]
		[Token(Token = "0x6000D4A")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19B4BD0", Offset = "0x19B3FD0", Length = "0x5")]
		[Token(Token = "0x6000D4B")]
		public override void Reset() { }

		[Address(RVA = "0x19B82D0", Offset = "0x19B76D0", Length = "0x5E")]
		[Token(Token = "0x6000D4D")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000139")]
	internal struct KeyValueEnumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000514")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x1700018F")]
		public override KeyValue<TKey, TValue> Current
		{
			[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
			[Token(Token = "0x6000D55")]
			 get { } //Length: 79
		}

		[Token(Token = "0x17000190")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
			[Token(Token = "0x6000D56")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D52")]
		public override void Dispose() { }

		[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
		[Token(Token = "0x6000D55")]
		public override KeyValue<TKey, TValue> get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x6000D53")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x6000D54")]
		public override void Reset() { }

		[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
		[Token(Token = "0x6000D56")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x2000138")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000512")]
		internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeSetThreadIndex]
		[Token(Token = "0x4000513")]
		internal int m_ThreadIndex; //Field offset: 0x0

		[Token(Token = "0x1700018E")]
		public int Capacity
		{
			[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000D4F")]
			 get { } //Length: 25
		}

		[Address(RVA = "0xE1CDA0", Offset = "0xE1C1A0", Length = "0x69")]
		[Token(Token = "0x6000D50")]
		public void Add(TKey key, TValue item) { }

		[Address(RVA = "0xE1CBD0", Offset = "0xE1BFD0", Length = "0x6D")]
		[Token(Token = "0x6000D51")]
		public void Add(TKey key, TValue item, int threadIndexOverride) { }

		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000D4F")]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x200013A")]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000515")]
		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; //Field offset: 0x0

		[Token(Token = "0x17000193")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x6000D5B")]
			 get { } //Length: 49
		}

		[Token(Token = "0x17000191")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x6000D58")]
			 get { } //Length: 40
		}

		[Token(Token = "0x17000192")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
			[IsReadOnly]
			[Token(Token = "0x6000D59")]
			 get { } //Length: 161
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x6000D57")]
		internal ReadOnly(UnsafeParallelMultiHashMap<TKey, TValue> container) { }

		[Address(RVA = "0xE9E5B0", Offset = "0xE9D9B0", Length = "0x43")]
		[IsReadOnly]
		[Token(Token = "0x6000D5E")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xD8F2A0", Offset = "0xD8E6A0", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x6000D5A")]
		public int Count() { }

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x6000D5B")]
		public int get_Capacity() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x6000D58")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
		[IsReadOnly]
		[Token(Token = "0x6000D59")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[Token(Token = "0x6000D62")]
		public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0EA0", Offset = "0xEA02A0", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x6000D5F")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1240", Offset = "0xEA0640", Length = "0x6F")]
		[IsReadOnly]
		[Token(Token = "0x6000D61")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1470", Offset = "0xEA0870", Length = "0x66")]
		[IsReadOnly]
		[Token(Token = "0x6000D60")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000D63")]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000D64")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA34B0", Offset = "0xEA28B0", Length = "0x6D")]
		[IsReadOnly]
		[Token(Token = "0x6000D5C")]
		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

		[Address(RVA = "0xEA3520", Offset = "0xEA2920", Length = "0x55")]
		[IsReadOnly]
		[Token(Token = "0x6000D5D")]
		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400050B")]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400050C")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x1700018A")]
	public int Capacity
	{
		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000D31")]
		 get { } //Length: 25
		[Address(RVA = "0x11D86F0", Offset = "0x11D7AF0", Length = "0x84")]
		[Token(Token = "0x6000D32")]
		 set { } //Length: 132
	}

	[Token(Token = "0x1700018B")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000D3D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000189")]
	public bool IsEmpty
	{
		[Address(RVA = "0x11D5460", Offset = "0x11D4860", Length = "0x38")]
		[IsReadOnly]
		[Token(Token = "0x6000D2F")]
		 get { } //Length: 56
	}

	[Address(RVA = "0x11D5240", Offset = "0x11D4640", Length = "0xBB")]
	[Token(Token = "0x6000D2E")]
	public UnsafeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x11D9CC0", Offset = "0x11D90C0", Length = "0x6D")]
	[Token(Token = "0x6000D34")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0x11D4640", Offset = "0x11D3A40", Length = "0x10")]
	[Token(Token = "0x6000D44")]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[Address(RVA = "0xD89D10", Offset = "0xD89110", Length = "0x3A")]
	[Token(Token = "0x6000D48")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x11D4700", Offset = "0x11D3B00", Length = "0x36")]
	[Token(Token = "0x6000D33")]
	public void Clear() { }

	[Address(RVA = "0x11D9EB0", Offset = "0x11D92B0", Length = "0x8F")]
	[IsReadOnly]
	[Token(Token = "0x6000D3A")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0x11DA440", Offset = "0x11D9840", Length = "0x2C")]
	[IsReadOnly]
	[Token(Token = "0x6000D30")]
	public int Count() { }

	[Address(RVA = "0x11DA100", Offset = "0x11D9500", Length = "0x11F")]
	[IsReadOnly]
	[Token(Token = "0x6000D3B")]
	public int CountValuesForKey(TKey key) { }

	[Address(RVA = "0x11DA470", Offset = "0x11D9870", Length = "0xBA")]
	[Token(Token = "0x6000D3F")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11D4880", Offset = "0x11D3C80", Length = "0x3C")]
	[Token(Token = "0x6000D3E")]
	public override void Dispose() { }

	[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x6000D31")]
	public int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000D3D")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11D5460", Offset = "0x11D4860", Length = "0x38")]
	[IsReadOnly]
	[Token(Token = "0x6000D2F")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x6000D45")]
	public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0x11DA630", Offset = "0x11D9A30", Length = "0x109")]
	[IsReadOnly]
	[Token(Token = "0x6000D40")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DAA30", Offset = "0x11D9E30", Length = "0x119")]
	[IsReadOnly]
	[Token(Token = "0x6000D42")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0x11DACC0", Offset = "0x11DA0C0", Length = "0x109")]
	[IsReadOnly]
	[Token(Token = "0x6000D41")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8FBA0", Offset = "0xD8EFA0", Length = "0x23")]
	[Token(Token = "0x6000D43")]
	public Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }

	[Address(RVA = "0x11DB000", Offset = "0x11DA400", Length = "0x59")]
	[Token(Token = "0x6000D37")]
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }

	[Address(RVA = "0x6E8610", Offset = "0x6E7A10", Length = "0x112")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000D36")]
	public void Remove(TKey key, TValueEQ value) { }

	[Address(RVA = "0x11DB060", Offset = "0x11DA460", Length = "0x46")]
	[Token(Token = "0x6000D35")]
	public int Remove(TKey key) { }

	[Address(RVA = "0x11D86F0", Offset = "0x11D7AF0", Length = "0x84")]
	[Token(Token = "0x6000D32")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0x11DB2B0", Offset = "0x11DA6B0", Length = "0x52")]
	[Token(Token = "0x6000D3C")]
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000D46")]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000D47")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x11DB3B0", Offset = "0x11DA7B0", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000D38")]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	[Address(RVA = "0x11DB540", Offset = "0x11DA940", Length = "0x58")]
	[IsReadOnly]
	[Token(Token = "0x6000D39")]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

