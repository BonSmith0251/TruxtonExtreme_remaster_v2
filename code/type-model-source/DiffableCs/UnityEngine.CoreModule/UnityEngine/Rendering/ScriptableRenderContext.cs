namespace UnityEngine.Rendering;

[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[Token(Token = "0x20003EE")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	[Token(Token = "0x20003EF")]
	private struct CullShadowCastersContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CF9")]
		public IntPtr cullResults; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000CFA")]
		public ShadowSplitData* splitBuffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CFB")]
		public int splitBufferLength; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CFC")]
		public LightShadowCasterCullingInfo* perLightInfos; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CFD")]
		public int perLightInfoCount; //Field offset: 0x20

	}

	[Token(Token = "0x4000CF7")]
	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CF8")]
	private IntPtr m_Ptr; //Field offset: 0x0

	[Address(RVA = "0x30CB4C0", Offset = "0x30CA8C0", Length = "0x4F")]
	[Token(Token = "0x6001E6D")]
	private static ScriptableRenderContext() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001E58")]
	internal ScriptableRenderContext(IntPtr ptr) { }

	[Address(RVA = "0x30C8F20", Offset = "0x30C8320", Length = "0x154")]
	[Token(Token = "0x6001E68")]
	public RendererList CreateGizmoRendererList(Camera camera, GizmoSubset gizmoSubset) { }

	[Address(RVA = "0x30C8E10", Offset = "0x30C8210", Length = "0x100")]
	[Token(Token = "0x6001E53")]
	private RendererList CreateGizmoRendererList_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	[Address(RVA = "0x30C8DA0", Offset = "0x30C81A0", Length = "0x62")]
	[Token(Token = "0x6001E77")]
	private static void CreateGizmoRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, GizmoSubset gizmoSubset, out RendererList ret) { }

	[Address(RVA = "0x30C91F0", Offset = "0x30C85F0", Length = "0x18C")]
	[Token(Token = "0x6001E63")]
	public RendererList CreateRendererList(ref RendererListParams param) { }

	[Address(RVA = "0x30C9100", Offset = "0x30C8500", Length = "0xE9")]
	[Token(Token = "0x6001E50")]
	private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	[Address(RVA = "0x30C9080", Offset = "0x30C8480", Length = "0x71")]
	[Token(Token = "0x6001E74")]
	private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, in ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret) { }

	[Address(RVA = "0x30C9480", Offset = "0x30C8880", Length = "0xF3")]
	[Token(Token = "0x6001E64")]
	public RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings) { }

	[Address(RVA = "0x30C93E0", Offset = "0x30C87E0", Length = "0x91")]
	[Token(Token = "0x6001E51")]
	private RendererList CreateShadowRendererList_Internal(IntPtr shadowDrawinSettings) { }

	[Address(RVA = "0x30C9380", Offset = "0x30C8780", Length = "0x52")]
	[Token(Token = "0x6001E75")]
	private static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawinSettings, out RendererList ret) { }

	[Address(RVA = "0x30C9C00", Offset = "0x30C9000", Length = "0x35F")]
	[Token(Token = "0x6001E67")]
	public RendererList CreateSkyboxRendererList(Camera camera) { }

	[Address(RVA = "0x30C99E0", Offset = "0x30C8DE0", Length = "0x218")]
	[Token(Token = "0x6001E65")]
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[Address(RVA = "0x30C9720", Offset = "0x30C8B20", Length = "0x2B9")]
	[Token(Token = "0x6001E66")]
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[Address(RVA = "0x30C95F0", Offset = "0x30C89F0", Length = "0x12B")]
	[Token(Token = "0x6001E52")]
	private RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR) { }

	[Address(RVA = "0x30C9580", Offset = "0x30C8980", Length = "0x62")]
	[Token(Token = "0x6001E76")]
	private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, int mode, in Matrix4x4 proj, in Matrix4x4 view, in Matrix4x4 projR, in Matrix4x4 viewR, out RendererList ret) { }

	[Address(RVA = "0x30CA0E0", Offset = "0x30C94E0", Length = "0x154")]
	[Token(Token = "0x6001E69")]
	public RendererList CreateUIOverlayRendererList(Camera camera, UISubset uiSubset) { }

	[Address(RVA = "0x30C9FD0", Offset = "0x30C93D0", Length = "0x100")]
	[Token(Token = "0x6001E54")]
	private RendererList CreateUIOverlayRendererList_Internal(Camera camera, UISubset uiSubset) { }

	[Address(RVA = "0x30C9F60", Offset = "0x30C9360", Length = "0x62")]
	[Token(Token = "0x6001E78")]
	private static void CreateUIOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, UISubset uiSubset, out RendererList ret) { }

	[Address(RVA = "0x30CA390", Offset = "0x30C9790", Length = "0x142")]
	[Token(Token = "0x6001E6A")]
	public RendererList CreateWireOverlayRendererList(Camera camera) { }

	[Address(RVA = "0x30CA2A0", Offset = "0x30C96A0", Length = "0xEA")]
	[Token(Token = "0x6001E55")]
	private RendererList CreateWireOverlayRendererList_Internal(Camera camera) { }

	[Address(RVA = "0x30CA240", Offset = "0x30C9640", Length = "0x52")]
	[Token(Token = "0x6001E79")]
	private static void CreateWireOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, out RendererList ret) { }

	[Address(RVA = "0x30CA640", Offset = "0x30C9A40", Length = "0xED")]
	[Token(Token = "0x6001E5E")]
	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	[Address(RVA = "0x30CA4E0", Offset = "0x30C98E0", Length = "0x160")]
	[Token(Token = "0x6001E5F")]
	public void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos infos) { }

	[Address(RVA = "0x30CA770", Offset = "0x30C9B70", Length = "0x8C")]
	[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
	[Token(Token = "0x6001E4C")]
	public static void EmitGeometryForCamera(Camera camera) { }

	[Address(RVA = "0x30CA730", Offset = "0x30C9B30", Length = "0x33")]
	[Token(Token = "0x6001E71")]
	private static void EmitGeometryForCamera_Injected(IntPtr camera) { }

	[Address(RVA = "0x30CA800", Offset = "0x30C9C00", Length = "0xB7")]
	[Token(Token = "0x6001E61")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CA8C0", Offset = "0x30C9CC0", Length = "0x33")]
	[Token(Token = "0x6001E60")]
	public override bool Equals(ScriptableRenderContext other) { }

	[Address(RVA = "0x30CAC20", Offset = "0x30CA020", Length = "0x14D")]
	[Token(Token = "0x6001E5C")]
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	[Address(RVA = "0x30CABA0", Offset = "0x30C9FA0", Length = "0x7E")]
	[NativeThrows]
	[Token(Token = "0x6001E4D")]
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	[Address(RVA = "0x30CAB50", Offset = "0x30C9F50", Length = "0x42")]
	[Token(Token = "0x6001E72")]
	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer) { }

	[Address(RVA = "0x30CA9F0", Offset = "0x30C9DF0", Length = "0x15D")]
	[Token(Token = "0x6001E5D")]
	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x30CA960", Offset = "0x30C9D60", Length = "0x8E")]
	[NativeThrows]
	[Token(Token = "0x6001E4E")]
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x30CA900", Offset = "0x30C9D00", Length = "0x52")]
	[Token(Token = "0x6001E73")]
	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x30CADD0", Offset = "0x30CA1D0", Length = "0xB5")]
	[Token(Token = "0x6001E5B")]
	internal void GetCameras(List<Camera> results) { }

	[Address(RVA = "0x30CAD70", Offset = "0x30CA170", Length = "0x52")]
	[Token(Token = "0x6001E4B")]
	private void GetCameras_Internal(Type listType, object resultList) { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x6001E62")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30CAEC0", Offset = "0x30CA2C0", Length = "0x5B")]
	[Token(Token = "0x6001E5A")]
	public bool HasInvokeOnRenderObjectCallbacks() { }

	[Address(RVA = "0x30CAE90", Offset = "0x30CA290", Length = "0x2A")]
	[FreeFunction("ScriptableRenderContext::HasInvokeOnRenderObjectCallbacks")]
	[Token(Token = "0x6001E46")]
	private static bool HasInvokeOnRenderObjectCallbacks_Internal() { }

	[Address(RVA = "0x30CAF70", Offset = "0x30CA370", Length = "0x9B")]
	[FreeFunction("InitializeSortSettings")]
	[Token(Token = "0x6001E49")]
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	[Address(RVA = "0x30CAF20", Offset = "0x30CA320", Length = "0x42")]
	[Token(Token = "0x6001E70")]
	private static void InitializeSortSettings_Injected(IntPtr camera, out SortingSettings sortingSettings) { }

	[Address(RVA = "0x30CB130", Offset = "0x30CA530", Length = "0x7D")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
	[Token(Token = "0x6001E47")]
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	[Address(RVA = "0x30CB0D0", Offset = "0x30CA4D0", Length = "0x52")]
	[Token(Token = "0x6001E6E")]
	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, in ScriptableRenderContext renderLoop, IntPtr results) { }

	[Address(RVA = "0x30CB060", Offset = "0x30CA460", Length = "0x6D")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_CullShadowCasters")]
	[Token(Token = "0x6001E48")]
	private static void Internal_CullShadowCasters(ScriptableRenderContext renderLoop, IntPtr context) { }

	[Address(RVA = "0x30CB010", Offset = "0x30CA410", Length = "0x42")]
	[Token(Token = "0x6001E6F")]
	private static void Internal_CullShadowCasters_Injected(in ScriptableRenderContext renderLoop, IntPtr context) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001E4F")]
	internal IntPtr Internal_GetPtr() { }

	[Address(RVA = "0x30CB200", Offset = "0x30CA600", Length = "0x73")]
	[Token(Token = "0x6001E6B")]
	public void PrepareRendererListsAsync(List<RendererList> rendererLists) { }

	[Address(RVA = "0x30CB1B0", Offset = "0x30CA5B0", Length = "0x42")]
	[Token(Token = "0x6001E56")]
	private void PrepareRendererListsAsync_Internal(object rendererLists) { }

	[Address(RVA = "0x30CB350", Offset = "0x30CA750", Length = "0xB9")]
	[Token(Token = "0x6001E6C")]
	public RendererListStatus QueryRendererListStatus(RendererList rendererList) { }

	[Address(RVA = "0x30CB2D0", Offset = "0x30CA6D0", Length = "0x73")]
	[Token(Token = "0x6001E57")]
	private RendererListStatus QueryRendererListStatus_Internal(RendererList handle) { }

	[Address(RVA = "0x30CB280", Offset = "0x30CA680", Length = "0x42")]
	[Token(Token = "0x6001E7A")]
	private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, in RendererList handle) { }

	[Address(RVA = "0x30CB450", Offset = "0x30CA850", Length = "0x64")]
	[Token(Token = "0x6001E59")]
	public void Submit() { }

	[Address(RVA = "0x30CB410", Offset = "0x30CA810", Length = "0x33")]
	[Token(Token = "0x6001E4A")]
	private void Submit_Internal() { }

}

