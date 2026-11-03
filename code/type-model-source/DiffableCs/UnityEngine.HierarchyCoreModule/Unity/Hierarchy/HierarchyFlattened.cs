namespace Unity.Hierarchy;

[DefaultMember("Item")]
[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattened.h")]
[RequiredByNativeCode]
[Token(Token = "0x200001B")]
public sealed class HierarchyFlattened : IDisposable
{
	[Token(Token = "0x200001C")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x60000A7")]
		public static IntPtr ConvertToUnmanaged(HierarchyFlattened hierarchyFlattened) { }

	}

	[Token(Token = "0x200001D")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003C")]
		private readonly ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003D")]
		private readonly int m_Version; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400003E")]
		private int m_Index; //Field offset: 0x1C

		[IsReadOnly]
		[Token(Token = "0x17000012")]
		public HierarchyFlattenedNode Current
		{
			[Address(RVA = "0x30D52C0", Offset = "0x30D46C0", Length = "0x9B")]
			[Token(Token = "0x60000A9")]
			 get { } //Length: 155
		}

		[Address(RVA = "0x30D5270", Offset = "0x30D4670", Length = "0x42")]
		[Token(Token = "0x60000A8")]
		internal Enumerator(HierarchyFlattened hierarchyFlattened) { }

		[Address(RVA = "0x30D52C0", Offset = "0x30D46C0", Length = "0x9B")]
		[Token(Token = "0x60000A9")]
		public HierarchyFlattenedNode get_Current() { }

		[Address(RVA = "0x30D4E10", Offset = "0x30D4210", Length = "0x39")]
		[Token(Token = "0x60000AA")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000036")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000037")]
	internal readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000038")]
	private ReadOnlyNativeVector<HierarchyFlattenedNode> m_FlattenedNodes; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000039")]
	private int m_Version; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400003A")]
	private readonly bool m_IsOwner; //Field offset: 0x34

	[Token(Token = "0x1700000E")]
	public bool IsCreated
	{
		[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 9
	}

	[IsReadOnly]
	[Token(Token = "0x17000011")]
	public HierarchyFlattenedNode Item
	{
		[Address(RVA = "0x30D67E0", Offset = "0x30D5BE0", Length = "0x47")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700000F")]
	public bool UpdateNeeded
	{
		[Address(RVA = "0x30D6870", Offset = "0x30D5C70", Length = "0x51")]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		[Token(Token = "0x6000090")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000010")]
	internal int Version
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000091")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x30D66C0", Offset = "0x30D5AC0", Length = "0x103")]
	[Token(Token = "0x6000092")]
	public HierarchyFlattened(Hierarchy hierarchy) { }

	[Address(RVA = "0x30D6610", Offset = "0x30D5A10", Length = "0xA4")]
	[Token(Token = "0x6000093")]
	private HierarchyFlattened(IntPtr nativePtr, Hierarchy hierarchy, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version) { }

	[Address(RVA = "0x30D5EA0", Offset = "0x30D52A0", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000099")]
	public bool Contains(in HierarchyNode node) { }

	[Address(RVA = "0x30D5E50", Offset = "0x30D5250", Length = "0x42")]
	[Token(Token = "0x60000A4")]
	private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30D6070", Offset = "0x30D5470", Length = "0x6C")]
	[FreeFunction("HierarchyFlattenedBindings::Create", IsThreadSafe = True)]
	[Token(Token = "0x600009E")]
	private static IntPtr Create(IntPtr handlePtr, Hierarchy hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x30D6000", Offset = "0x30D5400", Length = "0x62")]
	[Token(Token = "0x60000A6")]
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[Address(RVA = "0x30D5F00", Offset = "0x30D5300", Length = "0xF9")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000A0")]
	private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version) { }

	[Address(RVA = "0x30D60E0", Offset = "0x30D54E0", Length = "0x33")]
	[FreeFunction("HierarchyFlattenedBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600009F")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x30D6120", Offset = "0x30D5520", Length = "0x97")]
	[Token(Token = "0x6000095")]
	public override void Dispose() { }

	[Address(RVA = "0x30D61C0", Offset = "0x30D55C0", Length = "0x5D")]
	[Token(Token = "0x6000096")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30D6220", Offset = "0x30D5620", Length = "0x28")]
	[Token(Token = "0x600009A")]
	public HierarchyFlattenedChildrenEnumerable EnumerateChildren(in HierarchyNode node) { }

	[Address(RVA = "0x30D6250", Offset = "0x30D5650", Length = "0x9F")]
	[Token(Token = "0x6000094")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30D62F0", Offset = "0x30D56F0", Length = "0xC6")]
	[Token(Token = "0x600009D")]
	internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x30D67D0", Offset = "0x30D5BD0", Length = "0x9")]
	[Token(Token = "0x600008F")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x30D67E0", Offset = "0x30D5BE0", Length = "0x47")]
	[Token(Token = "0x6000097")]
	public HierarchyFlattenedNode get_Item(int index) { }

	[Address(RVA = "0x30D6870", Offset = "0x30D5C70", Length = "0x51")]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	[Token(Token = "0x6000090")]
	public bool get_UpdateNeeded() { }

	[Address(RVA = "0x30D6830", Offset = "0x30D5C30", Length = "0x33")]
	[Token(Token = "0x60000A2")]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000091")]
	internal int get_Version() { }

	[Address(RVA = "0x30D63C0", Offset = "0x30D57C0", Length = "0x53")]
	[Token(Token = "0x600009C")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x30D6470", Offset = "0x30D5870", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000098")]
	public int IndexOf(in HierarchyNode node) { }

	[Address(RVA = "0x30D6420", Offset = "0x30D5820", Length = "0x42")]
	[Token(Token = "0x60000A3")]
	private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30D65B0", Offset = "0x30D59B0", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600009B")]
	public void Update() { }

	[Address(RVA = "0x30D6570", Offset = "0x30D5970", Length = "0x33")]
	[Token(Token = "0x60000A5")]
	private static void Update_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D64D0", Offset = "0x30D58D0", Length = "0x93")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000A1")]
	private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr flattenedNodesPtr, int flattenedNodesCount, int version) { }

}

