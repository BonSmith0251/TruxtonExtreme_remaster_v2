namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000102")]
[VolumeComponentMenu("Post-processing/Depth Of Field")]
public sealed class DepthOfField : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CA")]
	[Tooltip("Use \"Gaussian\" for a faster but non physical depth of field; \"Bokeh\" for a more realistic but slower depth of field.")]
	public DepthOfFieldModeParameter mode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005CB")]
	[Tooltip("The distance at which the blurring will start.")]
	public MinFloatParameter gaussianStart; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005CC")]
	[Tooltip("The distance at which the blurring will reach its maximum radius.")]
	public MinFloatParameter gaussianEnd; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005CD")]
	[Tooltip("The maximum radius of the gaussian blur. Values above 1 may show under-sampling artifacts.")]
	public ClampedFloatParameter gaussianMaxRadius; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005CE")]
	[Tooltip("Use higher quality sampling to reduce flickering and improve the overall blur smoothness.")]
	public BoolParameter highQualitySampling; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005CF")]
	[Tooltip("The distance to the point of focus.")]
	public MinFloatParameter focusDistance; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005D0")]
	[Tooltip("The ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public ClampedFloatParameter aperture; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005D1")]
	[Tooltip("The distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	public ClampedFloatParameter focalLength; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005D2")]
	[Tooltip("The number of aperture blades.")]
	public ClampedIntParameter bladeCount; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005D3")]
	[Tooltip("The curvature of aperture blades. The smaller the value is, the more visible aperture blades are. A value of 1 will make the bokeh perfectly circular.")]
	public ClampedFloatParameter bladeCurvature; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005D4")]
	[Tooltip("The rotation of aperture blades in degrees.")]
	public ClampedFloatParameter bladeRotation; //Field offset: 0x88

	[Address(RVA = "0x2DAA660", Offset = "0x2DA9A60", Length = "0x354")]
	[Token(Token = "0x60006C9")]
	public DepthOfField() { }

	[Address(RVA = "0x2DAA5E0", Offset = "0x2DA99E0", Length = "0x7E")]
	[Token(Token = "0x60006C7")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006C8")]
	public override bool IsTileCompatible() { }

}

