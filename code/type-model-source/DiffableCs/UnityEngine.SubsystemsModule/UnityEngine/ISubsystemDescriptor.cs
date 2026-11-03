namespace UnityEngine;

[Token(Token = "0x2000009")]
public interface ISubsystemDescriptor
{

	[Token(Token = "0x17000004")]
	public string id
	{
		[Token(Token = "0x600000F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600000F")]
	public string get_id() { }

}

