namespace Unity.Collections;

[Token(Token = "0x2000098")]
public interface IIndexable
{

	[Token(Token = "0x170000CC")]
	public int Length
	{
		[Token(Token = "0x600077E")]
		 get { } //Length: 0
		[Token(Token = "0x600077F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000780")]
	public T ElementAt(int index) { }

	[Token(Token = "0x600077E")]
	public int get_Length() { }

	[Token(Token = "0x600077F")]
	public void set_Length(int value) { }

}

