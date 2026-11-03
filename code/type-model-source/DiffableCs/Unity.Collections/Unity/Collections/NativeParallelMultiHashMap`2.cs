namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[NativeContainer]
[Token(Token = "0x20000AE")]
public struct NativeParallelMultiHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x20000B0")]
	internal struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D6")]
		internal NativeParallelMultiHashMap<TKey, TValue> hashmap; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D7")]
		internal TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D8")]
		internal byte isFirst; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D9")]
		private TValue value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DA")]
		private NativeParallelMultiHashMapIterator<TKey> iterator; //Field offset: 0x0

		[Token(Token = "0x170000F5")]
		public override TValue Current
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x600089E")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170000F6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19B82D0", Offset = "0x19B76D0", Length = "0x5E")]
			[Token(Token = "0x600089F")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600089B")]
		public override void Dispose() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600089E")]
		public override TValue get_Current() { }

		[Address(RVA = "0x19B22C0", Offset = "0x19B16C0", Length = "0x1C")]
		[Token(Token = "0x60008A0")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0x19B49D0", Offset = "0x19B3DD0", Length = "0xAF")]
		[Token(Token = "0x600089C")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19B4BD0", Offset = "0x19B3FD0", Length = "0x5")]
		[Token(Token = "0x600089D")]
		public override void Reset() { }

		[Address(RVA = "0x19B82D0", Offset = "0x19B76D0", Length = "0x5E")]
		[Token(Token = "0x600089F")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000B1")]
	internal struct KeyValueEnumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DB")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000F7")]
		public override KeyValue<TKey, TValue> Current
		{
			[Address(RVA = "0xAE88A0", Offset = "0xAE7CA0", Length = "0x52")]
			[IsReadOnly]
			[Token(Token = "0x60008A4")]
			 get { } //Length: 82
		}

		[Token(Token = "0x170000F8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE8750", Offset = "0xAE7B50", Length = "0xA8")]
			[Token(Token = "0x60008A5")]
			private get { } //Length: 168
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60008A1")]
		public override void Dispose() { }

		[Address(RVA = "0xAE88A0", Offset = "0xAE7CA0", Length = "0x52")]
		[IsReadOnly]
		[Token(Token = "0x60008A4")]
		public override KeyValue<TKey, TValue> get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x60008A2")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x60008A3")]
		public override void Reset() { }

		[Address(RVA = "0xAE8750", Offset = "0xAE7B50", Length = "0xA8")]
		[Token(Token = "0x60008A5")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x20000AF")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D5")]
		internal ParallelWriter<TKey, TValue> m_Writer; //Field offset: 0x0

		[Token(Token = "0x170000F4")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x6000898")]
			 get { } //Length: 49
		}

		[Token(Token = "0x170000F3")]
		public int m_ThreadIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000897")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xE1CB40", Offset = "0xE1BF40", Length = "0x8C")]
		[Token(Token = "0x6000899")]
		public void Add(TKey key, TValue item) { }

		[Address(RVA = "0xE1CAB0", Offset = "0xE1BEB0", Length = "0x90")]
		[Token(Token = "0x600089A")]
		public void Add(TKey key, TValue item, int threadIndexOverride) { }

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x6000898")]
		public int get_Capacity() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000897")]
		public int get_m_ThreadIndex() { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000B2")]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DC")]
		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; //Field offset: 0x0

		[Token(Token = "0x170000FB")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x60008AA")]
			 get { } //Length: 49
		}

		[Token(Token = "0x170000F9")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x60008A7")]
			 get { } //Length: 40
		}

		[Token(Token = "0x170000FA")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
			[IsReadOnly]
			[Token(Token = "0x60008A8")]
			 get { } //Length: 161
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x60008A6")]
		internal ReadOnly(UnsafeParallelMultiHashMap<TKey, TValue> container) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x60008B1")]
		private void CheckRead() { }

		[Address(RVA = "0xE9E5B0", Offset = "0xE9D9B0", Length = "0x43")]
		[IsReadOnly]
		[Token(Token = "0x60008AD")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xD8F2A0", Offset = "0xD8E6A0", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x60008A9")]
		public int Count() { }

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x60008AA")]
		public int get_Capacity() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x60008A7")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
		[IsReadOnly]
		[Token(Token = "0x60008A8")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[Token(Token = "0x60008B3")]
		public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0EA0", Offset = "0xEA02A0", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x60008AE")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1240", Offset = "0xEA0640", Length = "0x6F")]
		[IsReadOnly]
		[Token(Token = "0x60008B0")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1470", Offset = "0xEA0870", Length = "0x66")]
		[IsReadOnly]
		[Token(Token = "0x60008AF")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60008B4")]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60008B5")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA2F90", Offset = "0xEA2390", Length = "0x8D")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x60008B2")]
		private void ThrowKeyNotPresent(TKey key) { }

		[Address(RVA = "0xEA34B0", Offset = "0xEA28B0", Length = "0x6D")]
		[IsReadOnly]
		[Token(Token = "0x60008AB")]
		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

		[Address(RVA = "0xEA3520", Offset = "0xEA2920", Length = "0x55")]
		[IsReadOnly]
		[Token(Token = "0x60008AC")]
		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003D4")]
	internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; //Field offset: 0x0

	[Token(Token = "0x170000F1")]
	public int Capacity
	{
		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x600087E")]
		 get { } //Length: 49
		[Address(RVA = "0xD8CFD0", Offset = "0xD8C3D0", Length = "0x43")]
		[Token(Token = "0x600087F")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170000F2")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x6000889")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170000F0")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD90430", Offset = "0xD8F830", Length = "0x58")]
		[IsReadOnly]
		[Token(Token = "0x600087C")]
		 get { } //Length: 88
	}

	[Address(RVA = "0xD902C0", Offset = "0xD8F6C0", Length = "0x54")]
	[Token(Token = "0x600087A")]
	public NativeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD8EBB0", Offset = "0xD8DFB0", Length = "0x53")]
	[Token(Token = "0x6000881")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0xD8EC10", Offset = "0xD8E010", Length = "0x5C")]
	[Token(Token = "0x600088F")]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[Address(RVA = "0xD89D10", Offset = "0xD89110", Length = "0x3A")]
	[Token(Token = "0x6000894")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x6000895")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6000896")]
	private void CheckWrite() { }

	[Address(RVA = "0xD89D90", Offset = "0xD89190", Length = "0x36")]
	[Token(Token = "0x6000880")]
	public void Clear() { }

	[Address(RVA = "0xD8ED10", Offset = "0xD8E110", Length = "0x8C")]
	[Token(Token = "0x6000886")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0xD8F2A0", Offset = "0xD8E6A0", Length = "0x36")]
	[IsReadOnly]
	[Token(Token = "0x600087D")]
	public int Count() { }

	[Address(RVA = "0xD8F180", Offset = "0xD8E580", Length = "0x116")]
	[Token(Token = "0x6000887")]
	public int CountValuesForKey(TKey key) { }

	[Address(RVA = "0xD8F5A0", Offset = "0xD8E9A0", Length = "0x81")]
	[Token(Token = "0x600088A")]
	public override void Dispose() { }

	[Address(RVA = "0xD8F4C0", Offset = "0xD8E8C0", Length = "0xDD")]
	[Token(Token = "0x600088B")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
	[IsReadOnly]
	[Token(Token = "0x600087E")]
	public int get_Capacity() { }

	[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
	[IsReadOnly]
	[Token(Token = "0x6000889")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD90430", Offset = "0xD8F830", Length = "0x58")]
	[IsReadOnly]
	[Token(Token = "0x600087C")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x6000891")]
	public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0xD8F6D0", Offset = "0xD8EAD0", Length = "0x66")]
	[Token(Token = "0x600088C")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8F7F0", Offset = "0xD8EBF0", Length = "0x6F")]
	[Token(Token = "0x600088E")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8F860", Offset = "0xD8EC60", Length = "0x66")]
	[Token(Token = "0x600088D")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8FBA0", Offset = "0xD8EFA0", Length = "0x23")]
	[Token(Token = "0x6000890")]
	public Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }

	[Address(RVA = "0x69FF40", Offset = "0x69F340", Length = "0x95")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x600087B")]
	internal void Initialize(int capacity, ref U allocator) { }

	[Address(RVA = "0xD8FD10", Offset = "0xD8F110", Length = "0x5C")]
	[Token(Token = "0x6000883")]
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }

	[Address(RVA = "0xD8FBD0", Offset = "0xD8EFD0", Length = "0x43")]
	[Token(Token = "0x6000882")]
	public int Remove(TKey key) { }

	[Address(RVA = "0xD8CFD0", Offset = "0xD8C3D0", Length = "0x43")]
	[Token(Token = "0x600087F")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xD8FFC0", Offset = "0xD8F3C0", Length = "0x6A")]
	[Token(Token = "0x6000888")]
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000892")]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000893")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD90030", Offset = "0xD8F430", Length = "0x70")]
	[Token(Token = "0x6000884")]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	[Address(RVA = "0xD90260", Offset = "0xD8F660", Length = "0x58")]
	[Token(Token = "0x6000885")]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

