namespace UnityEngine.Rendering;

[Token(Token = "0x200004C")]
public enum DynamicResUpscaleFilter : byte
{
	Bilinear = 0,
	CatmullRom = 1,
	Lanczos = 2,
	ContrastAdaptiveSharpen = 3,
	EdgeAdaptiveScalingUpres = 4,
	TAAU = 5,
}

