namespace System.Net;

[Token(Token = "0x2000266")]
internal class LazyAsyncResult : IAsyncResult
{
	[Token(Token = "0x2000267")]
	private class ThreadContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009C7")]
		internal int m_NestedIOCount; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600102E")]
		public ThreadContext() { }

	}

	[ThreadStatic]
	[Token(Token = "0x40009BE")]
	private static ThreadContext t_ThreadContext; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009BF")]
	private object m_AsyncObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009C0")]
	private object m_AsyncState; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009C1")]
	private AsyncCallback m_AsyncCallback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009C2")]
	private object m_Result; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009C3")]
	private int m_IntCompleted; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009C4")]
	private bool m_EndCalled; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40009C5")]
	private bool m_UserEvent; //Field offset: 0x35
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009C6")]
	private object m_Event; //Field offset: 0x38

	[Token(Token = "0x17000354")]
	protected AsyncCallback AsyncCallback
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600101E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000352")]
	internal object AsyncObject
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600101C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000353")]
	public override object AsyncState
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600101D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000355")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x26CC670", Offset = "0x26CBA70", Length = "0xB7")]
		[Token(Token = "0x600101F")]
		 get { } //Length: 183
	}

	[Token(Token = "0x17000356")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x26CC730", Offset = "0x26CBB30", Length = "0x29")]
		[Token(Token = "0x6001021")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000351")]
	private static ThreadContext CurrentThreadContext
	{
		[Address(RVA = "0x26CC760", Offset = "0x26CBB60", Length = "0x91")]
		[Token(Token = "0x600101A")]
		private get { } //Length: 145
	}

	[Token(Token = "0x17000359")]
	internal bool EndCalled
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x6001024")]
		internal get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[Token(Token = "0x6001025")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000358")]
	internal bool InternalPeekCompleted
	{
		[Address(RVA = "0x26CC800", Offset = "0x26CBC00", Length = "0xB")]
		[Token(Token = "0x6001023")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000357")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x26CC810", Offset = "0x26CBC10", Length = "0x2C")]
		[Token(Token = "0x6001022")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x26CC5B0", Offset = "0x26CB9B0", Length = "0xC0")]
	[Token(Token = "0x600101B")]
	internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600102B")]
	protected override void Cleanup() { }

	[Address(RVA = "0x26CBE00", Offset = "0x26CB200", Length = "0x1F8")]
	[Token(Token = "0x6001029")]
	protected override void Complete(IntPtr userToken) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600101E")]
	protected AsyncCallback get_AsyncCallback() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600101C")]
	internal object get_AsyncObject() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600101D")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x26CC670", Offset = "0x26CBA70", Length = "0xB7")]
	[Token(Token = "0x600101F")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x26CC730", Offset = "0x26CBB30", Length = "0x29")]
	[Token(Token = "0x6001021")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x26CC760", Offset = "0x26CBB60", Length = "0x91")]
	[Token(Token = "0x600101A")]
	private static ThreadContext get_CurrentThreadContext() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x6001024")]
	internal bool get_EndCalled() { }

	[Address(RVA = "0x26CC800", Offset = "0x26CBC00", Length = "0xB")]
	[Token(Token = "0x6001023")]
	internal bool get_InternalPeekCompleted() { }

	[Address(RVA = "0x26CC810", Offset = "0x26CBC10", Length = "0x2C")]
	[Token(Token = "0x6001022")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x26CC000", Offset = "0x26CB400", Length = "0xA")]
	[Token(Token = "0x600102C")]
	internal object InternalWaitForCompletion() { }

	[Address(RVA = "0x26CC020", Offset = "0x26CB420", Length = "0xB")]
	[Token(Token = "0x6001027")]
	internal void InvokeCallback(object result) { }

	[Address(RVA = "0x26CC010", Offset = "0x26CB410", Length = "0xD")]
	[Token(Token = "0x6001028")]
	internal void InvokeCallback() { }

	[Address(RVA = "0x26CC030", Offset = "0x26CB430", Length = "0x17A")]
	[Token(Token = "0x6001020")]
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	[Address(RVA = "0x26CC1B0", Offset = "0x26CB5B0", Length = "0x189")]
	[Token(Token = "0x6001026")]
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[Token(Token = "0x6001025")]
	internal void set_EndCalled(bool value) { }

	[Address(RVA = "0x26CC340", Offset = "0x26CB740", Length = "0x1D7")]
	[Token(Token = "0x600102D")]
	private object WaitForCompletion(bool snap) { }

	[Address(RVA = "0x26CC520", Offset = "0x26CB920", Length = "0x85")]
	[Token(Token = "0x600102A")]
	private void WorkerThreadComplete(object state) { }

}

