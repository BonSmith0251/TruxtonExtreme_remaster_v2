namespace Unity.Profiling;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ProfilerRecorderDebugView))]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
[Token(Token = "0x200002D")]
[UsedByNativeCode]
public struct ProfilerRecorder : IDisposable
{
	[Token(Token = "0x200002E")]
	public enum ControlOptions : int
	{
		Start = 0,
		Stop = 1,
		Reset = 2,
		Release = 4,
		SetFilterToCurrentThread = 5,
		SetToCollectFromAllThreads = 6,
	}

	[Token(Token = "0x200002F")]
	public enum CountOptions : int
	{
		Count = 0,
		MaxCount = 1,
	}

	[Token(Token = "0x4000062")]
	internal const ProfilerRecorderOptions SharedRecorder = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	internal ulong handle; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	public int Count
	{
		[Address(RVA = "0x2FE48F0", Offset = "0x2FE3CF0", Length = "0x91")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 145
	}

	[Token(Token = "0x1700000E")]
	public bool IsRunning
	{
		[Address(RVA = "0x2FE4990", Offset = "0x2FE3D90", Length = "0x8F")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700000C")]
	public long LastValue
	{
		[Address(RVA = "0x2FE4A20", Offset = "0x2FE3E20", Length = "0x8F")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700000B")]
	public bool Valid
	{
		[Address(RVA = "0x2FE4AB0", Offset = "0x2FE3EB0", Length = "0x51")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x2FE4880", Offset = "0x2FE3C80", Length = "0x6E")]
	[Token(Token = "0x6000079")]
	public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	[Address(RVA = "0x2FE41C0", Offset = "0x2FE35C0", Length = "0x61")]
	[BurstDiscard]
	[Token(Token = "0x6000089")]
	private void CheckInitializedAndThrow() { }

	[Address(RVA = "0x2FE4270", Offset = "0x2FE3670", Length = "0x3A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000082")]
	private static void Control(ProfilerRecorder handle, ControlOptions options) { }

	[Address(RVA = "0x2FE4230", Offset = "0x2FE3630", Length = "0x40")]
	[Token(Token = "0x600008B")]
	private static void Control_Injected(in ProfilerRecorder handle, ControlOptions options) { }

	[Address(RVA = "0x2FE4310", Offset = "0x2FE3710", Length = "0x5D")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000081")]
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) { }

	[Address(RVA = "0x2FE42B0", Offset = "0x2FE36B0", Length = "0x60")]
	[Token(Token = "0x600008A")]
	private static void Create_Injected(in ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) { }

	[Address(RVA = "0x2FE4370", Offset = "0x2FE3770", Length = "0x4F")]
	[Token(Token = "0x6000088")]
	public override void Dispose() { }

	[Address(RVA = "0x2FE48F0", Offset = "0x2FE3CF0", Length = "0x91")]
	[Token(Token = "0x600007E")]
	public int get_Count() { }

	[Address(RVA = "0x2FE4990", Offset = "0x2FE3D90", Length = "0x8F")]
	[Token(Token = "0x600007F")]
	public bool get_IsRunning() { }

	[Address(RVA = "0x2FE4A20", Offset = "0x2FE3E20", Length = "0x8F")]
	[Token(Token = "0x600007D")]
	public long get_LastValue() { }

	[Address(RVA = "0x2FE4AB0", Offset = "0x2FE3EB0", Length = "0x51")]
	[Token(Token = "0x600007A")]
	public bool get_Valid() { }

	[Address(RVA = "0x2FE4400", Offset = "0x2FE3800", Length = "0x3A")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000084")]
	private static int GetCount(ProfilerRecorder handle, CountOptions countOptions) { }

	[Address(RVA = "0x2FE43C0", Offset = "0x2FE37C0", Length = "0x40")]
	[Token(Token = "0x600008D")]
	private static int GetCount_Injected(in ProfilerRecorder handle, CountOptions countOptions) { }

	[Address(RVA = "0x2FE4480", Offset = "0x2FE3880", Length = "0x34")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000083")]
	private static long GetLastValue(ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE4440", Offset = "0x2FE3840", Length = "0x33")]
	[Token(Token = "0x600008C")]
	private static long GetLastValue_Injected(in ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE4500", Offset = "0x2FE3900", Length = "0x34")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000086")]
	private static bool GetRunning(ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE44C0", Offset = "0x2FE38C0", Length = "0x33")]
	[Token(Token = "0x600008F")]
	private static bool GetRunning_Injected(in ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE45F0", Offset = "0x2FE39F0", Length = "0xCB")]
	[Token(Token = "0x6000080")]
	public ProfilerRecorderSample GetSample(int index) { }

	[Address(RVA = "0x2FE4590", Offset = "0x2FE3990", Length = "0x5A")]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000087")]
	private static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index) { }

	[Address(RVA = "0x2FE4540", Offset = "0x2FE3940", Length = "0x50")]
	[Token(Token = "0x6000090")]
	private static void GetSampleInternal_Injected(in ProfilerRecorder handle, int index, out ProfilerRecorderSample ret) { }

	[Address(RVA = "0x2FE4700", Offset = "0x2FE3B00", Length = "0x34")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000085")]
	private static bool GetValid(ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE46C0", Offset = "0x2FE3AC0", Length = "0x33")]
	[Token(Token = "0x600008E")]
	private static bool GetValid_Injected(in ProfilerRecorder handle) { }

	[Address(RVA = "0x2FE4740", Offset = "0x2FE3B40", Length = "0x91")]
	[Token(Token = "0x600007B")]
	public void Start() { }

	[Address(RVA = "0x2FE47E0", Offset = "0x2FE3BE0", Length = "0x94")]
	[Token(Token = "0x600007C")]
	public void Stop() { }

}

