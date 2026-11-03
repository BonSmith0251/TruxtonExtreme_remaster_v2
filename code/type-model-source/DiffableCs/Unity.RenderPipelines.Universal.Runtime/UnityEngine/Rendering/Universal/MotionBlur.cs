namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200010B")]
[VolumeComponentMenu("Post-processing/Motion Blur")]
public sealed class MotionBlur : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F4")]
	[Tooltip("The motion blur technique to use. If you don't need object motion blur, CameraOnly will result in better performance.")]
	public MotionBlurModeParameter mode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005F5")]
	[Tooltip("The quality of the effect. Lower presets will result in better performance at the expense of visual quality.")]
	public MotionBlurQualityParameter quality; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005F6")]
	[Tooltip("The strength of the motion blur filter. Acts as a multiplier for velocities.")]
	public ClampedFloatParameter intensity; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005F7")]
	[Tooltip("Sets the maximum length, as a fraction of the screen's full resolution, that the velocity resulting from Camera rotation can have. Lower values will improve performance.")]
	public ClampedFloatParameter clamp; //Field offset: 0x50

	[Address(RVA = "0x2DB2010", Offset = "0x2DB1410", Length = "0x17E")]
	[Token(Token = "0x60006D7")]
	public MotionBlur() { }

	[Address(RVA = "0x2D6F300", Offset = "0x2D6E700", Length = "0x33")]
	[Token(Token = "0x60006D5")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006D6")]
	public override bool IsTileCompatible() { }

}

