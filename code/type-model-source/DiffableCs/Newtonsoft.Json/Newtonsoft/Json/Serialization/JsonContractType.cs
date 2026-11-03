namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000114")]
internal enum JsonContractType : int
{
	None = 0,
	Object = 1,
	Array = 2,
	Primitive = 3,
	String = 4,
	Dictionary = 5,
	Dynamic = 6,
	Serializable = 7,
	Linq = 8,
}

