namespace UnityEngine.Rendering.UnifiedRayTracing;

[Flags]
[Token(Token = "0x2000056")]
public enum BuildFlags : int
{
	None = 0,
	PreferFastTrace = 1,
	PreferFastBuild = 2,
	MinimizeMemory = 4,
}

