namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200017F")]
internal class ScreenSpaceAmbientOcclusionSettings
{
	[Token(Token = "0x2000183")]
	public enum AOMethodOptions : int
	{
		BlueNoise = 0,
		InterleavedGradient = 1,
	}

	[Token(Token = "0x2000182")]
	public enum AOSampleOption : int
	{
		High = 0,
		Medium = 1,
		Low = 2,
	}

	[Token(Token = "0x2000184")]
	public enum BlurQualityOptions : int
	{
		High = 0,
		Medium = 1,
		Low = 2,
	}

	[Token(Token = "0x2000180")]
	public enum DepthSource : int
	{
		Depth = 0,
		DepthNormals = 1,
	}

	[Token(Token = "0x2000181")]
	public enum NormalQuality : int
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000895")]
	internal AOMethodOptions AOMethod; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000896")]
	internal bool Downsample; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	[Token(Token = "0x4000897")]
	internal bool AfterOpaque; //Field offset: 0x15
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000898")]
	internal DepthSource Source; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000899")]
	internal NormalQuality NormalSamples; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400089A")]
	internal float Intensity; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400089B")]
	internal float DirectLightingStrength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400089C")]
	internal float Radius; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400089D")]
	internal AOSampleOption Samples; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400089E")]
	internal BlurQualityOptions BlurQuality; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400089F")]
	internal float Falloff; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40008A0")]
	internal int SampleCount; //Field offset: 0x38

	[Address(RVA = "0x2DDAB90", Offset = "0x2DD9F90", Length = "0x3F")]
	[Token(Token = "0x600081D")]
	public ScreenSpaceAmbientOcclusionSettings() { }

}

