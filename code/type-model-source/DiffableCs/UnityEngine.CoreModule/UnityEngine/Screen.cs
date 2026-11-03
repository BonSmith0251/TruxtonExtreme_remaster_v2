namespace UnityEngine;

[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000D9")]
public sealed class Screen
{

	[Token(Token = "0x17000119")]
	public static Resolution currentResolution
	{
		[Address(RVA = "0x3013A90", Offset = "0x3012E90", Length = "0x3C")]
		[Token(Token = "0x6000638")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000117")]
	public static float dpi
	{
		[Address(RVA = "0x3013AD0", Offset = "0x3012ED0", Length = "0x2A")]
		[NativeName("GetDPI")]
		[Token(Token = "0x6000635")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700011A")]
	public static bool fullScreen
	{
		[Address(RVA = "0x3013B30", Offset = "0x3012F30", Length = "0x2A")]
		[NativeName("IsFullscreen")]
		[Token(Token = "0x6000639")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700011B")]
	public static FullScreenMode fullScreenMode
	{
		[Address(RVA = "0x3013B00", Offset = "0x3012F00", Length = "0x2A")]
		[NativeName("GetFullscreenMode")]
		[Token(Token = "0x600063A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000116")]
	public static int height
	{
		[Address(RVA = "0x3013B60", Offset = "0x3012F60", Length = "0x2A")]
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		[Token(Token = "0x6000634")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700011D")]
	public static int msaaSamples
	{
		[Address(RVA = "0x3013880", Offset = "0x3012C80", Length = "0x2A")]
		[Token(Token = "0x6000640")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000118")]
	public static ScreenOrientation orientation
	{
		[Address(RVA = "0x30138B0", Offset = "0x3012CB0", Length = "0x2A")]
		[Token(Token = "0x6000637")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700011C")]
	public static Rect safeArea
	{
		[Address(RVA = "0x3013BD0", Offset = "0x3012FD0", Length = "0x3C")]
		[Token(Token = "0x600063B")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000115")]
	public static int width
	{
		[Address(RVA = "0x3013C10", Offset = "0x3013010", Length = "0x2A")]
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		[Token(Token = "0x6000633")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3013A90", Offset = "0x3012E90", Length = "0x3C")]
	[Token(Token = "0x6000638")]
	public static Resolution get_currentResolution() { }

	[Address(RVA = "0x3013A50", Offset = "0x3012E50", Length = "0x33")]
	[Token(Token = "0x6000641")]
	private static void get_currentResolution_Injected(out Resolution ret) { }

	[Address(RVA = "0x3013AD0", Offset = "0x3012ED0", Length = "0x2A")]
	[NativeName("GetDPI")]
	[Token(Token = "0x6000635")]
	public static float get_dpi() { }

	[Address(RVA = "0x3013B30", Offset = "0x3012F30", Length = "0x2A")]
	[NativeName("IsFullscreen")]
	[Token(Token = "0x6000639")]
	public static bool get_fullScreen() { }

	[Address(RVA = "0x3013B00", Offset = "0x3012F00", Length = "0x2A")]
	[NativeName("GetFullscreenMode")]
	[Token(Token = "0x600063A")]
	public static FullScreenMode get_fullScreenMode() { }

	[Address(RVA = "0x3013B60", Offset = "0x3012F60", Length = "0x2A")]
	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	[Token(Token = "0x6000634")]
	public static int get_height() { }

	[Address(RVA = "0x3013880", Offset = "0x3012C80", Length = "0x2A")]
	[Token(Token = "0x6000640")]
	public static int get_msaaSamples() { }

	[Address(RVA = "0x30138B0", Offset = "0x3012CB0", Length = "0x2A")]
	[Token(Token = "0x6000637")]
	public static ScreenOrientation get_orientation() { }

	[Address(RVA = "0x3013BD0", Offset = "0x3012FD0", Length = "0x3C")]
	[Token(Token = "0x600063B")]
	public static Rect get_safeArea() { }

	[Address(RVA = "0x3013B90", Offset = "0x3012F90", Length = "0x33")]
	[Token(Token = "0x6000642")]
	private static void get_safeArea_Injected(out Rect ret) { }

	[Address(RVA = "0x3013C10", Offset = "0x3013010", Length = "0x2A")]
	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	[Token(Token = "0x6000633")]
	public static int get_width() { }

	[Address(RVA = "0x3013880", Offset = "0x3012C80", Length = "0x2A")]
	[NativeName("GetRequestedMSAASamples")]
	[Token(Token = "0x600063F")]
	private static int GetMSAASamples() { }

	[Address(RVA = "0x30138B0", Offset = "0x3012CB0", Length = "0x2A")]
	[Token(Token = "0x6000636")]
	private static ScreenOrientation GetScreenOrientation() { }

	[Address(RVA = "0x30138E0", Offset = "0x3012CE0", Length = "0x31")]
	[NativeName("SetRequestedMSAASamples")]
	[Token(Token = "0x600063E")]
	public static void SetMSAASamples(int numSamples) { }

	[Address(RVA = "0x3013980", Offset = "0x3012D80", Length = "0x58")]
	[NativeName("RequestResolution")]
	[Token(Token = "0x600063C")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[Address(RVA = "0x30139E0", Offset = "0x3012DE0", Length = "0x6D")]
	[Token(Token = "0x600063D")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[Address(RVA = "0x3013920", Offset = "0x3012D20", Length = "0x5E")]
	[Token(Token = "0x6000643")]
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

}

