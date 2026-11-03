namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000A2")]
public abstract class ScriptableRenderer : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20000AF")]
	private sealed class <>c
	{
		[Token(Token = "0x4000374")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000375")]
		public static BaseRenderFunc<PassData, UnsafeGraphContext> <>9__98_0; //Field offset: 0x8
		[Token(Token = "0x4000376")]
		public static BaseRenderFunc<VFXProcessCameraPassData, UnsafeGraphContext> <>9__100_0; //Field offset: 0x10
		[Token(Token = "0x4000377")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__101_0; //Field offset: 0x18
		[Token(Token = "0x4000378")]
		public static BaseRenderFunc<BeginXRPassData, RasterGraphContext> <>9__107_0; //Field offset: 0x20
		[Token(Token = "0x4000379")]
		public static BaseRenderFunc<EndXRPassData, RasterGraphContext> <>9__109_0; //Field offset: 0x28
		[Token(Token = "0x400037A")]
		public static BaseRenderFunc<DummyData, UnsafeGraphContext> <>9__111_0; //Field offset: 0x30

		[Address(RVA = "0x2D89980", Offset = "0x2D88D80", Length = "0x67")]
		[Token(Token = "0x6000423")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000424")]
		public <>c() { }

		[Address(RVA = "0x2D88500", Offset = "0x2D87900", Length = "0x1D8")]
		[Token(Token = "0x6000428")]
		internal void <BeginRenderGraphXRRendering>b__107_0(BeginXRPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D886E0", Offset = "0x2D87AE0", Length = "0x18F")]
		[Token(Token = "0x6000429")]
		internal void <EndRenderGraphXRRendering>b__109_0(EndXRPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D88870", Offset = "0x2D87C70", Length = "0xB6")]
		[Token(Token = "0x6000425")]
		internal void <InitRenderGraphFrame>b__98_0(PassData data, UnsafeGraphContext rgContext) { }

		[Address(RVA = "0x2D88930", Offset = "0x2D87D30", Length = "0x138")]
		[Token(Token = "0x6000426")]
		internal void <ProcessVFXCameraCommand>b__100_0(VFXProcessCameraPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2D89170", Offset = "0x2D88570", Length = "0xAD")]
		[Token(Token = "0x600042A")]
		internal void <SetEditorTarget>b__111_0(DummyData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2D89220", Offset = "0x2D88620", Length = "0x40B")]
		[Token(Token = "0x6000427")]
		internal void <SetupRenderGraphCameraProperties>b__101_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20000A9")]
	private class BeginXRPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000369")]
		internal UniversalCameraData cameraData; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000415")]
		public BeginXRPassData() { }

	}

	[Token(Token = "0x20000A7")]
	private class DrawGizmosPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000365")]
		public RendererListHandle gizmoRenderList; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000366")]
		public TextureHandle color; //Field offset: 0x1C
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000367")]
		public TextureHandle depth; //Field offset: 0x2C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000413")]
		public DrawGizmosPassData() { }

	}

	[Token(Token = "0x20000A8")]
	private class DrawWireOverlayPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000368")]
		public RendererListHandle wireOverlayList; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000414")]
		public DrawWireOverlayPassData() { }

	}

	[Token(Token = "0x20000AB")]
	private class DummyData
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000417")]
		public DummyData() { }

	}

	[Token(Token = "0x20000AA")]
	private class EndXRPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036A")]
		public UniversalCameraData cameraData; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000416")]
		public EndXRPassData() { }

	}

	[Token(Token = "0x20000AC")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036B")]
		internal ScriptableRenderer renderer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036C")]
		internal UniversalCameraData cameraData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400036D")]
		internal TextureHandle target; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400036E")]
		internal Vector2Int cameraTargetSizeCopy; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000418")]
		public PassData() { }

	}

	[Token(Token = "0x20000A3")]
	private static class Profiling
	{
		[Token(Token = "0x400034C")]
		private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
		[Token(Token = "0x400034D")]
		public static readonly ProfilingSampler setPerCameraShaderVariables; //Field offset: 0x0
		[Token(Token = "0x400034E")]
		public static readonly ProfilingSampler sortRenderPasses; //Field offset: 0x8
		[Token(Token = "0x400034F")]
		public static readonly ProfilingSampler recordRenderGraph; //Field offset: 0x10
		[Token(Token = "0x4000350")]
		public static readonly ProfilingSampler setupCamera; //Field offset: 0x18
		[Token(Token = "0x4000351")]
		public static readonly ProfilingSampler vfxProcessCamera; //Field offset: 0x20
		[Token(Token = "0x4000352")]
		public static readonly ProfilingSampler addRenderPasses; //Field offset: 0x28
		[Token(Token = "0x4000353")]
		public static readonly ProfilingSampler clearRenderingState; //Field offset: 0x30
		[Token(Token = "0x4000354")]
		public static readonly ProfilingSampler internalFinishRenderingCommon; //Field offset: 0x38
		[Token(Token = "0x4000355")]
		public static readonly ProfilingSampler drawGizmos; //Field offset: 0x40
		[Token(Token = "0x4000356")]
		public static readonly ProfilingSampler drawWireOverlay; //Field offset: 0x48
		[Token(Token = "0x4000357")]
		internal static readonly ProfilingSampler beginXRRendering; //Field offset: 0x50
		[Token(Token = "0x4000358")]
		internal static readonly ProfilingSampler endXRRendering; //Field offset: 0x58
		[Token(Token = "0x4000359")]
		internal static readonly ProfilingSampler initRenderGraphFrame; //Field offset: 0x60
		[Token(Token = "0x400035A")]
		internal static readonly ProfilingSampler setEditorTarget; //Field offset: 0x68

		[Address(RVA = "0x2D81220", Offset = "0x2D80620", Length = "0x510")]
		[Token(Token = "0x600040B")]
		private static Profiling() { }

	}

	[Token(Token = "0x20000AD")]
	public struct RenderBlocks : IDisposable
	{
		[Token(Token = "0x20000AE")]
		internal struct BlockRange : IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000372")]
			private int m_Current; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000373")]
			private int m_End; //Field offset: 0x4

			[Token(Token = "0x17000103")]
			public int Current
			{
				[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
				[Token(Token = "0x6000421")]
				 get { } //Length: 3
			}

			[Address(RVA = "0x2D6F2E0", Offset = "0x2D6E6E0", Length = "0x18")]
			[Token(Token = "0x600041E")]
			public BlockRange(int begin, int end) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6000422")]
			public override void Dispose() { }

			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x6000421")]
			public int get_Current() { }

			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x600041F")]
			public BlockRange GetEnumerator() { }

			[Address(RVA = "0x2D6F2D0", Offset = "0x2D6E6D0", Length = "0xB")]
			[Token(Token = "0x6000420")]
			public bool MoveNext() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036F")]
		private NativeArray<RenderPassEvent> m_BlockEventLimits; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000370")]
		private NativeArray<Int32> m_BlockRanges; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000371")]
		private NativeArray<Int32> m_BlockRangeLengths; //Field offset: 0x20

		[Address(RVA = "0x2D818C0", Offset = "0x2D80CC0", Length = "0x2AE")]
		[Token(Token = "0x6000419")]
		public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue) { }

		[Address(RVA = "0x2D81730", Offset = "0x2D80B30", Length = "0x4A")]
		[Token(Token = "0x600041A")]
		public override void Dispose() { }

		[Address(RVA = "0x2D81780", Offset = "0x2D80B80", Length = "0xF6")]
		[Token(Token = "0x600041B")]
		private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue) { }

		[Address(RVA = "0x2CE0FA0", Offset = "0x2CE03A0", Length = "0xB")]
		[Token(Token = "0x600041C")]
		public int GetLength(int index) { }

		[Address(RVA = "0x2D81880", Offset = "0x2D80C80", Length = "0x38")]
		[Token(Token = "0x600041D")]
		public BlockRange GetRange(int index) { }

	}

	[Token(Token = "0x20000A4")]
	internal class RenderingFeatures
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035B")]
		private bool <cameraStacking>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400035C")]
		private bool <msaa>k__BackingField; //Field offset: 0x11

		[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead. #from(2022.2) #breakingFrom(2023.1)", True)]
		[Token(Token = "0x17000101")]
		public bool cameraStacking
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600040C")]
			 get { } //Length: 5
			[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600040D")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000102")]
		public bool msaa
		{
			[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600040E")]
			 get { } //Length: 5
			[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600040F")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x2D81BF0", Offset = "0x2D80FF0", Length = "0xB")]
		[Token(Token = "0x6000410")]
		public RenderingFeatures() { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600040C")]
		public bool get_cameraStacking() { }

		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600040E")]
		public bool get_msaa() { }

		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600040D")]
		public void set_cameraStacking(bool value) { }

		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600040F")]
		public void set_msaa(bool value) { }

	}

	[Token(Token = "0x20000A5")]
	private static class RenderPassBlock
	{
		[Token(Token = "0x400035D")]
		public static readonly int BeforeRendering; //Field offset: 0x0
		[Token(Token = "0x400035E")]
		public static readonly int MainRenderingOpaque; //Field offset: 0x4
		[Token(Token = "0x400035F")]
		public static readonly int MainRenderingTransparent; //Field offset: 0x8
		[Token(Token = "0x4000360")]
		public static readonly int AfterRendering; //Field offset: 0xC

		[Address(RVA = "0x2D81B70", Offset = "0x2D80F70", Length = "0x78")]
		[Token(Token = "0x6000411")]
		private static RenderPassBlock() { }

	}

	[Token(Token = "0x20000A6")]
	private class VFXProcessCameraPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000361")]
		internal UniversalRenderingData renderingData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000362")]
		internal Camera camera; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000363")]
		internal VFXCameraXRSettings cameraXRSettings; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000364")]
		internal XRPass xrPass; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000412")]
		public VFXProcessCameraPassData() { }

	}

	[Token(Token = "0x400032F")]
	internal static ScriptableRenderer current; //Field offset: 0x0
	[Token(Token = "0x4000334")]
	private const int k_RenderPassBlockCount = 4; //Field offset: 0x0
	[Token(Token = "0x4000333")]
	private static bool m_UseOptimizedStoreActions; //Field offset: 0x8
	[Token(Token = "0x4000335")]
	protected static readonly RTHandle k_CameraTarget; //Field offset: 0x10
	[Token(Token = "0x400033F")]
	private static RenderTargetIdentifier[] m_ActiveColorAttachmentIDs; //Field offset: 0x18
	[Token(Token = "0x4000340")]
	private static RTHandle[] m_ActiveColorAttachments; //Field offset: 0x20
	[Token(Token = "0x4000341")]
	private static RTHandle m_ActiveDepthAttachment; //Field offset: 0x28
	[Token(Token = "0x4000343")]
	private static RenderBufferStoreAction[] m_ActiveColorStoreActions; //Field offset: 0x30
	[Token(Token = "0x4000344")]
	private static RenderBufferStoreAction m_ActiveDepthStoreAction; //Field offset: 0x38
	[Token(Token = "0x4000345")]
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopyIDs; //Field offset: 0x40
	[Token(Token = "0x4000346")]
	private static RTHandle[][] m_TrimmedColorAttachmentCopies; //Field offset: 0x48
	[Token(Token = "0x4000347")]
	private static Plane[] s_Planes; //Field offset: 0x50
	[Token(Token = "0x4000348")]
	private static Vector4[] s_VectorPlanes; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400032C")]
	private ProfilingSampler <profilingExecute>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400032D")]
	internal bool hasReleasedRTs; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400032E")]
	private readonly DebugHandler <DebugHandler>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000330")]
	private RenderingFeatures <supportedRenderingFeatures>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000331")]
	private GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000332")]
	private StoreActionsOptimization m_StoreActionsOptimizationSetting; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000336")]
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000337")]
	private List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000338")]
	private RTHandle m_CameraColorTarget; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000339")]
	private RTHandle m_CameraDepthTarget; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400033A")]
	private RTHandle m_CameraResolveTarget; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400033B")]
	private bool m_FirstTimeCameraColorTargetIsBound; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400033C")]
	private bool m_FirstTimeCameraDepthTargetIsBound; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x400033D")]
	private bool m_IsPipelineExecuting; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x400033E")]
	internal bool useRenderPassEnabled; //Field offset: 0x6B
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000342")]
	private ContextContainer m_frameData; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000349")]
	private bool <useDepthPriming>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x400034A")]
	private bool <stripShadowsOffVariants>k__BackingField; //Field offset: 0x79
	[CompilerGenerated]
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x400034B")]
	private bool <stripAdditionalLightOffVariants>k__BackingField; //Field offset: 0x7A

	[Token(Token = "0x170000F8")]
	protected List<ScriptableRenderPass> activeRenderPassQueue
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 5
	}

	[Obsolete("Use cameraColorTargetHandle. #from(2022.1) #breakingFrom(2023.2)", True)]
	[Token(Token = "0x170000F6")]
	public RenderTargetIdentifier cameraColorTarget
	{
		[Address(RVA = "0x2D88470", Offset = "0x2D87870", Length = "0x4E")]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 78
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000F3")]
	public RTHandle cameraColorTargetHandle
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60003C0")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003C1")]
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("cameraDepth has been renamed to cameraDepthTarget. #from(2021.1) #breakingFrom(2023.1) (UnityUpgradable) -> cameraDepthTarget", True)]
	[Token(Token = "0x170000F1")]
	public RenderTargetIdentifier cameraDepth
	{
		[Address(RVA = "0x2D884C0", Offset = "0x2D878C0", Length = "0x33")]
		[Token(Token = "0x60003BB")]
		 get { } //Length: 51
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000F4")]
	public RTHandle cameraDepthTargetHandle
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60003C2")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003C3")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170000F5")]
	internal DebugHandler DebugHandler
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003CE")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000FB")]
	internal ContextContainer frameData
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60003DC")]
		internal get { } //Length: 5
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000F2")]
	protected ProfilingSampler profilingExecute
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003BC")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000F7")]
	protected List<ScriptableRendererFeature> rendererFeatures
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60003D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FE")]
	internal bool stripAdditionalLightOffVariants
	{
		[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003E1")]
		internal get { } //Length: 5
		[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003E2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000FD")]
	internal bool stripShadowsOffVariants
	{
		[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003DF")]
		internal get { } //Length: 5
		[Address(RVA = "0x2490EA0", Offset = "0x24902A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003E0")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000F9")]
	public RenderingFeatures supportedRenderingFeatures
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D8")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003D9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000100")]
	public override bool supportsGPUOcclusion
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000409")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000FF")]
	internal override bool supportsNativeRenderPassRendergraphCompiler
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000408")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000FA")]
	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003DA")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003DB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000FC")]
	internal bool useDepthPriming
	{
		[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003DD")]
		internal get { } //Length: 5
		[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003DE")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2D87780", Offset = "0x2D86B80", Length = "0x8DB")]
	[Token(Token = "0x600040A")]
	private static ScriptableRenderer() { }

	[Address(RVA = "0x2D88060", Offset = "0x2D87460", Length = "0x406")]
	[Token(Token = "0x60003E3")]
	public ScriptableRenderer(ScriptableRendererData data) { }

	[Address(RVA = "0x2D826A0", Offset = "0x2D81AA0", Length = "0x23A")]
	[Token(Token = "0x60003FF")]
	internal void AddRenderPasses(ref RenderingData renderingData) { }

	[Address(RVA = "0x2D828E0", Offset = "0x2D81CE0", Length = "0x1B4")]
	[Token(Token = "0x6000406")]
	 int AdjustAndGetScreenMSAASamples(RenderGraph renderGraph, bool useIntermediateColorTarget) { }

	[Address(RVA = "0x2D82AA0", Offset = "0x2D81EA0", Length = "0x434")]
	[Token(Token = "0x60003F1")]
	internal void BeginRenderGraphXRRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D82EE0", Offset = "0x2D822E0", Length = "0x3D8")]
	[Token(Token = "0x60003D2")]
	private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle) { }

	[Address(RVA = "0x2D832C0", Offset = "0x2D826C0", Length = "0xE4")]
	[Token(Token = "0x60003F8")]
	internal void CalculateSplitEventRange(RenderPassEvent startInjectionPoint, RenderPassEvent targetEvent, out RenderPassEvent startEvent, out RenderPassEvent splitEvent, out RenderPassEvent endEvent) { }

	[Address(RVA = "0x2D838C0", Offset = "0x2D82CC0", Length = "0x307")]
	[Token(Token = "0x6000401")]
	internal void Clear(CameraRenderType cameraType) { }

	[Address(RVA = "0x2D833B0", Offset = "0x2D827B0", Length = "0x50B")]
	[Token(Token = "0x6000400")]
	private static void ClearRenderingState(IBaseCommandBuffer cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003C4")]
	public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget) { }

	[Address(RVA = "0x2D83BD0", Offset = "0x2D82FD0", Length = "0x185")]
	[Token(Token = "0x60003E4")]
	public override void Dispose() { }

	[Address(RVA = "0x2D83D60", Offset = "0x2D83160", Length = "0x11")]
	[Token(Token = "0x60003E5")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003EF")]
	internal void DrawRenderGraphGizmos(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003F0")]
	internal void DrawRenderGraphWireOverlay(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000404")]
	internal override void EnableSwapBufferMSAA(bool enable) { }

	[Address(RVA = "0x2D83D80", Offset = "0x2D83180", Length = "0x3A0")]
	[Token(Token = "0x60003F2")]
	internal void EndRenderGraphXRRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D84130", Offset = "0x2D83530", Length = "0xA9")]
	[Token(Token = "0x60003FB")]
	public void EnqueuePass(ScriptableRenderPass pass) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003C7")]
	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D841E0", Offset = "0x2D835E0", Length = "0x92")]
	[Token(Token = "0x60003F5")]
	internal void FinishRenderGraphRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E8")]
	public override void FinishRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60003D7")]
	protected List<ScriptableRenderPass> get_activeRenderPassQueue() { }

	[Address(RVA = "0x2D88470", Offset = "0x2D87870", Length = "0x4E")]
	[Token(Token = "0x60003D5")]
	public RenderTargetIdentifier get_cameraColorTarget() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60003C0")]
	public RTHandle get_cameraColorTargetHandle() { }

	[Address(RVA = "0x2D884C0", Offset = "0x2D878C0", Length = "0x33")]
	[Token(Token = "0x60003BB")]
	public RenderTargetIdentifier get_cameraDepth() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60003C2")]
	public RTHandle get_cameraDepthTargetHandle() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003CE")]
	internal DebugHandler get_DebugHandler() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60003DC")]
	internal ContextContainer get_frameData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003BC")]
	protected ProfilingSampler get_profilingExecute() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60003D6")]
	protected List<ScriptableRendererFeature> get_rendererFeatures() { }

	[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003E1")]
	internal bool get_stripAdditionalLightOffVariants() { }

	[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003DF")]
	internal bool get_stripShadowsOffVariants() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003D8")]
	public RenderingFeatures get_supportedRenderingFeatures() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000409")]
	public override bool get_supportsGPUOcclusion() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000408")]
	internal override bool get_supportsNativeRenderPassRendergraphCompiler() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003DA")]
	public GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003DD")]
	internal bool get_useDepthPriming() { }

	[Address(RVA = "0x2D84450", Offset = "0x2D83850", Length = "0x56")]
	[Token(Token = "0x60003FC")]
	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData) { }

	[Address(RVA = "0x2D84280", Offset = "0x2D83680", Length = "0x1CD")]
	[Token(Token = "0x60003FD")]
	protected static ClearFlag GetCameraClearFlag(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D844B0", Offset = "0x2D838B0", Length = "0x30D")]
	[Token(Token = "0x60003EC")]
	private void InitRenderGraphFrame(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D847C0", Offset = "0x2D83BC0", Length = "0x193")]
	[Token(Token = "0x6000405")]
	private void InternalFinishRenderingCommon(CommandBuffer cmd, bool resolveFinalTarget) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000402")]
	internal bool IsSceneFilteringEnabled(Camera camera) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E9")]
	public override void OnBeginRenderGraphFrame() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003EB")]
	public override void OnEndRenderGraphFrame() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003F6")]
	internal override void OnFinishRenderGraphRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x2D84960", Offset = "0x2D83D60", Length = "0xD4")]
	[Token(Token = "0x60003FE")]
	internal void OnPreCullRenderPasses(in CameraData cameraData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003EA")]
	internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[Address(RVA = "0x2D84A40", Offset = "0x2D83E40", Length = "0x46E")]
	[Token(Token = "0x60003ED")]
	internal void ProcessVFXCameraCommand(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D85080", Offset = "0x2D84480", Length = "0x4D")]
	[Token(Token = "0x60003FA")]
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent injectionPoint) { }

	[Address(RVA = "0x2D85020", Offset = "0x2D84420", Length = "0x59")]
	[Token(Token = "0x60003F9")]
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint) { }

	[Address(RVA = "0x2D84EB0", Offset = "0x2D842B0", Length = "0x161")]
	[Token(Token = "0x60003F7")]
	internal void RecordCustomRenderGraphPassesInEventRange(RenderGraph renderGraph, RenderPassEvent eventStart, RenderPassEvent eventEnd) { }

	[Address(RVA = "0x2D850D0", Offset = "0x2D844D0", Length = "0x36C")]
	[Token(Token = "0x60003F4")]
	internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E6")]
	internal override void ReleaseRenderTargets() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003C1")]
	public void set_cameraColorTargetHandle(RTHandle value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003C3")]
	public void set_cameraDepthTargetHandle(RTHandle value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003BD")]
	protected void set_profilingExecute(ProfilingSampler value) { }

	[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003E2")]
	internal void set_stripAdditionalLightOffVariants(bool value) { }

	[Address(RVA = "0x2490EA0", Offset = "0x24902A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003E0")]
	internal void set_stripShadowsOffVariants(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003D9")]
	public void set_supportedRenderingFeatures(RenderingFeatures value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003DB")]
	public void set_unsupportedGraphicsDeviceTypes(GraphicsDeviceType[] value) { }

	[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003DE")]
	internal void set_useDepthPriming(bool value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003BE")]
	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices) { }

	[Address(RVA = "0x2D85440", Offset = "0x2D84840", Length = "0x59D")]
	[Token(Token = "0x60003CF")]
	internal static void SetCameraMatrices(RasterCommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003BF")]
	public static void SetCameraMatrices(CommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices) { }

	[Address(RVA = "0x2D859E0", Offset = "0x2D84DE0", Length = "0x2EA")]
	[Token(Token = "0x60003F3")]
	private void SetEditorTarget(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D85CD0", Offset = "0x2D850D0", Length = "0x21B")]
	[Token(Token = "0x60003D1")]
	private void SetPerCameraBillboardProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D85EF0", Offset = "0x2D852F0", Length = "0x36D")]
	[Token(Token = "0x60003D3")]
	private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData, bool isTargetFlipped) { }

	[Address(RVA = "0x2D86260", Offset = "0x2D85660", Length = "0x8DC")]
	[Token(Token = "0x60003D0")]
	private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, bool isTargetFlipped) { }

	[Address(RVA = "0x2D86B40", Offset = "0x2D85F40", Length = "0x701")]
	[Token(Token = "0x60003D4")]
	private static void SetShaderTimeValues(IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003C5")]
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E7")]
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003C6")]
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D87250", Offset = "0x2D86650", Length = "0x3CA")]
	[Token(Token = "0x60003EE")]
	internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, TextureHandle target) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003C8")]
	protected void SetupRenderPasses(in RenderingData renderingData) { }

	[Address(RVA = "0x2D87620", Offset = "0x2D86A20", Length = "0x116")]
	[Token(Token = "0x6000407")]
	internal static void SortStable(List<ScriptableRenderPass> list) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60003C9")]
	public override int SupportedCameraStackingTypes() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60003CD")]
	protected private override bool SupportsCameraNormals() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60003CC")]
	protected private override bool SupportsCameraOpaque() { }

	[Address(RVA = "0x2D87740", Offset = "0x2D86B40", Length = "0x36")]
	[Token(Token = "0x60003CA")]
	public bool SupportsCameraStackingType(CameraRenderType cameraRenderType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60003CB")]
	protected private override bool SupportsMotionVectors() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000403")]
	internal override void SwapColorBuffer(CommandBuffer cmd) { }

}

