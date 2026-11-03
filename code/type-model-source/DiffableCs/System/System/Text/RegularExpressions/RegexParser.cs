namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F0")]
internal sealed class RegexParser
{
	[Token(Token = "0x4000427")]
	private static readonly Byte[] s_category; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000414")]
	private RegexNode _stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000415")]
	private RegexNode _group; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000416")]
	private RegexNode _alternation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000417")]
	private RegexNode _concatenation; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000418")]
	private RegexNode _unit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000419")]
	private string _pattern; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041A")]
	private int _currentPos; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400041B")]
	private CultureInfo _culture; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400041C")]
	private int _autocap; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400041D")]
	private int _capcount; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400041E")]
	private int _captop; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400041F")]
	private int _capsize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000420")]
	private Hashtable _caps; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000421")]
	private Hashtable _capnames; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000422")]
	private Int32[] _capnumlist; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000423")]
	private List<String> _capnamelist; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000424")]
	private RegexOptions _options; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000425")]
	private List<RegexOptions> _optionsStack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000426")]
	private bool _ignoreNextParen; //Field offset: 0x90

	[Address(RVA = "0x2639150", Offset = "0x2638550", Length = "0x8C")]
	[Token(Token = "0x60005E2")]
	private static RegexParser() { }

	[Address(RVA = "0x26391E0", Offset = "0x26385E0", Length = "0xC5")]
	[Token(Token = "0x600059A")]
	private RegexParser(CultureInfo culture) { }

	[Address(RVA = "0x2632960", Offset = "0x2631D60", Length = "0x12A")]
	[Token(Token = "0x60005C9")]
	private void AddAlternate() { }

	[Address(RVA = "0x2632C10", Offset = "0x2632010", Length = "0x21C")]
	[Token(Token = "0x60005C4")]
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	[Address(RVA = "0x2632BD0", Offset = "0x2631FD0", Length = "0x3B")]
	[Token(Token = "0x60005CA")]
	private void AddConcatenate() { }

	[Address(RVA = "0x2632A90", Offset = "0x2631E90", Length = "0x13E")]
	[Token(Token = "0x60005CB")]
	private void AddConcatenate(bool lazy, int min, int max) { }

	[Address(RVA = "0x2632E30", Offset = "0x2632230", Length = "0x1C5")]
	[Token(Token = "0x60005D2")]
	private void AddGroup() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60005D0")]
	private void AddUnitNode(RegexNode node) { }

	[Address(RVA = "0x2633000", Offset = "0x2632400", Length = "0xD7")]
	[Token(Token = "0x60005CE")]
	private void AddUnitNotone(char ch) { }

	[Address(RVA = "0x26330E0", Offset = "0x26324E0", Length = "0xD7")]
	[Token(Token = "0x60005CD")]
	private void AddUnitOne(char ch) { }

	[Address(RVA = "0x26331C0", Offset = "0x26325C0", Length = "0x93")]
	[Token(Token = "0x60005CF")]
	private void AddUnitSet(string cc) { }

	[Address(RVA = "0x2633260", Offset = "0x2632660", Length = "0x7E")]
	[Token(Token = "0x60005D1")]
	private void AddUnitType(int type) { }

	[Address(RVA = "0x26332E0", Offset = "0x26326E0", Length = "0x6F9")]
	[Token(Token = "0x60005B5")]
	private void AssignNameSlots() { }

	[Address(RVA = "0x26339E0", Offset = "0x2632DE0", Length = "0x56")]
	[Token(Token = "0x60005B6")]
	private int CaptureSlotFromName(string capname) { }

	[Address(RVA = "0x2633A40", Offset = "0x2632E40", Length = "0x1E")]
	[Token(Token = "0x60005DE")]
	private char CharAt(int i) { }

	[Address(RVA = "0x2633A60", Offset = "0x2632E60", Length = "0x1D")]
	[Token(Token = "0x60005E1")]
	private int CharsRight() { }

	[Address(RVA = "0x2633A80", Offset = "0x2632E80", Length = "0x4E8")]
	[Token(Token = "0x60005B1")]
	private void CountCaptures() { }

	[Address(RVA = "0x2633F90", Offset = "0x2633390", Length = "0x43")]
	[Token(Token = "0x60005D5")]
	private bool EmptyOptionsStack() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x60005C7")]
	private bool EmptyStack() { }

	[Address(RVA = "0x2633FE0", Offset = "0x26333E0", Length = "0x31")]
	[Token(Token = "0x60005A9")]
	private static int HexDigit(char ch) { }

	[Address(RVA = "0x2634020", Offset = "0x2633420", Length = "0x22")]
	[Token(Token = "0x60005B8")]
	private bool IsCaptureName(string capname) { }

