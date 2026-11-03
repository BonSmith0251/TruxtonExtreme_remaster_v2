namespace System.ComponentModel;

[Token(Token = "0x20001A0")]
public interface IChangeTracking
{

	[Token(Token = "0x170001F2")]
	public bool IsChanged
	{
		[Token(Token = "0x6000A28")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000A29")]
	public void AcceptChanges() { }

	[Token(Token = "0x6000A28")]
	public bool get_IsChanged() { }

}

