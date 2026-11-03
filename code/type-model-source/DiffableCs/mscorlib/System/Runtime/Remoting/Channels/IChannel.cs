namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x2000389")]
public interface IChannel
{

	[Token(Token = "0x17000305")]
	public string ChannelName
	{
		[Token(Token = "0x6001C02")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000306")]
	public int ChannelPriority
	{
		[Token(Token = "0x6001C03")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C02")]
	public string get_ChannelName() { }

	[Token(Token = "0x6001C03")]
	public int get_ChannelPriority() { }

}

