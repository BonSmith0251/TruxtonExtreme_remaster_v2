namespace UnityEngine.ResourceManagement;

[Token(Token = "0x200000A")]
internal class ChainOperationTypelessDepedency : AsyncOperationBase<TObject>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000016")]
	private AsyncOperationHandle m_DepOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000017")]
	private AsyncOperationHandle<TObject> m_WrappedOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000018")]
	private DownloadStatus m_depStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000019")]
	private DownloadStatus m_wrapStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	private Func<AsyncOperationHandle, AsyncOperationHandle`1<TObject>> m_Callback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001B")]
	private Action<AsyncOperationHandle`1<TObject>> m_CachedOnWrappedCompleted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001C")]
	private bool m_ReleaseDependenciesOnFailure; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	protected virtual string DebugName
	{
		[Address(RVA = "0x16CA6A0", Offset = "0x16C9AA0", Length = "0xC5")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 197
	}

	[Token(Token = "0x17000009")]
	protected virtual float Progress
	{
		[Address(RVA = "0x16CB120", Offset = "0x16CA520", Length = "0x16D")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 365
	}

	[Token(Token = "0x17000007")]
	internal AsyncOperationHandle<TObject> WrappedOp
	{
		[Address(RVA = "0x16CB2E0", Offset = "0x16CA6E0", Length = "0x1B")]
		[Token(Token = "0x6000035")]
		internal get { } //Length: 27
	}

	[Address(RVA = "0x16CA560", Offset = "0x16C9960", Length = "0x9E")]
	[Token(Token = "0x6000036")]
	public ChainOperationTypelessDepedency`1() { }

	[Address(RVA = "0x16C7B80", Offset = "0x16C6F80", Length = "0x78")]
	[Token(Token = "0x600003D")]
	protected virtual void Destroy() { }

	[Address(RVA = "0x16C7C00", Offset = "0x16C7000", Length = "0xC4")]
	[Token(Token = "0x600003B")]
	protected virtual void Execute() { }

	[Address(RVA = "0x16CA6A0", Offset = "0x16C9AA0", Length = "0xC5")]
	[Token(Token = "0x6000037")]
	protected virtual string get_DebugName() { }

	[Address(RVA = "0x16CB120", Offset = "0x16CA520", Length = "0x16D")]
	[Token(Token = "0x6000041")]
	protected virtual float get_Progress() { }

	[Address(RVA = "0x16CB2E0", Offset = "0x16CA6E0", Length = "0x1B")]
	[Token(Token = "0x6000035")]
	internal AsyncOperationHandle<TObject> get_WrappedOp() { }

	[Address(RVA = "0x16C8190", Offset = "0x16C7590", Length = "0xEA")]
	[Token(Token = "0x6000038")]
	public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x16C8690", Offset = "0x16C7A90", Length = "0x99")]
	[Token(Token = "0x600003F")]
	internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x16C8BC0", Offset = "0x16C7FC0", Length = "0x9C")]
	[Token(Token = "0x6000039")]
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle`1<TObject>> callback, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x16C9080", Offset = "0x16C8480", Length = "0x111")]
	[Token(Token = "0x600003A")]
	protected virtual bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x16C9A80", Offset = "0x16C8E80", Length = "0x145")]
	[Token(Token = "0x600003C")]
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }

	[Address(RVA = "0x16CA100", Offset = "0x16C9500", Length = "0xF7")]
	[Token(Token = "0x6000040")]
	private void RefreshDownloadStatus(HashSet<Object> visited = null) { }

	[Address(RVA = "0x16CA240", Offset = "0x16C9640", Length = "0x34")]
	[Token(Token = "0x600003E")]
	internal virtual void ReleaseDependencies() { }

}

