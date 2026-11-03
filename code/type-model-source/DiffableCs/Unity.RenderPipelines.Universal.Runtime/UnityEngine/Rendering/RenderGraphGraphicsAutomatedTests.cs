namespace UnityEngine.Rendering;

[Token(Token = "0x200000E")]
public static class RenderGraphGraphicsAutomatedTests
{
	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000043")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000044")]
		public static Predicate<String> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x2D64E10", Offset = "0x2D64210", Length = "0x67")]
		[Token(Token = "0x600002E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600002F")]
		public <>c() { }

		[Address(RVA = "0x2D61D00", Offset = "0x2D61100", Length = "0x3C")]
		[Token(Token = "0x6000030")]
		internal bool <get_activatedFromCommandLine>b__1_0(string arg) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000041")]
	private static bool <enabled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000042")]
	private static Nullable<Boolean> <forceRenderGraphState>k__BackingField; //Field offset: 0x1

	[Token(Token = "0x17000001")]
	private static bool activatedFromCommandLine
	{
		[Address(RVA = "0x2D5DD10", Offset = "0x2D5D110", Length = "0x11A")]
		[Token(Token = "0x6000028")]
		private get { } //Length: 282
	}

	[Obsolete]
	[Token(Token = "0x17000002")]
	public static bool enabled
	{
		[Address(RVA = "0x2D5DE30", Offset = "0x2D5D230", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		 get { } //Length: 78
		[Address(RVA = "0x2D5DED0", Offset = "0x2D5D2D0", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x600002A")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000003")]
	public static Nullable<Boolean> forceRenderGraphState
	{
		[Address(RVA = "0x2D5DE80", Offset = "0x2D5D280", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		 get { } //Length: 79
		[Address(RVA = "0x2D5DF30", Offset = "0x2D5D330", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600002C")]
		 set { } //Length: 85
	}

	[Address(RVA = "0x2D5DC70", Offset = "0x2D5D070", Length = "0x9B")]
	[Token(Token = "0x600002D")]
	private static RenderGraphGraphicsAutomatedTests() { }

	[Address(RVA = "0x2D5DD10", Offset = "0x2D5D110", Length = "0x11A")]
	[Token(Token = "0x6000028")]
	private static bool get_activatedFromCommandLine() { }

	[Address(RVA = "0x2D5DE30", Offset = "0x2D5D230", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	public static bool get_enabled() { }

	[Address(RVA = "0x2D5DE80", Offset = "0x2D5D280", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600002B")]
	public static Nullable<Boolean> get_forceRenderGraphState() { }

	[Address(RVA = "0x2D5DED0", Offset = "0x2D5D2D0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x600002A")]
	public static void set_enabled(bool value) { }

	[Address(RVA = "0x2D5DF30", Offset = "0x2D5D330", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600002C")]
	public static void set_forceRenderGraphState(Nullable<Boolean> value) { }

}

