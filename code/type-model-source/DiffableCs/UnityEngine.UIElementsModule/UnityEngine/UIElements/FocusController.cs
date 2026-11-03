namespace UnityEngine.UIElements;

[Token(Token = "0x200025C")]
public class FocusController
{
	[Token(Token = "0x200025D")]
	private struct FocusedElement
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000932")]
		public VisualElement m_SubTreeRoot; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000933")]
		public VisualElement m_FocusedElement; //Field offset: 0x8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400092B")]
	private readonly IFocusRing <focusRing>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400092C")]
	private TextElement m_SelectedTextElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092D")]
	private List<FocusedElement> m_FocusedElements; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400092E")]
	private Focusable m_LastFocusedElement; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400092F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Focusable m_LastPendingFocusedElement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000930")]
	private int m_PendingFocusCount; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000931")]
	private int <imguiKeyboardControl>k__BackingField; //Field offset: 0x3C

	[Token(Token = "0x17000306")]
	public Focusable focusedElement
	{
		[Address(RVA = "0x33E6BE0", Offset = "0x33E5FE0", Length = "0x5B")]
		[Token(Token = "0x600103C")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000304")]
	private IFocusRing focusRing
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600103A")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000307")]
	internal int imguiKeyboardControl
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001053")]
		internal get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001054")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000305")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextElement selectedTextElement
	{
		[Address(RVA = "0x33E6C40", Offset = "0x33E6040", Length = "0x7B")]
		[Token(Token = "0x600103B")]
		internal set { } //Length: 123
	}

	[Address(RVA = "0x33E6B40", Offset = "0x33E5F40", Length = "0x9D")]
	[Token(Token = "0x6001039")]
	public FocusController(IFocusRing focusRing) { }

	[Address(RVA = "0x33E4880", Offset = "0x33E3C80", Length = "0x112")]
	[Token(Token = "0x600104B")]
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x33E49A0", Offset = "0x33E3DA0", Length = "0x112")]
	[Token(Token = "0x6001049")]
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x33E4BD0", Offset = "0x33E3FD0", Length = "0x10F")]
	[Token(Token = "0x600104D")]
	internal void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x33E4AC0", Offset = "0x33E3EC0", Length = "0x101")]
	[Token(Token = "0x6001044")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void BlurLastFocusedElement() { }

	[Address(RVA = "0x33E4CE0", Offset = "0x33E40E0", Length = "0x74")]
	[Token(Token = "0x6001045")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void DoFocusChange(Focusable f) { }

	[Address(RVA = "0x33E4D60", Offset = "0x33E4160", Length = "0x108")]
	[Token(Token = "0x6001048")]
	internal Focusable FocusNextInDirection(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x33E6BE0", Offset = "0x33E5FE0", Length = "0x5B")]
	[Token(Token = "0x600103C")]
	public Focusable get_focusedElement() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600103A")]
	private IFocusRing get_focusRing() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001053")]
	internal int get_imguiKeyboardControl() { }

	[Address(RVA = "0x33E4FD0", Offset = "0x33E43D0", Length = "0x155")]
	[Token(Token = "0x6001052")]
	internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) { }

	[Address(RVA = "0x33E4E70", Offset = "0x33E4270", Length = "0x15A")]
	[Token(Token = "0x6001047")]
	private static void GetFocusTargets(Focusable f, List<FocusedElement> outTargets) { }

	[Address(RVA = "0x33E5130", Offset = "0x33E4530", Length = "0xB9")]
	[Token(Token = "0x6001040")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Focusable GetLeafFocusedElement() { }

	[Address(RVA = "0x33E51F0", Offset = "0x33E45F0", Length = "0x22C")]
	[Token(Token = "0x600103F")]
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	[Address(RVA = "0x33E5420", Offset = "0x33E4820", Length = "0x345")]
	[Token(Token = "0x600104C")]
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	[Address(RVA = "0x33E5770", Offset = "0x33E4B70", Length = "0xD2")]
	[Token(Token = "0x600103D")]
	public void IgnoreEvent(EventBase evt) { }

	[Address(RVA = "0x33E5850", Offset = "0x33E4C50", Length = "0x14C")]
	[Token(Token = "0x600103E")]
	internal bool IsFocused(Focusable f) { }

	[Address(RVA = "0x33E59A0", Offset = "0x33E4DA0", Length = "0x41")]
	[Token(Token = "0x6001041")]
	private bool IsLocalElement(Focusable f) { }

	[Address(RVA = "0x33E59F0", Offset = "0x33E4DF0", Length = "0xC9")]
	[Token(Token = "0x6001042")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool IsPendingFocus(Focusable f) { }

	[Address(RVA = "0x33E5AC0", Offset = "0x33E4EC0", Length = "0x29B")]
	[Token(Token = "0x6001046")]
	internal void ProcessPendingFocusChange(Focusable f) { }

	[Address(RVA = "0x33E5D60", Offset = "0x33E5160", Length = "0xC6")]
	[Token(Token = "0x6001051")]
	internal void ReevaluateFocus() { }

	[Address(RVA = "0x33E5E30", Offset = "0x33E5230", Length = "0x33E")]
	[Token(Token = "0x600104A")]
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001054")]
	internal void set_imguiKeyboardControl(int value) { }

	[Address(RVA = "0x33E6C40", Offset = "0x33E6040", Length = "0x7B")]
	[Token(Token = "0x600103B")]
	internal void set_selectedTextElement(TextElement value) { }

	[Address(RVA = "0x33E6170", Offset = "0x33E5570", Length = "0x8F")]
	[Token(Token = "0x6001043")]
	internal void SetFocusToLastFocusedElement() { }

	[Address(RVA = "0x33E64E0", Offset = "0x33E58E0", Length = "0xC5")]
	[Token(Token = "0x600104E")]
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x33E65B0", Offset = "0x33E59B0", Length = "0x466")]
	[Token(Token = "0x600104F")]
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = 1) { }

	[Address(RVA = "0x33E6200", Offset = "0x33E5600", Length = "0x2DF")]
	[Token(Token = "0x6001050")]
	internal void SwitchFocusOnEvent(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x33E6A20", Offset = "0x33E5E20", Length = "0x11C")]
	[Token(Token = "0x6001055")]
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

