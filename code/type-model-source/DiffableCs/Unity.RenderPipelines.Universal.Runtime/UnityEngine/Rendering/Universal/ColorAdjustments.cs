namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000FE")]
[VolumeComponentMenu("Post-processing/Color Adjustments")]
public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B7")]
	[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005B8")]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public ClampedFloatParameter contrast; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005B9")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005BA")]
	[Tooltip("Shift the hue of all colors.")]
	public ClampedFloatParameter hueShift; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005BB")]
	[Tooltip("Pushes the intensity of all colors.")]
	public ClampedFloatParameter saturation; //Field offset: 0x58

	[Address(RVA = "0x2DA9880", Offset = "0x2DA8C80", Length = "0x1B6")]
	[Token(Token = "0x60006BF")]
	public ColorAdjustments() { }

	[Address(RVA = "0x2DA9780", Offset = "0x2DA8B80", Length = "0xFC")]
	[Token(Token = "0x60006BD")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006BE")]
	public override bool IsTileCompatible() { }

}

