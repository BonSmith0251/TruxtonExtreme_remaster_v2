namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003A7")]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EA3")]
	private object async_state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EA4")]
	private WaitHandle handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EA5")]
	private object async_delegate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EA6")]
	private IntPtr data; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EA7")]
	private object object_data; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EA8")]
	private bool sync_completed; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000EA9")]
	private bool completed; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000EAA")]
	private bool endinvoke_called; //Field offset: 0x3A
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EAB")]
	private object async_callback; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EAC")]
	private ExecutionContext current; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EAD")]
	private ExecutionContext original; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000EAE")]
	private long add_time; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000EAF")]
	private MonoMethodMessage call_message; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000EB0")]
	private IMessageCtrl message_ctrl; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EB1")]
	private IMessage reply_message; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000EB2")]
	private WaitCallback orig_cb; //Field offset: 0x78

	[Token(Token = "0x17000334")]
	public override object AsyncDelegate
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001C6E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032F")]
	public override object AsyncState
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001C68")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000330")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x1EF8690", Offset = "0x1EF7A90", Length = "0xEB")]
		[Token(Token = "0x6001C69")]
		 get { } //Length: 235
	}

	[Token(Token = "0x17000336")]
	internal MonoMethodMessage CallMessage
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001C76")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6001C77")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x17000331")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6001C6A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000333")]
	public bool EndInvokeCalled
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x6001C6C")]
		 get { } //Length: 5
		[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
		[Token(Token = "0x6001C6D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000332")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x6001C6B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000335")]
	public override IMessageSink NextSink
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001C6F")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C67")]
	internal AsyncResult() { }

	[Address(RVA = "0x1EF83D0", Offset = "0x1EF77D0", Length = "0x3E")]
	[Token(Token = "0x6001C70")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EF8410", Offset = "0x1EF7810", Length = "0xE4")]
	[Token(Token = "0x6001C74")]
	internal IMessage EndInvoke() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001C6E")]
	public override object get_AsyncDelegate() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001C68")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x1EF8690", Offset = "0x1EF7A90", Length = "0xEB")]
	[Token(Token = "0x6001C69")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001C76")]
	internal MonoMethodMessage get_CallMessage() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6001C6A")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x6001C6C")]
	public bool get_EndInvokeCalled() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[Token(Token = "0x6001C6B")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001C6F")]
	public override IMessageSink get_NextSink() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001C71")]
	public override IMessage GetReplyMessage() { }

	[Address(RVA = "0x1EF8500", Offset = "0x1EF7900", Length = "0x5")]
	[Token(Token = "0x6001C7A")]
	internal object Invoke() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6001C77")]
	internal void set_CallMessage(MonoMethodMessage value) { }

	[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
	[Token(Token = "0x6001C6D")]
	public void set_EndInvokeCalled(bool value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6001C73")]
	internal void SetCompletedSynchronously(bool completed) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6001C72")]
	public override void SetMessageCtrl(IMessageCtrl mc) { }

	[Address(RVA = "0x1EF8510", Offset = "0x1EF7910", Length = "0x173")]
	[Token(Token = "0x6001C75")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

	[Address(RVA = "0x1EF8500", Offset = "0x1EF7900", Length = "0x5")]
	[Token(Token = "0x6001C78")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001C79")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

