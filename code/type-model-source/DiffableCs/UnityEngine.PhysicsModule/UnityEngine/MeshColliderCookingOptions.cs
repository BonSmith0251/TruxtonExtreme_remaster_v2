namespace UnityEngine;

[Flags]
[Token(Token = "0x200000E")]
public enum MeshColliderCookingOptions : int
{
	None = 0,
	InflateConvexMesh = 1,
	CookForFasterSimulation = 2,
	EnableMeshCleaning = 4,
	WeldColocatedVertices = 8,
	UseFastMidphase = 16,
}

