namespace UnityEngine.ResourceManagement;

[Token(Token = "0x200000B")]
public class ResourceManager : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <>c__DisplayClass90_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		public Action<TObject> callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		public bool releaseDependenciesOnFailure; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		public ResourceManager <>4__this; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000097")]
		public <>c__DisplayClass90_0`1() { }

		[Address(RVA = "0xA76560", Offset = "0xA75960", Length = "0x99")]
		[Token(Token = "0x6000098")]
		internal void <ProvideResources>b__0(AsyncOperationHandle x) { }

		[Address(RVA = "0xA76E60", Offset = "0xA76260", Length = "0x762")]
		[Token(Token = "0x6000099")]
		internal AsyncOperationHandle<IList`1<TObject>> <ProvideResources>b__1(AsyncOperationHandle resultHandle) { }

	}

	[Token(Token = "0x200000E")]
	private class CompletedOperation : AsyncOperationBase<TObject>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private bool m_Success; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private Exception m_Exception; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		private bool m_ReleaseDependenciesOnFailure; //Field offset: 0x0

		[Token(Token = "0x17000014")]
		protected virtual string DebugName
		{
			[Address(RVA = "0x17A5070", Offset = "0x17A4470", Length = "0x2C")]
			[Token(Token = "0x600008A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x17A4F70", Offset = "0x17A4370", Length = "0x13")]
		[Token(Token = "0x6000087")]
		public CompletedOperation`1() { }

		[Address(RVA = "0x17A4130", Offset = "0x17A3530", Length = "0x4A")]
		[Token(Token = "0x600008C")]
		protected virtual void Execute() { }

		[Address(RVA = "0x17A5070", Offset = "0x17A4470", Length = "0x2C")]
		[Token(Token = "0x600008A")]
		protected virtual string get_DebugName() { }

		[Address(RVA = "0x17A49C0", Offset = "0x17A3DC0", Length = "0xC4")]
		[Token(Token = "0x6000088")]
		public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = true) { }

		[Address(RVA = "0x17A45F0", Offset = "0x17A39F0", Length = "0x44")]
		[Token(Token = "0x6000089")]
		public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true) { }

		[Address(RVA = "0x17A4DE0", Offset = "0x17A41E0", Length = "0x62")]
		[Token(Token = "0x600008B")]
		protected virtual bool InvokeWaitForCompletion() { }

	}

	[Token(Token = "0x200000D")]
	private struct DeferredCallbackRegisterRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		internal IAsyncOperation operation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003E")]
		internal bool incrementRefCount; //Field offset: 0x8

	}

	[Token(Token = "0x200000C")]
	internal enum DiagnosticEventType : int
	{
		AsyncOperationFail = 0,
		AsyncOperationCreate = 1,
		AsyncOperationPercentComplete = 2,
		AsyncOperationComplete = 3,
		AsyncOperationReferenceCount = 4,
		AsyncOperationDestroy = 5,
	}

	[Token(Token = "0x200000F")]
	public class InstanceOperation : AsyncOperationBase<GameObject>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000042")]
		private AsyncOperationHandle<GameObject> m_dependency; //Field offset: 0x98
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000043")]
		private InstantiationParameters m_instantiationParams; //Field offset: 0xB0
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000044")]
		private IInstanceProvider m_instanceProvider; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000045")]
		private GameObject m_instance; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000046")]
		private Scene m_scene; //Field offset: 0xF0

		[Token(Token = "0x17000015")]
		protected virtual string DebugName
		{
			[Address(RVA = "0x2E41540", Offset = "0x2E40940", Length = "0x10A")]
			[Token(Token = "0x6000090")]
			 get { } //Length: 266
		}

		[Token(Token = "0x17000016")]
		protected virtual float Progress
		{
			[Address(RVA = "0x2E41650", Offset = "0x2E40A50", Length = "0x3D")]
			[Token(Token = "0x6000093")]
			 get { } //Length: 61
		}

		[Address(RVA = "0x2E41500", Offset = "0x2E40900", Length = "0x39")]
		[Token(Token = "0x6000096")]
		public InstanceOperation() { }

		[Address(RVA = "0x2E40D70", Offset = "0x2E40170", Length = "0x109")]
		[Token(Token = "0x6000092")]
		protected virtual void Destroy() { }

		[Address(RVA = "0x2E40E80", Offset = "0x2E40280", Length = "0x292")]
		[Token(Token = "0x6000095")]
		protected virtual void Execute() { }

		[Address(RVA = "0x2E41540", Offset = "0x2E40940", Length = "0x10A")]
		[Token(Token = "0x6000090")]
		protected virtual string get_DebugName() { }

		[Address(RVA = "0x2E41650", Offset = "0x2E40A50", Length = "0x3D")]
		[Token(Token = "0x6000093")]
		protected virtual float get_Progress() { }

		[Address(RVA = "0x2E41120", Offset = "0x2E40520", Length = "0x11F")]
		[Token(Token = "0x600008F")]
		public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

		[Address(RVA = "0x2E41240", Offset = "0x2E40640", Length = "0xE2")]
		[Token(Token = "0x600008E")]
		internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

		[Address(RVA = "0x2E41330", Offset = "0x2E40730", Length = "0xAB")]
		[Token(Token = "0x600008D")]
		public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency) { }

		[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
		[Token(Token = "0x6000091")]
		public Scene InstanceScene() { }

		[Address(RVA = "0x2E413E0", Offset = "0x2E407E0", Length = "0x11F")]
		[Token(Token = "0x6000094")]
		protected virtual bool InvokeWaitForCompletion() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x400001D")]
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000031")]
	private static int s_GroupOperationTypeHash; //Field offset: 0x8
	[Token(Token = "0x4000032")]
	private static int s_InstanceOperationTypeHash; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001E")]
	private Func<IResourceLocation, String> <InternalIdTransformFunc>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001F")]
	private Action<UnityWebRequest> <WebRequestOverride>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000020")]
	internal bool CallbackHooksEnabled; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000021")]
	private ListWithEvents<IResourceProvider> m_ResourceProviders; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000022")]
	private IAllocationStrategy m_allocator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000023")]
	internal ListWithEvents<IUpdateReceiver> m_UpdateReceivers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000024")]
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000025")]
	private bool m_UpdatingReceivers; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000026")]
	private bool m_InsideUpdateMethod; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000027")]
	internal Dictionary<Int32, IResourceProvider> m_providerMap; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000028")]
	private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000029")]
	private HashSet<InstanceOperation> m_TrackedInstanceOperations; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400002A")]
	internal DelegateList<Single> m_UpdateCallbacks; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400002B")]
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400002C")]
	private bool m_InsideExecuteDeferredCallbacksMethod; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400002D")]
	private List<DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400002E")]
	private Action<IAsyncOperation> m_ReleaseOpNonCached; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400002F")]
	private Action<IAsyncOperation> m_ReleaseOpCached; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000030")]
	private Action<IAsyncOperation> m_ReleaseInstanceOp; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000033")]
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000034")]
	private bool m_RegisteredForCallbacks; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000035")]
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; //Field offset: 0xB0

	[Token(Token = "0x17000011")]
	public IAllocationStrategy Allocator
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000050")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000013")]
	public CertificateHandler CertificateHandlerInstance
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000010")]
	internal int DeferredCallbackCount
	{
		[Address(RVA = "0x2E4D8C0", Offset = "0x2E4CCC0", Length = "0x40")]
		[Token(Token = "0x600004C")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x1700000F")]
	internal int DeferredCompleteCallbacksCount
	{
		[Address(RVA = "0x2E4D900", Offset = "0x2E4CD00", Length = "0x3C")]
		[Token(Token = "0x600004B")]
		internal get { } //Length: 60
	}

	[Token(Token = "0x1700000A")]
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler
	{
		[Address(RVA = "0x2E4D940", Offset = "0x2E4CD40", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000042")]
		 get { } //Length: 78
		[Address(RVA = "0x2E4DA20", Offset = "0x2E4CE20", Length = "0x69")]
		[CompilerGenerated]
		[Token(Token = "0x6000043")]
		 set { } //Length: 105
	}

	[Token(Token = "0x1700000E")]
	internal int InstanceOperationCount
	{
		[Address(RVA = "0x2E4D990", Offset = "0x2E4CD90", Length = "0x3C")]
		[Token(Token = "0x600004A")]
		internal get { } //Length: 60
	}

	[Token(Token = "0x1700000B")]
	public Func<IResourceLocation, String> InternalIdTransformFunc
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000044")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000045")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000D")]
	internal int OperationCacheCount
	{
		[Address(RVA = "0x2E4D9D0", Offset = "0x2E4CDD0", Length = "0x44")]
		[Token(Token = "0x6000049")]
		internal get { } //Length: 68
	}

	[Token(Token = "0x17000012")]
	public IList<IResourceProvider> ResourceProviders
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public Action<UnityWebRequest> WebRequestOverride
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000047")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000048")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2E4D340", Offset = "0x2E4C740", Length = "0xD3")]
	[Token(Token = "0x6000085")]
	private static ResourceManager() { }

	[Address(RVA = "0x2E4D420", Offset = "0x2E4C820", Length = "0x49C")]
	[Token(Token = "0x6000054")]
	public ResourceManager(IAllocationStrategy alloc = null) { }

	[Address(RVA = "0x2E4CF00", Offset = "0x2E4C300", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000086")]
	private void <.ctor>b__53_0(IUpdateReceiver x) { }

	[Address(RVA = "0x8EA180", Offset = "0x8E9580", Length = "0x62")]
	[Token(Token = "0x600006E")]
	public AsyncOperationHandle<TObject> Acquire(AsyncOperationHandle<TObject> handle) { }

	[Address(RVA = "0x2E49680", Offset = "0x2E48A80", Length = "0x52")]
	[Token(Token = "0x600006F")]
	public void Acquire(AsyncOperationHandle handle) { }

	[Address(RVA = "0x2E49570", Offset = "0x2E48970", Length = "0x100")]
	[Token(Token = "0x6000070")]
	private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key) { }

	[Address(RVA = "0x2E496E0", Offset = "0x2E48AE0", Length = "0x9C")]
	[Token(Token = "0x6000065")]
	internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation) { }

	[Address(RVA = "0x2E49780", Offset = "0x2E48B80", Length = "0x59")]
	[Token(Token = "0x600004D")]
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	[Address(RVA = "0x2E497E0", Offset = "0x2E48BE0", Length = "0x44")]
	[Token(Token = "0x6000068")]
	internal int CachedOperationCount() { }

	[Address(RVA = "0x2E49830", Offset = "0x2E48C30", Length = "0x25F")]
	[Token(Token = "0x600005A")]
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t = null) { }

	[Address(RVA = "0x2E49A90", Offset = "0x2E48E90", Length = "0x348")]
	[Token(Token = "0x6000080")]
	public void CleanupSceneInstances(Scene scene) { }

	[Address(RVA = "0x2E49DE0", Offset = "0x2E491E0", Length = "0x44")]
	[Token(Token = "0x6000069")]
	internal void ClearOperationCache() { }

	[Address(RVA = "0x2E49E30", Offset = "0x2E49230", Length = "0x1A9")]
	[Token(Token = "0x600005D")]
	internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType = null) { }

	[Address(RVA = "0x8EA910", Offset = "0x8E9D10", Length = "0x1CE")]
	[Token(Token = "0x6000077")]
	public AsyncOperationHandle<TObject> CreateChainOperation(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle`1<TObjectDependency>, AsyncOperationHandle`1<TObject>> callback) { }

	[Address(RVA = "0x8EA1F0", Offset = "0x8E95F0", Length = "0x142")]
	[Token(Token = "0x6000078")]
	public AsyncOperationHandle<TObject> CreateChainOperation(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle`1<TObject>> callback) { }

	[Address(RVA = "0x8EA500", Offset = "0x8E9900", Length = "0x1C3")]
	[Token(Token = "0x6000079")]
	public AsyncOperationHandle<TObject> CreateChainOperation(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle`1<TObjectDependency>, AsyncOperationHandle`1<TObject>> callback, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x8EAF50", Offset = "0x8EA350", Length = "0x148")]
	[Token(Token = "0x600007A")]
	public AsyncOperationHandle<TObject> CreateChainOperation(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle`1<TObject>> callback, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x8EBFE0", Offset = "0x8EB3E0", Length = "0x20A")]
	[Token(Token = "0x600006A")]
	public AsyncOperationHandle<TObject> CreateCompletedOperation(TObject result, string errorMsg) { }

	[Address(RVA = "0x8EB3C0", Offset = "0x8EA7C0", Length = "0x1AF")]
	[Token(Token = "0x600006C")]
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x8EBDF0", Offset = "0x8EB1F0", Length = "0x99")]
	[Token(Token = "0x600006B")]
	public AsyncOperationHandle<TObject> CreateCompletedOperationWithException(TObject result, Exception exception) { }

	[Address(RVA = "0x2E49FE0", Offset = "0x2E493E0", Length = "0x25C")]
	[Token(Token = "0x6000073")]
	public AsyncOperationHandle<IList`1<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = false) { }

	[Address(RVA = "0x8ED0A0", Offset = "0x8EC4A0", Length = "0x539")]
	[Token(Token = "0x6000071")]
	public AsyncOperationHandle<IList`1<AsyncOperationHandle>> CreateGroupOperation(IList<IResourceLocation> locations) { }

	[Address(RVA = "0x8ED5E0", Offset = "0x8EC9E0", Length = "0x55F")]
	[Token(Token = "0x6000072")]
	internal AsyncOperationHandle<IList`1<AsyncOperationHandle>> CreateGroupOperation(IList<IResourceLocation> locations, bool allowFailedDependencies) { }

	[Address(RVA = "0x8EDED0", Offset = "0x8ED2D0", Length = "0x1AB")]
	[Token(Token = "0x6000064")]
	internal T CreateOperation(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) { }

	[Address(RVA = "0x2E4A240", Offset = "0x2E49640", Length = "0x162")]
	[Token(Token = "0x6000084")]
	public override void Dispose() { }

	[Address(RVA = "0x2E4A3B0", Offset = "0x2E497B0", Length = "0x219")]
	[Token(Token = "0x6000081")]
	private void ExecuteDeferredCallbacks() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600004F")]
	public IAllocationStrategy get_Allocator() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	public CertificateHandler get_CertificateHandlerInstance() { }

	[Address(RVA = "0x2E4D8C0", Offset = "0x2E4CCC0", Length = "0x40")]
	[Token(Token = "0x600004C")]
	internal int get_DeferredCallbackCount() { }

	[Address(RVA = "0x2E4D900", Offset = "0x2E4CD00", Length = "0x3C")]
	[Token(Token = "0x600004B")]
	internal int get_DeferredCompleteCallbacksCount() { }

	[Address(RVA = "0x2E4D940", Offset = "0x2E4CD40", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000042")]
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[Address(RVA = "0x2E4D990", Offset = "0x2E4CD90", Length = "0x3C")]
	[Token(Token = "0x600004A")]
	internal int get_InstanceOperationCount() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000044")]
	public Func<IResourceLocation, String> get_InternalIdTransformFunc() { }

	[Address(RVA = "0x2E4D9D0", Offset = "0x2E4CDD0", Length = "0x44")]
	[Token(Token = "0x6000049")]
	internal int get_OperationCacheCount() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000051")]
	public IList<IResourceProvider> get_ResourceProviders() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000047")]
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	[Address(RVA = "0x2E4A5D0", Offset = "0x2E499D0", Length = "0xC0")]
	[Token(Token = "0x6000059")]
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	[Address(RVA = "0x2E4A690", Offset = "0x2E49A90", Length = "0xAC")]
	[Token(Token = "0x600005C")]
	internal IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType) { }

	[Address(RVA = "0x2E4A740", Offset = "0x2E49B40", Length = "0x280")]
	[Token(Token = "0x6000058")]
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	[Address(RVA = "0x2E4A9D0", Offset = "0x2E49DD0", Length = "0x53")]
	[Token(Token = "0x6000067")]
	internal bool IsOperationCached(IOperationCacheKey key) { }

	[Address(RVA = "0x2E4AA30", Offset = "0x2E49E30", Length = "0x114")]
	[Token(Token = "0x6000061")]
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	[Address(RVA = "0x2E4AB50", Offset = "0x2E49F50", Length = "0x87")]
	[Token(Token = "0x6000055")]
	private void OnObjectAdded(object obj) { }

	[Address(RVA = "0x2E4ABE0", Offset = "0x2E49FE0", Length = "0x59")]
	[Token(Token = "0x6000056")]
	private void OnObjectRemoved(object obj) { }

	[Address(RVA = "0x2E4AC40", Offset = "0x2E4A040", Length = "0x17A")]
	[Token(Token = "0x6000063")]
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	[Address(RVA = "0x2E4ADC0", Offset = "0x2E4A1C0", Length = "0x8C")]
	[Token(Token = "0x6000062")]
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	[Address(RVA = "0x2E4AE50", Offset = "0x2E4A250", Length = "0x302")]
	[Token(Token = "0x600007F")]
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	[Address(RVA = "0x8EE170", Offset = "0x8ED570", Length = "0xE5")]
	[Token(Token = "0x600005E")]
	public AsyncOperationHandle<TObject> ProvideResource(IResourceLocation location) { }

	[Address(RVA = "0x2E4BA10", Offset = "0x2E4AE10", Length = "0x856")]
	[Token(Token = "0x600005B")]
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType = null, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x2E4B160", Offset = "0x2E4A560", Length = "0x8A6")]
	[Token(Token = "0x6000074")]
	internal AsyncOperationHandle<IList`1<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x8EE260", Offset = "0x8ED660", Length = "0x91")]
	[Token(Token = "0x6000075")]
	public AsyncOperationHandle<IList`1<TObject>> ProvideResources(IList<IResourceLocation> locations, Action<TObject> callback = null) { }

	[Address(RVA = "0x8EE610", Offset = "0x8EDA10", Length = "0x411")]
	[Token(Token = "0x6000076")]
	public AsyncOperationHandle<IList`1<TObject>> ProvideResources(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback = null) { }

	[Address(RVA = "0x2E4C490", Offset = "0x2E4B890", Length = "0x128")]
	[Token(Token = "0x600007B")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4C380", Offset = "0x2E4B780", Length = "0x101")]
	[Token(Token = "0x600007C")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4C270", Offset = "0x2E4B670", Length = "0x104")]
	[Token(Token = "0x600007D")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority) { }

	[Address(RVA = "0x2E4C5C0", Offset = "0x2E4B9C0", Length = "0x142")]
	[Token(Token = "0x6000057")]
	internal void RegisterForCallbacks() { }

	[Address(RVA = "0x2E4C710", Offset = "0x2E4BB10", Length = "0x275")]
	[Token(Token = "0x6000082")]
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = true) { }

	[Address(RVA = "0x2E4CAF0", Offset = "0x2E4BEF0", Length = "0x64")]
	[Token(Token = "0x600006D")]
	public void Release(AsyncOperationHandle handle) { }

	[Address(RVA = "0x2E4C990", Offset = "0x2E4BD90", Length = "0x157")]
	[Token(Token = "0x600007E")]
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	[Address(RVA = "0x2E4CB60", Offset = "0x2E4BF60", Length = "0x98")]
	[Token(Token = "0x6000066")]
	internal bool RemoveOperationFromCache(IOperationCacheKey key) { }

	[Address(RVA = "0x2E4CC00", Offset = "0x2E4C000", Length = "0x13E")]
	[Token(Token = "0x600004E")]
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000050")]
	public void set_Allocator(IAllocationStrategy value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	[Address(RVA = "0x2E4DA20", Offset = "0x2E4CE20", Length = "0x69")]
	[CompilerGenerated]
	[Token(Token = "0x6000043")]
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000045")]
	public void set_InternalIdTransformFunc(Func<IResourceLocation, String> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000048")]
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	[Address(RVA = "0x2E4CD40", Offset = "0x2E4C140", Length = "0x139")]
	[Token(Token = "0x6000060")]
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	[Address(RVA = "0x8EEA30", Offset = "0x8EDE30", Length = "0xC2")]
	[Token(Token = "0x600005F")]
	public AsyncOperationHandle<TObject> StartOperation(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }

	[Address(RVA = "0x2E4CE80", Offset = "0x2E4C280", Length = "0x7D")]
	[Token(Token = "0x6000046")]
	public string TransformInternalId(IResourceLocation location) { }

	[Address(RVA = "0x2E4CF10", Offset = "0x2E4C310", Length = "0x429")]
	[Token(Token = "0x6000083")]
	internal void Update(float unscaledDeltaTime) { }

}

