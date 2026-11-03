namespace System.Diagnostics;

[AttributeUsage(13, AllowMultiple = True)]
[ComVisible(True)]
[Token(Token = "0x200058A")]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400175F")]
	private string typeName; //Field offset: 0x10

	[Address(RVA = "0x1FC17E0", Offset = "0x1FC0BE0", Length = "0xC0")]
	[Token(Token = "0x60028E9")]
	public DebuggerTypeProxyAttribute(Type type) { }

}

