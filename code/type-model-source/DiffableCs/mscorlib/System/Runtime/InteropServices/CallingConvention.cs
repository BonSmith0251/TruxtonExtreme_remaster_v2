namespace System.Runtime.InteropServices;

[ComVisible(True)]
[Token(Token = "0x2000458")]
public enum CallingConvention : int
{
	Winapi = 1,
	Cdecl = 2,
	StdCall = 3,
	ThisCall = 4,
	FastCall = 5,
}

