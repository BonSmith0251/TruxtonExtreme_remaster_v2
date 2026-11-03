namespace UnityEngine.InputSystem.Users;

[Token(Token = "0x2000112")]
public enum InputUserChange : int
{
	Added = 0,
	Removed = 1,
	DevicePaired = 2,
	DeviceUnpaired = 3,
	DeviceLost = 4,
	DeviceRegained = 5,
	AccountChanged = 6,
	AccountNameChanged = 7,
	AccountSelectionInProgress = 8,
	AccountSelectionCanceled = 9,
	AccountSelectionComplete = 10,
	ControlSchemeChanged = 11,
	ControlsChanged = 12,
}

