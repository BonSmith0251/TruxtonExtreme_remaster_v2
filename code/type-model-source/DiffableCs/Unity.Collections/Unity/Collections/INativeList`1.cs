namespace Unity.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000099")]
public interface INativeList : IIndexable<T>
{

	[Token(Token = "0x170000CD")]
	public int Capacity
	{
		[Token(Token = "0x6000781")]
		 get { } //Length: 0
		[Token(Token = "0x6000782")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000CE")]
	public bool IsEmpty
	{
		[Token(Token = "0x6000783")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000CF")]
	public T Item
	{
		[Token(Token = "0x6000784")]
		 get { } //Length: 0
		[Token(Token = "0x6000785")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000786")]
	public void Clear() { }

	[Token(Token = "0x6000781")]
	public int get_Capacity() { }

	[Token(Token = "0x6000783")]
	public bool get_IsEmpty() { }

	[Token(Token = "0x6000784")]
	public T get_Item(int index) { }

	[Token(Token = "0x6000782")]
	public void set_Capacity(int value) { }

	[Token(Token = "0x6000785")]
	public void set_Item(int index, T value) { }

}

