namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000275")]
internal class RenderGraphBuilders : IBaseRenderGraphBuilder, IDisposable, IComputeRenderGraphBuilder, IRasterRenderGraphBuilder, IRenderAttachmentRenderGraphBuilder, IUnsafeRenderGraphBuilder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0F")]
	private RenderGraphPass m_RenderPass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B10")]
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B11")]
	private RenderGraph m_RenderGraph; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B12")]
	private bool m_Disposed; //Field offset: 0x28

	[Address(RVA = "0x2C77180", Offset = "0x2C76580", Length = "0x53")]
	[Token(Token = "0x600114E")]
	public RenderGraphBuilders() { }

	[Address(RVA = "0x2C72B10", Offset = "0x2C71F10", Length = "0x2B")]
	[Token(Token = "0x6001152")]
	public override void AllowGlobalStateModification(bool value) { }

	[Address(RVA = "0x2C72B40", Offset = "0x2C71F40", Length = "0x2D")]
	[Token(Token = "0x6001151")]
	public override void AllowPassCulling(bool value) { }

	[Address(RVA = "0x2C72B70", Offset = "0x2C71F70", Length = "0x242")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001172")]
	private void CheckFrameBufferFetchEmulationIsSupported(in TextureHandle tex) { }

	[Address(RVA = "0x2C72DC0", Offset = "0x2C721C0", Length = "0x44E")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600115F")]
	private void CheckNotUseFragment(in TextureHandle tex) { }

	[Address(RVA = "0x2C73210", Offset = "0x2C72610", Length = "0x6F6")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001171")]
	private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = false) { }

	[Address(RVA = "0x2C73910", Offset = "0x2C72D10", Length = "0x223")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001160")]
	private void CheckTextureUVOriginIsValid(in ResourceHandle handle, TextureResource texRes) { }

	[Address(RVA = "0x2C73B40", Offset = "0x2C72F40", Length = "0x170D")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001165")]
	private void CheckUseFragment(in TextureHandle tex, bool isDepth) { }

	[Address(RVA = "0x2C75250", Offset = "0x2C74650", Length = "0x5AA")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600115B")]
	private void CheckWriteTo(in ResourceHandle handle) { }

	[Address(RVA = "0x2C75860", Offset = "0x2C74C60", Length = "0xE6")]
	[Token(Token = "0x6001154")]
	public BufferHandle CreateTransientBuffer(in BufferDesc desc) { }

	[Address(RVA = "0x2C75800", Offset = "0x2C74C00", Length = "0x5E")]
	[Token(Token = "0x6001155")]
	public BufferHandle CreateTransientBuffer(in BufferHandle computebuffer) { }

	[Address(RVA = "0x2C75A40", Offset = "0x2C74E40", Length = "0x56")]
	[Token(Token = "0x6001157")]
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	[Address(RVA = "0x2C75950", Offset = "0x2C74D50", Length = "0xE0")]
	[Token(Token = "0x6001156")]
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	[Address(RVA = "0x1F647B0", Offset = "0x1F63BB0", Length = "0x16")]
	[Token(Token = "0x6001159")]
	public override void Dispose() { }

	[Address(RVA = "0x2C75AA0", Offset = "0x2C74EA0", Length = "0x5E1")]
	[Token(Token = "0x600115A")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2C76090", Offset = "0x2C75490", Length = "0x1A")]
	[Token(Token = "0x6001150")]
	public override void EnableAsyncCompute(bool value) { }

	[Address(RVA = "0x2C760B0", Offset = "0x2C754B0", Length = "0x1A")]
	[Token(Token = "0x6001153")]
	public override void EnableFoveatedRasterization(bool value) { }

	[Address(RVA = "0x2C760D0", Offset = "0x2C754D0", Length = "0x1D")]
	[Token(Token = "0x6001158")]
	public override void GenerateDebugData(bool value) { }

	[Address(RVA = "0x2C760F0", Offset = "0x2C754F0", Length = "0x1E")]
	[Token(Token = "0x6001175")]
	public override void SetExtendedFeatureFlags(ExtendedFeatureFlags extendedFeatureFlags) { }

	[Address(RVA = "0x2C76110", Offset = "0x2C75510", Length = "0x114")]
	[Token(Token = "0x6001164")]
	public void SetGlobalTextureAfterPass(in TextureHandle input, int propertyId) { }

	[Address(RVA = "0x2C76230", Offset = "0x2C75630", Length = "0xCB")]
	[Token(Token = "0x6001167")]
	public override void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C76300", Offset = "0x2C75700", Length = "0xA3")]
	[Token(Token = "0x6001169")]
	public override TextureHandle SetRandomAccessAttachment(TextureHandle input, int index, AccessFlags flags = 1) { }

	[Address(RVA = "0x2C765F0", Offset = "0x2C759F0", Length = "0xCB")]
	[Token(Token = "0x6001166")]
	public override void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C763B0", Offset = "0x2C757B0", Length = "0x23C")]
	[Token(Token = "0x6001168")]
	public override void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x8E6300", Offset = "0x8E5700", Length = "0x103")]
	[Token(Token = "0x600116F")]
	public override void SetRenderFunc(BaseRenderFunc<PassData, UnsafeGraphContext> renderFunc) { }

	[Address(RVA = "0x8E6300", Offset = "0x8E5700", Length = "0x103")]
	[Token(Token = "0x600116D")]
	public override void SetRenderFunc(BaseRenderFunc<PassData, ComputeGraphContext> renderFunc) { }

	[Address(RVA = "0x8E6300", Offset = "0x8E5700", Length = "0x103")]
	[Token(Token = "0x600116E")]
	public override void SetRenderFunc(BaseRenderFunc<PassData, RasterGraphContext> renderFunc) { }

	[Address(RVA = "0x2C766C0", Offset = "0x2C75AC0", Length = "0x1E")]
	[Token(Token = "0x6001174")]
	public override void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x2C766E0", Offset = "0x2C75AE0", Length = "0x1E")]
	[Token(Token = "0x6001173")]
	public override void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x2C76700", Offset = "0x2C75B00", Length = "0x8E")]
	[Token(Token = "0x600116A")]
	public void SetShadingRateImageAttachment(in TextureHandle tex) { }

	[Address(RVA = "0x2C76790", Offset = "0x2C75B90", Length = "0xAD")]
	[Token(Token = "0x600114F")]
	public void Setup(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	[Address(RVA = "0x2C75800", Offset = "0x2C74C00", Length = "0x5E")]
	[Token(Token = "0x600117D")]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferHandle computebuffer) { }

	[Address(RVA = "0x2C76840", Offset = "0x2C75C40", Length = "0x2D")]
	[Token(Token = "0x600117C")]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferDesc desc) { }

	[Address(RVA = "0x2C75A40", Offset = "0x2C74E40", Length = "0x56")]
	[Token(Token = "0x600117B")]
	private override TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(in TextureHandle texture) { }

	[Address(RVA = "0x2C76870", Offset = "0x2C75C70", Length = "0x25")]
	[Token(Token = "0x600117A")]
	private override TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(in TextureDesc desc) { }

	[Address(RVA = "0x2C76110", Offset = "0x2C75510", Length = "0x114")]
	[Token(Token = "0x6001178")]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(in TextureHandle input, int propertyId) { }

	[Address(RVA = "0x2C768A0", Offset = "0x2C75CA0", Length = "0x3F")]
	[Token(Token = "0x6001179")]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseBuffer(in BufferHandle input, AccessFlags flags) { }

	[Address(RVA = "0x2C768E0", Offset = "0x2C75CE0", Length = "0x1E")]
	[Token(Token = "0x600117E")]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseRendererList(in RendererListHandle input) { }

	[Address(RVA = "0x2C76900", Offset = "0x2C75D00", Length = "0x8")]
	[Token(Token = "0x6001177")]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseTexture(in TextureHandle input, AccessFlags flags) { }

	[Address(RVA = "0x2C76700", Offset = "0x2C75B00", Length = "0x8E")]
	[Token(Token = "0x6001176")]
	private override void UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder.SetShadingRateImageAttachment(in TextureHandle tex) { }

	[Address(RVA = "0x2C76910", Offset = "0x2C75D10", Length = "0x1D")]
	[Token(Token = "0x6001163")]
	public override void UseAllGlobalTextures(bool enable) { }

	[Address(RVA = "0x2C768A0", Offset = "0x2C75CA0", Length = "0x3F")]
	[Token(Token = "0x600115E")]
	public BufferHandle UseBuffer(in BufferHandle input, AccessFlags flags) { }

	[Address(RVA = "0x2C769E0", Offset = "0x2C75DE0", Length = "0xAB")]
	[Token(Token = "0x600116C")]
	public override BufferHandle UseBufferRandomAccess(BufferHandle input, int index, bool preserveCounterValue, AccessFlags flags = 1) { }

	[Address(RVA = "0x2C76930", Offset = "0x2C75D30", Length = "0xA8")]
	[Token(Token = "0x600116B")]
	public override BufferHandle UseBufferRandomAccess(BufferHandle input, int index, AccessFlags flags = 1) { }

	[Address(RVA = "0x2C76A90", Offset = "0x2C75E90", Length = "0x33A")]
	[Token(Token = "0x6001162")]
	public override void UseGlobalTexture(int propertyId, AccessFlags flags) { }

	[Address(RVA = "0x2C768E0", Offset = "0x2C75CE0", Length = "0x1E")]
	[Token(Token = "0x6001170")]
	public void UseRendererList(in RendererListHandle input) { }

	[Address(RVA = "0x2C76DD0", Offset = "0x2C761D0", Length = "0x25E")]
	[Token(Token = "0x600115D")]
	private ResourceHandle UseResource(in ResourceHandle inputHandle, AccessFlags flags) { }

	[Address(RVA = "0x2C77030", Offset = "0x2C76430", Length = "0x83")]
	[Token(Token = "0x6001161")]
	public void UseTexture(in TextureHandle input, AccessFlags flags) { }

	[Address(RVA = "0x2C770C0", Offset = "0x2C764C0", Length = "0xB2")]
	[Token(Token = "0x600115C")]
	private ResourceHandle UseTransientResource(in ResourceHandle inputHandle) { }

}