	[Address(RVA = "0x2634050", Offset = "0x2633450", Length = "0x63")]
	[Token(Token = "0x60005B7")]
	private bool IsCaptureSlot(int i) { }

	[Address(RVA = "0x26340C0", Offset = "0x26334C0", Length = "0x1A")]
	[Token(Token = "0x60005AB")]
	private bool IsOnlyTopOption(RegexOptions option) { }

	[Address(RVA = "0x26340E0", Offset = "0x26334E0", Length = "0x7E")]
	[Token(Token = "0x60005C1")]
	private static bool IsQuantifier(char ch) { }

	[Address(RVA = "0x2634160", Offset = "0x2633560", Length = "0x7E")]
	[Token(Token = "0x60005C3")]
	private static bool IsSpace(char ch) { }

	[Address(RVA = "0x26341E0", Offset = "0x26335E0", Length = "0x7E")]
	[Token(Token = "0x60005BF")]
	private static bool IsSpecial(char ch) { }

	[Address(RVA = "0x2634260", Offset = "0x2633660", Length = "0x7E")]
	[Token(Token = "0x60005C0")]
	private static bool IsStopperX(char ch) { }

	[Address(RVA = "0x26342E0", Offset = "0x26336E0", Length = "0x172")]
	[Token(Token = "0x60005C2")]
	private bool IsTrueQuantifier() { }

	[Address(RVA = "0x2634460", Offset = "0x2633860", Length = "0x7C")]
	[Token(Token = "0x60005D7")]
	private ArgumentException MakeException(string message) { }

	[Address(RVA = "0x26344E0", Offset = "0x26338E0", Length = "0x4")]
	[Token(Token = "0x60005DD")]
	private void MoveLeft() { }

	[Address(RVA = "0x26344F0", Offset = "0x26338F0", Length = "0x4")]
	[Token(Token = "0x60005DB")]
	private void MoveRight() { }

	[Address(RVA = "0x2634500", Offset = "0x2633900", Length = "0x4")]
	[Token(Token = "0x60005DC")]
	private void MoveRight(int i) { }

	[Address(RVA = "0x2634510", Offset = "0x2633910", Length = "0x155")]
	[Token(Token = "0x60005B3")]
	private void NoteCaptureName(string name, int pos) { }

	[Address(RVA = "0x2634760", Offset = "0x2633B60", Length = "0x47")]
	[Token(Token = "0x60005B4")]
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	[Address(RVA = "0x2634670", Offset = "0x2633A70", Length = "0xEB")]
	[Token(Token = "0x60005B2")]
	private void NoteCaptureSlot(int i, int pos) { }

	[Address(RVA = "0x26347B0", Offset = "0x2633BB0", Length = "0x80")]
	[Token(Token = "0x60005B0")]
	private static RegexOptions OptionFromCode(char ch) { }

	[Address(RVA = "0x2634BA0", Offset = "0x2633FA0", Length = "0x24F")]
	[Token(Token = "0x6000598")]
	public static RegexTree Parse(string re, RegexOptions op) { }

	[Address(RVA = "0x2634850", Offset = "0x2633C50", Length = "0x1CB")]
	[Token(Token = "0x60005AE")]
	private string ParseProperty() { }

	[Address(RVA = "0x2634A20", Offset = "0x2633E20", Length = "0x172")]
	[Token(Token = "0x6000599")]
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	[Address(RVA = "0x2634DF0", Offset = "0x26341F0", Length = "0x12B")]
	[Token(Token = "0x60005C6")]
	private void PopGroup() { }

	[Address(RVA = "0x2634F20", Offset = "0x2634320", Length = "0x5F")]
	[Token(Token = "0x60005D6")]
	private void PopKeepOptions() { }

	[Address(RVA = "0x2634F80", Offset = "0x2634380", Length = "0x95")]
	[Token(Token = "0x60005D4")]
	private void PopOptions() { }

	[Address(RVA = "0x2635020", Offset = "0x2634420", Length = "0x72")]
	[Token(Token = "0x60005C5")]
	private void PushGroup() { }

	[Address(RVA = "0x26350A0", Offset = "0x26344A0", Length = "0x90")]
	[Token(Token = "0x60005D3")]
	private void PushOptions() { }

	[Address(RVA = "0x2635140", Offset = "0x2634540", Length = "0x9E")]
	[Token(Token = "0x600059C")]
	private void Reset(RegexOptions topopts) { }

	[Address(RVA = "0x2635240", Offset = "0x2634640", Length = "0x24")]
	[Token(Token = "0x60005E0")]
	private char RightChar(int i) { }

	[Address(RVA = "0x2635210", Offset = "0x2634610", Length = "0x24")]
	[Token(Token = "0x60005DF")]
	internal char RightChar() { }

