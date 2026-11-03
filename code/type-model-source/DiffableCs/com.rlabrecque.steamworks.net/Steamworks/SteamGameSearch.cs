namespace Steamworks;

[Token(Token = "0x2000018")]
public static class SteamGameSearch
{

	[Address(RVA = "0x5DD140", Offset = "0x5DC540", Length = "0x44")]
	[Token(Token = "0x60002E3")]
	public static EGameSearchErrorCode_t AcceptGame() { }

	[Address(RVA = "0x5DD190", Offset = "0x5DC590", Length = "0x1A7")]
	[Token(Token = "0x60002E0")]
	public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind) { }

	[Address(RVA = "0x5DD340", Offset = "0x5DC740", Length = "0x44")]
	[Token(Token = "0x60002EB")]
	public static EGameSearchErrorCode_t CancelRequestPlayersForGame() { }

	[Address(RVA = "0x5DD390", Offset = "0x5DC790", Length = "0x44")]
	[Token(Token = "0x60002E4")]
	public static EGameSearchErrorCode_t DeclineGame() { }

	[Address(RVA = "0x5DD430", Offset = "0x5DC830", Length = "0x4E")]
	[Token(Token = "0x60002ED")]
	public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID) { }

	[Address(RVA = "0x5DD3E0", Offset = "0x5DC7E0", Length = "0x44")]
	[Token(Token = "0x60002E6")]
	public static EGameSearchErrorCode_t EndGameSearch() { }

	[Address(RVA = "0x5DD480", Offset = "0x5DC880", Length = "0x4E")]
	[Token(Token = "0x60002EA")]
	public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID) { }

	[Address(RVA = "0x5DD4D0", Offset = "0x5DC8D0", Length = "0x71")]
	[Token(Token = "0x60002E9")]
	public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	[Address(RVA = "0x5DD550", Offset = "0x5DC950", Length = "0x107")]
	[Token(Token = "0x60002E5")]
	public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails) { }

	[Address(RVA = "0x5DD660", Offset = "0x5DCA60", Length = "0x5A")]
	[Token(Token = "0x60002E2")]
	public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax) { }

	[Address(RVA = "0x5DD6C0", Offset = "0x5DCAC0", Length = "0x73")]
	[Token(Token = "0x60002E1")]
	public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	[Address(RVA = "0x5DD740", Offset = "0x5DCB40", Length = "0x124")]
	[Token(Token = "0x60002E8")]
	public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails) { }

	[Address(RVA = "0x5DD870", Offset = "0x5DCC70", Length = "0x1A7")]
	[Token(Token = "0x60002E7")]
	public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue) { }

	[Address(RVA = "0x5DDA20", Offset = "0x5DCE20", Length = "0x74")]
	[Token(Token = "0x60002EC")]
	public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

}

