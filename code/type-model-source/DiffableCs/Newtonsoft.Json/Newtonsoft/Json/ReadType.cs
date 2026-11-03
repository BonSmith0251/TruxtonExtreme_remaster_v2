namespace Newtonsoft.Json;

[Token(Token = "0x200005C")]
internal enum ReadType : int
{
	Read = 0,
	ReadAsInt32 = 1,
	ReadAsInt64 = 2,
	ReadAsBytes = 3,
	ReadAsString = 4,
	ReadAsDecimal = 5,
	ReadAsDateTime = 6,
	ReadAsDateTimeOffset = 7,
	ReadAsDouble = 8,
	ReadAsBoolean = 9,
}

