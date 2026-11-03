namespace System.Collections;

[Token(Token = "0x20005A7")]
public interface IEnumerator
{

	[Token(Token = "0x1700061C")]
	public object Current
	{
		[Token(Token = "0x6002954")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002954")]
	public object get_Current() { }

	[Token(Token = "0x6002953")]
	public bool MoveNext() { }

	[Token(Token = "0x6002955")]
	public void Reset() { }

}

