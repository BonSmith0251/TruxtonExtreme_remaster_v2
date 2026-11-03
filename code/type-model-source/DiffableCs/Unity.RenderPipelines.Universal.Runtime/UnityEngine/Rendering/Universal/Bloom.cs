namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000B3")]
[VolumeComponentMenu("Post-processing/Bloom")]
public sealed class Bloom : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Obsolete("This is obsolete, please use maxIterations instead. #from(2022.2) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x400038C")]
	[Tooltip("The number of final iterations to skip in the effect processing sequence.")]
	public ClampedIntParameter skipIterations; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Header("Bloom")]
	[Token(Token = "0x400038D")]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public MinFloatParameter threshold; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400038E")]
	[Tooltip("Strength of the bloom filter.")]
	public MinFloatParameter intensity; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400038F")]
	[Tooltip("Set the radius of the bloom effect.")]
	public ClampedFloatParameter scatter; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000390")]
	[Tooltip("Set the maximum intensity that Unity uses to calculate Bloom. If pixels in your Scene are more intense than this, URP renders them at their current intensity, but uses this intensity value for the purposes of Bloom calculations.")]
	public MinFloatParameter clamp; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000391")]
	[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
	public ColorParameter tint; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000392")]
	[Tooltip("Use bicubic sampling instead of bilinear sampling for the upsampling passes. This is slightly more expensive but helps getting smoother visuals.")]
	public BoolParameter highQualityFiltering; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000393")]
	[Tooltip("Set the filtering algorithm for the Bloom effect.")]
	public BloomFilterModeParameter filter; //Field offset: 0x70
	[AdditionalProperty]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000394")]
	[Tooltip("The starting resolution that this effect begins processing.")]
	public DownscaleParameter downscale; //Field offset: 0x78
	[AdditionalProperty]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000395")]
	[Tooltip("The maximum number of iterations in the effect processing sequence.")]
	public ClampedIntParameter maxIterations; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Header("Lens Dirt")]
	[Token(Token = "0x4000396")]
	[Tooltip("Dirtiness texture to add smudges or dust to the bloom effect.")]
	public TextureParameter dirtTexture; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000397")]
	[Tooltip("Amount of dirtiness.")]
	public MinFloatParameter dirtIntensity; //Field offset: 0x90

	[Address(RVA = "0x2D6F340", Offset = "0x2D6E740", Length = "0x367")]
	[Token(Token = "0x600043F")]
	public Bloom() { }

	[Address(RVA = "0x2D6F300", Offset = "0x2D6E700", Length = "0x33")]
	[Token(Token = "0x600043D")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x600043E")]
	public override bool IsTileCompatible() { }

}

