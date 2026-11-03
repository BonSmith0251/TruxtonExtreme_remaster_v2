namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
[Token(Token = "0x2000258")]
public struct ValueTask : IEquatable<ValueTask>
{
	[Token(Token = "0x2000259")]
	private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
	{
		[CompilerGenerated]
		[Token(Token = "0x200025A")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AAF")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x20C4610", Offset = "0x20C3A10", Length = "0x67")]
			[Token(Token = "0x60013C5")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60013C6")]
			public <>c() { }

			[Address(RVA = "0x20C4150", Offset = "0x20C3550", Length = "0x1A0")]
			[Token(Token = "0x60013C7")]
			internal void <.cctor>b__4_0(object state) { }

		}

		[Token(Token = "0x4000AAC")]
		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AAD")]
		private IValueTaskSource _source; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AAE")]
		private readonly short _token; //Field offset: 0x60

		[Address(RVA = "0x20C46F0", Offset = "0x20C3AF0", Length = "0xC8")]
		[Token(Token = "0x60013C4")]
		private static ValueTaskSourceAsTask() { }

		[Address(RVA = "0x20C47C0", Offset = "0x20C3BC0", Length = "0x155")]
		[Token(Token = "0x60013C3")]
		public ValueTaskSourceAsTask(IValueTaskSource source, short token) { }

	}

	[Token(Token = "0x4000AA8")]
	private static readonly Task s_canceledTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AA9")]
	internal readonly object _obj; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AAA")]
	internal readonly short _token; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000AAB")]
	internal readonly bool _continueOnCapturedContext; //Field offset: 0xA

	[Token(Token = "0x170001CE")]
	internal static Task CompletedTask
	{
		[Address(RVA = "0x20C50A0", Offset = "0x20C44A0", Length = "0x8A")]
		[Token(Token = "0x60013B5")]
		internal get { } //Length: 138
	}

	[Token(Token = "0x170001CF")]
	public bool IsCompleted
	{
		[Address(RVA = "0x20C5130", Offset = "0x20C4530", Length = "0xED")]
		[Token(Token = "0x60013BE")]
		 get { } //Length: 237
	}

	[Address(RVA = "0x20C4EF0", Offset = "0x20C42F0", Length = "0xC8")]
	[Token(Token = "0x60013C2")]
	private static ValueTask() { }

	[Address(RVA = "0x20C5050", Offset = "0x20C4450", Length = "0x42")]
	[Token(Token = "0x60013B6")]
	public ValueTask(Task task) { }

	[Address(RVA = "0x20C4FC0", Offset = "0x20C43C0", Length = "0x4E")]
	[Token(Token = "0x60013B7")]
	public ValueTask(IValueTaskSource source, short token) { }

	[Address(RVA = "0x20C5010", Offset = "0x20C4410", Length = "0x3A")]
	[Token(Token = "0x60013B8")]
	private ValueTask(object obj, short token, bool continueOnCapturedContext) { }

	[Address(RVA = "0x20C4920", Offset = "0x20C3D20", Length = "0xC8")]
	[Token(Token = "0x60013BC")]
	public Task AsTask() { }

	[Address(RVA = "0x20C49F0", Offset = "0x20C3DF0", Length = "0x64")]
	[Token(Token = "0x60013C1")]
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x20C4A60", Offset = "0x20C3E60", Length = "0xA9")]
	[Token(Token = "0x60013BA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x20C4B10", Offset = "0x20C3F10", Length = "0x17")]
	[Token(Token = "0x60013BB")]
	public override bool Equals(ValueTask other) { }

	[Address(RVA = "0x20C50A0", Offset = "0x20C44A0", Length = "0x8A")]
	[Token(Token = "0x60013B5")]
	internal static Task get_CompletedTask() { }

	[Address(RVA = "0x20C5130", Offset = "0x20C4530", Length = "0xED")]
	[Token(Token = "0x60013BE")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x1F33300", Offset = "0x1F32700", Length = "0x1F")]
	[Token(Token = "0x60013C0")]
	public ValueTaskAwaiter GetAwaiter() { }

	[Address(RVA = "0x20C4B30", Offset = "0x20C3F30", Length = "0x1F")]
	[Token(Token = "0x60013B9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20C4B50", Offset = "0x20C3F50", Length = "0x2FE")]
	[Token(Token = "0x60013BD")]
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	[Address(RVA = "0x20C4E50", Offset = "0x20C4250", Length = "0x94")]
	[StackTraceHidden]
	[Token(Token = "0x60013BF")]
	internal void ThrowIfCompletedUnsuccessfully() { }

}

