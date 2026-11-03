namespace UnityEngine.UIElements;

[Token(Token = "0x20001EE")]
public interface IMouseEvent
{

	[Token(Token = "0x17000278")]
	public int button
	{
		[Token(Token = "0x6000DD8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000277")]
	public int clickCount
	{
		[Token(Token = "0x6000DD7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000275")]
	public Vector2 localMousePosition
	{
		[Token(Token = "0x6000DD5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000273")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000DD3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000276")]
	public Vector2 mouseDelta
	{
		[Token(Token = "0x6000DD6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000274")]
	public Vector2 mousePosition
	{
		[Token(Token = "0x6000DD4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000279")]
	public int pressedButtons
	{
		[Token(Token = "0x6000DD9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000DD8")]
	public int get_button() { }

	[Token(Token = "0x6000DD7")]
	public int get_clickCount() { }

	[Token(Token = "0x6000DD5")]
	public Vector2 get_localMousePosition() { }

	[Token(Token = "0x6000DD3")]
	public EventModifiers get_modifiers() { }

	[Token(Token = "0x6000DD6")]
	public Vector2 get_mouseDelta() { }

	[Token(Token = "0x6000DD4")]
	public Vector2 get_mousePosition() { }

	[Token(Token = "0x6000DD9")]
	public int get_pressedButtons() { }

}

