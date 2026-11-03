namespace System.ComponentModel;

[Token(Token = "0x200017D")]
public interface INestedSite : ISite, IServiceProvider
{

	[Token(Token = "0x170001C5")]
	public string FullName
	{
		[Token(Token = "0x600094D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600094D")]
	public string get_FullName() { }

}

