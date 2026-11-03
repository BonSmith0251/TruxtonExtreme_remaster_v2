namespace Steamworks;

[Token(Token = "0x200014E")]
public enum EServerMode : int
{
	eServerModeInvalid = 0,
	eServerModeNoAuthentication = 1,
	eServerModeAuthentication = 2,
	eServerModeAuthenticationAndSecure = 3,
}

