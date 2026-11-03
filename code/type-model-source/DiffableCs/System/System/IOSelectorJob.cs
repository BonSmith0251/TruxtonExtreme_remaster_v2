namespace System;

[Token(Token = "0x20000D2")]
internal class IOSelectorJob : IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000343")]
	private IOOperation operation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000344")]
	private IOAsyncCallback callback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000345")]
	private IOAsyncResult state; //Field offset: 0x20

	[Address(RVA = "0x19529A0", Offset = "0x1951DA0", Length = "0x5D")]
	[Token(Token = "0x600043F")]
	public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	[Address(RVA = "0x2617F60", Offset = "0x2617360", Length = "0x2A")]
	[Token(Token = "0x6000442")]
	public void MarkDisposed() { }

	[Address(RVA = "0x2617F90", Offset = "0x2617390", Length = "0x2C")]
	[Token(Token = "0x6000440")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000441")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

