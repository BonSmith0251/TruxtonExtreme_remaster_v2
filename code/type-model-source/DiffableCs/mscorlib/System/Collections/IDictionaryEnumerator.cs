namespace System.Collections;

[Token(Token = "0x20005A5")]
public interface IDictionaryEnumerator : IEnumerator
{

	[Token(Token = "0x1700061B")]
	public DictionaryEntry Entry
	{
		[Token(Token = "0x6002951")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000619")]
	public object Key
	{
		[Token(Token = "0x600294F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700061A")]
	public object Value
	{
		[Token(Token = "0x6002950")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002951")]
	public DictionaryEntry get_Entry() { }

	[Token(Token = "0x600294F")]
	public object get_Key() { }

	[Token(Token = "0x6002950")]
	public object get_Value() { }

}

