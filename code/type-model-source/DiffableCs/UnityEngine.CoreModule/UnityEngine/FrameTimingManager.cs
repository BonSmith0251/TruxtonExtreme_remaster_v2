namespace UnityEngine;

[StaticAccessor("GetUncheckedRealGfxDevice().GetFrameTimingManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000E0")]
public static class FrameTimingManager
{

	[Address(RVA = "0x2FF26B0", Offset = "0x2FF1AB0", Length = "0x2A")]
	[Token(Token = "0x6000686")]
	public static void CaptureFrameTimings() { }

	[Address(RVA = "0x2FF2720", Offset = "0x2FF1B20", Length = "0xC9")]
	[Token(Token = "0x6000687")]
	public static uint GetLatestTimings(uint numFrames, FrameTiming[] timings) { }

	[Address(RVA = "0x2FF26E0", Offset = "0x2FF1AE0", Length = "0x40")]
	[Token(Token = "0x6000688")]
	private static uint GetLatestTimings_Injected(uint numFrames, ref ManagedSpanWrapper timings) { }

}

