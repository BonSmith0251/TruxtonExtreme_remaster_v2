namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
[Token(Token = "0x2000094")]
public struct NativeHashSet : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x2000095")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003BD")]
		internal Enumerator<T> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170000C5")]
		public override T Current
		{
			[Address(RVA = "0x198AC80", Offset = "0x198A080", Length = "0x47")]
			[Token(Token = "0x600076F")]
			 get { } //Length: 71
		}

		[Token(Token = "0x170000C6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x198A2D0", Offset = "0x19896D0", Length = "0x9D")]
			[Token(Token = "0x6000770")]
			private get { } //Length: 157
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600076C")]
		public override void Dispose() { }

		[Address(RVA = "0x198AC80", Offset = "0x198A080", Length = "0x47")]
		[Token(Token = "0x600076F")]
		public override T get_Current() { }

		[Address(RVA = "0x1987330", Offset = "0x1986730", Length = "0x74")]
		[Token(Token = "0x600076D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19883E0", Offset = "0x19877E0", Length = "0x36")]
		[Token(Token = "0x600076E")]
		public override void Reset() { }

		[Address(RVA = "0x198A2D0", Offset = "0x19896D0", Length = "0x9D")]
		[Token(Token = "0x6000770")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x2000096")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003BE")]
		internal HashMapHelper<T>* m_Data; //Field offset: 0x0

		[Token(Token = "0x170000CA")]
		public int Capacity
		{
			[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000775")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000C9")]
		public int Count
		{
			[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
			[IsReadOnly]
			[Token(Token = "0x6000774")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170000C7")]
		public bool IsCreated
		{
			[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
			[IsReadOnly]
			[Token(Token = "0x6000772")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000C8")]
		public bool IsEmpty
		{
			[Address(RVA = "0xE9E1D0", Offset = "0xE9D5D0", Length = "0xB5")]
			[IsReadOnly]
			[Token(Token = "0x6000773")]
			 get { } //Length: 181
		}

		[Address(RVA = "0xE9E120", Offset = "0xE9D520", Length = "0x7")]
		[Token(Token = "0x6000771")]
		internal ReadOnly(ref NativeHashSet<T>& data) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x600077B")]
		private void CheckRead() { }

		[Address(RVA = "0xE9B460", Offset = "0xE9A860", Length = "0x4A")]
		[IsReadOnly]
		[Token(Token = "0x6000776")]
		public bool Contains(T item) { }

		[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000775")]
		public int get_Capacity() { }

		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x6000774")]
		public int get_Count() { }

		[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x6000772")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xE9E1D0", Offset = "0xE9D5D0", Length = "0xB5")]
		[IsReadOnly]
		[Token(Token = "0x6000773")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xE9BAB0", Offset = "0xE9AEB0", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x6000778")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000779")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x600077A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xE9DB20", Offset = "0xE9CF20", Length = "0x63")]
		[IsReadOnly]
		[Token(Token = "0x6000777")]
		public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003BC")]
	internal HashMapHelper<T>* m_Data; //Field offset: 0x0

	[Token(Token = "0x170000C3")]
	public int Capacity
	{
		[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x600075B")]
		 get { } //Length: 25
		[Address(RVA = "0xD6CC30", Offset = "0xD6C030", Length = "0x43")]
		[Token(Token = "0x600075C")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170000C2")]
	public int Count
	{
		[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x600075A")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000C4")]
	public bool IsCreated
	{
		[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x600075D")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170000C1")]
	public bool IsEmpty
	{
		[Address(RVA = "0xD6CB70", Offset = "0xD6BF70", Length = "0xB5")]
		[IsReadOnly]
		[Token(Token = "0x6000759")]
		 get { } //Length: 181
	}

	[Address(RVA = "0xD6C910", Offset = "0xD6BD10", Length = "0x60")]
	[Token(Token = "0x6000758")]
	public NativeHashSet`1(int initialCapacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD6BEE0", Offset = "0xD6B2E0", Length = "0x45")]
	[Token(Token = "0x6000761")]
	public bool Add(T item) { }

	[Address(RVA = "0xD6BFC0", Offset = "0xD6B3C0", Length = "0x4D")]
	[Token(Token = "0x6000769")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x600076A")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x600076B")]
	private void CheckWrite() { }

	[Address(RVA = "0xD6C010", Offset = "0xD6B410", Length = "0x36")]
	[Token(Token = "0x6000760")]
	public void Clear() { }

	[Address(RVA = "0xD6C0C0", Offset = "0xD6B4C0", Length = "0x4D")]
	[Token(Token = "0x6000763")]
	public bool Contains(T item) { }

	[Address(RVA = "0xD6C2E0", Offset = "0xD6B6E0", Length = "0x98")]
	[Token(Token = "0x600075E")]
	public override void Dispose() { }

	[Address(RVA = "0xD6C380", Offset = "0xD6B780", Length = "0xE4")]
	[Token(Token = "0x600075F")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD6B3E0", Offset = "0xD6A7E0", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x600075B")]
	public int get_Capacity() { }

	[Address(RVA = "0xD6B400", Offset = "0xD6A800", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x600075A")]
	public int get_Count() { }

	[Address(RVA = "0xD6B4A0", Offset = "0xD6A8A0", Length = "0x3C")]
	[IsReadOnly]
	[Token(Token = "0x600075D")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD6CB70", Offset = "0xD6BF70", Length = "0xB5")]
	[IsReadOnly]
	[Token(Token = "0x6000759")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xD6C570", Offset = "0xD6B970", Length = "0x77")]
	[Token(Token = "0x6000766")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD6C5F0", Offset = "0xD6B9F0", Length = "0x4A")]
	[Token(Token = "0x6000762")]
	public bool Remove(T item) { }

	[Address(RVA = "0xD6CC30", Offset = "0xD6C030", Length = "0x43")]
	[Token(Token = "0x600075C")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000767")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000768")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD6C7E0", Offset = "0xD6BBE0", Length = "0x66")]
	[Token(Token = "0x6000765")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD6C8D0", Offset = "0xD6BCD0", Length = "0x39")]
	[Token(Token = "0x6000764")]
	public void TrimExcess() { }

}

