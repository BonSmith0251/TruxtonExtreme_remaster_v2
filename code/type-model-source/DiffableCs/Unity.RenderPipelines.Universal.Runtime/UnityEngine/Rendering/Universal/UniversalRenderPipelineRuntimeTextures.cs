namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Runtime Textures", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000198")]
public class UniversalRenderPipelineRuntimeTextures : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000900")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Textures/BlueNoise64/L/LDR_LLL1_0.png", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000901")]
	private Texture2D m_BlueNoise64LTex; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Textures/BayerMatrix.png", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000902")]
	private Texture2D m_BayerMatrixTex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Textures/DebugFont.tga", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000903")]
	private Texture2D m_DebugFontTex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000904")]
	private Texture2D m_StencilDitherTex; //Field offset: 0x30

	[Token(Token = "0x1700020F")]
	public Texture2D bayerMatrixTex
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD210", Offset = "0x2DFC610", Length = "0x65")]
		[Token(Token = "0x60008C4")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700020E")]
	public Texture2D blueNoise64LTex
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD280", Offset = "0x2DFC680", Length = "0x65")]
		[Token(Token = "0x60008C2")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000210")]
	public Texture2D debugFontTexture
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60008C5")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD2F0", Offset = "0x2DFC6F0", Length = "0x65")]
		[Token(Token = "0x60008C6")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000211")]
	public Texture2D stencilDitherTex
	{
		[Address(RVA = "0x2DFD070", Offset = "0x2DFC470", Length = "0x191")]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 401
	}

	[Token(Token = "0x1700020D")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60008C0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700020C")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60008BF")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x60008C8")]
	public UniversalRenderPipelineRuntimeTextures() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60008C3")]
	public Texture2D get_bayerMatrixTex() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008C1")]
	public Texture2D get_blueNoise64LTex() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60008C5")]
	public Texture2D get_debugFontTexture() { }

	[Address(RVA = "0x2DFD070", Offset = "0x2DFC470", Length = "0x191")]
	[Token(Token = "0x60008C7")]
	public Texture2D get_stencilDitherTex() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60008BF")]
	public override int get_version() { }

	[Address(RVA = "0x2DFD210", Offset = "0x2DFC610", Length = "0x65")]
	[Token(Token = "0x60008C4")]
	public void set_bayerMatrixTex(Texture2D value) { }

	[Address(RVA = "0x2DFD280", Offset = "0x2DFC680", Length = "0x65")]
	[Token(Token = "0x60008C2")]
	public void set_blueNoise64LTex(Texture2D value) { }

	[Address(RVA = "0x2DFD2F0", Offset = "0x2DFC6F0", Length = "0x65")]
	[Token(Token = "0x60008C6")]
	public void set_debugFontTexture(Texture2D value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008C0")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

