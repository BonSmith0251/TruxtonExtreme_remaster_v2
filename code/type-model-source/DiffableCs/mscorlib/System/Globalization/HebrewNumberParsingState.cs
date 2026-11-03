namespace System.Globalization;

[Token(Token = "0x200054D")]
internal enum HebrewNumberParsingState : int
{
	InvalidHebrewNumber = 0,
	NotHebrewDigit = 1,
	FoundEndOfHebrewNumber = 2,
	ContinueParsing = 3,
}

