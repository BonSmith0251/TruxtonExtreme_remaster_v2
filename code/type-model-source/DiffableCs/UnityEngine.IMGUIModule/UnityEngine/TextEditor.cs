namespace UnityEngine;

[Token(Token = "0x2000031")]
public class TextEditor
{
	[Token(Token = "0x2000032")]
	internal enum DblClickSnapping : byte
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000150")]
	private readonly GUIContent m_Content; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000151")]
	private TextSelectingUtilities m_TextSelecting; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000152")]
	internal TextEditingUtilities m_TextEditing; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000153")]
	internal IMGUITextHandle m_TextHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000154")]
	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000155")]
	public int controlID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000156")]
	public GUIStyle style; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	[Token(Token = "0x4000157")]
	public bool hasHorizontalCursorPos; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000158")]
	public bool isPasswordField; //Field offset: 0x49
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000159")]
	public Vector2 scrollOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400015A")]
	private string m_TextWithWhitespace; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400015B")]
	private Rect <position>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400015C")]
	public Vector2 graphicalCursorPos; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400015D")]
	private Vector2 lastCursorPos; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400015E")]
	private Vector2 previousContentSize; //Field offset: 0x80

	[Token(Token = "0x1700008A")]
	public Rect position
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x600024E")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000087")]
	public bool showCursor
	{
		[Address(RVA = "0x30FEDC0", Offset = "0x30FE1C0", Length = "0x1B")]
		[Token(Token = "0x6000249")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000088")]
	public string text
	{
		[Address(RVA = "0x251BA90", Offset = "0x251AE90", Length = "0x1B")]
		[Token(Token = "0x600024A")]
		 get { } //Length: 27
		[Address(RVA = "0x30FEED0", Offset = "0x30FE2D0", Length = "0xB5")]
		[Token(Token = "0x600024B")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000089")]
	internal string textWithWhitespace
	{
		[Address(RVA = "0x30FEDE0", Offset = "0x30FE1E0", Length = "0x6E")]
		[Token(Token = "0x600024C")]
		internal get { } //Length: 110
		[Address(RVA = "0x30FEE50", Offset = "0x30FE250", Length = "0x7B")]
		[Token(Token = "0x600024D")]
		internal set { } //Length: 123
	}

	[Address(RVA = "0x30FE830", Offset = "0x30FDC30", Length = "0x58F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600024F")]
	public TextEditor() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x600024E")]
	public Rect get_position() { }

	[Address(RVA = "0x30FEDC0", Offset = "0x30FE1C0", Length = "0x1B")]
	[Token(Token = "0x6000249")]
	public bool get_showCursor() { }

	[Address(RVA = "0x251BA90", Offset = "0x251AE90", Length = "0x1B")]
	[Token(Token = "0x600024A")]
	public string get_text() { }

	[Address(RVA = "0x30FEDE0", Offset = "0x30FE1E0", Length = "0x6E")]
	[Token(Token = "0x600024C")]
	internal string get_textWithWhitespace() { }

	[Address(RVA = "0x30FDF80", Offset = "0x30FD380", Length = "0xE0")]
	[Token(Token = "0x6000251")]
	private void OnContentTextChangedHandle() { }

	[Address(RVA = "0x30FE070", Offset = "0x30FD470", Length = "0x7")]
	[Token(Token = "0x6000254")]
	internal override void OnCursorIndexChange() { }

	[Address(RVA = "0x30FE070", Offset = "0x30FD470", Length = "0x7")]
	[Token(Token = "0x6000255")]
	internal override void OnSelectIndexChange() { }

	[Address(RVA = "0x30FE080", Offset = "0x30FD480", Length = "0x53")]
	[Token(Token = "0x6000250")]
	private void OnTextChangedHandle() { }

	[Address(RVA = "0x30FEED0", Offset = "0x30FE2D0", Length = "0xB5")]
	[Token(Token = "0x600024B")]
	public void set_text(string value) { }

	[Address(RVA = "0x30FEE50", Offset = "0x30FE250", Length = "0x7B")]
	[Token(Token = "0x600024D")]
	internal void set_textWithWhitespace(string value) { }

	[Address(RVA = "0x30FE0E0", Offset = "0x30FD4E0", Length = "0x594")]
	[Token(Token = "0x6000253")]
	[VisibleToOtherModules]
	internal void UpdateScrollOffset() { }

	[Address(RVA = "0x30FE680", Offset = "0x30FDA80", Length = "0x1A7")]
	[Token(Token = "0x6000252")]
	internal void UpdateTextHandle() { }

}

