namespace UnityEngine.Timeline;

[Token(Token = "0x200003A")]
internal interface IInterval
{

	[Token(Token = "0x170000A1")]
	public long intervalEnd
	{
		[Token(Token = "0x6000245")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A0")]
	public long intervalStart
	{
		[Token(Token = "0x6000244")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000245")]
	public long get_intervalEnd() { }

	[Token(Token = "0x6000244")]
	public long get_intervalStart() { }

}

