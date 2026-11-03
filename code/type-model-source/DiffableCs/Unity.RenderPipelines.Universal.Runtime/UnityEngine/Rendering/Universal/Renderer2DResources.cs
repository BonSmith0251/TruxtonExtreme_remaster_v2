namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: 2D Renderer", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000194")]
internal class Renderer2DResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008E5")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/2D/Light2D.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008E6")]
	private Shader m_LightShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Shaders/2D/Shadow2D-Projected.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008E7")]
	private Shader m_ProjectedShadowShader; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Shaders/2D/Shadow2D-Shadow-Sprite.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008E8")]
	private Shader m_SpriteShadowShader; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008E9")]
	private Shader m_SpriteUnshadowShader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Shaders/2D/Shadow2D-Shadow-Geometry.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008EA")]
	private Shader m_GeometryShadowShader; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008EB")]
	private Shader m_GeometryUnshadowShader; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[ResourcePath("Shaders/Utils/CopyDepth.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008EC")]
	private Shader m_CopyDepthPS; //Field offset: 0x48

	[Token(Token = "0x170001F4")]
	internal Shader copyDepthPS
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000891")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEAD70", Offset = "0x2DEA170", Length = "0x65")]
		[Token(Token = "0x6000892")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001F2")]
	internal Shader geometryShadowShader
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600088D")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEADE0", Offset = "0x2DEA1E0", Length = "0x65")]
		[Token(Token = "0x600088E")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001F3")]
	internal Shader geometryUnshadowShader
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600088F")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEAE50", Offset = "0x2DEA250", Length = "0x65")]
		[Token(Token = "0x6000890")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001EE")]
	internal Shader lightShader
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000885")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEAEC0", Offset = "0x2DEA2C0", Length = "0x65")]
		[Token(Token = "0x6000886")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001EF")]
	internal Shader projectedShadowShader
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000887")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEAF30", Offset = "0x2DEA330", Length = "0x65")]
		[Token(Token = "0x6000888")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001F0")]
	internal Shader spriteShadowShader
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000889")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEAFA0", Offset = "0x2DEA3A0", Length = "0x65")]
		[Token(Token = "0x600088A")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001F1")]
	internal Shader spriteUnshadowShader
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600088B")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DEB010", Offset = "0x2DEA410", Length = "0x65")]
		[Token(Token = "0x600088C")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x170001ED")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000884")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001EC")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000883")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000893")]
	public Renderer2DResources() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000891")]
	internal Shader get_copyDepthPS() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600088D")]
	internal Shader get_geometryShadowShader() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600088F")]
	internal Shader get_geometryUnshadowShader() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000885")]
	internal Shader get_lightShader() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000887")]
	internal Shader get_projectedShadowShader() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000889")]
	internal Shader get_spriteShadowShader() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600088B")]
	internal Shader get_spriteUnshadowShader() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000883")]
	public override int get_version() { }

	[Address(RVA = "0x2DEAD70", Offset = "0x2DEA170", Length = "0x65")]
	[Token(Token = "0x6000892")]
	internal void set_copyDepthPS(Shader value) { }

	[Address(RVA = "0x2DEADE0", Offset = "0x2DEA1E0", Length = "0x65")]
	[Token(Token = "0x600088E")]
	internal void set_geometryShadowShader(Shader value) { }

	[Address(RVA = "0x2DEAE50", Offset = "0x2DEA250", Length = "0x65")]
	[Token(Token = "0x6000890")]
	internal void set_geometryUnshadowShader(Shader value) { }

	[Address(RVA = "0x2DEAEC0", Offset = "0x2DEA2C0", Length = "0x65")]
	[Token(Token = "0x6000886")]
	internal void set_lightShader(Shader value) { }

	[Address(RVA = "0x2DEAF30", Offset = "0x2DEA330", Length = "0x65")]
	[Token(Token = "0x6000888")]
	internal void set_projectedShadowShader(Shader value) { }

	[Address(RVA = "0x2DEAFA0", Offset = "0x2DEA3A0", Length = "0x65")]
	[Token(Token = "0x600088A")]
	internal void set_spriteShadowShader(Shader value) { }

	[Address(RVA = "0x2DEB010", Offset = "0x2DEA410", Length = "0x65")]
	[Token(Token = "0x600088C")]
	internal void set_spriteUnshadowShader(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000884")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

