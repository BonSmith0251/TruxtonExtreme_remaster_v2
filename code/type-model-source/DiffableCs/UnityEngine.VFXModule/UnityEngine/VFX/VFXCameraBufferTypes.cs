namespace UnityEngine.VFX;

[Flags]
[Token(Token = "0x2000003")]
public enum VFXCameraBufferTypes : int
{
	None = 0,
	Depth = 1,
	Color = 2,
	Normal = 4,
}

