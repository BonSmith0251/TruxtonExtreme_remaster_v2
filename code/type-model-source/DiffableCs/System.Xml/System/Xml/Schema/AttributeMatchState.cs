namespace System.Xml.Schema;

[Token(Token = "0x20001DC")]
internal enum AttributeMatchState : int
{
	AttributeFound = 0,
	AnyIdAttributeFound = 1,
	UndeclaredElementAndAttribute = 2,
	UndeclaredAttribute = 3,
	AnyAttributeLax = 4,
	AnyAttributeSkip = 5,
	ProhibitedAnyAttribute = 6,
	ProhibitedAttribute = 7,
	AttributeNameMismatch = 8,
	ValidateAttributeInvalidCall = 9,
}

