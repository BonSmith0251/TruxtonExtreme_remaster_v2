namespace System.Runtime.InteropServices;

[ComVisible(True)]
[Token(Token = "0x2000445")]
public enum ComInterfaceType : int
{
	InterfaceIsDual = 0,
	InterfaceIsIUnknown = 1,
	InterfaceIsIDispatch = 2,
	InterfaceIsIInspectable = 3,
}

