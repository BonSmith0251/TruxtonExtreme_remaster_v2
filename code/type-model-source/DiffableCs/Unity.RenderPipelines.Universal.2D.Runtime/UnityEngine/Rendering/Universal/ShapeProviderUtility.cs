namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000093")]
internal class ShapeProviderUtility
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000357")]
	public ShapeProviderUtility() { }

	[Address(RVA = "0x2D52990", Offset = "0x2D51D90", Length = "0x123")]
	[Token(Token = "0x6000355")]
	public static void CallOnBeforeRender(ShadowShape2DProvider shapeProvider, Component component, ShadowMesh2D shadowMesh, Bounds bounds) { }

	[Address(RVA = "0x2D52AC0", Offset = "0x2D51EC0", Length = "0x8B")]
	[Token(Token = "0x6000356")]
	public static void PersistantDataCreated(ShadowShape2DProvider shapeProvider, Component component, ShadowMesh2D shadowMesh) { }

}

