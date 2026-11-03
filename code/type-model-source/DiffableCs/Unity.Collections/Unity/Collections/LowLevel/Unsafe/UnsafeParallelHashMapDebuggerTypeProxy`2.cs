namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200012E")]
internal sealed class UnsafeParallelHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000503")]
	private UnsafeParallelHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	[Token(Token = "0x1700017E")]
	public List<Pair`2<TKey, TValue>> Items
	{
		[Address(RVA = "0x11D4130", Offset = "0x11D3530", Length = "0x3F3")]
		[Token(Token = "0x6000C89")]
		 get { } //Length: 1011
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000C88")]
	public UnsafeParallelHashMapDebuggerTypeProxy`2(UnsafeParallelHashMap<TKey, TValue> target) { }

	[Address(RVA = "0x11D4130", Offset = "0x11D3530", Length = "0x3F3")]
	[Token(Token = "0x6000C89")]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

