namespace Unity.Collections;

[Token(Token = "0x2000093")]
internal sealed class NativeHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BB")]
	private HashMapHelper<TKey>* Data; //Field offset: 0x0

	[Token(Token = "0x170000C0")]
	public List<Pair`2<TKey, TValue>> Items
	{
		[Address(RVA = "0xD69AA0", Offset = "0xD68EA0", Length = "0x419")]
		[Token(Token = "0x6000757")]
		 get { } //Length: 1049
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000755")]
	public NativeHashMapDebuggerTypeProxy`2(NativeHashMap<TKey, TValue> target) { }

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000756")]
	public NativeHashMapDebuggerTypeProxy`2(ReadOnly<TKey, TValue> target) { }

	[Address(RVA = "0xD69AA0", Offset = "0xD68EA0", Length = "0x419")]
	[Token(Token = "0x6000757")]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

