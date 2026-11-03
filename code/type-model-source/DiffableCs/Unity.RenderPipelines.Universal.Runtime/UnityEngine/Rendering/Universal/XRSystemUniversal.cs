namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001FD")]
internal static class XRSystemUniversal
{
	[Token(Token = "0x4000C0E")]
	private static Matrix4x4[] s_projMatrix; //Field offset: 0x0
	[Token(Token = "0x4000C0F")]
	private static MaterialPropertyBlock s_XRSharedPropertyBlock; //Field offset: 0x8

	[Address(RVA = "0x2E187D0", Offset = "0x2E17BD0", Length = "0xBC")]
	[Token(Token = "0x6000ADE")]
	private static XRSystemUniversal() { }

	[Address(RVA = "0x2E18310", Offset = "0x2E17710", Length = "0xCC")]
	[Token(Token = "0x6000ADA")]
	internal static void BeginLateLatching(Camera camera, XRPassUniversal xrPass) { }

	[Address(RVA = "0x2E183E0", Offset = "0x2E177E0", Length = "0xB9")]
	[Token(Token = "0x6000ADB")]
	internal static void EndLateLatching(Camera camera, XRPassUniversal xrPass) { }

	[Address(RVA = "0x2E184A0", Offset = "0x2E178A0", Length = "0x4F")]
	[Token(Token = "0x6000AD9")]
	internal static MaterialPropertyBlock GetMaterialPropertyBlock() { }

	[Address(RVA = "0x2E184F0", Offset = "0x2E178F0", Length = "0x254")]
	[Token(Token = "0x6000ADD")]
	internal static void MarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture) { }

	[Address(RVA = "0x2E18750", Offset = "0x2E17B50", Length = "0x7D")]
	[Token(Token = "0x6000ADC")]
	internal static void UnmarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass) { }

}

