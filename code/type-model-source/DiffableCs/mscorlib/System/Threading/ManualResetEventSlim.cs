namespace System.Threading;

[DebuggerDisplay("Set = {IsSet}")]
[Token(Token = "0x2000203")]
public class ManualResetEventSlim : IDisposable
{
	[Token(Token = "0x400099D")]
	private static Action<Object> s_cancellationTokenCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400099A")]
	private object m_lock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400099B")]
	private ManualResetEvent m_eventObj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400099C")]
	private int m_combinedState; //Field offset: 0x20

	[Token(Token = "0x17000190")]
	public private bool IsSet
	{
		[Address(RVA = "0x20A1710", Offset = "0x20A0B10", Length = "0x51")]
		[Token(Token = "0x60011B0")]
		 get { } //Length: 81
		[Address(RVA = "0x20A18C0", Offset = "0x20A0CC0", Length = "0x26")]
		[Token(Token = "0x60011B1")]
		private set { } //Length: 38
	}

	[Token(Token = "0x17000191")]
	public private int SpinCount
	{
		[Address(RVA = "0x20A1770", Offset = "0x20A0B70", Length = "0x53")]
		[Token(Token = "0x60011B2")]
		 get { } //Length: 83
		[Address(RVA = "0x20A18F0", Offset = "0x20A0CF0", Length = "0x3F")]
		[Token(Token = "0x60011B3")]
		private set { } //Length: 63
	}

	[Token(Token = "0x17000192")]
	private int Waiters
	{
		[Address(RVA = "0x20A1870", Offset = "0x20A0C70", Length = "0x50")]
		[Token(Token = "0x60011B4")]
		private get { } //Length: 80
		[Address(RVA = "0x20A1930", Offset = "0x20A0D30", Length = "0xA7")]
		[Token(Token = "0x60011B5")]
		private set { } //Length: 167
	}

	[Token(Token = "0x1700018F")]
	public WaitHandle WaitHandle
	{
		[Address(RVA = "0x20A17D0", Offset = "0x20A0BD0", Length = "0x92")]
		[Token(Token = "0x60011AF")]
		 get { } //Length: 146
	}

	[Address(RVA = "0x20A1460", Offset = "0x20A0860", Length = "0x89")]
	[Token(Token = "0x60011C5")]
	private static ManualResetEventSlim() { }

	[Address(RVA = "0x20A14F0", Offset = "0x20A08F0", Length = "0xFA")]
	[Token(Token = "0x60011B6")]
	public ManualResetEventSlim(bool initialState) { }

	[Address(RVA = "0x20A15F0", Offset = "0x20A09F0", Length = "0x119")]
	[Token(Token = "0x60011B7")]
	public ManualResetEventSlim(bool initialState, int spinCount) { }

	[Address(RVA = "0x209FE80", Offset = "0x209F280", Length = "0x21A")]
	[Token(Token = "0x60011C1")]
	private static void CancellationTokenCallback(object obj) { }

	[Address(RVA = "0x20A0110", Offset = "0x209F510", Length = "0x165")]
	[Token(Token = "0x60011BF")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x20A00A0", Offset = "0x209F4A0", Length = "0x61")]
	[Token(Token = "0x60011BE")]
	public override void Dispose() { }

	[Address(RVA = "0x20A0280", Offset = "0x209F680", Length = "0x72")]
	[Token(Token = "0x60011B9")]
	private void EnsureLockObjectCreated() { }

	[Address(RVA = "0x20A0310", Offset = "0x209F710", Length = "0x5")]
	[Token(Token = "0x60011C4")]
	private static int ExtractStatePortion(int state, int mask) { }

	[Address(RVA = "0x20A0300", Offset = "0x209F700", Length = "0xF")]
	[Token(Token = "0x60011C3")]
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	[Address(RVA = "0x20A1710", Offset = "0x20A0B10", Length = "0x51")]
	[Token(Token = "0x60011B0")]
	public bool get_IsSet() { }

	[Address(RVA = "0x20A1770", Offset = "0x20A0B70", Length = "0x53")]
	[Token(Token = "0x60011B2")]
	public int get_SpinCount() { }

	[Address(RVA = "0x20A1870", Offset = "0x20A0C70", Length = "0x50")]
	[Token(Token = "0x60011B4")]
	private int get_Waiters() { }

	[Address(RVA = "0x20A17D0", Offset = "0x20A0BD0", Length = "0x92")]
	[Token(Token = "0x60011AF")]
	public WaitHandle get_WaitHandle() { }

	[Address(RVA = "0x20A0320", Offset = "0x209F720", Length = "0xBB")]
	[Token(Token = "0x60011B8")]
	private void Initialize(bool initialState, int spinCount) { }

	[Address(RVA = "0x20A03E0", Offset = "0x209F7E0", Length = "0x33C")]
	[Token(Token = "0x60011BA")]
	private bool LazyInitializeEvent() { }

	[Address(RVA = "0x20A0730", Offset = "0x209FB30", Length = "0x38B")]
	[Token(Token = "0x60011BC")]
	private void Set(bool duringCancellation) { }

	[Address(RVA = "0x20A0720", Offset = "0x209FB20", Length = "0xA")]
	[Token(Token = "0x60011BB")]
	public void Set() { }

	[Address(RVA = "0x20A18C0", Offset = "0x20A0CC0", Length = "0x26")]
	[Token(Token = "0x60011B1")]
	private void set_IsSet(bool value) { }

	[Address(RVA = "0x20A18F0", Offset = "0x20A0CF0", Length = "0x3F")]
	[Token(Token = "0x60011B3")]
	private void set_SpinCount(int value) { }

	[Address(RVA = "0x20A1930", Offset = "0x20A0D30", Length = "0xA7")]
	[Token(Token = "0x60011B5")]
	private void set_Waiters(int value) { }

	[Address(RVA = "0x20A0AC0", Offset = "0x209FEC0", Length = "0x62")]
	[Token(Token = "0x60011C0")]
	private void ThrowIfDisposed() { }

	[Address(RVA = "0x20A0B30", Offset = "0x209FF30", Length = "0x103")]
	[Token(Token = "0x60011C2")]
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	[Address(RVA = "0x20A0C40", Offset = "0x20A0040", Length = "0x818")]
	[Token(Token = "0x60011BD")]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

}

