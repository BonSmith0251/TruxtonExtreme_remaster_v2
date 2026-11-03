namespace UnityEngine.InputSystem.LowLevel;

[Flags]
[Token(Token = "0x20001D1")]
public enum InputUpdateType : int
{
	None = 0,
	Dynamic = 1,
	Fixed = 2,
	BeforeRender = 4,
	Editor = 8,
	Manual = 16,
	Default = 11,
}

