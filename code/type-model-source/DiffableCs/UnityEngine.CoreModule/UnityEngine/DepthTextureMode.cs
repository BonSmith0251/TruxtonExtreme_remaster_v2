namespace UnityEngine;

[Flags]
[Token(Token = "0x200010B")]
public enum DepthTextureMode : int
{
	None = 0,
	Depth = 1,
	DepthNormals = 2,
	MotionVectors = 4,
}

