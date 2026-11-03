namespace UnityEngine.AddressableAssets.ResourceProviders;

[DisplayName("Content Catalog Provider")]
[Token(Token = "0x2000044")]
public class ContentCatalogProvider : ResourceProviderBase
{
	[Token(Token = "0x2000045")]
	internal enum DependencyHashIndex : int
	{
		Remote = 0,
		Cache = 1,
		Local = 2,
		Count = 3,
	}

	[Token(Token = "0x2000046")]
	public class InternalOp
	{
		[Token(Token = "0x2000047")]
		public class BundledCatalog
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000F3")]
			private readonly string m_BundlePath; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000F4")]
			private bool m_OpInProgress; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000F5")]
			private AssetBundleCreateRequest m_LoadBundleRequest; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40000F6")]
			internal AssetBundle m_CatalogAssetBundle; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40000F7")]
			private AssetBundleRequest m_LoadTextAssetRequest; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x40000F8")]
			private ContentCatalogData m_CatalogData; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x40000F9")]
			private WebRequestQueueOperation m_WebRequestQueueOperation; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x40000FA")]
			private AsyncOperation m_RequestOperation; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x40000FB")]
			private int m_WebRequestTimeout; //Field offset: 0x50
			[CompilerGenerated]
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x40000FC")]
			private Action<ContentCatalogData> OnLoaded; //Field offset: 0x58

			[Token(Token = "0x14000001")]
			public event Action<ContentCatalogData> OnLoaded
			{
				[Address(RVA = "0x27A6880", Offset = "0x27A5C80", Length = "0xAC")]
				[CompilerGenerated]
				[Token(Token = "0x60001C7")]
				 add { } //Length: 172
				[Address(RVA = "0x27A6950", Offset = "0x27A5D50", Length = "0xAC")]
				[CompilerGenerated]
				[Token(Token = "0x60001C8")]
				 remove { } //Length: 172
			}

