namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with .NET")]
[Token(Token = "0x200058E")]
public class StackTrace
{
	[Token(Token = "0x200058F")]
	public enum TraceFormat : int
	{
		Normal = 0,
		TrailingNewLine = 1,
		NoResourceLookup = 2,
	}

	[Token(Token = "0x4001771")]
	private static bool isAotidSet; //Field offset: 0x0
	[Token(Token = "0x4001772")]
	private static string aotid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400176E")]
	private StackFrame[] frames; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400176F")]
	private readonly StackTrace[] captured_traces; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001770")]
	private bool debug_info; //Field offset: 0x20

	[Token(Token = "0x17000603")]
	public override int FrameCount
	{
		[Address(RVA = "0x1FD00A0", Offset = "0x1FCF4A0", Length = "0x12")]
		[Token(Token = "0x6002906")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x1FD0070", Offset = "0x1FCF470", Length = "0x25")]
	[Token(Token = "0x60028FF")]
	public StackTrace() { }

	[Address(RVA = "0x1FCFE20", Offset = "0x1FCF220", Length = "0x32")]
	[Token(Token = "0x6002900")]
	public StackTrace(bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCFF80", Offset = "0x1FCF380", Length = "0x3F")]
	[Token(Token = "0x6002901")]
	public StackTrace(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCFFC0", Offset = "0x1FCF3C0", Length = "0xAB")]
	[Token(Token = "0x6002904")]
	public StackTrace(Exception e, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCFE60", Offset = "0x1FCF260", Length = "0x11B")]
	[Token(Token = "0x6002905")]
	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCEC60", Offset = "0x1FCE060", Length = "0x507")]
	[Token(Token = "0x6002909")]
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	[Address(RVA = "0x1FCF170", Offset = "0x1FCE570", Length = "0x2D8")]
	[Token(Token = "0x600290B")]
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	[Address(RVA = "0x1FD00A0", Offset = "0x1FCF4A0", Length = "0x12")]
	[Token(Token = "0x6002906")]
	public override int get_FrameCount() { }

	[Address(RVA = "0x1FD00C0", Offset = "0x1FCF4C0", Length = "0x5")]
	[Token(Token = "0x6002903")]
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCF450", Offset = "0x1FCE850", Length = "0xE2")]
	[Token(Token = "0x6002908")]
	private static string GetAotId() { }

	[Address(RVA = "0x1FCF540", Offset = "0x1FCE940", Length = "0x61")]
	[Token(Token = "0x6002907")]
	public override StackFrame GetFrame(int index) { }

	[Address(RVA = "0x1FCF5B0", Offset = "0x1FCE9B0", Length = "0x6C1")]
	[Token(Token = "0x600290A")]
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	[Address(RVA = "0x1FD00D0", Offset = "0x1FCF4D0", Length = "0x233")]
	[Token(Token = "0x6002902")]
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x1FCFC80", Offset = "0x1FCF080", Length = "0x176")]
	[Token(Token = "0x600290C")]
	public virtual string ToString() { }

	[Address(RVA = "0x1FCFE00", Offset = "0x1FCF200", Length = "0x14")]
	[Token(Token = "0x600290D")]
	internal string ToString(TraceFormat traceFormat) { }

}

