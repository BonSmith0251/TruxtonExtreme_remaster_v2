namespace Steamworks;

[Token(Token = "0x200002A")]
internal static class NativeMethods
{
	[Token(Token = "0x4000006")]
	internal const string NativeLibraryName = "steam_api64"; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64"; //Field offset: 0x0

	[Address(RVA = "0x60E400", Offset = "0x60D800", Length = "0xDD")]
	[Token(Token = "0x600051C")]
	public static bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize) { }

	[Address(RVA = "0x60E4E0", Offset = "0x60D8E0", Length = "0x8A")]
	[Token(Token = "0x6000524")]
	public static bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID) { }

	[Address(RVA = "0x60E570", Offset = "0x60D970", Length = "0x7D")]
	[Token(Token = "0x6000513")]
	public static bool ISteamApps_BIsCybercafe(IntPtr instancePtr) { }

	[Address(RVA = "0x60E5F0", Offset = "0x60D9F0", Length = "0x8A")]
	[Token(Token = "0x6000518")]
	public static bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID) { }

	[Address(RVA = "0x60E680", Offset = "0x60DA80", Length = "0x7D")]
	[Token(Token = "0x6000512")]
	public static bool ISteamApps_BIsLowViolence(IntPtr instancePtr) { }

	[Address(RVA = "0x60E890", Offset = "0x60DC90", Length = "0x7D")]
	[Token(Token = "0x6000511")]
	public static bool ISteamApps_BIsSubscribed(IntPtr instancePtr) { }

	[Address(RVA = "0x60E700", Offset = "0x60DB00", Length = "0x8A")]
	[Token(Token = "0x6000517")]
	public static bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID) { }

	[Address(RVA = "0x60E790", Offset = "0x60DB90", Length = "0x7D")]
	[Token(Token = "0x600052C")]
	public static bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr) { }

	[Address(RVA = "0x60E810", Offset = "0x60DC10", Length = "0x7D")]
	[Token(Token = "0x600051A")]
	public static bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr) { }

	[Address(RVA = "0x60E910", Offset = "0x60DD10", Length = "0x98")]
	[Token(Token = "0x600052D")]
	public static bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	[Address(RVA = "0x60E9B0", Offset = "0x60DDB0", Length = "0x7D")]
	[Token(Token = "0x6000514")]
	public static bool ISteamApps_BIsVACBanned(IntPtr instancePtr) { }

	[Address(RVA = "0x60EA30", Offset = "0x60DE30", Length = "0x78")]
	[Token(Token = "0x6000528")]
	public static int ISteamApps_GetAppBuildId(IntPtr instancePtr) { }

	[Address(RVA = "0x60EAB0", Offset = "0x60DEB0", Length = "0xA0")]
	[Token(Token = "0x6000523")]
	public static uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize) { }

	[Address(RVA = "0x60EB50", Offset = "0x60DF50", Length = "0x78")]
	[Token(Token = "0x6000525")]
	public static ulong ISteamApps_GetAppOwner(IntPtr instancePtr) { }

	[Address(RVA = "0x60EBD0", Offset = "0x60DFD0", Length = "0x78")]
	[Token(Token = "0x6000516")]
	public static IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr) { }

	[Address(RVA = "0x60EC50", Offset = "0x60E050", Length = "0xD6")]
	[Token(Token = "0x6000530")]
	public static bool ISteamApps_GetBetaInfo(IntPtr instancePtr, int iBetaIndex, out uint punFlags, out uint punBuildID, IntPtr pchBetaName, int cchBetaName, IntPtr pchDescription, int cchDescription) { }

	[Address(RVA = "0x60ED30", Offset = "0x60E130", Length = "0x98")]
	[Token(Token = "0x6000520")]
	public static bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize) { }

	[Address(RVA = "0x60EDD0", Offset = "0x60E1D0", Length = "0x78")]
	[Token(Token = "0x6000515")]
	public static IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr) { }

	[Address(RVA = "0x60EE50", Offset = "0x60E250", Length = "0x78")]
	[Token(Token = "0x600051B")]
	public static int ISteamApps_GetDLCCount(IntPtr instancePtr) { }

	[Address(RVA = "0x60EED0", Offset = "0x60E2D0", Length = "0xA5")]
	[Token(Token = "0x6000527")]
	public static bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	[Address(RVA = "0x60EF80", Offset = "0x60E380", Length = "0x85")]
	[Token(Token = "0x6000519")]
	public static uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x60F010", Offset = "0x60E410", Length = "0xD4")]
	[Token(Token = "0x600052A")]
	public static ulong ISteamApps_GetFileDetails(IntPtr instancePtr, UTF8StringHandle pszFileName) { }

	[Address(RVA = "0x60F0F0", Offset = "0x60E4F0", Length = "0xAA")]
	[Token(Token = "0x6000522")]
	public static uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, out DepotId_t[] pvecDepots, uint cMaxDepots) { }

	[Address(RVA = "0x60F1A0", Offset = "0x60E5A0", Length = "0x93")]
	[Token(Token = "0x600052B")]
	public static int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine) { }

	[Address(RVA = "0x60F240", Offset = "0x60E640", Length = "0xD4")]
	[Token(Token = "0x6000526")]
	public static IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x60F320", Offset = "0x60E720", Length = "0x93")]
	[Token(Token = "0x600052F")]
	public static int ISteamApps_GetNumBetas(IntPtr instancePtr, out int pnAvailable, out int pnPrivate) { }

	[Address(RVA = "0x60F3C0", Offset = "0x60E7C0", Length = "0x85")]
	[Token(Token = "0x600051D")]
	public static void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x60F450", Offset = "0x60E850", Length = "0x8C")]
	[Token(Token = "0x6000521")]
	public static bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly) { }

	[Address(RVA = "0x60F4E0", Offset = "0x60E8E0", Length = "0x78")]
	[Token(Token = "0x6000529")]
	public static void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr) { }

	[Address(RVA = "0x60F560", Offset = "0x60E960", Length = "0x85")]
	[Token(Token = "0x600051F")]
	public static void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x60F5F0", Offset = "0x60E9F0", Length = "0xD7")]
	[Token(Token = "0x6000531")]
	public static bool ISteamApps_SetActiveBeta(IntPtr instancePtr, UTF8StringHandle pchBetaName) { }

	[Address(RVA = "0x60F6D0", Offset = "0x60EAD0", Length = "0x8A")]
	[Token(Token = "0x600052E")]
	public static bool ISteamApps_SetDlcContext(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x60F760", Offset = "0x60EB60", Length = "0x85")]
	[Token(Token = "0x600051E")]
	public static void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x60F7F0", Offset = "0x60EBF0", Length = "0x8A")]
	[Token(Token = "0x6000533")]
	public static bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x60F880", Offset = "0x60EC80", Length = "0x7D")]
	[Token(Token = "0x6000548")]
	public static bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr) { }

	[Address(RVA = "0x60F900", Offset = "0x60ED00", Length = "0x85")]
	[Token(Token = "0x6000534")]
	public static int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x60F990", Offset = "0x60ED90", Length = "0x93")]
	[Token(Token = "0x6000535")]
	public static int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	[Address(RVA = "0x60FA30", Offset = "0x60EE30", Length = "0x78")]
	[Token(Token = "0x6000532")]
	public static int ISteamClient_CreateSteamPipe(IntPtr instancePtr) { }

	[Address(RVA = "0x60FAB0", Offset = "0x60EEB0", Length = "0x78")]
	[Token(Token = "0x6000546")]
	public static uint ISteamClient_GetIPCCallCount(IntPtr instancePtr) { }

	[Address(RVA = "0x60FB30", Offset = "0x60EF30", Length = "0xED")]
	[Token(Token = "0x6000541")]
	public static IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x60FC20", Offset = "0x60F020", Length = "0xED")]
	[Token(Token = "0x600054A")]
	public static IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x60FD10", Offset = "0x60F110", Length = "0xED")]
	[Token(Token = "0x600053A")]
	public static IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x60FE00", Offset = "0x60F200", Length = "0xED")]
	[Token(Token = "0x6000545")]
	public static IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x60FFE0", Offset = "0x60F3E0", Length = "0xED")]
	[Token(Token = "0x6000538")]
	public static IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x60FEF0", Offset = "0x60F2F0", Length = "0xED")]
	[Token(Token = "0x6000540")]
	public static IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6100D0", Offset = "0x60F4D0", Length = "0xED")]
	[Token(Token = "0x600053E")]
	public static IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6101C0", Offset = "0x60F5C0", Length = "0xED")]
	[Token(Token = "0x600054E")]
	public static IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6102B0", Offset = "0x60F6B0", Length = "0xED")]
	[Token(Token = "0x6000549")]
	public static IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6103A0", Offset = "0x60F7A0", Length = "0xED")]
	[Token(Token = "0x6000552")]
	public static IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610490", Offset = "0x60F890", Length = "0xED")]
	[Token(Token = "0x600054F")]
	public static IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610670", Offset = "0x60FA70", Length = "0xED")]
	[Token(Token = "0x600053C")]
	public static IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610580", Offset = "0x60F980", Length = "0xED")]
	[Token(Token = "0x600053D")]
	public static IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610850", Offset = "0x60FC50", Length = "0xED")]
	[Token(Token = "0x600054C")]
	public static IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610760", Offset = "0x60FB60", Length = "0xED")]
	[Token(Token = "0x600054D")]
	public static IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610940", Offset = "0x60FD40", Length = "0xED")]
	[Token(Token = "0x6000542")]
	public static IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610A30", Offset = "0x60FE30", Length = "0xED")]
	[Token(Token = "0x6000551")]
	public static IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610B20", Offset = "0x60FF20", Length = "0xED")]
	[Token(Token = "0x6000553")]
	public static IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610C10", Offset = "0x610010", Length = "0xED")]
	[Token(Token = "0x6000554")]
	public static IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610D00", Offset = "0x610100", Length = "0xED")]
	[Token(Token = "0x6000543")]
	public static IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610DF0", Offset = "0x6101F0", Length = "0xED")]
	[Token(Token = "0x6000544")]
	public static IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610EE0", Offset = "0x6102E0", Length = "0xED")]
	[Token(Token = "0x600054B")]
	public static IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6110C0", Offset = "0x6104C0", Length = "0xED")]
	[Token(Token = "0x6000537")]
	public static IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x610FD0", Offset = "0x6103D0", Length = "0xED")]
	[Token(Token = "0x600053F")]
	public static IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x6111B0", Offset = "0x6105B0", Length = "0xDE")]
	[Token(Token = "0x600053B")]
	public static IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x611290", Offset = "0x610690", Length = "0xED")]
	[Token(Token = "0x6000550")]
	public static IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	[Address(RVA = "0x611380", Offset = "0x610780", Length = "0x91")]
	[Token(Token = "0x6000536")]
	public static void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser) { }

	[Address(RVA = "0x611420", Offset = "0x610820", Length = "0x95")]
	[Token(Token = "0x6000539")]
	public static void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort) { }

	[Address(RVA = "0x6114C0", Offset = "0x6108C0", Length = "0x91")]
	[Token(Token = "0x6000547")]
	public static void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	[Address(RVA = "0x6119B0", Offset = "0x610DB0", Length = "0xCB")]
	[Token(Token = "0x6000571")]
	public static void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, UTF8StringHandle pchDialog) { }

	[Address(RVA = "0x611630", Offset = "0x610A30", Length = "0x87")]
	[Token(Token = "0x6000576")]
	public static void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x611560", Offset = "0x610960", Length = "0xCB")]
	[Token(Token = "0x60005A0")]
	public static void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, UTF8StringHandle pchConnectString) { }

	[Address(RVA = "0x6116C0", Offset = "0x610AC0", Length = "0x87")]
	[Token(Token = "0x600059E")]
	public static void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x611750", Offset = "0x610B50", Length = "0x91")]
	[Token(Token = "0x6000574")]
	public static void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	[Address(RVA = "0x6117F0", Offset = "0x610BF0", Length = "0xD7")]
	[Token(Token = "0x6000572")]
	public static void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, UTF8StringHandle pchDialog, CSteamID steamID) { }

	[Address(RVA = "0x6118D0", Offset = "0x610CD0", Length = "0xD7")]
	[Token(Token = "0x6000573")]
	public static void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode) { }

	[Address(RVA = "0x611A80", Offset = "0x610E80", Length = "0x98")]
	[Token(Token = "0x60005A2")]
	public static bool ISteamFriends_BHasEquippedProfileItem(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType) { }

	[Address(RVA = "0x611B20", Offset = "0x610F20", Length = "0x78")]
	[Token(Token = "0x6000581")]
	public static void ISteamFriends_ClearRichPresence(IntPtr instancePtr) { }

	[Address(RVA = "0x611BA0", Offset = "0x610FA0", Length = "0x8C")]
	[Token(Token = "0x6000594")]
	public static bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	[Address(RVA = "0x611C30", Offset = "0x611030", Length = "0x9D")]
	[Token(Token = "0x600056C")]
	public static ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, out CSteamID[] psteamIDClans, int cClansToRequest) { }

	[Address(RVA = "0x611CD0", Offset = "0x6110D0", Length = "0x85")]
	[Token(Token = "0x600059A")]
	public static ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex) { }

	[Address(RVA = "0x611D60", Offset = "0x611160", Length = "0x93")]
	[Token(Token = "0x600058E")]
	public static ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser) { }

	[Address(RVA = "0x611E00", Offset = "0x611200", Length = "0xB7")]
	[Token(Token = "0x600056B")]
	public static bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	[Address(RVA = "0x611EC0", Offset = "0x6112C0", Length = "0x85")]
	[Token(Token = "0x6000568")]
	public static ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan) { }

	[Address(RVA = "0x611F50", Offset = "0x611350", Length = "0x87")]
	[Token(Token = "0x600058D")]
	public static int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x611FE0", Offset = "0x6113E0", Length = "0xC8")]
	[Token(Token = "0x6000590")]
	public static int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	[Address(RVA = "0x6120B0", Offset = "0x6114B0", Length = "0x78")]
	[Token(Token = "0x6000567")]
	public static int ISteamFriends_GetClanCount(IntPtr instancePtr) { }

	[Address(RVA = "0x612130", Offset = "0x611530", Length = "0x87")]
	[Token(Token = "0x6000569")]
	public static IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x6121C0", Offset = "0x6115C0", Length = "0x93")]
	[Token(Token = "0x600057E")]
	public static ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer) { }

	[Address(RVA = "0x612260", Offset = "0x611660", Length = "0x87")]
	[Token(Token = "0x600057D")]
	public static int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x6122F0", Offset = "0x6116F0", Length = "0x87")]
	[Token(Token = "0x600057C")]
	public static ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x612380", Offset = "0x611780", Length = "0x87")]
	[Token(Token = "0x600056A")]
	public static IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x612490", Offset = "0x611890", Length = "0x85")]
	[Token(Token = "0x6000588")]
	public static ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend) { }

	[Address(RVA = "0x612410", Offset = "0x611810", Length = "0x78")]
	[Token(Token = "0x6000587")]
	public static int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr) { }

	[Address(RVA = "0x612520", Offset = "0x611920", Length = "0x87")]
	[Token(Token = "0x6000598")]
	public static ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x6125B0", Offset = "0x6119B0", Length = "0x91")]
	[Token(Token = "0x6000559")]
	public static ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x612650", Offset = "0x611A50", Length = "0x87")]
	[Token(Token = "0x600058A")]
	public static uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x6126E0", Offset = "0x611AE0", Length = "0x87")]
	[Token(Token = "0x6000589")]
	public static int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x612800", Offset = "0x611C00", Length = "0x85")]
	[Token(Token = "0x6000558")]
	public static int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x612770", Offset = "0x611B70", Length = "0x87")]
	[Token(Token = "0x600056D")]
	public static int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource) { }

	[Address(RVA = "0x612890", Offset = "0x611C90", Length = "0x93")]
	[Token(Token = "0x600056E")]
	public static ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend) { }

	[Address(RVA = "0x612930", Offset = "0x611D30", Length = "0x98")]
	[Token(Token = "0x600055D")]
	public static bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	[Address(RVA = "0x6129D0", Offset = "0x611DD0", Length = "0xBD")]
	[Token(Token = "0x6000597")]
	public static int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType) { }

	[Address(RVA = "0x612B30", Offset = "0x611F30", Length = "0x87")]
	[Token(Token = "0x600055C")]
	public static IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x612A90", Offset = "0x611E90", Length = "0x93")]
	[Token(Token = "0x600055E")]
	public static IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName) { }

	[Address(RVA = "0x612BC0", Offset = "0x611FC0", Length = "0x87")]
	[Token(Token = "0x600055B")]
	public static EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x612C50", Offset = "0x612050", Length = "0x87")]
	[Token(Token = "0x600055A")]
	public static EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x612E10", Offset = "0x612210", Length = "0xE0")]
	[Token(Token = "0x6000582")]
	public static IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x612CE0", Offset = "0x6120E0", Length = "0x93")]
	[Token(Token = "0x6000584")]
	public static IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey) { }

	[Address(RVA = "0x612D80", Offset = "0x612180", Length = "0x87")]
	[Token(Token = "0x6000583")]
	public static int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x612F90", Offset = "0x612390", Length = "0x78")]
	[Token(Token = "0x6000561")]
	public static int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr) { }

	[Address(RVA = "0x613010", Offset = "0x612410", Length = "0x85")]
	[Token(Token = "0x6000562")]
	public static short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG) { }

	[Address(RVA = "0x6130A0", Offset = "0x6124A0", Length = "0x87")]
	[Token(Token = "0x6000564")]
	public static int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	[Address(RVA = "0x613130", Offset = "0x612530", Length = "0xAC")]
	[Token(Token = "0x6000565")]
	public static void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, out CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	[Address(RVA = "0x6131E0", Offset = "0x6125E0", Length = "0x87")]
	[Token(Token = "0x6000563")]
	public static IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	[Address(RVA = "0x612F00", Offset = "0x612300", Length = "0x87")]
	[Token(Token = "0x600055F")]
	public static int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x613270", Offset = "0x612670", Length = "0x87")]
	[Token(Token = "0x6000579")]
	public static int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x613300", Offset = "0x612700", Length = "0x87")]
	[Token(Token = "0x6000578")]
	public static int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x613390", Offset = "0x612790", Length = "0x78")]
	[Token(Token = "0x600059D")]
	public static int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr) { }

	[Address(RVA = "0x613410", Offset = "0x612810", Length = "0x78")]
	[Token(Token = "0x6000555")]
	public static IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr) { }

	[Address(RVA = "0x613490", Offset = "0x612890", Length = "0x78")]
	[Token(Token = "0x6000557")]
	public static EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr) { }

	[Address(RVA = "0x613510", Offset = "0x612910", Length = "0x87")]
	[Token(Token = "0x6000560")]
	public static IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer) { }

	[Address(RVA = "0x6135A0", Offset = "0x6129A0", Length = "0xA2")]
	[Token(Token = "0x60005A3")]
	public static IntPtr ISteamFriends_GetProfileItemPropertyString(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	[Address(RVA = "0x613650", Offset = "0x612A50", Length = "0xA2")]
	[Token(Token = "0x60005A4")]
	public static uint ISteamFriends_GetProfileItemPropertyUint(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	[Address(RVA = "0x613700", Offset = "0x612B00", Length = "0x87")]
	[Token(Token = "0x6000577")]
	public static int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x613790", Offset = "0x612B90", Length = "0x78")]
	[Token(Token = "0x600057F")]
	public static uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr) { }

	[Address(RVA = "0x613810", Offset = "0x612C10", Length = "0x98")]
	[Token(Token = "0x6000566")]
	public static bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x6138B0", Offset = "0x612CB0", Length = "0xE2")]
	[Token(Token = "0x6000586")]
	public static bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchConnectString) { }

	[Address(RVA = "0x6139A0", Offset = "0x612DA0", Length = "0x98")]
	[Token(Token = "0x6000591")]
	public static bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	[Address(RVA = "0x613A40", Offset = "0x612E40", Length = "0x8C")]
	[Token(Token = "0x6000592")]
	public static bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	[Address(RVA = "0x613AD0", Offset = "0x612ED0", Length = "0x8C")]
	[Token(Token = "0x600059C")]
	public static bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x613B60", Offset = "0x612F60", Length = "0x8C")]
	[Token(Token = "0x600059B")]
	public static bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x613BF0", Offset = "0x612FF0", Length = "0x87")]
	[Token(Token = "0x6000599")]
	public static ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x613C80", Offset = "0x613080", Length = "0x98")]
	[Token(Token = "0x600056F")]
	public static bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource) { }

	[Address(RVA = "0x613D20", Offset = "0x613120", Length = "0x87")]
	[Token(Token = "0x600058B")]
	public static ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x613DB0", Offset = "0x6131B0", Length = "0x8C")]
	[Token(Token = "0x600058C")]
	public static bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x613E40", Offset = "0x613240", Length = "0x8C")]
	[Token(Token = "0x6000593")]
	public static bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	[Address(RVA = "0x613ED0", Offset = "0x6132D0", Length = "0xD7")]
	[Token(Token = "0x600059F")]
	public static bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, UTF8StringHandle pchProtocol) { }

	[Address(RVA = "0x613FB0", Offset = "0x6133B0", Length = "0xE2")]
	[Token(Token = "0x6000596")]
	public static bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchMsgToSend) { }

	[Address(RVA = "0x6140A0", Offset = "0x6134A0", Length = "0x87")]
	[Token(Token = "0x600057B")]
	public static ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x614130", Offset = "0x613530", Length = "0x87")]
	[Token(Token = "0x60005A1")]
	public static ulong ISteamFriends_RequestEquippedProfileItems(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x6141C0", Offset = "0x6135C0", Length = "0x87")]
	[Token(Token = "0x6000585")]
	public static void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x614250", Offset = "0x613650", Length = "0x9A")]
	[Token(Token = "0x600057A")]
	public static bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly) { }

	[Address(RVA = "0x6142F0", Offset = "0x6136F0", Length = "0xE2")]
	[Token(Token = "0x600058F")]
	public static bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, UTF8StringHandle pchText) { }

	[Address(RVA = "0x6143E0", Offset = "0x6137E0", Length = "0x95")]
	[Token(Token = "0x6000570")]
	public static void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking) { }

	[Address(RVA = "0x614480", Offset = "0x613880", Length = "0x8C")]
	[Token(Token = "0x6000595")]
	public static bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled) { }

	[Address(RVA = "0x614510", Offset = "0x613910", Length = "0xD4")]
	[Token(Token = "0x6000556")]
	public static ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, UTF8StringHandle pchPersonaName) { }

	[Address(RVA = "0x6145F0", Offset = "0x6139F0", Length = "0x87")]
	[Token(Token = "0x6000575")]
	public static void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith) { }

	[Address(RVA = "0x614680", Offset = "0x613A80", Length = "0x13D")]
	[Token(Token = "0x6000580")]
	public static bool ISteamFriends_SetRichPresence(IntPtr instancePtr, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x6147C0", Offset = "0x613BC0", Length = "0x78")]
	[Token(Token = "0x60006A6")]
	public static EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr) { }

	[Address(RVA = "0x614840", Offset = "0x613C40", Length = "0x134")]
	[Token(Token = "0x60006A3")]
	public static EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, UTF8StringHandle pchKeyToFind, UTF8StringHandle pchValuesToFind) { }

	[Address(RVA = "0x614980", Offset = "0x613D80", Length = "0x78")]
	[Token(Token = "0x60006AE")]
	public static EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr) { }

	[Address(RVA = "0x614A00", Offset = "0x613E00", Length = "0x78")]
	[Token(Token = "0x60006A7")]
	public static EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr) { }

	[Address(RVA = "0x614B00", Offset = "0x613F00", Length = "0x87")]
	[Token(Token = "0x60006B0")]
	public static EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID) { }

	[Address(RVA = "0x614A80", Offset = "0x613E80", Length = "0x78")]
	[Token(Token = "0x60006A9")]
	public static EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr) { }

	[Address(RVA = "0x614B90", Offset = "0x613F90", Length = "0x87")]
	[Token(Token = "0x60006AD")]
	public static EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID) { }

	[Address(RVA = "0x614C20", Offset = "0x614020", Length = "0xA0")]
	[Token(Token = "0x60006AC")]
	public static EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	[Address(RVA = "0x614CC0", Offset = "0x6140C0", Length = "0xA2")]
	[Token(Token = "0x60006A8")]
	public static EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails) { }

	[Address(RVA = "0x614D70", Offset = "0x614170", Length = "0x91")]
	[Token(Token = "0x60006A5")]
	public static EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax) { }

	[Address(RVA = "0x614E10", Offset = "0x614210", Length = "0xA2")]
	[Token(Token = "0x60006A4")]
	public static EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	[Address(RVA = "0x614EC0", Offset = "0x6142C0", Length = "0xDE")]
	[Token(Token = "0x60006AB")]
	public static EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, UTF8StringHandle pchConnectionDetails, int cubConnectionDetails) { }

	[Address(RVA = "0x614FA0", Offset = "0x6143A0", Length = "0x134")]
	[Token(Token = "0x60006AA")]
	public static EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x6150E0", Offset = "0x6144E0", Length = "0xA2")]
	[Token(Token = "0x60006AF")]
	public static EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

	[Address(RVA = "0x615AC0", Offset = "0x614EC0", Length = "0x87")]
	[Token(Token = "0x60005C8")]
	public static ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan) { }

	[Address(RVA = "0x615D50", Offset = "0x615150", Length = "0xAC")]
	[Token(Token = "0x60005BE")]
	public static EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	[Address(RVA = "0x615B50", Offset = "0x614F50", Length = "0x7D")]
	[Token(Token = "0x60005AC")]
	public static bool ISteamGameServer_BLoggedOn(IntPtr instancePtr) { }

	[Address(RVA = "0x615BD0", Offset = "0x614FD0", Length = "0x7D")]
	[Token(Token = "0x60005AD")]
	public static bool ISteamGameServer_BSecure(IntPtr instancePtr) { }

	[Address(RVA = "0x615C50", Offset = "0x615050", Length = "0xF1")]
	[Token(Token = "0x60005CD")]
	public static bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchPlayerName, uint uScore) { }

	[Address(RVA = "0x615E00", Offset = "0x615200", Length = "0x85")]
	[Token(Token = "0x60005C0")]
	public static void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	[Address(RVA = "0x615E90", Offset = "0x615290", Length = "0x78")]
	[Token(Token = "0x60005B7")]
	public static void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr) { }

	[Address(RVA = "0x615F10", Offset = "0x615310", Length = "0x87")]
	[Token(Token = "0x60005C9")]
	public static ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer) { }

	[Address(RVA = "0x615FA0", Offset = "0x6153A0", Length = "0x78")]
	[Token(Token = "0x60005CB")]
	public static ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr) { }

	[Address(RVA = "0x616020", Offset = "0x615420", Length = "0x87")]
	[Token(Token = "0x60005BF")]
	public static void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x6160B0", Offset = "0x6154B0", Length = "0xBC")]
	[Token(Token = "0x60005BD")]
	public static uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid) { }

	[Address(RVA = "0x616170", Offset = "0x615570", Length = "0x78")]
	[Token(Token = "0x60005C3")]
	public static void ISteamGameServer_GetGameplayStats(IntPtr instancePtr) { }

	[Address(RVA = "0x6161F0", Offset = "0x6155F0", Length = "0xBC")]
	[Token(Token = "0x60005C7")]
	public static int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, Byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	[Address(RVA = "0x6162B0", Offset = "0x6156B0", Length = "0x9B")]
	[Token(Token = "0x60005C5")]
	public static SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr) { }

	[Address(RVA = "0x616350", Offset = "0x615750", Length = "0x78")]
	[Token(Token = "0x60005C4")]
	public static ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr) { }

	[Address(RVA = "0x6163D0", Offset = "0x6157D0", Length = "0x78")]
	[Token(Token = "0x60005AE")]
	public static ulong ISteamGameServer_GetSteamID(IntPtr instancePtr) { }

	[Address(RVA = "0x616450", Offset = "0x615850", Length = "0xC1")]
	[Token(Token = "0x60005C6")]
	public static bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, Byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	[Address(RVA = "0x616520", Offset = "0x615920", Length = "0x78")]
	[Token(Token = "0x60005AB")]
	public static void ISteamGameServer_LogOff(IntPtr instancePtr) { }

	[Address(RVA = "0x616620", Offset = "0x615A20", Length = "0xCB")]
	[Token(Token = "0x60005A9")]
	public static void ISteamGameServer_LogOn(IntPtr instancePtr, UTF8StringHandle pszToken) { }

	[Address(RVA = "0x6165A0", Offset = "0x6159A0", Length = "0x78")]
	[Token(Token = "0x60005AA")]
	public static void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr) { }

	[Address(RVA = "0x6166F0", Offset = "0x615AF0", Length = "0x98")]
	[Token(Token = "0x60005C2")]
	public static bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup) { }

	[Address(RVA = "0x616790", Offset = "0x615B90", Length = "0xBF")]
	[Token(Token = "0x60005CA")]
	public static bool ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED(IntPtr instancePtr, uint unIPClient, Byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	[Address(RVA = "0x616850", Offset = "0x615C50", Length = "0x87")]
	[Token(Token = "0x60005CC")]
	public static void ISteamGameServer_SendUserDisconnect_DEPRECATED(IntPtr instancePtr, CSteamID steamIDUser) { }

	[Address(RVA = "0x6168E0", Offset = "0x615CE0", Length = "0x87")]
	[Token(Token = "0x60005BC")]
	public static void ISteamGameServer_SetAdvertiseServerActive(IntPtr instancePtr, bool bActive) { }

	[Address(RVA = "0x616970", Offset = "0x615D70", Length = "0x85")]
	[Token(Token = "0x60005B1")]
	public static void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers) { }

	[Address(RVA = "0x616A00", Offset = "0x615E00", Length = "0x87")]
	[Token(Token = "0x60005A8")]
	public static void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated) { }

	[Address(RVA = "0x616A90", Offset = "0x615E90", Length = "0xCB")]
	[Token(Token = "0x60005BA")]
	public static void ISteamGameServer_SetGameData(IntPtr instancePtr, UTF8StringHandle pchGameData) { }

	[Address(RVA = "0x616B60", Offset = "0x615F60", Length = "0xCB")]
	[Token(Token = "0x60005A6")]
	public static void ISteamGameServer_SetGameDescription(IntPtr instancePtr, UTF8StringHandle pszGameDescription) { }

	[Address(RVA = "0x616C30", Offset = "0x616030", Length = "0xCB")]
	[Token(Token = "0x60005B9")]
	public static void ISteamGameServer_SetGameTags(IntPtr instancePtr, UTF8StringHandle pchGameTags) { }

	[Address(RVA = "0x616D00", Offset = "0x616100", Length = "0x12D")]
	[Token(Token = "0x60005B8")]
	public static void ISteamGameServer_SetKeyValue(IntPtr instancePtr, UTF8StringHandle pKey, UTF8StringHandle pValue) { }

	[Address(RVA = "0x616E30", Offset = "0x616230", Length = "0xCB")]
	[Token(Token = "0x60005B3")]
	public static void ISteamGameServer_SetMapName(IntPtr instancePtr, UTF8StringHandle pszMapName) { }

	[Address(RVA = "0x616F00", Offset = "0x616300", Length = "0x85")]
	[Token(Token = "0x60005B0")]
	public static void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax) { }

	[Address(RVA = "0x616F90", Offset = "0x616390", Length = "0xCB")]
	[Token(Token = "0x60005A7")]
	public static void ISteamGameServer_SetModDir(IntPtr instancePtr, UTF8StringHandle pszModDir) { }

	[Address(RVA = "0x617060", Offset = "0x616460", Length = "0x87")]
	[Token(Token = "0x60005B4")]
	public static void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected) { }

	[Address(RVA = "0x6170F0", Offset = "0x6164F0", Length = "0xCB")]
	[Token(Token = "0x60005A5")]
	public static void ISteamGameServer_SetProduct(IntPtr instancePtr, UTF8StringHandle pszProduct) { }

	[Address(RVA = "0x6171C0", Offset = "0x6165C0", Length = "0xCB")]
	[Token(Token = "0x60005BB")]
	public static void ISteamGameServer_SetRegion(IntPtr instancePtr, UTF8StringHandle pszRegion) { }

	[Address(RVA = "0x617290", Offset = "0x616690", Length = "0xCB")]
	[Token(Token = "0x60005B2")]
	public static void ISteamGameServer_SetServerName(IntPtr instancePtr, UTF8StringHandle pszServerName) { }

	[Address(RVA = "0x617360", Offset = "0x616760", Length = "0x87")]
	[Token(Token = "0x60005B5")]
	public static void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort) { }

	[Address(RVA = "0x6173F0", Offset = "0x6167F0", Length = "0xCB")]
	[Token(Token = "0x60005B6")]
	public static void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, UTF8StringHandle pszSpectatorServerName) { }

	[Address(RVA = "0x6174C0", Offset = "0x6168C0", Length = "0x93")]
	[Token(Token = "0x60005C1")]
	public static EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	[Address(RVA = "0x617560", Offset = "0x616960", Length = "0x7D")]
	[Token(Token = "0x60005AF")]
	public static bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr) { }

	[Address(RVA = "0x615190", Offset = "0x614590", Length = "0xE2")]
	[Token(Token = "0x60005D6")]
	public static bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName) { }

	[Address(RVA = "0x615280", Offset = "0x614680", Length = "0x111")]
	[Token(Token = "0x60005D1")]
	public static bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved) { }

	[Address(RVA = "0x6153A0", Offset = "0x6147A0", Length = "0xF1")]
	[Token(Token = "0x60005D0")]
	public static bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out float pData) { }

	[Address(RVA = "0x6154A0", Offset = "0x6148A0", Length = "0xF1")]
	[Token(Token = "0x60005CF")]
	public static bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out int pData) { }

	[Address(RVA = "0x6155A0", Offset = "0x6149A0", Length = "0x87")]
	[Token(Token = "0x60005CE")]
	public static ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	[Address(RVA = "0x615630", Offset = "0x614A30", Length = "0xE2")]
	[Token(Token = "0x60005D5")]
	public static bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName) { }

	[Address(RVA = "0x615720", Offset = "0x614B20", Length = "0xFB")]
	[Token(Token = "0x60005D3")]
	public static bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, float fData) { }

	[Address(RVA = "0x615820", Offset = "0x614C20", Length = "0xF1")]
	[Token(Token = "0x60005D2")]
	public static bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, int nData) { }

	[Address(RVA = "0x615920", Offset = "0x614D20", Length = "0x87")]
	[Token(Token = "0x60005D7")]
	public static ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	[Address(RVA = "0x6159B0", Offset = "0x614DB0", Length = "0x10C")]
	[Token(Token = "0x60005D4")]
	public static bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	[Address(RVA = "0x6175E0", Offset = "0x6169E0", Length = "0x141")]
	[Token(Token = "0x60005E2")]
	public static void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x617730", Offset = "0x616B30", Length = "0x93")]
	[Token(Token = "0x60005FA")]
	public static void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	[Address(RVA = "0x6177D0", Offset = "0x616BD0", Length = "0x85")]
	[Token(Token = "0x60005F0")]
	public static void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x617860", Offset = "0x616C60", Length = "0x136")]
	[Token(Token = "0x60005DA")]
	public static ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, UTF8StringHandle pchUserAgent, UTF8StringHandle pchUserCSS) { }

	[Address(RVA = "0x6179A0", Offset = "0x616DA0", Length = "0xD5")]
	[Token(Token = "0x60005E3")]
	public static void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchScript) { }

	[Address(RVA = "0x617A80", Offset = "0x616E80", Length = "0x91")]
	[Token(Token = "0x60005FC")]
	public static void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }

	[Address(RVA = "0x617B20", Offset = "0x616F20", Length = "0xFE")]
	[Token(Token = "0x60005F2")]
	public static void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	[Address(RVA = "0x617C20", Offset = "0x617020", Length = "0xA0")]
	[Token(Token = "0x60005F4")]
	public static void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	[Address(RVA = "0x617CC0", Offset = "0x6170C0", Length = "0x85")]
	[Token(Token = "0x60005E0")]
	public static void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x617D50", Offset = "0x617150", Length = "0x85")]
	[Token(Token = "0x60005E1")]
	public static void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x617DE0", Offset = "0x6171E0", Length = "0x7D")]
	[Token(Token = "0x60005D8")]
	public static bool ISteamHTMLSurface_Init(IntPtr instancePtr) { }

	[Address(RVA = "0x617E60", Offset = "0x617260", Length = "0x93")]
	[Token(Token = "0x60005FB")]
	public static void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult) { }

	[Address(RVA = "0x617F00", Offset = "0x617300", Length = "0xA0")]
	[Token(Token = "0x60005EB")]
	public static void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	[Address(RVA = "0x617FA0", Offset = "0x6173A0", Length = "0xAF")]
	[Token(Token = "0x60005E9")]
	public static void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) { }

	[Address(RVA = "0x618050", Offset = "0x617450", Length = "0xA0")]
	[Token(Token = "0x60005EA")]
	public static void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	[Address(RVA = "0x6180F0", Offset = "0x6174F0", Length = "0x141")]
	[Token(Token = "0x60005DC")]
	public static void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchURL, UTF8StringHandle pchPostData) { }

	[Address(RVA = "0x618240", Offset = "0x617640", Length = "0x91")]
	[Token(Token = "0x60005E6")]
	public static void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x6182E0", Offset = "0x6176E0", Length = "0x91")]
	[Token(Token = "0x60005E5")]
	public static void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x618380", Offset = "0x617780", Length = "0xA0")]
	[Token(Token = "0x60005E7")]
	public static void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	[Address(RVA = "0x618420", Offset = "0x617820", Length = "0x91")]
	[Token(Token = "0x60005E4")]
	public static void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x6184C0", Offset = "0x6178C0", Length = "0x91")]
	[Token(Token = "0x60005E8")]
	public static void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta) { }

	[Address(RVA = "0x618560", Offset = "0x617960", Length = "0x85")]
	[Token(Token = "0x60005F9")]
	public static void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x6185F0", Offset = "0x6179F0", Length = "0x85")]
	[Token(Token = "0x60005F1")]
	public static void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x618680", Offset = "0x617A80", Length = "0x85")]
	[Token(Token = "0x60005DF")]
	public static void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x618710", Offset = "0x617B10", Length = "0x85")]
	[Token(Token = "0x60005DB")]
	public static void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x6187A0", Offset = "0x617BA0", Length = "0x93")]
	[Token(Token = "0x60005F7")]
	public static void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	[Address(RVA = "0x618840", Offset = "0x617C40", Length = "0x23A")]
	[Token(Token = "0x60005F5")]
	public static void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, UTF8StringHandle pchHostname, UTF8StringHandle pchKey, UTF8StringHandle pchValue, UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly) { }

	[Address(RVA = "0x618A80", Offset = "0x617E80", Length = "0x95")]
	[Token(Token = "0x60005F8")]
	public static void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	[Address(RVA = "0x618B20", Offset = "0x617F20", Length = "0x91")]
	[Token(Token = "0x60005EC")]
	public static void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	[Address(RVA = "0x618BC0", Offset = "0x617FC0", Length = "0x93")]
	[Token(Token = "0x60005EE")]
	public static void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	[Address(RVA = "0x618C60", Offset = "0x618060", Length = "0xAE")]
	[Token(Token = "0x60005F6")]
	public static void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	[Address(RVA = "0x618D10", Offset = "0x618110", Length = "0xA0")]
	[Token(Token = "0x60005DD")]
	public static void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	[Address(RVA = "0x618DB0", Offset = "0x6181B0", Length = "0x91")]
	[Token(Token = "0x60005ED")]
	public static void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	[Address(RVA = "0x618E50", Offset = "0x618250", Length = "0x7D")]
	[Token(Token = "0x60005D9")]
	public static bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr) { }

	[Address(RVA = "0x618ED0", Offset = "0x6182D0", Length = "0x85")]
	[Token(Token = "0x60005F3")]
	public static void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x618F60", Offset = "0x618360", Length = "0x85")]
	[Token(Token = "0x60005DE")]
	public static void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x618FF0", Offset = "0x6183F0", Length = "0x85")]
	[Token(Token = "0x60005EF")]
	public static void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x619080", Offset = "0x618480", Length = "0x87")]
	[Token(Token = "0x600060E")]
	public static uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify) { }

	[Address(RVA = "0x619110", Offset = "0x618510", Length = "0xDC")]
	[Token(Token = "0x60005FD")]
	public static uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, UTF8StringHandle pchAbsoluteURL) { }

	[Address(RVA = "0x6191F0", Offset = "0x6185F0", Length = "0x8A")]
	[Token(Token = "0x6000604")]
	public static bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x619280", Offset = "0x618680", Length = "0x96")]
	[Token(Token = "0x600060C")]
	public static bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut) { }

	[Address(RVA = "0x619320", Offset = "0x618720", Length = "0xAA")]
	[Token(Token = "0x6000615")]
	public static bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	[Address(RVA = "0x6193D0", Offset = "0x6187D0", Length = "0xAF")]
	[Token(Token = "0x6000609")]
	public static bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x619480", Offset = "0x618880", Length = "0x96")]
	[Token(Token = "0x6000608")]
	public static bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize) { }

	[Address(RVA = "0x619520", Offset = "0x618920", Length = "0xEF")]
	[Token(Token = "0x6000606")]
	public static bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize) { }

	[Address(RVA = "0x619610", Offset = "0x618A10", Length = "0x111")]
	[Token(Token = "0x6000607")]
	public static bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, Byte[] pHeaderValueBuffer, uint unBufferSize) { }

	[Address(RVA = "0x619730", Offset = "0x618B30", Length = "0xBD")]
	[Token(Token = "0x600060A")]
	public static bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	[Address(RVA = "0x6197F0", Offset = "0x618BF0", Length = "0x8A")]
	[Token(Token = "0x6000605")]
	public static bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x619880", Offset = "0x618C80", Length = "0x8A")]
	[Token(Token = "0x600060F")]
	public static bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x619910", Offset = "0x618D10", Length = "0x8A")]
	[Token(Token = "0x600060B")]
	public static bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	[Address(RVA = "0x619A40", Offset = "0x618E40", Length = "0x96")]
	[Token(Token = "0x6000602")]
	public static bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x6199A0", Offset = "0x618DA0", Length = "0x96")]
	[Token(Token = "0x6000603")]
	public static bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	[Address(RVA = "0x619AE0", Offset = "0x618EE0", Length = "0x1BB")]
	[Token(Token = "0x6000610")]
	public static bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, UTF8StringHandle pchHost, UTF8StringHandle pchUrl, UTF8StringHandle pchCookie) { }

	[Address(RVA = "0x619CA0", Offset = "0x6190A0", Length = "0x96")]
	[Token(Token = "0x6000614")]
	public static bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds) { }

	[Address(RVA = "0x619D40", Offset = "0x619140", Length = "0x96")]
	[Token(Token = "0x60005FE")]
	public static bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue) { }

	[Address(RVA = "0x619DE0", Offset = "0x6191E0", Length = "0x96")]
	[Token(Token = "0x6000611")]
	public static bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	[Address(RVA = "0x619E80", Offset = "0x619280", Length = "0x150")]
	[Token(Token = "0x6000601")]
	public static bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchParamName, UTF8StringHandle pchParamValue) { }

	[Address(RVA = "0x619FE0", Offset = "0x6193E0", Length = "0x150")]
	[Token(Token = "0x6000600")]
	public static bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, UTF8StringHandle pchHeaderValue) { }

	[Address(RVA = "0x61A140", Offset = "0x619540", Length = "0x96")]
	[Token(Token = "0x60005FF")]
	public static bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	[Address(RVA = "0x61A1E0", Offset = "0x6195E0", Length = "0x111")]
	[Token(Token = "0x600060D")]
	public static bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchContentType, Byte[] pubBody, uint unBodyLen) { }

	[Address(RVA = "0x61A300", Offset = "0x619700", Length = "0x98")]
	[Token(Token = "0x6000613")]
	public static bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	[Address(RVA = "0x61A3A0", Offset = "0x6197A0", Length = "0xE0")]
	[Token(Token = "0x6000612")]
	public static bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchUserAgentInfo) { }

	[Address(RVA = "0x61A530", Offset = "0x619930", Length = "0x93")]
	[Token(Token = "0x6000620")]
	public static void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	[Address(RVA = "0x61A490", Offset = "0x619890", Length = "0x93")]
	[Token(Token = "0x6000622")]
	public static void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	[Address(RVA = "0x61A5D0", Offset = "0x6199D0", Length = "0x7D")]
	[Token(Token = "0x600061B")]
	public static bool ISteamInput_BNewDataAvailable(IntPtr instancePtr) { }

	[Address(RVA = "0x61A650", Offset = "0x619A50", Length = "0x99")]
	[Token(Token = "0x600061A")]
	public static bool ISteamInput_BWaitForData(IntPtr instancePtr, bool bWaitForever, uint unTimeout) { }

	[Address(RVA = "0x61A6F0", Offset = "0x619AF0", Length = "0x93")]
	[Token(Token = "0x6000623")]
	public static void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	[Address(RVA = "0x61A790", Offset = "0x619B90", Length = "0x87")]
	[Token(Token = "0x6000624")]
	public static void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61A820", Offset = "0x619C20", Length = "0x91")]
	[Token(Token = "0x600061E")]
	public static void ISteamInput_EnableActionEventCallbacks(IntPtr instancePtr, SteamInputActionEventCallbackPointer pCallback) { }

	[Address(RVA = "0x61A8C0", Offset = "0x619CC0", Length = "0x78")]
	[Token(Token = "0x600061D")]
	public static void ISteamInput_EnableDeviceCallbacks(IntPtr instancePtr) { }

	[Address(RVA = "0x61A940", Offset = "0x619D40", Length = "0x93")]
	[Token(Token = "0x6000640")]
	public static EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	[Address(RVA = "0x61A9E0", Offset = "0x619DE0", Length = "0xD4")]
	[Token(Token = "0x600061F")]
	public static ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, UTF8StringHandle pszActionSetName) { }

	[Address(RVA = "0x61AAC0", Offset = "0x619EC0", Length = "0x9D")]
	[Token(Token = "0x6000625")]
	public static int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, out InputActionSetHandle_t[] handlesOut) { }

	[Address(RVA = "0x61AB60", Offset = "0x619F60", Length = "0xBF")]
	[Token(Token = "0x600062B")]
	public static InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	[Address(RVA = "0x61AC20", Offset = "0x61A020", Length = "0xD4")]
	[Token(Token = "0x600062A")]
	public static ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, UTF8StringHandle pszActionName) { }

	[Address(RVA = "0x61AD00", Offset = "0x61A100", Length = "0xC0")]
	[Token(Token = "0x600062C")]
	public static int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, out EInputActionOrigin[] originsOut) { }

	[Address(RVA = "0x61ADC0", Offset = "0x61A1C0", Length = "0x91")]
	[Token(Token = "0x600061C")]
	public static int ISteamInput_GetConnectedControllers(IntPtr instancePtr, out InputHandle_t[] handlesOut) { }

	[Address(RVA = "0x61AE60", Offset = "0x61A260", Length = "0x85")]
	[Token(Token = "0x600063C")]
	public static ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex) { }

	[Address(RVA = "0x61AEF0", Offset = "0x61A2F0", Length = "0x87")]
	[Token(Token = "0x6000621")]
	public static ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61AF80", Offset = "0x61A380", Length = "0xA7")]
	[Token(Token = "0x6000642")]
	public static bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	[Address(RVA = "0x61B030", Offset = "0x61A430", Length = "0x93")]
	[Token(Token = "0x6000627")]
	public static InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	[Address(RVA = "0x61B0D0", Offset = "0x61A4D0", Length = "0xD4")]
	[Token(Token = "0x6000626")]
	public static ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, UTF8StringHandle pszActionName) { }

	[Address(RVA = "0x61B1B0", Offset = "0x61A5B0", Length = "0xC0")]
	[Token(Token = "0x6000628")]
	public static int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, out EInputActionOrigin[] originsOut) { }

	[Address(RVA = "0x61B270", Offset = "0x61A670", Length = "0x87")]
	[Token(Token = "0x600063D")]
	public static int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle) { }

	[Address(RVA = "0x61B300", Offset = "0x61A700", Length = "0x85")]
	[Token(Token = "0x600062F")]
	public static IntPtr ISteamInput_GetGlyphForActionOrigin_Legacy(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	[Address(RVA = "0x61B390", Offset = "0x61A790", Length = "0x85")]
	[Token(Token = "0x600063F")]
	public static IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	[Address(RVA = "0x61B420", Offset = "0x61A820", Length = "0xA0")]
	[Token(Token = "0x600062D")]
	public static IntPtr ISteamInput_GetGlyphPNGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	[Address(RVA = "0x61B4C0", Offset = "0x61A8C0", Length = "0x91")]
	[Token(Token = "0x600062E")]
	public static IntPtr ISteamInput_GetGlyphSVGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, uint unFlags) { }

	[Address(RVA = "0x61B560", Offset = "0x61A960", Length = "0x87")]
	[Token(Token = "0x600063B")]
	public static ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61B5F0", Offset = "0x61A9F0", Length = "0xB8")]
	[Token(Token = "0x6000633")]
	public static InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61B6B0", Offset = "0x61AAB0", Length = "0x87")]
	[Token(Token = "0x6000643")]
	public static uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61B740", Offset = "0x61AB40", Length = "0x78")]
	[Token(Token = "0x6000644")]
	public static ushort ISteamInput_GetSessionInputConfigurationSettings(IntPtr instancePtr) { }

	[Address(RVA = "0x61B7C0", Offset = "0x61ABC0", Length = "0x85")]
	[Token(Token = "0x6000630")]
	public static IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	[Address(RVA = "0x61B850", Offset = "0x61AC50", Length = "0x87")]
	[Token(Token = "0x6000631")]
	public static IntPtr ISteamInput_GetStringForAnalogActionName(IntPtr instancePtr, InputAnalogActionHandle_t eActionHandle) { }

	[Address(RVA = "0x61B8E0", Offset = "0x61ACE0", Length = "0x87")]
	[Token(Token = "0x6000629")]
	public static IntPtr ISteamInput_GetStringForDigitalActionName(IntPtr instancePtr, InputDigitalActionHandle_t eActionHandle) { }

	[Address(RVA = "0x61B970", Offset = "0x61AD70", Length = "0x85")]
	[Token(Token = "0x600063E")]
	public static IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	[Address(RVA = "0x61BA00", Offset = "0x61AE00", Length = "0x8C")]
	[Token(Token = "0x6000616")]
	public static bool ISteamInput_Init(IntPtr instancePtr, bool bExplicitlyCallRunFrame) { }

	[Address(RVA = "0x61BA90", Offset = "0x61AE90", Length = "0xA4")]
	[Token(Token = "0x6000638")]
	public static void ISteamInput_Legacy_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	[Address(RVA = "0x61BB40", Offset = "0x61AF40", Length = "0xCA")]
	[Token(Token = "0x6000639")]
	public static void ISteamInput_Legacy_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	[Address(RVA = "0x61BC10", Offset = "0x61B010", Length = "0x87")]
	[Token(Token = "0x6000619")]
	public static void ISteamInput_RunFrame(IntPtr instancePtr, bool bReservedValue) { }

	[Address(RVA = "0x61BCA0", Offset = "0x61B0A0", Length = "0x93")]
	[Token(Token = "0x6000645")]
	public static void ISteamInput_SetDualSenseTriggerEffect(IntPtr instancePtr, InputHandle_t inputHandle, IntPtr pParam) { }

	[Address(RVA = "0x61BD40", Offset = "0x61B140", Length = "0xD7")]
	[Token(Token = "0x6000618")]
	public static bool ISteamInput_SetInputActionManifestFilePath(IntPtr instancePtr, UTF8StringHandle pchInputActionManifestAbsolutePath) { }

	[Address(RVA = "0x61BE20", Offset = "0x61B220", Length = "0xC0")]
	[Token(Token = "0x6000637")]
	public static void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	[Address(RVA = "0x61BEE0", Offset = "0x61B2E0", Length = "0x8C")]
	[Token(Token = "0x600063A")]
	public static bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle) { }

	[Address(RVA = "0x61BF70", Offset = "0x61B370", Length = "0x7D")]
	[Token(Token = "0x6000617")]
	public static bool ISteamInput_Shutdown(IntPtr instancePtr) { }

	[Address(RVA = "0x61BFF0", Offset = "0x61B3F0", Length = "0x93")]
	[Token(Token = "0x6000632")]
	public static void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	[Address(RVA = "0x61C090", Offset = "0x61B490", Length = "0x91")]
	[Token(Token = "0x6000641")]
	public static EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	[Address(RVA = "0x61C130", Offset = "0x61B530", Length = "0xC9")]
	[Token(Token = "0x6000636")]
	public static void ISteamInput_TriggerSimpleHapticEvent(IntPtr instancePtr, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	[Address(RVA = "0x61C2D0", Offset = "0x61B6D0", Length = "0xA6")]
	[Token(Token = "0x6000634")]
	public static void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	[Address(RVA = "0x61C200", Offset = "0x61B600", Length = "0xC3")]
	[Token(Token = "0x6000635")]
	public static void ISteamInput_TriggerVibrationExtended(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

	[Address(RVA = "0x61C380", Offset = "0x61B780", Length = "0x98")]
	[Token(Token = "0x6000652")]
	public static bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	[Address(RVA = "0x61C420", Offset = "0x61B820", Length = "0xB1")]
	[Token(Token = "0x6000653")]
	public static bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	[Address(RVA = "0x61C4E0", Offset = "0x61B8E0", Length = "0x96")]
	[Token(Token = "0x600064A")]
	public static bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	[Address(RVA = "0x61C580", Offset = "0x61B980", Length = "0xA7")]
	[Token(Token = "0x6000654")]
	public static bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	[Address(RVA = "0x61C630", Offset = "0x61BA30", Length = "0xC0")]
	[Token(Token = "0x600064F")]
	public static bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, Byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) { }

	[Address(RVA = "0x61C6F0", Offset = "0x61BAF0", Length = "0x85")]
	[Token(Token = "0x600064B")]
	public static void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x61C780", Offset = "0x61BB80", Length = "0x109")]
	[Token(Token = "0x6000655")]
	public static bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayGenerate, out UInt32[] punArrayGenerateQuantity, uint unArrayGenerateLength, out SteamItemInstanceID_t[] pArrayDestroy, out UInt32[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	[Address(RVA = "0x61C890", Offset = "0x61BC90", Length = "0xCB")]
	[Token(Token = "0x6000650")]
	public static bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayItemDefs, out UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x61C960", Offset = "0x61BD60", Length = "0x8C")]
	[Token(Token = "0x600064C")]
	public static bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x61C9F0", Offset = "0x61BDF0", Length = "0xB1")]
	[Token(Token = "0x600065E")]
	public static bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, out SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x61CAB0", Offset = "0x61BEB0", Length = "0xA2")]
	[Token(Token = "0x600065B")]
	public static bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, out SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x61CB60", Offset = "0x61BF60", Length = "0x109")]
	[Token(Token = "0x600065C")]
	public static bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x61CC70", Offset = "0x61C070", Length = "0xA5")]
	[Token(Token = "0x6000663")]
	public static bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	[Address(RVA = "0x61CD20", Offset = "0x61C120", Length = "0xB1")]
	[Token(Token = "0x600064D")]
	public static bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	[Address(RVA = "0x61CDE0", Offset = "0x61C1E0", Length = "0xD3")]
	[Token(Token = "0x6000662")]
	public static bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, out SteamItemDef_t[] pArrayItemDefs, out UInt64[] pCurrentPrices, out UInt64[] pBasePrices, uint unArrayLength) { }

	[Address(RVA = "0x61CEC0", Offset = "0x61C2C0", Length = "0x78")]
	[Token(Token = "0x6000661")]
	public static uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr) { }

	[Address(RVA = "0x61CF40", Offset = "0x61C340", Length = "0x116")]
	[Token(Token = "0x6000648")]
	public static bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x61D060", Offset = "0x61C460", Length = "0xAF")]
	[Token(Token = "0x6000647")]
	public static bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, out SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	[Address(RVA = "0x61D110", Offset = "0x61C510", Length = "0x85")]
	[Token(Token = "0x6000646")]
	public static EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x61D1A0", Offset = "0x61C5A0", Length = "0x85")]
	[Token(Token = "0x6000649")]
	public static uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x61D230", Offset = "0x61C630", Length = "0x8C")]
	[Token(Token = "0x6000651")]
	public static bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x61D2C0", Offset = "0x61C6C0", Length = "0xE3")]
	[Token(Token = "0x600066B")]
	public static bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, UTF8StringHandle pchItemToken) { }

	[Address(RVA = "0x61D3B0", Offset = "0x61C7B0", Length = "0x7D")]
	[Token(Token = "0x600065A")]
	public static bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr) { }

	[Address(RVA = "0x61D430", Offset = "0x61C830", Length = "0xF1")]
	[Token(Token = "0x6000665")]
	public static bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName) { }

	[Address(RVA = "0x61D530", Offset = "0x61C930", Length = "0x87")]
	[Token(Token = "0x600065D")]
	public static ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x61D5C0", Offset = "0x61C9C0", Length = "0x78")]
	[Token(Token = "0x6000660")]
	public static ulong ISteamInventory_RequestPrices(IntPtr instancePtr) { }

	[Address(RVA = "0x61D640", Offset = "0x61CA40", Length = "0x78")]
	[Token(Token = "0x6000657")]
	public static void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr) { }

	[Address(RVA = "0x61D6C0", Offset = "0x61CAC0", Length = "0xAF")]
	[Token(Token = "0x600064E")]
	public static bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, Byte[] pOutBuffer, out uint punOutBufferSize) { }

	[Address(RVA = "0x61D770", Offset = "0x61CB70", Length = "0x10A")]
	[Token(Token = "0x6000667")]
	public static bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, bool bValue) { }

	[Address(RVA = "0x61D880", Offset = "0x61CC80", Length = "0x10C")]
	[Token(Token = "0x6000669")]
	public static bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, float flValue) { }

	[Address(RVA = "0x61D990", Offset = "0x61CD90", Length = "0x10B")]
	[Token(Token = "0x6000668")]
	public static bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, long nValue) { }

	[Address(RVA = "0x61DAA0", Offset = "0x61CEA0", Length = "0x173")]
	[Token(Token = "0x6000666")]
	public static bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, UTF8StringHandle pchPropertyValue) { }

	[Address(RVA = "0x61DC20", Offset = "0x61D020", Length = "0xB4")]
	[Token(Token = "0x600065F")]
	public static ulong ISteamInventory_StartPurchase(IntPtr instancePtr, out SteamItemDef_t[] pArrayItemDefs, out UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x61DCE0", Offset = "0x61D0E0", Length = "0x78")]
	[Token(Token = "0x6000664")]
	public static ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr) { }

	[Address(RVA = "0x61DD60", Offset = "0x61D160", Length = "0x98")]
	[Token(Token = "0x600066A")]
	public static bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x61DE00", Offset = "0x61D200", Length = "0x11B")]
	[Token(Token = "0x6000659")]
	public static bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, out SteamItemInstanceID_t[] pArrayGive, out UInt32[] pArrayGiveQuantity, uint nArrayGiveLength, out SteamItemInstanceID_t[] pArrayGet, out UInt32[] pArrayGetQuantity, uint nArrayGetLength) { }

	[Address(RVA = "0x61DF20", Offset = "0x61D320", Length = "0xB7")]
	[Token(Token = "0x6000656")]
	public static bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	[Address(RVA = "0x61DFE0", Offset = "0x61D3E0", Length = "0x98")]
	[Token(Token = "0x6000658")]
	public static bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	[Address(RVA = "0x61EB40", Offset = "0x61DF40", Length = "0xC6")]
	[Token(Token = "0x600066E")]
	public static int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	[Address(RVA = "0x61EC10", Offset = "0x61E010", Length = "0x87")]
	[Token(Token = "0x6000677")]
	public static void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61ECA0", Offset = "0x61E0A0", Length = "0x85")]
	[Token(Token = "0x6000675")]
	public static void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter) { }

	[Address(RVA = "0x61ED30", Offset = "0x61E130", Length = "0x85")]
	[Token(Token = "0x6000674")]
	public static void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable) { }

	[Address(RVA = "0x61EDC0", Offset = "0x61E1C0", Length = "0xD7")]
	[Token(Token = "0x6000673")]
	public static void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo) { }

	[Address(RVA = "0x61EEA0", Offset = "0x61E2A0", Length = "0xE6")]
	[Token(Token = "0x6000672")]
	public static void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	[Address(RVA = "0x61EF90", Offset = "0x61E390", Length = "0x85")]
	[Token(Token = "0x6000676")]
	public static void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults) { }

	[Address(RVA = "0x61F020", Offset = "0x61E420", Length = "0x143")]
	[Token(Token = "0x6000671")]
	public static void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType) { }

	[Address(RVA = "0x61F170", Offset = "0x61E570", Length = "0x91")]
	[Token(Token = "0x6000679")]
	public static ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers) { }

	[Address(RVA = "0x61F210", Offset = "0x61E610", Length = "0xE2")]
	[Token(Token = "0x6000683")]
	public static bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x61F380", Offset = "0x61E780", Length = "0xDA")]
	[Token(Token = "0x600066D")]
	public static bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	[Address(RVA = "0x61F300", Offset = "0x61E700", Length = "0x78")]
	[Token(Token = "0x600066C")]
	public static int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr) { }

	[Address(RVA = "0x61F460", Offset = "0x61E860", Length = "0x85")]
	[Token(Token = "0x6000678")]
	public static ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby) { }

	[Address(RVA = "0x61F4F0", Offset = "0x61E8F0", Length = "0xD6")]
	[Token(Token = "0x6000687")]
	public static int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, Byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	[Address(RVA = "0x61F730", Offset = "0x61EB30", Length = "0xE0")]
	[Token(Token = "0x600067F")]
	public static IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x61F5D0", Offset = "0x61E9D0", Length = "0xCB")]
	[Token(Token = "0x6000682")]
	public static bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize) { }

	[Address(RVA = "0x61F6A0", Offset = "0x61EAA0", Length = "0x87")]
	[Token(Token = "0x6000681")]
	public static int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61F820", Offset = "0x61EC20", Length = "0xB7")]
	[Token(Token = "0x600068A")]
	public static bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	[Address(RVA = "0x61F8E0", Offset = "0x61ECE0", Length = "0x93")]
	[Token(Token = "0x600067E")]
	public static ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember) { }

	[Address(RVA = "0x61F980", Offset = "0x61ED80", Length = "0xEF")]
	[Token(Token = "0x6000684")]
	public static IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x61FA70", Offset = "0x61EE70", Length = "0x87")]
	[Token(Token = "0x600068C")]
	public static int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FB00", Offset = "0x61EF00", Length = "0x87")]
	[Token(Token = "0x600068F")]
	public static ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FB90", Offset = "0x61EF90", Length = "0x87")]
	[Token(Token = "0x600067D")]
	public static int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FC20", Offset = "0x61F020", Length = "0x98")]
	[Token(Token = "0x600067C")]
	public static bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	[Address(RVA = "0x61FCC0", Offset = "0x61F0C0", Length = "0x87")]
	[Token(Token = "0x600067A")]
	public static ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FD50", Offset = "0x61F150", Length = "0x87")]
	[Token(Token = "0x600067B")]
	public static void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FDE0", Offset = "0x61F1E0", Length = "0xC2")]
	[Token(Token = "0x600066F")]
	public static bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	[Address(RVA = "0x61FEB0", Offset = "0x61F2B0", Length = "0x8C")]
	[Token(Token = "0x6000688")]
	public static bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby) { }

	[Address(RVA = "0x61FF40", Offset = "0x61F340", Length = "0x78")]
	[Token(Token = "0x6000670")]
	public static ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr) { }

	[Address(RVA = "0x61FFC0", Offset = "0x61F3C0", Length = "0xB1")]
	[Token(Token = "0x6000686")]
	public static bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, Byte[] pvMsgBody, int cubMsgBody) { }

	[Address(RVA = "0x620080", Offset = "0x61F480", Length = "0x98")]
	[Token(Token = "0x6000691")]
	public static bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }

	[Address(RVA = "0x620120", Offset = "0x61F520", Length = "0x152")]
	[Token(Token = "0x6000680")]
	public static bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x620280", Offset = "0x61F680", Length = "0xB4")]
	[Token(Token = "0x6000689")]
	public static void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	[Address(RVA = "0x620340", Offset = "0x61F740", Length = "0x9A")]
	[Token(Token = "0x600068E")]
	public static bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable) { }

	[Address(RVA = "0x6203E0", Offset = "0x61F7E0", Length = "0x143")]
	[Token(Token = "0x6000685")]
	public static void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x620530", Offset = "0x61F930", Length = "0x98")]
	[Token(Token = "0x600068B")]
	public static bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers) { }

	[Address(RVA = "0x6205D0", Offset = "0x61F9D0", Length = "0x98")]
	[Token(Token = "0x6000690")]
	public static bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	[Address(RVA = "0x620670", Offset = "0x61FA70", Length = "0x98")]
	[Token(Token = "0x600068D")]
	public static bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType) { }

	[Address(RVA = "0x61E080", Offset = "0x61D480", Length = "0x87")]
	[Token(Token = "0x600069A")]
	public static void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	[Address(RVA = "0x61E110", Offset = "0x61D510", Length = "0x85")]
	[Token(Token = "0x60006A2")]
	public static void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery) { }

	[Address(RVA = "0x61E1A0", Offset = "0x61D5A0", Length = "0x87")]
	[Token(Token = "0x600069D")]
	public static int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest) { }

	[Address(RVA = "0x61E230", Offset = "0x61D630", Length = "0x93")]
	[Token(Token = "0x6000699")]
	public static IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x61E2D0", Offset = "0x61D6D0", Length = "0x8C")]
	[Token(Token = "0x600069C")]
	public static bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest) { }

	[Address(RVA = "0x61E360", Offset = "0x61D760", Length = "0xA2")]
	[Token(Token = "0x600069F")]
	public static int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E410", Offset = "0x61D810", Length = "0xA2")]
	[Token(Token = "0x60006A0")]
	public static int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E4C0", Offset = "0x61D8C0", Length = "0x87")]
	[Token(Token = "0x600069B")]
	public static void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	[Address(RVA = "0x61E550", Offset = "0x61D950", Length = "0x93")]
	[Token(Token = "0x600069E")]
	public static void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x61E5F0", Offset = "0x61D9F0", Length = "0x87")]
	[Token(Token = "0x6000698")]
	public static void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest) { }

	[Address(RVA = "0x61E680", Offset = "0x61DA80", Length = "0xB0")]
	[Token(Token = "0x6000695")]
	public static IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E730", Offset = "0x61DB30", Length = "0xB0")]
	[Token(Token = "0x6000694")]
	public static IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E7E0", Offset = "0x61DBE0", Length = "0xB0")]
	[Token(Token = "0x6000696")]
	public static IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E890", Offset = "0x61DC90", Length = "0xB0")]
	[Token(Token = "0x6000692")]
	public static IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E940", Offset = "0x61DD40", Length = "0x91")]
	[Token(Token = "0x6000693")]
	public static IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61E9E0", Offset = "0x61DDE0", Length = "0xB0")]
	[Token(Token = "0x6000697")]
	public static IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x61EA90", Offset = "0x61DE90", Length = "0xA2")]
	[Token(Token = "0x60006A1")]
	public static int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	[Address(RVA = "0x621A80", Offset = "0x620E80", Length = "0x7D")]
	[Token(Token = "0x60006BD")]
	public static bool ISteamMusic_BIsEnabled(IntPtr instancePtr) { }

	[Address(RVA = "0x621B00", Offset = "0x620F00", Length = "0x7D")]
	[Token(Token = "0x60006BE")]
	public static bool ISteamMusic_BIsPlaying(IntPtr instancePtr) { }

	[Address(RVA = "0x621B80", Offset = "0x620F80", Length = "0x78")]
	[Token(Token = "0x60006BF")]
	public static AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr) { }

	[Address(RVA = "0x621C00", Offset = "0x621000", Length = "0x78")]
	[Token(Token = "0x60006C5")]
	public static float ISteamMusic_GetVolume(IntPtr instancePtr) { }

	[Address(RVA = "0x621C80", Offset = "0x621080", Length = "0x78")]
	[Token(Token = "0x60006C1")]
	public static void ISteamMusic_Pause(IntPtr instancePtr) { }

	[Address(RVA = "0x621E00", Offset = "0x621200", Length = "0x78")]
	[Token(Token = "0x60006C0")]
	public static void ISteamMusic_Play(IntPtr instancePtr) { }

	[Address(RVA = "0x621D00", Offset = "0x621100", Length = "0x78")]
	[Token(Token = "0x60006C3")]
	public static void ISteamMusic_PlayNext(IntPtr instancePtr) { }

	[Address(RVA = "0x621D80", Offset = "0x621180", Length = "0x78")]
	[Token(Token = "0x60006C2")]
	public static void ISteamMusic_PlayPrevious(IntPtr instancePtr) { }

	[Address(RVA = "0x621E80", Offset = "0x621280", Length = "0x88")]
	[Token(Token = "0x60006C4")]
	public static void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume) { }

	[Address(RVA = "0x620710", Offset = "0x61FB10", Length = "0x8C")]
	[Token(Token = "0x60006C9")]
	public static bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x6207A0", Offset = "0x61FBA0", Length = "0x7D")]
	[Token(Token = "0x60006C8")]
	public static bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr) { }

	[Address(RVA = "0x620820", Offset = "0x61FC20", Length = "0x7D")]
	[Token(Token = "0x60006DB")]
	public static bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr) { }

	[Address(RVA = "0x6208A0", Offset = "0x61FCA0", Length = "0x8C")]
	[Token(Token = "0x60006D7")]
	public static bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable) { }

	[Address(RVA = "0x620930", Offset = "0x61FD30", Length = "0x7D")]
	[Token(Token = "0x60006D6")]
	public static bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr) { }

	[Address(RVA = "0x6209B0", Offset = "0x61FDB0", Length = "0x7D")]
	[Token(Token = "0x60006C7")]
	public static bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr) { }

	[Address(RVA = "0x620A30", Offset = "0x61FE30", Length = "0x8C")]
	[Token(Token = "0x60006CF")]
	public static bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620BE0", Offset = "0x61FFE0", Length = "0x8C")]
	[Token(Token = "0x60006D1")]
	public static bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620AC0", Offset = "0x61FEC0", Length = "0x8C")]
	[Token(Token = "0x60006CD")]
	public static bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620B50", Offset = "0x61FF50", Length = "0x8C")]
	[Token(Token = "0x60006CC")]
	public static bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620C70", Offset = "0x620070", Length = "0x8C")]
	[Token(Token = "0x60006D0")]
	public static bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620D00", Offset = "0x620100", Length = "0x8C")]
	[Token(Token = "0x60006CE")]
	public static bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x620D90", Offset = "0x620190", Length = "0x7D")]
	[Token(Token = "0x60006E5")]
	public static bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr) { }

	[Address(RVA = "0x620E10", Offset = "0x620210", Length = "0x7D")]
	[Token(Token = "0x60006E1")]
	public static bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr) { }

	[Address(RVA = "0x620E90", Offset = "0x620290", Length = "0x7D")]
	[Token(Token = "0x60006E0")]
	public static bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr) { }

	[Address(RVA = "0x620F10", Offset = "0x620310", Length = "0x7D")]
	[Token(Token = "0x60006DC")]
	public static bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr) { }

	[Address(RVA = "0x620F90", Offset = "0x620390", Length = "0xD7")]
	[Token(Token = "0x60006C6")]
	public static bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, UTF8StringHandle pchName) { }

	[Address(RVA = "0x621070", Offset = "0x620470", Length = "0x7D")]
	[Token(Token = "0x60006E2")]
	public static bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr) { }

	[Address(RVA = "0x6210F0", Offset = "0x6204F0", Length = "0x7D")]
	[Token(Token = "0x60006DD")]
	public static bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr) { }

	[Address(RVA = "0x621170", Offset = "0x620570", Length = "0x8A")]
	[Token(Token = "0x60006E4")]
	public static bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID) { }

	[Address(RVA = "0x621200", Offset = "0x620600", Length = "0x8A")]
	[Token(Token = "0x60006DF")]
	public static bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID) { }

	[Address(RVA = "0x621290", Offset = "0x620690", Length = "0xD7")]
	[Token(Token = "0x60006CA")]
	public static bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, UTF8StringHandle pchDisplayName) { }

	[Address(RVA = "0x621420", Offset = "0x620820", Length = "0xF0")]
	[Token(Token = "0x60006E3")]
	public static bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, UTF8StringHandle pchEntryText) { }

	[Address(RVA = "0x621370", Offset = "0x620770", Length = "0xA2")]
	[Token(Token = "0x60006CB")]
	public static bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, Byte[] pvBuffer, uint cbBufferLength) { }

	[Address(RVA = "0x621520", Offset = "0x620920", Length = "0xF0")]
	[Token(Token = "0x60006DE")]
	public static bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, UTF8StringHandle pchEntryText) { }

	[Address(RVA = "0x621620", Offset = "0x620A20", Length = "0xA2")]
	[Token(Token = "0x60006DA")]
	public static bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, Byte[] pvBuffer, uint cbBufferLength) { }

	[Address(RVA = "0x6216D0", Offset = "0x620AD0", Length = "0x8A")]
	[Token(Token = "0x60006D9")]
	public static bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue) { }

	[Address(RVA = "0x621760", Offset = "0x620B60", Length = "0xD7")]
	[Token(Token = "0x60006D8")]
	public static bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, UTF8StringHandle pchText) { }

	[Address(RVA = "0x621840", Offset = "0x620C40", Length = "0x8C")]
	[Token(Token = "0x60006D4")]
	public static bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x6218D0", Offset = "0x620CD0", Length = "0x8A")]
	[Token(Token = "0x60006D2")]
	public static bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus) { }

	[Address(RVA = "0x621960", Offset = "0x620D60", Length = "0x8C")]
	[Token(Token = "0x60006D3")]
	public static bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue) { }

	[Address(RVA = "0x6219F0", Offset = "0x620DF0", Length = "0x8D")]
	[Token(Token = "0x60006D5")]
	public static bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue) { }

	[Address(RVA = "0x626550", Offset = "0x625950", Length = "0x8C")]
	[Token(Token = "0x60006E9")]
	public static bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	[Address(RVA = "0x6265E0", Offset = "0x6259E0", Length = "0x8C")]
	[Token(Token = "0x60006ED")]
	public static bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow) { }

	[Address(RVA = "0x626670", Offset = "0x625A70", Length = "0x98")]
	[Token(Token = "0x60006EB")]
	public static bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel) { }

	[Address(RVA = "0x626710", Offset = "0x625B10", Length = "0x8C")]
	[Token(Token = "0x60006EA")]
	public static bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	[Address(RVA = "0x6267A0", Offset = "0x625BA0", Length = "0xB6")]
	[Token(Token = "0x60006F0")]
	public static uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	[Address(RVA = "0x626860", Offset = "0x625C60", Length = "0xC6")]
	[Token(Token = "0x60006EE")]
	public static uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x626930", Offset = "0x625D30", Length = "0xB1")]
	[Token(Token = "0x60006EF")]
	public static uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x6269F0", Offset = "0x625DF0", Length = "0x98")]
	[Token(Token = "0x60006F2")]
	public static bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x626A90", Offset = "0x625E90", Length = "0x98")]
	[Token(Token = "0x60006F1")]
	public static bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x626B30", Offset = "0x625F30", Length = "0xA5")]
	[Token(Token = "0x60006F9")]
	public static bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	[Address(RVA = "0x626BE0", Offset = "0x625FE0", Length = "0x85")]
	[Token(Token = "0x60006FB")]
	public static int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket) { }

	[Address(RVA = "0x626C70", Offset = "0x626070", Length = "0x98")]
	[Token(Token = "0x60006EC")]
	public static bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	[Address(RVA = "0x626D10", Offset = "0x626110", Length = "0x85")]
	[Token(Token = "0x60006FA")]
	public static ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket) { }

	[Address(RVA = "0x626DA0", Offset = "0x6261A0", Length = "0xC2")]
	[Token(Token = "0x60006F8")]
	public static bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	[Address(RVA = "0x626F10", Offset = "0x626310", Length = "0xA5")]
	[Token(Token = "0x60006F6")]
	public static bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x626E70", Offset = "0x626270", Length = "0x96")]
	[Token(Token = "0x60006F4")]
	public static bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize) { }

	[Address(RVA = "0x626FC0", Offset = "0x6263C0", Length = "0x98")]
	[Token(Token = "0x60006E7")]
	public static bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel) { }

	[Address(RVA = "0x627060", Offset = "0x626460", Length = "0xCC")]
	[Token(Token = "0x60006E8")]
	public static bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel) { }

	[Address(RVA = "0x6271F0", Offset = "0x6265F0", Length = "0xCC")]
	[Token(Token = "0x60006F7")]
	public static bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x627130", Offset = "0x626530", Length = "0xBF")]
	[Token(Token = "0x60006F5")]
	public static bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	[Address(RVA = "0x6272C0", Offset = "0x6266C0", Length = "0xBE")]
	[Token(Token = "0x60006F3")]
	public static bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, Byte[] pubData, uint cubData, bool bReliable) { }

	[Address(RVA = "0x627380", Offset = "0x626780", Length = "0xCA")]
	[Token(Token = "0x60006E6")]
	public static bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, Byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel) { }

	[Address(RVA = "0x621F10", Offset = "0x621310", Length = "0x8C")]
	[Token(Token = "0x60006FE")]
	public static bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x621FA0", Offset = "0x6213A0", Length = "0x98")]
	[Token(Token = "0x6000700")]
	public static bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	[Address(RVA = "0x622040", Offset = "0x621440", Length = "0x8C")]
	[Token(Token = "0x60006FF")]
	public static bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x6220D0", Offset = "0x6214D0", Length = "0x200")]
	[Token(Token = "0x6000701")]
	public static ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }

	[Address(RVA = "0x6222D0", Offset = "0x6216D0", Length = "0xAA")]
	[Token(Token = "0x60006FD")]
	public static int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x622380", Offset = "0x621780", Length = "0xBB")]
	[Token(Token = "0x60006FC")]
	public static EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	[Address(RVA = "0x622440", Offset = "0x621840", Length = "0x85")]
	[Token(Token = "0x6000706")]
	public static EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	[Address(RVA = "0x6224D0", Offset = "0x6218D0", Length = "0x8A")]
	[Token(Token = "0x600072C")]
	public static bool ISteamNetworkingSockets_BeginAsyncRequestFakeIP(IntPtr instancePtr, int nNumPorts) { }

	[Address(RVA = "0x622560", Offset = "0x621960", Length = "0x108")]
	[Token(Token = "0x6000707")]
	public static bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, UTF8StringHandle pszDebug, bool bEnableLinger) { }

	[Address(RVA = "0x622670", Offset = "0x621A70", Length = "0x8A")]
	[Token(Token = "0x6000708")]
	public static bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket) { }

	[Address(RVA = "0x622700", Offset = "0x621B00", Length = "0xC6")]
	[Token(Token = "0x6000716")]
	public static EResult ISteamNetworkingSockets_ConfigureConnectionLanes(IntPtr instancePtr, HSteamNetConnection hConn, int nNumLanes, out Int32[] pLanePriorities, out UInt16[] pLaneWeights) { }

	[Address(RVA = "0x6227D0", Offset = "0x621BD0", Length = "0x103")]
	[Token(Token = "0x6000703")]
	public static uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x6229B0", Offset = "0x621DB0", Length = "0xC0")]
	[Token(Token = "0x6000705")]
	public static uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x6228E0", Offset = "0x621CE0", Length = "0xCB")]
	[Token(Token = "0x6000726")]
	public static uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622A70", Offset = "0x621E70", Length = "0xC0")]
	[Token(Token = "0x6000720")]
	public static uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622B30", Offset = "0x621F30", Length = "0x85")]
	[Token(Token = "0x6000730")]
	public static IntPtr ISteamNetworkingSockets_CreateFakeUDPPort(IntPtr instancePtr, int idxFakeServerPort) { }

	[Address(RVA = "0x622BC0", Offset = "0x621FC0", Length = "0xAA")]
	[Token(Token = "0x6000724")]
	public static uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622C70", Offset = "0x622070", Length = "0x103")]
	[Token(Token = "0x6000702")]
	public static uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622E30", Offset = "0x622230", Length = "0xAA")]
	[Token(Token = "0x6000704")]
	public static uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622D80", Offset = "0x622180", Length = "0xAA")]
	[Token(Token = "0x600072E")]
	public static uint ISteamNetworkingSockets_CreateListenSocketP2PFakeIP(IntPtr instancePtr, int idxFakePort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x622EE0", Offset = "0x6222E0", Length = "0x78")]
	[Token(Token = "0x600071A")]
	public static uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr) { }

	[Address(RVA = "0x622F60", Offset = "0x622360", Length = "0xC6")]
	[Token(Token = "0x6000715")]
	public static bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	[Address(RVA = "0x623030", Offset = "0x622430", Length = "0x8A")]
	[Token(Token = "0x600071B")]
	public static bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x6230C0", Offset = "0x6224C0", Length = "0x18E")]
	[Token(Token = "0x600071F")]
	public static int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x623250", Offset = "0x622650", Length = "0x85")]
	[Token(Token = "0x600070F")]
	public static EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	[Address(RVA = "0x6232E0", Offset = "0x6226E0", Length = "0x152")]
	[Token(Token = "0x6000719")]
	public static ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails) { }

	[Address(RVA = "0x623440", Offset = "0x622840", Length = "0xFC")]
	[Token(Token = "0x6000728")]
	public static bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x623540", Offset = "0x622940", Length = "0x17C")]
	[Token(Token = "0x6000711")]
	public static bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	[Address(RVA = "0x6236C0", Offset = "0x622AC0", Length = "0xA5")]
	[Token(Token = "0x600070C")]
	public static bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen) { }

	[Address(RVA = "0x623770", Offset = "0x622B70", Length = "0x3D9")]
	[Token(Token = "0x6000712")]
	public static EResult ISteamNetworkingSockets_GetConnectionRealTimeStatus(IntPtr instancePtr, HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	[Address(RVA = "0x623B50", Offset = "0x622F50", Length = "0x85")]
	[Token(Token = "0x600070A")]
	public static long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer) { }

	[Address(RVA = "0x623BE0", Offset = "0x622FE0", Length = "0xA0")]
	[Token(Token = "0x6000713")]
	public static int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf) { }

	[Address(RVA = "0x623C80", Offset = "0x623080", Length = "0x282")]
	[Token(Token = "0x600072D")]
	public static void ISteamNetworkingSockets_GetFakeIP(IntPtr instancePtr, int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	[Address(RVA = "0x623F10", Offset = "0x623310", Length = "0xA2")]
	[Token(Token = "0x6000725")]
	public static EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	[Address(RVA = "0x623FC0", Offset = "0x6233C0", Length = "0x106")]
	[Token(Token = "0x6000723")]
	public static EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting) { }

	[Address(RVA = "0x6240D0", Offset = "0x6234D0", Length = "0x78")]
	[Token(Token = "0x6000722")]
	public static uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr) { }

	[Address(RVA = "0x624150", Offset = "0x623550", Length = "0x78")]
	[Token(Token = "0x6000721")]
	public static ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr) { }

	[Address(RVA = "0x6241D0", Offset = "0x6235D0", Length = "0x8C")]
	[Token(Token = "0x6000717")]
	public static bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x624260", Offset = "0x623660", Length = "0xDB")]
	[Token(Token = "0x6000714")]
	public static bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	[Address(RVA = "0x624340", Offset = "0x623740", Length = "0xD7")]
	[Token(Token = "0x600072F")]
	public static EResult ISteamNetworkingSockets_GetRemoteFakeIPForConnection(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	[Address(RVA = "0x624420", Offset = "0x623820", Length = "0x78")]
	[Token(Token = "0x6000718")]
	public static ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr) { }

	[Address(RVA = "0x624600", Offset = "0x623A00", Length = "0xA7")]
	[Token(Token = "0x6000727")]
	public static bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	[Address(RVA = "0x6246B0", Offset = "0x623AB0", Length = "0x192")]
	[Token(Token = "0x600071E")]
	public static bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x6244A0", Offset = "0x6238A0", Length = "0xAA")]
	[Token(Token = "0x6000710")]
	public static int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x624550", Offset = "0x623950", Length = "0xAA")]
	[Token(Token = "0x600071D")]
	public static int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x624850", Offset = "0x623C50", Length = "0x87")]
	[Token(Token = "0x600072A")]
	public static void ISteamNetworkingSockets_ResetIdentity(IntPtr instancePtr, ref SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x6248E0", Offset = "0x623CE0", Length = "0x78")]
	[Token(Token = "0x600072B")]
	public static void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr) { }

	[Address(RVA = "0x624A20", Offset = "0x623E20", Length = "0xB2")]
	[Token(Token = "0x600070E")]
	public static void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, out IntPtr[] pMessages, out Int64[] pOutMessageNumberOrResult) { }

	[Address(RVA = "0x624960", Offset = "0x623D60", Length = "0xBB")]
	[Token(Token = "0x600070D")]
	public static EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	[Address(RVA = "0x624AE0", Offset = "0x623EE0", Length = "0xFC")]
	[Token(Token = "0x6000729")]
	public static bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x624BE0", Offset = "0x623FE0", Length = "0xD5")]
	[Token(Token = "0x600070B")]
	public static void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, UTF8StringHandle pszName) { }

	[Address(RVA = "0x624CC0", Offset = "0x6240C0", Length = "0x96")]
	[Token(Token = "0x600071C")]
	public static bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x624D60", Offset = "0x624160", Length = "0x96")]
	[Token(Token = "0x6000709")]
	public static bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData) { }

	[Address(RVA = "0x624E00", Offset = "0x624200", Length = "0x85")]
	[Token(Token = "0x6000731")]
	public static IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer) { }

	[Address(RVA = "0x624E90", Offset = "0x624290", Length = "0x8D")]
	[Token(Token = "0x6000739")]
	public static bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds) { }

	[Address(RVA = "0x624F20", Offset = "0x624320", Length = "0x159")]
	[Token(Token = "0x6000737")]
	public static void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize) { }

	[Address(RVA = "0x625080", Offset = "0x624480", Length = "0x20A")]
	[Token(Token = "0x6000735")]
	public static int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	[Address(RVA = "0x625290", Offset = "0x624690", Length = "0x143")]
	[Token(Token = "0x6000736")]
	public static int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation) { }

	[Address(RVA = "0x625480", Offset = "0x624880", Length = "0xC8")]
	[Token(Token = "0x6000744")]
	public static ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	[Address(RVA = "0x6253E0", Offset = "0x6247E0", Length = "0xA0")]
	[Token(Token = "0x6000745")]
	public static IntPtr ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	[Address(RVA = "0x625550", Offset = "0x624950", Length = "0x85")]
	[Token(Token = "0x600073B")]
	public static int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID) { }

	[Address(RVA = "0x6255E0", Offset = "0x6249E0", Length = "0x85")]
	[Token(Token = "0x6000741")]
	public static ESteamNetworkingFakeIPType ISteamNetworkingUtils_GetIPv4FakeIPType(IntPtr instancePtr, uint nIPv4) { }

	[Address(RVA = "0x625670", Offset = "0x624A70", Length = "0xF5")]
	[Token(Token = "0x6000734")]
	public static float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x625770", Offset = "0x624B70", Length = "0x78")]
	[Token(Token = "0x600073E")]
	public static long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr) { }

	[Address(RVA = "0x625910", Offset = "0x624D10", Length = "0x91")]
	[Token(Token = "0x600073A")]
	public static int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	[Address(RVA = "0x6257F0", Offset = "0x624BF0", Length = "0x78")]
	[Token(Token = "0x600073C")]
	public static int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr) { }

	[Address(RVA = "0x625870", Offset = "0x624C70", Length = "0x93")]
	[Token(Token = "0x600073D")]
	public static int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz) { }

	[Address(RVA = "0x6259B0", Offset = "0x624DB0", Length = "0xEB")]
	[Token(Token = "0x6000742")]
	public static EResult ISteamNetworkingUtils_GetRealIdentityForFakeIP(IntPtr instancePtr, ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	[Address(RVA = "0x625AA0", Offset = "0x624EA0", Length = "0x191")]
	[Token(Token = "0x6000733")]
	public static ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails) { }

	[Address(RVA = "0x625C40", Offset = "0x625040", Length = "0x78")]
	[Token(Token = "0x6000732")]
	public static void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr) { }

	[Address(RVA = "0x625CC0", Offset = "0x6250C0", Length = "0x8A")]
	[Token(Token = "0x6000740")]
	public static bool ISteamNetworkingUtils_IsFakeIPv4(IntPtr instancePtr, uint nIPv4) { }

	[Address(RVA = "0x625D50", Offset = "0x625150", Length = "0x93")]
	[Token(Token = "0x6000746")]
	public static ESteamNetworkingConfigValue ISteamNetworkingUtils_IterateGenericEditableConfigValues(IntPtr instancePtr, ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	[Address(RVA = "0x625DF0", Offset = "0x6251F0", Length = "0x13A")]
	[Token(Token = "0x6000738")]
	public static bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, UTF8StringHandle pszString, out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x625F30", Offset = "0x625330", Length = "0xC0")]
	[Token(Token = "0x6000743")]
	public static bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	[Address(RVA = "0x625FF0", Offset = "0x6253F0", Length = "0x9B")]
	[Token(Token = "0x600073F")]
	public static void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	[Address(RVA = "0x6263B0", Offset = "0x6257B0", Length = "0xE3")]
	[Token(Token = "0x600074B")]
	public static bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, UTF8StringHandle pszStr) { }

	[Address(RVA = "0x6264A0", Offset = "0x6258A0", Length = "0xA2")]
	[Token(Token = "0x600074A")]
	public static void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf) { }

	[Address(RVA = "0x626090", Offset = "0x625490", Length = "0xE0")]
	[Token(Token = "0x6000749")]
	public static ESteamNetworkingFakeIPType ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType(IntPtr instancePtr, ref SteamNetworkingIPAddr addr) { }

	[Address(RVA = "0x626170", Offset = "0x625570", Length = "0x131")]
	[Token(Token = "0x6000748")]
	public static bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, UTF8StringHandle pszStr) { }

	[Address(RVA = "0x6262B0", Offset = "0x6256B0", Length = "0xFE")]
	[Token(Token = "0x6000747")]
	public static void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort) { }

	[Address(RVA = "0x627450", Offset = "0x626850", Length = "0x8A")]
	[Token(Token = "0x600074E")]
	public static bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x6274E0", Offset = "0x6268E0", Length = "0x8A")]
	[Token(Token = "0x600074F")]
	public static bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID) { }

	[Address(RVA = "0x627570", Offset = "0x626970", Length = "0x8A")]
	[Token(Token = "0x6000750")]
	public static bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature) { }

	[Address(RVA = "0x627600", Offset = "0x626A00", Length = "0x8A")]
	[Token(Token = "0x6000751")]
	public static bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature) { }

	[Address(RVA = "0x627690", Offset = "0x626A90", Length = "0x7D")]
	[Token(Token = "0x600074C")]
	public static bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr) { }

	[Address(RVA = "0x627710", Offset = "0x626B10", Length = "0x7D")]
	[Token(Token = "0x600074D")]
	public static bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr) { }

	[Address(RVA = "0x627790", Offset = "0x626B90", Length = "0x93")]
	[Token(Token = "0x60006B9")]
	public static void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	[Address(RVA = "0x627830", Offset = "0x626C30", Length = "0x93")]
	[Token(Token = "0x60006BA")]
	public static ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	[Address(RVA = "0x6278D0", Offset = "0x626CD0", Length = "0x173")]
	[Token(Token = "0x60006B7")]
	public static ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, UTF8StringHandle pchConnectString, UTF8StringHandle pchMetadata) { }

	[Address(RVA = "0x627A50", Offset = "0x626E50", Length = "0x8C")]
	[Token(Token = "0x60006BB")]
	public static bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon) { }

	[Address(RVA = "0x627AE0", Offset = "0x626EE0", Length = "0xA2")]
	[Token(Token = "0x60006B6")]
	public static bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, out SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	[Address(RVA = "0x627B90", Offset = "0x626F90", Length = "0x85")]
	[Token(Token = "0x60006B2")]
	public static ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex) { }

	[Address(RVA = "0x627C20", Offset = "0x627020", Length = "0xC2")]
	[Token(Token = "0x60006B3")]
	public static bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata) { }

	[Address(RVA = "0x627CF0", Offset = "0x6270F0", Length = "0xBD")]
	[Token(Token = "0x60006BC")]
	public static bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut) { }

	[Address(RVA = "0x627DB0", Offset = "0x6271B0", Length = "0x78")]
	[Token(Token = "0x60006B1")]
	public static uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr) { }

	[Address(RVA = "0x627E30", Offset = "0x627230", Length = "0x8C")]
	[Token(Token = "0x60006B5")]
	public static bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations) { }

	[Address(RVA = "0x627EC0", Offset = "0x6272C0", Length = "0x87")]
	[Token(Token = "0x60006B4")]
	public static ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID) { }

	[Address(RVA = "0x627F50", Offset = "0x627350", Length = "0x93")]
	[Token(Token = "0x60006B8")]
	public static void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	[Address(RVA = "0x627FF0", Offset = "0x6273F0", Length = "0xA5")]
	[Token(Token = "0x6000757")]
	public static bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	[Address(RVA = "0x6280A0", Offset = "0x6274A0", Length = "0x8C")]
	[Token(Token = "0x6000759")]
	public static bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend) { }

	[Address(RVA = "0x628130", Offset = "0x627530", Length = "0x8C")]
	[Token(Token = "0x6000758")]
	public static bool ISteamRemotePlay_BStartRemotePlayTogether(IntPtr instancePtr, bool bShowOverlay) { }

	[Address(RVA = "0x6281C0", Offset = "0x6275C0", Length = "0x85")]
	[Token(Token = "0x6000756")]
	public static ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	[Address(RVA = "0x628250", Offset = "0x627650", Length = "0x85")]
	[Token(Token = "0x6000755")]
	public static IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	[Address(RVA = "0x6282E0", Offset = "0x6276E0", Length = "0x78")]
	[Token(Token = "0x6000752")]
	public static uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr) { }

	[Address(RVA = "0x628360", Offset = "0x627760", Length = "0x85")]
	[Token(Token = "0x6000753")]
	public static uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex) { }

	[Address(RVA = "0x6283F0", Offset = "0x6277F0", Length = "0x85")]
	[Token(Token = "0x6000754")]
	public static ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	[Address(RVA = "0x628480", Offset = "0x627880", Length = "0x7D")]
	[Token(Token = "0x6000793")]
	public static bool ISteamRemoteStorage_BeginFileWriteBatch(IntPtr instancePtr) { }

	[Address(RVA = "0x628500", Offset = "0x627900", Length = "0x87")]
	[Token(Token = "0x6000780")]
	public static ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle) { }

	[Address(RVA = "0x628590", Offset = "0x627990", Length = "0x87")]
	[Token(Token = "0x6000779")]
	public static ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x628620", Offset = "0x627A20", Length = "0x87")]
	[Token(Token = "0x6000782")]
	public static ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x6286B0", Offset = "0x627AB0", Length = "0x7D")]
	[Token(Token = "0x6000794")]
	public static bool ISteamRemoteStorage_EndFileWriteBatch(IntPtr instancePtr) { }

	[Address(RVA = "0x628730", Offset = "0x627B30", Length = "0x91")]
	[Token(Token = "0x600078E")]
	public static ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex) { }

	[Address(RVA = "0x6287D0", Offset = "0x627BD0", Length = "0xC6")]
	[Token(Token = "0x600078F")]
	public static ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags) { }

	[Address(RVA = "0x6288A0", Offset = "0x627CA0", Length = "0x85")]
	[Token(Token = "0x6000783")]
	public static ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex) { }

	[Address(RVA = "0x628930", Offset = "0x627D30", Length = "0xB2")]
	[Token(Token = "0x600078B")]
	public static ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags) { }

	[Address(RVA = "0x6289F0", Offset = "0x627DF0", Length = "0x85")]
	[Token(Token = "0x6000785")]
	public static ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex) { }

	[Address(RVA = "0x628A80", Offset = "0x627E80", Length = "0xD7")]
	[Token(Token = "0x6000760")]
	public static bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x628B60", Offset = "0x627F60", Length = "0xD7")]
	[Token(Token = "0x6000767")]
	public static bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x628C40", Offset = "0x628040", Length = "0xD7")]
	[Token(Token = "0x600075F")]
	public static bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x628D20", Offset = "0x628120", Length = "0xD7")]
	[Token(Token = "0x6000768")]
	public static bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x628FB0", Offset = "0x6283B0", Length = "0xF7")]
	[Token(Token = "0x600075B")]
	public static int ISteamRemoteStorage_FileRead(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, int cubDataToRead) { }

	[Address(RVA = "0x628EC0", Offset = "0x6282C0", Length = "0xEF")]
	[Token(Token = "0x600075D")]
	public static ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, UTF8StringHandle pchFile, uint nOffset, uint cubToRead) { }

	[Address(RVA = "0x628E00", Offset = "0x628200", Length = "0xB1")]
	[Token(Token = "0x600075E")]
	public static bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, Byte[] pvBuffer, uint cubToRead) { }

	[Address(RVA = "0x6290B0", Offset = "0x6284B0", Length = "0xD4")]
	[Token(Token = "0x6000761")]
	public static ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x629550", Offset = "0x628950", Length = "0xFC")]
	[Token(Token = "0x600075A")]
	public static bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, int cubData) { }

	[Address(RVA = "0x629190", Offset = "0x628590", Length = "0xF9")]
	[Token(Token = "0x600075C")]
	public static ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, uint cubData) { }

	[Address(RVA = "0x629290", Offset = "0x628690", Length = "0x8C")]
	[Token(Token = "0x6000766")]
	public static bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	[Address(RVA = "0x629320", Offset = "0x628720", Length = "0x8C")]
	[Token(Token = "0x6000765")]
	public static bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	[Address(RVA = "0x6293B0", Offset = "0x6287B0", Length = "0xD4")]
	[Token(Token = "0x6000763")]
	public static ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x629490", Offset = "0x628890", Length = "0xB1")]
	[Token(Token = "0x6000764")]
	public static bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, Byte[] pvData, int cubData) { }

	[Address(RVA = "0x629650", Offset = "0x628A50", Length = "0x78")]
	[Token(Token = "0x6000776")]
	public static int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr) { }

	[Address(RVA = "0x6296D0", Offset = "0x628AD0", Length = "0x85")]
	[Token(Token = "0x6000777")]
	public static ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent) { }

	[Address(RVA = "0x629760", Offset = "0x628B60", Length = "0x78")]
	[Token(Token = "0x600076C")]
	public static int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr) { }

	[Address(RVA = "0x6297E0", Offset = "0x628BE0", Length = "0x91")]
	[Token(Token = "0x600076D")]
	public static IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes) { }

	[Address(RVA = "0x629880", Offset = "0x628C80", Length = "0xD2")]
	[Token(Token = "0x6000769")]
	public static int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x629960", Offset = "0x628D60", Length = "0xD4")]
	[Token(Token = "0x600076A")]
	public static long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x629AC0", Offset = "0x628EC0", Length = "0xA0")]
	[Token(Token = "0x6000792")]
	public static IntPtr ISteamRemoteStorage_GetLocalFileChange(IntPtr instancePtr, int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	[Address(RVA = "0x629A40", Offset = "0x628E40", Length = "0x78")]
	[Token(Token = "0x6000791")]
	public static int ISteamRemoteStorage_GetLocalFileChangeCount(IntPtr instancePtr) { }

	[Address(RVA = "0x629B60", Offset = "0x628F60", Length = "0x93")]
	[Token(Token = "0x6000781")]
	public static ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	[Address(RVA = "0x629C00", Offset = "0x629000", Length = "0x87")]
	[Token(Token = "0x6000788")]
	public static ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x629C90", Offset = "0x629090", Length = "0x98")]
	[Token(Token = "0x600076E")]
	public static bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	[Address(RVA = "0x629D30", Offset = "0x629130", Length = "0xD2")]
	[Token(Token = "0x600076B")]
	public static ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x629E10", Offset = "0x629210", Length = "0xC4")]
	[Token(Token = "0x6000774")]
	public static bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	[Address(RVA = "0x629EE0", Offset = "0x6292E0", Length = "0xA7")]
	[Token(Token = "0x6000773")]
	public static bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	[Address(RVA = "0x629F90", Offset = "0x629390", Length = "0x87")]
	[Token(Token = "0x600078A")]
	public static ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x62A020", Offset = "0x629420", Length = "0x7D")]
	[Token(Token = "0x600076F")]
	public static bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr) { }

	[Address(RVA = "0x62A0A0", Offset = "0x6294A0", Length = "0x7D")]
	[Token(Token = "0x6000770")]
	public static bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr) { }

	[Address(RVA = "0x62A120", Offset = "0x629520", Length = "0x293")]
	[Token(Token = "0x600078C")]
	public static ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, UTF8StringHandle pchVideoAccount, UTF8StringHandle pchVideoIdentifier, UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, UTF8StringHandle pchTitle, UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags) { }

	[Address(RVA = "0x62A3C0", Offset = "0x6297C0", Length = "0x260")]
	[Token(Token = "0x6000778")]
	public static ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, UTF8StringHandle pchFile, UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, UTF8StringHandle pchTitle, UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType) { }

	[Address(RVA = "0x62A630", Offset = "0x629A30", Length = "0x87")]
	[Token(Token = "0x6000771")]
	public static void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled) { }

	[Address(RVA = "0x62A6C0", Offset = "0x629AC0", Length = "0xE3")]
	[Token(Token = "0x6000762")]
	public static bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	[Address(RVA = "0x62A7B0", Offset = "0x629BB0", Length = "0x93")]
	[Token(Token = "0x600078D")]
	public static ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	[Address(RVA = "0x62A850", Offset = "0x629C50", Length = "0x87")]
	[Token(Token = "0x6000784")]
	public static ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x62A9D0", Offset = "0x629DD0", Length = "0x93")]
	[Token(Token = "0x6000772")]
	public static ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority) { }

	[Address(RVA = "0x62A8E0", Offset = "0x629CE0", Length = "0xEF")]
	[Token(Token = "0x6000790")]
	public static ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, UTF8StringHandle pchLocation, uint unPriority) { }

	[Address(RVA = "0x62AA70", Offset = "0x629E70", Length = "0xC5")]
	[Token(Token = "0x6000775")]
	public static int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, Byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	[Address(RVA = "0x62AB40", Offset = "0x629F40", Length = "0x87")]
	[Token(Token = "0x6000786")]
	public static ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x62ABD0", Offset = "0x629FD0", Length = "0xE2")]
	[Token(Token = "0x600077D")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchDescription) { }

	[Address(RVA = "0x62ACC0", Offset = "0x62A0C0", Length = "0xE2")]
	[Token(Token = "0x600077A")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchFile) { }

	[Address(RVA = "0x62ADB0", Offset = "0x62A1B0", Length = "0xE2")]
	[Token(Token = "0x600077B")]
	public static bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchPreviewFile) { }

	[Address(RVA = "0x62AEA0", Offset = "0x62A2A0", Length = "0xE2")]
	[Token(Token = "0x6000787")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchChangeDescription) { }

	[Address(RVA = "0x62AF90", Offset = "0x62A390", Length = "0x98")]
	[Token(Token = "0x600077F")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags) { }

	[Address(RVA = "0x62B030", Offset = "0x62A430", Length = "0xE2")]
	[Token(Token = "0x600077C")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchTitle) { }

	[Address(RVA = "0x62B120", Offset = "0x62A520", Length = "0x98")]
	[Token(Token = "0x600077E")]
	public static bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	[Address(RVA = "0x62B1C0", Offset = "0x62A5C0", Length = "0x95")]
	[Token(Token = "0x6000789")]
	public static ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

	[Address(RVA = "0x62B260", Offset = "0x62A660", Length = "0x15A")]
	[Token(Token = "0x6000796")]
	public static uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, UTF8StringHandle pchFilename, UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight) { }

	[Address(RVA = "0x62B3C0", Offset = "0x62A7C0", Length = "0x14C")]
	[Token(Token = "0x600079D")]
	public static uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, UTF8StringHandle pchFilename, UTF8StringHandle pchVRFilename) { }

	[Address(RVA = "0x62B510", Offset = "0x62A910", Length = "0x87")]
	[Token(Token = "0x6000798")]
	public static void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook) { }

	[Address(RVA = "0x62B5A0", Offset = "0x62A9A0", Length = "0x7D")]
	[Token(Token = "0x600079C")]
	public static bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr) { }

	[Address(RVA = "0x62B620", Offset = "0x62AA20", Length = "0xE0")]
	[Token(Token = "0x6000799")]
	public static bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, UTF8StringHandle pchLocation) { }

	[Address(RVA = "0x62B710", Offset = "0x62AB10", Length = "0x96")]
	[Token(Token = "0x600079B")]
	public static bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	[Address(RVA = "0x62B7B0", Offset = "0x62ABB0", Length = "0x96")]
	[Token(Token = "0x600079A")]
	public static bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID) { }

	[Address(RVA = "0x62B850", Offset = "0x62AC50", Length = "0x78")]
	[Token(Token = "0x6000797")]
	public static void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr) { }

	[Address(RVA = "0x62B8D0", Offset = "0x62ACD0", Length = "0xBA")]
	[Token(Token = "0x6000795")]
	public static uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, Byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

	[Address(RVA = "0x62B990", Offset = "0x62AD90", Length = "0x1DB")]
	[Token(Token = "0x60007A0")]
	public static void ISteamTimeline_AddTimelineEvent(IntPtr instancePtr, UTF8StringHandle pchIcon, UTF8StringHandle pchTitle, UTF8StringHandle pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip) { }

	[Address(RVA = "0x62BB70", Offset = "0x62AF70", Length = "0x88")]
	[Token(Token = "0x600079F")]
	public static void ISteamTimeline_ClearTimelineStateDescription(IntPtr instancePtr, float flTimeDelta) { }

	[Address(RVA = "0x62BC00", Offset = "0x62B000", Length = "0x85")]
	[Token(Token = "0x60007A1")]
	public static void ISteamTimeline_SetTimelineGameMode(IntPtr instancePtr, ETimelineGameMode eMode) { }

	[Address(RVA = "0x62BC90", Offset = "0x62B090", Length = "0xDB")]
	[Token(Token = "0x600079E")]
	public static void ISteamTimeline_SetTimelineStateDescription(IntPtr instancePtr, UTF8StringHandle pchDescription, float flTimeDelta) { }

	[Address(RVA = "0x62BD70", Offset = "0x62B170", Length = "0x93")]
	[Token(Token = "0x60007F9")]
	public static ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x62BE10", Offset = "0x62B210", Length = "0x98")]
	[Token(Token = "0x60007E1")]
	public static bool ISteamUGC_AddContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x62BEB0", Offset = "0x62B2B0", Length = "0x93")]
	[Token(Token = "0x60007F7")]
	public static ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x62BF50", Offset = "0x62B350", Length = "0xE2")]
	[Token(Token = "0x60007BA")]
	public static bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pTagName) { }

	[Address(RVA = "0x62C040", Offset = "0x62B440", Length = "0x152")]
	[Token(Token = "0x60007DB")]
	public static bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	[Address(RVA = "0x62C1A0", Offset = "0x62B5A0", Length = "0xF1")]
	[Token(Token = "0x60007DC")]
	public static bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszPreviewFile, EItemPreviewType type) { }

	[Address(RVA = "0x62C2A0", Offset = "0x62B6A0", Length = "0xE2")]
	[Token(Token = "0x60007DD")]
	public static bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszVideoID) { }

	[Address(RVA = "0x62C390", Offset = "0x62B790", Length = "0x91")]
	[Token(Token = "0x60007E8")]
	public static ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62C430", Offset = "0x62B830", Length = "0x152")]
	[Token(Token = "0x60007CC")]
	public static bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pKey, UTF8StringHandle pValue) { }

	[Address(RVA = "0x62C630", Offset = "0x62BA30", Length = "0xE2")]
	[Token(Token = "0x60007B8")]
	public static bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pTagName) { }

	[Address(RVA = "0x62C590", Offset = "0x62B990", Length = "0x98")]
	[Token(Token = "0x60007B9")]
	public static bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups) { }

	[Address(RVA = "0x62C720", Offset = "0x62BB20", Length = "0xE0")]
	[Token(Token = "0x60007F2")]
	public static bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, UTF8StringHandle pszFolder) { }

	[Address(RVA = "0x62C810", Offset = "0x62BC10", Length = "0x91")]
	[Token(Token = "0x60007CE")]
	public static ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	[Address(RVA = "0x62C8B0", Offset = "0x62BCB0", Length = "0x114")]
	[Token(Token = "0x60007A4")]
	public static ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, UTF8StringHandle pchCursor) { }

	[Address(RVA = "0x62C9D0", Offset = "0x62BDD0", Length = "0xB9")]
	[Token(Token = "0x60007A3")]
	public static ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x62CA90", Offset = "0x62BE90", Length = "0x9D")]
	[Token(Token = "0x60007A5")]
	public static ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x62CB30", Offset = "0x62BF30", Length = "0xCD")]
	[Token(Token = "0x60007A2")]
	public static ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x62CC00", Offset = "0x62C000", Length = "0x87")]
	[Token(Token = "0x60007FC")]
	public static ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62CC90", Offset = "0x62C090", Length = "0x9A")]
	[Token(Token = "0x60007F1")]
	public static bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	[Address(RVA = "0x62CD30", Offset = "0x62C130", Length = "0x87")]
	[Token(Token = "0x60007FB")]
	public static ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62CDC0", Offset = "0x62C1C0", Length = "0xA7")]
	[Token(Token = "0x60007F0")]
	public static bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	[Address(RVA = "0x62CE70", Offset = "0x62C270", Length = "0xC2")]
	[Token(Token = "0x60007EF")]
	public static bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	[Address(RVA = "0x62CF40", Offset = "0x62C340", Length = "0x87")]
	[Token(Token = "0x60007EE")]
	public static uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62CFD0", Offset = "0x62C3D0", Length = "0xA2")]
	[Token(Token = "0x60007E5")]
	public static EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	[Address(RVA = "0x62D080", Offset = "0x62C480", Length = "0x78")]
	[Token(Token = "0x60007EC")]
	public static uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr) { }

	[Address(RVA = "0x62D100", Offset = "0x62C500", Length = "0x93")]
	[Token(Token = "0x60007B4")]
	public static uint ISteamUGC_GetNumSupportedGameVersions(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x62D1A0", Offset = "0x62C5A0", Length = "0x116")]
	[Token(Token = "0x60007B3")]
	public static bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize) { }

	[Address(RVA = "0x62D2C0", Offset = "0x62C6C0", Length = "0xEB")]
	[Token(Token = "0x60007B0")]
	public static bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	[Address(RVA = "0x62D3B0", Offset = "0x62C7B0", Length = "0xBF")]
	[Token(Token = "0x60007AD")]
	public static bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x62D470", Offset = "0x62C870", Length = "0xBA")]
	[Token(Token = "0x60007B6")]
	public static uint ISteamUGC_GetQueryUGCContentDescriptors(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x62D530", Offset = "0x62C930", Length = "0xD8")]
	[Token(Token = "0x60007B2")]
	public static bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	[Address(RVA = "0x62D610", Offset = "0x62CA10", Length = "0xB5")]
	[Token(Token = "0x60007AC")]
	public static bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	[Address(RVA = "0x62D6D0", Offset = "0x62CAD0", Length = "0x93")]
	[Token(Token = "0x60007AF")]
	public static uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x62D770", Offset = "0x62CB70", Length = "0x93")]
	[Token(Token = "0x60007B1")]
	public static uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x62D810", Offset = "0x62CC10", Length = "0x93")]
	[Token(Token = "0x60007A8")]
	public static uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x62D8B0", Offset = "0x62CCB0", Length = "0xB5")]
	[Token(Token = "0x60007AB")]
	public static bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	[Address(RVA = "0x62D970", Offset = "0x62CD70", Length = "0x171")]
	[Token(Token = "0x60007A7")]
	public static bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	[Address(RVA = "0x62DAF0", Offset = "0x62CEF0", Length = "0xB7")]
	[Token(Token = "0x60007AE")]
	public static bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	[Address(RVA = "0x62DC80", Offset = "0x62D080", Length = "0xC2")]
	[Token(Token = "0x60007A9")]
	public static bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	[Address(RVA = "0x62DBB0", Offset = "0x62CFB0", Length = "0xC2")]
	[Token(Token = "0x60007AA")]
	public static bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	[Address(RVA = "0x62DD50", Offset = "0x62D150", Length = "0x9D")]
	[Token(Token = "0x60007ED")]
	public static uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x62DDF0", Offset = "0x62D1F0", Length = "0xCD")]
	[Token(Token = "0x60007B5")]
	public static bool ISteamUGC_GetSupportedGameVersionData(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint versionIndex, IntPtr pchGameBranchMin, IntPtr pchGameBranchMax, uint cchGameBranchSize) { }

	[Address(RVA = "0x62DEC0", Offset = "0x62D2C0", Length = "0x9D")]
	[Token(Token = "0x60007FF")]
	public static uint ISteamUGC_GetUserContentDescriptorPreferences(IntPtr instancePtr, out EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x62DF60", Offset = "0x62D360", Length = "0x87")]
	[Token(Token = "0x60007E7")]
	public static ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62DFF0", Offset = "0x62D3F0", Length = "0x78")]
	[Token(Token = "0x60007FE")]
	public static ulong ISteamUGC_GetWorkshopEULAStatus(IntPtr instancePtr) { }

	[Address(RVA = "0x62E070", Offset = "0x62D470", Length = "0x8C")]
	[Token(Token = "0x60007B7")]
	public static bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	[Address(RVA = "0x62E100", Offset = "0x62D500", Length = "0x8C")]
	[Token(Token = "0x60007D9")]
	public static bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle) { }

	[Address(RVA = "0x62E190", Offset = "0x62D590", Length = "0x93")]
	[Token(Token = "0x60007FA")]
	public static ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x62E230", Offset = "0x62D630", Length = "0x98")]
	[Token(Token = "0x60007E2")]
	public static bool ISteamUGC_RemoveContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x62E2D0", Offset = "0x62D6D0", Length = "0x93")]
	[Token(Token = "0x60007F8")]
	public static ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x62E370", Offset = "0x62D770", Length = "0x91")]
	[Token(Token = "0x60007E9")]
	public static ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62E410", Offset = "0x62D810", Length = "0xE2")]
	[Token(Token = "0x60007DA")]
	public static bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x62E500", Offset = "0x62D900", Length = "0x98")]
	[Token(Token = "0x60007E0")]
	public static bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index) { }

	[Address(RVA = "0x62E5A0", Offset = "0x62D9A0", Length = "0x93")]
	[Token(Token = "0x60007CD")]
	public static ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x62E640", Offset = "0x62DA40", Length = "0x87")]
	[Token(Token = "0x60007A6")]
	public static ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	[Address(RVA = "0x62E6D0", Offset = "0x62DAD0", Length = "0x9A")]
	[Token(Token = "0x60007C5")]
	public static bool ISteamUGC_SetAdminQuery(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAdminQuery) { }

	[Address(RVA = "0x62E770", Offset = "0x62DB70", Length = "0x98")]
	[Token(Token = "0x60007C4")]
	public static bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x62E810", Offset = "0x62DC10", Length = "0x9A")]
	[Token(Token = "0x60007D8")]
	public static bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	[Address(RVA = "0x62E8B0", Offset = "0x62DCB0", Length = "0xE2")]
	[Token(Token = "0x60007C6")]
	public static bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pMatchCloudFileName) { }

	[Address(RVA = "0x62E9A0", Offset = "0x62DDA0", Length = "0xE2")]
	[Token(Token = "0x60007D6")]
	public static bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszContentFolder) { }

	[Address(RVA = "0x62EA90", Offset = "0x62DE90", Length = "0xE2")]
	[Token(Token = "0x60007D1")]
	public static bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchDescription) { }

	[Address(RVA = "0x62EB80", Offset = "0x62DF80", Length = "0xE2")]
	[Token(Token = "0x60007D3")]
	public static bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchMetaData) { }

	[Address(RVA = "0x62EC70", Offset = "0x62E070", Length = "0xE2")]
	[Token(Token = "0x60007D7")]
	public static bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszPreviewFile) { }

	[Address(RVA = "0x62ED60", Offset = "0x62E160", Length = "0xA9")]
	[Token(Token = "0x60007D5")]
	public static bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags, bool bAllowAdminTags) { }

	[Address(RVA = "0x62EE10", Offset = "0x62E210", Length = "0xE2")]
	[Token(Token = "0x60007D0")]
	public static bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchTitle) { }

	[Address(RVA = "0x62EF00", Offset = "0x62E300", Length = "0xE2")]
	[Token(Token = "0x60007D2")]
	public static bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchLanguage) { }

	[Address(RVA = "0x62EFF0", Offset = "0x62E3F0", Length = "0x98")]
	[Token(Token = "0x60007D4")]
	public static bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	[Address(RVA = "0x62F090", Offset = "0x62E490", Length = "0xE2")]
	[Token(Token = "0x60007C3")]
	public static bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pchLanguage) { }

	[Address(RVA = "0x62F180", Offset = "0x62E580", Length = "0x9A")]
	[Token(Token = "0x60007C7")]
	public static bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	[Address(RVA = "0x62F220", Offset = "0x62E620", Length = "0x98")]
	[Token(Token = "0x60007C9")]
	public static bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x62F2C0", Offset = "0x62E6C0", Length = "0x152")]
	[Token(Token = "0x60007E3")]
	public static bool ISteamUGC_SetRequiredGameVersions(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszGameBranchMin, UTF8StringHandle pszGameBranchMax) { }

	[Address(RVA = "0x62F420", Offset = "0x62E820", Length = "0x9A")]
	[Token(Token = "0x60007C0")]
	public static bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	[Address(RVA = "0x62F4C0", Offset = "0x62E8C0", Length = "0x9A")]
	[Token(Token = "0x60007BF")]
	public static bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren) { }

	[Address(RVA = "0x62F560", Offset = "0x62E960", Length = "0x9A")]
	[Token(Token = "0x60007BC")]
	public static bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	[Address(RVA = "0x62F600", Offset = "0x62EA00", Length = "0x9A")]
	[Token(Token = "0x60007BD")]
	public static bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	[Address(RVA = "0x62F6A0", Offset = "0x62EAA0", Length = "0x9A")]
	[Token(Token = "0x60007BE")]
	public static bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	[Address(RVA = "0x62F740", Offset = "0x62EB40", Length = "0x9A")]
	[Token(Token = "0x60007BB")]
	public static bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	[Address(RVA = "0x62F7E0", Offset = "0x62EBE0", Length = "0x98")]
	[Token(Token = "0x60007C2")]
	public static bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x62F880", Offset = "0x62EC80", Length = "0x9A")]
	[Token(Token = "0x60007C1")]
	public static bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	[Address(RVA = "0x62F920", Offset = "0x62ED20", Length = "0xE2")]
	[Token(Token = "0x60007C8")]
	public static bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pSearchText) { }

	[Address(RVA = "0x62FA10", Offset = "0x62EE10", Length = "0xA7")]
	[Token(Token = "0x60007CA")]
	public static bool ISteamUGC_SetTimeCreatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x62FAC0", Offset = "0x62EEC0", Length = "0xA7")]
	[Token(Token = "0x60007CB")]
	public static bool ISteamUGC_SetTimeUpdatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x62FB70", Offset = "0x62EF70", Length = "0x95")]
	[Token(Token = "0x60007E6")]
	public static ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	[Address(RVA = "0x62FC10", Offset = "0x62F010", Length = "0x7D")]
	[Token(Token = "0x60007FD")]
	public static bool ISteamUGC_ShowWorkshopEULA(IntPtr instancePtr) { }

	[Address(RVA = "0x62FC90", Offset = "0x62F090", Length = "0x91")]
	[Token(Token = "0x60007CF")]
	public static ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x62FD30", Offset = "0x62F130", Length = "0x9D")]
	[Token(Token = "0x60007F4")]
	public static ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x62FE50", Offset = "0x62F250", Length = "0x9D")]
	[Token(Token = "0x60007F5")]
	public static ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x62FDD0", Offset = "0x62F1D0", Length = "0x78")]
	[Token(Token = "0x60007F6")]
	public static ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr) { }

	[Address(RVA = "0x62FEF0", Offset = "0x62F2F0", Length = "0xE0")]
	[Token(Token = "0x60007E4")]
	public static ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchChangeNote) { }

	[Address(RVA = "0x62FFE0", Offset = "0x62F3E0", Length = "0x87")]
	[Token(Token = "0x60007EA")]
	public static ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x630070", Offset = "0x62F470", Length = "0x87")]
	[Token(Token = "0x60007F3")]
	public static void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend) { }

	[Address(RVA = "0x630100", Offset = "0x62F500", Length = "0x87")]
	[Token(Token = "0x60007EB")]
	public static ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x630190", Offset = "0x62F590", Length = "0xF1")]
	[Token(Token = "0x60007DE")]
	public static bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, UTF8StringHandle pszPreviewFile) { }

	[Address(RVA = "0x630290", Offset = "0x62F690", Length = "0xF1")]
	[Token(Token = "0x60007DF")]
	public static bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, UTF8StringHandle pszVideoID) { }

	[Address(RVA = "0x632890", Offset = "0x631C90", Length = "0xA4")]
	[Token(Token = "0x6000814")]
	public static void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	[Address(RVA = "0x632CD0", Offset = "0x6320D0", Length = "0xAC")]
	[Token(Token = "0x600080F")]
	public static EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	[Address(RVA = "0x632940", Offset = "0x631D40", Length = "0x7D")]
	[Token(Token = "0x6000813")]
	public static bool ISteamUser_BIsBehindNAT(IntPtr instancePtr) { }

	[Address(RVA = "0x6329C0", Offset = "0x631DC0", Length = "0x7D")]
	[Token(Token = "0x600081C")]
	public static bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr) { }

	[Address(RVA = "0x632A40", Offset = "0x631E40", Length = "0x7D")]
	[Token(Token = "0x600081D")]
	public static bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr) { }

	[Address(RVA = "0x632AC0", Offset = "0x631EC0", Length = "0x7D")]
	[Token(Token = "0x600081A")]
	public static bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr) { }

	[Address(RVA = "0x632B40", Offset = "0x631F40", Length = "0x7D")]
	[Token(Token = "0x600081B")]
	public static bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr) { }

	[Address(RVA = "0x632BC0", Offset = "0x631FC0", Length = "0x7D")]
	[Token(Token = "0x6000801")]
	public static bool ISteamUser_BLoggedOn(IntPtr instancePtr) { }

	[Address(RVA = "0x632C40", Offset = "0x632040", Length = "0x8A")]
	[Token(Token = "0x6000820")]
	public static bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState) { }

	[Address(RVA = "0x632D80", Offset = "0x632180", Length = "0x85")]
	[Token(Token = "0x6000811")]
	public static void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	[Address(RVA = "0x632E10", Offset = "0x632210", Length = "0xDC")]
	[Token(Token = "0x600080B")]
	public static EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, Byte[] pCompressed, uint cbCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	[Address(RVA = "0x632EF0", Offset = "0x6322F0", Length = "0x87")]
	[Token(Token = "0x6000810")]
	public static void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	[Address(RVA = "0x632F80", Offset = "0x632380", Length = "0xBC")]
	[Token(Token = "0x600080D")]
	public static uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity) { }

	[Address(RVA = "0x633040", Offset = "0x632440", Length = "0xD2")]
	[Token(Token = "0x600080E")]
	public static uint ISteamUser_GetAuthTicketForWebApi(IntPtr instancePtr, UTF8StringHandle pchIdentity) { }

	[Address(RVA = "0x633120", Offset = "0x632520", Length = "0xA2")]
	[Token(Token = "0x6000809")]
	public static EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	[Address(RVA = "0x6331D0", Offset = "0x6325D0", Length = "0x78")]
	[Token(Token = "0x600081F")]
	public static ulong ISteamUser_GetDurationControl(IntPtr instancePtr) { }

	[Address(RVA = "0x633250", Offset = "0x632650", Length = "0xB1")]
	[Token(Token = "0x6000816")]
	public static bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	[Address(RVA = "0x633310", Offset = "0x632710", Length = "0x93")]
	[Token(Token = "0x6000817")]
	public static int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil) { }

	[Address(RVA = "0x6333B0", Offset = "0x6327B0", Length = "0x78")]
	[Token(Token = "0x6000800")]
	public static int ISteamUser_GetHSteamUser(IntPtr instancePtr) { }

	[Address(RVA = "0x633430", Offset = "0x632830", Length = "0x78")]
	[Token(Token = "0x600081E")]
	public static ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr) { }

	[Address(RVA = "0x6334B0", Offset = "0x6328B0", Length = "0x78")]
	[Token(Token = "0x6000818")]
	public static int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr) { }

	[Address(RVA = "0x633530", Offset = "0x632930", Length = "0x78")]
	[Token(Token = "0x6000802")]
	public static ulong ISteamUser_GetSteamID(IntPtr instancePtr) { }

	[Address(RVA = "0x6335B0", Offset = "0x6329B0", Length = "0x98")]
	[Token(Token = "0x6000806")]
	public static bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer) { }

	[Address(RVA = "0x6336D0", Offset = "0x632AD0", Length = "0x101")]
	[Token(Token = "0x600080A")]
	public static EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	[Address(RVA = "0x633650", Offset = "0x632A50", Length = "0x78")]
	[Token(Token = "0x600080C")]
	public static uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr) { }

	[Address(RVA = "0x6337E0", Offset = "0x632BE0", Length = "0xD1")]
	[Token(Token = "0x6000803")]
	public static int ISteamUser_InitiateGameConnection_DEPRECATED(IntPtr instancePtr, Byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	[Address(RVA = "0x6338C0", Offset = "0x632CC0", Length = "0x9D")]
	[Token(Token = "0x6000815")]
	public static ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, Byte[] pDataToInclude, int cbDataToInclude) { }

	[Address(RVA = "0x633960", Offset = "0x632D60", Length = "0xD4")]
	[Token(Token = "0x6000819")]
	public static ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, UTF8StringHandle pchRedirectURL) { }

	[Address(RVA = "0x633A40", Offset = "0x632E40", Length = "0x78")]
	[Token(Token = "0x6000807")]
	public static void ISteamUser_StartVoiceRecording(IntPtr instancePtr) { }

	[Address(RVA = "0x633AC0", Offset = "0x632EC0", Length = "0x78")]
	[Token(Token = "0x6000808")]
	public static void ISteamUser_StopVoiceRecording(IntPtr instancePtr) { }

	[Address(RVA = "0x633B40", Offset = "0x632F40", Length = "0x93")]
	[Token(Token = "0x6000804")]
	public static void ISteamUser_TerminateGameConnection_DEPRECATED(IntPtr instancePtr, uint unIPServer, ushort usPortServer) { }

	[Address(RVA = "0x633BE0", Offset = "0x632FE0", Length = "0xE6")]
	[Token(Token = "0x6000805")]
	public static void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, UTF8StringHandle pchExtraInfo) { }

	[Address(RVA = "0x633CD0", Offset = "0x6330D0", Length = "0x93")]
	[Token(Token = "0x6000812")]
	public static EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	[Address(RVA = "0x630390", Offset = "0x62F790", Length = "0x93")]
	[Token(Token = "0x6000841")]
	public static ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	[Address(RVA = "0x630430", Offset = "0x62F830", Length = "0xD7")]
	[Token(Token = "0x6000829")]
	public static bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, UTF8StringHandle pchName) { }

	[Address(RVA = "0x6305C0", Offset = "0x62F9C0", Length = "0xB0")]
	[Token(Token = "0x600083D")]
	public static ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	[Address(RVA = "0x630510", Offset = "0x62F910", Length = "0xAC")]
	[Token(Token = "0x600083E")]
	public static ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, out CSteamID[] prgUsers, int cUsers) { }

	[Address(RVA = "0x630670", Offset = "0x62FA70", Length = "0xD4")]
	[Token(Token = "0x6000838")]
	public static ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, UTF8StringHandle pchLeaderboardName) { }

	[Address(RVA = "0x630750", Offset = "0x62FB50", Length = "0xEF")]
	[Token(Token = "0x6000837")]
	public static ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	[Address(RVA = "0x630EF0", Offset = "0x6302F0", Length = "0xFA")]
	[Token(Token = "0x6000827")]
	public static bool ISteamUserStats_GetAchievement(IntPtr instancePtr, UTF8StringHandle pchName, out bool pbAchieved) { }

	[Address(RVA = "0x630840", Offset = "0x62FC40", Length = "0xE3")]
	[Token(Token = "0x6000846")]
	public static bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, UTF8StringHandle pchName, out float pflPercent) { }

	[Address(RVA = "0x630930", Offset = "0x62FD30", Length = "0x107")]
	[Token(Token = "0x600082A")]
	public static bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	[Address(RVA = "0x630A40", Offset = "0x62FE40", Length = "0x136")]
	[Token(Token = "0x600082D")]
	public static IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, UTF8StringHandle pchName, UTF8StringHandle pchKey) { }

	[Address(RVA = "0x630B80", Offset = "0x62FF80", Length = "0xD2")]
	[Token(Token = "0x600082C")]
	public static int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, UTF8StringHandle pchName) { }

	[Address(RVA = "0x630C60", Offset = "0x630060", Length = "0x85")]
	[Token(Token = "0x6000830")]
	public static IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement) { }

	[Address(RVA = "0x630CF0", Offset = "0x6300F0", Length = "0xF2")]
	[Token(Token = "0x600084D")]
	public static bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress) { }

	[Address(RVA = "0x630DF0", Offset = "0x6301F0", Length = "0xF2")]
	[Token(Token = "0x600084C")]
	public static bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress) { }

	[Address(RVA = "0x630FF0", Offset = "0x6303F0", Length = "0xD0")]
	[Token(Token = "0x600083F")]
	public static bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, out Int32[] pDetails, int cDetailsMax) { }

	[Address(RVA = "0x6310C0", Offset = "0x6304C0", Length = "0xE3")]
	[Token(Token = "0x6000849")]
	public static bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, UTF8StringHandle pchStatName, out double pData) { }

	[Address(RVA = "0x6311B0", Offset = "0x6305B0", Length = "0xF7")]
	[Token(Token = "0x600084B")]
	public static int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, UTF8StringHandle pchStatName, out Double[] pData, uint cubData) { }

	[Address(RVA = "0x6312B0", Offset = "0x6306B0", Length = "0xF7")]
	[Token(Token = "0x600084A")]
	public static int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, UTF8StringHandle pchStatName, out Int64[] pData, uint cubData) { }

	[Address(RVA = "0x6313B0", Offset = "0x6307B0", Length = "0xE3")]
	[Token(Token = "0x6000848")]
	public static bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, UTF8StringHandle pchStatName, out long pData) { }

	[Address(RVA = "0x6314A0", Offset = "0x6308A0", Length = "0x87")]
	[Token(Token = "0x600083C")]
	public static ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x631530", Offset = "0x630930", Length = "0x87")]
	[Token(Token = "0x600083A")]
	public static int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x6315C0", Offset = "0x6309C0", Length = "0x87")]
	[Token(Token = "0x6000839")]
	public static IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x631650", Offset = "0x630A50", Length = "0x87")]
	[Token(Token = "0x600083B")]
	public static ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	[Address(RVA = "0x6316E0", Offset = "0x630AE0", Length = "0xC7")]
	[Token(Token = "0x6000844")]
	public static int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	[Address(RVA = "0x6317B0", Offset = "0x630BB0", Length = "0xD2")]
	[Token(Token = "0x6000845")]
	public static int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	[Address(RVA = "0x631890", Offset = "0x630C90", Length = "0x78")]
	[Token(Token = "0x600082F")]
	public static uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr) { }

	[Address(RVA = "0x631910", Offset = "0x630D10", Length = "0x78")]
	[Token(Token = "0x6000842")]
	public static ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr) { }

	[Address(RVA = "0x631990", Offset = "0x630D90", Length = "0xE3")]
	[Token(Token = "0x6000823")]
	public static bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, out float pData) { }

	[Address(RVA = "0x631A80", Offset = "0x630E80", Length = "0xE3")]
	[Token(Token = "0x6000822")]
	public static bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, out int pData) { }

	[Address(RVA = "0x631CA0", Offset = "0x6310A0", Length = "0x111")]
	[Token(Token = "0x6000834")]
	public static bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved) { }

	[Address(RVA = "0x631B70", Offset = "0x630F70", Length = "0x121")]
	[Token(Token = "0x6000835")]
	public static bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	[Address(RVA = "0x631DC0", Offset = "0x6311C0", Length = "0xF1")]
	[Token(Token = "0x6000833")]
	public static bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out float pData) { }

	[Address(RVA = "0x631EC0", Offset = "0x6312C0", Length = "0xF1")]
	[Token(Token = "0x6000832")]
	public static bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out int pData) { }

	[Address(RVA = "0x631FC0", Offset = "0x6313C0", Length = "0xF2")]
	[Token(Token = "0x600082E")]
	public static bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress) { }

	[Address(RVA = "0x6320C0", Offset = "0x6314C0", Length = "0x7D")]
	[Token(Token = "0x6000821")]
	public static bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr) { }

	[Address(RVA = "0x632140", Offset = "0x631540", Length = "0x78")]
	[Token(Token = "0x6000843")]
	public static ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr) { }

	[Address(RVA = "0x6321C0", Offset = "0x6315C0", Length = "0x85")]
	[Token(Token = "0x6000847")]
	public static ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays) { }

	[Address(RVA = "0x632250", Offset = "0x631650", Length = "0x87")]
	[Token(Token = "0x6000831")]
	public static ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	[Address(RVA = "0x6322E0", Offset = "0x6316E0", Length = "0x8C")]
	[Token(Token = "0x6000836")]
	public static bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo) { }

	[Address(RVA = "0x632370", Offset = "0x631770", Length = "0xD7")]
	[Token(Token = "0x6000828")]
	public static bool ISteamUserStats_SetAchievement(IntPtr instancePtr, UTF8StringHandle pchName) { }

	[Address(RVA = "0x632450", Offset = "0x631850", Length = "0xE7")]
	[Token(Token = "0x6000825")]
	public static bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, float fData) { }

	[Address(RVA = "0x632540", Offset = "0x631940", Length = "0xE3")]
	[Token(Token = "0x6000824")]
	public static bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, int nData) { }

	[Address(RVA = "0x632630", Offset = "0x631A30", Length = "0x7D")]
	[Token(Token = "0x600082B")]
	public static bool ISteamUserStats_StoreStats(IntPtr instancePtr) { }

	[Address(RVA = "0x6326B0", Offset = "0x631AB0", Length = "0x103")]
	[Token(Token = "0x6000826")]
	public static bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	[Address(RVA = "0x6327C0", Offset = "0x631BC0", Length = "0xCB")]
	[Token(Token = "0x6000840")]
	public static ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, out Int32[] pScoreDetails, int cScoreDetailsCount) { }

	[Address(RVA = "0x633D70", Offset = "0x633170", Length = "0x7D")]
	[Token(Token = "0x600085E")]
	public static bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr) { }

	[Address(RVA = "0x633DF0", Offset = "0x6331F0", Length = "0xD4")]
	[Token(Token = "0x600085F")]
	public static ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, UTF8StringHandle szFileName) { }

	[Address(RVA = "0x633ED0", Offset = "0x6332D0", Length = "0x7D")]
	[Token(Token = "0x6000871")]
	public static bool ISteamUtils_DismissFloatingGamepadTextInput(IntPtr instancePtr) { }

	[Address(RVA = "0x633F50", Offset = "0x633350", Length = "0x7D")]
	[Token(Token = "0x6000872")]
	public static bool ISteamUtils_DismissGamepadTextInput(IntPtr instancePtr) { }

	[Address(RVA = "0x633FD0", Offset = "0x6333D0", Length = "0x110")]
	[Token(Token = "0x600086C")]
	public static int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	[Address(RVA = "0x6340F0", Offset = "0x6334F0", Length = "0x87")]
	[Token(Token = "0x6000859")]
	public static ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall) { }

	[Address(RVA = "0x634180", Offset = "0x633580", Length = "0xD7")]
	[Token(Token = "0x600085A")]
	public static bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	[Address(RVA = "0x634260", Offset = "0x633660", Length = "0x78")]
	[Token(Token = "0x6000856")]
	public static uint ISteamUtils_GetAppID(IntPtr instancePtr) { }

	[Address(RVA = "0x6342E0", Offset = "0x6336E0", Length = "0x78")]
	[Token(Token = "0x6000850")]
	public static EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr) { }

	[Address(RVA = "0x634360", Offset = "0x633760", Length = "0x78")]
	[Token(Token = "0x6000855")]
	public static byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr) { }

	[Address(RVA = "0x6343E0", Offset = "0x6337E0", Length = "0x98")]
	[Token(Token = "0x6000862")]
	public static bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText) { }

	[Address(RVA = "0x634480", Offset = "0x633880", Length = "0x78")]
	[Token(Token = "0x6000861")]
	public static uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr) { }

	[Address(RVA = "0x634690", Offset = "0x633A90", Length = "0xAF")]
	[Token(Token = "0x6000854")]
	public static bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, Byte[] pubDest, int nDestBufferSize) { }

	[Address(RVA = "0x634740", Offset = "0x633B40", Length = "0xA5")]
	[Token(Token = "0x6000853")]
	public static bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight) { }

	[Address(RVA = "0x634500", Offset = "0x633900", Length = "0x78")]
	[Token(Token = "0x600085B")]
	public static uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr) { }

	[Address(RVA = "0x634580", Offset = "0x633980", Length = "0x78")]
	[Token(Token = "0x6000852")]
	public static IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr) { }

	[Address(RVA = "0x634600", Offset = "0x633A00", Length = "0x85")]
	[Token(Token = "0x600086D")]
	public static ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol) { }

	[Address(RVA = "0x6347F0", Offset = "0x633BF0", Length = "0x78")]
	[Token(Token = "0x600084E")]
	public static uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr) { }

	[Address(RVA = "0x634870", Offset = "0x633C70", Length = "0x78")]
	[Token(Token = "0x600084F")]
	public static uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr) { }

	[Address(RVA = "0x6348F0", Offset = "0x633CF0", Length = "0x78")]
	[Token(Token = "0x6000851")]
	public static uint ISteamUtils_GetServerRealTime(IntPtr instancePtr) { }

	[Address(RVA = "0x634970", Offset = "0x633D70", Length = "0x78")]
	[Token(Token = "0x6000863")]
	public static IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr) { }

	[Address(RVA = "0x6349F0", Offset = "0x633DF0", Length = "0x8A")]
	[Token(Token = "0x600086B")]
	public static bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions) { }

	[Address(RVA = "0x634A80", Offset = "0x633E80", Length = "0xAC")]
	[Token(Token = "0x6000858")]
	public static bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	[Address(RVA = "0x634B30", Offset = "0x633F30", Length = "0x7D")]
	[Token(Token = "0x600085D")]
	public static bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr) { }

	[Address(RVA = "0x634BB0", Offset = "0x633FB0", Length = "0x7D")]
	[Token(Token = "0x600086A")]
	public static bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr) { }

	[Address(RVA = "0x634C30", Offset = "0x634030", Length = "0x7D")]
	[Token(Token = "0x6000866")]
	public static bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr) { }

	[Address(RVA = "0x634CB0", Offset = "0x6340B0", Length = "0x7D")]
	[Token(Token = "0x6000864")]
	public static bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr) { }

	[Address(RVA = "0x634D30", Offset = "0x634130", Length = "0x7D")]
	[Token(Token = "0x600086E")]
	public static bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr) { }

	[Address(RVA = "0x634DB0", Offset = "0x6341B0", Length = "0x7D")]
	[Token(Token = "0x6000868")]
	public static bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr) { }

	[Address(RVA = "0x634E30", Offset = "0x634230", Length = "0x87")]
	[Token(Token = "0x6000870")]
	public static void ISteamUtils_SetGameLauncherMode(IntPtr instancePtr, bool bLauncherMode) { }

	[Address(RVA = "0x634EC0", Offset = "0x6342C0", Length = "0x91")]
	[Token(Token = "0x6000865")]
	public static void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset) { }

	[Address(RVA = "0x634F60", Offset = "0x634360", Length = "0x85")]
	[Token(Token = "0x6000857")]
	public static void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition) { }

	[Address(RVA = "0x634FF0", Offset = "0x6343F0", Length = "0x87")]
	[Token(Token = "0x6000869")]
	public static void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled) { }

	[Address(RVA = "0x635080", Offset = "0x634480", Length = "0x91")]
	[Token(Token = "0x600085C")]
	public static void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	[Address(RVA = "0x635120", Offset = "0x634520", Length = "0xBE")]
	[Token(Token = "0x600086F")]
	public static bool ISteamUtils_ShowFloatingGamepadTextInput(IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	[Address(RVA = "0x6351E0", Offset = "0x6345E0", Length = "0x181")]
	[Token(Token = "0x6000860")]
	public static bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, UTF8StringHandle pchDescription, uint unCharMax, UTF8StringHandle pchExistingText) { }

	[Address(RVA = "0x635370", Offset = "0x634770", Length = "0x78")]
	[Token(Token = "0x6000867")]
	public static void ISteamUtils_StartVRDashboard(IntPtr instancePtr) { }

	[Address(RVA = "0x6353F0", Offset = "0x6347F0", Length = "0x85")]
	[Token(Token = "0x6000875")]
	public static void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID) { }

	[Address(RVA = "0x635480", Offset = "0x634880", Length = "0xA5")]
	[Token(Token = "0x6000876")]
	public static bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize) { }

	[Address(RVA = "0x635530", Offset = "0x634930", Length = "0x85")]
	[Token(Token = "0x6000873")]
	public static void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID) { }

	[Address(RVA = "0x6355C0", Offset = "0x6349C0", Length = "0x8C")]
	[Token(Token = "0x6000874")]
	public static bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers) { }

	[Address(RVA = "0x635650", Offset = "0x634A50", Length = "0x68")]
	[Token(Token = "0x60004C1")]
	public static int SteamAPI_GetHSteamPipe() { }

	[Address(RVA = "0x6356C0", Offset = "0x634AC0", Length = "0x68")]
	[Token(Token = "0x60004C3")]
	public static int SteamAPI_GetHSteamUser() { }

	[Address(RVA = "0x635730", Offset = "0x634B30", Length = "0x68")]
	[Token(Token = "0x60004C0")]
	public static int SteamAPI_GetSteamInstallPath() { }

	[Address(RVA = "0x6357A0", Offset = "0x634BA0", Length = "0x6D")]
	[Token(Token = "0x60004BF")]
	public static bool SteamAPI_IsSteamRunning() { }

	[Address(RVA = "0x60CF60", Offset = "0x60C360", Length = "0x78")]
	[Token(Token = "0x6000503")]
	public static void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self) { }

	[Address(RVA = "0x60CFE0", Offset = "0x60C3E0", Length = "0x1A0")]
	[Token(Token = "0x6000502")]
	public static bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

	[Address(RVA = "0x60D180", Offset = "0x60C580", Length = "0xA0")]
	[Token(Token = "0x6000504")]
	public static IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	[Address(RVA = "0x60D220", Offset = "0x60C620", Length = "0xA2")]
	[Token(Token = "0x6000505")]
	public static void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }

	[Address(RVA = "0x635810", Offset = "0x634C10", Length = "0x76")]
	[Token(Token = "0x60004CD")]
	public static void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x635890", Offset = "0x634C90", Length = "0xD5")]
	[Token(Token = "0x60004CE")]
	public static bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	[Address(RVA = "0x635970", Offset = "0x634D70", Length = "0x8A")]
	[Token(Token = "0x60004CC")]
	public static bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg) { }

	[Address(RVA = "0x635A00", Offset = "0x634E00", Length = "0x68")]
	[Token(Token = "0x60004CA")]
	public static void SteamAPI_ManualDispatch_Init() { }

	[Address(RVA = "0x635A70", Offset = "0x634E70", Length = "0x76")]
	[Token(Token = "0x60004CB")]
	public static void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x635B80", Offset = "0x634F80", Length = "0x85")]
	[Token(Token = "0x60004BB")]
	public static void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback) { }

	[Address(RVA = "0x635AF0", Offset = "0x634EF0", Length = "0x87")]
	[Token(Token = "0x60004BD")]
	public static void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	[Address(RVA = "0x635C10", Offset = "0x635010", Length = "0x68")]
	[Token(Token = "0x60004B7")]
	public static void SteamAPI_ReleaseCurrentThreadMemory() { }

	[Address(RVA = "0x635C80", Offset = "0x635080", Length = "0x7B")]
	[Token(Token = "0x60004B6")]
	public static bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID) { }

	[Address(RVA = "0x635D00", Offset = "0x635100", Length = "0x68")]
	[Token(Token = "0x60004BA")]
	public static void SteamAPI_RunCallbacks() { }

	[Address(RVA = "0x635D70", Offset = "0x635170", Length = "0x76")]
	[Token(Token = "0x60004C9")]
	public static void SteamAPI_SetBreakpadAppID(uint unAppID) { }

	[Address(RVA = "0x635DF0", Offset = "0x6351F0", Length = "0xBC")]
	[Token(Token = "0x60004B9")]
	public static void SteamAPI_SetMiniDumpComment(UTF8StringHandle pchMsg) { }

	[Address(RVA = "0x635EB0", Offset = "0x6352B0", Length = "0x78")]
	[Token(Token = "0x60004C2")]
	public static void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks) { }

	[Address(RVA = "0x635F30", Offset = "0x635330", Length = "0x68")]
	[Token(Token = "0x60004B5")]
	public static void SteamAPI_Shutdown() { }

	[Address(RVA = "0x636BF0", Offset = "0x635FF0", Length = "0x78")]
	[Token(Token = "0x60004E6")]
	public static void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636C70", Offset = "0x636070", Length = "0x78")]
	[Token(Token = "0x60004F6")]
	public static ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIdentity_GetFakeIPType(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636CF0", Offset = "0x6360F0", Length = "0x87")]
	[Token(Token = "0x60004FD")]
	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen) { }

	[Address(RVA = "0x636D80", Offset = "0x636180", Length = "0x78")]
	[Token(Token = "0x60004FB")]
	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636E00", Offset = "0x636200", Length = "0x78")]
	[Token(Token = "0x60004F3")]
	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636E80", Offset = "0x636280", Length = "0x78")]
	[Token(Token = "0x60004F5")]
	public static uint SteamAPI_SteamNetworkingIdentity_GetIPv4(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636F00", Offset = "0x636300", Length = "0x78")]
	[Token(Token = "0x60004EF")]
	public static ulong SteamAPI_SteamNetworkingIdentity_GetPSNID(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x636F80", Offset = "0x636380", Length = "0x78")]
	[Token(Token = "0x60004F1")]
	public static ulong SteamAPI_SteamNetworkingIdentity_GetStadiaID(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637080", Offset = "0x636480", Length = "0x78")]
	[Token(Token = "0x60004E9")]
	public static ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637000", Offset = "0x636400", Length = "0x78")]
	[Token(Token = "0x60004EB")]
	public static ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637100", Offset = "0x636500", Length = "0x78")]
	[Token(Token = "0x60004ED")]
	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637180", Offset = "0x636580", Length = "0x8C")]
	[Token(Token = "0x60004FE")]
	public static bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x) { }

	[Address(RVA = "0x637210", Offset = "0x636610", Length = "0x7D")]
	[Token(Token = "0x60004F7")]
	public static bool SteamAPI_SteamNetworkingIdentity_IsFakeIP(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637290", Offset = "0x636690", Length = "0x7D")]
	[Token(Token = "0x60004E7")]
	public static bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637310", Offset = "0x636710", Length = "0x7D")]
	[Token(Token = "0x60004F9")]
	public static bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637390", Offset = "0x636790", Length = "0xD7")]
	[Token(Token = "0x6000500")]
	public static bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, UTF8StringHandle pszStr) { }

	[Address(RVA = "0x637470", Offset = "0x636870", Length = "0xA2")]
	[Token(Token = "0x60004FC")]
	public static bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, out Byte[] data, uint cbLen) { }

	[Address(RVA = "0x637520", Offset = "0x636920", Length = "0xD7")]
	[Token(Token = "0x60004FA")]
	public static bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, UTF8StringHandle pszString) { }

	[Address(RVA = "0x637600", Offset = "0x636A00", Length = "0xE2")]
	[Token(Token = "0x60004F2")]
	public static IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr) { }

	[Address(RVA = "0x6376F0", Offset = "0x636AF0", Length = "0x93")]
	[Token(Token = "0x60004F4")]
	public static void SteamAPI_SteamNetworkingIdentity_SetIPv4Addr(ref SteamNetworkingIdentity self, uint nIPv4, ushort nPort) { }

	[Address(RVA = "0x637790", Offset = "0x636B90", Length = "0x78")]
	[Token(Token = "0x60004F8")]
	public static void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self) { }

	[Address(RVA = "0x637810", Offset = "0x636C10", Length = "0x87")]
	[Token(Token = "0x60004EE")]
	public static void SteamAPI_SteamNetworkingIdentity_SetPSNID(ref SteamNetworkingIdentity self, ulong id) { }

	[Address(RVA = "0x6378A0", Offset = "0x636CA0", Length = "0x87")]
	[Token(Token = "0x60004F0")]
	public static void SteamAPI_SteamNetworkingIdentity_SetStadiaID(ref SteamNetworkingIdentity self, ulong id) { }

	[Address(RVA = "0x6379C0", Offset = "0x636DC0", Length = "0x87")]
	[Token(Token = "0x60004E8")]
	public static void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID) { }

	[Address(RVA = "0x637930", Offset = "0x636D30", Length = "0x87")]
	[Token(Token = "0x60004EA")]
	public static void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID) { }

	[Address(RVA = "0x637A50", Offset = "0x636E50", Length = "0xD7")]
	[Token(Token = "0x60004EC")]
	public static bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, UTF8StringHandle pszString) { }

	[Address(RVA = "0x637B30", Offset = "0x636F30", Length = "0x93")]
	[Token(Token = "0x60004FF")]
	public static void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf) { }

	[Address(RVA = "0x635FA0", Offset = "0x6353A0", Length = "0xC7")]
	[Token(Token = "0x60004D9")]
	public static void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636070", Offset = "0x635470", Length = "0xDA")]
	[Token(Token = "0x60004E4")]
	public static ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636150", Offset = "0x635550", Length = "0xDA")]
	[Token(Token = "0x60004DE")]
	public static uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636230", Offset = "0x635630", Length = "0x129")]
	[Token(Token = "0x60004E3")]
	public static bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x) { }

	[Address(RVA = "0x636360", Offset = "0x635760", Length = "0xDE")]
	[Token(Token = "0x60004E5")]
	public static bool SteamAPI_SteamNetworkingIPAddr_IsFakeIP(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636440", Offset = "0x635840", Length = "0xDE")]
	[Token(Token = "0x60004DD")]
	public static bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636520", Offset = "0x635920", Length = "0xDE")]
	[Token(Token = "0x60004DA")]
	public static bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x636600", Offset = "0x635A00", Length = "0xDE")]
	[Token(Token = "0x60004E0")]
	public static bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self) { }

	[Address(RVA = "0x6366E0", Offset = "0x635AE0", Length = "0x144")]
	[Token(Token = "0x60004E2")]
	public static bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, UTF8StringHandle pszStr) { }

	[Address(RVA = "0x636830", Offset = "0x635C30", Length = "0xE4")]
	[Token(Token = "0x60004DC")]
	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort) { }

	[Address(RVA = "0x636A00", Offset = "0x635E00", Length = "0xF0")]
	[Token(Token = "0x60004DB")]
	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, out Byte[] ipv6, ushort nPort) { }

	[Address(RVA = "0x636920", Offset = "0x635D20", Length = "0xD9")]
	[Token(Token = "0x60004DF")]
	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort) { }

	[Address(RVA = "0x636AF0", Offset = "0x635EF0", Length = "0xF4")]
	[Token(Token = "0x60004E1")]
	public static void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	[Address(RVA = "0x637BD0", Offset = "0x636FD0", Length = "0x78")]
	[Token(Token = "0x6000501")]
	public static void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self) { }

	[Address(RVA = "0x637CE0", Offset = "0x6370E0", Length = "0x78")]
	[Token(Token = "0x60004BC")]
	public static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

	[Address(RVA = "0x637C50", Offset = "0x637050", Length = "0x87")]
	[Token(Token = "0x60004BE")]
	public static void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	[Address(RVA = "0x637D60", Offset = "0x637160", Length = "0x1BD")]
	[Token(Token = "0x60004C8")]
	public static void SteamAPI_UseBreakpadCrashHandler(UTF8StringHandle pchVersion, UTF8StringHandle pchDate, UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback) { }

	[Address(RVA = "0x637F20", Offset = "0x637320", Length = "0x91")]
	[Token(Token = "0x60004B8")]
	public static void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID) { }

	[Address(RVA = "0x637FC0", Offset = "0x6373C0", Length = "0x68")]
	[Token(Token = "0x60004D7")]
	public static IntPtr SteamClient() { }

	[Address(RVA = "0x638030", Offset = "0x637430", Length = "0xE1")]
	[Token(Token = "0x6000506")]
	public static bool SteamEncryptedAppTicket_BDecryptTicket(out Byte[] rgubTicketEncrypted, uint cubTicketEncrypted, out Byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, Byte[] rgubKey, int cubKey) { }

	[Address(RVA = "0x638120", Offset = "0x637520", Length = "0x94")]
	[Token(Token = "0x600050F")]
	public static bool SteamEncryptedAppTicket_BIsLicenseBorrowed(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x6381C0", Offset = "0x6375C0", Length = "0x94")]
	[Token(Token = "0x6000510")]
	public static bool SteamEncryptedAppTicket_BIsLicenseTemporary(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638260", Offset = "0x637660", Length = "0xA0")]
	[Token(Token = "0x6000507")]
	public static bool SteamEncryptedAppTicket_BIsTicketForApp(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	[Address(RVA = "0x638300", Offset = "0x637700", Length = "0xB7")]
	[Token(Token = "0x600050E")]
	public static bool SteamEncryptedAppTicket_BIsTicketSigned(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out Byte[] pubRSAKey, uint cubRSAKey) { }

	[Address(RVA = "0x6383C0", Offset = "0x6377C0", Length = "0x94")]
	[Token(Token = "0x600050C")]
	public static bool SteamEncryptedAppTicket_BUserIsVacBanned(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638460", Offset = "0x637860", Length = "0xA0")]
	[Token(Token = "0x600050B")]
	public static bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	[Address(RVA = "0x638500", Offset = "0x637900", Length = "0x8F")]
	[Token(Token = "0x600050A")]
	public static uint SteamEncryptedAppTicket_GetTicketAppID(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638590", Offset = "0x637990", Length = "0x8F")]
	[Token(Token = "0x6000508")]
	public static uint SteamEncryptedAppTicket_GetTicketIssueTime(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	[Address(RVA = "0x638620", Offset = "0x637A20", Length = "0x9B")]
	[Token(Token = "0x6000509")]
	public static void SteamEncryptedAppTicket_GetTicketSteamID(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	[Address(RVA = "0x6386C0", Offset = "0x637AC0", Length = "0x9B")]
	[Token(Token = "0x600050D")]
	public static IntPtr SteamEncryptedAppTicket_GetUserVariableData(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

	[Address(RVA = "0x60A6F0", Offset = "0x609AF0", Length = "0x6D")]
	[Token(Token = "0x60004D2")]
	public static bool SteamGameServer_BSecure() { }

	[Address(RVA = "0x6387D0", Offset = "0x637BD0", Length = "0x68")]
	[Token(Token = "0x60004D4")]
	public static int SteamGameServer_GetHSteamPipe() { }

	[Address(RVA = "0x638840", Offset = "0x637C40", Length = "0x68")]
	[Token(Token = "0x60004D5")]
	public static int SteamGameServer_GetHSteamUser() { }

	[Address(RVA = "0x6388B0", Offset = "0x637CB0", Length = "0x68")]
	[Token(Token = "0x60004D3")]
	public static ulong SteamGameServer_GetSteamID() { }

	[Address(RVA = "0x60AEB0", Offset = "0x60A2B0", Length = "0x68")]
	[Token(Token = "0x60004D1")]
	public static void SteamGameServer_ReleaseCurrentThreadMemory() { }

	[Address(RVA = "0x638920", Offset = "0x637D20", Length = "0x68")]
	[Token(Token = "0x60004D0")]
	public static void SteamGameServer_RunCallbacks() { }

	[Address(RVA = "0x638990", Offset = "0x637D90", Length = "0x68")]
	[Token(Token = "0x60004CF")]
	public static void SteamGameServer_Shutdown() { }

	[Address(RVA = "0x638760", Offset = "0x637B60", Length = "0x68")]
	[Token(Token = "0x60004D8")]
	public static IntPtr SteamGameServerClient() { }

	[Address(RVA = "0x638A00", Offset = "0x637E00", Length = "0x78")]
	[Token(Token = "0x60004C4")]
	public static IntPtr SteamInternal_ContextInit(IntPtr pContextInitData) { }

	[Address(RVA = "0x638A80", Offset = "0x637E80", Length = "0xCF")]
	[Token(Token = "0x60004C5")]
	public static IntPtr SteamInternal_CreateInterface(UTF8StringHandle ver) { }

	[Address(RVA = "0x638B50", Offset = "0x637F50", Length = "0xD2")]
	[Token(Token = "0x60004C7")]
	public static IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

	[Address(RVA = "0x638C30", Offset = "0x638030", Length = "0xD2")]
	[Token(Token = "0x60004C6")]
	public static IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

	[Address(RVA = "0x638D10", Offset = "0x638110", Length = "0x193")]
	[Token(Token = "0x60004D6")]
	public static ESteamAPIInitResult SteamInternal_GameServer_Init_V2(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, UTF8StringHandle pchVersionString, UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg) { }

	[Address(RVA = "0x638EB0", Offset = "0x6382B0", Length = "0xD2")]
	[Token(Token = "0x60004B4")]
	public static ESteamAPIInitResult SteamInternal_SteamAPI_Init(UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg) { }

}

