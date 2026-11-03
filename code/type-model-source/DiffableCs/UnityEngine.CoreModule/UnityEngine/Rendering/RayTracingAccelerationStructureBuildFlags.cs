namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200033C")]
public enum RayTracingAccelerationStructureBuildFlags : int
{
	None = 0,
	PreferFastTrace = 1,
	PreferFastBuild = 2,
	MinimizeMemory = 4,
}