	[Address(RVA = "0x26351E0", Offset = "0x26345E0", Length = "0x2A")]
	[Token(Token = "0x60005DA")]
	private char RightCharMoveRight() { }

	[Address(RVA = "0x2635270", Offset = "0x2634670", Length = "0x590")]
	[Token(Token = "0x60005A2")]
	private RegexNode ScanBackslash(bool scanOnly) { }

	[Address(RVA = "0x2635820", Offset = "0x2634C20", Length = "0x6EF")]
	[Token(Token = "0x60005A3")]
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	[Address(RVA = "0x2635F10", Offset = "0x2635310", Length = "0x39D")]
	[Token(Token = "0x60005A1")]
	private void ScanBlank() { }

	[Address(RVA = "0x26362B0", Offset = "0x26356B0", Length = "0xB0")]
	[Token(Token = "0x60005A5")]
	private string ScanCapname() { }

	[Address(RVA = "0x2636370", Offset = "0x2635770", Length = "0x8DC")]
	[Token(Token = "0x600059F")]
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	[Address(RVA = "0x2636C50", Offset = "0x2636050", Length = "0x110")]
	[Token(Token = "0x60005AD")]
	private char ScanCharEscape() { }

	[Address(RVA = "0x2637010", Offset = "0x2636410", Length = "0xC1")]
	[Token(Token = "0x60005AA")]
	private char ScanControl() { }

	[Address(RVA = "0x26370E0", Offset = "0x26364E0", Length = "0xB4")]
	[Token(Token = "0x60005A7")]
	private int ScanDecimal() { }

	[Address(RVA = "0x26371A0", Offset = "0x26365A0", Length = "0x444")]
	[Token(Token = "0x60005A4")]
	private RegexNode ScanDollar() { }

	[Address(RVA = "0x26375F0", Offset = "0x26369F0", Length = "0xCA7")]
	[Token(Token = "0x60005A0")]
	private RegexNode ScanGroupOpen() { }

	[Address(RVA = "0x26382A0", Offset = "0x26376A0", Length = "0x114")]
	[Token(Token = "0x60005A8")]
	private char ScanHex(int c) { }

	[Address(RVA = "0x26383C0", Offset = "0x26377C0", Length = "0x99")]
	[Token(Token = "0x60005A6")]
	private char ScanOctal() { }

	[Address(RVA = "0x2638460", Offset = "0x2637860", Length = "0xFA")]
	[Token(Token = "0x60005AC")]
	private void ScanOptions() { }

	[Address(RVA = "0x2638560", Offset = "0x2637960", Length = "0x3B4")]
	[Token(Token = "0x600059D")]
	private RegexNode ScanRegex() { }

	[Address(RVA = "0x2638DF0", Offset = "0x26381F0", Length = "0x161")]
	[Token(Token = "0x600059E")]
	private RegexNode ScanReplacement() { }

	[Address(RVA = "0x2638F60", Offset = "0x2638360", Length = "0x39")]
	[Token(Token = "0x600059B")]
	private void SetPattern(string Re) { }

	[Address(RVA = "0x2638FA0", Offset = "0x26383A0", Length = "0xC2")]
	[Token(Token = "0x60005C8")]
	private void StartGroup(RegexNode openGroup) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60005D8")]
	private int Textpos() { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x60005D9")]
	private void Textto(int pos) { }

	[Address(RVA = "0x2639070", Offset = "0x2638470", Length = "0x79")]
	[Token(Token = "0x60005AF")]
	private int TypeFromCode(char ch) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60005CC")]
	private RegexNode Unit() { }

	[Address(RVA = "0x26390F0", Offset = "0x26384F0", Length = "0xE")]
	[Token(Token = "0x60005BE")]
	private bool UseOptionE() { }

	[Address(RVA = "0x2639100", Offset = "0x2638500", Length = "0xA")]
	[Token(Token = "0x60005BA")]
	private bool UseOptionI() { }

	[Address(RVA = "0x2639110", Offset = "0x2638510", Length = "0xB")]
	[Token(Token = "0x60005BB")]
	private bool UseOptionM() { }

	[Address(RVA = "0x2639120", Offset = "0x2638520", Length = "0xB")]
	[Token(Token = "0x60005B9")]
	private bool UseOptionN() { }

	[Address(RVA = "0x2639130", Offset = "0x2638530", Length = "0xB")]
	[Token(Token = "0x60005BC")]
	private bool UseOptionS() { }

	[Address(RVA = "0x2639140", Offset = "0x2638540", Length = "0xB")]
	[Token(Token = "0x60005BD")]
	private bool UseOptionX() { }

}

