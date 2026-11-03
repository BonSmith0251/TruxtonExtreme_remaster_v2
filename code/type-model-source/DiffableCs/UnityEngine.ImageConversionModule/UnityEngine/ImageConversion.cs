namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
[Token(Token = "0x2000002")]
public static class ImageConversion
{

	[Address(RVA = "0x30DC3B0", Offset = "0x30DB7B0", Length = "0x263")]
	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	[Token(Token = "0x6000001")]
	public static bool LoadImage(Texture2D tex, ReadOnlySpan<Byte> data, bool markNonReadable) { }

	[Address(RVA = "0x30DC260", Offset = "0x30DB660", Length = "0x14B")]
	[Extension]
	[Token(Token = "0x6000002")]
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

	[Address(RVA = "0x30DC200", Offset = "0x30DB600", Length = "0x54")]
	[Token(Token = "0x6000003")]
	private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable) { }

}

