namespace System.Threading;

[Token(Token = "0x200028E")]
public class ReaderWriterLockSlim : IDisposable
{
	[Token(Token = "0x200028F")]
	private struct TimeoutTracker
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C1")]
		private int m_total; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40004C2")]
		private int m_start; //Field offset: 0x4

		[Token(Token = "0x17000298")]
		public bool IsExpired
		{
			[Address(RVA = "0x22B43F0", Offset = "0x22B37F0", Length = "0x4C")]
			[Token(Token = "0x6000D22")]
			 get { } //Length: 76
		}

		[Token(Token = "0x17000297")]
		public int RemainingMilliseconds
		{
			[Address(RVA = "0x22B4440", Offset = "0x22B3840", Length = "0x3F")]
			[Token(Token = "0x6000D21")]
			 get { } //Length: 63
		}

		[Address(RVA = "0x22B4370", Offset = "0x22B3770", Length = "0x7D")]
		[Token(Token = "0x6000D20")]
		public TimeoutTracker(int millisecondsTimeout) { }

		[Address(RVA = "0x22B43F0", Offset = "0x22B37F0", Length = "0x4C")]
		[Token(Token = "0x6000D22")]
		public bool get_IsExpired() { }

		[Address(RVA = "0x22B4440", Offset = "0x22B3840", Length = "0x3F")]
		[Token(Token = "0x6000D21")]
		public int get_RemainingMilliseconds() { }

	}

	[ThreadStatic]
	[Token(Token = "0x40004BD")]
	private static ReaderWriterCount t_rwc; //Field offset: 0x80000000
	[Token(Token = "0x40004BB")]
	private static long s_nextLockID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004AE")]
	private bool fIsReentrant; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004AF")]
	private int myLock; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B0")]
	private uint numWriteWaiters; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004B1")]
	private uint numReadWaiters; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B2")]
	private uint numWriteUpgradeWaiters; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004B3")]
	private uint numUpgradeWaiters; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B4")]
	private bool fNoWaiters; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004B5")]
	private int upgradeLockOwnerId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B6")]
	private int writeLockOwnerId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004B7")]
	private EventWaitHandle writeEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004B8")]
	private EventWaitHandle readEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004B9")]
	private EventWaitHandle upgradeEvent; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004BA")]
	private EventWaitHandle waitUpgradeEvent; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004BC")]
	private long lockID; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004BE")]
	private bool fUpgradeThreadHoldingRead; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40004BF")]
	private uint owners; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004C0")]
	private bool fDisposed; //Field offset: 0x68

	[Token(Token = "0x1700028E")]
	public bool IsReadLockHeld
	{
		[Address(RVA = "0x22B3B40", Offset = "0x22B2F40", Length = "0x74")]
		[Token(Token = "0x6000D17")]
		 get { } //Length: 116
	}

	[Token(Token = "0x1700028F")]
	public bool IsUpgradeableReadLockHeld
	{
		[Address(RVA = "0x22B3BC0", Offset = "0x22B2FC0", Length = "0x9B")]
		[Token(Token = "0x6000D18")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000290")]
	public bool IsWriteLockHeld
	{
		[Address(RVA = "0x22B3C60", Offset = "0x22B3060", Length = "0x9B")]
		[Token(Token = "0x6000D19")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000291")]
	public int RecursiveReadCount
	{
		[Address(RVA = "0x22B3D00", Offset = "0x22B3100", Length = "0x70")]
		[Token(Token = "0x6000D1A")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000292")]
	public int RecursiveUpgradeCount
	{
		[Address(RVA = "0x22B3D70", Offset = "0x22B3170", Length = "0xB4")]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000293")]
	public int RecursiveWriteCount
	{
		[Address(RVA = "0x22B3E30", Offset = "0x22B3230", Length = "0xB4")]
		[Token(Token = "0x6000D1C")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000294")]
	public int WaitingReadCount
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000D1D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000295")]
	public int WaitingUpgradeCount
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000D1E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000296")]
	public int WaitingWriteCount
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x22B3AE0", Offset = "0x22B2EE0", Length = "0x5A")]
	[Token(Token = "0x6000CF0")]
	public ReaderWriterLockSlim() { }

	[Address(RVA = "0x22B3A70", Offset = "0x22B2E70", Length = "0x6E")]
	[Token(Token = "0x6000CF1")]
	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy) { }

	[Address(RVA = "0x22B19A0", Offset = "0x22B0DA0", Length = "0x8")]
	[Token(Token = "0x6000D0F")]
	private void ClearUpgraderWaiting() { }

	[Address(RVA = "0x22B19B0", Offset = "0x22B0DB0", Length = "0x8")]
	[Token(Token = "0x6000D0B")]
	private void ClearWriterAcquired() { }

	[Address(RVA = "0x22B19C0", Offset = "0x22B0DC0", Length = "0x8")]
	[Token(Token = "0x6000D0D")]
	private void ClearWritersWaiting() { }

	[Address(RVA = "0x22B19D0", Offset = "0x22B0DD0", Length = "0x323")]
	[Token(Token = "0x6000D16")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x22B1D00", Offset = "0x22B1100", Length = "0xA")]
	[Token(Token = "0x6000D15")]
	public override void Dispose() { }

	[Address(RVA = "0x22B1DD0", Offset = "0x22B11D0", Length = "0x36")]
	[Token(Token = "0x6000D11")]
	private void EnterMyLock() { }

	[Address(RVA = "0x22B1D10", Offset = "0x22B1110", Length = "0xBC")]
	[Token(Token = "0x6000D12")]
	private void EnterMyLockSpin() { }

	[Address(RVA = "0x22B1E10", Offset = "0x22B1210", Length = "0x1F")]
	[Token(Token = "0x6000CF5")]
	public void EnterReadLock() { }

	[Address(RVA = "0x22B1E30", Offset = "0x22B1230", Length = "0x1F")]
	[Token(Token = "0x6000CFD")]
	public void EnterUpgradeableReadLock() { }

	[Address(RVA = "0x22B1E50", Offset = "0x22B1250", Length = "0x1F")]
	[Token(Token = "0x6000CF9")]
	public void EnterWriteLock() { }

	[Address(RVA = "0x22B1E70", Offset = "0x22B1270", Length = "0x92")]
	[Token(Token = "0x6000D08")]
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	[Address(RVA = "0x22B1FA0", Offset = "0x22B13A0", Length = "0x98")]
	[Token(Token = "0x6000D06")]
	private void ExitAndWakeUpAppropriateWaiters() { }

	[Address(RVA = "0x22B1F10", Offset = "0x22B1310", Length = "0x80")]
	[Token(Token = "0x6000D07")]
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	[Address(RVA = "0x22B2040", Offset = "0x22B1440", Length = "0x1B")]
	[Token(Token = "0x6000D13")]
	private void ExitMyLock() { }

	[Address(RVA = "0x22B2060", Offset = "0x22B1460", Length = "0x1D3")]
	[Token(Token = "0x6000D01")]
	public void ExitReadLock() { }

	[Address(RVA = "0x22B2240", Offset = "0x22B1640", Length = "0x2FC")]
	[Token(Token = "0x6000D03")]
	public void ExitUpgradeableReadLock() { }

	[Address(RVA = "0x22B2540", Offset = "0x22B1940", Length = "0x1F6")]
	[Token(Token = "0x6000D02")]
	public void ExitWriteLock() { }

	[Address(RVA = "0x22B3B40", Offset = "0x22B2F40", Length = "0x74")]
	[Token(Token = "0x6000D17")]
	public bool get_IsReadLockHeld() { }

	[Address(RVA = "0x22B3BC0", Offset = "0x22B2FC0", Length = "0x9B")]
	[Token(Token = "0x6000D18")]
	public bool get_IsUpgradeableReadLockHeld() { }

	[Address(RVA = "0x22B3C60", Offset = "0x22B3060", Length = "0x9B")]
	[Token(Token = "0x6000D19")]
	public bool get_IsWriteLockHeld() { }

	[Address(RVA = "0x22B3D00", Offset = "0x22B3100", Length = "0x70")]
	[Token(Token = "0x6000D1A")]
	public int get_RecursiveReadCount() { }

	[Address(RVA = "0x22B3D70", Offset = "0x22B3170", Length = "0xB4")]
	[Token(Token = "0x6000D1B")]
	public int get_RecursiveUpgradeCount() { }

	[Address(RVA = "0x22B3E30", Offset = "0x22B3230", Length = "0xB4")]
	[Token(Token = "0x6000D1C")]
	public int get_RecursiveWriteCount() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000D1D")]
	public int get_WaitingReadCount() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000D1E")]
	public int get_WaitingUpgradeCount() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000D1F")]
	public int get_WaitingWriteCount() { }

	[Address(RVA = "0x22B2740", Offset = "0x22B1B40", Length = "0x9")]
	[Token(Token = "0x6000D10")]
	private uint GetNumReaders() { }

	[Address(RVA = "0x22B2750", Offset = "0x22B1B50", Length = "0x135")]
	[Token(Token = "0x6000CF4")]
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	[Address(RVA = "0x22B2890", Offset = "0x22B1C90", Length = "0x9")]
	[Token(Token = "0x6000CEF")]
	private void InitializeThreadCounts() { }

	[Address(RVA = "0x22B28A0", Offset = "0x22B1CA0", Length = "0x35")]
	[Token(Token = "0x6000CF2")]
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	[Address(RVA = "0x22B28E0", Offset = "0x22B1CE0", Length = "0x1E")]
	[Token(Token = "0x6000CF3")]
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	[Address(RVA = "0x22B2900", Offset = "0x22B1D00", Length = "0xB")]
	[Token(Token = "0x6000D09")]
	private bool IsWriterAcquired() { }

	[Address(RVA = "0x22B2910", Offset = "0x22B1D10", Length = "0x100")]
	[Token(Token = "0x6000D04")]
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	[Address(RVA = "0x22B2A20", Offset = "0x22B1E20", Length = "0x8")]
	[Token(Token = "0x6000D0E")]
	private void SetUpgraderWaiting() { }

	[Address(RVA = "0x22B2A30", Offset = "0x22B1E30", Length = "0x8")]
	[Token(Token = "0x6000D0A")]
	private void SetWriterAcquired() { }

	[Address(RVA = "0x22B2A40", Offset = "0x22B1E40", Length = "0x8")]
	[Token(Token = "0x6000D0C")]
	private void SetWritersWaiting() { }

	[Address(RVA = "0x22B2A50", Offset = "0x22B1E50", Length = "0x7E")]
	[Token(Token = "0x6000D14")]
	private static void SpinWait(int SpinCount) { }

	[Address(RVA = "0x22B2EE0", Offset = "0x22B22E0", Length = "0x8")]
	[Token(Token = "0x6000CF7")]
	private bool TryEnterReadLock(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B2E50", Offset = "0x22B2250", Length = "0x8C")]
	[Token(Token = "0x6000CF6")]
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	[Address(RVA = "0x22B2AD0", Offset = "0x22B1ED0", Length = "0x37C")]
	[Token(Token = "0x6000CF8")]
	private bool TryEnterReadLockCore(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B3350", Offset = "0x22B2750", Length = "0x8")]
	[Token(Token = "0x6000CFF")]
	private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B3360", Offset = "0x22B2760", Length = "0x8C")]
	[Token(Token = "0x6000CFE")]
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	[Address(RVA = "0x22B2EF0", Offset = "0x22B22F0", Length = "0x45C")]
	[Token(Token = "0x6000D00")]
	private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B38A0", Offset = "0x22B2CA0", Length = "0x8")]
	[Token(Token = "0x6000CFB")]
	private bool TryEnterWriteLock(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B38B0", Offset = "0x22B2CB0", Length = "0x8C")]
	[Token(Token = "0x6000CFA")]
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	[Address(RVA = "0x22B33F0", Offset = "0x22B27F0", Length = "0x4A8")]
	[Token(Token = "0x6000CFC")]
	private bool TryEnterWriteLockCore(TimeoutTracker timeout) { }

	[Address(RVA = "0x22B3940", Offset = "0x22B2D40", Length = "0x12E")]
	[Token(Token = "0x6000D05")]
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter) { }

}

