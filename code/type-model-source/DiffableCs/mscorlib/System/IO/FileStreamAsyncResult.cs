namespace System.IO;

[Token(Token = "0x200067A")]
internal class FileStreamAsyncResult : IAsyncResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A15")]
	private object state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A16")]
	private bool completed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A17")]
	private ManualResetEvent wh; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A18")]
	private AsyncCallback cb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A19")]
	private bool completedSynch; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001A1A")]
	public int Count; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A1B")]
	public int OriginalCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001A1C")]
	public int BytesRead; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A1D")]
	private AsyncCallback realcb; //Field offset: 0x40

	[Token(Token = "0x1700079A")]
	public override object AsyncState
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60030AE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700079C")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60030B0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700079B")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60030AF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700079D")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60030B1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FF13C0", Offset = "0x1FF07C0", Length = "0xEB")]
	[Token(Token = "0x60030AC")]
	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	[Address(RVA = "0x1FF1330", Offset = "0x1FF0730", Length = "0x89")]
	[Token(Token = "0x60030AD")]
	private static void CBWrapper(IAsyncResult ares) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60030AE")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60030B0")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60030AF")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60030B1")]
	public override bool get_IsCompleted() { }

}

