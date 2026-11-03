namespace KANAI.MVPSystem;

[Token(Token = "0x2000010")]
public interface IPresenterValue
{

	[Token(Token = "0x6000066")]
	public string GetString() { }

	[Token(Token = "0x6000065")]
	public int GetValue(int n) { }

}

