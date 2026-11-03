namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000D2")]
public struct NativeText : INativeList<Byte>, IIndexable<Byte>, INativeDisposable, IDisposable, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	[Token(Token = "0x20000D3")]
	internal struct Enumerator : IEnumerator<Rune>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400040D")]
		private ReadOnly target; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400040E")]
		private int offset; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400040F")]
		private Rune current; //Field offset: 0xC

		[Token(Token = "0x17000118")]
		public override Rune Current
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x60009B5")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000117")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x28C6A80", Offset = "0x28C5E80", Length = "0x43")]
			[Token(Token = "0x60009B4")]
			private get { } //Length: 67
		}

		[Address(RVA = "0x28C6AD0", Offset = "0x28C5ED0", Length = "0xC")]
		[Token(Token = "0x60009AF")]
		public Enumerator(NativeText source) { }

		[Address(RVA = "0x28C6AD0", Offset = "0x28C5ED0", Length = "0xC")]
		[Token(Token = "0x60009B0")]
		public Enumerator(ReadOnly source) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009B1")]
		public override void Dispose() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60009B5")]
		public override Rune get_Current() { }

		[Address(RVA = "0x28C6A00", Offset = "0x28C5E00", Length = "0x64")]
		[Token(Token = "0x60009B2")]
		public override bool MoveNext() { }

		[Address(RVA = "0x28C6A70", Offset = "0x28C5E70", Length = "0x9")]
		[Token(Token = "0x60009B3")]
		public override void Reset() { }

		[Address(RVA = "0x28C6A80", Offset = "0x28C5E80", Length = "0x43")]
		[Token(Token = "0x60009B4")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000D4")]
	internal struct ReadOnly : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000410")]
		internal UnsafeText* m_Data; //Field offset: 0x0

		[Token(Token = "0x17000119")]
		public override int Capacity
		{
			[Address(RVA = "0x28CA640", Offset = "0x28C9A40", Length = "0x64")]
			[IsReadOnly]
			[Token(Token = "0x60009B7")]
			 get { } //Length: 100
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60009B8")]
			 set { } //Length: 3
		}

		[Token(Token = "0x1700011A")]
		public override bool IsEmpty
		{
			[Address(RVA = "0x28CA6B0", Offset = "0x28C9AB0", Length = "0x13")]
			[IsReadOnly]
			[Token(Token = "0x60009B9")]
			 get { } //Length: 19
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60009BA")]
			 set { } //Length: 3
		}

		[Token(Token = "0x1700011C")]
		public override byte Item
		{
			[Address(RVA = "0x28CA6D0", Offset = "0x28C9AD0", Length = "0x3E")]
			[IsReadOnly]
			[Token(Token = "0x60009BD")]
			 get { } //Length: 62
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60009BE")]
			 set { } //Length: 3
		}

		[Token(Token = "0x1700011B")]
		public override int Length
		{
			[Address(RVA = "0x7F31A0", Offset = "0x7F25A0", Length = "0x80")]
			[IsReadOnly]
			[Token(Token = "0x60009BB")]
			 get { } //Length: 128
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60009BC")]
			 set { } //Length: 3
		}

		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState::Never (1))]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		[Token(Token = "0x1700011D")]
		public string Value
		{
			[Address(RVA = "0x28CBB10", Offset = "0x28CAF10", Length = "0x58")]
			[Token(Token = "0x60009E3")]
			 get { } //Length: 88
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x60009B6")]
		internal ReadOnly(UnsafeText* text) { }

		[Address(RVA = "0x28CB040", Offset = "0x28CA440", Length = "0x60")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x60009C3")]
		internal static void CheckNull(Void* dataPtr) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x60009C4")]
		private void CheckRead() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009BF")]
		public override void Clear() { }

		[Address(RVA = "0x28CB0F0", Offset = "0x28CA4F0", Length = "0x49")]
		[Token(Token = "0x60009D4")]
		public override int CompareTo(FixedString128Bytes other) { }

		[Address(RVA = "0x28CB1D0", Offset = "0x28CA5D0", Length = "0x49")]
		[Token(Token = "0x60009CC")]
		public override int CompareTo(FixedString32Bytes other) { }

		[Address(RVA = "0x28CB2C0", Offset = "0x28CA6C0", Length = "0x49")]
		[Token(Token = "0x60009DC")]
		public override int CompareTo(FixedString4096Bytes other) { }

		[Address(RVA = "0x28CB140", Offset = "0x28CA540", Length = "0x48")]
		[Token(Token = "0x60009CA")]
		public override int CompareTo(NativeText other) { }

		[Address(RVA = "0x28CB220", Offset = "0x28CA620", Length = "0x49")]
		[Token(Token = "0x60009D8")]
		public override int CompareTo(FixedString512Bytes other) { }

		[Address(RVA = "0x28CB0A0", Offset = "0x28CA4A0", Length = "0x49")]
		[Token(Token = "0x60009D0")]
		public override int CompareTo(FixedString64Bytes other) { }

		[Address(RVA = "0x28CB270", Offset = "0x28CA670", Length = "0x48")]
		[Token(Token = "0x60009C8")]
		public int CompareTo(ReadOnly other) { }

		[Address(RVA = "0x28CB190", Offset = "0x28CA590", Length = "0x30")]
		[ExcludeFromBurstCompatTesting("Takes managed string")]
		[Token(Token = "0x60009C6")]
		public override int CompareTo(string other) { }

		[Address(RVA = "0x28CB340", Offset = "0x28CA740", Length = "0x4E")]
		[Token(Token = "0x60009C0")]
		public override byte ElementAt(int index) { }

		[Address(RVA = "0x28CB390", Offset = "0x28CA790", Length = "0x11")]
		[Token(Token = "0x60009CF")]
		public override bool Equals(FixedString32Bytes other) { }

		[Address(RVA = "0x28CB8F0", Offset = "0x28CACF0", Length = "0x48")]
		[Token(Token = "0x60009CB")]
		public override bool Equals(NativeText other) { }

		[Address(RVA = "0x28CB880", Offset = "0x28CAC80", Length = "0x48")]
		[Token(Token = "0x60009C9")]
		public bool Equals(ReadOnly other) { }

		[Address(RVA = "0x28CB840", Offset = "0x28CAC40", Length = "0x30")]
		[ExcludeFromBurstCompatTesting("Takes managed string")]
		[Token(Token = "0x60009C7")]
		public override bool Equals(string other) { }

		[Address(RVA = "0x28CB3F0", Offset = "0x28CA7F0", Length = "0x44D")]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		[Token(Token = "0x60009E2")]
		public virtual bool Equals(object other) { }

		[Address(RVA = "0x28CB3D0", Offset = "0x28CA7D0", Length = "0x11")]
		[Token(Token = "0x60009D7")]
		public override bool Equals(FixedString128Bytes other) { }

		[Address(RVA = "0x28CB940", Offset = "0x28CAD40", Length = "0x11")]
		[Token(Token = "0x60009DB")]
		public override bool Equals(FixedString512Bytes other) { }

		[Address(RVA = "0x28CB8D0", Offset = "0x28CACD0", Length = "0x11")]
		[Token(Token = "0x60009DF")]
		public override bool Equals(FixedString4096Bytes other) { }

		[Address(RVA = "0x28CB3B0", Offset = "0x28CA7B0", Length = "0x11")]
		[Token(Token = "0x60009D3")]
		public override bool Equals(FixedString64Bytes other) { }

		[Address(RVA = "0x28CB960", Offset = "0x28CAD60", Length = "0x4E")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x60009C5")]
		private void ErrorWrite() { }

		[Address(RVA = "0x28CA640", Offset = "0x28C9A40", Length = "0x64")]
		[IsReadOnly]
		[Token(Token = "0x60009B7")]
		public override int get_Capacity() { }

		[Address(RVA = "0x28CA6B0", Offset = "0x28C9AB0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x60009B9")]
		public override bool get_IsEmpty() { }

		[Address(RVA = "0x28CA6D0", Offset = "0x28C9AD0", Length = "0x3E")]
		[IsReadOnly]
		[Token(Token = "0x60009BD")]
		public override byte get_Item(int index) { }

		[Address(RVA = "0x7F31A0", Offset = "0x7F25A0", Length = "0x80")]
		[IsReadOnly]
		[Token(Token = "0x60009BB")]
		public override int get_Length() { }

		[Address(RVA = "0x28CBB10", Offset = "0x28CAF10", Length = "0x58")]
		[Token(Token = "0x60009E3")]
		public string get_Value() { }

		[Address(RVA = "0x27F4810", Offset = "0x27F3C10", Length = "0x12")]
		[Token(Token = "0x60009E4")]
		public Enumerator GetEnumerator() { }

		[Address(RVA = "0x28CBA30", Offset = "0x28CAE30", Length = "0x39")]
		[Token(Token = "0x60009E1")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x28C9DC0", Offset = "0x28C91C0", Length = "0x7")]
		[Token(Token = "0x60009C1")]
		public override Byte* GetUnsafePtr() { }

		[Address(RVA = "0x28CBD40", Offset = "0x28CB140", Length = "0xBE")]
		[Token(Token = "0x60009D1")]
		public static bool op_Equality(in ReadOnly a, in FixedString64Bytes b) { }

		[Address(RVA = "0x28CBBC0", Offset = "0x28CAFC0", Length = "0xBE")]
		[Token(Token = "0x60009DD")]
		public static bool op_Equality(in ReadOnly a, in FixedString4096Bytes b) { }

		[Address(RVA = "0x28CBEC0", Offset = "0x28CB2C0", Length = "0xBE")]
		[Token(Token = "0x60009D9")]
		public static bool op_Equality(in ReadOnly a, in FixedString512Bytes b) { }

		[Address(RVA = "0x28CBE00", Offset = "0x28CB200", Length = "0xBE")]
		[Token(Token = "0x60009CD")]
		public static bool op_Equality(in ReadOnly a, in FixedString32Bytes b) { }

		[Address(RVA = "0x28CBC80", Offset = "0x28CB080", Length = "0xBE")]
		[Token(Token = "0x60009D5")]
		public static bool op_Equality(in ReadOnly a, in FixedString128Bytes b) { }

		[Address(RVA = "0x28CBF80", Offset = "0x28CB380", Length = "0x13")]
		[Token(Token = "0x60009D6")]
		public static bool op_Inequality(in ReadOnly a, in FixedString128Bytes b) { }

		[Address(RVA = "0x28CBFE0", Offset = "0x28CB3E0", Length = "0x13")]
		[Token(Token = "0x60009DA")]
		public static bool op_Inequality(in ReadOnly a, in FixedString512Bytes b) { }

		[Address(RVA = "0x28CBFC0", Offset = "0x28CB3C0", Length = "0x13")]
		[Token(Token = "0x60009D2")]
		public static bool op_Inequality(in ReadOnly a, in FixedString64Bytes b) { }

		[Address(RVA = "0x28CC000", Offset = "0x28CB400", Length = "0x13")]
		[Token(Token = "0x60009DE")]
		public static bool op_Inequality(in ReadOnly a, in FixedString4096Bytes b) { }

		[Address(RVA = "0x28CBFA0", Offset = "0x28CB3A0", Length = "0x13")]
		[Token(Token = "0x60009CE")]
		public static bool op_Inequality(in ReadOnly a, in FixedString32Bytes b) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009B8")]
		public override void set_Capacity(int value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009BA")]
		public void set_IsEmpty(bool value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009BE")]
		public override void set_Item(int index, byte value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60009BC")]
		public override void set_Length(int value) { }

		[Address(RVA = "0x28CBB10", Offset = "0x28CAF10", Length = "0x58")]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		[Token(Token = "0x60009E0")]
		public virtual string ToString() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60009C2")]
		public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400040C")]
	internal UnsafeText* m_Data; //Field offset: 0x0

	[Token(Token = "0x17000112")]
	public override int Capacity
	{
		[Address(RVA = "0x28CA640", Offset = "0x28C9A40", Length = "0x64")]
		[IsReadOnly]
		[Token(Token = "0x600097C")]
		 get { } //Length: 100
		[Address(RVA = "0x28CAB20", Offset = "0x28C9F20", Length = "0x63")]
		[Token(Token = "0x600097D")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000114")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000980")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000113")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x28CA6B0", Offset = "0x28C9AB0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x600097F")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000115")]
	public override byte Item
	{
		[Address(RVA = "0x28CA6D0", Offset = "0x28C9AD0", Length = "0x3E")]
		[Token(Token = "0x6000982")]
		 get { } //Length: 62
		[Address(RVA = "0x28CAB90", Offset = "0x28C9F90", Length = "0x4B")]
		[Token(Token = "0x6000983")]
		 set { } //Length: 75
	}

	[Token(Token = "0x17000111")]
	public override int Length
	{
		[Address(RVA = "0x7F31A0", Offset = "0x7F25A0", Length = "0x80")]
		[IsReadOnly]
		[Token(Token = "0x600097A")]
		 get { } //Length: 128
		[Address(RVA = "0x28CABE0", Offset = "0x28C9FE0", Length = "0xB")]
		[Token(Token = "0x600097B")]
		 set { } //Length: 11
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x17000116")]
	public string Value
	{
		[Address(RVA = "0x28C9E60", Offset = "0x28C9260", Length = "0x58")]
		[Token(Token = "0x600098D")]
		 get { } //Length: 88
	}

	[Address(RVA = "0x28CA210", Offset = "0x28C9610", Length = "0x35")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600096A")]
	public NativeText(string source, Allocator allocator) { }

	[Address(RVA = "0x28CA180", Offset = "0x28C9580", Length = "0x8B")]
	[Token(Token = "0x6000978")]
	public NativeText(in FixedString4096Bytes source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28CA0C0", Offset = "0x28C94C0", Length = "0x35")]
	[Token(Token = "0x6000977")]
	public NativeText(in FixedString512Bytes source, Allocator allocator) { }

	[Address(RVA = "0x28CA3E0", Offset = "0x28C97E0", Length = "0x8B")]
	[Token(Token = "0x6000976")]
	public NativeText(in FixedString512Bytes source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28CA3A0", Offset = "0x28C97A0", Length = "0x35")]
	[Token(Token = "0x6000975")]
	public NativeText(in FixedString128Bytes source, Allocator allocator) { }

	[Address(RVA = "0x28CA030", Offset = "0x28C9430", Length = "0x8B")]
	[Token(Token = "0x6000974")]
	public NativeText(in FixedString128Bytes source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28CA140", Offset = "0x28C9540", Length = "0x35")]
	[Token(Token = "0x6000973")]
	public NativeText(in FixedString64Bytes source, Allocator allocator) { }

	[Address(RVA = "0x28CA100", Offset = "0x28C9500", Length = "0x35")]
	[Token(Token = "0x6000979")]
	public NativeText(in FixedString4096Bytes source, Allocator allocator) { }

	[Address(RVA = "0x28CA310", Offset = "0x28C9710", Length = "0x8B")]
	[Token(Token = "0x6000972")]
	public NativeText(in FixedString64Bytes source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C9F60", Offset = "0x28C9360", Length = "0x8B")]
	[Token(Token = "0x6000970")]
	public NativeText(in FixedString32Bytes source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C9F50", Offset = "0x28C9350", Length = "0x10")]
	[Token(Token = "0x600096F")]
	public NativeText(AllocatorHandle allocator) { }

	[Address(RVA = "0x28C9EE0", Offset = "0x28C92E0", Length = "0x2C")]
	[Token(Token = "0x600096E")]
	public NativeText(Allocator allocator) { }

	[Address(RVA = "0x28CA250", Offset = "0x28C9650", Length = "0xC0")]
	[Token(Token = "0x600096D")]
	public NativeText(int capacity, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C9F10", Offset = "0x28C9310", Length = "0x33")]
	[Token(Token = "0x600096C")]
	public NativeText(int capacity, Allocator allocator) { }

	[Address(RVA = "0x28CA470", Offset = "0x28C9870", Length = "0x1C2")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600096B")]
	public NativeText(string source, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C9FF0", Offset = "0x28C93F0", Length = "0x35")]
	[Token(Token = "0x6000971")]
	public NativeText(in FixedString32Bytes source, Allocator allocator) { }

	[Address(RVA = "0x28C8FD0", Offset = "0x28C83D0", Length = "0x68")]
	[Token(Token = "0x6000986")]
	public void Add(in byte value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60009AE")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x28C9040", Offset = "0x28C8440", Length = "0x142")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60009AC")]
	private void CheckIndexInRange(int index) { }

	[Address(RVA = "0x28C9190", Offset = "0x28C8590", Length = "0x60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60009A8")]
	internal static void CheckNull(Void* dataPtr) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60009A9")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60009AA")]
	private void CheckWrite() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60009AB")]
	private void CheckWriteAndBumpSecondaryVersion() { }

	[Address(RVA = "0x28C91F0", Offset = "0x28C85F0", Length = "0xD")]
	[Token(Token = "0x6000985")]
	public override void Clear() { }

	[Address(RVA = "0x28C9410", Offset = "0x28C8810", Length = "0x49")]
	[Token(Token = "0x6000995")]
	public override int CompareTo(FixedString64Bytes other) { }

	[Address(RVA = "0x28C9320", Offset = "0x28C8720", Length = "0x49")]
	[Token(Token = "0x60009A1")]
	public override int CompareTo(FixedString4096Bytes other) { }

	[Address(RVA = "0x28C92D0", Offset = "0x28C86D0", Length = "0x49")]
	[Token(Token = "0x600099D")]
	public override int CompareTo(FixedString512Bytes other) { }

	[Address(RVA = "0x28C9370", Offset = "0x28C8770", Length = "0x49")]
	[Token(Token = "0x6000999")]
	public override int CompareTo(FixedString128Bytes other) { }

	[Address(RVA = "0x28C9280", Offset = "0x28C8680", Length = "0x49")]
	[Token(Token = "0x6000991")]
	public override int CompareTo(FixedString32Bytes other) { }

	[Address(RVA = "0x28C93C0", Offset = "0x28C87C0", Length = "0x48")]
	[Token(Token = "0x6000987")]
	public override int CompareTo(NativeText other) { }

	[Address(RVA = "0x28C9200", Offset = "0x28C8600", Length = "0x78")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x600098F")]
	public override int CompareTo(string other) { }

	[Address(RVA = "0x28C9460", Offset = "0x28C8860", Length = "0x43")]
	[Token(Token = "0x6000989")]
	public int CompareTo(ReadOnly other) { }

	[Address(RVA = "0x28C9530", Offset = "0x28C8930", Length = "0xAE")]
	[Token(Token = "0x600098B")]
	public override void Dispose() { }

	[Address(RVA = "0x28C94B0", Offset = "0x28C88B0", Length = "0x7D")]
	[Token(Token = "0x600098C")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28C95E0", Offset = "0x28C89E0", Length = "0x3D")]
	[Token(Token = "0x6000984")]
	public override byte ElementAt(int index) { }

	[Address(RVA = "0x28C96C0", Offset = "0x28C8AC0", Length = "0x59A")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	[Token(Token = "0x60009A7")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x28C9C60", Offset = "0x28C9060", Length = "0x11")]
	[Token(Token = "0x60009A4")]
	public override bool Equals(FixedString4096Bytes other) { }

	[Address(RVA = "0x28C9670", Offset = "0x28C8A70", Length = "0x48")]
	[Token(Token = "0x6000988")]
	public override bool Equals(NativeText other) { }

	[Address(RVA = "0x28C9CA0", Offset = "0x28C90A0", Length = "0x78")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Token(Token = "0x6000990")]
	public override bool Equals(string other) { }

	[Address(RVA = "0x28C9D40", Offset = "0x28C9140", Length = "0x11")]
	[Token(Token = "0x60009A0")]
	public override bool Equals(FixedString512Bytes other) { }

	[Address(RVA = "0x28C9620", Offset = "0x28C8A20", Length = "0x48")]
	[Token(Token = "0x600098A")]
	public bool Equals(ReadOnly other) { }

	[Address(RVA = "0x28C9C80", Offset = "0x28C9080", Length = "0x11")]
	[Token(Token = "0x600099C")]
	public override bool Equals(FixedString128Bytes other) { }

	[Address(RVA = "0x28C9D20", Offset = "0x28C9120", Length = "0x11")]
	[Token(Token = "0x6000994")]
	public override bool Equals(FixedString32Bytes other) { }

	[Address(RVA = "0x28C9D60", Offset = "0x28C9160", Length = "0x11")]
	[Token(Token = "0x6000998")]
	public override bool Equals(FixedString64Bytes other) { }

	[Address(RVA = "0x28CA640", Offset = "0x28C9A40", Length = "0x64")]
	[IsReadOnly]
	[Token(Token = "0x600097C")]
	public override int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000980")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28CA6B0", Offset = "0x28C9AB0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x600097F")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x28CA6D0", Offset = "0x28C9AD0", Length = "0x3E")]
	[Token(Token = "0x6000982")]
	public override byte get_Item(int index) { }

	[Address(RVA = "0x7F31A0", Offset = "0x7F25A0", Length = "0x80")]
	[IsReadOnly]
	[Token(Token = "0x600097A")]
	public override int get_Length() { }

	[Address(RVA = "0x28C9E60", Offset = "0x28C9260", Length = "0x58")]
	[Token(Token = "0x600098D")]
	public string get_Value() { }

	[Address(RVA = "0x27F4810", Offset = "0x27F3C10", Length = "0x12")]
	[Token(Token = "0x600098E")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x28C9D80", Offset = "0x28C9180", Length = "0x39")]
	[Token(Token = "0x60009A6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28C9DC0", Offset = "0x28C91C0", Length = "0x7")]
	[Token(Token = "0x6000981")]
	public override Byte* GetUnsafePtr() { }

	[Address(RVA = "0x28CA7C0", Offset = "0x28C9BC0", Length = "0xAC")]
	[Token(Token = "0x60009A2")]
	public static bool op_Equality(in NativeText a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28CA920", Offset = "0x28C9D20", Length = "0xAC")]
	[Token(Token = "0x6000996")]
	public static bool op_Equality(in NativeText a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28CA9D0", Offset = "0x28C9DD0", Length = "0xAC")]
	[Token(Token = "0x600099E")]
	public static bool op_Equality(in NativeText a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28CA710", Offset = "0x28C9B10", Length = "0xAC")]
	[Token(Token = "0x6000992")]
	public static bool op_Equality(in NativeText a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28CA870", Offset = "0x28C9C70", Length = "0xAC")]
	[Token(Token = "0x600099A")]
	public static bool op_Equality(in NativeText a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28CAAE0", Offset = "0x28C9EE0", Length = "0x13")]
	[Token(Token = "0x600099F")]
	public static bool op_Inequality(in NativeText a, in FixedString512Bytes b) { }

	[Address(RVA = "0x28CAAA0", Offset = "0x28C9EA0", Length = "0x13")]
	[Token(Token = "0x60009A3")]
	public static bool op_Inequality(in NativeText a, in FixedString4096Bytes b) { }

	[Address(RVA = "0x28CAAC0", Offset = "0x28C9EC0", Length = "0x13")]
	[Token(Token = "0x6000993")]
	public static bool op_Inequality(in NativeText a, in FixedString32Bytes b) { }

	[Address(RVA = "0x28CAB00", Offset = "0x28C9F00", Length = "0x13")]
	[Token(Token = "0x600099B")]
	public static bool op_Inequality(in NativeText a, in FixedString128Bytes b) { }

	[Address(RVA = "0x28CAA80", Offset = "0x28C9E80", Length = "0x13")]
	[Token(Token = "0x6000997")]
	public static bool op_Inequality(in NativeText a, in FixedString64Bytes b) { }

	[Address(RVA = "0x28CAB20", Offset = "0x28C9F20", Length = "0x63")]
	[Token(Token = "0x600097D")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x28CAB90", Offset = "0x28C9F90", Length = "0x4B")]
	[Token(Token = "0x6000983")]
	public override void set_Item(int index, byte value) { }

	[Address(RVA = "0x28CABE0", Offset = "0x28C9FE0", Length = "0xB")]
	[Token(Token = "0x600097B")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x28C9DD0", Offset = "0x28C91D0", Length = "0x89")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60009AD")]
	private void ThrowCopyError(CopyError error, string source) { }

	[Address(RVA = "0x28C9E60", Offset = "0x28C9260", Length = "0x58")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Token(Token = "0x60009A5")]
	public virtual string ToString() { }

	[Address(RVA = "0x28C9EC0", Offset = "0x28C92C0", Length = "0x16")]
	[Token(Token = "0x600097E")]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

