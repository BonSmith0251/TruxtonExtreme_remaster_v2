namespace System.Net.Security;

[Token(Token = "0x200031A")]
public enum AuthenticationLevel : int
{
	None = 0,
	MutualAuthRequested = 1,
	MutualAuthRequired = 2,
}

