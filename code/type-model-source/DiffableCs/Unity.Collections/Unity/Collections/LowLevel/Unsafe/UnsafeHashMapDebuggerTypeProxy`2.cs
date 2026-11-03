namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200010E")]
internal sealed class UnsafeHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004BB")]
	private HashMapHelper<TKey> Data; //Field offset: 0x0

	[Token(Token = "0x1700014F")]
	public List<Pair`2<TKey, TValue>> Items
	{
		[Address(RVA = "0xD89270", Offset = "0xD88670", Length = "0x402")]
		[Token(Token = "0x6000B81")]
		 get { } //Length: 1026
	}

	[Address(RVA = "0x11A5B80", Offset = "0x11A4F80", Length = "0x41")]
	[Token(Token = "0x6000B7F")]
	public UnsafeHashMapDebuggerTypeProxy`2(UnsafeHashMap<TKey, TValue> target) { }

	[Address(RVA = "0x11A5B80", Offset = "0x11A4F80", Length = "0x41")]
	[Token(Token = "0x6000B80")]
	public UnsafeHashMapDebuggerTypeProxy`2(ReadOnly<TKey, TValue> target) { }

	[Address(RVA = "0xD89270", Offset = "0xD88670", Length = "0x402")]
	[Token(Token = "0x6000B81")]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

