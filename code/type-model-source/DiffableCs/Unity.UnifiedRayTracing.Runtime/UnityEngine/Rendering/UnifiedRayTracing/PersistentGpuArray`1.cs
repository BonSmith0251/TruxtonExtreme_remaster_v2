namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000043")]
internal sealed class PersistentGpuArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018D")]
	private BlockAllocator m_SlotAllocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018E")]
	private ComputeBuffer m_GpuBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018F")]
	private NativeArray<Tstruct> m_CpuList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000190")]
	private BitArray m_Updates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000191")]
	private bool m_gpuBufferDirty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000192")]
	private int m_ElementCount; //Field offset: 0x0

	[Token(Token = "0x1700001D")]
	public int elementCount
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xE226B0", Offset = "0xE21AB0", Length = "0x15A")]
	[Token(Token = "0x60000EB")]
	public PersistentGpuArray`1(int initialSize) { }

	[Address(RVA = "0xE21210", Offset = "0xE20610", Length = "0x19F")]
	[Token(Token = "0x60000ED")]
	public Allocation Add(Tstruct element) { }

	[Address(RVA = "0xE21120", Offset = "0xE20520", Length = "0xEB")]
	[Token(Token = "0x60000EE")]
	public Allocation[] Add(int elementCount) { }

	[Address(RVA = "0xE216D0", Offset = "0xE20AD0", Length = "0x9C")]
	[Token(Token = "0x60000F0")]
	public void Clear() { }

	[Address(RVA = "0xE21770", Offset = "0xE20B70", Length = "0x5A")]
	[Token(Token = "0x60000EC")]
	public override void Dispose() { }

	[Address(RVA = "0xE21B10", Offset = "0xE20F10", Length = "0xBE")]
	[Token(Token = "0x60000F2")]
	public Tstruct Get(Allocation allocation) { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60000EA")]
	public int get_elementCount() { }

	[Address(RVA = "0xE21830", Offset = "0xE20C30", Length = "0x16A")]
	[Token(Token = "0x60000F4")]
	public ComputeBuffer GetGpuBuffer(CommandBuffer cmd) { }

	[Address(RVA = "0xE21C70", Offset = "0xE21070", Length = "0x227")]
	[Token(Token = "0x60000F5")]
	private void Grow() { }

	[Address(RVA = "0xE22300", Offset = "0xE21700", Length = "0x1CB")]
	[Token(Token = "0x60000F3")]
	public void ModifyForEach(Func<Tstruct, Tstruct> lambda) { }

	[Address(RVA = "0xE224D0", Offset = "0xE218D0", Length = "0x18")]
	[Token(Token = "0x60000EF")]
	public void Remove(Allocation allocation) { }

	[Address(RVA = "0xE224F0", Offset = "0xE218F0", Length = "0xDE")]
	[Token(Token = "0x60000F1")]
	public void Set(Allocation allocation, Tstruct element) { }

}

