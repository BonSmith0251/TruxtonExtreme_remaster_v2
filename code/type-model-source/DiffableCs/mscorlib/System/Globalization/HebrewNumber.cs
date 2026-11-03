namespace System.Globalization;

[Token(Token = "0x200054E")]
internal class HebrewNumber
{
	[Token(Token = "0x200054F")]
	private enum HebrewToken : short
	{
		Invalid = -1,
		Digit400 = 0,
		Digit200_300 = 1,
		Digit100 = 2,
		Digit10 = 3,
		Digit1 = 4,
		Digit6_7 = 5,
		Digit7 = 6,
		Digit9 = 7,
		SingleQuote = 8,
		DoubleQuote = 9,
	}

	[Token(Token = "0x2000550")]
	private struct HebrewValue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40015C1")]
		internal HebrewToken token; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40015C2")]
		internal short value; //Field offset: 0x2

		[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
		[Token(Token = "0x60026C5")]
		internal HebrewValue(HebrewToken token, short value) { }

	}

	[Token(Token = "0x2000551")]
	public enum HS : sbyte
	{
		_err = -1,
		Start = 0,
		S400 = 1,
		S400_400 = 2,
		S400_X00 = 3,
		S400_X0 = 4,
		X00_DQ = 5,
		S400_X00_X0 = 6,
		X0_DQ = 7,
		X = 8,
		X0 = 9,
		X00 = 10,
		S400_DQ = 11,
		S400_400_DQ = 12,
		S400_400_100 = 13,
		S9 = 14,
		X00_S9 = 15,
		S9_DQ = 16,
		END = 100,
	}

	[Token(Token = "0x40015B2")]
	private static readonly HebrewValue[] s_hebrewValues; //Field offset: 0x0
	[Token(Token = "0x40015B3")]
	private static char s_maxHebrewNumberCh; //Field offset: 0x8
	[Token(Token = "0x40015B4")]
	private static readonly HS[] s_numberPasingState; //Field offset: 0x10

	[Address(RVA = "0x1F77850", Offset = "0x1F76C50", Length = "0x3C0")]
	[Token(Token = "0x60026C4")]
	private static HebrewNumber() { }

	[Address(RVA = "0x1F77330", Offset = "0x1F76730", Length = "0xBD")]
	[Token(Token = "0x60026C3")]
	internal static bool IsDigit(char ch) { }

	[Address(RVA = "0x1F773F0", Offset = "0x1F767F0", Length = "0x1AB")]
	[Token(Token = "0x60026C2")]
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	[Address(RVA = "0x1F775A0", Offset = "0x1F769A0", Length = "0x27C")]
	[Token(Token = "0x60026C1")]
	internal static string ToString(int Number) { }

}

