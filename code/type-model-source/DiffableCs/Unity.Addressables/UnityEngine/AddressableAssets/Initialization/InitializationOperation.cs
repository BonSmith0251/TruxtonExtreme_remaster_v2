namespace UnityEngine.AddressableAssets.Initialization;

[Token(Token = "0x2000062")]
internal class InitializationOperation : AsyncOperationBase<IResourceLocator>
{
	[CompilerGenerated]
	[Token(Token = "0x2000063")]
	private sealed class <>c
	{
		[Token(Token = "0x400015C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400015D")]
		public static Func<IResourceProvider, Boolean> <>9__12_0; //Field offset: 0x8

		[Address(RVA = "0x27B9C60", Offset = "0x27B9060", Length = "0x67")]
		[Token(Token = "0x600026E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600026F")]
		public <>c() { }

		[Address(RVA = "0x27B99D0", Offset = "0x27B8DD0", Length = "0x7F")]
		[Token(Token = "0x6000270")]
		internal bool <Execute>b__12_0(IResourceProvider rp) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015E")]
		public AddressablesImpl addressables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400015F")]
		public string providerSuffix; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000160")]
		public IResourceLocation remoteHashLocation; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000271")]
		public <>c__DisplayClass15_0() { }

		[Address(RVA = "0x27B9A50", Offset = "0x27B8E50", Length = "0x60")]
		[Token(Token = "0x6000272")]
		internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalog>b__0(AsyncOperationHandle<ContentCatalogData> res) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000161")]
		public InitializationOperation <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000162")]
		public IList<IResourceLocation> catalogs; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000163")]
		public ResourceLocationMap locMap; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000164")]
		public int index; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000165")]
		public IResourceLocation remoteHashLocation; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000273")]
		public <>c__DisplayClass17_0() { }

		[Address(RVA = "0x27B9AB0", Offset = "0x27B8EB0", Length = "0x58")]
		[Token(Token = "0x6000274")]
		internal void <LoadContentCatalogInternal>b__0(AsyncOperationHandle<IResourceLocator> op) { }

	}

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000157")]
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; //Field offset: 0x98
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000158")]
	private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000159")]
	private string m_ProviderSuffix; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400015A")]
	private AddressablesImpl m_Addressables; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400015B")]
	private InitalizationObjectsOperation m_InitGroupOps; //Field offset: 0xD8

	[Token(Token = "0x1700006C")]
	protected virtual string DebugName
	{
		[Address(RVA = "0x27B97F0", Offset = "0x27B8BF0", Length = "0x2C")]
		[Token(Token = "0x6000264")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700006B")]
	protected virtual float Progress
	{
		[Address(RVA = "0x27B9820", Offset = "0x27B8C20", Length = "0x69")]
		[Token(Token = "0x6000263")]
		 get { } //Length: 105
	}

	[Address(RVA = "0x27B9790", Offset = "0x27B8B90", Length = "0x5B")]
	[Token(Token = "0x6000262")]
	public InitializationOperation(AddressablesImpl aa) { }

	[Address(RVA = "0x27B7370", Offset = "0x27B6770", Length = "0x4B9")]
	[Token(Token = "0x6000265")]
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	[Address(RVA = "0x27B7830", Offset = "0x27B6C30", Length = "0x9E0")]
	[Token(Token = "0x6000267")]
	protected virtual void Execute() { }

	[Address(RVA = "0x27B97F0", Offset = "0x27B8BF0", Length = "0x2C")]
	[Token(Token = "0x6000264")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0x27B9820", Offset = "0x27B8C20", Length = "0x69")]
	[Token(Token = "0x6000263")]
	protected virtual float get_Progress() { }

	[Address(RVA = "0x27B8220", Offset = "0x27B7620", Length = "0x1AA")]
	[Token(Token = "0x6000266")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x27B8620", Offset = "0x27B7A20", Length = "0x5D5")]
	[Token(Token = "0x600026A")]
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation = null) { }

	[Address(RVA = "0x27B85D0", Offset = "0x27B79D0", Length = "0x49")]
	[Token(Token = "0x600026B")]
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	[Address(RVA = "0x27B83D0", Offset = "0x27B77D0", Length = "0x1FF")]
	[Token(Token = "0x600026C")]
	internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation) { }

	[Address(RVA = "0x27B8C00", Offset = "0x27B8000", Length = "0x36A")]
	[Token(Token = "0x600026D")]
	private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation) { }

	[Address(RVA = "0x27B8F70", Offset = "0x27B8370", Length = "0x2EA")]
	[Token(Token = "0x6000268")]
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	[Address(RVA = "0x27B9260", Offset = "0x27B8660", Length = "0x52A")]
	[Token(Token = "0x6000269")]
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation) { }

}

