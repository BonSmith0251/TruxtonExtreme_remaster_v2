namespace System.Linq.Expressions;

[Token(Token = "0x2000083")]
public interface IArgumentProvider
{

	[Token(Token = "0x17000086")]
	public int ArgumentCount
	{
		[Token(Token = "0x60003D8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60003D8")]
	public int get_ArgumentCount() { }

	[Token(Token = "0x60003D7")]
	public Expression GetArgument(int index) { }

}

