namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F0")]
public struct LightData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB8")]
	private ContextContainer frameData; //Field offset: 0x0

	[Token(Token = "0x17000275")]
	public int additionalLightsCount
	{
		[Address(RVA = "0x2E07130", Offset = "0x2E06530", Length = "0x4D")]
		[Token(Token = "0x6000A97")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000274")]
	public int mainLightIndex
	{
		[Address(RVA = "0x2E07180", Offset = "0x2E06580", Length = "0x4D")]
		[Token(Token = "0x6000A96")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000276")]
	public int maxPerObjectAdditionalLightsCount
	{
		[Address(RVA = "0x2E071D0", Offset = "0x2E065D0", Length = "0x4D")]
		[Token(Token = "0x6000A98")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027C")]
	public bool reflectionProbeAtlas
	{
		[Address(RVA = "0x2E07220", Offset = "0x2E06620", Length = "0x4D")]
		[Token(Token = "0x6000A9E")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027B")]
	public bool reflectionProbeBlending
	{
		[Address(RVA = "0x2E07270", Offset = "0x2E06670", Length = "0x4D")]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027A")]
	public bool reflectionProbeBoxProjection
	{
		[Address(RVA = "0x2E072C0", Offset = "0x2E066C0", Length = "0x4D")]
		[Token(Token = "0x6000A9C")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000278")]
	public bool shadeAdditionalLightsPerVertex
	{
		[Address(RVA = "0x2E07310", Offset = "0x2E06710", Length = "0x4D")]
		[Token(Token = "0x6000A9A")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027E")]
	public bool supportsAdditionalLights
	{
		[Address(RVA = "0x2E07360", Offset = "0x2E06760", Length = "0x4D")]
		[Token(Token = "0x6000AA0")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027D")]
	public bool supportsLightLayers
	{
		[Address(RVA = "0x2E073B0", Offset = "0x2E067B0", Length = "0x4D")]
		[Token(Token = "0x6000A9F")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000279")]
	public bool supportsMixedLighting
	{
		[Address(RVA = "0x2E07400", Offset = "0x2E06800", Length = "0x4D")]
		[Token(Token = "0x6000A9B")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000273")]
	internal UniversalLightData universalLightData
	{
		[Address(RVA = "0x2E07450", Offset = "0x2E06850", Length = "0x43")]
		[Token(Token = "0x6000A95")]
		internal get { } //Length: 67
	}

	[Token(Token = "0x17000277")]
	public NativeArray<VisibleLight>& visibleLights
	{
		[Address(RVA = "0x2E074A0", Offset = "0x2E068A0", Length = "0x4D")]
		[Token(Token = "0x6000A99")]
		 get { } //Length: 77
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000A94")]
	internal LightData(ContextContainer frameData) { }

	[Address(RVA = "0x2E07130", Offset = "0x2E06530", Length = "0x4D")]
	[Token(Token = "0x6000A97")]
	public int get_additionalLightsCount() { }

	[Address(RVA = "0x2E07180", Offset = "0x2E06580", Length = "0x4D")]
	[Token(Token = "0x6000A96")]
	public int get_mainLightIndex() { }

	[Address(RVA = "0x2E071D0", Offset = "0x2E065D0", Length = "0x4D")]
	[Token(Token = "0x6000A98")]
	public int get_maxPerObjectAdditionalLightsCount() { }

	[Address(RVA = "0x2E07220", Offset = "0x2E06620", Length = "0x4D")]
	[Token(Token = "0x6000A9E")]
	public bool get_reflectionProbeAtlas() { }

	[Address(RVA = "0x2E07270", Offset = "0x2E06670", Length = "0x4D")]
	[Token(Token = "0x6000A9D")]
	public bool get_reflectionProbeBlending() { }

	[Address(RVA = "0x2E072C0", Offset = "0x2E066C0", Length = "0x4D")]
	[Token(Token = "0x6000A9C")]
	public bool get_reflectionProbeBoxProjection() { }

	[Address(RVA = "0x2E07310", Offset = "0x2E06710", Length = "0x4D")]
	[Token(Token = "0x6000A9A")]
	public bool get_shadeAdditionalLightsPerVertex() { }

	[Address(RVA = "0x2E07360", Offset = "0x2E06760", Length = "0x4D")]
	[Token(Token = "0x6000AA0")]
	public bool get_supportsAdditionalLights() { }

	[Address(RVA = "0x2E073B0", Offset = "0x2E067B0", Length = "0x4D")]
	[Token(Token = "0x6000A9F")]
	public bool get_supportsLightLayers() { }

	[Address(RVA = "0x2E07400", Offset = "0x2E06800", Length = "0x4D")]
	[Token(Token = "0x6000A9B")]
	public bool get_supportsMixedLighting() { }

	[Address(RVA = "0x2E07450", Offset = "0x2E06850", Length = "0x43")]
	[Token(Token = "0x6000A95")]
	internal UniversalLightData get_universalLightData() { }

	[Address(RVA = "0x2E074A0", Offset = "0x2E068A0", Length = "0x4D")]
	[Token(Token = "0x6000A99")]
	public NativeArray<VisibleLight>& get_visibleLights() { }

}

