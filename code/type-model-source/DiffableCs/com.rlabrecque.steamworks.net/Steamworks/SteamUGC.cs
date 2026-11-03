namespace Steamworks;

[Token(Token = "0x2000025")]
public static class SteamUGC
{

	[Address(RVA = "0x5FF790", Offset = "0x5FEB90", Length = "0x9A")]
	[Token(Token = "0x6000436")]
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x5FF830", Offset = "0x5FEC30", Length = "0x5C")]
	[Token(Token = "0x600041E")]
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x5FF890", Offset = "0x5FEC90", Length = "0x9B")]
	[Token(Token = "0x6000434")]
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x5FF930", Offset = "0x5FED30", Length = "0x125")]
	[Token(Token = "0x60003F7")]
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	[Address(RVA = "0x5FFA60", Offset = "0x5FEE60", Length = "0x1C6")]
	[Token(Token = "0x6000418")]
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	[Address(RVA = "0x5FFC30", Offset = "0x5FF030", Length = "0x13D")]
	[Token(Token = "0x6000419")]
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	[Address(RVA = "0x5FFD70", Offset = "0x5FF170", Length = "0x125")]
	[Token(Token = "0x600041A")]
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	[Address(RVA = "0x5FFEA0", Offset = "0x5FF2A0", Length = "0x99")]
	[Token(Token = "0x6000425")]
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5FFF40", Offset = "0x5FF340", Length = "0x1C6")]
	[Token(Token = "0x6000409")]
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	[Address(RVA = "0x6001D0", Offset = "0x5FF5D0", Length = "0x125")]
	[Token(Token = "0x60003F5")]
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	[Address(RVA = "0x600110", Offset = "0x5FF510", Length = "0xB8")]
	[Token(Token = "0x60003F6")]
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<String> pTagGroups) { }

	[Address(RVA = "0x600300", Offset = "0x5FF700", Length = "0x123")]
	[Token(Token = "0x600042F")]
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	[Address(RVA = "0x600430", Offset = "0x5FF830", Length = "0x98")]
	[Token(Token = "0x600040B")]
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	[Address(RVA = "0x6004D0", Offset = "0x5FF8D0", Length = "0xC7")]
	[Token(Token = "0x60003E0")]
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x6005A0", Offset = "0x5FF9A0", Length = "0x180")]
	[Token(Token = "0x60003E1")]
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) { }

	[Address(RVA = "0x600730", Offset = "0x5FFB30", Length = "0x9A")]
	[Token(Token = "0x60003E2")]
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x6007D0", Offset = "0x5FFBD0", Length = "0xE0")]
	[Token(Token = "0x60003DF")]
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x6008B0", Offset = "0x5FFCB0", Length = "0x8C")]
	[Token(Token = "0x6000439")]
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x600940", Offset = "0x5FFD40", Length = "0x5E")]
	[Token(Token = "0x600042E")]
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	[Address(RVA = "0x6009A0", Offset = "0x5FFDA0", Length = "0x8C")]
	[Token(Token = "0x6000438")]
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x600A30", Offset = "0x5FFE30", Length = "0x74")]
	[Token(Token = "0x600042D")]
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	[Address(RVA = "0x600AB0", Offset = "0x5FFEB0", Length = "0x119")]
	[Token(Token = "0x600042C")]
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	[Address(RVA = "0x600BD0", Offset = "0x5FFFD0", Length = "0x4E")]
	[Token(Token = "0x600042B")]
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x600C20", Offset = "0x600020", Length = "0x74")]
	[Token(Token = "0x6000422")]
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	[Address(RVA = "0x600CA0", Offset = "0x6000A0", Length = "0x44")]
	[Token(Token = "0x6000429")]
	public static uint GetNumSubscribedItems() { }

	[Address(RVA = "0x600CF0", Offset = "0x6000F0", Length = "0x5C")]
	[Token(Token = "0x60003F1")]
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x600D50", Offset = "0x600150", Length = "0x19A")]
	[Token(Token = "0x60003ED")]
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	[Address(RVA = "0x600EF0", Offset = "0x6002F0", Length = "0x84")]
	[Token(Token = "0x60003EA")]
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x600F80", Offset = "0x600380", Length = "0xDA")]
	[Token(Token = "0x60003F3")]
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x601060", Offset = "0x600460", Length = "0x18D")]
	[Token(Token = "0x60003EF")]
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x6011F0", Offset = "0x6005F0", Length = "0x1C4")]
	[Token(Token = "0x60003F0")]
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x6013C0", Offset = "0x6007C0", Length = "0x10C")]
	[Token(Token = "0x60003E9")]
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	[Address(RVA = "0x6014D0", Offset = "0x6008D0", Length = "0x5C")]
	[Token(Token = "0x60003EC")]
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x601530", Offset = "0x600930", Length = "0x5C")]
	[Token(Token = "0x60003EE")]
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x601590", Offset = "0x600990", Length = "0x5C")]
	[Token(Token = "0x60003E5")]
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x6015F0", Offset = "0x6009F0", Length = "0x10C")]
	[Token(Token = "0x60003E8")]
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	[Address(RVA = "0x601700", Offset = "0x600B00", Length = "0x73")]
	[Token(Token = "0x60003E4")]
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	[Address(RVA = "0x601780", Offset = "0x600B80", Length = "0x85")]
	[Token(Token = "0x60003EB")]
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	[Address(RVA = "0x601940", Offset = "0x600D40", Length = "0x124")]
	[Token(Token = "0x60003E6")]
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x601810", Offset = "0x600C10", Length = "0x124")]
	[Token(Token = "0x60003E7")]
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x601A70", Offset = "0x600E70", Length = "0x5C")]
	[Token(Token = "0x600042A")]
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x601AD0", Offset = "0x600ED0", Length = "0x17C")]
	[Token(Token = "0x60003F2")]
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	[Address(RVA = "0x601C50", Offset = "0x601050", Length = "0x5C")]
	[Token(Token = "0x600043C")]
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x601CB0", Offset = "0x6010B0", Length = "0x8C")]
	[Token(Token = "0x6000424")]
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x601D40", Offset = "0x601140", Length = "0x85")]
	[Token(Token = "0x600043B")]
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	[Address(RVA = "0x601DD0", Offset = "0x6011D0", Length = "0x4E")]
	[Token(Token = "0x60003F4")]
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	[Address(RVA = "0x601E20", Offset = "0x601220", Length = "0x4E")]
	[Token(Token = "0x6000416")]
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	[Address(RVA = "0x601E70", Offset = "0x601270", Length = "0x9A")]
	[Token(Token = "0x6000437")]
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x601F10", Offset = "0x601310", Length = "0x5C")]
	[Token(Token = "0x600041F")]
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x601F70", Offset = "0x601370", Length = "0x9B")]
	[Token(Token = "0x6000435")]
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x602010", Offset = "0x601410", Length = "0x99")]
	[Token(Token = "0x6000426")]
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x6020B0", Offset = "0x6014B0", Length = "0x125")]
	[Token(Token = "0x6000417")]
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	[Address(RVA = "0x6021E0", Offset = "0x6015E0", Length = "0x5C")]
	[Token(Token = "0x600041D")]
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	[Address(RVA = "0x602240", Offset = "0x601640", Length = "0x9A")]
	[Token(Token = "0x600040A")]
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x6022E0", Offset = "0x6016E0", Length = "0x8C")]
	[Token(Token = "0x60003E3")]
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	[Address(RVA = "0x602370", Offset = "0x601770", Length = "0x5E")]
	[Token(Token = "0x6000402")]
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	[Address(RVA = "0x6023D0", Offset = "0x6017D0", Length = "0x5C")]
	[Token(Token = "0x6000401")]
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x602430", Offset = "0x601830", Length = "0x5E")]
	[Token(Token = "0x6000415")]
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	[Address(RVA = "0x602490", Offset = "0x601890", Length = "0x125")]
	[Token(Token = "0x6000403")]
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	[Address(RVA = "0x6025C0", Offset = "0x6019C0", Length = "0x125")]
	[Token(Token = "0x6000413")]
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	[Address(RVA = "0x6026F0", Offset = "0x601AF0", Length = "0x125")]
	[Token(Token = "0x600040E")]
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	[Address(RVA = "0x602820", Offset = "0x601C20", Length = "0x125")]
	[Token(Token = "0x6000410")]
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	[Address(RVA = "0x602950", Offset = "0x601D50", Length = "0x125")]
	[Token(Token = "0x6000414")]
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	[Address(RVA = "0x602A80", Offset = "0x601E80", Length = "0xD3")]
	[Token(Token = "0x6000412")]
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<String> pTags, bool bAllowAdminTags = false) { }

	[Address(RVA = "0x602B60", Offset = "0x601F60", Length = "0x125")]
	[Token(Token = "0x600040D")]
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	[Address(RVA = "0x602C90", Offset = "0x602090", Length = "0x125")]
	[Token(Token = "0x600040F")]
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	[Address(RVA = "0x602DC0", Offset = "0x6021C0", Length = "0x5C")]
	[Token(Token = "0x6000411")]
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	[Address(RVA = "0x602E20", Offset = "0x602220", Length = "0x125")]
	[Token(Token = "0x6000400")]
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	[Address(RVA = "0x602F50", Offset = "0x602350", Length = "0x5E")]
	[Token(Token = "0x6000404")]
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	[Address(RVA = "0x602FB0", Offset = "0x6023B0", Length = "0x5C")]
	[Token(Token = "0x6000406")]
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x603010", Offset = "0x602410", Length = "0x1C6")]
	[Token(Token = "0x6000420")]
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	[Address(RVA = "0x6031E0", Offset = "0x6025E0", Length = "0x5E")]
	[Token(Token = "0x60003FD")]
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	[Address(RVA = "0x603240", Offset = "0x602640", Length = "0x5E")]
	[Token(Token = "0x60003FC")]
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	[Address(RVA = "0x6032A0", Offset = "0x6026A0", Length = "0x5E")]
	[Token(Token = "0x60003F9")]
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	[Address(RVA = "0x603300", Offset = "0x602700", Length = "0x5E")]
	[Token(Token = "0x60003FA")]
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	[Address(RVA = "0x603360", Offset = "0x602760", Length = "0x5E")]
	[Token(Token = "0x60003FB")]
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	[Address(RVA = "0x6033C0", Offset = "0x6027C0", Length = "0x5E")]
	[Token(Token = "0x60003F8")]
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	[Address(RVA = "0x603420", Offset = "0x602820", Length = "0x5C")]
	[Token(Token = "0x60003FF")]
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x603480", Offset = "0x602880", Length = "0x5E")]
	[Token(Token = "0x60003FE")]
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	[Address(RVA = "0x6034E0", Offset = "0x6028E0", Length = "0x125")]
	[Token(Token = "0x6000405")]
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	[Address(RVA = "0x603610", Offset = "0x602A10", Length = "0x73")]
	[Token(Token = "0x6000407")]
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x603690", Offset = "0x602A90", Length = "0x73")]
	[Token(Token = "0x6000408")]
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x603710", Offset = "0x602B10", Length = "0x9C")]
	[Token(Token = "0x6000423")]
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	[Address(RVA = "0x6037B0", Offset = "0x602BB0", Length = "0x44")]
	[Token(Token = "0x600043A")]
	public static bool ShowWorkshopEULA() { }

	[Address(RVA = "0x603800", Offset = "0x602C00", Length = "0x99")]
	[Token(Token = "0x600040C")]
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x6038A0", Offset = "0x602CA0", Length = "0x9A")]
	[Token(Token = "0x6000431")]
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x6039D0", Offset = "0x602DD0", Length = "0x9A")]
	[Token(Token = "0x6000432")]
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x603940", Offset = "0x602D40", Length = "0x85")]
	[Token(Token = "0x6000433")]
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	[Address(RVA = "0x603A70", Offset = "0x602E70", Length = "0x158")]
	[Token(Token = "0x6000421")]
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	[Address(RVA = "0x603BD0", Offset = "0x602FD0", Length = "0x8C")]
	[Token(Token = "0x6000427")]
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x603C60", Offset = "0x603060", Length = "0x4E")]
	[Token(Token = "0x6000430")]
	public static void SuspendDownloads(bool bSuspend) { }

	[Address(RVA = "0x603CB0", Offset = "0x6030B0", Length = "0x8C")]
	[Token(Token = "0x6000428")]
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x603D40", Offset = "0x603140", Length = "0x13D")]
	[Token(Token = "0x600041B")]
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	[Address(RVA = "0x603E80", Offset = "0x603280", Length = "0x13D")]
	[Token(Token = "0x600041C")]
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

}

