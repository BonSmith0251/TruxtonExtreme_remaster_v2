namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000071")]
public struct FixedString128Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x2000072")]
	internal struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000257")]
		private FixedString128Bytes target; //Field offset: 0x0
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000258")]
		private int offset; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000259")]
		private Rune current; //Field offset: 0x84

		[Token(Token = "0x17000095")]
		public Rune Current
		{
			[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
			[Token(Token = "0x6000480")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000096")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28AFE00", Offset = "0x28AF200", Length = "0x46")]
			[Token(Token = "0x6000481")]
			private get { } //Length: 70
		}

		[Address(RVA = "0x28AFFB0", Offset = "0x28AF3B0", Length = "0x4A")]
		[Token(Token = "0x600047C")]
		public Enumerator(FixedString128Bytes other) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600047D")]
		public void Dispose() { }

		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x6000480")]
		public Rune get_Current() { }

		[Address(RVA = "0x28AFC70", Offset = "0x28AF070", Length = "0x41")]
		[Token(Token = "0x600047E")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28AFCC0", Offset = "0x28AF0C0", Length = "0xC")]
		[Token(Token = "0x600047F")]
		public override void Reset() { }

		[Address(RVA = "0x28AFE00", Offset = "0x28AF200", Length = "0x46")]
		[Token(Token = "0x6000481")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x4000254")]
	internal const ushort utf8MaxLengthInBytes = 125; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000255")]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[SerializeField]
	[Token(Token = "0x4000256")]
	internal FixedBytes126 bytes; //Field offset: 0x2

	[Token(Token = "0x17000092")]
	public override int Capacity
	{
		[Address(RVA = "0x28B1530", Offset = "0x28B0930", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x600043F")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000440")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000093")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000442")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000094")]
	public override byte Item
	{
		[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
		[IsReadOnly]
		[Token(Token = "0x6000443")]
		 get { } //Length: 9
		[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
		[Token(Token = "0x6000444")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000091")]
	public override int Length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x600043D")]
		 get { } //Length: 4
		[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
		[Token(Token = "0x600043E")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700008F")]
	public static int UTF8MaxLengthInBytes
	{
		[Address(RVA = "0x28B1530", Offset = "0x28B0930", Length = "0x6")]
		[Token(Token = "0x600043A")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x17000090")]
	public string Value
	{
		[Address(RVA = "0x28B1050", Offset = "0x28B0450", Length = "0x39")]
		[Token(Token = "0x600043B")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x28B14B0", Offset = "0x28B08B0", Length = "0x7E")]
	[Token(Token = "0x600045A")]
	public FixedString128Bytes(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B1350", Offset = "0x28B0750", Length = "0x7E")]
	[Token(Token = "0x600046D")]
	public FixedString128Bytes(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B1110", Offset = "0x28B0510", Length = "0x7E")]
	[Token(Token = "0x6000466")]
	public FixedString128Bytes(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B1190", Offset = "0x28B0590", Length = "0x7E")]
	[Token(Token = "0x6000460")]
	public FixedString128Bytes(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B12A0", Offset = "0x28B06A0", Length = "0x7E")]
	[Token(Token = "0x6000454")]
	public FixedString128Bytes(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B1210", Offset = "0x28B0610", Length = "0x84")]
	[Token(Token = "0x6000452")]
	public FixedString128Bytes(in UnsafeText other) { }

	[Address(RVA = "0x28B1440", Offset = "0x28B0840", Length = "0x6B")]
	[Token(Token = "0x6000451")]
	public FixedString128Bytes(ReadOnly other) { }

	[Address(RVA = "0x28B1320", Offset = "0x28B0720", Length = "0x2A")]
	[Token(Token = "0x600044E")]
	public FixedString128Bytes(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B13D0", Offset = "0x28B07D0", Length = "0x6A")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600044C")]
	public FixedString128Bytes(string source) { }

	[Address(RVA = "0x28B0020", Offset = "0x28AF420", Length = "0x1F")]
	[Token(Token = "0x6000447")]
	public void Add(in byte value) { }

	[Address(RVA = "0x28B0040", Offset = "0x28AF440", Length = "0x2E")]
	[Token(Token = "0x600044B")]
	public FixedList128Bytes<Byte>& AsFixedList() { }

	[Address(RVA = "0x28B0070", Offset = "0x28AF470", Length = "0xB4")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000479")]
	private void CheckCapacityInRange(int capacity) { }

	[Address(RVA = "0x28B0130", Offset = "0x28AF530", Length = "0x97")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600047A")]
	private static void CheckCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28B01D0", Offset = "0x28AF5D0", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600047B")]
	private static void CheckFormatError(FormatError error) { }

	[Address(RVA = "0x28B0230", Offset = "0x28AF630", Length = "0x129")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	[Token(Token = "0x6000477")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28B0360", Offset = "0x28AF760", Length = "0x126")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000478")]
	private void CheckLengthInRange(int length) { }

	[Address(RVA = "0x28B0490", Offset = "0x28AF890", Length = "0x9")]
	[Token(Token = "0x6000446")]
	public override void Clear() { }

	[Address(RVA = "0x28B0640", Offset = "0x28AFA40", Length = "0x49")]
	[Token(Token = "0x6000453")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28B0590", Offset = "0x28AF990", Length = "0x5D")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000449")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28B05F0", Offset = "0x28AF9F0", Length = "0x49")]
	[Token(Token = "0x6000459")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28B0540", Offset = "0x28AF940", Length = "0x49")]
	[Token(Token = "0x6000465")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28B04F0", Offset = "0x28AF8F0", Length = "0x49")]
	[Token(Token = "0x600045F")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28B04A0", Offset = "0x28AF8A0", Length = "0x49")]
	[Token(Token = "0x600046C")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B0690", Offset = "0x28AFA90", Length = "0xB")]
	[Token(Token = "0x6000445")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28B06E0", Offset = "0x28AFAE0", Length = "0x11")]
	[Token(Token = "0x6000464")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28B0700", Offset = "0x28AFB00", Length = "0x11")]
	[Token(Token = "0x6000458")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28B06A0", Offset = "0x28AFAA0", Length = "0x11")]
	[Token(Token = "0x600046A")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28B07C0", Offset = "0x28AFBC0", Length = "0x11")]
	[Token(Token = "0x600045E")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28B07E0", Offset = "0x28AFBE0", Length = "0x47C")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x6000476")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x28B0720", Offset = "0x28AFB20", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600044A")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28B06C0", Offset = "0x28AFAC0", Length = "0x11")]
	[Token(Token = "0x6000471")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B1530", Offset = "0x28B0930", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x600043F")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000442")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x6000443")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x600043D")]
	public override int get_Length() { }

	[Address(RVA = "0x28B1530", Offset = "0x28B0930", Length = "0x6")]
	[Token(Token = "0x600043A")]
	public static int get_UTF8MaxLengthInBytes() { }

	[Address(RVA = "0x28B1050", Offset = "0x28B0450", Length = "0x39")]
	[Token(Token = "0x600043B")]
	public string get_Value() { }

	[Address(RVA = "0x28B0C60", Offset = "0x28B0060", Length = "0x67")]
	[Token(Token = "0x6000448")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28B0CD0", Offset = "0x28B00D0", Length = "0x39")]
	[Token(Token = "0x6000475")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28B0D10", Offset = "0x28B0110", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x600043C")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28B0F20", Offset = "0x28B0320", Length = "0x48")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600044D")]
	internal CopyError Initialize(string source) { }

	[Address(RVA = "0x28B0FD0", Offset = "0x28B03D0", Length = "0x78")]
	[Token(Token = "0x600044F")]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B0DE0", Offset = "0x28B01E0", Length = "0x78")]
	[Token(Token = "0x6000450")]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[Address(RVA = "0x28B0E60", Offset = "0x28B0260", Length = "0x5C")]
	[Token(Token = "0x600046E")]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B0EC0", Offset = "0x28B02C0", Length = "0x5C")]
	[Token(Token = "0x6000455")]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B0D20", Offset = "0x28B0120", Length = "0x5C")]
	[Token(Token = "0x6000461")]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B0D80", Offset = "0x28B0180", Length = "0x5C")]
	[Token(Token = "0x600045B")]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B0F70", Offset = "0x28B0370", Length = "0x5C")]
	[Token(Token = "0x6000467")]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B1560", Offset = "0x28B0960", Length = "0x9E")]
	[Token(Token = "0x6000468")]
	public static bool op_Equality(in FixedString128Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B16A0", Offset = "0x28B0AA0", Length = "0x92")]
	[Token(Token = "0x6000462")]
	public static bool op_Equality(in FixedString128Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B17E0", Offset = "0x28B0BE0", Length = "0x9E")]
	[Token(Token = "0x600046F")]
	public static bool op_Equality(in FixedString128Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B1740", Offset = "0x28B0B40", Length = "0x9E")]
	[Token(Token = "0x600045C")]
	public static bool op_Equality(in FixedString128Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B1600", Offset = "0x28B0A00", Length = "0x9E")]
	[Token(Token = "0x6000456")]
	public static bool op_Equality(in FixedString128Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B1880", Offset = "0x28B0C80", Length = "0x39")]
	[Token(Token = "0x600046B")]
	public static FixedString512Bytes op_Implicit(in FixedString128Bytes fs) { }

	[Address(RVA = "0x28B18C0", Offset = "0x28B0CC0", Length = "0x62")]
	[Token(Token = "0x6000472")]
	public static FixedString4096Bytes op_Implicit(in FixedString128Bytes fs) { }

	[Address(RVA = "0x28B1930", Offset = "0x28B0D30", Length = "0x6E")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000473")]
	public static FixedString128Bytes op_Implicit(string b) { }

	[Address(RVA = "0x28B1A20", Offset = "0x28B0E20", Length = "0x13")]
	[Token(Token = "0x6000457")]
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B1A00", Offset = "0x28B0E00", Length = "0x13")]
	[Token(Token = "0x6000469")]
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B19A0", Offset = "0x28B0DA0", Length = "0x13")]
	[Token(Token = "0x6000463")]
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B19E0", Offset = "0x28B0DE0", Length = "0x13")]
	[Token(Token = "0x600045D")]
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B19C0", Offset = "0x28B0DC0", Length = "0x13")]
	[Token(Token = "0x6000470")]
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000440")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
	[Token(Token = "0x6000444")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
	[Token(Token = "0x600043E")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28B1050", Offset = "0x28B0450", Length = "0x39")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x6000474")]
	public virtual string ToString() { }

	[Address(RVA = "0x28B1090", Offset = "0x28B0490", Length = "0x73")]
	[Token(Token = "0x6000441")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

