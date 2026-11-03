namespace Unity.Multiplayer.PlayMode;

[MovedFrom(True, "Unity.Multiplayer.Playmode", "Unity.Multiplayer.Playmode", null)]
[Token(Token = "0x2000003")]
public static class CurrentPlayer
{
	[Token(Token = "0x4000001")]
	private static CurrentPlayerApi s_CurrentPlayerApi; //Field offset: 0x0

	[Address(RVA = "0x3114140", Offset = "0x3113540", Length = "0x98")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	[Token(Token = "0x6000001")]
	private static void ReloadLatestTagsOnEnterPlaymode() { }

}

