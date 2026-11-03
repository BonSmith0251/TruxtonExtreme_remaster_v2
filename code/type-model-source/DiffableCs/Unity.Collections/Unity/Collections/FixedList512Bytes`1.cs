namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList512BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200005A")]
public struct FixedList512Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[Token(Token = "0x200005B")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CC")]
		private FixedList512Bytes<T> m_List; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CD")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000070")]
		public override T Current
		{
			[Address(RVA = "0x1963FF0", Offset = "0x19633F0", Length = "0x47")]
			[Token(Token = "0x6000347")]
			 get { } //Length: 71
		}

		[Token(Token = "0x17000071")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1961D70", Offset = "0x1961170", Length = "0xA3")]
			[Token(Token = "0x6000348")]
			private get { } //Length: 163
		}

		[Address(RVA = "0x1963110", Offset = "0x1962510", Length = "0xE6")]
		[Token(Token = "0x6000343")]
		public Enumerator(ref FixedList512Bytes<T>& list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000344")]
		public override void Dispose() { }

		[Address(RVA = "0x1963FF0", Offset = "0x19633F0", Length = "0x47")]
		[Token(Token = "0x6000347")]
		public override T get_Current() { }

		[Address(RVA = "0x195E960", Offset = "0x195DD60", Length = "0x60")]
		[Token(Token = "0x6000345")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195FF10", Offset = "0x195F310", Length = "0xB")]
		[Token(Token = "0x6000346")]
		public override void Reset() { }

		[Address(RVA = "0x1961D70", Offset = "0x1961170", Length = "0xA3")]
		[Token(Token = "0x6000348")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	internal FixedBytes512Align8 data; //Field offset: 0x0

	[Token(Token = "0x17000068")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1BF9DB0", Offset = "0x1BF91B0", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000303")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x1700006D")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1BF9890", Offset = "0x1BF8C90", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x6000309")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x1700006E")]
	public override int Capacity
	{
		[Address(RVA = "0x1BF9A10", Offset = "0x1BF8E10", Length = "0x7A")]
		[IsReadOnly]
		[Token(Token = "0x600030A")]
		 get { } //Length: 122
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600030B")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x1700006A")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0x1BF9AC0", Offset = "0x1BF8EC0", Length = "0x36")]
		[Token(Token = "0x6000306")]
		private get { } //Length: 54
	}

	[Token(Token = "0x1700006B")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
		[IsReadOnly]
		[Token(Token = "0x6000307")]
		 get { } //Length: 72
	}

	[Token(Token = "0x1700006F")]
	public override T Item
	{
		[Address(RVA = "0x1BF9C70", Offset = "0x1BF9070", Length = "0x7D")]
		[IsReadOnly]
		[Token(Token = "0x600030C")]
		 get { } //Length: 125
		[Address(RVA = "0x1BFD290", Offset = "0x1BFC690", Length = "0x7D")]
		[Token(Token = "0x600030D")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000067")]
	internal ushort length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000301")]
		internal get { } //Length: 4
		[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
		[Token(Token = "0x6000302")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x17000069")]
	public override int Length
	{
		[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000304")]
		 get { } //Length: 36
		[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
		[Token(Token = "0x6000305")]
		 set { } //Length: 47
	}

	[Token(Token = "0x1700006C")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
		[Token(Token = "0x6000308")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x1BF91B0", Offset = "0x1BF85B0", Length = "0x62")]
	[Token(Token = "0x600032A")]
	public FixedList512Bytes`1(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BF9140", Offset = "0x1BF8540", Length = "0x62")]
	[Token(Token = "0x600033C")]
	public FixedList512Bytes`1(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BF9220", Offset = "0x1BF8620", Length = "0x62")]
	[Token(Token = "0x6000323")]
	public FixedList512Bytes`1(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BF9590", Offset = "0x1BF8990", Length = "0x62")]
	[Token(Token = "0x6000331")]
	public FixedList512Bytes`1(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BF1A50", Offset = "0x1BF0E50", Length = "0x48")]
	[Token(Token = "0x6000310")]
	public void Add(in T item) { }

	[Address(RVA = "0x1BF0F50", Offset = "0x1BF0350", Length = "0xD6")]
	[Token(Token = "0x6000312")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1BF1590", Offset = "0x1BF0990", Length = "0x58")]
	[Token(Token = "0x6000311")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1BF1390", Offset = "0x1BF0790", Length = "0x131")]
	[Token(Token = "0x6000313")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1BF1730", Offset = "0x1BF0B30", Length = "0x13E")]
	[Token(Token = "0x6000314")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1BC8170", Offset = "0x1BC7570", Length = "0x49")]
	[Token(Token = "0x6000315")]
	public override void Clear() { }

	[Address(RVA = "0x1BF36F0", Offset = "0x1BF2AF0", Length = "0x21E")]
	[Token(Token = "0x6000321")]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BF32A0", Offset = "0x1BF26A0", Length = "0x21E")]
	[Token(Token = "0x6000328")]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BF1EF0", Offset = "0x1BF12F0", Length = "0x21E")]
	[Token(Token = "0x600032F")]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BF2C10", Offset = "0x1BF2010", Length = "0x21E")]
	[Token(Token = "0x600033A")]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BF1CD0", Offset = "0x1BF10D0", Length = "0x21B")]
	[Token(Token = "0x6000336")]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BF3C20", Offset = "0x1BF3020", Length = "0x69")]
	[Token(Token = "0x600030E")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1BF5EE0", Offset = "0x1BF52E0", Length = "0xB6")]
	[Token(Token = "0x6000337")]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BF4A10", Offset = "0x1BF3E10", Length = "0xA6")]
	[Token(Token = "0x6000330")]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BF48F0", Offset = "0x1BF3CF0", Length = "0x8F")]
	[Token(Token = "0x600033B")]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BF4700", Offset = "0x1BF3B00", Length = "0x73")]
	[Token(Token = "0x6000329")]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BF58D0", Offset = "0x1BF4CD0", Length = "0x60D")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x600033F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BF3C90", Offset = "0x1BF3090", Length = "0x61")]
	[Token(Token = "0x6000322")]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BF9DB0", Offset = "0x1BF91B0", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000303")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1BF9890", Offset = "0x1BF8C90", Length = "0x77")]
	[IsReadOnly]
	[Token(Token = "0x6000309")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1BF9A10", Offset = "0x1BF8E10", Length = "0x7A")]
	[IsReadOnly]
	[Token(Token = "0x600030A")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1BF9AC0", Offset = "0x1BF8EC0", Length = "0x36")]
	[Token(Token = "0x6000306")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
	[IsReadOnly]
	[Token(Token = "0x6000307")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1BF9C70", Offset = "0x1BF9070", Length = "0x7D")]
	[IsReadOnly]
	[Token(Token = "0x600030C")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000301")]
	internal ushort get_length() { }

	[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x6000304")]
	public override int get_Length() { }

	[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
	[Token(Token = "0x6000308")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1BF5FA0", Offset = "0x1BF53A0", Length = "0x66")]
	[Token(Token = "0x6000340")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1BF6010", Offset = "0x1BF5410", Length = "0xC6")]
	[Token(Token = "0x600030F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BF6E60", Offset = "0x1BF6260", Length = "0x173")]
	[Token(Token = "0x600033D")]
	internal int Initialize(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BF69D0", Offset = "0x1BF5DD0", Length = "0x173")]
	[Token(Token = "0x600032B")]
	internal int Initialize(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BF7300", Offset = "0x1BF6700", Length = "0x173")]
	[Token(Token = "0x6000324")]
	internal int Initialize(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BF6CE0", Offset = "0x1BF60E0", Length = "0x173")]
	[Token(Token = "0x6000332")]
	internal int Initialize(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BF7B40", Offset = "0x1BF6F40", Length = "0x99")]
	[Token(Token = "0x6000318")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1BF78E0", Offset = "0x1BF6CE0", Length = "0x57")]
	[Token(Token = "0x6000317")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1BF7480", Offset = "0x1BF6880", Length = "0x15C")]
	[Token(Token = "0x6000316")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1BF9DF0", Offset = "0x1BF91F0", Length = "0x1BA")]
	[Token(Token = "0x600032D")]
	public static bool op_Equality(in FixedList512Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BFB310", Offset = "0x1BFA710", Length = "0x1BA")]
	[Token(Token = "0x6000334")]
	public static bool op_Equality(in FixedList512Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BFC250", Offset = "0x1BFB650", Length = "0x1BA")]
	[Token(Token = "0x6000338")]
	public static bool op_Equality(in FixedList512Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BFB730", Offset = "0x1BFAB30", Length = "0x1BA")]
	[Token(Token = "0x600031F")]
	public static bool op_Equality(in FixedList512Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BFAEF0", Offset = "0x1BFA2F0", Length = "0x1BA")]
	[Token(Token = "0x6000326")]
	public static bool op_Equality(in FixedList512Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BFC7A0", Offset = "0x1BFBBA0", Length = "0x99")]
	[Token(Token = "0x6000333")]
	public static FixedList512Bytes<T> op_Implicit(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BFC410", Offset = "0x1BFB810", Length = "0x99")]
	[Token(Token = "0x600033E")]
	public static FixedList512Bytes<T> op_Implicit(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BFC700", Offset = "0x1BFBB00", Length = "0x99")]
	[Token(Token = "0x6000325")]
	public static FixedList512Bytes<T> op_Implicit(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BFC980", Offset = "0x1BFBD80", Length = "0x99")]
	[Token(Token = "0x600032C")]
	public static FixedList512Bytes<T> op_Implicit(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BFD1A0", Offset = "0x1BFC5A0", Length = "0x4B")]
	[Token(Token = "0x6000327")]
	public static bool op_Inequality(in FixedList512Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BFD060", Offset = "0x1BFC460", Length = "0x4B")]
	[Token(Token = "0x6000335")]
	public static bool op_Inequality(in FixedList512Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BFCDE0", Offset = "0x1BFC1E0", Length = "0x4B")]
	[Token(Token = "0x6000339")]
	public static bool op_Inequality(in FixedList512Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BFD100", Offset = "0x1BFC500", Length = "0x4B")]
	[Token(Token = "0x6000320")]
	public static bool op_Inequality(in FixedList512Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BFCFC0", Offset = "0x1BFC3C0", Length = "0x4B")]
	[Token(Token = "0x600032E")]
	public static bool op_Inequality(in FixedList512Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BF7CD0", Offset = "0x1BF70D0", Length = "0x4C")]
	[Token(Token = "0x600031B")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BF7BE0", Offset = "0x1BF6FE0", Length = "0x4C")]
	[Token(Token = "0x6000319")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1BF8690", Offset = "0x1BF7A90", Length = "0x1A9")]
	[Token(Token = "0x600031C")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1BF7F90", Offset = "0x1BF7390", Length = "0x1AB")]
	[Token(Token = "0x600031A")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600030B")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1BFD290", Offset = "0x1BFC690", Length = "0x7D")]
	[Token(Token = "0x600030D")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000302")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
	[Token(Token = "0x6000305")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000342")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000341")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1BF8980", Offset = "0x1BF7D80", Length = "0x177")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x600031D")]
	public T[] ToArray() { }

	[Address(RVA = "0x1BF8F20", Offset = "0x1BF8320", Length = "0x1A1")]
	[Token(Token = "0x600031E")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

