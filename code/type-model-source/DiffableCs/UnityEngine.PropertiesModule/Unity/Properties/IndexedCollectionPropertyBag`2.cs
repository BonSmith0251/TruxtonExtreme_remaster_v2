namespace Unity.Properties;

[Token(Token = "0x200002D")]
public class IndexedCollectionPropertyBag : PropertyBag<TList>, IListPropertyBag<TList, TElement>, ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>, IConstructorWithCount<TList>, IConstructor, IIndexedCollectionPropertyBagEnumerator<TList>
{
	[Token(Token = "0x200002E")]
	private class ListElementProperty : Property<TList, TElement>, IListElementProperty
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		internal int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		internal bool m_IsReadOnly; //Field offset: 0x0

		[Token(Token = "0x17000025")]
		public override int Index
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x60000B4")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000027")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
			[Token(Token = "0x60000B6")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000026")]
		public virtual string Name
		{
			[Address(RVA = "0xB0B7B0", Offset = "0xB0ABB0", Length = "0x21")]
			[Token(Token = "0x60000B5")]
			 get { } //Length: 33
		}

		[Address(RVA = "0xB0B780", Offset = "0xB0AB80", Length = "0x14")]
		[Token(Token = "0x60000B9")]
		public ListElementProperty() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60000B4")]
		public override int get_Index() { }

		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x60000B6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xB0B7B0", Offset = "0xB0ABB0", Length = "0x21")]
		[Token(Token = "0x60000B5")]
		public virtual string get_Name() { }

		[Address(RVA = "0xB0B0C0", Offset = "0xB0A4C0", Length = "0xB8")]
		[Token(Token = "0x60000B7")]
		public virtual TElement GetValue(ref TList container) { }

		[Address(RVA = "0xB0B380", Offset = "0xB0A780", Length = "0xC7")]
		[Token(Token = "0x60000B8")]
		public virtual void SetValue(ref TList container, TElement value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	private readonly ListElementProperty<TList, TElement> m_Property; //Field offset: 0x0

	[Address(RVA = "0x1C79A30", Offset = "0x1C78E30", Length = "0xC4")]
	[Token(Token = "0x60000B3")]
	public IndexedCollectionPropertyBag`2() { }

	[Address(RVA = "0x1C79020", Offset = "0x1C78420", Length = "0x8F")]
	[Token(Token = "0x60000A7")]
	public virtual PropertyCollection<TList> GetProperties() { }

	[Address(RVA = "0x1C790B0", Offset = "0x1C784B0", Length = "0xBC")]
	[Token(Token = "0x60000A8")]
	public virtual PropertyCollection<TList> GetProperties(ref TList container) { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x60000AE")]
	protected override TList InstantiateWithCount(int count) { }

	[Address(RVA = "0x1C79610", Offset = "0x1C78A10", Length = "0xE4")]
	[Token(Token = "0x60000A9")]
	public override bool TryGetProperty(ref TList container, int index, out IProperty<TList>& property) { }

	[Address(RVA = "0x1C79700", Offset = "0x1C78B00", Length = "0x2F")]
	[Token(Token = "0x60000AA")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container) { }

	[Address(RVA = "0x1C79830", Offset = "0x1C78C30", Length = "0x14")]
	[Token(Token = "0x60000AD")]
	private override TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	[Address(RVA = "0x1C79920", Offset = "0x1C78D20", Length = "0x4D")]
	[Token(Token = "0x60000AF")]
	private override int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container) { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x60000B0")]
	private override IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty() { }

	[Address(RVA = "0x1C79970", Offset = "0x1C78D70", Length = "0x4C")]
	[Token(Token = "0x60000B1")]
	private override IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState() { }

	[Address(RVA = "0x1C799C0", Offset = "0x1C78DC0", Length = "0x2A")]
	[Token(Token = "0x60000B2")]
	private override void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

	[Address(RVA = "0x69AB50", Offset = "0x699F50", Length = "0x154")]
	[Token(Token = "0x60000AC")]
	private override void Unity.Properties.IListPropertyAccept<TList>.Accept(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	[Address(RVA = "0x1C799F0", Offset = "0x1C78DF0", Length = "0x32")]
	[Token(Token = "0x60000AB")]
	private override void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list) { }

}

