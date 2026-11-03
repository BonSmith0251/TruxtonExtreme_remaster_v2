namespace UnityEngine.Rendering;

[Token(Token = "0x20001E1")]
public static class LightUnitUtils
{
	[Token(Token = "0x4000940")]
	public const float SphereSolidAngle = 12.566371; //Field offset: 0x0

	[Token(Token = "0x170001D8")]
	private static float k_EvToLuminanceFactor
	{
		[Address(RVA = "0x2C612E0", Offset = "0x2C606E0", Length = "0x17")]
		[Token(Token = "0x6000E66")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170001D7")]
	private static float k_LuminanceToEvFactor
	{
		[Address(RVA = "0x2C61300", Offset = "0x2C60700", Length = "0xA9")]
		[Token(Token = "0x6000E65")]
		private get { } //Length: 169
	}

	[Address(RVA = "0x2C60250", Offset = "0x2C5F650", Length = "0x7")]
	[Token(Token = "0x6000E7A")]
	public static float CandelaToEv100(float candela) { }

	[Address(RVA = "0x2A2CA60", Offset = "0x2A2BE60", Length = "0x5")]
	[Token(Token = "0x6000E72")]
	public static float CandelaToLumen(float candela, float solidAngle) { }

	[Address(RVA = "0x2C60260", Offset = "0x2C5F660", Length = "0x9")]
	[Token(Token = "0x6000E76")]
	public static float CandelaToLux(float candela, float distance) { }

	[Address(RVA = "0x2C60A70", Offset = "0x2C5FE70", Length = "0x1FE")]
	[Token(Token = "0x6000E7C")]
	public static float ConvertIntensity(Light light, float intensity, LightUnit fromUnit, LightUnit toUnit) { }

	[Address(RVA = "0x2C60270", Offset = "0x2C5F670", Length = "0x100")]
	[Token(Token = "0x6000E7B")]
	internal static float ConvertIntensityInternal(float intensity, LightUnit fromUnit, LightUnit toUnit, LightType lightType, float area, float luxAtDistance, float solidAngle) { }

	[Address(RVA = "0x2C60C70", Offset = "0x2C60070", Length = "0x37")]
	[Token(Token = "0x6000E79")]
	public static float Ev100ToCandela(float ev100) { }

	[Address(RVA = "0x2C60C70", Offset = "0x2C60070", Length = "0x37")]
	[Token(Token = "0x6000E77")]
	public static float Ev100ToNits(float ev100) { }

	[Address(RVA = "0x2C612E0", Offset = "0x2C606E0", Length = "0x17")]
	[Token(Token = "0x6000E66")]
	private static float get_k_EvToLuminanceFactor() { }

	[Address(RVA = "0x2C61300", Offset = "0x2C60700", Length = "0xA9")]
	[Token(Token = "0x6000E65")]
	private static float get_k_LuminanceToEvFactor() { }

	[Address(RVA = "0x2C60CB0", Offset = "0x2C600B0", Length = "0x15")]
	[Token(Token = "0x6000E6F")]
	public static float GetAreaFromDiscLight(float discRadius) { }

	[Address(RVA = "0x2C60CF0", Offset = "0x2C600F0", Length = "0x21")]
	[Token(Token = "0x6000E6E")]
	public static float GetAreaFromRectangleLight(Vector2 rectSize) { }

	[Address(RVA = "0x2C60CD0", Offset = "0x2C600D0", Length = "0x14")]
	[Token(Token = "0x6000E6D")]
	public static float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY) { }

	[Address(RVA = "0x2C60D20", Offset = "0x2C60120", Length = "0x18")]
	[Token(Token = "0x6000E70")]
	public static float GetAreaFromTubeLight(float tubeLength) { }

	[Address(RVA = "0x2C60D40", Offset = "0x2C60140", Length = "0x80")]
	[Token(Token = "0x6000E67")]
	public static LightUnit GetNativeLightUnit(LightType lightType) { }

	[Address(RVA = "0x2C60F80", Offset = "0x2C60380", Length = "0x25D")]
	[Token(Token = "0x6000E6C")]
	internal static float GetSolidAngle(LightType lightType, bool spotReflector, float spotAngle, float aspectRatio) { }

	[Address(RVA = "0x2C60DE0", Offset = "0x2C601E0", Length = "0x9")]
	[Token(Token = "0x6000E69")]
	public static float GetSolidAngleFromPointLight() { }

	[Address(RVA = "0x2C60DF0", Offset = "0x2C601F0", Length = "0xF7")]
	[Token(Token = "0x6000E6B")]
	public static float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio) { }

	[Address(RVA = "0x2C60EF0", Offset = "0x2C602F0", Length = "0x83")]
	[Token(Token = "0x6000E6A")]
	public static float GetSolidAngleFromSpotLight(float spotAngle) { }

	[Address(RVA = "0x2C611E0", Offset = "0x2C605E0", Length = "0x48")]
	[Token(Token = "0x6000E68")]
	public static bool IsLightUnitSupported(LightType lightType, LightUnit lightUnit) { }

	[Address(RVA = "0x2C61250", Offset = "0x2C60650", Length = "0x5")]
	[Token(Token = "0x6000E71")]
	public static float LumenToCandela(float lumen, float solidAngle) { }

	[Address(RVA = "0x2C61250", Offset = "0x2C60650", Length = "0x5")]
	[Token(Token = "0x6000E73")]
	public static float LumenToNits(float lumen, float area) { }

	[Address(RVA = "0x2C61260", Offset = "0x2C60660", Length = "0xC")]
	[Token(Token = "0x6000E75")]
	public static float LuxToCandela(float lux, float distance) { }

	[Address(RVA = "0x2C61270", Offset = "0x2C60670", Length = "0x70")]
	[Token(Token = "0x6000E78")]
	public static float NitsToEv100(float nits) { }

	[Address(RVA = "0x2A2CA60", Offset = "0x2A2BE60", Length = "0x5")]
	[Token(Token = "0x6000E74")]
	public static float NitsToLumen(float nits, float area) { }

}

