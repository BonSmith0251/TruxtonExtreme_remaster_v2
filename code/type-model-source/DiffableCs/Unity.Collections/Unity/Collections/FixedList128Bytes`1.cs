namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList128BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000056")]
public struct FixedList128Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[Token(Token = "0x2000057")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C8")]
		private FixedList128Bytes<T> m_List; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C9")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000064")]
		public override T Current
		{
			[Address(RVA = "0x1963A40", Offset = "0x1962E40", Length = "0x47")]
			[Token(Token = "0x60002F9")]
			 get { } //Length: 71
		}

		[Token(Token = "0x17000065")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19617E0", Offset = "0x1960BE0", Length = "0xA3")]
			[Token(Token = "0x60002FA")]
			private get { } //Length: 163
		}

		[Address(RVA = "0x1962A50", Offset = "0x1961E50", Length = "0x63")]
		[Token(Token = "0x60002F5")]
		public Enumerator(ref FixedList128Bytes<T>& list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002F6")]
		public override void Dispose() { }

		[Address(RVA = "0x1963A40", Offset = "0x1962E40", Length = "0x47")]
		[Token(Token = "0x60002F9")]
		public override T get_Current() { }

		[Address(RVA = "0x195E850", Offset = "0x195DC50", Length = "0x60")]
		[Token(Token = "0x60002F7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19602C0", Offset = "0x195F6C0", Length = "0xB")]
		[Token(Token = "0x60002F8")]
		public override void Reset() { }

		[Address(RVA = "0x19617E0", Offset = "0x1960BE0", Length = "0xA3")]
		[Token(Token = "0x60002FA")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000C7")]
	internal FixedBytes128Align8 data; //Field offset: 0x0

	[Token(Token = "0x1700005C")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1BD3850", Offset = "0x1BD2C50", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x60002B5")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000061")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1BD2EA0", Offset = "0x1BD22A0", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x60002BB")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x17000062")]
	public override int Capacity
	{
		[Address(RVA = "0x1BD3010", Offset = "0x1BD2410", Length = "0x7A")]
		[IsReadOnly]
		[Token(Token = "0x60002BC")]
		 get { } //Length: 122
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60002BD")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x1700005E")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0x1BD3130", Offset = "0x1BD2530", Length = "0x36")]
		[Token(Token = "0x60002B8")]
		private get { } //Length: 54
	}

	[Token(Token = "0x1700005F")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
		[IsReadOnly]
		[Token(Token = "0x60002B9")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000063")]
	public override T Item
	{
		[Address(RVA = "0x1BD33E0", Offset = "0x1BD27E0", Length = "0x7D")]
		[IsReadOnly]
		[Token(Token = "0x60002BE")]
		 get { } //Length: 125
		[Address(RVA = "0x1BD6950", Offset = "0x1BD5D50", Length = "0x7D")]
		[Token(Token = "0x60002BF")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700005B")]
	internal ushort length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60002B3")]
		internal get { } //Length: 4
		[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
		[Token(Token = "0x60002B4")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x1700005D")]
	public override int Length
	{
		[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x60002B6")]
		 get { } //Length: 36
		[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
		[Token(Token = "0x60002B7")]
		 set { } //Length: 47
	}

	[Token(Token = "0x17000060")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
		[Token(Token = "0x60002BA")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x1BD2730", Offset = "0x1BD1B30", Length = "0x6A")]
	[Token(Token = "0x60002DC")]
	public FixedList128Bytes`1(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BD29E0", Offset = "0x1BD1DE0", Length = "0x6A")]
	[Token(Token = "0x60002EE")]
	public FixedList128Bytes`1(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BD2C50", Offset = "0x1BD2050", Length = "0x6A")]
	[Token(Token = "0x60002E7")]
	public FixedList128Bytes`1(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD28C0", Offset = "0x1BD1CC0", Length = "0x6A")]
	[Token(Token = "0x60002D5")]
	public FixedList128Bytes`1(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BC8120", Offset = "0x1BC7520", Length = "0x48")]
	[Token(Token = "0x60002C2")]
	public void Add(in T item) { }

	[Address(RVA = "0x1BC71C0", Offset = "0x1BC65C0", Length = "0xD6")]
	[Token(Token = "0x60002C4")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1BC7860", Offset = "0x1BC6C60", Length = "0x58")]
	[Token(Token = "0x60002C3")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1BC75E0", Offset = "0x1BC69E0", Length = "0x131")]
	[Token(Token = "0x60002C5")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1BC7EB0", Offset = "0x1BC72B0", Length = "0x13E")]
	[Token(Token = "0x60002C6")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1BC8170", Offset = "0x1BC7570", Length = "0x49")]
	[Token(Token = "0x60002C7")]
	public override void Clear() { }

	[Address(RVA = "0x1BCAA10", Offset = "0x1BC9E10", Length = "0x21E")]
	[Token(Token = "0x60002D3")]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BCA4C0", Offset = "0x1BC98C0", Length = "0x21E")]
	[Token(Token = "0x60002DA")]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BC9F80", Offset = "0x1BC9380", Length = "0x21B")]
	[Token(Token = "0x60002E1")]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BC8D00", Offset = "0x1BC8100", Length = "0x21E")]
	[Token(Token = "0x60002EC")]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BC9B30", Offset = "0x1BC8F30", Length = "0x21E")]
	[Token(Token = "0x60002E5")]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BCB470", Offset = "0x1BCA870", Length = "0x69")]
	[Token(Token = "0x60002C0")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1BCD6D0", Offset = "0x1BCCAD0", Length = "0xA6")]
	[Token(Token = "0x60002E2")]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BCDA60", Offset = "0x1BCCE60", Length = "0x8F")]
	[Token(Token = "0x60002ED")]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BCD5A0", Offset = "0x1BCC9A0", Length = "0x73")]
	[Token(Token = "0x60002DB")]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BCC060", Offset = "0x1BCB460", Length = "0x609")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60002F1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BCD7F0", Offset = "0x1BCCBF0", Length = "0xB6")]
	[Token(Token = "0x60002E6")]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BCD780", Offset = "0x1BCCB80", Length = "0x61")]
	[Token(Token = "0x60002D4")]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BD3850", Offset = "0x1BD2C50", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x60002B5")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1BD2EA0", Offset = "0x1BD22A0", Length = "0x77")]
	[IsReadOnly]
	[Token(Token = "0x60002BB")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1BD3010", Offset = "0x1BD2410", Length = "0x7A")]
	[IsReadOnly]
	[Token(Token = "0x60002BC")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1BD3130", Offset = "0x1BD2530", Length = "0x36")]
	[Token(Token = "0x60002B8")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
	[IsReadOnly]
	[Token(Token = "0x60002B9")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1BD33E0", Offset = "0x1BD27E0", Length = "0x7D")]
	[IsReadOnly]
	[Token(Token = "0x60002BE")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60002B3")]
	internal ushort get_length() { }

	[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x60002B6")]
	public override int get_Length() { }

	[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
	[Token(Token = "0x60002BA")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1BCDAF0", Offset = "0x1BCCEF0", Length = "0x77")]
	[Token(Token = "0x60002F2")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1BCDCE0", Offset = "0x1BCD0E0", Length = "0xC6")]
	[Token(Token = "0x60002C1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BCE160", Offset = "0x1BCD560", Length = "0x173")]
	[Token(Token = "0x60002EF")]
	internal int Initialize(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BCEC80", Offset = "0x1BCE080", Length = "0x173")]
	[Token(Token = "0x60002DD")]
	internal int Initialize(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BCEB00", Offset = "0x1BCDF00", Length = "0x173")]
	[Token(Token = "0x60002D6")]
	internal int Initialize(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BCF530", Offset = "0x1BCE930", Length = "0x173")]
	[Token(Token = "0x60002E8")]
	internal int Initialize(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD0370", Offset = "0x1BCF770", Length = "0x99")]
	[Token(Token = "0x60002CA")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1BD0270", Offset = "0x1BCF670", Length = "0x57")]
	[Token(Token = "0x60002C9")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1BCFAC0", Offset = "0x1BCEEC0", Length = "0x15C")]
	[Token(Token = "0x60002C8")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1BD46E0", Offset = "0x1BD3AE0", Length = "0x153")]
	[Token(Token = "0x60002E3")]
	public static bool op_Equality(in FixedList128Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BD39F0", Offset = "0x1BD2DF0", Length = "0x153")]
	[Token(Token = "0x60002EA")]
	public static bool op_Equality(in FixedList128Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BD3890", Offset = "0x1BD2C90", Length = "0x153")]
	[Token(Token = "0x60002D1")]
	public static bool op_Equality(in FixedList128Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BD4840", Offset = "0x1BD3C40", Length = "0x150")]
	[Token(Token = "0x60002DF")]
	public static bool op_Equality(in FixedList128Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BD4BF0", Offset = "0x1BD3FF0", Length = "0x153")]
	[Token(Token = "0x60002D8")]
	public static bool op_Equality(in FixedList128Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BD5C70", Offset = "0x1BD5070", Length = "0x6E")]
	[Token(Token = "0x60002E9")]
	public static FixedList128Bytes<T> op_Implicit(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BD5E30", Offset = "0x1BD5230", Length = "0x6E")]
	[Token(Token = "0x60002F0")]
	public static FixedList128Bytes<T> op_Implicit(in FixedList4096Bytes<T>& other) { }

	[Address(RVA = "0x1BD59D0", Offset = "0x1BD4DD0", Length = "0x6E")]
	[Token(Token = "0x60002D7")]
	public static FixedList128Bytes<T> op_Implicit(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BD5F10", Offset = "0x1BD5310", Length = "0x6E")]
	[Token(Token = "0x60002DE")]
	public static FixedList128Bytes<T> op_Implicit(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BD6250", Offset = "0x1BD5650", Length = "0x4B")]
	[Token(Token = "0x60002E4")]
	public static bool op_Inequality(in FixedList128Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BD6720", Offset = "0x1BD5B20", Length = "0x4B")]
	[Token(Token = "0x60002D9")]
	public static bool op_Inequality(in FixedList128Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BD6330", Offset = "0x1BD5730", Length = "0x4B")]
	[Token(Token = "0x60002EB")]
	public static bool op_Inequality(in FixedList128Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BD6510", Offset = "0x1BD5910", Length = "0x4B")]
	[Token(Token = "0x60002D2")]
	public static bool op_Inequality(in FixedList128Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BD6200", Offset = "0x1BD5600", Length = "0x4B")]
	[Token(Token = "0x60002E0")]
	public static bool op_Inequality(in FixedList128Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BD08D0", Offset = "0x1BCFCD0", Length = "0x4C")]
	[Token(Token = "0x60002CD")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BD07F0", Offset = "0x1BCFBF0", Length = "0x4C")]
	[Token(Token = "0x60002CB")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1BD1610", Offset = "0x1BD0A10", Length = "0x1A9")]
	[Token(Token = "0x60002CE")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1BD09C0", Offset = "0x1BCFDC0", Length = "0x1AB")]
	[Token(Token = "0x60002CC")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002BD")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1BD6950", Offset = "0x1BD5D50", Length = "0x7D")]
	[Token(Token = "0x60002BF")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x60002B4")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
	[Token(Token = "0x60002B7")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60002F4")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60002F3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1BD1C00", Offset = "0x1BD1000", Length = "0x177")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x60002CF")]
	public T[] ToArray() { }

	[Address(RVA = "0x1BD1F10", Offset = "0x1BD1310", Length = "0x1A1")]
	[Token(Token = "0x60002D0")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

