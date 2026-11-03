namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000129")]
public struct UnsafeParallelHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x200012C")]
	internal struct Enumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000500")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x1700017C")]
		public override KeyValue<TKey, TValue> Current
		{
			[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
			[Token(Token = "0x6000C85")]
			 get { } //Length: 79
		}

		[Token(Token = "0x1700017D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
			[Token(Token = "0x6000C86")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000C82")]
		public override void Dispose() { }

		[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
		[Token(Token = "0x6000C85")]
		public override KeyValue<TKey, TValue> get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x6000C83")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x6000C84")]
		public override void Reset() { }

		[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
		[Token(Token = "0x6000C86")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x200012B")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004FE")]
		internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeSetThreadIndex]
		[Token(Token = "0x40004FF")]
		internal int m_ThreadIndex; //Field offset: 0x0

		[Token(Token = "0x1700017B")]
		public int Capacity
		{
			[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000C7F")]
			 get { } //Length: 25
		}

		[Token(Token = "0x1700017A")]
		public int ThreadIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6000C7E")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000C7F")]
		public int get_Capacity() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000C7E")]
		public int get_ThreadIndex() { }

		[Address(RVA = "0xE1E660", Offset = "0xE1DA60", Length = "0x9A")]
		[Token(Token = "0x6000C80")]
		public bool TryAdd(TKey key, TValue item) { }

		[Address(RVA = "0xE1D730", Offset = "0xE1CB30", Length = "0xA2")]
		[Token(Token = "0x6000C81")]
		public bool TryAdd(TKey key, TValue item, int threadIndexOverride) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x200012A")]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004FD")]
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

		[Token(Token = "0x17000178")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x6000C73")]
			 get { } //Length: 49
		}

		[Token(Token = "0x17000176")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x6000C70")]
			 get { } //Length: 40
		}

		[Token(Token = "0x17000177")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
			[IsReadOnly]
			[Token(Token = "0x6000C71")]
			 get { } //Length: 161
		}

		[Token(Token = "0x17000179")]
		public TValue Item
		{
			[Address(RVA = "0xEA4B80", Offset = "0xEA3F80", Length = "0x9D")]
			[IsReadOnly]
			[Token(Token = "0x6000C76")]
			 get { } //Length: 157
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x6000C6F")]
		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData) { }

		[Address(RVA = "0xE9E600", Offset = "0xE9DA00", Length = "0x72")]
		[IsReadOnly]
		[Token(Token = "0x6000C75")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xD8A1B0", Offset = "0xD895B0", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x6000C72")]
		public int Count() { }

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x6000C73")]
		public int get_Capacity() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x6000C70")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
		[IsReadOnly]
		[Token(Token = "0x6000C71")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xEA4B80", Offset = "0xEA3F80", Length = "0x9D")]
		[IsReadOnly]
		[Token(Token = "0x6000C76")]
		public TValue get_Item(TKey key) { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[IsReadOnly]
		[Token(Token = "0x6000C7B")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0DE0", Offset = "0xEA01E0", Length = "0x60")]
		[IsReadOnly]
		[Token(Token = "0x6000C77")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA11D0", Offset = "0xEA05D0", Length = "0x6C")]
		[IsReadOnly]
		[Token(Token = "0x6000C79")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1400", Offset = "0xEA0800", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x6000C78")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000C7C")]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000C7D")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA3020", Offset = "0xEA2420", Length = "0xB5")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000C7A")]
		private void ThrowKeyNotPresent(TKey key) { }

		[Address(RVA = "0xEA38C0", Offset = "0xEA2CC0", Length = "0x84")]
		[IsReadOnly]
		[Token(Token = "0x6000C74")]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004FB")]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004FC")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x17000174")]
	public int Capacity
	{
		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000C5B")]
		 get { } //Length: 25
		[Address(RVA = "0x11D5740", Offset = "0x11D4B40", Length = "0x84")]
		[Token(Token = "0x6000C5C")]
		 set { } //Length: 132
	}

	[Token(Token = "0x17000172")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000C58")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000173")]
	public bool IsEmpty
	{
		[Address(RVA = "0x11D5460", Offset = "0x11D4860", Length = "0x38")]
		[IsReadOnly]
		[Token(Token = "0x6000C59")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000175")]
	public TValue Item
	{
		[Address(RVA = "0x11D5530", Offset = "0x11D4930", Length = "0xF0")]
		[Token(Token = "0x6000C63")]
		 get { } //Length: 240
		[Address(RVA = "0x11D59F0", Offset = "0x11D4DF0", Length = "0x295")]
		[Token(Token = "0x6000C64")]
		 set { } //Length: 661
	}

	[Address(RVA = "0x11D5300", Offset = "0x11D4700", Length = "0xBB")]
	[Token(Token = "0x6000C57")]
	public UnsafeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x11D45A0", Offset = "0x11D39A0", Length = "0x9E")]
	[Token(Token = "0x6000C5F")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0x11D4640", Offset = "0x11D3A40", Length = "0x10")]
	[Token(Token = "0x6000C6A")]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[Address(RVA = "0xD89D10", Offset = "0xD89110", Length = "0x3A")]
	[Token(Token = "0x6000C6B")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x11D4700", Offset = "0x11D3B00", Length = "0x36")]
	[Token(Token = "0x6000C5D")]
	public void Clear() { }

	[Address(RVA = "0x11D47B0", Offset = "0x11D3BB0", Length = "0xB6")]
	[Token(Token = "0x6000C62")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0x11D4870", Offset = "0x11D3C70", Length = "0xA")]
	[IsReadOnly]
	[Token(Token = "0x6000C5A")]
	public int Count() { }

	[Address(RVA = "0x11D4B00", Offset = "0x11D3F00", Length = "0xBA")]
	[Token(Token = "0x6000C66")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11D4880", Offset = "0x11D3C80", Length = "0x3C")]
	[Token(Token = "0x6000C65")]
	public override void Dispose() { }

	[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x6000C5B")]
	public int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000C58")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11D5460", Offset = "0x11D4860", Length = "0x38")]
	[IsReadOnly]
	[Token(Token = "0x6000C59")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x11D5530", Offset = "0x11D4930", Length = "0xF0")]
	[Token(Token = "0x6000C63")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x6000C6C")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0x11D4BC0", Offset = "0x11D3FC0", Length = "0xDB")]
	[Token(Token = "0x6000C67")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11D4E70", Offset = "0x11D4270", Length = "0xEA")]
	[Token(Token = "0x6000C69")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0x11D4F60", Offset = "0x11D4360", Length = "0xDB")]
	[Token(Token = "0x6000C68")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11D5090", Offset = "0x11D4490", Length = "0x7C")]
	[Token(Token = "0x6000C60")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0x11D5740", Offset = "0x11D4B40", Length = "0x84")]
	[Token(Token = "0x6000C5C")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0x11D59F0", Offset = "0x11D4DF0", Length = "0x295")]
	[Token(Token = "0x6000C64")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C6D")]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C6E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x11D45A0", Offset = "0x11D39A0", Length = "0x9E")]
	[Token(Token = "0x6000C5E")]
	public bool TryAdd(TKey key, TValue item) { }

	[Address(RVA = "0x11D5180", Offset = "0x11D4580", Length = "0xB4")]
	[Token(Token = "0x6000C61")]
	public bool TryGetValue(TKey key, out TValue item) { }

}

