namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D9")]
internal static class XblInterop
{
	[Token(Token = "0x20002DA")]
	public sealed class XblAchievementsProgressChangeHandler : MulticastDelegate
	{

		[Address(RVA = "0xF76CF0", Offset = "0xF760F0", Length = "0xA6")]
		[Token(Token = "0x600111F")]
		public XblAchievementsProgressChangeHandler(object object, IntPtr method) { }

		[Address(RVA = "0x2BA63F0", Offset = "0x2BA57F0", Length = "0x97")]
		[Token(Token = "0x6001121")]
		public override IAsyncResult BeginInvoke(XblAchievementProgressChangeEventArgs eventArgs, IntPtr context, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001122")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0xF769C0", Offset = "0xF75DC0", Length = "0x24")]
		[Token(Token = "0x6001120")]
		public override void Invoke(XblAchievementProgressChangeEventArgs eventArgs, IntPtr context) { }

	}

	[Token(Token = "0x20002DD")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	public sealed class XblMultiplayerConnectionIdChangedHandler : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x600112B")]
		public XblMultiplayerConnectionIdChangedHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x600112D")]
		public override IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600112E")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600112C")]
		public override void Invoke(IntPtr context) { }

	}

	[Token(Token = "0x20002DB")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	public sealed class XblMultiplayerSessionChangedHandler : MulticastDelegate
	{

		[Address(RVA = "0x2BB6B00", Offset = "0x2BB5F00", Length = "0xA6")]
		[Token(Token = "0x6001123")]
		public XblMultiplayerSessionChangedHandler(object object, IntPtr method) { }

		[Address(RVA = "0x2BB69C0", Offset = "0x2BB5DC0", Length = "0x97")]
		[Token(Token = "0x6001125")]
		public override IAsyncResult BeginInvoke(IntPtr context, XblMultiplayerSessionChangeEventArgs args, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001126")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x2BB6A60", Offset = "0x2BB5E60", Length = "0x96")]
		[Token(Token = "0x6001124")]
		public override void Invoke(IntPtr context, XblMultiplayerSessionChangeEventArgs args) { }

	}

	[Token(Token = "0x20002DC")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	public sealed class XblMultiplayerSessionSubscriptionLostHandler : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6001127")]
		public XblMultiplayerSessionSubscriptionLostHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6001129")]
		public override IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600112A")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001128")]
		public override void Invoke(IntPtr context) { }

	}

	[Token(Token = "0x20002DE")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	public sealed class XblStatisticChangedHandler : MulticastDelegate
	{

		[Address(RVA = "0x2BB8C10", Offset = "0x2BB8010", Length = "0xA6")]
		[Token(Token = "0x600112F")]
		public XblStatisticChangedHandler(object object, IntPtr method) { }

		[Address(RVA = "0x2BB8B20", Offset = "0x2BB7F20", Length = "0x97")]
		[Token(Token = "0x6001131")]
		public override IAsyncResult BeginInvoke(XblStatisticChangeEventArgs statisticChangeEventArgs, IntPtr context, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001132")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x2BB8BC0", Offset = "0x2BB7FC0", Length = "0x4A")]
		[Token(Token = "0x6001130")]
		public override void Invoke(XblStatisticChangeEventArgs statisticChangeEventArgs, IntPtr context) { }

	}

	[Token(Token = "0x40007B9")]
	public const string XblThunkDllName = "Microsoft.Xbox.Services.GDK.C.Thunks"; //Field offset: 0x0
	[Token(Token = "0x40007D4")]
	internal const int XBL_TITLE_STORAGE_BLOB_PATH_MAX_LENGTH = 771; //Field offset: 0x0
	[Token(Token = "0x40007D3")]
	internal const int XBL_TITLE_STORAGE_DEFAULT_DOWNLOAD_BLOCK_SIZE = 1048576; //Field offset: 0x0
	[Token(Token = "0x40007D2")]
	internal const int XBL_TITLE_STORAGE_MIN_DOWNLOAD_BLOCK_SIZE = 1024; //Field offset: 0x0
	[Token(Token = "0x40007D1")]
	internal const int XBL_TITLE_STORAGE_DEFAULT_UPLOAD_BLOCK_SIZE = 262144; //Field offset: 0x0
	[Token(Token = "0x40007D0")]
	internal const int XBL_TITLE_STORAGE_MAX_UPLOAD_BLOCK_SIZE = 4194304; //Field offset: 0x0
	[Token(Token = "0x40007CF")]
	internal const int XBL_TITLE_STORAGE_MIN_UPLOAD_BLOCK_SIZE = 1024; //Field offset: 0x0
	[Token(Token = "0x40007CE")]
	internal const int XBL_MULTIPLAYER_SEARCH_HANDLE_MAX_FIELD_LENGTH = 100; //Field offset: 0x0
	[Token(Token = "0x40007CD")]
	internal const int XBL_MULTIPLAYER_SESSION_REFERENCE_URI_MAX_LENGTH = 284; //Field offset: 0x0
	[Token(Token = "0x40007CC")]
	internal const int XBL_MULTIPLAYER_SESSION_NAME_MAX_LENGTH = 100; //Field offset: 0x0
	[Token(Token = "0x40007CB")]
	internal const int XBL_MULTIPLAYER_SESSION_TEMPLATE_NAME_MAX_LENGTH = 100; //Field offset: 0x0
	[Token(Token = "0x40007CA")]
	internal const int XBL_SOCIAL_MANAGER_MAX_AFFECTED_USERS_PER_EVENT = 10; //Field offset: 0x0
	[Token(Token = "0x40007C9")]
	internal const int XBL_SCID_LENGTH = 40; //Field offset: 0x0
	[Token(Token = "0x40007C8")]
	internal const int XBL_GUID_LENGTH = 40; //Field offset: 0x0
	[Token(Token = "0x40007C7")]
	internal const int XBL_XBOX_USER_ID_CHAR_SIZE = 63; //Field offset: 0x0
	[Token(Token = "0x40007C6")]
	internal const int XBL_TITLE_NAME_CHAR_SIZE = 300; //Field offset: 0x0
	[Token(Token = "0x40007C5")]
	internal const int XBL_RICH_PRESENCE_CHAR_SIZE = 300; //Field offset: 0x0
	[Token(Token = "0x40007C4")]
	internal const int XBL_REAL_NAME_CHAR_SIZE = 765; //Field offset: 0x0
	[Token(Token = "0x40007C3")]
	internal const int XBL_NUM_PRESENCE_RECORDS = 6; //Field offset: 0x0
	[Token(Token = "0x40007C2")]
	internal const int XBL_UNIQUE_MODERN_GAMERTAG_CHAR_SIZE = 101; //Field offset: 0x0
	[Token(Token = "0x40007C1")]
	internal const int XBL_MODERN_GAMERTAG_SUFFIX_CHAR_SIZE = 15; //Field offset: 0x0
	[Token(Token = "0x40007C0")]
	internal const int XBL_MODERN_GAMERTAG_CHAR_SIZE = 97; //Field offset: 0x0
	[Token(Token = "0x40007BF")]
	internal const int XBL_GAMERTAG_CHAR_SIZE = 48; //Field offset: 0x0
	[Token(Token = "0x40007BE")]
	internal const int XBL_GAMERSCORE_CHAR_SIZE = 48; //Field offset: 0x0
	[Token(Token = "0x40007BD")]
	internal const int XBL_DISPLAY_PIC_URL_RAW_CHAR_SIZE = 675; //Field offset: 0x0
	[Token(Token = "0x40007BC")]
	internal const int XBL_DISPLAY_NAME_CHAR_SIZE = 90; //Field offset: 0x0
	[Token(Token = "0x40007BB")]
	internal const int XBL_COLOR_CHAR_SIZE = 21; //Field offset: 0x0
	[Token(Token = "0x40007BA")]
	public const string HttpClientGdkDll = "libHttpClient.GDK"; //Field offset: 0x0
	[Token(Token = "0x40007D5")]
	internal const int XBL_TITLE_STORAGE_BLOB_DISPLAY_NAME_MAX_LENGTH = 387; //Field offset: 0x0
	[Token(Token = "0x40007D6")]
	internal const int XBL_TITLE_STORAGE_BLOB_ETAG_MAX_LENGTH = 54; //Field offset: 0x0

	[Address(RVA = "0x2BA64E0", Offset = "0x2BA58E0", Length = "0x78")]
	[Token(Token = "0x6000FD8")]
	internal static int HCSettingsGetTraceLevel(out HCTraceLevel traceLevel) { }

	[Address(RVA = "0x2BA6560", Offset = "0x2BA5960", Length = "0x76")]
	[Token(Token = "0x6000FD7")]
	internal static int HCSettingsSetTraceLevel(HCTraceLevel traceLevel) { }

	[Address(RVA = "0x2BA65E0", Offset = "0x2BA59E0", Length = "0x82")]
	[Token(Token = "0x6000FD9")]
	internal static void HCTraceSetClientCallback(HCTraceCallback callback) { }

	[Address(RVA = "0x2BA6670", Offset = "0x2BA5A70", Length = "0x78")]
	[Token(Token = "0x6000FDA")]
	internal static void HCTraceSetTraceToDebugger(bool traceToDebugger) { }

	[Address(RVA = "0x2BA66F0", Offset = "0x2BA5AF0", Length = "0xA0")]
	[Token(Token = "0x6000FC8")]
	internal static XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(IntPtr xblContext, XblAchievementsProgressChangeHandler handler, IntPtr handlerContext) { }

	[Address(RVA = "0x2BA6790", Offset = "0x2BA5B90", Length = "0xC8")]
	[Token(Token = "0x6000FC6")]
	internal static int XblAchievementsGetAchievementAsync(IntPtr xboxLiveContext, ulong xboxUserId, Byte[] serviceConfigurationId, Byte[] achievementId, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA6860", Offset = "0x2BA5C60", Length = "0x87")]
	[Token(Token = "0x6000FC7")]
	internal static int XblAchievementsGetAchievementResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle result) { }

	[Address(RVA = "0x2BA68F0", Offset = "0x2BA5CF0", Length = "0xE3")]
	[Token(Token = "0x6000FC2")]
	internal static int XblAchievementsGetAchievementsForTitleIdAsync(IntPtr xboxLiveContext, ulong xboxUserId, uint titleId, XblAchievementType type, bool unlockedOnly, XblAchievementOrderBy orderBy, uint skipItems, uint maxItems, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA69E0", Offset = "0x2BA5DE0", Length = "0x87")]
	[Token(Token = "0x6000FC3")]
	internal static int XblAchievementsGetAchievementsForTitleIdResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle result) { }

	[Address(RVA = "0x2BA6A70", Offset = "0x2BA5E70", Length = "0xD2")]
	[Token(Token = "0x6000FCF")]
	internal static int XblAchievementsManagerAddLocalUser(IntPtr user, XTaskQueueHandle queue) { }

	[Address(RVA = "0x2BA6B50", Offset = "0x2BA5F50", Length = "0x87")]
	[Token(Token = "0x6000FD2")]
	internal static int XblAchievementsManagerDoWork(out IntPtr achievementsEvents, out SizeT achievementsEventsCount) { }

	[Address(RVA = "0x2BA6BE0", Offset = "0x2BA5FE0", Length = "0x9D")]
	[Token(Token = "0x6000FD3")]
	internal static int XblAchievementsManagerGetAchievement(ulong xboxUserId, Byte[] achievementId, out XblAchievementsManagerResultHandle achievementResult) { }

	[Address(RVA = "0x2BA6D30", Offset = "0x2BA6130", Length = "0xA0")]
	[Token(Token = "0x6000FD4")]
	internal static int XblAchievementsManagerGetAchievements(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, out XblAchievementsManagerResultHandle achievementsResult) { }

	[Address(RVA = "0x2BA6C80", Offset = "0x2BA6080", Length = "0xB0")]
	[Token(Token = "0x6000FD5")]
	internal static int XblAchievementsManagerGetAchievementsByState(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, XblAchievementProgressState achievementState, out XblAchievementsManagerResultHandle achievementResult) { }

	[Address(RVA = "0x2BA6DD0", Offset = "0x2BA61D0", Length = "0x78")]
	[Token(Token = "0x6000FD1")]
	internal static int XblAchievementsManagerIsUserInitialized(ulong xboxUserId) { }

	[Address(RVA = "0x2BA6E50", Offset = "0x2BA6250", Length = "0x78")]
	[Token(Token = "0x6000FD0")]
	internal static int XblAchievementsManagerRemoveLocalUser(IntPtr user) { }

	[Address(RVA = "0x2BA6ED0", Offset = "0x2BA62D0", Length = "0x78")]
	[Token(Token = "0x6000FCE")]
	internal static void XblAchievementsManagerResultCloseHandle(IntPtr handle) { }

	[Address(RVA = "0x2BA6F50", Offset = "0x2BA6350", Length = "0x87")]
	[Token(Token = "0x6000FCD")]
	internal static int XblAchievementsManagerResultDuplicateHandle(IntPtr handle, out XblAchievementsManagerResultHandle duplicatedHandle) { }

	[Address(RVA = "0x2BA6FE0", Offset = "0x2BA63E0", Length = "0x93")]
	[Token(Token = "0x6000FCC")]
	internal static int XblAchievementsManagerResultGetAchievements(IntPtr resultHandle, out IntPtr achievements, out ulong achievementsCount) { }

	[Address(RVA = "0x2BA7080", Offset = "0x2BA6480", Length = "0x9F")]
	[Token(Token = "0x6000FD6")]
	internal static int XblAchievementsManagerUpdateAchievement(ulong xboxUserId, Byte[] achievementId, byte currentProgress) { }

	[Address(RVA = "0x2BA7120", Offset = "0x2BA6520", Length = "0x85")]
	[Token(Token = "0x6000FC9")]
	internal static void XblAchievementsRemoveAchievementProgressChangeHandler(IntPtr xblContextHandle, XblFunctionContext functionContext) { }

	[Address(RVA = "0x2BA71B0", Offset = "0x2BA65B0", Length = "0x78")]
	[Token(Token = "0x6000FCB")]
	internal static void XblAchievementsResultCloseHandle(IntPtr handle) { }

	[Address(RVA = "0x2BA7230", Offset = "0x2BA6630", Length = "0x87")]
	[Token(Token = "0x6000FCA")]
	internal static int XblAchievementsResultDuplicateHandle(IntPtr handle, out XblAchievementsResultHandle duplicatedHandle) { }

	[Address(RVA = "0x2BA72C0", Offset = "0x2BA66C0", Length = "0x93")]
	[Token(Token = "0x6000FBE")]
	internal static int XblAchievementsResultGetAchievements(IntPtr resultHandle, out IntPtr achievements, out SizeT achievementsCount) { }

	[Address(RVA = "0x2BA7360", Offset = "0x2BA6760", Length = "0x91")]
	[Token(Token = "0x6000FC0")]
	internal static int XblAchievementsResultGetNextAsync(IntPtr resultHandle, uint maxItems, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA7400", Offset = "0x2BA6800", Length = "0x87")]
	[Token(Token = "0x6000FC1")]
	internal static int XblAchievementsResultGetNextResult(XAsyncBlockPtr asyncBlock, out XblAchievementsResultHandle resultHandle) { }

	[Address(RVA = "0x2BA7490", Offset = "0x2BA6890", Length = "0x87")]
	[Token(Token = "0x6000FBF")]
	internal static int XblAchievementsResultHasNext(IntPtr resultHandle, out bool hasNext) { }

	[Address(RVA = "0x2BA7520", Offset = "0x2BA6920", Length = "0xBC")]
	[Token(Token = "0x6000FC4")]
	internal static int XblAchievementsUpdateAchievementAsync(IntPtr xboxLiveContext, ulong xboxUserId, Byte[] achievementId, uint percentComplete, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA75E0", Offset = "0x2BA69E0", Length = "0xE1")]
	[Token(Token = "0x6000FC5")]
	internal static int XblAchievementsUpdateAchievementForTitleIdAsync(IntPtr xboxLiveContext, ulong xboxUserId, uint titleId, Byte[] serviceConfigurationId, Byte[] achievementId, uint percentComplete, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA76D0", Offset = "0x2BA6AD0", Length = "0x78")]
	[Token(Token = "0x600111E")]
	internal static int XblCleanupAsync(XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA7750", Offset = "0x2BA6B50", Length = "0x78")]
	[Token(Token = "0x6001119")]
	internal static void XblContextCloseHandle(IntPtr xboxLiveContextHandle) { }

	[Address(RVA = "0x2BA77D0", Offset = "0x2BA6BD0", Length = "0x87")]
	[Token(Token = "0x6001118")]
	internal static int XblContextCreateHandle(IntPtr user, out XblContextHandle context) { }

	[Address(RVA = "0x2BA7860", Offset = "0x2BA6C60", Length = "0xBC")]
	[Token(Token = "0x600111B")]
	internal static int XblEventsWriteInGameEvent(IntPtr xboxLiveContext, Byte[] eventName, Byte[] dimensionsJson, Byte[] measurementsJson) { }

	[Address(RVA = "0x2BA7920", Offset = "0x2BA6D20", Length = "0x91")]
	[Token(Token = "0x6001025")]
	public static int XblFormatSecureDeviceAddress(Byte[] deviceId, out XblFormattedSecureDeviceAddress address) { }

	[Address(RVA = "0x2BA79C0", Offset = "0x2BA6DC0", Length = "0x76")]
	[Token(Token = "0x600111A")]
	internal static XblErrorCondition XblGetErrorCondition(int hr) { }

	[Address(RVA = "0x2BA7A40", Offset = "0x2BA6E40", Length = "0x78")]
	[Token(Token = "0x6000FE1")]
	internal static void XblHttpCallCloseHandle(IntPtr call) { }

	[Address(RVA = "0x2BA7AC0", Offset = "0x2BA6EC0", Length = "0xB4")]
	[Token(Token = "0x6000FE0")]
	internal static int XblHttpCallCreate(IntPtr xblContext, Byte[] method, Byte[] url, out XblHttpCallHandle call) { }

	[Address(RVA = "0x2BA7B80", Offset = "0x2BA6F80", Length = "0x87")]
	[Token(Token = "0x6000FEA")]
	internal static int XblHttpCallDuplicateHandle(IntPtr call, out XblHttpCallHandle duplicateHandle) { }

	[Address(RVA = "0x2BA7CB0", Offset = "0x2BA70B0", Length = "0x9D")]
	[Token(Token = "0x6000FED")]
	internal static int XblHttpCallGetHeader(IntPtr call, Byte[] headerName, out UTF8StringPtr headerValue) { }

	[Address(RVA = "0x2BA7C10", Offset = "0x2BA7010", Length = "0xA0")]
	[Token(Token = "0x6000FE4")]
	internal static int XblHttpCallGetHeaderAtIndex(IntPtr call, uint headerIndex, out UTF8StringPtr headerName, out UTF8StringPtr headerValue) { }

	[Address(RVA = "0x2BA7D50", Offset = "0x2BA7150", Length = "0x93")]
	[Token(Token = "0x6000FDC")]
	internal static int XblHttpCallGetNetworkErrorCode(IntPtr call, out int networkErrorCode, out uint platformNetworkErrorCode) { }

	[Address(RVA = "0x2BA7DF0", Offset = "0x2BA71F0", Length = "0x87")]
	[Token(Token = "0x6000FEB")]
	internal static int XblHttpCallGetNumHeaders(IntPtr call, out uint numHeaders) { }

	[Address(RVA = "0x2BA7E80", Offset = "0x2BA7280", Length = "0x87")]
	[Token(Token = "0x6000FE6")]
	internal static int XblHttpCallGetPlatformNetworkErrorMessage(IntPtr call, out UTF8StringPtr platformNetworkErrorMessage) { }

	[Address(RVA = "0x2BA7F10", Offset = "0x2BA7310", Length = "0x87")]
	[Token(Token = "0x6000FEE")]
	internal static int XblHttpCallGetRequestUrl(IntPtr call, out UTF8StringPtr url) { }

	[Address(RVA = "0x2BA8030", Offset = "0x2BA7430", Length = "0x113")]
	[Token(Token = "0x6000FE7")]
	internal static int XblHttpCallGetResponseBodyBytes(IntPtr call, SizeT bufferSize, out Byte[] buffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA7FA0", Offset = "0x2BA73A0", Length = "0x87")]
	[Token(Token = "0x6000FE5")]
	internal static int XblHttpCallGetResponseBodyBytesSize(IntPtr call, out SizeT bufferSize) { }

	[Address(RVA = "0x2BA8150", Offset = "0x2BA7550", Length = "0x87")]
	[Token(Token = "0x6000FE3")]
	internal static int XblHttpCallGetResponseString(IntPtr call, out UTF8StringPtr responseString) { }

	[Address(RVA = "0x2BA81E0", Offset = "0x2BA75E0", Length = "0x87")]
	[Token(Token = "0x6000FEC")]
	internal static int XblHttpCallGetStatusCode(IntPtr call, out uint statusCode) { }

	[Address(RVA = "0x2BA8270", Offset = "0x2BA7670", Length = "0x91")]
	[Token(Token = "0x6000FDE")]
	internal static int XblHttpCallPerformAsync(IntPtr call, XblHttpCallResponseBodyType type, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA8310", Offset = "0x2BA7710", Length = "0xB6")]
	[Token(Token = "0x6000FE9")]
	internal static int XblHttpCallRequestSetHeader(IntPtr call, Byte[] headerName, Byte[] headerValue, NativeBool allowTracing) { }

	[Address(RVA = "0x2BA83D0", Offset = "0x2BA77D0", Length = "0x87")]
	[Token(Token = "0x6000FDD")]
	internal static int XblHttpCallRequestSetLongHttpCall(IntPtr call, NativeBool longHttpCall) { }

	[Address(RVA = "0x2BA8460", Offset = "0x2BA7860", Length = "0x9D")]
	[Token(Token = "0x6000FDB")]
	internal static int XblHttpCallRequestSetRequestBodyBytes(IntPtr call, Byte[] requestBodyBytes, uint requestBodySize) { }

	[Address(RVA = "0x2BA8500", Offset = "0x2BA7900", Length = "0x91")]
	[Token(Token = "0x6000FE2")]
	internal static int XblHttpCallRequestSetRequestBodyString(IntPtr call, Byte[] requestBodyString) { }

	[Address(RVA = "0x2BA85A0", Offset = "0x2BA79A0", Length = "0x87")]
	[Token(Token = "0x6000FE8")]
	internal static int XblHttpCallRequestSetRetryAllowed(IntPtr call, NativeBool retryAllowed) { }

	[Address(RVA = "0x2BA8630", Offset = "0x2BA7A30", Length = "0x85")]
	[Token(Token = "0x6000FEF")]
	internal static int XblHttpCallRequestSetRetryCacheId(IntPtr call, uint retryAfterCacheId) { }

	[Address(RVA = "0x2BA86C0", Offset = "0x2BA7AC0", Length = "0x87")]
	[Token(Token = "0x6000FDF")]
	internal static int XblHttpCallSetTracing(IntPtr call, NativeBool traceCall) { }

	[Address(RVA = "0x2BA8750", Offset = "0x2BA7B50", Length = "0xF7")]
	[Token(Token = "0x6000FF0")]
	internal static int XblLeaderboardGetLeaderboardAsync(IntPtr xboxLiveContext, XblLeaderboardQuery leaderboardQuery, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA88E0", Offset = "0x2BA7CE0", Length = "0xB2")]
	[Token(Token = "0x6000FF2")]
	internal static int XblLeaderboardGetLeaderboardResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA8850", Offset = "0x2BA7C50", Length = "0x87")]
	[Token(Token = "0x6000FF1")]
	internal static int XblLeaderboardGetLeaderboardResultSize(XAsyncBlockPtr asyncBlockPtr, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BA89A0", Offset = "0x2BA7DA0", Length = "0xA2")]
	[Token(Token = "0x6000FF3")]
	internal static int XblLeaderboardResultGetNextAsync(IntPtr xboxLiveContext, in XblLeaderboardResult leaderboardResult, uint maxItems, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA8AE0", Offset = "0x2BA7EE0", Length = "0xB2")]
	[Token(Token = "0x6000FF5")]
	internal static int XblLeaderboardResultGetNextResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA8A50", Offset = "0x2BA7E50", Length = "0x87")]
	[Token(Token = "0x6000FF4")]
	internal static int XblLeaderboardResultGetNextResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BA8BA0", Offset = "0x2BA7FA0", Length = "0x187")]
	[Token(Token = "0x6000FF6")]
	internal static int XblMatchmakingCreateMatchTicketAsync(IntPtr xboxLiveContext, XblMultiplayerSessionReference ticketSessionReference, Byte[] matchmakingServiceConfigurationId, Byte[] hopperName, ulong ticketTimeout, XblPreserveSessionMode preserveSession, Byte[] ticketAttributesJson, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA8D30", Offset = "0x2BA8130", Length = "0x2CF")]
	[Token(Token = "0x6000FF7")]
	internal static int XblMatchmakingCreateMatchTicketResult(XAsyncBlockPtr async, out XblCreateMatchTicketResponse resultPtr) { }

	[Address(RVA = "0x2BA9000", Offset = "0x2BA8400", Length = "0xD0")]
	[Token(Token = "0x6000FF8")]
	internal static int XblMatchmakingDeleteMatchTicketAsync(IntPtr xboxLiveContext, Byte[] serviceConfigurationId, Byte[] hopperName, Byte[] ticketId, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA90D0", Offset = "0x2BA84D0", Length = "0xB4")]
	[Token(Token = "0x6000FFC")]
	internal static int XblMatchmakingGetHopperStatisticsAsync(IntPtr xboxLiveContext, Byte[] serviceConfigurationId, Byte[] hopperName, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA9220", Offset = "0x2BA8620", Length = "0xB2")]
	[Token(Token = "0x6000FFE")]
	internal static int XblMatchmakingGetHopperStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA9190", Offset = "0x2BA8590", Length = "0x87")]
	[Token(Token = "0x6000FFD")]
	internal static int XblMatchmakingGetHopperStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BA92E0", Offset = "0x2BA86E0", Length = "0xD0")]
	[Token(Token = "0x6000FF9")]
	internal static int XblMatchmakingGetMatchTicketDetailsAsync(IntPtr xboxLiveContext, Byte[] serviceConfigurationId, Byte[] hopperName, Byte[] ticketId, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA9440", Offset = "0x2BA8840", Length = "0xB2")]
	[Token(Token = "0x6000FFB")]
	internal static int XblMatchmakingGetMatchTicketDetailsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA93B0", Offset = "0x2BA87B0", Length = "0x87")]
	[Token(Token = "0x6000FFA")]
	internal static int XblMatchmakingGetMatchTicketDetailsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BA9500", Offset = "0x2BA8900", Length = "0x87")]
	[Token(Token = "0x6001068")]
	internal static int XblMultiplayerActivityDeleteActivityAsync(IntPtr xboxLiveContext, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9590", Offset = "0x2BA8990", Length = "0x87")]
	[Token(Token = "0x6001063")]
	internal static int XblMultiplayerActivityFlushRecentPlayersAsync(IntPtr xboxLiveContext, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9620", Offset = "0x2BA8A20", Length = "0xAC")]
	[Token(Token = "0x6001065")]
	internal static int XblMultiplayerActivityGetActivityAsync(IntPtr xboxLiveContext, in UInt64[] xboxUserIdList, SizeT xboxUserIdListCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9760", Offset = "0x2BA8B60", Length = "0xBF")]
	[Token(Token = "0x6001067")]
	internal static int XblMultiplayerActivityGetActivityResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBufferResults, out SizeT resultCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BA96D0", Offset = "0x2BA8AD0", Length = "0x87")]
	[Token(Token = "0x6001066")]
	internal static int XblMultiplayerActivityGetActivityResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BA9820", Offset = "0x2BA8C20", Length = "0xDA")]
	[Token(Token = "0x6001069")]
	internal static int XblMultiplayerActivitySendInvitesAsync(IntPtr xblContext, in UInt64[] xboxUserIdList, SizeT xboxUserIdListCount, bool allowCrossPlatformJoin, Byte[] connectionString, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9900", Offset = "0x2BA8D00", Length = "0xA4")]
	[Token(Token = "0x6001064")]
	internal static int XblMultiplayerActivitySetActivityAsync(IntPtr xboxLiveContext, in XblMultiplayerActivityInfo activityInfo, bool allowCrossPlatformJoin, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA99B0", Offset = "0x2BA8DB0", Length = "0x9D")]
	[Token(Token = "0x6001062")]
	internal static int XblMultiplayerActivityUpdateRecentPlayers(IntPtr xboxLiveContext, XblMultiplayerActivityRecentPlayerUpdate[] updates, SizeT updatesCount) { }

	[Address(RVA = "0x2BA9A50", Offset = "0x2BA8E50", Length = "0xA0")]
	[Token(Token = "0x6001060")]
	internal static XblFunctionContext XblMultiplayerAddConnectionIdChangedHandler(IntPtr xblContext, XblMultiplayerConnectionIdChangedHandler handler, IntPtr context) { }

	[Address(RVA = "0x2BA9AF0", Offset = "0x2BA8EF0", Length = "0xA0")]
	[Token(Token = "0x6001059")]
	internal static XblFunctionContext XblMultiplayerAddSessionChangedHandler(IntPtr xblContext, XblMultiplayerSessionChangedHandler handler, IntPtr context) { }

	[Address(RVA = "0x2BA9B90", Offset = "0x2BA8F90", Length = "0xA0")]
	[Token(Token = "0x600105B")]
	internal static XblFunctionContext XblMultiplayerAddSubscriptionLostHandler(IntPtr xblContext, XblMultiplayerSessionSubscriptionLostHandler handler, IntPtr context) { }

	[Address(RVA = "0x2BA9C30", Offset = "0x2BA9030", Length = "0x9D")]
	[Token(Token = "0x6001040")]
	internal static int XblMultiplayerClearActivityAsync(IntPtr xblContext, Byte[] scid, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9CD0", Offset = "0x2BA90D0", Length = "0x10E")]
	[Token(Token = "0x6001043")]
	internal static int XblMultiplayerCreateSearchHandleAsync(IntPtr xblContext, in XblMultiplayerSessionReference sessionRef, XblMultiplayerSessionTag[] tags, SizeT tagsCount, XblMultiplayerSessionNumberAttribute[] numberAttributes, SizeT numberAttributesCount, XblMultiplayerSessionStringAttribute[] stringAttributes, SizeT stringAttributesCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9DE0", Offset = "0x2BA91E0", Length = "0x87")]
	[Token(Token = "0x6001044")]
	public static int XblMultiplayerCreateSearchHandleResult(XAsyncBlockPtr async, out XblMultiplayerSearchHandle handle) { }

	[Address(RVA = "0x2BA9E70", Offset = "0x2BA9270", Length = "0x9D")]
	[Token(Token = "0x6001045")]
	public static int XblMultiplayerDeleteSearchHandleAsync(IntPtr xblContext, Byte[] handleId, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BA9F10", Offset = "0x2BA9310", Length = "0x93")]
	[Token(Token = "0x600106D")]
	internal static int XblMultiplayerEventArgsFindMatchCompleted(IntPtr argsHandle, out XblMultiplayerMatchStatus matchStatus, out XblMultiplayerMeasurementFailure initializationFailureCause) { }

	[Address(RVA = "0x2BA9FB0", Offset = "0x2BA93B0", Length = "0x87")]
	[Token(Token = "0x600108D")]
	internal static int XblMultiplayerEventArgsMember(IntPtr argsHandle, out XblMultiplayerManagerMember member) { }

	[Address(RVA = "0x2BAA0D0", Offset = "0x2BA94D0", Length = "0x132")]
	[Token(Token = "0x6001094")]
	internal static int XblMultiplayerEventArgsMembers(IntPtr argsHandle, SizeT membersCount, out XblMultiplayerManagerMember[] members) { }

	[Address(RVA = "0x2BAA040", Offset = "0x2BA9440", Length = "0x87")]
	[Token(Token = "0x6001074")]
	internal static int XblMultiplayerEventArgsMembersCount(IntPtr argsHandle, out SizeT memberCount) { }

	[Address(RVA = "0x2BAA210", Offset = "0x2BA9610", Length = "0x87")]
	[Token(Token = "0x60010A7")]
	internal static int XblMultiplayerEventArgsPerformQoSMeasurements(IntPtr argsHandle, out XblMultiplayerPerformQoSMeasurementsArgs performQoSMeasurementsArgs) { }

	[Address(RVA = "0x2BAA2A0", Offset = "0x2BA96A0", Length = "0x87")]
	[Token(Token = "0x6001077")]
	internal static int XblMultiplayerEventArgsPropertiesJson(IntPtr argsHandle, out UTF8StringPtr properties) { }

	[Address(RVA = "0x2BAA330", Offset = "0x2BA9730", Length = "0x87")]
	[Token(Token = "0x6001087")]
	internal static int XblMultiplayerEventArgsTournamentGameSessionReady(IntPtr argsHandle, out TimeT startTime) { }

	[Address(RVA = "0x2BAA3C0", Offset = "0x2BA97C0", Length = "0x93")]
	[Token(Token = "0x600106B")]
	internal static int XblMultiplayerEventArgsTournamentRegistrationStateChanged(IntPtr argsHandle, out XblTournamentRegistrationState registrationState, out XblTournamentRegistrationReason registrationReason) { }

	[Address(RVA = "0x2BAA460", Offset = "0x2BA9860", Length = "0x87")]
	[Token(Token = "0x600107F")]
	internal static int XblMultiplayerEventArgsXuid(IntPtr argsHandle, out ulong xuid) { }

	[Address(RVA = "0x2BAA4F0", Offset = "0x2BA98F0", Length = "0xC8")]
	[Token(Token = "0x600104B")]
	public static int XblMultiplayerGetActivitiesForSocialGroupAsync(IntPtr xboxLiveContext, Byte[] scid, ulong socialGroupOwnerXuid, Byte[] socialGroup, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAA650", Offset = "0x2BA9A50", Length = "0x1D4")]
	[Token(Token = "0x600104E")]
	public static int XblMultiplayerGetActivitiesForSocialGroupResult(XAsyncBlockPtr async, SizeT activityCount, out XblMultiplayerActivityDetails[] activities) { }

	[Address(RVA = "0x2BAA5C0", Offset = "0x2BA99C0", Length = "0x87")]
	[Token(Token = "0x600104D")]
	public static int XblMultiplayerGetActivitiesForSocialGroupResultCount(XAsyncBlockPtr async, out SizeT activityCount) { }

	[Address(RVA = "0x2BAA830", Offset = "0x2BA9C30", Length = "0xC8")]
	[Token(Token = "0x6001051")]
	public static int XblMultiplayerGetActivitiesForUsersAsync(IntPtr xboxLiveContext, Byte[] scid, in UInt64[] xuids, SizeT xuidsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAA990", Offset = "0x2BA9D90", Length = "0x1D4")]
	[Token(Token = "0x6001054")]
	public static int XblMultiplayerGetActivitiesForUsersResult(XAsyncBlockPtr async, SizeT activityCount, out XblMultiplayerActivityDetails[] activities) { }

	[Address(RVA = "0x2BAA900", Offset = "0x2BA9D00", Length = "0x87")]
	[Token(Token = "0x6001053")]
	public static int XblMultiplayerGetActivitiesForUsersResultCount(XAsyncBlockPtr async, out SizeT activityCount) { }

	[Address(RVA = "0x2BAAB70", Offset = "0x2BA9F70", Length = "0xC8")]
	[Token(Token = "0x600104C")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync(IntPtr xboxLiveContext, Byte[] scid, ulong socialGroupOwnerXuid, Byte[] socialGroup, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAACD0", Offset = "0x2BAA0D0", Length = "0xBF")]
	[Token(Token = "0x6001050")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT ptrToBufferCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BAAC40", Offset = "0x2BAA040", Length = "0x87")]
	[Token(Token = "0x600104F")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForSocialGroupResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BAAD90", Offset = "0x2BAA190", Length = "0xC8")]
	[Token(Token = "0x6001052")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForUsersAsync(IntPtr xboxLiveContext, Byte[] scid, in UInt64[] xuids, SizeT xuidsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAAEF0", Offset = "0x2BAA2F0", Length = "0xBF")]
	[Token(Token = "0x6001056")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForUsersResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT ptrToBufferCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BAAE60", Offset = "0x2BAA260", Length = "0x87")]
	[Token(Token = "0x6001055")]
	public static int XblMultiplayerGetActivitiesWithPropertiesForUsersResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BAAFB0", Offset = "0x2BAA3B0", Length = "0x112")]
	[Token(Token = "0x6001046")]
	public static int XblMultiplayerGetSearchHandlesAsync(IntPtr xblContext, Byte[] scid, Byte[] sessionTemplateName, Byte[] orderByAttribute, bool orderAscending, Byte[] searchFilter, Byte[] socialGroup, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAB160", Offset = "0x2BAA560", Length = "0x11D")]
	[Token(Token = "0x6001048")]
	public static int XblMultiplayerGetSearchHandlesResult(XAsyncBlockPtr async, out XblMultiplayerSearchHandle[] searchHandles, SizeT searchHandleCount) { }

	[Address(RVA = "0x2BAB0D0", Offset = "0x2BAA4D0", Length = "0x87")]
	[Token(Token = "0x6001047")]
	public static int XblMultiplayerGetSearchHandlesResultCount(XAsyncBlockPtr async, out SizeT searchHandleCount) { }

	[Address(RVA = "0x2BAB280", Offset = "0x2BAA680", Length = "0x93")]
	[Token(Token = "0x6001038")]
	internal static int XblMultiplayerGetSessionAsync(IntPtr xblContext, in XblMultiplayerSessionReference sessionRef, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAB320", Offset = "0x2BAA720", Length = "0x9D")]
	[Token(Token = "0x600103A")]
	internal static int XblMultiplayerGetSessionByHandleAsync(IntPtr xblContext, Byte[] handleId, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAB3C0", Offset = "0x2BAA7C0", Length = "0x87")]
	[Token(Token = "0x600103B")]
	internal static int XblMultiplayerGetSessionByHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle) { }

	[Address(RVA = "0x2BAB450", Offset = "0x2BAA850", Length = "0x87")]
	[Token(Token = "0x6001039")]
	internal static int XblMultiplayerGetSessionResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle) { }

	[Address(RVA = "0x2BAB4E0", Offset = "0x2BAA8E0", Length = "0x68")]
	[Token(Token = "0x600109C")]
	internal static NativeBool XblMultiplayerManagerAutoFillMembersDuringMatchmaking() { }

	[Address(RVA = "0x2BAB550", Offset = "0x2BAA950", Length = "0x68")]
	[Token(Token = "0x6001084")]
	internal static void XblMultiplayerManagerCancelMatch() { }

	[Address(RVA = "0x2BAB5C0", Offset = "0x2BAA9C0", Length = "0x87")]
	[Token(Token = "0x60010A0")]
	internal static int XblMultiplayerManagerDoWork(out IntPtr multiplayerEvents, out SizeT multiplayerEventsCount) { }

	[Address(RVA = "0x2BAB650", Offset = "0x2BAAA50", Length = "0x68")]
	[Token(Token = "0x6001085")]
	internal static uint XblMultiplayerManagerEstimatedMatchWaitTime() { }

	[Address(RVA = "0x2BAB6C0", Offset = "0x2BAAAC0", Length = "0xA6")]
	[Token(Token = "0x600109F")]
	internal static int XblMultiplayerManagerFindMatch(Byte[] hopperName, Byte[] attributesJson, uint timeoutInSeconds) { }

	[Address(RVA = "0x2BAB770", Offset = "0x2BAAB70", Length = "0x68")]
	[Token(Token = "0x6001089")]
	internal static NativeBool XblMultiplayerManagerGameSessionActive() { }

	[Address(RVA = "0x2BAB7E0", Offset = "0x2BAABE0", Length = "0x68")]
	[Token(Token = "0x6001098")]
	internal static XblMultiplayerSessionConstants* XblMultiplayerManagerGameSessionConstants() { }

	[Address(RVA = "0x2BAB850", Offset = "0x2BAAC50", Length = "0x68")]
	[Token(Token = "0x6001097")]
	internal static UTF8StringPtr XblMultiplayerManagerGameSessionCorrelationId() { }

	[Address(RVA = "0x2BAB8C0", Offset = "0x2BAACC0", Length = "0x78")]
	[Token(Token = "0x6001078")]
	internal static int XblMultiplayerManagerGameSessionHost(out XblMultiplayerManagerMember hostMember) { }

	[Address(RVA = "0x2BAB940", Offset = "0x2BAAD40", Length = "0x78")]
	[Token(Token = "0x6001076")]
	internal static NativeBool XblMultiplayerManagerGameSessionIsHost(ulong xuid) { }

	[Address(RVA = "0x2BABA30", Offset = "0x2BAAE30", Length = "0x132")]
	[Token(Token = "0x60010A2")]
	internal static int XblMultiplayerManagerGameSessionMembers(SizeT membersCount, out XblMultiplayerManagerMember[] members) { }

	[Address(RVA = "0x2BAB9C0", Offset = "0x2BAADC0", Length = "0x68")]
	[Token(Token = "0x60010A5")]
	internal static SizeT XblMultiplayerManagerGameSessionMembersCount() { }

	[Address(RVA = "0x2BABB70", Offset = "0x2BAAF70", Length = "0x68")]
	[Token(Token = "0x60010A6")]
	internal static UTF8StringPtr XblMultiplayerManagerGameSessionPropertiesJson() { }

	[Address(RVA = "0x2BABBE0", Offset = "0x2BAAFE0", Length = "0x68")]
	[Token(Token = "0x600107E")]
	internal static XblMultiplayerSessionReference* XblMultiplayerManagerGameSessionSessionReference() { }

	[Address(RVA = "0x2BABC50", Offset = "0x2BAB050", Length = "0xA6")]
	[Token(Token = "0x6001080")]
	internal static int XblMultiplayerManagerGameSessionSetProperties(Byte[] name, Byte[] valueJson, IntPtr context) { }

	[Address(RVA = "0x2BABD00", Offset = "0x2BAB100", Length = "0x91")]
	[Token(Token = "0x600108F")]
	internal static int XblMultiplayerManagerGameSessionSetSynchronizedHost(Byte[] deviceToken, IntPtr context) { }

	[Address(RVA = "0x2BABDA0", Offset = "0x2BAB1A0", Length = "0xA6")]
	[Token(Token = "0x6001096")]
	internal static int XblMultiplayerManagerGameSessionSetSynchronizedProperties(Byte[] name, Byte[] valueJson, IntPtr context) { }

	[Address(RVA = "0x2BABE50", Offset = "0x2BAB250", Length = "0xDC")]
	[Token(Token = "0x600108A")]
	internal static int XblMultiplayerManagerInitialize(Byte[] lobbySessionTemplateName, XTaskQueueHandle asyncQueue) { }

	[Address(RVA = "0x2BAC120", Offset = "0x2BAB520", Length = "0x68")]
	[Token(Token = "0x6001082")]
	internal static XblMultiplayerJoinability XblMultiplayerManagerJoinability() { }

	[Address(RVA = "0x2BABFC0", Offset = "0x2BAB3C0", Length = "0xBD")]
	[Token(Token = "0x60010A4")]
	internal static int XblMultiplayerManagerJoinGame(Byte[] sessionName, Byte[] sessionTemplateName, in UInt64[] xuids, SizeT xuidsCount) { }

	[Address(RVA = "0x2BABF30", Offset = "0x2BAB330", Length = "0x82")]
	[Token(Token = "0x6001075")]
	internal static int XblMultiplayerManagerJoinGameFromLobby(Byte[] sessionTemplateName) { }

	[Address(RVA = "0x2BAC080", Offset = "0x2BAB480", Length = "0x91")]
	[Token(Token = "0x600106F")]
	internal static int XblMultiplayerManagerJoinLobby(Byte[] handleId, IntPtr user) { }

	[Address(RVA = "0x2BAC190", Offset = "0x2BAB590", Length = "0x68")]
	[Token(Token = "0x6001093")]
	internal static int XblMultiplayerManagerLeaveGame() { }

	[Address(RVA = "0x2BAC200", Offset = "0x2BAB600", Length = "0x78")]
	[Token(Token = "0x6001073")]
	internal static int XblMultiplayerManagerLobbySessionAddLocalUser(IntPtr user) { }

	[Address(RVA = "0x2BAC280", Offset = "0x2BAB680", Length = "0x68")]
	[Token(Token = "0x6001086")]
	internal static XblMultiplayerSessionConstants* XblMultiplayerManagerLobbySessionConstants() { }

	[Address(RVA = "0x2BAC2F0", Offset = "0x2BAB6F0", Length = "0x78")]
	[Token(Token = "0x600109D")]
	internal static int XblMultiplayerManagerLobbySessionCorrelationId(out XblGuid correlationId) { }

	[Address(RVA = "0x2BAC370", Offset = "0x2BAB770", Length = "0x9D")]
	[Token(Token = "0x600108C")]
	internal static int XblMultiplayerManagerLobbySessionDeleteLocalMemberProperties(IntPtr user, Byte[] name, IntPtr context) { }

	[Address(RVA = "0x2BAC410", Offset = "0x2BAB810", Length = "0x78")]
	[Token(Token = "0x600106A")]
	internal static int XblMultiplayerManagerLobbySessionHost(out XblMultiplayerManagerMember hostMember) { }

	[Address(RVA = "0x2BAC490", Offset = "0x2BAB890", Length = "0xA5")]
	[Token(Token = "0x6001070")]
	internal static int XblMultiplayerManagerLobbySessionInviteFriends(IntPtr requestingUser, Byte[] contextStringId, Byte[] customActivationContext) { }

	[Address(RVA = "0x2BAC540", Offset = "0x2BAB940", Length = "0xD0")]
	[Token(Token = "0x600106E")]
	internal static int XblMultiplayerManagerLobbySessionInviteUsers(IntPtr user, in UInt64[] xuids, SizeT xuidsCount, Byte[] contextStringId, Byte[] customActivationContext) { }

	[Address(RVA = "0x2BAC610", Offset = "0x2BABA10", Length = "0x78")]
	[Token(Token = "0x6001095")]
	internal static NativeBool XblMultiplayerManagerLobbySessionIsHost(ulong xuid) { }

	[Address(RVA = "0x2BAC690", Offset = "0x2BABA90", Length = "0x68")]
	[Token(Token = "0x6001090")]
	internal static XblTournamentTeamResult* XblMultiplayerManagerLobbySessionLastTournamentTeamResult() { }

	[Address(RVA = "0x2BAC770", Offset = "0x2BABB70", Length = "0x132")]
	[Token(Token = "0x6001099")]
	internal static int XblMultiplayerManagerLobbySessionLocalMembers(SizeT localMembersCount, out XblMultiplayerManagerMember[] localMembers) { }

	[Address(RVA = "0x2BAC700", Offset = "0x2BABB00", Length = "0x68")]
	[Token(Token = "0x6001088")]
	internal static SizeT XblMultiplayerManagerLobbySessionLocalMembersCount() { }

	[Address(RVA = "0x2BAC920", Offset = "0x2BABD20", Length = "0x132")]
	[Token(Token = "0x6001081")]
	internal static int XblMultiplayerManagerLobbySessionMembers(SizeT membersCount, out XblMultiplayerManagerMember[] members) { }

	[Address(RVA = "0x2BAC8B0", Offset = "0x2BABCB0", Length = "0x68")]
	[Token(Token = "0x600109E")]
	internal static SizeT XblMultiplayerManagerLobbySessionMembersCount() { }

	[Address(RVA = "0x2BACA60", Offset = "0x2BABE60", Length = "0x68")]
	[Token(Token = "0x6001083")]
	internal static UTF8StringPtr XblMultiplayerManagerLobbySessionPropertiesJson() { }

	[Address(RVA = "0x2BACAD0", Offset = "0x2BABED0", Length = "0x78")]
	[Token(Token = "0x600108B")]
	internal static int XblMultiplayerManagerLobbySessionRemoveLocalUser(IntPtr user) { }

	[Address(RVA = "0x2BACB50", Offset = "0x2BABF50", Length = "0x78")]
	[Token(Token = "0x6001079")]
	internal static int XblMultiplayerManagerLobbySessionSessionReference(out XblMultiplayerSessionReference sessionReference) { }

	[Address(RVA = "0x2BACBD0", Offset = "0x2BABFD0", Length = "0x9D")]
	[Token(Token = "0x60010A3")]
	internal static int XblMultiplayerManagerLobbySessionSetLocalMemberConnectionAddress(IntPtr user, Byte[] connectionAddress, IntPtr context) { }

	[Address(RVA = "0x2BACC70", Offset = "0x2BAC070", Length = "0xB4")]
	[Token(Token = "0x600107C")]
	internal static int XblMultiplayerManagerLobbySessionSetLocalMemberProperties(IntPtr user, Byte[] name, Byte[] valueJson, IntPtr context) { }

	[Address(RVA = "0x2BACD30", Offset = "0x2BAC130", Length = "0xA6")]
	[Token(Token = "0x600107A")]
	internal static int XblMultiplayerManagerLobbySessionSetProperties(Byte[] name, Byte[] valueJson, IntPtr context) { }

	[Address(RVA = "0x2BACDE0", Offset = "0x2BAC1E0", Length = "0x91")]
	[Token(Token = "0x600109B")]
	internal static int XblMultiplayerManagerLobbySessionSetSynchronizedHost(Byte[] deviceToken, IntPtr context) { }

	[Address(RVA = "0x2BACE80", Offset = "0x2BAC280", Length = "0xA6")]
	[Token(Token = "0x600107D")]
	internal static int XblMultiplayerManagerLobbySessionSetSynchronizedProperties(Byte[] name, Byte[] valueJson, IntPtr context) { }

	[Address(RVA = "0x2BACF30", Offset = "0x2BAC330", Length = "0x68")]
	[Token(Token = "0x600109A")]
	internal static XblMultiplayerMatchStatus XblMultiplayerManagerMatchStatus() { }

	[Address(RVA = "0x2BACFA0", Offset = "0x2BAC3A0", Length = "0x87")]
	[Token(Token = "0x600108E")]
	internal static NativeBool XblMultiplayerManagerMemberAreMembersOnSameDevice(in XblMultiplayerManagerMember first, in XblMultiplayerManagerMember second) { }

	[Address(RVA = "0x2BAD030", Offset = "0x2BAC430", Length = "0x78")]
	[Token(Token = "0x600107B")]
	internal static void XblMultiplayerManagerSetAutoFillMembersDuringMatchmaking(NativeBool autoFillMembers) { }

	[Address(RVA = "0x2BAD0B0", Offset = "0x2BAC4B0", Length = "0x85")]
	[Token(Token = "0x6001072")]
	internal static int XblMultiplayerManagerSetJoinability(XblMultiplayerJoinability joinability, IntPtr context) { }

	[Address(RVA = "0x2BAD140", Offset = "0x2BAC540", Length = "0x82")]
	[Token(Token = "0x6001071")]
	internal static int XblMultiplayerManagerSetQosMeasurements(Byte[] measurementsJson) { }

	[Address(RVA = "0x2BAD1D0", Offset = "0x2BAC5D0", Length = "0xC5")]
	[Token(Token = "0x600103C")]
	internal static int XblMultiplayerQuerySessionsAsync(IntPtr xblContext, in XblMultiplayerSessionQuery sessionQuery, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAD330", Offset = "0x2BAC730", Length = "0x189")]
	[Token(Token = "0x600103E")]
	internal static int XblMultiplayerQuerySessionsResult(XAsyncBlockPtr async, SizeT sessionCount, out XblMultiplayerSessionQueryResult[] sessions) { }

	[Address(RVA = "0x2BAD2A0", Offset = "0x2BAC6A0", Length = "0x87")]
	[Token(Token = "0x600103D")]
	internal static int XblMultiplayerQuerySessionsResultCount(XAsyncBlockPtr async, out SizeT sessionCount) { }

	[Address(RVA = "0x2BAD4C0", Offset = "0x2BAC8C0", Length = "0x85")]
	[Token(Token = "0x6001061")]
	internal static int XblMultiplayerRemoveConnectionIdChangedHandler(IntPtr xblContext, XblFunctionContext token) { }

	[Address(RVA = "0x2BAD550", Offset = "0x2BAC950", Length = "0x85")]
	[Token(Token = "0x600105A")]
	internal static int XblMultiplayerRemoveSessionChangedHandler(IntPtr xblContext, XblFunctionContext token) { }

	[Address(RVA = "0x2BAD5E0", Offset = "0x2BAC9E0", Length = "0x85")]
	[Token(Token = "0x600105C")]
	internal static int XblMultiplayerRemoveSubscriptionLostHandler(IntPtr xblContext, XblFunctionContext token) { }

	[Address(RVA = "0x2BAD670", Offset = "0x2BACA70", Length = "0x78")]
	[Token(Token = "0x6001027")]
	public static void XblMultiplayerSearchHandleCloseHandle(IntPtr handle) { }

	[Address(RVA = "0x2BAD6F0", Offset = "0x2BACAF0", Length = "0x87")]
	[Token(Token = "0x6001026")]
	public static int XblMultiplayerSearchHandleDuplicateHandle(in XblMultiplayerSearchHandle handle, out XblMultiplayerSearchHandle duplicatedHandle) { }

	[Address(RVA = "0x2BAD780", Offset = "0x2BACB80", Length = "0x87")]
	[Token(Token = "0x6001032")]
	public static int XblMultiplayerSearchHandleGetCreationTime(in IntPtr handle, out TimeT creationTime) { }

	[Address(RVA = "0x2BAD810", Offset = "0x2BACC10", Length = "0x87")]
	[Token(Token = "0x6001033")]
	public static int XblMultiplayerSearchHandleGetCustomSessionPropertiesJson(in IntPtr handle, out UTF8StringPtr customPropertiesJson) { }

	[Address(RVA = "0x2BAD8A0", Offset = "0x2BACCA0", Length = "0x87")]
	[Token(Token = "0x6001029")]
	public static int XblMultiplayerSearchHandleGetId(in IntPtr handle, out UTF8StringPtr id) { }

	[Address(RVA = "0x2BAD930", Offset = "0x2BACD30", Length = "0x87")]
	[Token(Token = "0x600102F")]
	public static int XblMultiplayerSearchHandleGetJoinRestriction(in IntPtr handle, out XblMultiplayerSessionRestriction joinRestriction) { }

	[Address(RVA = "0x2BAD9C0", Offset = "0x2BACDC0", Length = "0x93")]
	[Token(Token = "0x6001031")]
	public static int XblMultiplayerSearchHandleGetMemberCounts(in IntPtr handle, out SizeT maxMembers, out SizeT currentMembers) { }

	[Address(RVA = "0x2BADA60", Offset = "0x2BACE60", Length = "0x93")]
	[Token(Token = "0x600102D")]
	public static int XblMultiplayerSearchHandleGetNumberAttributes(in IntPtr handle, out IntPtr attributes, out SizeT attributesCount) { }

	[Address(RVA = "0x2BADB00", Offset = "0x2BACF00", Length = "0x87")]
	[Token(Token = "0x6001030")]
	public static int XblMultiplayerSearchHandleGetSessionClosed(in IntPtr handle, out bool closed) { }

	[Address(RVA = "0x2BADB90", Offset = "0x2BACF90", Length = "0x93")]
	[Token(Token = "0x600102A")]
	public static int XblMultiplayerSearchHandleGetSessionOwnerXuids(in IntPtr handle, out IntPtr xuids, out SizeT xuidsCount) { }

	[Address(RVA = "0x2BADC30", Offset = "0x2BAD030", Length = "0x87")]
	[Token(Token = "0x6001028")]
	public static int XblMultiplayerSearchHandleGetSessionReference(in IntPtr handle, out XblMultiplayerSessionReference sessionRef) { }

	[Address(RVA = "0x2BADCC0", Offset = "0x2BAD0C0", Length = "0x93")]
	[Token(Token = "0x600102C")]
	public static int XblMultiplayerSearchHandleGetStringAttributes(in IntPtr handle, out IntPtr attributes, out SizeT attributesCount) { }

	[Address(RVA = "0x2BADD60", Offset = "0x2BAD160", Length = "0x93")]
	[Token(Token = "0x600102B")]
	public static int XblMultiplayerSearchHandleGetTags(in IntPtr handle, out IntPtr tags, out SizeT tagsCount) { }

	[Address(RVA = "0x2BADE00", Offset = "0x2BAD200", Length = "0x87")]
	[Token(Token = "0x600102E")]
	public static int XblMultiplayerSearchHandleGetVisibility(in IntPtr handle, out XblMultiplayerSessionVisibility visibility) { }

	[Address(RVA = "0x2BADE90", Offset = "0x2BAD290", Length = "0xF9")]
	[Token(Token = "0x6001049")]
	public static int XblMultiplayerSendInvitesAsync(IntPtr xblContext, in XblMultiplayerSessionReference sessionRef, in UInt64[] xuids, SizeT xuidsCount, uint titleId, Byte[] contextStringId, Byte[] customActivationContext, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BADF90", Offset = "0x2BAD390", Length = "0x131")]
	[Token(Token = "0x600104A")]
	public static int XblMultiplayerSendInvitesResult(XAsyncBlockPtr async, SizeT handlesCount, out XblMultiplayerInviteHandle[] handles) { }

	[Address(RVA = "0x2BAE0D0", Offset = "0x2BAD4D0", Length = "0x78")]
	[Token(Token = "0x6001000")]
	public static void XblMultiplayerSessionCloseHandle(IntPtr handle) { }

	[Address(RVA = "0x2BAE150", Offset = "0x2BAD550", Length = "0x87")]
	[Token(Token = "0x600105F")]
	internal static XblMultiplayerSessionChangeTypes XblMultiplayerSessionCompare(IntPtr currentSessionHandle, IntPtr oldSessionHandle) { }

	[Address(RVA = "0x2BAE1E0", Offset = "0x2BAD5E0", Length = "0xA4")]
	[Token(Token = "0x600100E")]
	internal static int XblMultiplayerSessionConstantsSetCapabilities(IntPtr handle, XblMultiplayerSessionCapabilities capabilities) { }

	[Address(RVA = "0x2BAE290", Offset = "0x2BAD690", Length = "0x85")]
	[Token(Token = "0x6001007")]
	public static void XblMultiplayerSessionConstantsSetMaxMembersInSession(IntPtr handle, uint maxMembersInSession) { }

	[Address(RVA = "0x2BAE320", Offset = "0x2BAD720", Length = "0x91")]
	[Token(Token = "0x600100D")]
	public static int XblMultiplayerSessionConstantsSetMeasurementServerAddressesJson(IntPtr handle, Byte[] measurementServerAddressesJson) { }

	[Address(RVA = "0x2BAE3C0", Offset = "0x2BAD7C0", Length = "0x9D")]
	[Token(Token = "0x600100B")]
	public static int XblMultiplayerSessionConstantsSetMemberInitialization(IntPtr handle, XblMultiplayerMemberInitialization memberInitialization) { }

	[Address(RVA = "0x2BAE460", Offset = "0x2BAD860", Length = "0x91")]
	[Token(Token = "0x600100C")]
	public static int XblMultiplayerSessionConstantsSetPeerToPeerRequirements(IntPtr handle, XblMultiplayerPeerToPeerRequirements requirements) { }

	[Address(RVA = "0x2BAE500", Offset = "0x2BAD900", Length = "0xB6")]
	[Token(Token = "0x600100A")]
	public static int XblMultiplayerSessionConstantsSetQosConnectivityMetrics(IntPtr handle, NativeBool enableLatencyMetric, NativeBool enableBandwidthDownMetric, NativeBool enableBandwidthUpMetric, NativeBool enableCustomMetric) { }

	[Address(RVA = "0x2BAE5C0", Offset = "0x2BAD9C0", Length = "0xB2")]
	[Token(Token = "0x6001009")]
	public static int XblMultiplayerSessionConstantsSetTimeouts(IntPtr handle, ulong memberReservedTimeout, ulong memberInactiveTimeout, ulong memberReadyTimeout, ulong sessionEmptyTimeout) { }

	[Address(RVA = "0x2BAE680", Offset = "0x2BADA80", Length = "0x85")]
	[Token(Token = "0x6001008")]
	public static void XblMultiplayerSessionConstantsSetVisibility(IntPtr handle, XblMultiplayerSessionVisibility visibility) { }

	[Address(RVA = "0x2BAE710", Offset = "0x2BADB10", Length = "0x93")]
	[Token(Token = "0x6000FFF")]
	public static XblMultiplayerSessionHandle XblMultiplayerSessionCreateHandle(ulong xboxUserId, in XblMultiplayerSessionReference sessionRef, in XblMultiplayerSessionInitArgs initArgs) { }

	[Address(RVA = "0x2BAECB0", Offset = "0x2BAE0B0", Length = "0x78")]
	[Token(Token = "0x6001016")]
	internal static XblMultiplayerSessionMember* XblMultiplayerSessionCurrentUser(IntPtr handle) { }

	[Address(RVA = "0x2BAE7B0", Offset = "0x2BADBB0", Length = "0x91")]
	[Token(Token = "0x6001022")]
	public static int XblMultiplayerSessionCurrentUserDeleteCustomPropertyJson(IntPtr handle, Byte[] name) { }

	[Address(RVA = "0x2BAE850", Offset = "0x2BADC50", Length = "0xA5")]
	[Token(Token = "0x6001021")]
	public static int XblMultiplayerSessionCurrentUserSetCustomPropertyJson(IntPtr handle, Byte[] name, Byte[] valueJson) { }

	[Address(RVA = "0x2BAE900", Offset = "0x2BADD00", Length = "0x93")]
	[Token(Token = "0x600101E")]
	public static int XblMultiplayerSessionCurrentUserSetEncounters(IntPtr handle, IntPtr encounters, SizeT encountersCount) { }

	[Address(RVA = "0x2BAE9A0", Offset = "0x2BADDA0", Length = "0x93")]
	[Token(Token = "0x6001020")]
	public static int XblMultiplayerSessionCurrentUserSetGroups(IntPtr handle, IntPtr groups, SizeT groupsCount) { }

	[Address(RVA = "0x2BAEA40", Offset = "0x2BADE40", Length = "0x9D")]
	[Token(Token = "0x600101F")]
	public static int XblMultiplayerSessionCurrentUserSetMembersInGroup(IntPtr handle, UInt32[] memberIds, SizeT memberIdsCount) { }

	[Address(RVA = "0x2BAEAE0", Offset = "0x2BADEE0", Length = "0x93")]
	[Token(Token = "0x600101D")]
	public static int XblMultiplayerSessionCurrentUserSetRoles(IntPtr handle, IntPtr roles, SizeT rolesCount) { }

	[Address(RVA = "0x2BAEB80", Offset = "0x2BADF80", Length = "0x91")]
	[Token(Token = "0x6001024")]
	public static int XblMultiplayerSessionCurrentUserSetSecureDeviceAddressBase64(IntPtr handle, Byte[] value) { }

	[Address(RVA = "0x2BAEC20", Offset = "0x2BAE020", Length = "0x85")]
	[Token(Token = "0x6001023")]
	public static int XblMultiplayerSessionCurrentUserSetStatus(IntPtr handle, XblMultiplayerSessionMemberStatus status) { }

	[Address(RVA = "0x2BAED30", Offset = "0x2BAE130", Length = "0x91")]
	[Token(Token = "0x600105E")]
	internal static int XblMultiplayerSessionDeleteCustomPropertyJson(IntPtr handle, Byte[] name) { }

	[Address(RVA = "0x2BAEDD0", Offset = "0x2BAE1D0", Length = "0x78")]
	[Token(Token = "0x6001002")]
	internal static XblMultiplayerSessionInitializationInfo* XblMultiplayerSessionGetInitializationInfo(IntPtr handle) { }

	[Address(RVA = "0x2BAEE50", Offset = "0x2BAE250", Length = "0x93")]
	[Token(Token = "0x6001004")]
	public static int XblMultiplayerSessionHostCandidates(IntPtr handle, out IntPtr deviceTokens, out SizeT deviceTokensCount) { }

	[Address(RVA = "0x2BAEEF0", Offset = "0x2BAE2F0", Length = "0xB0")]
	[Token(Token = "0x6001018")]
	public static int XblMultiplayerSessionJoin(IntPtr handle, Byte[] memberCustomConstantsJson, bool initializeRequested, bool joinWithActiveStatus) { }

	[Address(RVA = "0x2BAEFA0", Offset = "0x2BAE3A0", Length = "0x78")]
	[Token(Token = "0x600101C")]
	public static int XblMultiplayerSessionLeave(IntPtr handle) { }

	[Address(RVA = "0x2BAF020", Offset = "0x2BAE420", Length = "0x78")]
	[Token(Token = "0x6001015")]
	internal static XblMultiplayerMatchmakingServer* XblMultiplayerSessionMatchmakingServer(IntPtr handle) { }

	[Address(RVA = "0x2BAF0A0", Offset = "0x2BAE4A0", Length = "0x93")]
	[Token(Token = "0x6001014")]
	internal static int XblMultiplayerSessionMembers(IntPtr handle, out IntPtr members, out SizeT membersCount) { }

	[Address(RVA = "0x2BAF140", Offset = "0x2BAE540", Length = "0x85")]
	[Token(Token = "0x6001011")]
	public static void XblMultiplayerSessionPropertiesSetJoinRestriction(IntPtr handle, XblMultiplayerSessionRestriction joinRestriction) { }

	[Address(RVA = "0x2BAF1D0", Offset = "0x2BAE5D0", Length = "0x93")]
	[Token(Token = "0x6001010")]
	internal static int XblMultiplayerSessionPropertiesSetKeywords(IntPtr handle, IntPtr keywords, SizeT keywordsCount) { }

	[Address(RVA = "0x2BAF270", Offset = "0x2BAE670", Length = "0x85")]
	[Token(Token = "0x6001012")]
	public static void XblMultiplayerSessionPropertiesSetReadRestriction(IntPtr handle, XblMultiplayerSessionRestriction readRestriction) { }

	[Address(RVA = "0x2BAF300", Offset = "0x2BAE700", Length = "0x9D")]
	[Token(Token = "0x6001013")]
	internal static int XblMultiplayerSessionPropertiesSetTurnCollection(IntPtr handle, in UInt32[] turnCollectionMemberIds, SizeT turnCollectionMemberIdsCount) { }

	[Address(RVA = "0x2BAF3A0", Offset = "0x2BAE7A0", Length = "0x14D")]
	[Token(Token = "0x600106C")]
	internal static XblMultiplayerSessionReference XblMultiplayerSessionReferenceCreate(Byte[] scid, Byte[] sessionTemplateName, Byte[] sessionName) { }

	[Address(RVA = "0x2BAF4F0", Offset = "0x2BAE8F0", Length = "0x78")]
	[Token(Token = "0x60010A1")]
	internal static NativeBool XblMultiplayerSessionReferenceIsValid(in XblMultiplayerSessionReference sessionReference) { }

	[Address(RVA = "0x2BAF570", Offset = "0x2BAE970", Length = "0x91")]
	[Token(Token = "0x6001091")]
	internal static int XblMultiplayerSessionReferenceParseFromUriPath(Byte[] path, out XblMultiplayerSessionReference sessionReference) { }

	[Address(RVA = "0x2BAF610", Offset = "0x2BAEA10", Length = "0x116")]
	[Token(Token = "0x6001092")]
	internal static int XblMultiplayerSessionReferenceToUriPath(XblMultiplayerSessionReference sessionReference, out XblMultiplayerSessionReferenceUri sessionReferenceUri) { }

	[Address(RVA = "0x2BAF730", Offset = "0x2BAEB30", Length = "0x78")]
	[Token(Token = "0x6001006")]
	internal static XblMultiplayerSessionConstants* XblMultiplayerSessionSessionConstants(IntPtr handle) { }

	[Address(RVA = "0x2BAF7B0", Offset = "0x2BAEBB0", Length = "0x78")]
	[Token(Token = "0x600100F")]
	internal static XblMultiplayerSessionProperties* XblMultiplayerSessionSessionProperties(IntPtr handle) { }

	[Address(RVA = "0x2BAF830", Offset = "0x2BAEC30", Length = "0x78")]
	[Token(Token = "0x6001005")]
	internal static XblMultiplayerSessionReference* XblMultiplayerSessionSessionReference(IntPtr handle) { }

	[Address(RVA = "0x2BAF8B0", Offset = "0x2BAECB0", Length = "0x87")]
	[Token(Token = "0x600101A")]
	public static void XblMultiplayerSessionSetClosed(IntPtr handle, bool closed) { }

	[Address(RVA = "0x2BAF940", Offset = "0x2BAED40", Length = "0xA5")]
	[Token(Token = "0x600105D")]
	internal static int XblMultiplayerSessionSetCustomPropertyJson(IntPtr handle, Byte[] name, Byte[] valueJson) { }

	[Address(RVA = "0x2BAF9F0", Offset = "0x2BAEDF0", Length = "0xAE")]
	[Token(Token = "0x6001019")]
	public static void XblMultiplayerSessionSetHostDeviceToken(IntPtr handle, XblDeviceToken hostDeviceToken) { }

	[Address(RVA = "0x2BAFAA0", Offset = "0x2BAEEA0", Length = "0x85")]
	[Token(Token = "0x600101B")]
	public static int XblMultiplayerSessionSetSessionChangeSubscription(IntPtr handle, XblMultiplayerSessionChangeTypes changeTypes) { }

	[Address(RVA = "0x2BAFB30", Offset = "0x2BAEF30", Length = "0x78")]
	[Token(Token = "0x6001003")]
	public static XblMultiplayerSessionChangeTypes XblMultiplayerSessionSubscribedChangeTypes(IntPtr handle) { }

	[Address(RVA = "0x2BAFBB0", Offset = "0x2BAEFB0", Length = "0x78")]
	[Token(Token = "0x6001001")]
	public static TimeT XblMultiplayerSessionTimeOfSession(IntPtr handle) { }

	[Address(RVA = "0x2BAFC30", Offset = "0x2BAF030", Length = "0x78")]
	[Token(Token = "0x6001017")]
	public static XblWriteSessionStatus XblMultiplayerSessionWriteStatus(IntPtr handle) { }

	[Address(RVA = "0x2BAFCB0", Offset = "0x2BAF0B0", Length = "0x93")]
	[Token(Token = "0x600103F")]
	internal static int XblMultiplayerSetActivityAsync(IntPtr xblContext, in XblMultiplayerSessionReference sessionReference, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAFD50", Offset = "0x2BAF150", Length = "0x87")]
	[Token(Token = "0x6001057")]
	public static int XblMultiplayerSetSubscriptionsEnabled(IntPtr xblContext, bool subscriptionsEnabled) { }

	[Address(RVA = "0x2BAFDE0", Offset = "0x2BAF1E0", Length = "0xA2")]
	[Token(Token = "0x6001041")]
	internal static int XblMultiplayerSetTransferHandleAsync(IntPtr xblContext, in XblMultiplayerSessionReference targetSessionReference, in XblMultiplayerSessionReference originSessionReference, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BAFE90", Offset = "0x2BAF290", Length = "0x2C8")]
	[Token(Token = "0x6001042")]
	public static int XblMultiplayerSetTransferHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandleId handle) { }

	[Address(RVA = "0x2BB0160", Offset = "0x2BAF560", Length = "0x7D")]
	[Token(Token = "0x6001058")]
	public static bool XblMultiplayerSubscriptionsEnabled(IntPtr xblHandle) { }

	[Address(RVA = "0x2BB01E0", Offset = "0x2BAF5E0", Length = "0xA2")]
	[Token(Token = "0x6001034")]
	internal static int XblMultiplayerWriteSessionAsync(IntPtr xblContext, IntPtr multiplayerSession, XblMultiplayerSessionWriteMode writeMode, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB0290", Offset = "0x2BAF690", Length = "0xBC")]
	[Token(Token = "0x6001036")]
	internal static int XblMultiplayerWriteSessionByHandleAsync(IntPtr xblContext, IntPtr multiplayerSession, XblMultiplayerSessionWriteMode writeMode, Byte[] handleId, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB0350", Offset = "0x2BAF750", Length = "0x87")]
	[Token(Token = "0x6001037")]
	internal static int XblMultiplayerWriteSessionByHandleResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle) { }

	[Address(RVA = "0x2BB03E0", Offset = "0x2BAF7E0", Length = "0x87")]
	[Token(Token = "0x6001035")]
	internal static int XblMultiplayerWriteSessionResult(XAsyncBlockPtr async, out XblMultiplayerSessionHandle handle) { }

	[Address(RVA = "0x2BB0470", Offset = "0x2BAF870", Length = "0xA0")]
	[Token(Token = "0x60010BA")]
	internal static XblFunctionContext XblPresenceAddDevicePresenceChangedHandler(XblContextHandle xblContextHandle, XblPresenceDevicePresenceChangedHandler handler, IntPtr context) { }

	[Address(RVA = "0x2BB0510", Offset = "0x2BAF910", Length = "0xA0")]
	[Token(Token = "0x60010BC")]
	internal static XblFunctionContext XblPresenceAddTitlePresenceChangedHandler(XblContextHandle xblContextHandle, XblPresenceTitlePresenceChangedHandler handler, IntPtr context) { }

	[Address(RVA = "0x2BB05B0", Offset = "0x2BAF9B0", Length = "0x93")]
	[Token(Token = "0x60010AE")]
	internal static int XblPresenceGetPresenceAsync(IntPtr xblContextHandle, ulong xuid, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB0650", Offset = "0x2BAFA50", Length = "0xC8")]
	[Token(Token = "0x60010B0")]
	internal static int XblPresenceGetPresenceForMultipleUsersAsync(IntPtr xblContextHandle, UInt64[] xuids, SizeT xuidsCount, XblPresenceQueryFiltersRef filters, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB07B0", Offset = "0x2BAFBB0", Length = "0x11D")]
	[Token(Token = "0x60010B2")]
	internal static int XblPresenceGetPresenceForMultipleUsersResult(XAsyncBlockPtr asyncBlock, out XblPresenceRecordHandle[] presenceRecordHandles, SizeT presenceRecordHandlesCount) { }

	[Address(RVA = "0x2BB0720", Offset = "0x2BAFB20", Length = "0x87")]
	[Token(Token = "0x60010B1")]
	internal static int XblPresenceGetPresenceForMultipleUsersResultCount(XAsyncBlockPtr asyncBlock, out SizeT resultCount) { }

	[Address(RVA = "0x2BB08D0", Offset = "0x2BAFCD0", Length = "0xD0")]
	[Token(Token = "0x60010B3")]
	internal static int XblPresenceGetPresenceForSocialGroupAsync(IntPtr xblContextHandle, Byte[] socialGroupName, UInt64Ref socialGroupOwnerXuid, XblPresenceQueryFiltersRef filters, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB0A30", Offset = "0x2BAFE30", Length = "0x11D")]
	[Token(Token = "0x60010B5")]
	internal static int XblPresenceGetPresenceForSocialGroupResult(XAsyncBlockPtr asyncBlock, out XblPresenceRecordHandle[] presenceRecordHandles, SizeT presenceRecordHandlesCount) { }

	[Address(RVA = "0x2BB09A0", Offset = "0x2BAFDA0", Length = "0x87")]
	[Token(Token = "0x60010B4")]
	internal static int XblPresenceGetPresenceForSocialGroupResultCount(XAsyncBlockPtr asyncBlock, out SizeT resultCount) { }

	[Address(RVA = "0x2BB0B50", Offset = "0x2BAFF50", Length = "0x87")]
	[Token(Token = "0x60010AF")]
	internal static int XblPresenceGetPresenceResult(XAsyncBlockPtr asyncBlock, out XblPresenceRecordHandle presenceRecordHandle) { }

	[Address(RVA = "0x2BB0BE0", Offset = "0x2BAFFE0", Length = "0x78")]
	[Token(Token = "0x60010AC")]
	internal static void XblPresenceRecordCloseHandle(IntPtr handle) { }

	[Address(RVA = "0x2BB0C60", Offset = "0x2BB0060", Length = "0x87")]
	[Token(Token = "0x60010AB")]
	internal static int XblPresenceRecordDuplicateHandle(IntPtr handle, out XblPresenceRecordHandle duplicatedHandle) { }

	[Address(RVA = "0x2BB0CF0", Offset = "0x2BB00F0", Length = "0x93")]
	[Token(Token = "0x60010AA")]
	internal static int XblPresenceRecordGetDeviceRecords(IntPtr handle, out IntPtr deviceRecords, out SizeT deviceRecordsCount) { }

	[Address(RVA = "0x2BB0D90", Offset = "0x2BB0190", Length = "0x87")]
	[Token(Token = "0x60010A9")]
	internal static int XblPresenceRecordGetUserState(IntPtr handle, out XblPresenceUserState userState) { }

	[Address(RVA = "0x2BB0E20", Offset = "0x2BB0220", Length = "0x87")]
	[Token(Token = "0x60010A8")]
	internal static int XblPresenceRecordGetXuid(IntPtr handle, out ulong xuid) { }

	[Address(RVA = "0x2BB0EB0", Offset = "0x2BB02B0", Length = "0x85")]
	[Token(Token = "0x60010BB")]
	internal static int XblPresenceRemoveDevicePresenceChangedHandler(XblContextHandle xblContextHandle, XblFunctionContext token) { }

	[Address(RVA = "0x2BB0F40", Offset = "0x2BB0340", Length = "0x85")]
	[Token(Token = "0x60010BD")]
	internal static int XblPresenceRemoveTitlePresenceChangedHandler(XblContextHandle xblContextHandle, XblFunctionContext token) { }

	[Address(RVA = "0x2BB0FD0", Offset = "0x2BB03D0", Length = "0x248")]
	[Token(Token = "0x60010AD")]
	internal static int XblPresenceSetPresenceAsync(IntPtr xblContextHandle, bool isUserActiveInTitle, XblPresenceRichPresenceIdsRef richPresenceIds, XAsyncBlockPtr asyncBlockPtr) { }

	[Address(RVA = "0x2BB1220", Offset = "0x2BB0620", Length = "0x93")]
	[Token(Token = "0x60010B6")]
	internal static int XblPresenceSubscribeToDevicePresenceChange(XblContextHandle xblContextHandle, ulong xuid, out XblRealTimeActivitySubscriptionHandle subscriptionHandle) { }

	[Address(RVA = "0x2BB12C0", Offset = "0x2BB06C0", Length = "0xA2")]
	[Token(Token = "0x60010B8")]
	internal static int XblPresenceSubscribeToTitlePresenceChange(XblContextHandle xblContextHandle, ulong xuid, uint titleId, out XblRealTimeActivitySubscriptionHandle subscriptionHandle) { }

	[Address(RVA = "0x2BB1370", Offset = "0x2BB0770", Length = "0x87")]
	[Token(Token = "0x60010B7")]
	internal static int XblPresenceUnsubscribeFromDevicePresenceChange(XblContextHandle xblContextHandle, XblRealTimeActivitySubscriptionHandle subscriptionHandle) { }

	[Address(RVA = "0x2BB1400", Offset = "0x2BB0800", Length = "0x87")]
	[Token(Token = "0x60010B9")]
	internal static int XblPresenceUnsubscribeFromTitlePresenceChange(XblContextHandle xblContext, XblRealTimeActivitySubscriptionHandle subscriptionHandle) { }

	[Address(RVA = "0x2BB1490", Offset = "0x2BB0890", Length = "0xF8")]
	[Token(Token = "0x60010CA")]
	internal static int XblPrivacyBatchCheckPermissionAsync(IntPtr xblContextHandle, in XblPermission[] permissionsToCheck, SizeT permissionsCount, in UInt64[] targetXuids, SizeT xuidsCount, in XblAnonymousUserType[] targetAnonymousUserTypes, SizeT targetAnonymousUserTypesCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB1620", Offset = "0x2BB0A20", Length = "0xBF")]
	[Token(Token = "0x60010CC")]
	internal static int XblPrivacyBatchCheckPermissionResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr results, out SizeT resultsCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB1590", Offset = "0x2BB0990", Length = "0x87")]
	[Token(Token = "0x60010CB")]
	internal static int XblPrivacyBatchCheckPermissionResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB16E0", Offset = "0x2BB0AE0", Length = "0xA0")]
	[Token(Token = "0x60010C4")]
	internal static int XblPrivacyCheckPermissionAsync(IntPtr xblContextHandle, XblPermission permissionToCheck, ulong targetXuid, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB1780", Offset = "0x2BB0B80", Length = "0xA0")]
	[Token(Token = "0x60010C7")]
	internal static int XblPrivacyCheckPermissionForAnonymousUserAsync(IntPtr xblContextHandle, XblPermission permissionToCheck, XblAnonymousUserType userType, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB18B0", Offset = "0x2BB0CB0", Length = "0xB2")]
	[Token(Token = "0x60010C9")]
	internal static int XblPrivacyCheckPermissionForAnonymousUserResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB1820", Offset = "0x2BB0C20", Length = "0x87")]
	[Token(Token = "0x60010C8")]
	internal static int XblPrivacyCheckPermissionForAnonymousUserResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB1A00", Offset = "0x2BB0E00", Length = "0xB2")]
	[Token(Token = "0x60010C6")]
	internal static int XblPrivacyCheckPermissionResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr result, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB1970", Offset = "0x2BB0D70", Length = "0x87")]
	[Token(Token = "0x60010C5")]
	internal static int XblPrivacyCheckPermissionResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB1AC0", Offset = "0x2BB0EC0", Length = "0x87")]
	[Token(Token = "0x60010BE")]
	internal static int XblPrivacyGetAvoidListAsync(IntPtr xblContextHandle, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB1BE0", Offset = "0x2BB0FE0", Length = "0x11D")]
	[Token(Token = "0x60010C0")]
	internal static int XblPrivacyGetAvoidListResult(XAsyncBlockPtr async, SizeT xuidCount, out UInt64[] xuids) { }

	[Address(RVA = "0x2BB1B50", Offset = "0x2BB0F50", Length = "0x87")]
	[Token(Token = "0x60010BF")]
	internal static int XblPrivacyGetAvoidListResultCount(XAsyncBlockPtr async, out SizeT xuidCount) { }

	[Address(RVA = "0x2BB1D00", Offset = "0x2BB1100", Length = "0x87")]
	[Token(Token = "0x60010C1")]
	internal static int XblPrivacyGetMuteListAsync(IntPtr xblContextHandle, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB1E20", Offset = "0x2BB1220", Length = "0x11D")]
	[Token(Token = "0x60010C3")]
	internal static int XblPrivacyGetMuteListResult(XAsyncBlockPtr async, SizeT xuidCount, out UInt64[] xuids) { }

	[Address(RVA = "0x2BB1D90", Offset = "0x2BB1190", Length = "0x87")]
	[Token(Token = "0x60010C2")]
	internal static int XblPrivacyGetMuteListResultCount(XAsyncBlockPtr async, out SizeT xuidCount) { }

	[Address(RVA = "0x2BB1F40", Offset = "0x2BB1340", Length = "0x93")]
	[Token(Token = "0x60010CD")]
	internal static int XblProfileGetUserProfileAsync(IntPtr xblContextHandle, ulong xboxUserId, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB1FE0", Offset = "0x2BB13E0", Length = "0x12B")]
	[Token(Token = "0x60010CE")]
	internal static int XblProfileGetUserProfileResult(XAsyncBlockPtr async, out XblUserProfile profile) { }

	[Address(RVA = "0x2BB2110", Offset = "0x2BB1510", Length = "0xAC")]
	[Token(Token = "0x60010CF")]
	internal static int XblProfileGetUserProfilesAsync(IntPtr xblContextHandle, UInt64[] xboxUserIds, SizeT xboxUserIdsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB21C0", Offset = "0x2BB15C0", Length = "0x9D")]
	[Token(Token = "0x60010D2")]
	internal static int XblProfileGetUserProfilesForSocialGroupAsync(IntPtr xblContextHandle, Byte[] socialGroup, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB22F0", Offset = "0x2BB16F0", Length = "0x18D")]
	[Token(Token = "0x60010D4")]
	internal static int XblProfileGetUserProfilesForSocialGroupResult(XAsyncBlockPtr async, SizeT profilesCount, out XblUserProfile[] profiles) { }

	[Address(RVA = "0x2BB2260", Offset = "0x2BB1660", Length = "0x87")]
	[Token(Token = "0x60010D3")]
	internal static int XblProfileGetUserProfilesForSocialGroupResultCount(XAsyncBlockPtr async, out SizeT profileCount) { }

	[Address(RVA = "0x2BB2510", Offset = "0x2BB1910", Length = "0x18D")]
	[Token(Token = "0x60010D1")]
	internal static int XblProfileGetUserProfilesResult(XAsyncBlockPtr async, SizeT profilesCount, out XblUserProfile[] profiles) { }

	[Address(RVA = "0x2BB2480", Offset = "0x2BB1880", Length = "0x87")]
	[Token(Token = "0x60010D0")]
	internal static int XblProfileGetUserProfilesResultCount(XAsyncBlockPtr async, out SizeT profileCount) { }

	[Address(RVA = "0x2BB26A0", Offset = "0x2BB1AA0", Length = "0xA0")]
	[Token(Token = "0x60010DE")]
	internal static int XblSocialAddSocialRelationshipChangedHandler(IntPtr xboxLiveContext, XblSocialRelationshipChangedHandler handler, IntPtr handlerContext) { }

	[Address(RVA = "0x2BB2740", Offset = "0x2BB1B40", Length = "0xBF")]
	[Token(Token = "0x60010D5")]
	internal static int XblSocialGetSocialRelationshipsAsync(IntPtr xboxLiveContext, ulong xboxUserId, XblSocialRelationshipFilter socialRelationshipFilter, SizeT startIndex, SizeT maxItems, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB2800", Offset = "0x2BB1C00", Length = "0x87")]
	[Token(Token = "0x60010D6")]
	internal static int XblSocialGetSocialRelationshipsResult(XAsyncBlockPtr async, out XblSocialRelationshipResultHandle handle) { }

	[Address(RVA = "0x2BB2890", Offset = "0x2BB1C90", Length = "0xDC")]
	[Token(Token = "0x60010E3")]
	internal static int XblSocialManagerAddLocalUser(IntPtr user, XblSocialManagerExtraDetailLevel extraLevelDetail, XTaskQueueHandle queue) { }

	[Address(RVA = "0x2BB2970", Offset = "0x2BB1D70", Length = "0xA0")]
	[Token(Token = "0x60010E6")]
	internal static int XblSocialManagerCreateSocialUserGroupFromFilters(IntPtr user, XblPresenceFilter presenceDetailLevel, XblRelationshipFilter filter, out XblSocialManagerUserGroupHandle group) { }

	[Address(RVA = "0x2BB2A10", Offset = "0x2BB1E10", Length = "0xAC")]
	[Token(Token = "0x60010E7")]
	internal static int XblSocialManagerCreateSocialUserGroupFromList(IntPtr user, UInt64[] xboxUserIdList, SizeT xboxUserIdListCount, out XblSocialManagerUserGroupHandle group) { }

	[Address(RVA = "0x2BB2AC0", Offset = "0x2BB1EC0", Length = "0x78")]
	[Token(Token = "0x60010E8")]
	internal static int XblSocialManagerDestroySocialUserGroup(IntPtr group) { }

	[Address(RVA = "0x2BB2B40", Offset = "0x2BB1F40", Length = "0x87")]
	[Token(Token = "0x60010E5")]
	internal static int XblSocialManagerDoWork(out IntPtr socialEvents, out SizeT socialEventsCount) { }

	[Address(RVA = "0x2BB2BD0", Offset = "0x2BB1FD0", Length = "0x68")]
	[Token(Token = "0x60010E9")]
	internal static SizeT XblSocialManagerGetLocalUserCount() { }

	[Address(RVA = "0x2BB2C40", Offset = "0x2BB2040", Length = "0x10C")]
	[Token(Token = "0x60010EA")]
	internal static int XblSocialManagerGetLocalUsers(SizeT usersCount, out IntPtr[] users) { }

	[Address(RVA = "0x2BB2D50", Offset = "0x2BB2150", Length = "0xB9")]
	[Token(Token = "0x60010E0")]
	internal static bool XblSocialManagerPresenceRecordIsUserPlayingTitle(in XblSocialManagerPresenceRecord presenceRecord, uint titleId) { }

	[Address(RVA = "0x2BB2E10", Offset = "0x2BB2210", Length = "0x78")]
	[Token(Token = "0x60010E4")]
	internal static int XblSocialManagerRemoveLocalUser(IntPtr user) { }

	[Address(RVA = "0x2BB2E90", Offset = "0x2BB2290", Length = "0x87")]
	[Token(Token = "0x60010EC")]
	internal static int XblSocialManagerSetRichPresencePollingStatus(IntPtr user, bool shouldEnablePolling) { }

	[Address(RVA = "0x2BB2F20", Offset = "0x2BB2320", Length = "0x9D")]
	[Token(Token = "0x60010EB")]
	internal static int XblSocialManagerUpdateSocialUserGroup(IntPtr group, UInt64[] users, SizeT usersCount) { }

	[Address(RVA = "0x2BB2FC0", Offset = "0x2BB23C0", Length = "0x93")]
	[Token(Token = "0x60010EF")]
	internal static int XblSocialManagerUserGroupGetFilters(IntPtr group, out XblPresenceFilter presenceFilter, out XblRelationshipFilter relationshipFilter) { }

	[Address(RVA = "0x2BB3060", Offset = "0x2BB2460", Length = "0x87")]
	[Token(Token = "0x60010EE")]
	internal static int XblSocialManagerUserGroupGetLocalUser(IntPtr group, out IntPtr localUser) { }

	[Address(RVA = "0x2BB30F0", Offset = "0x2BB24F0", Length = "0x87")]
	[Token(Token = "0x60010ED")]
	internal static int XblSocialManagerUserGroupGetType(IntPtr group, out XblSocialUserGroupType type) { }

	[Address(RVA = "0x2BB3220", Offset = "0x2BB2620", Length = "0x93")]
	[Token(Token = "0x60010E1")]
	internal static int XblSocialManagerUserGroupGetUsers(IntPtr group, out IntPtr xboxSocialUsers, out SizeT usersCount) { }

	[Address(RVA = "0x2BB3180", Offset = "0x2BB2580", Length = "0x93")]
	[Token(Token = "0x60010E2")]
	internal static int XblSocialManagerUserGroupGetUsersTrackedByGroup(IntPtr group, out IntPtr trackedUsers, out SizeT trackedUsersCount) { }

	[Address(RVA = "0x2BB32C0", Offset = "0x2BB26C0", Length = "0x78")]
	[Token(Token = "0x60010DD")]
	internal static void XblSocialRelationshipResultCloseHandle(XblSocialRelationshipResultHandle handle) { }

	[Address(RVA = "0x2BB3340", Offset = "0x2BB2740", Length = "0x87")]
	[Token(Token = "0x60010DC")]
	internal static int XblSocialRelationshipResultDuplicateHandle(XblSocialRelationshipResultHandle handle, out XblSocialRelationshipResultHandle duplicatedHandle) { }

	[Address(RVA = "0x2BB33D0", Offset = "0x2BB27D0", Length = "0xA2")]
	[Token(Token = "0x60010DA")]
	internal static int XblSocialRelationshipResultGetNextAsync(IntPtr xboxLiveContext, XblSocialRelationshipResultHandle resultHandle, SizeT maxItems, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3480", Offset = "0x2BB2880", Length = "0x87")]
	[Token(Token = "0x60010DB")]
	internal static int XblSocialRelationshipResultGetNextResult(XAsyncBlockPtr async, out XblSocialRelationshipResultHandle handle) { }

	[Address(RVA = "0x2BB3510", Offset = "0x2BB2910", Length = "0x93")]
	[Token(Token = "0x60010D7")]
	internal static int XblSocialRelationshipResultGetRelationships(XblSocialRelationshipResultHandle resultHandle, out IntPtr relationships, out SizeT relationshipsCount) { }

	[Address(RVA = "0x2BB35B0", Offset = "0x2BB29B0", Length = "0x87")]
	[Token(Token = "0x60010D9")]
	internal static int XblSocialRelationshipResultGetTotalCount(XblSocialRelationshipResultHandle resultHandle, out SizeT totalCount) { }

	[Address(RVA = "0x2BB3640", Offset = "0x2BB2A40", Length = "0x87")]
	[Token(Token = "0x60010D8")]
	internal static int XblSocialRelationshipResultHasNext(XblSocialRelationshipResultHandle resultHandle, out bool hasNext) { }

	[Address(RVA = "0x2BB36D0", Offset = "0x2BB2AD0", Length = "0x85")]
	[Token(Token = "0x60010DF")]
	internal static int XblSocialRemoveSocialRelationshipChangedHandler(IntPtr xboxLiveContext, int handlerFunctionContext) { }

	[Address(RVA = "0x2BB3760", Offset = "0x2BB2B60", Length = "0x9D")]
	[Token(Token = "0x60010F0")]
	internal static int XblStringVerifyStringAsync(IntPtr xblContextHandle, Byte[] stringToVerify, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3890", Offset = "0x2BB2C90", Length = "0xB2")]
	[Token(Token = "0x60010F2")]
	internal static int XblStringVerifyStringResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB3800", Offset = "0x2BB2C00", Length = "0x87")]
	[Token(Token = "0x60010F1")]
	internal static int XblStringVerifyStringResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB3950", Offset = "0x2BB2D50", Length = "0xA2")]
	[Token(Token = "0x60010F3")]
	internal static int XblStringVerifyStringsAsync(IntPtr xblContextHandle, IntPtr stringsToVerify, ulong stringsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3A90", Offset = "0x2BB2E90", Length = "0xBF")]
	[Token(Token = "0x60010F5")]
	internal static int XblStringVerifyStringsResult(XAsyncBlockPtr async, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBufferStrings, out SizeT stringsCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB3A00", Offset = "0x2BB2E00", Length = "0x87")]
	[Token(Token = "0x60010F4")]
	internal static int XblStringVerifyStringsResultSize(XAsyncBlockPtr async, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB3B50", Offset = "0x2BB2F50", Length = "0xA2")]
	[Token(Token = "0x60010F8")]
	internal static int XblTitleManagedStatsDeleteStatsAsync(IntPtr xblContextHandle, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3C00", Offset = "0x2BB3000", Length = "0xAC")]
	[Token(Token = "0x60010F7")]
	internal static int XblTitleManagedStatsUpdateStatsAsync(IntPtr xblContextHandle, in XblTitleManagedStatistic[] statistics, SizeT statisticsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3CB0", Offset = "0x2BB30B0", Length = "0xBC")]
	[Token(Token = "0x60010F6")]
	internal static int XblTitleManagedStatsWriteAsync(IntPtr xblContextHandle, ulong xboxUserId, in XblTitleManagedStatistic[] statistics, SizeT statisticsCount, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3D70", Offset = "0x2BB3170", Length = "0x78")]
	[Token(Token = "0x60010FE")]
	public static int XblTitleStorageBlobMetadataResultCloseHandle(in IntPtr handle) { }

	[Address(RVA = "0x2BB3DF0", Offset = "0x2BB31F0", Length = "0x87")]
	[Token(Token = "0x60010FD")]
	public static int XblTitleStorageBlobMetadataResultDuplicateHandle(in IntPtr handle, out XblTitleStorageBlobMetadataResultHandle duplicatedHandle) { }

	[Address(RVA = "0x2BB3E80", Offset = "0x2BB3280", Length = "0x93")]
	[Token(Token = "0x60010F9")]
	internal static int XblTitleStorageBlobMetadataResultGetItems(in IntPtr resultHandle, out IntPtr items, out SizeT itemsCount) { }

	[Address(RVA = "0x2BB3F20", Offset = "0x2BB3320", Length = "0x91")]
	[Token(Token = "0x60010FB")]
	public static int XblTitleStorageBlobMetadataResultGetNextAsync(in IntPtr resultHandle, uint maxItems, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB3FC0", Offset = "0x2BB33C0", Length = "0x87")]
	[Token(Token = "0x60010FC")]
	public static int XblTitleStorageBlobMetadataResultGetNextResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadataResultHandle result) { }

	[Address(RVA = "0x2BB4050", Offset = "0x2BB3450", Length = "0x87")]
	[Token(Token = "0x60010FA")]
	internal static int XblTitleStorageBlobMetadataResultHasNext(in IntPtr resultHandle, out bool hasNext) { }

	[Address(RVA = "0x2BB40E0", Offset = "0x2BB34E0", Length = "0x174")]
	[Token(Token = "0x6001103")]
	public static int XblTitleStorageDeleteBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, bool deleteOnlyIfEtagMatches, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB4260", Offset = "0x2BB3660", Length = "0x1B1")]
	[Token(Token = "0x6001104")]
	public static int XblTitleStorageDownloadBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, IntPtr blobBuffer, SizeT blobBufferCount, XblTitleStorageETagMatchCondition etagMatchCondition, Byte[] selectQuery, SizeT preferredDownloadBlockSize, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB4420", Offset = "0x2BB3820", Length = "0x116")]
	[Token(Token = "0x6001105")]
	public static int XblTitleStorageDownloadBlobResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadata blobMetadata) { }

	[Address(RVA = "0x2BB4540", Offset = "0x2BB3940", Length = "0xE9")]
	[Token(Token = "0x6001101")]
	public static int XblTitleStorageGetBlobMetadataAsync(IntPtr xboxLiveContext, Byte[] serviceConfigurationId, XblTitleStorageType storageType, Byte[] blobPath, ulong xboxUserId, uint skipItems, uint maxItems, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB4630", Offset = "0x2BB3A30", Length = "0x87")]
	[Token(Token = "0x6001102")]
	public static int XblTitleStorageGetBlobMetadataResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadataResultHandle result) { }

	[Address(RVA = "0x2BB46C0", Offset = "0x2BB3AC0", Length = "0xAC")]
	[Token(Token = "0x60010FF")]
	public static int XblTitleStorageGetQuotaAsync(IntPtr xboxLiveContext, Byte[] serviceConfigurationId, XblTitleStorageType storageType, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB4770", Offset = "0x2BB3B70", Length = "0x93")]
	[Token(Token = "0x6001100")]
	public static int XblTitleStorageGetQuotaResult(XAsyncBlockPtr async, out SizeT usedBytes, out SizeT quotaBytes) { }

	[Address(RVA = "0x2BB4810", Offset = "0x2BB3C10", Length = "0x197")]
	[Token(Token = "0x6001106")]
	public static int XblTitleStorageUploadBlobAsync(IntPtr xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, IntPtr blobBuffer, SizeT blobBufferCount, XblTitleStorageETagMatchCondition etagMatchCondition, SizeT preferredUploadBlockSize, XAsyncBlockPtr async) { }

	[Address(RVA = "0x2BB49B0", Offset = "0x2BB3DB0", Length = "0x116")]
	[Token(Token = "0x6001107")]
	public static int XblTitleStorageUploadBlobResult(XAsyncBlockPtr async, out XblTitleStorageBlobMetadata blobMetadata) { }

	[Address(RVA = "0x2BB4AD0", Offset = "0x2BB3ED0", Length = "0xA0")]
	[Token(Token = "0x6001114")]
	internal static XblFunctionContext XblUserStatisticsAddStatisticChangedHandler(IntPtr xblContextHandle, XblStatisticChangedHandler handler, IntPtr handlerContext) { }

	[Address(RVA = "0x2BB4B70", Offset = "0x2BB3F70", Length = "0xE0")]
	[Token(Token = "0x600110E")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsAsync(IntPtr xblContextHandle, UInt64[] xboxUserIds, SizeT xboxUserIdsCount, Byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB4C50", Offset = "0x2BB4050", Length = "0xC7")]
	[Token(Token = "0x6001111")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync(IntPtr xblContextHandle, UInt64[] xboxUserIds, uint xboxUserIdsCount, IntPtr requestedServiceConfigurationStatisticsCollection, uint requestedServiceConfigurationStatisticsCollectionCount, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB4DB0", Offset = "0x2BB41B0", Length = "0xBF")]
	[Token(Token = "0x6001113")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr results, out SizeT resultsCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB4D20", Offset = "0x2BB4120", Length = "0x87")]
	[Token(Token = "0x6001112")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB4F00", Offset = "0x2BB4300", Length = "0xBF")]
	[Token(Token = "0x6001110")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT resultsCount, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB4E70", Offset = "0x2BB4270", Length = "0x87")]
	[Token(Token = "0x600110F")]
	internal static int XblUserStatisticsGetMultipleUserStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB4FC0", Offset = "0x2BB43C0", Length = "0xC8")]
	[Token(Token = "0x6001108")]
	internal static int XblUserStatisticsGetSingleUserStatisticAsync(IntPtr xblContextHandle, ulong xboxUserId, Byte[] serviceConfigurationId, Byte[] statisticName, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB5120", Offset = "0x2BB4520", Length = "0xB2")]
	[Token(Token = "0x600110A")]
	internal static int XblUserStatisticsGetSingleUserStatisticResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB5090", Offset = "0x2BB4490", Length = "0x87")]
	[Token(Token = "0x6001109")]
	internal static int XblUserStatisticsGetSingleUserStatisticResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB51E0", Offset = "0x2BB45E0", Length = "0xC9")]
	[Token(Token = "0x600110B")]
	internal static int XblUserStatisticsGetSingleUserStatisticsAsync(IntPtr xblContextHandle, ulong xboxUserId, Byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB5340", Offset = "0x2BB4740", Length = "0xB2")]
	[Token(Token = "0x600110D")]
	internal static int XblUserStatisticsGetSingleUserStatisticsResult(XAsyncBlockPtr asyncBlock, SizeT bufferSize, IntPtr buffer, out IntPtr ptrToBuffer, out SizeT bufferUsed) { }

	[Address(RVA = "0x2BB52B0", Offset = "0x2BB46B0", Length = "0x87")]
	[Token(Token = "0x600110C")]
	internal static int XblUserStatisticsGetSingleUserStatisticsResultSize(XAsyncBlockPtr asyncBlock, out SizeT resultSizeInBytes) { }

	[Address(RVA = "0x2BB5400", Offset = "0x2BB4800", Length = "0x87")]
	[Token(Token = "0x6001115")]
	internal static void XblUserStatisticsRemoveStatisticChangedHandler(IntPtr xblContextHandle, IntPtr context) { }

	[Address(RVA = "0x2BB5490", Offset = "0x2BB4890", Length = "0xD5")]
	[Token(Token = "0x6001117")]
	internal static int XblUserStatisticsStopTrackingStatistics(XblContextHandle xblContextHandle, UInt64[] xboxUserIds, SizeT xboxUserIdsCount, Byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount) { }

	[Address(RVA = "0x2BB5570", Offset = "0x2BB4970", Length = "0xD5")]
	[Token(Token = "0x6001116")]
	internal static int XblUserStatisticsTrackStatistics(XblContextHandle xblContextHandle, UInt64[] xboxUserIds, SizeT xboxUserIdsCount, Byte[] serviceConfigurationId, IntPtr statisticNames, SizeT statisticNamesCount) { }

	[Address(RVA = "0x2BB5650", Offset = "0x2BB4A50", Length = "0x78")]
	[Token(Token = "0x600111D")]
	internal static int XblWrapper_XblCleanupAsync(XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BB56D0", Offset = "0x2BB4AD0", Length = "0xDC")]
	[Token(Token = "0x600111C")]
	internal static int XblWrapper_XblInitialize(Byte[] scid, XTaskQueueHandle internalWorkQueue) { }

}

