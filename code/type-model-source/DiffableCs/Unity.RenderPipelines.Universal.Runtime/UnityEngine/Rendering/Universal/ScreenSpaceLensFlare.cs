namespace UnityEngine.Rendering.Universal;

[DisplayInfo(name = "Screen Space Lens Flare")]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000110")]
[VolumeComponentMenu("Post-processing/Screen Space Lens Flare")]
public class ScreenSpaceLensFlare : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005FE")]
	public MinFloatParameter intensity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005FF")]
	public ColorParameter tintColor; //Field offset: 0x40
	[AdditionalProperty]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000600")]
	public ClampedIntParameter bloomMip; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Header("Flares")]
	[Token(Token = "0x4000601")]
	public MinFloatParameter firstFlareIntensity; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000602")]
	public MinFloatParameter secondaryFlareIntensity; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000603")]
	public MinFloatParameter warpedFlareIntensity; //Field offset: 0x60
	[AdditionalProperty]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000604")]
	public Vector2Parameter warpedFlareScale; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000605")]
	public ClampedIntParameter samples; //Field offset: 0x70
	[AdditionalProperty]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000606")]
	public ClampedFloatParameter sampleDimmer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000607")]
	public ClampedFloatParameter vignetteEffect; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000608")]
	public ClampedFloatParameter startingPosition; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000609")]
	public ClampedFloatParameter scale; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Header("Streaks")]
	[Token(Token = "0x400060A")]
	public MinFloatParameter streaksIntensity; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400060B")]
	public ClampedFloatParameter streaksLength; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400060C")]
	public FloatParameter streaksOrientation; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400060D")]
	public ClampedFloatParameter streaksThreshold; //Field offset: 0xB0
	[AdditionalProperty]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400060E")]
	public ScreenSpaceLensFlareResolutionParameter resolution; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Header("Chromatic Abberation")]
	[Token(Token = "0x400060F")]
	public ClampedFloatParameter chromaticAbberationIntensity; //Field offset: 0xC0

	[Address(RVA = "0x2DC5BF0", Offset = "0x2DC4FF0", Length = "0x51D")]
	[Token(Token = "0x60006E0")]
	public ScreenSpaceLensFlare() { }

	[Address(RVA = "0x2DA96C0", Offset = "0x2DA8AC0", Length = "0x33")]
	[Token(Token = "0x60006DD")]
	public override bool IsActive() { }

	[Address(RVA = "0x2DC5BB0", Offset = "0x2DC4FB0", Length = "0x36")]
	[Token(Token = "0x60006DE")]
	public bool IsStreaksActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006DF")]
	public override bool IsTileCompatible() { }

}

