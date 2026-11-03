namespace UnityEngine.InputSystem;

[Token(Token = "0x20000DF")]
public enum PlayerJoinBehavior : int
{
	JoinPlayersWhenButtonIsPressed = 0,
	JoinPlayersWhenJoinActionIsTriggered = 1,
	JoinPlayersManually = 2,
}

