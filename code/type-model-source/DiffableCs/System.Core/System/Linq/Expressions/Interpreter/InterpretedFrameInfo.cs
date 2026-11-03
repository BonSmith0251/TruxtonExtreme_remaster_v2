namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x2000191")]
internal struct InterpretedFrameInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000347")]
	private readonly string _methodName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000348")]
	private readonly DebugInfo _debugInfo; //Field offset: 0x8

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x6000852")]
	public InterpretedFrameInfo(string methodName, DebugInfo info) { }

	[Address(RVA = "0x22791D0", Offset = "0x22785D0", Length = "0x7A")]
	[Token(Token = "0x6000853")]
	public virtual string ToString() { }

}

