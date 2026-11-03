namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200013A")]
public class UniTaskSynchronizationContext : SynchronizationContext
{
	[IsReadOnly]
	[Token(Token = "0x200013B")]
	private struct Callback
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004DC")]
		private readonly SendOrPostCallback callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004DD")]
		private readonly object state; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000768")]
		public Callback(SendOrPostCallback callback, object state) { }

		[Address(RVA = "0x2786580", Offset = "0x2785980", Length = "0x5C")]
		[Token(Token = "0x6000769")]
		public void Invoke() { }

	}

	[Token(Token = "0x40004D3")]
	private const int MaxArrayLength = 2146435071; //Field offset: 0x0
	[Token(Token = "0x40004D4")]
	private const int InitialSize = 16; //Field offset: 0x0
	[Token(Token = "0x40004D5")]
	private static SpinLock gate; //Field offset: 0x0
	[Token(Token = "0x40004D6")]
	private static bool dequing; //Field offset: 0x4
	[Token(Token = "0x40004D7")]
	private static int actionListCount; //Field offset: 0x8
	[Token(Token = "0x40004D8")]
	private static Callback[] actionList; //Field offset: 0x10
	[Token(Token = "0x40004D9")]
	private static int waitingListCount; //Field offset: 0x18
	[Token(Token = "0x40004DA")]
	private static Callback[] waitingList; //Field offset: 0x20
	[Token(Token = "0x40004DB")]
	private static int opCount; //Field offset: 0x28

	[Address(RVA = "0x2748EF0", Offset = "0x27482F0", Length = "0x112")]
	[Token(Token = "0x6000767")]
	private static UniTaskSynchronizationContext() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000766")]
	public UniTaskSynchronizationContext() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000764")]
	public virtual SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x27485E0", Offset = "0x27479E0", Length = "0x52")]
	[Token(Token = "0x6000763")]
	public virtual void OperationCompleted() { }

	[Address(RVA = "0x2748640", Offset = "0x2747A40", Length = "0x52")]
	[Token(Token = "0x6000762")]
	public virtual void OperationStarted() { }

	[Address(RVA = "0x27486A0", Offset = "0x2747AA0", Length = "0x482")]
	[Token(Token = "0x6000761")]
	public virtual void Post(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x2748B30", Offset = "0x2747F30", Length = "0x3B6")]
	[Token(Token = "0x6000765")]
	internal static void Run() { }

	[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
	[Token(Token = "0x6000760")]
	public virtual void Send(SendOrPostCallback d, object state) { }

}

