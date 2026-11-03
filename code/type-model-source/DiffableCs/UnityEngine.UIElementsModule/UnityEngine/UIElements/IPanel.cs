namespace UnityEngine.UIElements;

[Token(Token = "0x20002B7")]
public interface IPanel : IDisposable
{

	[Token(Token = "0x1700038A")]
	public ContextType contextType
	{
		[Token(Token = "0x6001287")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000389")]
	public EventDispatcher dispatcher
	{
		[Token(Token = "0x6001286")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700038B")]
	public FocusController focusController
	{
		[Token(Token = "0x6001288")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700038C")]
	public bool isDirty
	{
		[Token(Token = "0x6001289")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700038D")]
	public float scaledPixelsPerPoint
	{
		[Token(Token = "0x600128A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000388")]
	public VisualElement visualTree
	{
		[Token(Token = "0x6001285")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001287")]
	public ContextType get_contextType() { }

	[Token(Token = "0x6001286")]
	public EventDispatcher get_dispatcher() { }

	[Token(Token = "0x6001288")]
	public FocusController get_focusController() { }

	[Token(Token = "0x6001289")]
	public bool get_isDirty() { }

	[Token(Token = "0x600128A")]
	public float get_scaledPixelsPerPoint() { }

	[Token(Token = "0x6001285")]
	public VisualElement get_visualTree() { }

}

