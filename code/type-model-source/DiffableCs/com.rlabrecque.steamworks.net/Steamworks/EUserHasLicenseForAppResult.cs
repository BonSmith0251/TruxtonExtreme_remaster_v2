namespace Steamworks;

[Token(Token = "0x2000154")]
public enum EUserHasLicenseForAppResult : int
{
	k_EUserHasLicenseResultHasLicense = 0,
	k_EUserHasLicenseResultDoesNotHaveLicense = 1,
	k_EUserHasLicenseResultNoAuth = 2,
}

