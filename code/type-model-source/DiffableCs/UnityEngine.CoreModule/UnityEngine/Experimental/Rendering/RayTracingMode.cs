namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000427")]
public enum RayTracingMode : int
{
	Off = 0,
	Static = 1,
	DynamicTransform = 2,
	DynamicGeometry = 3,
	DynamicGeometryManualUpdate = 4,
}

