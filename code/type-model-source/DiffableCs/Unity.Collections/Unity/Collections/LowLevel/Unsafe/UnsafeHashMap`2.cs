namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x200010B")]
public struct UnsafeHashMap : INativeDisposable, IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x200010C")]
	internal struct Enumerator : IEnumerator<KVPair`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B9")]
		internal Enumerator<TKey> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x17000148")]
		public override KVPair<TKey, TValue> Current
		{
			[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
			[Token(Token = "0x6000B6F")]
			 get { } //Length: 79
		}

		[Token(Token = "0x17000149")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19B8330", Offset = "0x19B7730", Length = "0x99")]
			[Token(Token = "0x6000B70")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000B6C")]
		public override void Dispose() { }

		[Address(RVA = "0xAE8A20", Offset = "0xAE7E20", Length = "0x4F")]
		[Token(Token = "0x6000B6F")]
		public override KVPair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19B4660", Offset = "0x19B3A60", Length = "0x36")]
		[Token(Token = "0x6000B6D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19B4BE0", Offset = "0x19B3FE0", Length = "0x36")]
		[Token(Token = "0x6000B6E")]
		public override void Reset() { }

		[Address(RVA = "0x19B8330", Offset = "0x19B7730", Length = "0x99")]
		[Token(Token = "0x6000B70")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x200010D")]
	internal struct ReadOnly : IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004BA")]
		internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

		[Token(Token = "0x1700014D")]
		public int Capacity
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000B75")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700014C")]
		public int Count
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000B74")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700014A")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
			[IsReadOnly]
			[Token(Token = "0x6000B72")]
			 get { } //Length: 40
		}

		[Token(Token = "0x1700014B")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA45D0", Offset = "0xEA39D0", Length = "0x56")]
			[IsReadOnly]
			[Token(Token = "0x6000B73")]
			 get { } //Length: 86
		}

		[Token(Token = "0x1700014E")]
		public TValue Item
		{
			[Address(RVA = "0xEA4790", Offset = "0xEA3B90", Length = "0x6E")]
			[IsReadOnly]
			[Token(Token = "0x6000B78")]
			 get { } //Length: 110
		}

		[Address(RVA = "0xEA41E0", Offset = "0xEA35E0", Length = "0x1F")]
		[Token(Token = "0x6000B71")]
		internal ReadOnly(ref HashMapHelper<TKey>& data) { }

		[Address(RVA = "0xE9E780", Offset = "0xE9DB80", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x6000B77")]
		public bool ContainsKey(TKey key) { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B75")]
		public int get_Capacity() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B74")]
		public int get_Count() { }

		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x6000B72")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA45D0", Offset = "0xEA39D0", Length = "0x56")]
		[IsReadOnly]
		[Token(Token = "0x6000B73")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xEA4790", Offset = "0xEA3B90", Length = "0x6E")]
		[IsReadOnly]
		[Token(Token = "0x6000B78")]
		public TValue get_Item(TKey key) { }

		[Address(RVA = "0xEA0690", Offset = "0xE9FA90", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x6000B7C")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xEA0F80", Offset = "0xEA0380", Length = "0x7E")]
		[IsReadOnly]
		[Token(Token = "0x6000B79")]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA1140", Offset = "0xEA0540", Length = "0x8D")]
		[IsReadOnly]
		[Token(Token = "0x6000B7B")]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[Address(RVA = "0xEA15C0", Offset = "0xEA09C0", Length = "0x7E")]
		[IsReadOnly]
		[Token(Token = "0x6000B7A")]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000B7D")]
		private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000B7E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA3850", Offset = "0xEA2C50", Length = "0x6C")]
		[IsReadOnly]
		[Token(Token = "0x6000B76")]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004B8")]
	internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

	[Token(Token = "0x17000146")]
	public int Capacity
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B58")]
		 get { } //Length: 4
		[Address(RVA = "0x11A70C0", Offset = "0x11A64C0", Length = "0x43")]
		[Token(Token = "0x6000B59")]
		 set { } //Length: 67
	}

	[Token(Token = "0x17000145")]
	public int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B57")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000143")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
		[IsReadOnly]
		[Token(Token = "0x6000B55")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000144")]
	public bool IsEmpty
	{
		[Address(RVA = "0x11A6E70", Offset = "0x11A6270", Length = "0x56")]
		[IsReadOnly]
		[Token(Token = "0x6000B56")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000147")]
	public TValue Item
	{
		[Address(RVA = "0x11A6ED0", Offset = "0x11A62D0", Length = "0x58")]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 88
		[Address(RVA = "0x11A73E0", Offset = "0x11A67E0", Length = "0xC2")]
		[Token(Token = "0x6000B62")]
		 set { } //Length: 194
	}

	[Address(RVA = "0x11A6D10", Offset = "0x11A6110", Length = "0x78")]
	[Token(Token = "0x6000B52")]
	public UnsafeHashMap`2(int initialCapacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x11A5BD0", Offset = "0x11A4FD0", Length = "0x56")]
	[Token(Token = "0x6000B5C")]
	public void Add(TKey key, TValue item) { }

	[Address(RVA = "0x11A5D90", Offset = "0x11A5190", Length = "0x5E")]
	[Token(Token = "0x6000B69")]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[Address(RVA = "0x11A5DF0", Offset = "0x11A51F0", Length = "0x36")]
	[Token(Token = "0x6000B5A")]
	public void Clear() { }

	[Address(RVA = "0x11A5E30", Offset = "0x11A5230", Length = "0x4D")]
	[Token(Token = "0x6000B5F")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0x11A60C0", Offset = "0x11A54C0", Length = "0xEB")]
	[Token(Token = "0x6000B54")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11A5F80", Offset = "0x11A5380", Length = "0x7B")]
	[Token(Token = "0x6000B53")]
	public override void Dispose() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000B58")]
	public int get_Capacity() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000B57")]
	public int get_Count() { }

	[Address(RVA = "0xD8C680", Offset = "0xD8BA80", Length = "0x28")]
	[IsReadOnly]
	[Token(Token = "0x6000B55")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11A6E70", Offset = "0x11A6270", Length = "0x56")]
	[IsReadOnly]
	[Token(Token = "0x6000B56")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x11A6ED0", Offset = "0x11A62D0", Length = "0x58")]
	[Token(Token = "0x6000B61")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0x11A62C0", Offset = "0x11A56C0", Length = "0x77")]
	[Token(Token = "0x6000B66")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0x11A6340", Offset = "0x11A5740", Length = "0x66")]
	[Token(Token = "0x6000B63")]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11A63B0", Offset = "0x11A57B0", Length = "0x6F")]
	[Token(Token = "0x6000B65")]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0x11A6420", Offset = "0x11A5820", Length = "0x66")]
	[Token(Token = "0x6000B64")]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11A6590", Offset = "0x11A5990", Length = "0x4D")]
	[Token(Token = "0x6000B5D")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0x11A70C0", Offset = "0x11A64C0", Length = "0x43")]
	[Token(Token = "0x6000B59")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0x11A73E0", Offset = "0x11A67E0", Length = "0xC2")]
	[Token(Token = "0x6000B62")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000B67")]
	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000B68")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x11A65E0", Offset = "0x11A59E0", Length = "0x8D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B6B")]
	private void ThrowKeyAlreadyAdded(TKey key) { }

	[Address(RVA = "0x11A6760", Offset = "0x11A5B60", Length = "0x8D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B6A")]
	private void ThrowKeyNotPresent(TKey key) { }

	[Address(RVA = "0x11A68E0", Offset = "0x11A5CE0", Length = "0x39")]
	[Token(Token = "0x6000B60")]
	public void TrimExcess() { }

	[Address(RVA = "0x11A69A0", Offset = "0x11A5DA0", Length = "0x89")]
	[Token(Token = "0x6000B5B")]
	public bool TryAdd(TKey key, TValue item) { }

	[Address(RVA = "0x11A6BA0", Offset = "0x11A5FA0", Length = "0x56")]
	[Token(Token = "0x6000B5E")]
	public bool TryGetValue(TKey key, out TValue item) { }

}

