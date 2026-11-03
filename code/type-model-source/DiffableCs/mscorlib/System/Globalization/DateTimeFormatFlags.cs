namespace System.Globalization;

[Flags]
[Token(Token = "0x2000543")]
internal enum DateTimeFormatFlags : int
{
	None = 0,
	UseGenitiveMonth = 1,
	UseLeapYearMonth = 2,
	UseSpacesInMonthNames = 4,
	UseHebrewRule = 8,
	UseSpacesInDayNames = 16,
	UseDigitPrefixInTokens = 32,
	NotInitialized = -1,
}

