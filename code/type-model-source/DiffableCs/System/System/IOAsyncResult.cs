namespace System;

[Token(Token = "0x20000D1")]
internal abstract class IOAsyncResult : IAsyncResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033E")]
	private AsyncCallback async_callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033F")]
	private object async_state; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000340")]
	private ManualResetEvent wait_handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000341")]
	private bool completed_synchronously; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000342")]
	private bool completed; //Field offset: 0x29

	[Token(Token = "0x170000AE")]
	public AsyncCallback AsyncCallback
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000437")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000AF")]
	public override object AsyncState
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000438")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B0")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x2617DC0", Offset = "0x26171C0", Length = "0xEB")]
		[Token(Token = "0x6000439")]
		 get { } //Length: 235
	}

	[Token(Token = "0x170000B1")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600043A")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x600043B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B2")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x600043C")]
		 get { } //Length: 5
		[Address(RVA = "0x2617EB0", Offset = "0x26172B0", Length = "0xA0")]
		[Token(Token = "0x600043D")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000434")]
	protected IOAsyncResult() { }

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000436")]
	protected IOAsyncResult(AsyncCallback async_callback, object async_state) { }

	[Token(Token = "0x600043E")]
	internal abstract void CompleteDisposed() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000437")]
	public AsyncCallback get_AsyncCallback() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000438")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x2617DC0", Offset = "0x26171C0", Length = "0xEB")]
	[Token(Token = "0x6000439")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600043A")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x600043C")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x2617D70", Offset = "0x2617170", Length = "0x50")]
	[Token(Token = "0x6000435")]
	protected void Init(AsyncCallback async_callback, object async_state) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x600043B")]
	protected void set_CompletedSynchronously(bool value) { }

	[Address(RVA = "0x2617EB0", Offset = "0x26172B0", Length = "0xA0")]
	[Token(Token = "0x600043D")]
	protected void set_IsCompleted(bool value) { }

}

