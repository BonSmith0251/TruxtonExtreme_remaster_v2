namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000219")]
public class DepthOnlyPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200021B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D19")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D1A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__14_0; //Field offset: 0x8

		[Address(RVA = "0x2E35950", Offset = "0x2E34D50", Length = "0x67")]
		[Token(Token = "0x6000BB5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BB6")]
		public <>c() { }

		[Address(RVA = "0x2E34430", Offset = "0x2E33830", Length = "0xB4")]
		[Token(Token = "0x6000BB7")]
		internal void <Render>b__14_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200021A")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D18")]
		internal RendererListHandle rendererList; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BB4")]
		public PassData() { }

	}

	[Token(Token = "0x4000D16")]
	private static readonly ShaderTagId k_ShaderTagId; //Field offset: 0x0
	[Token(Token = "0x4000D17")]
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D14")]
	private ShaderTagId <shaderTagId>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000D15")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x64

	[Token(Token = "0x170002CC")]
	internal ShaderTagId shaderTagId
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAC")]
		internal get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAD")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2E25290", Offset = "0x2E24690", Length = "0x8C")]
	[Token(Token = "0x6000BB3")]
	private static DepthOnlyPass() { }

	[Address(RVA = "0x2E25320", Offset = "0x2E24720", Length = "0x17A")]
	[Token(Token = "0x6000BAE")]
	public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BAB")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E24530", Offset = "0x2E23930", Length = "0xCB")]
	[Token(Token = "0x6000BB0")]
	private static void ExecutePass(RasterCommandBuffer cmd, RendererList rendererList) { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAC")]
	internal ShaderTagId get_shaderTagId() { }

	[Address(RVA = "0x2E24600", Offset = "0x2E23A00", Length = "0x33D")]
	[Token(Token = "0x6000BB1")]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BAA")]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E24940", Offset = "0x2E23D40", Length = "0x943")]
	[Token(Token = "0x6000BB2")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle depthTexture, uint batchLayerMask, bool setGlobalDepth) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAD")]
	internal void set_shaderTagId(ShaderTagId value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BAF")]
	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle) { }

}

