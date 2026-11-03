namespace UnityEngine.Rendering;

[RequiredByNativeCode]
[Token(Token = "0x2000381")]
public class OnDemandRendering
{
	[Token(Token = "0x4000A81")]
	private static int m_RenderFrameInterval; //Field offset: 0x0

	[Token(Token = "0x170003DB")]
	public static int effectiveRenderFrameRate
	{
		[Address(RVA = "0x30B5E80", Offset = "0x30B5280", Length = "0x76")]
		[Token(Token = "0x6001A5A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170003DA")]
	public static int renderFrameInterval
	{
		[Address(RVA = "0x30B5F00", Offset = "0x30B5300", Length = "0x4D")]
		[Token(Token = "0x6001A57")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170003D9")]
	public static bool willCurrentFrameRender
	{
		[Address(RVA = "0x30B5F50", Offset = "0x30B5350", Length = "0x8F")]
		[Token(Token = "0x6001A56")]
		 get { } //Length: 143
	}

	[Address(RVA = "0x30B5E40", Offset = "0x30B5240", Length = "0x39")]
	[Token(Token = "0x6001A5B")]
	private static OnDemandRendering() { }

	[Address(RVA = "0x30B5E80", Offset = "0x30B5280", Length = "0x76")]
	[Token(Token = "0x6001A5A")]
	public static int get_effectiveRenderFrameRate() { }

	[Address(RVA = "0x30B5F00", Offset = "0x30B5300", Length = "0x4D")]
	[Token(Token = "0x6001A57")]
	public static int get_renderFrameInterval() { }

	[Address(RVA = "0x30B5F50", Offset = "0x30B5350", Length = "0x8F")]
	[Token(Token = "0x6001A56")]
	public static bool get_willCurrentFrameRender() { }

	[Address(RVA = "0x30B5D80", Offset = "0x30B5180", Length = "0x2A")]
	[FreeFunction]
	[Token(Token = "0x6001A59")]
	internal static float GetEffectiveRenderFrameRate() { }

	[Address(RVA = "0x30B5DB0", Offset = "0x30B51B0", Length = "0x83")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001A58")]
	internal static void GetRenderFrameInterval(out int frameInterval) { }

}

