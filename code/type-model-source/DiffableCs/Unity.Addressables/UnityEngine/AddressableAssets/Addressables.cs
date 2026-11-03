namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200000C")]
public static class Addressables
{
	[Token(Token = "0x200000D")]
	internal enum MergeMode : int
	{
		None = 0,
		UseFirst = 0,
		Union = 1,
		Intersection = 2,
	}

	[Token(Token = "0x400002E")]
	internal static bool reinitializeAddressables; //Field offset: 0x0
	[Token(Token = "0x4000030")]
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath"; //Field offset: 0x0
	[Token(Token = "0x4000031")]
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL"; //Field offset: 0x0
	[Token(Token = "0x4000032")]
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog"; //Field offset: 0x0
	[Token(Token = "0x400002F")]
	internal static AddressablesImpl m_AddressablesInstance; //Field offset: 0x8
	[Token(Token = "0x4000033")]
	public static string LibraryPath; //Field offset: 0x10
	[Token(Token = "0x4000034")]
	public static string BuildReportPath; //Field offset: 0x18

	[Token(Token = "0x17000015")]
	public static string BuildPath
	{
		[Address(RVA = "0x27A3DF0", Offset = "0x27A31F0", Length = "0x8D")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000010")]
	internal static AddressablesImpl Instance
	{
		[Address(RVA = "0x27A3F10", Offset = "0x27A3310", Length = "0x8A")]
		[Token(Token = "0x600003E")]
		internal get { } //Length: 138
	}

	[Token(Token = "0x17000011")]
	public static IInstanceProvider InstanceProvider
	{
		[Address(RVA = "0x27A3E80", Offset = "0x27A3280", Length = "0x8B")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 139
	}

	[Token(Token = "0x17000012")]
	public static Func<IResourceLocation, String> InternalIdTransformFunc
	{
		[Address(RVA = "0x27A3FA0", Offset = "0x27A33A0", Length = "0x94")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 148
		[Address(RVA = "0x27A4450", Offset = "0x27A3850", Length = "0xA5")]
		[Token(Token = "0x6000042")]
		 set { } //Length: 165
	}

	[Token(Token = "0x1700000D")]
	private static AddressablesImpl m_Addressables
	{
		[Address(RVA = "0x27A4400", Offset = "0x27A3800", Length = "0x4F")]
		[Token(Token = "0x600003B")]
		private get { } //Length: 79
	}

	[Token(Token = "0x17000016")]
	public static string PlayerBuildDataPath
	{
		[Address(RVA = "0x27A4040", Offset = "0x27A3440", Length = "0x8D")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000018")]
	public static IEnumerable<IResourceLocator> ResourceLocators
	{
		[Address(RVA = "0x27A40D0", Offset = "0x27A34D0", Length = "0x8D")]
		[Token(Token = "0x6000049")]
		 get { } //Length: 141
	}

	[Token(Token = "0x1700000F")]
	public static ResourceManager ResourceManager
	{
		[Address(RVA = "0x27A4160", Offset = "0x27A3560", Length = "0x8B")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 139
	}

	[Preserve]
	[Token(Token = "0x17000017")]
	public static string RuntimePath
	{
		[Address(RVA = "0x27A41F0", Offset = "0x27A35F0", Length = "0x8D")]
		[Token(Token = "0x6000048")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000014")]
	public static string StreamingAssetsSubFolder
	{
		[Address(RVA = "0x27A4280", Offset = "0x27A3680", Length = "0xA8")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 168
	}

	[Token(Token = "0x1700000E")]
	public static string Version
	{
		[Address(RVA = "0x27A4330", Offset = "0x27A3730", Length = "0x2C")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000013")]
	public static Action<UnityWebRequest> WebRequestOverride
	{
		[Address(RVA = "0x27A4360", Offset = "0x27A3760", Length = "0x94")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 148
		[Address(RVA = "0x27A4500", Offset = "0x27A3900", Length = "0xA5")]
		[Token(Token = "0x6000044")]
		 set { } //Length: 165
	}

	[Address(RVA = "0x27A3B10", Offset = "0x27A2F10", Length = "0x2D5")]
	[Token(Token = "0x6000097")]
	private static Addressables() { }

	[Address(RVA = "0x279FE90", Offset = "0x279F290", Length = "0x198")]
	[Token(Token = "0x6000090")]
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null) { }

	[Address(RVA = "0x27A0030", Offset = "0x279F430", Length = "0xBD")]
	[Token(Token = "0x600008D")]
	public static AsyncOperationHandle<List`1<String>> CheckForCatalogUpdates(bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A00F0", Offset = "0x279F4F0", Length = "0xC5")]
	[Token(Token = "0x6000093")]
	public static AsyncOperationHandle<Boolean> CleanBundleCache(IEnumerable<String> catalogsIds = null) { }

	[Address(RVA = "0x27A06A0", Offset = "0x279FAA0", Length = "0xA6")]
	[Token(Token = "0x6000070")]
	public static void ClearDependencyCacheAsync(object key) { }

	[Address(RVA = "0x27A05F0", Offset = "0x279F9F0", Length = "0xA6")]
	[Token(Token = "0x6000071")]
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[Address(RVA = "0x27A0750", Offset = "0x279FB50", Length = "0xA6")]
	[Token(Token = "0x6000072")]
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	[Address(RVA = "0x27A0540", Offset = "0x279F940", Length = "0xA6")]
	[Token(Token = "0x6000073")]
	public static void ClearDependencyCacheAsync(string key) { }

	[Address(RVA = "0x27A0460", Offset = "0x279F860", Length = "0xD4")]
	[Token(Token = "0x6000074")]
	public static AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	[Address(RVA = "0x27A0380", Offset = "0x279F780", Length = "0xD4")]
	[Token(Token = "0x6000077")]
	public static AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	[Address(RVA = "0x27A01C0", Offset = "0x279F5C0", Length = "0xD4")]
	[Token(Token = "0x6000075")]
	public static AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[Address(RVA = "0x27A02A0", Offset = "0x279F6A0", Length = "0xD4")]
	[Token(Token = "0x6000076")]
	public static AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	[Address(RVA = "0x27A0800", Offset = "0x279FC00", Length = "0xD5")]
	[Token(Token = "0x6000092")]
	public static void ClearResourceLocators() { }

	[Address(RVA = "0x6E0010", Offset = "0x6DF410", Length = "0xC1")]
	[Token(Token = "0x6000096")]
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies(string remoteCatalogPath, string remoteHashPath) { }

	[Address(RVA = "0x6E00E0", Offset = "0x6DF4E0", Length = "0xB1")]
	[Token(Token = "0x6000094")]
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies(string remoteCatalogPath) { }

	[Address(RVA = "0x6E00E0", Offset = "0x6DF4E0", Length = "0xB1")]
	[Token(Token = "0x6000095")]
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies(IResourceLocation remoteCatalogLocation) { }

	[Address(RVA = "0x27A08E0", Offset = "0x279FCE0", Length = "0xE5")]
	[Token(Token = "0x600006F")]
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, MergeMode mode, bool autoReleaseHandle = false) { }

	[Address(RVA = "0x27A09D0", Offset = "0x279FDD0", Length = "0xD4")]
	[Token(Token = "0x600006E")]
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false) { }

	[Address(RVA = "0x27A0AB0", Offset = "0x279FEB0", Length = "0xD4")]
	[Token(Token = "0x600006D")]
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false) { }

	[Address(RVA = "0x27A3DF0", Offset = "0x27A31F0", Length = "0x8D")]
	[Token(Token = "0x6000046")]
	public static string get_BuildPath() { }

	[Address(RVA = "0x27A3F10", Offset = "0x27A3310", Length = "0x8A")]
	[Token(Token = "0x600003E")]
	internal static AddressablesImpl get_Instance() { }

	[Address(RVA = "0x27A3E80", Offset = "0x27A3280", Length = "0x8B")]
	[Token(Token = "0x600003F")]
	public static IInstanceProvider get_InstanceProvider() { }

	[Address(RVA = "0x27A3FA0", Offset = "0x27A33A0", Length = "0x94")]
	[Token(Token = "0x6000041")]
	public static Func<IResourceLocation, String> get_InternalIdTransformFunc() { }

	[Address(RVA = "0x27A4400", Offset = "0x27A3800", Length = "0x4F")]
	[Token(Token = "0x600003B")]
	private static AddressablesImpl get_m_Addressables() { }

	[Address(RVA = "0x27A4040", Offset = "0x27A3440", Length = "0x8D")]
	[Token(Token = "0x6000047")]
	public static string get_PlayerBuildDataPath() { }

	[Address(RVA = "0x27A40D0", Offset = "0x27A34D0", Length = "0x8D")]
	[Token(Token = "0x6000049")]
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[Address(RVA = "0x27A4160", Offset = "0x27A3560", Length = "0x8B")]
	[Token(Token = "0x600003D")]
	public static ResourceManager get_ResourceManager() { }

	[Address(RVA = "0x27A41F0", Offset = "0x27A35F0", Length = "0x8D")]
	[Token(Token = "0x6000048")]
	public static string get_RuntimePath() { }

	[Address(RVA = "0x27A4280", Offset = "0x27A3680", Length = "0xA8")]
	[Token(Token = "0x6000045")]
	public static string get_StreamingAssetsSubFolder() { }

	[Address(RVA = "0x27A4330", Offset = "0x27A3730", Length = "0x2C")]
	[Token(Token = "0x600003C")]
	public static string get_Version() { }

	[Address(RVA = "0x27A4360", Offset = "0x27A3760", Length = "0x94")]
	[Token(Token = "0x6000043")]
	public static Action<UnityWebRequest> get_WebRequestOverride() { }

	[Address(RVA = "0x27A0CF0", Offset = "0x27A00F0", Length = "0xBC")]
	[Token(Token = "0x600006C")]
	public static AsyncOperationHandle<Int64> GetDownloadSizeAsync(IEnumerable keys) { }

	[Address(RVA = "0x27A0B90", Offset = "0x279FF90", Length = "0x152")]
	[Token(Token = "0x600006B")]
	public static AsyncOperationHandle<Int64> GetDownloadSizeAsync(string key) { }

	[Address(RVA = "0x27A0DB0", Offset = "0x27A01B0", Length = "0x152")]
	[Token(Token = "0x600006A")]
	public static AsyncOperationHandle<Int64> GetDownloadSizeAsync(object key) { }

	[Address(RVA = "0x27A0F10", Offset = "0x27A0310", Length = "0xC5")]
	[Token(Token = "0x6000079")]
	public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator) { }

	[Address(RVA = "0x27A0FE0", Offset = "0x27A03E0", Length = "0x97")]
	[Token(Token = "0x6000078")]
	public static ResourceLocatorInfo GetLocatorInfo(string locatorId) { }

	[Address(RVA = "0x27A11B0", Offset = "0x27A05B0", Length = "0x114")]
	[Token(Token = "0x6000054")]
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	[Address(RVA = "0x27A1080", Offset = "0x27A0480", Length = "0x121")]
	[Token(Token = "0x6000055")]
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	[Address(RVA = "0x27A1450", Offset = "0x27A0850", Length = "0x17B")]
	[Token(Token = "0x600007D")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true) { }

	[Address(RVA = "0x27A15D0", Offset = "0x27A09D0", Length = "0x157")]
	[Token(Token = "0x600007A")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true) { }

	[Address(RVA = "0x27A12D0", Offset = "0x27A06D0", Length = "0x17B")]
	[Token(Token = "0x600007B")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true) { }

	[Address(RVA = "0x27A1840", Offset = "0x27A0C40", Length = "0x157")]
	[Token(Token = "0x600007C")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true) { }

	[Address(RVA = "0x27A19A0", Offset = "0x27A0DA0", Length = "0x108")]
	[Token(Token = "0x600007F")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	[Address(RVA = "0x27A1730", Offset = "0x27A0B30", Length = "0x108")]
	[Token(Token = "0x600007E")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	[Address(RVA = "0x27A1C00", Offset = "0x27A1000", Length = "0x124")]
	[Conditional("ADDRESSABLES_LOG_ALL")]
	[Token(Token = "0x600004A")]
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[Address(RVA = "0x27A1AB0", Offset = "0x27A0EB0", Length = "0x144")]
	[Conditional("ADDRESSABLES_LOG_ALL")]
	[Token(Token = "0x600004B")]
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, Object[] args) { }

	[Address(RVA = "0x6E0280", Offset = "0x6DF680", Length = "0xD6")]
	[Token(Token = "0x6000059")]
	public static AsyncOperationHandle<TObject> LoadAssetAsync(object key) { }

	[Address(RVA = "0x6E01A0", Offset = "0x6DF5A0", Length = "0xD6")]
	[Token(Token = "0x6000058")]
	public static AsyncOperationHandle<TObject> LoadAssetAsync(IResourceLocation location) { }

	[Address(RVA = "0x6E0360", Offset = "0x6DF760", Length = "0x104")]
	[Token(Token = "0x6000063")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x6E0750", Offset = "0x6DFB50", Length = "0xEF")]
	[Token(Token = "0x6000062")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(object key, Action<TObject> callback) { }

	[Address(RVA = "0x6E0580", Offset = "0x6DF980", Length = "0x1CA")]
	[Token(Token = "0x6000061")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(string key, bool releaseDependenciesOnFailure, Action<TObject> callback = null) { }

	[Address(RVA = "0x6E0470", Offset = "0x6DF870", Length = "0x10E")]
	[Token(Token = "0x6000060")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x6E0B10", Offset = "0x6DFF10", Length = "0x1B4")]
	[Token(Token = "0x600005F")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(string key, Action<TObject> callback = null) { }

	[Address(RVA = "0x6E0A00", Offset = "0x6DFE00", Length = "0x107")]
	[Token(Token = "0x600005E")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IEnumerable keys, Action<TObject> callback, MergeMode mode) { }

	[Address(RVA = "0x6E0360", Offset = "0x6DF760", Length = "0x104")]
	[Token(Token = "0x600005D")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x6E0750", Offset = "0x6DFB50", Length = "0xEF")]
	[Token(Token = "0x600005C")]
	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IList<IResourceLocation> locations, Action<TObject> callback) { }

	[Address(RVA = "0x27A1E10", Offset = "0x27A1210", Length = "0xE6")]
	[Token(Token = "0x6000057")]
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix = null) { }

	[Address(RVA = "0x27A1D30", Offset = "0x27A1130", Length = "0xD7")]
	[Token(Token = "0x6000056")]
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix = null) { }

	[Address(RVA = "0x27A1F00", Offset = "0x27A1300", Length = "0xD2")]
	[Token(Token = "0x600005B")]
	public static AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type = null) { }

	[Address(RVA = "0x27A1FE0", Offset = "0x27A13E0", Length = "0xE4")]
	[Token(Token = "0x600005A")]
	public static AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, MergeMode mode, Type type = null) { }

	[Address(RVA = "0x27A2200", Offset = "0x27A1600", Length = "0x123")]
	[Token(Token = "0x6000085")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A27A0", Offset = "0x27A1BA0", Length = "0xF8")]
	[Token(Token = "0x6000082")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A28A0", Offset = "0x27A1CA0", Length = "0x100")]
	[Token(Token = "0x6000083")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A2430", Offset = "0x27A1830", Length = "0x121")]
	[Token(Token = "0x6000084")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A2330", Offset = "0x27A1730", Length = "0xF8")]
	[Token(Token = "0x6000086")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A2560", Offset = "0x27A1960", Length = "0x100")]
	[Token(Token = "0x6000087")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A2670", Offset = "0x27A1A70", Length = "0x123")]
	[Token(Token = "0x6000081")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode, SceneReleaseMode releaseMode, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A20D0", Offset = "0x27A14D0", Length = "0x124")]
	[Token(Token = "0x6000080")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100, SceneReleaseMode releaseMode = 0) { }

	[Address(RVA = "0x27A2FA0", Offset = "0x27A23A0", Length = "0xC5")]
	[Conditional("ADDRESSABLES_LOG_ALL")]
	[Token(Token = "0x600004C")]
	public static void Log(string msg) { }

	[Address(RVA = "0x27A2A90", Offset = "0x27A1E90", Length = "0xC5")]
	[Token(Token = "0x6000050")]
	public static void LogError(string msg) { }

	[Address(RVA = "0x27A29B0", Offset = "0x27A1DB0", Length = "0xD5")]
	[Token(Token = "0x6000053")]
	public static void LogErrorFormat(string format, Object[] args) { }

	[Address(RVA = "0x27A2BF0", Offset = "0x27A1FF0", Length = "0x118")]
	[Token(Token = "0x6000051")]
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	[Address(RVA = "0x27A2B60", Offset = "0x27A1F60", Length = "0x85")]
	[Token(Token = "0x6000052")]
	public static void LogException(Exception ex) { }

	[Address(RVA = "0x27A2D10", Offset = "0x27A2110", Length = "0xD5")]
	[Conditional("ADDRESSABLES_LOG_ALL")]
	[Token(Token = "0x600004D")]
	public static void LogFormat(string format, Object[] args) { }

	[Address(RVA = "0x27A2ED0", Offset = "0x27A22D0", Length = "0xC5")]
	[Token(Token = "0x600004E")]
	public static void LogWarning(string msg) { }

	[Address(RVA = "0x27A2DF0", Offset = "0x27A21F0", Length = "0xD5")]
	[Token(Token = "0x600004F")]
	public static void LogWarningFormat(string format, Object[] args) { }

	[Address(RVA = "0x6E0CD0", Offset = "0x6E00D0", Length = "0x142")]
	[Token(Token = "0x6000064")]
	public static void Release(TObject obj) { }

	[Address(RVA = "0x6E0E60", Offset = "0x6E0260", Length = "0x3A")]
	[Token(Token = "0x6000065")]
	public static void Release(AsyncOperationHandle<TObject> handle) { }

	[Address(RVA = "0x27A3260", Offset = "0x27A2660", Length = "0x10")]
	[Token(Token = "0x6000066")]
	public static void Release(AsyncOperationHandle handle) { }

	[Address(RVA = "0x27A3220", Offset = "0x27A2620", Length = "0x3C")]
	[Token(Token = "0x6000069")]
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[Address(RVA = "0x27A3070", Offset = "0x27A2470", Length = "0x18D")]
	[Token(Token = "0x6000067")]
	public static bool ReleaseInstance(GameObject instance) { }

	[Address(RVA = "0x27A3200", Offset = "0x27A2600", Length = "0x12")]
	[Token(Token = "0x6000068")]
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	[Address(RVA = "0x27A3270", Offset = "0x27A2670", Length = "0x150")]
	[Token(Token = "0x6000091")]
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	[Address(RVA = "0x27A33D0", Offset = "0x27A27D0", Length = "0x97")]
	[Token(Token = "0x6000040")]
	public static string ResolveInternalId(string id) { }

	[Address(RVA = "0x27A4450", Offset = "0x27A3850", Length = "0xA5")]
	[Token(Token = "0x6000042")]
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, String> value) { }

	[Address(RVA = "0x27A4500", Offset = "0x27A3900", Length = "0xA5")]
	[Token(Token = "0x6000044")]
	public static void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	[Address(RVA = "0x27A3750", Offset = "0x27A2B50", Length = "0xEF")]
	[Token(Token = "0x600008B")]
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3560", Offset = "0x27A2960", Length = "0xFB")]
	[Token(Token = "0x6000089")]
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3840", Offset = "0x27A2C40", Length = "0xF3")]
	[Token(Token = "0x6000088")]
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3660", Offset = "0x27A2A60", Length = "0xE2")]
	[Token(Token = "0x600008A")]
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3470", Offset = "0x27A2870", Length = "0xEF")]
	[Token(Token = "0x600008C")]
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3940", Offset = "0x27A2D40", Length = "0xD9")]
	[Token(Token = "0x600008E")]
	public static AsyncOperationHandle<List`1<IResourceLocator>> UpdateCatalogs(IEnumerable<String> catalogs = null, bool autoReleaseHandle = true) { }

	[Address(RVA = "0x27A3A20", Offset = "0x27A2E20", Length = "0xE6")]
	[Token(Token = "0x600008F")]
	public static AsyncOperationHandle<List`1<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<String> catalogs = null, bool autoReleaseHandle = true) { }

}

