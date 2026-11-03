namespace System.Runtime.ConstrainedExecution;

[Token(Token = "0x2000469")]
public enum Consistency : int
{
	MayCorruptProcess = 0,
	MayCorruptAppDomain = 1,
	MayCorruptInstance = 2,
	WillNotCorruptState = 3,
}

