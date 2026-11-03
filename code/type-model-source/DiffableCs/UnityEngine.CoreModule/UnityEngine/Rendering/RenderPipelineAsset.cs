namespace UnityEngine.Rendering;

[Token(Token = "0x20003E6")]
public abstract class RenderPipelineAsset : ScriptableObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CCC")]
	private readonly bool <requiresCompatibleRenderPipelineGlobalSettings>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000440")]
	public override Shader autodeskInteractiveMaskedShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DEA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043E")]
	public override Shader autodeskInteractiveShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DE8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043F")]
	public override Shader autodeskInteractiveTransparentShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DE9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044B")]
	public override Material default2DMaskMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044A")]
	public override Material default2DMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000445")]
	public override Material defaultLineMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DEF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700043D")]
	public override Material defaultMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DE7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000444")]
	public override Material defaultParticleMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DEE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044C")]
	public override Shader defaultShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044D")]
	public override Shader defaultSpeedTree7Shader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044E")]
	public override Shader defaultSpeedTree8Shader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700044F")]
	public override Shader defaultSpeedTree9Shader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000446")]
	public override Material defaultTerrainMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000449")]
	public override Material defaultUIETC1SupportedMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000447")]
	public override Material defaultUIMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000448")]
	public override Material defaultUIOverdrawMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DF2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000451")]
	public override Type pipelineType
	{
		[Address(RVA = "0x30C36D0", Offset = "0x30C2AD0", Length = "0x56")]
		[Token(Token = "0x6001DFC")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000452")]
	internal string pipelineTypeFullName
	{
		[Address(RVA = "0x30C3680", Offset = "0x30C2A80", Length = "0x4E")]
		[Token(Token = "0x6001DFD")]
		internal get { } //Length: 78
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	[Token(Token = "0x17000456")]
	public override String[] prefixedRenderingLayerMaskNames
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001E04")]
		 get { } //Length: 3
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	[Token(Token = "0x17000455")]
	public override String[] renderingLayerMaskNames
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001E03")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000450")]
	public override string renderPipelineShaderTag
	{
		[Address(RVA = "0x30C3730", Offset = "0x30C2B30", Length = "0x65")]
		[Token(Token = "0x6001DFA")]
		 get { } //Length: 101
	}

	[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", False)]
	[Token(Token = "0x17000454")]
	protected private override Type renderPipelineType
	{
		[Address(RVA = "0x30C37A0", Offset = "0x30C2BA0", Length = "0x56")]
		[Token(Token = "0x6001E02")]
		private get { } //Length: 86
	}

	[Token(Token = "0x17000453")]
	protected private override bool requiresCompatibleRenderPipelineGlobalSettings
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001E01")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000443")]
	public override Shader terrainDetailGrassBillboardShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DED")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000442")]
	public override Shader terrainDetailGrassShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DEC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000441")]
	public override Shader terrainDetailLitShader
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001DEB")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x30C3670", Offset = "0x30C2A70", Length = "0xB")]
	[Token(Token = "0x6001E05")]
	protected RenderPipelineAsset() { }

	[Token(Token = "0x6001DFB")]
	protected abstract RenderPipeline CreatePipeline() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001DFE")]
	protected override void EnsureGlobalSettings() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DEA")]
	public override Shader get_autodeskInteractiveMaskedShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DE8")]
	public override Shader get_autodeskInteractiveShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DE9")]
	public override Shader get_autodeskInteractiveTransparentShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF5")]
	public override Material get_default2DMaskMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF4")]
	public override Material get_default2DMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DEF")]
	public override Material get_defaultLineMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DE7")]
	public override Material get_defaultMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DEE")]
	public override Material get_defaultParticleMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF6")]
	public override Shader get_defaultShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF7")]
	public override Shader get_defaultSpeedTree7Shader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF8")]
	public override Shader get_defaultSpeedTree8Shader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF9")]
	public override Shader get_defaultSpeedTree9Shader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF0")]
	public override Material get_defaultTerrainMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF3")]
	public override Material get_defaultUIETC1SupportedMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF1")]
	public override Material get_defaultUIMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DF2")]
	public override Material get_defaultUIOverdrawMaterial() { }

	[Address(RVA = "0x30C36D0", Offset = "0x30C2AD0", Length = "0x56")]
	[Token(Token = "0x6001DFC")]
	public override Type get_pipelineType() { }

	[Address(RVA = "0x30C3680", Offset = "0x30C2A80", Length = "0x4E")]
	[Token(Token = "0x6001DFD")]
	internal string get_pipelineTypeFullName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001E04")]
	public override String[] get_prefixedRenderingLayerMaskNames() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001E03")]
	public override String[] get_renderingLayerMaskNames() { }

	[Address(RVA = "0x30C3730", Offset = "0x30C2B30", Length = "0x65")]
	[Token(Token = "0x6001DFA")]
	public override string get_renderPipelineShaderTag() { }

	[Address(RVA = "0x30C37A0", Offset = "0x30C2BA0", Length = "0x56")]
	[Token(Token = "0x6001E02")]
	protected private override Type get_renderPipelineType() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001E01")]
	protected private override bool get_requiresCompatibleRenderPipelineGlobalSettings() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DED")]
	public override Shader get_terrainDetailGrassBillboardShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DEC")]
	public override Shader get_terrainDetailGrassShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001DEB")]
	public override Shader get_terrainDetailLitShader() { }

	[Address(RVA = "0x30C3560", Offset = "0x30C2960", Length = "0x64")]
	[Token(Token = "0x6001DE6")]
	internal RenderPipeline InternalCreatePipeline() { }

	[Address(RVA = "0x30C35D0", Offset = "0x30C29D0", Length = "0x7")]
	[Token(Token = "0x6001E00")]
	protected override void OnDisable() { }

	[Address(RVA = "0x30C35E0", Offset = "0x30C29E0", Length = "0x8A")]
	[Token(Token = "0x6001DFF")]
	protected override void OnValidate() { }

}

