namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000108")]
[VolumeComponentMenu("Post-processing/Lift, Gamma, Gain")]
public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005EA")]
	public Vector4Parameter lift; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005EB")]
	public Vector4Parameter gamma; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005EC")]
	public Vector4Parameter gain; //Field offset: 0x48

	[Address(RVA = "0x2DAE300", Offset = "0x2DAD700", Length = "0xFA")]
	[Token(Token = "0x60006D4")]
	public LiftGammaGain() { }

	[Address(RVA = "0x2DAE250", Offset = "0x2DAD650", Length = "0xA4")]
	[Token(Token = "0x60006D2")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006D3")]
	public override bool IsTileCompatible() { }

}

