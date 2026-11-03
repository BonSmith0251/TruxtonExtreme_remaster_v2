namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "Additional Shader Stripping Settings", Order = 40)]
[ElementInfo(Order = 10)]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20001A1")]
public class URPShaderStrippingSetting : IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x20001A2")]
	public enum Version : int
	{
		Initial = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400091C")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400091D")]
	[Tooltip("Controls whether to automatically strip post processing shader variants based on VolumeProfile components. Stripping is done based on VolumeProfiles in project, their usage in scenes is not considered.")]
	private bool m_StripUnusedPostProcessingVariants; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	[Token(Token = "0x400091E")]
	[Tooltip("Controls whether to strip variants if the feature is disabled.")]
	private bool m_StripUnusedVariants; //Field offset: 0x15
	[FieldOffset(Offset = "0x16")]
	[SerializeField]
	[Token(Token = "0x400091F")]
	[Tooltip("Controls whether Screen Coordinates Override shader variants are automatically stripped.")]
	private bool m_StripScreenCoordOverrideVariants; //Field offset: 0x16

	[Token(Token = "0x17000223")]
	public bool stripScreenCoordOverrideVariants
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFB240", Offset = "0x2DFA640", Length = "0x66")]
		[Token(Token = "0x6000900")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000221")]
	public bool stripUnusedPostProcessingVariants
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFB2B0", Offset = "0x2DFA6B0", Length = "0x66")]
		[Token(Token = "0x60008FC")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000222")]
	public bool stripUnusedVariants
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x60008FD")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFB320", Offset = "0x2DFA720", Length = "0x66")]
		[Token(Token = "0x60008FE")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000220")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60008FA")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x2DFB230", Offset = "0x2DFA630", Length = "0xD")]
	[Token(Token = "0x6000901")]
	public URPShaderStrippingSetting() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[Token(Token = "0x60008FF")]
	public bool get_stripScreenCoordOverrideVariants() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x60008FB")]
	public bool get_stripUnusedPostProcessingVariants() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x60008FD")]
	public bool get_stripUnusedVariants() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60008FA")]
	public override int get_version() { }

	[Address(RVA = "0x2DFB240", Offset = "0x2DFA640", Length = "0x66")]
	[Token(Token = "0x6000900")]
	public void set_stripScreenCoordOverrideVariants(bool value) { }

	[Address(RVA = "0x2DFB2B0", Offset = "0x2DFA6B0", Length = "0x66")]
	[Token(Token = "0x60008FC")]
	public void set_stripUnusedPostProcessingVariants(bool value) { }

	[Address(RVA = "0x2DFB320", Offset = "0x2DFA720", Length = "0x66")]
	[Token(Token = "0x60008FE")]
	public void set_stripUnusedVariants(bool value) { }

}

