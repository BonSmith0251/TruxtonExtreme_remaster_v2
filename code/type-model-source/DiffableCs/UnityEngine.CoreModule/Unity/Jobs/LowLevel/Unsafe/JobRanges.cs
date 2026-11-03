namespace Unity.Jobs.LowLevel.Unsafe;

[Token(Token = "0x200001A")]
public struct JobRanges
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000010")]
	internal int BatchSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000011")]
	internal int NumJobs; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000012")]
	public int TotalIterationCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	internal IntPtr StartEndIndex; //Field offset: 0x10

}

