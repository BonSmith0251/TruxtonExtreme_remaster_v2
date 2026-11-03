namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000086")]
internal class GroupOperation : AsyncOperationBase<IList`1<AsyncOperationHandle>>, ICachable
{
	[Flags]
	[Token(Token = "0x2000087")]
	internal enum GroupOperationSettings : int
	{
		None = 0,
		ReleaseDependenciesOnFailure = 1,
		AllowFailedDependencies = 2,
	}

	[Token(Token = "0x4000179")]
	private const int k_MaxDisplayedLocationLength = 45; //Field offset: 0x0
	[Token(Token = "0x400017A")]
	private const int k_MaxDebugNameLength = 2000; //Field offset: 0x0
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000175")]
	private Action<AsyncOperationHandle> m_InternalOnComplete; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000176")]
	private int m_LoadedCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000177")]
	private GroupOperationSettings m_Settings; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000178")]
	private string debugName; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400017B")]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400017C")]
	private HashSet<String> m_CachedDependencyLocations; //Field offset: 0xB8

	[Token(Token = "0x170000C3")]
	protected virtual string DebugName
	{
		[Address(RVA = "0x2E40440", Offset = "0x2E3F840", Length = "0x2E5")]
		[Token(Token = "0x600036D")]
		 get { } //Length: 741
	}

	[Token(Token = "0x170000C4")]
	protected virtual float Progress
	{
		[Address(RVA = "0x2E40730", Offset = "0x2E3FB30", Length = "0x33B")]
		[Token(Token = "0x6000371")]
		 get { } //Length: 827
	}

	[Token(Token = "0x170000C2")]
	private override IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000366")]
		private get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000367")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x2E40300", Offset = "0x2E3F700", Length = "0x132")]
	[Token(Token = "0x6000364")]
	public GroupOperation() { }

	[Address(RVA = "0x2E3F0A0", Offset = "0x2E3E4A0", Length = "0x2C9")]
	[Token(Token = "0x600036F")]
	private void CompleteIfDependenciesComplete() { }

	[Address(RVA = "0x2E3F370", Offset = "0x2E3E770", Length = "0x1B6")]
	[Token(Token = "0x600036C")]
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x2E3F530", Offset = "0x2E3E930", Length = "0x3A")]
	[Token(Token = "0x6000370")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x2E3F570", Offset = "0x2E3E970", Length = "0x36E")]
	[Token(Token = "0x600036E")]
	protected virtual void Execute() { }

	[Address(RVA = "0x2E40440", Offset = "0x2E3F840", Length = "0x2E5")]
	[Token(Token = "0x600036D")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0x2E40730", Offset = "0x2E3FB30", Length = "0x33B")]
	[Token(Token = "0x6000371")]
	protected virtual float get_Progress() { }

	[Address(RVA = "0x2E3F8E0", Offset = "0x2E3ECE0", Length = "0x5F")]
	[Token(Token = "0x6000369")]
	public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x2E3F940", Offset = "0x2E3ED40", Length = "0x39")]
	[Token(Token = "0x6000368")]
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	[Address(RVA = "0x2E3F980", Offset = "0x2E3ED80", Length = "0x2E4")]
	[Token(Token = "0x600036B")]
	internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x2E3FC70", Offset = "0x2E3F070", Length = "0x9D")]
	[Token(Token = "0x6000373")]
	public void Init(List<AsyncOperationHandle> operations, GroupOperationSettings settings) { }

	[Address(RVA = "0x2E3FD10", Offset = "0x2E3F110", Length = "0xBE")]
	[Token(Token = "0x6000372")]
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = true, bool allowFailedDependencies = false) { }

	[Address(RVA = "0x2E3FDD0", Offset = "0x2E3F1D0", Length = "0x24A")]
	[Token(Token = "0x6000365")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x2E40020", Offset = "0x2E3F420", Length = "0xD")]
	[Token(Token = "0x6000374")]
	private void OnOperationCompleted(AsyncOperationHandle op) { }

	[Address(RVA = "0x2E40030", Offset = "0x2E3F430", Length = "0x2C5")]
	[Token(Token = "0x600036A")]
	internal virtual void ReleaseDependencies() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000366")]
	private override IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000367")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

}

