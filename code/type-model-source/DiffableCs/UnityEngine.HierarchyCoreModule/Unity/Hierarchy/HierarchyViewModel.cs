namespace Unity.Hierarchy;

[DefaultMember("Item")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyViewModel.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyViewModelBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200002A")]
public sealed class HierarchyViewModel : IDisposable
{
	[Token(Token = "0x200002B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000123")]
		public static IntPtr ConvertToUnmanaged(HierarchyViewModel viewModel) { }

	}

	[Token(Token = "0x200002D")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000083")]
		private readonly HierarchyViewModel m_ViewModel; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000084")]
		private readonly ReadOnlyNativeVector<HierarchyNode> m_Nodes; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000085")]
		private readonly int m_Version; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000086")]
		private int m_Index; //Field offset: 0x1C

		[IsReadOnly]
		[Token(Token = "0x17000034")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x30D5480", Offset = "0x30D4880", Length = "0x9B")]
			[Token(Token = "0x6000127")]
			 get { } //Length: 155
		}

		[Address(RVA = "0x30D5190", Offset = "0x30D4590", Length = "0x42")]
		[Token(Token = "0x6000126")]
		internal Enumerator(HierarchyViewModel hierarchyViewModel) { }

		[Address(RVA = "0x30D5480", Offset = "0x30D4880", Length = "0x9B")]
		[Token(Token = "0x6000127")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x30D4DD0", Offset = "0x30D41D0", Length = "0x39")]
		[Token(Token = "0x6000128")]
		public bool MoveNext() { }

	}

	[Token(Token = "0x200002C")]
	internal sealed class FlagsChangedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6000124")]
		public FlagsChangedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000125")]
		public override void Invoke(HierarchyNodeFlags flags) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007A")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007B")]
	internal readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007C")]
	internal readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007D")]
	private ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007E")]
	private ReadOnlyNativeVector<HierarchyNode> m_Nodes; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400007F")]
	private int m_Version; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000080")]
	private readonly bool m_IsOwner; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000081")]
	private FlagsChangedEventHandler FlagsChanged; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000082")]
	private IHierarchySearchQueryParser <QueryParser>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x1700002D")]
	public int Count
	{
		[Address(RVA = "0x30DA900", Offset = "0x30D9D00", Length = "0x37")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700002F")]
	internal ReadOnlyNativeVector<HierarchyFlattenedNode> FlattenedNodes
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x60000F3")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x1700002C")]
	public bool IsCreated
	{
		[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
		[Token(Token = "0x60000F0")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x17000033")]
	public HierarchyNode Item
	{
		[Address(RVA = "0x30DA940", Offset = "0x30D9D40", Length = "0x47")]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 71
	}

	[Token(Token = "0x17000032")]
	internal HierarchySearchQueryDescriptor Query
	{
		[Address(RVA = "0x30DA9D0", Offset = "0x30D9DD0", Length = "0x51")]
		[NativeMethod(IsThreadSafe = True)]
		[Token(Token = "0x60000F6")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
		internal get { } //Length: 81
	}

	[Token(Token = "0x17000031")]
	internal IHierarchySearchQueryParser QueryParser
	{
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000F5")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.HierarchyModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700002E")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x30DAA70", Offset = "0x30D9E70", Length = "0x51")]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000030")]
	internal int Version
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60000F4")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x30DA5E0", Offset = "0x30D99E0", Length = "0x136")]
	[Token(Token = "0x60000F8")]
	private HierarchyViewModel(IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x30DA720", Offset = "0x30D9B20", Length = "0x1D4")]
	[Token(Token = "0x60000F7")]
	public HierarchyViewModel(HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags = 0) { }

	[Address(RVA = "0x30D94A0", Offset = "0x30D88A0", Length = "0x69")]
	[Token(Token = "0x6000104")]
	public void ClearFlags(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D94A0", Offset = "0x30D88A0", Length = "0x69")]
	[FreeFunction("HierarchyViewModelBindings::ClearFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000110")]
	private void ClearFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9440", Offset = "0x30D8840", Length = "0x52")]
	[Token(Token = "0x6000121")]
	private static void ClearFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9580", Offset = "0x30D8980", Length = "0x79")]
	[Token(Token = "0x6000105")]
	public void ClearFlagsRecursive(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30D9580", Offset = "0x30D8980", Length = "0x79")]
	[FreeFunction("HierarchyViewModelBindings::ClearFlagsRecursiveNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000111")]
	private void ClearFlagsRecursiveNode(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30D9510", Offset = "0x30D8910", Length = "0x62")]
	[Token(Token = "0x6000122")]
	private static void ClearFlagsRecursiveNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30D9650", Offset = "0x30D8A50", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000FE")]
	public bool Contains(in HierarchyNode node) { }

	[Address(RVA = "0x30D9600", Offset = "0x30D8A00", Length = "0x42")]
	[Token(Token = "0x6000119")]
	private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30D98B0", Offset = "0x30D8CB0", Length = "0x6C")]
	[FreeFunction("HierarchyViewModelBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x600010A")]
	private static IntPtr Create(IntPtr handlePtr, HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out IntPtr indicesPtr, out int indicesCount, out int version) { }

	[Address(RVA = "0x30D9840", Offset = "0x30D8C40", Length = "0x62")]
	[Token(Token = "0x600011C")]
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchyFlattened, HierarchyNodeFlags defaultFlags, out IntPtr nodesPtr, out int nodesCount, out IntPtr indicesPtr, out int indicesCount, out int version) { }

	[Address(RVA = "0x30D96B0", Offset = "0x30D8AB0", Length = "0x188")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000112")]
	private static IntPtr CreateHierarchyViewModel(IntPtr nativePtr, IntPtr flattenedPtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version) { }

	[Address(RVA = "0x30D9920", Offset = "0x30D8D20", Length = "0x33")]
	[FreeFunction("HierarchyViewModelBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600010B")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x30D9960", Offset = "0x30D8D60", Length = "0x9E")]
	[Token(Token = "0x60000FA")]
	public override void Dispose() { }

	[Address(RVA = "0x30D9A00", Offset = "0x30D8E00", Length = "0x64")]
	[Token(Token = "0x60000FB")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30D9A70", Offset = "0x30D8E70", Length = "0x185")]
	[Token(Token = "0x6000106")]
	public HierarchyViewModelNodesEnumerable EnumerateNodesWithAllFlags(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9C00", Offset = "0x30D9000", Length = "0xA6")]
	[Token(Token = "0x60000F9")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30D9CB0", Offset = "0x30D90B0", Length = "0xC6")]
	[Token(Token = "0x6000109")]
	internal static HierarchyViewModel FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x30DA900", Offset = "0x30D9D00", Length = "0x37")]
	[Token(Token = "0x60000F1")]
	public int get_Count() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x60000F3")]
	internal ReadOnlyNativeVector<HierarchyFlattenedNode> get_FlattenedNodes() { }

	[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
	[Token(Token = "0x60000F0")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x30DA940", Offset = "0x30D9D40", Length = "0x47")]
	[Token(Token = "0x60000FC")]
	public HierarchyNode get_Item(int index) { }

	[Address(RVA = "0x30DA9D0", Offset = "0x30D9DD0", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x60000F6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal HierarchySearchQueryDescriptor get_Query() { }

	[Address(RVA = "0x30DA990", Offset = "0x30D9D90", Length = "0x33")]
	[Token(Token = "0x6000117")]
	private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DAA70", Offset = "0x30D9E70", Length = "0x51")]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x60000F2")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x30DAA30", Offset = "0x30D9E30", Length = "0x33")]
	[Token(Token = "0x6000116")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60000F4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int get_Version() { }

	[Address(RVA = "0x30D9DD0", Offset = "0x30D91D0", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000FF")]
	public int GetChildrenCount(in HierarchyNode node) { }

	[Address(RVA = "0x30D9D80", Offset = "0x30D9180", Length = "0x42")]
	[Token(Token = "0x600011A")]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30D9E30", Offset = "0x30D9230", Length = "0x53")]
	[Token(Token = "0x6000108")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x30D9EF0", Offset = "0x30D92F0", Length = "0x69")]
	[Token(Token = "0x6000103")]
	public bool HasAllFlags(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9EF0", Offset = "0x30D92F0", Length = "0x69")]
	[FreeFunction("HierarchyViewModelBindings::HasAllFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600010F")]
	private bool HasAllFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9E90", Offset = "0x30D9290", Length = "0x52")]
	[Token(Token = "0x6000120")]
	private static bool HasAllFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30D9FB0", Offset = "0x30D93B0", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60000FD")]
	public int IndexOf(in HierarchyNode node) { }

	[Address(RVA = "0x30D9F60", Offset = "0x30D9360", Length = "0x42")]
	[Token(Token = "0x6000118")]
	private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30DA010", Offset = "0x30D9410", Length = "0x3E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000114")]
	private static void InvokeFlagsChanged(IntPtr handlePtr, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA050", Offset = "0x30D9450", Length = "0x1B4")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000115")]
	private static void SearchBegin(IntPtr handlePtr) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000F5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.HierarchyModule"})]
	internal void set_QueryParser(IHierarchySearchQueryParser value) { }

	[Address(RVA = "0x30DA310", Offset = "0x30D9710", Length = "0x69")]
	[Token(Token = "0x6000101")]
	public void SetFlags(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA250", Offset = "0x30D9650", Length = "0x58")]
	[Token(Token = "0x6000100")]
	public void SetFlags(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA250", Offset = "0x30D9650", Length = "0x58")]
	[FreeFunction("HierarchyViewModelBindings::SetFlagsAll", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600010C")]
	private void SetFlagsAll(HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA210", Offset = "0x30D9610", Length = "0x40")]
	[Token(Token = "0x600011D")]
	private static void SetFlagsAll_Injected(IntPtr _unity_self, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA310", Offset = "0x30D9710", Length = "0x69")]
	[FreeFunction("HierarchyViewModelBindings::SetFlagsNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600010D")]
	private void SetFlagsNode(in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA2B0", Offset = "0x30D96B0", Length = "0x52")]
	[Token(Token = "0x600011E")]
	private static void SetFlagsNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags) { }

	[Address(RVA = "0x30DA3F0", Offset = "0x30D97F0", Length = "0x79")]
	[Token(Token = "0x6000102")]
	public void SetFlagsRecursive(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30DA3F0", Offset = "0x30D97F0", Length = "0x79")]
	[FreeFunction("HierarchyViewModelBindings::SetFlagsRecursiveNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600010E")]
	private void SetFlagsRecursiveNode(in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30DA380", Offset = "0x30D9780", Length = "0x62")]
	[Token(Token = "0x600011F")]
	private static void SetFlagsRecursiveNode_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags flags, HierarchyTraversalDirection direction) { }

	[Address(RVA = "0x30DA580", Offset = "0x30D9980", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000107")]
	public void Update() { }

	[Address(RVA = "0x30DA540", Offset = "0x30D9940", Length = "0x33")]
	[Token(Token = "0x600011B")]
	private static void Update_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DA470", Offset = "0x30D9870", Length = "0xCD")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000113")]
	private static void UpdateHierarchyViewModel(IntPtr handlePtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, IntPtr nodesPtr, int nodesCount, int version) { }

}

