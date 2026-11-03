namespace System.Net;

[Token(Token = "0x2000218")]
internal class ContextAwareResult : LazyAsyncResult
{
	[CompilerGenerated]
	[Token(Token = "0x200021A")]
	private sealed class <>c
	{
		[Token(Token = "0x40007C5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007C6")]
		public static ContextCallback <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x2696610", Offset = "0x2695A10", Length = "0x67")]
		[Token(Token = "0x6000E2B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E2C")]
		public <>c() { }

		[Address(RVA = "0x26964C0", Offset = "0x26958C0", Length = "0x14A")]
		[Token(Token = "0x6000E2D")]
		internal void <Complete>b__17_0(object s) { }

	}

	[Flags]
	[Token(Token = "0x2000219")]
	private enum StateFlags : byte
	{
		None = 0,
		CaptureIdentity = 1,
		CaptureContext = 2,
		ThreadSafeContextCopy = 4,
		PostBlockStarted = 8,
		PostBlockFinished = 16,
	}

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007BB")]
	private ExecutionContext _context; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007BC")]
	private object _lock; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007BD")]
	private StateFlags _flags; //Field offset: 0x50

	[Address(RVA = "0x267ADB0", Offset = "0x267A1B0", Length = "0x17")]
	[Token(Token = "0x6000E21")]
	internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x267AD50", Offset = "0x267A150", Length = "0x58")]
	[Token(Token = "0x6000E22")]
	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x267ACE0", Offset = "0x267A0E0", Length = "0x6E")]
	[Token(Token = "0x6000E23")]
	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x267A0D0", Offset = "0x26794D0", Length = "0x4E9")]
	[Token(Token = "0x6000E28")]
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	[Address(RVA = "0x267A5C0", Offset = "0x26799C0", Length = "0xDB")]
	[Token(Token = "0x6000E27")]
	protected virtual void Cleanup() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E20")]
	private void CleanupInternal() { }

	[Address(RVA = "0x267A790", Offset = "0x2679B90", Length = "0x350")]
	[Token(Token = "0x6000E29")]
	protected virtual void Complete(IntPtr userToken) { }

	[Address(RVA = "0x267A6A0", Offset = "0x2679AA0", Length = "0xE9")]
	[Token(Token = "0x6000E2A")]
	private void CompleteCallback() { }

	[Address(RVA = "0x267AAF0", Offset = "0x2679EF0", Length = "0x37")]
	[Token(Token = "0x6000E26")]
	internal bool FinishPostingAsyncOp() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E1F")]
	private void SafeCaptureIdentity() { }

	[Address(RVA = "0x267AC10", Offset = "0x267A010", Length = "0xCF")]
	[Token(Token = "0x6000E24")]
	internal object StartPostingAsyncOp() { }

	[Address(RVA = "0x267AB30", Offset = "0x2679F30", Length = "0xDB")]
	[Token(Token = "0x6000E25")]
	internal object StartPostingAsyncOp(bool lockCapture) { }

}

