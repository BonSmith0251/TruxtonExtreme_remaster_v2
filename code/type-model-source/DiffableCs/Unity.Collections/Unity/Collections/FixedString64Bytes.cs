namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200006E")]
public struct FixedString64Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x200006F")]
	internal struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023C")]
		private FixedString64Bytes target; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400023D")]
		private int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400023E")]
		private Rune current; //Field offset: 0x44

		[Token(Token = "0x1700008D")]
		public Rune Current
		{
			[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
			[Token(Token = "0x6000438")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700008E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28AFD60", Offset = "0x28AF160", Length = "0x43")]
			[Token(Token = "0x6000439")]
			private get { } //Length: 67
		}

		[Address(RVA = "0x28AFF80", Offset = "0x28AF380", Length = "0x27")]
		[Token(Token = "0x6000434")]
		public Enumerator(FixedString64Bytes other) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000435")]
		public void Dispose() { }

		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000438")]
		public Rune get_Current() { }

		[Address(RVA = "0x28AFC30", Offset = "0x28AF030", Length = "0x38")]
		[Token(Token = "0x6000436")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28AFCF0", Offset = "0x28AF0F0", Length = "0x9")]
		[Token(Token = "0x6000437")]
		public override void Reset() { }

		[Address(RVA = "0x28AFD60", Offset = "0x28AF160", Length = "0x43")]
		[Token(Token = "0x6000439")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x4000239")]
	internal const ushort utf8MaxLengthInBytes = 61; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400023A")]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[SerializeField]
	[Token(Token = "0x400023B")]
	internal FixedBytes62 bytes; //Field offset: 0x2

	[Token(Token = "0x1700008A")]
	public override int Capacity
	{
		[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x60003F6")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003F7")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700008B")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700008C")]
	public override byte Item
	{
		[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
		[IsReadOnly]
		[Token(Token = "0x60003FA")]
		 get { } //Length: 9
		[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
		[Token(Token = "0x60003FB")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000089")]
	public override int Length
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60003F4")]
		 get { } //Length: 4
		[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
		[Token(Token = "0x60003F5")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000087")]
	public static int UTF8MaxLengthInBytes
	{
		[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
		[Token(Token = "0x60003F1")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x17000088")]
	public string Value
	{
		[Address(RVA = "0x28B7AC0", Offset = "0x28B6EC0", Length = "0x39")]
		[Token(Token = "0x60003F2")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x28B7C40", Offset = "0x28B7040", Length = "0x1A")]
	[Token(Token = "0x6000411")]
	public FixedString64Bytes(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B7C60", Offset = "0x28B7060", Length = "0x1A")]
	[Token(Token = "0x6000417")]
	public FixedString64Bytes(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B7CA0", Offset = "0x28B70A0", Length = "0x1A")]
	[Token(Token = "0x600040B")]
	public FixedString64Bytes(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B7B80", Offset = "0x28B6F80", Length = "0xBB")]
	[Token(Token = "0x6000409")]
	public FixedString64Bytes(in UnsafeText other) { }

	[Address(RVA = "0x28B7CC0", Offset = "0x28B70C0", Length = "0xA2")]
	[Token(Token = "0x6000408")]
	public FixedString64Bytes(ReadOnly other) { }

	[Address(RVA = "0x28B7C80", Offset = "0x28B7080", Length = "0x1A")]
	[Token(Token = "0x600041E")]
	public FixedString64Bytes(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B7DF0", Offset = "0x28B71F0", Length = "0x7A")]
	[Token(Token = "0x6000405")]
	public FixedString64Bytes(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B7D90", Offset = "0x28B7190", Length = "0x5A")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000403")]
	public FixedString64Bytes(string source) { }

	[Address(RVA = "0x28B7D70", Offset = "0x28B7170", Length = "0x1A")]
	[Token(Token = "0x6000425")]
	public FixedString64Bytes(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B0020", Offset = "0x28AF420", Length = "0x1F")]
	[Token(Token = "0x60003FE")]
	public void Add(in byte value) { }

	[Address(RVA = "0x28B6960", Offset = "0x28B5D60", Length = "0x2E")]
	[Token(Token = "0x6000402")]
	public FixedList64Bytes<Byte>& AsFixedList() { }

	[Address(RVA = "0x28B6990", Offset = "0x28B5D90", Length = "0xB4")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000431")]
	private void CheckCapacityInRange(int capacity) { }

	[Address(RVA = "0x28B6A50", Offset = "0x28B5E50", Length = "0x97")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000432")]
	private static void CheckCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28B6AF0", Offset = "0x28B5EF0", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000433")]
	private static void CheckFormatError(FormatError error) { }

	[Address(RVA = "0x28B6B50", Offset = "0x28B5F50", Length = "0x129")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	[Token(Token = "0x600042F")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28B6C80", Offset = "0x28B6080", Length = "0x126")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000430")]
	private void CheckLengthInRange(int length) { }

	[Address(RVA = "0x28B0490", Offset = "0x28AF890", Length = "0x9")]
	[Token(Token = "0x60003FD")]
	public override void Clear() { }

	[Address(RVA = "0x28B6E50", Offset = "0x28B6250", Length = "0x49")]
	[Token(Token = "0x6000424")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B6EA0", Offset = "0x28B62A0", Length = "0x5D")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000400")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28B6F50", Offset = "0x28B6350", Length = "0x49")]
	[Token(Token = "0x6000410")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28B6E00", Offset = "0x28B6200", Length = "0x49")]
	[Token(Token = "0x6000416")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28B6DB0", Offset = "0x28B61B0", Length = "0x49")]
	[Token(Token = "0x600041D")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28B6F00", Offset = "0x28B6300", Length = "0x49")]
	[Token(Token = "0x600040A")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28B0690", Offset = "0x28AFA90", Length = "0xB")]
	[Token(Token = "0x60003FC")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28B7420", Offset = "0x28B6820", Length = "0x11")]
	[Token(Token = "0x600040F")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28B7440", Offset = "0x28B6840", Length = "0x11")]
	[Token(Token = "0x600041B")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28B7460", Offset = "0x28B6860", Length = "0x11")]
	[Token(Token = "0x6000415")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28B7540", Offset = "0x28B6940", Length = "0x11")]
	[Token(Token = "0x6000429")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28B7520", Offset = "0x28B6920", Length = "0x11")]
	[Token(Token = "0x6000422")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28B7480", Offset = "0x28B6880", Length = "0x97")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000401")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28B6FA0", Offset = "0x28B63A0", Length = "0x47C")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x600042E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x60003F6")]
	public override int get_Capacity() { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60003F9")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28B1550", Offset = "0x28B0950", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x60003FA")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60003F4")]
	public override int get_Length() { }

	[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
	[Token(Token = "0x60003F1")]
	public static int get_UTF8MaxLengthInBytes() { }

	[Address(RVA = "0x28B7AC0", Offset = "0x28B6EC0", Length = "0x39")]
	[Token(Token = "0x60003F2")]
	public string get_Value() { }

	[Address(RVA = "0x28B7560", Offset = "0x28B6960", Length = "0x2A")]
	[Token(Token = "0x60003FF")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28B7590", Offset = "0x28B6990", Length = "0x39")]
	[Token(Token = "0x600042D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28B0D10", Offset = "0x28B0110", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x60003F3")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28B7700", Offset = "0x28B6B00", Length = "0xB2")]
	[Token(Token = "0x6000426")]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[Address(RVA = "0x28B77C0", Offset = "0x28B6BC0", Length = "0x48")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000404")]
	internal CopyError Initialize(string source) { }

	[Address(RVA = "0x28B7A00", Offset = "0x28B6E00", Length = "0xB2")]
	[Token(Token = "0x600041F")]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[Address(RVA = "0x28B7810", Offset = "0x28B6C10", Length = "0x68")]
	[Token(Token = "0x6000406")]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[Address(RVA = "0x28B7940", Offset = "0x28B6D40", Length = "0xB2")]
	[Token(Token = "0x6000412")]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[Address(RVA = "0x28B7880", Offset = "0x28B6C80", Length = "0xB2")]
	[Token(Token = "0x600040C")]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[Address(RVA = "0x28B7640", Offset = "0x28B6A40", Length = "0xB2")]
	[Token(Token = "0x6000418")]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[Address(RVA = "0x28B75D0", Offset = "0x28B69D0", Length = "0x68")]
	[Token(Token = "0x6000407")]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[Address(RVA = "0x28B8050", Offset = "0x28B7450", Length = "0x92")]
	[Token(Token = "0x6000413")]
	public static bool op_Equality(in FixedString64Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B7E70", Offset = "0x28B7270", Length = "0x9E")]
	[Token(Token = "0x6000420")]
	public static bool op_Equality(in FixedString64Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B7FB0", Offset = "0x28B73B0", Length = "0x9E")]
	[Token(Token = "0x600040D")]
	public static bool op_Equality(in FixedString64Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B7F10", Offset = "0x28B7310", Length = "0x9E")]
	[Token(Token = "0x6000419")]
	public static bool op_Equality(in FixedString64Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B80F0", Offset = "0x28B74F0", Length = "0x9E")]
	[Token(Token = "0x6000427")]
	public static bool op_Equality(in FixedString64Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28B8200", Offset = "0x28B7600", Length = "0x5E")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600042B")]
	public static FixedString64Bytes op_Implicit(string b) { }

	[Address(RVA = "0x28B8190", Offset = "0x28B7590", Length = "0x62")]
	[Token(Token = "0x600042A")]
	public static FixedString4096Bytes op_Implicit(in FixedString64Bytes fs) { }

	[Address(RVA = "0x28B82A0", Offset = "0x28B76A0", Length = "0x3C")]
	[Token(Token = "0x600041C")]
	public static FixedString128Bytes op_Implicit(in FixedString64Bytes fs) { }

	[Address(RVA = "0x28B8260", Offset = "0x28B7660", Length = "0x39")]
	[Token(Token = "0x6000423")]
	public static FixedString512Bytes op_Implicit(in FixedString64Bytes fs) { }

	[Address(RVA = "0x28B8340", Offset = "0x28B7740", Length = "0x13")]
	[Token(Token = "0x6000414")]
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28B8300", Offset = "0x28B7700", Length = "0x13")]
	[Token(Token = "0x600041A")]
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28B82E0", Offset = "0x28B76E0", Length = "0x13")]
	[Token(Token = "0x6000421")]
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28B8360", Offset = "0x28B7760", Length = "0x13")]
	[Token(Token = "0x600040E")]
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28B8320", Offset = "0x28B7720", Length = "0x13")]
	[Token(Token = "0x6000428")]
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003F7")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28B1A40", Offset = "0x28B0E40", Length = "0x9")]
	[Token(Token = "0x60003FB")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28B1A50", Offset = "0x28B0E50", Length = "0xC")]
	[Token(Token = "0x60003F5")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28B7AC0", Offset = "0x28B6EC0", Length = "0x39")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x600042C")]
	public virtual string ToString() { }

	[Address(RVA = "0x28B7B00", Offset = "0x28B6F00", Length = "0x73")]
	[Token(Token = "0x60003F8")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

