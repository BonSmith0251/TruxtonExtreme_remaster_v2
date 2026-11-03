namespace UnityEngine.Accessibility;

[Flags]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Token(Token = "0x2000008")]
public enum AccessibilityState : byte
{
	None = 0,
	Disabled = 1,
	Selected = 2,
	Expanded = 4,
}

