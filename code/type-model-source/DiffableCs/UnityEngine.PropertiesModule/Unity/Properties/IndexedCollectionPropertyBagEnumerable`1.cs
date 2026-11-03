namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000029")]
internal struct IndexedCollectionPropertyBagEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000045")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000046")]
	private readonly TContainer m_Container; //Field offset: 0x0

	[Address(RVA = "0xAEE690", Offset = "0xAEDA90", Length = "0x27")]
	[Token(Token = "0x600009B")]
	public IndexedCollectionPropertyBagEnumerable`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[Address(RVA = "0x1C751E0", Offset = "0x1C745E0", Length = "0xC7")]
	[Token(Token = "0x600009C")]
	public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator() { }

}

