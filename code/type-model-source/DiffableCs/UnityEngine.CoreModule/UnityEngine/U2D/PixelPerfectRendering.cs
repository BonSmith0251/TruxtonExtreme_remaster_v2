namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/PixelSnapping.h")]
[Token(Token = "0x200043A")]
public static class PixelPerfectRendering
{

	[Token(Token = "0x170004AB")]
	public static float pixelSnapSpacing
	{
		[Address(RVA = "0x30C3110", Offset = "0x30C2510", Length = "0x3A")]
		[FreeFunction("SetPixelSnapSpacing")]
		[Token(Token = "0x6001F9F")]
		 set { } //Length: 58
	}

	[Address(RVA = "0x30C3110", Offset = "0x30C2510", Length = "0x3A")]
	[FreeFunction("SetPixelSnapSpacing")]
	[Token(Token = "0x6001F9F")]
	public static void set_pixelSnapSpacing(float value) { }

}

