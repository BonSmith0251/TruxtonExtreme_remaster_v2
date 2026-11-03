namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200020C")]
internal sealed class ContinuationQueue
{
	[Token(Token = "0x40005A8")]
	private const int MaxArrayLength = 2146435071; //Field offset: 0x0
	[Token(Token = "0x40005A9")]
	private const int InitialSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005AA")]
	private readonly PlayerLoopTiming timing; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005AB")]
	private SpinLock gate; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005AC")]
	private bool dequing; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40005AD")]
	private int actionListCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005AE")]
	private Action[] actionList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005AF")]
	private int waitingListCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B0")]
	private Action[] waitingList; //Field offset: 0x30

	[Address(RVA = "0x2786DA0", Offset = "0x27861A0", Length = "0xA3")]
	[Token(Token = "0x6000BD9")]
	public ContinuationQueue(PlayerLoopTiming timing) { }

	[Address(RVA = "0x2786750", Offset = "0x2785B50", Length = "0x97")]
	[Token(Token = "0x6000BDB")]
	public int Clear() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BDF")]
	private void EarlyUpdate() { }

	[Address(RVA = "0x2786800", Offset = "0x2785C00", Length = "0x27D")]
	[Token(Token = "0x6000BDA")]
	public void Enqueue(Action continuation) { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE1")]
	private void FixedUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BDD")]
	private void Initialization() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE0")]
	private void LastEarlyUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE2")]
	private void LastFixedUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BDE")]
	private void LastInitialization() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BEA")]
	private void LastPostLateUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE8")]
	private void LastPreLateUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE4")]
	private void LastPreUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BEC")]
	private void LastTimeUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE6")]
	private void LastUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE9")]
	private void PostLateUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE7")]
	private void PreLateUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE3")]
	private void PreUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BDC")]
	public void Run() { }

	[Address(RVA = "0x2786A80", Offset = "0x2785E80", Length = "0x314")]
	[DebuggerHidden]
	[Token(Token = "0x6000BED")]
	private void RunCore() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BEB")]
	private void TimeUpdate() { }

	[Address(RVA = "0x27867F0", Offset = "0x2785BF0", Length = "0x7")]
	[Token(Token = "0x6000BE5")]
	private void Update() { }

}

