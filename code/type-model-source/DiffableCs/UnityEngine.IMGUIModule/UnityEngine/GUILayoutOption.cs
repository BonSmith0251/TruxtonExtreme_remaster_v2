namespace UnityEngine;

[Token(Token = "0x2000010")]
public sealed class GUILayoutOption
{
	[Token(Token = "0x2000011")]
	public enum Type : int
	{
		fixedWidth = 0,
		fixedHeight = 1,
		minWidth = 2,
		maxWidth = 3,
		minHeight = 4,
		maxHeight = 5,
		stretchWidth = 6,
		stretchHeight = 7,
		alignStart = 8,
		alignMiddle = 9,
		alignEnd = 10,
		alignJustify = 11,
		equalSize = 12,
		spacing = 13,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005F")]
	internal Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000060")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
	[Token(Token = "0x60000B3")]
	internal GUILayoutOption(Type type, object value) { }

}

