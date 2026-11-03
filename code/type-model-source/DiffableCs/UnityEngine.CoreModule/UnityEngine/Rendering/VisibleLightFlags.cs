namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20003FE")]
internal enum VisibleLightFlags : int
{
	IntersectsNearPlane = 1,
	IntersectsFarPlane = 2,
	ForcedVisible = 4,
}

