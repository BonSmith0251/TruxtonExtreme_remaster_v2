namespace System.Security.Principal;

[Token(Token = "0x200033B")]
public enum TokenImpersonationLevel : int
{
	None = 0,
	Anonymous = 1,
	Identification = 2,
	Impersonation = 3,
	Delegation = 4,
}

