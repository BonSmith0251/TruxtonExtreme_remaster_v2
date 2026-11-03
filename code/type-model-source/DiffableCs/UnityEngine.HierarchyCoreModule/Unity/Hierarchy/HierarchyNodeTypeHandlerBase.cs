namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyNodeTypeHandlerBaseBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000009")]
public abstract class HierarchyNodeTypeHandlerBase
{
	[Token(Token = "0x200000A")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600002E")]
		public static IntPtr ConvertToUnmanaged(HierarchyNodeTypeHandlerBase handler) { }

	}

	[Token(Token = "0x200000B")]
	private struct ConstructorScope : IDisposable
	{
		[NoAutoStaticsCleanup]
		[ThreadStatic]
		[Token(Token = "0x400001A")]
		private static IntPtr m_Ptr; //Field offset: 0x80000000
		[NoAutoStaticsCleanup]
		[ThreadStatic]
		[Token(Token = "0x400001B")]
		private static Hierarchy m_Hierarchy; //Field offset: 0x80000008
		[NoAutoStaticsCleanup]
		[ThreadStatic]
		[Token(Token = "0x400001C")]
		private static HierarchyCommandList m_CommandList; //Field offset: 0x80000010

		[Token(Token = "0x17000005")]
		private static HierarchyCommandList CommandList
		{
			[Address(RVA = "0x30D4B20", Offset = "0x30D3F20", Length = "0x52")]
			[Token(Token = "0x6000031")]
			private set { } //Length: 82
		}

		[Token(Token = "0x17000004")]
		private static Hierarchy Hierarchy
		{
			[Address(RVA = "0x30D4B80", Offset = "0x30D3F80", Length = "0x52")]
			[Token(Token = "0x6000030")]
			private set { } //Length: 82
		}

		[Token(Token = "0x17000003")]
		private static IntPtr Ptr
		{
			[Address(RVA = "0x30D4BE0", Offset = "0x30D3FE0", Length = "0x3A")]
			[Token(Token = "0x600002F")]
			private set { } //Length: 58
		}

		[Address(RVA = "0x30D4A40", Offset = "0x30D3E40", Length = "0xDA")]
		[Token(Token = "0x6000032")]
		public ConstructorScope(IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList) { }

		[Address(RVA = "0x30D4970", Offset = "0x30D3D70", Length = "0xC5")]
		[Token(Token = "0x6000033")]
		public override void Dispose() { }

		[Address(RVA = "0x30D4B20", Offset = "0x30D3F20", Length = "0x52")]
		[Token(Token = "0x6000031")]
		private static void set_CommandList(HierarchyCommandList value) { }

		[Address(RVA = "0x30D4B80", Offset = "0x30D3F80", Length = "0x52")]
		[Token(Token = "0x6000030")]
		private static void set_Hierarchy(Hierarchy value) { }

		[Address(RVA = "0x30D4BE0", Offset = "0x30D3FE0", Length = "0x3A")]
		[Token(Token = "0x600002F")]
		private static void set_Ptr(IntPtr value) { }

	}

