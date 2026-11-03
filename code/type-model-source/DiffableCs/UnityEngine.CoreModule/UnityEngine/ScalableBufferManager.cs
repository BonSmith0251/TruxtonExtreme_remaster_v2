namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000DE")]
public static class ScalableBufferManager
{

	[Token(Token = "0x17000124")]
	public static float heightScaleFactor
	{
		[Address(RVA = "0x3013820", Offset = "0x3012C20", Length = "0x2A")]
		[Token(Token = "0x6000684")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000123")]
	public static float widthScaleFactor
	{
		[Address(RVA = "0x3013850", Offset = "0x3012C50", Length = "0x2A")]
		[Token(Token = "0x6000683")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3013820", Offset = "0x3012C20", Length = "0x2A")]
	[Token(Token = "0x6000684")]
	public static float get_heightScaleFactor() { }

	[Address(RVA = "0x3013850", Offset = "0x3012C50", Length = "0x2A")]
	[Token(Token = "0x6000683")]
	public static float get_widthScaleFactor() { }

	[Address(RVA = "0x30137D0", Offset = "0x3012BD0", Length = "0x4A")]
	[Token(Token = "0x6000685")]
	public static void ResizeBuffers(float widthScale, float heightScale) { }

}

