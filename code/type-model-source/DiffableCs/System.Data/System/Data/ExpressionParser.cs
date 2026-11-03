namespace System.Data;

[Token(Token = "0x2000063")]
internal sealed class ExpressionParser
{
	[IsReadOnly]
	[Token(Token = "0x2000064")]
	private struct ReservedWords
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000218")]
		internal readonly string _word; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000219")]
		internal readonly Tokens _token; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400021A")]
		internal readonly int _op; //Field offset: 0xC

		[Address(RVA = "0xD0EDF0", Offset = "0xD0E1F0", Length = "0x36")]
		[Token(Token = "0x60005BF")]
		internal ReservedWords(string word, Tokens token, int op) { }

	}

	[Token(Token = "0x4000206")]
	private static readonly ReservedWords[] s_reservedwords; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000207")]
	private char _escape; //Field offset: 0x10
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000208")]
	private char _decimalSeparator; //Field offset: 0x12
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000209")]
	private char _listSeparator; //Field offset: 0x14
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x400020A")]
	private char _exponentL; //Field offset: 0x16
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020B")]
	private char _exponentU; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400020C")]
	internal Char[] _text; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400020D")]
	internal int _pos; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400020E")]
	internal int _start; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400020F")]
	internal Tokens _token; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000210")]
	internal int _op; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000211")]
	internal OperatorInfo[] _ops; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000212")]
	internal int _topOperator; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000213")]
	internal int _topNode; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000214")]
	private readonly DataTable _table; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000215")]
	internal ExpressionNode[] _nodeStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000216")]
	internal int _prevOperand; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000217")]
	internal ExpressionNode _expression; //Field offset: 0x60

	[Address(RVA = "0x233E360", Offset = "0x233D760", Length = "0x470")]
	[Token(Token = "0x60005BE")]
	private static ExpressionParser() { }

	[Address(RVA = "0x233E7E0", Offset = "0x233DBE0", Length = "0xB2")]
	[Token(Token = "0x60005A6")]
	internal ExpressionParser(DataTable table) { }

	[Address(RVA = "0x233B460", Offset = "0x233A860", Length = "0x35C")]
	[Token(Token = "0x60005AE")]
	private void BuildExpression(int pri) { }

	[Address(RVA = "0x233B7E0", Offset = "0x233ABE0", Length = "0x45")]
	[Token(Token = "0x60005AF")]
	internal void CheckToken(Tokens token) { }

	[Address(RVA = "0x233B8D0", Offset = "0x233ACD0", Length = "0x38")]
	[Token(Token = "0x60005BD")]
	private bool IsAlpha(char ch) { }

	[Address(RVA = "0x233B830", Offset = "0x233AC30", Length = "0x20")]
	[Token(Token = "0x60005BB")]
	private bool IsAlphaNumeric(char ch) { }

	[Address(RVA = "0x233B950", Offset = "0x233AD50", Length = "0x30")]
	[Token(Token = "0x60005BC")]
	private bool IsDigit(char ch) { }

	[Address(RVA = "0x233B9B0", Offset = "0x233ADB0", Length = "0x10")]
	[Token(Token = "0x60005BA")]
	private bool IsWhiteSpace(char ch) { }

	[Address(RVA = "0x233B9C0", Offset = "0x233ADC0", Length = "0xF0")]
	[Token(Token = "0x60005A7")]
	internal void LoadExpression(string data) { }

	[Address(RVA = "0x233BAC0", Offset = "0x233AEC0", Length = "0x3A")]
	[Token(Token = "0x60005AC")]
	private ExpressionNode NodePeek() { }

	[Address(RVA = "0x233BB00", Offset = "0x233AF00", Length = "0x36")]
	[Token(Token = "0x60005AB")]
	private ExpressionNode NodePop() { }

	[Address(RVA = "0x233BB40", Offset = "0x233AF40", Length = "0xAA")]
	[Token(Token = "0x60005AD")]
	private void NodePush(ExpressionNode node) { }

	[Address(RVA = "0x233BF40", Offset = "0x233B340", Length = "0x1278")]
	[Token(Token = "0x60005A9")]
	internal ExpressionNode Parse() { }

	[Address(RVA = "0x233BBF0", Offset = "0x233AFF0", Length = "0x346")]
	[Token(Token = "0x60005AA")]
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	[Address(RVA = "0x233DB80", Offset = "0x233CF80", Length = "0x9C")]
	[Token(Token = "0x60005B0")]
	internal Tokens Scan() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005B5")]
	private void ScanBinaryConstant() { }

	[Address(RVA = "0x233D220", Offset = "0x233C620", Length = "0x116")]
	[Token(Token = "0x60005B4")]
	private void ScanDate() { }

	[Address(RVA = "0x233D420", Offset = "0x233C820", Length = "0x133")]
	[Token(Token = "0x60005B3")]
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	[Address(RVA = "0x233D340", Offset = "0x233C740", Length = "0x7C")]
	[Token(Token = "0x60005B2")]
	private void ScanName() { }

	[Address(RVA = "0x233D560", Offset = "0x233C960", Length = "0x40")]
	[Token(Token = "0x60005B1")]
	private void ScanNumeric() { }

	[Address(RVA = "0x233D740", Offset = "0x233CB40", Length = "0x260")]
	[Token(Token = "0x60005B6")]
	private void ScanReserved() { }

	[Address(RVA = "0x233D9F0", Offset = "0x233CDF0", Length = "0xD1")]
	[Token(Token = "0x60005B7")]
	private void ScanString(char escape) { }

	[Address(RVA = "0x233DAD0", Offset = "0x233CED0", Length = "0x51")]
	[Token(Token = "0x60005B8")]
	internal void ScanToken(Tokens token) { }

	[Address(RVA = "0x233DB30", Offset = "0x233CF30", Length = "0x49")]
	[Token(Token = "0x60005B9")]
	private void ScanWhite() { }

	[Address(RVA = "0x233E2C0", Offset = "0x233D6C0", Length = "0x96")]
	[Token(Token = "0x60005A8")]
	internal void StartScan() { }

}

