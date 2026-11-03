namespace UnityEngine.UIElements.StyleSheets;

[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
[Token(Token = "0x200063F")]
internal struct StyleValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400176E")]
	public StylePropertyId id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400176F")]
	public StyleKeyword keyword; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001770")]
	public float number; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001771")]
	public Length length; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001772")]
	public Color color; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001773")]
	public GCHandle resource; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001774")]
	public BackgroundPosition position; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001775")]
	public BackgroundRepeat repeat; //Field offset: 0x8

}

