namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000402")]
internal enum BinaryArrayTypeEnum : int
{
	Single = 0,
	Jagged = 1,
	Rectangular = 2,
	SingleOffset = 3,
	JaggedOffset = 4,
	RectangularOffset = 5,
}

