namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Obsolete("RenderGraphBuilder is deprecated, use IComputeRenderGraphBuilder/IRasterRenderGraphBuilder/IUnsafeRenderGraphBuilder instead.")]
[Token(Token = "0x2000274")]
public struct RenderGraphBuilder : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B0B")]
	private RenderGraphPass m_RenderPass; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B0C")]
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0D")]
	private RenderGraph m_RenderGraph; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B0E")]
	private bool m_Disposed; //Field offset: 0x18

	[Address(RVA = "0x2C72AB0", Offset = "0x2C71EB0", Length = "0x54")]
	[Token(Token = "0x600114A")]
	internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	[Address(RVA = "0x2C71DE0", Offset = "0x2C711E0", Length = "0x19")]
	[Token(Token = "0x6001145")]
	public void AllowPassCulling(bool value) { }

	[Address(RVA = "0x2C71E00", Offset = "0x2C71200", Length = "0x1C")]
	[Token(Token = "0x6001148")]
	public void AllowRendererListCulling(bool value) { }

	[Address(RVA = "0x2C71E20", Offset = "0x2C71220", Length = "0x2AD")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600114C")]
	private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = true) { }

	[Address(RVA = "0x2C72170", Offset = "0x2C71570", Length = "0x70")]
	[Token(Token = "0x6001141")]
	public BufferHandle CreateTransientBuffer(in BufferDesc desc) { }

	[Address(RVA = "0x2C720D0", Offset = "0x2C714D0", Length = "0x91")]
	[Token(Token = "0x6001142")]
	public BufferHandle CreateTransientBuffer(in BufferHandle graphicsbuffer) { }

	[Address(RVA = "0x2C72280", Offset = "0x2C71680", Length = "0x6A")]
	[Token(Token = "0x600113A")]
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	[Address(RVA = "0x2C721F0", Offset = "0x2C715F0", Length = "0x87")]
	[Token(Token = "0x600113B")]
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	[Address(RVA = "0x2C722F0", Offset = "0x2C716F0", Length = "0x44")]
	[Token(Token = "0x6001149")]
	public RendererListHandle DependsOn(in RendererListHandle input) { }

	[Address(RVA = "0x2C72340", Offset = "0x2C71740", Length = "0x6F")]
	[Token(Token = "0x600114B")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x2C72340", Offset = "0x2C71740", Length = "0x6F")]
	[Token(Token = "0x6001147")]
	public override void Dispose() { }

	[Address(RVA = "0x2C723B0", Offset = "0x2C717B0", Length = "0x19")]
	[Token(Token = "0x6001144")]
	public void EnableAsyncCompute(bool value) { }

	[Address(RVA = "0x2C723D0", Offset = "0x2C717D0", Length = "0x19")]
	[Token(Token = "0x6001146")]
	public void EnableFoveatedRasterization(bool value) { }

	[Address(RVA = "0x2C723F0", Offset = "0x2C717F0", Length = "0x1C")]
	[Token(Token = "0x600114D")]
	internal void GenerateDebugData(bool value) { }

	[Address(RVA = "0x2C72410", Offset = "0x2C71810", Length = "0x44")]
	[Token(Token = "0x600113F")]
	public BufferHandle ReadBuffer(in BufferHandle input) { }

	[Address(RVA = "0x2C72410", Offset = "0x2C71810", Length = "0x44")]
	[Token(Token = "0x600113D")]
	public RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input) { }

	[Address(RVA = "0x2C72460", Offset = "0x2C71860", Length = "0x183")]
	[Token(Token = "0x6001137")]
	public TextureHandle ReadTexture(in TextureHandle input) { }

	[Address(RVA = "0x2C725F0", Offset = "0x2C719F0", Length = "0x72")]
	[Token(Token = "0x6001139")]
	public TextureHandle ReadWriteTexture(in TextureHandle input) { }

	[Address(RVA = "0x8E61F0", Offset = "0x8E55F0", Length = "0x102")]
	[Token(Token = "0x6001143")]
	public void SetRenderFunc(BaseRenderFunc<PassData, RenderGraphContext> renderFunc) { }

	[Address(RVA = "0x2C72670", Offset = "0x2C71A70", Length = "0x13D")]
	[Token(Token = "0x6001135")]
	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	[Address(RVA = "0x2C727B0", Offset = "0x2C71BB0", Length = "0x157")]
	[Token(Token = "0x6001136")]
	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	[Address(RVA = "0x2C72910", Offset = "0x2C71D10", Length = "0x5C")]
	[Token(Token = "0x600113E")]
	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	[Address(RVA = "0x2C72970", Offset = "0x2C71D70", Length = "0x6A")]
	[Token(Token = "0x6001140")]
	public BufferHandle WriteBuffer(in BufferHandle input) { }

	[Address(RVA = "0x2C729E0", Offset = "0x2C71DE0", Length = "0x67")]
	[Token(Token = "0x600113C")]
	public RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input) { }

	[Address(RVA = "0x2C72A50", Offset = "0x2C71E50", Length = "0x5F")]
	[Token(Token = "0x6001138")]
	public TextureHandle WriteTexture(in TextureHandle input) { }

}

