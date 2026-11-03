namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000F4")]
internal class ThreadSafeStore
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D8")]
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D9")]
	private readonly Func<TKey, TValue> _creator; //Field offset: 0x0

	[Address(RVA = "0x1084CD0", Offset = "0x10840D0", Length = "0xC1")]
	[Token(Token = "0x600071E")]
	public ThreadSafeStore`2(Func<TKey, TValue> creator) { }

	[Address(RVA = "0x1084BC0", Offset = "0x1083FC0", Length = "0x3F")]
	[Token(Token = "0x600071F")]
	public TValue Get(TKey key) { }

}

