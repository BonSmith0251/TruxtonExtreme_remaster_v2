namespace UnityEngine.Pool;

[Token(Token = "0x2000301")]
public interface IObjectPool
{

	[Token(Token = "0x60018A1")]
	public void Release(T element) { }

}

