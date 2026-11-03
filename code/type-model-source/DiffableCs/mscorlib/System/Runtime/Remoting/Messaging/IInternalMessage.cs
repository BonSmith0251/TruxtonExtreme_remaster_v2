namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B7")]
internal interface IInternalMessage
{

	[Token(Token = "0x1700034C")]
	public Identity TargetIdentity
	{
		[Token(Token = "0x6001CC9")]
		 get { } //Length: 0
		[Token(Token = "0x6001CCA")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700034D")]
	public string Uri
	{
		[Token(Token = "0x6001CCB")]
		 get { } //Length: 0
		[Token(Token = "0x6001CCC")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001CC9")]
	public Identity get_TargetIdentity() { }

	[Token(Token = "0x6001CCB")]
	public string get_Uri() { }

	[Token(Token = "0x6001CCA")]
	public void set_TargetIdentity(Identity value) { }

	[Token(Token = "0x6001CCC")]
	public void set_Uri(string value) { }

}

