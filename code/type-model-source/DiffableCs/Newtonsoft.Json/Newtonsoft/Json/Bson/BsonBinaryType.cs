namespace Newtonsoft.Json.Bson;

[Token(Token = "0x20001D4")]
internal enum BsonBinaryType : byte
{
	Binary = 0,
	Function = 1,
	BinaryOld = 2,
	UuidOld = 3,
	Uuid = 4,
	Md5 = 5,
	UserDefined = 128,
}

