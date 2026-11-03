namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200021C")]
public class DrawObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200021E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D2F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D30")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__19_0; //Field offset: 0x8

		[Address(RVA = "0x2E35800", Offset = "0x2E34C00", Length = "0x67")]
		[Token(Token = "0x6000BC6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BC7")]
		public <>c() { }

		[Address(RVA = "0x2E34A10", Offset = "0x2E33E10", Length = "0x293")]
		[Token(Token = "0x6000BC8")]
		internal void <Render>b__19_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200021D")]
	public class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D22")]
		internal TextureHandle albedoHdl; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D23")]
		internal TextureHandle depthHdl; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D24")]
		internal TextureHandle screenSpaceIrradianceHdl; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000D25")]
		internal UniversalCameraData cameraData; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000D26")]
		internal bool isOpaque; //Field offset: 0x48
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x4000D27")]
		internal bool shouldTransparentsReceiveShadows; //Field offset: 0x49
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000D28")]
		internal uint batchLayerMask; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000D29")]
		internal bool isActiveTargetBackBuffer; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000D2A")]
		internal RendererListHandle rendererListHdl; //Field offset: 0x54
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000D2B")]
		internal RendererListHandle objectsWithErrorRendererListHdl; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000D2C")]
		internal DebugRendererLists debugRendererLists; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000D2D")]
		internal RendererList rendererList; //Field offset: 0x78
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000D2E")]
		internal RendererList objectsWithErrorRendererList; //Field offset: 0x90

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BC5")]
		public PassData() { }

	}

	[Token(Token = "0x4000D21")]
	private static readonly int s_DrawObjectPassDataPropID; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x4000D1B")]
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000D1C")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x64
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000D1D")]
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x84
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000D1E")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000D1F")]
	private bool m_IsOpaque; //Field offset: 0xF8
	[FieldOffset(Offset = "0xF9")]
	[Token(Token = "0x4000D20")]
	public bool m_ShouldTransparentsReceiveShadows; //Field offset: 0xF9

	[Address(RVA = "0x2E27020", Offset = "0x2E26420", Length = "0x4F")]
	[Token(Token = "0x6000BC4")]
	private static DrawObjectsPass() { }

	[Address(RVA = "0x2E271B0", Offset = "0x2E265B0", Length = "0x142")]
	[Token(Token = "0x6000BBB")]
	public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[Address(RVA = "0x2E27070", Offset = "0x2E26470", Length = "0x13B")]
	[Token(Token = "0x6000BBC")]
	public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[Address(RVA = "0x2E27300", Offset = "0x2E26700", Length = "0x12D")]
	[Token(Token = "0x6000BBD")]
	internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[Address(RVA = "0x2E254A0", Offset = "0x2E248A0", Length = "0x42")]
	[Token(Token = "0x6000BC2")]
	internal static bool CanDisableZWrite(UniversalCameraData cameraData, bool isOpaque) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BB9")]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BBA")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E254F0", Offset = "0x2E248F0", Length = "0x36B")]
	[Token(Token = "0x6000BBF")]
	internal static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList objectsWithErrorRendererList, bool yFlip) { }

	[Address(RVA = "0x2E260E0", Offset = "0x2E254E0", Length = "0x392")]
	[Token(Token = "0x6000BBE")]
	internal void Init(bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, ShaderTagId[] shaderTagIds = null) { }

	[Address(RVA = "0x2E25860", Offset = "0x2E24C60", Length = "0x81")]
	[Token(Token = "0x6000BC0")]
	internal void InitPassData(UniversalCameraData cameraData, ref PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer = false) { }

	[Address(RVA = "0x2E258F0", Offset = "0x2E24CF0", Length = "0x7E4")]
	[Token(Token = "0x6000BC1")]
	internal void InitRendererLists(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph, bool zWriteOff) { }

	[Address(RVA = "0x2E26480", Offset = "0x2E25880", Length = "0xB90")]
	[Token(Token = "0x6000BC3")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, uint batchLayerMask = 4294967295, bool isMainOpaquePass = false) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BB8")]
	public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment) { }

}

