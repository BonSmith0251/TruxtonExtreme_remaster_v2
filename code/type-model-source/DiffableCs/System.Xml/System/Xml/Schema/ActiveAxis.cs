namespace System.Xml.Schema;

[Token(Token = "0x200014B")]
internal class ActiveAxis
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000702")]
	private int _currentDepth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000703")]
	private bool _isActive; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000704")]
	private Asttree _axisTree; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000705")]
	private ArrayList _axisStack; //Field offset: 0x20

	[Token(Token = "0x170003B5")]
	public int CurrentDepth
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000E61")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x2579B90", Offset = "0x2578F90", Length = "0x24A")]
	[Token(Token = "0x6000E63")]
	internal ActiveAxis(Asttree axisTree) { }

	[Address(RVA = "0x2579750", Offset = "0x2578B50", Length = "0x139")]
	[Token(Token = "0x6000E65")]
	public override bool EndElement(string localname, string URN) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000E61")]
	public int get_CurrentDepth() { }

	[Address(RVA = "0x2579890", Offset = "0x2578C90", Length = "0x15B")]
	[Token(Token = "0x6000E66")]
	public bool MoveToAttribute(string localname, string URN) { }

	[Address(RVA = "0x25799F0", Offset = "0x2578DF0", Length = "0x180")]
	[Token(Token = "0x6000E64")]
	public bool MoveToStartElement(string localname, string URN) { }

	[Address(RVA = "0x2579B80", Offset = "0x2578F80", Length = "0xC")]
	[Token(Token = "0x6000E62")]
	internal void Reactivate() { }

}

