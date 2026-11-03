namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000456")]
public sealed class FieldOffsetAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001218")]
	internal int _val; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002037")]
	public FieldOffsetAttribute(int offset) { }

}

