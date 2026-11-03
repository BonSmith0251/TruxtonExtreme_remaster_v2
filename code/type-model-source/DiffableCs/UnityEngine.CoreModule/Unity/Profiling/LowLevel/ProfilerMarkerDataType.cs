namespace Unity.Profiling.LowLevel;

[Token(Token = "0x2000033")]
public enum ProfilerMarkerDataType : byte
{
	InstanceId = 1,
	Int32 = 2,
	UInt32 = 3,
	Int64 = 4,
	UInt64 = 5,
	Float = 6,
	Double = 7,
	String16 = 9,
	Blob8 = 11,
	GfxResourceId = 12,
}

