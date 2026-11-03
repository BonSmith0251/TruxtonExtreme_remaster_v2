namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005D0")]
internal class RenderTreeManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20005D5")]
	private sealed class <>c
	{
		[Token(Token = "0x4001529")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400152A")]
		public static Func<RenderChainCommand> <>9__40_0; //Field offset: 0x8
		[Token(Token = "0x400152B")]
		public static Action<RenderChainCommand> <>9__40_1; //Field offset: 0x10
		[Token(Token = "0x400152C")]
		public static Func<ExtraRenderData> <>9__40_2; //Field offset: 0x18
		[Token(Token = "0x400152D")]
		public static Func<RenderData> <>9__40_3; //Field offset: 0x20
		[Token(Token = "0x400152E")]
		public static Func<RenderTree> <>9__40_4; //Field offset: 0x28

		[Address(RVA = "0x332A3A0", Offset = "0x33297A0", Length = "0x67")]
		[Token(Token = "0x6002A03")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002A04")]
		public <>c() { }

		[Address(RVA = "0x332A160", Offset = "0x3329560", Length = "0x44")]
		[Token(Token = "0x6002A05")]
		internal RenderChainCommand <.ctor>b__40_0() { }

		[Address(RVA = "0x332A1B0", Offset = "0x33295B0", Length = "0x1F")]
		[Token(Token = "0x6002A06")]
		internal void <.ctor>b__40_1(RenderChainCommand cmd) { }

		[Address(RVA = "0x332A1D0", Offset = "0x33295D0", Length = "0x44")]
		[Token(Token = "0x6002A07")]
		internal ExtraRenderData <.ctor>b__40_2() { }

		[Address(RVA = "0x332A220", Offset = "0x3329620", Length = "0x44")]
		[Token(Token = "0x6002A08")]
		internal RenderData <.ctor>b__40_3() { }

		[Address(RVA = "0x332A270", Offset = "0x3329670", Length = "0x44")]
		[Token(Token = "0x6002A09")]
		internal RenderTree <.ctor>b__40_4() { }

	}

	[Token(Token = "0x20005D1")]
	public struct ElementInsertionData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001518")]
		public VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001519")]
		public bool canceled; //Field offset: 0x8

	}

	[Token(Token = "0x20005D2")]
	public class VisualChangesProcessor : IDisposable
	{
		[Token(Token = "0x20005D4")]
		private struct EntryProcessingInfo
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001526")]
			public RenderData renderData; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4001527")]
			public VisualsProcessingType type; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4001528")]
			public Entry rootEntry; //Field offset: 0x10

		}

		[Token(Token = "0x20005D3")]
		private enum VisualsProcessingType : int
		{
			Head = 0,
			Tail = 1,
		}

		[Token(Token = "0x400151A")]
		private static readonly ProfilerMarker k_GenerateEntriesMarker; //Field offset: 0x0
		[Token(Token = "0x400151B")]
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; //Field offset: 0x8
		[Token(Token = "0x400151C")]
		private static readonly ProfilerMarker k_UpdateOpacityIdMarker; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400151D")]
		private RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400151E")]
		private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400151F")]
		private BaseElementBuilder m_ElementBuilder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001520")]
		private List<EntryProcessingInfo> m_EntryProcessingList; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001521")]
		private List<EntryProcessor> m_Processors; //Field offset: 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001522")]
		private bool <disposed>k__BackingField; //Field offset: 0x38

		[Token(Token = "0x17000A86")]
		protected private bool disposed
		{
			[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60029FE")]
			 get { } //Length: 5
			[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60029FF")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000A84")]
		public BaseElementBuilder elementBuilder
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60029F4")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000A85")]
		public MeshGenerationContext meshGenerationContext
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60029F5")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x3316820", Offset = "0x3315C20", Length = "0xD2")]
		[Token(Token = "0x6002A02")]
		private static VisualChangesProcessor() { }

		[Address(RVA = "0x3316900", Offset = "0x3315D00", Length = "0x68E")]
		[Token(Token = "0x60029F6")]
		public VisualChangesProcessor(RenderTreeManager renderTreeManager) { }

		[Address(RVA = "0x3315AC0", Offset = "0x3314EC0", Length = "0x26B")]
		[Token(Token = "0x60029FB")]
		public void ConvertEntriesToCommands(ref ChainBuilderStats stats) { }

		[Address(RVA = "0x3315D30", Offset = "0x3315130", Length = "0x5F0")]
		[Token(Token = "0x60029F9")]
		private void DepthFirstOnVisualsChanged(RenderData renderData, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats) { }

		[Address(RVA = "0x3316330", Offset = "0x3315730", Length = "0x7B")]
		[Token(Token = "0x6002A00")]
		public override void Dispose() { }

		[Address(RVA = "0x33163B0", Offset = "0x33157B0", Length = "0x45")]
		[Token(Token = "0x6002A01")]
		protected void Dispose(bool disposing) { }

		[Address(RVA = "0x3316400", Offset = "0x3315800", Length = "0x21C")]
		[Token(Token = "0x60029FD")]
		private static void DoUpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager, MeshHandle mesh) { }

		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60029FE")]
		protected bool get_disposed() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60029F4")]
		public BaseElementBuilder get_elementBuilder() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60029F5")]
		public MeshGenerationContext get_meshGenerationContext() { }

		[Address(RVA = "0x3316620", Offset = "0x3315A20", Length = "0x4F")]
		[Token(Token = "0x60029F8")]
		public void ProcessOnVisualsChanged(RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

		[Address(RVA = "0x3316670", Offset = "0x3315A70", Length = "0x31")]
		[Token(Token = "0x60029F7")]
		public void ScheduleMeshGenerationJobs() { }

		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60029FF")]
		private void set_disposed(bool value) { }

		[Address(RVA = "0x33166B0", Offset = "0x3315AB0", Length = "0x121")]
		[Token(Token = "0x60029FC")]
		public static void UpdateOpacityId(RenderData renderData, RenderTreeManager renderTreeManager) { }

		[Address(RVA = "0x33167E0", Offset = "0x3315BE0", Length = "0x3B")]
		[Token(Token = "0x60029FA")]
		private static void UpdateWorldFlipsWinding(RenderData renderData) { }

	}

	[Token(Token = "0x4001505")]
	private static EntryPool s_SharedEntryPool; //Field offset: 0x0
	[Token(Token = "0x4001506")]
	private static readonly ProfilerMarker k_MarkerProcess; //Field offset: 0x8
	[Token(Token = "0x4001507")]
	private static readonly ProfilerMarker k_MarkerSerialize; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014F1")]
	private RenderTreeCompositor m_Compositor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014F2")]
	private VisualChangesProcessor m_VisualChangesProcessor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014F3")]
	private LinkedPool<RenderChainCommand> m_CommandPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014F4")]
	private LinkedPool<ExtraRenderData> m_ExtraDataPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014F5")]
	private BasicNodePool<MeshHandle> m_MeshHandleNodePool; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014F6")]
	private BasicNodePool<GraphicEntry> m_GraphicEntryPool; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014F7")]
	private Dictionary<RenderData, ExtraRenderData> m_ExtraData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014F8")]
	internal List<ElementInsertionData> m_InsertionList; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40014F9")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014FA")]
	private Material m_DefaultMat; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014FB")]
	private bool m_BlockDirtyRegistration; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40014FC")]
	private ChainBuilderStats m_Stats; //Field offset: 0x64
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40014FD")]
	private uint m_StatsElementsAdded; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40014FE")]
	private uint m_StatsElementsRemoved; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40014FF")]
	private TextureRegistry m_TextureRegistry; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001500")]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001501")]
	private ObjectPool<RenderData> m_RenderDataPool; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001502")]
	private ObjectPool<RenderTree> m_RenderTreePool; //Field offset: 0xE0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001503")]
	private bool <blockDirtyRegistration>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4001504")]
	private TextureSlotCount <textureSlotCount>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001508")]
	private bool <disposed>k__BackingField; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001509")]
	private RenderTree m_RootRenderTree; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400150A")]
	private BaseVisualElementPanel <panel>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400150B")]
	private UIRenderDevice <device>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400150C")]
	private AtlasBase <atlas>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400150D")]
	private VectorImageManager <vectorImageManager>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400150E")]
	private TempMeshAllocatorImpl <tempMeshAllocator>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400150F")]
	private readonly MeshWriteDataPool <meshWriteDataPool>k__BackingField; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001510")]
	public EntryRecorder entryRecorder; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001511")]
	private MeshGenerationNodeManager <meshGenerationNodeManager>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001512")]
	private JobManager <jobManager>k__BackingField; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001513")]
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; //Field offset: 0x148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4001514")]
	private bool <drawStats>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x151")]
	[Token(Token = "0x4001515")]
	private readonly bool <drawInCameras>k__BackingField; //Field offset: 0x151
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x152")]
	[Token(Token = "0x4001516")]
	private readonly bool <isFlat>k__BackingField; //Field offset: 0x152
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x153")]
	[Token(Token = "0x4001517")]
	private readonly bool <forceGammaRendering>k__BackingField; //Field offset: 0x153

	[Token(Token = "0x17000A78")]
	internal AtlasBase atlas
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029D4")]
		internal get { } //Length: 8
		[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029D5")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A76")]
	internal UIRenderDevice device
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029D1")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029D2")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A72")]
	protected private bool disposed
	{
		[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029B5")]
		 get { } //Length: 8
		[Address(RVA = "0x3312AA0", Offset = "0x3311EA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60029B6")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000A81")]
	internal bool drawInCameras
	{
		[Address(RVA = "0x1D5FD70", Offset = "0x1D5F170", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029E3")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A80")]
	internal bool drawStats
	{
		[Address(RVA = "0x1D5FD80", Offset = "0x1D5F180", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029E1")]
		internal get { } //Length: 8
		[Address(RVA = "0x1D5DF20", Offset = "0x1D5D320", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60029E2")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000A77")]
	public BaseElementBuilder elementBuilder
	{
		[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
		[Token(Token = "0x60029D3")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000A7C")]
	internal EntryPool entryPool
	{
		[Address(RVA = "0x3312A40", Offset = "0x3311E40", Length = "0x4E")]
		[Token(Token = "0x60029DB")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000A83")]
	public bool forceGammaRendering
	{
		[Address(RVA = "0x1D5FD90", Offset = "0x1D5F190", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029E5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000A82")]
	internal bool isFlat
	{
		[Address(RVA = "0x3312A90", Offset = "0x3311E90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029E4")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A7F")]
	internal JobManager jobManager
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029DF")]
		internal get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029E0")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A7D")]
	public MeshGenerationDeferrer meshGenerationDeferrer
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60029DC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A7E")]
	public private MeshGenerationNodeManager meshGenerationNodeManager
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029DD")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029DE")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A7B")]
	internal MeshWriteDataPool meshWriteDataPool
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029DA")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A70")]
	public private OpacityIdAccelerator opacityIdAccelerator
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029AC")]
		 get { } //Length: 8
		[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029AD")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A75")]
	internal BaseVisualElementPanel panel
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029CF")]
		internal get { } //Length: 8
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029D0")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A74")]
	internal RenderTree rootRenderTree
	{
		[Address(RVA = "0x3312AB0", Offset = "0x3311EB0", Length = "0x7F")]
		[Token(Token = "0x60029BB")]
		internal set { } //Length: 127
	}

	[Token(Token = "0x17000A73")]
	internal ChainBuilderStats statsByRef
	{
		[Address(RVA = "0x2822E40", Offset = "0x2822240", Length = "0x5")]
		[Token(Token = "0x60029BA")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000A7A")]
	internal TempMeshAllocatorImpl tempMeshAllocator
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029D8")]
		internal get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029D9")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A6E")]
	internal TextureRegistry textureRegistry
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x60029AA")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000A71")]
	public TextureSlotCount textureSlotCount
	{
		[Address(RVA = "0x2D67D60", Offset = "0x2D67160", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60029AE")]
		 get { } //Length: 7
		[Address(RVA = "0x2D687D0", Offset = "0x2D67BD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60029AF")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000A79")]
	internal VectorImageManager vectorImageManager
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60029D6")]
		internal get { } //Length: 8
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60029D7")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A6F")]
	internal VisualChangesProcessor visualChangesProcessor
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60029AB")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x3311830", Offset = "0x3310C30", Length = "0xF0")]
	[Token(Token = "0x60029F3")]
	private static RenderTreeManager() { }

	[Address(RVA = "0x3311920", Offset = "0x3310D20", Length = "0x1111")]
	[Token(Token = "0x60029B4")]
	public RenderTreeManager(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x330DDE0", Offset = "0x330D1E0", Length = "0x44")]
	[Token(Token = "0x60029E6")]
	internal RenderChainCommand AllocCommand() { }

	[Address(RVA = "0x330DE30", Offset = "0x330D230", Length = "0x11B")]
	[Token(Token = "0x60029C2")]
	public void CancelInsertion(VisualElement ve) { }

	[Address(RVA = "0x330DF50", Offset = "0x330D350", Length = "0x5A")]
	[Token(Token = "0x60029BC")]
	private void DepthFirstProcessChanges(RenderTree renderTree) { }

	[Address(RVA = "0x330DFB0", Offset = "0x330D3B0", Length = "0x77")]
	[Token(Token = "0x60029EA")]
	private void DepthFirstRepaintTextured(RenderData renderData) { }

	[Address(RVA = "0x330E030", Offset = "0x330D430", Length = "0xBF")]
	[Token(Token = "0x60029E9")]
	private void DepthFirstRepaintTextured(RenderTree renderTree) { }

	[Address(RVA = "0x330E0F0", Offset = "0x330D4F0", Length = "0x56")]
	[Token(Token = "0x60029B7")]
	public override void Dispose() { }

	[Address(RVA = "0x330E150", Offset = "0x330D550", Length = "0x4BC")]
	[Token(Token = "0x60029B8")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x330E610", Offset = "0x330DA10", Length = "0xA01")]
	[Token(Token = "0x60029F2")]
	private void DrawStats() { }

	[Address(RVA = "0x330F020", Offset = "0x330E420", Length = "0x62")]
	[Token(Token = "0x60029E7")]
	internal void FreeCommand(RenderChainCommand cmd) { }

	[Address(RVA = "0x330F090", Offset = "0x330E490", Length = "0xE7")]
	[Token(Token = "0x60029EC")]
	public void FreeExtraData(RenderData renderData) { }

	[Address(RVA = "0x330F180", Offset = "0x330E580", Length = "0x11D")]
	[Token(Token = "0x60029EE")]
	public void FreeExtraMeshes(RenderData renderData) { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029D4")]
	internal AtlasBase get_atlas() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029D1")]
	internal UIRenderDevice get_device() { }

	[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029B5")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1D5FD70", Offset = "0x1D5F170", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029E3")]
	internal bool get_drawInCameras() { }

	[Address(RVA = "0x1D5FD80", Offset = "0x1D5F180", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029E1")]
	internal bool get_drawStats() { }

	[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
	[Token(Token = "0x60029D3")]
	public BaseElementBuilder get_elementBuilder() { }

	[Address(RVA = "0x3312A40", Offset = "0x3311E40", Length = "0x4E")]
	[Token(Token = "0x60029DB")]
	internal EntryPool get_entryPool() { }

	[Address(RVA = "0x1D5FD90", Offset = "0x1D5F190", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029E5")]
	public bool get_forceGammaRendering() { }

	[Address(RVA = "0x3312A90", Offset = "0x3311E90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029E4")]
	internal bool get_isFlat() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029DF")]
	internal JobManager get_jobManager() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60029DC")]
	public MeshGenerationDeferrer get_meshGenerationDeferrer() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029DD")]
	public MeshGenerationNodeManager get_meshGenerationNodeManager() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029DA")]
	internal MeshWriteDataPool get_meshWriteDataPool() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029AC")]
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029CF")]
	internal BaseVisualElementPanel get_panel() { }

	[Address(RVA = "0x2822E40", Offset = "0x2822240", Length = "0x5")]
	[Token(Token = "0x60029BA")]
	internal ChainBuilderStats get_statsByRef() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029D8")]
	internal TempMeshAllocatorImpl get_tempMeshAllocator() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x60029AA")]
	internal TextureRegistry get_textureRegistry() { }

	[Address(RVA = "0x2D67D60", Offset = "0x2D67160", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60029AE")]
	public TextureSlotCount get_textureSlotCount() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60029D6")]
	internal VectorImageManager get_vectorImageManager() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60029AB")]
	internal VisualChangesProcessor get_visualChangesProcessor() { }

	[Address(RVA = "0x330F2A0", Offset = "0x330E6A0", Length = "0xC1")]
	[Token(Token = "0x60029EB")]
	public ExtraRenderData GetOrAddExtraData(RenderData renderData) { }

	[Address(RVA = "0x330F370", Offset = "0x330E770", Length = "0x5D")]
	[Token(Token = "0x60029B0")]
	internal RenderData GetPooledRenderData() { }

	[Address(RVA = "0x330F3D0", Offset = "0x330E7D0", Length = "0x202")]
	[Token(Token = "0x60029B2")]
	internal RenderTree GetPooledRenderTree(RenderTreeManager renderTreeManager, RenderData rootRenderData) { }

	[Address(RVA = "0x330F5E0", Offset = "0x330E9E0", Length = "0xBE")]
	[Token(Token = "0x60029ED")]
	public void InsertExtraMesh(RenderData renderData, MeshHandle mesh) { }

	[Address(RVA = "0x330F6A0", Offset = "0x330EAA0", Length = "0xB3")]
	[Token(Token = "0x60029EF")]
	public void InsertTexture(RenderData renderData, Texture src, TextureId id, bool isAtlas) { }

	[Address(RVA = "0x330F760", Offset = "0x330EB60", Length = "0x9C")]
	[Token(Token = "0x60029F0")]
	public void InsertVectorImage(RenderData renderData, VectorImage vi) { }

	[Address(RVA = "0x330F800", Offset = "0x330EC00", Length = "0x5AE")]
	[Token(Token = "0x60029BD")]
	public void ProcessChanges() { }

	[Address(RVA = "0x330FDB0", Offset = "0x330F1B0", Length = "0x1FE")]
	[Token(Token = "0x60029C4")]
	private void ProcessChildAdded(VisualElement ve) { }

	[Address(RVA = "0x33028A0", Offset = "0x3301CA0", Length = "0x679")]
	[Token(Token = "0x60029C8")]
	private void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyClasses) { }

	[Address(RVA = "0x330FFB0", Offset = "0x330F3B0", Length = "0x22")]
	[Token(Token = "0x60029C0")]
	private void RenderNestedTrees() { }

	[Address(RVA = "0x330FFE0", Offset = "0x330F3E0", Length = "0x22F")]
	[Token(Token = "0x60029BF")]
	public void RenderRootTree() { }

	[Address(RVA = "0x3310210", Offset = "0x330F610", Length = "0x6CE")]
	[Token(Token = "0x60029C1")]
	public void RenderSingleTree(RenderTree renderTree, RenderTexture nestedTreeRT, RectInt nestedTreeViewport, Rect bounds) { }

	[Address(RVA = "0x33108E0", Offset = "0x330FCE0", Length = "0xB5")]
	[Token(Token = "0x60029E8")]
	internal void RepaintTexturedElements() { }

	[Address(RVA = "0x33109A0", Offset = "0x330FDA0", Length = "0x1AB")]
	[Token(Token = "0x60029F1")]
	public void ResetGraphicEntries(RenderData renderData) { }

	[Address(RVA = "0x3310B50", Offset = "0x330FF50", Length = "0x19E")]
	[Token(Token = "0x60029B1")]
	internal void ReturnPoolRenderData(RenderData data) { }

	[Address(RVA = "0x3310CF0", Offset = "0x33100F0", Length = "0xC9")]
	[Token(Token = "0x60029B3")]
	internal void ReturnPoolRenderTree(RenderTree tree) { }

	[Address(RVA = "0x3310DC0", Offset = "0x33101C0", Length = "0xD7")]
	[Token(Token = "0x60029B9")]
	private static void ReverseDepthFirstDisposeRenderTrees(RenderTree renderTree) { }

	[Address(RVA = "0x3310EA0", Offset = "0x33102A0", Length = "0x1EC")]
	[Token(Token = "0x60029BE")]
	private void SerializeRootTreeCommands() { }

	[Address(RVA = "0x1CC9D00", Offset = "0x1CC9100", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029D5")]
	private void set_atlas(AtlasBase value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029D2")]
	private void set_device(UIRenderDevice value) { }

	[Address(RVA = "0x3312AA0", Offset = "0x3311EA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60029B6")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x1D5DF20", Offset = "0x1D5D320", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60029E2")]
	internal void set_drawStats(bool value) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029E0")]
	private void set_jobManager(JobManager value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029DE")]
	private void set_meshGenerationNodeManager(MeshGenerationNodeManager value) { }

	[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029AD")]
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029D0")]
	private void set_panel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x3312AB0", Offset = "0x3311EB0", Length = "0x7F")]
	[Token(Token = "0x60029BB")]
	internal void set_rootRenderTree(RenderTree value) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029D9")]
	private void set_tempMeshAllocator(TempMeshAllocatorImpl value) { }

	[Address(RVA = "0x2D687D0", Offset = "0x2D67BD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60029AF")]
	public void set_textureSlotCount(TextureSlotCount value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60029D7")]
	private void set_vectorImageManager(VectorImageManager value) { }

	[Address(RVA = "0x3311090", Offset = "0x3310490", Length = "0x161")]
	[Token(Token = "0x60029C3")]
	public void UIEOnChildAdded(VisualElement ve) { }

	[Address(RVA = "0x3311200", Offset = "0x3310600", Length = "0xFF")]
	[Token(Token = "0x60029C6")]
	public void UIEOnChildRemoving(VisualElement ve) { }

	[Address(RVA = "0x3311300", Offset = "0x3310700", Length = "0x1AB")]
	[Token(Token = "0x60029C5")]
	public void UIEOnChildrenReordered(VisualElement ve) { }

	[Address(RVA = "0x33114B0", Offset = "0x33108B0", Length = "0x30")]
	[Token(Token = "0x60029C9")]
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	[Address(RVA = "0x33114F0", Offset = "0x33108F0", Length = "0x23")]
	[Token(Token = "0x60029CB")]
	public void UIEOnColorChanged(VisualElement ve) { }

	[Address(RVA = "0x3311520", Offset = "0x3310920", Length = "0x9A")]
	[Token(Token = "0x60029CE")]
	public void UIEOnDisableRenderingChanged(VisualElement ve) { }

	[Address(RVA = "0x33115C0", Offset = "0x33109C0", Length = "0x33")]
	[Token(Token = "0x60029CA")]
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false) { }

	[Address(RVA = "0x3311600", Offset = "0x3310A00", Length = "0x1BD")]
	[Token(Token = "0x60029C7")]
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	[Address(RVA = "0x33117C0", Offset = "0x3310BC0", Length = "0x22")]
	[Token(Token = "0x60029CC")]
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	[Address(RVA = "0x33117F0", Offset = "0x3310BF0", Length = "0x33")]
	[Token(Token = "0x60029CD")]
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

}

