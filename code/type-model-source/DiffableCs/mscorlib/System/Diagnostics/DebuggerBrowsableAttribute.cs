namespace System.Diagnostics;

[AttributeUsage(384, AllowMultiple = False)]
[ComVisible(True)]
[Token(Token = "0x2000589")]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400175E")]
	private DebuggerBrowsableState state; //Field offset: 0x10

	[Address(RVA = "0x1FC16C0", Offset = "0x1FC0AC0", Length = "0x71")]
	[Token(Token = "0x60028E8")]
	public DebuggerBrowsableAttribute(DebuggerBrowsableState state) { }

}

