namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000ED")]
public sealed class RenderSettings : object
{

	[Token(Token = "0x1700016B")]
	public static Color ambientEquatorColor
	{
		[Address(RVA = "0x3011990", Offset = "0x3010D90", Length = "0x3C")]
		[Token(Token = "0x60007AE")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700016C")]
	public static Color ambientGroundColor
	{
		[Address(RVA = "0x3011A10", Offset = "0x3010E10", Length = "0x3C")]
		[Token(Token = "0x60007AF")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700016D")]
	public static float ambientIntensity
	{
		[Address(RVA = "0x3011D70", Offset = "0x3011170", Length = "0x3A")]
		[Token(Token = "0x60007B0")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000169")]
	public static AmbientMode ambientMode
	{
		[Address(RVA = "0x3011DB0", Offset = "0x30111B0", Length = "0x31")]
		[Token(Token = "0x60007AC")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000171")]
	public static SphericalHarmonicsL2 ambientProbe
	{
		[Address(RVA = "0x3011A90", Offset = "0x3010E90", Length = "0x59")]
		[NativeMethod("GetFinalAmbientProbe")]
		[Token(Token = "0x60007B6")]
		 get { } //Length: 89
	}

	[Token(Token = "0x1700016A")]
	public static Color ambientSkyColor
	{
		[Address(RVA = "0x3011B30", Offset = "0x3010F30", Length = "0x3C")]
		[Token(Token = "0x60007AD")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000174")]
	public static DefaultReflectionMode defaultReflectionMode
	{
		[Address(RVA = "0x3011DF0", Offset = "0x30111F0", Length = "0x31")]
		[Token(Token = "0x60007BA")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000175")]
	public static int defaultReflectionResolution
	{
		[Address(RVA = "0x3011E30", Offset = "0x3011230", Length = "0x31")]
		[Token(Token = "0x60007BB")]
		 set { } //Length: 49
	}

	[NativeProperty("UseFog")]
	[Token(Token = "0x17000164")]
	public static bool fog
	{
		[Address(RVA = "0x3011B70", Offset = "0x3010F70", Length = "0x2A")]
		[Token(Token = "0x60007A6")]
		 get { } //Length: 42
		[Address(RVA = "0x3011FB0", Offset = "0x30113B0", Length = "0x33")]
		[Token(Token = "0x60007A7")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000168")]
	public static Color fogColor
	{
		[Address(RVA = "0x3011EB0", Offset = "0x30112B0", Length = "0x33")]
		[Token(Token = "0x60007AB")]
		 set { } //Length: 51
	}

	[NativeProperty("LinearFogEnd")]
	[Token(Token = "0x17000166")]
	public static float fogEndDistance
	{
		[Address(RVA = "0x3011EF0", Offset = "0x30112F0", Length = "0x3A")]
		[Token(Token = "0x60007A9")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000167")]
	public static FogMode fogMode
	{
		[Address(RVA = "0x3011F30", Offset = "0x3011330", Length = "0x31")]
		[Token(Token = "0x60007AA")]
		 set { } //Length: 49
	}

	[NativeProperty("LinearFogStart")]
	[Token(Token = "0x17000165")]
	public static float fogStartDistance
	{
		[Address(RVA = "0x3011F70", Offset = "0x3011370", Length = "0x3A")]
		[Token(Token = "0x60007A8")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000173")]
	public static int reflectionBounces
	{
		[Address(RVA = "0x3011FF0", Offset = "0x30113F0", Length = "0x31")]
		[Token(Token = "0x60007B9")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000172")]
	public static float reflectionIntensity
	{
		[Address(RVA = "0x3011BA0", Offset = "0x3010FA0", Length = "0x2A")]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 42
		[Address(RVA = "0x3012030", Offset = "0x3011430", Length = "0x3A")]
		[Token(Token = "0x60007B8")]
		 set { } //Length: 58
	}

	[NativeProperty("SkyboxMaterial")]
	[Token(Token = "0x1700016F")]
	public static Material skybox
	{
		[Address(RVA = "0x3011C00", Offset = "0x3011000", Length = "0x54")]
		[Token(Token = "0x60007B3")]
		 get { } //Length: 84
		[Address(RVA = "0x30120B0", Offset = "0x30114B0", Length = "0x6B")]
		[Token(Token = "0x60007B4")]
		 set { } //Length: 107
	}

	[Token(Token = "0x1700016E")]
	public static Color subtractiveShadowColor
	{
		[Address(RVA = "0x3011CA0", Offset = "0x30110A0", Length = "0x3C")]
		[Token(Token = "0x60007B1")]
		 get { } //Length: 60
		[Address(RVA = "0x3012160", Offset = "0x3011560", Length = "0x33")]
		[Token(Token = "0x60007B2")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000170")]
	public static Light sun
	{
		[Address(RVA = "0x3011D10", Offset = "0x3011110", Length = "0x54")]
		[Token(Token = "0x60007B5")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x3011990", Offset = "0x3010D90", Length = "0x3C")]
	[Token(Token = "0x60007AE")]
	public static Color get_ambientEquatorColor() { }

	[Address(RVA = "0x3011950", Offset = "0x3010D50", Length = "0x33")]
	[Token(Token = "0x60007BE")]
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	[Address(RVA = "0x3011A10", Offset = "0x3010E10", Length = "0x3C")]
	[Token(Token = "0x60007AF")]
	public static Color get_ambientGroundColor() { }

	[Address(RVA = "0x30119D0", Offset = "0x3010DD0", Length = "0x33")]
	[Token(Token = "0x60007BF")]
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	[Address(RVA = "0x3011A90", Offset = "0x3010E90", Length = "0x59")]
	[NativeMethod("GetFinalAmbientProbe")]
	[Token(Token = "0x60007B6")]
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	[Address(RVA = "0x3011A50", Offset = "0x3010E50", Length = "0x33")]
	[Token(Token = "0x60007C5")]
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	[Address(RVA = "0x3011B30", Offset = "0x3010F30", Length = "0x3C")]
	[Token(Token = "0x60007AD")]
	public static Color get_ambientSkyColor() { }

	[Address(RVA = "0x3011AF0", Offset = "0x3010EF0", Length = "0x33")]
	[Token(Token = "0x60007BD")]
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	[Address(RVA = "0x3011B70", Offset = "0x3010F70", Length = "0x2A")]
	[Token(Token = "0x60007A6")]
	public static bool get_fog() { }

	[Address(RVA = "0x3011BA0", Offset = "0x3010FA0", Length = "0x2A")]
	[Token(Token = "0x60007B7")]
	public static float get_reflectionIntensity() { }

	[Address(RVA = "0x3011C00", Offset = "0x3011000", Length = "0x54")]
	[Token(Token = "0x60007B3")]
	public static Material get_skybox() { }

	[Address(RVA = "0x3011BD0", Offset = "0x3010FD0", Length = "0x2A")]
	[Token(Token = "0x60007C2")]
	private static IntPtr get_skybox_Injected() { }

	[Address(RVA = "0x3011CA0", Offset = "0x30110A0", Length = "0x3C")]
	[Token(Token = "0x60007B1")]
	public static Color get_subtractiveShadowColor() { }

	[Address(RVA = "0x3011C60", Offset = "0x3011060", Length = "0x33")]
	[Token(Token = "0x60007C0")]
	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	[Address(RVA = "0x3011D10", Offset = "0x3011110", Length = "0x54")]
	[Token(Token = "0x60007B5")]
	public static Light get_sun() { }

	[Address(RVA = "0x3011CE0", Offset = "0x30110E0", Length = "0x2A")]
	[Token(Token = "0x60007C4")]
	private static IntPtr get_sun_Injected() { }

	[Address(RVA = "0x3011D70", Offset = "0x3011170", Length = "0x3A")]
	[Token(Token = "0x60007B0")]
	public static void set_ambientIntensity(float value) { }

	[Address(RVA = "0x3011DB0", Offset = "0x30111B0", Length = "0x31")]
	[Token(Token = "0x60007AC")]
	public static void set_ambientMode(AmbientMode value) { }

	[Address(RVA = "0x3011DF0", Offset = "0x30111F0", Length = "0x31")]
	[Token(Token = "0x60007BA")]
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	[Address(RVA = "0x3011E30", Offset = "0x3011230", Length = "0x31")]
	[Token(Token = "0x60007BB")]
	public static void set_defaultReflectionResolution(int value) { }

	[Address(RVA = "0x3011FB0", Offset = "0x30113B0", Length = "0x33")]
	[Token(Token = "0x60007A7")]
	public static void set_fog(bool value) { }

	[Address(RVA = "0x3011EB0", Offset = "0x30112B0", Length = "0x33")]
	[Token(Token = "0x60007AB")]
	public static void set_fogColor(Color value) { }

	[Address(RVA = "0x3011E70", Offset = "0x3011270", Length = "0x33")]
	[Token(Token = "0x60007BC")]
	private static void set_fogColor_Injected(in Color value) { }

	[Address(RVA = "0x3011EF0", Offset = "0x30112F0", Length = "0x3A")]
	[Token(Token = "0x60007A9")]
	public static void set_fogEndDistance(float value) { }

	[Address(RVA = "0x3011F30", Offset = "0x3011330", Length = "0x31")]
	[Token(Token = "0x60007AA")]
	public static void set_fogMode(FogMode value) { }

	[Address(RVA = "0x3011F70", Offset = "0x3011370", Length = "0x3A")]
	[Token(Token = "0x60007A8")]
	public static void set_fogStartDistance(float value) { }

	[Address(RVA = "0x3011FF0", Offset = "0x30113F0", Length = "0x31")]
	[Token(Token = "0x60007B9")]
	public static void set_reflectionBounces(int value) { }

	[Address(RVA = "0x3012030", Offset = "0x3011430", Length = "0x3A")]
	[Token(Token = "0x60007B8")]
	public static void set_reflectionIntensity(float value) { }

	[Address(RVA = "0x30120B0", Offset = "0x30114B0", Length = "0x6B")]
	[Token(Token = "0x60007B4")]
	public static void set_skybox(Material value) { }

	[Address(RVA = "0x3012070", Offset = "0x3011470", Length = "0x33")]
	[Token(Token = "0x60007C3")]
	private static void set_skybox_Injected(IntPtr value) { }

	[Address(RVA = "0x3012160", Offset = "0x3011560", Length = "0x33")]
	[Token(Token = "0x60007B2")]
	public static void set_subtractiveShadowColor(Color value) { }

	[Address(RVA = "0x3012120", Offset = "0x3011520", Length = "0x33")]
	[Token(Token = "0x60007C1")]
	private static void set_subtractiveShadowColor_Injected(in Color value) { }

}

