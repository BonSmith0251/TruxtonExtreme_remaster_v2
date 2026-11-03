namespace Steamworks;

[Token(Token = "0x2000022")]
public static class SteamRemoteStorage
{

	[Address(RVA = "0x5FB7C0", Offset = "0x5FABC0", Length = "0x44")]
	[Token(Token = "0x60003D0")]
	public static bool BeginFileWriteBatch() { }

	[Address(RVA = "0x5FB810", Offset = "0x5FAC10", Length = "0x8C")]
	[Token(Token = "0x60003BD")]
	public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle) { }

	[Address(RVA = "0x5FB8A0", Offset = "0x5FACA0", Length = "0x8C")]
	[Token(Token = "0x60003B6")]
	public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FB930", Offset = "0x5FAD30", Length = "0x8C")]
	[Token(Token = "0x60003BF")]
	public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FB9C0", Offset = "0x5FADC0", Length = "0x44")]
	[Token(Token = "0x60003D1")]
	public static bool EndFileWriteBatch() { }

	[Address(RVA = "0x5FBA10", Offset = "0x5FAE10", Length = "0x98")]
	[Token(Token = "0x60003CB")]
	public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex) { }

	[Address(RVA = "0x5FBAB0", Offset = "0x5FAEB0", Length = "0x14E")]
	[Token(Token = "0x60003CC")]
	public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<String> pTags, IList<String> pUserTags) { }

	[Address(RVA = "0x5FBC00", Offset = "0x5FB000", Length = "0x8A")]
	[Token(Token = "0x60003C0")]
	public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex) { }

	[Address(RVA = "0x5FBC90", Offset = "0x5FB090", Length = "0x12F")]
	[Token(Token = "0x60003C8")]
	public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<String> pRequiredTags, IList<String> pExcludedTags) { }

	[Address(RVA = "0x5FBDC0", Offset = "0x5FB1C0", Length = "0x8A")]
	[Token(Token = "0x60003C2")]
	public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex) { }

	[Address(RVA = "0x5FBE50", Offset = "0x5FB250", Length = "0x115")]
	[Token(Token = "0x600039D")]
	public static bool FileDelete(string pchFile) { }

	[Address(RVA = "0x5FBF70", Offset = "0x5FB370", Length = "0x115")]
	[Token(Token = "0x60003A4")]
	public static bool FileExists(string pchFile) { }

	[Address(RVA = "0x5FC090", Offset = "0x5FB490", Length = "0x115")]
	[Token(Token = "0x600039C")]
	public static bool FileForget(string pchFile) { }

	[Address(RVA = "0x5FC1B0", Offset = "0x5FB5B0", Length = "0x115")]
	[Token(Token = "0x60003A5")]
	public static bool FilePersisted(string pchFile) { }

	[Address(RVA = "0x5FC4C0", Offset = "0x5FB8C0", Length = "0x130")]
	[Token(Token = "0x6000398")]
	public static int FileRead(string pchFile, Byte[] pvData, int cubDataToRead) { }

	[Address(RVA = "0x5FC350", Offset = "0x5FB750", Length = "0x162")]
	[Token(Token = "0x600039A")]
	public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead) { }

	[Address(RVA = "0x5FC2D0", Offset = "0x5FB6D0", Length = "0x74")]
	[Token(Token = "0x600039B")]
	public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, Byte[] pvBuffer, uint cubToRead) { }

	[Address(RVA = "0x5FC600", Offset = "0x5FBA00", Length = "0x148")]
	[Token(Token = "0x600039E")]
	public static SteamAPICall_t FileShare(string pchFile) { }

	[Address(RVA = "0x5FCB30", Offset = "0x5FBF30", Length = "0x13D")]
	[Token(Token = "0x6000397")]
	public static bool FileWrite(string pchFile, Byte[] pvData, int cubData) { }

	[Address(RVA = "0x5FC750", Offset = "0x5FBB50", Length = "0x162")]
	[Token(Token = "0x6000399")]
	public static SteamAPICall_t FileWriteAsync(string pchFile, Byte[] pvData, uint cubData) { }

	[Address(RVA = "0x5FC8C0", Offset = "0x5FBCC0", Length = "0x4E")]
	[Token(Token = "0x60003A3")]
	public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle) { }

	[Address(RVA = "0x5FC910", Offset = "0x5FBD10", Length = "0x4E")]
	[Token(Token = "0x60003A2")]
	public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle) { }

	[Address(RVA = "0x5FC960", Offset = "0x5FBD60", Length = "0x148")]
	[Token(Token = "0x60003A0")]
	public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile) { }

	[Address(RVA = "0x5FCAB0", Offset = "0x5FBEB0", Length = "0x74")]
	[Token(Token = "0x60003A1")]
	public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, Byte[] pvData, int cubData) { }

	[Address(RVA = "0x5FCC70", Offset = "0x5FC070", Length = "0x44")]
	[Token(Token = "0x60003B3")]
	public static int GetCachedUGCCount() { }

	[Address(RVA = "0x5FCCC0", Offset = "0x5FC0C0", Length = "0x8A")]
	[Token(Token = "0x60003B4")]
	public static UGCHandle_t GetCachedUGCHandle(int iCachedContent) { }

	[Address(RVA = "0x5FCD50", Offset = "0x5FC150", Length = "0x44")]
	[Token(Token = "0x60003A9")]
	public static int GetFileCount() { }

	[Address(RVA = "0x5FCDA0", Offset = "0x5FC1A0", Length = "0x65")]
	[Token(Token = "0x60003AA")]
	public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes) { }

	[Address(RVA = "0x5FCE10", Offset = "0x5FC210", Length = "0x115")]
	[Token(Token = "0x60003A6")]
	public static int GetFileSize(string pchFile) { }

	[Address(RVA = "0x5FCF30", Offset = "0x5FC330", Length = "0x11A")]
	[Token(Token = "0x60003A7")]
	public static long GetFileTimestamp(string pchFile) { }

	[Address(RVA = "0x5FD0A0", Offset = "0x5FC4A0", Length = "0x7B")]
	[Token(Token = "0x60003CF")]
	public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	[Address(RVA = "0x5FD050", Offset = "0x5FC450", Length = "0x44")]
	[Token(Token = "0x60003CE")]
	public static int GetLocalFileChangeCount() { }

	[Address(RVA = "0x5FD120", Offset = "0x5FC520", Length = "0x9A")]
	[Token(Token = "0x60003BE")]
	public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	[Address(RVA = "0x5FD1C0", Offset = "0x5FC5C0", Length = "0x8C")]
	[Token(Token = "0x60003C5")]
	public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FD250", Offset = "0x5FC650", Length = "0x5D")]
	[Token(Token = "0x60003AB")]
	public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	[Address(RVA = "0x5FD2B0", Offset = "0x5FC6B0", Length = "0x115")]
	[Token(Token = "0x60003A8")]
	public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile) { }

	[Address(RVA = "0x5FD3D0", Offset = "0x5FC7D0", Length = "0xBB")]
	[Token(Token = "0x60003B1")]
	public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	[Address(RVA = "0x5FD490", Offset = "0x5FC890", Length = "0x74")]
	[Token(Token = "0x60003B0")]
	public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	[Address(RVA = "0x5FD510", Offset = "0x5FC910", Length = "0x8C")]
	[Token(Token = "0x60003C7")]
	public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FD5A0", Offset = "0x5FC9A0", Length = "0x44")]
	[Token(Token = "0x60003AC")]
	public static bool IsCloudEnabledForAccount() { }

	[Address(RVA = "0x5FD5F0", Offset = "0x5FC9F0", Length = "0x44")]
	[Token(Token = "0x60003AD")]
	public static bool IsCloudEnabledForApp() { }

	[Address(RVA = "0x5FD640", Offset = "0x5FCA40", Length = "0x430")]
	[Token(Token = "0x60003C9")]
	public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<String> pTags) { }

	[Address(RVA = "0x5FDA80", Offset = "0x5FCE80", Length = "0x39B")]
	[Token(Token = "0x60003B5")]
	public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<String> pTags, EWorkshopFileType eWorkshopFileType) { }

	[Address(RVA = "0x5FDE20", Offset = "0x5FD220", Length = "0x4E")]
	[Token(Token = "0x60003AE")]
	public static void SetCloudEnabledForApp(bool bEnabled) { }

	[Address(RVA = "0x5FDE70", Offset = "0x5FD270", Length = "0x124")]
	[Token(Token = "0x600039F")]
	public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	[Address(RVA = "0x5FDFA0", Offset = "0x5FD3A0", Length = "0x9A")]
	[Token(Token = "0x60003CA")]
	public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	[Address(RVA = "0x5FE040", Offset = "0x5FD440", Length = "0x8C")]
	[Token(Token = "0x60003C1")]
	public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FE240", Offset = "0x5FD640", Length = "0x9A")]
	[Token(Token = "0x60003AF")]
	public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority) { }

	[Address(RVA = "0x5FE0D0", Offset = "0x5FD4D0", Length = "0x162")]
	[Token(Token = "0x60003CD")]
	public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority) { }

	[Address(RVA = "0x5FE2E0", Offset = "0x5FD6E0", Length = "0x8D")]
	[Token(Token = "0x60003B2")]
	public static int UGCRead(UGCHandle_t hContent, Byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	[Address(RVA = "0x5FE370", Offset = "0x5FD770", Length = "0x8C")]
	[Token(Token = "0x60003C3")]
	public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	[Address(RVA = "0x5FE400", Offset = "0x5FD800", Length = "0x125")]
	[Token(Token = "0x60003BA")]
	public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription) { }

	[Address(RVA = "0x5FE530", Offset = "0x5FD930", Length = "0x125")]
	[Token(Token = "0x60003B7")]
	public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile) { }

	[Address(RVA = "0x5FE660", Offset = "0x5FDA60", Length = "0x125")]
	[Token(Token = "0x60003B8")]
	public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile) { }

	[Address(RVA = "0x5FE790", Offset = "0x5FDB90", Length = "0x125")]
	[Token(Token = "0x60003C4")]
	public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription) { }

	[Address(RVA = "0x5FE8C0", Offset = "0x5FDCC0", Length = "0xB8")]
	[Token(Token = "0x60003BC")]
	public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<String> pTags) { }

	[Address(RVA = "0x5FE980", Offset = "0x5FDD80", Length = "0x125")]
	[Token(Token = "0x60003B9")]
	public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle) { }

	[Address(RVA = "0x5FEAB0", Offset = "0x5FDEB0", Length = "0x5C")]
	[Token(Token = "0x60003BB")]
	public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	[Address(RVA = "0x5FEB10", Offset = "0x5FDF10", Length = "0x9C")]
	[Token(Token = "0x60003C6")]
	public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

}

