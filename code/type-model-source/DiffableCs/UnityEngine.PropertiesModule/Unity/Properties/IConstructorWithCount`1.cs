namespace Unity.Properties;

[Token(Token = "0x2000065")]
internal interface IConstructorWithCount : IConstructor
{

	[Token(Token = "0x6000238")]
	public T InstantiateWithCount(int count) { }

}

