namespace UnityEngine;

[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[NativeHeader("NativeKernel/Math/FloatConversion.h")]
[Token(Token = "0x2000158")]
public struct Mathf
{
	[Token(Token = "0x40005B5")]
	public static readonly float Epsilon; //Field offset: 0x0

	[Address(RVA = "0x304B590", Offset = "0x304A990", Length = "0xBE")]
	[Token(Token = "0x600111C")]
	private static Mathf() { }

	[Address(RVA = "0x304A430", Offset = "0x3049830", Length = "0x46")]
	[Token(Token = "0x60010F5")]
	public static int Abs(int value) { }

	[Address(RVA = "0x304A3D0", Offset = "0x30497D0", Length = "0x51")]
	[Token(Token = "0x60010F4")]
	public static float Abs(float f) { }

	[Address(RVA = "0x304A480", Offset = "0x3049880", Length = "0x57")]
	[Token(Token = "0x60010F0")]
	public static float Acos(float f) { }

	[Address(RVA = "0x304A4E0", Offset = "0x30498E0", Length = "0x87")]
	[Token(Token = "0x600110E")]
	public static bool Approximately(float a, float b) { }

	[Address(RVA = "0x304A570", Offset = "0x3049970", Length = "0x57")]
	[Token(Token = "0x60010EF")]
	public static float Asin(float f) { }

	[Address(RVA = "0x304A640", Offset = "0x3049A40", Length = "0x57")]
	[Token(Token = "0x60010F1")]
	public static float Atan(float f) { }

	[Address(RVA = "0x304A5D0", Offset = "0x30499D0", Length = "0x6B")]
	[Token(Token = "0x60010F2")]
	public static float Atan2(float y, float x) { }

	[Address(RVA = "0x304A700", Offset = "0x3049B00", Length = "0x57")]
	[Token(Token = "0x6001100")]
	public static float Ceil(float f) { }

	[Address(RVA = "0x304A6A0", Offset = "0x3049AA0", Length = "0x57")]
	[Token(Token = "0x6001103")]
	public static int CeilToInt(float f) { }

	[Address(RVA = "0x304A840", Offset = "0x3049C40", Length = "0x12")]
	[Token(Token = "0x6001107")]
	public static float Clamp(float value, float min, float max) { }

	[Address(RVA = "0x304A820", Offset = "0x3049C20", Length = "0x13")]
	[Token(Token = "0x6001108")]
	public static int Clamp(int value, int min, int max) { }

	[Address(RVA = "0x304A760", Offset = "0x3049B60", Length = "0x1D")]
	[Token(Token = "0x6001109")]
	public static float Clamp01(float value) { }

	[Address(RVA = "0x304A780", Offset = "0x3049B80", Length = "0x5F")]
	[Token(Token = "0x6001114")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ClampToFloat(double value) { }

	[Address(RVA = "0x304A7E0", Offset = "0x3049BE0", Length = "0x1B")]
	[Token(Token = "0x6001115")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	internal static int ClampToInt(long value) { }

	[Address(RVA = "0x304A800", Offset = "0x3049C00", Length = "0x14")]
	[Token(Token = "0x6001116")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static uint ClampToUInt(long value) { }

	[Address(RVA = "0x304A8B0", Offset = "0x3049CB0", Length = "0x4C")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60010E7")]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[Address(RVA = "0x304A860", Offset = "0x3049C60", Length = "0x43")]
	[Token(Token = "0x600111D")]
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }

	[Address(RVA = "0x304A900", Offset = "0x3049D00", Length = "0x57")]
	[Token(Token = "0x60010ED")]
	public static float Cos(float f) { }

	[Address(RVA = "0x304A960", Offset = "0x3049D60", Length = "0x65")]
	[Token(Token = "0x6001113")]
	public static float DeltaAngle(float current, float target) { }

	[Address(RVA = "0x304A9D0", Offset = "0x3049DD0", Length = "0xD1")]
	[Token(Token = "0x6001119")]
	internal static double DiscardLeastSignificantDecimal(double v) { }

	[Address(RVA = "0x304AAB0", Offset = "0x3049EB0", Length = "0x57")]
	[Token(Token = "0x60010FC")]
	public static float Exp(float power) { }

	[Address(RVA = "0x304AB10", Offset = "0x3049F10", Length = "0x3A")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60010E8")]
	public static ushort FloatToHalf(float val) { }

	[Address(RVA = "0x304ABB0", Offset = "0x3049FB0", Length = "0x57")]
	[Token(Token = "0x6001101")]
	public static float Floor(float f) { }

	[Address(RVA = "0x304AB50", Offset = "0x3049F50", Length = "0x57")]
	[Token(Token = "0x6001104")]
	public static int FloorToInt(float f) { }

	[Address(RVA = "0x304AC10", Offset = "0x304A010", Length = "0x3A")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60010E5")]
	public static float GammaToLinearSpace(float value) { }

	[Address(RVA = "0x304AC50", Offset = "0x304A050", Length = "0x74")]
	[Token(Token = "0x6001117")]
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	[Address(RVA = "0x304ACD0", Offset = "0x304A0D0", Length = "0x33")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60010E9")]
	public static float HalfToFloat(ushort val) { }

	[Address(RVA = "0x304AD10", Offset = "0x304A110", Length = "0x34")]
	[Token(Token = "0x6001112")]
	public static float InverseLerp(float a, float b, float value) { }

	[Address(RVA = "0x304AD50", Offset = "0x304A150", Length = "0xB")]
	[Token(Token = "0x600111B")]
	public static bool IsPowerOfTwo(int value) { }

	[Address(RVA = "0x1DE88B0", Offset = "0x1DE7CB0", Length = "0x3B")]
	[Token(Token = "0x600110A")]
	public static float Lerp(float a, float b, float t) { }

	[Address(RVA = "0x1CFA430", Offset = "0x1CF9830", Length = "0xAE")]
	[Token(Token = "0x600110C")]
	public static float LerpAngle(float a, float b, float t) { }

	[Address(RVA = "0x304AD60", Offset = "0x304A160", Length = "0x12")]
	[Token(Token = "0x600110B")]
	public static float LerpUnclamped(float a, float b, float t) { }

	[Address(RVA = "0x304AD80", Offset = "0x304A180", Length = "0x3A")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60010E6")]
	public static float LinearToGammaSpace(float value) { }

	[Address(RVA = "0x304AE20", Offset = "0x304A220", Length = "0x6E")]
	[Token(Token = "0x60010FD")]
	public static float Log(float f, float p) { }

	[Address(RVA = "0x304AE90", Offset = "0x304A290", Length = "0x57")]
	[Token(Token = "0x60010FE")]
	public static float Log(float f) { }

	[Address(RVA = "0x304ADC0", Offset = "0x304A1C0", Length = "0x57")]
	[Token(Token = "0x60010FF")]
	public static float Log10(float f) { }

	[Address(RVA = "0x2DCFF20", Offset = "0x2DCF320", Length = "0xA")]
	[Token(Token = "0x60010FA")]
	public static int Max(int a, int b) { }

	[Address(RVA = "0x304AF70", Offset = "0x304A370", Length = "0x7")]
	[Token(Token = "0x60010F8")]
	public static float Max(float a, float b) { }

	[Address(RVA = "0x304AEF0", Offset = "0x304A2F0", Length = "0x72")]
	[Token(Token = "0x60010F9")]
	public static float Max(Single[] values) { }

	[Address(RVA = "0x304AF80", Offset = "0x304A380", Length = "0x7")]
	[Token(Token = "0x60010F6")]
	public static float Min(float a, float b) { }

	[Address(RVA = "0x7A92F0", Offset = "0x7A86F0", Length = "0xA")]
	[Token(Token = "0x60010F7")]
	public static int Min(int a, int b) { }

	[Address(RVA = "0x304AF90", Offset = "0x304A390", Length = "0x4F")]
	[Token(Token = "0x600110D")]
	public static float MoveTowards(float current, float target, float maxDelta) { }

	[Address(RVA = "0x304AFE0", Offset = "0x304A3E0", Length = "0x27")]
	[Token(Token = "0x600111A")]
	public static int NextPowerOfTwo(int value) { }

	[Address(RVA = "0x304B050", Offset = "0x304A450", Length = "0x4A")]
	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	[Token(Token = "0x60010EA")]
	public static float PerlinNoise(float x, float y) { }

	[Address(RVA = "0x304B010", Offset = "0x304A410", Length = "0x3A")]
	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	[Token(Token = "0x60010EB")]
	public static float PerlinNoise1D(float x) { }

	[Address(RVA = "0x1CC4A40", Offset = "0x1CC3E40", Length = "0x74")]
	[Token(Token = "0x6001111")]
	public static float PingPong(float t, float length) { }

	[Address(RVA = "0x304B0A0", Offset = "0x304A4A0", Length = "0x6E")]
	[Token(Token = "0x60010FB")]
	public static float Pow(float f, float p) { }

	[Address(RVA = "0x1CC4AC0", Offset = "0x1CC3EC0", Length = "0x56")]
	[Token(Token = "0x6001110")]
	public static float Repeat(float t, float length) { }

	[Address(RVA = "0x304B270", Offset = "0x304A670", Length = "0x57")]
	[Token(Token = "0x6001102")]
	public static float Round(float f) { }

	[Address(RVA = "0x304B110", Offset = "0x304A510", Length = "0xF7")]
	[Token(Token = "0x6001118")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	[Address(RVA = "0x304B210", Offset = "0x304A610", Length = "0x57")]
	[Token(Token = "0x6001105")]
	public static int RoundToInt(float f) { }

	[Address(RVA = "0x304B2D0", Offset = "0x304A6D0", Length = "0x1A")]
	[Token(Token = "0x6001106")]
	public static float Sign(float f) { }

	[Address(RVA = "0x304B2F0", Offset = "0x304A6F0", Length = "0x57")]
	[Token(Token = "0x60010EC")]
	public static float Sin(float f) { }

	[Address(RVA = "0x304B350", Offset = "0x304A750", Length = "0x160")]
	[Token(Token = "0x600110F")]
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[Address(RVA = "0x304B4B0", Offset = "0x304A8B0", Length = "0x75")]
	[Token(Token = "0x60010F3")]
	public static float Sqrt(float f) { }

	[Address(RVA = "0x304B530", Offset = "0x304A930", Length = "0x57")]
	[Token(Token = "0x60010EE")]
	public static float Tan(float f) { }

}

