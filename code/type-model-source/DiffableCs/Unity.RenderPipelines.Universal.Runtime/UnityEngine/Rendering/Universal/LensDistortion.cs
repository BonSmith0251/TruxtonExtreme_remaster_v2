namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000107")]
[VolumeComponentMenu("Post-processing/Lens Distortion")]
public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005E5")]
	[Tooltip("Total distortion amount.")]
	public ClampedFloatParameter intensity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005E6")]
	[Tooltip("Intensity multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
	public ClampedFloatParameter xMultiplier; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005E7")]
	[Tooltip("Intensity multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
	public ClampedFloatParameter yMultiplier; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005E8")]
	[Tooltip("Distortion center point. 0.5,0.5 is center of the screen.")]
	public Vector2Parameter center; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005E9")]
	[Tooltip("Controls global screen scaling for the distortion effect. Use this to hide the screen borders when using high \"Intensity.\"")]
	public ClampedFloatParameter scale; //Field offset: 0x58

	[Address(RVA = "0x2DAE0A0", Offset = "0x2DAD4A0", Length = "0x1A8")]
	[Token(Token = "0x60006D1")]
	public LensDistortion() { }

	[Address(RVA = "0x2DADFF0", Offset = "0x2DAD3F0", Length = "0xAA")]
	[Token(Token = "0x60006CF")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006D0")]
	public override bool IsTileCompatible() { }

}

