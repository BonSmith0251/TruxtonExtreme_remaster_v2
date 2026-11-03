namespace UnityEngine.UIElements;

[Token(Token = "0x20004A8")]
internal class TextEditingManipulator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F80")]
	private readonly TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F81")]
	private TextEditorEventHandler m_EditingEventHandler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F82")]
	internal TextEditingUtilities editingUtilities; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F83")]
	private bool m_TouchScreenTextFieldInitialized; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F84")]
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; //Field offset: 0x30

	[Token(Token = "0x1700093A")]
	internal TextEditorEventHandler editingEventHandler
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60022E3")]
		internal get { } //Length: 5
		[Address(RVA = "0x32A2D00", Offset = "0x32A2100", Length = "0x71")]
		[Token(Token = "0x60022E4")]
		internal set { } //Length: 113
	}

	[Token(Token = "0x1700093B")]
	private bool touchScreenTextFieldChanged
	{
		[Address(RVA = "0x32A2C60", Offset = "0x32A2060", Length = "0x91")]
		[Token(Token = "0x60022E5")]
		private get { } //Length: 145
	}

	[Address(RVA = "0x32A2B50", Offset = "0x32A1F50", Length = "0x10B")]
	[Token(Token = "0x60022E6")]
	public TextEditingManipulator(TextElement textElement) { }

	[Address(RVA = "0x32A2B00", Offset = "0x32A1F00", Length = "0x4B")]
	[CompilerGenerated]
	[Token(Token = "0x60022EC")]
	private void <OnFocusInEvent>b__14_0() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60022E3")]
	internal TextEditorEventHandler get_editingEventHandler() { }

	[Address(RVA = "0x32A2C60", Offset = "0x32A2060", Length = "0x91")]
	[Token(Token = "0x60022E5")]
	private bool get_touchScreenTextFieldChanged() { }

	[Address(RVA = "0x32A2490", Offset = "0x32A1890", Length = "0x255")]
	[Token(Token = "0x60022E9")]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x32A26F0", Offset = "0x32A1AF0", Length = "0xC6")]
	[Token(Token = "0x60022E8")]
	private void InitTextEditorEventHandler() { }

	[Address(RVA = "0x32A27C0", Offset = "0x32A1BC0", Length = "0x261")]
	[Token(Token = "0x60022EA")]
	private void OnFocusInEvent() { }

	[Address(RVA = "0x32A2A30", Offset = "0x32A1E30", Length = "0x59")]
	[Token(Token = "0x60022EB")]
	private void OnFocusOutEvent() { }

	[Address(RVA = "0x32A2A90", Offset = "0x32A1E90", Length = "0x6A")]
	[Token(Token = "0x60022E7")]
	public void Reset() { }

	[Address(RVA = "0x32A2D00", Offset = "0x32A2100", Length = "0x71")]
	[Token(Token = "0x60022E4")]
	internal void set_editingEventHandler(TextEditorEventHandler value) { }

}

