namespace System.Runtime.InteropServices;

[Token(Token = "0x200043F")]
public enum GCHandleType : int
{
	Weak = 0,
	WeakTrackResurrection = 1,
	Normal = 2,
	Pinned = 3,
}

