namespace UnityEngine;

[Flags]
[Token(Token = "0x200011F")]
public enum HDRDisplaySupportFlags : int
{
	None = 0,
	Supported = 1,
	RuntimeSwitchable = 2,
	AutomaticTonemapping = 4,
}

