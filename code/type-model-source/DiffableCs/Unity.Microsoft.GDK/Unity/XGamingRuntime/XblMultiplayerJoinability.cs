namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000193")]
public enum XblMultiplayerJoinability : uint
{
	None = 0,
	JoinableByFriends = 1,
	InviteOnly = 2,
	DisableWhileGameInProgress = 3,
	Closed = 4,
}

