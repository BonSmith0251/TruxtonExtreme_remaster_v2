namespace UnityEngine.Rendering;

[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[Token(Token = "0x2000347")]
public enum CompareFunction : int
{
	Disabled = 0,
	Never = 1,
	Less = 2,
	Equal = 3,
	LessEqual = 4,
	Greater = 5,
	NotEqual = 6,
	GreaterEqual = 7,
	Always = 8,
}

