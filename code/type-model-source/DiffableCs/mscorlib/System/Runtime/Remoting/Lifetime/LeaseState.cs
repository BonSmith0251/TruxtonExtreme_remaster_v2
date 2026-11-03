namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x2000370")]
public enum LeaseState : int
{
	Null = 0,
	Initial = 1,
	Active = 2,
	Renewing = 3,
	Expired = 4,
}

