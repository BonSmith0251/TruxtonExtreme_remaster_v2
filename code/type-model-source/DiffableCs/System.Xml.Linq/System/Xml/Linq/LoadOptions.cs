namespace System.Xml.Linq;

[Flags]
[Token(Token = "0x200001A")]
public enum LoadOptions : int
{
	None = 0,
	PreserveWhitespace = 1,
	SetBaseUri = 2,
	SetLineInfo = 4,
}

