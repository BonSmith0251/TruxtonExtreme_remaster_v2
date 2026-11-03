namespace UnityEngine.UIElements;

[Token(Token = "0x200025B")]
public interface IFocusRing
{

	[Token(Token = "0x6001037")]
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Token(Token = "0x6001038")]
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

}

