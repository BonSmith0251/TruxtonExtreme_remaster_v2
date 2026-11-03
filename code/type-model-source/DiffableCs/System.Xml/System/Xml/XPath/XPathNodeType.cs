namespace System.Xml.XPath;

[Token(Token = "0x20000EE")]
public enum XPathNodeType : int
{
	Root = 0,
	Element = 1,
	Attribute = 2,
	Namespace = 3,
	Text = 4,
	SignificantWhitespace = 5,
	Whitespace = 6,
	ProcessingInstruction = 7,
	Comment = 8,
	All = 9,
}

