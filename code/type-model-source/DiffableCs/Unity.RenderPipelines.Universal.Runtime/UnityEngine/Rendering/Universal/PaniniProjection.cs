namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200010E")]
[VolumeComponentMenu("Post-processing/Panini Projection")]
public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F8")]
	[Tooltip("Panini projection distance.")]
	public ClampedFloatParameter distance; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005F9")]
	[Tooltip("Panini projection crop to fit.")]
	public ClampedFloatParameter cropToFit; //Field offset: 0x40

	[Address(RVA = "0x2DB52F0", Offset = "0x2DB46F0", Length = "0xC3")]
	[Token(Token = "0x60006DC")]
	public PaniniProjection() { }

	[Address(RVA = "0x2DA96C0", Offset = "0x2DA8AC0", Length = "0x33")]
	[Token(Token = "0x60006DA")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006DB")]
	public override bool IsTileCompatible() { }

}

