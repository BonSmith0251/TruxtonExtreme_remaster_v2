namespace Steamworks;

[Token(Token = "0x200014C")]
public enum EMatchMakingServerResponse : int
{
	eServerResponded = 0,
	eServerFailedToRespond = 1,
	eNoServersListedOnMasterServer = 2,
}

