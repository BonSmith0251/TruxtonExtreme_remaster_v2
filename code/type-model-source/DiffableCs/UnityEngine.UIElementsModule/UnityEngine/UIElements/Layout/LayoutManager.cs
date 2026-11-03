namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005F6")]
internal class LayoutManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20005F8")]
	private sealed class <>c
	{
		[Token(Token = "0x40015E1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40015E2")]
		public static EventHandler <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x332A410", Offset = "0x3329810", Length = "0x67")]
		[Token(Token = "0x6002AC7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002AC8")]
		public <>c() { }

		[Address(RVA = "0x3329F00", Offset = "0x3329300", Length = "0xCE")]
		[Token(Token = "0x6002AC9")]
		internal void <Initialize>b__9_0(object _, EventArgs __) { }

	}

	[Token(Token = "0x20005F7")]
	private enum SharedManagerState : int
	{
		Uninitialized = 0,
		Initialized = 1,
		Shutdown = 2,
	}

	[Token(Token = "0x40015CF")]
	private static SharedManagerState s_Initialized; //Field offset: 0x0
	[Token(Token = "0x40015D0")]
	private static bool s_AppDomainUnloadRegistered; //Field offset: 0x4
	[Token(Token = "0x40015D1")]
	private static LayoutManager s_SharedInstance; //Field offset: 0x8
	[Token(Token = "0x40015D2")]
	private static readonly List<LayoutManager> s_Managers; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015D3")]
	private readonly int m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015D4")]
	private LayoutDataStore m_Nodes; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015D5")]
	private LayoutDataStore m_Configs; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40015D6")]
	private readonly ConcurrentQueue<LayoutHandle> m_NodesToFree; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40015D7")]
	private readonly LayoutHandle m_DefaultConfig; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40015D8")]
	private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40015D9")]
	private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40015DA")]
	private readonly ManagedObjectStore<GCHandle> m_ManagedOwners; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015DB")]
	private readonly ProfilerMarker m_CollectMarker; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015DC")]
	private int m_HighMark; //Field offset: 0x78

	[Token(Token = "0x17000A9E")]
	private static int DefaultCapacity
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x6002AB1")]
		private get { } //Length: 6
	}

	[Token(Token = "0x17000A9C")]
	public static bool IsSharedManagerCreated
	{
		[Address(RVA = "0x3320810", Offset = "0x331FC10", Length = "0x51")]
		[Token(Token = "0x6002AAD")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000A9D")]
	public static LayoutManager SharedManager
	{
		[Address(RVA = "0x3320870", Offset = "0x331FC70", Length = "0x53")]
		[Token(Token = "0x6002AAE")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x3320080", Offset = "0x331F480", Length = "0x89")]
	[Token(Token = "0x6002AC6")]
	private static LayoutManager() { }

	[Address(RVA = "0x3320110", Offset = "0x331F510", Length = "0x693")]
	[Token(Token = "0x6002AB4")]
	public LayoutManager(Allocator allocator, int initialNodeCapacity) { }

	[Address(RVA = "0x33207B0", Offset = "0x331FBB0", Length = "0x5D")]
	[Token(Token = "0x6002AB3")]
	public LayoutManager(Allocator allocator) { }

	[Address(RVA = "0x331E5D0", Offset = "0x331D9D0", Length = "0x8A")]
	[Token(Token = "0x6002AC0")]
	public void Collect() { }

	[Address(RVA = "0x331E660", Offset = "0x331DA60", Length = "0x11C")]
	[Token(Token = "0x6002AB8")]
	public LayoutConfig CreateConfig() { }

	[Address(RVA = "0x331EC40", Offset = "0x331E040", Length = "0x53")]
	[Token(Token = "0x6002ABA")]
	public LayoutNode CreateNode() { }

	[Address(RVA = "0x331E780", Offset = "0x331DB80", Length = "0x4B3")]
	[Token(Token = "0x6002ABB")]
	private LayoutNode CreateNodeInternal(LayoutHandle configHandle) { }

	[Address(RVA = "0x331ECA0", Offset = "0x331E0A0", Length = "0x56")]
	[Token(Token = "0x6002AB9")]
	public void DestroyConfig(ref LayoutConfig config) { }

	[Address(RVA = "0x331ED00", Offset = "0x331E100", Length = "0x2C7")]
	[Token(Token = "0x6002AB5")]
	public override void Dispose() { }

	[Address(RVA = "0x331EFD0", Offset = "0x331E3D0", Length = "0x8E")]
	[Token(Token = "0x6002ABE")]
	public void EnqueueNodeForRecycling(ref LayoutNode node) { }

	[Address(RVA = "0x331F060", Offset = "0x331E460", Length = "0x27C")]
	[Token(Token = "0x6002ABF")]
	private void FreeNode(LayoutHandle handle) { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6002AB1")]
	private static int get_DefaultCapacity() { }

	[Address(RVA = "0x3320810", Offset = "0x331FC10", Length = "0x51")]
	[Token(Token = "0x6002AAD")]
	public static bool get_IsSharedManagerCreated() { }

	[Address(RVA = "0x3320870", Offset = "0x331FC70", Length = "0x53")]
	[Token(Token = "0x6002AAE")]
	public static LayoutManager get_SharedManager() { }

	[Address(RVA = "0x331F2E0", Offset = "0x331E6E0", Length = "0x52")]
	[Token(Token = "0x6002AB6")]
	private LayoutDataAccess GetAccess() { }

	[Address(RVA = "0x331F340", Offset = "0x331E740", Length = "0xB4")]
	[Token(Token = "0x6002AC5")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[Address(RVA = "0x331F400", Offset = "0x331E800", Length = "0x6A")]
	[Token(Token = "0x6002AB7")]
	public LayoutConfig GetDefaultConfig() { }

	[Address(RVA = "0x331F470", Offset = "0x331E870", Length = "0xB6")]
	[Token(Token = "0x6002AB2")]
	internal static LayoutManager GetManager(int index) { }

	[Address(RVA = "0x331F530", Offset = "0x331E930", Length = "0xB4")]
	[Token(Token = "0x6002AC3")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[Address(RVA = "0x331F5F0", Offset = "0x331E9F0", Length = "0x215")]
	[Token(Token = "0x6002AC1")]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[Address(RVA = "0x331F810", Offset = "0x331EC10", Length = "0x257")]
	[Token(Token = "0x6002AAF")]
	private static void Initialize() { }

	[Address(RVA = "0x331FA70", Offset = "0x331EE70", Length = "0xC6")]
	[Token(Token = "0x6002AC4")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[Address(RVA = "0x331FB40", Offset = "0x331EF40", Length = "0x138")]
	[Token(Token = "0x6002AC2")]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

	[Address(RVA = "0x331FC80", Offset = "0x331F080", Length = "0x96")]
	[Token(Token = "0x6002AB0")]
	private static void Shutdown() { }

	[Address(RVA = "0x331FD20", Offset = "0x331F120", Length = "0x2EF")]
	[Token(Token = "0x6002ABD")]
	private void TryRecycleNodes() { }

	[Address(RVA = "0x3320010", Offset = "0x331F410", Length = "0x67")]
	[Token(Token = "0x6002ABC")]
	private void TryRecycleSingleNode() { }

}

