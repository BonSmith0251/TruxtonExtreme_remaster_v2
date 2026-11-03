namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000020")]
internal sealed class RestructureBvh : IDisposable
{
	[Token(Token = "0x2000021")]
	private struct ScratchBufferLayout
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AA")]
		public uint LeafParents; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000AB")]
		public uint TreeletCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AC")]
		public uint TreeletRoots; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000AD")]
		public uint PrimitiveCounts; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AE")]
		public uint TotalSize; //Field offset: 0x10

		[Address(RVA = "0x2F604A0", Offset = "0x2F5F8A0", Length = "0x32")]
		[Token(Token = "0x600004E")]
		public static ScratchBufferLayout Create(uint triangleCount) { }

		[Address(RVA = "0x2F60650", Offset = "0x2F5FA50", Length = "0x7")]
		[Token(Token = "0x600004F")]
		private uint Reserve(uint size) { }

	}

	[Token(Token = "0x40000A3")]
	private const int numIterations = 3; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	private const uint kGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x40000A6")]
	private const uint kTrianglesPerThread = 8; //Field offset: 0x0
	[Token(Token = "0x40000A7")]
	private const uint kTrianglesPerGroup = 2048; //Field offset: 0x0
	[Token(Token = "0x40000A8")]
	private const uint kMinPrimitivesPerTreelet = 64; //Field offset: 0x0
	[Token(Token = "0x40000A9")]
	private const int kMaxThreadGroupsPerDispatch = 65535; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009E")]
	private readonly ComputeShader shader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009F")]
	private readonly int kernelInitPrimitiveCounts; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000A0")]
	private readonly int kernelFindTreeletRoots; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A1")]
	private readonly int kernelRestructure; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A2")]
	private readonly int kernelPrepareTreeletsDispatchSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A4")]
	private readonly GraphicsBuffer treeletDispatchIndirectBuffer; //Field offset: 0x28

	[Address(RVA = "0x2F5F3E0", Offset = "0x2F5E7E0", Length = "0x144")]
	[Token(Token = "0x6000048")]
	public RestructureBvh(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5ED20", Offset = "0x2F5E120", Length = "0x181")]
	[Token(Token = "0x600004D")]
	private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer vertices, GraphicsBuffer scratch, BottomLevelLevelAccelStruct result) { }

	[Address(RVA = "0x2F5EEB0", Offset = "0x2F5E2B0", Length = "0x1D")]
	[Token(Token = "0x6000049")]
	public override void Dispose() { }

	[Address(RVA = "0x2F5EED0", Offset = "0x2F5E2D0", Length = "0x4F4")]
	[Token(Token = "0x600004C")]
	public void Execute(CommandBuffer cmd, GraphicsBuffer vertices, int verticesOffset, uint vertexStride, uint triangleCount, GraphicsBuffer scratch, in BottomLevelLevelAccelStruct result) { }

	[Address(RVA = "0x2F5C1B0", Offset = "0x2F5B5B0", Length = "0x4")]
	[Token(Token = "0x600004B")]
	public static uint GetBvhNodeCount(uint leafCount) { }

	[Address(RVA = "0x2F5F3D0", Offset = "0x2F5E7D0", Length = "0x4")]
	[Token(Token = "0x600004A")]
	public ulong GetScratchDataSizeInDwords(uint triangleCount) { }

}

