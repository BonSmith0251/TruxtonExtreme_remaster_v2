namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000105")]
public struct UniTaskCompletionSourceCore
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C5")]
	private TResult result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C6")]
	private object error; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C7")]
	private short version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C8")]
	private bool hasUnhandledError; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C9")]
	private int completedCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CA")]
	private Action<Object> continuation; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CB")]
	private object continuationState; //Field offset: 0x0

	[DebuggerHidden]
	[Token(Token = "0x17000048")]
	public short Version
	{
		[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
		[Token(Token = "0x6000655")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
	[Token(Token = "0x6000655")]
	public short get_Version() { }

	[Address(RVA = "0x10EFA60", Offset = "0x10EEE60", Length = "0x1D7")]
	[DebuggerHidden]
	[Token(Token = "0x6000658")]
	public TResult GetResult(short token) { }

	[Address(RVA = "0x1119510", Offset = "0x1118910", Length = "0x12E")]
	[DebuggerHidden]
	[Token(Token = "0x6000656")]
	public UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x1119B20", Offset = "0x1118F20", Length = "0x5")]
	[Token(Token = "0x6000651")]
	internal void MarkHandled() { }

	[Address(RVA = "0x1119EB0", Offset = "0x11192B0", Length = "0x1B2")]
	[DebuggerHidden]
	[Token(Token = "0x6000659")]
	public void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x111A500", Offset = "0x1119900", Length = "0x108")]
	[Token(Token = "0x6000650")]
	private void ReportUnhandledError() { }

	[Address(RVA = "0x111A9C0", Offset = "0x1119DC0", Length = "0x84")]
	[DebuggerHidden]
	[Token(Token = "0x600064F")]
	public void Reset() { }

	[Address(RVA = "0x111B010", Offset = "0x111A410", Length = "0x101")]
	[DebuggerHidden]
	[Token(Token = "0x6000654")]
	public bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x111B120", Offset = "0x111A520", Length = "0x14D")]
	[DebuggerHidden]
	[Token(Token = "0x6000653")]
	public bool TrySetException(Exception error) { }

	[Address(RVA = "0x111B930", Offset = "0x111AD30", Length = "0xC7")]
	[DebuggerHidden]
	[Token(Token = "0x6000652")]
	public bool TrySetResult(TResult result) { }

	[Address(RVA = "0x111BD60", Offset = "0x111B160", Length = "0x91")]
	[DebuggerHidden]
	[Token(Token = "0x6000657")]
	public UniTaskStatus UnsafeGetStatus() { }

	[Address(RVA = "0x111BF60", Offset = "0x111B360", Length = "0x5B")]
	[DebuggerHidden]
	[Token(Token = "0x600065A")]
	private void ValidateToken(short token) { }

}

