namespace UnityEngine.Rendering;

[Token(Token = "0x20000EA")]
internal struct ParallelBitArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000447")]
	private Allocator m_Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000448")]
	private NativeArray<Int64> m_Bits; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000449")]
	private int m_Length; //Field offset: 0x18

	[Token(Token = "0x17000076")]
	public bool IsCreated
	{
		[Address(RVA = "0x2CFE020", Offset = "0x2CFD420", Length = "0x33")]
		[Token(Token = "0x60003C0")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000075")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60003BF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2CFDF90", Offset = "0x2CFD390", Length = "0x8E")]
	[Token(Token = "0x60003C1")]
	public ParallelBitArray(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60003CB")]
	public int ChunkCount() { }

	[Address(RVA = "0x2CFD960", Offset = "0x2CFCD60", Length = "0x42")]
	[Token(Token = "0x60003C2")]
	public void Dispose() { }

	[Address(RVA = "0x2CFD9B0", Offset = "0x2CFCDB0", Length = "0x60")]
	[Token(Token = "0x60003C3")]
	public void Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x2CFDA10", Offset = "0x2CFCE10", Length = "0xD1")]
	[Token(Token = "0x60003CE")]
	public void FillZeroes(int length) { }

	[Address(RVA = "0x2CFDB90", Offset = "0x2CFCF90", Length = "0x70")]
	[Token(Token = "0x60003C6")]
	public bool Get(int index) { }

	[Address(RVA = "0x2CFE020", Offset = "0x2CFD420", Length = "0x33")]
	[Token(Token = "0x60003C0")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60003BF")]
	public int get_Length() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[Token(Token = "0x60003CD")]
	public NativeArray<Int64> GetBitsArray() { }

	[Address(RVA = "0x2CFDAF0", Offset = "0x2CFCEF0", Length = "0xC")]
	[Token(Token = "0x60003C7")]
	public ulong GetChunk(int chunk_index) { }

	[Address(RVA = "0x2CFDB00", Offset = "0x2CFCF00", Length = "0x89")]
	[Token(Token = "0x60003CC")]
	public ParallelBitArray GetSubArray(int length) { }

	[Address(RVA = "0x2CFDC00", Offset = "0x2CFD000", Length = "0x88")]
	[Token(Token = "0x60003CA")]
	public void InterlockedOrChunk(int chunk_index, ulong chunk_bits) { }

	[Address(RVA = "0x2CFDC90", Offset = "0x2CFD090", Length = "0x5B")]
	[Token(Token = "0x60003C9")]
	public ulong InterlockedReadChunk(int chunk_index) { }

	[Address(RVA = "0x2CFDCF0", Offset = "0x2CFD0F0", Length = "0x1C0")]
	[Token(Token = "0x60003C4")]
	public void Resize(int newLength) { }

	[Address(RVA = "0x2CFDEC0", Offset = "0x2CFD2C0", Length = "0xCA")]
	[Token(Token = "0x60003C5")]
	public void Set(int index, bool value) { }

	[Address(RVA = "0x2CFDEB0", Offset = "0x2CFD2B0", Length = "0xC")]
	[Token(Token = "0x60003C8")]
	public void SetChunk(int chunk_index, ulong chunk_bits) { }

}

