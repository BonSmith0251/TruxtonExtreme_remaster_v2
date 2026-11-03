namespace UnityEngine.Rendering;

[Token(Token = "0x20000D1")]
internal class OcclusionCullingCommon : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20000D9")]
	private sealed class <>c
	{
		[Token(Token = "0x40003ED")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003EE")]
		public static BaseRenderFunc<OcclusionTestOverlaySetupPassData, ComputeGraphContext> <>9__29_0; //Field offset: 0x8
		[Token(Token = "0x40003EF")]
		public static BaseRenderFunc<OccluderOverlayPassData, RasterGraphContext> <>9__32_0; //Field offset: 0x10
		[Token(Token = "0x40003F0")]
		public static BaseRenderFunc<UpdateOccludersPassData, ComputeGraphContext> <>9__37_0; //Field offset: 0x18

		[Address(RVA = "0x2D040A0", Offset = "0x2D034A0", Length = "0x67")]
		[Token(Token = "0x6000378")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000379")]
		public <>c() { }

		[Address(RVA = "0x2D03980", Offset = "0x2D02D80", Length = "0x1D3")]
		[Token(Token = "0x600037B")]
		internal void <RenderDebugOccluderOverlay>b__32_0(OccluderOverlayPassData data, RasterGraphContext ctx) { }

		[Address(RVA = "0x2D03B60", Offset = "0x2D02F60", Length = "0x238")]
		[Token(Token = "0x600037A")]
		internal void <RenderDebugOcclusionTestOverlay>b__29_0(OcclusionTestOverlaySetupPassData data, ComputeGraphContext ctx) { }

		[Address(RVA = "0x2D03DA0", Offset = "0x2D031A0", Length = "0x2FA")]
		[Token(Token = "0x600037C")]
		internal void <UpdateInstanceOccluders>b__37_0(UpdateOccludersPassData data, ComputeGraphContext context) { }

	}

	[Token(Token = "0x20000D6")]
	private struct DebugOccluderViewData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003E2")]
		public int passIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003E3")]
		public Rect viewport; //Field offset: 0x4
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40003E4")]
		public bool valid; //Field offset: 0x14

	}

	[Token(Token = "0x20000D2")]
	private struct OccluderContextSlot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D9")]
		public bool valid; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003DA")]
		public int lastUsedFrameIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003DB")]
		public int viewInstanceID; //Field offset: 0x8

	}

	[Token(Token = "0x20000D7")]
	private class OccluderOverlayPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E5")]
		public Material debugMaterial; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E6")]
		public RTHandle occluderTexture; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003E7")]
		public Rect viewport; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003E8")]
		public int passIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40003E9")]
		public Vector2 validRange; //Field offset: 0x34

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000376")]
		public OccluderOverlayPassData() { }

	}

	[Token(Token = "0x20000D5")]
	private class OcclusionTestOverlayPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E1")]
		public BufferHandle debugPyramid; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000375")]
		public OcclusionTestOverlayPassData() { }

	}

	[Token(Token = "0x20000D4")]
	private class OcclusionTestOverlaySetupPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E0")]
		public OcclusionCullingDebugShaderVariables cb; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000374")]
		public OcclusionTestOverlaySetupPassData() { }

	}

	[Token(Token = "0x20000D3")]
	private static class ShaderIDs
	{
		[Token(Token = "0x40003DC")]
		public static readonly int OcclusionCullingCommonShaderVariables; //Field offset: 0x0
		[Token(Token = "0x40003DD")]
		public static readonly int _OccluderDepthPyramid; //Field offset: 0x4
		[Token(Token = "0x40003DE")]
		public static readonly int _OcclusionDebugOverlay; //Field offset: 0x8
		[Token(Token = "0x40003DF")]
		public static readonly int OcclusionCullingDebugShaderVariables; //Field offset: 0xC

		[Address(RVA = "0x2D02820", Offset = "0x2D01C20", Length = "0xD0")]
		[Token(Token = "0x6000373")]
		private static ShaderIDs() { }

	}

	[Token(Token = "0x20000D8")]
	private class UpdateOccludersPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003EA")]
		public OccluderParameters occluderParams; //Field offset: 0x10
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003EB")]
		public List<OccluderSubviewUpdate> occluderSubviewUpdates; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003EC")]
		public OccluderHandles occluderHandles; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000377")]
		public UpdateOccludersPassData() { }

	}

	[Token(Token = "0x40003C5")]
	private static readonly int s_MaxContextGCFrame; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C6")]
	private Material m_DebugOcclusionTestMaterial; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C7")]
	private Material m_OccluderDebugViewMaterial; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C8")]
	private ComputeShader m_OcclusionDebugCS; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003C9")]
	private int m_ClearOcclusionDebugKernel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003CA")]
	private ComputeShader m_OccluderDepthPyramidCS; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003CB")]
	private int m_OccluderDepthDownscaleKernel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003CC")]
	private int m_FrameIndex; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003CD")]
	private SilhouettePlaneCache m_SilhouettePlaneCache; //Field offset: 0x40
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003CE")]
	private NativeParallelHashMap<Int32, Int32> m_ViewIDToIndexMap; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003CF")]
	private List<OccluderContext> m_OccluderContextData; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003D0")]
	private NativeList<OccluderContextSlot> m_OccluderContextSlots; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003D1")]
	private NativeList<Int32> m_FreeOccluderContexts; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003D2")]
	private NativeArray<OcclusionCullingCommonShaderVariables> m_CommonShaderVariables; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003D3")]
	private ComputeBuffer m_CommonConstantBuffer; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40003D4")]
	private NativeArray<OcclusionCullingDebugShaderVariables> m_DebugShaderVariables; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40003D5")]
	private ComputeBuffer m_DebugConstantBuffer; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40003D6")]
	private ProfilingSampler m_ProfilingSamplerUpdateOccluders; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40003D7")]
	private ProfilingSampler m_ProfilingSamplerOcclusionTestOverlay; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40003D8")]
	private ProfilingSampler m_ProfilingSamplerOccluderOverlay; //Field offset: 0xD0

	[Address(RVA = "0x2CFD890", Offset = "0x2CFCC90", Length = "0x39")]
	[Token(Token = "0x6000371")]
	private static OcclusionCullingCommon() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000370")]
	public OcclusionCullingCommon() { }

	[Address(RVA = "0x2CFC6E0", Offset = "0x2CFBAE0", Length = "0x12A")]
	[CompilerGenerated]
	[Token(Token = "0x6000372")]
	private void <RenderDebugOcclusionTestOverlay>b__29_1(OcclusionTestOverlayPassData data, RasterGraphContext ctx) { }

	[Address(RVA = "0x2CF9D50", Offset = "0x2CF9150", Length = "0x29B")]
	[Token(Token = "0x6000365")]
	private void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles) { }

	[Address(RVA = "0x2CF9FF0", Offset = "0x2CF93F0", Length = "0x23E")]
	[Token(Token = "0x600036E")]
	private void DeleteContext(int viewInstanceID) { }

	[Address(RVA = "0x2CFA230", Offset = "0x2CF9630", Length = "0x2B1")]
	[Token(Token = "0x6000363")]
	private void DispatchDebugClear(ComputeCommandBuffer cmd, int viewInstanceID) { }

	[Address(RVA = "0x2CFA4F0", Offset = "0x2CF98F0", Length = "0x343")]
	[Token(Token = "0x600036F")]
	public override void Dispose() { }

	[Address(RVA = "0x2CFA840", Offset = "0x2CF9C40", Length = "0x199")]
	[Token(Token = "0x600036B")]
	internal bool GetOccluderContext(int viewInstanceID, out OccluderContext occluderContext) { }

	[Address(RVA = "0x2CFA9E0", Offset = "0x2CF9DE0", Length = "0x1E8")]
	[Token(Token = "0x6000368")]
	internal OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID) { }

	[Address(RVA = "0x2CFABD0", Offset = "0x2CF9FD0", Length = "0x47")]
	[Token(Token = "0x600036A")]
	internal bool HasOccluderContext(int viewInstanceID) { }

	[Address(RVA = "0x2CFAC20", Offset = "0x2CFA020", Length = "0x445")]
	[Token(Token = "0x600035C")]
	internal void Init(GPUResidentDrawerResources resources) { }

	[Address(RVA = "0x2CFB070", Offset = "0x2CFA470", Length = "0x346")]
	[Token(Token = "0x600036D")]
	private int NewContext(int viewInstanceID) { }

	[Address(RVA = "0x2CFB3C0", Offset = "0x2CFA7C0", Length = "0x24F")]
	[Token(Token = "0x600035E")]
	internal void PrepareCulling(ComputeCommandBuffer cmd, in OccluderContext occluderCtx, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in OcclusionTestComputeShader shader, bool useOcclusionDebug) { }

	[Address(RVA = "0x2CFB610", Offset = "0x2CFAA10", Length = "0x226")]
	[Token(Token = "0x6000364")]
	private OccluderHandles PrepareOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams) { }

	[Address(RVA = "0x2CFB840", Offset = "0x2CFAC40", Length = "0x544")]
	[Token(Token = "0x6000362")]
	public void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, in TextureHandle colorBuffer) { }

	[Address(RVA = "0x2CFBD90", Offset = "0x2CFB190", Length = "0x797")]
	[Token(Token = "0x6000361")]
	public void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, in TextureHandle colorBuffer) { }

	[Address(RVA = "0x2CFC530", Offset = "0x2CFB930", Length = "0xEE")]
	[Token(Token = "0x6000360")]
	internal static void SetDebugPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles) { }

	[Address(RVA = "0x2CFC620", Offset = "0x2CFBA20", Length = "0xB2")]
	[Token(Token = "0x600035F")]
	internal static void SetDepthPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles) { }

	[Address(RVA = "0x2CFC810", Offset = "0x2CFBC10", Length = "0x272")]
	[Token(Token = "0x600036C")]
	internal void UpdateFrame() { }

	[Address(RVA = "0x2CFCA90", Offset = "0x2CFBE90", Length = "0xA2A")]
	[Token(Token = "0x6000366")]
	public bool UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

	[Address(RVA = "0x2CFD4C0", Offset = "0x2CFC8C0", Length = "0x38C")]
	[Token(Token = "0x6000369")]
	public void UpdateOccluderStats(DebugRendererBatcherStats debugStats) { }

	[Address(RVA = "0x2CFD850", Offset = "0x2CFCC50", Length = "0x2D")]
	[Token(Token = "0x6000367")]
	internal void UpdateSilhouettePlanes(int viewInstanceID, NativeArray<Plane> planes) { }

	[Address(RVA = "0x2CFD880", Offset = "0x2CFCC80", Length = "0x8")]
	[Token(Token = "0x600035D")]
	internal static bool UseOcclusionDebug(in OccluderContext occluderCtx) { }

}

