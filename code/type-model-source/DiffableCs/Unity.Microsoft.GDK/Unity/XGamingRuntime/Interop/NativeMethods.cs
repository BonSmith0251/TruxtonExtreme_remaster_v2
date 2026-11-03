namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002BF")]
internal class NativeMethods
{
	[Token(Token = "0x4000755")]
	internal const int MAX_PATH = 260; //Field offset: 0x0
	[Token(Token = "0x4000756")]
	internal const int APPCAPTURE_MAX_CAPTURE_FILES = 10; //Field offset: 0x0
	[Token(Token = "0x4000757")]
	internal const int APPCAPTURE_MAX_LOCALID_LENGTH = 250; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F95")]
	public NativeMethods() { }

	[Address(RVA = "0x2B8EE50", Offset = "0x2B8E250", Length = "0x87")]
	[Token(Token = "0x6000E39")]
	internal static int XAppBroadcastGetStatus(IntPtr requestingUser, out XAppBroadcastStatus appBroadcastStatus) { }

	[Address(RVA = "0x2B8EEE0", Offset = "0x2B8E2E0", Length = "0x6D")]
	[Token(Token = "0x6000E3A")]
	internal static bool XAppBroadcastIsAppBroadcasting() { }

	[Address(RVA = "0x2B8EF50", Offset = "0x2B8E350", Length = "0xAF")]
	[Token(Token = "0x6000E3C")]
	internal static int XAppBroadcastRegisterIsAppBroadcastingChanged(IntPtr queue, IntPtr context, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out ulong token) { }

	[Address(RVA = "0x2B8F000", Offset = "0x2B8E400", Length = "0x78")]
	[Token(Token = "0x6000E3B")]
	internal static int XAppBroadcastShowUI(IntPtr requestingUser) { }

	[Address(RVA = "0x2B8F080", Offset = "0x2B8E480", Length = "0x8C")]
	[Token(Token = "0x6000E40")]
	internal static bool XAppBroadcastUnregisterIsAppBroadcastingChanged(ulong token, bool wait) { }

	[Address(RVA = "0x2B8F110", Offset = "0x2B8E510", Length = "0x78")]
	[Token(Token = "0x6000E52")]
	internal static int XAppCaptureCloseLocalStream(IntPtr handle) { }

	[Address(RVA = "0x2B8F190", Offset = "0x2B8E590", Length = "0x78")]
	[Token(Token = "0x6000E3D")]
	internal static int XAppCaptureCloseScreenshotStream(IntPtr handle) { }

	[Address(RVA = "0x2B8F210", Offset = "0x2B8E610", Length = "0x68")]
	[Token(Token = "0x6000E3F")]
	internal static int XAppCaptureDisableRecord() { }

	[Address(RVA = "0x2B8F280", Offset = "0x2B8E680", Length = "0x68")]
	[Token(Token = "0x6000E3E")]
	internal static int XAppCaptureEnableRecord() { }

	[Address(RVA = "0x2B8F2F0", Offset = "0x2B8E6F0", Length = "0x78")]
	[Token(Token = "0x6000E54")]
	internal static int XAppCaptureGetVideoCaptureSettings(out XAppCaptureVideoCaptureSettings userCaptureSettings) { }

