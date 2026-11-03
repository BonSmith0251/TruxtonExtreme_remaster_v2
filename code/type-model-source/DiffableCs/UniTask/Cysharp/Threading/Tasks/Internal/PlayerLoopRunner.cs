namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000211")]
internal sealed class PlayerLoopRunner
{
	[CompilerGenerated]
	[Token(Token = "0x2000212")]
	private sealed class <>c
	{
		[Token(Token = "0x40005C7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40005C8")]
		public static Action<Exception> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x278D450", Offset = "0x278C850", Length = "0x67")]
		[Token(Token = "0x6000C23")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C24")]
		public <>c() { }

		[Address(RVA = "0x278CFA0", Offset = "0x278C3A0", Length = "0x49")]
		[Token(Token = "0x6000C25")]
		internal void <.ctor>b__9_0(Exception ex) { }

	}

	[Token(Token = "0x40005BE")]
	private const int InitialSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BF")]
	private readonly PlayerLoopTiming timing; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005C0")]
	private readonly object runningAndQueueLock; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C1")]
	private readonly object arrayLock; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C2")]
	private readonly Action<Exception> unhandledExceptionCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C3")]
	private int tail; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40005C4")]
	private bool running; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C5")]
	private IPlayerLoopItem[] loopItems; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C6")]
	private MinimumQueue<IPlayerLoopItem> waitQueue; //Field offset: 0x40

	[Address(RVA = "0x2789C60", Offset = "0x2789060", Length = "0x1EF")]
	[Token(Token = "0x6000C0E")]
	public PlayerLoopRunner(PlayerLoopTiming timing) { }

	[Address(RVA = "0x2789120", Offset = "0x2788520", Length = "0x318")]
	[Token(Token = "0x6000C0F")]
	public void AddAction(IPlayerLoopItem item) { }

	[Address(RVA = "0x2789440", Offset = "0x2788840", Length = "0x133")]
	[Token(Token = "0x6000C10")]
	public int Clear() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C14")]
	private void EarlyUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C16")]
	private void FixedUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C12")]
	private void Initialization() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C15")]
	private void LastEarlyUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C17")]
	private void LastFixedUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C13")]
	private void LastInitialization() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1F")]
	private void LastPostLateUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1D")]
	private void LastPreLateUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C19")]
	private void LastPreUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C21")]
	private void LastTimeUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1B")]
	private void LastUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1E")]
	private void PostLateUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1C")]
	private void PreLateUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C18")]
	private void PreUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C11")]
	public void Run() { }

	[Address(RVA = "0x2789590", Offset = "0x2788990", Length = "0x6C3")]
	[DebuggerHidden]
	[Token(Token = "0x6000C22")]
	private void RunCore() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C20")]
	private void TimeUpdate() { }

	[Address(RVA = "0x2789580", Offset = "0x2788980", Length = "0x7")]
	[Token(Token = "0x6000C1A")]
	private void Update() { }

}

