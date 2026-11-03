namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200011B")]
[VolumeComponentMenu("Post-processing/Vignette")]
public sealed class Vignette : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400062E")]
	[Tooltip("Vignette color.")]
	public ColorParameter color; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400062F")]
	[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
	public Vector2Parameter center; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000630")]
	[Tooltip("Use the slider to set the strength of the Vignette effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000631")]
	[Tooltip("Smoothness of the vignette borders.")]
	public ClampedFloatParameter smoothness; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000632")]
	[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
	public BoolParameter rounded; //Field offset: 0x58

	[Address(RVA = "0x2DC9020", Offset = "0x2DC8420", Length = "0x1BB")]
	[Token(Token = "0x60006F0")]
	public Vignette() { }

	[Address(RVA = "0x2D6F300", Offset = "0x2D6E700", Length = "0x33")]
	[Token(Token = "0x60006EE")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006EF")]
	public override bool IsTileCompatible() { }

}

