namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x20005A9")]
public interface IList : ICollection, IEnumerable
{

	[Token(Token = "0x1700061F")]
	public bool IsFixedSize
	{
		[Token(Token = "0x600295E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700061E")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600295D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700061D")]
	public object Item
	{
		[Token(Token = "0x6002958")]
		 get { } //Length: 0
		[Token(Token = "0x6002959")]
		 set { } //Length: 0
	}

	[Token(Token = "0x600295A")]
	public int Add(object value) { }

	[Token(Token = "0x600295C")]
	public void Clear() { }

	[Token(Token = "0x600295B")]
	public bool Contains(object value) { }

	[Token(Token = "0x600295E")]
	public bool get_IsFixedSize() { }

	[Token(Token = "0x600295D")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x6002958")]
	public object get_Item(int index) { }

	[Token(Token = "0x600295F")]
	public int IndexOf(object value) { }

	[Token(Token = "0x6002960")]
	public void Insert(int index, object value) { }

	[Token(Token = "0x6002961")]
	public void Remove(object value) { }

	[Token(Token = "0x6002962")]
	public void RemoveAt(int index) { }

	[Token(Token = "0x6002959")]
	public void set_Item(int index, object value) { }

}

