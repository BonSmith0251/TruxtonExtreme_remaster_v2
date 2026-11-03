namespace System.Data;

[Token(Token = "0x200009A")]
public enum XmlReadMode : int
{
	Auto = 0,
	ReadSchema = 1,
	IgnoreSchema = 2,
	InferSchema = 3,
	DiffGram = 4,
	Fragment = 5,
	InferTypedSchema = 6,
}

