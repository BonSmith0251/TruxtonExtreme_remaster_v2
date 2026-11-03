namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200011C")]
[VolumeComponentMenu("Post-processing/White Balance")]
public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000633")]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public ClampedFloatParameter temperature; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000634")]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public ClampedFloatParameter tint; //Field offset: 0x40

	[Address(RVA = "0x2DC9260", Offset = "0x2DC8660", Length = "0xCD")]
	[Token(Token = "0x60006F3")]
	public WhiteBalance() { }

	[Address(RVA = "0x2DC91E0", Offset = "0x2DC85E0", Length = "0x76")]
	[Token(Token = "0x60006F1")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006F2")]
	public override bool IsTileCompatible() { }

}

