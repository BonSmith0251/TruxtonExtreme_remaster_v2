namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000034")]
internal class Light2DCullResult : ILight2DCullResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private sealed class <>c
	{
		[Token(Token = "0x400010A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400010B")]
		public static Comparison<Light2D> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x2D2FE30", Offset = "0x2D2F230", Length = "0x67")]
		[Token(Token = "0x6000157")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000158")]
		public <>c() { }

		[Address(RVA = "0x2D2FE10", Offset = "0x2D2F210", Length = "0x1F")]
		[Token(Token = "0x6000159")]
		internal int <SetupCulling>b__8_0(Light2D l1, Light2D l2) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000108")]
	private List<Light2D> m_VisibleLights; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000109")]
	private HashSet<ShadowCasterGroup2D> m_VisibleShadows; //Field offset: 0x18

	[Token(Token = "0x17000043")]
	public override List<Light2D> visibleLights
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000151")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000044")]
	public override HashSet<ShadowCasterGroup2D> visibleShadows
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000152")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D226E0", Offset = "0x2D21AE0", Length = "0xBD")]
	[Token(Token = "0x6000156")]
	public Light2DCullResult() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000151")]
	public override List<Light2D> get_visibleLights() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000152")]
	public override HashSet<ShadowCasterGroup2D> get_visibleShadows() { }

	[Address(RVA = "0x2D216A0", Offset = "0x2D20AA0", Length = "0x6AF")]
	[Token(Token = "0x6000154")]
	public override LightStats GetLightStatsByLayer(int layerID, ref LayerBatch layer) { }

	[Address(RVA = "0x2D21D50", Offset = "0x2D21150", Length = "0x9A")]
	[Token(Token = "0x6000153")]
	public override bool IsSceneLit() { }

	[Address(RVA = "0x2D21DF0", Offset = "0x2D211F0", Length = "0x8EB")]
	[Token(Token = "0x6000155")]
	public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera) { }

}

