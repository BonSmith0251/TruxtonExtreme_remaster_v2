namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000216")]
public class DepthNormalOnlyPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000218")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D12")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D13")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__29_0; //Field offset: 0x8

		[Address(RVA = "0x2E355D0", Offset = "0x2E349D0", Length = "0x67")]
		[Token(Token = "0x6000BA7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BA8")]
		public <>c() { }

		[Address(RVA = "0x2E34DA0", Offset = "0x2E341A0", Length = "0x146")]
		[Token(Token = "0x6000BA9")]
		internal void <Render>b__29_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000217")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D0F")]
		internal bool enableRenderingLayers; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000D10")]
		internal MaskSize maskSize; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D11")]
		internal RendererListHandle rendererList; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BA6")]
		public PassData() { }

	}

	[Token(Token = "0x4000D09")]
	private static readonly List<ShaderTagId> k_DepthNormals; //Field offset: 0x0
	[Token(Token = "0x4000D0A")]
	private static readonly List<ShaderTagId> k_DepthNormalsOnly; //Field offset: 0x8
	[Token(Token = "0x4000D0B")]
	internal static readonly string k_CameraNormalsTextureName; //Field offset: 0x10
	[Token(Token = "0x4000D0C")]
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x18
	[Token(Token = "0x4000D0D")]
	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x1C
	[Token(Token = "0x4000D0E")]
	private static readonly int s_CameraRenderingLayersTextureID; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D05")]
	private List<ShaderTagId> <shaderTagIds>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D06")]
	private bool <enableRenderingLayers>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000D07")]
	private MaskSize <renderingLayersMaskSize>k__BackingField; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D08")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x70

	[Token(Token = "0x170002CA")]
	internal bool enableRenderingLayers
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B99")]
		internal get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B9A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002CB")]
	internal MaskSize renderingLayersMaskSize
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B9B")]
		internal get { } //Length: 4
		[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B9C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C9")]
	internal List<ShaderTagId> shaderTagIds
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B97")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x6000B98")]
		internal set { } //Length: 995
	}

	[Address(RVA = "0x2E240B0", Offset = "0x2E234B0", Length = "0x326")]
	[Token(Token = "0x6000BA5")]
	private static DepthNormalOnlyPass() { }

	[Address(RVA = "0x2E243E0", Offset = "0x2E237E0", Length = "0x14C")]
	[Token(Token = "0x6000B9D")]
	public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B96")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E22F00", Offset = "0x2E22300", Length = "0xD5")]
	[Token(Token = "0x6000BA1")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B99")]
	internal bool get_enableRenderingLayers() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B9B")]
	internal MaskSize get_renderingLayersMaskSize() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B97")]
	internal List<ShaderTagId> get_shaderTagIds() { }

	[Address(RVA = "0x2E22FE0", Offset = "0x2E223E0", Length = "0x53")]
	[Token(Token = "0x6000B9E")]
	public static GraphicsFormat GetGraphicsFormat() { }

	[Address(RVA = "0x2E23040", Offset = "0x2E22440", Length = "0x331")]
	[Token(Token = "0x6000BA3")]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2E23380", Offset = "0x2E22780", Length = "0xB9")]
	[Token(Token = "0x6000BA2")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B95")]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E23440", Offset = "0x2E22840", Length = "0xC4C")]
	[Token(Token = "0x6000BA4")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraNormalsTexture, in TextureHandle depthTexture, in TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalNormalAndRenderingLayers, bool allowPartialPass) { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B9A")]
	internal void set_enableRenderingLayers(bool value) { }

	[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B9C")]
	internal void set_renderingLayersMaskSize(MaskSize value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x6000B98")]
	internal void set_shaderTagIds(List<ShaderTagId> value) { }

	[Address(RVA = "0x2E24090", Offset = "0x2E23490", Length = "0x5")]
	[Token(Token = "0x6000B9F")]
	public void Setup(RTHandle depthHandle, RTHandle normalHandle) { }

	[Address(RVA = "0x2E240A0", Offset = "0x2E234A0", Length = "0x5")]
	[Token(Token = "0x6000BA0")]
	public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle) { }

}

