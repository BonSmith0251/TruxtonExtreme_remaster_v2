namespace Steamworks;

[Token(Token = "0x2000027")]
public static class SteamUserStats
{

	[Address(RVA = "0x63CDF0", Offset = "0x63C1F0", Length = "0x106")]
	[Token(Token = "0x600047E")]
	public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	[Address(RVA = "0x63CF00", Offset = "0x63C300", Length = "0x1F2")]
	[Token(Token = "0x6000466")]
	public static bool ClearAchievement(string pchName) { }

	[Address(RVA = "0x63D220", Offset = "0x63C620", Length = "0x129")]
	[Token(Token = "0x600047A")]
	public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	[Address(RVA = "0x63D100", Offset = "0x63C500", Length = "0x120")]
	[Token(Token = "0x600047B")]
	public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers) { }

	[Address(RVA = "0x63D350", Offset = "0x63C750", Length = "0x21F")]
	[Token(Token = "0x6000475")]
	public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName) { }

	[Address(RVA = "0x63D570", Offset = "0x63C970", Length = "0x22A")]
	[Token(Token = "0x6000474")]
	public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	[Address(RVA = "0x63E530", Offset = "0x63D930", Length = "0x209")]
	[Token(Token = "0x6000464")]
	public static bool GetAchievement(string pchName, out bool pbAchieved) { }

	[Address(RVA = "0x63D7A0", Offset = "0x63CBA0", Length = "0x1EF")]
	[Token(Token = "0x6000483")]
	public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) { }

	[Address(RVA = "0x63D990", Offset = "0x63CD90", Length = "0x211")]
	[Token(Token = "0x6000467")]
	public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	[Address(RVA = "0x63DBB0", Offset = "0x63CFB0", Length = "0x2CC")]
	[Token(Token = "0x600046A")]
	public static string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	[Address(RVA = "0x63DE80", Offset = "0x63D280", Length = "0x1EC")]
	[Token(Token = "0x6000469")]
	public static int GetAchievementIcon(string pchName) { }

	[Address(RVA = "0x63E070", Offset = "0x63D470", Length = "0xC0")]
	[Token(Token = "0x600046D")]
	public static string GetAchievementName(uint iAchievement) { }

	[Address(RVA = "0x63E330", Offset = "0x63D730", Length = "0x1FD")]
	[Token(Token = "0x6000489")]
	public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress) { }

	[Address(RVA = "0x63E130", Offset = "0x63D530", Length = "0x1FD")]
	[Token(Token = "0x600048A")]
	public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress) { }

	[Address(RVA = "0x63E740", Offset = "0x63DB40", Length = "0x10A")]
	[Token(Token = "0x600047C")]
	public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, Int32[] pDetails, int cDetailsMax) { }

	[Address(RVA = "0x63EC50", Offset = "0x63E050", Length = "0x1EF")]
	[Token(Token = "0x6000486")]
	public static bool GetGlobalStat(string pchStatName, out double pData) { }

	[Address(RVA = "0x63EE40", Offset = "0x63E240", Length = "0x1EF")]
	[Token(Token = "0x6000485")]
	public static bool GetGlobalStat(string pchStatName, out long pData) { }

	[Address(RVA = "0x63EA50", Offset = "0x63DE50", Length = "0x1F4")]
	[Token(Token = "0x6000488")]
	public static int GetGlobalStatHistory(string pchStatName, Double[] pData, uint cubData) { }

	[Address(RVA = "0x63E850", Offset = "0x63DC50", Length = "0x1F4")]
	[Token(Token = "0x6000487")]
	public static int GetGlobalStatHistory(string pchStatName, Int64[] pData, uint cubData) { }

	[Address(RVA = "0x63F030", Offset = "0x63E430", Length = "0xB9")]
	[Token(Token = "0x6000479")]
	public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x63F0F0", Offset = "0x63E4F0", Length = "0xB9")]
	[Token(Token = "0x6000477")]
	public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x63F1B0", Offset = "0x63E5B0", Length = "0xC2")]
	[Token(Token = "0x6000476")]
	public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x63F280", Offset = "0x63E680", Length = "0xB9")]
	[Token(Token = "0x6000478")]
	public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x63F340", Offset = "0x63E740", Length = "0x184")]
	[Token(Token = "0x6000481")]
	public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	[Address(RVA = "0x63F4D0", Offset = "0x63E8D0", Length = "0x191")]
	[Token(Token = "0x6000482")]
	public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	[Address(RVA = "0x63F670", Offset = "0x63EA70", Length = "0xAA")]
	[Token(Token = "0x600046C")]
	public static uint GetNumAchievements() { }

	[Address(RVA = "0x63F720", Offset = "0x63EB20", Length = "0xE7")]
	[Token(Token = "0x600047F")]
	public static SteamAPICall_t GetNumberOfCurrentPlayers() { }

	[Address(RVA = "0x63F810", Offset = "0x63EC10", Length = "0x1EF")]
	[Token(Token = "0x6000460")]
	public static bool GetStat(string pchName, out float pData) { }

	[Address(RVA = "0x63FA00", Offset = "0x63EE00", Length = "0x1EF")]
	[Token(Token = "0x600045F")]
	public static bool GetStat(string pchName, out int pData) { }

	[Address(RVA = "0x63FE10", Offset = "0x63F210", Length = "0x211")]
	[Token(Token = "0x6000471")]
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	[Address(RVA = "0x63FBF0", Offset = "0x63EFF0", Length = "0x21C")]
	[Token(Token = "0x6000472")]
	public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	[Address(RVA = "0x640030", Offset = "0x63F430", Length = "0x1FC")]
	[Token(Token = "0x6000470")]
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	[Address(RVA = "0x640230", Offset = "0x63F630", Length = "0x1FC")]
	[Token(Token = "0x600046F")]
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	[Address(RVA = "0x640430", Offset = "0x63F830", Length = "0x1FD")]
	[Token(Token = "0x600046B")]
	public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) { }

	[Address(RVA = "0x640630", Offset = "0x63FA30", Length = "0xAF")]
	[Token(Token = "0x600045E")]
	public static bool RequestCurrentStats() { }

	[Address(RVA = "0x6406E0", Offset = "0x63FAE0", Length = "0xE7")]
	[Token(Token = "0x6000480")]
	public static SteamAPICall_t RequestGlobalAchievementPercentages() { }

	[Address(RVA = "0x6407D0", Offset = "0x63FBD0", Length = "0xF4")]
	[Token(Token = "0x6000484")]
	public static SteamAPICall_t RequestGlobalStats(int nHistoryDays) { }

	[Address(RVA = "0x6408D0", Offset = "0x63FCD0", Length = "0xF6")]
	[Token(Token = "0x600046E")]
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	[Address(RVA = "0x6409D0", Offset = "0x63FDD0", Length = "0xBE")]
	[Token(Token = "0x6000473")]
	public static bool ResetAllStats(bool bAchievementsToo) { }

	[Address(RVA = "0x640A90", Offset = "0x63FE90", Length = "0x1F2")]
	[Token(Token = "0x6000465")]
	public static bool SetAchievement(string pchName) { }

	[Address(RVA = "0x640E80", Offset = "0x640280", Length = "0x1F6")]
	[Token(Token = "0x6000462")]
	public static bool SetStat(string pchName, float fData) { }

	[Address(RVA = "0x640C90", Offset = "0x640090", Length = "0x1EE")]
	[Token(Token = "0x6000461")]
	public static bool SetStat(string pchName, int nData) { }

	[Address(RVA = "0x641080", Offset = "0x640480", Length = "0xAF")]
	[Token(Token = "0x6000468")]
	public static bool StoreStats() { }

	[Address(RVA = "0x641130", Offset = "0x640530", Length = "0x1FD")]
	[Token(Token = "0x6000463")]
	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) { }

	[Address(RVA = "0x641330", Offset = "0x640730", Length = "0x142")]
	[Token(Token = "0x600047D")]
	public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, Int32[] pScoreDetails, int cScoreDetailsCount) { }

}

