namespace UnityEngine.Rendering;

[Token(Token = "0x2000231")]
internal class VrsResources : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CC")]
	internal ProfilingSampler conversionProfilingSampler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009CD")]
	internal ProfilingSampler visualizationProfilingSampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009CE")]
	internal GraphicsBuffer conversionLutBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009CF")]
	internal GraphicsBuffer visualizationLutBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009D0")]
	internal ComputeShader textureComputeShader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009D1")]
	internal int textureReduceKernel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40009D2")]
	internal int textureCopyKernel; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009D3")]
	internal Vector2Int tileSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009D4")]
	internal GraphicsBuffer validatedShadingRateFragmentSizeBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009D5")]
	private Shader m_VisualizationShader; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009D6")]
	private Material m_VisualizationMaterial; //Field offset: 0x58

	[Token(Token = "0x17000205")]
	internal Material visualizationMaterial
	{
		[Address(RVA = "0x2C89E30", Offset = "0x2C89230", Length = "0xA9")]
		[Token(Token = "0x6000FB8")]
		internal get { } //Length: 169
	}

	[Address(RVA = "0x2C89D50", Offset = "0x2C89150", Length = "0xDA")]
	[Token(Token = "0x6000FB9")]
	internal VrsResources(VrsRenderPipelineRuntimeResources resources) { }

	[Address(RVA = "0x2C89530", Offset = "0x2C88930", Length = "0x1AF")]
	[Token(Token = "0x6000FBE")]
	private void AllocFragmentSizeBuffer() { }

	[Address(RVA = "0x2C89780", Offset = "0x2C88B80", Length = "0x7")]
	[Token(Token = "0x6000FBB")]
	public override void Dispose() { }

	[Address(RVA = "0x2C896E0", Offset = "0x2C88AE0", Length = "0x94")]
	[Token(Token = "0x6000FBD")]
	private void DisposeResources() { }

	[Address(RVA = "0x2C89790", Offset = "0x2C88B90", Length = "0x94")]
	[Token(Token = "0x6000FBA")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2C89E30", Offset = "0x2C89230", Length = "0xA9")]
	[Token(Token = "0x6000FB8")]
	internal Material get_visualizationMaterial() { }

	[Address(RVA = "0x2C89830", Offset = "0x2C88C30", Length = "0x266")]
	[Token(Token = "0x6000FBF")]
	private bool InitComputeShader(VrsRenderPipelineRuntimeResources resources) { }

	[Address(RVA = "0x2C89AA0", Offset = "0x2C88EA0", Length = "0x252")]
	[Token(Token = "0x6000FBC")]
	private void InitializeResources(VrsRenderPipelineRuntimeResources resources) { }

	[Address(RVA = "0x2C89D00", Offset = "0x2C89100", Length = "0x4E")]
	[Token(Token = "0x6000FC0")]
	private static int TryFindKernel(ComputeShader computeShader, string name) { }

}

