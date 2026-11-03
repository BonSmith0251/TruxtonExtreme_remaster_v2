namespace Newtonsoft.Json;

[NullableContext(1)]
[Token(Token = "0x2000015")]
public interface IArrayPool
{

	[Token(Token = "0x6000015")]
	public T[] Rent(int minimumLength) { }

	[Token(Token = "0x6000016")]
	public void Return(T[] array) { }

}

