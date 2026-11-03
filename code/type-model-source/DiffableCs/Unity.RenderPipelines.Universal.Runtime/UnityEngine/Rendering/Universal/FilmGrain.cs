namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000105")]
[VolumeComponentMenu("Post-processing/Film Grain")]
public sealed class FilmGrain : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005E1")]
	[Tooltip("The type of grain to use. You can select a preset or provide your own texture by selecting Custom.")]
	public FilmGrainLookupParameter type; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005E2")]
	[Tooltip("Use the slider to set the strength of the Film Grain effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005E3")]
	[Tooltip("Controls the noisiness response curve based on scene luminance. Higher values mean less noise in light areas.")]
	public ClampedFloatParameter response; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005E4")]
	[Tooltip("A tileable texture to use for the grain. The neutral value is 0.5 where no grain is applied.")]
	public NoInterpTextureParameter texture; //Field offset: 0x50

	[Address(RVA = "0x2DABF40", Offset = "0x2DAB340", Length = "0x15E")]
	[Token(Token = "0x60006CD")]
	public FilmGrain() { }

	[Address(RVA = "0x2DABE70", Offset = "0x2DAB270", Length = "0xC9")]
	[Token(Token = "0x60006CB")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006CC")]
	public override bool IsTileCompatible() { }

}

