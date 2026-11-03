namespace System.Net;

[Token(Token = "0x200022D")]
internal enum FtpLoginState : byte
{
	NotLoggedIn = 0,
	LoggedIn = 1,
	LoggedInButNeedsRelogin = 2,
	ReloginFailed = 3,
}

