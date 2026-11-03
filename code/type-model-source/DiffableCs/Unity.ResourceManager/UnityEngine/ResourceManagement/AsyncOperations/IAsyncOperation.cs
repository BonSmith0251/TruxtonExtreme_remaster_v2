namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200007B")]
internal interface IAsyncOperation
{

	[Token(Token = "0x14000005")]
	public event Action<AsyncOperationHandle> CompletedTypeless
	{
		[CompilerGenerated]
		[Token(Token = "0x60002BC")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x60002BD")]
		 remove { } //Length: 0
	}

	[Token(Token = "0x14000006")]
	public event Action<AsyncOperationHandle> Destroyed
	{
		[CompilerGenerated]
		[Token(Token = "0x60002BE")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x60002BF")]
		 remove { } //Length: 0
	}

	[Token(Token = "0x17000084")]
	public string DebugName
	{
		[Token(Token = "0x60002B0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008D")]
	public AsyncOperationHandle Handle
	{
		[Token(Token = "0x60002C3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000089")]
	public bool IsDone
	{
		[Token(Token = "0x60002B8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008B")]
	public bool IsRunning
	{
		[Token(Token = "0x60002BB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008A")]
	public Action<IAsyncOperation> OnDestroy
	{
		[Token(Token = "0x60002B9")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000088")]
	public Exception OperationException
	{
		[Token(Token = "0x60002B7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000086")]
	public float PercentComplete
	{
		[Token(Token = "0x60002B4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000085")]
	public int ReferenceCount
	{
		[Token(Token = "0x60002B3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000082")]
	public Type ResultType
	{
		[Token(Token = "0x60002AE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000087")]
	public AsyncOperationStatus Status
	{
		[Token(Token = "0x60002B6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008C")]
	public Task<Object> Task
	{
		[Token(Token = "0x60002C1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000083")]
	public int Version
	{
		[Token(Token = "0x60002AF")]
		 get { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x60002BC")]
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[CompilerGenerated]
	[Token(Token = "0x60002BE")]
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	[Token(Token = "0x60002B1")]
	public void DecrementReferenceCount() { }

	[Token(Token = "0x60002B0")]
	public string get_DebugName() { }

	[Token(Token = "0x60002C3")]
	public AsyncOperationHandle get_Handle() { }

	[Token(Token = "0x60002B8")]
	public bool get_IsDone() { }

	[Token(Token = "0x60002BB")]
	public bool get_IsRunning() { }

	[Token(Token = "0x60002B7")]
	public Exception get_OperationException() { }

	[Token(Token = "0x60002B4")]
	public float get_PercentComplete() { }

	[Token(Token = "0x60002B3")]
	public int get_ReferenceCount() { }

	[Token(Token = "0x60002AE")]
	public Type get_ResultType() { }

	[Token(Token = "0x60002B6")]
	public AsyncOperationStatus get_Status() { }

	[Token(Token = "0x60002C1")]
	public Task<Object> get_Task() { }

	[Token(Token = "0x60002AF")]
	public int get_Version() { }

	[Token(Token = "0x60002BA")]
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Token(Token = "0x60002B5")]
	public DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Token(Token = "0x60002AD")]
	public object GetResultAsObject() { }

	[Token(Token = "0x60002B2")]
	public void IncrementReferenceCount() { }

	[Token(Token = "0x60002C0")]
	public void InvokeCompletionEvent() { }

	[CompilerGenerated]
	[Token(Token = "0x60002BD")]
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[CompilerGenerated]
	[Token(Token = "0x60002BF")]
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	[Token(Token = "0x60002B9")]
	public void set_OnDestroy(Action<IAsyncOperation> value) { }

	[Token(Token = "0x60002C2")]
	public void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<Single> updateCallbacks) { }

	[Token(Token = "0x60002C4")]
	public void WaitForCompletion() { }

}

