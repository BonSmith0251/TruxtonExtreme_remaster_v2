namespace UnityEngine.UIElements;

[Token(Token = "0x20000F7")]
internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40004DA")]
	private static long <Frame>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40004DB")]
	private static TouchScreenKeyboard <activeTouchScreenKeyboard>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004D7")]
	private IVisualElementScheduledItem m_TouchKeyboardPoller; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004D8")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40004D9")]
	private bool m_IsClicking; //Field offset: 0x29

	[Token(Token = "0x1700013F")]
	private static TouchScreenKeyboard activeTouchScreenKeyboard
	{
		[Address(RVA = "0x3391060", Offset = "0x3390460", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60007B9")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700013E")]
	internal static long Frame
	{
		[Address(RVA = "0x3390FE0", Offset = "0x33903E0", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60007B7")]
		internal get { } //Length: 54
		[Address(RVA = "0x3391020", Offset = "0x3390420", Length = "0x3C")]
		[CompilerGenerated]
		[Token(Token = "0x60007B8")]
		private set { } //Length: 60
	}

	[Address(RVA = "0x3390F70", Offset = "0x3390370", Length = "0x6A")]
	[Token(Token = "0x60007BA")]
	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[Address(RVA = "0x338F980", Offset = "0x338ED80", Length = "0xEB")]
	[Token(Token = "0x60007BE")]
	private void CloseTouchScreenKeyboard() { }

	[Address(RVA = "0x338FA70", Offset = "0x338EE70", Length = "0x5CB")]
	[Token(Token = "0x60007BC")]
	private void DoPollTouchScreenKeyboard() { }

	[Address(RVA = "0x3390FE0", Offset = "0x33903E0", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60007B7")]
	internal static long get_Frame() { }

	[Address(RVA = "0x3390040", Offset = "0x338F440", Length = "0x3B8")]
	[Token(Token = "0x60007C0")]
	public virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x3390400", Offset = "0x338F800", Length = "0xE3")]
	[Token(Token = "0x60007C3")]
	private void OnFocusInEvent() { }

	[Address(RVA = "0x33904F0", Offset = "0x338F8F0", Length = "0x281")]
	[Token(Token = "0x60007C4")]
	private void OnFocusOutEvent(FocusOutEvent evt) { }

	[Address(RVA = "0x3390780", Offset = "0x338FB80", Length = "0x13F")]
	[Token(Token = "0x60007C1")]
	private void OnPointerDownEvent() { }

	[Address(RVA = "0x33908C0", Offset = "0x338FCC0", Length = "0x23")]
	[Token(Token = "0x60007C2")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x33908F0", Offset = "0x338FCF0", Length = "0x308")]
	[Token(Token = "0x60007BF")]
	private void OpenTouchScreenKeyboard() { }

	[Address(RVA = "0x3390C00", Offset = "0x3390000", Length = "0x218")]
	[Token(Token = "0x60007BB")]
	private void PollTouchScreenKeyboard() { }

	[Address(RVA = "0x3391060", Offset = "0x3390460", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60007B9")]
	private static void set_activeTouchScreenKeyboard(TouchScreenKeyboard value) { }

	[Address(RVA = "0x3391020", Offset = "0x3390420", Length = "0x3C")]
	[CompilerGenerated]
	[Token(Token = "0x60007B8")]
	private static void set_Frame(long value) { }

	[Address(RVA = "0x3390E20", Offset = "0x3390220", Length = "0x14E")]
	[Token(Token = "0x60007BD")]
	private void UpdateStringPositionFromKeyboard() { }

}

