namespace System.Text.RegularExpressions;

[Token(Token = "0x20000EE")]
internal sealed class RegexNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000401")]
	public int NType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000402")]
	public List<RegexNode> Children; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000403")]
	public string Str; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000404")]
	public char Ch; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000405")]
	public int M; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000406")]
	public int N; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000407")]
	public readonly RegexOptions Options; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000408")]
	public RegexNode Next; //Field offset: 0x38

	[Address(RVA = "0x26328D0", Offset = "0x2631CD0", Length = "0x34")]
	[Token(Token = "0x6000584")]
	public RegexNode(int type, RegexOptions options) { }

	[Address(RVA = "0x2632910", Offset = "0x2631D10", Length = "0x46")]
	[Token(Token = "0x6000585")]
	public RegexNode(int type, RegexOptions options, char ch) { }

	[Address(RVA = "0x26327E0", Offset = "0x2631BE0", Length = "0x50")]
	[Token(Token = "0x6000586")]
	public RegexNode(int type, RegexOptions options, string str) { }

	[Address(RVA = "0x2632830", Offset = "0x2631C30", Length = "0x44")]
	[Token(Token = "0x6000587")]
	public RegexNode(int type, RegexOptions options, int m) { }

	[Address(RVA = "0x2632880", Offset = "0x2631C80", Length = "0x4B")]
	[Token(Token = "0x6000588")]
	public RegexNode(int type, RegexOptions options, int m, int n) { }

	[Address(RVA = "0x26315C0", Offset = "0x26309C0", Length = "0x12B")]
	[Token(Token = "0x6000594")]
	public void AddChild(RegexNode newChild) { }

	[Address(RVA = "0x2631740", Offset = "0x2630B40", Length = "0x51")]
	[Token(Token = "0x6000595")]
	public RegexNode Child(int i) { }

	[Address(RVA = "0x26316F0", Offset = "0x2630AF0", Length = "0x41")]
	[Token(Token = "0x6000596")]
	public int ChildCount() { }

	[Address(RVA = "0x26317A0", Offset = "0x2630BA0", Length = "0x101")]
	[Token(Token = "0x6000593")]
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	[Address(RVA = "0x26318B0", Offset = "0x2630CB0", Length = "0xF")]
	[Token(Token = "0x600058B")]
	private void MakeRep(int type, int min, int max) { }

	[Address(RVA = "0x2632430", Offset = "0x2631830", Length = "0x224")]
	[Token(Token = "0x600058C")]
	private RegexNode Reduce() { }

	[Address(RVA = "0x26318C0", Offset = "0x2630CC0", Length = "0x40D")]
	[Token(Token = "0x6000591")]
	private RegexNode ReduceAlternation() { }

	[Address(RVA = "0x2631CD0", Offset = "0x26310D0", Length = "0x3C9")]
	[Token(Token = "0x6000592")]
	private RegexNode ReduceConcatenation() { }

	[Address(RVA = "0x26320A0", Offset = "0x26314A0", Length = "0x67")]
	[Token(Token = "0x600058E")]
	private RegexNode ReduceGroup() { }

	[Address(RVA = "0x2632110", Offset = "0x2631510", Length = "0x1B7")]
	[Token(Token = "0x600058F")]
	private RegexNode ReduceRep() { }

	[Address(RVA = "0x26322D0", Offset = "0x26316D0", Length = "0x15A")]
	[Token(Token = "0x6000590")]
	private RegexNode ReduceSet() { }

	[Address(RVA = "0x2632670", Offset = "0x2631A70", Length = "0x67")]
	[Token(Token = "0x600058A")]
	public RegexNode ReverseLeft() { }

	[Address(RVA = "0x26326E0", Offset = "0x2631AE0", Length = "0xE8")]
	[Token(Token = "0x600058D")]
	private RegexNode StripEnation(int emptyType) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000597")]
	public int Type() { }

	[Address(RVA = "0x26327D0", Offset = "0x2631BD0", Length = "0x8")]
	[Token(Token = "0x6000589")]
	public bool UseOptionR() { }

}

