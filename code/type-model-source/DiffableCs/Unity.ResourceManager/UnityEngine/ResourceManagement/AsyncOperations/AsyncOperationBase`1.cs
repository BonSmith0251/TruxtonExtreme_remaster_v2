namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200007C")]
public abstract class AsyncOperationBase : IAsyncOperation
{
	[CompilerGenerated]
	[Token(Token = "0x200007D")]
	private sealed class <>c__DisplayClass60_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000160")]
		public Action<AsyncOperationHandle> value; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600030D")]
		public <>c__DisplayClass60_0() { }

		[Address(RVA = "0xA74880", Offset = "0xA73C80", Length = "0x74")]
		[Token(Token = "0x600030E")]
		internal void <add_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007E")]
	private sealed class <>c__DisplayClass61_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000161")]
		public Action<AsyncOperationHandle> value; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600030F")]
		public <>c__DisplayClass61_0() { }

		[Address(RVA = "0xA74880", Offset = "0xA73C80", Length = "0x74")]
		[Token(Token = "0x6000310")]
		internal void <remove_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014E")]
	private TObject <Result>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015D")]
	private bool m_InDeferredCallbackQueue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015C")]
	private TaskCompletionSource<Object> m_taskCompletionSourceTypeless; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015B")]
	private TaskCompletionSource<TObject> m_taskCompletionSource; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015A")]
	private bool <IsRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000159")]
	private Action Executed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	protected private bool HasExecuted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000157")]
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000156")]
	private Action<IAsyncOperation> m_OnDestroyAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000155")]
	private DelegateList<AsyncOperationHandle`1<TObject>> m_CompletedActionT; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000154")]
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000153")]
	internal int m_Version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000152")]
	internal ResourceManager m_RM; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000151")]
	internal Exception m_Error; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000150")]
	internal AsyncOperationStatus m_Status; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014F")]
	private int m_referenceCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015E")]
	private DelegateList<Single> m_UpdateCallbacks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015F")]
	private Action<Single> m_UpdateCallback; //Field offset: 0x0

	[Token(Token = "0x14000008")]
	internal event Action<AsyncOperationHandle`1<TObject>> Completed
	{
		[Address(RVA = "0x115DE20", Offset = "0x115D220", Length = "0xB1")]
		[Token(Token = "0x60002DF")]
		internal add { } //Length: 177
		[Address(RVA = "0x115F790", Offset = "0x115EB90", Length = "0x21")]
		[Token(Token = "0x60002E0")]
		internal remove { } //Length: 33
	}

	[Token(Token = "0x1400000A")]
	internal event Action<AsyncOperationHandle> CompletedTypeless
	{
		[Address(RVA = "0x115D8F0", Offset = "0x115CCF0", Length = "0x106")]
		[Token(Token = "0x60002E3")]
		internal add { } //Length: 262
		[Address(RVA = "0x115F410", Offset = "0x115E810", Length = "0x11F")]
		[Token(Token = "0x60002E4")]
		internal remove { } //Length: 287
	}

	[Token(Token = "0x14000009")]
	internal event Action<AsyncOperationHandle> Destroyed
	{
		[Address(RVA = "0x115DFA0", Offset = "0x115D3A0", Length = "0x82")]
		[Token(Token = "0x60002E1")]
		internal add { } //Length: 130
		[Address(RVA = "0x115C930", Offset = "0x115BD30", Length = "0x4F")]
		[Token(Token = "0x60002E2")]
		internal remove { } //Length: 79
	}

	[Token(Token = "0x14000007")]
	internal event Action Executed
	{
		[Address(RVA = "0x115E5E0", Offset = "0x115D9E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60002D0")]
		internal add { } //Length: 158
		[Address(RVA = "0x115FAD0", Offset = "0x115EED0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60002D1")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x1400000B")]
	private override event Action<AsyncOperationHandle> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.CompletedTypeless
	{
		[Address(RVA = "0x115BBC0", Offset = "0x115AFC0", Length = "0x17")]
		[Token(Token = "0x60002F5")]
		private add { } //Length: 23
		[Address(RVA = "0x115C7E0", Offset = "0x115BBE0", Length = "0x17")]
		[Token(Token = "0x60002F6")]
		private remove { } //Length: 23
	}

	[Token(Token = "0x1400000C")]
	private override event Action<AsyncOperationHandle> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Destroyed
	{
		[Address(RVA = "0x115BC80", Offset = "0x115B080", Length = "0x17")]
		[Token(Token = "0x60002F7")]
		private add { } //Length: 23
		[Address(RVA = "0x115C930", Offset = "0x115BD30", Length = "0x4F")]
		[Token(Token = "0x60002F8")]
		private remove { } //Length: 79
	}

	[Token(Token = "0x17000092")]
	internal bool CompletedEventHasListeners
	{
		[Address(RVA = "0x115E760", Offset = "0x115DB60", Length = "0x34")]
		[Token(Token = "0x60002CD")]
		internal get { } //Length: 52
	}

	[Token(Token = "0x1700009B")]
	internal object Current
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60002EA")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700008F")]
	protected override string DebugName
	{
		[Address(RVA = "0x115E7A0", Offset = "0x115DBA0", Length = "0x26")]
		[Token(Token = "0x60002C8")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000093")]
	internal bool DestroyedEventHasListeners
	{
		[Address(RVA = "0x115E7D0", Offset = "0x115DBD0", Length = "0x4F")]
		[Token(Token = "0x60002CE")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700009E")]
	internal AsyncOperationHandle<TObject> Handle
	{
		[Address(RVA = "0x115EA10", Offset = "0x115DE10", Length = "0x82")]
		[Token(Token = "0x60002EE")]
		internal get { } //Length: 130
	}

	[Token(Token = "0x1700009C")]
	internal bool IsDone
	{
		[Address(RVA = "0x115BF00", Offset = "0x115B300", Length = "0x11")]
		[Token(Token = "0x60002EB")]
		internal get { } //Length: 17
	}

	[Token(Token = "0x17000096")]
	public internal override bool IsRunning
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002D3")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60002D4")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000094")]
	internal Action<IAsyncOperation> OnDestroy
	{
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60002CF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700009A")]
	internal Exception OperationException
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002E6")]
		internal get { } //Length: 5
		[Address(RVA = "0x115FD00", Offset = "0x115F100", Length = "0x15F")]
		[Token(Token = "0x60002E7")]
		private set { } //Length: 351
	}

	[Token(Token = "0x1700009D")]
	internal float PercentComplete
	{
		[Address(RVA = "0x115EC90", Offset = "0x115E090", Length = "0x35")]
		[Token(Token = "0x60002EC")]
		internal get { } //Length: 53
	}

	[Token(Token = "0x1700008E")]
	protected override float Progress
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60002C7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000095")]
	protected private int ReferenceCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60002D2")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000090")]
	public TObject Result
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002CA")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60002CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000099")]
	internal AsyncOperationStatus Status
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60002E5")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000097")]
	internal Task<TObject> Task
	{
		[Address(RVA = "0x115F1E0", Offset = "0x115E5E0", Length = "0xFE")]
		[Token(Token = "0x60002DB")]
		internal get { } //Length: 254
	}

	[Token(Token = "0x170000A7")]
	private override string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName
	{
		[Address(RVA = "0x115BCA0", Offset = "0x115B0A0", Length = "0x14")]
		[Token(Token = "0x6000301")]
		private get { } //Length: 20
	}

	[Token(Token = "0x170000A5")]
	private override AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle
	{
		[Address(RVA = "0x115BCC0", Offset = "0x115B0C0", Length = "0xDE")]
		[Token(Token = "0x60002FF")]
		private get { } //Length: 222
	}

	[Token(Token = "0x170000A4")]
	private override bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone
	{
		[Address(RVA = "0x115BF00", Offset = "0x115B300", Length = "0x11")]
		[Token(Token = "0x60002FE")]
		private get { } //Length: 17
	}

	[Token(Token = "0x170000A6")]
	private override Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy
	{
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000300")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000A3")]
	private override Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002FD")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000A1")]
	private override float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete
	{
		[Address(RVA = "0x115BFE0", Offset = "0x115B3E0", Length = "0x17")]
		[Token(Token = "0x60002FB")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170000A0")]
	private override int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60002FA")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170000A8")]
	private override Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType
	{
		[Address(RVA = "0x115C020", Offset = "0x115B420", Length = "0x3C")]
		[Token(Token = "0x6000303")]
		private get { } //Length: 60
	}

	[Token(Token = "0x170000A2")]
	private override AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60002FC")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000098")]
	private override Task<Object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task
	{
		[Address(RVA = "0x115C060", Offset = "0x115B460", Length = "0x138")]
		[Token(Token = "0x60002DC")]
		private get { } //Length: 312
	}

	[Token(Token = "0x1700009F")]
	private override int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60002F9")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000091")]
	internal int Version
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60002CC")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x115D490", Offset = "0x115C890", Length = "0xDB")]
	[Token(Token = "0x60002D5")]
	protected AsyncOperationBase`1() { }

	[Address(RVA = "0x115B3B0", Offset = "0x115A7B0", Length = "0x17")]
	[CompilerGenerated]
	[Token(Token = "0x600030C")]
	private void <.ctor>b__38_0(AsyncOperationHandle o) { }

	[Address(RVA = "0x115DE20", Offset = "0x115D220", Length = "0xB1")]
	[Token(Token = "0x60002DF")]
	internal void add_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	[Address(RVA = "0x115D8F0", Offset = "0x115CCF0", Length = "0x106")]
	[Token(Token = "0x60002E3")]
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115DFA0", Offset = "0x115D3A0", Length = "0x82")]
	[Token(Token = "0x60002E1")]
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115E5E0", Offset = "0x115D9E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60002D0")]
	internal void add_Executed(Action value) { }

	[Address(RVA = "0x1156770", Offset = "0x1155B70", Length = "0x27A")]
	[Token(Token = "0x60002F2")]
	public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true) { }

	[Address(RVA = "0x1156D50", Offset = "0x1156150", Length = "0xD2")]
	[Token(Token = "0x60002F1")]
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }

	[Address(RVA = "0x1156F10", Offset = "0x1156310", Length = "0xDD")]
	[Token(Token = "0x60002F0")]
	public void Complete(TObject result, bool success, string errorMsg) { }

	[Address(RVA = "0x1158640", Offset = "0x1157A40", Length = "0x255")]
	[Token(Token = "0x60002DA")]
	protected private void DecrementReferenceCount() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002C6")]
	protected override void Destroy() { }

	[Token(Token = "0x60002C5")]
	protected abstract void Execute() { }

	[Address(RVA = "0x115E760", Offset = "0x115DB60", Length = "0x34")]
	[Token(Token = "0x60002CD")]
	internal bool get_CompletedEventHasListeners() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60002EA")]
	internal object get_Current() { }

	[Address(RVA = "0x115E7A0", Offset = "0x115DBA0", Length = "0x26")]
	[Token(Token = "0x60002C8")]
	protected override string get_DebugName() { }

	[Address(RVA = "0x115E7D0", Offset = "0x115DBD0", Length = "0x4F")]
	[Token(Token = "0x60002CE")]
	internal bool get_DestroyedEventHasListeners() { }

	[Address(RVA = "0x115EA10", Offset = "0x115DE10", Length = "0x82")]
	[Token(Token = "0x60002EE")]
	internal AsyncOperationHandle<TObject> get_Handle() { }

	[Address(RVA = "0x115BF00", Offset = "0x115B300", Length = "0x11")]
	[Token(Token = "0x60002EB")]
	internal bool get_IsDone() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002D3")]
	public override bool get_IsRunning() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60002E6")]
	internal Exception get_OperationException() { }

	[Address(RVA = "0x115EC90", Offset = "0x115E090", Length = "0x35")]
	[Token(Token = "0x60002EC")]
	internal float get_PercentComplete() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60002C7")]
	protected override float get_Progress() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60002D2")]
	protected private int get_ReferenceCount() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002CA")]
	public TObject get_Result() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60002E5")]
	internal AsyncOperationStatus get_Status() { }

	[Address(RVA = "0x115F1E0", Offset = "0x115E5E0", Length = "0xFE")]
	[Token(Token = "0x60002DB")]
	internal Task<TObject> get_Task() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60002CC")]
	internal int get_Version() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002C9")]
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	[Address(RVA = "0x1158EB0", Offset = "0x11582B0", Length = "0x8F")]
	[Token(Token = "0x600030B")]
	internal override DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x1159270", Offset = "0x1158670", Length = "0x7B")]
	[Token(Token = "0x60002D9")]
	protected private void IncrementReferenceCount() { }

	[Address(RVA = "0x11599C0", Offset = "0x1158DC0", Length = "0x18F")]
	[Token(Token = "0x60002ED")]
	internal void InvokeCompletionEvent() { }

	[Address(RVA = "0x1159D80", Offset = "0x1159180", Length = "0xB2")]
	[Token(Token = "0x60002F4")]
	internal void InvokeExecute() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60002D8")]
	protected override bool InvokeWaitForCompletion() { }

	[Address(RVA = "0x115A1C0", Offset = "0x11595C0", Length = "0x11")]
	[Token(Token = "0x60002E8")]
	internal bool MoveNext() { }

	[Address(RVA = "0x115A1E0", Offset = "0x11595E0", Length = "0x38")]
	[Token(Token = "0x60002DE")]
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = true) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000309")]
	internal override void ReleaseDependencies() { }

	[Address(RVA = "0x115F790", Offset = "0x115EB90", Length = "0x21")]
	[Token(Token = "0x60002E0")]
	internal void remove_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	[Address(RVA = "0x115F410", Offset = "0x115E810", Length = "0x11F")]
	[Token(Token = "0x60002E4")]
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115C930", Offset = "0x115BD30", Length = "0x4F")]
	[Token(Token = "0x60002E2")]
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115FAD0", Offset = "0x115EED0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60002D1")]
	internal void remove_Executed(Action value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002E9")]
	internal void Reset() { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60002D4")]
	internal void set_IsRunning(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60002CF")]
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }

	[Address(RVA = "0x115FD00", Offset = "0x115F100", Length = "0x15F")]
	[Token(Token = "0x60002E7")]
	private void set_OperationException(Exception value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60002CB")]
	public void set_Result(TObject value) { }

	[Address(RVA = "0x115A3B0", Offset = "0x11597B0", Length = "0x7B")]
	[Token(Token = "0x60002D6")]
	internal static string ShortenPath(string p, bool keepExtension) { }

	[Address(RVA = "0x115A6C0", Offset = "0x1159AC0", Length = "0xC3")]
	[Token(Token = "0x60002F3")]
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<Single> updateCallbacks) { }

	[Address(RVA = "0x115AF70", Offset = "0x115A370", Length = "0x1EC")]
	[Token(Token = "0x60002DD")]
	public virtual string ToString() { }

	[Address(RVA = "0x115BBC0", Offset = "0x115AFC0", Length = "0x17")]
	[Token(Token = "0x60002F5")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115BC80", Offset = "0x115B080", Length = "0x17")]
	[Token(Token = "0x60002F7")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115B430", Offset = "0x115A830", Length = "0x17")]
	[Token(Token = "0x6000305")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }

	[Address(RVA = "0x115BCA0", Offset = "0x115B0A0", Length = "0x14")]
	[Token(Token = "0x6000301")]
	private override string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }

	[Address(RVA = "0x115BCC0", Offset = "0x115B0C0", Length = "0xDE")]
	[Token(Token = "0x60002FF")]
	private override AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }

	[Address(RVA = "0x115BF00", Offset = "0x115B300", Length = "0x11")]
	[Token(Token = "0x60002FE")]
	private override bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60002FD")]
	private override Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }

	[Address(RVA = "0x115BFE0", Offset = "0x115B3E0", Length = "0x17")]
	[Token(Token = "0x60002FB")]
	private override float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60002FA")]
	private override int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }

	[Address(RVA = "0x115C020", Offset = "0x115B420", Length = "0x3C")]
	[Token(Token = "0x6000303")]
	private override Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60002FC")]
	private override AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }

	[Address(RVA = "0x115C060", Offset = "0x115B460", Length = "0x138")]
	[Token(Token = "0x60002DC")]
	private override Task<Object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60002F9")]
	private override int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }

	[Address(RVA = "0x115B470", Offset = "0x115A870", Length = "0x14")]
	[Token(Token = "0x6000304")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x115B490", Offset = "0x115A890", Length = "0x3A")]
	[Token(Token = "0x600030A")]
	private override DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x115B500", Offset = "0x115A900", Length = "0x2A")]
	[Token(Token = "0x6000302")]
	private override object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }

	[Address(RVA = "0x115B670", Offset = "0x115AA70", Length = "0x17")]
	[Token(Token = "0x6000306")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }

	[Address(RVA = "0x115B6F0", Offset = "0x115AAF0", Length = "0x17")]
	[Token(Token = "0x6000307")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }

	[Address(RVA = "0x115C7E0", Offset = "0x115BBE0", Length = "0x17")]
	[Token(Token = "0x60002F6")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115C930", Offset = "0x115BD30", Length = "0x4F")]
	[Token(Token = "0x60002F8")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000300")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }

	[Address(RVA = "0x115BA80", Offset = "0x115AE80", Length = "0xF1")]
	[Token(Token = "0x6000308")]
	private override void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<Single> updateCallbacks) { }

	[Address(RVA = "0x115CB40", Offset = "0x115BF40", Length = "0x73")]
	[Token(Token = "0x60002EF")]
	private void UpdateCallback(float unscaledDeltaTime) { }

	[Address(RVA = "0x115CC40", Offset = "0x115C040", Length = "0x141")]
	[Token(Token = "0x60002D7")]
	public override void WaitForCompletion() { }

}

