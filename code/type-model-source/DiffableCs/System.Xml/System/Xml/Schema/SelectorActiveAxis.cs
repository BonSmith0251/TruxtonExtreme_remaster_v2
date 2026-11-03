namespace System.Xml.Schema;

[Token(Token = "0x2000158")]
internal class SelectorActiveAxis : ActiveAxis
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073E")]
	private ConstraintStruct cs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400073F")]
	private ArrayList KSs; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000740")]
	private int KSpointer; //Field offset: 0x38

	[Token(Token = "0x170003D6")]
	public int lastDepth
	{
		[Address(RVA = "0x2588FD0", Offset = "0x25883D0", Length = "0xA2")]
		[Token(Token = "0x6000ED2")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x2588F40", Offset = "0x2588340", Length = "0x8A")]
	[Token(Token = "0x6000ED3")]
	public SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs) { }

	[Address(RVA = "0x25888A0", Offset = "0x2587CA0", Length = "0x1E5")]
	[Token(Token = "0x6000ED4")]
	public virtual bool EndElement(string localname, string URN) { }

	[Address(RVA = "0x2588FD0", Offset = "0x25883D0", Length = "0xA2")]
	[Token(Token = "0x6000ED2")]
	public int get_lastDepth() { }

	[Address(RVA = "0x2588A90", Offset = "0x2587E90", Length = "0x95")]
	[Token(Token = "0x6000ED6")]
	public KeySequence PopKS() { }

	[Address(RVA = "0x2588B30", Offset = "0x2587F30", Length = "0x402")]
	[Token(Token = "0x6000ED5")]
	public int PushKS(int errline, int errcol) { }

}

