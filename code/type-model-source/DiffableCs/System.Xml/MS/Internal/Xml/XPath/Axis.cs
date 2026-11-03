namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000274")]
internal class Axis : AstNode
{
	[Token(Token = "0x2000275")]
	internal enum AxisType : int
	{
		Ancestor = 0,
		AncestorOrSelf = 1,
		Attribute = 2,
		Child = 3,
		Descendant = 4,
		DescendantOrSelf = 5,
		Following = 6,
		FollowingSibling = 7,
		Namespace = 8,
		Parent = 9,
		Preceding = 10,
		PrecedingSibling = 11,
		Self = 12,
		None = 13,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DCC")]
	private AxisType _axisType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DCD")]
	private AstNode _input; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DCE")]
	private string _prefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DCF")]
	private string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DD0")]
	private XPathNodeType _nodeType; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000DD1")]
	protected bool abbrAxis; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DD2")]
	private string _urn; //Field offset: 0x38

	[Token(Token = "0x1700069D")]
	public bool AbbrAxis
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x600198A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000698")]
	public AstNode Input
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001984")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001985")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700069A")]
	public string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001987")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700069B")]
	public XPathNodeType NodeType
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001988")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000699")]
	public string Prefix
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001986")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000697")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6001983")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000696")]
	public virtual AstType Type
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001982")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700069C")]
	public AxisType TypeOfAxis
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001989")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700069E")]
	public string Urn
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600198B")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600198C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x24D71D0", Offset = "0x24D65D0", Length = "0x98")]
	[Token(Token = "0x6001980")]
	public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	[Address(RVA = "0x24D7270", Offset = "0x24D6670", Length = "0xA9")]
	[Token(Token = "0x6001981")]
	public Axis(AxisType axisType, AstNode input) { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x600198A")]
	public bool get_AbbrAxis() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001984")]
	public AstNode get_Input() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001987")]
	public string get_Name() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001988")]
	public XPathNodeType get_NodeType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001986")]
	public string get_Prefix() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6001983")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001982")]
	public virtual AstType get_Type() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001989")]
	public AxisType get_TypeOfAxis() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600198B")]
	public string get_Urn() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001985")]
	public void set_Input(AstNode value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600198C")]
	public void set_Urn(string value) { }

}

