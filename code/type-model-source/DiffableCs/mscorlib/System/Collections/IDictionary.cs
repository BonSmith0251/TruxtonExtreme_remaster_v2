namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x20005A4")]
public interface IDictionary : ICollection, IEnumerable
{

	[Token(Token = "0x17000618")]
	public bool IsFixedSize
	{
		[Token(Token = "0x600294C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000617")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600294B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000614")]
	public object Item
	{
		[Token(Token = "0x6002944")]
		 get { } //Length: 0
		[Token(Token = "0x6002945")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000615")]
	public ICollection Keys
	{
		[Token(Token = "0x6002946")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000616")]
	public ICollection Values
	{
		[Token(Token = "0x6002947")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002949")]
	public void Add(object key, object value) { }

	[Token(Token = "0x600294A")]
	public void Clear() { }

	[Token(Token = "0x6002948")]
	public bool Contains(object key) { }

	[Token(Token = "0x600294C")]
	public bool get_IsFixedSize() { }

	[Token(Token = "0x600294B")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x6002944")]
	public object get_Item(object key) { }

	[Token(Token = "0x6002946")]
	public ICollection get_Keys() { }

	[Token(Token = "0x6002947")]
	public ICollection get_Values() { }

	[Token(Token = "0x600294D")]
	public IDictionaryEnumerator GetEnumerator() { }

	[Token(Token = "0x600294E")]
	public void Remove(object key) { }

	[Token(Token = "0x6002945")]
	public void set_Item(object key, object value) { }

}

