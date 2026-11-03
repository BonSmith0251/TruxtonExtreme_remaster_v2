namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000FF")]
[VolumeComponentMenu("Post-processing/Color Curves")]
public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005BC")]
	[Tooltip("Affects the luminance across the whole image.")]
	public TextureCurveParameter master; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005BD")]
	[Tooltip("Affects the red channel intensity across the whole image.")]
	public TextureCurveParameter red; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005BE")]
	[Tooltip("Affects the green channel intensity across the whole image.")]
	public TextureCurveParameter green; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005BF")]
	[Tooltip("Affects the blue channel intensity across the whole image.")]
	public TextureCurveParameter blue; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005C0")]
	[Tooltip("Shifts the input hue (x-axis) according to the output hue (y-axis).")]
	public TextureCurveParameter hueVsHue; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005C1")]
	[Tooltip("Adjusts saturation (y-axis) according to the input hue (x-axis).")]
	public TextureCurveParameter hueVsSat; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005C2")]
	[Tooltip("Adjusts saturation (y-axis) according to the input saturation (x-axis).")]
	public TextureCurveParameter satVsSat; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005C3")]
	[Tooltip("Adjusts saturation (y-axis) according to the input luminance (x-axis).")]
	public TextureCurveParameter lumVsSat; //Field offset: 0x70

	[Address(RVA = "0x2DA9A40", Offset = "0x2DA8E40", Length = "0x77A")]
	[Token(Token = "0x60006C2")]
	public ColorCurves() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60006C0")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006C1")]
	public override bool IsTileCompatible() { }

}

