namespace UnityEngine.InputSystem.Users;

[Flags]
[Token(Token = "0x2000113")]
public enum InputUserPairingOptions : int
{
	None = 0,
	ForcePlatformUserAccountSelection = 1,
	ForceNoPlatformUserAccountSelection = 2,
	UnpairCurrentDevicesFromUser = 8,
}

