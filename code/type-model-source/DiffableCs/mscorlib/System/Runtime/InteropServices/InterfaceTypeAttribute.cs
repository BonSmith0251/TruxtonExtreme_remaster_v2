namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Interface (1024), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000446")]
public sealed class InterfaceTypeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A9")]
	internal ComInterfaceType _val; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002027")]
	public InterfaceTypeAttribute(ComInterfaceType interfaceType) { }

}

