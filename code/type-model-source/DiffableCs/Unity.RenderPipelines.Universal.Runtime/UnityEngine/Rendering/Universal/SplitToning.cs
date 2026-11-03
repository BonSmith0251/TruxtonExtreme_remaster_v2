namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000113")]
[VolumeComponentMenu("Post-processing/Split Toning")]
public sealed class SplitToning : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000617")]
	[Tooltip("The color to use for shadows.")]
	public ColorParameter shadows; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000618")]
	[Tooltip("The color to use for highlights.")]
	public ColorParameter highlights; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000619")]
	[Tooltip("Balance between the colors in the highlights and shadows.")]
	public ClampedFloatParameter balance; //Field offset: 0x48

	[Address(RVA = "0x2DC6E60", Offset = "0x2DC6260", Length = "0x14F")]
	[Token(Token = "0x60006E7")]
	public SplitToning() { }

	[Address(RVA = "0x2DC6DC0", Offset = "0x2DC61C0", Length = "0x9D")]
	[Token(Token = "0x60006E5")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006E6")]
	public override bool IsTileCompatible() { }

}

