namespace UnityEngine.UIElements;

[Token(Token = "0x20001E5")]
public interface IKeyboardEvent
{

	[Token(Token = "0x17000265")]
	public char character
	{
		[Token(Token = "0x6000DA3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000266")]
	public KeyCode keyCode
	{
		[Token(Token = "0x6000DA4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000264")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000DA2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000DA3")]
	public char get_character() { }

	[Token(Token = "0x6000DA4")]
	public KeyCode get_keyCode() { }

	[Token(Token = "0x6000DA2")]
	public EventModifiers get_modifiers() { }

}

