namespace Unity.Profiling;

[Token(Token = "0x2000029")]
public enum ProfilerMarkerDataUnit : byte
{
	Undefined = 0,
	TimeNanoseconds = 1,
	Bytes = 2,
	Count = 3,
	Percent = 4,
	FrequencyHz = 5,
}

