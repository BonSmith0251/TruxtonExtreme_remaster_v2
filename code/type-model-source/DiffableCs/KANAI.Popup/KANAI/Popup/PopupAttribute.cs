namespace KANAI.Popup;

[Flags]
[Token(Token = "0x2000015")]
public enum PopupAttribute : int
{
	none = 0,
	Normal = 1,
	SkipDark = 2,
	Error = 65536,
}

