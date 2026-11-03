namespace Unity.Properties;

[Token(Token = "0x200002A")]
internal struct IndexedCollectionPropertyBagEnumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000047")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	private readonly IndexedCollectionSharedPropertyState m_Previous; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000049")]
	private TContainer m_Container; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004A")]
	private int m_Position; //Field offset: 0x0

	[Token(Token = "0x17000023")]
	public override IProperty<TContainer> Current
	{
		[Address(RVA = "0x1C78F20", Offset = "0x1C78320", Length = "0x58")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000024")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x1C77FB0", Offset = "0x1C773B0", Length = "0x7B")]
		[Token(Token = "0x600009F")]
		private get { } //Length: 123
	}

	[Address(RVA = "0x1C781A0", Offset = "0x1C775A0", Length = "0x96")]
	[Token(Token = "0x600009D")]
	internal IndexedCollectionPropertyBagEnumerator`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000A2")]
	public override void Dispose() { }

	[Address(RVA = "0x1C78F20", Offset = "0x1C78320", Length = "0x58")]
	[Token(Token = "0x600009E")]
	public override IProperty<TContainer> get_Current() { }

	[Address(RVA = "0x1C765E0", Offset = "0x1C759E0", Length = "0x1BF")]
	[Token(Token = "0x60000A0")]
	public override bool MoveNext() { }

	[Address(RVA = "0x1C77C40", Offset = "0x1C77040", Length = "0x6F")]
	[Token(Token = "0x60000A1")]
	public override void Reset() { }

	[Address(RVA = "0x1C77FB0", Offset = "0x1C773B0", Length = "0x7B")]
	[Token(Token = "0x600009F")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

