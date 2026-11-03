namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000155")]
public enum XblErrorCondition : uint
{
	NoError = 0,
	GenericError = 1,
	GenericOutOfRange = 2,
	Auth = 3,
	Network = 4,
	HttpGeneric = 5,
	Http304NotModified = 6,
	Http404NotFound = 7,
	Http412PreconditionFailed = 8,
	Http429TooManyRequests = 9,
	HttpServiceTimeout = 10,
	Rta = 11,
}

