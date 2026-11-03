namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200001C")]
public enum MeshGenerationStatus : int
{
	Success = 0,
	InvalidMeshId = 1,
	GenerationAlreadyInProgress = 2,
	Canceled = 3,
	UnknownError = 4,
}

