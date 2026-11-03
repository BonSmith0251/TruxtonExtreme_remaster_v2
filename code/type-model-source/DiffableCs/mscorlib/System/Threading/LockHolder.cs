namespace System.Threading;

[ReflectionBlocked]
[Token(Token = "0x2000214")]
public struct LockHolder : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009CB")]
	private Lock _lock; //Field offset: 0x0

	[Address(RVA = "0x209FC50", Offset = "0x209F050", Length = "0x1E")]
	[Token(Token = "0x600120C")]
	public override void Dispose() { }

	[Address(RVA = "0x209FC70", Offset = "0x209F070", Length = "0x42")]
	[Token(Token = "0x600120B")]
	public static LockHolder Hold(Lock l) { }

}

