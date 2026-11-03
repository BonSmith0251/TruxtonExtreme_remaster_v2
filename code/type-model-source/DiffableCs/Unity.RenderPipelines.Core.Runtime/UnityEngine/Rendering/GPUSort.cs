namespace UnityEngine.Rendering;

[Token(Token = "0x20001CE")]
public struct GPUSort
{
	[Token(Token = "0x20001D0")]
	internal struct Args
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000909")]
		public uint count; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400090A")]
		public uint maxDepth; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400090B")]
		public GraphicsBuffer inputKeys; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400090C")]
		public GraphicsBuffer inputValues; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400090D")]
		public SupportResources resources; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400090E")]
		internal int workGroupCount; //Field offset: 0x28

	}

	[Token(Token = "0x20001D1")]
	internal struct RenderGraphResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400090F")]
		public BufferHandle sortBufferKeys; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000910")]
		public BufferHandle sortBufferValues; //Field offset: 0xC

		[Address(RVA = "0x2C63940", Offset = "0x2C62D40", Length = "0x128")]
		[Obsolete("This Create signature is deprecated and will be removed in the future. Please use Create(IBaseRenderGraphBuilder) instead. #from(6000.3)")]
		[Token(Token = "0x6000E2A")]
		public static RenderGraphResources Create(int count, RenderGraph renderGraph, RenderGraphBuilder builder) { }

		[Address(RVA = "0x2C63A70", Offset = "0x2C62E70", Length = "0x231")]
		[Token(Token = "0x6000E2B")]
		public static RenderGraphResources Create(int count, RenderGraph renderGraph, IBaseRenderGraphBuilder builder) { }

	}

	[Token(Token = "0x20001CF")]
	private enum Stage : int
	{
		LocalBMS = 0,
		LocalDisperse = 1,
		BigFlip = 2,
		BigDisperse = 3,
	}

	[Token(Token = "0x20001D2")]
	internal struct SupportResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000911")]
		public GraphicsBuffer sortBufferKeys; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000912")]
		public GraphicsBuffer sortBufferValues; //Field offset: 0x8

		[Address(RVA = "0x2C64EC0", Offset = "0x2C642C0", Length = "0x5A")]
		[Token(Token = "0x6000E2D")]
		public void Dispose() { }

		[Address(RVA = "0x2C651D0", Offset = "0x2C645D0", Length = "0xDB")]
		[Token(Token = "0x6000E2C")]
		public static SupportResources Load(RenderGraphResources renderGraphResources) { }

	}

	[Token(Token = "0x20001D3")]
	internal struct SystemResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000913")]
		public ComputeShader computeAsset; //Field offset: 0x0

	}

	[Token(Token = "0x4000901")]
	private const uint kWorkGroupSize = 1024; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000902")]
	private LocalKeyword[] m_Keywords; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000903")]
	private SystemResources resources; //Field offset: 0x8

	[Address(RVA = "0x2C5D3B0", Offset = "0x2C5C7B0", Length = "0x1F6")]
	[Token(Token = "0x6000E24")]
	public GPUSort(SystemResources resources) { }

	[Address(RVA = "0x2C5CC30", Offset = "0x2C5C030", Length = "0x1CA")]
	[Token(Token = "0x6000E26")]
	private void CopyBuffer(CommandBuffer cmd, GraphicsBuffer src, GraphicsBuffer dst) { }

	[Address(RVA = "0x2C5D300", Offset = "0x2C5C700", Length = "0xA2")]
	[Token(Token = "0x6000E28")]
	public void Dispatch(IComputeCommandBuffer cmd, Args args) { }

	[Address(RVA = "0x2C5D090", Offset = "0x2C5C490", Length = "0x270")]
	[Token(Token = "0x6000E29")]
	public void Dispatch(CommandBuffer cmd, Args args) { }

	[Address(RVA = "0x2C5CE00", Offset = "0x2C5C200", Length = "0x28A")]
	[Token(Token = "0x6000E25")]
	private void DispatchStage(CommandBuffer cmd, Args args, uint h, Stage stage) { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x6000E27")]
	internal static int DivRoundUp(int x, int y) { }

}

