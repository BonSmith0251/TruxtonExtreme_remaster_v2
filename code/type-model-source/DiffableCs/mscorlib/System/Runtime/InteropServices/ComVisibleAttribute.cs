namespace System.Runtime.InteropServices;

[AttributeUsage(5597, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x200044A")]
public sealed class ComVisibleAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011B0")]
	internal bool _val; //Field offset: 0x10

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x600202A")]
	public ComVisibleAttribute(bool visibility) { }

}

