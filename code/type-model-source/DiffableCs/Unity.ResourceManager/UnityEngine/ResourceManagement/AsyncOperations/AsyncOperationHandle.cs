namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000081")]
public struct AsyncOperationHandle : IEnumerator
{
	[CompilerGenerated]
	[Token(Token = "0x2000082")]
	private sealed class <>c
	{
		[Token(Token = "0x400016A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400016B")]
		public static Action<AsyncOperationHandle> <>9__16_0; //Field offset: 0x8

		[Address(RVA = "0x2E508D0", Offset = "0x2E4FCD0", Length = "0x67")]
		[Token(Token = "0x600035B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600035C")]
		public <>c() { }

		[Address(RVA = "0x2E4CAF0", Offset = "0x2E4BEF0", Length = "0x64")]
		[Token(Token = "0x600035D")]
		internal void <ReleaseHandleOnCompletion>b__16_0(AsyncOperationHandle op) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000167")]
	internal IAsyncOperation m_InternalOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000168")]
	private int m_Version; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000169")]
	private string m_LocationName; //Field offset: 0x10

	[Token(Token = "0x14000010")]
	public event Action<AsyncOperationHandle> Completed
	{
		[Address(RVA = "0x2E3B420", Offset = "0x2E3A820", Length = "0x61")]
		[Token(Token = "0x6000341")]
		 add { } //Length: 97
		[Address(RVA = "0x2E3BA20", Offset = "0x2E3AE20", Length = "0x61")]
		[Token(Token = "0x6000342")]
		 remove { } //Length: 97
	}

	[Token(Token = "0x14000011")]
	public event Action<AsyncOperationHandle> Destroyed
	{
		[Address(RVA = "0x2E3B490", Offset = "0x2E3A890", Length = "0x61")]
		[Token(Token = "0x6000347")]
		 add { } //Length: 97
		[Address(RVA = "0x2E3BA90", Offset = "0x2E3AE90", Length = "0x61")]
		[Token(Token = "0x6000348")]
		 remove { } //Length: 97
	}

	[Token(Token = "0x170000B7")]
	public string DebugName
	{
		[Address(RVA = "0x2E3B500", Offset = "0x2E3A900", Length = "0xA6")]
		[Token(Token = "0x6000346")]
		 get { } //Length: 166
	}

	[Token(Token = "0x170000B8")]
	private IAsyncOperation InternalOp
	{
		[Address(RVA = "0x2E3B5B0", Offset = "0x2E3A9B0", Length = "0x95")]
		[Token(Token = "0x600034B")]
		private get { } //Length: 149
	}

	[Token(Token = "0x170000B9")]
	public bool IsDone
	{
		[Address(RVA = "0x2E3B650", Offset = "0x2E3AA50", Length = "0x95")]
		[Token(Token = "0x600034C")]
		 get { } //Length: 149
	}

	[Token(Token = "0x170000B6")]
	internal string LocationName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600033A")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600033B")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170000BA")]
	public Exception OperationException
	{
		[Address(RVA = "0x2E3B6F0", Offset = "0x2E3AAF0", Length = "0xCB")]
		[Token(Token = "0x600034E")]
		 get { } //Length: 203
	}

	[Token(Token = "0x170000BB")]
	public float PercentComplete
	{
		[Address(RVA = "0x2E3B7C0", Offset = "0x2E3ABC0", Length = "0xCB")]
		[Token(Token = "0x600034F")]
		 get { } //Length: 203
	}

	[Token(Token = "0x170000BC")]
	internal int ReferenceCount
	{
		[Address(RVA = "0x2E3B890", Offset = "0x2E3AC90", Length = "0x52")]
		[Token(Token = "0x6000352")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x170000BD")]
	public object Result
	{
		[Address(RVA = "0x2E3B140", Offset = "0x2E3A540", Length = "0x4F")]
		[Token(Token = "0x6000354")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000BE")]
	public AsyncOperationStatus Status
	{
		[Address(RVA = "0x2E3B8F0", Offset = "0x2E3ACF0", Length = "0x52")]
		[Token(Token = "0x6000355")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000C0")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2E3B140", Offset = "0x2E3A540", Length = "0x4F")]
		[Token(Token = "0x6000357")]
		private get { } //Length: 79
	}

	[Token(Token = "0x170000BF")]
	public Task<Object> Task
	{
		[Address(RVA = "0x2E3B950", Offset = "0x2E3AD50", Length = "0xCB")]
		[Token(Token = "0x6000356")]
		 get { } //Length: 203
	}

	[Token(Token = "0x170000B5")]
	internal int Version
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000339")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x2E3B310", Offset = "0x2E3A710", Length = "0x77")]
	[Token(Token = "0x600033C")]
	internal AsyncOperationHandle(IAsyncOperation op) { }

	[Address(RVA = "0x2E3B2D0", Offset = "0x2E3A6D0", Length = "0x38")]
	[Token(Token = "0x600033D")]
	internal AsyncOperationHandle(IAsyncOperation op, int version) { }

	[Address(RVA = "0x2E3B390", Offset = "0x2E3A790", Length = "0x81")]
	[Token(Token = "0x600033E")]
	internal AsyncOperationHandle(IAsyncOperation op, string locationName) { }

	[Address(RVA = "0xF52C10", Offset = "0xF52010", Length = "0x42")]
	[Token(Token = "0x600033F")]
	internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName) { }

