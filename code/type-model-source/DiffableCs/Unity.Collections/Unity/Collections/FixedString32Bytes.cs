namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200006B")]
public struct FixedString32Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x200006C")]
	internal struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000225")]
		private FixedString32Bytes target; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000226")]
		private int offset; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000227")]
		private Rune current; //Field offset: 0x24

		[Token(Token = "0x17000085")]
		public Rune Current
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[Token(Token = "0x60003EF")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000086")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28AFDB0", Offset = "0x28AF1B0", Length = "0x43")]
			[Token(Token = "0x60003F0")]
			private get { } //Length: 67
		}

		[Address(RVA = "0x28AFF10", Offset = "0x28AF310", Length = "0x17")]
		[Token(Token = "0x60003EB")]
		public Enumerator(FixedString32Bytes other) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003EC")]
		public void Dispose() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60003EF")]
		public Rune get_Current() { }

		[Address(RVA = "0x28AFBA0", Offset = "0x28AEFA0", Length = "0x38")]
		[Token(Token = "0x60003ED")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28AFD00", Offset = "0x28AF100", Length = "0x9")]
		[Token(Token = "0x60003EE")]
		public override void Reset() { }

		[Address(RVA = "0x28AFDB0", Offset = "0x28AF1B0", Length = "0x43")]
		[Token(Token = "0x60003F0")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x4000222")]
	internal const ushort utf8MaxLengthInBytes = 29; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000223")]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[SerializeField]
	[Token(Token = "0x4000224")]
	internal FixedBytes30 bytes; //Field offset: 0x2

	[Token(Token = "0x17000082")]
	public override int Capacity
	{
		[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x60003AC")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003AD")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000083")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000084")]
	public override byte Item
	{
		[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
		[IsReadOnly]
		[Token(Token = "0x60003B0")]
		 get { } //Length: 9
		[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
		[Token(Token = "0x60003B1")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000081")]
	public override int Length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60003AA")]
		 get { } //Length: 4
		[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
		[Token(Token = "0x60003AB")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700007F")]
	public static int UTF8MaxLengthInBytes
	{
		[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
		[Token(Token = "0x60003A7")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x17000080")]
	public string Value
	{
		[Address(RVA = "0x28B2B40", Offset = "0x28B1F40", Length = "0x39")]
		[Token(Token = "0x60003A8")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x28B2C60", Offset = "0x28B2060", Length = "0x12")]
	[Token(Token = "0x60003C7")]
	public FixedString32Bytes(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B2EA0", Offset = "0x28B22A0", Length = "0x12")]
	[Token(Token = "0x60003CE")]
	public FixedString32Bytes(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B2D50", Offset = "0x28B2150", Length = "0x12")]
	[Token(Token = "0x60003C1")]
	public FixedString32Bytes(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B2CA0", Offset = "0x28B20A0", Length = "0xAB")]
	[Token(Token = "0x60003BF")]
	public FixedString32Bytes(in UnsafeText other) { }

	[Address(RVA = "0x28B2D70", Offset = "0x28B2170", Length = "0x92")]
	[Token(Token = "0x60003BE")]
	public FixedString32Bytes(ReadOnly other) { }

	[Address(RVA = "0x28B2E80", Offset = "0x28B2280", Length = "0x12")]
	[Token(Token = "0x60003D5")]
	public FixedString32Bytes(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B2E10", Offset = "0x28B2210", Length = "0x6A")]
	[Token(Token = "0x60003BB")]
	public FixedString32Bytes(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B2C00", Offset = "0x28B2000", Length = "0x52")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60003B9")]
	public FixedString32Bytes(string source) { }

	[Address(RVA = "0x28B2C80", Offset = "0x28B2080", Length = "0x12")]
	[Token(Token = "0x60003DC")]
	public FixedString32Bytes(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B0020", Offset = "0x28AF420", Length = "0x1F")]
	[Token(Token = "0x60003B4")]
	public void Add(in byte value) { }

	[Address(RVA = "0x28B1A60", Offset = "0x28B0E60", Length = "0x2E")]
	[Token(Token = "0x60003B8")]
	public FixedList32Bytes<Byte>& AsFixedList() { }

	[Address(RVA = "0x28B1A90", Offset = "0x28B0E90", Length = "0xB4")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60003E8")]
	private void CheckCapacityInRange(int capacity) { }

	[Address(RVA = "0x28B1B50", Offset = "0x28B0F50", Length = "0x97")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60003E9")]
	private static void CheckCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28B1BF0", Offset = "0x28B0FF0", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60003EA")]
	private static void CheckFormatError(FormatError error) { }

	[Address(RVA = "0x28B1C50", Offset = "0x28B1050", Length = "0x129")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	[Token(Token = "0x60003E6")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28B1D80", Offset = "0x28B1180", Length = "0x126")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60003E7")]
	private void CheckLengthInRange(int length) { }

	[Address(RVA = "0x28B0490", Offset = "0x28AF890", Length = "0x9")]
	[Token(Token = "0x60003B3")]
	public override void Clear() { }

	[Address(RVA = "0x28B1FB0", Offset = "0x28B13B0", Length = "0x49")]
	[Token(Token = "0x60003DB")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B1F50", Offset = "0x28B1350", Length = "0x5D")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60003B6")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28B2050", Offset = "0x28B1450", Length = "0x49")]
	[Token(Token = "0x60003C6")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28B1F00", Offset = "0x28B1300", Length = "0x49")]
	[Token(Token = "0x60003CD")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28B1EB0", Offset = "0x28B12B0", Length = "0x49")]
	[Token(Token = "0x60003D4")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28B2000", Offset = "0x28B1400", Length = "0x49")]
	[Token(Token = "0x60003C0")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28B0690", Offset = "0x28AFA90", Length = "0xB")]
	[Token(Token = "0x60003B2")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28B2180", Offset = "0x28B1580", Length = "0x11")]
	[Token(Token = "0x60003C5")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28B21A0", Offset = "0x28B15A0", Length = "0x11")]
	[Token(Token = "0x60003D2")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28B2160", Offset = "0x28B1560", Length = "0x11")]
	[Token(Token = "0x60003CB")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28B2640", Offset = "0x28B1A40", Length = "0x11")]
	[Token(Token = "0x60003E0")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B2140", Offset = "0x28B1540", Length = "0x11")]
	[Token(Token = "0x60003D9")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28B20A0", Offset = "0x28B14A0", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60003B7")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28B21C0", Offset = "0x28B15C0", Length = "0x478")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60003E5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x60003AC")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60003AF")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x60003B0")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60003AA")]
	public override int get_Length() { }

	[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
	[Token(Token = "0x60003A7")]
	public static int get_UTF8MaxLengthInBytes() { }

	[Address(RVA = "0x28B2B40", Offset = "0x28B1F40", Length = "0x39")]
	[Token(Token = "0x60003A8")]
	public string get_Value() { }

	[Address(RVA = "0x28B2660", Offset = "0x28B1A60", Length = "0x1A")]
	[Token(Token = "0x60003B5")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28B2680", Offset = "0x28B1A80", Length = "0x39")]
	[Token(Token = "0x60003E4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28B0D10", Offset = "0x28B0110", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x60003A9")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28B2930", Offset = "0x28B1D30", Length = "0xAA")]
	[Token(Token = "0x60003C8")]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B2A90", Offset = "0x28B1E90", Length = "0xAA")]
	[Token(Token = "0x60003CF")]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B2880", Offset = "0x28B1C80", Length = "0xAA")]
	[Token(Token = "0x60003DD")]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B2770", Offset = "0x28B1B70", Length = "0xAA")]
	[Token(Token = "0x60003C2")]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B2820", Offset = "0x28B1C20", Length = "0x60")]
	[Token(Token = "0x60003BD")]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[Address(RVA = "0x28B2710", Offset = "0x28B1B10", Length = "0x60")]
	[Token(Token = "0x60003BC")]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B29E0", Offset = "0x28B1DE0", Length = "0xAA")]
	[Token(Token = "0x60003D6")]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B26C0", Offset = "0x28B1AC0", Length = "0x48")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60003BA")]
	internal CopyError Initialize(string source) { }

	[Address(RVA = "0x28B3140", Offset = "0x28B2540", Length = "0x9E")]
	[Token(Token = "0x60003DE")]
	public static bool op_Equality(in FixedString32Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B2EC0", Offset = "0x28B22C0", Length = "0x9E")]
	[Token(Token = "0x60003C9")]
	public static bool op_Equality(in FixedString32Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B3000", Offset = "0x28B2400", Length = "0x9E")]
	[Token(Token = "0x60003D7")]
	public static bool op_Equality(in FixedString32Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B2F60", Offset = "0x28B2360", Length = "0x92")]
	[Token(Token = "0x60003C3")]
	public static bool op_Equality(in FixedString32Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B30A0", Offset = "0x28B24A0", Length = "0x9E")]
	[Token(Token = "0x60003D0")]
	public static bool op_Equality(in FixedString32Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B3220", Offset = "0x28B2620", Length = "0x2C")]
	[Token(Token = "0x60003CC")]
	public static FixedString64Bytes op_Implicit(in FixedString32Bytes fs) { }

	[Address(RVA = "0x28B32C0", Offset = "0x28B26C0", Length = "0x56")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60003E2")]
	public static FixedString32Bytes op_Implicit(string b) { }

	[Address(RVA = "0x28B3250", Offset = "0x28B2650", Length = "0x62")]
	[Token(Token = "0x60003E1")]
	public static FixedString4096Bytes op_Implicit(in FixedString32Bytes fs) { }

	[Address(RVA = "0x28B3320", Offset = "0x28B2720", Length = "0x3C")]
	[Token(Token = "0x60003D3")]
	public static FixedString128Bytes op_Implicit(in FixedString32Bytes fs) { }

	[Address(RVA = "0x28B31E0", Offset = "0x28B25E0", Length = "0x39")]
	[Token(Token = "0x60003DA")]
	public static FixedString512Bytes op_Implicit(in FixedString32Bytes fs) { }

	[Address(RVA = "0x28B3360", Offset = "0x28B2760", Length = "0x13")]
	[Token(Token = "0x60003DF")]
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B33C0", Offset = "0x28B27C0", Length = "0x13")]
	[Token(Token = "0x60003D8")]
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B33A0", Offset = "0x28B27A0", Length = "0x13")]
	[Token(Token = "0x60003C4")]
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B33E0", Offset = "0x28B27E0", Length = "0x13")]
	[Token(Token = "0x60003CA")]
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B3380", Offset = "0x28B2780", Length = "0x13")]
	[Token(Token = "0x60003D1")]
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003AD")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
	[Token(Token = "0x60003B1")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
	[Token(Token = "0x60003AB")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28B2B40", Offset = "0x28B1F40", Length = "0x39")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x60003E3")]
	public virtual string ToString() { }

	[Address(RVA = "0x28B2B80", Offset = "0x28B1F80", Length = "0x73")]
	[Token(Token = "0x60003AE")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

