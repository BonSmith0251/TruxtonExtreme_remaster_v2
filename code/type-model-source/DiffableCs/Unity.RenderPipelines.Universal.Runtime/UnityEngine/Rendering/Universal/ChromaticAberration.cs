namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000FD")]
[VolumeComponentMenu("Post-processing/Chromatic Aberration")]
public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B6")]
	[Tooltip("Use the slider to set the strength of the Chromatic Aberration effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x38

	[Address(RVA = "0x2DA9700", Offset = "0x2DA8B00", Length = "0x80")]
	[Token(Token = "0x60006BC")]
	public ChromaticAberration() { }

	[Address(RVA = "0x2DA96C0", Offset = "0x2DA8AC0", Length = "0x33")]
	[Token(Token = "0x60006BA")]
	public override bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006BB")]
	public override bool IsTileCompatible() { }

}

