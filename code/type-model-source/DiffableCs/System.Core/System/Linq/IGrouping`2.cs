namespace System.Linq;

[Token(Token = "0x2000032")]
public interface IGrouping : IEnumerable<TElement>, IEnumerable
{

	[Token(Token = "0x17000028")]
	public TKey Key
	{
		[Token(Token = "0x600013F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600013F")]
	public TKey get_Key() { }

}

