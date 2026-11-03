namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000247")]
public enum XPackageChunkAvailability : uint
{
	Ready = 0,
	Pending = 1,
	Installable = 2,
	Unavailable = 3,
}

