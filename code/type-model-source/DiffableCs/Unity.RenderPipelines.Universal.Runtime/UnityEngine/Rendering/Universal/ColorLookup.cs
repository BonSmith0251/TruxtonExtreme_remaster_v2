namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000100")]
[VolumeComponentMenu("Post-processing/Color Lookup")]
public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C4")]
	[Tooltip("A 2D Lookup Texture (LUT) to use for color grading.")]
	public TextureParameter texture; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C5")]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public ClampedFloatParameter contribution; //Field offset: 0x40

	[Address(RVA = "0x2DAA4C0", Offset = "0x2DA98C0", Length = "0xBB")]
	[Token(Token = "0x60006C6")]
	public ColorLookup() { }

	[Address(RVA = "0x2DAA1C0", Offset = "0x2DA95C0", Length = "0x49")]
	[Token(Token = "0x60006C3")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006C4")]
	public override bool IsTileCompatible() { }

	[Address(RVA = "0x2DAA210", Offset = "0x2DA9610", Length = "0x2A8")]
	[Token(Token = "0x60006C5")]
	public bool ValidateLUT() { }

}

