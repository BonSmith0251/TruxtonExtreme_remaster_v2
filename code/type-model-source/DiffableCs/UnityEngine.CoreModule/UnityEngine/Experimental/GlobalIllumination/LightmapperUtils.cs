namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000416")]
public static class LightmapperUtils
{

	[Address(RVA = "0x30C08A0", Offset = "0x30BFCA0", Length = "0x57")]
	[Token(Token = "0x6001F42")]
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	[Address(RVA = "0x30C13A0", Offset = "0x30C07A0", Length = "0x12")]
	[Token(Token = "0x6001F3E")]
	public static LightMode Extract(LightmapBakeType baketype) { }

	[Address(RVA = "0x30C0DA0", Offset = "0x30C01A0", Length = "0x2EF")]
	[Token(Token = "0x6001F43")]
	public static void Extract(Light l, ref DirectionalLight dir) { }

	[Address(RVA = "0x30C1090", Offset = "0x30C0490", Length = "0x302")]
	[Token(Token = "0x6001F44")]
	public static void Extract(Light l, ref PointLight point) { }

	[Address(RVA = "0x30C13C0", Offset = "0x30C07C0", Length = "0x358")]
	[Token(Token = "0x6001F45")]
	public static void Extract(Light l, ref SpotLight spot) { }

	[Address(RVA = "0x30C0A90", Offset = "0x30BFE90", Length = "0x303")]
	[Token(Token = "0x6001F46")]
	public static void Extract(Light l, ref RectangleLight rect) { }

	[Address(RVA = "0x30C1720", Offset = "0x30C0B20", Length = "0x302")]
	[Token(Token = "0x6001F47")]
	public static void Extract(Light l, ref DiscLight disc) { }

	[Address(RVA = "0x30C1A30", Offset = "0x30C0E30", Length = "0x131")]
	[Token(Token = "0x6001F48")]
	public static void Extract(Light l, out Cookie cookie) { }

	[Address(RVA = "0x30C0900", Offset = "0x30BFD00", Length = "0xAA")]
	[Token(Token = "0x6001F41")]
	private static Color ExtractColorTemperature(Light l) { }

	[Address(RVA = "0x30C09B0", Offset = "0x30BFDB0", Length = "0x8E")]
	[Token(Token = "0x6001F3F")]
	public static LinearColor ExtractIndirect(Light l) { }

	[Address(RVA = "0x30C0A40", Offset = "0x30BFE40", Length = "0x48")]
	[Token(Token = "0x6001F40")]
	public static float ExtractInnerCone(Light l) { }

}

