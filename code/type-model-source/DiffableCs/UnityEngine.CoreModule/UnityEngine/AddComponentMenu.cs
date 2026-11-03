namespace UnityEngine;

[Token(Token = "0x2000187")]
public sealed class AddComponentMenu : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000627")]
	private string m_AddComponentMenu; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000628")]
	private int m_Ordering; //Field offset: 0x18

	[Address(RVA = "0x3053FE0", Offset = "0x30533E0", Length = "0x39")]
	[Token(Token = "0x6001283")]
	public AddComponentMenu(string menuName) { }

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x6001284")]
	public AddComponentMenu(string menuName, int order) { }

}

