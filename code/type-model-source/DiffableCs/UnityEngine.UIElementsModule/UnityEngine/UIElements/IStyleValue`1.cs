namespace UnityEngine.UIElements;

[Token(Token = "0x200042C")]
public interface IStyleValue
{

	[Token(Token = "0x170008D8")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6002010")]
		 get { } //Length: 0
		[Token(Token = "0x6002011")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170008D7")]
	public T value
	{
		[Token(Token = "0x600200E")]
		 get { } //Length: 0
		[Token(Token = "0x600200F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002010")]
	public StyleKeyword get_keyword() { }

	[Token(Token = "0x600200E")]
	public T get_value() { }

	[Token(Token = "0x6002011")]
	public void set_keyword(StyleKeyword value) { }

	[Token(Token = "0x600200F")]
	public void set_value(T value) { }

}