			[Token(Token = "0x17000038")]
			public bool OpInProgress
			{
				[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
				[Token(Token = "0x60001C9")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000039")]
			public bool OpIsSuccess
			{
				[Address(RVA = "0x27A6930", Offset = "0x27A5D30", Length = "0x12")]
				[Token(Token = "0x60001CA")]
				 get { } //Length: 18
			}

			[Address(RVA = "0x27A6740", Offset = "0x27A5B40", Length = "0x13D")]
			[Token(Token = "0x60001CB")]
			public BundledCatalog(string bundlePath, int webRequestTimeout = 0) { }

			[Address(RVA = "0x27A6140", Offset = "0x27A5540", Length = "0x1EE")]
			[CompilerGenerated]
			[Token(Token = "0x60001D3")]
			private void <LoadCatalogFromBundleAsync>b__19_0(AsyncOperation loadOp) { }

			[Address(RVA = "0x27A6330", Offset = "0x27A5730", Length = "0x9C")]
			[CompilerGenerated]
			[Token(Token = "0x60001D2")]
			private void <LoadCatalogFromBundleAsync>b__19_1(UnityWebRequestAsyncOperation asyncOp) { }

			[Address(RVA = "0x27A6880", Offset = "0x27A5C80", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x60001C7")]
			public void add_OnLoaded(Action<ContentCatalogData> value) { }

			[Address(RVA = "0x27A5C40", Offset = "0x27A5040", Length = "0x78")]
			[Token(Token = "0x60001CC")]
			protected virtual void Finalize() { }

			[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
			[Token(Token = "0x60001C9")]
			public bool get_OpInProgress() { }

			[Address(RVA = "0x27A6930", Offset = "0x27A5D30", Length = "0x12")]
			[Token(Token = "0x60001CA")]
			public bool get_OpIsSuccess() { }

			[Address(RVA = "0x27A5CC0", Offset = "0x27A50C0", Length = "0x2D4")]
			[Token(Token = "0x60001CE")]
			public void LoadCatalogFromBundleAsync() { }

			[Address(RVA = "0x27A5FA0", Offset = "0x27A53A0", Length = "0x198")]
			[Token(Token = "0x60001D0")]
			private void LoadTextAssetRequestComplete(AsyncOperation op) { }

			[Address(RVA = "0x27A6950", Offset = "0x27A5D50", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x60001C8")]
			public void remove_OnLoaded(Action<ContentCatalogData> value) { }

			[Address(RVA = "0x27A63D0", Offset = "0x27A57D0", Length = "0x34")]
			[Token(Token = "0x60001CD")]
			private void Unload() { }

			[Address(RVA = "0x27A6410", Offset = "0x27A5810", Length = "0xE0")]
			[Token(Token = "0x60001D1")]
			public bool WaitForCompletion() { }

			[Address(RVA = "0x27A6500", Offset = "0x27A5900", Length = "0x23F")]
			[Token(Token = "0x60001CF")]
			private void WebRequestOperationCompleted(AsyncOperation op) { }

		}

		[Token(Token = "0x40000F2")]
		private const string kCatalogExt = ".bin"; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E8")]
		private string m_LocalDataPath; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E9")]
		private string m_RemoteHashValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000EA")]
		internal string m_LocalHashValue; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000EB")]
		private ProvideHandle m_ProviderInterface; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000EC")]
		internal ContentCatalogData m_ContentCatalogData; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000ED")]
		private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40000EE")]
		private BundledCatalog m_BundledCatalog; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40000EF")]
		private bool m_Retried; //Field offset: 0x68
		[FieldOffset(Offset = "0x69")]
		[Token(Token = "0x40000F0")]
		private bool m_DisableCatalogUpdateOnStart; //Field offset: 0x69
		[FieldOffset(Offset = "0x6A")]
		[Token(Token = "0x40000F1")]
		private bool m_IsLocalCatalogInBundle; //Field offset: 0x6A

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001C5")]
		public InternalOp() { }

		[Address(RVA = "0x27AC0E0", Offset = "0x27AB4E0", Length = "0x35")]
		[CompilerGenerated]
		[Token(Token = "0x60001C6")]
		private void <LoadCatalog>b__14_0(ContentCatalogData ccd) { }

		[Address(RVA = "0x27AA9D0", Offset = "0x27A9DD0", Length = "0xF6")]
		[Token(Token = "0x60001BF")]
		internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location) { }

		[Address(RVA = "0x27AAAD0", Offset = "0x27A9ED0", Length = "0x80")]
		[Token(Token = "0x60001C1")]
		private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op) { }

		[Address(RVA = "0x27AAB50", Offset = "0x27A9F50", Length = "0x513")]
		[Token(Token = "0x60001C3")]
		internal string DetermineIdToLoad(IResourceLocation location, IList<Object> dependencyObjects, bool disableCatalogUpdateOnStart = false) { }

		[Address(RVA = "0x27AB070", Offset = "0x27AA470", Length = "0x71")]
		[Token(Token = "0x60001C2")]
		private string GetTransformedInternalId(IResourceLocation loc) { }

		[Address(RVA = "0x27AB0F0", Offset = "0x27AA4F0", Length = "0x62B")]
		[Token(Token = "0x60001C0")]
		internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle) { }

		[Address(RVA = "0x27AB720", Offset = "0x27AAB20", Length = "0x723")]
		[Token(Token = "0x60001C4")]
		private void OnCatalogLoaded(ContentCatalogData ccd) { }

		[Address(RVA = "0x27ABE50", Offset = "0x27AB250", Length = "0x46")]
		[Token(Token = "0x60001BE")]
		public void Release() { }

		[Address(RVA = "0x27ABEA0", Offset = "0x27AB2A0", Length = "0x234")]
		[Token(Token = "0x60001BC")]
		public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

		[Address(RVA = "0x27AC120", Offset = "0x27AB520", Length = "0x1B1")]
		[Token(Token = "0x60001BD")]
		private bool WaitForCompletionCallback() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E0")]
	public bool DisableCatalogUpdateOnStart; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000E1")]
	public bool IsLocalCatalogInBundle; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E2")]
	internal Dictionary<IResourceLocation, InternalOp> m_LocationToCatalogLoadOpMap; //Field offset: 0x28

	[Address(RVA = "0x27A9330", Offset = "0x27A8730", Length = "0x7F")]
	[Token(Token = "0x60001B9")]
	public ContentCatalogProvider(ResourceManager resourceManagerInstance) { }

	[Address(RVA = "0x27A90C0", Offset = "0x27A84C0", Length = "0x150")]
	[Token(Token = "0x60001BB")]
	public virtual void Provide(ProvideHandle providerInterface) { }

	[Address(RVA = "0x27A9220", Offset = "0x27A8620", Length = "0x109")]
	[Token(Token = "0x60001BA")]
	public virtual void Release(IResourceLocation location, object obj) { }

}

