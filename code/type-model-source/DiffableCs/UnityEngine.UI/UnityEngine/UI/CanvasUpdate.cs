namespace UnityEngine.UI;

[Token(Token = "0x2000008")]
public enum CanvasUpdate : int
{
	Prelayout = 0,
	Layout = 1,
	PostLayout = 2,
	PreRender = 3,
	LatePreRender = 4,
	MaxUpdateValue = 5,
}

