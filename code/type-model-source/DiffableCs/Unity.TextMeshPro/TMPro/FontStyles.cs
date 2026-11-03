namespace TMPro;

[Flags]
[Token(Token = "0x200009F")]
public enum FontStyles : int
{
	Normal = 0,
	Bold = 1,
	Italic = 2,
	Underline = 4,
	LowerCase = 8,
	UpperCase = 16,
	SmallCaps = 32,
	Strikethrough = 64,
	Superscript = 128,
	Subscript = 256,
	Highlight = 512,
}

