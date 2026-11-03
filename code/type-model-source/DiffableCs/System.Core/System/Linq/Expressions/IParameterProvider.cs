namespace System.Linq.Expressions;

[Token(Token = "0x2000084")]
internal interface IParameterProvider
{

	[Token(Token = "0x17000087")]
	public int ParameterCount
	{
		[Token(Token = "0x60003DA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60003DA")]
	public int get_ParameterCount() { }

	[Token(Token = "0x60003D9")]
	public ParameterExpression GetParameter(int index) { }

}

