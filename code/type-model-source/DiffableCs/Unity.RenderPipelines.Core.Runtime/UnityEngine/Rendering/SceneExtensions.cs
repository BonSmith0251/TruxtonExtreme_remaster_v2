namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000117")]
internal static class SceneExtensions
{
	[Token(Token = "0x40004DD")]
	private static PropertyInfo s_SceneGUID; //Field offset: 0x0

	[Address(RVA = "0x2C1D2B0", Offset = "0x2C1C6B0", Length = "0xAE")]
	[Token(Token = "0x6000A3E")]
	private static SceneExtensions() { }

	[Address(RVA = "0x2C1D1F0", Offset = "0x2C1C5F0", Length = "0xBA")]
	[Extension]
	[Token(Token = "0x6000A3D")]
	public static string GetGUID(Scene scene) { }

}

