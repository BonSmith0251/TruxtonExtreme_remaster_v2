namespace UnityEngine.UIElements;

[Token(Token = "0x2000157")]
internal class TabDragLocationPreview : VisualElement
{
	[Token(Token = "0x40006CB")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40006CC")]
	public static readonly string visualUssClassName; //Field offset: 0x8
	[Token(Token = "0x40006CD")]
	public static readonly string verticalUssClassName; //Field offset: 0x10
	[Token(Token = "0x40006CE")]
	public static readonly string horizontalUssClassName; //Field offset: 0x18
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40006CF")]
	private VisualElement m_Preview; //Field offset: 0x2C8

	[Token(Token = "0x170001C8")]
	internal VisualElement preview
	{
		[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
		[Token(Token = "0x6000A66")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x33B3BC0", Offset = "0x33B2FC0", Length = "0x1A4")]
	[Token(Token = "0x6000A68")]
	private static TabDragLocationPreview() { }

	[Address(RVA = "0x33B3D70", Offset = "0x33B3170", Length = "0x127")]
	[Token(Token = "0x6000A67")]
	public TabDragLocationPreview() { }

	[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
	[Token(Token = "0x6000A66")]
	internal VisualElement get_preview() { }

}

