namespace Unity.Profiling;

[Flags]
[Token(Token = "0x200002A")]
public enum ProfilerCounterOptions : ushort
{
	None = 0,
	FlushOnEndOfFrame = 2,
	ResetToZeroOnFlush = 4,
}

