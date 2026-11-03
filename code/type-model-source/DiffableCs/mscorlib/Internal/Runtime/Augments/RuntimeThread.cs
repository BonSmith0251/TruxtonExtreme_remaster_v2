namespace Internal.Runtime.Augments;

[Token(Token = "0x200008B")]
internal sealed class RuntimeThread
{
	[Token(Token = "0x400023F")]
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000240")]
	private readonly Thread thread; //Field offset: 0x10

	[Token(Token = "0x17000035")]
	public bool IsBackground
	{
		[Address(RVA = "0x1E7C680", Offset = "0x1E7BA80", Length = "0x1E")]
		[Token(Token = "0x600023A")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x1E7C640", Offset = "0x1E7BA40", Length = "0x39")]
	[Token(Token = "0x6000240")]
	private static RuntimeThread() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000238")]
	private RuntimeThread(Thread t) { }

	[Address(RVA = "0x1E7C540", Offset = "0x1E7B940", Length = "0x98")]
	[Token(Token = "0x6000239")]
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600023F")]
	public static int GetCurrentProcessorId() { }

	[Address(RVA = "0x1E7C680", Offset = "0x1E7BA80", Length = "0x1E")]
	[Token(Token = "0x600023A")]
	public void set_IsBackground(bool value) { }

	[Address(RVA = "0x1E7C5E0", Offset = "0x1E7B9E0", Length = "0x7")]
	[Token(Token = "0x600023C")]
	public static void Sleep(int millisecondsTimeout) { }

	[Address(RVA = "0x1E7C5F0", Offset = "0x1E7B9F0", Length = "0x12")]
	[Token(Token = "0x600023E")]
	public static bool SpinWait(int iterations) { }

	[Address(RVA = "0x1E7C610", Offset = "0x1E7BA10", Length = "0x1E")]
	[Token(Token = "0x600023B")]
	public void Start(object state) { }

	[Address(RVA = "0x1E7C630", Offset = "0x1E7BA30", Length = "0x7")]
	[Token(Token = "0x600023D")]
	public static bool Yield() { }

}

