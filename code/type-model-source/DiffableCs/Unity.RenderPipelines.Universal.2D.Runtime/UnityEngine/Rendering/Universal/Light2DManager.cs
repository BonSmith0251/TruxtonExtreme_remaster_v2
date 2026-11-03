namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000036")]
internal static class Light2DManager
{
	[Token(Token = "0x400010C")]
	private static SortingLayer[] s_SortingLayers; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400010D")]
	private static readonly List<Light2D> <lights>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000045")]
	public static List<Light2D> lights
	{
		[Address(RVA = "0x2D24100", Offset = "0x2D23500", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600015A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2D24070", Offset = "0x2D23470", Length = "0x89")]
	[Token(Token = "0x6000163")]
	private static Light2DManager() { }

	[Address(RVA = "0x2D23860", Offset = "0x2D22C60", Length = "0x1C0")]
	[Token(Token = "0x6000161")]
	private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex) { }

	[Address(RVA = "0x2D23A30", Offset = "0x2D22E30", Length = "0xA7")]
	[Token(Token = "0x600015E")]
	public static void DeregisterLight(Light2D light) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015C")]
	internal static void Dispose() { }

	[Address(RVA = "0x2D23AE0", Offset = "0x2D22EE0", Length = "0x16F")]
	[Token(Token = "0x600015F")]
	public static void ErrorIfDuplicateGlobalLight(Light2D light) { }

	[Address(RVA = "0x2D24100", Offset = "0x2D23500", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600015A")]
	public static List<Light2D> get_lights() { }

	[Address(RVA = "0x2D23C50", Offset = "0x2D23050", Length = "0xD3")]
	[Token(Token = "0x6000162")]
	public static SortingLayer[] GetCachedSortingLayer() { }

	[Address(RVA = "0x2D23D30", Offset = "0x2D23130", Length = "0x228")]
	[Token(Token = "0x6000160")]
	public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015B")]
	internal static void Initialize() { }

	[Address(RVA = "0x2D23F60", Offset = "0x2D23360", Length = "0x10F")]
	[Token(Token = "0x600015D")]
	public static void RegisterLight(Light2D light) { }

}

