namespace System.Threading.Tasks;

[Token(Token = "0x2000276")]
internal sealed class UnwrapPromise : Task<TResult>, ITaskCompletionAction
{
	[CompilerGenerated]
	[Token(Token = "0x2000277")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B20")]
		public static readonly <>c<TResult> <>9; //Field offset: 0x0
		[Token(Token = "0x4000B21")]
		public static WaitCallback <>9__8_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60014BC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014BD")]
		public <>c() { }

		[Address(RVA = "0xA35480", Offset = "0xA34880", Length = "0x95")]
		[Token(Token = "0x60014BE")]
		internal void <InvokeCoreAsync>b__8_0(object state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B1E")]
	private byte _state; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B1F")]
	private readonly bool _lookForOce; //Field offset: 0x0

	[Token(Token = "0x170001F6")]
	public override bool InvokeMayRunArbitraryCode
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60014BB")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x11E27D0", Offset = "0x11E1BD0", Length = "0x145")]
	[Token(Token = "0x60014B4")]
	public UnwrapPromise`1(Task outerTask, bool lookForOce) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60014BB")]
	public override bool get_InvokeMayRunArbitraryCode() { }

	[Address(RVA = "0x11E13A0", Offset = "0x11E07A0", Length = "0x15A")]
	[Token(Token = "0x60014B5")]
	public override void Invoke(Task completingTask) { }

	[Address(RVA = "0x11E1100", Offset = "0x11E0500", Length = "0x4F")]
	[Token(Token = "0x60014B6")]
	private void InvokeCore(Task completingTask) { }

	[Address(RVA = "0x11E0B80", Offset = "0x11DFF80", Length = "0x1CB")]
	[Token(Token = "0x60014B7")]
	private void InvokeCoreAsync(Task completingTask) { }

	[Address(RVA = "0x11E1660", Offset = "0x11E0A60", Length = "0x1BB")]
	[Token(Token = "0x60014B8")]
	private void ProcessCompletedOuterTask(Task task) { }

	[Address(RVA = "0x11E1BD0", Offset = "0x11E0FD0", Length = "0x8F")]
	[Token(Token = "0x60014BA")]
	private void ProcessInnerTask(Task task) { }

	[Address(RVA = "0x11E21D0", Offset = "0x11E15D0", Length = "0x2F5")]
	[Token(Token = "0x60014B9")]
	private bool TrySetFromTask(Task task, bool lookForOce) { }

}

