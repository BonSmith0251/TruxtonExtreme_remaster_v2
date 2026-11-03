namespace UnityEngineInternal.Input;

[Flags]
[Token(Token = "0x2000006")]
internal enum NativeInputUpdateType : int
{
	Dynamic = 1,
	Fixed = 2,
	BeforeRender = 4,
	Editor = 8,
	IgnoreFocus = -2147483648,
}

