namespace UnityEngine.Rendering;

[Token(Token = "0x20001C5")]
public struct GPUPrefixSum
{
	[Token(Token = "0x20001CA")]
	internal struct DirectArgs
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008E7")]
		public bool exclusive; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008E8")]
		public int inputCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008E9")]
		public GraphicsBuffer input; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008EA")]
		public SupportResources supportResources; //Field offset: 0x10

	}

	[Token(Token = "0x20001CB")]
	internal struct IndirectDirectArgs
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EB")]
		public bool exclusive; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008EC")]
		public int inputCountBufferByteOffset; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008ED")]
		public ComputeBuffer inputCountBuffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008EE")]
		public GraphicsBuffer input; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008EF")]
		public SupportResources supportResources; //Field offset: 0x18

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
	[Token(Token = "0x20001C7")]
	internal struct LevelOffsets
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008D3")]
		public uint count; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008D4")]
		public uint offset; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008D5")]
		public uint parentOffset; //Field offset: 0x8

	}

	[Token(Token = "0x20001C8")]
	internal struct RenderGraphResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008D6")]
		internal int alignedElementCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008D7")]
		internal int maxBufferCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008D8")]
		internal int maxLevelCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40008D9")]
		internal BufferHandle prefixBuffer0; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008DA")]
		internal BufferHandle prefixBuffer1; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40008DB")]
		internal BufferHandle totalLevelCountBuffer; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008DC")]
		internal BufferHandle levelOffsetBuffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40008DD")]
		internal BufferHandle indirectDispatchArgsBuffer; //Field offset: 0x3C

		[Token(Token = "0x170001C9")]
		public BufferHandle output
		{
			[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
			[Token(Token = "0x6000E16")]
			 get { } //Length: 19
		}

		[Address(RVA = "0x2C63CF0", Offset = "0x2C630F0", Length = "0x58")]
		[Obsolete("This Create signature is deprecated and will be removed in the future. Please use Create(IBaseRenderGraphBuilder) instead. #from(6000.3)")]
		[Token(Token = "0x6000E17")]
		public static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false) { }

		[Address(RVA = "0x2C63CB0", Offset = "0x2C630B0", Length = "0x3D")]
		[Token(Token = "0x6000E19")]
		public static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, IBaseRenderGraphBuilder builder, bool outputIsTemp = false) { }

		[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
		[Token(Token = "0x6000E16")]
		public BufferHandle get_output() { }

		[Address(RVA = "0x2C64340", Offset = "0x2C63740", Length = "0x376")]
		[Token(Token = "0x6000E18")]
		private void Initialize(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false) { }

		[Address(RVA = "0x2C63D50", Offset = "0x2C63150", Length = "0x5E8")]
		[Token(Token = "0x6000E1A")]
		private void Initialize(int newMaxElementCount, RenderGraph renderGraph, IBaseRenderGraphBuilder builder, bool outputIsTemp = false) { }

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
	[Token(Token = "0x20001C6")]
	public static class ShaderDefs
	{
		[Token(Token = "0x40008CF")]
		public const int GroupSize = 128; //Field offset: 0x0
		[Token(Token = "0x40008D0")]
		public const int ArgsBufferStride = 16; //Field offset: 0x0
		[Token(Token = "0x40008D1")]
		public const int ArgsBufferUpper = 0; //Field offset: 0x0
		[Token(Token = "0x40008D2")]
		public const int ArgsBufferLower = 8; //Field offset: 0x0

		[Address(RVA = "0x2C649F0", Offset = "0x2C63DF0", Length = "0xD")]
		[Token(Token = "0x6000E14")]
		public static int AlignUpGroup(int value) { }

		[Address(RVA = "0x2C64A00", Offset = "0x2C63E00", Length = "0x37")]
		[Token(Token = "0x6000E15")]
		public static void CalculateTotalBufferSize(int maxElementCount, out int totalSize, out int levelCounts) { }

		[Address(RVA = "0x2C12A40", Offset = "0x2C11E40", Length = "0xD")]
		[Token(Token = "0x6000E13")]
		public static int DivUpGroup(int value) { }

	}

	[Token(Token = "0x20001CD")]
	private static class ShaderIDs
	{
		[Token(Token = "0x40008F8")]
		public static readonly int _InputBuffer; //Field offset: 0x0
		[Token(Token = "0x40008F9")]
		public static readonly int _OutputBuffer; //Field offset: 0x4
		[Token(Token = "0x40008FA")]
		public static readonly int _InputCountBuffer; //Field offset: 0x8
		[Token(Token = "0x40008FB")]
		public static readonly int _TotalLevelsBuffer; //Field offset: 0xC
		[Token(Token = "0x40008FC")]
		public static readonly int _OutputTotalLevelsBuffer; //Field offset: 0x10
		[Token(Token = "0x40008FD")]
		public static readonly int _OutputDispatchLevelArgsBuffer; //Field offset: 0x14
		[Token(Token = "0x40008FE")]
		public static readonly int _LevelsOffsetsBuffer; //Field offset: 0x18
		[Token(Token = "0x40008FF")]
		public static readonly int _OutputLevelsOffsetsBuffer; //Field offset: 0x1C
		[Token(Token = "0x4000900")]
		public static readonly int _PrefixSumIntArgs; //Field offset: 0x20

		[Address(RVA = "0x2C64A40", Offset = "0x2C63E40", Length = "0x1A7")]
		[Token(Token = "0x6000E23")]
		private static ShaderIDs() { }

	}

	[Token(Token = "0x20001C9")]
	internal struct SupportResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DE")]
		internal bool ownsResources; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40008DF")]
		internal int alignedElementCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008E0")]
		internal int maxBufferCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40008E1")]
		internal int maxLevelCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008E2")]
		internal GraphicsBuffer prefixBuffer0; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008E3")]
		internal GraphicsBuffer prefixBuffer1; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008E4")]
		internal GraphicsBuffer totalLevelCountBuffer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008E5")]
		internal GraphicsBuffer levelOffsetBuffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008E6")]
		internal GraphicsBuffer indirectDispatchArgsBuffer; //Field offset: 0x30

		[Token(Token = "0x170001CA")]
		public GraphicsBuffer output
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000E1B")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2C57430", Offset = "0x2C56830", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000E21")]
		internal static void <Dispose>g__TryFreeBuffer|15_0(GraphicsBuffer resource) { }

		[Address(RVA = "0x2C64DF0", Offset = "0x2C641F0", Length = "0x49")]
		[Token(Token = "0x6000E1C")]
		public static SupportResources Create(int maxElementCount) { }

		[Address(RVA = "0x2C64E40", Offset = "0x2C64240", Length = "0x71")]
		[Token(Token = "0x6000E20")]
		public void Dispose() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E1B")]
		public GraphicsBuffer get_output() { }

		[Address(RVA = "0x2C65160", Offset = "0x2C64560", Length = "0x6D")]
		[Token(Token = "0x6000E1D")]
		public static SupportResources Load(RenderGraphResources shaderGraphResources) { }

		[Address(RVA = "0x2C64F20", Offset = "0x2C64320", Length = "0x240")]
		[Token(Token = "0x6000E1F")]
		private void LoadFromShaderGraph(RenderGraphResources shaderGraphResources) { }

		[Address(RVA = "0x2C652B0", Offset = "0x2C646B0", Length = "0x298")]
		[Token(Token = "0x6000E1E")]
		internal void Resize(int newMaxElementCount) { }

	}

	[Token(Token = "0x20001CC")]
	internal struct SystemResources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F0")]
		public ComputeShader computeAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008F1")]
		internal int kernelCalculateLevelDispatchArgsFromConst; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40008F2")]
		internal int kernelCalculateLevelDispatchArgsFromBuffer; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008F3")]
		internal int kernelPrefixSumOnGroup; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40008F4")]
		internal int kernelPrefixSumOnGroupExclusive; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008F5")]
		internal int kernelPrefixSumNextInput; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40008F6")]
		internal int kernelPrefixSumResolveParent; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008F7")]
		internal int kernelPrefixSumResolveParentExclusive; //Field offset: 0x20

		[Address(RVA = "0x2C65E50", Offset = "0x2C65250", Length = "0x17C")]
		[Token(Token = "0x6000E22")]
		internal void LoadKernels() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CE")]
	private SystemResources resources; //Field offset: 0x0

	[Address(RVA = "0x2C5CBF0", Offset = "0x2C5BFF0", Length = "0x37")]
	[Token(Token = "0x6000E0C")]
	public GPUPrefixSum(SystemResources resources) { }

	[Address(RVA = "0x2C5C040", Offset = "0x2C5B440", Length = "0x86")]
	[Token(Token = "0x6000E0F")]
	public void DispatchDirect(IComputeCommandBuffer cmdBuffer, in DirectArgs arguments) { }

	[Address(RVA = "0x2C5C0D0", Offset = "0x2C5B4D0", Length = "0x2BA")]
	[Token(Token = "0x6000E10")]
	public void DispatchDirect(CommandBuffer cmdBuffer, in DirectArgs arguments) { }

	[Address(RVA = "0x2C5C640", Offset = "0x2C5BA40", Length = "0x86")]
	[Token(Token = "0x6000E11")]
	public void DispatchIndirect(IComputeCommandBuffer cmdBuffer, in IndirectDirectArgs arguments) { }

	[Address(RVA = "0x2C5C390", Offset = "0x2C5B790", Length = "0x2A4")]
	[Token(Token = "0x6000E12")]
	public void DispatchIndirect(CommandBuffer cmdBuffer, in IndirectDirectArgs arguments) { }

	[Address(RVA = "0x2C5C6D0", Offset = "0x2C5BAD0", Length = "0x4E2")]
	[Token(Token = "0x6000E0E")]
	internal void ExecuteCommonIndirect(CommandBuffer cmdBuffer, GraphicsBuffer inputBuffer, in SupportResources supportResources, bool isExclusive) { }

	[Address(RVA = "0x2C5CBC0", Offset = "0x2C5BFC0", Length = "0x21")]
	[Token(Token = "0x6000E0D")]
	private Vector4 PackPrefixSumArgs(int a, int b, int c, int d) { }

}

