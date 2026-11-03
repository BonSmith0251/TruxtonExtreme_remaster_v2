namespace Unity.Properties;

[Token(Token = "0x200002B")]
internal interface IIndexedCollectionPropertyBagEnumerator
{

	[Token(Token = "0x60000A3")]
	public int GetCount(ref TContainer container) { }

	[Token(Token = "0x60000A4")]
	public IProperty<TContainer> GetSharedProperty() { }

	[Token(Token = "0x60000A5")]
	public IndexedCollectionSharedPropertyState GetSharedPropertyState() { }

	[Token(Token = "0x60000A6")]
	public void SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

}

