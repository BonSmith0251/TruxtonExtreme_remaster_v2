namespace UnityEngine.Accessibility;

[Token(Token = "0x2000013")]
public class AccessibilityNode
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004F")]
	private Action<AccessibilityNode, Boolean> focusChanged; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000050")]
	private Func<Boolean> invoked; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000051")]
	private Action incremented; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000052")]
	private Action decremented; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000053")]
	private Func<AccessibilityScrollDirection, Boolean> scrolled; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000054")]
	private Func<Boolean> dismissed; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000055")]
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000056")]
	internal List<AccessibilityNode> childList; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000057")]
	private AccessibilityNode <parent>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000058")]
	private string m_Label; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000059")]
	private string m_Value; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400005A")]
	private string m_Hint; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400005B")]
	private Rect m_Frame; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400005C")]
	private Func<Rect> m_FrameGetter; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400005D")]
	private int <id>k__BackingField; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400005E")]
	private AccessibilityRole m_Role; //Field offset: 0x8C
	[FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x400005F")]
	private AccessibilityState m_State; //Field offset: 0x8D
	[FieldOffset(Offset = "0x8E")]
	[Token(Token = "0x4000060")]
	private bool m_IsActive; //Field offset: 0x8E
	[FieldOffset(Offset = "0x8F")]
	[Token(Token = "0x4000061")]
	private bool m_AllowsDirectInteraction; //Field offset: 0x8F

	[Token(Token = "0x17000028")]
	public bool allowsDirectInteraction
	{
		[Address(RVA = "0x2F86280", Offset = "0x2F85680", Length = "0x8")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001D")]
	public IReadOnlyList<AccessibilityNode> children
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000022")]
	public Rect frame
	{
		[Address(RVA = "0x2F86290", Offset = "0x2F85690", Length = "0x158")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 344
		[Address(RVA = "0x2F86410", Offset = "0x2F85810", Length = "0x63")]
		[Token(Token = "0x600006F")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000023")]
	public Func<Rect> frameGetter
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000070")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000021")]
	public string hint
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600006D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000024")]
	public private int id
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000071")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000072")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000027")]
	public bool isActive
	{
		[Address(RVA = "0x2F863F0", Offset = "0x2F857F0", Length = "0x8")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001F")]
	public string label
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public AccessibilityNode parent
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600006A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000025")]
	public AccessibilityRole role
	{
		[Address(RVA = "0x2D260A0", Offset = "0x2D254A0", Length = "0x8")]
		[Token(Token = "0x6000073")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000026")]
	public AccessibilityState state
	{
		[Address(RVA = "0x2F86400", Offset = "0x2F85800", Length = "0x8")]
		[Token(Token = "0x6000074")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000020")]
	public string value
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F852E0", Offset = "0x2F846E0", Length = "0x522")]
	[Token(Token = "0x6000079")]
	internal void AllocateNative() { }

	[Address(RVA = "0x2F85810", Offset = "0x2F84C10", Length = "0x1C0")]
	[Token(Token = "0x6000077")]
	private void CreateNativeNodeWithData(ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F859D0", Offset = "0x2F84DD0", Length = "0x26D")]
	[Token(Token = "0x600007A")]
	internal void FreeNative(bool freeChildren) { }

	[Address(RVA = "0x2F86280", Offset = "0x2F85680", Length = "0x8")]
	[Token(Token = "0x6000076")]
	public bool get_allowsDirectInteraction() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000069")]
	public IReadOnlyList<AccessibilityNode> get_children() { }

	[Address(RVA = "0x2F86290", Offset = "0x2F85690", Length = "0x158")]
	[Token(Token = "0x600006E")]
	public Rect get_frame() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000070")]
	public Func<Rect> get_frameGetter() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600006D")]
	public string get_hint() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000071")]
	public int get_id() { }

	[Address(RVA = "0x2F863F0", Offset = "0x2F857F0", Length = "0x8")]
	[Token(Token = "0x6000075")]
	public bool get_isActive() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600006B")]
	public string get_label() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600006A")]
	public AccessibilityNode get_parent() { }

	[Address(RVA = "0x2D260A0", Offset = "0x2D254A0", Length = "0x8")]
	[Token(Token = "0x6000073")]
	public AccessibilityRole get_role() { }

	[Address(RVA = "0x2F86400", Offset = "0x2F85800", Length = "0x8")]
	[Token(Token = "0x6000074")]
	public AccessibilityState get_state() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600006C")]
	public string get_value() { }

	[Address(RVA = "0x2F85C40", Offset = "0x2F85040", Length = "0x30A")]
	[Token(Token = "0x6000078")]
	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x2F85F50", Offset = "0x2F85350", Length = "0x2B")]
	[Token(Token = "0x6000080")]
	internal bool InvokeDecremented() { }

	[Address(RVA = "0x2F85F80", Offset = "0x2F85380", Length = "0x34")]
	[Token(Token = "0x6000082")]
	internal bool InvokeDismissed() { }

	[Address(RVA = "0x2F85FC0", Offset = "0x2F853C0", Length = "0x20")]
	[Token(Token = "0x600007D")]
	internal void InvokeFocusChanged(bool isNodeFocused) { }

	[Address(RVA = "0x2F85FE0", Offset = "0x2F853E0", Length = "0x2B")]
	[Token(Token = "0x600007F")]
	internal bool InvokeIncremented() { }

	[Address(RVA = "0x2F86010", Offset = "0x2F85410", Length = "0x34")]
	[Token(Token = "0x600007E")]
	internal bool InvokeNodeInvoked() { }

	[Address(RVA = "0x2F86050", Offset = "0x2F85450", Length = "0x34")]
	[Token(Token = "0x6000081")]
	internal bool InvokeScrolled(AccessibilityScrollDirection direction) { }

	[Address(RVA = "0x2F86090", Offset = "0x2F85490", Length = "0x86")]
	[Token(Token = "0x600007B")]
	private bool IsInActiveHierarchy() { }

	[Address(RVA = "0x2F86120", Offset = "0x2F85520", Length = "0x154")]
	[Token(Token = "0x600007C")]
	internal void NotifyFocusChanged(bool isNodeFocused) { }

	[Address(RVA = "0x2F86410", Offset = "0x2F85810", Length = "0x63")]
	[Token(Token = "0x600006F")]
	public void set_frame(Rect value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000072")]
	private void set_id(int value) { }

}

