namespace UnityEngine.ResourceManagement.AsyncOperations;

[Preserve]
[Token(Token = "0x2000089")]
internal class ProviderOperation : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable
{
	[Token(Token = "0x400018E")]
	private const float k_OperationWaitingToCompletePercentComplete = 0.99; //Field offset: 0x0
	[Token(Token = "0x400018F")]
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000181")]
	private bool m_ReleaseDependenciesOnFailure; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000182")]
	private Func<Single> m_GetProgressCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000183")]
	private Func<DownloadStatus> m_GetDownloadProgressCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000184")]
	private Func<Boolean> m_WaitForCompletionCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000185")]
	private bool m_ProviderCompletedCalled; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000186")]
	private DownloadStatus m_DownloadStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000187")]
	private IResourceProvider m_Provider; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000188")]
	internal AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000189")]
	private IResourceLocation m_Location; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018A")]
	private int m_ProvideHandleVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018B")]
	private bool m_NeedsRelease; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018C")]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018D")]
	private ResourceManager m_ResourceManager; //Field offset: 0x0

	[Token(Token = "0x170000CC")]
	protected virtual string DebugName
	{
		[Address(RVA = "0xE7D4E0", Offset = "0xE7C8E0", Length = "0x111")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 273
	}

	[Token(Token = "0x170000CE")]
	public override int DependencyCount
	{
		[Address(RVA = "0xE7D600", Offset = "0xE7CA00", Length = "0xA7")]
		[Token(Token = "0x600038F")]
		 get { } //Length: 167
	}

	[Token(Token = "0x170000CB")]
	public override IResourceLocation Location
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x6000384")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CF")]
	protected virtual float Progress
	{
		[Address(RVA = "0xE7DC00", Offset = "0xE7D000", Length = "0x2DA")]
		[Token(Token = "0x6000393")]
		 get { } //Length: 730
	}

	[Token(Token = "0x170000CA")]
	public override int ProvideHandleVersion
	{
		[Address(RVA = "0xE7DEE0", Offset = "0xE7D2E0", Length = "0x7")]
		[Token(Token = "0x6000383")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000CD")]
	public override Type RequestedType
	{
		[Address(RVA = "0xE7DF20", Offset = "0xE7D320", Length = "0x39")]
		[Token(Token = "0x600038E")]
		 get { } //Length: 57
	}

	[Token(Token = "0x170000C9")]
	private override IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000381")]
		private get { } //Length: 8
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000382")]
		private set { } //Length: 19
	}

	[Address(RVA = "0xE7D360", Offset = "0xE7C760", Length = "0x1B")]
	[Token(Token = "0x6000389")]
	public ProviderOperation`1() { }

	[Address(RVA = "0xE7A880", Offset = "0xE79C80", Length = "0xD3")]
	[Token(Token = "0x6000398")]
	protected virtual void Destroy() { }

	[Address(RVA = "0xE7A960", Offset = "0xE79D60", Length = "0x278")]
	[Token(Token = "0x6000394")]
	protected virtual void Execute() { }

	[Address(RVA = "0xE7D4E0", Offset = "0xE7C8E0", Length = "0x111")]
	[Token(Token = "0x600038C")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0xE7D600", Offset = "0xE7CA00", Length = "0xA7")]
	[Token(Token = "0x600038F")]
	public override int get_DependencyCount() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x6000384")]
	public override IResourceLocation get_Location() { }

	[Address(RVA = "0xE7DC00", Offset = "0xE7D000", Length = "0x2DA")]
	[Token(Token = "0x6000393")]
	protected virtual float get_Progress() { }

	[Address(RVA = "0xE7DEE0", Offset = "0xE7D2E0", Length = "0x7")]
	[Token(Token = "0x6000383")]
	public override int get_ProvideHandleVersion() { }

	[Address(RVA = "0xE7DF20", Offset = "0xE7D320", Length = "0x39")]
	[Token(Token = "0x600038E")]
	public override Type get_RequestedType() { }

	[Address(RVA = "0xE7B060", Offset = "0xE7A460", Length = "0x146")]
	[Token(Token = "0x600038A")]
	public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0xE7B1B0", Offset = "0xE7A5B0", Length = "0x30F")]
	[Token(Token = "0x600038D")]
	public override void GetDependencies(IList<Object> dstList) { }

	[Address(RVA = "0x6A0AC0", Offset = "0x69FEC0", Length = "0x181")]
	[Token(Token = "0x6000390")]
	public override TDepObject GetDependency(int index) { }

	[Address(RVA = "0xE7BA30", Offset = "0xE7AE30", Length = "0x173")]
	[Token(Token = "0x6000388")]
	internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0xE7C1F0", Offset = "0xE7B5F0", Length = "0x172")]
	[Token(Token = "0x6000396")]
	public override void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0xE7C370", Offset = "0xE7B770", Length = "0x16B")]
	[Token(Token = "0x6000395")]
	public override void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	[Address(RVA = "0xE7CA70", Offset = "0xE7BE70", Length = "0x147")]
	[Token(Token = "0x6000387")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x6A1640", Offset = "0x6A0A40", Length = "0x44D")]
	[Token(Token = "0x6000392")]
	public override void ProviderCompleted(T result, bool status, Exception e) { }

	[Address(RVA = "0xE7CBC0", Offset = "0xE7BFC0", Length = "0x66")]
	[Token(Token = "0x600038B")]
	internal virtual void ReleaseDependencies() { }

	[Address(RVA = "0xE7CCF0", Offset = "0xE7C0F0", Length = "0x5D")]
	[Token(Token = "0x6000385")]
	public override void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000391")]
	public override void SetProgressCallback(Func<Single> callback) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6000386")]
	public override void SetWaitForCompletionCallback(Func<Boolean> callback) { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000381")]
	private override IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000382")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

	[Address(RVA = "0xE7D200", Offset = "0xE7C600", Length = "0xD6")]
	[Token(Token = "0x6000397")]
	private bool WaitForCompletionHandler() { }

}

