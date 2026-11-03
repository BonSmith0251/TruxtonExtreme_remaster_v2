namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000077")]
public struct FixedString4096Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x2000078")]
	internal struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039D")]
		private FixedString4096Bytes target; //Field offset: 0x0
		[FieldOffset(Offset = "0x1000")]
		[Token(Token = "0x400039E")]
		private int offset; //Field offset: 0x1000
		[FieldOffset(Offset = "0x1004")]
		[Token(Token = "0x400039F")]
		private Rune current; //Field offset: 0x1004

		[Token(Token = "0x170000A5")]
		public Rune Current
		{
			[Address(RVA = "0x28B0010", Offset = "0x28AF410", Length = "0x7")]
			[Token(Token = "0x600050D")]
			 get { } //Length: 7
		}

		[Token(Token = "0x170000A6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28AFD10", Offset = "0x28AF110", Length = "0x46")]
			[Token(Token = "0x600050E")]
			private get { } //Length: 70
		}

		[Address(RVA = "0x28AFF30", Offset = "0x28AF330", Length = "0x49")]
		[Token(Token = "0x6000509")]
		public Enumerator(FixedString4096Bytes other) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600050A")]
		public void Dispose() { }

		[Address(RVA = "0x28B0010", Offset = "0x28AF410", Length = "0x7")]
		[Token(Token = "0x600050D")]
		public Rune get_Current() { }

		[Address(RVA = "0x28AFBE0", Offset = "0x28AEFE0", Length = "0x41")]
		[Token(Token = "0x600050B")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28AFCE0", Offset = "0x28AF0E0", Length = "0xC")]
		[Token(Token = "0x600050C")]
		public override void Reset() { }

		[Address(RVA = "0x28AFD10", Offset = "0x28AF110", Length = "0x46")]
		[Token(Token = "0x600050E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x400039A")]
	internal const ushort utf8MaxLengthInBytes = 4093; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400039B")]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[SerializeField]
	[Token(Token = "0x400039C")]
	internal FixedBytes4094 bytes; //Field offset: 0x2

	[Token(Token = "0x170000A2")]
	public override int Capacity
	{
		[Address(RVA = "0x28B4A10", Offset = "0x28B3E10", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004CF")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170000A3")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60004D1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000A4")]
	public override byte Item
	{
		[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
		[IsReadOnly]
		[Token(Token = "0x60004D2")]
		 get { } //Length: 9
		[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
		[Token(Token = "0x60004D3")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170000A1")]
	public override int Length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60004CC")]
		 get { } //Length: 4
		[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
		[Token(Token = "0x60004CD")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700009F")]
	public static int UTF8MaxLengthInBytes
	{
		[Address(RVA = "0x28B4A10", Offset = "0x28B3E10", Length = "0x6")]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x170000A0")]
	public string Value
	{
		[Address(RVA = "0x28B45E0", Offset = "0x28B39E0", Length = "0x39")]
		[Token(Token = "0x60004CA")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x28B4800", Offset = "0x28B3C00", Length = "0x35")]
	[Token(Token = "0x60004E9")]
	public FixedString4096Bytes(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B4720", Offset = "0x28B3B20", Length = "0x55")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60004DB")]
	public FixedString4096Bytes(string source) { }

	[Address(RVA = "0x28B4960", Offset = "0x28B3D60", Length = "0xAD")]
	[Token(Token = "0x60004E1")]
	public FixedString4096Bytes(in UnsafeText other) { }

	[Address(RVA = "0x28B46A0", Offset = "0x28B3AA0", Length = "0x35")]
	[Token(Token = "0x60004E3")]
	public FixedString4096Bytes(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B48C0", Offset = "0x28B3CC0", Length = "0x9E")]
	[Token(Token = "0x60004E0")]
	public FixedString4096Bytes(ReadOnly other) { }

	[Address(RVA = "0x28B46E0", Offset = "0x28B3AE0", Length = "0x35")]
	[Token(Token = "0x60004EF")]
	public FixedString4096Bytes(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B4780", Offset = "0x28B3B80", Length = "0x73")]
	[Token(Token = "0x60004DD")]
	public FixedString4096Bytes(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B4840", Offset = "0x28B3C40", Length = "0x35")]
	[Token(Token = "0x60004FB")]
	public FixedString4096Bytes(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B4880", Offset = "0x28B3C80", Length = "0x35")]
	[Token(Token = "0x60004F5")]
	public FixedString4096Bytes(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B0020", Offset = "0x28AF420", Length = "0x1F")]
	[Token(Token = "0x60004D6")]
	public void Add(in byte value) { }

	[Address(RVA = "0x28B3400", Offset = "0x28B2800", Length = "0x2E")]
	[Token(Token = "0x60004DA")]
	public FixedList4096Bytes<Byte>& AsFixedList() { }

	[Address(RVA = "0x28B3430", Offset = "0x28B2830", Length = "0xAC")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000506")]
	private void CheckCapacityInRange(int capacity) { }

	[Address(RVA = "0x28B34E0", Offset = "0x28B28E0", Length = "0x97")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000507")]
	private static void CheckCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28B3580", Offset = "0x28B2980", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000508")]
	private static void CheckFormatError(FormatError error) { }

	[Address(RVA = "0x28B35E0", Offset = "0x28B29E0", Length = "0x129")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	[Token(Token = "0x6000504")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28B3710", Offset = "0x28B2B10", Length = "0x125")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000505")]
	private void CheckLengthInRange(int length) { }

	[Address(RVA = "0x28B0490", Offset = "0x28AF890", Length = "0x9")]
	[Token(Token = "0x60004D5")]
	public override void Clear() { }

	[Address(RVA = "0x28B3840", Offset = "0x28B2C40", Length = "0x49")]
	[Token(Token = "0x60004F4")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28B3890", Offset = "0x28B2C90", Length = "0x49")]
	[Token(Token = "0x60004FA")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B38E0", Offset = "0x28B2CE0", Length = "0x49")]
	[Token(Token = "0x60004EE")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28B3930", Offset = "0x28B2D30", Length = "0x49")]
	[Token(Token = "0x60004E2")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28B3980", Offset = "0x28B2D80", Length = "0x49")]
	[Token(Token = "0x60004E8")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28B39D0", Offset = "0x28B2DD0", Length = "0x5D")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60004D8")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28B0690", Offset = "0x28AFA90", Length = "0xB")]
	[Token(Token = "0x60004D4")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28B3AF0", Offset = "0x28B2EF0", Length = "0x11")]
	[Token(Token = "0x60004F3")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28B3A50", Offset = "0x28B2E50", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60004D9")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28B3B30", Offset = "0x28B2F30", Length = "0x484")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x6000503")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x28B3A30", Offset = "0x28B2E30", Length = "0x11")]
	[Token(Token = "0x60004FF")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B3B10", Offset = "0x28B2F10", Length = "0x11")]
	[Token(Token = "0x60004F9")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28B3FC0", Offset = "0x28B33C0", Length = "0x11")]
	[Token(Token = "0x60004E7")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28B3FE0", Offset = "0x28B33E0", Length = "0x11")]
	[Token(Token = "0x60004ED")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28B4A10", Offset = "0x28B3E10", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x60004CE")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60004D1")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x60004D2")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60004CC")]
	public override int get_Length() { }

	[Address(RVA = "0x28B4A10", Offset = "0x28B3E10", Length = "0x6")]
	[Token(Token = "0x60004C9")]
	public static int get_UTF8MaxLengthInBytes() { }

	[Address(RVA = "0x28B45E0", Offset = "0x28B39E0", Length = "0x39")]
	[Token(Token = "0x60004CA")]
	public string get_Value() { }

	[Address(RVA = "0x28B4000", Offset = "0x28B3400", Length = "0x9A")]
	[Token(Token = "0x60004D7")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28B40A0", Offset = "0x28B34A0", Length = "0x39")]
	[Token(Token = "0x6000502")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28B0D10", Offset = "0x28B0110", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x60004CB")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28B43E0", Offset = "0x28B37E0", Length = "0x77")]
	[Token(Token = "0x60004DF")]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[Address(RVA = "0x28B40E0", Offset = "0x28B34E0", Length = "0xB1")]
	[Token(Token = "0x60004EA")]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B4320", Offset = "0x28B3720", Length = "0xB1")]
	[Token(Token = "0x60004F0")]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B4590", Offset = "0x28B3990", Length = "0x48")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60004DC")]
	internal CopyError Initialize(string source) { }

	[Address(RVA = "0x28B4520", Offset = "0x28B3920", Length = "0x66")]
	[Token(Token = "0x60004DE")]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B4460", Offset = "0x28B3860", Length = "0xB1")]
	[Token(Token = "0x60004F6")]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B4260", Offset = "0x28B3660", Length = "0xB1")]
	[Token(Token = "0x60004E4")]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B41A0", Offset = "0x28B35A0", Length = "0xB1")]
	[Token(Token = "0x60004FC")]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B4A20", Offset = "0x28B3E20", Length = "0x92")]
	[Token(Token = "0x60004FD")]
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B4B60", Offset = "0x28B3F60", Length = "0x9E")]
	[Token(Token = "0x60004E5")]
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B4CA0", Offset = "0x28B40A0", Length = "0x9E")]
	[Token(Token = "0x60004F7")]
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B4C00", Offset = "0x28B4000", Length = "0x9E")]
	[Token(Token = "0x60004F1")]
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B4AC0", Offset = "0x28B3EC0", Length = "0x9E")]
	[Token(Token = "0x60004EB")]
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B4D40", Offset = "0x28B4140", Length = "0x82")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000500")]
	public static FixedString4096Bytes op_Implicit(string b) { }

	[Address(RVA = "0x28B4DF0", Offset = "0x28B41F0", Length = "0x13")]
	[Token(Token = "0x60004E6")]
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B4E50", Offset = "0x28B4250", Length = "0x13")]
	[Token(Token = "0x60004F8")]
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B4E10", Offset = "0x28B4210", Length = "0x13")]
	[Token(Token = "0x60004FE")]
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B4DD0", Offset = "0x28B41D0", Length = "0x13")]
	[Token(Token = "0x60004F2")]
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B4E30", Offset = "0x28B4230", Length = "0x13")]
	[Token(Token = "0x60004EC")]
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004CF")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
	[Token(Token = "0x60004D3")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
	[Token(Token = "0x60004CD")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28B45E0", Offset = "0x28B39E0", Length = "0x39")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x6000501")]
	public virtual string ToString() { }

	[Address(RVA = "0x28B4620", Offset = "0x28B3A20", Length = "0x76")]
	[Token(Token = "0x60004D0")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

