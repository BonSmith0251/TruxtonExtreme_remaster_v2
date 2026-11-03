namespace Unity.Collections;

[Token(Token = "0x20000A5")]
internal sealed class NativeParallelHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CB")]
	private UnsafeParallelHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	[Token(Token = "0x170000E5")]
	public List<Pair`2<TKey, TValue>> Items
	{
		[Address(RVA = "0xD89270", Offset = "0xD88670", Length = "0x402")]
		[Token(Token = "0x6000809")]
		 get { } //Length: 1026
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000807")]
	public NativeParallelHashMapDebuggerTypeProxy`2(NativeParallelHashMap<TKey, TValue> target) { }

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000808")]
	internal NativeParallelHashMapDebuggerTypeProxy`2(ReadOnly<TKey, TValue> target) { }

	[Address(RVA = "0xD89270", Offset = "0xD88670", Length = "0x402")]
	[Token(Token = "0x6000809")]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

