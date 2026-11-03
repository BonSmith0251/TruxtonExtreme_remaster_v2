namespace Unity.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000033")]
internal struct ArrayOfArrays : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000077")]
	private AllocatorHandle m_backingAllocatorHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000078")]
	private int m_lengthInElements; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000079")]
	private int m_capacityInElements; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007A")]
	private int m_log2BlockSizeInElements; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007B")]
	private int m_blocks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	private IntPtr* m_block; //Field offset: 0x0

	[Token(Token = "0x17000021")]
	private int BlockMask
	{
		[Address(RVA = "0xB46020", Offset = "0xB45420", Length = "0x2D")]
		[Token(Token = "0x60000DE")]
		private get { } //Length: 45
	}

	[Token(Token = "0x17000020")]
	private int BlockSizeInBytes
	{
		[Address(RVA = "0xB460C0", Offset = "0xB454C0", Length = "0x2B")]
		[Token(Token = "0x60000DD")]
		private get { } //Length: 43
	}

	[Token(Token = "0x1700001F")]
	private int BlockSizeInElements
	{
		[Address(RVA = "0xB46190", Offset = "0xB45590", Length = "0xB")]
		[Token(Token = "0x60000DC")]
		private get { } //Length: 11
	}

	[Token(Token = "0x17000023")]
	public int Capacity
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public T Item
	{
		[Address(RVA = "0xB461A0", Offset = "0xB455A0", Length = "0xA9")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000022")]
	public int Length
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xB45F70", Offset = "0xB45370", Length = "0xAE")]
	[Token(Token = "0x60000E1")]
	public ArrayOfArrays`1(int capacityInElements, AllocatorHandle backingAllocatorHandle, int log2BlockSizeInElements = 12) { }

	[Address(RVA = "0xB451C0", Offset = "0xB445C0", Length = "0x8")]
	[Token(Token = "0x60000EB")]
	private int BlockIndexOfElement(int elementIndex) { }

	[Address(RVA = "0xB451D0", Offset = "0xB445D0", Length = "0xAD")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60000E8")]
	private void CheckBlockIndex(int blockIndex) { }

	[Address(RVA = "0xB45280", Offset = "0xB44680", Length = "0x96")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60000E9")]
	private void CheckBlockIsNotNull(int blockIndex) { }

	[Address(RVA = "0xB45320", Offset = "0xB44720", Length = "0xAD")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60000E7")]
	private void CheckElementIndex(int elementIndex) { }

	[Address(RVA = "0xB453D0", Offset = "0xB447D0", Length = "0x8A")]
	[Token(Token = "0x60000E5")]
	public void Clear() { }

	[Address(RVA = "0xB455C0", Offset = "0xB449C0", Length = "0x70")]
	[Token(Token = "0x60000E6")]
	public override void Dispose() { }

	[Address(RVA = "0xB46020", Offset = "0xB45420", Length = "0x2D")]
	[Token(Token = "0x60000DE")]
	private int get_BlockMask() { }

	[Address(RVA = "0xB460C0", Offset = "0xB454C0", Length = "0x2B")]
	[Token(Token = "0x60000DD")]
	private int get_BlockSizeInBytes() { }

	[Address(RVA = "0xB46190", Offset = "0xB45590", Length = "0xB")]
	[Token(Token = "0x60000DC")]
	private int get_BlockSizeInElements() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60000E0")]
	public int get_Capacity() { }

	[Address(RVA = "0xB461A0", Offset = "0xB455A0", Length = "0xA9")]
	[Token(Token = "0x60000E3")]
	public T get_Item(int elementIndex) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60000DF")]
	public int get_Length() { }

	[Address(RVA = "0xB458A0", Offset = "0xB44CA0", Length = "0x161")]
	[Token(Token = "0x60000E2")]
	public void LockfreeAdd(T t) { }

	[Address(RVA = "0xB45A10", Offset = "0xB44E10", Length = "0xA9")]
	[Token(Token = "0x60000EA")]
	public void RemoveAtSwapBack(int elementIndex) { }

	[Address(RVA = "0xB45CA0", Offset = "0xB450A0", Length = "0x8")]
	[Token(Token = "0x60000E4")]
	public void Rewind() { }

	[Address(RVA = "0xB45DD0", Offset = "0xB451D0", Length = "0xD0")]
	[Token(Token = "0x60000EC")]
	public void TrimExcess() { }

}

