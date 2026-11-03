namespace System.Xml.Linq;

[Flags]
[Token(Token = "0x200001B")]
public enum SaveOptions : int
{
	None = 0,
	DisableFormatting = 1,
	OmitDuplicateNamespaces = 2,
}

