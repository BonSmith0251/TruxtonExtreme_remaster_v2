namespace Steamworks;

[Token(Token = "0x2000132")]
public enum EUGCReadAction : int
{
	k_EUGCRead_ContinueReadingUntilFinished = 0,
	k_EUGCRead_ContinueReading = 1,
	k_EUGCRead_Close = 2,
}

