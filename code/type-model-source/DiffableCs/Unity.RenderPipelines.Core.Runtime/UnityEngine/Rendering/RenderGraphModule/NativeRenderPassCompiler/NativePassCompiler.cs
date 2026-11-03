namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002B6")]
internal class NativePassCompiler : IDisposable
{
	[Token(Token = "0x20002B8")]
	public enum NativeCompilerProfileId : int
	{
		NRPRGComp_PrepareNativePass = 0,
		NRPRGComp_SetupContextData = 1,
		NRPRGComp_BuildGraph = 2,
		NRPRGComp_CullNodes = 3,
		NRPRGComp_TryMergeNativePasses = 4,
		NRPRGComp_FindResourceUsageRanges = 5,
		NRPRGComp_DetectMemorylessResources = 6,
		NRPRGComp_PropagateTextureUVOrigin = 7,
		NRPRGComp_ExecuteInitializeResources = 8,
		NRPRGComp_ExecuteBeginRenderpassCommand = 9,
		NRPRGComp_ExecuteDestroyResources = 10,
	}

	[Token(Token = "0x20002B7")]
	public struct RenderGraphInputInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C59")]
		public RenderGraphResourceRegistry m_ResourcesForDebugOnly; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C5A")]
		public List<RenderGraphPass> m_RenderPasses; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C5B")]
		public string debugName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C5C")]
		public bool disablePassCulling; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000C5D")]
		public bool disablePassMerging; //Field offset: 0x19
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C5E")]
		public RenderTextureUVOriginStrategy renderTextureUVOriginStrategy; //Field offset: 0x1C

	}

	[Token(Token = "0x4000C53")]
	internal const int k_EstimatedPassCount = 100; //Field offset: 0x0
	[Token(Token = "0x4000C54")]
	internal const int k_MaxSubpass = 8; //Field offset: 0x0
	[Token(Token = "0x4000C56")]
	internal static bool s_ForceGenerateAuditsForTests; //Field offset: 0x0
	[Token(Token = "0x4000C57")]
	private const int ArbitraryMaxNbMergedPasses = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C4A")]
	internal RenderGraphInputInfo graph; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C4B")]
	internal CompilerContextData contextData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C4C")]
	internal CompilerContextData defaultContextData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C4D")]
	internal CommandBuffer previousCommandBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C4E")]
	private Stack<Int32> m_HasSideEffectPassIdCullingStack; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C4F")]
	private List<Stack`1<ResourceHandle>> m_UnusedVersionedResourceIdCullingStacks; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C50")]
	private Dictionary<Int32, List`1<ResourceHandle>> m_DelayedLastUseListPerPassMap; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C51")]
	private RenderGraphCompilationCache m_CompilationCache; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C52")]
	private RenderTargetIdentifier[][] m_TempMRTArrays; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C55")]
	private NativeList<AttachmentDescriptor> m_BeginRenderPassAttachments; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C58")]
	private DynamicArray<Name> graphPassNamesForDebug; //Field offset: 0x78

	[Address(RVA = "0x2C9B9F0", Offset = "0x2C9ADF0", Length = "0x4AC")]
	[Token(Token = "0x6001351")]
	public NativePassCompiler(RenderGraphCompilationCache cache) { }

	[Address(RVA = "0x2C8F540", Offset = "0x2C8E940", Length = "0x169")]
	[Token(Token = "0x6001365")]
	private void AddDelayedLastUseToPass(in ResourceHandle releaseResource, int passId) { }

	[Address(RVA = "0x2C8F6B0", Offset = "0x2C8EAB0", Length = "0x369")]
	[Token(Token = "0x6001366")]
	public void AddLastUseFromDelayedList(ref PassData passData) { }

	[Address(RVA = "0x2C8FA20", Offset = "0x2C8EE20", Length = "0xA78")]
	[Token(Token = "0x600135D")]
	private void BuildGraph() { }

	[Address(RVA = "0x2C904A0", Offset = "0x2C8F8A0", Length = "0xF3")]
	[Token(Token = "0x6001354")]
	public void Cleanup() { }

	[Address(RVA = "0x2C90630", Offset = "0x2C8FA30", Length = "0x386")]
	[Token(Token = "0x6001358")]
	public void Clear(bool clearContextData) { }

	[Address(RVA = "0x2C905A0", Offset = "0x2C8F9A0", Length = "0x84")]
	[Token(Token = "0x6001364")]
	private void ClearDelayedLastUseListAtPass(int passId) { }

	[Address(RVA = "0x2C909C0", Offset = "0x2C8FDC0", Length = "0x114")]
	[Token(Token = "0x6001357")]
	public void Compile(RenderGraphResourceRegistry resources) { }

	[Address(RVA = "0x2C90AE0", Offset = "0x2C8FEE0", Length = "0x538")]
	[Token(Token = "0x600135F")]
	private void CullRenderGraphPassesWritingOnlyUnusedResources() { }

	[Address(RVA = "0x2C91020", Offset = "0x2C90420", Length = "0x3A0")]
	[Token(Token = "0x600135E")]
	private void CullUnusedRenderGraphPasses() { }

	[Address(RVA = "0x2C913D0", Offset = "0x2C907D0", Length = "0x4FD")]
	[Token(Token = "0x600136A")]
	private void DetectMemoryLessResources() { }

	[Address(RVA = "0x2C918D0", Offset = "0x2C90CD0", Length = "0x74D")]
	[Token(Token = "0x600136D")]
	private void DetermineLoadStoreActions(ref NativePassData nativePass) { }

	[Address(RVA = "0x2C92020", Offset = "0x2C91420", Length = "0x53")]
	[Token(Token = "0x6001353")]
	public override void Dispose() { }

	[Address(RVA = "0x2C92080", Offset = "0x2C91480", Length = "0x33A")]
	[Token(Token = "0x6001376")]
	private void EndRenderGraphPass(ref InternalRenderGraphContext rgContext, ref PassData passData, ref bool inRenderPass, RenderGraphResourceRegistry resources, bool nrpBegan) { }

	[Address(RVA = "0x2C923C0", Offset = "0x2C917C0", Length = "0xBB3")]
	[Token(Token = "0x6001370")]
	internal void ExecuteBeginRenderPass(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref NativePassData nativePass) { }

	[Address(RVA = "0x2C92F80", Offset = "0x2C92380", Length = "0x551")]
	[Token(Token = "0x6001371")]
	private void ExecuteDestroyResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref PassData pass) { }

	[Address(RVA = "0x2C934E0", Offset = "0x2C928E0", Length = "0x5AA")]
	[Token(Token = "0x6001375")]
	public void ExecuteGraph(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in List<RenderGraphPass>& passes) { }

	[Address(RVA = "0x2C93A90", Offset = "0x2C92E90", Length = "0x684")]
	[Token(Token = "0x600136C")]
	private bool ExecuteInitializeResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in PassData pass) { }

	[Address(RVA = "0x2C94120", Offset = "0x2C93520", Length = "0x33B")]
	[Token(Token = "0x6001374")]
	internal void ExecuteRenderGraphPass(ref InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, RenderGraphPass pass) { }

	[Address(RVA = "0x2C94460", Offset = "0x2C93860", Length = "0x2E9")]
	[Token(Token = "0x6001373")]
	internal void ExecuteSetRandomWriteTarget(in CommandBuffer cmd, RenderGraphResourceRegistry resources, int index, in ResourceHandle resource, bool preserveCounterValue = true) { }

	[Address(RVA = "0x2C94750", Offset = "0x2C93B50", Length = "0x52D")]
	[Token(Token = "0x6001372")]
	private void ExecuteSetRenderTargets(RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[Address(RVA = "0x2C94C80", Offset = "0x2C94080", Length = "0x57")]
	[Token(Token = "0x6001352")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2C94CE0", Offset = "0x2C940E0", Length = "0xC8")]
	[Token(Token = "0x6001362")]
	private int FindFirstNonCulledPassIdGoingBackward(int startPassId, bool startPassIsIncluded) { }

	[Address(RVA = "0x2C94DB0", Offset = "0x2C941B0", Length = "0xE3")]
	[Token(Token = "0x6001361")]
	private bool FindFirstPassIdOnGraphicsQueueAwaitingFenceGoingForward(ref PassData startAsyncPass, out int firstPassIdAwaiting) { }

	[Address(RVA = "0x2C94EA0", Offset = "0x2C942A0", Length = "0xAB4")]
	[Token(Token = "0x6001363")]
	private void FindResourceUsageRangeAndSynchronization() { }

	[Address(RVA = "0x2C95960", Offset = "0x2C94D60", Length = "0x2670")]
	[Token(Token = "0x600137B")]
	internal void GenerateNativeCompilerDebugData(ref DebugData debugData) { }

	[Address(RVA = "0x2C97FE0", Offset = "0x2C973E0", Length = "0x5C5")]
	[Token(Token = "0x6001356")]
	private void HandleExtendedFeatureFlags() { }

	[Address(RVA = "0x2C985B0", Offset = "0x2C979B0", Length = "0xF9")]
	[Token(Token = "0x6001355")]
	public bool Initialize(RenderGraphResourceRegistry resources, List<RenderGraphPass> renderPasses, RenderGraphDebugParams debugParams, string debugName, bool useCompilationCaching, int graphHash, int frameIndex, RenderTextureUVOriginStrategy renderTextureUVOriginStrategy) { }

	[Address(RVA = "0x2C986B0", Offset = "0x2C97AB0", Length = "0x15D")]
	[Token(Token = "0x600137A")]
	private static string InjectSpaces(string camelCaseString) { }

	[Address(RVA = "0x2C98810", Offset = "0x2C97C10", Length = "0x192")]
	[Token(Token = "0x6001369")]
	private static bool IsGlobalTextureInPass(RenderGraphPass pass, in ResourceHandle handle) { }

	[Address(RVA = "0x2C989B0", Offset = "0x2C97DB0", Length = "0x1A3")]
	[Token(Token = "0x600136B")]
	internal static bool IsSameNativeSubPass(ref SubPassDescriptor a, ref SubPassDescriptor b) { }

	[Address(RVA = "0x2C98B60", Offset = "0x2C97F60", Length = "0x5E2")]
	[Token(Token = "0x6001377")]
	private static AttachmentInfo MakeAttachmentInfo(CompilerContextData ctx, in NativePassData nativePass, int attachmentIndex) { }

	[Address(RVA = "0x2C99150", Offset = "0x2C98550", Length = "0x122")]
	[Token(Token = "0x6001378")]
	internal static string MakePassBreakInfoMessage(CompilerContextData ctx, in NativePassData nativePass) { }

	[Address(RVA = "0x2C99280", Offset = "0x2C98680", Length = "0x9E0")]
	[Token(Token = "0x6001379")]
	internal static string MakePassMergeMessage(CompilerContextData ctx, in PassData pass, in PassData prevPass, in PassBreakAudit mergeResult) { }

	[Address(RVA = "0x2C99CA0", Offset = "0x2C990A0", Length = "0xC4")]
	[Token(Token = "0x6001367")]
	private void PrepareNativeRenderPasses() { }

	[Address(RVA = "0x2C99D70", Offset = "0x2C99170", Length = "0x5E4")]
	[Token(Token = "0x6001368")]
	private void PropagateTextureUVOrigin() { }

	[Address(RVA = "0x2C9A360", Offset = "0x2C99760", Length = "0x15A")]
	[Token(Token = "0x6001359")]
	private void SetPassStatesForNativePass(int nativePassId) { }

	[Address(RVA = "0x2C9A4C0", Offset = "0x2C998C0", Length = "0x115")]
	[Token(Token = "0x600135B")]
	private void SetupContextData(RenderGraphResourceRegistry resources) { }

	[Address(RVA = "0x2C9A5E0", Offset = "0x2C999E0", Length = "0x3D2")]
	[Token(Token = "0x6001360")]
	private void TryMergeNativePasses() { }

	[Address(RVA = "0x2C9A9C0", Offset = "0x2C99DC0", Length = "0x9B9")]
	[Token(Token = "0x600135C")]
	private bool TrySetupRasterFragmentList(ref PassData ctxPass, ref RenderGraphPass inputPass, out string errorMessage) { }

	[Address(RVA = "0x2C9B380", Offset = "0x2C9A780", Length = "0x169")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600136F")]
	private void ValidateAttachment(in RenderTargetInfo attRenderTargetInfo, RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples, bool isVrs, bool isShaderResolve) { }

	[Address(RVA = "0x2C9B4F0", Offset = "0x2C9A8F0", Length = "0x212")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600136E")]
	private void ValidateNativePass(in NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount) { }

	[Address(RVA = "0x2C9B710", Offset = "0x2C9AB10", Length = "0x2D6")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600135A")]
	private void ValidatePasses() { }

}

