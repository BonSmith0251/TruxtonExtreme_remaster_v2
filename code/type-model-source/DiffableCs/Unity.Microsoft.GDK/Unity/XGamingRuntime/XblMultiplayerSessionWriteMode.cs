namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000184")]
public enum XblMultiplayerSessionWriteMode : int
{
	CreateNew = 0,
	UpdateOrCreateNew = 1,
	UpdateExisting = 2,
	SynchronizedUpdate = 3,
}

