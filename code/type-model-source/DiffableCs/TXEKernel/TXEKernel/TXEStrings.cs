namespace TXEKernel;

[Token(Token = "0x20000F7")]
public static class TXEStrings
{
	[Token(Token = "0x4000502")]
	public static readonly String[] OffOnString; //Field offset: 0x0
	[Token(Token = "0x4000503")]
	public static readonly String[] ClockString; //Field offset: 0x8
	[Token(Token = "0x4000504")]
	public static readonly String[] RulerString; //Field offset: 0x10
	[Token(Token = "0x4000505")]
	public static readonly String[] P1P2String; //Field offset: 0x18
	[Token(Token = "0x4000506")]
	public static readonly String[] NvReflexString; //Field offset: 0x20

	[Address(RVA = "0x2718680", Offset = "0x2717A80", Length = "0x3E0")]
	[Token(Token = "0x600072A")]
	private static TXEStrings() { }

}

