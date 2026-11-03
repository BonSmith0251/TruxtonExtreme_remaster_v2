namespace System;

[Token(Token = "0x20000E5")]
internal enum ParseFailureKind : int
{
	None = 0,
	ArgumentNull = 1,
	Format = 2,
	FormatWithParameter = 3,
	FormatWithOriginalDateTime = 4,
	FormatWithFormatSpecifier = 5,
	FormatWithOriginalDateTimeAndParameter = 6,
	FormatBadDateTimeCalendar = 7,
}

