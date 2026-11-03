namespace System.IO.Enumeration;

[Token(Token = "0x2000686")]
public abstract class FileSystemEnumerator : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A58")]
	private readonly string _originalRootDirectory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A59")]
	private readonly string _rootDirectory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5A")]
	private readonly EnumerationOptions _options; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5B")]
	private readonly object _lock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5C")]
	private FILE_FULL_DIR_INFORMATION* _entry; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5D")]
	private TResult _current; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5E")]
	private IntPtr _buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A5F")]
	private int _bufferLength; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A60")]
	private IntPtr _directoryHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A61")]
	private string _currentPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A62")]
	private bool _lastEntryFound; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A63")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Handle", "Path"})]
	private Queue<ValueTuple`2<IntPtr, String>> _pending; //Field offset: 0x0

	[Token(Token = "0x170007A5")]
	public override TResult Current
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6003124")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170007A6")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6003125")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x1BC1DB0", Offset = "0x1BC11B0", Length = "0x329")]
	[Token(Token = "0x6003115")]
	public FileSystemEnumerator`1(string directory, EnumerationOptions options = null) { }

	[Address(RVA = "0x1BBE780", Offset = "0x1BBDB80", Length = "0x2A")]
	[Token(Token = "0x6003116")]
	private void CloseDirectoryHandle() { }

	[Address(RVA = "0x1BBE890", Offset = "0x1BBDC90", Length = "0x51")]
	[Token(Token = "0x6003118")]
	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6003123")]
	protected override bool ContinueOnError(int error) { }

	[Address(RVA = "0x1BBE8F0", Offset = "0x1BBDCF0", Length = "0x1FB")]
	[Token(Token = "0x6003117")]
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false) { }

	[Address(RVA = "0x1BBEE20", Offset = "0x1BBE220", Length = "0x115")]
	[Token(Token = "0x600311E")]
	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[Address(RVA = "0x1BBECF0", Offset = "0x1BBE0F0", Length = "0x1A")]
	[Token(Token = "0x6003114")]
	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[Address(RVA = "0x1BBF0F0", Offset = "0x1BBE4F0", Length = "0x81")]
	[Token(Token = "0x600311B")]
	private bool DequeueNextDirectory() { }

	[Address(RVA = "0x1BBF310", Offset = "0x1BBE710", Length = "0x148")]
	[Token(Token = "0x6003126")]
	private void DirectoryFinished() { }

	[Address(RVA = "0x1BBF4E0", Offset = "0x1BBE8E0", Length = "0x71")]
	[Token(Token = "0x6003128")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6003129")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1BBF5F0", Offset = "0x1BBE9F0", Length = "0x7E")]
	[Token(Token = "0x600312A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1BBF670", Offset = "0x1BBEA70", Length = "0x131")]
	[Token(Token = "0x600311A")]
	private void FindNextEntry() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6003124")]
	public override TResult get_Current() { }

	[Address(RVA = "0x1BBFBD0", Offset = "0x1BBEFD0", Length = "0x136")]
	[Token(Token = "0x600311D")]
	private bool GetData() { }

	[Address(RVA = "0x1BBFAB0", Offset = "0x1BBEEB0", Length = "0x119")]
	[Token(Token = "0x6003113")]
	private bool GetDataUWP() { }

	[Address(RVA = "0x1BC0260", Offset = "0x1BBF660", Length = "0x1DB")]
	[Token(Token = "0x600311C")]
	private void InternalDispose(bool disposing) { }

	[Address(RVA = "0x1BC0E40", Offset = "0x1BC0240", Length = "0x880")]
	[Token(Token = "0x6003119")]
	public override bool MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6003122")]
	protected override void OnDirectoryFinished(ReadOnlySpan<Char> directory) { }

	[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
	[Token(Token = "0x6003127")]
	public override void Reset() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600311F")]
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6003120")]
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6003125")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Token(Token = "0x6003121")]
	protected abstract TResult TransformEntry(ref FileSystemEntry entry) { }

}

