namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x20001C6")]
internal static class CameraTypeUtility
{
	[Token(Token = "0x40009C2")]
	private static String[] s_CameraTypeNames; //Field offset: 0x0

	[Address(RVA = "0x2DE7EC0", Offset = "0x2DE72C0", Length = "0xBD")]
	[Token(Token = "0x60009A7")]
	private static CameraTypeUtility() { }

	[Address(RVA = "0x2DE7E20", Offset = "0x2DE7220", Length = "0x9B")]
	[Extension]
	[Token(Token = "0x60009A6")]
	public static string GetName(CameraRenderType type) { }

}

