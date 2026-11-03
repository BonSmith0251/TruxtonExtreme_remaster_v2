namespace Unity.Profiling;

[DebuggerDisplay("Value = {Value}; Count = {Count}")]
[Token(Token = "0x200002C")]
[UsedByNativeCode]
public struct ProfilerRecorderSample
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005E")]
	private long value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005F")]
	private long count; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000060")]
	private long refValue; //Field offset: 0x10

	[Token(Token = "0x1700000A")]
	public long Count
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000078")]
	public long get_Count() { }

}

