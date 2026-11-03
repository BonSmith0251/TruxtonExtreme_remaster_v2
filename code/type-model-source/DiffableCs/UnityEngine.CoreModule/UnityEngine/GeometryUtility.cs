namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GeometryUtilityScripting", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20000C5")]
public sealed class GeometryUtility
{

	[Address(RVA = "0x2FF3220", Offset = "0x2FF2620", Length = "0x1A5")]
	[Token(Token = "0x600057F")]
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	[Address(RVA = "0x2FF3050", Offset = "0x2FF2450", Length = "0x1C6")]
	[Token(Token = "0x6000580")]
	public static void CalculateFrustumPlanes(in Matrix4x4 worldToProjectionMatrix, Span<Plane> planes) { }

	[Address(RVA = "0x2FF33D0", Offset = "0x2FF27D0", Length = "0x88")]
	[Token(Token = "0x6000581")]
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	[Address(RVA = "0x2FF34B0", Offset = "0x2FF28B0", Length = "0xA2")]
	[NativeName("ExtractPlanes")]
	[Token(Token = "0x6000584")]
	private static void Internal_ExtractPlanes(Span<Plane> planes, in Matrix4x4 worldToProjectionMatrix) { }

	[Address(RVA = "0x2FF3460", Offset = "0x2FF2860", Length = "0x42")]
	[Token(Token = "0x6000586")]
	private static void Internal_ExtractPlanes_Injected(ref ManagedSpanWrapper planes, in Matrix4x4 worldToProjectionMatrix) { }

	[Address(RVA = "0x2FF35B0", Offset = "0x2FF29B0", Length = "0xA2")]
	[NativeName("TestPlanesAABB")]
	[Token(Token = "0x6000582")]
	private static bool Internal_TestPlanesAABB(ReadOnlySpan<Plane> planes, in Bounds bounds) { }

	[Address(RVA = "0x2FF3560", Offset = "0x2FF2960", Length = "0x42")]
	[Token(Token = "0x6000585")]
	private static bool Internal_TestPlanesAABB_Injected(ref ManagedSpanWrapper planes, in Bounds bounds) { }

	[Address(RVA = "0x2FF3660", Offset = "0x2FF2A60", Length = "0x124")]
	[Token(Token = "0x6000583")]
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

}

