namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList32BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200004E")]
public struct FixedList32Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[Token(Token = "0x200004F")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C0")]
		private FixedList32Bytes<T> m_List; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		public override T Current
		{
			[Address(RVA = "0x1963F70", Offset = "0x1963370", Length = "0x44")]
			[Token(Token = "0x600025D")]
			 get { } //Length: 68
		}

		[Token(Token = "0x1700004D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1962910", Offset = "0x1961D10", Length = "0xA0")]
			[Token(Token = "0x600025E")]
			private get { } //Length: 160
		}

		[Address(RVA = "0x1962F30", Offset = "0x1962330", Length = "0x16")]
		[Token(Token = "0x6000259")]
		public Enumerator(ref FixedList32Bytes<T>& list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600025A")]
		public override void Dispose() { }

		[Address(RVA = "0x1963F70", Offset = "0x1963370", Length = "0x44")]
		[Token(Token = "0x600025D")]
		public override T get_Current() { }

		[Address(RVA = "0x195D500", Offset = "0x195C900", Length = "0x5A")]
		[Token(Token = "0x600025B")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1960180", Offset = "0x195F580", Length = "0x8")]
		[Token(Token = "0x600025C")]
		public override void Reset() { }

		[Address(RVA = "0x1962910", Offset = "0x1961D10", Length = "0xA0")]
		[Token(Token = "0x600025E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000BF")]
	internal FixedBytes32Align8 data; //Field offset: 0x0

	[Token(Token = "0x17000044")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1BD9720", Offset = "0x1BD8B20", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000219")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000049")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1BD9560", Offset = "0x1BD8960", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x600021F")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x1700004A")]
	public override int Capacity
	{
		[Address(RVA = "0x1BD95E0", Offset = "0x1BD89E0", Length = "0x7A")]
		[IsReadOnly]
		[Token(Token = "0x6000220")]
		 get { } //Length: 122
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000221")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x17000046")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0x1BD9660", Offset = "0x1BD8A60", Length = "0x36")]
		[Token(Token = "0x600021C")]
		private get { } //Length: 54
	}

	[Token(Token = "0x17000047")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
		[IsReadOnly]
		[Token(Token = "0x600021D")]
		 get { } //Length: 72
	}

	[Token(Token = "0x1700004B")]
	public override T Item
	{
		[Address(RVA = "0x1BD96A0", Offset = "0x1BD8AA0", Length = "0x7D")]
		[IsReadOnly]
		[Token(Token = "0x6000222")]
		 get { } //Length: 125
		[Address(RVA = "0x1BDA1C0", Offset = "0x1BD95C0", Length = "0x7D")]
		[Token(Token = "0x6000223")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000043")]
	internal ushort length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000217")]
		internal get { } //Length: 4
		[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
		[Token(Token = "0x6000218")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x17000045")]
	public override int Length
	{
		[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x600021A")]
		 get { } //Length: 36
		[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
		[Token(Token = "0x600021B")]
		 set { } //Length: 47
	}

	[Token(Token = "0x17000048")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
		[Token(Token = "0x600021E")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x1BD93E0", Offset = "0x1BD87E0", Length = "0x52")]
	[Token(Token = "0x600023D")]
	public FixedList32Bytes`1(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BD9440", Offset = "0x1BD8840", Length = "0x52")]
	[Token(Token = "0x6000252")]
	public FixedList32Bytes`1(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BD9500", Offset = "0x1BD8900", Length = "0x52")]
	[Token(Token = "0x6000244")]
	public FixedList32Bytes`1(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BD94A0", Offset = "0x1BD88A0", Length = "0x52")]
	[Token(Token = "0x600024B")]
	public FixedList32Bytes`1(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD6EC0", Offset = "0x1BD62C0", Length = "0x48")]
	[Token(Token = "0x6000226")]
	public void Add(in T item) { }

	[Address(RVA = "0x1BD6B00", Offset = "0x1BD5F00", Length = "0xD6")]
	[Token(Token = "0x6000228")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1BD6D20", Offset = "0x1BD6120", Length = "0x58")]
	[Token(Token = "0x6000227")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1BD6BE0", Offset = "0x1BD5FE0", Length = "0x131")]
	[Token(Token = "0x6000229")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1BD6D80", Offset = "0x1BD6180", Length = "0x13E")]
	[Token(Token = "0x600022A")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1BC8170", Offset = "0x1BC7570", Length = "0x49")]
	[Token(Token = "0x600022B")]
	public override void Clear() { }

	[Address(RVA = "0x1BD7350", Offset = "0x1BD6750", Length = "0x21B")]
	[Token(Token = "0x6000237")]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BD7570", Offset = "0x1BD6970", Length = "0x21E")]
	[Token(Token = "0x6000242")]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BD6F10", Offset = "0x1BD6310", Length = "0x21E")]
	[Token(Token = "0x6000250")]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BD7790", Offset = "0x1BD6B90", Length = "0x21E")]
	[Token(Token = "0x600023B")]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BD7130", Offset = "0x1BD6530", Length = "0x21E")]
	[Token(Token = "0x6000249")]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BD79B0", Offset = "0x1BD6DB0", Length = "0x69")]
	[Token(Token = "0x6000224")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1BD7A20", Offset = "0x1BD6E20", Length = "0x8F")]
	[Token(Token = "0x6000251")]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BD8270", Offset = "0x1BD7670", Length = "0xA6")]
	[Token(Token = "0x6000243")]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BD7BE0", Offset = "0x1BD6FE0", Length = "0x609")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x6000255")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BD81F0", Offset = "0x1BD75F0", Length = "0x73")]
	[Token(Token = "0x600023C")]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BD7AB0", Offset = "0x1BD6EB0", Length = "0xB6")]
	[Token(Token = "0x600024A")]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BD7B70", Offset = "0x1BD6F70", Length = "0x61")]
	[Token(Token = "0x6000238")]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BD9720", Offset = "0x1BD8B20", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000219")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1BD9560", Offset = "0x1BD8960", Length = "0x77")]
	[IsReadOnly]
	[Token(Token = "0x600021F")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1BD95E0", Offset = "0x1BD89E0", Length = "0x7A")]
	[IsReadOnly]
	[Token(Token = "0x6000220")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1BD9660", Offset = "0x1BD8A60", Length = "0x36")]
	[Token(Token = "0x600021C")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
	[IsReadOnly]
	[Token(Token = "0x600021D")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1BD96A0", Offset = "0x1BD8AA0", Length = "0x7D")]
	[IsReadOnly]
	[Token(Token = "0x6000222")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000217")]
	internal ushort get_length() { }

	[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x600021A")]
	public override int get_Length() { }

	[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
	[Token(Token = "0x600021E")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1BD8320", Offset = "0x1BD7720", Length = "0x5C")]
	[Token(Token = "0x6000256")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1BD8380", Offset = "0x1BD7780", Length = "0xC6")]
	[Token(Token = "0x6000225")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BD8450", Offset = "0x1BD7850", Length = "0x173")]
	[Token(Token = "0x600024C")]
	internal int Initialize(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD85D0", Offset = "0x1BD79D0", Length = "0x173")]
	[Token(Token = "0x6000245")]
	internal int Initialize(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BD8750", Offset = "0x1BD7B50", Length = "0x173")]
	[Token(Token = "0x600023E")]
	internal int Initialize(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BD88D0", Offset = "0x1BD7CD0", Length = "0x173")]
	[Token(Token = "0x6000253")]
	internal int Initialize(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BD8C10", Offset = "0x1BD8010", Length = "0x99")]
	[Token(Token = "0x600022E")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1BD8BB0", Offset = "0x1BD7FB0", Length = "0x57")]
	[Token(Token = "0x600022D")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1BD8A50", Offset = "0x1BD7E50", Length = "0x15C")]
	[Token(Token = "0x600022C")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1BD98B0", Offset = "0x1BD8CB0", Length = "0x14C")]
	[Token(Token = "0x600024E")]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BD9CA0", Offset = "0x1BD90A0", Length = "0x14C")]
	[Token(Token = "0x6000239")]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BD9A00", Offset = "0x1BD8E00", Length = "0x14C")]
	[Token(Token = "0x6000247")]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BD9B50", Offset = "0x1BD8F50", Length = "0x14C")]
	[Token(Token = "0x6000240")]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BD9760", Offset = "0x1BD8B60", Length = "0x149")]
	[Token(Token = "0x6000235")]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BD9DF0", Offset = "0x1BD91F0", Length = "0x83")]
	[Token(Token = "0x600024D")]
	public static FixedList32Bytes<T> op_Implicit(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD9E80", Offset = "0x1BD9280", Length = "0x83")]
	[Token(Token = "0x6000246")]
	public static FixedList32Bytes<T> op_Implicit(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BD9F10", Offset = "0x1BD9310", Length = "0x83")]
	[Token(Token = "0x600023F")]
	public static FixedList32Bytes<T> op_Implicit(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BD9FA0", Offset = "0x1BD93A0", Length = "0x83")]
	[Token(Token = "0x6000254")]
	public static FixedList32Bytes<T> op_Implicit(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BDA170", Offset = "0x1BD9570", Length = "0x4B")]
	[Token(Token = "0x6000248")]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BDA030", Offset = "0x1BD9430", Length = "0x4B")]
	[Token(Token = "0x600023A")]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BDA080", Offset = "0x1BD9480", Length = "0x4B")]
	[Token(Token = "0x600024F")]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BDA120", Offset = "0x1BD9520", Length = "0x4B")]
	[Token(Token = "0x6000236")]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BDA0D0", Offset = "0x1BD94D0", Length = "0x4B")]
	[Token(Token = "0x6000241")]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BD8D00", Offset = "0x1BD8100", Length = "0x4C")]
	[Token(Token = "0x6000231")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BD8CB0", Offset = "0x1BD80B0", Length = "0x4C")]
	[Token(Token = "0x600022F")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1BD8F00", Offset = "0x1BD8300", Length = "0x1A9")]
	[Token(Token = "0x6000232")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1BD8D50", Offset = "0x1BD8150", Length = "0x1AB")]
	[Token(Token = "0x6000230")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000221")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1BDA1C0", Offset = "0x1BD95C0", Length = "0x7D")]
	[Token(Token = "0x6000223")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000218")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
	[Token(Token = "0x600021B")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000258")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000257")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1BD90B0", Offset = "0x1BD84B0", Length = "0x177")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x6000233")]
	public T[] ToArray() { }

	[Address(RVA = "0x1BD9230", Offset = "0x1BD8630", Length = "0x1A1")]
	[Token(Token = "0x6000234")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

