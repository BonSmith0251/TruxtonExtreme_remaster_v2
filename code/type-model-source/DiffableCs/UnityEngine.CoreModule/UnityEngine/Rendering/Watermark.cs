namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/DrawSplashScreenAndWatermarks.h")]
[Token(Token = "0x2000395")]
public class Watermark
{

	[Address(RVA = "0x30B9220", Offset = "0x30B8620", Length = "0x10B")]
	[FreeFunction("IsAnyWatermarkVisible")]
	[Token(Token = "0x6001CCF")]
	public static bool IsVisible() { }

}

