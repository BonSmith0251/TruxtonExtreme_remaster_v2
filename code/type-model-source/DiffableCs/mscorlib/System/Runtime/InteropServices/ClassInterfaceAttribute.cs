namespace System.Runtime.InteropServices;

[AttributeUsage(5, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000449")]
public sealed class ClassInterfaceAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011AF")]
	internal ClassInterfaceType _val; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002029")]
	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType) { }

}

