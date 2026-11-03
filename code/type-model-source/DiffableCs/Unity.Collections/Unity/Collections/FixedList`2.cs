namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(FixedBytes32Align8)})]
[Token(Token = "0x200004C")]
internal struct FixedList : INativeList<T>, IIndexable<T>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000BE")]
	internal U data; //Field offset: 0x0

	[Token(Token = "0x1700003B")]
	internal Byte* buffer
	{
		[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A3D0", Length = "0x69")]
		[IsReadOnly]
		[Token(Token = "0x60001F7")]
		internal get { } //Length: 105
	}

	[Token(Token = "0x17000040")]
	internal Byte* Buffer
	{
		[Address(RVA = "0x1C0ABA0", Offset = "0x1C09FA0", Length = "0xBA")]
		[IsReadOnly]
		[Token(Token = "0x60001FD")]
		internal get { } //Length: 186
	}

	[Token(Token = "0x17000041")]
	public override int Capacity
	{
		[Address(RVA = "0x1C0AC60", Offset = "0x1C0A060", Length = "0x60")]
		[IsReadOnly]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 96
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60001FF")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x1700003D")]
	private IEnumerable<T> Elements
	{
		[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
		[Token(Token = "0x60001FA")]
		private get { } //Length: 112
	}

	[Token(Token = "0x1700003E")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x1C0ACC0", Offset = "0x1C0A0C0", Length = "0x72")]
		[IsReadOnly]
		[Token(Token = "0x60001FB")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000042")]
	public override T Item
	{
		[Address(RVA = "0x1C0AD40", Offset = "0x1C0A140", Length = "0x157")]
		[IsReadOnly]
		[Token(Token = "0x6000200")]
		 get { } //Length: 343
		[Address(RVA = "0x1C0B080", Offset = "0x1C0A480", Length = "0x15E")]
		[Token(Token = "0x6000201")]
		 set { } //Length: 350
	}

	[Token(Token = "0x1700003A")]
	internal ushort length
	{
		[Address(RVA = "0x1C0B040", Offset = "0x1C0A440", Length = "0x40")]
		[IsReadOnly]
		[Token(Token = "0x60001F5")]
		internal get { } //Length: 64
		[Address(RVA = "0x1C0B260", Offset = "0x1C0A660", Length = "0x4C")]
		[Token(Token = "0x60001F6")]
		internal set { } //Length: 76
	}

	[CreateProperty]
	[Token(Token = "0x1700003C")]
	public override int Length
	{
		[Address(RVA = "0x1C0AF60", Offset = "0x1C0A360", Length = "0x70")]
		[IsReadOnly]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 112
		[Address(RVA = "0x1C0B1E0", Offset = "0x1C0A5E0", Length = "0x7F")]
		[Token(Token = "0x60001F9")]
		 set { } //Length: 127
	}

	[Token(Token = "0x1700003F")]
	internal int LengthInBytes
	{
		[Address(RVA = "0x1C0AEA0", Offset = "0x1C0A2A0", Length = "0xB7")]
		[IsReadOnly]
		[Token(Token = "0x60001FC")]
		internal get { } //Length: 183
	}

	[Address(RVA = "0x1C09A50", Offset = "0x1C08E50", Length = "0x86")]
	[Token(Token = "0x6000204")]
	public void Add(in T item) { }

	[Address(RVA = "0x1C00BA0", Offset = "0x1BFFFA0", Length = "0x1FE")]
	[Token(Token = "0x6000206")]
	public void AddNoResize(in T item) { }

	[Address(RVA = "0x1C097A0", Offset = "0x1C08BA0", Length = "0x98")]
	[Token(Token = "0x6000205")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x1C09590", Offset = "0x1C08990", Length = "0x201")]
	[Token(Token = "0x6000207")]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[Address(RVA = "0x1C09840", Offset = "0x1C08C40", Length = "0x208")]
	[Token(Token = "0x6000208")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x1C09AE0", Offset = "0x1C08EE0", Length = "0x78")]
	[Token(Token = "0x6000209")]
	public override void Clear() { }

	[Address(RVA = "0x1C09B60", Offset = "0x1C08F60", Length = "0xCF")]
	[Token(Token = "0x6000202")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A3D0", Length = "0x69")]
	[IsReadOnly]
	[Token(Token = "0x60001F7")]
	internal Byte* get_buffer() { }

	[Address(RVA = "0x1C0ABA0", Offset = "0x1C09FA0", Length = "0xBA")]
	[IsReadOnly]
	[Token(Token = "0x60001FD")]
	internal Byte* get_Buffer() { }

	[Address(RVA = "0x1C0AC60", Offset = "0x1C0A060", Length = "0x60")]
	[IsReadOnly]
	[Token(Token = "0x60001FE")]
	public override int get_Capacity() { }

	[Address(RVA = "0xD8E000", Offset = "0xD8D400", Length = "0x70")]
	[Token(Token = "0x60001FA")]
	private IEnumerable<T> get_Elements() { }

	[Address(RVA = "0x1C0ACC0", Offset = "0x1C0A0C0", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x60001FB")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x1C0AD40", Offset = "0x1C0A140", Length = "0x157")]
	[IsReadOnly]
	[Token(Token = "0x6000200")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x1C0B040", Offset = "0x1C0A440", Length = "0x40")]
	[IsReadOnly]
	[Token(Token = "0x60001F5")]
	internal ushort get_length() { }

	[Address(RVA = "0x1C0AF60", Offset = "0x1C0A360", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x60001F8")]
	public override int get_Length() { }

	[Address(RVA = "0x1C0AEA0", Offset = "0x1C0A2A0", Length = "0xB7")]
	[IsReadOnly]
	[Token(Token = "0x60001FC")]
	internal int get_LengthInBytes() { }

	[Address(RVA = "0x1C09C30", Offset = "0x1C09030", Length = "0xD4")]
	[Token(Token = "0x6000203")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1C0A040", Offset = "0x1C09440", Length = "0x164")]
	[Token(Token = "0x600020C")]
	public void Insert(int index, in T item) { }

	[Address(RVA = "0x1C09FA0", Offset = "0x1C093A0", Length = "0x97")]
	[Token(Token = "0x600020B")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x1C09D10", Offset = "0x1C09110", Length = "0x28C")]
	[Token(Token = "0x600020A")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x1C0A240", Offset = "0x1C09640", Length = "0x8A")]
	[Token(Token = "0x600020F")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1C0A1B0", Offset = "0x1C095B0", Length = "0x8A")]
	[Token(Token = "0x600020D")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x1C0A570", Offset = "0x1C09970", Length = "0x297")]
	[Token(Token = "0x6000210")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1C0A2D0", Offset = "0x1C096D0", Length = "0x29A")]
	[Token(Token = "0x600020E")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001FF")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1C0B080", Offset = "0x1C0A480", Length = "0x15E")]
	[Token(Token = "0x6000201")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x1C0B260", Offset = "0x1C0A660", Length = "0x4C")]
	[Token(Token = "0x60001F6")]
	internal void set_length(ushort value) { }

	[Address(RVA = "0x1C0B1E0", Offset = "0x1C0A5E0", Length = "0x7F")]
	[Token(Token = "0x60001F9")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x1C0A810", Offset = "0x1C09C10", Length = "0x18E")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Token(Token = "0x6000211")]
	public T[] ToArray() { }

	[Address(RVA = "0x1C0A9A0", Offset = "0x1C09DA0", Length = "0x1F6")]
	[Token(Token = "0x6000212")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

