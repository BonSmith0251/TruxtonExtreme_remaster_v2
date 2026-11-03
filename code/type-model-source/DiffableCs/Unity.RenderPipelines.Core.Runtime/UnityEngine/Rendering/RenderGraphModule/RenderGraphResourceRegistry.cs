namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000291")]
internal class RenderGraphResourceRegistry
{
	[Token(Token = "0x2000294")]
	private class RenderGraphResourcesData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B83")]
		public DynamicArray<IRenderGraphResource> resourceArray; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B84")]
		public int sharedResourcesCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B85")]
		public IRenderGraphResourcePool pool; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B86")]
		public ResourceCreateCallback createResourceCallback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B87")]
		public ResourceCallback releaseResourceCallback; //Field offset: 0x30

		[Address(RVA = "0x2CA6E10", Offset = "0x2CA6210", Length = "0xA5")]
		[Token(Token = "0x60012AC")]
		public RenderGraphResourcesData() { }

		[Address(RVA = "0x9F64D0", Offset = "0x9F58D0", Length = "0x19B")]
		[Token(Token = "0x60012B0")]
		public int AddNewRenderGraphResource(out ResType outRes, bool pooledResource = true) { }

		[Address(RVA = "0x2CA6CB0", Offset = "0x2CA60B0", Length = "0xA2")]
		[Token(Token = "0x60012AE")]
		public void Cleanup() { }

		[Address(RVA = "0x2CA6D60", Offset = "0x2CA6160", Length = "0x8B")]
		[Token(Token = "0x60012AD")]
		public void Clear(bool onException, int frameIndex) { }

