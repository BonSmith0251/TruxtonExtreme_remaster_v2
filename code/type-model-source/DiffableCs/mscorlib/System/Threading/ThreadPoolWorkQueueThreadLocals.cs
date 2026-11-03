namespace System.Threading;

[Token(Token = "0x200023D")]
internal sealed class ThreadPoolWorkQueueThreadLocals
{
	[ThreadStatic]
	[Token(Token = "0x4000A43")]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A44")]
	public readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A45")]
	public readonly WorkStealingQueue workStealingQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A46")]
	public readonly Random random; //Field offset: 0x20

	[Address(RVA = "0x20C0D60", Offset = "0x20C0160", Length = "0x1FF")]
	[Token(Token = "0x6001316")]
	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq) { }

	[Address(RVA = "0x20C0BD0", Offset = "0x20BFFD0", Length = "0xF5")]
	[Token(Token = "0x6001317")]
	private void CleanUp() { }

	[Address(RVA = "0x20C0CD0", Offset = "0x20C00D0", Length = "0x83")]
	[Token(Token = "0x6001318")]
	protected virtual void Finalize() { }

}

