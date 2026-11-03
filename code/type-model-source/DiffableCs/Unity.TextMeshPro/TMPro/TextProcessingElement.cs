namespace TMPro;

[DebuggerDisplay("{DebuggerDisplay()}")]
[Token(Token = "0x20000B2")]
internal struct TextProcessingElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000667")]
	private TextProcessingElementType m_ElementType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000668")]
	private int m_StartIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000669")]
	private int m_Length; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066A")]
	private CharacterElement m_CharacterElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400066B")]
	private MarkupElement m_MarkupElement; //Field offset: 0x20

	[Token(Token = "0x170001A1")]
	public CharacterElement CharacterElement
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x60006C5")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700019E")]
	public TextProcessingElementType ElementType
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60006BF")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60006C0")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170001A0")]
	public int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60006C3")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60006C4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001A2")]
	public MarkupElement MarkupElement
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60006C6")]
		 get { } //Length: 5
		[Address(RVA = "0x2F210E0", Offset = "0x2F204E0", Length = "0xD3")]
		[Token(Token = "0x60006C7")]
		 set { } //Length: 211
	}

	[Token(Token = "0x1700019F")]
	public int StartIndex
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60006C1")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60006C2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001A3")]
	public static TextProcessingElement Undefined
	{
		[Address(RVA = "0x137D0E0", Offset = "0x137C4E0", Length = "0x14")]
		[Token(Token = "0x60006CC")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x2F210C0", Offset = "0x2F204C0", Length = "0x18")]
	[Token(Token = "0x60006C8")]
	public TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length) { }

	[Address(RVA = "0x2F21070", Offset = "0x2F20470", Length = "0x4C")]
	[Token(Token = "0x60006C9")]
	public TextProcessingElement(TMP_TextElement textElement, int startIndex, int length) { }

	[Address(RVA = "0x2F20FE0", Offset = "0x2F203E0", Length = "0x35")]
	[Token(Token = "0x60006CA")]
	public TextProcessingElement(CharacterElement characterElement, int startIndex, int length) { }

	[Address(RVA = "0x2F21020", Offset = "0x2F20420", Length = "0x4D")]
	[Token(Token = "0x60006CB")]
	public TextProcessingElement(MarkupElement markupElement) { }

	[Address(RVA = "0x2F20EF0", Offset = "0x2F202F0", Length = "0xE6")]
	[Token(Token = "0x60006CD")]
	private string DebuggerDisplay() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x60006C5")]
	public CharacterElement get_CharacterElement() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60006BF")]
	public TextProcessingElementType get_ElementType() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60006C3")]
	public int get_Length() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60006C6")]
	public MarkupElement get_MarkupElement() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60006C1")]
	public int get_StartIndex() { }

	[Address(RVA = "0x137D0E0", Offset = "0x137C4E0", Length = "0x14")]
	[Token(Token = "0x60006CC")]
	public static TextProcessingElement get_Undefined() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60006C0")]
	public void set_ElementType(TextProcessingElementType value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60006C4")]
	public void set_Length(int value) { }

	[Address(RVA = "0x2F210E0", Offset = "0x2F204E0", Length = "0xD3")]
	[Token(Token = "0x60006C7")]
	public void set_MarkupElement(MarkupElement value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60006C2")]
	public void set_StartIndex(int value) { }

}

