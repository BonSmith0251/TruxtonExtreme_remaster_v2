namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200003D")]
internal static class Light2DLookupTexture
{
	[Token(Token = "0x400012D")]
	internal static readonly string k_LightLookupProperty; //Field offset: 0x0
	[Token(Token = "0x400012E")]
	internal static readonly string k_FalloffLookupProperty; //Field offset: 0x8
	[Token(Token = "0x400012F")]
	internal static readonly int k_LightLookupID; //Field offset: 0x10
	[Token(Token = "0x4000130")]
	internal static readonly int k_FalloffLookupID; //Field offset: 0x14
	[Token(Token = "0x4000131")]
	private static Texture2D s_PointLightLookupTexture; //Field offset: 0x18
	[Token(Token = "0x4000132")]
	private static Texture2D s_FalloffLookupTexture; //Field offset: 0x20
	[Token(Token = "0x4000133")]
	private static RTHandle m_LightLookupRTHandle; //Field offset: 0x28
	[Token(Token = "0x4000134")]
	private static RTHandle m_FalloffRTHandle; //Field offset: 0x30

	[Address(RVA = "0x2D23700", Offset = "0x2D22B00", Length = "0x156")]
	[Token(Token = "0x6000183")]
	private static Light2DLookupTexture() { }

	[Address(RVA = "0x2D227A0", Offset = "0x2D21BA0", Length = "0x24E")]
	[Token(Token = "0x6000182")]
	private static Texture2D CreateFalloffLookupTexture() { }

	[Address(RVA = "0x2D229F0", Offset = "0x2D21DF0", Length = "0x3B5")]
	[Token(Token = "0x6000181")]
	private static Texture2D CreatePointLightLookupTexture() { }

	[Address(RVA = "0x2D22F40", Offset = "0x2D22340", Length = "0x330")]
	[Token(Token = "0x6000180")]
	public static Texture GetFalloffLookupTexture() { }

	[Address(RVA = "0x2D22DB0", Offset = "0x2D221B0", Length = "0x18F")]
	[Token(Token = "0x600017D")]
	public static RTHandle GetFallOffLookupTexture_Rendergraph() { }

	[Address(RVA = "0x2D234F0", Offset = "0x2D228F0", Length = "0xF6")]
	[Token(Token = "0x600017F")]
	public static Texture GetLightLookupTexture() { }

	[Address(RVA = "0x2D23280", Offset = "0x2D22680", Length = "0x262")]
	[Token(Token = "0x600017C")]
	public static RTHandle GetLightLookupTexture_Rendergraph() { }

	[Address(RVA = "0x2D235F0", Offset = "0x2D229F0", Length = "0x103")]
	[Token(Token = "0x600017E")]
	public static void Release() { }

}

