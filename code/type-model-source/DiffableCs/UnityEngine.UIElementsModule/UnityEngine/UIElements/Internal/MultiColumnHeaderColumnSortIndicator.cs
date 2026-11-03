namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000675")]
internal class MultiColumnHeaderColumnSortIndicator : VisualElement
{
	[Token(Token = "0x4001840")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4001841")]
	public static readonly string arrowUssClassName; //Field offset: 0x8
	[Token(Token = "0x4001842")]
	public static readonly string indexLabelUssClassName; //Field offset: 0x10
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001843")]
	private Label m_IndexLabel; //Field offset: 0x2C8

	[Token(Token = "0x17000BAB")]
	public string sortOrderLabel
	{
		[Address(RVA = "0x33688A0", Offset = "0x3367CA0", Length = "0x2D")]
		[Token(Token = "0x6002DFD")]
		 set { } //Length: 45
	}

	[Address(RVA = "0x33685C0", Offset = "0x33679C0", Length = "0x148")]
	[Token(Token = "0x6002DFF")]
	private static MultiColumnHeaderColumnSortIndicator() { }

	[Address(RVA = "0x3368710", Offset = "0x3367B10", Length = "0x18C")]
	[Token(Token = "0x6002DFE")]
	public MultiColumnHeaderColumnSortIndicator() { }

	[Address(RVA = "0x33688A0", Offset = "0x3367CA0", Length = "0x2D")]
	[Token(Token = "0x6002DFD")]
	public void set_sortOrderLabel(string value) { }

}

