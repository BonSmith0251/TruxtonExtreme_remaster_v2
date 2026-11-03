namespace UnityEngine.Rendering;

[Token(Token = "0x20001BD")]
public static class ColorUtils
{
	[Token(Token = "0x40008A2")]
	public static float s_LightMeterCalibrationConstant; //Field offset: 0x0
	[Token(Token = "0x40008A3")]
	public static float s_LensAttenuation; //Field offset: 0x4

	[Token(Token = "0x170001C0")]
	public static float lensImperfectionExposureScale
	{
		[Address(RVA = "0x2C459B0", Offset = "0x2C44DB0", Length = "0x64")]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x2C45960", Offset = "0x2C44D60", Length = "0x4E")]
	[Token(Token = "0x6000D98")]
	private static ColorUtils() { }

	[Address(RVA = "0x2C44BB0", Offset = "0x2C43FB0", Length = "0x8D")]
	[Token(Token = "0x6000D8B")]
	public static Vector3 CIExyToLMS(float x, float y) { }

	[Address(RVA = "0x2C44C40", Offset = "0x2C44040", Length = "0x176")]
	[Token(Token = "0x6000D8C")]
	public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) { }

	[Address(RVA = "0x2C44E70", Offset = "0x2C44270", Length = "0x76")]
	[Token(Token = "0x6000D91")]
	public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) { }

	[Address(RVA = "0x2C44DC0", Offset = "0x2C441C0", Length = "0xB0")]
	[Token(Token = "0x6000D94")]
	public static float ComputeEV100FromAvgLuminance(float avgLuminance) { }

	[Address(RVA = "0x2C44EF0", Offset = "0x2C442F0", Length = "0x4A")]
	[Token(Token = "0x6000D95")]
	public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) { }

	[Address(RVA = "0x2C44F40", Offset = "0x2C44340", Length = "0xC2")]
	[Token(Token = "0x6000D92")]
	public static float ConvertEV100ToExposure(float EV100) { }

	[Address(RVA = "0x2C45010", Offset = "0x2C44410", Length = "0xF7")]
	[Token(Token = "0x6000D93")]
	public static float ConvertExposureToEV100(float exposure) { }

	[Address(RVA = "0x2C459B0", Offset = "0x2C44DB0", Length = "0x64")]
	[Token(Token = "0x6000D89")]
	public static float get_lensImperfectionExposureScale() { }

	[Address(RVA = "0x2C45110", Offset = "0x2C44510", Length = "0x2F")]
	[Token(Token = "0x6000D90")]
	public static float Luminance(in Color color) { }

	[Address(RVA = "0x2C45140", Offset = "0x2C44540", Length = "0x35E")]
	[Token(Token = "0x6000D8E")]
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain) { }

	[Address(RVA = "0x2C454A0", Offset = "0x2C448A0", Length = "0x2AD")]
	[Token(Token = "0x6000D8D")]
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights) { }

	[Address(RVA = "0x2C45750", Offset = "0x2C44B50", Length = "0xD9")]
	[Token(Token = "0x6000D8F")]
	public static ValueTuple<Vector4, Vector4> PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance) { }

	[Address(RVA = "0x2C45830", Offset = "0x2C44C30", Length = "0x2A")]
	[Token(Token = "0x6000D8A")]
	public static float StandardIlluminantY(float x) { }

	[Address(RVA = "0x2C45860", Offset = "0x2C44C60", Length = "0x7F")]
	[Token(Token = "0x6000D96")]
	public static uint ToHex(Color c) { }

	[Address(RVA = "0x2C458E0", Offset = "0x2C44CE0", Length = "0x77")]
	[Token(Token = "0x6000D97")]
	public static Color ToRGBA(uint hex) { }

}