		[Address(RVA = "0x2CA6DF0", Offset = "0x2CA61F0", Length = "0x20")]
		[Token(Token = "0x60012AF")]
		public void PurgeUnusedGraphicsResources(int frameIndex) { }

	}

	[Token(Token = "0x2000293")]
	private sealed class ResourceCallback : MulticastDelegate
	{

		[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
		[Token(Token = "0x60012A8")]
		public ResourceCallback(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x60012AA")]
		public override IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60012AB")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60012A9")]
		public override void Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	}

	[Token(Token = "0x2000292")]
	private sealed class ResourceCreateCallback : MulticastDelegate
	{

		[Address(RVA = "0x1C14E80", Offset = "0x1C14280", Length = "0x125")]
		[Token(Token = "0x60012A4")]
		public ResourceCreateCallback(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x60012A6")]
		public override IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

		[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
		[Token(Token = "0x60012A7")]
		public override bool EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60012A5")]
		public override bool Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	}

	[Token(Token = "0x4000B73")]
	private const int kSharedResourceLifetime = 30; //Field offset: 0x0
	[Token(Token = "0x4000B74")]
	private static RenderGraphResourceRegistry m_CurrentRegistry; //Field offset: 0x0
	[Token(Token = "0x4000B7E")]
	private const int kInitialRendererListCount = 256; //Field offset: 0x0
	[Token(Token = "0x4000B80")]
	private static RenderTargetIdentifier emptyId; //Field offset: 0x8
	[Token(Token = "0x4000B81")]
	private static RenderTargetIdentifier builtinCameraRenderTarget; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B75")]
	private RenderGraphResourcesData[] m_RenderGraphResources; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B76")]
	private DynamicArray<RendererListResource> m_RendererListResources; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B77")]
	private DynamicArray<RendererListLegacyResource> m_RendererListLegacyResources; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B78")]
	private RenderGraphDebugParams m_RenderGraphDebug; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B79")]
	private RenderGraphLogger m_ResourceLogger; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B7A")]
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B7B")]
	private int m_CurrentFrameIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B7C")]
	private int m_ExecutionCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B7D")]
	private RTHandle m_CurrentBackbuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B7F")]
	private List<RendererList> m_ActiveRendererLists; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B82")]
	internal bool forceManualClearOfResource; //Field offset: 0x58

	[Token(Token = "0x17000255")]
	internal static RenderGraphResourceRegistry current
	{
		[Address(RVA = "0x2CA6BF0", Offset = "0x2CA5FF0", Length = "0x4E")]
		[Token(Token = "0x600124A")]
		internal get { } //Length: 78
		[Address(RVA = "0x2CA6C40", Offset = "0x2CA6040", Length = "0x69")]
		[Token(Token = "0x600124B")]
		internal set { } //Length: 105
	}

	[Address(RVA = "0x2CA6310", Offset = "0x2CA5710", Length = "0xCF")]
	[Token(Token = "0x60012A3")]
	private static RenderGraphResourceRegistry() { }

	[Address(RVA = "0x2CA6550", Offset = "0x2CA5950", Length = "0x698")]
	[Token(Token = "0x6001257")]
	internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) { }

	[Address(RVA = "0x2CA63E0", Offset = "0x2CA57E0", Length = "0x16E")]
	[Token(Token = "0x6001256")]
	private RenderGraphResourceRegistry() { }

	[Address(RVA = "0x2C9FC90", Offset = "0x2C9F090", Length = "0x1F7")]
	[Token(Token = "0x6001259")]
	internal void BeginExecute(int currentFrameIndex) { }

	[Address(RVA = "0x2C9FE90", Offset = "0x2C9F290", Length = "0x16D")]
	[Token(Token = "0x6001258")]
	internal void BeginRenderGraph(int executionCount) { }

	[Address(RVA = "0x2CA0000", Offset = "0x2C9F400", Length = "0xB1")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001251")]
	private void CheckBufferResource(BufferResource bufferResource) { }

	[Address(RVA = "0x2CA00C0", Offset = "0x2C9F4C0", Length = "0x1FE")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600125C")]
	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600125B")]
	private void CheckHandleValidity(in ResourceHandle res) { }

	[Address(RVA = "0x2CA02C0", Offset = "0x2C9F6C0", Length = "0xBA")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600124C")]
	private void CheckTextureResource(TextureResource texResource) { }

	[Address(RVA = "0x2CA0380", Offset = "0x2C9F780", Length = "0x147")]
	[Token(Token = "0x60012A0")]
	internal void Cleanup() { }

	[Address(RVA = "0x2CA0730", Offset = "0x2C9FB30", Length = "0x25E")]
	[Token(Token = "0x600129E")]
	internal void Clear(bool onException) { }

	[Address(RVA = "0x2CA04D0", Offset = "0x2C9F8D0", Length = "0xF5")]
	[Token(Token = "0x6001295")]
	internal bool ClearResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[Address(RVA = "0x2CA05D0", Offset = "0x2C9F9D0", Length = "0x15F")]
	[Token(Token = "0x6001296")]
	private void ClearTexture(InternalRenderGraphContext rgContext, TextureResource resource) { }

	[Address(RVA = "0x2CA0990", Offset = "0x2C9FD90", Length = "0x161")]
	[Token(Token = "0x6001287")]
	internal BufferHandle CreateBuffer(in BufferDesc desc, int transientPassIndex = -1) { }

	[Address(RVA = "0x2CA0B00", Offset = "0x2C9FF00", Length = "0xF7")]
	[Token(Token = "0x6001280")]
	internal RendererListHandle CreateGizmoRendererList(ScriptableRenderContext context, in Camera camera, in GizmoSubset gizmoSubset) { }

	[Address(RVA = "0x2CA0CB0", Offset = "0x2CA00B0", Length = "0x195")]
	[Token(Token = "0x6001292")]
	internal bool CreatePooledResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[Address(RVA = "0x2CA0C00", Offset = "0x2CA0000", Length = "0xA6")]
	[Token(Token = "0x6001293")]
	internal bool CreatePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle) { }

	[Address(RVA = "0x2CA0F90", Offset = "0x2CA0390", Length = "0x20E")]
	[Token(Token = "0x600127D")]
	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	[Address(RVA = "0x2CA0E50", Offset = "0x2CA0250", Length = "0x13A")]
	[Token(Token = "0x600127E")]
	internal RendererListHandle CreateRendererList(in RendererListParams desc) { }

	[Address(RVA = "0x2CA11A0", Offset = "0x2CA05A0", Length = "0x2BD")]
	[Token(Token = "0x600129D")]
	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false) { }

	[Address(RVA = "0x2CA1460", Offset = "0x2CA0860", Length = "0xD6")]
	[Token(Token = "0x600127F")]
	internal RendererListHandle CreateShadowRendererList(ScriptableRenderContext context, ref ShadowDrawingSettings shadowDrawinSettings) { }

	[Address(RVA = "0x2CA1540", Offset = "0x2CA0940", Length = "0x32C")]
	[Token(Token = "0x600126E")]
	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease) { }

	[Address(RVA = "0x2CA1950", Offset = "0x2CA0D50", Length = "0x1AD")]
	[Token(Token = "0x6001285")]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[Address(RVA = "0x2CA1B00", Offset = "0x2CA0F00", Length = "0x161")]
	[Token(Token = "0x6001284")]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[Address(RVA = "0x2CA1870", Offset = "0x2CA0C70", Length = "0xD9")]
	[Token(Token = "0x6001283")]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera) { }

	[Address(RVA = "0x2CA1D80", Offset = "0x2CA1180", Length = "0x1DC")]
	[Token(Token = "0x6001276")]
	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	[Address(RVA = "0x2CA1C70", Offset = "0x2CA1070", Length = "0x103")]
	[Token(Token = "0x6001294")]
	private bool CreateTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	[Address(RVA = "0x2CA1F60", Offset = "0x2CA1360", Length = "0xF7")]
	[Token(Token = "0x6001281")]
	internal RendererListHandle CreateUIOverlayRendererList(ScriptableRenderContext context, in Camera camera, in UISubset uiSubset) { }

	[Address(RVA = "0x2CA2060", Offset = "0x2CA1460", Length = "0xD9")]
	[Token(Token = "0x6001282")]
	internal RendererListHandle CreateWireOverlayRendererList(ScriptableRenderContext context, in Camera camera) { }

	[Address(RVA = "0x2CA2140", Offset = "0x2CA1540", Length = "0x94")]
	[Token(Token = "0x600125A")]
	internal void EndExecute() { }

	[Address(RVA = "0x2CA21E0", Offset = "0x2CA15E0", Length = "0x1D")]
	[Token(Token = "0x60012A2")]
	internal void FlushLogs() { }

	[Address(RVA = "0x2CA6BF0", Offset = "0x2CA5FF0", Length = "0x4E")]
	[Token(Token = "0x600124A")]
	internal static RenderGraphResourceRegistry get_current() { }

	[Address(RVA = "0x2CA2650", Offset = "0x2CA1A50", Length = "0x167")]
	[Token(Token = "0x6001252")]
	internal GraphicsBuffer GetBuffer(in BufferHandle handle) { }

	[Address(RVA = "0x2CA2590", Offset = "0x2CA1990", Length = "0xB4")]
	[Token(Token = "0x6001253")]
	internal GraphicsBuffer GetBuffer(int index) { }

	[Address(RVA = "0x2CA23C0", Offset = "0x2CA17C0", Length = "0xC2")]
	[Token(Token = "0x600128B")]
	private BufferResource GetBufferResource(int index) { }

	[Address(RVA = "0x2CA2490", Offset = "0x2CA1890", Length = "0xF4")]
	[Token(Token = "0x600128A")]
	private BufferResource GetBufferResource(in ResourceHandle handle) { }

	[Address(RVA = "0x2CA2200", Offset = "0x2CA1600", Length = "0x5A")]
	[Token(Token = "0x6001289")]
	internal int GetBufferResourceCount() { }

	[Address(RVA = "0x2CA2260", Offset = "0x2CA1660", Length = "0x15A")]
	[Token(Token = "0x6001288")]
	internal BufferDesc GetBufferResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false) { }

	[Address(RVA = "0x2CA27C0", Offset = "0x2CA1BC0", Length = "0xA")]
	[Token(Token = "0x6001274")]
	internal GraphicsFormat GetFormat(GraphicsFormat color, GraphicsFormat depthStencil) { }

	[Address(RVA = "0x2CA27D0", Offset = "0x2CA1BD0", Length = "0x130")]
	[Token(Token = "0x600125F")]
	internal ResourceHandle GetLatestVersionHandle(in ResourceHandle res) { }

	[Address(RVA = "0x2CA2A70", Offset = "0x2CA1E70", Length = "0x167")]
	[Token(Token = "0x6001254")]
	internal RayTracingAccelerationStructure GetRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle handle) { }

	[Address(RVA = "0x2CA2970", Offset = "0x2CA1D70", Length = "0xF4")]
	[Token(Token = "0x600128C")]
	private RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(in ResourceHandle handle) { }

	[Address(RVA = "0x2CA2910", Offset = "0x2CA1D10", Length = "0x5A")]
	[Token(Token = "0x600128D")]
	internal int GetRayTracingAccelerationStructureResourceCount() { }

	[Address(RVA = "0x2CA3380", Offset = "0x2CA2780", Length = "0x151")]
	[Token(Token = "0x6001250")]
	internal RendererList GetRendererList(in RendererListHandle handle) { }

	[Address(RVA = "0x2CA2C80", Offset = "0x2CA2080", Length = "0xE3")]
	[Token(Token = "0x6001262")]
	internal string GetRenderGraphResourceName(in ResourceHandle res) { }

	[Address(RVA = "0x2CA2BE0", Offset = "0x2CA1FE0", Length = "0x99")]
	[Token(Token = "0x6001263")]
	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) { }

	[Address(RVA = "0x2CA2D70", Offset = "0x2CA2170", Length = "0xD3")]
	[Token(Token = "0x600126A")]
	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res) { }

	[Address(RVA = "0x2CA2E50", Offset = "0x2CA2250", Length = "0x523")]
	[Token(Token = "0x6001273")]
	internal void GetRenderTargetInfo(in ResourceHandle res, out RenderTargetInfo outInfo) { }

	[Address(RVA = "0x2CA34E0", Offset = "0x2CA28E0", Length = "0x66")]
	[Token(Token = "0x6001278")]
	internal int GetResourceCount(RenderGraphResourceType type) { }

	[Address(RVA = "0x2CA3550", Offset = "0x2CA2950", Length = "0xCB")]
	[Token(Token = "0x6001261")]
	internal IRenderGraphResource GetResourceLowLevel(in ResourceHandle res) { }

	[Address(RVA = "0x2CA3620", Offset = "0x2CA2A20", Length = "0x33")]
	[Token(Token = "0x6001255")]
	internal int GetSharedResourceCount(RenderGraphResourceType type) { }

	[Address(RVA = "0x2CA39F0", Offset = "0x2CA2DF0", Length = "0xB7")]
	[Token(Token = "0x600124D")]
	internal RTHandle GetTexture(in TextureHandle handle) { }

	[Address(RVA = "0x2CA3AB0", Offset = "0x2CA2EB0", Length = "0xB7")]
	[Token(Token = "0x600124E")]
	internal RTHandle GetTexture(int index) { }

	[Address(RVA = "0x2CA3820", Offset = "0x2CA2C20", Length = "0xC2")]
	[Token(Token = "0x600127B")]
	internal TextureResource GetTextureResource(int index) { }

	[Address(RVA = "0x2CA38F0", Offset = "0x2CA2CF0", Length = "0xF4")]
	[Token(Token = "0x600127A")]
	internal TextureResource GetTextureResource(in ResourceHandle handle) { }

	[Address(RVA = "0x2CA3660", Offset = "0x2CA2A60", Length = "0x5A")]
	[Token(Token = "0x6001279")]
	internal int GetTextureResourceCount() { }

	[Address(RVA = "0x2CA36C0", Offset = "0x2CA2AC0", Length = "0x15D")]
	[Token(Token = "0x600127C")]
	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false) { }

	[Address(RVA = "0x2CA3B70", Offset = "0x2CA2F70", Length = "0x67")]
	[Token(Token = "0x6001260")]
	internal ResourceHandle GetZeroVersionHandle(in ResourceHandle res) { }

	[Address(RVA = "0x2CA3BE0", Offset = "0x2CA2FE0", Length = "0x309")]
	[Token(Token = "0x6001271")]
	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, in RenderTargetInfo info, in ImportResourceParams importParams) { }

	[Address(RVA = "0x2CA3EF0", Offset = "0x2CA32F0", Length = "0x148")]
	[Token(Token = "0x6001286")]
	internal BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer) { }

	[Address(RVA = "0x2CA4040", Offset = "0x2CA3440", Length = "0xFA")]
	[Token(Token = "0x600128E")]
	internal RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name) { }

	[Address(RVA = "0x2CA4540", Offset = "0x2CA3940", Length = "0x45C")]
	[Token(Token = "0x600126C")]
	internal TextureHandle ImportTexture(in RTHandle rt, in ImportResourceParams importParams, bool isBuiltin = false) { }

	[Address(RVA = "0x2CA44F0", Offset = "0x2CA38F0", Length = "0x44")]
	[Token(Token = "0x600126B")]
	internal TextureHandle ImportTexture(in RTHandle rt, bool isBuiltin = false) { }

	[Address(RVA = "0x2CA4140", Offset = "0x2CA3540", Length = "0x3A9")]
	[Token(Token = "0x600126D")]
	internal TextureHandle ImportTexture(in RTHandle rt, RenderTargetInfo info, in ImportResourceParams importParams) { }

	[Address(RVA = "0x2CA49A0", Offset = "0x2CA3DA0", Length = "0xE3")]
	[Token(Token = "0x600125E")]
	internal void IncrementReadCount(in ResourceHandle res) { }

	[Address(RVA = "0x2CA4A90", Offset = "0x2CA3E90", Length = "0x14A")]
	[Token(Token = "0x600125D")]
	internal ResourceHandle IncrementWriteCount(in ResourceHandle res) { }

	[Address(RVA = "0x2CA4BE0", Offset = "0x2CA3FE0", Length = "0xE3")]
	[Token(Token = "0x6001267")]
	internal bool IsGraphicsResourceCreated(in ResourceHandle res) { }

	[Address(RVA = "0x2CA4F00", Offset = "0x2CA4300", Length = "0x10F")]
	[Token(Token = "0x6001268")]
	internal bool IsRendererListCreated(in RendererListHandle res) { }

	[Address(RVA = "0x2CA4D60", Offset = "0x2CA4160", Length = "0xD4")]
	[Token(Token = "0x6001264")]
	internal bool IsRenderGraphResourceImported(in ResourceHandle res) { }

	[Address(RVA = "0x2CA4CD0", Offset = "0x2CA40D0", Length = "0x8A")]
	[Token(Token = "0x6001269")]
	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) { }

	[Address(RVA = "0x2CA4EC0", Offset = "0x2CA42C0", Length = "0x37")]
	[Token(Token = "0x6001265")]
	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) { }

	[Address(RVA = "0x2CA4E40", Offset = "0x2CA4240", Length = "0x7F")]
	[Token(Token = "0x6001266")]
	internal bool IsRenderGraphResourceShared(in ResourceHandle res) { }

	[Address(RVA = "0x2CA5010", Offset = "0x2CA4410", Length = "0x13B")]
	[Token(Token = "0x60012A1")]
	private void LogResources() { }

	[Address(RVA = "0x2CA5150", Offset = "0x2CA4550", Length = "0x16B")]
	[Token(Token = "0x6001291")]
	private void ManageSharedRenderGraphResources() { }

	[Address(RVA = "0x2CA52C0", Offset = "0x2CA46C0", Length = "0x7F")]
	[Token(Token = "0x600129F")]
	internal void PurgeUnusedGraphicsResources() { }

	[Address(RVA = "0x2CA5340", Offset = "0x2CA4740", Length = "0xAB")]
	[Token(Token = "0x600126F")]
	internal void RefreshSharedTextureDesc(in TextureHandle texture, in TextureDesc desc) { }

	[Address(RVA = "0x2CA53F0", Offset = "0x2CA47F0", Length = "0xA6")]
	[Token(Token = "0x6001298")]
	internal void ReleasePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle) { }

	[Address(RVA = "0x2CA54A0", Offset = "0x2CA48A0", Length = "0x135")]
	[Token(Token = "0x6001297")]
	internal void ReleasePooledResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[Address(RVA = "0x2CA55E0", Offset = "0x2CA49E0", Length = "0xD1")]
	[Token(Token = "0x6001270")]
	internal void ReleaseSharedTexture(in TextureHandle texture) { }

	[Address(RVA = "0x2CA56C0", Offset = "0x2CA4AC0", Length = "0x182")]
	[Token(Token = "0x6001299")]
	private void ReleaseTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	[Address(RVA = "0x2CA6C40", Offset = "0x2CA6040", Length = "0x69")]
	[Token(Token = "0x600124B")]
	internal static void set_current(RenderGraphResourceRegistry value) { }

	[Address(RVA = "0x2CA5850", Offset = "0x2CA4C50", Length = "0x85")]
	[Token(Token = "0x6001277")]
	internal void SetTextureAsMemoryLess(in ResourceHandle handle) { }

	[Address(RVA = "0x2CA58E0", Offset = "0x2CA4CE0", Length = "0xC6")]
	[Token(Token = "0x600124F")]
	internal bool TextureNeedsFallback(in TextureHandle handle) { }

	[Address(RVA = "0x2CA5A40", Offset = "0x2CA4E40", Length = "0xC1")]
	[Token(Token = "0x6001290")]
	internal void UpdateSharedResourceLastFrameIndex(in ResourceHandle handle) { }

	[Address(RVA = "0x2CA59B0", Offset = "0x2CA4DB0", Length = "0x8D")]
	[Token(Token = "0x600128F")]
	internal void UpdateSharedResourceLastFrameIndex(int type, int index) { }

	[Address(RVA = "0x2CA5B10", Offset = "0x2CA4F10", Length = "0x12F")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600129C")]
	private void ValidateBufferDesc(in BufferDesc desc) { }

	[Address(RVA = "0x2CA5C40", Offset = "0x2CA5040", Length = "0xE0")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001275")]
	internal void ValidateFormat(GraphicsFormat color, GraphicsFormat depthStencil) { }

	[Address(RVA = "0x2CA5DF0", Offset = "0x2CA51F0", Length = "0x267")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600129B")]
	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	[Address(RVA = "0x2CA5D30", Offset = "0x2CA5130", Length = "0xB2")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001272")]
	private void ValidateRenderTarget(in ResourceHandle res) { }

	[Address(RVA = "0x2CA6060", Offset = "0x2CA5460", Length = "0x2A5")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600129A")]
	private void ValidateTextureDesc(in TextureDesc desc) { }

}

