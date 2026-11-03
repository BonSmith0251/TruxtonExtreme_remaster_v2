namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000046")]
internal sealed class BLASPositionsPool : IDisposable
{
	[Token(Token = "0x4000198")]
	public const int VertexSizeInDwords = 3; //Field offset: 0x0
	[Token(Token = "0x4000199")]
	private const int intialVertexCount = 1000; //Field offset: 0x0
	[Token(Token = "0x400019F")]
	private const uint kItemsPerWorkgroup = 6144; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400019A")]
	private GraphicsBuffer m_VerticesBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400019B")]
	private BlockAllocator m_VerticesAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019C")]
	private readonly ComputeShader m_CopyPositionsShader; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019D")]
	private readonly int m_CopyVerticesKernel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400019E")]
	private readonly ComputeShader m_CopyShader; //Field offset: 0x48

	[Token(Token = "0x1700001E")]
	public GraphicsBuffer VertexBuffer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F50280", Offset = "0x2F4F680", Length = "0x100")]
	[Token(Token = "0x60000FA")]
	public BLASPositionsPool(ComputeShader copyPositionsShader, ComputeShader copyShader) { }

	[Address(RVA = "0x2F4FC50", Offset = "0x2F4F050", Length = "0x4B6")]
	[Token(Token = "0x60000FE")]
	public void Add(VertexBufferChunk info, out Allocation verticesAllocation) { }

	[Address(RVA = "0x2F50110", Offset = "0x2F4F510", Length = "0xB1")]
	[Token(Token = "0x60000FD")]
	public void Clear() { }

	[Address(RVA = "0x2F501D0", Offset = "0x2F4F5D0", Length = "0x2E")]
	[Token(Token = "0x60000FB")]
	public override void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000FC")]
	public GraphicsBuffer get_VertexBuffer() { }

	[Address(RVA = "0x2F50200", Offset = "0x2F4F600", Length = "0x7A")]
	[Token(Token = "0x60000FF")]
	public void Remove(ref Allocation verticesAllocation) { }

}

