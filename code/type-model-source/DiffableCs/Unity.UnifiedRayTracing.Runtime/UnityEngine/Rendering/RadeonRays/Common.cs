namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000009")]
internal static class Common
{

	[Address(RVA = "0x2F526E0", Offset = "0x2F51AE0", Length = "0xE")]
	[Token(Token = "0x600001C")]
	public static uint CeilDivide(uint val, uint div) { }

	[Address(RVA = "0x2F526F0", Offset = "0x2F51AF0", Length = "0xC0")]
	[Token(Token = "0x600001D")]
	public static void EnableKeyword(CommandBuffer cmd, ComputeShader shader, string keyword, bool enable) { }

}

