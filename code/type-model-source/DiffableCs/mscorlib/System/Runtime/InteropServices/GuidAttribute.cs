namespace System.Runtime.InteropServices;

[AttributeUsage(5149, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x200044E")]
public sealed class GuidAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001205")]
	internal string _val; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600202C")]
	public GuidAttribute(string guid) { }

}

