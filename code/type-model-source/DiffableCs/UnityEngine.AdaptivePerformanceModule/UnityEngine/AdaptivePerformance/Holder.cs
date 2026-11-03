namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000011")]
public static class Holder
{
	[Token(Token = "0x400005B")]
	private static IAdaptivePerformance m_Instance; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400005C")]
	private static LifecycleEventHandler LifecycleEventHandler; //Field offset: 0x8

	[Token(Token = "0x17000033")]
	public internal static IAdaptivePerformance Instance
	{
		[Address(RVA = "0x2F97940", Offset = "0x2F96D40", Length = "0x36")]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 54
		[Address(RVA = "0x2F97980", Offset = "0x2F96D80", Length = "0x91")]
		[Token(Token = "0x60000A4")]
		internal set { } //Length: 145
	}

	[Address(RVA = "0x2F97940", Offset = "0x2F96D40", Length = "0x36")]
	[Token(Token = "0x60000A3")]
	public static IAdaptivePerformance get_Instance() { }

	[Address(RVA = "0x2F97980", Offset = "0x2F96D80", Length = "0x91")]
	[Token(Token = "0x60000A4")]
	internal static void set_Instance(IAdaptivePerformance value) { }

}

