namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000012")]
internal enum ClipTypes : int
{
	ctIntersection = 0,
	ctUnion = 1,
	ctDifference = 2,
	ctXor = 3,
}

