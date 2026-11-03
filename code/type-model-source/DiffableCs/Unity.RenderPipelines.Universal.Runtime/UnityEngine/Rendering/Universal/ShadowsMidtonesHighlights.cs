namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000112")]
[VolumeComponentMenu("Post-processing/Shadows, Midtones, Highlights")]
public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000610")]
	public Vector4Parameter shadows; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000611")]
	public Vector4Parameter midtones; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000612")]
	public Vector4Parameter highlights; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Header("Shadow Limits")]
	[Token(Token = "0x4000613")]
	[Tooltip("Start point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsStart; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000614")]
	[Tooltip("End point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsEnd; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Header("Highlight Limits")]
	[Token(Token = "0x4000615")]
	[Tooltip("Start point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsStart; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000616")]
	[Tooltip("End point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsEnd; //Field offset: 0x68

	[Address(RVA = "0x2DC65F0", Offset = "0x2DC59F0", Length = "0x1F5")]
	[Token(Token = "0x60006E4")]
	public ShadowsMidtonesHighlights() { }

	[Address(RVA = "0x2DC6540", Offset = "0x2DC5940", Length = "0xA4")]
	[Token(Token = "0x60006E2")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006E3")]
	public override bool IsTileCompatible() { }

}

