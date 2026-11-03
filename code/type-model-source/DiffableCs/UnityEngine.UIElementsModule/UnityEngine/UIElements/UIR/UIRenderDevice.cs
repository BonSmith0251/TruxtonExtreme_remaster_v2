namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000581")]
internal class UIRenderDevice : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000588")]
	private sealed class <>c
	{
		[Token(Token = "0x40012BF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40012C0")]
		public static Func<MeshHandle> <>9__51_0; //Field offset: 0x8
		[Token(Token = "0x40012C1")]
		public static Action<MeshHandle> <>9__51_1; //Field offset: 0x10

		[Address(RVA = "0x33027C0", Offset = "0x3301BC0", Length = "0x67")]
		[Token(Token = "0x6002831")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002832")]
		public <>c() { }

		[Address(RVA = "0x3302770", Offset = "0x3301B70", Length = "0x44")]
		[Token(Token = "0x6002833")]
		internal MeshHandle <.ctor>b__51_0() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002834")]
		internal void <.ctor>b__51_1(MeshHandle mh) { }

	}

	[Token(Token = "0x2000583")]
	private struct AllocToFree
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001292")]
		public Alloc alloc; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001293")]
		public Page page; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001294")]
		public bool vertices; //Field offset: 0x20

	}

	[Token(Token = "0x2000582")]
	public struct AllocToUpdate
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128B")]
		public uint id; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400128C")]
		public uint allocTime; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400128D")]
		public MeshHandle meshHandle; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400128E")]
		public Alloc permAllocVerts; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400128F")]
		public Alloc permAllocIndices; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001290")]
		public Page permPage; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001291")]
		public bool copyBackIndices; //Field offset: 0x48

	}

	[Token(Token = "0x2000584")]
	private struct DeviceToFree
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001295")]
		public uint handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001296")]
		public Page page; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001297")]
		public CommandListManager commandListManager; //Field offset: 0x10

		[Address(RVA = "0x32F19C0", Offset = "0x32F0DC0", Length = "0xBC")]
		[Token(Token = "0x6002830")]
		public void Dispose() { }

	}

	[Token(Token = "0x2000587")]
	public struct DrawStatistics
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B4")]
		public int currentFrameIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40012B5")]
		public uint totalIndices; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40012B6")]
		public uint commandCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40012B7")]
		public uint skippedCommandCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012B8")]
		public uint drawCommandCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40012B9")]
		public uint disableCommandCount; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012BA")]
		public uint materialSetCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40012BB")]
		public uint drawRangeCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012BC")]
		public uint drawRangeCallCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40012BD")]
		public uint immediateDraws; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40012BE")]
		public uint stencilRefChanges; //Field offset: 0x28

	}

	[Flags]
	[Token(Token = "0x2000585")]
	private enum EvaluationFlags : int
	{
		None = 0,
		MustApplyMaterial = 1,
		MustApplyBatchProps = 2,
		MustApplyStencil = 4,
		ForceRenderTypeBitOffset = 3,
		ForceRenderTypeSolid = 8,
		ForceRenderTypeTextured = 16,
		ForceRenderTypeText = 24,
		ForceRenderTypeSvgGradient = 32,
		ForceRenderTypeBits = 56,
		TextureSlotCountBitOffset = 6,
		TextureSlotCount1 = 64,
		TextureSlotCount2 = 128,
		TextureSlotCount4 = 192,
		TextureSlotCount8 = 256,
		TextureSlotCountBits = 448,
		IsSerializing = 512,
		IsRenderingNestedTreeRT = 1024,
	}

	[Token(Token = "0x2000586")]
	private struct EvaluationState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AB")]
		public CommandList activeCommandList; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40012AC")]
		public MaterialPropertyBlock constantProps; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012AD")]
		public MaterialPropertyBlock batchProps; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012AE")]
		public MaterialPropertyBlock userProps; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012AF")]
		public Material material; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40012B0")]
		public int stencilRef; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40012B1")]
		public Page curPage; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40012B2")]
		public EvaluationFlags flags; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40012B3")]
		public VisualElement commandListOwner; //Field offset: 0x40

	}

	[Token(Token = "0x4001265")]
	internal const uint k_MaxQueuedFrameCount = 4; //Field offset: 0x0
	[Token(Token = "0x4001266")]
	internal const int k_PruneEmptyPageFrameCount = 60; //Field offset: 0x0
	[Token(Token = "0x400127A")]
	private static LinkedList<DeviceToFree> m_DeviceFreeQueue; //Field offset: 0x0
	[Token(Token = "0x400127B")]
	private static int m_ActiveDeviceCount; //Field offset: 0x8
	[Token(Token = "0x400127C")]
	private static bool m_SubscribedToNotifications; //Field offset: 0xC
	[Token(Token = "0x400127D")]
	private static bool m_SynchronousFree; //Field offset: 0xD
	[Token(Token = "0x400127E")]
	private static readonly int s_GradientSettingsTexID; //Field offset: 0x10
	[Token(Token = "0x400127F")]
	private static readonly int s_ShaderInfoTexID; //Field offset: 0x14
	[Token(Token = "0x4001280")]
	private static ProfilerMarker s_MarkerAllocate; //Field offset: 0x18
	[Token(Token = "0x4001281")]
	private static ProfilerMarker s_MarkerFree; //Field offset: 0x20
	[Token(Token = "0x4001282")]
	private static ProfilerMarker s_MarkerAdvanceFrame; //Field offset: 0x28
	[Token(Token = "0x4001283")]
	private static ProfilerMarker s_MarkerFence; //Field offset: 0x30
	[Token(Token = "0x4001284")]
	private static ProfilerMarker s_MarkerBeforeDraw; //Field offset: 0x38
	[Token(Token = "0x4001289")]
	private static readonly Int32[] s_EvaluationFlagsToTextureSlotCount; //Field offset: 0x40
	[Token(Token = "0x400128A")]
	private static readonly Int32[] s_TextureSlotCountToEvaluationFlags; //Field offset: 0x48
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001267")]
	private IntPtr m_DefaultStencilState; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001268")]
	private IntPtr m_VertexDecl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001269")]
	private Page m_FirstPage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400126A")]
	private uint m_NextPageVertexCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400126B")]
	private uint m_LargeMeshVertexCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400126C")]
	private float m_IndexToVertexCountRatio; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400126D")]
	private List<List`1<AllocToFree>> m_DeferredFrees; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400126E")]
	private List<List`1<AllocToUpdate>> m_Updates; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400126F")]
	private CommandListManager m_CommandListManager; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001270")]
	private UInt32[] m_Fences; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001271")]
	private MaterialPropertyBlock m_ConstantProps; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001272")]
	private MaterialPropertyBlock m_BatchProps; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001273")]
	private uint m_FrameIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001274")]
	private uint m_NextUpdateID; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001275")]
	private DrawStatistics m_DrawStats; //Field offset: 0x70
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001276")]
	private readonly LinkedPool<MeshHandle> m_MeshHandles; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001277")]
	private readonly DrawParams m_DrawParams; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001278")]
	private readonly TextureSlotManager m_TextureSlotManager; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001279")]
	private HashSet<Material> m_ScreenSpaceAlteredMaterials; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001285")]
	private bool <breakBatches>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x4001286")]
	private readonly bool <isFlat>k__BackingField; //Field offset: 0xC1
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC2")]
	[Token(Token = "0x4001287")]
	private readonly bool <forceGammaRendering>k__BackingField; //Field offset: 0xC2
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC3")]
	[Token(Token = "0x4001288")]
	private bool <disposed>k__BackingField; //Field offset: 0xC3

	[Token(Token = "0x17000A34")]
	internal bool breakBatches
	{
		[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002805")]
		internal get { } //Length: 8
		[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002806")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000A37")]
	protected private bool disposed
	{
		[Address(RVA = "0x290A020", Offset = "0x2909420", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600280C")]
		 get { } //Length: 8
		[Address(RVA = "0x32E5DB0", Offset = "0x32E51B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600280D")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000A36")]
	internal bool forceGammaRendering
	{
		[Address(RVA = "0x290A030", Offset = "0x2909430", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002808")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A35")]
	internal bool isFlat
	{
		[Address(RVA = "0x32E5DA0", Offset = "0x32E51A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002807")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A33")]
	internal static uint maxVerticesPerPage
	{
		[Address(RVA = "0x1F52210", Offset = "0x1F51610", Length = "0x6")]
		[Token(Token = "0x6002804")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x32E4F80", Offset = "0x32E4380", Length = "0x514")]
	[Token(Token = "0x6002809")]
	private static UIRenderDevice() { }

	[Address(RVA = "0x32E54A0", Offset = "0x32E48A0", Length = "0x8F1")]
	[Token(Token = "0x600280A")]
	public UIRenderDevice(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0, bool isFlat = true, bool forceGammaRendering = false) { }

	[Address(RVA = "0x32DED70", Offset = "0x32DE170", Length = "0x68")]
	[Token(Token = "0x6002814")]
	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	[Address(RVA = "0x32DEDE0", Offset = "0x32DE1E0", Length = "0xCDE")]
	[Token(Token = "0x6002827")]
	public void AdvanceFrame() { }

	[Address(RVA = "0x32DFAC0", Offset = "0x32DEEC0", Length = "0xCB")]
	[Token(Token = "0x6002810")]
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[Address(RVA = "0x32DFB90", Offset = "0x32DEF90", Length = "0x793")]
	[Token(Token = "0x6002816")]
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, bool shortLived) { }

	[Address(RVA = "0x32E0330", Offset = "0x32DF730", Length = "0xB76")]
	[Token(Token = "0x600281E")]
	private void ApplyBatchState(ref EvaluationState st) { }

	[Address(RVA = "0x32E0EB0", Offset = "0x32E02B0", Length = "0x2C8")]
	[Token(Token = "0x600281D")]
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, MaterialPropertyBlock userProps, EvaluationFlags defaultTextureSlotCountFlags, bool kickRanges, Texture gradientSettings, Texture shaderInfo, ref EvaluationState st) { }

	[Address(RVA = "0x32E13A0", Offset = "0x32E07A0", Length = "0x61")]
	[Token(Token = "0x600280E")]
	public override void Dispose() { }

	[Address(RVA = "0x32E1180", Offset = "0x32E0580", Length = "0x210")]
	[Token(Token = "0x600280F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x32E1410", Offset = "0x32E0810", Length = "0x2DD")]
	[Token(Token = "0x6002825")]
	private void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList) { }

	[Address(RVA = "0x32E16F0", Offset = "0x32E0AF0", Length = "0xD07")]
	[Token(Token = "0x600281F")]
	public void EvaluateChain(RenderChainCommand head, Material defaultMat, Texture gradientSettings, Texture shaderInfo, Nullable<Rect> scissor, float pixelsPerPoint, bool isSerializing, TextureSlotCount defaultTextureSlotCount, bool isRenderingNestedTreeRT, ref Exception immediateException) { }

	[Address(RVA = "0x32E2400", Offset = "0x32E1800", Length = "0x73")]
	[Token(Token = "0x600281B")]
	private static int FlagsToTextureSlotCount(EvaluationFlags flags) { }

	[Address(RVA = "0x32E2480", Offset = "0x32E1880", Length = "0x82")]
	[Token(Token = "0x600282B")]
	internal static void FlushAllPendingDeviceDisposes() { }

	[Address(RVA = "0x32E2510", Offset = "0x32E1910", Length = "0x665")]
	[Token(Token = "0x6002818")]
	public void Free(MeshHandle mesh) { }

	[Address(RVA = "0x32E2B80", Offset = "0x32E1F80", Length = "0x2C")]
	[Token(Token = "0x600282C")]
	internal DrawStatistics GatherDrawStatistics() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002805")]
	internal bool get_breakBatches() { }

	[Address(RVA = "0x290A020", Offset = "0x2909420", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600280C")]
	protected bool get_disposed() { }

	[Address(RVA = "0x290A030", Offset = "0x2909430", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002808")]
	internal bool get_forceGammaRendering() { }

	[Address(RVA = "0x32E5DA0", Offset = "0x32E51A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002807")]
	internal bool get_isFlat() { }

	[Address(RVA = "0x1F52210", Offset = "0x1F51610", Length = "0x6")]
	[Token(Token = "0x6002804")]
	internal static uint get_maxVerticesPerPage() { }

	[Address(RVA = "0x32E2F60", Offset = "0x32E2360", Length = "0x11D")]
	[Token(Token = "0x6002821")]
	private void InitializeConstantProperties(MaterialPropertyBlock constantProps, Texture gradientSettings, Texture shaderInfo) { }

	[Address(RVA = "0x32E2BB0", Offset = "0x32E1FB0", Length = "0x3A8")]
	[Token(Token = "0x600280B")]
	private void InitVertexDeclaration() { }

	[Address(RVA = "0x32E3080", Offset = "0x32E2480", Length = "0x2BD")]
	[Token(Token = "0x6002824")]
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList) { }

	[Address(RVA = "0x32E3340", Offset = "0x32E2740", Length = "0x40")]
	[Token(Token = "0x600282E")]
	private static void OnEngineUpdateGlobal() { }

	[Address(RVA = "0x32E3380", Offset = "0x32E2780", Length = "0x55")]
	[Token(Token = "0x600282F")]
	private static void OnFlushPendingResources() { }

	[Address(RVA = "0x32E33E0", Offset = "0x32E27E0", Length = "0xAF")]
	[Token(Token = "0x6002819")]
	public void OnFrameRenderingBegin() { }

	[Address(RVA = "0x32E3490", Offset = "0x32E2890", Length = "0x53")]
	[Token(Token = "0x6002829")]
	internal static void PrepareForGfxDeviceRecreate() { }

	[Address(RVA = "0x32E34F0", Offset = "0x32E28F0", Length = "0x320")]
	[Token(Token = "0x600282D")]
	public static void ProcessDeviceFreeQueue() { }

	[Address(RVA = "0x32E3820", Offset = "0x32E2C20", Length = "0x129")]
	[Token(Token = "0x6002828")]
	private void PruneUnusedPages() { }

	[Address(RVA = "0x9A8280", Offset = "0x9A7680", Length = "0x78")]
	[Token(Token = "0x600281A")]
	internal static NativeSlice<T> PtrToSlice(Void* p, int count) { }

	[Address(RVA = "0x32E3950", Offset = "0x32E2D50", Length = "0x293")]
	[Token(Token = "0x6002820")]
	private void ResetScreenSpaceMaterials() { }

	[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6002806")]
	internal void set_breakBatches(bool value) { }

	[Address(RVA = "0x32E5DB0", Offset = "0x32E51B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600280D")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x32E3BF0", Offset = "0x32E2FF0", Length = "0x217")]
	[Token(Token = "0x6002822")]
	private void SetupCommandList(ref EvaluationState st, Texture gradientSettings, Texture shaderInfo, CommandFlags commandFlags) { }

	[Address(RVA = "0x32E3E10", Offset = "0x32E3210", Length = "0x71")]
	[Token(Token = "0x600281C")]
	private static EvaluationFlags TextureSlotCountToFlags(TextureSlotCount count) { }

	[Address(RVA = "0x32E3E90", Offset = "0x32E3290", Length = "0x145")]
	[Token(Token = "0x6002815")]
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	[Address(RVA = "0x32E4B90", Offset = "0x32E3F90", Length = "0x2D4")]
	[Token(Token = "0x6002812")]
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[Address(RVA = "0x32E4950", Offset = "0x32E3D50", Length = "0x230")]
	[Token(Token = "0x6002811")]
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex>& vertexData) { }

	[Address(RVA = "0x32E3FE0", Offset = "0x32E33E0", Length = "0x742")]
	[Token(Token = "0x6002817")]
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	[Address(RVA = "0x32E4730", Offset = "0x32E3B30", Length = "0x144")]
	[Token(Token = "0x6002813")]
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	[Address(RVA = "0x32E4880", Offset = "0x32E3C80", Length = "0xCF")]
	[Token(Token = "0x6002823")]
	private void UpdateFenceValue() { }

	[Address(RVA = "0x32E4E70", Offset = "0x32E4270", Length = "0xA8")]
	[Token(Token = "0x6002826")]
	private void WaitOnCpuFence(uint fence) { }

	[Address(RVA = "0x32E4F20", Offset = "0x32E4320", Length = "0x53")]
	[Token(Token = "0x600282A")]
	internal static void WrapUpGfxDeviceRecreate() { }

}

