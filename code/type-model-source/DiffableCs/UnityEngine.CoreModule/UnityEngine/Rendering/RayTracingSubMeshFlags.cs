namespace UnityEngine.Rendering;

[Flags]
[MovedFrom("UnityEngine.Experimental.Rendering")]
[NativeHeader("Runtime/Export/Graphics/RayTracingAccelerationStructure.bindings.h")]
[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
[Token(Token = "0x2000382")]
[UsedByNativeCode]
public enum RayTracingSubMeshFlags : int
{
	Disabled = 0,
	Enabled = 1,
	ClosestHitOnly = 2,
	UniqueAnyHitCalls = 4,
}

