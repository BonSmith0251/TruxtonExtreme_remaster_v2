namespace Newtonsoft.Json;

[Token(Token = "0x2000016")]
public interface IJsonLineInfo
{

	[Token(Token = "0x17000003")]
	public int LineNumber
	{
		[Token(Token = "0x6000018")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000004")]
	public int LinePosition
	{
		[Token(Token = "0x6000019")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000018")]
	public int get_LineNumber() { }

	[Token(Token = "0x6000019")]
	public int get_LinePosition() { }

	[Token(Token = "0x6000017")]
	public bool HasLineInfo() { }

}

