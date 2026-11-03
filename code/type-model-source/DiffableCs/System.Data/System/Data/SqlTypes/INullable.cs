namespace System.Data.SqlTypes;

[Token(Token = "0x20000A7")]
public interface INullable
{

	[Token(Token = "0x17000150")]
	public bool IsNull
	{
		[Token(Token = "0x600089E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600089E")]
	public bool get_IsNull() { }

}

