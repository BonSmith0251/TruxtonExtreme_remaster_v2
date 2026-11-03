namespace System.Net.Sockets;

[Token(Token = "0x2000313")]
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	[Token(Token = "0x4000E30")]
	private const int SOCKET_CLOSED = 10004; //Field offset: 0x0
	[Token(Token = "0x4000E31")]
	private const int ABORT_RETRIES = 10; //Field offset: 0x0
	[Token(Token = "0x4000E32")]
	private static bool THROW_ON_ABORT_RETRIES; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E2D")]
	private List<Thread> blocking_threads; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E2E")]
	private Dictionary<Thread, StackTrace> threads_stacktraces; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E2F")]
	private bool in_cleanup; //Field offset: 0x30

	[Address(RVA = "0x25E2430", Offset = "0x25E1830", Length = "0x6D")]
	[Token(Token = "0x600148B")]
	private static SafeSocketHandle() { }

	[Address(RVA = "0x25E24B0", Offset = "0x25E18B0", Length = "0xC8")]
	[Token(Token = "0x6001486")]
	public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[Address(RVA = "0x25E24A0", Offset = "0x25E18A0", Length = "0xA")]
	[Token(Token = "0x6001487")]
	internal SafeSocketHandle() { }

	[Address(RVA = "0x25E1BF0", Offset = "0x25E0FF0", Length = "0x141")]
	[Token(Token = "0x6001489")]
	public void RegisterForBlockingSyscall() { }

	[Address(RVA = "0x25E1D40", Offset = "0x25E1140", Length = "0x54C")]
	[Token(Token = "0x6001488")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x25E2290", Offset = "0x25E1690", Length = "0x198")]
	[Token(Token = "0x600148A")]
	public void UnRegisterForBlockingSyscall() { }

}

