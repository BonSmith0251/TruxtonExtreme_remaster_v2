namespace UnityEngine.Rendering;

[Token(Token = "0x2000076")]
internal struct InstanceAllocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000210")]
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000211")]
	private NativeList<Int32> m_FreeInstances; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000212")]
	private int m_BaseInstanceOffset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000213")]
	private int m_InstanceStride; //Field offset: 0x1C

	[Token(Token = "0x17000038")]
	public int length
	{
		[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
		[Token(Token = "0x6000203")]
		 get { } //Length: 6
		[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
		[Token(Token = "0x6000204")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000039")]
	public bool valid
	{
		[Address(RVA = "0x2CE29D0", Offset = "0x2CE1DD0", Length = "0x32")]
		[Token(Token = "0x6000205")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x2CE26F0", Offset = "0x2CE1AF0", Length = "0x10F")]
	[Token(Token = "0x6000208")]
	public int AllocateInstance() { }

	[Address(RVA = "0x2CE2800", Offset = "0x2CE1C00", Length = "0x55")]
	[Token(Token = "0x6000207")]
	public void Dispose() { }

	[Address(RVA = "0x2CE2860", Offset = "0x2CE1C60", Length = "0x43")]
	[Token(Token = "0x6000209")]
	public void FreeInstance(int instance) { }

	[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
	[Token(Token = "0x6000203")]
	public int get_length() { }

	[Address(RVA = "0x2CE29D0", Offset = "0x2CE1DD0", Length = "0x32")]
	[Token(Token = "0x6000205")]
	public bool get_valid() { }

	[Address(RVA = "0x2CE28B0", Offset = "0x2CE1CB0", Length = "0x5B")]
	[Token(Token = "0x600020A")]
	public int GetNumAllocated() { }

	[Address(RVA = "0x2CE2910", Offset = "0x2CE1D10", Length = "0xBA")]
	[Token(Token = "0x6000206")]
	public void Initialize(int baseInstanceOffset = 0, int instanceStride = 1) { }

	[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
	[Token(Token = "0x6000204")]
	public void set_length(int value) { }

}

