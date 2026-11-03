namespace UnityEngine;

[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000B")]
public static class UISystemProfilerApi
{
	[Token(Token = "0x200000C")]
	internal enum SampleType : int
	{
		Layout = 0,
		Render = 1,
	}


	[Address(RVA = "0x34338E0", Offset = "0x3432CE0", Length = "0x1B4")]
	[Token(Token = "0x60000EA")]
	public static void AddMarker(string name, object obj) { }

	[Address(RVA = "0x3433890", Offset = "0x3432C90", Length = "0x42")]
	[Token(Token = "0x60000EB")]
	private static void AddMarker_Injected(ref ManagedSpanWrapper name, IntPtr obj) { }

	[Address(RVA = "0x3433AA0", Offset = "0x3432EA0", Length = "0x31")]
	[Token(Token = "0x60000E8")]
	public static void BeginSample(SampleType type) { }

	[Address(RVA = "0x3433AE0", Offset = "0x3432EE0", Length = "0x31")]
	[Token(Token = "0x60000E9")]
	public static void EndSample(SampleType type) { }

}

