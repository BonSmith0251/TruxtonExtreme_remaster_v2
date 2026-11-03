namespace System.Xml.Schema;

[Token(Token = "0x200024E")]
internal enum ValidatorState : int
{
	None = 0,
	Start = 1,
	TopLevelAttribute = 2,
	TopLevelTextOrWS = 3,
	Element = 4,
	Attribute = 5,
	EndOfAttributes = 6,
	Text = 7,
	Whitespace = 8,
	EndElement = 9,
	SkipToEndElement = 10,
	Finish = 11,
}

