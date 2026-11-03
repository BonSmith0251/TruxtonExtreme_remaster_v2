namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200010F")]
public struct UnsafeHashSet : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable
{
	[Token(Token = "0x2000110")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BD")]
		internal Enumerator<T> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x17000154")]
		public override T Current
		{
			[Address(RVA = "0x19A8EF0", Offset = "0x19A82F0", Length = "0xB5")]
			[Token(Token = "0x6000B97")]
			 get { } //Length: 181
		}

		[Token(Token = "0x17000155")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19A4AD0", Offset = "0x19A3ED0", Length = "0xFD")]
			[Token(Token = "0x6000B98")]
			private get { } //Length: 253
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000B94")]
		public override void Dispose() { }

		[Address(RVA = "0x19A8EF0", Offset = "0x19A82F0", Length = "0xB5")]
		[Token(Token = "0x6000B97")]
		public override T get_Current() { }

		[Address(RVA = "0xD6DEE0", Offset = "0xD6D2E0", Length = "0x70")]
		[Token(Token = "0x6000B95")]
		public override bool MoveNext() { }

		[Address(RVA = "0xEA4280", Offset = "0xEA3680", Length = "0x70")]
		[Token(Token = "0x6000B96")]
		public override void Reset() { }

		[Address(RVA = "0x19A4AD0", Offset = "0x19A3ED0", Length = "0xFD")]
		[Token(Token = "0x6000B98")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x2000111")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BE")]
		internal HashMapHelper<T> m_Data; //Field offset: 0x0

		[Token(Token = "0x17000159")]
		public int Capacity
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000B9D")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000158")]
		public int Count
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000B9C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000156")]
		public bool IsCreated
		{
			[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000B9A")]
			 get { } //Length: 112
		}

		[Token(Token = "0x17000157")]
		public bool IsEmpty
		{
			[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
			[IsReadOnly]
			[Token(Token = "0x6000B9B")]
			 get { } //Length: 112
		}

		[Address(RVA = "0xEA41E0", Offset = "0xEA35E0", Length = "0x1F")]
		[Token(Token = "0x6000B99")]
		internal ReadOnly(ref HashMapHelper<T>& data) { }

		[Address(RVA = "0xE9E9E0", Offset = "0xE9DDE0", Length = "0x10D")]
		[IsReadOnly]
		[Token(Token = "0x6000B9E")]
		public bool Contains(T item) { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B9D")]
		public int get_Capacity() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B9C")]
		public int get_Count() { }

		[Address(RVA = "0xD8E070", Offset = "0xD8D470", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000B9A")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xD8DC50", Offset = "0xD8D050", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000B9B")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xEA0060", Offset = "0xE9F460", Length = "0x74")]
		[IsReadOnly]
		[Token(Token = "0x6000BA0")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000BA1")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000BA2")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xEA3220", Offset = "0xEA2620", Length = "0xAE")]
		[IsReadOnly]
		[Token(Token = "0x6000B9F")]
		public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004BC")]
	internal HashMapHelper<T> m_Data; //Field offset: 0x0

	[Token(Token = "0x17000152")]
	public int Capacity
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B85")]
		 get { } //Length: 4
		[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
		[Token(Token = "0x6000B86")]
		 set { } //Length: 126
	}

	[Token(Token = "0x17000151")]
	public int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000B84")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000153")]
	public bool IsCreated
	{
		[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x6000B87")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000150")]
	public bool IsEmpty
	{
		[Address(RVA = "0xEA4500", Offset = "0xEA3900", Length = "0xCE")]
		[IsReadOnly]
		[Token(Token = "0x6000B83")]
		 get { } //Length: 206
	}

	[Address(RVA = "0x11A7C60", Offset = "0x11A7060", Length = "0xB0")]
	[Token(Token = "0x6000B82")]
	public UnsafeHashSet`1(int initialCapacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x11A76D0", Offset = "0x11A6AD0", Length = "0x83")]
	[Token(Token = "0x6000B8B")]
	public bool Add(T item) { }

	[Address(RVA = "0x11A7760", Offset = "0x11A6B60", Length = "0x5E")]
	[Token(Token = "0x6000B93")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD89DD0", Offset = "0xD891D0", Length = "0x70")]
	[Token(Token = "0x6000B8A")]
	public void Clear() { }

	[Address(RVA = "0x11A77C0", Offset = "0x11A6BC0", Length = "0xEC")]
	[Token(Token = "0x6000B8D")]
	public bool Contains(T item) { }

	[Address(RVA = "0x11A78B0", Offset = "0x11A6CB0", Length = "0xB9")]
	[Token(Token = "0x6000B88")]
	public override void Dispose() { }

	[Address(RVA = "0x11A7970", Offset = "0x11A6D70", Length = "0xFC")]
	[Token(Token = "0x6000B89")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000B85")]
	public int get_Capacity() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000B84")]
	public int get_Count() { }

	[Address(RVA = "0xD8C610", Offset = "0xD8BA10", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000B87")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xEA4500", Offset = "0xEA3900", Length = "0xCE")]
	[IsReadOnly]
	[Token(Token = "0x6000B83")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x11A7A70", Offset = "0x11A6E70", Length = "0x77")]
	[Token(Token = "0x6000B90")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x11A7AF0", Offset = "0x11A6EF0", Length = "0xEC")]
	[Token(Token = "0x6000B8C")]
	public bool Remove(T item) { }

	[Address(RVA = "0xD8E0E0", Offset = "0xD8D4E0", Length = "0x7E")]
	[Token(Token = "0x6000B86")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000B91")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000B92")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEB71F0", Offset = "0xEB65F0", Length = "0xA0")]
	[Token(Token = "0x6000B8F")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x11A7BE0", Offset = "0x11A6FE0", Length = "0x76")]
	[Token(Token = "0x6000B8E")]
	public void TrimExcess() { }

}

