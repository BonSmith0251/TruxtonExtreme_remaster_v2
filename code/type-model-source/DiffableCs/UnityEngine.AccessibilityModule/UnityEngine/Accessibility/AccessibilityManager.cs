namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityManager.h")]
[Token(Token = "0x2000002")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AccessibilityModule"})]
internal class AccessibilityManager
{
	[Token(Token = "0x2000006")]
	private sealed class ExclusiveLock : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000014")]
		private bool m_Disposed; //Field offset: 0x10

		[Address(RVA = "0x2F87270", Offset = "0x2F86670", Length = "0x6B")]
		[Token(Token = "0x600002B")]
		public ExclusiveLock() { }

		[Address(RVA = "0x2F870A0", Offset = "0x2F864A0", Length = "0xA5")]
		[Token(Token = "0x600002E")]
		public override void Dispose() { }

		[Address(RVA = "0x2F87150", Offset = "0x2F86550", Length = "0xAD")]
		[Token(Token = "0x600002C")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x2F87200", Offset = "0x2F86600", Length = "0x6B")]
		[Token(Token = "0x600002D")]
		private void InternalDispose() { }

	}

	[Token(Token = "0x2000005")]
	private class Nested
	{
		[Token(Token = "0x4000013")]
		internal static readonly AccessibilityManager s_Instance; //Field offset: 0x0

		[Address(RVA = "0x2F872E0", Offset = "0x2F866E0", Length = "0x73")]
		[Token(Token = "0x600002A")]
		private static Nested() { }

	}

	[Token(Token = "0x2000003")]
	internal enum Notification : byte
	{
		None = 0,
		ScreenReaderStatusChanged = 1,
		ElementFocused = 2,
		ElementUnfocused = 3,
		FontScaleChanged = 4,
		BoldTextStatusChanged = 5,
		ClosedCaptioningStatusChanged = 6,
	}

	[Token(Token = "0x2000004")]
	internal struct NotificationContext
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000D")]
		private AccessibilityNode <focusedNode>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400000E")]
		private float <fontScale>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400000F")]
		private bool <isBoldTextEnabled>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xD")]
		[Token(Token = "0x4000010")]
		private bool <isClosedCaptioningEnabled>k__BackingField; //Field offset: 0xD
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xE")]
		[Token(Token = "0x4000011")]
		private bool <isScreenReaderEnabled>k__BackingField; //Field offset: 0xE
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xF")]
		[Token(Token = "0x4000012")]
		private Notification <notification>k__BackingField; //Field offset: 0xF

		[Token(Token = "0x17000003")]
		public AccessibilityNode focusedNode
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600001E")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600001F")]
			 set { } //Length: 8
		}

		[Token(Token = "0x17000004")]
		public float fontScale
		{
			[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000020")]
			 get { } //Length: 229
			[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x6000021")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000005")]
		public bool isBoldTextEnabled
		{
			[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000022")]
			 get { } //Length: 5
			[Address(RVA = "0x2F87380", Offset = "0x2F86780", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000023")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000006")]
		public bool isClosedCaptioningEnabled
		{
			[Address(RVA = "0x2F87360", Offset = "0x2F86760", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000024")]
			 get { } //Length: 5
			[Address(RVA = "0x2F87390", Offset = "0x2F86790", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000025")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000007")]
		public bool isScreenReaderEnabled
		{
			[Address(RVA = "0x293B8F0", Offset = "0x293ACF0", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000026")]
			 get { } //Length: 5
			[Address(RVA = "0x2F873A0", Offset = "0x2F867A0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000027")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000008")]
		public Notification notification
		{
			[Address(RVA = "0x2F87370", Offset = "0x2F86770", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000028")]
			 get { } //Length: 5
			[Address(RVA = "0x2F873B0", Offset = "0x2F867B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000029")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600001E")]
		public AccessibilityNode get_focusedNode() { }

		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000020")]
		public float get_fontScale() { }

		[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000022")]
		public bool get_isBoldTextEnabled() { }

		[Address(RVA = "0x2F87360", Offset = "0x2F86760", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000024")]
		public bool get_isClosedCaptioningEnabled() { }

		[Address(RVA = "0x293B8F0", Offset = "0x293ACF0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000026")]
		public bool get_isScreenReaderEnabled() { }

		[Address(RVA = "0x2F87370", Offset = "0x2F86770", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000028")]
		public Notification get_notification() { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600001F")]
		public void set_focusedNode(AccessibilityNode value) { }

		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		public void set_fontScale(float value) { }

		[Address(RVA = "0x2F87380", Offset = "0x2F86780", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		public void set_isBoldTextEnabled(bool value) { }

		[Address(RVA = "0x2F87390", Offset = "0x2F86790", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		public void set_isClosedCaptioningEnabled(bool value) { }

		[Address(RVA = "0x2F873A0", Offset = "0x2F867A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		public void set_isScreenReaderEnabled(bool value) { }

		[Address(RVA = "0x2F873B0", Offset = "0x2F867B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		public void set_notification(Notification value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static Action<Boolean> screenReaderStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static Action<AccessibilityNode> nodeFocusChanged; //Field offset: 0x8
	[Token(Token = "0x4000003")]
	internal static Queue<NotificationContext> asyncNotificationContexts; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	private bool m_RefreshNodeFramesRequested; //Field offset: 0x10

	[Token(Token = "0x14000002")]
	public static event Action<AccessibilityNode> nodeFocusChanged
	{
		[Address(RVA = "0x2F845F0", Offset = "0x2F839F0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 add { } //Length: 261
		[Address(RVA = "0x2F848D0", Offset = "0x2F83CD0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000001")]
	public static event Action<Boolean> screenReaderStatusChanged
	{
		[Address(RVA = "0x2F84700", Offset = "0x2F83B00", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6000003")]
		 add { } //Length: 257
		[Address(RVA = "0x2F849E0", Offset = "0x2F83DE0", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x17000001")]
	public static AccessibilityManager instance
	{
		[Address(RVA = "0x2F84810", Offset = "0x2F83C10", Length = "0x4E")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000002")]
	public static bool isSupportedPlatform
	{
		[Address(RVA = "0x2F84860", Offset = "0x2F83C60", Length = "0x62")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x2F84560", Offset = "0x2F83960", Length = "0x89")]
	[Token(Token = "0x600001C")]
	private static AccessibilityManager() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000001")]
	private AccessibilityManager() { }

	[Address(RVA = "0x6DB1B0", Offset = "0x6DA5B0", Length = "0x194")]
	[CompilerGenerated]
	[Token(Token = "0x600001D")]
	internal static int <Internal_GetNextOrPreviousSiblingId>g__IndexOf|30_0(T elementToFind, IReadOnlyList<T> list) { }

	[Address(RVA = "0x2F845F0", Offset = "0x2F839F0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	public static void add_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[Address(RVA = "0x2F84700", Offset = "0x2F83B00", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6000003")]
	public static void add_screenReaderStatusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2F84810", Offset = "0x2F83C10", Length = "0x4E")]
	[Token(Token = "0x6000002")]
	public static AccessibilityManager get_instance() { }

	[Address(RVA = "0x2F84860", Offset = "0x2F83C60", Length = "0x62")]
	[Token(Token = "0x6000007")]
	public static bool get_isSupportedPlatform() { }

	[Address(RVA = "0x2F82E90", Offset = "0x2F82290", Length = "0x96")]
	[Token(Token = "0x6000019")]
	internal static IDisposable GetExclusiveLock() { }

	[Address(RVA = "0x2F82F30", Offset = "0x2F82330", Length = "0x118")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000013")]
	internal static bool Internal_GetFirstOrLastChildId(int nodeId, bool first, out int childId) { }

	[Address(RVA = "0x2F83050", Offset = "0x2F82450", Length = "0xF9")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000012")]
	internal static bool Internal_GetFirstOrLastRootNodeId(bool first, out int managedRootId) { }

	[Address(RVA = "0x2F83150", Offset = "0x2F82550", Length = "0x251")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	internal static bool Internal_GetNextOrPreviousSiblingId(int nodeId, bool next, out int siblingId) { }

	[Address(RVA = "0x2F83480", Offset = "0x2F82880", Length = "0x12A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000010")]
	internal static bool Internal_GetNode(int nodeId, ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F833B0", Offset = "0x2F827B0", Length = "0xC9")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000011")]
	internal static int Internal_GetNodeIdAt(float x, float y) { }

	[Address(RVA = "0x2F835B0", Offset = "0x2F829B0", Length = "0x3BD")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static Int32[] Internal_GetRootNodeIds() { }

	[Address(RVA = "0x2F83970", Offset = "0x2F82D70", Length = "0x40")]
	[ExcludeFromCodeCoverage]
	[RequiredByNativeCode]
	[Token(Token = "0x600000B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AccessibilityModule"})]
	internal static void Internal_Initialize() { }

	[Address(RVA = "0x2F839B0", Offset = "0x2F82DB0", Length = "0x152")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000E")]
	internal static void Internal_LateUpdate() { }

	[Address(RVA = "0x2F83B10", Offset = "0x2F82F10", Length = "0x107")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000015")]
	internal static void Internal_OnScreenReaderStatusChanged(bool enabled) { }

	[Address(RVA = "0x2F83C20", Offset = "0x2F83020", Length = "0x8D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000016")]
	internal static void Internal_OnWindowGeometryChanged() { }

	[Address(RVA = "0x2F841C0", Offset = "0x2F835C0", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000C")]
	internal static void Internal_Update() { }

	[Address(RVA = "0x2F83CB0", Offset = "0x2F830B0", Length = "0x4F0")]
	[Token(Token = "0x600000D")]
	private void Internal_Update_Impl() { }

	[Address(RVA = "0x2F84250", Offset = "0x2F83650", Length = "0x2A")]
	[Token(Token = "0x6000008")]
	internal static bool IsScreenReaderEnabled() { }

	[Address(RVA = "0x2F84280", Offset = "0x2F83680", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600001A")]
	private static void Lock() { }

	[Address(RVA = "0x2F84400", Offset = "0x2F83800", Length = "0xA4")]
	[Token(Token = "0x6000017")]
	internal static void QueueNotification(NotificationContext notification) { }

	[Address(RVA = "0x2F842B0", Offset = "0x2F836B0", Length = "0x140")]
	[Token(Token = "0x6000018")]
	internal void QueueNotification_Impl(NotificationContext notification) { }

	[Address(RVA = "0x2F848D0", Offset = "0x2F83CD0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public static void remove_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[Address(RVA = "0x2F849E0", Offset = "0x2F83DE0", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	public static void remove_screenReaderStatusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2F844B0", Offset = "0x2F838B0", Length = "0x31")]
	[Token(Token = "0x600000A")]
	internal static void SendLayoutChangedNotification(int nodeId = -1) { }

	[Address(RVA = "0x2F844F0", Offset = "0x2F838F0", Length = "0x31")]
	[Token(Token = "0x6000009")]
	internal static void SendScreenChangedNotification(int nodeId = -1) { }

	[Address(RVA = "0x2F84530", Offset = "0x2F83930", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600001B")]
	private static void Unlock() { }

}