	[Address(RVA = "0x2B8F370", Offset = "0x2B8E770", Length = "0xB5")]
	[Token(Token = "0x6000E43")]
	internal static int XAppCaptureMetadataAddDoubleEvent(string name, double value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F430", Offset = "0x2B8E830", Length = "0xB0")]
	[Token(Token = "0x6000E42")]
	internal static int XAppCaptureMetadataAddInt32Event(string name, int value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F4E0", Offset = "0x2B8E8E0", Length = "0xC5")]
	[Token(Token = "0x6000E41")]
	internal static int XAppCaptureMetadataAddStringEvent(string name, string value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F5B0", Offset = "0x2B8E9B0", Length = "0x78")]
	[Token(Token = "0x6000E49")]
	internal static int XAppCaptureMetadataRemainingStorageBytesAvailable(out ulong value) { }

	[Address(RVA = "0x2B8F630", Offset = "0x2B8EA30", Length = "0xB5")]
	[Token(Token = "0x6000E46")]
	internal static int XAppCaptureMetadataStartDoubleState(string name, double value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F6F0", Offset = "0x2B8EAF0", Length = "0xB0")]
	[Token(Token = "0x6000E45")]
	internal static int XAppCaptureMetadataStartInt32State(string name, int value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F7A0", Offset = "0x2B8EBA0", Length = "0xC5")]
	[Token(Token = "0x6000E44")]
	internal static int XAppCaptureMetadataStartStringState(string name, string value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B8F870", Offset = "0x2B8EC70", Length = "0x68")]
	[Token(Token = "0x6000E48")]
	internal static int XAppCaptureMetadataStopAllStates() { }

	[Address(RVA = "0x2B8F8E0", Offset = "0x2B8ECE0", Length = "0x9D")]
	[Token(Token = "0x6000E47")]
	internal static int XAppCaptureMetadataStopState(string name) { }

	[Address(RVA = "0x2B8F980", Offset = "0x2B8ED80", Length = "0xBF")]
	[Token(Token = "0x6000E4A")]
	internal static int XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag screenshotFormat, out IntPtr handle, out ulong totalBytes) { }

	[Address(RVA = "0x2B8FA40", Offset = "0x2B8EE40", Length = "0xBC")]
	[Token(Token = "0x6000E51")]
	internal static int XAppCaptureReadLocalStream(IntPtr handle, long startPosition, uint bytesToRead, out Byte[] buffer, out uint bytesWritten) { }

	[Address(RVA = "0x2B8FB00", Offset = "0x2B8EF00", Length = "0xBC")]
	[Token(Token = "0x6000E4B")]
	internal static int XAppCaptureReadScreenshotStream(IntPtr handle, ulong startPosition, uint bytesToRead, out Byte[] buffer, out uint bytesWritten) { }

	[Address(RVA = "0x2B8FBC0", Offset = "0x2B8EFC0", Length = "0x191")]
	[Token(Token = "0x6000E4C")]
	internal static int XAppCaptureRecordDiagnosticClip(long startTime, uint durationInMs, string filenamePrefix, out XAppCaptureRecordClipResult result) { }

	[Address(RVA = "0x2B8FD60", Offset = "0x2B8F160", Length = "0x93")]
	[Token(Token = "0x6000E53")]
	internal static int XAppCaptureRecordTimespan(IntPtr startTimestamp, ulong durationInMilliseconds, out XAppCaptureLocalResult result) { }

	[Address(RVA = "0x2B8FE00", Offset = "0x2B8F200", Length = "0xAF")]
	[Token(Token = "0x6000E4F")]
	internal static int XAppCaptureRegisterMetadataPurged(IntPtr queue, IntPtr context, XAppCaptureMetadataPurgedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B8FEB0", Offset = "0x2B8F2B0", Length = "0x201")]
	[Token(Token = "0x6000E4D")]
	internal static int XAppCaptureTakeDiagnosticScreenshot(bool gamescreenOnly, XAppCaptureScreenshotFormatFlag captureFlags, string filenamePrefix, out XAppCaptureDiagnosticScreenshotResult result) { }

	[Address(RVA = "0x2B900C0", Offset = "0x2B8F4C0", Length = "0x100")]
	[Token(Token = "0x6000E4E")]
	internal static int XAppCaptureTakeScreenshot(IntPtr requestingUser, out XAppCaptureTakeScreenshotResult result) { }

	[Address(RVA = "0x2B901C0", Offset = "0x2B8F5C0", Length = "0x8C")]
	[Token(Token = "0x6000E50")]
	internal static bool XAppCaptureUnRegisterMetadataPurged(ulong token, bool wait) { }

	[Address(RVA = "0x2B90250", Offset = "0x2B8F650", Length = "0xDC")]
	[Token(Token = "0x6000E59")]
	internal static int XAsyncBegin(IntPtr asyncInterop, IntPtr context, IntPtr identity, string identityName, XAsyncProviderInterop provider) { }

	[Address(RVA = "0x2B90330", Offset = "0x2B8F730", Length = "0x78")]
	[Token(Token = "0x6000E57")]
	internal static void XAsyncCancel(IntPtr asyncBlock) { }

	[Address(RVA = "0x2B903B0", Offset = "0x2B8F7B0", Length = "0x91")]
	[Token(Token = "0x6000E5B")]
	internal static void XAsyncComplete(IntPtr asyncInterop, uint result, ulong requiredBufferSize) { }

	[Address(RVA = "0x2B904E0", Offset = "0x2B8F8E0", Length = "0xBC")]
	[Token(Token = "0x6000E5C")]
	internal static int XAsyncGetResult(IntPtr asyncInterop, IntPtr identity, ulong bufferSize, out Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B90450", Offset = "0x2B8F850", Length = "0x87")]
	[Token(Token = "0x6000E56")]
	internal static int XAsyncGetResultSize(IntPtr asyncBlock, out ulong bufferSize) { }

	[Address(RVA = "0x2B905A0", Offset = "0x2B8F9A0", Length = "0x87")]
	[Token(Token = "0x6000E55")]
	internal static int XAsyncGetStatus(IntPtr asyncBlock, bool wait) { }

	[Address(RVA = "0x2B90630", Offset = "0x2B8FA30", Length = "0x94")]
	[Token(Token = "0x6000E58")]
	internal static int XAsyncRun(IntPtr asyncBlock, XAsyncWorkInterop work) { }

	[Address(RVA = "0x2B906D0", Offset = "0x2B8FAD0", Length = "0x85")]
	[Token(Token = "0x6000E5A")]
	internal static int XAsyncSchedule(IntPtr asyncInterop, uint delayInMs) { }

	[Address(RVA = "0x2B90760", Offset = "0x2B8FB60", Length = "0x78")]
	[Token(Token = "0x6000E30")]
	internal static int XClosedCaptionGetProperties(out XClosedCaptionProperties properties) { }

	[Address(RVA = "0x2B907E0", Offset = "0x2B8FBE0", Length = "0x78")]
	[Token(Token = "0x6000E31")]
	internal static int XClosedCaptionSetEnabled(bool enabled) { }

	[Address(RVA = "0x2B90860", Offset = "0x2B8FC60", Length = "0x78")]
	[Token(Token = "0x6000E5E")]
	internal static int XDisplayAcquireTimeoutDeferral(out IntPtr handle) { }

	[Address(RVA = "0x2B908E0", Offset = "0x2B8FCE0", Length = "0x78")]
	[Token(Token = "0x6000E5F")]
	internal static int XDisplayCloseTimeoutDeferralHandle(IntPtr handle) { }

	[Address(RVA = "0x2B90960", Offset = "0x2B8FD60", Length = "0x85")]
	[Token(Token = "0x6000E5D")]
	internal static XDisplayHdrModeResult XDisplayTryEnableHdrMode(XDisplayHdrModePreference displayModePreference, out XDisplayHdrModeInfo displayHdrModeInfo) { }

	[Address(RVA = "0x2B909F0", Offset = "0x2B8FDF0", Length = "0x91")]
	[Token(Token = "0x6000E60")]
	internal static void XErrorSetCallback(XErrorCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B90A90", Offset = "0x2B8FE90", Length = "0x83")]
	[Token(Token = "0x6000E61")]
	internal static void XErrorSetOptions(XErrorOptions optionsDebuggerPresent, XErrorOptions optionsDebuggerNotPresent) { }

	[Address(RVA = "0x2B90B20", Offset = "0x2B8FF20", Length = "0x132")]
	[Token(Token = "0x6000E62")]
	internal static int XGameEventWrite(IntPtr user, string serviceConfigId, string playSessionId, string eventName, string dimensionsJson, string measurementsJson) { }

	[Address(RVA = "0x2B90C60", Offset = "0x2B90060", Length = "0x78")]
	[Token(Token = "0x6000E63")]
	internal static int XGameGetXboxTitleId(out uint titleId) { }

	[Address(RVA = "0x2B90CE0", Offset = "0x2B900E0", Length = "0xAF")]
	[Token(Token = "0x6000E66")]
	internal static int XGameInviteRegisterForEvent(IntPtr queue, IntPtr context, XGameInviteEventCallback callback, out ulong token) { }

	[Address(RVA = "0x2B90D90", Offset = "0x2B90190", Length = "0x8C")]
	[Token(Token = "0x6000E67")]
	internal static bool XGameInviteUnregisterForEvent(ulong token, bool wait) { }

	[Address(RVA = "0x2B90E20", Offset = "0x2B90220", Length = "0xAF")]
	[Token(Token = "0x6000E68")]
	internal static int XGameProtocolRegisterForActivation(IntPtr queue, IntPtr context, XGameProtocolActivationCallback callback, out ulong token) { }

	[Address(RVA = "0x2B90ED0", Offset = "0x2B902D0", Length = "0x8C")]
	[Token(Token = "0x6000E69")]
	internal static bool XGameProtocolUnregisterForActivation(ulong token, bool wait) { }

	[Address(RVA = "0x2B91010", Offset = "0x2B90410", Length = "0x68")]
	[Token(Token = "0x6000E6B")]
	internal static int XGameRuntimeInitialize() { }

	[Address(RVA = "0x2B90F60", Offset = "0x2B90360", Length = "0xAD")]
	[Token(Token = "0x6000E6C")]
	internal static int XGameRuntimeInitializeWithOptions(XGameRuntimeOptions options) { }

	[Address(RVA = "0x2B91080", Offset = "0x2B90480", Length = "0x7B")]
	[Token(Token = "0x6000E6A")]
	internal static bool XGameRuntimeIsFeatureAvailable(XGameRuntimeFeature feature) { }

	[Address(RVA = "0x2B91100", Offset = "0x2B90500", Length = "0x68")]
	[Token(Token = "0x6000E6D")]
	internal static void XGameRuntimeUninitialize() { }

	[Address(RVA = "0x2B91170", Offset = "0x2B90570", Length = "0x78")]
	[Token(Token = "0x6000E7F")]
	internal static void XGameSaveCloseContainer(IntPtr context) { }

	[Address(RVA = "0x2B911F0", Offset = "0x2B905F0", Length = "0x78")]
	[Token(Token = "0x6000E74")]
	internal static void XGameSaveCloseProvider(IntPtr provider) { }

	[Address(RVA = "0x2B91270", Offset = "0x2B90670", Length = "0x78")]
	[Token(Token = "0x6000E86")]
	internal static int XGameSaveCloseUpdate(IntPtr context) { }

	[Address(RVA = "0x2B912F0", Offset = "0x2B906F0", Length = "0xB0")]
	[Token(Token = "0x6000E7E")]
	internal static int XGameSaveCreateContainer(IntPtr provider, string containerName, out IntPtr containerContext) { }

	[Address(RVA = "0x2B913A0", Offset = "0x2B907A0", Length = "0xB0")]
	[Token(Token = "0x6000E85")]
	internal static int XGameSaveCreateUpdate(IntPtr container, string containerDisplayName, out IntPtr updateContext) { }

	[Address(RVA = "0x2B91580", Offset = "0x2B90980", Length = "0xAA")]
	[Token(Token = "0x6000E78")]
	internal static int XGameSaveDeleteContainer(IntPtr provider, string containerName) { }

	[Address(RVA = "0x2B91450", Offset = "0x2B90850", Length = "0xB0")]
	[Token(Token = "0x6000E79")]
	internal static int XGameSaveDeleteContainerAsync(IntPtr provider, string containerName, IntPtr async) { }

	[Address(RVA = "0x2B91500", Offset = "0x2B90900", Length = "0x78")]
	[Token(Token = "0x6000E7A")]
	internal static int XGameSaveDeleteContainerResult(IntPtr async) { }

	[Address(RVA = "0x2B91700", Offset = "0x2B90B00", Length = "0xA0")]
	[Token(Token = "0x6000E80")]
	internal static int XGameSaveEnumerateBlobInfo(IntPtr container, IntPtr context, XGameSaveBlobInfoCallback callback) { }

	[Address(RVA = "0x2B91630", Offset = "0x2B90A30", Length = "0xC7")]
	[Token(Token = "0x6000E81")]
	internal static int XGameSaveEnumerateBlobInfoByName(IntPtr container, string blobNamePrefix, IntPtr context, XGameSaveBlobInfoCallback callback) { }

	[Address(RVA = "0x2B91870", Offset = "0x2B90C70", Length = "0xA0")]
	[Token(Token = "0x6000E7C")]
	internal static int XGameSaveEnumerateContainerInfo(IntPtr provider, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B917A0", Offset = "0x2B90BA0", Length = "0xC7")]
	[Token(Token = "0x6000E7D")]
	internal static int XGameSaveEnumerateContainerInfoByName(IntPtr provider, string containerNamePrefix, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B91910", Offset = "0x2B90D10", Length = "0xB0")]
	[Token(Token = "0x6000E6E")]
	internal static int XGameSaveFilesGetFolderWithUiAsync(IntPtr requestingUser, string configurationId, IntPtr async) { }

	[Address(RVA = "0x2B919C0", Offset = "0x2B90DC0", Length = "0xC4")]
	[Token(Token = "0x6000E6F")]
	internal static int XGameSaveFilesGetFolderWithUiResult(IntPtr async, ulong folderSize, StringBuilder folderResult) { }

	[Address(RVA = "0x2B91A90", Offset = "0x2B90E90", Length = "0xB0")]
	[Token(Token = "0x6000E70")]
	internal static int XGameSaveFilesGetRemainingQuota(IntPtr userContext, string configurationId, out ulong remainingQuota) { }

	[Address(RVA = "0x2B91B40", Offset = "0x2B90F40", Length = "0xC7")]
	[Token(Token = "0x6000E7B")]
	internal static int XGameSaveGetContainerInfo(IntPtr provider, string containerName, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B91D30", Offset = "0x2B91130", Length = "0x87")]
	[Token(Token = "0x6000E75")]
	internal static int XGameSaveGetRemainingQuota(IntPtr provider, out long remainingQuota) { }

	[Address(RVA = "0x2B91C10", Offset = "0x2B91010", Length = "0x87")]
	[Token(Token = "0x6000E76")]
	internal static int XGameSaveGetRemainingQuotaAsync(IntPtr provider, IntPtr xAsyncBlockInterop) { }

	[Address(RVA = "0x2B91CA0", Offset = "0x2B910A0", Length = "0x87")]
	[Token(Token = "0x6000E77")]
	internal static int XGameSaveGetRemainingQuotaResult(IntPtr async, out long remainingQuota) { }

	[Address(RVA = "0x2B91F20", Offset = "0x2B91320", Length = "0xC1")]
	[Token(Token = "0x6000E71")]
	internal static int XGameSaveInitializeProvider(IntPtr requestingUser, string configurationId, bool syncOnDemand, out IntPtr provider) { }

	[Address(RVA = "0x2B91DC0", Offset = "0x2B911C0", Length = "0xC1")]
	[Token(Token = "0x6000E72")]
	internal static int XGameSaveInitializeProviderAsync(IntPtr requestingUser, string configurationId, bool syncOnDemand, IntPtr async) { }

	[Address(RVA = "0x2B91E90", Offset = "0x2B91290", Length = "0x87")]
	[Token(Token = "0x6000E73")]
	internal static int XGameSaveInitializeProviderResult(IntPtr async, out IntPtr provider) { }

	[Address(RVA = "0x2B92220", Offset = "0x2B91620", Length = "0x194")]
	[Token(Token = "0x6000E82")]
	internal static int XGameSaveReadBlobData(IntPtr container, String[] blobNames, ref uint countOfBlobs, ulong blobsSize, IntPtr blobData) { }

	[Address(RVA = "0x2B91FF0", Offset = "0x2B913F0", Length = "0x17A")]
	[Token(Token = "0x6000E83")]
	internal static int XGameSaveReadBlobDataAsync(IntPtr container, String[] blobNames, uint countOfBlobs, IntPtr async) { }

	[Address(RVA = "0x2B92170", Offset = "0x2B91570", Length = "0xA2")]
	[Token(Token = "0x6000E84")]
	internal static int XGameSaveReadBlobDataResult(IntPtr async, ulong blobsSize, IntPtr blobData, out uint countOfBlobs) { }

	[Address(RVA = "0x2B923C0", Offset = "0x2B917C0", Length = "0xAA")]
	[Token(Token = "0x6000E88")]
	internal static int XGameSaveSubmitBlobDelete(IntPtr updateContext, string blobName) { }

	[Address(RVA = "0x2B92470", Offset = "0x2B91870", Length = "0xC9")]
	[Token(Token = "0x6000E87")]
	internal static int XGameSaveSubmitBlobWrite(IntPtr updateContext, string blobName, out Byte[] data, ulong byteCount) { }

	[Address(RVA = "0x2B92650", Offset = "0x2B91A50", Length = "0x78")]
	[Token(Token = "0x6000E89")]
	internal static int XGameSaveSubmitUpdate(IntPtr updateContext) { }

	[Address(RVA = "0x2B92540", Offset = "0x2B91940", Length = "0x87")]
	[Token(Token = "0x6000E8A")]
	internal static int XGameSaveSubmitUpdateAsync(IntPtr updateContext, IntPtr async) { }

	[Address(RVA = "0x2B925D0", Offset = "0x2B919D0", Length = "0x78")]
	[Token(Token = "0x6000E8B")]
	internal static int XGameSaveSubmitUpdateResult(IntPtr async) { }

	[Address(RVA = "0x2B926D0", Offset = "0x2B91AD0", Length = "0x87")]
	[Token(Token = "0x6000EA0")]
	internal static int XGameStreamingGetAssociatedFrame(IntPtr gamepadReading, out ulong framePipelineToken) { }

	[Address(RVA = "0x2B92760", Offset = "0x2B91B60", Length = "0x68")]
	[Token(Token = "0x6000E8F")]
	internal static uint XGameStreamingGetClientCount() { }

	[Address(RVA = "0x2B927D0", Offset = "0x2B91BD0", Length = "0xC4")]
	[Token(Token = "0x6000EA8")]
	internal static int XGameStreamingGetClientIPAddress(XGameStreamingClientId client, ulong ipAddressSize, StringBuilder ipAddress) { }

	[Address(RVA = "0x2B928A0", Offset = "0x2B91CA0", Length = "0x9B")]
	[Token(Token = "0x6000E90")]
	internal static int XGameStreamingGetClients(uint clientCount, out XGameStreamingClientId[] clients, out uint clientUsed) { }

	[Address(RVA = "0x2B92940", Offset = "0x2B91D40", Length = "0x78")]
	[Token(Token = "0x6000E91")]
	internal static XGameStreamingConnectionState XGameStreamingGetConnectionState(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B929C0", Offset = "0x2B91DC0", Length = "0xBB")]
	[Token(Token = "0x6000EAA")]
	internal static int XGameStreamingGetDisplayDetails(XGameStreamingClientId clientId, uint maxSupportedPixels, float widestSupportedAspectRatio, float tallestSupportedAspectRatio, out XGameStreamingDisplayDetails displayDetails) { }

	[Address(RVA = "0x2B92A80", Offset = "0x2B91E80", Length = "0x87")]
	[Token(Token = "0x6000EA1")]
	internal static int XGameStreamingGetGamepadPhysicality(IntPtr gamepadReading, out XGameStreamingGamepadPhysicality gamepadPhysicality) { }

	[Address(RVA = "0x2B92B10", Offset = "0x2B91F10", Length = "0x87")]
	[Token(Token = "0x6000E9F")]
	internal static int XGameStreamingGetLastFrameDisplayed(XGameStreamingClientId client, out ulong framePipelineToken) { }

	[Address(RVA = "0x2B92C10", Offset = "0x2B92010", Length = "0xB5")]
	[Token(Token = "0x6000E9D")]
	internal static int XGameStreamingGetServerLocationName(ulong serverLocationNameSize, StringBuilder serverLocationName) { }

	[Address(RVA = "0x2B92BA0", Offset = "0x2B91FA0", Length = "0x68")]
	[Token(Token = "0x6000E9C")]
	internal static ulong XGameStreamingGetServerLocationNameSize() { }

	[Address(RVA = "0x2B92CD0", Offset = "0x2B920D0", Length = "0xD5")]
	[Token(Token = "0x6000EA9")]
	internal static int XGameStreamingGetSessionId(XGameStreamingClientId client, ulong sessionIdSize, StringBuilder sessionId, out ulong sessionIdUsed) { }

	[Address(RVA = "0x2B92DB0", Offset = "0x2B921B0", Length = "0xA2")]
	[Token(Token = "0x6000E9B")]
	internal static int XGameStreamingGetStreamAddedLatency(XGameStreamingClientId client, out uint averageInputLatencyUs, out uint averageOutputLatencyUs, out uint standardDeviationUs) { }

	[Address(RVA = "0x2B92E60", Offset = "0x2B92260", Length = "0x93")]
	[Token(Token = "0x6000E9A")]
	internal static int XGameStreamingGetStreamPhysicalDimensions(XGameStreamingClientId client, out uint horizontalMm, out uint verticalMm) { }

	[Address(RVA = "0x2B92F80", Offset = "0x2B92380", Length = "0xD5")]
	[Token(Token = "0x6000EA7")]
	internal static int XGameStreamingGetTouchBundleVersion(XGameStreamingClientId client, out XVersion version, ulong versionNameSize, StringBuilder versionName) { }

	[Address(RVA = "0x2B92F00", Offset = "0x2B92300", Length = "0x78")]
	[Token(Token = "0x6000EA6")]
	internal static ulong XGameStreamingGetTouchBundleVersionNameSize(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B930E0", Offset = "0x2B924E0", Length = "0x68")]
	[Token(Token = "0x6000E94")]
	internal static void XGameStreamingHideTouchControls() { }

	[Address(RVA = "0x2B93060", Offset = "0x2B92460", Length = "0x78")]
	[Token(Token = "0x6000E95")]
	internal static void XGameStreamingHideTouchControlsOnClient(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B93150", Offset = "0x2B92550", Length = "0x68")]
	[Token(Token = "0x6000E8C")]
	internal static int XGameStreamingInitialize() { }

	[Address(RVA = "0x2B931C0", Offset = "0x2B925C0", Length = "0x6D")]
	[Token(Token = "0x6000E8E")]
	internal static bool XGameStreamingIsStreaming() { }

	[Address(RVA = "0x2B93230", Offset = "0x2B92630", Length = "0x87")]
	[Token(Token = "0x6000E9E")]
	internal static int XGameStreamingIsTouchInputEnabled(XGameStreamingClientId client, out bool touchInputEnabled) { }

	[Address(RVA = "0x2B932C0", Offset = "0x2B926C0", Length = "0xB2")]
	[Token(Token = "0x6000E98")]
	internal static int XGameStreamingRegisterClientPropertiesChanged(XGameStreamingClientId client, IntPtr queue, IntPtr context, XGameStreamingClientPropertiesChangedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B93380", Offset = "0x2B92780", Length = "0xAF")]
	[Token(Token = "0x6000E92")]
	internal static int XGameStreamingRegisterConnectionStateChanged(IntPtr queue, IntPtr context, XGameStreamingConnectionStateChangedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B93430", Offset = "0x2B92830", Length = "0x83")]
	[Token(Token = "0x6000EAB")]
	internal static int XGameStreamingSetResolution(uint width, uint height) { }

	[Address(RVA = "0x2B93560", Offset = "0x2B92960", Length = "0x8C")]
	[Token(Token = "0x6000E96")]
	internal static void XGameStreamingShowTouchControlLayout(string layout) { }

	[Address(RVA = "0x2B934C0", Offset = "0x2B928C0", Length = "0x9B")]
	[Token(Token = "0x6000E97")]
	internal static void XGameStreamingShowTouchControlLayoutOnClient(XGameStreamingClientId client, string layout) { }

	[Address(RVA = "0x2B93790", Offset = "0x2B92B90", Length = "0x1BD")]
	[Token(Token = "0x6000EA4")]
	internal static int XGameStreamingShowTouchControlsWithStateUpdate(string layout, ulong operatoinCount, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B935F0", Offset = "0x2B929F0", Length = "0x194")]
	[Token(Token = "0x6000EA5")]
	internal static int XGameStreamingShowTouchControlsWithStateUpdateOnClient(XGameStreamingClientId client, string layout, ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B93950", Offset = "0x2B92D50", Length = "0x68")]
	[Token(Token = "0x6000E8D")]
	internal static void XGameStreamingUninitialize() { }

	[Address(RVA = "0x2B939C0", Offset = "0x2B92DC0", Length = "0x9A")]
	[Token(Token = "0x6000E99")]
	internal static bool XGameStreamingUnregisterClientPropertiesChanged(XGameStreamingClientId client, ulong token, bool wait) { }

	[Address(RVA = "0x2B93A60", Offset = "0x2B92E60", Length = "0x8C")]
	[Token(Token = "0x6000E93")]
	internal static bool XGameStreamingUnregisterConnectionStateChanged(ulong token, bool wait) { }

	[Address(RVA = "0x2B93C80", Offset = "0x2B93080", Length = "0x183")]
	[Token(Token = "0x6000EA2")]
	internal static int XGameStreamingUpdateTouchControlsState(ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B93AF0", Offset = "0x2B92EF0", Length = "0x184")]
	[Token(Token = "0x6000EA3")]
	internal static int XGameStreamingUpdateTouchControlsStateOnClient(XGameStreamingClientId client, ulong operationCount, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B93E10", Offset = "0x2B93210", Length = "0x76")]
	[Token(Token = "0x6000EBB")]
	internal static int XGameUiSetNotificationPositionHint(XGameUiNotificationPositionHint position) { }

	[Address(RVA = "0x2B93E90", Offset = "0x2B93290", Length = "0x93")]
	[Token(Token = "0x6000EB4")]
	internal static int XGameUiShowAchievementsAsync(IntPtr async, IntPtr requestingUser, uint titleId) { }

	[Address(RVA = "0x2B93F30", Offset = "0x2B93330", Length = "0x78")]
	[Token(Token = "0x6000EB5")]
	internal static int XGameUiShowAchievementsResult(IntPtr async) { }

	[Address(RVA = "0x2B93FB0", Offset = "0x2B933B0", Length = "0xB7")]
	[Token(Token = "0x6000EB9")]
	internal static int XGameUiShowErrorDialogAsync(IntPtr async, int errorCode, string context) { }

	[Address(RVA = "0x2B94070", Offset = "0x2B93470", Length = "0x78")]
	[Token(Token = "0x6000EBA")]
	internal static int XGameUiShowErrorDialogResult(IntPtr async) { }

	[Address(RVA = "0x2B940F0", Offset = "0x2B934F0", Length = "0x148")]
	[Token(Token = "0x6000EAC")]
	internal static int XGameUiShowMessageDialogAsync(IntPtr async, string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton) { }

	[Address(RVA = "0x2B94240", Offset = "0x2B93640", Length = "0x87")]
	[Token(Token = "0x6000EAD")]
	internal static int XGameUiShowMessageDialogResult(IntPtr async, out XGameUiMessageDialogButton resultButton) { }

	[Address(RVA = "0x2B942D0", Offset = "0x2B936D0", Length = "0x87")]
	[Token(Token = "0x6000EB0")]
	internal static int XGameUiShowMultiplayerActivityGameInviteAsync(IntPtr async, IntPtr requestingUser) { }

	[Address(RVA = "0x2B94360", Offset = "0x2B93760", Length = "0x78")]
	[Token(Token = "0x6000EB1")]
	internal static int XGameUiShowMultiplayerActivityGameInviteResult(IntPtr async) { }

	[Address(RVA = "0x2B943E0", Offset = "0x2B937E0", Length = "0x119")]
	[Token(Token = "0x6000EB6")]
	internal static int XGameUiShowPlayerPickerAsync(IntPtr async, IntPtr requestingUser, string promptText, uint selectFromPlayersCount, UInt64[] selectFromPlayers, uint preSelectedPlayersCount, UInt64[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount) { }

	[Address(RVA = "0x2B94590", Offset = "0x2B93990", Length = "0xAA")]
	[Token(Token = "0x6000EB8")]
	internal static int XGameUiShowPlayerPickerResult(IntPtr async, uint resultPlayersCount, UInt64[] resultPlayers, out uint resultPlayerUsed) { }

	[Address(RVA = "0x2B94500", Offset = "0x2B93900", Length = "0x87")]
	[Token(Token = "0x6000EB7")]
	internal static int XGameUiShowPlayerPickerResultCount(IntPtr async, out uint resultPlayersCount) { }

	[Address(RVA = "0x2B94640", Offset = "0x2B93A40", Length = "0x93")]
	[Token(Token = "0x6000EB2")]
	internal static int XGameUiShowPlayerProfileCardAsync(IntPtr async, IntPtr requestingUser, ulong targetPlayer) { }

	[Address(RVA = "0x2B946E0", Offset = "0x2B93AE0", Length = "0x78")]
	[Token(Token = "0x6000EB3")]
	internal static int XGameUiShowPlayerProfileCardResult(IntPtr async) { }

	[Address(RVA = "0x2B94760", Offset = "0x2B93B60", Length = "0x13A")]
	[Token(Token = "0x6000EAE")]
	internal static int XGameUiShowSendGameInviteAsync(IntPtr async, IntPtr requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext) { }

	[Address(RVA = "0x2B948A0", Offset = "0x2B93CA0", Length = "0x78")]
	[Token(Token = "0x6000EAF")]
	internal static int XGameUiShowSendGameInviteResult(IntPtr async) { }

	[Address(RVA = "0x2B94920", Offset = "0x2B93D20", Length = "0x106")]
	[Token(Token = "0x6000EBC")]
	internal static int XGameUiShowTextEntryAsync(IntPtr async, string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength) { }

	[Address(RVA = "0x2B94AC0", Offset = "0x2B93EC0", Length = "0xD3")]
	[Token(Token = "0x6000EBE")]
	internal static int XGameUiShowTextEntryResult(IntPtr async, uint resultTextBufferSize, StringBuilder resultTextBuffer, out uint resultTextBufferUsed) { }

	[Address(RVA = "0x2B94A30", Offset = "0x2B93E30", Length = "0x87")]
	[Token(Token = "0x6000EBD")]
	internal static int XGameUiShowTextEntryResultSize(IntPtr async, out uint resultTextBufferSize) { }

	[Address(RVA = "0x2B94BA0", Offset = "0x2B93FA0", Length = "0xDD")]
	[Token(Token = "0x6000EBF")]
	internal static int XGameUiShowWebAuthenticationAsync(IntPtr async, IntPtr requestingUser, string requestUri, string completionUri) { }

	[Address(RVA = "0x2B94D10", Offset = "0x2B94110", Length = "0xBC")]
	[Token(Token = "0x6000EC1")]
	internal static int XGameUiShowWebAuthenticationResult(IntPtr asyncblock, ulong bufferSize, out Byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B94C80", Offset = "0x2B94080", Length = "0x87")]
	[Token(Token = "0x6000EC2")]
	internal static int XGameUiShowWebAuthenticationResultSize(IntPtr async, out ulong bufferSize) { }

	[Address(RVA = "0x2B94DD0", Offset = "0x2B941D0", Length = "0xE8")]
	[Token(Token = "0x6000EC0")]
	internal static int XGameUiShowWebAuthenticationWithOptionsAsync(IntPtr async, IntPtr requestingUser, string requestUri, string completionUri, XGameUiWebAuthenticationOptions options) { }

	[Address(RVA = "0x2B94EC0", Offset = "0x2B942C0", Length = "0x78")]
	[Token(Token = "0x6000EC4")]
	internal static void XGameUiTextEntryClose(IntPtr handle) { }

	[Address(RVA = "0x2B94F40", Offset = "0x2B94340", Length = "0x87")]
	[Token(Token = "0x6000EC5")]
	internal static int XGameUiTextEntryGetExtents(IntPtr handle, out XGameUiTextEntryExtents extents) { }

	[Address(RVA = "0x2B94FD0", Offset = "0x2B943D0", Length = "0xFC")]
	[Token(Token = "0x6000EC6")]
	internal static int XGameUiTextEntryGetState(IntPtr handle, out XGameUiTextEntryChangeTypeFlags changeType, out uint cursorIndex, out uint imeClauseStartIndex, out uint imeClauseEndIndex, uint bufferSize, StringBuilder buffer) { }

	[Address(RVA = "0x2B950D0", Offset = "0x2B944D0", Length = "0xDE")]
	[Token(Token = "0x6000EC3")]
	internal static int XGameUiTextEntryOpen(XGameUiTextEntryOptions options, uint maxLength, string initialText, uint cursorIndex, out IntPtr handle) { }

	[Address(RVA = "0x2B951B0", Offset = "0x2B945B0", Length = "0x85")]
	[Token(Token = "0x6000EC7")]
	internal static int XGameUiTextEntryUpdatePositionHint(IntPtr handle, XGameUiTextEntryPositionHint positionHint) { }

	[Address(RVA = "0x2B95240", Offset = "0x2B94640", Length = "0x85")]
	[Token(Token = "0x6000EC8")]
	internal static int XGameUiTextEntryUpdateVisibility(IntPtr handle, XGameUiTextEntryVisibilityFlags visibilityFlags) { }

	[Address(RVA = "0x2B952D0", Offset = "0x2B946D0", Length = "0x78")]
	[Token(Token = "0x6000E32")]
	internal static int XHighContrastGetMode(out XHighContrastMode mode) { }

	[Address(RVA = "0x2B95350", Offset = "0x2B94750", Length = "0xBA")]
	[Token(Token = "0x6000E64")]
	internal static void XLaunchNewGame(string exePath, string args, IntPtr defaultUser) { }

	[Address(RVA = "0x2B95410", Offset = "0x2B94810", Length = "0xA2")]
	[Token(Token = "0x6000E65")]
	internal static int XLaunchRestartOnCrash(string args, uint reserved) { }

	[Address(RVA = "0x2B954C0", Offset = "0x2B948C0", Length = "0xAA")]
	[Token(Token = "0x6000EC9")]
	internal static int XLaunchUri(IntPtr requestingUser, string uri) { }

	[Address(RVA = "0x2B95570", Offset = "0x2B94970", Length = "0x78")]
	[Token(Token = "0x6000ECA")]
	internal static int XNetworkingGetConnectivityHint(out XNetworkingConnectivityHint connectivityHint) { }

	[Address(RVA = "0x2B955F0", Offset = "0x2B949F0", Length = "0x85")]
	[Token(Token = "0x6000ECB")]
	internal static int XNetworkingQueryConfigurationSetting(XNetworkingConfigurationSetting configurationSetting, out ulong value) { }

	[Address(RVA = "0x2B95790", Offset = "0x2B94B90", Length = "0x78")]
	[Token(Token = "0x6000ECC")]
	internal static int XNetworkingQueryPreferredLocalUdpMultiplayerPort(out ushort value) { }

	[Address(RVA = "0x2B95710", Offset = "0x2B94B10", Length = "0x78")]
	[Token(Token = "0x6000ECD")]
	internal static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(IntPtr async) { }

	[Address(RVA = "0x2B95680", Offset = "0x2B94A80", Length = "0x87")]
	[Token(Token = "0x6000ECE")]
	internal static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsyncResult(IntPtr async, out ushort preferredLocalUdpMultiplayerPort) { }

	[Address(RVA = "0x2B95960", Offset = "0x2B94D60", Length = "0xA4")]
	[Token(Token = "0x6000ECF")]
	internal static int XNetworkingQuerySecurityInformationForUrlAsync(string url, IntPtr async) { }

	[Address(RVA = "0x2B958A0", Offset = "0x2B94CA0", Length = "0xBC")]
	[Token(Token = "0x6000ED1")]
	internal static int XNetworkingQuerySecurityInformationForUrlAsyncResult(IntPtr async, ulong securityInformationBufferByteCount, out ulong securityInformationBufferByteCountUsed, out Byte[] securityInformationBuffer, out IntPtr securityInformation) { }

	[Address(RVA = "0x2B95810", Offset = "0x2B94C10", Length = "0x87")]
	[Token(Token = "0x6000ED0")]
	internal static int XNetworkingQuerySecurityInformationForUrlAsyncResultSize(IntPtr async, out ulong securityInformationBufferByteCount) { }

	[Address(RVA = "0x2B95B60", Offset = "0x2B94F60", Length = "0x91")]
	[Token(Token = "0x6000ED2")]
	internal static int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, IntPtr async) { }

	[Address(RVA = "0x2B95AA0", Offset = "0x2B94EA0", Length = "0xBC")]
	[Token(Token = "0x6000ED4")]
	internal static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResult(IntPtr async, ulong securityInformationBufferByteCount, out ulong securityInformationBufferByteCountUsed, out Byte[] securityInformationBuffer, out IntPtr securityInformation) { }

	[Address(RVA = "0x2B95A10", Offset = "0x2B94E10", Length = "0x87")]
	[Token(Token = "0x6000ED3")]
	internal static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResultSize(IntPtr async, out ulong securityInformationBufferByteCount) { }

	[Address(RVA = "0x2B95C00", Offset = "0x2B95000", Length = "0x85")]
	[Token(Token = "0x6000ED5")]
	internal static int XNetworkingQueryStatistics(XNetworkingStatisticsType statisticsType, out XNetworkingStatisticsBuffer statisticsBuffer) { }

	[Address(RVA = "0x2B95C90", Offset = "0x2B95090", Length = "0xAF")]
	[Token(Token = "0x6000ED6")]
	internal static int XNetworkingRegisterConnectivityHintChanged(IntPtr taskQueueHandle, IntPtr context, XNetworkingConnectivityHintChangedCallback callback, out ulong registrationToken) { }

	[Address(RVA = "0x2B95D40", Offset = "0x2B95140", Length = "0xAF")]
	[Token(Token = "0x6000ED8")]
	internal static int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(IntPtr taskQueueHandle, IntPtr context, XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out ulong registrationToken) { }

	[Address(RVA = "0x2B95DF0", Offset = "0x2B951F0", Length = "0x8C")]
	[Token(Token = "0x6000ED7")]
	internal static bool XNetworkingUnregisterConnectivityHintChanged(ulong token, bool wait) { }

	[Address(RVA = "0x2B95E80", Offset = "0x2B95280", Length = "0x8C")]
	[Token(Token = "0x6000ED9")]
	internal static bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(ulong token, bool wait) { }

	[Address(RVA = "0x2B95F10", Offset = "0x2B95310", Length = "0x87")]
	[Token(Token = "0x6000EDA")]
	internal static int XNetworkingVerifyServerCertificate(IntPtr requestHandle, IntPtr securityInformation) { }

	[Address(RVA = "0x2B95FA0", Offset = "0x2B953A0", Length = "0xB8")]
	[Token(Token = "0x6000EE3")]
	internal static int XPackageChangeChunkInstallOrder(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors) { }

	[Address(RVA = "0x2B96060", Offset = "0x2B95460", Length = "0x78")]
	[Token(Token = "0x6000EDC")]
	internal static void XPackageCloseInstallationMonitorHandle(IntPtr installationMonitor) { }

	[Address(RVA = "0x2B960E0", Offset = "0x2B954E0", Length = "0x78")]
	[Token(Token = "0x6000EE9")]
	internal static void XPackageCloseMountHandle(IntPtr mount) { }

	[Address(RVA = "0x2B96160", Offset = "0x2B95560", Length = "0xE4")]
	[Token(Token = "0x6000EDB")]
	internal static int XPackageCreateInstallationMonitor(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, IntPtr queue, out IntPtr installationMonitor) { }

	[Address(RVA = "0x2B96250", Offset = "0x2B95650", Length = "0xC5")]
	[Token(Token = "0x6000EEA")]
	internal static int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, IntPtr context, XPackageChunkAvailabilityCallback callback) { }

	[Address(RVA = "0x2B96320", Offset = "0x2B95720", Length = "0xB8")]
	[Token(Token = "0x6000EEB")]
	internal static int XPackageEnumerateFeatures(string packageIdentifier, IntPtr context, XPackageFeatureEnumerationCallbackInterop callback) { }

	[Address(RVA = "0x2B963E0", Offset = "0x2B957E0", Length = "0xAB")]
	[Token(Token = "0x6000EEC")]
	internal static int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, IntPtr context, XPackageEnumerationCallback callback) { }

	[Address(RVA = "0x2B96490", Offset = "0x2B95890", Length = "0xD7")]
	[Token(Token = "0x6000EE7")]
	internal static int XPackageEstimateDownloadSize(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, out ulong downloadSize, out bool shouldPresentUserConfirmation) { }

	[Address(RVA = "0x2B96570", Offset = "0x2B95970", Length = "0xC7")]
	[Token(Token = "0x6000EE2")]
	internal static int XPackageFindChunkAvailability(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, out XPackageChunkAvailability availability) { }

	[Address(RVA = "0x2B96640", Offset = "0x2B95A40", Length = "0xB5")]
	[Token(Token = "0x6000EDD")]
	internal static int XPackageGetCurrentProcessPackageIdentifier(ulong bufferSize, StringBuilder buffer) { }

	[Address(RVA = "0x2B96700", Offset = "0x2B95B00", Length = "0x87")]
	[Token(Token = "0x6000EDF")]
	internal static void XPackageGetInstallationProgress(IntPtr installationMonitor, out XPackageInstallationProgress progress) { }

	[Address(RVA = "0x2B96820", Offset = "0x2B95C20", Length = "0xC4")]
	[Token(Token = "0x6000EEE")]
	internal static int XPackageGetMountPath(IntPtr mount, ulong pathSize, StringBuilder path) { }

	[Address(RVA = "0x2B96790", Offset = "0x2B95B90", Length = "0x87")]
	[Token(Token = "0x6000EED")]
	internal static int XPackageGetMountPathSize(IntPtr mount, out ulong pathSize) { }

	[Address(RVA = "0x2B968F0", Offset = "0x2B95CF0", Length = "0xB5")]
	[Token(Token = "0x6000EE1")]
	internal static int XPackageGetUserLocale(ulong localeSize, StringBuilder locale) { }

	[Address(RVA = "0x2B969B0", Offset = "0x2B95DB0", Length = "0x78")]
	[Token(Token = "0x6000EEF")]
	internal static int XPackageGetWriteStats(out XPackageWriteStats writeStats) { }

	[Address(RVA = "0x2B96BB0", Offset = "0x2B95FB0", Length = "0xEE")]
	[Token(Token = "0x6000EE4")]
	internal static int XPackageInstallChunks(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, IntPtr queue, out IntPtr installationMonitor) { }

	[Address(RVA = "0x2B96A30", Offset = "0x2B95E30", Length = "0xE3")]
	[Token(Token = "0x6000EE5")]
	internal static int XPackageInstallChunksAsync(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, IntPtr async) { }

	[Address(RVA = "0x2B96B20", Offset = "0x2B95F20", Length = "0x87")]
	[Token(Token = "0x6000EE6")]
	internal static int XPackageInstallChunksResult(IntPtr asyncBlock, out IntPtr installationMonitor) { }

	[Address(RVA = "0x2B96CA0", Offset = "0x2B960A0", Length = "0x6D")]
	[Token(Token = "0x6000EDE")]
	internal static bool XPackageIsPackagedProcess() { }

	[Address(RVA = "0x2B96D10", Offset = "0x2B96110", Length = "0xA4")]
	[Token(Token = "0x6000EF0")]
	internal static int XPackageMountWithUiAsync(string packageIdentifier, IntPtr async) { }

	[Address(RVA = "0x2B96DC0", Offset = "0x2B961C0", Length = "0x87")]
	[Token(Token = "0x6000EF1")]
	internal static int XPackageMountWithUiResult(IntPtr async, out IntPtr mount) { }

	[Address(RVA = "0x2B96E50", Offset = "0x2B96250", Length = "0xAF")]
	[Token(Token = "0x6000EF2")]
	internal static int XPackageRegisterInstallationProgressChanged(IntPtr installationMonitor, IntPtr context, XPackageInstallationProgressCallback callback, out ulong token) { }

	[Address(RVA = "0x2B96F00", Offset = "0x2B96300", Length = "0xAF")]
	[Token(Token = "0x6000EF3")]
	internal static int XPackageRegisterPackageInstalled(IntPtr queue, IntPtr context, XPackageInstalledCallback callback, out ulong token) { }

	[Address(RVA = "0x2B96FB0", Offset = "0x2B963B0", Length = "0xB8")]
	[Token(Token = "0x6000EE8")]
	internal static int XPackageUninstallChunks(string packageIdentifier, uint selectorCount, XPackageChunkSelectorInterop[] selectors) { }

	[Address(RVA = "0x2B97070", Offset = "0x2B96470", Length = "0xA1")]
	[Token(Token = "0x6000EF5")]
	internal static bool XPackageUninstallPackage(string packageIdentifier) { }

	[Address(RVA = "0x2B97120", Offset = "0x2B96520", Length = "0x9D")]
	[Token(Token = "0x6000EF4")]
	internal static int XPackageUninstallUWPInstance(string packageName) { }

	[Address(RVA = "0x2B971C0", Offset = "0x2B965C0", Length = "0x9A")]
	[Token(Token = "0x6000EF6")]
	internal static bool XPackageUnregisterInstallationProgressChanged(IntPtr installationMonitor, ulong token, bool wait) { }

	[Address(RVA = "0x2B97260", Offset = "0x2B96660", Length = "0x8C")]
	[Token(Token = "0x6000EF7")]
	internal static bool XPackageUnregisterPackageInstalled(ulong token, bool wait) { }

	[Address(RVA = "0x2B972F0", Offset = "0x2B966F0", Length = "0x7D")]
	[Token(Token = "0x6000EE0")]
	internal static bool XPackageUpdateInstallationMonitor(IntPtr installationMonitor) { }

	[Address(RVA = "0x2B973F0", Offset = "0x2B967F0", Length = "0x9D")]
	[Token(Token = "0x6000EF9")]
	internal static int XPersistentLocalStorageGetPath(ulong pathSize, out Byte[] path, out ulong pathUsed) { }

	[Address(RVA = "0x2B97370", Offset = "0x2B96770", Length = "0x78")]
	[Token(Token = "0x6000EF8")]
	internal static int XPersistentLocalStorageGetPathSize(out ulong pathSize) { }

	[Address(RVA = "0x2B97490", Offset = "0x2B96890", Length = "0x78")]
	[Token(Token = "0x6000EFA")]
	internal static int XPersistentLocalStorageGetSpaceInfo(out XPersistentLocalStorageSpaceInfo spaceInfo) { }

	[Address(RVA = "0x2B97510", Offset = "0x2B96910", Length = "0x87")]
	[Token(Token = "0x6000EFB")]
	internal static int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, IntPtr asyncBlock) { }

	[Address(RVA = "0x2B975A0", Offset = "0x2B969A0", Length = "0x78")]
	[Token(Token = "0x6000EFC")]
	internal static int XPersistentLocalStoragePromptUserForSpaceResult(IntPtr asyncBlock) { }

	[Address(RVA = "0x2B97620", Offset = "0x2B96A20", Length = "0x78")]
	[Token(Token = "0x6000EFF")]
	internal static int XSpeechSynthesizerCloseHandle(IntPtr speechSynthesizer) { }

	[Address(RVA = "0x2B976A0", Offset = "0x2B96AA0", Length = "0x78")]
	[Token(Token = "0x6000F04")]
	internal static int XSpeechSynthesizerCloseStreamHandle(IntPtr speechSynthesisStream) { }

	[Address(RVA = "0x2B97880", Offset = "0x2B96C80", Length = "0x78")]
	[Token(Token = "0x6000EFE")]
	internal static int XSpeechSynthesizerCreate(out IntPtr speechSynthesizer) { }

	[Address(RVA = "0x2B97720", Offset = "0x2B96B20", Length = "0xB0")]
	[Token(Token = "0x6000F03")]
	internal static int XSpeechSynthesizerCreateStreamFromSsml(IntPtr speechSynthesizer, string ssml, out IntPtr speechSynthesisStream) { }

	[Address(RVA = "0x2B977D0", Offset = "0x2B96BD0", Length = "0xB0")]
	[Token(Token = "0x6000F02")]
	internal static int XSpeechSynthesizerCreateStreamFromText(IntPtr speechSynthesizer, string text, out IntPtr speechSynthesisStream) { }

	[Address(RVA = "0x2B97900", Offset = "0x2B96D00", Length = "0x94")]
	[Token(Token = "0x6000EFD")]
	internal static int XSpeechSynthesizerEnumerateInstalledVoices(IntPtr context, XSpeechSynthesizerInstalledVoicesCallback callback) { }

	[Address(RVA = "0x2B97A30", Offset = "0x2B96E30", Length = "0xAC")]
	[Token(Token = "0x6000F06")]
	internal static int XSpeechSynthesizerGetStreamData(IntPtr speechSynthesisStream, ulong bufferSize, out Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B979A0", Offset = "0x2B96DA0", Length = "0x87")]
	[Token(Token = "0x6000F05")]
	internal static int XSpeechSynthesizerGetStreamDataSize(IntPtr speechSynthesisStream, out ulong bufferSize) { }

	[Address(RVA = "0x2B97AE0", Offset = "0x2B96EE0", Length = "0xAA")]
	[Token(Token = "0x6000F01")]
	internal static int XSpeechSynthesizerSetCustomVoice(IntPtr speechSynthesizer, string voiceId) { }

	[Address(RVA = "0x2B97B90", Offset = "0x2B96F90", Length = "0x78")]
	[Token(Token = "0x6000F00")]
	internal static int XSpeechSynthesizerSetDefaultVoice(IntPtr speechSynthesizer) { }

	[Address(RVA = "0x2B97C10", Offset = "0x2B97010", Length = "0xD2")]
	[Token(Token = "0x6000E35")]
	internal static int XSpeechToTextBeginHypothesisString(string speakerName, string content, XSpeechToTextType type, out uint hypothesisId) { }

	[Address(RVA = "0x2B97CF0", Offset = "0x2B970F0", Length = "0x76")]
	[Token(Token = "0x6000E38")]
	internal static int XSpeechToTextCancelHypothesisString(uint hypothesisId) { }

	[Address(RVA = "0x2B97D70", Offset = "0x2B97170", Length = "0xA8")]
	[Token(Token = "0x6000E37")]
	internal static int XSpeechToTextFinalizeHypothesisString(uint hypothesisId, string content) { }

	[Address(RVA = "0x2B97E20", Offset = "0x2B97220", Length = "0xC3")]
	[Token(Token = "0x6000E34")]
	internal static int XSpeechToTextSendString(string speakerName, string content, XSpeechToTextType type) { }

	[Address(RVA = "0x2B97EF0", Offset = "0x2B972F0", Length = "0x76")]
	[Token(Token = "0x6000E33")]
	internal static int XSpeechToTextSetPositionHint(XSpeechToTextPositionHint position) { }

	[Address(RVA = "0x2B97F70", Offset = "0x2B97370", Length = "0xA8")]
	[Token(Token = "0x6000E36")]
	internal static int XSpeechToTextUpdateHypothesisString(uint hypothesisId, string content) { }

	[Address(RVA = "0x2B98020", Offset = "0x2B97420", Length = "0xB0")]
	[Token(Token = "0x6000F0A")]
	internal static int XStoreAcquireLicenseForDurablesAsync(IntPtr storeContextHandle, string storeId, IntPtr async) { }

	[Address(RVA = "0x2B980D0", Offset = "0x2B974D0", Length = "0x87")]
	[Token(Token = "0x6000F0B")]
	internal static int XStoreAcquireLicenseForDurablesResult(IntPtr async, out IntPtr storeLicenseHandle) { }

	[Address(RVA = "0x2B98160", Offset = "0x2B97560", Length = "0xB0")]
	[Token(Token = "0x6000F0C")]
	internal static int XStoreAcquireLicenseForPackageAsync(IntPtr storeContextHandle, string packageIdentifier, IntPtr async) { }

	[Address(RVA = "0x2B98210", Offset = "0x2B97610", Length = "0x87")]
	[Token(Token = "0x6000F0D")]
	internal static int XStoreAcquireLicenseForPackageResult(IntPtr async, out IntPtr storeLicenseHandle) { }

	[Address(RVA = "0x2B982A0", Offset = "0x2B976A0", Length = "0xB0")]
	[Token(Token = "0x6000F10")]
	internal static int XStoreCanAcquireLicenseForPackageAsync(IntPtr storeContextHandle, string packageIdentifier, IntPtr async) { }

	[Address(RVA = "0x2B98350", Offset = "0x2B97750", Length = "0xE3")]
	[Token(Token = "0x6000F11")]
	internal static int XStoreCanAcquireLicenseForPackageResult(IntPtr async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult) { }

	[Address(RVA = "0x2B98440", Offset = "0x2B97840", Length = "0xB0")]
	[Token(Token = "0x6000F0E")]
	internal static int XStoreCanAcquireLicenseForStoreIdAsync(IntPtr storeContextHandle, string storeProductId, IntPtr async) { }

	[Address(RVA = "0x2B984F0", Offset = "0x2B978F0", Length = "0xE3")]
	[Token(Token = "0x6000F0F")]
	internal static int XStoreCanAcquireLicenseForStoreIdResult(IntPtr async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult) { }

	[Address(RVA = "0x2B985E0", Offset = "0x2B979E0", Length = "0x78")]
	[Token(Token = "0x6000F08")]
	internal static void XStoreCloseContextHandle(IntPtr storeContextHandle) { }

	[Address(RVA = "0x2B98660", Offset = "0x2B97A60", Length = "0x78")]
	[Token(Token = "0x6000F09")]
	internal static void XStoreCloseLicenseHandle(IntPtr storeLicenseHandle) { }

	[Address(RVA = "0x2B986E0", Offset = "0x2B97AE0", Length = "0x78")]
	[Token(Token = "0x6000F15")]
	internal static void XStoreCloseProductsQueryHandle(IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B98760", Offset = "0x2B97B60", Length = "0x87")]
	[Token(Token = "0x6000F07")]
	internal static int XStoreCreateContext(IntPtr user, out IntPtr storeContextHandle) { }

	[Address(RVA = "0x2B989F0", Offset = "0x2B97DF0", Length = "0x17A")]
	[Token(Token = "0x6000F1A")]
	internal static int XStoreDownloadAndInstallPackagesAsync(IntPtr storeContextHandle, String[] storeIds, ulong storeIdsCount, IntPtr async) { }

	[Address(RVA = "0x2B98C00", Offset = "0x2B98000", Length = "0x1A9")]
	[Token(Token = "0x6000F1C")]
	internal static int XStoreDownloadAndInstallPackagesResult(IntPtr async, uint count, out XStorePackageIdentifierInterop[] identifiers) { }

	[Address(RVA = "0x2B98B70", Offset = "0x2B97F70", Length = "0x87")]
	[Token(Token = "0x6000F1B")]
	internal static int XStoreDownloadAndInstallPackagesResultCount(IntPtr async, out uint count) { }

	[Address(RVA = "0x2B987F0", Offset = "0x2B97BF0", Length = "0x17A")]
	[Token(Token = "0x6000F18")]
	internal static int XStoreDownloadAndInstallPackageUpdatesAsync(IntPtr storeContextHandle, String[] packageIdentifiers, ulong packageIdentifiersCount, IntPtr async) { }

	[Address(RVA = "0x2B98970", Offset = "0x2B97D70", Length = "0x78")]
	[Token(Token = "0x6000F19")]
	internal static int XStoreDownloadAndInstallPackageUpdatesResult(IntPtr async) { }

	[Address(RVA = "0x2B98DB0", Offset = "0x2B981B0", Length = "0x17A")]
	[Token(Token = "0x6000F16")]
	internal static int XStoreDownloadPackageUpdatesAsync(IntPtr storeContextHandle, String[] packageIdentifiers, ulong packageIdentifiersCount, IntPtr async) { }

	[Address(RVA = "0x2B98F30", Offset = "0x2B98330", Length = "0x78")]
	[Token(Token = "0x6000F17")]
	internal static int XStoreDownloadPackageUpdatesResult(IntPtr async) { }

	[Address(RVA = "0x2B98FB0", Offset = "0x2B983B0", Length = "0xA0")]
	[Token(Token = "0x6000F14")]
	internal static int XStoreEnumerateProductsQuery(IntPtr productQueryHandle, IntPtr context, XStoreProductQueryCallbackInterop callback) { }

	[Address(RVA = "0x2B99050", Offset = "0x2B98450", Length = "0xD2")]
	[Token(Token = "0x6000F1D")]
	internal static int XStoreGetUserCollectionsIdAsync(IntPtr storeContextHandle, string serviceTicket, string publisherUserId, IntPtr async) { }

	[Address(RVA = "0x2B991C0", Offset = "0x2B985C0", Length = "0xC4")]
	[Token(Token = "0x6000F1F")]
	internal static int XStoreGetUserCollectionsIdResult(IntPtr async, ulong size, StringBuilder result) { }

	[Address(RVA = "0x2B99130", Offset = "0x2B98530", Length = "0x87")]
	[Token(Token = "0x6000F1E")]
	internal static int XStoreGetUserCollectionsIdResultSize(IntPtr async, out ulong size) { }

	[Address(RVA = "0x2B99290", Offset = "0x2B98690", Length = "0xD2")]
	[Token(Token = "0x6000F20")]
	internal static int XStoreGetUserPurchaseIdAsync(IntPtr storeContextHandle, string serviceTicket, string publisherUserId, IntPtr async) { }

	[Address(RVA = "0x2B99400", Offset = "0x2B98800", Length = "0xC4")]
	[Token(Token = "0x6000F22")]
	internal static int XStoreGetUserPurchaseIdResult(IntPtr async, ulong size, StringBuilder result) { }

	[Address(RVA = "0x2B99370", Offset = "0x2B98770", Length = "0x87")]
	[Token(Token = "0x6000F21")]
	internal static int XStoreGetUserPurchaseIdResultSize(IntPtr async, out ulong size) { }

	[Address(RVA = "0x2B994D0", Offset = "0x2B988D0", Length = "0x13B")]
	[Token(Token = "0x6000F23")]
	internal static bool XStoreIsAvailabilityPurchasable(XStoreAvailability availability) { }

	[Address(RVA = "0x2B99610", Offset = "0x2B98A10", Length = "0x7D")]
	[Token(Token = "0x6000F24")]
	internal static bool XStoreIsLicenseValid(IntPtr storeLicenseHandle) { }

	[Address(RVA = "0x2B99690", Offset = "0x2B98A90", Length = "0x7D")]
	[Token(Token = "0x6000F25")]
	internal static bool XStoreProductsQueryHasMorePages(IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B99710", Offset = "0x2B98B10", Length = "0x87")]
	[Token(Token = "0x6000F26")]
	internal static int XStoreProductsQueryNextPageAsync(IntPtr productQueryHandle, IntPtr async) { }

	[Address(RVA = "0x2B997A0", Offset = "0x2B98BA0", Length = "0x87")]
	[Token(Token = "0x6000F27")]
	internal static int XStoreProductsQueryNextPageResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B99830", Offset = "0x2B98C30", Length = "0x87")]
	[Token(Token = "0x6000F28")]
	internal static int XStoreQueryAddOnLicensesAsync(IntPtr storeContextHandle, IntPtr async) { }

	[Address(RVA = "0x2B99950", Offset = "0x2B98D50", Length = "0x252")]
	[Token(Token = "0x6000F2A")]
	internal static int XStoreQueryAddOnLicensesResult(IntPtr async, uint count, out XStoreAddonLicense[] addOnLicenses) { }

	[Address(RVA = "0x2B998C0", Offset = "0x2B98CC0", Length = "0x87")]
	[Token(Token = "0x6000F29")]
	internal static int XStoreQueryAddOnLicensesResultCount(IntPtr async, out uint count) { }

	[Address(RVA = "0x2B99BB0", Offset = "0x2B98FB0", Length = "0xA0")]
	[Token(Token = "0x6000F2B")]
	internal static int XStoreQueryAssociatedProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, IntPtr async) { }

	[Address(RVA = "0x2B99C50", Offset = "0x2B99050", Length = "0x87")]
	[Token(Token = "0x6000F2C")]
	internal static int XStoreQueryAssociatedProductsResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B99CE0", Offset = "0x2B990E0", Length = "0xB0")]
	[Token(Token = "0x6000F2D")]
	internal static int XStoreQueryConsumableBalanceRemainingAsync(IntPtr storeContextHandle, string storeProductId, IntPtr async) { }

	[Address(RVA = "0x2B99D90", Offset = "0x2B99190", Length = "0x87")]
	[Token(Token = "0x6000F2E")]
	internal static int XStoreQueryConsumableBalanceRemainingResult(IntPtr async, out XStoreConsumableResult consumableResult) { }

	[Address(RVA = "0x2B99E20", Offset = "0x2B99220", Length = "0xA0")]
	[Token(Token = "0x6000F2F")]
	internal static int XStoreQueryEntitledProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, IntPtr async) { }

	[Address(RVA = "0x2B99EC0", Offset = "0x2B992C0", Length = "0x87")]
	[Token(Token = "0x6000F30")]
	internal static int XStoreQueryEntitledProductsResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B99F50", Offset = "0x2B99350", Length = "0x87")]
	[Token(Token = "0x6000F31")]
	internal static int XStoreQueryGameAndDlcPackageUpdatesAsync(IntPtr storeContextHandle, IntPtr async) { }

	[Address(RVA = "0x2B9A070", Offset = "0x2B99470", Length = "0x1CD")]
	[Token(Token = "0x6000F33")]
	internal static int XStoreQueryGameAndDlcPackageUpdatesResult(IntPtr async, uint count, out XStorePackageUpdate[] packageUpdates) { }

	[Address(RVA = "0x2B99FE0", Offset = "0x2B993E0", Length = "0x87")]
	[Token(Token = "0x6000F32")]
	internal static int XStoreQueryGameAndDlcPackageUpdatesResultCount(IntPtr async, out uint count) { }

	[Address(RVA = "0x2B9A240", Offset = "0x2B99640", Length = "0x87")]
	[Token(Token = "0x6000F34")]
	internal static int XStoreQueryGameLicenseAsync(IntPtr storeContextHandle, IntPtr async) { }

	[Address(RVA = "0x2B9A2D0", Offset = "0x2B996D0", Length = "0x151")]
	[Token(Token = "0x6000F35")]
	internal static int XStoreQueryGameLicenseResult(IntPtr async, out XStoreGameLicense license) { }

	[Address(RVA = "0x2B9A430", Offset = "0x2B99830", Length = "0x18C")]
	[Token(Token = "0x6000F36")]
	internal static int XStoreQueryLicenseTokenAsync(IntPtr storeContextHandle, String[] productIds, ulong productIdsCount, string customDeveloperString, IntPtr async) { }

	[Address(RVA = "0x2B9A650", Offset = "0x2B99A50", Length = "0xC4")]
	[Token(Token = "0x6000F38")]
	internal static int XStoreQueryLicenseTokenResult(IntPtr async, ulong size, StringBuilder result) { }

	[Address(RVA = "0x2B9A5C0", Offset = "0x2B999C0", Length = "0x87")]
	[Token(Token = "0x6000F37")]
	internal static int XStoreQueryLicenseTokenResultSize(IntPtr async, out ulong size) { }

	[Address(RVA = "0x2B9A720", Offset = "0x2B99B20", Length = "0xD7")]
	[Token(Token = "0x6000F39")]
	internal static int XStoreQueryPackageIdentifier(string storeId, ulong size, StringBuilder packageIdentifier) { }

	[Address(RVA = "0x2B9A800", Offset = "0x2B99C00", Length = "0x87")]
	[Token(Token = "0x6000F12")]
	internal static int XStoreQueryProductForCurrentGameAsync(IntPtr storeContextHandle, IntPtr async) { }

	[Address(RVA = "0x2B9A890", Offset = "0x2B99C90", Length = "0x87")]
	[Token(Token = "0x6000F13")]
	internal static int XStoreQueryProductForCurrentGameResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B9A920", Offset = "0x2B99D20", Length = "0xBD")]
	[Token(Token = "0x6000F3A")]
	internal static int XStoreQueryProductForPackageAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, string packageIdentifier, IntPtr async) { }

	[Address(RVA = "0x2B9A9E0", Offset = "0x2B99DE0", Length = "0x87")]
	[Token(Token = "0x6000F3B")]
	internal static int XStoreQueryProductForPackageResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B9AA70", Offset = "0x2B99E70", Length = "0x235")]
	[Token(Token = "0x6000F3C")]
	internal static int XStoreQueryProductsAsync(IntPtr storeContextHandle, XStoreProductKind productKinds, String[] storeIds, ulong storeIdsCount, String[] actionFilters, ulong actionFiltersCount, IntPtr async) { }

	[Address(RVA = "0x2B9ACB0", Offset = "0x2B9A0B0", Length = "0x87")]
	[Token(Token = "0x6000F3D")]
	internal static int XStoreQueryProductsResult(IntPtr async, out IntPtr productQueryHandle) { }

	[Address(RVA = "0x2B9AD40", Offset = "0x2B9A140", Length = "0xB2")]
	[Token(Token = "0x6000F3E")]
	internal static int XStoreRegisterGameLicenseChanged(IntPtr storeContextHandle, IntPtr queue, IntPtr context, XStoreGameLicenseChangedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9AE00", Offset = "0x2B9A200", Length = "0xB2")]
	[Token(Token = "0x6000F40")]
	internal static int XStoreRegisterPackageLicenseLost(IntPtr licenseHandle, IntPtr queue, IntPtr context, XStorePackageLicenseLostCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9AEC0", Offset = "0x2B9A2C0", Length = "0xD7")]
	[Token(Token = "0x6000F42")]
	internal static int XStoreReportConsumableFulfillmentAsync(IntPtr storeContextHandle, string storeProductId, uint quantity, Guid trackingId, IntPtr async) { }

	[Address(RVA = "0x2B9AFA0", Offset = "0x2B9A3A0", Length = "0x87")]
	[Token(Token = "0x6000F43")]
	internal static int XStoreReportConsumableFulfillmentResult(IntPtr async, out XStoreConsumableResult consumableResult) { }

	[Address(RVA = "0x2B9B030", Offset = "0x2B9A430", Length = "0xBF")]
	[Token(Token = "0x6000F44")]
	internal static int XStoreShowAssociatedProductsUIAsync(IntPtr storeContextHandle, string storeId, XStoreProductKind productKinds, IntPtr async) { }

	[Address(RVA = "0x2B9B0F0", Offset = "0x2B9A4F0", Length = "0x78")]
	[Token(Token = "0x6000F45")]
	internal static int XStoreShowAssociatedProductsUIResult(IntPtr async) { }

	[Address(RVA = "0x2B9B170", Offset = "0x2B9A570", Length = "0xB0")]
	[Token(Token = "0x6000F46")]
	internal static int XStoreShowProductPageUIAsync(IntPtr storeContextHandle, string storeId, IntPtr async) { }

	[Address(RVA = "0x2B9B220", Offset = "0x2B9A620", Length = "0x78")]
	[Token(Token = "0x6000F47")]
	internal static int XStoreShowProductPageUIResult(IntPtr async) { }

	[Address(RVA = "0x2B9B2A0", Offset = "0x2B9A6A0", Length = "0xFD")]
	[Token(Token = "0x6000F48")]
	internal static int XStoreShowPurchaseUIAsync(IntPtr storeContextHandle, string storeId, string name, string extendedJsonData, IntPtr async) { }

	[Address(RVA = "0x2B9B3A0", Offset = "0x2B9A7A0", Length = "0x78")]
	[Token(Token = "0x6000F49")]
	internal static int XStoreShowPurchaseUIResult(IntPtr async) { }

	[Address(RVA = "0x2B9B420", Offset = "0x2B9A820", Length = "0x87")]
	[Token(Token = "0x6000F4A")]
	internal static int XStoreShowRateAndReviewUIAsync(IntPtr storeContextHandle, IntPtr async) { }

	[Address(RVA = "0x2B9B4B0", Offset = "0x2B9A8B0", Length = "0x87")]
	[Token(Token = "0x6000F4B")]
	internal static int XStoreShowRateAndReviewUIResult(IntPtr async, out XStoreRateAndReviewResult result) { }

	[Address(RVA = "0x2B9B540", Offset = "0x2B9A940", Length = "0x191")]
	[Token(Token = "0x6000F4C")]
	internal static int XStoreShowRedeemTokenUIAsync(IntPtr storeContextHandle, string token, String[] allowedStoreIds, ulong allowedStoreIdsCount, bool disallowCsvRedemption, IntPtr async) { }

	[Address(RVA = "0x2B9B6E0", Offset = "0x2B9AAE0", Length = "0x78")]
	[Token(Token = "0x6000F4D")]
	internal static int XStoreShowRedeemTokenUIResult(IntPtr async) { }

	[Address(RVA = "0x2B9B760", Offset = "0x2B9AB60", Length = "0x9A")]
	[Token(Token = "0x6000F3F")]
	internal static bool XStoreUnregisterGameLicenseChanged(IntPtr storeContextHandle, ulong token, bool wait) { }

	[Address(RVA = "0x2B9B800", Offset = "0x2B9AC00", Length = "0x9A")]
	[Token(Token = "0x6000F41")]
	internal static bool XStoreUnregisterPackageLicenseLost(IntPtr licenseHandle, ulong token, bool wait) { }

	[Address(RVA = "0x2B9B8A0", Offset = "0x2B9ACA0", Length = "0x127")]
	[Token(Token = "0x6000F4E")]
	internal static void XSystemGetAnalyticsInfo(out XSystemAnalyticsInfo info) { }

	[Address(RVA = "0x2B9B9D0", Offset = "0x2B9ADD0", Length = "0xC4")]
	[Token(Token = "0x6000F4F")]
	internal static int XSystemGetAppSpecificDeviceId(ulong appSpecificDeviceIdSize, StringBuilder appSpecificDeviceId, out ulong appSpecificDeviceIdUsed) { }

	[Address(RVA = "0x2B9BAA0", Offset = "0x2B9AEA0", Length = "0xC4")]
	[Token(Token = "0x6000F50")]
	internal static int XSystemGetConsoleId(ulong consoleIdSize, StringBuilder consoleId, out ulong consoleIdUsed) { }

	[Address(RVA = "0x2B9BB70", Offset = "0x2B9AF70", Length = "0x68")]
	[Token(Token = "0x6000F51")]
	internal static XSystemDeviceType XSystemGetDeviceType() { }

	[Address(RVA = "0x2B9BBE0", Offset = "0x2B9AFE0", Length = "0x7C")]
	[Token(Token = "0x6000F53")]
	internal static XSystemRuntimeInfo XSystemGetRuntimeInfo() { }

	[Address(RVA = "0x2B9BC60", Offset = "0x2B9B060", Length = "0xC4")]
	[Token(Token = "0x6000F52")]
	internal static int XSystemGetXboxLiveSandboxId(ulong sandboxIdSize, StringBuilder sandboxId, out ulong sandboxIdUsed) { }

	[Address(RVA = "0x2B9BD30", Offset = "0x2B9B130", Length = "0x94")]
	[Token(Token = "0x6000F55")]
	internal static int XSystemHandleTrack(XSystemHandleCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B9BDD0", Offset = "0x2B9B1D0", Length = "0x7D")]
	[Token(Token = "0x6000F54")]
	internal static bool XSystemIsHandleValid(IntPtr handle) { }

	[Address(RVA = "0x2B9BE50", Offset = "0x2B9B250", Length = "0x78")]
	[Token(Token = "0x6000F56")]
	internal static void XTaskQueueCloseHandle(IntPtr queue) { }

	[Address(RVA = "0x2B9BF70", Offset = "0x2B9B370", Length = "0x8F")]
	[Token(Token = "0x6000F57")]
	internal static int XTaskQueueCreate(XTaskQueueDispatchMode workDispatchMode, XTaskQueueDispatchMode completionDispatchMode, out IntPtr queue) { }

	[Address(RVA = "0x2B9BED0", Offset = "0x2B9B2D0", Length = "0x93")]
	[Token(Token = "0x6000F58")]
	internal static int XTaskQueueCreateComposite(IntPtr workPort, IntPtr completionPort, out IntPtr queue) { }

	[Address(RVA = "0x2B9C000", Offset = "0x2B9B400", Length = "0x96")]
	[Token(Token = "0x6000F59")]
	internal static bool XTaskQueueDispatch(IntPtr queue, XTaskQueuePort port, uint timeoutInMs) { }

	[Address(RVA = "0x2B9C0A0", Offset = "0x2B9B4A0", Length = "0x87")]
	[Token(Token = "0x6000F5A")]
	internal static int XTaskQueueDuplicateHandle(IntPtr queueHandle, out IntPtr duplicatedHandle) { }

	[Address(RVA = "0x2B9C130", Offset = "0x2B9B530", Length = "0x7D")]
	[Token(Token = "0x6000F5B")]
	internal static bool XTaskQueueGetCurrentProcessTaskQueue(out IntPtr queue) { }

	[Address(RVA = "0x2B9C1B0", Offset = "0x2B9B5B0", Length = "0x91")]
	[Token(Token = "0x6000F5C")]
	internal static int XTaskQueueGetPort(IntPtr queue, XTaskQueuePort port, out IntPtr portHandle) { }

	[Address(RVA = "0x2B9C250", Offset = "0x2B9B650", Length = "0xAF")]
	[Token(Token = "0x6000F5D")]
	internal static int XTaskQueueRegisterMonitor(IntPtr queue, IntPtr callbackContext, XTaskQueueMonitorCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9C300", Offset = "0x2B9B700", Length = "0x125")]
	[Token(Token = "0x6000F5E")]
	internal static int XTaskQueueRegisterWaiter(IntPtr queue, XTaskQueuePort port, SafeWaitHandle waitHandle, IntPtr callbackContext, XTaskQueueCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9C430", Offset = "0x2B9B830", Length = "0x78")]
	[Token(Token = "0x6000F5F")]
	internal static void XTaskQueueSetCurrentProcessTaskQueue(IntPtr queue) { }

	[Address(RVA = "0x2B9C4B0", Offset = "0x2B9B8B0", Length = "0xAD")]
	[Token(Token = "0x6000F60")]
	internal static int XTaskQueueSubmitCallback(IntPtr queue, XTaskQueuePort port, IntPtr callbackContext, XTaskQueueCallback callback) { }

	[Address(RVA = "0x2B9C560", Offset = "0x2B9B960", Length = "0xBD")]
	[Token(Token = "0x6000F61")]
	internal static int XTaskQueueSubmitDelayedCallback(IntPtr queue, XTaskQueuePort port, uint delayMs, IntPtr callbackContext, XTaskQueueCallback callback) { }

	[Address(RVA = "0x2B9C620", Offset = "0x2B9BA20", Length = "0xB0")]
	[Token(Token = "0x6000F62")]
	internal static int XTaskQueueTerminate(IntPtr queue, bool wait, IntPtr callbackContext, XTaskQueueTerminatedCallback callback) { }

	[Address(RVA = "0x2B9C6D0", Offset = "0x2B9BAD0", Length = "0x87")]
	[Token(Token = "0x6000F63")]
	internal static int XTaskQueueUnregisterMonitor(IntPtr queue, ulong token) { }

	[Address(RVA = "0x2B9C760", Offset = "0x2B9BB60", Length = "0x87")]
	[Token(Token = "0x6000F64")]
	internal static int XTaskQueueUnregisterWaiter(IntPtr queue, ulong token) { }

	[Address(RVA = "0x2B9C7F0", Offset = "0x2B9BBF0", Length = "0x68")]
	[Token(Token = "0x6000F65")]
	internal static void XThreadAssertNotTimeSensitive() { }

	[Address(RVA = "0x2B9C860", Offset = "0x2B9BC60", Length = "0x6D")]
	[Token(Token = "0x6000F66")]
	internal static bool XThreadIsTimeSensitive() { }

	[Address(RVA = "0x2B9C8D0", Offset = "0x2B9BCD0", Length = "0x78")]
	[Token(Token = "0x6000F67")]
	internal static int XThreadSetTimeSensitive(bool isTimeSensitiveThread) { }

	[Address(RVA = "0x2B9C950", Offset = "0x2B9BD50", Length = "0x85")]
	[Token(Token = "0x6000F68")]
	internal static int XUserAddAsync(XUserAddOptions options, IntPtr async) { }

	[Address(RVA = "0x2B9C9E0", Offset = "0x2B9BDE0", Length = "0x87")]
	[Token(Token = "0x6000F6A")]
	internal static int XUserAddByIdWithUiAsync(ulong userId, IntPtr async) { }

	[Address(RVA = "0x2B9CA70", Offset = "0x2B9BE70", Length = "0x87")]
	[Token(Token = "0x6000F6B")]
	internal static int XUserAddByIdWithUiResult(IntPtr async, out IntPtr newUser) { }

	[Address(RVA = "0x2B9CB00", Offset = "0x2B9BF00", Length = "0x87")]
	[Token(Token = "0x6000F69")]
	internal static int XUserAddResult(IntPtr async, out IntPtr newUser) { }

	[Address(RVA = "0x2B9CB90", Offset = "0x2B9BF90", Length = "0xB0")]
	[Token(Token = "0x6000F6C")]
	internal static int XUserCheckPrivilege(IntPtr user, XUserPrivilegeOptions options, XUserPrivilege privilege, out bool hasPrivilege, out XUserPrivilegeDenyReason reason) { }

	[Address(RVA = "0x2B9CC40", Offset = "0x2B9C040", Length = "0x78")]
	[Token(Token = "0x6000F6D")]
	internal static void XUserCloseHandle(IntPtr user) { }

	[Address(RVA = "0x2B9CCC0", Offset = "0x2B9C0C0", Length = "0x78")]
	[Token(Token = "0x6000F6E")]
	internal static void XUserCloseSignOutDeferralHandle(IntPtr deferral) { }

	[Address(RVA = "0x2B9CD40", Offset = "0x2B9C140", Length = "0x87")]
	[Token(Token = "0x6000F6F")]
	internal static int XUserCompare(IntPtr user1, IntPtr user2) { }

	[Address(RVA = "0x2B9CDD0", Offset = "0x2B9C1D0", Length = "0x87")]
	[Token(Token = "0x6000F70")]
	internal static int XUserDuplicateHandle(IntPtr handle, out IntPtr duplicatedHandle) { }

	[Address(RVA = "0x2B9CE60", Offset = "0x2B9C260", Length = "0x87")]
	[Token(Token = "0x6000F71")]
	internal static int XUserFindControllerForUserWithUiAsync(IntPtr user, IntPtr async) { }

	[Address(RVA = "0x2B9CEF0", Offset = "0x2B9C2F0", Length = "0xD0")]
	[Token(Token = "0x6000F72")]
	internal static int XUserFindControllerForUserWithUiResult(IntPtr async, out APP_LOCAL_DEVICE_ID deviceId) { }

	[Address(RVA = "0x2B9CFC0", Offset = "0x2B9C3C0", Length = "0xE2")]
	[Token(Token = "0x6000F73")]
	internal static int XUserFindForDevice(ref APP_LOCAL_DEVICE_ID deviceId, out IntPtr handle) { }

	[Address(RVA = "0x2B9D0B0", Offset = "0x2B9C4B0", Length = "0x87")]
	[Token(Token = "0x6000F74")]
	internal static int XUserFindUserById(ulong userId, out IntPtr handle) { }

	[Address(RVA = "0x2B9D140", Offset = "0x2B9C540", Length = "0x87")]
	[Token(Token = "0x6000F75")]
	internal static int XUserFindUserByLocalId(XUserLocalId userLocalId, out IntPtr handle) { }

	[Address(RVA = "0x2B9D1D0", Offset = "0x2B9C5D0", Length = "0x87")]
	[Token(Token = "0x6000F76")]
	internal static int XUserGetAgeGroup(IntPtr user, out XUserAgeGroup ageGroup) { }

	[Address(RVA = "0x2B9D260", Offset = "0x2B9C660", Length = "0xBA")]
	[Token(Token = "0x6000F77")]
	internal static int XUserGetDefaultAudioEndpointUtf16(XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, ulong endpointIdUtf16Count, out Char[] endpointIdUtf16, out ulong endpointIdUtf16Used) { }

	[Address(RVA = "0x2B9D320", Offset = "0x2B9C720", Length = "0x91")]
	[Token(Token = "0x6000F78")]
	internal static int XUserGetGamerPictureAsync(IntPtr user, XUserGamerPictureSize pictureSize, IntPtr async) { }

	[Address(RVA = "0x2B9D450", Offset = "0x2B9C850", Length = "0xAC")]
	[Token(Token = "0x6000F7A")]
	internal static int XUserGetGamerPictureResult(IntPtr async, ulong bufferSize, out Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B9D3C0", Offset = "0x2B9C7C0", Length = "0x87")]
	[Token(Token = "0x6000F79")]
	internal static int XUserGetGamerPictureResultSize(IntPtr async, out ulong bufferSize) { }

	[Address(RVA = "0x2B9D500", Offset = "0x2B9C900", Length = "0xE0")]
	[Token(Token = "0x6000F7B")]
	internal static int XUserGetGamertag(IntPtr user, XUserGamertagComponent gamertagComponent, ulong gamertagSize, StringBuilder gamertag, out ulong gamertagUsed) { }

	[Address(RVA = "0x2B9D5E0", Offset = "0x2B9C9E0", Length = "0x87")]
	[Token(Token = "0x6000F7C")]
	internal static int XUserGetId(IntPtr user, out ulong userId) { }

	[Address(RVA = "0x2B9D670", Offset = "0x2B9CA70", Length = "0x87")]
	[Token(Token = "0x6000F7D")]
	internal static int XUserGetIsGuest(IntPtr user, out bool isGuest) { }

	[Address(RVA = "0x2B9D700", Offset = "0x2B9CB00", Length = "0x87")]
	[Token(Token = "0x6000F7E")]
	internal static int XUserGetLocalId(IntPtr user, out XUserLocalId userLocalId) { }

	[Address(RVA = "0x2B9D790", Offset = "0x2B9CB90", Length = "0x78")]
	[Token(Token = "0x6000F7F")]
	internal static int XUserGetMaxUsers(out uint maxUsers) { }

	[Address(RVA = "0x2B9D810", Offset = "0x2B9CC10", Length = "0x78")]
	[Token(Token = "0x6000F80")]
	internal static int XUserGetSignOutDeferral(out IntPtr deferral) { }

	[Address(RVA = "0x2B9D890", Offset = "0x2B9CC90", Length = "0x87")]
	[Token(Token = "0x6000F81")]
	internal static int XUserGetState(IntPtr user, out XUserState state) { }

	[Address(RVA = "0x2B9D920", Offset = "0x2B9CD20", Length = "0x1EC")]
	[Token(Token = "0x6000F82")]
	internal static int XUserGetTokenAndSignatureAsync(IntPtr user, XUserGetTokenAndSignatureOptions options, string method, string url, ulong headerCount, XUserGetTokenAndSignatureHttpHeader[] headers, ulong bodySize, Byte[] bodyBuffer, IntPtr async) { }

	[Address(RVA = "0x2B9DBA0", Offset = "0x2B9CFA0", Length = "0xBC")]
	[Token(Token = "0x6000F84")]
	internal static int XUserGetTokenAndSignatureResult(IntPtr async, ulong bufferSize, out Byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B9DB10", Offset = "0x2B9CF10", Length = "0x87")]
	[Token(Token = "0x6000F83")]
	internal static int XUserGetTokenAndSignatureResultSize(IntPtr async, out ulong bufferSize) { }

	[Address(RVA = "0x2B9DC60", Offset = "0x2B9D060", Length = "0x1C9")]
	[Token(Token = "0x6000F85")]
	internal static int XUserGetTokenAndSignatureUtf16Async(IntPtr user, XUserGetTokenAndSignatureOptions options, string method, string url, ulong headerCount, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, ulong bodySize, Byte[] bodyBuffer, IntPtr async) { }

	[Address(RVA = "0x2B9DEC0", Offset = "0x2B9D2C0", Length = "0xBC")]
	[Token(Token = "0x6000F87")]
	internal static int XUserGetTokenAndSignatureUtf16Result(IntPtr async, ulong bufferSize, out Byte[] buffer, out IntPtr ptrToBuffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B9DE30", Offset = "0x2B9D230", Length = "0x87")]
	[Token(Token = "0x6000F86")]
	internal static int XUserGetTokenAndSignatureUtf16ResultSize(IntPtr async, out ulong bufferSize) { }

	[Address(RVA = "0x2B9DF80", Offset = "0x2B9D380", Length = "0x7D")]
	[Token(Token = "0x6000F88")]
	internal static bool XUserIsStoreUser(IntPtr user) { }

	[Address(RVA = "0x2B9E000", Offset = "0x2B9D400", Length = "0xAF")]
	[Token(Token = "0x6000F89")]
	internal static int XUserRegisterForChangeEvent(IntPtr queue, IntPtr context, XUserChangeEventCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9E0B0", Offset = "0x2B9D4B0", Length = "0xAF")]
	[Token(Token = "0x6000F8A")]
	internal static int XUserRegisterForDefaultAudioEndpointUtf16Changed(IntPtr queue, IntPtr context, XUserDefaultAudioEndpointUtf16ChangedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9E160", Offset = "0x2B9D560", Length = "0xAF")]
	[Token(Token = "0x6000F8B")]
	internal static int XUserRegisterForDeviceAssociationChanged(IntPtr queue, IntPtr context, XUserDeviceAssociationChangedCallback callback, out ulong token) { }

	[Address(RVA = "0x2B9E210", Offset = "0x2B9D610", Length = "0xB0")]
	[Token(Token = "0x6000F8C")]
	internal static int XUserResolveIssueWithUiAsync(IntPtr user, string url, IntPtr async) { }

	[Address(RVA = "0x2B9E2C0", Offset = "0x2B9D6C0", Length = "0x78")]
	[Token(Token = "0x6000F8D")]
	internal static int XUserResolveIssueWithUiResult(IntPtr async) { }

	[Address(RVA = "0x2B9E340", Offset = "0x2B9D740", Length = "0x9D")]
	[Token(Token = "0x6000F8E")]
	internal static int XUserResolveIssueWithUiUtf16Async(IntPtr user, string url, IntPtr async) { }

	[Address(RVA = "0x2B9E3E0", Offset = "0x2B9D7E0", Length = "0x78")]
	[Token(Token = "0x6000F8F")]
	internal static int XUserResolveIssueWithUiUtf16Result(IntPtr async) { }

	[Address(RVA = "0x2B9E460", Offset = "0x2B9D860", Length = "0xA0")]
	[Token(Token = "0x6000F90")]
	internal static int XUserResolvePrivilegeWithUiAsync(IntPtr user, XUserPrivilegeOptions options, XUserPrivilege privilege, IntPtr async) { }

	[Address(RVA = "0x2B9E500", Offset = "0x2B9D900", Length = "0x78")]
	[Token(Token = "0x6000F91")]
	internal static int XUserResolvePrivilegeWithUiResult(IntPtr async) { }

	[Address(RVA = "0x2B9E580", Offset = "0x2B9D980", Length = "0x8C")]
	[Token(Token = "0x6000F92")]
	internal static bool XUserUnregisterForChangeEvent(ulong token, bool wait) { }

	[Address(RVA = "0x2B9E610", Offset = "0x2B9DA10", Length = "0x8C")]
	[Token(Token = "0x6000F93")]
	internal static bool XUserUnregisterForDefaultAudioEndpointUtf16Changed(ulong token, bool wait) { }

	[Address(RVA = "0x2B9E6A0", Offset = "0x2B9DAA0", Length = "0x8C")]
	[Token(Token = "0x6000F94")]
	internal static bool XUserUnregisterForDeviceAssociationChanged(ulong token, bool wait) { }

}

