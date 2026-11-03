namespace UnityEngine.Accessibility;

[Token(Token = "0x200000E")]
public static class AssistiveSupport
{
	[Token(Token = "0x200000F")]
	public class NotificationDispatcher : IAccessibilityNotificationDispatcher
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600005C")]
		public NotificationDispatcher() { }

		[Address(RVA = "0x2F873C0", Offset = "0x2F867C0", Length = "0x75")]
		[Token(Token = "0x600005B")]
		public override void SendLayoutChanged(AccessibilityNode nodeToFocus = null) { }

		[Address(RVA = "0x2F87440", Offset = "0x2F86840", Length = "0xDF")]
		[Token(Token = "0x600005A")]
		public override void SendScreenChanged(AccessibilityNode nodeToFocus = null) { }

	}

	[Token(Token = "0x2000010")]
	internal enum ScreenReaderStatusOverride : byte
	{
		OSDriven = 0,
		ForceEnabled = 1,
		ForceDisabled = 2,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000044")]
	private static readonly IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000045")]
	private static Action<Boolean> screenReaderStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000046")]
	private static Action<AccessibilityNode> nodeFocusChanged; //Field offset: 0x10
	[Token(Token = "0x4000047")]
	private static ScreenReaderStatusOverride s_ScreenReaderStatusOverride; //Field offset: 0x18

	[Token(Token = "0x17000018")]
	public static AccessibilityHierarchy activeHierarchy
	{
		[Address(RVA = "0x2F86EE0", Offset = "0x2F862E0", Length = "0x36")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000019")]
	public static bool isScreenReaderEnabled
	{
		[Address(RVA = "0x2F86F20", Offset = "0x2F86320", Length = "0xD3")]
		[Token(Token = "0x6000054")]
		 get { } //Length: 211
	}

	[Token(Token = "0x17000017")]
	public static IAccessibilityNotificationDispatcher notificationDispatcher
	{
		[Address(RVA = "0x2F87000", Offset = "0x2F86400", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700001A")]
	public static ScreenReaderStatusOverride screenReaderStatusOverride
	{
		[Address(RVA = "0x2F87050", Offset = "0x2F86450", Length = "0x4F")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2F86E60", Offset = "0x2F86260", Length = "0x73")]
	[Token(Token = "0x6000059")]
	private static AssistiveSupport() { }

	[Address(RVA = "0x2F86EE0", Offset = "0x2F862E0", Length = "0x36")]
	[Token(Token = "0x6000053")]
	public static AccessibilityHierarchy get_activeHierarchy() { }

	[Address(RVA = "0x2F86F20", Offset = "0x2F86320", Length = "0xD3")]
	[Token(Token = "0x6000054")]
	public static bool get_isScreenReaderEnabled() { }

	[Address(RVA = "0x2F87000", Offset = "0x2F86400", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	public static IAccessibilityNotificationDispatcher get_notificationDispatcher() { }

	[Address(RVA = "0x2F87050", Offset = "0x2F86450", Length = "0x4F")]
	[Token(Token = "0x6000055")]
	public static ScreenReaderStatusOverride get_screenReaderStatusOverride() { }

	[Address(RVA = "0x2F868C0", Offset = "0x2F85CC0", Length = "0x281")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000056")]
	internal static void Initialize() { }

	[Address(RVA = "0x2F86B50", Offset = "0x2F85F50", Length = "0x71")]
	[Token(Token = "0x6000058")]
	private static void NodeFocusChanged(AccessibilityNode currentNode) { }

	[Address(RVA = "0x2F86BD0", Offset = "0x2F85FD0", Length = "0x28B")]
	[Token(Token = "0x6000057")]
	internal static void ScreenReaderStatusChanged(bool enabled) { }

}

