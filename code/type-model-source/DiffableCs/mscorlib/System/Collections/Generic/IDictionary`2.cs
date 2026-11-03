namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005F1")]
public interface IDictionary : ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	[Token(Token = "0x1700070F")]
	public TValue Item
	{
		[Token(Token = "0x6002C88")]
		 get { } //Length: 0
		[Token(Token = "0x6002C89")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000710")]
	public ICollection<TKey> Keys
	{
		[Token(Token = "0x6002C8A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000711")]
	public ICollection<TValue> Values
	{
		[Token(Token = "0x6002C8B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C8D")]
	public void Add(TKey key, TValue value) { }

	[Token(Token = "0x6002C8C")]
	public bool ContainsKey(TKey key) { }

	[Token(Token = "0x6002C88")]
	public TValue get_Item(TKey key) { }

	[Token(Token = "0x6002C8A")]
	public ICollection<TKey> get_Keys() { }

	[Token(Token = "0x6002C8B")]
	public ICollection<TValue> get_Values() { }

	[Token(Token = "0x6002C8E")]
	public bool Remove(TKey key) { }

	[Token(Token = "0x6002C89")]
	public void set_Item(TKey key, TValue value) { }

	[Token(Token = "0x6002C8F")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

