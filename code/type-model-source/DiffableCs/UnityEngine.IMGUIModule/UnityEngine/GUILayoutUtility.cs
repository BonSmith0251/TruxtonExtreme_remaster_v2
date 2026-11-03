namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
[Token(Token = "0x2000012")]
public class GUILayoutUtility
{
	[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
	[Token(Token = "0x2000013")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public sealed class LayoutCache
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000075")]
		private int <id>k__BackingField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000076")]
		public GUILayoutGroup topLevel; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000077")]
		internal GenericStack layoutGroups; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000078")]
		internal GUILayoutGroup windows; //Field offset: 0x28

		[Token(Token = "0x17000032")]
		private int id
		{
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60000CB")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x30F6BB0", Offset = "0x30F5FB0", Length = "0xF9")]
		[Token(Token = "0x60000CC")]
		public LayoutCache(int instanceID = -1) { }

		[Address(RVA = "0x30F6950", Offset = "0x30F5D50", Length = "0x253")]
		[Token(Token = "0x60000CD")]
		public void ResetCursor() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000CB")]
		private void set_id(int value) { }

	}

	[Token(Token = "0x4000070")]
	private static readonly Dictionary<Int32, LayoutCache> s_StoredLayouts; //Field offset: 0x0
	[Token(Token = "0x4000071")]
	private static readonly Dictionary<Int32, LayoutCache> s_StoredWindows; //Field offset: 0x8
	[Token(Token = "0x4000072")]
	internal static LayoutCache current; //Field offset: 0x10
	[Token(Token = "0x4000073")]
	internal static readonly Rect kDummyRect; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000074")]
	private static int <unbalancedgroupscount>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000031")]
	internal static int unbalancedgroupscount
	{
		[Address(RVA = "0x30E6960", Offset = "0x30E5D60", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60000B6")]
		internal get { } //Length: 78
		[Address(RVA = "0x30E69B0", Offset = "0x30E5DB0", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x60000B7")]
		internal set { } //Length: 83
	}

	[Address(RVA = "0x30E6820", Offset = "0x30E5C20", Length = "0x140")]
	[Token(Token = "0x60000C8")]
	private static GUILayoutUtility() { }

	[Address(RVA = "0x30E4B90", Offset = "0x30E3F90", Length = "0x2BF")]
	[Token(Token = "0x60000BB")]
	internal static void Begin(int instanceID) { }

	[Address(RVA = "0x30E4120", Offset = "0x30E3520", Length = "0x1ED")]
	[Token(Token = "0x60000BC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainer(LayoutCache cache) { }

	[Address(RVA = "0x30E4310", Offset = "0x30E3710", Length = "0x4AF")]
	[Token(Token = "0x60000C4")]
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	[Address(RVA = "0x30E47C0", Offset = "0x30E3BC0", Length = "0x3C5")]
	[Token(Token = "0x60000BD")]
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E4E50", Offset = "0x30E4250", Length = "0x132")]
	[Token(Token = "0x60000C3")]
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	[Address(RVA = "0x30E4F90", Offset = "0x30E4390", Length = "0x50C")]
	[Token(Token = "0x60000C7")]
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E54A0", Offset = "0x30E48A0", Length = "0x1DE")]
	[Token(Token = "0x60000C5")]
	internal static void EndLayoutArea() { }

	[Address(RVA = "0x30E6960", Offset = "0x30E5D60", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60000B6")]
	internal static int get_unbalancedgroupscount() { }

	[Address(RVA = "0x30E5680", Offset = "0x30E4A80", Length = "0xBF")]
	[Token(Token = "0x60000B8")]
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	[Address(RVA = "0x30E5740", Offset = "0x30E4B40", Length = "0x91")]
	[Token(Token = "0x60000C6")]
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E5820", Offset = "0x30E4C20", Length = "0x7A")]
	[Token(Token = "0x60000B4")]
	private static Rect Internal_GetWindowRect(int windowID) { }

	[Address(RVA = "0x30E57E0", Offset = "0x30E4BE0", Length = "0x40")]
	[Token(Token = "0x60000C9")]
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	[Address(RVA = "0x30E58E0", Offset = "0x30E4CE0", Length = "0x71")]
	[Token(Token = "0x60000B5")]
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[Address(RVA = "0x30E58A0", Offset = "0x30E4CA0", Length = "0x40")]
	[Token(Token = "0x60000CA")]
	private static void Internal_MoveWindow_Injected(int windowID, in Rect r) { }

	[Address(RVA = "0x30E6230", Offset = "0x30E5630", Length = "0x2BF")]
	[Token(Token = "0x60000BE")]
	internal static void Layout() { }

	[Address(RVA = "0x30E5960", Offset = "0x30E4D60", Length = "0x1B4")]
	[Token(Token = "0x60000C1")]
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	[Address(RVA = "0x30E5B20", Offset = "0x30E4F20", Length = "0x1E0")]
	[Token(Token = "0x60000C0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void LayoutFromContainer(float w, float h) { }

	[Address(RVA = "0x30E5D10", Offset = "0x30E5110", Length = "0x26D")]
	[Token(Token = "0x60000BF")]
	internal static void LayoutFromEditorWindow() { }

	[Address(RVA = "0x30E5F80", Offset = "0x30E5380", Length = "0x2AE")]
	[Token(Token = "0x60000C2")]
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	[Address(RVA = "0x30E64F0", Offset = "0x30E58F0", Length = "0xD0")]
	[Token(Token = "0x60000BA")]
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	[Address(RVA = "0x30E65D0", Offset = "0x30E59D0", Length = "0x247")]
	[Token(Token = "0x60000B9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	[Address(RVA = "0x30E69B0", Offset = "0x30E5DB0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60000B7")]
	internal static void set_unbalancedgroupscount(int value) { }

}