	[Address(RVA = "0x2E3AB80", Offset = "0x2E39F80", Length = "0x72")]
	[Token(Token = "0x6000340")]
	internal AsyncOperationHandle Acquire() { }

	[Address(RVA = "0x2E3B420", Offset = "0x2E3A820", Length = "0x61")]
	[Token(Token = "0x6000341")]
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x2E3B490", Offset = "0x2E3A890", Length = "0x61")]
	[Token(Token = "0x6000347")]
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x735880", Offset = "0x734C80", Length = "0x70")]
	[Token(Token = "0x6000344")]
	public AsyncOperationHandle<T> Convert() { }

	[Address(RVA = "0x1161AE0", Offset = "0x1160EE0", Length = "0x21")]
	[Token(Token = "0x6000345")]
	public bool Equals(AsyncOperationHandle other) { }

	[Address(RVA = "0x2E3B500", Offset = "0x2E3A900", Length = "0xA6")]
	[Token(Token = "0x6000346")]
	public string get_DebugName() { }

	[Address(RVA = "0x2E3B5B0", Offset = "0x2E3A9B0", Length = "0x95")]
	[Token(Token = "0x600034B")]
	private IAsyncOperation get_InternalOp() { }

	[Address(RVA = "0x2E3B650", Offset = "0x2E3AA50", Length = "0x95")]
	[Token(Token = "0x600034C")]
	public bool get_IsDone() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600033A")]
	internal string get_LocationName() { }

	[Address(RVA = "0x2E3B6F0", Offset = "0x2E3AAF0", Length = "0xCB")]
	[Token(Token = "0x600034E")]
	public Exception get_OperationException() { }

	[Address(RVA = "0x2E3B7C0", Offset = "0x2E3ABC0", Length = "0xCB")]
	[Token(Token = "0x600034F")]
	public float get_PercentComplete() { }

	[Address(RVA = "0x2E3B890", Offset = "0x2E3AC90", Length = "0x52")]
	[Token(Token = "0x6000352")]
	internal int get_ReferenceCount() { }

	[Address(RVA = "0x2E3B140", Offset = "0x2E3A540", Length = "0x4F")]
	[Token(Token = "0x6000354")]
	public object get_Result() { }

	[Address(RVA = "0x2E3B8F0", Offset = "0x2E3ACF0", Length = "0x52")]
	[Token(Token = "0x6000355")]
	public AsyncOperationStatus get_Status() { }

	[Address(RVA = "0x2E3B950", Offset = "0x2E3AD50", Length = "0xCB")]
	[Token(Token = "0x6000356")]
	public Task<Object> get_Task() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000339")]
	internal int get_Version() { }

	[Address(RVA = "0x2E3AC00", Offset = "0x2E3A000", Length = "0xC5")]
	[Token(Token = "0x6000349")]
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	[Address(RVA = "0x2E3ACD0", Offset = "0x2E3A0D0", Length = "0x91")]
	[Token(Token = "0x6000350")]
	public DownloadStatus GetDownloadStatus() { }

	[Address(RVA = "0x1162080", Offset = "0x1161480", Length = "0x39")]
	[Token(Token = "0x600034A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2E3AD70", Offset = "0x2E3A170", Length = "0x195")]
	[Token(Token = "0x6000351")]
	internal DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited) { }

	[Address(RVA = "0x2E3AF10", Offset = "0x2E3A310", Length = "0x53")]
	[Token(Token = "0x600034D")]
	public bool IsValid() { }

	[Address(RVA = "0x2E3B0B0", Offset = "0x2E3A4B0", Length = "0x63")]
	[Token(Token = "0x6000353")]
	public void Release() { }

	[Address(RVA = "0x2E3AF70", Offset = "0x2E3A370", Length = "0x137")]
	[Token(Token = "0x6000343")]
	public void ReleaseHandleOnCompletion() { }

	[Address(RVA = "0x2E3BA20", Offset = "0x2E3AE20", Length = "0x61")]
	[Token(Token = "0x6000342")]
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0x2E3BA90", Offset = "0x2E3AE90", Length = "0x61")]
	[Token(Token = "0x6000348")]
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600033B")]
	internal void set_LocationName(string value) { }

	[Address(RVA = "0x2E3B140", Offset = "0x2E3A540", Length = "0x4F")]
	[Token(Token = "0x6000357")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x2E3B120", Offset = "0x2E3A520", Length = "0x12")]
	[Token(Token = "0x6000358")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000359")]
	private override void System.Collections.IEnumerator.Reset() { }

	[Address(RVA = "0x2E3B190", Offset = "0x2E3A590", Length = "0x13B")]
	[Token(Token = "0x600035A")]
	public object WaitForCompletion() { }

}

