namespace Unity.Profiling;

[Flags]
[Token(Token = "0x200002B")]
public enum ProfilerRecorderOptions : int
{
	None = 0,
	StartImmediately = 1,
	KeepAliveDuringDomainReload = 2,
	CollectOnlyOnCurrentThread = 4,
	WrapAroundWhenCapacityReached = 8,
	SumAllSamplesInFrame = 16,
	GpuRecorder = 64,
	Default = 24,
}

