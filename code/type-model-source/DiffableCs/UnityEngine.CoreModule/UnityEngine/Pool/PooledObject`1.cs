namespace UnityEngine.Pool;

[Token(Token = "0x2000304")]
public struct PooledObject : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F9")]
	private readonly T m_ToReturn; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007FA")]
	private readonly IObjectPool<T> m_Pool; //Field offset: 0x0

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x60018AB")]
	public PooledObject`1(T value, IObjectPool<T> pool) { }

	[Address(RVA = "0xE28B50", Offset = "0xE27F50", Length = "0xC9")]
	[Token(Token = "0x60018AC")]
	private override void System.IDisposable.Dispose() { }

}

