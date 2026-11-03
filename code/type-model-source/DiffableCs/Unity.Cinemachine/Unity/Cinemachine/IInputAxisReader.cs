namespace Unity.Cinemachine;

[Token(Token = "0x20000C5")]
public interface IInputAxisReader
{

	[Token(Token = "0x60003BD")]
	public float GetValue(object context, Hints hint) { }

}

