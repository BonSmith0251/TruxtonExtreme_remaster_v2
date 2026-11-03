namespace Steamworks;

[Token(Token = "0x2000010")]
public static class SteamGameServerUGC
{

	[Address(RVA = "0x5E6C50", Offset = "0x5E6050", Length = "0x9A")]
	[Token(Token = "0x60001E9")]
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x5E6CF0", Offset = "0x5E60F0", Length = "0x5C")]
	[Token(Token = "0x60001D1")]
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x5E6D50", Offset = "0x5E6150", Length = "0x9B")]
	[Token(Token = "0x60001E7")]
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x5E6DF0", Offset = "0x5E61F0", Length = "0x125")]
	[Token(Token = "0x60001AA")]
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	[Address(RVA = "0x5E6F20", Offset = "0x5E6320", Length = "0x1C6")]
	[Token(Token = "0x60001CB")]
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	[Address(RVA = "0x5E70F0", Offset = "0x5E64F0", Length = "0x13D")]
	[Token(Token = "0x60001CC")]
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	[Address(RVA = "0x5E7230", Offset = "0x5E6630", Length = "0x125")]
	[Token(Token = "0x60001CD")]
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	[Address(RVA = "0x5E7360", Offset = "0x5E6760", Length = "0x99")]
	[Token(Token = "0x60001D8")]
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E7400", Offset = "0x5E6800", Length = "0x1C6")]
	[Token(Token = "0x60001BC")]
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	[Address(RVA = "0x5E7690", Offset = "0x5E6A90", Length = "0x125")]
	[Token(Token = "0x60001A8")]
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	[Address(RVA = "0x5E75D0", Offset = "0x5E69D0", Length = "0xB8")]
	[Token(Token = "0x60001A9")]
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<String> pTagGroups) { }

	[Address(RVA = "0x5E77C0", Offset = "0x5E6BC0", Length = "0x123")]
	[Token(Token = "0x60001E2")]
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	[Address(RVA = "0x5E78F0", Offset = "0x5E6CF0", Length = "0x98")]
	[Token(Token = "0x60001BE")]
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	[Address(RVA = "0x5E7990", Offset = "0x5E6D90", Length = "0xC7")]
	[Token(Token = "0x6000193")]
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x5E7A60", Offset = "0x5E6E60", Length = "0x180")]
	[Token(Token = "0x6000194")]
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) { }

	[Address(RVA = "0x5E7BF0", Offset = "0x5E6FF0", Length = "0x9A")]
	[Token(Token = "0x6000195")]
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x5E7C90", Offset = "0x5E7090", Length = "0xE0")]
	[Token(Token = "0x6000192")]
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	[Address(RVA = "0x5E7D70", Offset = "0x5E7170", Length = "0x8C")]
	[Token(Token = "0x60001EC")]
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E7E00", Offset = "0x5E7200", Length = "0x5E")]
	[Token(Token = "0x60001E1")]
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	[Address(RVA = "0x5E7E60", Offset = "0x5E7260", Length = "0x8C")]
	[Token(Token = "0x60001EB")]
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E7EF0", Offset = "0x5E72F0", Length = "0x74")]
	[Token(Token = "0x60001E0")]
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	[Address(RVA = "0x5E7F70", Offset = "0x5E7370", Length = "0x119")]
	[Token(Token = "0x60001DF")]
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	[Address(RVA = "0x5E8090", Offset = "0x5E7490", Length = "0x4E")]
	[Token(Token = "0x60001DE")]
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E80E0", Offset = "0x5E74E0", Length = "0x74")]
	[Token(Token = "0x60001D5")]
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	[Address(RVA = "0x5E8160", Offset = "0x5E7560", Length = "0x44")]
	[Token(Token = "0x60001DC")]
	public static uint GetNumSubscribedItems() { }

	[Address(RVA = "0x5E81B0", Offset = "0x5E75B0", Length = "0x5C")]
	[Token(Token = "0x60001A4")]
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x5E8210", Offset = "0x5E7610", Length = "0x19A")]
	[Token(Token = "0x60001A0")]
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	[Address(RVA = "0x5E83B0", Offset = "0x5E77B0", Length = "0x84")]
	[Token(Token = "0x600019D")]
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x5E8440", Offset = "0x5E7840", Length = "0xDA")]
	[Token(Token = "0x60001A6")]
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x5E86F0", Offset = "0x5E7AF0", Length = "0x18D")]
	[Token(Token = "0x60001A2")]
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x5E8520", Offset = "0x5E7920", Length = "0x1C4")]
	[Token(Token = "0x60001A3")]
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x5E8880", Offset = "0x5E7C80", Length = "0x10C")]
	[Token(Token = "0x600019C")]
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	[Address(RVA = "0x5E8990", Offset = "0x5E7D90", Length = "0x5C")]
	[Token(Token = "0x600019F")]
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x5E89F0", Offset = "0x5E7DF0", Length = "0x5C")]
	[Token(Token = "0x60001A1")]
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x5E8A50", Offset = "0x5E7E50", Length = "0x5C")]
	[Token(Token = "0x6000198")]
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	[Address(RVA = "0x5E8AB0", Offset = "0x5E7EB0", Length = "0x10C")]
	[Token(Token = "0x600019B")]
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	[Address(RVA = "0x5E8BC0", Offset = "0x5E7FC0", Length = "0x73")]
	[Token(Token = "0x6000197")]
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	[Address(RVA = "0x5E8C40", Offset = "0x5E8040", Length = "0x85")]
	[Token(Token = "0x600019E")]
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	[Address(RVA = "0x5E8E00", Offset = "0x5E8200", Length = "0x124")]
	[Token(Token = "0x6000199")]
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x5E8CD0", Offset = "0x5E80D0", Length = "0x124")]
	[Token(Token = "0x600019A")]
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	[Address(RVA = "0x5E8F30", Offset = "0x5E8330", Length = "0x5C")]
	[Token(Token = "0x60001DD")]
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	[Address(RVA = "0x5E8F90", Offset = "0x5E8390", Length = "0x17C")]
	[Token(Token = "0x60001A5")]
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	[Address(RVA = "0x5E9110", Offset = "0x5E8510", Length = "0x5C")]
	[Token(Token = "0x60001EF")]
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	[Address(RVA = "0x5E9170", Offset = "0x5E8570", Length = "0x8C")]
	[Token(Token = "0x60001D7")]
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E9200", Offset = "0x5E8600", Length = "0x85")]
	[Token(Token = "0x60001EE")]
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	[Address(RVA = "0x5E9290", Offset = "0x5E8690", Length = "0x4E")]
	[Token(Token = "0x60001A7")]
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	[Address(RVA = "0x5E92E0", Offset = "0x5E86E0", Length = "0x4E")]
	[Token(Token = "0x60001C9")]
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	[Address(RVA = "0x5E9330", Offset = "0x5E8730", Length = "0x9A")]
	[Token(Token = "0x60001EA")]
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	[Address(RVA = "0x5E93D0", Offset = "0x5E87D0", Length = "0x5C")]
	[Token(Token = "0x60001D2")]
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	[Address(RVA = "0x5E9430", Offset = "0x5E8830", Length = "0x9B")]
	[Token(Token = "0x60001E8")]
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	[Address(RVA = "0x5E94D0", Offset = "0x5E88D0", Length = "0x99")]
	[Token(Token = "0x60001D9")]
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5E9570", Offset = "0x5E8970", Length = "0x125")]
	[Token(Token = "0x60001CA")]
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	[Address(RVA = "0x5E96A0", Offset = "0x5E8AA0", Length = "0x5C")]
	[Token(Token = "0x60001D0")]
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	[Address(RVA = "0x5E9700", Offset = "0x5E8B00", Length = "0x9A")]
	[Token(Token = "0x60001BD")]
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x5E97A0", Offset = "0x5E8BA0", Length = "0x8C")]
	[Token(Token = "0x6000196")]
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	[Address(RVA = "0x5E9830", Offset = "0x5E8C30", Length = "0x5E")]
	[Token(Token = "0x60001B5")]
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	[Address(RVA = "0x5E9890", Offset = "0x5E8C90", Length = "0x5C")]
	[Token(Token = "0x60001B4")]
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	[Address(RVA = "0x5E98F0", Offset = "0x5E8CF0", Length = "0x5E")]
	[Token(Token = "0x60001C8")]
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	[Address(RVA = "0x5E9950", Offset = "0x5E8D50", Length = "0x125")]
	[Token(Token = "0x60001B6")]
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	[Address(RVA = "0x5E9A80", Offset = "0x5E8E80", Length = "0x125")]
	[Token(Token = "0x60001C6")]
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	[Address(RVA = "0x5E9BB0", Offset = "0x5E8FB0", Length = "0x125")]
	[Token(Token = "0x60001C1")]
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	[Address(RVA = "0x5E9CE0", Offset = "0x5E90E0", Length = "0x125")]
	[Token(Token = "0x60001C3")]
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	[Address(RVA = "0x5E9E10", Offset = "0x5E9210", Length = "0x125")]
	[Token(Token = "0x60001C7")]
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	[Address(RVA = "0x5E9F40", Offset = "0x5E9340", Length = "0xD3")]
	[Token(Token = "0x60001C5")]
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<String> pTags, bool bAllowAdminTags = false) { }

	[Address(RVA = "0x5EA020", Offset = "0x5E9420", Length = "0x125")]
	[Token(Token = "0x60001C0")]
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	[Address(RVA = "0x5EA150", Offset = "0x5E9550", Length = "0x125")]
	[Token(Token = "0x60001C2")]
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	[Address(RVA = "0x5EA280", Offset = "0x5E9680", Length = "0x5C")]
	[Token(Token = "0x60001C4")]
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	[Address(RVA = "0x5EA2E0", Offset = "0x5E96E0", Length = "0x125")]
	[Token(Token = "0x60001B3")]
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	[Address(RVA = "0x5EA410", Offset = "0x5E9810", Length = "0x5E")]
	[Token(Token = "0x60001B7")]
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	[Address(RVA = "0x5EA470", Offset = "0x5E9870", Length = "0x5C")]
	[Token(Token = "0x60001B9")]
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x5EA4D0", Offset = "0x5E98D0", Length = "0x1C6")]
	[Token(Token = "0x60001D3")]
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	[Address(RVA = "0x5EA6A0", Offset = "0x5E9AA0", Length = "0x5E")]
	[Token(Token = "0x60001B0")]
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	[Address(RVA = "0x5EA700", Offset = "0x5E9B00", Length = "0x5E")]
	[Token(Token = "0x60001AF")]
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	[Address(RVA = "0x5EA760", Offset = "0x5E9B60", Length = "0x5E")]
	[Token(Token = "0x60001AC")]
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	[Address(RVA = "0x5EA7C0", Offset = "0x5E9BC0", Length = "0x5E")]
	[Token(Token = "0x60001AD")]
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	[Address(RVA = "0x5EA820", Offset = "0x5E9C20", Length = "0x5E")]
	[Token(Token = "0x60001AE")]
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	[Address(RVA = "0x5EA880", Offset = "0x5E9C80", Length = "0x5E")]
	[Token(Token = "0x60001AB")]
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	[Address(RVA = "0x5EA8E0", Offset = "0x5E9CE0", Length = "0x5C")]
	[Token(Token = "0x60001B2")]
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	[Address(RVA = "0x5EA940", Offset = "0x5E9D40", Length = "0x5E")]
	[Token(Token = "0x60001B1")]
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	[Address(RVA = "0x5EA9A0", Offset = "0x5E9DA0", Length = "0x125")]
	[Token(Token = "0x60001B8")]
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	[Address(RVA = "0x5EAAD0", Offset = "0x5E9ED0", Length = "0x73")]
	[Token(Token = "0x60001BA")]
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x5EAB50", Offset = "0x5E9F50", Length = "0x73")]
	[Token(Token = "0x60001BB")]
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	[Address(RVA = "0x5EABD0", Offset = "0x5E9FD0", Length = "0x9C")]
	[Token(Token = "0x60001D6")]
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	[Address(RVA = "0x5EAC70", Offset = "0x5EA070", Length = "0x44")]
	[Token(Token = "0x60001ED")]
	public static bool ShowWorkshopEULA() { }

	[Address(RVA = "0x5EACC0", Offset = "0x5EA0C0", Length = "0x99")]
	[Token(Token = "0x60001BF")]
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5EAD60", Offset = "0x5EA160", Length = "0x9A")]
	[Token(Token = "0x60001E4")]
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x5EAE90", Offset = "0x5EA290", Length = "0x9A")]
	[Token(Token = "0x60001E5")]
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	[Address(RVA = "0x5EAE00", Offset = "0x5EA200", Length = "0x85")]
	[Token(Token = "0x60001E6")]
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	[Address(RVA = "0x5EAF30", Offset = "0x5EA330", Length = "0x158")]
	[Token(Token = "0x60001D4")]
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	[Address(RVA = "0x5EB090", Offset = "0x5EA490", Length = "0x8C")]
	[Token(Token = "0x60001DA")]
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5EB120", Offset = "0x5EA520", Length = "0x4E")]
	[Token(Token = "0x60001E3")]
	public static void SuspendDownloads(bool bSuspend) { }

	[Address(RVA = "0x5EB170", Offset = "0x5EA570", Length = "0x8C")]
	[Token(Token = "0x60001DB")]
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	[Address(RVA = "0x5EB200", Offset = "0x5EA600", Length = "0x13D")]
	[Token(Token = "0x60001CE")]
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	[Address(RVA = "0x5EB340", Offset = "0x5EA740", Length = "0x13D")]
	[Token(Token = "0x60001CF")]
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

}

