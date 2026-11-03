namespace System.Linq;

[DefaultMember("Item")]
[Token(Token = "0x2000033")]
public interface ILookup : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
{

	[Token(Token = "0x17000029")]
	public IEnumerable<TElement> Item
	{
		[Token(Token = "0x6000140")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000140")]
	public IEnumerable<TElement> get_Item(TKey key) { }

}

