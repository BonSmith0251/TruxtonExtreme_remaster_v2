namespace System.Threading;

[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
[Token(Token = "0x2000201")]
public struct CancellationToken
{
	[CompilerGenerated]
	[Token(Token = "0x2000202")]
	private sealed class <>c
	{
		[Token(Token = "0x4000999")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x20A89F0", Offset = "0x20A7DF0", Length = "0x67")]
		[Token(Token = "0x60011AC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011AD")]
		public <>c() { }

		[Address(RVA = "0x20A8890", Offset = "0x20A7C90", Length = "0x6A")]
		[Token(Token = "0x60011AE")]
		internal void <.cctor>b__26_0(object obj) { }

	}

	[Token(Token = "0x4000998")]
	private static readonly Action<Object> s_actionToActionObjShunt; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000997")]
	private readonly CancellationTokenSource _source; //Field offset: 0x0

	[Token(Token = "0x1700018E")]
	public bool CanBeCanceled
	{
		[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
		[Token(Token = "0x600119B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700018D")]
	public bool IsCancellationRequested
	{
		[Address(RVA = "0x2096440", Offset = "0x2095840", Length = "0x31")]
		[Token(Token = "0x600119A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700018C")]
	public static CancellationToken None
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001199")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x20962C0", Offset = "0x20956C0", Length = "0xC8")]
	[Token(Token = "0x60011AB")]
	private static CancellationToken() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x600119C")]
	internal CancellationToken(CancellationTokenSource source) { }

	[Address(RVA = "0x2096390", Offset = "0x2095790", Length = "0x96")]
	[Token(Token = "0x600119D")]
	public CancellationToken(bool canceled) { }

	[Address(RVA = "0x2095B00", Offset = "0x2094F00", Length = "0x99")]
	[Token(Token = "0x60011A5")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x60011A4")]
	public bool Equals(CancellationToken other) { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x600119B")]
	public bool get_CanBeCanceled() { }

	[Address(RVA = "0x2096440", Offset = "0x2095840", Length = "0x31")]
	[Token(Token = "0x600119A")]
	public bool get_IsCancellationRequested() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001199")]
	public static CancellationToken get_None() { }

	[Address(RVA = "0x2095BA0", Offset = "0x2094FA0", Length = "0x79")]
	[Token(Token = "0x60011A6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2095C20", Offset = "0x2095020", Length = "0xA2")]
	[Token(Token = "0x60011A2")]
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, object state) { }

	[Address(RVA = "0x2096480", Offset = "0x2095880", Length = "0x52")]
	[Token(Token = "0x60011A7")]
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	[Address(RVA = "0x20964E0", Offset = "0x20958E0", Length = "0x52")]
	[Token(Token = "0x60011A8")]
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	[Address(RVA = "0x2096130", Offset = "0x2095530", Length = "0xA9")]
	[Token(Token = "0x60011A1")]
	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext) { }

	[Address(RVA = "0x2095FB0", Offset = "0x20953B0", Length = "0x17E")]
	[Token(Token = "0x60011A3")]
	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	[Address(RVA = "0x2095E90", Offset = "0x2095290", Length = "0x119")]
	[Token(Token = "0x600119F")]
	public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext) { }

	[Address(RVA = "0x2095CD0", Offset = "0x20950D0", Length = "0x10B")]
	[Token(Token = "0x600119E")]
	public CancellationTokenRegistration Register(Action callback) { }

	[Address(RVA = "0x2095DE0", Offset = "0x20951E0", Length = "0xA2")]
	[Token(Token = "0x60011A0")]
	public CancellationTokenRegistration Register(Action<Object> callback, object state) { }

	[Address(RVA = "0x20961E0", Offset = "0x20955E0", Length = "0x76")]
	[Token(Token = "0x60011A9")]
	public void ThrowIfCancellationRequested() { }

	[Address(RVA = "0x2096260", Offset = "0x2095660", Length = "0x58")]
	[Token(Token = "0x60011AA")]
	private void ThrowOperationCanceledException() { }

}

