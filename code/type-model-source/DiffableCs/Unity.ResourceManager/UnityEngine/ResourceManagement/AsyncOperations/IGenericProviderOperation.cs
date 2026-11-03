namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000088")]
internal interface IGenericProviderOperation
{

	[Token(Token = "0x170000C7")]
	public int DependencyCount
	{
		[Token(Token = "0x6000379")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C6")]
	public IResourceLocation Location
	{
		[Token(Token = "0x6000378")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C5")]
	public int ProvideHandleVersion
	{
		[Token(Token = "0x6000377")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C8")]
	public Type RequestedType
	{
		[Token(Token = "0x600037E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000379")]
	public int get_DependencyCount() { }

	[Token(Token = "0x6000378")]
	public IResourceLocation get_Location() { }

	[Token(Token = "0x6000377")]
	public int get_ProvideHandleVersion() { }

	[Token(Token = "0x600037E")]
	public Type get_RequestedType() { }

	[Token(Token = "0x600037A")]
	public void GetDependencies(IList<Object> dstList) { }

	[Token(Token = "0x600037B")]
	public TDepObject GetDependency(int index) { }

	[Token(Token = "0x6000375")]
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	[Token(Token = "0x6000376")]
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }

	[Token(Token = "0x600037D")]
	public void ProviderCompleted(T result, bool status, Exception e) { }

	[Token(Token = "0x600037F")]
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }

	[Token(Token = "0x600037C")]
	public void SetProgressCallback(Func<Single> callback) { }

	[Token(Token = "0x6000380")]
	public void SetWaitForCompletionCallback(Func<Boolean> callback) { }

}

