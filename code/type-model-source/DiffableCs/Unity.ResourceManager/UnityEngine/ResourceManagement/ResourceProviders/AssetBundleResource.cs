namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000049")]
public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private sealed class <>c
	{
		[Token(Token = "0x40000DE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000DF")]
		public static Func<UnityWebRequestResult, Boolean> <>9__53_0; //Field offset: 0x8

		[Address(RVA = "0x2E50940", Offset = "0x2E4FD40", Length = "0x67")]
		[Token(Token = "0x60001C0")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001C1")]
		public <>c() { }

		[Address(RVA = "0x2E370D0", Offset = "0x2E364D0", Length = "0x1F")]
		[Token(Token = "0x60001C2")]
		internal bool <.ctor>b__53_0(UnityWebRequestResult x) { }

	}

	[Token(Token = "0x200004B")]
	public enum CacheStatus : int
	{
		Unknown = 0,
		Cached = 1,
		NotCached = 2,
	}

	[Token(Token = "0x200004A")]
	internal enum LoadType : int
	{
		None = 0,
		Local = 1,
		Web = 2,
	}

	[Token(Token = "0x40000CB")]
	private const int k_WaitForWebRequestMainThreadSleep = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BE")]
	private AssetBundle m_AssetBundle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BF")]
	private AsyncOperation m_RequestOperation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C0")]
	internal WebRequestQueueOperation m_WebRequestQueueOperation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C1")]
	internal ProvideHandle m_ProvideHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C2")]
	internal AssetBundleRequestOptions m_Options; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000C3")]
	internal CacheStatus cacheStatus; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000C4")]
	private bool m_RequestCompletedCallbackCalled; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000C5")]
	private int m_Retries; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000C6")]
	private BundleSource m_Source; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000C7")]
	private long m_BytesToDownload; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000C8")]
	private long m_DownloadedBytes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000C9")]
	private bool m_Completed; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000CA")]
	private AssetBundleUnloadOperation m_UnloadOperation; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000CC")]
	private string m_TransformedInternalId; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000CD")]
	private AssetBundleRequest m_PreloadRequest; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000CE")]
	private bool m_PreloadCompleted; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000CF")]
	private ulong m_LastDownloadedByteCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000D0")]
	private float m_TimeoutTimer; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000D1")]
	private int m_TimeoutOverFrames; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000D2")]
	internal bool m_DownloadOnly; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40000D3")]
	private int m_LastFrameCount; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000D4")]
	private float m_TimeSecSinceLastUpdate; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000D5")]
	internal Func<UnityWebRequestResult, Boolean> m_RequestRetryCallback; //Field offset: 0xB0

	[Token(Token = "0x17000044")]
	internal long BytesToDownload
	{
		[Address(RVA = "0x2E3A6B0", Offset = "0x2E39AB0", Length = "0x83")]
		[Token(Token = "0x60001A5")]
		internal get { } //Length: 131
	}

	[Token(Token = "0x17000043")]
	private bool HasTimedOut
	{
		[Address(RVA = "0x2E3A740", Offset = "0x2E39B40", Length = "0x2E")]
		[Token(Token = "0x60001A4")]
		private get { } //Length: 46
	}

	[Address(RVA = "0x2E3A590", Offset = "0x2E39990", Length = "0x119")]
	[Token(Token = "0x60001BD")]
	public AssetBundleResource() { }

	[Address(RVA = "0x2E39830", Offset = "0x2E38C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60001BF")]
	private void <AddBeginWebRequestHandler>b__46_0(UnityWebRequestAsyncOperation asyncOp) { }

	[Address(RVA = "0x2E39840", Offset = "0x2E38C40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60001BE")]
	private void <GetAssetPreloadRequest>b__33_0(AsyncOperation operation) { }

	[Address(RVA = "0x2E37660", Offset = "0x2E36A60", Length = "0x129")]
	[Token(Token = "0x60001B6")]
	internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation) { }

	[Address(RVA = "0x2E37790", Offset = "0x2E36B90", Length = "0x61")]
	[Token(Token = "0x60001B0")]
	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	[Address(RVA = "0x2E37800", Offset = "0x2E36C00", Length = "0x7D8")]
	[Token(Token = "0x60001B3")]
	private void BeginOperation() { }

	[Address(RVA = "0x2E37FE0", Offset = "0x2E373E0", Length = "0x135")]
	[Token(Token = "0x60001B7")]
	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	[Address(RVA = "0x2E38120", Offset = "0x2E37520", Length = "0x186")]
	[Token(Token = "0x60001BA")]
	private void CompleteBundleLoad(AssetBundle bundle) { }

	[Address(RVA = "0x2E38520", Offset = "0x2E37920", Length = "0x95")]
	[Token(Token = "0x60001A7")]
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	[Address(RVA = "0x2E382B0", Offset = "0x2E376B0", Length = "0x267")]
	[Token(Token = "0x60001A8")]
	internal UnityWebRequest CreateWebRequest(string url) { }

	[Address(RVA = "0x2E385C0", Offset = "0x2E379C0", Length = "0x17E")]
	[Token(Token = "0x60001B5")]
	internal WebRequestQueueOperation EnqueueWebRequest(string internalId) { }

	[Address(RVA = "0x2E3A6B0", Offset = "0x2E39AB0", Length = "0x83")]
	[Token(Token = "0x60001A5")]
	internal long get_BytesToDownload() { }

	[Address(RVA = "0x2E3A740", Offset = "0x2E39B40", Length = "0x2E")]
	[Token(Token = "0x60001A4")]
	private bool get_HasTimedOut() { }

	[Address(RVA = "0x2E38740", Offset = "0x2E37B40", Length = "0x4B")]
	[Token(Token = "0x60001AC")]
	public override AssetBundle GetAssetBundle() { }

	[Address(RVA = "0x2E38790", Offset = "0x2E37B90", Length = "0x15A")]
	[Token(Token = "0x60001A9")]
	public AssetBundleRequest GetAssetPreloadRequest() { }

	[Address(RVA = "0x2E388F0", Offset = "0x2E37CF0", Length = "0x191")]
	[Token(Token = "0x60001AB")]
	private DownloadStatus GetDownloadStatus() { }

	[Address(RVA = "0x2E38B20", Offset = "0x2E37F20", Length = "0x329")]
	[Token(Token = "0x60001B2")]
	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out LoadType loadType, out string path) { }

	[Address(RVA = "0x2E38A90", Offset = "0x2E37E90", Length = "0x87")]
	[Token(Token = "0x60001B1")]
	public static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path) { }

	[Address(RVA = "0x2E38E50", Offset = "0x2E38250", Length = "0xE3")]
	[Token(Token = "0x60001A6")]
	internal bool IsCached() { }

	[Address(RVA = "0x2E38F40", Offset = "0x2E38340", Length = "0xF2")]
	[Token(Token = "0x60001B4")]
	private void LoadLocalBundle() { }

	[Address(RVA = "0x2E39040", Offset = "0x2E38440", Length = "0x2F8")]
	[Token(Token = "0x60001B9")]
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	[Address(RVA = "0x2E39340", Offset = "0x2E38740", Length = "0x2B")]
	[Token(Token = "0x60001AD")]
	private void OnUnloadOperationComplete(AsyncOperation op) { }

	[Address(RVA = "0x2E39370", Offset = "0x2E38770", Length = "0x16")]
	[Token(Token = "0x60001AA")]
	private float PercentComplete() { }

	[Address(RVA = "0x2E39390", Offset = "0x2E38790", Length = "0x495")]
	[Token(Token = "0x60001AE")]
	public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp, Func<UnityWebRequestResult, Boolean> requestRetryCallback) { }

	[Address(RVA = "0x2E39850", Offset = "0x2E38C50", Length = "0xCF")]
	[Token(Token = "0x60001BC")]
	public bool Unload(out AssetBundleUnloadOperation unloadOp) { }

	[Address(RVA = "0x2E39920", Offset = "0x2E38D20", Length = "0x181")]
	[Token(Token = "0x60001B8")]
	public override void Update(float unscaledDeltaTime) { }

	[Address(RVA = "0x2E39AB0", Offset = "0x2E38EB0", Length = "0x465")]
	[Token(Token = "0x60001AF")]
	private bool WaitForCompletionHandler() { }

	[Address(RVA = "0x2E39F20", Offset = "0x2E39320", Length = "0x664")]
	[Token(Token = "0x60001BB")]
	private void WebRequestOperationCompleted(AsyncOperation op) { }

}