	[AutoStaticsCleanupOnCodeReload]
	[Token(Token = "0x4000019")]
	private static readonly Dictionary<Type, Int32> s_NodeTypes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000016")]
	internal readonly IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000017")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000018")]
	private readonly HierarchyCommandList m_CommandList; //Field offset: 0x20

	[Address(RVA = "0x30D7A00", Offset = "0x30D6E00", Length = "0x84")]
	[Token(Token = "0x6000028")]
	private static HierarchyNodeTypeHandlerBase() { }

	[Address(RVA = "0x30D6B00", Offset = "0x30D5F00", Length = "0x8B")]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::ChangesPending", HasExplicitThis = True, IsThreadSafe = True)]
	[Obsolete("ChangesPending is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	[Token(Token = "0x6000026")]
	protected override bool ChangesPending() { }

	[Address(RVA = "0x30D6AC0", Offset = "0x30D5EC0", Length = "0x33")]
	[Token(Token = "0x600002C")]
	private static bool ChangesPending_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30D6B90", Offset = "0x30D5F90", Length = "0x251")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001A")]
	private static IntPtr CreateNodeTypeHandlerFromType(IntPtr nativePtr, Type handlerType, IntPtr hierarchyPtr, IntPtr cmdListPtr) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000010")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x30D6DF0", Offset = "0x30D61F0", Length = "0xE3")]
	[Token(Token = "0x6000018")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal static HierarchyNodeTypeHandlerBase FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x30D6F40", Offset = "0x30D6340", Length = "0xAA")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000013")]
	public override HierarchyNodeFlags GetDefaultNodeFlags(in HierarchyNode node, HierarchyNodeFlags defaultFlags = 0) { }

	[Address(RVA = "0x30D6EE0", Offset = "0x30D62E0", Length = "0x52")]
	[Token(Token = "0x600002B")]
	private static HierarchyNodeFlags GetDefaultNodeFlags_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[Address(RVA = "0x30D7040", Offset = "0x30D6440", Length = "0x9A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000012")]
	public override int GetNodeHashCode(in HierarchyNode node) { }

	[Address(RVA = "0x30D6FF0", Offset = "0x30D63F0", Length = "0x42")]
	[Token(Token = "0x600002A")]
	private static int GetNodeHashCode_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x30D7130", Offset = "0x30D6530", Length = "0x11B")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000011")]
	public override string GetNodeTypeName() { }

	[Address(RVA = "0x30D70E0", Offset = "0x30D64E0", Length = "0x42")]
	[Token(Token = "0x6000029")]
	private static void GetNodeTypeName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000F")]
	protected override void Initialize() { }

	[Address(RVA = "0x30D72A0", Offset = "0x30D66A0", Length = "0xB1")]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::IntegrateChanges", HasExplicitThis = True, IsThreadSafe = True)]
	[Obsolete("IntegrateChanges is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	[Token(Token = "0x6000027")]
	protected override bool IntegrateChanges(HierarchyCommandList cmdList) { }

	[Address(RVA = "0x30D7250", Offset = "0x30D6650", Length = "0x42")]
	[Token(Token = "0x600002D")]
	private static bool IntegrateChanges_Injected(IntPtr _unity_self, IntPtr cmdList) { }

	[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
	[Token(Token = "0x6000019")]
	internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query) { }

	[Address(RVA = "0x30D7360", Offset = "0x30D6760", Length = "0x6A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000021")]
	private static bool InvokeChangesPending(IntPtr handlePtr) { }

	[Address(RVA = "0x30D73D0", Offset = "0x30D67D0", Length = "0x9A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001D")]
	private static void InvokeDispose(IntPtr handlePtr) { }

	[Address(RVA = "0x30D7470", Offset = "0x30D6870", Length = "0x89")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr handlePtr, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[Address(RVA = "0x30D7500", Offset = "0x30D6900", Length = "0x79")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	private static int InvokeGetNodeHashCode(IntPtr handlePtr, in HierarchyNode node) { }

	[Address(RVA = "0x30D7580", Offset = "0x30D6980", Length = "0x6A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	private static string InvokeGetNodeTypeName(IntPtr handlePtr) { }

	[Address(RVA = "0x30D75F0", Offset = "0x30D69F0", Length = "0x6A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001C")]
	private static void InvokeInitialize(IntPtr handlePtr) { }

	[Address(RVA = "0x30D7660", Offset = "0x30D6A60", Length = "0x86")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000022")]
	private static bool InvokeIntegrateChanges(IntPtr handlePtr, IntPtr cmdListPtr) { }

	[Address(RVA = "0x30D76F0", Offset = "0x30D6AF0", Length = "0x6A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000024")]
	private static void InvokeSearchEnd(IntPtr handlePtr) { }

	[Address(RVA = "0x30D7760", Offset = "0x30D6B60", Length = "0x79")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000023")]
	private static bool InvokeSearchMatch(IntPtr handlePtr, in HierarchyNode node) { }

	[Address(RVA = "0x30D77E0", Offset = "0x30D6BE0", Length = "0x86")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000025")]
	private static void InvokeViewModelPostUpdate(IntPtr handlePtr, IntPtr viewModelPtr) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000014")]
	protected override void SearchBegin(HierarchySearchQueryDescriptor query) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000016")]
	protected override void SearchEnd() { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x6000015")]
	protected override bool SearchMatch(in HierarchyNode node) { }

	[Address(RVA = "0x30D7870", Offset = "0x30D6C70", Length = "0x18A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001B")]
	private static bool TryGetStaticNodeType(Type handlerType, out int nodeType) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000017")]
	protected override void ViewModelPostUpdate(HierarchyViewModel viewModel) { }

}

