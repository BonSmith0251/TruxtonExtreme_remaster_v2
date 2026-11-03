namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[NativeHeader("Modules/HierarchyCore/Public/Hierarchy.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000016")]
public sealed class Hierarchy : IDisposable
{
	[Token(Token = "0x2000017")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000084")]
		public static IntPtr ConvertToUnmanaged(Hierarchy hierarchy) { }

	}

	[Token(Token = "0x2000018")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	public sealed class HandlerCreatedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x1C4A150", Offset = "0x1C49550", Length = "0x124")]
		[Token(Token = "0x6000085")]
		public HandlerCreatedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000086")]
		public override void Invoke(HierarchyNodeTypeHandlerBase handler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private readonly IntPtr m_RootPtr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000031")]
	private readonly IntPtr m_VersionPtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000032")]
	private readonly bool m_IsOwner; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000033")]
	private HandlerCreatedEventHandler HandlerCreated; //Field offset: 0x30

	[Token(Token = "0x1700000A")]
	public bool IsCreated
	{
		[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x1700000B")]
	public HierarchyNode Root
	{
		[Address(RVA = "0x30DBEA0", Offset = "0x30DB2A0", Length = "0xD")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700000C")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x30DBEF0", Offset = "0x30DB2F0", Length = "0x51")]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x6000054")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700000D")]
	internal int Version
	{
		[Address(RVA = "0x30DBF50", Offset = "0x30DB350", Length = "0x16")]
		[Token(Token = "0x6000055")]
		internal get { } //Length: 22
	}

	[Address(RVA = "0x30DBE50", Offset = "0x30DB250", Length = "0x4C")]
	[Token(Token = "0x6000057")]
	private Hierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	[Address(RVA = "0x30DBDC0", Offset = "0x30DB1C0", Length = "0x8A")]
	[Token(Token = "0x6000056")]
	public Hierarchy() { }

	[Address(RVA = "0x30DAB30", Offset = "0x30D9F30", Length = "0x6D")]
	[Token(Token = "0x600005D")]
	public HierarchyNode Add(in HierarchyNode parent) { }

	[Address(RVA = "0x30DAB30", Offset = "0x30D9F30", Length = "0x6D")]
	[FreeFunction("HierarchyBindings::AddNode", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006C")]
	private HierarchyNode AddNode(in HierarchyNode parent) { }

	[Address(RVA = "0x30DAAD0", Offset = "0x30D9ED0", Length = "0x52")]
	[Token(Token = "0x600007E")]
	private static void AddNode_Injected(IntPtr _unity_self, in HierarchyNode parent, out HierarchyNode ret) { }

	[Address(RVA = "0x30DAC30", Offset = "0x30DA030", Length = "0x52")]
	[FreeFunction("HierarchyBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x6000068")]
	private static IntPtr Create(IntPtr handlePtr, out IntPtr rootPtr, out IntPtr versionPtr) { }

	[Address(RVA = "0x30DABA0", Offset = "0x30D9FA0", Length = "0x8A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000072")]
	private static IntPtr CreateHierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	[Address(RVA = "0x30DAC90", Offset = "0x30DA090", Length = "0x33")]
	[FreeFunction("HierarchyBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000069")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x30DAD30", Offset = "0x30DA130", Length = "0x90")]
	[Token(Token = "0x6000059")]
	public override void Dispose() { }

	[Address(RVA = "0x30DACD0", Offset = "0x30DA0D0", Length = "0x56")]
	[Token(Token = "0x600005A")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30DAE70", Offset = "0x30DA270", Length = "0x96")]
	[Token(Token = "0x6000061")]
	public HierarchyNodeChildren EnumerateChildren(in HierarchyNode node) { }

	[Address(RVA = "0x30DAE10", Offset = "0x30DA210", Length = "0x5A")]
	[FreeFunction("HierarchyBindings::EnumerateChildrenPtr", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006E")]
	private IntPtr EnumerateChildrenPtr(in HierarchyNode node) { }

	[Address(RVA = "0x30DADC0", Offset = "0x30DA1C0", Length = "0x42")]
	[Token(Token = "0x6000080")]
	private static IntPtr EnumerateChildrenPtr_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600005B")]
	public HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase() { }

	[Address(RVA = "0x30DAF60", Offset = "0x30DA360", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005C")]
	public bool Exists(in HierarchyNode node) { }

	[Address(RVA = "0x30DAF10", Offset = "0x30DA310", Length = "0x42")]
	[Token(Token = "0x6000075")]
	private static bool Exists_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30DAFC0", Offset = "0x30DA3C0", Length = "0x9B")]
	[Token(Token = "0x6000058")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30DB060", Offset = "0x30DA460", Length = "0xC6")]
	[Token(Token = "0x6000067")]
	internal static Hierarchy FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
	[Token(Token = "0x6000052")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x30DBEA0", Offset = "0x30DB2A0", Length = "0xD")]
	[Token(Token = "0x6000053")]
	public HierarchyNode get_Root() { }

	[Address(RVA = "0x30DBEF0", Offset = "0x30DB2F0", Length = "0x51")]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x6000054")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x30DBEB0", Offset = "0x30DB2B0", Length = "0x33")]
	[Token(Token = "0x6000074")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DBF50", Offset = "0x30DB350", Length = "0x16")]
	[Token(Token = "0x6000055")]
	internal int get_Version() { }

	[Address(RVA = "0x30DB240", Offset = "0x30DA640", Length = "0x100")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000060")]
	public HierarchyNode[] GetChildren(in HierarchyNode node) { }

	[Address(RVA = "0x30DB1E0", Offset = "0x30DA5E0", Length = "0x52")]
	[Token(Token = "0x6000077")]
	private static void GetChildren_Injected(IntPtr _unity_self, in HierarchyNode node, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30DB180", Offset = "0x30DA580", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000062")]
	public int GetChildrenCount(in HierarchyNode node) { }

	[Address(RVA = "0x30DB130", Offset = "0x30DA530", Length = "0x42")]
	[Token(Token = "0x6000078")]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30DB390", Offset = "0x30DA790", Length = "0x51")]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseCount", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600006A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int GetNodeTypeHandlersBaseCount() { }

	[Address(RVA = "0x30DB350", Offset = "0x30DA750", Length = "0x33")]
	[Token(Token = "0x600007C")]
	private static int GetNodeTypeHandlersBaseCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DB440", Offset = "0x30DA840", Length = "0xD1")]
	[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseSpan", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal int GetNodeTypeHandlersBaseSpan(Span<IntPtr> outHandlers) { }

	[Address(RVA = "0x30DB3F0", Offset = "0x30DA7F0", Length = "0x42")]
	[Token(Token = "0x600007D")]
	private static int GetNodeTypeHandlersBaseSpan_Injected(IntPtr _unity_self, ref ManagedSpanWrapper outHandlers) { }

	[Address(RVA = "0x30DB590", Offset = "0x30DA990", Length = "0x1FB")]
	[FreeFunction("HierarchyBindings::GetOrCreateProperty", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006F")]
	private HierarchyPropertyId GetOrCreateProperty(string name, in HierarchyPropertyDescriptor descriptor) { }

	[Address(RVA = "0x30DB520", Offset = "0x30DA920", Length = "0x62")]
	[Token(Token = "0x6000081")]
	private static void GetOrCreateProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, in HierarchyPropertyDescriptor descriptor, out HierarchyPropertyId ret) { }

	[Address(RVA = "0x81F870", Offset = "0x81EC70", Length = "0xA3")]
	[Token(Token = "0x6000065")]
	public HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged(string name, HierarchyPropertyStorageType type = 1) { }

	[Address(RVA = "0x30DB7F0", Offset = "0x30DABF0", Length = "0x6D")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600005F")]
	public HierarchyNode GetParent(in HierarchyNode node) { }

	[Address(RVA = "0x30DB790", Offset = "0x30DAB90", Length = "0x52")]
	[Token(Token = "0x6000076")]
	private static void GetParent_Injected(IntPtr _unity_self, in HierarchyNode node, out HierarchyNode ret) { }

	[Address(RVA = "0x30DB8D0", Offset = "0x30DACD0", Length = "0x79")]
	[FreeFunction("HierarchyBindings::GetPropertyRaw", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000071")]
	internal Void* GetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, out int size) { }

	[Address(RVA = "0x30DB860", Offset = "0x30DAC60", Length = "0x62")]
	[Token(Token = "0x6000083")]
	private static Void* GetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, out int size) { }

	[Address(RVA = "0x30DB950", Offset = "0x30DAD50", Length = "0x88")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000073")]
	private static void InvokeHandlerCreated(IntPtr hierarchyPtr, IntPtr handlerPtr) { }

	[Address(RVA = "0x30DBA40", Offset = "0x30DAE40", Length = "0x69")]
	[FreeFunction("HierarchyBindings::SetNodeParent", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600006D")]
	private void SetNodeParent(in HierarchyNode node, in HierarchyNode parent) { }

	[Address(RVA = "0x30DB9E0", Offset = "0x30DADE0", Length = "0x52")]
	[Token(Token = "0x600007F")]
	private static void SetNodeParent_Injected(IntPtr _unity_self, in HierarchyNode node, in HierarchyNode parent) { }

	[Address(RVA = "0x30DBA40", Offset = "0x30DAE40", Length = "0x69")]
	[Token(Token = "0x600005E")]
	public void SetParent(in HierarchyNode node, in HierarchyNode parent) { }

	[Address(RVA = "0x30DBB20", Offset = "0x30DAF20", Length = "0x79")]
	[FreeFunction("HierarchyBindings::SetPropertyRaw", HasExplicitThis = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000070")]
	internal void SetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, Void* ptr, int size) { }

	[Address(RVA = "0x30DBAB0", Offset = "0x30DAEB0", Length = "0x62")]
	[Token(Token = "0x6000082")]
	private static void SetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, Void* ptr, int size) { }

	[Address(RVA = "0x30DBC00", Offset = "0x30DB000", Length = "0x69")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000063")]
	public void SetSortIndex(in HierarchyNode node, int sortIndex) { }

	[Address(RVA = "0x30DBBA0", Offset = "0x30DAFA0", Length = "0x52")]
	[Token(Token = "0x6000079")]
	private static void SetSortIndex_Injected(IntPtr _unity_self, in HierarchyNode node, int sortIndex) { }

	[Address(RVA = "0x30DBCC0", Offset = "0x30DB0C0", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000064")]
	public void SortChildren(in HierarchyNode node) { }

	[Address(RVA = "0x30DBC70", Offset = "0x30DB070", Length = "0x42")]
	[Token(Token = "0x600007A")]
	private static void SortChildren_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30DBD60", Offset = "0x30DB160", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000066")]
	public void Update() { }

	[Address(RVA = "0x30DBD20", Offset = "0x30DB120", Length = "0x33")]
	[Token(Token = "0x600007B")]
	private static void Update_Injected(IntPtr _unity_self) { }

}

