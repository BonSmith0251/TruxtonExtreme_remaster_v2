namespace System.Linq.Expressions;

[Token(Token = "0x20000C4")]
internal static class Utils
{
	[Token(Token = "0x40001D5")]
	public static readonly object BoxedFalse; //Field offset: 0x0
	[Token(Token = "0x40001D6")]
	public static readonly object BoxedTrue; //Field offset: 0x8
	[Token(Token = "0x40001D7")]
	public static readonly object BoxedIntM1; //Field offset: 0x10
	[Token(Token = "0x40001D8")]
	public static readonly object BoxedInt0; //Field offset: 0x18
	[Token(Token = "0x40001D9")]
	public static readonly object BoxedInt1; //Field offset: 0x20
	[Token(Token = "0x40001DA")]
	public static readonly object BoxedInt2; //Field offset: 0x28
	[Token(Token = "0x40001DB")]
	public static readonly object BoxedInt3; //Field offset: 0x30
	[Token(Token = "0x40001DC")]
	public static readonly object BoxedDefaultSByte; //Field offset: 0x38
	[Token(Token = "0x40001DD")]
	public static readonly object BoxedDefaultChar; //Field offset: 0x40
	[Token(Token = "0x40001DE")]
	public static readonly object BoxedDefaultInt16; //Field offset: 0x48
	[Token(Token = "0x40001DF")]
	public static readonly object BoxedDefaultInt64; //Field offset: 0x50
	[Token(Token = "0x40001E0")]
	public static readonly object BoxedDefaultByte; //Field offset: 0x58
	[Token(Token = "0x40001E1")]
	public static readonly object BoxedDefaultUInt16; //Field offset: 0x60
	[Token(Token = "0x40001E2")]
	public static readonly object BoxedDefaultUInt32; //Field offset: 0x68
	[Token(Token = "0x40001E3")]
	public static readonly object BoxedDefaultUInt64; //Field offset: 0x70
	[Token(Token = "0x40001E4")]
	public static readonly object BoxedDefaultSingle; //Field offset: 0x78
	[Token(Token = "0x40001E5")]
	public static readonly object BoxedDefaultDouble; //Field offset: 0x80
	[Token(Token = "0x40001E6")]
	public static readonly object BoxedDefaultDecimal; //Field offset: 0x88
	[Token(Token = "0x40001E7")]
	public static readonly object BoxedDefaultDateTime; //Field offset: 0x90
	[Token(Token = "0x40001E8")]
	private static readonly ConstantExpression s_true; //Field offset: 0x98
	[Token(Token = "0x40001E9")]
	private static readonly ConstantExpression s_false; //Field offset: 0xA0
	[Token(Token = "0x40001EA")]
	private static readonly ConstantExpression s_m1; //Field offset: 0xA8
	[Token(Token = "0x40001EB")]
	private static readonly ConstantExpression s_0; //Field offset: 0xB0
	[Token(Token = "0x40001EC")]
	private static readonly ConstantExpression s_1; //Field offset: 0xB8
	[Token(Token = "0x40001ED")]
	private static readonly ConstantExpression s_2; //Field offset: 0xC0
	[Token(Token = "0x40001EE")]
	private static readonly ConstantExpression s_3; //Field offset: 0xC8
	[Token(Token = "0x40001EF")]
	public static readonly DefaultExpression Empty; //Field offset: 0xD0
	[Token(Token = "0x40001F0")]
	public static readonly ConstantExpression Null; //Field offset: 0xD8

	[Address(RVA = "0x226DBE0", Offset = "0x226CFE0", Length = "0x7EE")]
	[Token(Token = "0x6000561")]
	private static Utils() { }

	[Address(RVA = "0x226D9B0", Offset = "0x226CDB0", Length = "0x193")]
	[Token(Token = "0x6000560")]
	public static ConstantExpression Constant(int value) { }

	[Address(RVA = "0x226DB50", Offset = "0x226CF50", Length = "0x88")]
	[Token(Token = "0x600055F")]
	public static ConstantExpression Constant(bool value) { }

}

