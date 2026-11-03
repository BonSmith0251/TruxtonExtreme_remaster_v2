namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000187")]
public enum XblWriteSessionStatus : int
{
	Unknown = 0,
	AccessDenied = 1,
	Created = 2,
	Conflict = 3,
	HandleNotFound = 4,
	OutOfSync = 5,
	SessionDeleted = 6,
	Updated = 7,
}

