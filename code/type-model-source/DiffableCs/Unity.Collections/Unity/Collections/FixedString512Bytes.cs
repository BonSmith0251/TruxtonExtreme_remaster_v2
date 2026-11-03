namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000074")]
public struct FixedString512Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x2000075")]
	internal struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		private FixedString512Bytes target; //Field offset: 0x0
		[FieldOffset(Offset = "0x200")]
		[Token(Token = "0x400028B")]
		private int offset; //Field offset: 0x200
		[FieldOffset(Offset = "0x204")]
		[Token(Token = "0x400028C")]
		private Rune current; //Field offset: 0x204

		[Token(Token = "0x1700009D")]
		public Rune Current
		{
			[Address(RVA = "0x28B0000", Offset = "0x28AF400", Length = "0x7")]
			[Token(Token = "0x60004C7")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700009E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28AFE50", Offset = "0x28AF250", Length = "0x46")]
			[Token(Token = "0x60004C8")]
			private get { } //Length: 70
		}

		[Address(RVA = "0x28AFEA0", Offset = "0x28AF2A0", Length = "0x6B")]
		[Token(Token = "0x60004C3")]
		public Enumerator(FixedString512Bytes other) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004C4")]
		public void Dispose() { }

		[Address(RVA = "0x28B0000", Offset = "0x28AF400", Length = "0x7")]
		[Token(Token = "0x60004C7")]
		public Rune get_Current() { }

		[Address(RVA = "0x28AFB50", Offset = "0x28AEF50", Length = "0x41")]
		[Token(Token = "0x60004C5")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28AFCD0", Offset = "0x28AF0D0", Length = "0xC")]
		[Token(Token = "0x60004C6")]
		public override void Reset() { }

		[Address(RVA = "0x28AFE50", Offset = "0x28AF250", Length = "0x46")]
		[Token(Token = "0x60004C8")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x4000287")]
	internal const ushort utf8MaxLengthInBytes = 509; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000288")]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[SerializeField]
	[Token(Token = "0x4000289")]
	internal FixedBytes510 bytes; //Field offset: 0x2

	[Token(Token = "0x1700009A")]
	public override int Capacity
	{
		[Address(RVA = "0x28B64C0", Offset = "0x28B58C0", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x6000487")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000488")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700009B")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x600048A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009C")]
	public override byte Item
	{
		[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
		[IsReadOnly]
		[Token(Token = "0x600048B")]
		 get { } //Length: 9
		[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
		[Token(Token = "0x600048C")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000099")]
	public override int Length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000485")]
		 get { } //Length: 4
		[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
		[Token(Token = "0x6000486")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000097")]
	public static int UTF8MaxLengthInBytes
	{
		[Address(RVA = "0x28B64C0", Offset = "0x28B58C0", Length = "0x6")]
		[Token(Token = "0x6000482")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x17000098")]
	public string Value
	{
		[Address(RVA = "0x28B6090", Offset = "0x28B5490", Length = "0x39")]
		[Token(Token = "0x6000483")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x28B6200", Offset = "0x28B5600", Length = "0x35")]
	[Token(Token = "0x60004A2")]
	public FixedString512Bytes(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B62A0", Offset = "0x28B56A0", Length = "0x35")]
	[Token(Token = "0x60004B4")]
	public FixedString512Bytes(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B62E0", Offset = "0x28B56E0", Length = "0x35")]
	[Token(Token = "0x60004AE")]
	public FixedString512Bytes(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B6400", Offset = "0x28B5800", Length = "0x35")]
	[Token(Token = "0x60004A8")]
	public FixedString512Bytes(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B6320", Offset = "0x28B5720", Length = "0x35")]
	[Token(Token = "0x600049C")]
	public FixedString512Bytes(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B6150", Offset = "0x28B5550", Length = "0xAD")]
	[Token(Token = "0x600049A")]
	public FixedString512Bytes(in UnsafeText other) { }

	[Address(RVA = "0x28B6360", Offset = "0x28B5760", Length = "0x9E")]
	[Token(Token = "0x6000499")]
	public FixedString512Bytes(ReadOnly other) { }

	[Address(RVA = "0x28B6440", Offset = "0x28B5840", Length = "0x73")]
	[Token(Token = "0x6000496")]
	public FixedString512Bytes(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B6240", Offset = "0x28B5640", Length = "0x55")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000494")]
	public FixedString512Bytes(string source) { }

	[Address(RVA = "0x28B0020", Offset = "0x28AF420", Length = "0x1F")]
	[Token(Token = "0x600048F")]
	public void Add(in byte value) { }

	[Address(RVA = "0x28B4E70", Offset = "0x28B4270", Length = "0x2E")]
	[Token(Token = "0x6000493")]
	public FixedList512Bytes<Byte>& AsFixedList() { }

	[Address(RVA = "0x28B4EA0", Offset = "0x28B42A0", Length = "0xAC")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60004C0")]
	private void CheckCapacityInRange(int capacity) { }

	[Address(RVA = "0x28B4F50", Offset = "0x28B4350", Length = "0x97")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60004C1")]
	private static void CheckCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28B4FF0", Offset = "0x28B43F0", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60004C2")]
	private static void CheckFormatError(FormatError error) { }

	[Address(RVA = "0x28B5050", Offset = "0x28B4450", Length = "0x129")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	[Token(Token = "0x60004BE")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28B5180", Offset = "0x28B4580", Length = "0x125")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60004BF")]
	private void CheckLengthInRange(int length) { }

	[Address(RVA = "0x28B0490", Offset = "0x28AF890", Length = "0x9")]
	[Token(Token = "0x600048E")]
	public override void Clear() { }

	[Address(RVA = "0x28B5450", Offset = "0x28B4850", Length = "0x49")]
	[Token(Token = "0x600049B")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28B53F0", Offset = "0x28B47F0", Length = "0x5D")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000491")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28B5350", Offset = "0x28B4750", Length = "0x49")]
	[Token(Token = "0x60004A1")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28B52B0", Offset = "0x28B46B0", Length = "0x49")]
	[Token(Token = "0x60004AD")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28B5300", Offset = "0x28B4700", Length = "0x49")]
	[Token(Token = "0x60004A7")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28B53A0", Offset = "0x28B47A0", Length = "0x49")]
	[Token(Token = "0x60004B3")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B0690", Offset = "0x28AFA90", Length = "0xB")]
	[Token(Token = "0x600048D")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28B5980", Offset = "0x28B4D80", Length = "0x11")]
	[Token(Token = "0x60004AC")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28B54C0", Offset = "0x28B48C0", Length = "0x11")]
	[Token(Token = "0x60004A0")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28B5960", Offset = "0x28B4D60", Length = "0x11")]
	[Token(Token = "0x60004B2")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28B54A0", Offset = "0x28B48A0", Length = "0x11")]
	[Token(Token = "0x60004A6")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28B54E0", Offset = "0x28B48E0", Length = "0x478")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60004BD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x28B59C0", Offset = "0x28B4DC0", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000492")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28B59A0", Offset = "0x28B4DA0", Length = "0x11")]
	[Token(Token = "0x60004B8")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B64C0", Offset = "0x28B58C0", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x6000487")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x600048A")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x600048B")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000485")]
	public override int get_Length() { }

	[Address(RVA = "0x28B64C0", Offset = "0x28B58C0", Length = "0x6")]
	[Token(Token = "0x6000482")]
	public static int get_UTF8MaxLengthInBytes() { }

	[Address(RVA = "0x28B6090", Offset = "0x28B5490", Length = "0x39")]
	[Token(Token = "0x6000483")]
	public string get_Value() { }

	[Address(RVA = "0x28B5A60", Offset = "0x28B4E60", Length = "0xE5")]
	[Token(Token = "0x6000490")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28B5B50", Offset = "0x28B4F50", Length = "0x39")]
	[Token(Token = "0x60004BC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28B0D10", Offset = "0x28B0110", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x6000484")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28B5E40", Offset = "0x28B5240", Length = "0xB1")]
	[Token(Token = "0x60004B5")]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B5F00", Offset = "0x28B5300", Length = "0x48")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000495")]
	internal CopyError Initialize(string source) { }

	[Address(RVA = "0x28B5C50", Offset = "0x28B5050", Length = "0x66")]
	[Token(Token = "0x6000497")]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B6010", Offset = "0x28B5410", Length = "0x77")]
	[Token(Token = "0x6000498")]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[Address(RVA = "0x28B5D80", Offset = "0x28B5180", Length = "0xB1")]
	[Token(Token = "0x600049D")]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B5F50", Offset = "0x28B5350", Length = "0xB1")]
	[Token(Token = "0x60004A9")]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B5B90", Offset = "0x28B4F90", Length = "0xB1")]
	[Token(Token = "0x60004A3")]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B5CC0", Offset = "0x28B50C0", Length = "0xB1")]
	[Token(Token = "0x60004AF")]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B64D0", Offset = "0x28B58D0", Length = "0x92")]
	[Token(Token = "0x60004B0")]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B66B0", Offset = "0x28B5AB0", Length = "0x9E")]
	[Token(Token = "0x60004A4")]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B6750", Offset = "0x28B5B50", Length = "0x9E")]
	[Token(Token = "0x600049E")]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B6570", Offset = "0x28B5970", Length = "0x9E")]
	[Token(Token = "0x60004AA")]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B6610", Offset = "0x28B5A10", Length = "0x9E")]
	[Token(Token = "0x60004B6")]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B6860", Offset = "0x28B5C60", Length = "0x59")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x60004BA")]
	public static FixedString512Bytes op_Implicit(string b) { }

	[Address(RVA = "0x28B67F0", Offset = "0x28B5BF0", Length = "0x62")]
	[Token(Token = "0x60004B9")]
	public static FixedString4096Bytes op_Implicit(in FixedString512Bytes fs) { }

	[Address(RVA = "0x28B6920", Offset = "0x28B5D20", Length = "0x13")]
	[Token(Token = "0x60004B7")]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B68E0", Offset = "0x28B5CE0", Length = "0x13")]
	[Token(Token = "0x60004A5")]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B6900", Offset = "0x28B5D00", Length = "0x13")]
	[Token(Token = "0x600049F")]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B68C0", Offset = "0x28B5CC0", Length = "0x13")]
	[Token(Token = "0x60004AB")]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B6940", Offset = "0x28B5D40", Length = "0x13")]
	[Token(Token = "0x60004B1")]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000488")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
	[Token(Token = "0x600048C")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
	[Token(Token = "0x6000486")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28B6090", Offset = "0x28B5490", Length = "0x39")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x60004BB")]
	public virtual string ToString() { }

	[Address(RVA = "0x28B60D0", Offset = "0x28B54D0", Length = "0x76")]
	[Token(Token = "0x6000489")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

