namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000FC")]
[VolumeComponentMenu("Post-processing/Channel Mixer")]
public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005AD")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter redOutRedIn; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005AE")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter redOutGreenIn; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005AF")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter redOutBlueIn; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005B0")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter greenOutRedIn; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005B1")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter greenOutGreenIn; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005B2")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter greenOutBlueIn; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005B3")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public ClampedFloatParameter blueOutRedIn; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005B4")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public ClampedFloatParameter blueOutGreenIn; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005B5")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public ClampedFloatParameter blueOutBlueIn; //Field offset: 0x78

	[Address(RVA = "0x2DA9420", Offset = "0x2DA8820", Length = "0x292")]
	[Token(Token = "0x60006B9")]
	public ChannelMixer() { }

	[Address(RVA = "0x2DA9260", Offset = "0x2DA8660", Length = "0x1B7")]
	[Token(Token = "0x60006B7")]
	public override bool IsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Obsolete("Unused. #from(2023.1)")]
	[Token(Token = "0x60006B8")]
	public override bool IsTileCompatible() { }

}

