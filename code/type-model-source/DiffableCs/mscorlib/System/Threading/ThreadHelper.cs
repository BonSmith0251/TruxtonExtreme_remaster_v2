namespace System.Threading;

[Token(Token = "0x2000230")]
internal class ThreadHelper
{
	[Token(Token = "0x4000A1D")]
	internal static ContextCallback _ccb; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A1A")]
	private Delegate _start; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A1B")]
	private object _startArg; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A1C")]
	private ExecutionContext _executionContext; //Field offset: 0x20

	[Address(RVA = "0x20A6260", Offset = "0x20A5660", Length = "0x89")]
	[Token(Token = "0x60012B9")]
	private static ThreadHelper() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60012B4")]
	internal ThreadHelper(Delegate start) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60012B5")]
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	[Address(RVA = "0x20A6030", Offset = "0x20A5430", Length = "0x11A")]
	[Token(Token = "0x60012B7")]
	internal void ThreadStart(object obj) { }

	[Address(RVA = "0x20A6150", Offset = "0x20A5550", Length = "0x100")]
	[Token(Token = "0x60012B8")]
	internal void ThreadStart() { }

	[Address(RVA = "0x20A5F10", Offset = "0x20A5310", Length = "0x11C")]
	[Token(Token = "0x60012B6")]
	private static void ThreadStart_Context(object state) { }

}

