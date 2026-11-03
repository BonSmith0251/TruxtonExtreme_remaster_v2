namespace UnityEngine;

[Token(Token = "0x2000033")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class TextSelectingUtilities
{
	[Token(Token = "0x2000034")]
	private enum CharacterType : int
	{
		LetterLike = 0,
		Symbol = 1,
		Symbol2 = 2,
		WhiteSpace = 3,
		NewLine = 4,
	}

	[Token(Token = "0x2000035")]
	private enum Direction : int
	{
		Forward = 0,
		Backward = 1,
	}

	[Token(Token = "0x400016B")]
	private const char kNewLineChar = '\uA'; //Field offset: 0x0
	[Token(Token = "0x400016F")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextSelectOp>> s_GlobalKeyMappings; //Field offset: 0x0
	[Token(Token = "0x400016A")]
	private const int kMoveDownHeight = 5; //Field offset: 0x0
	[Token(Token = "0x4000170")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextSelectOp>> s_MacKeyMappings; //Field offset: 0x8
	[Token(Token = "0x4000171")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"keyEvent", "operation"})]
	internal static readonly List<ValueTuple`2<KeyEvent, TextSelectOp>> s_WindowsLinuxKeyMappings; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000162")]
	public DblClickSnapping dblClickSnap; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000163")]
	public int iAltCursorPos; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000164")]
	public bool hasHorizontalCursorPos; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000165")]
	private bool m_bJustSelected; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000166")]
	private bool m_MouseDragSelectsWholeWords; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000167")]
	private int m_DblClickInitPosStart; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000168")]
	private int m_DblClickInitPosEnd; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000169")]
	public TextHandle textHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400016C")]
	private bool m_RevealCursor; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400016D")]
	private int m_CursorIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400016E")]
	internal int m_SelectIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000172")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnCursorIndexChange; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000173")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnSelectIndexChange; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000174")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnRevealCursorChange; //Field offset: 0x50

	[Token(Token = "0x1700008E")]
	private int characterCount
	{
		[Address(RVA = "0x31064D0", Offset = "0x31058D0", Length = "0xC9")]
		[Token(Token = "0x600025A")]
		private get { } //Length: 201
	}

	[Token(Token = "0x17000090")]
	public int cursorIndex
	{
		[Address(RVA = "0x31065B0", Offset = "0x31059B0", Length = "0x62")]
		[Token(Token = "0x600025C")]
		 get { } //Length: 98
		[Address(RVA = "0x3106970", Offset = "0x3105D70", Length = "0x28")]
		[Token(Token = "0x600025D")]
		 set { } //Length: 40
	}

	[Token(Token = "0x17000091")]
	internal int cursorIndexNoValidation
	{
		[Address(RVA = "0x31065A0", Offset = "0x31059A0", Length = "0x6")]
		[Token(Token = "0x600025E")]
		internal get { } //Length: 6
		[Address(RVA = "0x3106970", Offset = "0x3105D70", Length = "0x28")]
		[Token(Token = "0x600025F")]
		internal set { } //Length: 40
	}

	[Token(Token = "0x1700008B")]
	public bool hasSelection
	{
		[Address(RVA = "0x3106620", Offset = "0x3105A20", Length = "0xB6")]
		[Token(Token = "0x6000256")]
		 get { } //Length: 182
	}

	[Token(Token = "0x1700008D")]
	private int m_CharacterCount
	{
		[Address(RVA = "0x31066E0", Offset = "0x3105AE0", Length = "0x1D")]
		[Token(Token = "0x6000259")]
		private get { } //Length: 29
	}

	[Token(Token = "0x1700008F")]
	private TextElementInfo[] m_TextElementInfos
	{
		[Address(RVA = "0x3106700", Offset = "0x3105B00", Length = "0x27")]
		[Token(Token = "0x600025B")]
		private get { } //Length: 39
	}

	[Token(Token = "0x1700008C")]
	public bool revealCursor
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 5
		[Address(RVA = "0x31069A0", Offset = "0x3105DA0", Length = "0x28")]
		[Token(Token = "0x6000258")]
		 set { } //Length: 40
	}

	[Token(Token = "0x17000094")]
	public string selectedText
	{
		[Address(RVA = "0x31067A0", Offset = "0x3105BA0", Length = "0x1C1")]
		[Token(Token = "0x6000265")]
		 get { } //Length: 449
	}

	[Token(Token = "0x17000092")]
	public int selectIndex
	{
		[Address(RVA = "0x3106730", Offset = "0x3105B30", Length = "0x62")]
		[Token(Token = "0x6000261")]
		 get { } //Length: 98
		[Address(RVA = "0x31069D0", Offset = "0x3105DD0", Length = "0x28")]
		[Token(Token = "0x6000262")]
		 set { } //Length: 40
	}

	[Token(Token = "0x17000093")]
	internal int selectIndexNoValidation
	{
		[Address(RVA = "0x31069D0", Offset = "0x3105DD0", Length = "0x28")]
		[Token(Token = "0x6000263")]
		internal set { } //Length: 40
	}

	[Address(RVA = "0x3104F40", Offset = "0x3104340", Length = "0x153D")]
	[Token(Token = "0x60002A1")]
	private static TextSelectingUtilities() { }

	[Address(RVA = "0x3106480", Offset = "0x3105880", Length = "0x50")]
	[Token(Token = "0x6000266")]
	public TextSelectingUtilities(TextHandle textHandle) { }

	[Address(RVA = "0x30FEF90", Offset = "0x30FE390", Length = "0x27")]
	[Token(Token = "0x6000299")]
	private int ClampTextIndex(int index) { }

	[Address(RVA = "0x30FEFC0", Offset = "0x30FE3C0", Length = "0x131")]
	[Token(Token = "0x60002A0")]
	private CharacterType ClassifyChar(int index) { }

	[Address(RVA = "0x30FF100", Offset = "0x30FE500", Length = "0xC")]
	[Token(Token = "0x600026A")]
	public void ClearCursorPos() { }

	[Address(RVA = "0x30FF110", Offset = "0x30FE510", Length = "0x102")]
	[Token(Token = "0x600029F")]
	public void Copy() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6000291")]
	public void DblClickSnap(DblClickSnapping snapping) { }

	[Address(RVA = "0x30FF220", Offset = "0x30FE620", Length = "0x1F8")]
	[Token(Token = "0x6000290")]
	public void ExpandSelectGraphicalLineEnd() { }

	[Address(RVA = "0x30FF420", Offset = "0x30FE820", Length = "0x1F8")]
	[Token(Token = "0x600028F")]
	public void ExpandSelectGraphicalLineStart() { }

	[Address(RVA = "0x30FF620", Offset = "0x30FEA20", Length = "0x1A7")]
	[Token(Token = "0x6000298")]
	private int FindEndOfClassification(int p, Direction dir) { }

	[Address(RVA = "0x30FF7D0", Offset = "0x30FEBD0", Length = "0x1C2")]
	[Token(Token = "0x6000297")]
	public int FindEndOfPreviousWord(int p) { }

	[Address(RVA = "0x30FF9A0", Offset = "0x30FEDA0", Length = "0xED")]
	[Token(Token = "0x6000294")]
	private int FindNextSeperator(int startPos) { }

	[Address(RVA = "0x30FFA90", Offset = "0x30FEE90", Length = "0x167")]
	[Token(Token = "0x6000295")]
	private int FindPrevSeperator(int startPos) { }

	[Address(RVA = "0x30FFC00", Offset = "0x30FF000", Length = "0x2CF")]
	[Token(Token = "0x6000296")]
	public int FindStartOfNextWord(int p) { }

	[Address(RVA = "0x31064D0", Offset = "0x31058D0", Length = "0xC9")]
	[Token(Token = "0x600025A")]
	private int get_characterCount() { }

	[Address(RVA = "0x31065B0", Offset = "0x31059B0", Length = "0x62")]
	[Token(Token = "0x600025C")]
	public int get_cursorIndex() { }

	[Address(RVA = "0x31065A0", Offset = "0x31059A0", Length = "0x6")]
	[Token(Token = "0x600025E")]
	internal int get_cursorIndexNoValidation() { }

	[Address(RVA = "0x3106620", Offset = "0x3105A20", Length = "0xB6")]
	[Token(Token = "0x6000256")]
	public bool get_hasSelection() { }

	[Address(RVA = "0x31066E0", Offset = "0x3105AE0", Length = "0x1D")]
	[Token(Token = "0x6000259")]
	private int get_m_CharacterCount() { }

	[Address(RVA = "0x3106700", Offset = "0x3105B00", Length = "0x27")]
	[Token(Token = "0x600025B")]
	private TextElementInfo[] get_m_TextElementInfos() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000257")]
	public bool get_revealCursor() { }

	[Address(RVA = "0x31067A0", Offset = "0x3105BA0", Length = "0x1C1")]
	[Token(Token = "0x6000265")]
	public string get_selectedText() { }

	[Address(RVA = "0x3106730", Offset = "0x3105B30", Length = "0x62")]
	[Token(Token = "0x6000261")]
	public int get_selectIndex() { }

	[Address(RVA = "0x30FFED0", Offset = "0x30FF2D0", Length = "0x1E")]
	[Token(Token = "0x600029E")]
	private int GetGraphicalLineEnd(int p) { }

	[Address(RVA = "0x30FFEF0", Offset = "0x30FF2F0", Length = "0x1E")]
	[Token(Token = "0x600029D")]
	private int GetGraphicalLineStart(int p) { }

	[Address(RVA = "0x30FFF10", Offset = "0x30FF310", Length = "0xCA")]
	[Token(Token = "0x6000267")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool HandleKeyEvent(KeyCode key, EventModifiers modifiers) { }

	[Address(RVA = "0x30FFFE0", Offset = "0x30FF3E0", Length = "0x3C")]
	[Token(Token = "0x600029A")]
	private int IndexOfEndOfLine(int startIndex) { }

	[Address(RVA = "0x3100020", Offset = "0x30FF420", Length = "0x204")]
	[Token(Token = "0x600028E")]
	public void MouseDragSelectsWholeWords(bool on) { }

	[Address(RVA = "0x3100230", Offset = "0x30FF630", Length = "0xB6")]
	[Token(Token = "0x6000292")]
	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	[Address(RVA = "0x31002F0", Offset = "0x30FF6F0", Length = "0x245")]
	[Token(Token = "0x6000281")]
	public void MoveDown() { }

	[Address(RVA = "0x3100540", Offset = "0x30FF940", Length = "0x171")]
	[Token(Token = "0x6000285")]
	public void MoveGraphicalLineEnd() { }

	[Address(RVA = "0x31006C0", Offset = "0x30FFAC0", Length = "0x171")]
	[Token(Token = "0x6000284")]
	public void MoveGraphicalLineStart() { }

	[Address(RVA = "0x3100840", Offset = "0x30FFC40", Length = "0x26E")]
	[Token(Token = "0x600027F")]
	public void MoveLeft() { }

	[Address(RVA = "0x3100AB0", Offset = "0x30FFEB0", Length = "0x259")]
	[Token(Token = "0x6000283")]
	public void MoveLineEnd() { }

	[Address(RVA = "0x3100D10", Offset = "0x3100110", Length = "0x244")]
	[Token(Token = "0x6000282")]
	public void MoveLineStart() { }

	[Address(RVA = "0x3100F60", Offset = "0x3100360", Length = "0x23F")]
	[Token(Token = "0x6000289")]
	public void MoveParagraphBackward() { }

	[Address(RVA = "0x31011A0", Offset = "0x31005A0", Length = "0x25D")]
	[Token(Token = "0x6000288")]
	public void MoveParagraphForward() { }

	[Address(RVA = "0x3101400", Offset = "0x3100800", Length = "0x273")]
	[Token(Token = "0x600027E")]
	public void MoveRight() { }

	[Address(RVA = "0x3101680", Offset = "0x3100A80", Length = "0x60")]
	[Token(Token = "0x6000287")]
	public void MoveTextEnd() { }

	[Address(RVA = "0x31016E0", Offset = "0x3100AE0", Length = "0x57")]
	[Token(Token = "0x6000286")]
	public void MoveTextStart() { }

	[Address(RVA = "0x3101740", Offset = "0x3100B40", Length = "0x161")]
	[Token(Token = "0x600028C")]
	public void MoveToEndOfPreviousWord() { }

	[Address(RVA = "0x31018B0", Offset = "0x3100CB0", Length = "0x161")]
	[Token(Token = "0x600028B")]
	public void MoveToStartOfNextWord() { }

	[Address(RVA = "0x3101A20", Offset = "0x3100E20", Length = "0x236")]
	[Token(Token = "0x6000280")]
	public void MoveUp() { }

	[Address(RVA = "0x3101C60", Offset = "0x3101060", Length = "0x270")]
	[Token(Token = "0x600028D")]
	public void MoveWordLeft() { }

	[Address(RVA = "0x3101EE0", Offset = "0x31012E0", Length = "0x325")]
	[Token(Token = "0x600028A")]
	public void MoveWordRight() { }

	[Address(RVA = "0x3102210", Offset = "0x3101610", Length = "0x65")]
	[Token(Token = "0x600029C")]
	public int NextCodePointIndex(int index) { }

	[Address(RVA = "0x3102280", Offset = "0x3101680", Length = "0x8A")]
	[Token(Token = "0x600026B")]
	public void OnFocus(bool selectAll = true) { }

	[Address(RVA = "0x3102310", Offset = "0x3101710", Length = "0x5C")]
	[Token(Token = "0x6000268")]
	private bool PerformOperation(TextSelectOp operation) { }

	[Address(RVA = "0x3102870", Offset = "0x3101C70", Length = "0x59")]
	[Token(Token = "0x600029B")]
	public int PreviousCodePointIndex(int index) { }

	[Address(RVA = "0x31028D0", Offset = "0x3101CD0", Length = "0x65")]
	[Token(Token = "0x600026C")]
	public void SelectAll() { }

	[Address(RVA = "0x3102940", Offset = "0x3101D40", Length = "0x246")]
	[Token(Token = "0x600027D")]
	public void SelectCurrentParagraph() { }

	[Address(RVA = "0x3102B90", Offset = "0x3101F90", Length = "0x619")]
	[Token(Token = "0x600027C")]
	public void SelectCurrentWord() { }

	[Address(RVA = "0x31031B0", Offset = "0x31025B0", Length = "0x91")]
	[Token(Token = "0x6000271")]
	public void SelectDown() { }

	[Address(RVA = "0x3103250", Offset = "0x3102650", Length = "0x95")]
	[Token(Token = "0x6000279")]
	public void SelectGraphicalLineEnd() { }

	[Address(RVA = "0x31032F0", Offset = "0x31026F0", Length = "0x95")]
	[Token(Token = "0x6000278")]
	public void SelectGraphicalLineStart() { }

	[Address(RVA = "0x3103390", Offset = "0x3102790", Length = "0x1A8")]
	[Token(Token = "0x600026E")]
	public void SelectLeft() { }

	[Address(RVA = "0x3103540", Offset = "0x3102940", Length = "0x83")]
	[Token(Token = "0x600026D")]
	public void SelectNone() { }

	[Address(RVA = "0x31035D0", Offset = "0x31029D0", Length = "0x280")]
	[Token(Token = "0x600027B")]
	public void SelectParagraphBackward() { }

	[Address(RVA = "0x3103860", Offset = "0x3102C60", Length = "0x229")]
	[Token(Token = "0x600027A")]
	public void SelectParagraphForward() { }

	[Address(RVA = "0x3103A90", Offset = "0x3102E90", Length = "0x1B4")]
	[Token(Token = "0x600026F")]
	public void SelectRight() { }

	[Address(RVA = "0x3103C50", Offset = "0x3103050", Length = "0x35")]
	[Token(Token = "0x6000272")]
	public void SelectTextEnd() { }

	[Address(RVA = "0x3103C90", Offset = "0x3103090", Length = "0x2D")]
	[Token(Token = "0x6000273")]
	public void SelectTextStart() { }

	[Address(RVA = "0x3103CC0", Offset = "0x31030C0", Length = "0x96")]
	[Token(Token = "0x6000275")]
	public void SelectToEndOfPreviousWord() { }

	[Address(RVA = "0x3103D60", Offset = "0x3103160", Length = "0x7B0")]
	[Token(Token = "0x6000293")]
	public void SelectToPosition(Vector2 cursorPosition) { }

	[Address(RVA = "0x3104520", Offset = "0x3103920", Length = "0x96")]
	[Token(Token = "0x6000274")]
	public void SelectToStartOfNextWord() { }

	[Address(RVA = "0x31045C0", Offset = "0x31039C0", Length = "0x91")]
	[Token(Token = "0x6000270")]
	public void SelectUp() { }

	[Address(RVA = "0x3104660", Offset = "0x3103A60", Length = "0x2C9")]
	[Token(Token = "0x6000277")]
	public void SelectWordLeft() { }

	[Address(RVA = "0x3104930", Offset = "0x3103D30", Length = "0x2C9")]
	[Token(Token = "0x6000276")]
	public void SelectWordRight() { }

	[Address(RVA = "0x3106970", Offset = "0x3105D70", Length = "0x28")]
	[Token(Token = "0x600025D")]
	public void set_cursorIndex(int value) { }

	[Address(RVA = "0x3106970", Offset = "0x3105D70", Length = "0x28")]
	[Token(Token = "0x600025F")]
	internal void set_cursorIndexNoValidation(int value) { }

	[Address(RVA = "0x31069A0", Offset = "0x3105DA0", Length = "0x28")]
	[Token(Token = "0x6000258")]
	public void set_revealCursor(bool value) { }

	[Address(RVA = "0x31069D0", Offset = "0x3105DD0", Length = "0x28")]
	[Token(Token = "0x6000262")]
	public void set_selectIndex(int value) { }

	[Address(RVA = "0x31069D0", Offset = "0x3105DD0", Length = "0x28")]
	[Token(Token = "0x6000263")]
	internal void set_selectIndexNoValidation(int value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6000260")]
	internal void SetCursorIndexWithoutNotify(int index) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000264")]
	internal void SetSelectIndexWithoutNotify(int index) { }

	[Address(RVA = "0x3104C00", Offset = "0x3104000", Length = "0x338")]
	[Token(Token = "0x6000269")]
	internal static Nullable<TextSelectOp> TextSelectOpFromEnum(KeyCode key, EventModifiers modifiers, bool IsMacOsFamily) { }

}

