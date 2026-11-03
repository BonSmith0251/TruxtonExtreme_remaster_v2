namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200005E")]
public struct FixedList4096Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	[Token(Token = "0x200005F")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D0")]
		private FixedList4096Bytes<T> m_List; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D1")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x1700007C")]
		public override T Current
		{
			[Address(RVA = "0x1963920", Offset = "0x1962D20", Length = "0x47")]
			[Token(Token = "0x6000395")]
			 get { } //Length: 71
		}

		[Token(Token = "0x1700007D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1961ED0", Offset = "0x19612D0", Length = "0xA3")]
			[Token(Token = "0x6000396")]
			private get { } //Length: 163
		}

		[Address(RVA = "0x19634B0", Offset = "0x19628B0", Length = "0x48")]
		[Token(Token = "0x6000391")]
		public Enumerator(ref FixedList4096Bytes<T>& list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000392")]
		public override void Dispose() { }

		[Address(RVA = "0x1963920", Offset = "0x1962D20", Length = "0x47")]
		[Token(Token = "0x6000395")]
		public override T get_Current() { }

		[Address(RVA = "0x195F490", Offset = "0x195E890", Length = "0x60")]
		[Token(Token = "0x6000393")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195F900", Offset = "0x195ED00", Length = "0xB")]
		[Token(Token = "0x6000394")]
		public override void Reset() { }

		[Address(RVA = "0x1961ED0", Offset = "0x19612D0", Length = "0xA3")]
		[Token(Token = "0x6000396")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	internal FixedBytes4096Align8 data; //Field offset: 0x0

	[Token(Token = "0x17000074")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1BED5A0", Offset = "0x1BEC9A0", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000351")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000079")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1BED180", Offset = "0x1BEC580", Length = "0x77")]
		[IsReadOnly]
		[Token(Token = "0x6000357")]
		internal get { } //Length: 119
	}

	[Token(Token = "0x1700007A")]
	public override int Capacity
	{
		[Address(RVA = "0x1BED280", Offset = "0x1BEC680", Length = "0x7A")]
		[IsReadOnly]
		[Token(Token = "0x6000358")]
		 get { } //Length: 122
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000359")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x17000076")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0x1BED330", Offset = "0x1BEC730", Length = "0x36")]
		[Token(Token = "0x6000354")]
		private get { } //Length: 54
	}

	[Token(Token = "0x17000077")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
		[IsReadOnly]
		[Token(Token = "0x6000355")]
		 get { } //Length: 72
	}

	[Token(Token = "0x1700007B")]
	public override T Item
	{
		[Address(RVA = "0x1BED4E0", Offset = "0x1BEC8E0", Length = "0x7D")]
		[IsReadOnly]
		[Token(Token = "0x600035A")]
		 get { } //Length: 125
		[Address(RVA = "0x1BF0D70", Offset = "0x1BF0170", Length = "0x7D")]
		[Token(Token = "0x600035B")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000073")]
	internal ushort length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x600034F")]
		internal get { } //Length: 4
		[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
		[Token(Token = "0x6000350")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x17000075")]
	public override int Length
	{
		[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000352")]
		 get { } //Length: 36
		[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
		[Token(Token = "0x6000353")]
		 set { } //Length: 47
	}

	[Token(Token = "0x17000078")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
		[Token(Token = "0x6000356")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x1BEC940", Offset = "0x1BEBD40", Length = "0x62")]
	[Token(Token = "0x6000378")]
	public FixedList4096Bytes`1(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BECD60", Offset = "0x1BEC160", Length = "0x62")]
	[Token(Token = "0x6000386")]
	public FixedList4096Bytes`1(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BECC80", Offset = "0x1BEC080", Length = "0x62")]
	[Token(Token = "0x6000371")]
	public FixedList4096Bytes`1(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BECF10", Offset = "0x1BEC310", Length = "0x62")]
	[Token(Token = "0x600037F")]
	public FixedList4096Bytes`1(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BE45A0", Offset = "0x1BE39A0", Length = "0x48")]
	[Token(Token = "0x600035E")]
	public void Add(in T item) { }

	[Address(RVA = "0x1BE3B80", Offset = "0x1BE2F80", Length = "0xD6")]
	[Token(Token = "0x6000360")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1BE4080", Offset = "0x1BE3480", Length = "0x58")]
	[Token(Token = "0x600035F")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1BE3DA0", Offset = "0x1BE31A0", Length = "0x131")]
	[Token(Token = "0x6000361")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1BE43C0", Offset = "0x1BE37C0", Length = "0x13E")]
	[Token(Token = "0x6000362")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1BC8170", Offset = "0x1BC7570", Length = "0x49")]
	[Token(Token = "0x6000363")]
	public override void Clear() { }

	[Address(RVA = "0x1BE4820", Offset = "0x1BE3C20", Length = "0x21E")]
	[Token(Token = "0x600036F")]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BE68A0", Offset = "0x1BE5CA0", Length = "0x21E")]
	[Token(Token = "0x6000376")]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BE5BA0", Offset = "0x1BE4FA0", Length = "0x21E")]
	[Token(Token = "0x600037D")]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BE6440", Offset = "0x1BE5840", Length = "0x21B")]
	[Token(Token = "0x600038B")]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BE6220", Offset = "0x1BE5620", Length = "0x21E")]
	[Token(Token = "0x6000384")]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BE6CF0", Offset = "0x1BE60F0", Length = "0x69")]
	[Token(Token = "0x600035C")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1BE6E40", Offset = "0x1BE6240", Length = "0xB6")]
	[Token(Token = "0x6000385")]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[Address(RVA = "0x1BE8550", Offset = "0x1BE7950", Length = "0xA6")]
	[Token(Token = "0x600037E")]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[Address(RVA = "0x1BE8450", Offset = "0x1BE7850", Length = "0x8F")]
	[Token(Token = "0x600038C")]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x1BE8E20", Offset = "0x1BE8220", Length = "0x73")]
	[Token(Token = "0x6000377")]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[Address(RVA = "0x1BE8600", Offset = "0x1BE7A00", Length = "0x60D")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x600038D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BE84E0", Offset = "0x1BE78E0", Length = "0x61")]
	[Token(Token = "0x6000370")]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[Address(RVA = "0x1BED5A0", Offset = "0x1BEC9A0", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000351")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1BED180", Offset = "0x1BEC580", Length = "0x77")]
	[IsReadOnly]
	[Token(Token = "0x6000357")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1BED280", Offset = "0x1BEC680", Length = "0x7A")]
	[IsReadOnly]
	[Token(Token = "0x6000358")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1BED330", Offset = "0x1BEC730", Length = "0x36")]
	[Token(Token = "0x6000354")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1BD31B0", Offset = "0x1BD25B0", Length = "0x48")]
	[IsReadOnly]
	[Token(Token = "0x6000355")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1BED4E0", Offset = "0x1BEC8E0", Length = "0x7D")]
	[IsReadOnly]
	[Token(Token = "0x600035A")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x600034F")]
	internal ushort get_length() { }

	[Address(RVA = "0x1BD36F0", Offset = "0x1BD2AF0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x6000352")]
	public override int get_Length() { }

	[Address(RVA = "0x1BD3550", Offset = "0x1BD2950", Length = "0x64")]
	[Token(Token = "0x6000356")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1BE92F0", Offset = "0x1BE86F0", Length = "0x8E")]
	[Token(Token = "0x600038E")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1BE9380", Offset = "0x1BE8780", Length = "0xC6")]
	[Token(Token = "0x600035D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BE9FA0", Offset = "0x1BE93A0", Length = "0x173")]
	[Token(Token = "0x6000387")]
	internal int Initialize(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BEA530", Offset = "0x1BE9930", Length = "0x173")]
	[Token(Token = "0x6000380")]
	internal int Initialize(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BE9BA0", Offset = "0x1BE8FA0", Length = "0x173")]
	[Token(Token = "0x6000372")]
	internal int Initialize(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BE9A20", Offset = "0x1BE8E20", Length = "0x173")]
	[Token(Token = "0x6000379")]
	internal int Initialize(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BEB3B0", Offset = "0x1BEA7B0", Length = "0x99")]
	[Token(Token = "0x6000366")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1BEB1B0", Offset = "0x1BEA5B0", Length = "0x57")]
	[Token(Token = "0x6000365")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1BEAFF0", Offset = "0x1BEA3F0", Length = "0x15C")]
	[Token(Token = "0x6000364")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1BEEAE0", Offset = "0x1BEDEE0", Length = "0x17D")]
	[Token(Token = "0x6000374")]
	public static bool op_Equality(in FixedList4096Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BEE7E0", Offset = "0x1BEDBE0", Length = "0x17D")]
	[Token(Token = "0x600037B")]
	public static bool op_Equality(in FixedList4096Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BEE660", Offset = "0x1BEDA60", Length = "0x17A")]
	[Token(Token = "0x6000389")]
	public static bool op_Equality(in FixedList4096Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BEDC90", Offset = "0x1BED090", Length = "0x17D")]
	[Token(Token = "0x600036D")]
	public static bool op_Equality(in FixedList4096Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BED660", Offset = "0x1BECA60", Length = "0x17D")]
	[Token(Token = "0x6000382")]
	public static bool op_Equality(in FixedList4096Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BF0060", Offset = "0x1BEF460", Length = "0xC3")]
	[Token(Token = "0x6000381")]
	public static FixedList4096Bytes<T> op_Implicit(in FixedList128Bytes<T>& other) { }

	[Address(RVA = "0x1BEFB20", Offset = "0x1BEEF20", Length = "0xC3")]
	[Token(Token = "0x600037A")]
	public static FixedList4096Bytes<T> op_Implicit(in FixedList64Bytes<T>& other) { }

	[Address(RVA = "0x1BEFF90", Offset = "0x1BEF390", Length = "0xC3")]
	[Token(Token = "0x6000373")]
	public static FixedList4096Bytes<T> op_Implicit(in FixedList32Bytes<T>& other) { }

	[Address(RVA = "0x1BEFA50", Offset = "0x1BEEE50", Length = "0xC3")]
	[Token(Token = "0x6000388")]
	public static FixedList4096Bytes<T> op_Implicit(in FixedList512Bytes<T>& other) { }

	[Address(RVA = "0x1BF0930", Offset = "0x1BEFD30", Length = "0x4B")]
	[Token(Token = "0x600038A")]
	public static bool op_Inequality(in FixedList4096Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[Address(RVA = "0x1BF0610", Offset = "0x1BEFA10", Length = "0x4B")]
	[Token(Token = "0x600036E")]
	public static bool op_Inequality(in FixedList4096Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[Address(RVA = "0x1BF07F0", Offset = "0x1BEFBF0", Length = "0x4B")]
	[Token(Token = "0x6000383")]
	public static bool op_Inequality(in FixedList4096Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[Address(RVA = "0x1BF08E0", Offset = "0x1BEFCE0", Length = "0x4B")]
	[Token(Token = "0x600037C")]
	public static bool op_Inequality(in FixedList4096Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[Address(RVA = "0x1BF0750", Offset = "0x1BEFB50", Length = "0x4B")]
	[Token(Token = "0x6000375")]
	public static bool op_Inequality(in FixedList4096Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[Address(RVA = "0x1BEB540", Offset = "0x1BEA940", Length = "0x4C")]
	[Token(Token = "0x6000369")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1BEB450", Offset = "0x1BEA850", Length = "0x4C")]
	[Token(Token = "0x6000367")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1BEBD40", Offset = "0x1BEB140", Length = "0x1A9")]
	[Token(Token = "0x600036A")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1BEB9D0", Offset = "0x1BEADD0", Length = "0x1AB")]
	[Token(Token = "0x6000368")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000359")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1BF0D70", Offset = "0x1BF0170", Length = "0x7D")]
	[Token(Token = "0x600035B")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000350")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1BD6A50", Offset = "0x1BD5E50", Length = "0x2F")]
	[Token(Token = "0x6000353")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000390")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x600038F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1BEC0B0", Offset = "0x1BEB4B0", Length = "0x177")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x600036B")]
	public T[] ToArray() { }

	[Address(RVA = "0x1BEC4B0", Offset = "0x1BEB8B0", Length = "0x1A1")]
	[Token(Token = "0x600036C")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

