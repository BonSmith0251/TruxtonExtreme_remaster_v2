namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200007F")]
public struct AsyncOperationHandle : IEnumerator, IEquatable<AsyncOperationHandle`1<TObject>>
{
	[CompilerGenerated]
	[Token(Token = "0x2000080")]
	private sealed class <>c
	{
		[Token(Token = "0x4000165")]
		public static readonly <>c<TObject> <>9; //Field offset: 0x0
		[Token(Token = "0x4000166")]
		public static Action<AsyncOperationHandle`1<TObject>> <>9__20_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000336")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000337")]
		public <>c() { }

		[Address(RVA = "0xA356D0", Offset = "0xA34AD0", Length = "0x20")]
		[Token(Token = "0x6000338")]
		internal void <ReleaseHandleOnCompletion>b__20_0(AsyncOperationHandle<TObject> op) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000162")]
	internal AsyncOperationBase<TObject> m_InternalOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000163")]
	private int m_Version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000164")]
	private string m_LocationName; //Field offset: 0x0

	[Token(Token = "0x1400000D")]
	public event Action<AsyncOperationHandle`1<TObject>> Completed
	{
		[Address(RVA = "0x1166230", Offset = "0x1165630", Length = "0x87")]
		[Token(Token = "0x600031D")]
		 add { } //Length: 135
		[Address(RVA = "0x1168670", Offset = "0x1167A70", Length = "0xA0")]
		[Token(Token = "0x600031E")]
		 remove { } //Length: 160
	}

	[Token(Token = "0x1400000E")]
	public event Action<AsyncOperationHandle> CompletedTypeless
	{
		[Address(RVA = "0x1165FA0", Offset = "0x11653A0", Length = "0x8A")]
		[Token(Token = "0x6000320")]
		 add { } //Length: 138
		[Address(RVA = "0x1168390", Offset = "0x1167790", Length = "0x8A")]
		[Token(Token = "0x6000321")]
		 remove { } //Length: 138
	}

	[Token(Token = "0x1400000F")]
	public event Action<AsyncOperationHandle> Destroyed
	{
		[Address(RVA = "0x11665E0", Offset = "0x11659E0", Length = "0x8A")]
		[Token(Token = "0x6000324")]
		 add { } //Length: 138
		[Address(RVA = "0x1168960", Offset = "0x1167D60", Length = "0xA3")]
		[Token(Token = "0x6000325")]
		 remove { } //Length: 163
	}

	[Token(Token = "0x170000AB")]
	public string DebugName
	{
		[Address(RVA = "0x11667E0", Offset = "0x1165BE0", Length = "0xEE")]
		[Token(Token = "0x6000322")]
		 get { } //Length: 238
	}

	[Token(Token = "0x170000AC")]
	internal AsyncOperationBase<TObject> InternalOp
	{
		[Address(RVA = "0x1166CC0", Offset = "0x11660C0", Length = "0x87")]
		[Token(Token = "0x6000329")]
		internal get { } //Length: 135
	}

	[Token(Token = "0x170000AD")]
	public bool IsDone
	{
		[Address(RVA = "0x11670C0", Offset = "0x11664C0", Length = "0xD0")]
		[Token(Token = "0x600032A")]
		 get { } //Length: 208
	}

	[Token(Token = "0x170000AA")]
	internal string LocationName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000312")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000313")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170000AE")]
	public Exception OperationException
	{
		[Address(RVA = "0x1167280", Offset = "0x1166680", Length = "0x66")]
		[Token(Token = "0x600032C")]
		 get { } //Length: 102
	}

	[Token(Token = "0x170000AF")]
	public float PercentComplete
	{
		[Address(RVA = "0x1167600", Offset = "0x1166A00", Length = "0x7A")]
		[Token(Token = "0x600032D")]
		 get { } //Length: 122
	}

	[Token(Token = "0x170000B0")]
	internal int ReferenceCount
	{
		[Address(RVA = "0x11676F0", Offset = "0x1166AF0", Length = "0x65")]
		[Token(Token = "0x600032E")]
		internal get { } //Length: 101
	}

	[Token(Token = "0x170000B1")]
	public TObject Result
	{
		[Address(RVA = "0x1167A60", Offset = "0x1166E60", Length = "0x66")]
		[Token(Token = "0x6000330")]
		 get { } //Length: 102
	}

	[Token(Token = "0x170000B2")]
	public AsyncOperationStatus Status
	{
		[Address(RVA = "0x1167830", Offset = "0x1166C30", Length = "0x65")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 101
	}

	[Token(Token = "0x170000B4")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x1163C60", Offset = "0x1163060", Length = "0xC4")]
		[Token(Token = "0x6000333")]
		private get { } //Length: 196
	}

	[Token(Token = "0x170000B3")]
	public Task<TObject> Task
	{
		[Address(RVA = "0x11681F0", Offset = "0x11675F0", Length = "0x155")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 341
	}

	[Token(Token = "0x170000A9")]
	internal int Version
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000311")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x1165880", Offset = "0x1164C80", Length = "0x142")]
	[Token(Token = "0x600031B")]
	internal AsyncOperationHandle`1(IAsyncOperation op, int version, string locationName) { }

	[Address(RVA = "0x1164CE0", Offset = "0x11640E0", Length = "0x63")]
	[Token(Token = "0x6000315")]
	internal AsyncOperationHandle`1(AsyncOperationBase<TObject> op) { }

	[Address(RVA = "0x1165520", Offset = "0x1164920", Length = "0x17B")]
	[Token(Token = "0x600031A")]
	internal AsyncOperationHandle`1(IAsyncOperation op, string locationName) { }

	[Address(RVA = "0x1164DF0", Offset = "0x11641F0", Length = "0x163")]
	[Token(Token = "0x6000318")]
	internal AsyncOperationHandle`1(IAsyncOperation op) { }

	[Address(RVA = "0x11650E0", Offset = "0x11644E0", Length = "0x132")]
	[Token(Token = "0x6000319")]
	internal AsyncOperationHandle`1(IAsyncOperation op, int version) { }

	[Address(RVA = "0x1161A30", Offset = "0x1160E30", Length = "0xA3")]
	[Token(Token = "0x600031C")]
	internal AsyncOperationHandle<TObject> Acquire() { }

	[Address(RVA = "0x1166230", Offset = "0x1165630", Length = "0x87")]
	[Token(Token = "0x600031D")]
	public void add_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	[Address(RVA = "0x1165FA0", Offset = "0x11653A0", Length = "0x8A")]
	[Token(Token = "0x6000320")]
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x11665E0", Offset = "0x11659E0", Length = "0x8A")]
	[Token(Token = "0x6000324")]
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x1161AE0", Offset = "0x1160EE0", Length = "0x21")]
	[Token(Token = "0x6000326")]
	public override bool Equals(AsyncOperationHandle<TObject> other) { }

	[Address(RVA = "0x11667E0", Offset = "0x1165BE0", Length = "0xEE")]
	[Token(Token = "0x6000322")]
	public string get_DebugName() { }

	[Address(RVA = "0x1166CC0", Offset = "0x11660C0", Length = "0x87")]
	[Token(Token = "0x6000329")]
	internal AsyncOperationBase<TObject> get_InternalOp() { }

	[Address(RVA = "0x11670C0", Offset = "0x11664C0", Length = "0xD0")]
	[Token(Token = "0x600032A")]
	public bool get_IsDone() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000312")]
	internal string get_LocationName() { }

	[Address(RVA = "0x1167280", Offset = "0x1166680", Length = "0x66")]
	[Token(Token = "0x600032C")]
	public Exception get_OperationException() { }

	[Address(RVA = "0x1167600", Offset = "0x1166A00", Length = "0x7A")]
	[Token(Token = "0x600032D")]
	public float get_PercentComplete() { }

	[Address(RVA = "0x11676F0", Offset = "0x1166AF0", Length = "0x65")]
	[Token(Token = "0x600032E")]
	internal int get_ReferenceCount() { }

	[Address(RVA = "0x1167A60", Offset = "0x1166E60", Length = "0x66")]
	[Token(Token = "0x6000330")]
	public TObject get_Result() { }

	[Address(RVA = "0x1167830", Offset = "0x1166C30", Length = "0x65")]
	[Token(Token = "0x6000331")]
	public AsyncOperationStatus get_Status() { }

	[Address(RVA = "0x11681F0", Offset = "0x11675F0", Length = "0x155")]
	[Token(Token = "0x6000332")]
	public Task<TObject> get_Task() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000311")]
	internal int get_Version() { }

	[Address(RVA = "0x1161B10", Offset = "0x1160F10", Length = "0x66")]
	[Token(Token = "0x6000323")]
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x1161D80", Offset = "0x1161180", Length = "0xBB")]
	[Token(Token = "0x6000316")]
	public DownloadStatus GetDownloadStatus() { }

	[Address(RVA = "0x1162080", Offset = "0x1161480", Length = "0x39")]
	[Token(Token = "0x6000327")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1162440", Offset = "0x1161840", Length = "0x182")]
	[Token(Token = "0x6000317")]
	internal DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x1162990", Offset = "0x1161D90", Length = "0x45")]
	[Token(Token = "0x600032B")]
	public bool IsValid() { }

	[Address(RVA = "0x1168350", Offset = "0x1167750", Length = "0x33")]
	[Token(Token = "0x6000314")]
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }

	[Address(RVA = "0x1163470", Offset = "0x1162870", Length = "0x95")]
	[Token(Token = "0x600032F")]
	public void Release() { }

	[Address(RVA = "0x1162CB0", Offset = "0x11620B0", Length = "0x276")]
	[Token(Token = "0x600031F")]
	public void ReleaseHandleOnCompletion() { }

	[Address(RVA = "0x1168670", Offset = "0x1167A70", Length = "0xA0")]
	[Token(Token = "0x600031E")]
	public void remove_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	[Address(RVA = "0x1168390", Offset = "0x1167790", Length = "0x8A")]
	[Token(Token = "0x6000321")]
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x1168960", Offset = "0x1167D60", Length = "0xA3")]
	[Token(Token = "0x6000325")]
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000313")]
	internal void set_LocationName(string value) { }

	[Address(RVA = "0x1163C60", Offset = "0x1163060", Length = "0xC4")]
	[Token(Token = "0x6000333")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x11637E0", Offset = "0x1162BE0", Length = "0x39")]
	[Token(Token = "0x6000334")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000335")]
	private override void System.Collections.IEnumerator.Reset() { }

	[Address(RVA = "0x11649F0", Offset = "0x1163DF0", Length = "0x2EC")]
	[Token(Token = "0x6000328")]
	public TObject WaitForCompletion() { }

}

