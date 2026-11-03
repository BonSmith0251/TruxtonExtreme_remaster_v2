namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F1")]
public struct ShadowData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB9")]
	private ContextContainer frameData; //Field offset: 0x0

	[Token(Token = "0x17000288")]
	internal bool additionalLightShadowsEnabled
	{
		[Address(RVA = "0x2E0A410", Offset = "0x2E09810", Length = "0x4D")]
		[Token(Token = "0x6000AAB")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x1700028A")]
	public int additionalLightsShadowmapHeight
	{
		[Address(RVA = "0x2E0A460", Offset = "0x2E09860", Length = "0x4D")]
		[Token(Token = "0x6000AAD")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000289")]
	public int additionalLightsShadowmapWidth
	{
		[Address(RVA = "0x2E0A4B0", Offset = "0x2E098B0", Length = "0x4D")]
		[Token(Token = "0x6000AAC")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700028D")]
	public List<Vector4>& bias
	{
		[Address(RVA = "0x2E0A500", Offset = "0x2E09900", Length = "0x4D")]
		[Token(Token = "0x6000AB0")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700028F")]
	internal bool isKeywordAdditionalLightShadowsEnabled
	{
		[Address(RVA = "0x2E0A550", Offset = "0x2E09950", Length = "0x4D")]
		[Token(Token = "0x6000AB2")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000290")]
	internal bool isKeywordSoftShadowsEnabled
	{
		[Address(RVA = "0x2E0A5A0", Offset = "0x2E099A0", Length = "0x4D")]
		[Token(Token = "0x6000AB3")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000293")]
	internal int mainLightRenderTargetHeight
	{
		[Address(RVA = "0x2E0A5F0", Offset = "0x2E099F0", Length = "0x4D")]
		[Token(Token = "0x6000AB6")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000292")]
	internal int mainLightRenderTargetWidth
	{
		[Address(RVA = "0x2E0A640", Offset = "0x2E09A40", Length = "0x4D")]
		[Token(Token = "0x6000AB5")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000286")]
	public float mainLightShadowCascadeBorder
	{
		[Address(RVA = "0x2E0A690", Offset = "0x2E09A90", Length = "0x4D")]
		[Token(Token = "0x6000AA9")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000284")]
	public int mainLightShadowCascadesCount
	{
		[Address(RVA = "0x2E0A6E0", Offset = "0x2E09AE0", Length = "0x4D")]
		[Token(Token = "0x6000AA7")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000285")]
	public Vector3 mainLightShadowCascadesSplit
	{
		[Address(RVA = "0x2E0A730", Offset = "0x2E09B30", Length = "0x4D")]
		[Token(Token = "0x6000AA8")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000283")]
	public int mainLightShadowmapHeight
	{
		[Address(RVA = "0x2E0A7D0", Offset = "0x2E09BD0", Length = "0x4D")]
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000282")]
	public int mainLightShadowmapWidth
	{
		[Address(RVA = "0x2E0A820", Offset = "0x2E09C20", Length = "0x4D")]
		[Token(Token = "0x6000AA5")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000291")]
	internal int mainLightShadowResolution
	{
		[Address(RVA = "0x2E0A780", Offset = "0x2E09B80", Length = "0x4D")]
		[Token(Token = "0x6000AB4")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000281")]
	internal bool mainLightShadowsEnabled
	{
		[Address(RVA = "0x2E0A870", Offset = "0x2E09C70", Length = "0x4D")]
		[Token(Token = "0x6000AA4")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x1700028E")]
	public List<Int32>& resolution
	{
		[Address(RVA = "0x2E0A8C0", Offset = "0x2E09CC0", Length = "0x4D")]
		[Token(Token = "0x6000AB1")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000295")]
	internal AdditionalLightsShadowAtlasLayout shadowAtlasLayout
	{
		[Address(RVA = "0x2E0A910", Offset = "0x2E09D10", Length = "0x4D")]
		[Token(Token = "0x6000AB8")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x1700028C")]
	public int shadowmapDepthBufferBits
	{
		[Address(RVA = "0x2E0A960", Offset = "0x2E09D60", Length = "0x4D")]
		[Token(Token = "0x6000AAF")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000287")]
	public bool supportsAdditionalLightShadows
	{
		[Address(RVA = "0x2E0A9B0", Offset = "0x2E09DB0", Length = "0x4D")]
		[Token(Token = "0x6000AAA")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000280")]
	public bool supportsMainLightShadows
	{
		[Address(RVA = "0x2E0AA00", Offset = "0x2E09E00", Length = "0x4D")]
		[Token(Token = "0x6000AA3")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700028B")]
	public bool supportsSoftShadows
	{
		[Address(RVA = "0x2E0AA50", Offset = "0x2E09E50", Length = "0x4D")]
		[Token(Token = "0x6000AAE")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700027F")]
	internal UniversalShadowData universalShadowData
	{
		[Address(RVA = "0x2E0AAA0", Offset = "0x2E09EA0", Length = "0x43")]
		[Token(Token = "0x6000AA2")]
		internal get { } //Length: 67
	}

	[Token(Token = "0x17000294")]
	internal NativeArray<URPLightShadowCullingInfos>& visibleLightsShadowCullingInfos
	{
		[Address(RVA = "0x2E0AAF0", Offset = "0x2E09EF0", Length = "0x4D")]
		[Token(Token = "0x6000AB7")]
		internal get { } //Length: 77
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000AA1")]
	internal ShadowData(ContextContainer frameData) { }

	[Address(RVA = "0x2E0A410", Offset = "0x2E09810", Length = "0x4D")]
	[Token(Token = "0x6000AAB")]
	internal bool get_additionalLightShadowsEnabled() { }

	[Address(RVA = "0x2E0A460", Offset = "0x2E09860", Length = "0x4D")]
	[Token(Token = "0x6000AAD")]
	public int get_additionalLightsShadowmapHeight() { }

	[Address(RVA = "0x2E0A4B0", Offset = "0x2E098B0", Length = "0x4D")]
	[Token(Token = "0x6000AAC")]
	public int get_additionalLightsShadowmapWidth() { }

	[Address(RVA = "0x2E0A500", Offset = "0x2E09900", Length = "0x4D")]
	[Token(Token = "0x6000AB0")]
	public List<Vector4>& get_bias() { }

	[Address(RVA = "0x2E0A550", Offset = "0x2E09950", Length = "0x4D")]
	[Token(Token = "0x6000AB2")]
	internal bool get_isKeywordAdditionalLightShadowsEnabled() { }

	[Address(RVA = "0x2E0A5A0", Offset = "0x2E099A0", Length = "0x4D")]
	[Token(Token = "0x6000AB3")]
	internal bool get_isKeywordSoftShadowsEnabled() { }

	[Address(RVA = "0x2E0A5F0", Offset = "0x2E099F0", Length = "0x4D")]
	[Token(Token = "0x6000AB6")]
	internal int get_mainLightRenderTargetHeight() { }

	[Address(RVA = "0x2E0A640", Offset = "0x2E09A40", Length = "0x4D")]
	[Token(Token = "0x6000AB5")]
	internal int get_mainLightRenderTargetWidth() { }

	[Address(RVA = "0x2E0A690", Offset = "0x2E09A90", Length = "0x4D")]
	[Token(Token = "0x6000AA9")]
	public float get_mainLightShadowCascadeBorder() { }

	[Address(RVA = "0x2E0A6E0", Offset = "0x2E09AE0", Length = "0x4D")]
	[Token(Token = "0x6000AA7")]
	public int get_mainLightShadowCascadesCount() { }

	[Address(RVA = "0x2E0A730", Offset = "0x2E09B30", Length = "0x4D")]
	[Token(Token = "0x6000AA8")]
	public Vector3 get_mainLightShadowCascadesSplit() { }

	[Address(RVA = "0x2E0A7D0", Offset = "0x2E09BD0", Length = "0x4D")]
	[Token(Token = "0x6000AA6")]
	public int get_mainLightShadowmapHeight() { }

	[Address(RVA = "0x2E0A820", Offset = "0x2E09C20", Length = "0x4D")]
	[Token(Token = "0x6000AA5")]
	public int get_mainLightShadowmapWidth() { }

	[Address(RVA = "0x2E0A780", Offset = "0x2E09B80", Length = "0x4D")]
	[Token(Token = "0x6000AB4")]
	internal int get_mainLightShadowResolution() { }

	[Address(RVA = "0x2E0A870", Offset = "0x2E09C70", Length = "0x4D")]
	[Token(Token = "0x6000AA4")]
	internal bool get_mainLightShadowsEnabled() { }

	[Address(RVA = "0x2E0A8C0", Offset = "0x2E09CC0", Length = "0x4D")]
	[Token(Token = "0x6000AB1")]
	public List<Int32>& get_resolution() { }

	[Address(RVA = "0x2E0A910", Offset = "0x2E09D10", Length = "0x4D")]
	[Token(Token = "0x6000AB8")]
	internal AdditionalLightsShadowAtlasLayout get_shadowAtlasLayout() { }

	[Address(RVA = "0x2E0A960", Offset = "0x2E09D60", Length = "0x4D")]
	[Token(Token = "0x6000AAF")]
	public int get_shadowmapDepthBufferBits() { }

	[Address(RVA = "0x2E0A9B0", Offset = "0x2E09DB0", Length = "0x4D")]
	[Token(Token = "0x6000AAA")]
	public bool get_supportsAdditionalLightShadows() { }

	[Address(RVA = "0x2E0AA00", Offset = "0x2E09E00", Length = "0x4D")]
	[Token(Token = "0x6000AA3")]
	public bool get_supportsMainLightShadows() { }

	[Address(RVA = "0x2E0AA50", Offset = "0x2E09E50", Length = "0x4D")]
	[Token(Token = "0x6000AAE")]
	public bool get_supportsSoftShadows() { }

	[Address(RVA = "0x2E0AAA0", Offset = "0x2E09EA0", Length = "0x43")]
	[Token(Token = "0x6000AA2")]
	internal UniversalShadowData get_universalShadowData() { }

	[Address(RVA = "0x2E0AAF0", Offset = "0x2E09EF0", Length = "0x4D")]
	[Token(Token = "0x6000AB7")]
	internal NativeArray<URPLightShadowCullingInfos>& get_visibleLightsShadowCullingInfos() { }

}

