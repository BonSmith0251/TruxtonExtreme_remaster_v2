namespace Unity.Collections;

[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[NativeContainer]
[Token(Token = "0x20000A1")]
public struct NativeParallelHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000A4")]
	internal struct Enumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CA")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000E3")]
		public override KeyValue<TKey, TValue> Current
		{
			[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
			[Token(Token = "0x6000805")]
			 get { } //Length: 79
		}

		[Token(Token = "0x170000E4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
			[Token(Token = "0x6000806")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000802")]
		public override void Dispose() { }

		[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
		[Token(Token = "0x6000805")]
		public override KeyValue<TKey, TValue> get_Current() { }

		[Address(RVA = "0xAE8630", Offset = "0xAE7A30", Length = "0x53")]
		[Token(Token = "0x6000803")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE8690", Offset = "0xAE7A90", Length = "0x7")]
		[Token(Token = "0x6000804")]
		public override void Reset() { }

		[Address(RVA = "0xAE8800", Offset = "0xAE7C00", Length = "0x99")]
		[Token(Token = "0x6000806")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x20000A3")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C9")]
		internal ParallelWriter<TKey, TValue> m_Writer; //Field offset: 0x0

		[Token(Token = "0x170000E2")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x60007FF")]
			 get { } //Length: 49
		}

		[Obsolete("'m_ThreadIndex' has been deprecated; use 'ThreadIndex' instead. (UnityUpgradable) -> ThreadIndex")]
		[Token(Token = "0x170000E1")]
		public int m_ThreadIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x60007FE")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170000E0")]
		public int ThreadIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x60007FD")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x60007FF")]
		public int get_Capacity() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60007FE")]
		public int get_m_ThreadIndex() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60007FD")]
		public int get_ThreadIndex() { }

		[Address(RVA = "0xE1E080", Offset = "0xE1D480", Length = "0xBD")]
		[Token(Token = "0x6000800")]
		public bool TryAdd(TKey key, TValue item) { }

		[Address(RVA = "0xE1E8E0", Offset = "0xE1DCE0", Length = "0xC5")]
		[Token(Token = "0x6000801")]
		public bool TryAdd(TKey key, TValue item, int threadIndexOverride) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000A2")]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C8")]
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

		[Token(Token = "0x170000DE")]
		public int Capacity
		{
			[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
			[IsReadOnly]
			[Token(Token = "0x60007F1")]
			 get { } //Length: 49
		}

		[Token(Token = "0x170000DC")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x60007EE")]
			 get { } //Length: 40
		}

		[Token(Token = "0x170000DD")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
			[IsReadOnly]
			[Token(Token = "0x60007EF")]
			 get { } //Length: 161
		}

		[Token(Token = "0x170000DF")]
		public TValue Item
		{
			[Address(RVA = "0xEA4B80", Offset = "0xEA3F80", Length = "0x9D")]
			[IsReadOnly]
			[Token(Token = "0x60007F4")]
			 get { } //Length: 157
		}

		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x60007ED")]
		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x60007F8")]
		private void CheckRead() { }

		[Address(RVA = "0xE9E600", Offset = "0xE9DA00", Length = "0x72")]
		[IsReadOnly]
		[Token(Token = "0x60007F3")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xD8A1B0", Offset = "0xD895B0", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x60007F0")]
		public int Count() { }

		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x60007F1")]
		public int get_Capacity() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x60007EE")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4370", Offset = "0xEA3770", Length = "0xA1")]
		[IsReadOnly]
		[Token(Token = "0x60007EF")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xEA4B80", Offset = "0xEA3F80", Length = "0x9D")]
		[IsReadOnly]
		[Token(Token = "0x60007F4")]
		public TValue get_Item(TKey key) { }

		[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
		[IsReadOnly]
		[Token(Token = "0x60007FA")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0DE0", Offset = "0xEA01E0", Length = "0x60")]
		[IsReadOnly]
		[Token(Token = "0x60007F5")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA11D0", Offset = "0xEA05D0", Length = "0x6C")]
		[IsReadOnly]
		[Token(Token = "0x60007F7")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1400", Offset = "0xEA0800", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x60007F6")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60007FB")]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60007FC")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA3020", Offset = "0xEA2420", Length = "0xB5")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x60007F9")]
		private void ThrowKeyNotPresent(TKey key) { }

		[Address(RVA = "0xEA38C0", Offset = "0xEA2CC0", Length = "0x84")]
		[IsReadOnly]
		[Token(Token = "0x60007F2")]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C7")]
	internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

	[Token(Token = "0x170000D9")]
	public int Capacity
	{
		[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
		[IsReadOnly]
		[Token(Token = "0x60007D4")]
		 get { } //Length: 49
		[Address(RVA = "0xD8D070", Offset = "0xD8C470", Length = "0x43")]
		[Token(Token = "0x60007D5")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170000DB")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x60007DE")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170000D8")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD8C730", Offset = "0xD8BB30", Length = "0xA1")]
		[IsReadOnly]
		[Token(Token = "0x60007D2")]
		 get { } //Length: 161
	}

	[Token(Token = "0x170000DA")]
	public TValue Item
	{
		[Address(RVA = "0xD8CD90", Offset = "0xD8C190", Length = "0x9A")]
		[Token(Token = "0x60007DC")]
		 get { } //Length: 154
		[Address(RVA = "0xD8D390", Offset = "0xD8C790", Length = "0x87")]
		[Token(Token = "0x60007DD")]
		 set { } //Length: 135
	}

	[Address(RVA = "0xD8C330", Offset = "0xD8B730", Length = "0x66")]
	[Token(Token = "0x60007D1")]
	public NativeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD89B70", Offset = "0xD88F70", Length = "0x9E")]
	[Token(Token = "0x60007D8")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0xD89C10", Offset = "0xD89010", Length = "0x5C")]
	[Token(Token = "0x60007E4")]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[Address(RVA = "0xD89D10", Offset = "0xD89110", Length = "0x3A")]
	[Token(Token = "0x60007E5")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60007E9")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60007EA")]
	private void CheckWrite() { }

	[Address(RVA = "0xD89D90", Offset = "0xD89190", Length = "0x36")]
	[Token(Token = "0x60007D6")]
	public void Clear() { }

	[Address(RVA = "0xD8A130", Offset = "0xD89530", Length = "0x77")]
	[Token(Token = "0x60007DB")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0xD8A1B0", Offset = "0xD895B0", Length = "0x36")]
	[Token(Token = "0x60007D3")]
	public int Count() { }

	[Address(RVA = "0xD8A760", Offset = "0xD89B60", Length = "0xDA")]
	[Token(Token = "0x60007E0")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD8A6E0", Offset = "0xD89AE0", Length = "0x7E")]
	[Token(Token = "0x60007DF")]
	public override void Dispose() { }

	[Address(RVA = "0xD8C5D0", Offset = "0xD8B9D0", Length = "0x31")]
	[IsReadOnly]
	[Token(Token = "0x60007D4")]
	public int get_Capacity() { }

	[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
	[IsReadOnly]
	[Token(Token = "0x60007DE")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD8C730", Offset = "0xD8BB30", Length = "0xA1")]
	[IsReadOnly]
	[Token(Token = "0x60007D2")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD8CD90", Offset = "0xD8C190", Length = "0x9A")]
	[Token(Token = "0x60007DC")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0xD8B000", Offset = "0xD8A400", Length = "0x4B")]
	[Token(Token = "0x60007E6")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0xD8B1D0", Offset = "0xD8A5D0", Length = "0x66")]
	[Token(Token = "0x60007E1")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8B2B0", Offset = "0xD8A6B0", Length = "0x6F")]
	[Token(Token = "0x60007E3")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8B520", Offset = "0xD8A920", Length = "0x66")]
	[Token(Token = "0x60007E2")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD8B7B0", Offset = "0xD8ABB0", Length = "0x74")]
	[Token(Token = "0x60007D9")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0xD8D070", Offset = "0xD8C470", Length = "0x43")]
	[Token(Token = "0x60007D5")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xD8D390", Offset = "0xD8C790", Length = "0x87")]
	[Token(Token = "0x60007DD")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60007E7")]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60007E8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD8B9E0", Offset = "0xD8ADE0", Length = "0x60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007EC")]
	private void ThrowKeyAlreadyAdded(TKey key) { }

	[Address(RVA = "0xD8BC80", Offset = "0xD8B080", Length = "0xB5")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007EB")]
	private void ThrowKeyNotPresent(TKey key) { }

	[Address(RVA = "0xD89B70", Offset = "0xD88F70", Length = "0x9E")]
	[Token(Token = "0x60007D7")]
	public bool TryAdd(TKey key, TValue item) { }

	[Address(RVA = "0xD8BEC0", Offset = "0xD8B2C0", Length = "0x87")]
	[Token(Token = "0x60007DA")]
	public bool TryGetValue(TKey key, out TValue item) { }

}

