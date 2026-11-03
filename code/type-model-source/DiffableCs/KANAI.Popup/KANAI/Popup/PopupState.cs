namespace KANAI.Popup;

[Token(Token = "0x2000014")]
public enum PopupState : int
{
	Initialize = 0,
	Appear = 1,
	Active = 2,
	DisappearWait = 3,
	DisappearBySkip = 4,
	Disappear = 5,
	Terminate = 6,
	AnyWhere = 7,
}

