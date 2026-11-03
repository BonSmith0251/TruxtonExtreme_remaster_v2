namespace System.Security;

[Token(Token = "0x20002C9")]
public interface IPermission : ISecurityEncodable
{

	[Token(Token = "0x6001779")]
	public void Demand() { }

	[Token(Token = "0x600177A")]
	public bool IsSubsetOf(IPermission target) { }

}

