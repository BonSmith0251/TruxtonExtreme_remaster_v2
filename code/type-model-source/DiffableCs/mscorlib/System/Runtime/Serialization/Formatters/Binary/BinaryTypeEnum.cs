namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000401")]
internal enum BinaryTypeEnum : int
{
	Primitive = 0,
	String = 1,
	Object = 2,
	ObjectUrt = 3,
	ObjectUser = 4,
	ObjectArray = 5,
	StringArray = 6,
	PrimitiveArray = 7,
}

