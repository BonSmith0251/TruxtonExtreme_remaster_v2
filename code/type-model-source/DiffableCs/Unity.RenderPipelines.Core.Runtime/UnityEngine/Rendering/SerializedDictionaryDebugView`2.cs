namespace UnityEngine.Rendering;

[Token(Token = "0x2000066")]
internal sealed class SerializedDictionaryDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	private IDictionary<K, V> dict; //Field offset: 0x0

	[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
	[Token(Token = "0x17000048")]
	public KeyValuePair<K, V>[] Items
	{
		[Address(RVA = "0xF59CC0", Offset = "0xF590C0", Length = "0x1B4")]
		[Token(Token = "0x600056F")]
		 get { } //Length: 436
	}

	[Address(RVA = "0xF59C30", Offset = "0xF59030", Length = "0x89")]
	[Token(Token = "0x600056E")]
	public SerializedDictionaryDebugView`2(IDictionary<K, V> dictionary) { }

	[Address(RVA = "0xF59CC0", Offset = "0xF590C0", Length = "0x1B4")]
	[Token(Token = "0x600056F")]
	public KeyValuePair<K, V>[] get_Items() { }

}

