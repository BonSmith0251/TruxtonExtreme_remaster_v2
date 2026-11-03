namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000117")]
[VolumeComponentMenu("Post-processing/Tonemapping")]
public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000625")]
	[Tooltip("Select a tonemapping algorithm to use for the color grading process.")]
	public TonemappingModeParameter mode; //Field offset: 0x38
	[AdditionalProperty]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000626")]
	[Tooltip("Specifies the range reduction mode used when HDR output is enabled and Neutral tonemapping is enabled.")]
	public NeutralRangeReductionModeParameter neutralHDRRangeReductionMode; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000627")]
	[Tooltip("Use the ACES preset for HDR displays.")]
	public HDRACESPresetParameter acesPreset; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000628")]
	[Tooltip("Specify how much hue to preserve. Values closer to 0 are likely to preserve hue. As values get closer to 1, Unity doesn't correct hue shifts.")]
	public ClampedFloatParameter hueShiftAmount; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000629")]
	[Tooltip("Enable to use values detected from the output device as paper white. When enabled, output images might differ between SDR and HDR. For best accuracy, set this value manually.")]
	public BoolParameter detectPaperWhite; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400062A")]
	[Tooltip("The reference brightness of a paper white surface. This property determines the maximum brightness of UI. The brightness of the scene is scaled relative to this value. The value is in nits.")]
	public ClampedFloatParameter paperWhite; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400062B")]
	[Tooltip("Enable to use the minimum and maximum brightness values detected from the output device. For best accuracy, considering calibrating these values manually.")]
	public BoolParameter detectBrightnessLimits; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400062C")]
	[Tooltip("The minimum brightness of the screen (in nits). This value is assumed to be 0.005f with ACES Tonemap.")]
	public ClampedFloatParameter minNits; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400062D")]
	[Tooltip("The maximum brightness of the screen (in nits). This value is defined by the preset when using ACES Tonemap.")]
	public ClampedFloatParameter maxNits; //Field offset: 0x78

	[Address(RVA = "0x2DC7B10", Offset = "0x2DC6F10", Length = "0x2D5")]
	[Token(Token = "0x60006EA")]
	public Tonemapping() { }

	[Address(RVA = "0x2DC7AE0", Offset = "0x2DC6EE0", Length = "0x2F")]
	[Token(Token = "0x60006E8")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006E9")]
	public override bool IsTileCompatible() { }

}

