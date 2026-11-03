namespace UnityEngine;

[Token(Token = "0x200002F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextEditingUtilities
{
	[Token(Token = "0x2000030")]
	public struct KeyEvent : IEquatable<KeyEvent>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014E")]
		private KeyCode <key>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400014F")]
		private EventModifiers <modifiers>k__BackingField; //Field offset: 0x4

		[Token(Token = "0x17000085")]
		public KeyCode key
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000241")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000086")]
		public EventModifiers modifiers
		{
			[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000242")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x6000240")]
		public KeyEvent(KeyCode key, EventModifiers modifiers) { }

		[Address(RVA = "0x30F9930", Offset = "0x30F8D30", Length = "0x85")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000247")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x30F99C0", Offset = "0x30F8DC0", Length = "0xC8")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000248")]
		public override bool Equals(KeyEvent other) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000241")]
		public KeyCode get_key() { }

		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000242")]
		public EventModifiers get_modifiers() { }

		[Address(RVA = "0x30F9A90", Offset = "0x30F8E90", Length = "0xA5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000246")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x30F9D20", Offset = "0x30F9120", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x6000245")]
		public static bool op_Equality(KeyEvent left, KeyEvent right) { }

		[Address(RVA = "0x30F9B40", Offset = "0x30F8F40", Length = "0xFA")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000244")]
		private bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x30F9C40", Offset = "0x30F9040", Length = "0xDB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000243")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x400014A")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextEditOp>> s_GlobalKeyMappings; //Field offset: 0x0
	[Token(Token = "0x400014B")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextEditOp>> s_MacKeyMappings; //Field offset: 0x8
	[Token(Token = "0x400014C")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextEditOp>> s_WindowsLinuxKeyMappings; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000142")]
	private TextSelectingUtilities m_TextSelectingUtility; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000143")]
	internal TextHandle textHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000144")]
	private int m_CursorIndexSavedState; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000145")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool isCompositionActive; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000146")]
	private bool m_UpdateImeWindowPosition; //Field offset: 0x25
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000147")]
	internal Action OnTextChanged; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000148")]
	public bool multiline; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000149")]
	private string m_Text; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014D")]
	private char m_HighSurrogate; //Field offset: 0x40

	[Token(Token = "0x1700007F")]
	private int cursorIndex
	{
		[Address(RVA = "0x30FDBA0", Offset = "0x30FCFA0", Length = "0x68")]
		[Token(Token = "0x600021C")]
		private get { } //Length: 104
		[Address(RVA = "0x30FDE50", Offset = "0x30FD250", Length = "0x3B")]
		[Token(Token = "0x600021D")]
		private set { } //Length: 59
	}

	[Token(Token = "0x17000080")]
	private int cursorIndexNoValidation
	{
		[Address(RVA = "0x30FDB80", Offset = "0x30FCF80", Length = "0x1A")]
		[Token(Token = "0x600021E")]
		private get { } //Length: 26
		[Address(RVA = "0x30FDE50", Offset = "0x30FD250", Length = "0x3B")]
		[Token(Token = "0x600021F")]
		private set { } //Length: 59
	}

	[Token(Token = "0x1700007C")]
	private bool hasSelection
	{
		[Address(RVA = "0x30FDC10", Offset = "0x30FD010", Length = "0xC0")]
		[Token(Token = "0x6000219")]
		private get { } //Length: 192
	}

	[Token(Token = "0x1700007D")]
	internal bool revealCursor
	{
		[Address(RVA = "0x30FDE90", Offset = "0x30FD290", Length = "0x3B")]
		[Token(Token = "0x600021A")]
		internal set { } //Length: 59
	}

	[Token(Token = "0x17000083")]
	private int selectIndex
	{
		[Address(RVA = "0x30FDCE0", Offset = "0x30FD0E0", Length = "0x68")]
		[Token(Token = "0x6000222")]
		private get { } //Length: 104
		[Address(RVA = "0x30FDED0", Offset = "0x30FD2D0", Length = "0x3B")]
		[Token(Token = "0x6000223")]
		private set { } //Length: 59
	}

	[Token(Token = "0x17000081")]
	private int selectIndexNoValidation
	{
		[Address(RVA = "0x30FDED0", Offset = "0x30FD2D0", Length = "0x3B")]
		[Token(Token = "0x6000220")]
		private set { } //Length: 59
	}

	[Token(Token = "0x1700007E")]
	internal int stringCursorIndex
	{
		[Address(RVA = "0x30FDD50", Offset = "0x30FD150", Length = "0x7D")]
		[Token(Token = "0x600021B")]
		internal get { } //Length: 125
	}

	[Token(Token = "0x17000082")]
	internal int stringSelectIndex
	{
		[Address(RVA = "0x30FDDD0", Offset = "0x30FD1D0", Length = "0x7D")]
		[Token(Token = "0x6000221")]
		internal get { } //Length: 125
	}

	[Token(Token = "0x17000084")]
	public string text
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000224")]
		 get { } //Length: 5
		[Address(RVA = "0x30FDF10", Offset = "0x30FD310", Length = "0x6B")]
		[Token(Token = "0x6000225")]
		 set { } //Length: 107
	}

	[Address(RVA = "0x30FBE30", Offset = "0x30FB230", Length = "0x1CC2")]
	[Token(Token = "0x600023F")]
	private static TextEditingUtilities() { }

	[Address(RVA = "0x30FDB00", Offset = "0x30FCF00", Length = "0x76")]
	[Token(Token = "0x6000227")]
	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	[Address(RVA = "0x30F9D40", Offset = "0x30F9140", Length = "0x309")]
	[Token(Token = "0x6000235")]
	public bool Backspace() { }

	[Address(RVA = "0x30FA050", Offset = "0x30F9450", Length = "0x52")]
	[Token(Token = "0x6000239")]
	public bool CanPaste() { }

	[Address(RVA = "0x30FA0B0", Offset = "0x30F94B0", Length = "0x2D")]
	[Token(Token = "0x600023A")]
	public bool Cut() { }

	[Address(RVA = "0x30FA8C0", Offset = "0x30F9CC0", Length = "0x1D4")]
	[Token(Token = "0x6000234")]
	public bool Delete() { }

	[Address(RVA = "0x30FA0E0", Offset = "0x30F94E0", Length = "0x1FB")]
	[Token(Token = "0x6000231")]
	public bool DeleteLineBack() { }

	[Address(RVA = "0x30FA2E0", Offset = "0x30F96E0", Length = "0x315")]
	[Token(Token = "0x6000236")]
	public bool DeleteSelection() { }

	[Address(RVA = "0x30FA600", Offset = "0x30F9A00", Length = "0x173")]
	[Token(Token = "0x6000232")]
	public bool DeleteWordBack() { }

	[Address(RVA = "0x30FA780", Offset = "0x30F9B80", Length = "0x13D")]
	[Token(Token = "0x6000233")]
	public bool DeleteWordForward() { }

	[Address(RVA = "0x30FAAA0", Offset = "0x30F9EA0", Length = "0xCB")]
	[Token(Token = "0x600022C")]
	public void EnableCursorPreviewState() { }

	[Address(RVA = "0x30FAB70", Offset = "0x30F9F70", Length = "0xE3")]
	[Token(Token = "0x600022B")]
	public string GeneratePreviewString(bool richText) { }

	[Address(RVA = "0x30FDBA0", Offset = "0x30FCFA0", Length = "0x68")]
	[Token(Token = "0x600021C")]
	private int get_cursorIndex() { }

	[Address(RVA = "0x30FDB80", Offset = "0x30FCF80", Length = "0x1A")]
	[Token(Token = "0x600021E")]
	private int get_cursorIndexNoValidation() { }

	[Address(RVA = "0x30FDC10", Offset = "0x30FD010", Length = "0xC0")]
	[Token(Token = "0x6000219")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x30FDCE0", Offset = "0x30FD0E0", Length = "0x68")]
	[Token(Token = "0x6000222")]
	private int get_selectIndex() { }

	[Address(RVA = "0x30FDD50", Offset = "0x30FD150", Length = "0x7D")]
	[Token(Token = "0x600021B")]
	internal int get_stringCursorIndex() { }

	[Address(RVA = "0x30FDDD0", Offset = "0x30FD1D0", Length = "0x7D")]
	[Token(Token = "0x6000221")]
	internal int get_stringSelectIndex() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000224")]
	public string get_text() { }

	[Address(RVA = "0x30FAC60", Offset = "0x30FA060", Length = "0xCA")]
	[Token(Token = "0x600022E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool HandleKeyEvent(KeyCode key, EventModifiers modifiers) { }

	[Address(RVA = "0x30FAD30", Offset = "0x30FA130", Length = "0x140")]
	[Token(Token = "0x6000238")]
	public bool Insert(char c) { }

	[Address(RVA = "0x30FAE80", Offset = "0x30FA280", Length = "0x5B")]
	[Token(Token = "0x600023D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void OnBlur() { }

	[Address(RVA = "0x30FAEE0", Offset = "0x30FA2E0", Length = "0x149")]
	[Token(Token = "0x600023B")]
	public bool Paste() { }

	[Address(RVA = "0x30FB030", Offset = "0x30FA430", Length = "0x580")]
	[Token(Token = "0x6000230")]
	private void PerformOperation(TextEditOp operation) { }

	[Address(RVA = "0x30FB620", Offset = "0x30FAA20", Length = "0x8F")]
	[Token(Token = "0x600023C")]
	private static string ReplaceNewlinesWithSpaces(string value) { }

	[Address(RVA = "0x30FB6B0", Offset = "0x30FAAB0", Length = "0x193")]
	[Token(Token = "0x6000237")]
	public void ReplaceSelection(string replace) { }

	[Address(RVA = "0x30FB850", Offset = "0x30FAC50", Length = "0x7E")]
	[Token(Token = "0x600022D")]
	public void RestoreCursorState() { }

	[Address(RVA = "0x30FDE50", Offset = "0x30FD250", Length = "0x3B")]
	[Token(Token = "0x600021D")]
	private void set_cursorIndex(int value) { }

	[Address(RVA = "0x30FDE50", Offset = "0x30FD250", Length = "0x3B")]
	[Token(Token = "0x600021F")]
	private void set_cursorIndexNoValidation(int value) { }

	[Address(RVA = "0x30FDE90", Offset = "0x30FD290", Length = "0x3B")]
	[Token(Token = "0x600021A")]
	internal void set_revealCursor(bool value) { }

	[Address(RVA = "0x30FDED0", Offset = "0x30FD2D0", Length = "0x3B")]
	[Token(Token = "0x6000223")]
	private void set_selectIndex(int value) { }

	[Address(RVA = "0x30FDED0", Offset = "0x30FD2D0", Length = "0x3B")]
	[Token(Token = "0x6000220")]
	private void set_selectIndexNoValidation(int value) { }

	[Address(RVA = "0x30FDF10", Offset = "0x30FD310", Length = "0x6B")]
	[Token(Token = "0x6000225")]
	public void set_text(string value) { }

	[Address(RVA = "0x30FB8D0", Offset = "0x30FACD0", Length = "0x10C")]
	[Token(Token = "0x600022A")]
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000226")]
	internal void SetTextWithoutNotify(string value) { }

	[Address(RVA = "0x30FB9E0", Offset = "0x30FADE0", Length = "0x7")]
	[Token(Token = "0x6000229")]
	public bool ShouldUpdateImeWindowPosition() { }

	[Address(RVA = "0x30FB9F0", Offset = "0x30FADF0", Length = "0x338")]
	[Token(Token = "0x600022F")]
	internal static Nullable<TextEditOp> TextEditOpFromEnum(KeyCode key, EventModifiers modifiers, bool IsMacOsFamily) { }

	[Address(RVA = "0x30FBD30", Offset = "0x30FB130", Length = "0x62")]
	[Token(Token = "0x600023E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool TouchScreenKeyboardShouldBeUsed() { }

	[Address(RVA = "0x30FBDA0", Offset = "0x30FB1A0", Length = "0x8D")]
	[Token(Token = "0x6000228")]
	public bool UpdateImeState() { }

}

