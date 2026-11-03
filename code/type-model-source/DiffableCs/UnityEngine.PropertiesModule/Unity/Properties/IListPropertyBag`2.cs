namespace Unity.Properties;

[Token(Token = "0x2000035")]
public interface IListPropertyBag : ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>
{

}

