namespace UnityEngine.XR;

[Flags]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[Token(Token = "0x200001F")]
[UsedByNativeCode]
public enum MeshVertexAttributes : int
{
	None = 0,
	Normals = 1,
	Tangents = 2,
	UVs = 4,
	Colors = 8,
}

