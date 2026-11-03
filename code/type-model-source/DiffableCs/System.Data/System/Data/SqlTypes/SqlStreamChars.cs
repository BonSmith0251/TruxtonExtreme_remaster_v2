namespace System.Data.SqlTypes;

[Token(Token = "0x20000BD")]
internal abstract class SqlStreamChars
{

	[Token(Token = "0x1700017D")]
	public abstract long Length
	{
		[Token(Token = "0x6000A72")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700017E")]
	public abstract long Position
	{
		[Token(Token = "0x6000A73")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000A72")]
	public abstract long get_Length() { }

	[Token(Token = "0x6000A73")]
	public abstract long get_Position() { }

	[Token(Token = "0x6000A74")]
	public abstract int Read(Char[] buffer, int offset, int count) { }

	[Token(Token = "0x6000A75")]
	public abstract long Seek(long offset, SeekOrigin origin) { }

}

