namespace Steamworks;

[Token(Token = "0x2000126")]
public enum EP2PSend : int
{
	k_EP2PSendUnreliable = 0,
	k_EP2PSendUnreliableNoDelay = 1,
	k_EP2PSendReliable = 2,
	k_EP2PSendReliableWithBuffering = 3,
}

