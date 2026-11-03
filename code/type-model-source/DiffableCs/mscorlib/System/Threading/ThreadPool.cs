namespace System.Threading;

[Token(Token = "0x2000240")]
public static class ThreadPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000241")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4B")]
		public Action<TState> callBack; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001331")]
		public <>c__DisplayClass17_0`1() { }

		[Address(RVA = "0xA543C0", Offset = "0xA537C0", Length = "0x89")]
		[Token(Token = "0x6001332")]
		internal void <QueueUserWorkItem>b__0(object x) { }

	}


	[Token(Token = "0x170001C3")]
	internal static bool IsThreadPoolThread
	{
		[Address(RVA = "0x20C2540", Offset = "0x20C1940", Length = "0x7A")]
		[Token(Token = "0x6001330")]
		internal get { } //Length: 122
	}

	[Address(RVA = "0x20C1CE0", Offset = "0x20C10E0", Length = "0x9E")]
	[Token(Token = "0x6001329")]
	private static void EnsureVMInitialized() { }

	[Address(RVA = "0x20C2540", Offset = "0x20C1940", Length = "0x7A")]
	[Token(Token = "0x6001330")]
	internal static bool get_IsThreadPoolThread() { }

	[Address(RVA = "0x20C1D80", Offset = "0x20C1180", Length = "0x5")]
	[Token(Token = "0x600132F")]
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	[Address(RVA = "0x20C1D90", Offset = "0x20C1190", Length = "0x5")]
	[Token(Token = "0x600132A")]
	internal static bool NotifyWorkItemComplete() { }

	[Address(RVA = "0x20C0710", Offset = "0x20BFB10", Length = "0x14")]
	[Token(Token = "0x600132C")]
	internal static void NotifyWorkItemProgress() { }

	[Address(RVA = "0x20C1DA0", Offset = "0x20C11A0", Length = "0x5")]
	[Token(Token = "0x600132D")]
	internal static void NotifyWorkItemProgressNative() { }

	[Address(RVA = "0x1F685D0", Offset = "0x1F679D0", Length = "0x5")]
	[Token(Token = "0x600132E")]
	internal static void NotifyWorkItemQueued() { }

	[Address(RVA = "0x20C1F40", Offset = "0x20C1340", Length = "0x2C")]
	[Token(Token = "0x6001321")]
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	[Address(RVA = "0x20C1F10", Offset = "0x20C1310", Length = "0x2E")]
	[Token(Token = "0x6001322")]
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	[Address(RVA = "0x944EE0", Offset = "0x9442E0", Length = "0x13F")]
	[Token(Token = "0x6001324")]
	public static bool QueueUserWorkItem(Action<TState> callBack, TState state, bool preferLocal) { }

	[Address(RVA = "0x20C1DB0", Offset = "0x20C11B0", Length = "0x15F")]
	[Token(Token = "0x6001325")]
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true) { }

	[Address(RVA = "0x20C20F0", Offset = "0x20C14F0", Length = "0x294")]
	[Token(Token = "0x600131F")]
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	[Address(RVA = "0x20C1F70", Offset = "0x20C1370", Length = "0x17D")]
	[Token(Token = "0x6001320")]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	[Address(RVA = "0x1F659D0", Offset = "0x1F64DD0", Length = "0x5")]
	[Token(Token = "0x600132B")]
	internal static void ReportThreadStatus(bool isWorking) { }

	[Address(RVA = "0x20C2390", Offset = "0x20C1790", Length = "0x5")]
	[Token(Token = "0x6001328")]
	internal static bool RequestWorkerThread() { }

	[Address(RVA = "0x20C23A0", Offset = "0x20C17A0", Length = "0xE9")]
	[Token(Token = "0x6001327")]
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	[Address(RVA = "0x20C2490", Offset = "0x20C1890", Length = "0x77")]
	[Token(Token = "0x6001326")]
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	[Address(RVA = "0x20C2510", Offset = "0x20C1910", Length = "0x2C")]
	[Token(Token = "0x6001323")]
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

}

