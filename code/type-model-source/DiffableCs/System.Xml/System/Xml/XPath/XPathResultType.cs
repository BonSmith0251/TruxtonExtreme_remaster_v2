namespace System.Xml.XPath;

[Token(Token = "0x20000E9")]
public enum XPathResultType : int
{
	Number = 0,
	String = 1,
	Boolean = 2,
	NodeSet = 3,
	Navigator = 1,
	Any = 5,
	Error = 6,
}

