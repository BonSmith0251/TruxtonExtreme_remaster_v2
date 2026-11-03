namespace Steamworks;

[Token(Token = "0x200000F")]
public static class SteamGameServerStats
{

	[Address(RVA = "0x5E6130", Offset = "0x5E5530", Length = "0x125")]
	[Token(Token = "0x6000190")]
	public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) { }

	[Address(RVA = "0x5E6260", Offset = "0x5E5660", Length = "0x13D")]
	[Token(Token = "0x600018B")]
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	[Address(RVA = "0x5E63A0", Offset = "0x5E57A0", Length = "0x13D")]
	[Token(Token = "0x6000189")]
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	[Address(RVA = "0x5E64E0", Offset = "0x5E58E0", Length = "0x13D")]
	[Token(Token = "0x600018A")]
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	[Address(RVA = "0x5E6620", Offset = "0x5E5A20", Length = "0x8C")]
	[Token(Token = "0x6000188")]
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	[Address(RVA = "0x5E66B0", Offset = "0x5E5AB0", Length = "0x125")]
	[Token(Token = "0x600018F")]
	public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) { }

	[Address(RVA = "0x5E67E0", Offset = "0x5E5BE0", Length = "0x13D")]
	[Token(Token = "0x600018C")]
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) { }

	[Address(RVA = "0x5E6920", Offset = "0x5E5D20", Length = "0x13E")]
	[Token(Token = "0x600018D")]
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) { }

	[Address(RVA = "0x5E6A60", Offset = "0x5E5E60", Length = "0x8C")]
	[Token(Token = "0x6000191")]
	public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) { }

	[Address(RVA = "0x5E6AF0", Offset = "0x5E5EF0", Length = "0x159")]
	[Token(Token = "0x600018E")]
	public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) { }

}

