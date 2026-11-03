namespace System.Xml.Schema;

[Flags]
[Token(Token = "0x2000175")]
internal enum RestrictionFlags : int
{
	Length = 1,
	MinLength = 2,
	MaxLength = 4,
	Pattern = 8,
	Enumeration = 16,
	WhiteSpace = 32,
	MaxInclusive = 64,
	MaxExclusive = 128,
	MinInclusive = 256,
	MinExclusive = 512,
	TotalDigits = 1024,
	FractionDigits = 2048,
}

