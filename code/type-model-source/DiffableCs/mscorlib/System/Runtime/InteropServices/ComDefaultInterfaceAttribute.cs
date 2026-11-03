namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000447")]
public sealed class ComDefaultInterfaceAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011AA")]
	internal Type _val; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6002028")]
	public ComDefaultInterfaceAttribute(Type defaultInterface) { }

}

