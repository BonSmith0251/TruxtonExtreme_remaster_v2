namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005FA")]
public interface IReadOnlyDictionary : IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	[Token(Token = "0x17000715")]
	public TValue Item
	{
		[Token(Token = "0x6002C9C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000716")]
	public IEnumerable<TKey> Keys
	{
		[Token(Token = "0x6002C9D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000717")]
	public IEnumerable<TValue> Values
	{
		[Token(Token = "0x6002C9E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C9A")]
	public bool ContainsKey(TKey key) { }

	[Token(Token = "0x6002C9C")]
	public TValue get_Item(TKey key) { }

	[Token(Token = "0x6002C9D")]
	public IEnumerable<TKey> get_Keys() { }

	[Token(Token = "0x6002C9E")]
	public IEnumerable<TValue> get_Values() { }

	[Token(Token = "0x6002C9B")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

