namespace UnityEngine.UIElements;

[Token(Token = "0x2000095")]
public interface IBindable
{

	[Token(Token = "0x170000E6")]
	public IBinding binding
	{
		[Token(Token = "0x600059B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000E7")]
	public string bindingPath
	{
		[Token(Token = "0x600059C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x600059B")]
	public IBinding get_binding() { }

	[Token(Token = "0x600059C")]
	public void set_bindingPath(string value) { }

}

