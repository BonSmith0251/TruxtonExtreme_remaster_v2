namespace UnityEngine.ResourceManagement;

[Token(Token = "0x2000009")]
internal class ChainOperation : AsyncOperationBase<TObject>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private AsyncOperationHandle<TObjectDependency> m_DepOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000010")]
	private AsyncOperationHandle<TObject> m_WrappedOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	private DownloadStatus m_depStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000012")]
	private DownloadStatus m_wrapStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000013")]
	private Func<AsyncOperationHandle`1<TObjectDependency>, AsyncOperationHandle`1<TObject>> m_Callback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000014")]
	private Action<AsyncOperationHandle`1<TObject>> m_CachedOnWrappedCompleted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000015")]
	private bool m_ReleaseDependenciesOnFailure; //Field offset: 0x0

	[Token(Token = "0x17000005")]
	protected virtual string DebugName
	{
		[Address(RVA = "0x16CDFD0", Offset = "0x16CD3D0", Length = "0x1DB")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 475
	}

	[Token(Token = "0x17000006")]
	protected virtual float Progress
	{
		[Address(RVA = "0x16CE570", Offset = "0x16CD970", Length = "0x18D")]
		[Token(Token = "0x6000034")]
		 get { } //Length: 397
	}

	[Address(RVA = "0x16CDAB0", Offset = "0x16CCEB0", Length = "0x9E")]
	[Token(Token = "0x6000029")]
	public ChainOperation`2() { }

	[Address(RVA = "0x16CB320", Offset = "0x16CA720", Length = "0x98")]
	[Token(Token = "0x6000030")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x16CB640", Offset = "0x16CAA40", Length = "0xC4")]
	[Token(Token = "0x600002E")]
	protected virtual void Execute() { }

	[Address(RVA = "0x16CDFD0", Offset = "0x16CD3D0", Length = "0x1DB")]
	[Token(Token = "0x600002A")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0x16CE570", Offset = "0x16CD970", Length = "0x18D")]
	[Token(Token = "0x6000034")]
	protected virtual float get_Progress() { }

	[Address(RVA = "0x16CB9D0", Offset = "0x16CADD0", Length = "0x150")]
	[Token(Token = "0x600002B")]
	public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x16CC200", Offset = "0x16CB600", Length = "0x9C")]
	[Token(Token = "0x6000032")]
	internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x16CC360", Offset = "0x16CB760", Length = "0xB2")]
	[Token(Token = "0x600002C")]
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle`1<TObjectDependency>, AsyncOperationHandle`1<TObject>> callback, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x16CC7C0", Offset = "0x16CBBC0", Length = "0x13A")]
	[Token(Token = "0x600002D")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x16CCD40", Offset = "0x16CC140", Length = "0x145")]
	[Token(Token = "0x600002F")]
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }

	[Address(RVA = "0x16CD820", Offset = "0x16CCC20", Length = "0x119")]
	[Token(Token = "0x6000033")]
	private void RefreshDownloadStatus(HashSet<Object> visited = null) { }

	[Address(RVA = "0x16CD9A0", Offset = "0x16CCDA0", Length = "0x58")]
	[Token(Token = "0x6000031")]
	internal virtual void ReleaseDependencies() { }

}

