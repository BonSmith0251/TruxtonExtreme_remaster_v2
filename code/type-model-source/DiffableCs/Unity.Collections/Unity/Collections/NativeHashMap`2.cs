namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[NativeContainer]
[Token(Token = "0x2000090")]
public struct NativeHashMap : INativeDisposable, IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x2000091")]
	internal struct Enumerator : IEnumerator<KVPair`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003B9")]
		internal Enumerator<TKey> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000B9")]
		public override KVPair<TKey, TValue> Current
		{
			[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
			[Token(Token = "0x6000743")]
			 get { } //Length: 79
		}

		[Token(Token = "0x170000BA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19B8330", Offset = "0x19B7730", Length = "0x99")]
			[Token(Token = "0x6000744")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000740")]
		public override void Dispose() { }

		[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
		[Token(Token = "0x6000743")]
		public override KVPair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19B4660", Offset = "0x19B3A60", Length = "0x36")]
		[Token(Token = "0x6000741")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19B4BE0", Offset = "0x19B3FE0", Length = "0x36")]
		[Token(Token = "0x6000742")]
		public override void Reset() { }

		[Address(RVA = "0x19B8330", Offset = "0x19B7730", Length = "0x99")]
		[Token(Token = "0x6000744")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x2000092")]
	internal struct ReadOnly : IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003BA")]
		internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0

		[Token(Token = "0x170000BE")]
		public int Capacity
		{
			[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000749")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000BD")]
		public int Count
		{
			[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000748")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000BB")]
		public bool IsCreated
		{
			[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
			[IsReadOnly]
			[Token(Token = "0x6000746")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000BC")]
		public bool IsEmpty
		{
			[Address(RVA = "0xE9E1D0", Offset = "0xE9D5D0", Length = "0xB5")]
			[IsReadOnly]
			[Token(Token = "0x6000747")]
			 get { } //Length: 181
		}

		[Token(Token = "0x170000BF")]
		public TValue Item
		{
			[Address(RVA = "0xEA4CD0", Offset = "0xEA40D0", Length = "0x55")]
			[IsReadOnly]
			[Token(Token = "0x600074C")]
			 get { } //Length: 85
		}

		[Address(RVA = "0xE9E120", Offset = "0xE9D520", Length = "0x7")]
		[Token(Token = "0x6000745")]
		internal ReadOnly(ref NativeHashMap<TKey, TValue>& data) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x6000753")]
		private void CheckRead() { }

		[Address(RVA = "0xE9E890", Offset = "0xE9DC90", Length = "0x4A")]
		[IsReadOnly]
		[Token(Token = "0x600074B")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000749")]
		public int get_Capacity() { }

		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000748")]
		public int get_Count() { }

		[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x6000746")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xE9E1D0", Offset = "0xE9D5D0", Length = "0xB5")]
		[IsReadOnly]
		[Token(Token = "0x6000747")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xEA4CD0", Offset = "0xEA40D0", Length = "0x55")]
		[IsReadOnly]
		[Token(Token = "0x600074C")]
		public TValue get_Item(TKey key) { }

		[Address(RVA = "0xEA0400", Offset = "0xE9F800", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x6000750")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0F10", Offset = "0xEA0310", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x600074D")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA12B0", Offset = "0xEA06B0", Length = "0x6F")]
		[IsReadOnly]
		[Token(Token = "0x600074F")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1640", Offset = "0xEA0A40", Length = "0x66")]
		[IsReadOnly]
		[Token(Token = "0x600074E")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000751")]
		private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000752")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA30E0", Offset = "0xEA24E0", Length = "0x8D")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000754")]
		private void ThrowKeyNotPresent(TKey key) { }

		[Address(RVA = "0xEA3B70", Offset = "0xEA2F70", Length = "0x53")]
		[IsReadOnly]
		[Token(Token = "0x600074A")]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003B8")]
	internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0

	[Token(Token = "0x170000B7")]
	public int Capacity
	{
		[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x600072A")]
		 get { } //Length: 25
		[Address(RVA = "0xD6B900", Offset = "0xD6AD00", Length = "0x43")]
		[Token(Token = "0x600072B")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170000B6")]
	public int Count
	{
		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000729")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000B4")]
	public bool IsCreated
	{
		[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x6000727")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170000B5")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD6B5C0", Offset = "0xD6A9C0", Length = "0xB5")]
		[IsReadOnly]
		[Token(Token = "0x6000728")]
		 get { } //Length: 181
	}

	[Token(Token = "0x170000B8")]
	public TValue Item
	{
		[Address(RVA = "0xD6B680", Offset = "0xD6AA80", Length = "0x58")]
		[Token(Token = "0x6000733")]
		 get { } //Length: 88
		[Address(RVA = "0xD6B950", Offset = "0xD6AD50", Length = "0xD2")]
		[Token(Token = "0x6000734")]
		 set { } //Length: 210
	}

	[Address(RVA = "0xD6B2B0", Offset = "0xD6A6B0", Length = "0x64")]
	[Token(Token = "0x6000724")]
	public NativeHashMap`2(int initialCapacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD69EC0", Offset = "0xD692C0", Length = "0x56")]
	[Token(Token = "0x600072E")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0xD6A080", Offset = "0xD69480", Length = "0x4D")]
	[Token(Token = "0x600073B")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x600073C")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x600073D")]
	private void CheckWrite() { }

	[Address(RVA = "0xD6A0D0", Offset = "0xD694D0", Length = "0x36")]
	[Token(Token = "0x600072C")]
	public void Clear() { }

	[Address(RVA = "0xD6A280", Offset = "0xD69680", Length = "0x4D")]
	[Token(Token = "0x6000731")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0xD6A2D0", Offset = "0xD696D0", Length = "0x98")]
	[Token(Token = "0x6000725")]
	public override void Dispose() { }

	[Address(RVA = "0xD6A540", Offset = "0xD69940", Length = "0xE4")]
	[Token(Token = "0x6000726")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x600072A")]
	public int get_Capacity() { }

	[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x6000729")]
	public int get_Count() { }

	[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
	[IsReadOnly]
	[Token(Token = "0x6000727")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD6B5C0", Offset = "0xD6A9C0", Length = "0xB5")]
	[IsReadOnly]
	[Token(Token = "0x6000728")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD6B680", Offset = "0xD6AA80", Length = "0x58")]
	[Token(Token = "0x6000733")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0xD6A630", Offset = "0xD69A30", Length = "0x77")]
	[Token(Token = "0x6000738")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0xD6A760", Offset = "0xD69B60", Length = "0x66")]
	[Token(Token = "0x6000735")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD6A880", Offset = "0xD69C80", Length = "0x6F")]
	[Token(Token = "0x6000737")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0xD6A8F0", Offset = "0xD69CF0", Length = "0x66")]
	[Token(Token = "0x6000736")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD6AB10", Offset = "0xD69F10", Length = "0x4D")]
	[Token(Token = "0x600072F")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0xD6B900", Offset = "0xD6AD00", Length = "0x43")]
	[Token(Token = "0x600072B")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xD6B950", Offset = "0xD6AD50", Length = "0xD2")]
	[Token(Token = "0x6000734")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000739")]
	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x600073A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD6AB60", Offset = "0xD69F60", Length = "0x8D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600073F")]
	private void ThrowKeyAlreadyAdded(TKey key) { }

	[Address(RVA = "0xD6ACE0", Offset = "0xD6A0E0", Length = "0x8D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600073E")]
	private void ThrowKeyNotPresent(TKey key) { }

	[Address(RVA = "0xD6AEE0", Offset = "0xD6A2E0", Length = "0x39")]
	[Token(Token = "0x6000732")]
	public void TrimExcess() { }

	[Address(RVA = "0xD6B0A0", Offset = "0xD6A4A0", Length = "0x99")]
	[Token(Token = "0x600072D")]
	public bool TryAdd(TKey key, TValue item) { }

	[Address(RVA = "0xD6B140", Offset = "0xD6A540", Length = "0x56")]
	[Token(Token = "0x6000730")]
	public bool TryGetValue(TKey key, out TValue item) { }

}

