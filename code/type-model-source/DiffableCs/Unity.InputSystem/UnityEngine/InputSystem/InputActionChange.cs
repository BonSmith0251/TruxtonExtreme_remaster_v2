namespace UnityEngine.InputSystem;

[Token(Token = "0x2000026")]
public enum InputActionChange : int
{
	ActionEnabled = 0,
	ActionDisabled = 1,
	ActionMapEnabled = 2,
	ActionMapDisabled = 3,
	ActionStarted = 4,
	ActionPerformed = 5,
	ActionCanceled = 6,
	BoundControlsAboutToChange = 7,
	BoundControlsChanged = 8,
}

