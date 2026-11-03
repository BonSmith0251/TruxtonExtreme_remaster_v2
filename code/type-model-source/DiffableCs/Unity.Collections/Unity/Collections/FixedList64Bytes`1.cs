namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList64BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000052")]
public struct FixedList64Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[Token(Token = "0x2000053")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C4")]
		private FixedList64Bytes<T> m_List; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C5")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000058")]
		public override T Current
		{
			[Address(RVA = "0x19643D0", Offset = "0x19637D0", Length = "0x44")]
			[Token(Token = "0x60002AB")]
			 get { } //Length: 68
		}

		[Token(Token = "0x17000059")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1961A70", Offset = "0x1960E70", Length = "0xA0")]
			[Token(Token = "0x60002AC")]
			private get { } //Length: 160
		}

		[Address(RVA = "0x19636A0", Offset = "0x1962AA0", Length = "0x26")]
		[Token(Token = "0x60002A7")]
		public Enumerator(ref FixedList64Bytes<T>& list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002A8")]
		public override void Dispose() { }

		[Address(RVA = "0x19643D0", Offset = "0x19637D0", Length = "0x44")]
		[Token(Token = "0x60002AB")]
		public override T get_Current() { }

		[Address(RVA = "0x195CA20", Offset = "0x195BE20", Length = "0x5A")]
		[Token(Token = "0x60002A9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19602D0", Offset = "0x195F6D0", Length = "0x8")]
		[Token(Token = "0x60002AA")]
		public override void Reset() { }

		[Address(RVA = "0x1961A70", Offset = "0x1960E70", Length = "0xA0")]
		[Token(Token = "0x60002AC")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000C3")]
	internal FixedBytes64Align8 data; //Field offset: 0x0

	[Token(Token = "0x17000050")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1C00040", Offset = "0x1BFF440", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000267")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000055")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1BFFE80", Offset = "0x1BFF280", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x600026D")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x17000056")]
	public override int Capacity
	{
		[Address(RVA = "0x1BFFF00", Offset = "0x1BFF300", Length = "0x7A")]
		[IsReadOnly]
		[Token(Token = "0x600026E")]
		 get { } //Length: 122
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600026F")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x17000052")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0x1BFFF80", Offset = "0x1BFF380", Length = "0x36")]
		[Token(Token = "0x600026A")]
		private get { } //Length: 54
	}

	[Token(Token = "0x17000053")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
		[IsReadOnly]
		[Token(Token = "0x600026B")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000057")]
	public override T Item
	{
		[Address(RVA = "0x1BFFFC0", Offset = "0x1BFF3C0", Length = "0x7D")]
		[IsReadOnly]
		[Token(Token = "0x6000270")]
		 get { } //Length: 125
		[Address(RVA = "0x1C00B20", Offset = "0x1BFFF20", Length = "0x7D")]
		[Token(Token = "0x6000271")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700004F")]
	internal ushort length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000265")]
		internal get { } //Length: 4
		[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
		[Token(Token = "0x6000266")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x17000051")]
	public override int Length
	{
		[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000268")]
		 get { } //Length: 36
		[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
		[Token(Token = "0x6000269")]
		 set { } //Length: 47
	}

	[Token(Token = "0x17000054")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
		[Token(Token = "0x600026C")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x1BFFD00", Offset = "0x1BFF100", Length = "0x5A")]
	[Token(Token = "0x60002A0")]
	public FixedList64Bytes`1(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BFFE20", Offset = "0x1BFF220", Length = "0x5A")]
	[Token(Token = "0x6000292")]
	public FixedList64Bytes`1(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BFFD60", Offset = "0x1BFF160", Length = "0x5A")]
	[Token(Token = "0x6000299")]
	public FixedList64Bytes`1(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BFFDC0", Offset = "0x1BFF1C0", Length = "0x5A")]
	[Token(Token = "0x6000287")]
	public FixedList64Bytes`1(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BFD7D0", Offset = "0x1BFCBD0", Length = "0x48")]
	[Token(Token = "0x6000274")]
	public void Add(in T item) { }

	[Address(RVA = "0x1BFD410", Offset = "0x1BFC810", Length = "0xD6")]
	[Token(Token = "0x6000276")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1BFD630", Offset = "0x1BFCA30", Length = "0x58")]
	[Token(Token = "0x6000275")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1BFD4F0", Offset = "0x1BFC8F0", Length = "0x131")]
	[Token(Token = "0x6000277")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1BFD690", Offset = "0x1BFCA90", Length = "0x13E")]
	[Token(Token = "0x6000278")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1BC8170", Offset = "0x1BC7570", Length = "0x49")]
	[Token(Token = "0x6000279")]
	public override void Clear() { }

	[Address(RVA = "0x1BFDE80", Offset = "0x1BFD280", Length = "0x21E")]
	[Token(Token = "0x6000285")]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BFE0A0", Offset = "0x1BFD4A0", Length = "0x21B")]
	[Token(Token = "0x600028C")]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BFDA40", Offset = "0x1BFCE40", Length = "0x21E")]
	[Token(Token = "0x6000290")]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BFD820", Offset = "0x1BFCC20", Length = "0x21E")]
	[Token(Token = "0x600029E")]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BFDC60", Offset = "0x1BFD060", Length = "0x21E")]
	[Token(Token = "0x6000297")]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BFE2C0", Offset = "0x1BFD6C0", Length = "0x69")]
	[Token(Token = "0x6000272")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1BFEBA0", Offset = "0x1BFDFA0", Length = "0x8F")]
	[Token(Token = "0x600029F")]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BFE330", Offset = "0x1BFD730", Length = "0xA6")]
	[Token(Token = "0x6000291")]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BFE9F0", Offset = "0x1BFDDF0", Length = "0x73")]
	[Token(Token = "0x600028D")]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BFE3E0", Offset = "0x1BFD7E0", Length = "0x609")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60002A3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BFEAE0", Offset = "0x1BFDEE0", Length = "0xB6")]
	[Token(Token = "0x6000298")]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BFEA70", Offset = "0x1BFDE70", Length = "0x61")]
	[Token(Token = "0x6000286")]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1C00040", Offset = "0x1BFF440", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000267")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1BFFE80", Offset = "0x1BFF280", Length = "0x77")]
	[IsReadOnly]
	[Token(Token = "0x600026D")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1BFFF00", Offset = "0x1BFF300", Length = "0x7A")]
	[IsReadOnly]
	[Token(Token = "0x600026E")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1BFFF80", Offset = "0x1BFF380", Length = "0x36")]
	[Token(Token = "0x600026A")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
	[IsReadOnly]
	[Token(Token = "0x600026B")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1BFFFC0", Offset = "0x1BFF3C0", Length = "0x7D")]
	[IsReadOnly]
	[Token(Token = "0x6000270")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000265")]
	internal ushort get_length() { }

	[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x6000268")]
	public override int get_Length() { }

	[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
	[Token(Token = "0x600026C")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1BFEC30", Offset = "0x1BFE030", Length = "0x64")]
	[Token(Token = "0x60002A4")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1BFECA0", Offset = "0x1BFE0A0", Length = "0xC6")]
	[Token(Token = "0x6000273")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BFF070", Offset = "0x1BFE470", Length = "0x173")]
	[Token(Token = "0x60002A1")]
	internal int Initialize(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BFED70", Offset = "0x1BFE170", Length = "0x173")]
	[Token(Token = "0x6000293")]
	internal int Initialize(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BFEEF0", Offset = "0x1BFE2F0", Length = "0x173")]
	[Token(Token = "0x6000288")]
	internal int Initialize(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BFF1F0", Offset = "0x1BFE5F0", Length = "0x173")]
	[Token(Token = "0x600029A")]
	internal int Initialize(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BFF530", Offset = "0x1BFE930", Length = "0x99")]
	[Token(Token = "0x600027C")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1BFF4D0", Offset = "0x1BFE8D0", Length = "0x57")]
	[Token(Token = "0x600027B")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1BFF370", Offset = "0x1BFE770", Length = "0x15C")]
	[Token(Token = "0x600027A")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1C00320", Offset = "0x1BFF720", Length = "0x14D")]
	[Token(Token = "0x6000295")]
	public static bool op_Equality(in FixedList64Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1C00080", Offset = "0x1BFF480", Length = "0x14D")]
	[Token(Token = "0x600028E")]
	public static bool op_Equality(in FixedList64Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1C00470", Offset = "0x1BFF870", Length = "0x14D")]
	[Token(Token = "0x600029C")]
	public static bool op_Equality(in FixedList64Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1C005C0", Offset = "0x1BFF9C0", Length = "0x14D")]
	[Token(Token = "0x6000283")]
	public static bool op_Equality(in FixedList64Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1C001D0", Offset = "0x1BFF5D0", Length = "0x14A")]
	[Token(Token = "0x600028A")]
	public static bool op_Equality(in FixedList64Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1C008F0", Offset = "0x1BFFCF0", Length = "0x93")]
	[Token(Token = "0x600029B")]
	public static FixedList64Bytes<T> op_Implicit(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1C00710", Offset = "0x1BFFB10", Length = "0x93")]
	[Token(Token = "0x6000294")]
	public static FixedList64Bytes<T> op_Implicit(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1C00850", Offset = "0x1BFFC50", Length = "0x93")]
	[Token(Token = "0x6000289")]
	public static FixedList64Bytes<T> op_Implicit(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1C007B0", Offset = "0x1BFFBB0", Length = "0x93")]
	[Token(Token = "0x60002A2")]
	public static FixedList64Bytes<T> op_Implicit(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1C009E0", Offset = "0x1BFFDE0", Length = "0x4B")]
	[Token(Token = "0x6000296")]
	public static bool op_Inequality(in FixedList64Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1C00990", Offset = "0x1BFFD90", Length = "0x4B")]
	[Token(Token = "0x600028B")]
	public static bool op_Inequality(in FixedList64Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1C00A30", Offset = "0x1BFFE30", Length = "0x4B")]
	[Token(Token = "0x600029D")]
	public static bool op_Inequality(in FixedList64Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1C00AD0", Offset = "0x1BFFED0", Length = "0x4B")]
	[Token(Token = "0x6000284")]
	public static bool op_Inequality(in FixedList64Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1C00A80", Offset = "0x1BFFE80", Length = "0x4B")]
	[Token(Token = "0x600028F")]
	public static bool op_Inequality(in FixedList64Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BFF620", Offset = "0x1BFEA20", Length = "0x4C")]
	[Token(Token = "0x600027F")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BFF5D0", Offset = "0x1BFE9D0", Length = "0x4C")]
	[Token(Token = "0x600027D")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1BFF820", Offset = "0x1BFEC20", Length = "0x1A9")]
	[Token(Token = "0x6000280")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1BFF670", Offset = "0x1BFEA70", Length = "0x1AB")]
	[Token(Token = "0x600027E")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600026F")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1C00B20", Offset = "0x1BFFF20", Length = "0x7D")]
	[Token(Token = "0x6000271")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000266")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
	[Token(Token = "0x6000269")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60002A6")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60002A5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1BFF9D0", Offset = "0x1BFEDD0", Length = "0x177")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x6000281")]
	public T[] ToArray() { }

	[Address(RVA = "0x1BFFB50", Offset = "0x1BFEF50", Length = "0x1A1")]
	[Token(Token = "0x6000282")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

