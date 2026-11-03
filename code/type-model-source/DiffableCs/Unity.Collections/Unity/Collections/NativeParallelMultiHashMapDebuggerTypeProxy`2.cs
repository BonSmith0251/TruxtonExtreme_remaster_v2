namespace Unity.Collections;

[Token(Token = "0x20000B3")]
internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DD")]
	private NativeParallelMultiHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	[Token(Token = "0x170000FC")]
	public List<ListPair`2<TKey, List`1<TValue>>> Items
	{
		[Address(RVA = "0xD8E160", Offset = "0xD8D560", Length = "0x886")]
		[Token(Token = "0x60008B7")]
		 get { } //Length: 2182
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x60008B6")]
	public NativeParallelMultiHashMapDebuggerTypeProxy`2(NativeParallelMultiHashMap<TKey, TValue> target) { }

	[Address(RVA = "0xD8E160", Offset = "0xD8D560", Length = "0x886")]
	[Token(Token = "0x60008B7")]
	public List<ListPair`2<TKey, List`1<TValue>>> get_Items() { }

}

