namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000290")]
public enum XUserChangeEvent : uint
{
	SignedInAgain = 0,
	SigningOut = 1,
	SignedOut = 2,
	Gamertag = 3,
	GamerPicture = 4,
	Privileges = 5,
}

