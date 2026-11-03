namespace System.Xml.Schema;

[Token(Token = "0x2000214")]
internal enum FacetType : int
{
	None = 0,
	Length = 1,
	MinLength = 2,
	MaxLength = 3,
	Pattern = 4,
	Whitespace = 5,
	Enumeration = 6,
	MinExclusive = 7,
	MinInclusive = 8,
	MaxExclusive = 9,
	MaxInclusive = 10,
	TotalDigits = 11,
	FractionDigits = 12,
}

