namespace Steamworks;

[Flags]
[Token(Token = "0x2000120")]
public enum EChatMemberStateChange : int
{
	k_EChatMemberStateChangeEntered = 1,
	k_EChatMemberStateChangeLeft = 2,
	k_EChatMemberStateChangeDisconnected = 4,
	k_EChatMemberStateChangeKicked = 8,
	k_EChatMemberStateChangeBanned = 16,
}

