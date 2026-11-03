namespace System.Runtime.CompilerServices;

[AttributeUsage(71)]
[ComVisible(True)]
[Token(Token = "0x20004AB")]
public class CompilationRelaxationsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400128F")]
	private int m_relaxations; //Field offset: 0x10

	[Token(Token = "0x17000411")]
	public int CompilationRelaxations
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6002164")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002162")]
	public CompilationRelaxationsAttribute(int relaxations) { }

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002163")]
	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6002164")]
	public int get_CompilationRelaxations() { }

}

