namespace UnityEngine;

[Token(Token = "0x20001D2")]
internal sealed class UnitySynchronizationContext : SynchronizationContext
{
	[Token(Token = "0x20001D3")]
	private struct WorkRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B6")]
		private readonly SendOrPostCallback m_DelagateCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006B7")]
		private readonly object m_DelagateState; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006B8")]
		private readonly ManualResetEvent m_WaitHandle; //Field offset: 0x10

		[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
		[Token(Token = "0x60014BD")]
		public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null) { }

		[Address(RVA = "0x3076160", Offset = "0x3075560", Length = "0x28F")]
		[Token(Token = "0x60014BE")]
		public void Invoke() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006B2")]
	private readonly List<WorkRequest> m_AsyncWorkQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006B3")]
	private readonly List<WorkRequest> m_CurrentFrameWork; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006B4")]
	private readonly int m_MainThreadID; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40006B5")]
	private int m_TrackedCount; //Field offset: 0x2C

	[Token(Token = "0x170002FB")]
	internal int MainThreadId
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60014B0")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x3074D40", Offset = "0x3074140", Length = "0xC6")]
	[Token(Token = "0x60014B1")]
	private UnitySynchronizationContext(int mainThreadID) { }

	[Address(RVA = "0x3074C80", Offset = "0x3074080", Length = "0xB1")]
	[Token(Token = "0x60014B2")]
	private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID) { }

	[Address(RVA = "0x30740D0", Offset = "0x30734D0", Length = "0xE0")]
	[Token(Token = "0x60014B7")]
	public virtual SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x30741B0", Offset = "0x30735B0", Length = "0x1E6")]
	[Token(Token = "0x60014B8")]
	public void Exec() { }

	[Address(RVA = "0x30743A0", Offset = "0x30737A0", Length = "0x153")]
	[RequiredByNativeCode]
	[Token(Token = "0x60014BC")]
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

	[Address(RVA = "0x3074500", Offset = "0x3073900", Length = "0x51")]
	[RequiredByNativeCode]
	[Token(Token = "0x60014BB")]
	private static void ExecuteTasks() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60014B0")]
	internal int get_MainThreadId() { }

	[Address(RVA = "0x3074560", Offset = "0x3073960", Length = "0x52")]
	[Token(Token = "0x60014B9")]
	private bool HasPendingTasks() { }

	[Address(RVA = "0x30745C0", Offset = "0x30739C0", Length = "0x1B1")]
	[RequiredByNativeCode]
	[Token(Token = "0x60014BA")]
	private static void InitializeSynchronizationContext() { }

	[Address(RVA = "0x3074780", Offset = "0x3073B80", Length = "0xB")]
	[Token(Token = "0x60014B5")]
	public virtual void OperationCompleted() { }

	[Address(RVA = "0x3074790", Offset = "0x3073B90", Length = "0xB")]
	[Token(Token = "0x60014B4")]
	public virtual void OperationStarted() { }

	[Address(RVA = "0x30747A0", Offset = "0x3073BA0", Length = "0x1E7")]
	[Token(Token = "0x60014B6")]
	public virtual void Post(SendOrPostCallback callback, object state) { }

	[Address(RVA = "0x3074990", Offset = "0x3073D90", Length = "0x2EC")]
	[Token(Token = "0x60014B3")]
	public virtual void Send(SendOrPostCallback callback, object state) { }

}

